﻿Public Class BookItem
  Public Property id As Integer
  Public Property ThisBookName As String

  Sub New(id As Integer, name As String)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.id = id
    Me.ThisBookName = name
  End Sub

  Private Sub BookItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.BookName.Text = Me.ThisBookName
  End Sub

  Private Async Sub BookName_Click(sender As Object, e As EventArgs) Handles BookName.Click, Me.Click
    ' Fetch text from file
    Dim bookContent As String = Await Book.Fetch(Me.ThisBookName)

    ' Write text to RichTextBox
    AdamReader.TextBox.Text = bookContent

    ' Get Bookmark
    Dim mark As Integer = Await BookMark.GetBookMark(Me.id)

    ' Scroll to this Bookmark
    AdamReader.TextBox.Select()
    AdamReader.TextBox.SelectionStart = mark
    AdamReader.TextBox.ScrollToCaret()

    ' Set Header TextBox
    AdamReader.BookNameTextBox.Text = Me.ThisBookName

    ' HightLight Current and Whitize others
    AdamReader.SwitchSideBar("booklist")

    ' Set Adam Reader ID
    AdamReader.currentID = Me.id
    AdamReader.currentBookName = Me.ThisBookName
  End Sub

  Private Async Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
    Dim message As String = "Do you want to delete this book?"
    Dim caption As String = "Remove Book"
    Dim result As DialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel)
    If result = DialogResult.Yes Then
      ' Get Full Path of Book File
      Dim currentPath As String = Environment.CurrentDirectory
      Dim whereToSaveBook As String = Settings.booksFolder
      Dim bookFolder = IO.Path.Combine(currentPath, whereToSaveBook)
      Dim fileName = String.Format("{0}.txt", Me.ThisBookName)
      Dim destination As String = IO.Path.Combine(bookFolder, fileName)

      ' Delete File
      Dim removedBook As BookFile = New BookFile(destination)
      removedBook.Remove()

      ' Remove from database
      Await BookList.RemoveFromList(Me.id)

      ' Refresh BookList
      AdamReader.BarContent.Controls.Clear()
      AdamReader.RefreshBookList()
      AdamReader.TextBox.Text = ""
    End If
  End Sub
End Class