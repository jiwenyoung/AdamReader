Imports System.Collections.Generic

Public Class Book
  ReadOnly DB As Database = AdamReader.DB
  ReadOnly name As String

  Sub New(bookname As String)
    Me.name = bookname
  End Sub

  Public Shared Async Function Fetch(name As String) As Task(Of String)
    Dim DB As Database = AdamReader.DB
    Dim currentPath As String = Environment.CurrentDirectory
    Dim whereToSaveBooks As String = Settings.BooksFolder
    Dim bookFolder As String = IO.Path.Combine(currentPath, whereToSaveBooks)
    Dim fileName As String = String.Format("{0}.txt", name)
    Dim fileFullPath = IO.Path.Combine(bookFolder, fileName)
    Dim content As String = ""
    If IO.File.Exists(fileFullPath) = True Then
      Dim fileReader As IO.StreamReader
      fileReader = My.Computer.FileSystem.OpenTextFileReader(fileFullPath)
      content = Await fileReader.ReadToEndAsync()
      fileReader.Close()
    End If
    Return content
  End Function

  Public Shared Async Function Rename(bookId As String, oldName As String, newName As String) As Task(Of String)
    Dim DB As Database = AdamReader.DB
    newName = newName.Trim()
    If Await DB.Update("Books", "BookName", newName, bookId) Then
      Dim thisBookFilePath As String = BookFile.GetBookFilePath(oldName)
      Debug.WriteLine(thisBookFilePath)
      Dim thisBookFile As New BookFile(thisBookFilePath)
      If thisBookFile.Rename(newName) Then
        Return newName
      Else
        Return ""
      End If
    Else
      Return ""
    End If
  End Function

  Public Async Function Save() As Task(Of Boolean)
    Dim data As New Dictionary(Of String, String) From {
      {"BookName", name},
      {"BookMark", 1}
    }
    Await DB.Insert("Books", data)
    Return True
  End Function

End Class
