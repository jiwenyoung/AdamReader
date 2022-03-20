Imports System.Collections.Generic

Public Class BookList

  Public Shared Async Function GetList() As Task(Of List(Of BookEntry))
    Dim DB As Database = AdamReader.DB
    Dim collection As List(Of BookEntry) = New List(Of BookEntry)
    Dim results As List(Of List(Of String))
    Dim fields As List(Of String) = New List(Of String)
    fields.Add("ROWID")
    fields.Add("BookName")
    results = Await DB.Choice(fields).From("Books").OrderBy("DESC").Query()
    For Each document As List(Of String) In results
      Dim item As BookEntry = New BookEntry(document(0), document(1))
      collection.Add(item)
    Next
    Return collection
  End Function

  Public Shared Async Function RemoveFromList(id As Integer) As Task(Of Boolean)
    Dim DB As Database = AdamReader.DB
    Return Await DB.Remove("Books", id)
  End Function

End Class
