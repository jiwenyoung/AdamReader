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
        Me.Message = New System.Windows.Forms.Panel()
        Me.MessageText = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.RichTextBox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.DictionaryBuildBtn = New System.Windows.Forms.Button()
        Me.ZoomOutBtn = New System.Windows.Forms.Button()
        Me.ZoomInBtn = New System.Windows.Forms.Button()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.markBtn = New System.Windows.Forms.Button()
        Me.Bar.SuspendLayout()
        Me.SidebarTopBtnBox.SuspendLayout()
        Me.Body.SuspendLayout()
        Me.Message.SuspendLayout()
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
        Me.Body.Controls.Add(Me.Message)
        Me.Body.Controls.Add(Me.TextBox)
        Me.Body.Controls.Add(Me.Header)
        Me.Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body.Location = New System.Drawing.Point(0, 0)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(684, 629)
        Me.Body.TabIndex = 1
        '
        'Message
        '
        Me.Message.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Message.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Message.Controls.Add(Me.MessageText)
        Me.Message.Location = New System.Drawing.Point(-400, 579)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(400, 50)
        Me.Message.TabIndex = 0
        '
        'MessageText
        '
        Me.MessageText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MessageText.AutoSize = True
        Me.MessageText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MessageText.ForeColor = System.Drawing.Color.White
        Me.MessageText.Location = New System.Drawing.Point(165, 15)
        Me.MessageText.Name = "MessageText"
        Me.MessageText.Size = New System.Drawing.Size(71, 21)
        Me.MessageText.TabIndex = 0
        Me.MessageText.Text = "Message"
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.Header.Controls.Add(Me.DictionaryBuildBtn)
        Me.Header.Controls.Add(Me.ZoomOutBtn)
        Me.Header.Controls.Add(Me.ZoomInBtn)
        Me.Header.Controls.Add(Me.BookNameTextBox)
        Me.Header.Controls.Add(Me.resetBtn)
        Me.Header.Controls.Add(Me.Logo)
        Me.Header.Controls.Add(Me.markBtn)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(684, 50)
        Me.Header.TabIndex = 0
        '
        'DictionaryBuildBtn
        '
        Me.DictionaryBuildBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DictionaryBuildBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DictionaryBuildBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DictionaryBuildBtn.FlatAppearance.BorderSize = 0
        Me.DictionaryBuildBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DictionaryBuildBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DictionaryBuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DictionaryBuildBtn.ForeColor = System.Drawing.Color.White
        Me.DictionaryBuildBtn.Image = CType(resources.GetObject("DictionaryBuildBtn.Image"), System.Drawing.Image)
        Me.DictionaryBuildBtn.Location = New System.Drawing.Point(430, 10)
        Me.DictionaryBuildBtn.Name = "DictionaryBuildBtn"
        Me.DictionaryBuildBtn.Size = New System.Drawing.Size(30, 30)
        Me.DictionaryBuildBtn.TabIndex = 8
        Me.DictionaryBuildBtn.UseVisualStyleBackColor = False
        '
        'ZoomOutBtn
        '
        Me.ZoomOutBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZoomOutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ZoomOutBtn.FlatAppearance.BorderSize = 0
        Me.ZoomOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ZoomOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ZoomOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZoomOutBtn.ForeColor = System.Drawing.Color.White
        Me.ZoomOutBtn.Image = CType(resources.GetObject("ZoomOutBtn.Image"), System.Drawing.Image)
        Me.ZoomOutBtn.Location = New System.Drawing.Point(480, 10)
        Me.ZoomOutBtn.Name = "ZoomOutBtn"
        Me.ZoomOutBtn.Size = New System.Drawing.Size(30, 30)
        Me.ZoomOutBtn.TabIndex = 7
        Me.ZoomOutBtn.UseVisualStyleBackColor = False
        '
        'ZoomInBtn
        '
        Me.ZoomInBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZoomInBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ZoomInBtn.FlatAppearance.BorderSize = 0
        Me.ZoomInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ZoomInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ZoomInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZoomInBtn.ForeColor = System.Drawing.Color.White
        Me.ZoomInBtn.Image = CType(resources.GetObject("ZoomInBtn.Image"), System.Drawing.Image)
        Me.ZoomInBtn.Location = New System.Drawing.Point(530, 10)
        Me.ZoomInBtn.Name = "ZoomInBtn"
        Me.ZoomInBtn.Size = New System.Drawing.Size(30, 30)
        Me.ZoomInBtn.TabIndex = 6
        Me.ZoomInBtn.UseVisualStyleBackColor = False
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BookNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookNameTextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookNameTextBox.ForeColor = System.Drawing.Color.White
        Me.BookNameTextBox.Location = New System.Drawing.Point(75, 10)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(342, 28)
        Me.BookNameTextBox.TabIndex = 5
        Me.BookNameTextBox.Text = "Book Name"
        '
        'resetBtn
        '
        Me.resetBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.resetBtn.BackgroundImage = CType(resources.GetObject("resetBtn.BackgroundImage"), System.Drawing.Image)
        Me.resetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetBtn.FlatAppearance.BorderSize = 0
        Me.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.Location = New System.Drawing.Point(580, 10)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(30, 30)
        Me.resetBtn.TabIndex = 4
        Me.resetBtn.UseVisualStyleBackColor = False
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
        'markBtn
        '
        Me.markBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.markBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.markBtn.BackgroundImage = CType(resources.GetObject("markBtn.BackgroundImage"), System.Drawing.Image)
        Me.markBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.markBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.markBtn.FlatAppearance.BorderSize = 0
        Me.markBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.markBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.markBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.markBtn.Location = New System.Drawing.Point(630, 10)
        Me.markBtn.Name = "markBtn"
        Me.markBtn.Size = New System.Drawing.Size(30, 30)
        Me.markBtn.TabIndex = 1
        Me.markBtn.UseVisualStyleBackColor = False
        '
        'AdamReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Bar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 668)
        Me.Name = "AdamReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adam Reader"
        Me.Bar.ResumeLayout(False)
        Me.SidebarTopBtnBox.ResumeLayout(False)
        Me.Body.ResumeLayout(False)
        Me.Message.ResumeLayout(False)
        Me.Message.PerformLayout()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bar As Panel
    Friend WithEvents Body As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents markBtn As Button
    Friend WithEvents ImportBookBtn As Button
    Friend WithEvents TextBox As RichTextBox
    Friend WithEvents SidebarTopBtnBox As Panel
    Friend WithEvents DictionaryBtn As Button
    Friend WithEvents BookListBtn As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents DictUnderLine As Panel
    Friend WithEvents BooksUnderLine As Panel
    Friend WithEvents BarContent As FlowLayoutPanel
    Friend WithEvents resetBtn As Button
    Friend WithEvents MessageText As Label
    Friend WithEvents Message As Panel
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents ZoomInBtn As Button
    Friend WithEvents ZoomOutBtn As Button
    Friend WithEvents DictionaryBuildBtn As Button
End Class
