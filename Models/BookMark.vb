Public Class BookMark
  Property BookName As String
  Property id As Integer
  Property line As Integer

  Sub New(id As Integer, bookname As String, line As Integer)
    Me.BookName = bookname
    Me.id = id
    Me.line = line
  End Sub

  Public Function save() As Boolean

  End Function

  Public Shared Function getLine(bookID As Integer) As Integer

  End Function

End Class
