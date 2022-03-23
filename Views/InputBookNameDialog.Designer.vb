<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBookNameDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputBookNameDialog))
        Me.BookNamePrompt = New System.Windows.Forms.Label()
        Me.BookNameInputBox = New System.Windows.Forms.TextBox()
        Me.BookNameInputBoxUnderLine = New System.Windows.Forms.Panel()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BookNamePrompt
        '
        Me.BookNamePrompt.AutoSize = True
        Me.BookNamePrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookNamePrompt.ForeColor = System.Drawing.Color.White
        Me.BookNamePrompt.Location = New System.Drawing.Point(37, 25)
        Me.BookNamePrompt.Name = "BookNamePrompt"
        Me.BookNamePrompt.Size = New System.Drawing.Size(91, 21)
        Me.BookNamePrompt.TabIndex = 0
        Me.BookNamePrompt.Text = "Book Name"
        '
        'BookNameInputBox
        '
        Me.BookNameInputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BookNameInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookNameInputBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookNameInputBox.ForeColor = System.Drawing.Color.White
        Me.BookNameInputBox.Location = New System.Drawing.Point(37, 68)
        Me.BookNameInputBox.Name = "BookNameInputBox"
        Me.BookNameInputBox.Size = New System.Drawing.Size(309, 22)
        Me.BookNameInputBox.TabIndex = 1
        '
        'BookNameInputBoxUnderLine
        '
        Me.BookNameInputBoxUnderLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BookNameInputBoxUnderLine.Location = New System.Drawing.Point(37, 88)
        Me.BookNameInputBoxUnderLine.Name = "BookNameInputBoxUnderLine"
        Me.BookNameInputBoxUnderLine.Size = New System.Drawing.Size(309, 2)
        Me.BookNameInputBoxUnderLine.TabIndex = 2
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.OKBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKBtn.FlatAppearance.BorderSize = 0
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.ForeColor = System.Drawing.Color.White
        Me.OKBtn.Location = New System.Drawing.Point(264, 100)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(80, 35)
        Me.OKBtn.TabIndex = 3
        Me.OKBtn.Text = "Confirmed"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Location = New System.Drawing.Point(178, 100)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(80, 35)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'InputBookNameDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.BookNameInputBoxUnderLine)
        Me.Controls.Add(Me.BookNameInputBox)
        Me.Controls.Add(Me.BookNamePrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "InputBookNameDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Input Book Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookNamePrompt As Label
    Friend WithEvents BookNameInputBox As TextBox
    Friend WithEvents BookNameInputBoxUnderLine As Panel
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
