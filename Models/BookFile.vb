Imports System.Collections.Generic

Public Class BookFile
  Public Shared Async Function read(bookPath As String) As Task(Of List(Of String))
    Dim content = New List(Of String)
    Dim fileReader As System.IO.StreamReader
    fileReader = My.Computer.FileSystem.OpenTextFileReader(bookPath)
    Dim line As String
    While fileReader.Peek() <> -1
      line = Await fileReader.ReadLineAsync()
      content.Add(line)
    End While
    Return content
  End Function
End Class
