Public Class Settings
  Private Shared Function chooseColor() As Color
    Dim items As List(Of String) = New List(Of String)
    items.Add("#5352ed")
    items.Add("#ff6348")
    items.Add("#ffa502")
    items.Add("#2980b9")
    items.Add("#d35400")
    items.Add("#8e44ad")
    items.Add("#c0392b")
    items.Add("#16a085")
    Dim rand = New Random().Next(0, items.Count)
    Return ColorTranslator.FromHtml(items(rand))
  End Function

  Shared Property databaseFileName As String = "AdamReader.db"
  Shared Property booksFolder As String = "Books"
  Shared Property defaultFontSize As Single = 14
  Shared Property primaryColor As Color = chooseColor()

End Class
