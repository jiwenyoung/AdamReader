Public Class DictionaryContent
  Private Async Sub EditDefinitionBtn_Click(sender As Object, e As EventArgs) Handles EditDefinitionBtn.Click
    Dim word As String = Me.ChinieseLabel.Text
    Dim definition As String = ""

    InputWordDefinitionDialog.SelectedWord.Text = word
    Dim result As DialogResult = InputWordDefinitionDialog.ShowDialog()
    If result = DialogResult.OK Then
      definition = InputWordDefinitionDialog.DefinitionInputBox.Text.Trim()
    End If
    Await Dictionary.Modify(word, definition)

    AdamReader.showMessage("Dictionary has been modified")
    InputWordDefinitionDialog.DefinitionInputBox.Text = ""
  End Sub

  Private Sub ChinieseLabel_TextChanged(sender As Object, e As EventArgs) Handles ChinieseLabel.TextChanged
    If Me.ChinieseLabel.Text = "Chiniese" Then
      Me.EditDefinitionBtn.Hide()
    Else
      Me.EditDefinitionBtn.Show()
    End If
  End Sub
End Class