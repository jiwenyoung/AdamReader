Public Class BookItem
  Public Property Id As Integer
  Public Property ThisBookName As String

  Sub New(id As Integer, name As String)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.Id = id
    Me.ThisBookName = name
  End Sub

  Public Async Function PickOneBookItem() As Task
    ' Fetch text from file
    Dim bookContent As String = Await Book.Fetch(Me.ThisBookName)

    ' Write text to RichTextBox
    AdamReader.TextBox.Text = bookContent

    ' Get Bookmark
    Dim mark As Integer = Await BookMark.GetBookMark(Me.Id)

    ' Scroll to this Bookmark
    AdamReader.DragHerePic.Hide()
    AdamReader.TextBox.Show()
    AdamReader.TextBox.Select()
    AdamReader.TextBox.SelectionStart = mark
    AdamReader.TextBox.ScrollToCaret()

    ' Set Header TextBox
    AdamReader.BookNameTextBox.Text = Me.ThisBookName

    ' Set Adam Reader ID
    AdamReader.CurrentID = Me.Id
    AdamReader.CurrentBookName = Me.ThisBookName

    ' HightLight Current and Whitize others
    AdamReader.HighLightSelected()
  End Function

  Private Sub BookItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.BookName.Text = Me.ThisBookName
  End Sub

  Private Async Sub BookName_Click(sender As Object, e As EventArgs) Handles BookName.Click, MyBase.Click
    Await PickOneBookItem()
  End Sub

  Private Async Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
    Dim message As String = "Do you want to delete this book?"
    Dim caption As String = "Remove Book"
    Dim result As DialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo)
    If result = DialogResult.Yes Then
      ' Get Full Path of Book File
      Dim currentPath As String = Environment.CurrentDirectory
      Dim whereToSaveBook As String = Settings.BooksFolder
      Dim bookFolder = IO.Path.Combine(currentPath, whereToSaveBook)
      Dim fileName = String.Format("{0}.txt", Me.ThisBookName)
      Dim destination As String = IO.Path.Combine(bookFolder, fileName)

      ' Delete File
      Dim removedBook As New BookFile(destination)
      removedBook.Remove()

      ' Remove from database
      Await BookList.RemoveFromList(Me.Id)

      ' Refresh BookList
      AdamReader.BarContent.Controls.Clear()
      AdamReader.RefreshBookList()
      If AdamReader.CurrentID = Me.Id Then
        AdamReader.TextBox.Hide()
        AdamReader.DragHerePic.Show()
      End If
    End If
  End Sub
End Class