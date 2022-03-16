Public Class BookEntry
  Property BookName As String
  Property id As Integer

  Sub New(id As Integer, bookname As String)
    Me.id = id
    Me.BookName = bookname
  End Sub
End Class