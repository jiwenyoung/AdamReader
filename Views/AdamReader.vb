Public Class AdamReader
  Public Property DB As Database
  Public Property CurrentID As Integer = 0
  Public Property CurrentBookName As String = ""
  Public Property JustImportedBookName As String = ""
  Public Property Mode As String = "Book"

  Dim textBoxfontSize As Single = Settings.DefaultFontSize
  Dim sidebarStatus As String = "booklist"

  Private Sub SetColor()
    Me.Header.BackColor = Settings.PrimaryColor
    Me.ImportBookBtn.BackColor = Settings.PrimaryColor
    Me.BooksUnderLine.BackColor = Settings.PrimaryColor
    Me.DictUnderLine.BackColor = Settings.PrimaryColor
    Me.Message.BackColor = Settings.PrimaryColor
    Me.BookNameTextBox.BackColor = Settings.PrimaryColor

    Me.DictionaryBuildBtn.BackColor = Settings.PrimaryColor
    Me.DictionaryBuildBtn.FlatAppearance.MouseOverBackColor = Settings.PrimaryColor
    Me.DictionaryBuildBtn.FlatAppearance.MouseDownBackColor = Settings.PrimaryColor

    Me.resetBtn.BackColor = Settings.PrimaryColor
    Me.resetBtn.FlatAppearance.MouseOverBackColor = Settings.PrimaryColor
    Me.resetBtn.FlatAppearance.MouseDownBackColor = Settings.PrimaryColor

    Me.markBtn.BackColor = Settings.PrimaryColor
    Me.markBtn.FlatAppearance.MouseOverBackColor = Settings.PrimaryColor
    Me.markBtn.FlatAppearance.MouseDownBackColor = Settings.PrimaryColor

    Me.ZoomInBtn.BackColor = Settings.PrimaryColor
    Me.ZoomInBtn.FlatAppearance.MouseDownBackColor = Settings.PrimaryColor
    Me.ZoomInBtn.FlatAppearance.MouseOverBackColor = Settings.PrimaryColor

    Me.ZoomOutBtn.BackColor = Settings.PrimaryColor
    Me.ZoomOutBtn.FlatAppearance.MouseOverBackColor = Settings.PrimaryColor
    Me.ZoomOutBtn.FlatAppearance.MouseDownBackColor = Settings.PrimaryColor

    InputBookNameDialog.OKBtn.BackColor = Settings.PrimaryColor
    InputBookNameDialog.BookNameInputBoxUnderLine.BackColor = Settings.PrimaryColor
    InputWordDefinitionDialog.OKBtn.BackColor = Settings.PrimaryColor
    InputWordDefinitionDialog.DefinitionInputBoxUnderline.BackColor = Settings.PrimaryColor
  End Sub

  Private Sub SetLanguage()
    If Language.IsEnglish() = True Then
      Language.SetLanguageOfEN()
      Me.DragHerePic.Image = My.Resources.dragen
    Else
      Language.SetLanguageOfCN()
      Me.DragHerePic.Image = My.Resources.dragcn
    End If
    Me.ImportBookBtn.Text = Language.TextImportButton
    DictionaryContent.ChinieseLabel.Text = Language.TextDictionaryPanelPrompt
    InputBookNameDialog.BookNamePrompt.Text = Language.TextBookNamePrompt
    InputBookNameDialog.OKBtn.Text = Language.TextBtnConfirmed
    InputBookNameDialog.CancelBtn.Text = Language.TextBtnCancel
    InputWordDefinitionDialog.PromptText.Text = Language.TextDefinitionModifyPrompt
    InputWordDefinitionDialog.OKBtn.Text = Language.TextBtnConfirmed
    InputWordDefinitionDialog.CancelBtn.Text = Language.TextBtnCancel
    PrograssBar.Text = Language.TextPrograssBarPrompt
  End Sub

  Private Shared Function PickFile(Optional filter As String = "")
    Dim filename As String
    Dim filePicker As New OpenFileDialog With {
      .RestoreDirectory = True
    }
    If filter <> "" Then
      filePicker.Filter = filter
    End If
    If filePicker.ShowDialog() = DialogResult.OK Then
      filename = filePicker.FileName
      filePicker.Dispose()
      Return filename
    Else
      filePicker.Dispose()
      Return "NO"
    End If
  End Function

  Public Async Sub ShowNotice(notice As String)
    Me.Message.BringToFront()
    Me.MessageText.Text = notice
    Dim x As Integer = (Me.Message.Width - Me.MessageText.Width) / 2
    Dim y As Integer = (Me.Message.Height - Me.MessageText.Height) / 2
    Me.MessageText.Location = New Point(x, y)

    Dim MoveIn = Async Function(velocity As Integer) As Task(Of Boolean)
                   While True
                     Dim PositionX As Integer = Me.Message.Location.X + 10
                     Dim PositionY As Integer = Me.Message.Location.Y
                     If PositionX <= 0 Then
                       Me.Message.Location = New Point(PositionX, PositionY)
                       Await Task.Delay(velocity)
                     Else
                       Exit While
                     End If
                   End While
                   Return True
                 End Function

    ' Message Box Show
    Me.Message.Show()
    Await MoveIn(2)
    Await Task.Delay(4000)
    Me.Message.Hide()

    Dim ResetX As Integer = 0 - Me.Message.Width
    Dim ResetY As Integer = Me.Message.Location.Y
    Me.Message.Location = New Point(ResetX, ResetY)
  End Sub

  Public Sub HighLightSelected()
    For Each element As BookItem In BarContent.Controls
      If element.ThisBookName = CurrentBookName And element.Id = CurrentID Then
        element.BookName.ForeColor = Settings.PrimaryColor
      Else
        element.BookName.ForeColor = ColorTranslator.FromHtml("#a4b0be")
      End If
      element.Show()
    Next
  End Sub

  Public Async Sub RefreshBookList()
    '
    'Read Books From Database, call method in model 
    '
    Dim bookCollection As List(Of BookEntry) = Await BookList.GetList()

    For Each bookEntry As BookEntry In bookCollection
      Dim id As Integer = Integer.Parse(bookEntry.Id)
      Dim name As String = bookEntry.BookName
      Dim bookItem As New BookItem(id, name) With {
        .Width = BarContent.Width - 26,
        .TopLevel = False
      }
      BarContent.Controls.Add(bookItem)
      bookItem.Show()
    Next

    HighLightSelected()
  End Sub

  Public Sub SwitchSideBar(whichOne As String)
    If whichOne = "dictionary" Then
      Me.BooksUnderLine.Hide()
      Me.DictUnderLine.Show()
      Me.BarContent.Controls.Clear()
      DictionaryContent.TopLevel = False
      DictionaryContent.Width = Me.BarContent.Width - 28
      DictionaryContent.Height = Me.BarContent.Height - 28
      Me.BarContent.Controls.Add(DictionaryContent)
      DictionaryContent.Show()
      sidebarStatus = "dictionary"
    ElseIf whichOne = "booklist" Then
      Me.DictUnderLine.Hide()
      Me.BooksUnderLine.Show()
      Me.BarContent.Controls.Clear()
      RefreshBookList()
      sidebarStatus = "booklist"
    End If
  End Sub

  Public Sub Zoom(direction As String)
    Dim currentCursor As Integer = Me.TextBox.SelectionStart
    Me.TextBox.SelectAll()
    If direction = "in" Then
      textBoxfontSize += 2
    ElseIf direction = "out" Then
      textBoxfontSize -= 2
    End If
    Dim myFontFamily As FontFamily = TextBox.SelectionFont.FontFamily
    Me.TextBox.SelectionFont = New Font(myFontFamily, textBoxfontSize, FontStyle.Regular)
    Me.TextBox.Select(currentCursor, 1)
  End Sub

  Private Async Function ImportBook(Optional name As String = "", Optional filename As String = "") As Task(Of Boolean)
    Dim IsCancelBtnClicked As Boolean = False

    If name = "" Then
      ' Pompt to ask the name of book and pick its file
      Dim dialogResult As DialogResult = InputBookNameDialog.ShowDialog()
      InputBookNameDialog.Focus()
      If dialogResult = DialogResult.OK Then
        name = InputBookNameDialog.BookName
      Else
        IsCancelBtnClicked = True
      End If
      InputBookNameDialog.Hide()
      InputBookNameDialog.Dispose()
    End If
    If IsCancelBtnClicked = False Then
      If Await BookList.Has(name) Then
        ShowNotice(Language.NoticeSameBookName)
        Return False
      End If

      If filename = "" Then
        filename = PickFile("txt files (*.txt)|*.txt|All files (*.*)|*.*")
      End If
      If BookFile.Has(name) Then
        ShowNotice(Language.NoticeSameBookFile)
        Return False
      End If

      If filename <> "NO" Then
        ' Show Prograss Bar
        PrograssBar.Prograss.Maximum = 3
        PrograssBar.Prograss.Minimum = 0
        PrograssBar.Prograss.Value = 0
        PrograssBar.Show()

        ' Read file content to a String
        Dim importedBook As New BookFile(filename)
        Dim content As String = Await importedBook.Read()
        PrograssBar.Prograss.Increment(1)

        ' Copy to local directory
        importedBook.BookContent = content
        importedBook.BookName = name
        Await importedBook.Write()
        PrograssBar.Prograss.Increment(1)

        ' Write to database about bookname
        Dim booksWithSameNameInDB As Integer = Await DB.Count("Books", "BookName", name)
        If booksWithSameNameInDB = 0 Then
          Dim freshBook As New Book(name)
          Await freshBook.Save()
        End If
        PrograssBar.Prograss.Increment(1)

        ' Hide Prograss Bar and Switch to booklist in Sidebar
        SwitchMode("Book")
        SwitchSideBar("booklist")
        JustImportedBookName = name
        PrograssBar.Hide()
        Await PerformClickOnJustImportedBookItem()
      End If
      InputBookNameDialog.Dispose()
      PrograssBar.Dispose()

      Return True
    Else
      Return False
    End If
  End Function

  Private Async Function PerformClickOnJustImportedBookItem() As Task
    For Each thisBookItem As BookItem In Me.BarContent.Controls
      If thisBookItem.ThisBookName = JustImportedBookName Then
        Await thisBookItem.PickOneBookItem()
      End If
    Next
  End Function

  Private Async Function ImportEssay(EssayPath As String) As Task(Of Boolean)
    Dim Content As String = Await Essay.Read(EssayPath)
    If Content <> "" Then
      SwitchMode("Essay")
      Me.EssayModePathBox.Text = IO.Path.GetFileName(EssayPath)
      Me.TextBox.Text = Content
      Me.DragHerePic.Hide()
      Me.TextBox.Show()
      SwitchSideBar("dictionary")
      Return True
    Else
      Return False
    End If
  End Function

  Public Sub SwitchMode(mode As String, Optional IsStartUp As Boolean = False)
    Dim moveBtnGroup = Sub(direction As String)
                         Dim howmuch As Integer
                         If direction = "right" Then
                           howmuch = 50
                         ElseIf direction = "left" Then
                           howmuch = -50
                         End If
                         Me.resetBtn.Location = New Point(
                            Me.resetBtn.Location.X + howmuch,
                            Me.resetBtn.Location.Y
                         )
                         Me.ZoomInBtn.Location = New Point(
                            Me.ZoomInBtn.Location.X + howmuch,
                            Me.resetBtn.Location.Y
                         )
                         Me.ZoomOutBtn.Location = New Point(
                            Me.ZoomOutBtn.Location.X + howmuch,
                            Me.ZoomOutBtn.Location.Y
                         )
                         Me.DictionaryBuildBtn.Location = New Point(
                            Me.DictionaryBuildBtn.Location.X + howmuch,
                            Me.DictionaryBuildBtn.Location.Y
                         )
                       End Sub

    If mode = "Essay" Then
      Me.markBtn.Hide()
      If Me.Mode <> "Essay" Then
        moveBtnGroup("right")
      End If
      Me.BookNameTextBox.Hide()
      Me.EssayModePathBox.Show()
      Me.Mode = "Essay"
      ShowNotice(Language.NoticeEnterEssayMode)
    ElseIf mode = "Book" Then
      Me.EssayModePathBox.Hide()
      If IsStartUp <> True And Me.Mode <> "Book" Then
        moveBtnGroup("left")
      End If
      Me.markBtn.Show()
      Me.BookNameTextBox.Show()
      Me.Mode = "Book"
      ShowNotice(Language.NoticeEnterBookMode)
    End If
  End Sub

  Private Sub AdamReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    DB = New Database()
    DB.Conntect()
    SwitchSideBar("booklist")
    Me.Message.Visible = False
    Me.TextBox.ReadOnly = True
    Me.TextBox.HideSelection = True
    Me.WindowState = Me.WindowState.Maximized
    Me.BookNameTextBox.Width = Me.Header.Width * （30 / 100）
    MyBase.KeyPreview = True
    Me.TextBox.Hide()
    Dim x As Integer = (Me.TextContainer.Width - Me.DragHerePic.Width) / 2
    Dim y As Integer = (Me.TextContainer.Height - Me.DragHerePic.Height) / 2
    Me.DragHerePic.Location = New Point(x, y)
    Me.Message.BringToFront()
    SetColor()
    SetLanguage()
    SwitchMode("Book", True)
  End Sub

  Private Sub DictionaryBtn_Click(sender As Object, e As EventArgs) Handles DictionaryBtn.Click
    Try
      SwitchSideBar("dictionary")
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub BookListBtn_Click(sender As Object, e As EventArgs) Handles BookListBtn.Click
    Try
      SwitchSideBar("booklist")
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Async Sub ImportBookBtn_Click(sender As Object, e As EventArgs) Handles ImportBookBtn.Click
    Try
      Await ImportBook()
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub AdamReader_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
    Try
      DictionaryContent.Width = Me.BarContent.Width - 28
      DictionaryContent.Height = Me.BarContent.Height - 28
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub AdamReader_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
    Try
      Me.ImportBookBtn.FlatAppearance.BorderSize = 0
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub AdamReader_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Try
      DB.Close()
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Async Sub MarkBtn_Click(sender As Object, e As EventArgs) Handles markBtn.Click
    Try
      ' Get Current Caret Index
      Me.TextBox.Select()
      Dim mark As Integer = Me.TextBox.SelectionStart

      ' Update it to database
      Dim newBookMark As New BookMark(CurrentID, mark)
      Await newBookMark.Save()

      ShowNotice(Language.NoticeBookMarkUpdated)
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Async Sub TextBox_Click(sender As Object, e As MouseEventArgs) Handles TextBox.Click
    Try
      Dim selectedWord As String = ""
      Dim isEnglish As Boolean = True

      ' Sidebar open dictionary panel
      Me.DictionaryBtn.PerformClick()

      ' Get the word mouse pointed
      Dim GetPointedWord = Function() As String
                             Dim content As String = Me.TextBox.Text
                             Dim charIndex As Integer = Me.TextBox.GetCharIndexFromPosition(e.Location)
                             Dim word As New List(Of Char) From {
                               content.Chars(charIndex)
                             }
                             Dim symbols As Char()
                             Dim letters As String = "abcdefghijklmnopqrstuvwxyz"
                             letters += letters.ToUpper()
                             symbols = letters.ToCharArray()

                             If symbols.Contains(content.Chars(charIndex)) Then
                               Dim index As Integer = charIndex - 1
                               While symbols.Contains(content.Chars(index))
                                 Dim myChar = content.Chars(index)
                                 word.Insert(0, myChar)
                                 If index <> 0 Then
                                   index -= 1
                                 Else
                                   Exit While
                                 End If
                               End While

                               index = charIndex + 1
                               While symbols.Contains(content.Chars(index))
                                 Dim myChar = content.Chars(index)
                                 word.Add(content.Chars(index))
                                 index += 1
                               End While
                             Else
                               isEnglish = False
                             End If

                             Dim charStr As String = ""
                             For Each chr As Char In word
                               charStr += chr
                             Next
                             Return charStr
                           End Function
      Try
        If Me.TextBox.Text.Length > 0 Then
          selectedWord = GetPointedWord()
        End If
      Catch ex As Exception
        Console.WriteLine(ex.Message)
      End Try

      ' Get the word defination 
      Dim definition As String = ""
      selectedWord = selectedWord.Trim()
      If selectedWord <> "" And isEnglish = True Then
        definition = Await Dictionary.GetDefinitionFromDB(selectedWord)

        If definition = "" Then
          ' Ask User to input definition
          InputWordDefinitionDialog.DefinitionInputBox.Text = ""
          InputWordDefinitionDialog.SelectedWord.Text = selectedWord
          Dim response As DialogResult = InputWordDefinitionDialog.ShowDialog()
          If response = DialogResult.OK Then
            definition = InputWordDefinitionDialog.DefinitionInputBox.Text.Trim()

            ' Write the defination into database
            If Await Dictionary.Has(selectedWord) Then
              If Await Dictionary.Modify(selectedWord, definition) Then
                ShowNotice(Language.NoticeWordModified)
              End If
            Else
              If Await Dictionary.Add(selectedWord, definition) Then
                ShowNotice(Language.NoticeNewWordAdded)
              End If
            End If
          End If
        End If

        ' Update Dictionary Sidebar
        If isEnglish Then
          DictionaryContent.ChinieseLabel.Text = selectedWord
          DictionaryContent.ChinieseText.Text = definition
        End If
      End If
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
    Try
      Dim message As String = Language.TextResetAppMessage
      Dim caption As String = Language.TextResetAppPrompt
      Dim result As DialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo)
      If result = DialogResult.Yes Then
        BookFile.Destroy()
        DB.Destroy()
        Application.Exit()
      End If
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Async Sub BookNameTextBox_Leave(sender As Object, e As EventArgs) Handles BookNameTextBox.Leave
    Try
      Dim newName As String = Me.BookNameTextBox.Text
      Dim modifiedName As String = Await Book.Rename(CurrentID, CurrentBookName, newName)
      If modifiedName <> "" Then
        Me.BookNameTextBox.Text = modifiedName
        CurrentBookName = modifiedName
        SwitchSideBar("booklist")
        ShowNotice(Language.NoticeBookNameModified)
      Else
        Me.BookNameTextBox.Text = CurrentBookName
      End If
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub BarContent_Paint(sender As Object, e As PaintEventArgs) Handles BarContent.Paint
    Try
      If sidebarStatus = "booklist" Then
        If CurrentBookName <> "" And CurrentID <> 0 Then
          HighLightSelected()
        End If
      End If
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub ZoomInBtn_Click(sender As Object, e As EventArgs) Handles ZoomInBtn.Click
    Try
      Zoom("in")
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub ZoomOutBtn_Click(sender As Object, e As EventArgs) Handles ZoomOutBtn.Click
    Try
      Zoom("out")
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Async Sub DictionaryBuildBtn_Click(sender As Object, e As EventArgs) Handles DictionaryBuildBtn.Click
    Try
      Dim howManyWords As Integer = Await DB.Count("Words", "word")
      If howManyWords = 0 Then
        Dim fileReader As IO.StreamReader
        If IO.File.Exists("dictionary.dat") Then
          fileReader = New IO.StreamReader("dictionary.dat")
        Else
          Dim csvWordFile As String = PickFile("dat files (*.dat)|*.dat|All files (*.*)|*.*")
          fileReader = New IO.StreamReader(csvWordFile)
        End If
        Dim data As New List(Of String)

        Dim cleanENG = Function(eng As String)
                         If "abcdefghijklmnopqrstuvwxyz".Contains(eng(0)) = False Then
                           eng = eng.Remove(0, 1)
                         End If
                         eng = eng.Replace(Chr(34), "")
                         eng = eng.Replace(" ", "")
                         Return eng
                       End Function

        Dim cleanSINO = Function(sino As String)
                          sino = sino.Replace(Chr(34), "")
                          sino = sino.Replace("\n", "")
                          Return sino
                        End Function

        While fileReader.Peek() <> -1
          Dim line As String = Await fileReader.ReadLineAsync()
          Dim columns As String() = Split(line, "|")

          Dim eng As String = cleanENG(columns(0).ToLower())
          Dim sino As String = cleanSINO(columns(1))

          If sino <> "" Then
            If eng.Contains(" "c) = False Then
              data.Add(String.Format("'{0}','{1}'", eng, sino))
            End If
          End If
        End While

        PrograssBar.Prograss.Maximum = data.Count - 1
        PrograssBar.Prograss.Minimum = 0
        PrograssBar.Show()
        Dim callback = Function() As Boolean
                         PrograssBar.Prograss.Increment(1)
                         Return True
                       End Function
        Await DB.Fill("Words", data, callback)
        PrograssBar.Hide()
        PrograssBar.Dispose()
        ShowNotice(Language.NoticeDBCreated)

        Application.Restart()
      Else
        ShowNotice(Language.NoticeDBOK)
      End If
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Sub AdamReader_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    Try
      If e.KeyCode = Keys.Add AndAlso e.Modifiers = Keys.Control Then
        Zoom("in")
      End If
      If e.KeyCode = Keys.Subtract AndAlso e.Modifiers = Keys.Control Then
        Zoom("out")
      End If
    Catch ex As Exception
      ShowNotice(ex.Message)
    End Try
  End Sub

  Private Async Sub TextContainer_DragDrop(sender As Object, e As DragEventArgs) Handles TextContainer.DragDrop
    Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
    If files.Length = 1 Then
      Dim file As String = files(0)
      file = file.ToLower()
      Await ImportEssay(file)
    Else
      ShowNotice(Language.NoticeOnlyOneFileDropable)
    End If
  End Sub

  Private Sub TextContainer_DragEnter(sender As Object, e As DragEventArgs) Handles TextContainer.DragEnter
    e.Effect = DragDropEffects.All
  End Sub
End Class
