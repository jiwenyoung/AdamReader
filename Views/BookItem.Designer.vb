<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookItem
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookItem))
    Me.RemoveBtn = New System.Windows.Forms.PictureBox()
    Me.BookName = New System.Windows.Forms.Label()
    CType(Me.RemoveBtn, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'RemoveBtn
    '
    Me.RemoveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.RemoveBtn.Image = CType(resources.GetObject("RemoveBtn.Image"), System.Drawing.Image)
    Me.RemoveBtn.Location = New System.Drawing.Point(282, 13)
    Me.RemoveBtn.Name = "RemoveBtn"
    Me.RemoveBtn.Size = New System.Drawing.Size(20, 20)
    Me.RemoveBtn.TabIndex = 1
    Me.RemoveBtn.TabStop = False
    '
    'BookName
    '
    Me.BookName.AutoSize = True
    Me.BookName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
    Me.BookName.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.BookName.Location = New System.Drawing.Point(12, 13)
    Me.BookName.Name = "BookName"
    Me.BookName.Size = New System.Drawing.Size(91, 21)
    Me.BookName.TabIndex = 3
    Me.BookName.Text = "Book Name"
    '
    'BookItem
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(324, 50)
    Me.Controls.Add(Me.BookName)
    Me.Controls.Add(Me.RemoveBtn)
    Me.Cursor = System.Windows.Forms.Cursors.Hand
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "BookItem"
    Me.Text = "BookItem"
    CType(Me.RemoveBtn, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents RemoveBtn As PictureBox
  Friend WithEvents BookName As Label
End Class
