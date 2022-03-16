Public Class BookItem
  Dim id As Integer
  Dim ThisBookName As String

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
End Class