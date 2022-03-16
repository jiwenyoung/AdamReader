Imports System.Collections.Generic

Public Class Book
  Dim BookFile As String
  Property Content As List(Of String)

  Sub New(whichbook As String)
    Me.BookFile = whichbook
  End Sub

  Public Function fetch() As Boolean

  End Function

  Public Function save() As Boolean

  End Function

  Public Shared Function read(id As Integer) As List(Of String)

  End Function

End Class
