<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DictionaryContent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DictionaryContent))
    Me.ChinieseLabel = New System.Windows.Forms.Label()
    Me.ChinieseText = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EditDefinitionBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChinieseLabel
        '
        Me.ChinieseLabel.AutoSize = True
        Me.ChinieseLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChinieseLabel.ForeColor = System.Drawing.Color.White
        Me.ChinieseLabel.Location = New System.Drawing.Point(36, 40)
        Me.ChinieseLabel.Name = "ChinieseLabel"
        Me.ChinieseLabel.Size = New System.Drawing.Size(84, 25)
        Me.ChinieseLabel.TabIndex = 0
        Me.ChinieseLabel.Text = "Chiniese"
        '
        'ChinieseText
        '
        Me.ChinieseText.BackColor = System.Drawing.Color.Transparent
        Me.ChinieseText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChinieseText.ForeColor = System.Drawing.Color.White
        Me.ChinieseText.Location = New System.Drawing.Point(36, 91)
        Me.ChinieseText.Name = "ChinieseText"
        Me.ChinieseText.Size = New System.Drawing.Size(246, 397)
        Me.ChinieseText.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'EditDefinitionBtn
        '
        Me.EditDefinitionBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditDefinitionBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditDefinitionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditDefinitionBtn.FlatAppearance.BorderSize = 0
        Me.EditDefinitionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditDefinitionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditDefinitionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditDefinitionBtn.Image = CType(resources.GetObject("EditDefinitionBtn.Image"), System.Drawing.Image)
        Me.EditDefinitionBtn.Location = New System.Drawing.Point(239, 40)
        Me.EditDefinitionBtn.Name = "EditDefinitionBtn"
        Me.EditDefinitionBtn.Size = New System.Drawing.Size(20, 20)
        Me.EditDefinitionBtn.TabIndex = 2
        Me.EditDefinitionBtn.UseVisualStyleBackColor = True
        '
        'DictionaryContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(324, 568)
        Me.Controls.Add(Me.EditDefinitionBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChinieseText)
        Me.Controls.Add(Me.ChinieseLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DictionaryContent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DictionaryContent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChinieseLabel As Label
    Friend WithEvents ChinieseText As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EditDefinitionBtn As Button
End Class
