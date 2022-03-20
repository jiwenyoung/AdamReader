Imports Microsoft.Data.Sqlite

Public Class Database
  Dim commander As SqliteCommand
  Dim connection As SqliteConnection
  Dim find As String
  Dim isQueryChoiceExected As Boolean = False
  Dim isQueryFromExected As Boolean = False
  Dim databaseFile As String

  Sub New()
    databaseFile = Settings.databaseFileName
  End Sub

  Private Sub initDataBase()
    Dim sql As String

    ' Create Table
    Dim Create = Function(tableName As String, fields As List(Of String)) As Boolean
                   sql = "CREATE TABLE IF NOT EXISTS "
                   sql += tableName
                   sql += " ( "
                   For Each field As String In fields
                     sql += String.Format("{0},", field)
                   Next
                   sql = sql.Remove(sql.Length - 1, 1)
                   sql += " ) "
                   commander.CommandText = sql
                   commander.ExecuteNonQuery()
                   Return True
                 End Function

    Dim CreateIndex = Function(tableName As String, field As String, indexName As String) As Boolean
                        sql = String.Format(
                          "CREATE UNIQUE INDEX IF NOT EXISTS {0} ON {1}({2})",
                          indexName, tableName, field
                         )
                        commander.CommandText = sql
                        commander.ExecuteNonQuery()
                        Return True
                      End Function

    ' Create Tables Transcation
    Dim fileds As List(Of String) = New List(Of String)

    ' Create Table Books
    fileds.Clear()
    fileds.Add("BookName TEXT NOT NULL")
    fileds.Add("BookMark TEXT NOT NULL")
    Create("Books", fileds)

    ' Create Table Words
    fileds.Clear()
    fileds.Add("Word TEXT NOT NULL UNIQUE")
    fileds.Add("Chiniese TEXT")
    Create("Words", fileds)

    'Create Index of Table Words
    CreateIndex("Words", "Word", "WordIndex")
  End Sub

  Public Function Conntect() As Database
    Dim connectBuilder As SqliteConnectionStringBuilder = New SqliteConnectionStringBuilder()
    connectBuilder.DataSource = databaseFile
    Dim connectString As String = connectBuilder.ToString()

    connection = New SqliteConnection(connectString)
    connection.Open()
    commander = connection.CreateCommand()

    initDataBase()
    Return Me
  End Function

  Public Async Function Count(tableName As String, field As String, Optional value As String = "") As Task(Of Integer)
    Dim sql As String
    If value = "" Then
      sql = String.Format("SELECT COUNT({1}) FROM {0}", tableName, field)
    Else
      sql = String.Format("SELECT COUNT({1}) FROM {0} WHERE {1}='{2}'", tableName, field, value)
    End If
    commander.CommandText = sql
    Dim sum As Integer = Await Me.commander.ExecuteScalarAsync()
    Return sum
  End Function

  Public Function Choice(fields As List(Of String)) As Database
    Me.find = "SELECT "
    For Each filed As String In fields
      Me.find += String.Format("{0},", filed)
    Next
    Me.find = Me.find.Remove(find.Length - 1, 1)
    isQueryChoiceExected = True
    Return Me
  End Function

  Public Function From(tableName As String) As Database
    Me.find += String.Format(" FROM {0}", tableName)
    isQueryFromExected = True
    Return Me
  End Function

  Public Function Where(limitation As String) As Database
    Me.find += String.Format(" WHERE {0}", limitation)
    Return Me
  End Function

  Public Function OrderBy(sort As String) As Database
    Dim allowedSort As String() = {"ASC", "DESC"}
    If allowedSort.Contains(sort.Trim().ToUpper()) = False Then
      sort = "DESC"
    End If
    Me.find += String.Format(" ORDER BY rowid {0}", sort)
    Return Me
  End Function

  Public Async Function QuerySingleCell() As Task(Of String)
    Dim result As String
    commander.CommandText = Me.find
    result = Await commander.ExecuteScalarAsync()
    Return result
  End Function

  Public Async Function Query() As Task(Of List(Of List(Of String)))
    Dim result As List(Of List(Of String)) = New List(Of List(Of String))
    commander.CommandText = Me.find
    Dim reader As SqliteDataReader = Await commander.ExecuteReaderAsync()
    While Await reader.ReadAsync()
      Dim cols As Integer = reader.FieldCount - 1
      Dim items As List(Of String) = New List(Of String)
      For index As Integer = 0 To cols
        items.Add(reader.GetString(index))
      Next
      result.Add(items)
    End While
    isQueryChoiceExected = False
    isQueryFromExected = False
    reader.Close()
    Return result
  End Function

  Public Async Function Insert(tableName As String, data As Dictionary(Of String, String)) As Task(Of Boolean)
    Dim sql As String
    sql = String.Format("INSERT INTO {0} ", tableName)

    Dim generateListString = Function(collection As List(Of String)) As String
                               Dim str As String = ""
                               For Each item As String In collection
                                 str += String.Format("'{0}',", item)
                               Next
                               str = str.TrimEnd(CChar(","))
                               str = String.Format("({0})", str)
                               Return str
                             End Function

    Dim keys As String = generateListString(data.Keys.ToList())
    Dim values As String = generateListString(data.Values.ToList())
    sql += String.Format("{0} VALUES {1}", keys, values)
    commander.CommandText = sql
    Await commander.ExecuteNonQueryAsync()
    Return True
  End Function

  Public Async Function Update(tableName As String, key As String, value As String, id As Integer) As Task(Of Boolean)
    Dim sql As String = String.Format("UPDATE {0} SET {1}='{2}' WHERE ROWID={3}", tableName, key, value, id)
    commander.CommandText = sql
    Await commander.ExecuteNonQueryAsync()
    Return True
  End Function

  Public Async Function Remove(tableName As String, id As Integer) As Task(Of Boolean)
    Dim sql As String = String.Format("DELETE FROM {0} WHERE ROWID={1}", tableName, id)
    commander.CommandText = sql
    Await commander.ExecuteNonQueryAsync()
    commander.Dispose()
    Return True
  End Function

  Public Async Function fill(tableName As String, data As List(Of String), callback As Func(Of Boolean)) As Task(Of Boolean)
    Dim tr As SqliteTransaction = connection.BeginTransaction()
    Using tr
      commander.Transaction = tr
      For Each item As String In data
        Try
          commander.CommandText = String.Format("INSERT INTO {0} (Word, Chiniese) VALUES ({1})", tableName, item)
          Await commander.ExecuteNonQueryAsync()
          Debug.WriteLine(commander.CommandText)
          callback()
        Catch ex As Exception
          Debug.WriteLine(ex.Message)
          Continue For
        End Try
      Next
      tr.Commit()
    End Using
    Return True
  End Function

  Public Function Close() As Database
    connection.Close()
    Return Me
  End Function

  Public Function Destroy() As Boolean
    connection.Close()
    Dim currentPath = Environment.CurrentDirectory
    Dim file As String = System.IO.Path.Combine(currentPath, databaseFile)
    My.Computer.FileSystem.DeleteFile(file)
    Return True
  End Function
End Class
