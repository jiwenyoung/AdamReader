Imports System.Collections.Generic
Imports System.Threading.Tasks

Public Class BookFile
  Property bookPath As String
  Property bookContent As String = ""
  Property bookName As String = ""

  Sub New(bookLocation As String)
    Me.bookPath = bookLocation
  End Sub

  Public Shared Function GetBookFilePath(thisBookFile As String) As String
    Dim currentPath = Environment.CurrentDirectory
    Dim subPath = Settings.booksFolder
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
    Dim subPath = Settings.booksFolder
    Dim booksFolder As String = IO.Path.Combine(currentPath, subPath)
    Return booksFolder
  End Function

  Public Async Function Read() As Task(Of String)
    Dim content As String = ""
    Dim fileReader As IO.StreamReader
    If IO.File.Exists(bookPath) Then
      fileReader = My.Computer.FileSystem.OpenTextFileReader(bookPath)
      content = Await fileReader.ReadToEndAsync()
      fileReader.Close()
    End If
    Return content
  End Function

  Public Async Function Write() As Task(Of Boolean)
    If bookContent <> "" And bookName <> "" Then
      Dim booksFolder As String = GetBooksFolder()
      If IO.Directory.Exists(booksFolder) = False Then
        IO.Directory.CreateDirectory(booksFolder)
      End If

      Dim bookFile As String = String.Format("{0}.txt", bookName)
      bookFile = IO.Path.Combine(booksFolder, bookFile)
      Dim fileWriter As IO.StreamWriter
      fileWriter = My.Computer.FileSystem.OpenTextFileWriter(bookFile, False)
      Await fileWriter.WriteAsync(bookContent)
      fileWriter.Close()
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Rename(newName As String) As Boolean
    Dim oldFile = Me.bookPath
    If IO.File.Exists(oldFile) Then
      newName = String.Format("{0}.txt", newName)
      My.Computer.FileSystem.RenameFile(oldFile, newName)
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Remove() As Boolean
    If IO.File.Exists(Me.bookPath) = True Then
      My.Computer.FileSystem.DeleteFile(Me.bookPath)
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
