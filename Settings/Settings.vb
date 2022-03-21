Public Class Settings
  Private Shared Function ChooseColor() As Color
    Dim items As New List(Of String) From {
      "#5352ed",
      "#ff6348",
      "#ffa502",
      "#2980b9",
      "#d35400",
      "#8e44ad",
      "#c0392b",
      "#16a085"
    }
    Dim rand = New Random().Next(0, items.Count)
    Return ColorTranslator.FromHtml(items(rand))
  End Function

  Shared Property DatabaseFileName As String = "AdamReader.db"
  Shared Property BooksFolder As String = "Books"
  Shared Property DefaultFontSize As Single = 14
  Shared Property PrimaryColor As Color = ChooseColor()
End Class
