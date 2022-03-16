<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdamReader
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdamReader))
    Me.Bar = New System.Windows.Forms.Panel()
    Me.BarContent = New System.Windows.Forms.FlowLayoutPanel()
    Me.SidebarTopBtnBox = New System.Windows.Forms.Panel()
    Me.BooksUnderLine = New System.Windows.Forms.Panel()
    Me.DictUnderLine = New System.Windows.Forms.Panel()
    Me.BookListBtn = New System.Windows.Forms.Button()
    Me.DictionaryBtn = New System.Windows.Forms.Button()
    Me.ImportBookBtn = New System.Windows.Forms.Button()
    Me.Body = New System.Windows.Forms.Panel()
    Me.TextBox = New System.Windows.Forms.RichTextBox()
    Me.Header = New System.Windows.Forms.Panel()
    Me.BookName = New System.Windows.Forms.Label()
    Me.Logo = New System.Windows.Forms.PictureBox()
    Me.Mark = New System.Windows.Forms.Button()
        Me.Bar.SuspendLayout()
        Me.SidebarTopBtnBox.SuspendLayout()
        Me.Body.SuspendLayout()
        Me.Header.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar
        '
        Me.Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Bar.Controls.Add(Me.BarContent)
        Me.Bar.Controls.Add(Me.SidebarTopBtnBox)
        Me.Bar.Controls.Add(Me.ImportBookBtn)
        Me.Bar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bar.Location = New System.Drawing.Point(684, 0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(324, 629)
        Me.Bar.TabIndex = 0
        '
        'BarContent
        '
        Me.BarContent.AutoScroll = True
        Me.BarContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarContent.Location = New System.Drawing.Point(0, 50)
        Me.BarContent.Margin = New System.Windows.Forms.Padding(0)
        Me.BarContent.Name = "BarContent"
        Me.BarContent.Size = New System.Drawing.Size(324, 529)
        Me.BarContent.TabIndex = 2
        '
        'SidebarTopBtnBox
        '
        Me.SidebarTopBtnBox.Controls.Add(Me.BooksUnderLine)
        Me.SidebarTopBtnBox.Controls.Add(Me.DictUnderLine)
        Me.SidebarTopBtnBox.Controls.Add(Me.BookListBtn)
        Me.SidebarTopBtnBox.Controls.Add(Me.DictionaryBtn)
        Me.SidebarTopBtnBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidebarTopBtnBox.Location = New System.Drawing.Point(0, 0)
        Me.SidebarTopBtnBox.Name = "SidebarTopBtnBox"
        Me.SidebarTopBtnBox.Size = New System.Drawing.Size(324, 50)
        Me.SidebarTopBtnBox.TabIndex = 1
        '
        'BooksUnderLine
        '
        Me.BooksUnderLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BooksUnderLine.Location = New System.Drawing.Point(162, 48)
        Me.BooksUnderLine.Name = "BooksUnderLine"
        Me.BooksUnderLine.Size = New System.Drawing.Size(162, 2)
        Me.BooksUnderLine.TabIndex = 2
        '
        'DictUnderLine
        '
        Me.DictUnderLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DictUnderLine.Location = New System.Drawing.Point(0, 48)
        Me.DictUnderLine.Name = "DictUnderLine"
        Me.DictUnderLine.Size = New System.Drawing.Size(162, 2)
        Me.DictUnderLine.TabIndex = 4
        '
        'BookListBtn
        '
        Me.BookListBtn.BackgroundImage = CType(resources.GetObject("BookListBtn.BackgroundImage"), System.Drawing.Image)
        Me.BookListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BookListBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookListBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookListBtn.FlatAppearance.BorderSize = 0
        Me.BookListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookListBtn.Location = New System.Drawing.Point(162, 0)
        Me.BookListBtn.Name = "BookListBtn"
        Me.BookListBtn.Size = New System.Drawing.Size(162, 50)
        Me.BookListBtn.TabIndex = 1
        Me.BookListBtn.UseVisualStyleBackColor = True
        '
        'DictionaryBtn
        '
        Me.DictionaryBtn.BackgroundImage = CType(resources.GetObject("DictionaryBtn.BackgroundImage"), System.Drawing.Image)
        Me.DictionaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DictionaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DictionaryBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.DictionaryBtn.FlatAppearance.BorderSize = 0
        Me.DictionaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DictionaryBtn.Location = New System.Drawing.Point(0, 0)
        Me.DictionaryBtn.Name = "DictionaryBtn"
        Me.DictionaryBtn.Size = New System.Drawing.Size(162, 50)
        Me.DictionaryBtn.TabIndex = 0
        Me.DictionaryBtn.UseVisualStyleBackColor = True
        '
        'ImportBookBtn
        '
        Me.ImportBookBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ImportBookBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImportBookBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ImportBookBtn.FlatAppearance.BorderSize = 0
        Me.ImportBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImportBookBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ImportBookBtn.ForeColor = System.Drawing.Color.White
        Me.ImportBookBtn.Image = CType(resources.GetObject("ImportBookBtn.Image"), System.Drawing.Image)
        Me.ImportBookBtn.Location = New System.Drawing.Point(0, 579)
        Me.ImportBookBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ImportBookBtn.Name = "ImportBookBtn"
        Me.ImportBookBtn.Size = New System.Drawing.Size(324, 50)
        Me.ImportBookBtn.TabIndex = 0
        Me.ImportBookBtn.Text = "  IMPORT"
        Me.ImportBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImportBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ImportBookBtn.UseVisualStyleBackColor = False
        '
        'Body
        '
        Me.Body.BackColor = System.Drawing.Color.DimGray
        Me.Body.Controls.Add(Me.TextBox)
        Me.Body.Controls.Add(Me.Header)
        Me.Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body.Location = New System.Drawing.Point(0, 0)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(684, 629)
        Me.Body.TabIndex = 1
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox.ForeColor = System.Drawing.Color.White
        Me.TextBox.Location = New System.Drawing.Point(0, 50)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(684, 579)
        Me.TextBox.TabIndex = 2
        Me.TextBox.Text = ""
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Header.Controls.Add(Me.BookName)
        Me.Header.Controls.Add(Me.Logo)
        Me.Header.Controls.Add(Me.Mark)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(684, 50)
        Me.Header.TabIndex = 0
        '
        'BookName
        '
        Me.BookName.AutoSize = True
        Me.BookName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookName.ForeColor = System.Drawing.Color.White
        Me.BookName.Location = New System.Drawing.Point(77, 10)
        Me.BookName.Name = "BookName"
        Me.BookName.Size = New System.Drawing.Size(73, 30)
        Me.BookName.TabIndex = 3
        Me.BookName.Text = "Label1"
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(30, 10)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(30, 30)
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'Mark
        '
        Me.Mark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mark.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Mark.BackgroundImage = CType(resources.GetObject("Mark.BackgroundImage"), System.Drawing.Image)
        Me.Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Mark.FlatAppearance.BorderSize = 0
        Me.Mark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Mark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mark.Location = New System.Drawing.Point(630, 10)
        Me.Mark.Name = "Mark"
        Me.Mark.Size = New System.Drawing.Size(30, 30)
        Me.Mark.TabIndex = 1
        Me.Mark.UseVisualStyleBackColor = False
        '
        'AdamReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Bar)
        Me.MinimumSize = New System.Drawing.Size(1024, 668)
        Me.Name = "AdamReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adam Reader"
        Me.Bar.ResumeLayout(False)
        Me.SidebarTopBtnBox.ResumeLayout(False)
        Me.Body.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bar As Panel
  Friend WithEvents Body As Panel
  Friend WithEvents Header As Panel
  Friend WithEvents Mark As Button
  Friend WithEvents ImportBookBtn As Button
  Friend WithEvents TextBox As RichTextBox
  Friend WithEvents SidebarTopBtnBox As Panel
  Friend WithEvents DictionaryBtn As Button
  Friend WithEvents BookListBtn As Button
  Friend WithEvents Logo As PictureBox
  Friend WithEvents BookName As Label
  Friend WithEvents DictUnderLine As Panel
  Friend WithEvents BooksUnderLine As Panel
  Friend WithEvents BarContent As FlowLayoutPanel
End Class
