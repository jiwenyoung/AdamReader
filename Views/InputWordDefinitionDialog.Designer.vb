<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputWordDefinitionDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputWordDefinitionDialog))
        Me.PromptText = New System.Windows.Forms.Label()
        Me.DefinitionInputBox = New System.Windows.Forms.TextBox()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DefinitionInputBoxUnderline = New System.Windows.Forms.Panel()
        Me.SelectedWord = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PromptText
        '
        Me.PromptText.AutoSize = True
        Me.PromptText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PromptText.Location = New System.Drawing.Point(75, 67)
        Me.PromptText.Name = "PromptText"
        Me.PromptText.Size = New System.Drawing.Size(117, 25)
        Me.PromptText.TabIndex = 0
        Me.PromptText.Text = "Definition of"
        '
        'DefinitionInputBox
        '
        Me.DefinitionInputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DefinitionInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DefinitionInputBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DefinitionInputBox.ForeColor = System.Drawing.Color.White
        Me.DefinitionInputBox.Location = New System.Drawing.Point(36, 129)
        Me.DefinitionInputBox.Name = "DefinitionInputBox"
        Me.DefinitionInputBox.Size = New System.Drawing.Size(500, 22)
        Me.DefinitionInputBox.TabIndex = 4
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.OKBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKBtn.FlatAppearance.BorderSize = 0
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.Location = New System.Drawing.Point(436, 177)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(100, 30)
        Me.OKBtn.TabIndex = 5
        Me.OKBtn.Text = "Confirm"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(330, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DefinitionInputBoxUnderline
        '
        Me.DefinitionInputBoxUnderline.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DefinitionInputBoxUnderline.Location = New System.Drawing.Point(36, 149)
        Me.DefinitionInputBoxUnderline.Name = "DefinitionInputBoxUnderline"
        Me.DefinitionInputBoxUnderline.Size = New System.Drawing.Size(500, 2)
        Me.DefinitionInputBoxUnderline.TabIndex = 7
        '
        'SelectedWord
        '
        Me.SelectedWord.AutoSize = True
        Me.SelectedWord.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SelectedWord.Location = New System.Drawing.Point(187, 67)
        Me.SelectedWord.Name = "SelectedWord"
        Me.SelectedWord.Size = New System.Drawing.Size(58, 25)
        Me.SelectedWord.TabIndex = 8
        Me.SelectedWord.Text = "Word"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'InputWordDefinitionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SelectedWord)
        Me.Controls.Add(Me.DefinitionInputBoxUnderline)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.DefinitionInputBox)
        Me.Controls.Add(Me.PromptText)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InputWordDefinitionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input the definition of this word"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PromptText As Label
    Friend WithEvents DefinitionInputBox As TextBox
    Friend WithEvents OKBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DefinitionInputBoxUnderline As Panel
    Friend WithEvents SelectedWord As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
