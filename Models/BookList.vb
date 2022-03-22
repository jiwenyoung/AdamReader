Public Class BookList

  Public Shared Async Function GetList() As Task(Of List(Of BookEntry))
    Dim DB As Database = AdamReader.DB
    Dim collection As New List(Of BookEntry)
    Dim results As List(Of List(Of String))
    Dim fields As New List(Of String) From {
      "ROWID",
      "BookName"
    }
    results = Await DB.Choice(fields).From("Books").OrderBy("DESC").Query()
    For Each document As List(Of String) In results
      Dim item As New BookEntry(document(0), document(1))
      collection.Add(item)
    Next
    Return collection
  End Function

  Public Shared Async Function RemoveFromList(id As Integer) As Task(Of Boolean)
    Dim DB As Database = AdamReader.DB
    Return Await DB.Remove("Books", id)
  End Function

  Public Shared Async Function Has(bookname As String) As Task(Of Boolean)
    Dim DB As Database = AdamReader.DB
    Dim count As Integer = Await DB.Count("Books", "BookName", bookname)
    If count > 0 Then
      Return True
    Else
      Return False
    End If
  End Function
End Class
