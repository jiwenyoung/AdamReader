Public Class BookMark
  Property id As Integer
  Property BookMark As String

  Sub New(id As Integer, characterIndex As Integer)
    Me.id = id
    Me.BookMark = CStr(characterIndex)
  End Sub

  Public Async Function Save() As Task(Of Boolean)
    Dim DB As Database = AdamReader.DB
    Await DB.Update("Books", "BookMark", Me.BookMark, Me.id)
    Return True
  End Function

  Public Shared Async Function GetBookMark(bookID As Integer) As Task(Of Integer)
    Dim DB As Database = AdamReader.DB
    Dim fields As List(Of String) = New List(Of String)
    fields.Add("BookMark")
    Dim condition As String = String.Format("ROWID={0}", bookID)
    Dim bookmark As String = Await DB.Choice(fields).From("Books").Where(condition).QuerySingleCell()
    Dim thisBookMark As Integer = CInt(bookmark)
    Return thisBookMark
  End Function
End Class
