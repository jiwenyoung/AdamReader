Imports System.Collections.Generic

Public Class AdamReader
  Private Function pickFile()
    Dim filename As String
    Dim filePicker As OpenFileDialog = New OpenFileDialog()
    filePicker.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
    filePicker.RestoreDirectory = True
    If filePicker.ShowDialog() = DialogResult.OK Then
      filename = filePicker.FileName
      Return filename
    Else
      Return "NO"
    End If
  End Function

  Private Sub SwitchSideBar(whichOne As String)
    If whichOne = "dictionary" Then
      Me.BooksUnderLine.Hide()
      Me.DictUnderLine.Show()
      Me.BarContent.Controls.Clear()
      DictionaryContent.TopLevel = False
      DictionaryContent.Width = Me.BarContent.Width - 28
      DictionaryContent.Height = Me.BarContent.Height - 28
      Me.BarContent.Controls.Add(DictionaryContent)
      DictionaryContent.Show()
    ElseIf whichOne = "booklist" Then
      Me.DictUnderLine.Hide()
      Me.BooksUnderLine.Show()
      Me.BarContent.Controls.Clear()

      '
      'Read Books From Database, call method in model 
      '
      Dim a As BookItem = New BookItem(0, "Common Sense")
      a.Width = Me.BarContent.Width - 8
      a.TopLevel = False
      Me.BarContent.Controls.Add(a)
      a.Show()

      Dim b As BookItem = New BookItem(1, "Gone with the wind")
      b.Width = Me.BarContent.Width - 8
      b.TopLevel = False
      Me.BarContent.Controls.Add(b)
      b.Show()

    End If
  End Sub

  Private Sub AdamReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    SwitchSideBar("dictionary")
  End Sub

  Private Sub DictionaryBtn_Click(sender As Object, e As EventArgs) Handles DictionaryBtn.Click
    SwitchSideBar("dictionary")
  End Sub

  Private Sub BookListBtn_Click(sender As Object, e As EventArgs) Handles BookListBtn.Click
    SwitchSideBar("booklist")
  End Sub

  Private Async Sub ImportBookBtn_Click(sender As Object, e As EventArgs) Handles ImportBookBtn.Click
    Dim filename As String = Me.pickFile()
    Dim content As List(Of String) = Await BookFile.read(filename)
    For Each line As String In content
      Me.TextBox.Text = Me.TextBox.Text + line + Environment.NewLine
    Next
  End Sub

  Private Sub AdamReader_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
    DictionaryContent.Width = Me.BarContent.Width - 28
    DictionaryContent.Height = Me.BarContent.Height - 28
  End Sub

  Private Sub AdamReader_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
    Me.ImportBookBtn.FlatAppearance.BorderSize = 0
  End Sub
End Class
