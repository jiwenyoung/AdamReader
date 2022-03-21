Public Class Dictionary
  Public Shared Async Function GetDefinitionFromDB(word As String) As Task(Of String)
    Dim DB As Database = AdamReader.DB

    Dim definition As String
    Dim query = Async Function(queryWord As String) As Task(Of String)
                  Dim fields As New List(Of String) From {
                    "Chiniese"
                  }
                  Dim condition As String = String.Format("Word='{0}'", queryWord)
                  definition = Await DB.Choice(fields).From("Words").Where(condition).QuerySingleCell()
                  Return definition
                End Function

    word = word.Trim().ToLower()
    definition = Await query(word)
    If definition = "" Then
      If word.EndsWith("ed") Then
        word = word.TrimEnd(New Char() {"e", "d"})
        If word.EndsWith("i") Then
          word = String.Concat(word.AsSpan(0, word.Length - 1), "y")
          definition = Await query(word)
          If definition = "" Then
            word = word.Substring(0, word.Length - 2)
            definition = Await query(word)
          End If
        Else
          definition = Await query(word)
          If definition = "" Then
            word += "e"
            definition = Await query(word)
          End If
        End If
      ElseIf word.EndsWith("ing") Then
        word = word.Substring(0, word.Length - 3)
        definition = Await query(word)
      ElseIf word.EndsWith("s") Then
        word = word.TrimEnd("s")
        definition = Await query(word)
      ElseIf word.EndsWith("es") Then
        word = word.TrimEnd(New Char() {"e", "s"})
        word = String.Concat(word.AsSpan(0, word.Length - 1), "y")
        definition = Await query(word)
      ElseIf word.EndsWith("ly") Then
        word = word.TrimEnd(New Char() {"l", "y"})
        definition = Await query(word)
      End If
    End If
    Return definition
  End Function

  Public Shared Async Function Add(word As String, definition As String) As Task(Of Boolean)
    Dim DB As Database = AdamReader.DB
    Dim data As New Dictionary(Of String, String) From {
      {"Word", word.ToLower()},
      {"Chiniese", definition}
    }
    If Await DB.Insert("Words", data) Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Shared Async Function Modify(word As String, definition As String) As Task(Of Boolean)
    word = word.ToLower()
    Dim DB As Database = AdamReader.DB
    Dim fileds As New List(Of String) From {
      "ROWID"
    }
    Dim condition = String.Format("Word='{0}'", word)
    Dim rowID As String = Await DB.Choice(fileds).From("Words").Where(condition).QuerySingleCell()
    rowID = CInt(rowID)
    Debug.WriteLine(rowID)
    Return Await DB.Update("Words", "Chiniese", definition, rowID)
  End Function
End Class