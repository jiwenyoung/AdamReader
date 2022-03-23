Public Class Essay
  Public Shared Async Function Read(location As String) As Task(Of String)
    Dim content As String = ""
    Dim fileReader As IO.StreamReader
    If IO.File.Exists(location) Then
      fileReader = My.Computer.FileSystem.OpenTextFileReader(location)
      content = Await fileReader.ReadToEndAsync()
      fileReader.Close()
    End If
    Return content
  End Function
End Class