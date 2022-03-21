Imports System.Collections.Generic
Imports System.Threading.Tasks

Public Class BookFile
  Property BookPath As String
  Property BookContent As String = ""
  Property BookName As String = ""

  Sub New(bookLocation As String)
    Me.BookPath = bookLocation
  End Sub

  Public Shared Function GetBookFilePath(thisBookFile As String) As String
    Dim currentPath = Environment.CurrentDirectory
    Dim subPath = Settings.BooksFolder
    Dim booksFolder As String = IO.Path.Combine(currentPath, subPath)
    If IO.Directory.Exists(booksFolder) Then
      Dim bookFile As String = String.Format("{0}.txt", thisBookFile)
      bookFile = IO.Path.Combine(booksFolder, bookFile)
      Return bookFile
    Else
      Return ""
    End If
  End Function

  Public Shared Function GetBooksFolder() As String
    Dim currentPath = Environment.CurrentDirectory
    Dim subPath = Settings.BooksFolder
    Dim booksFolder As String = IO.Path.Combine(currentPath, subPath)
    Return booksFolder
  End Function

  Public Async Function Read() As Task(Of String)
    Dim content As String = ""
    Dim fileReader As IO.StreamReader
    If IO.File.Exists(BookPath) Then
      fileReader = My.Computer.FileSystem.OpenTextFileReader(BookPath)
      content = Await fileReader.ReadToEndAsync()
      fileReader.Close()
    End If
    Return content
  End Function

  Public Async Function Write() As Task(Of Boolean)
    If BookContent <> "" And BookName <> "" Then
      Dim booksFolder As String = GetBooksFolder()
      If IO.Directory.Exists(booksFolder) = False Then
        IO.Directory.CreateDirectory(booksFolder)
      End If

      Dim bookFile As String = String.Format("{0}.txt", BookName)
      bookFile = IO.Path.Combine(booksFolder, bookFile)
      Dim fileWriter As IO.StreamWriter
      fileWriter = My.Computer.FileSystem.OpenTextFileWriter(bookFile, False)
      Await fileWriter.WriteAsync(BookContent)
      fileWriter.Close()
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Rename(newName As String) As Boolean
    Dim oldFile = Me.BookPath
    If IO.File.Exists(oldFile) Then
      newName = String.Format("{0}.txt", newName)
      My.Computer.FileSystem.RenameFile(oldFile, newName)
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Remove() As Boolean
    If IO.File.Exists(Me.BookPath) = True Then
      My.Computer.FileSystem.DeleteFile(Me.BookPath)
      Return True
    Else
      Return False
    End If
  End Function

  Public Shared Function Destroy() As Boolean
    Dim booksFolder As String = GetBooksFolder()
    IO.Directory.Delete(booksFolder, True)
    Return True
  End Function
End Class
