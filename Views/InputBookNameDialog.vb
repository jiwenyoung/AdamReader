Public Class InputBookNameDialog
  Public Property BookName As String

  Private Sub BookNameInputBoxOKBtn_Click(sender As Object, e As EventArgs) Handles BookNameInputBoxOKBtn.Click
    Dim name As String = Me.BookNameInputBox.Text
    If name = "" Then
      Me.BookNameInputBox.Select()
    Else
      Me.BookName = name
      Me.Hide()
    End If
  End Sub
End Class