Public Class BookEntry
  Property BookName As String
  Property Id As Integer

  Sub New(id As Integer, bookname As String)
    Me.Id = id
    Me.BookName = bookname
  End Sub
End Class