<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT_SECTION_GROUP
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EDIT_SECTION_GROUP))
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtshow = New System.Windows.Forms.TextBox()
        Me.txtidlocation = New System.Windows.Forms.TextBox()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.ListViewlocat = New System.Windows.Forms.ListView()
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListViewsection = New System.Windows.Forms.ListView()
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ListViewfloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewshowdata = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.LOCATION, Me.STATUS, Me.SERIAL})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(2, 58)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.Size = New System.Drawing.Size(773, 236)
        Me.DataGridViewX1.TabIndex = 390
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 2
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 2
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 140
        '
        'Column5
        '
        Me.Column5.HeaderText = "FLOOR"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "SECTION"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'LOCATION
        '
        Me.LOCATION.HeaderText = "LOCATION"
        Me.LOCATION.Name = "LOCATION"
        Me.LOCATION.Width = 70
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Width = 80
        '
        'SERIAL
        '
        Me.SERIAL.HeaderText = "SERIAL"
        Me.SERIAL.Name = "SERIAL"
        Me.SERIAL.Width = 150
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label67.Location = New System.Drawing.Point(660, 29)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(45, 26)
        Me.Label67.TabIndex = 389
        Me.Label67.Text = "Count"
        '
        'txtshow
        '
        Me.txtshow.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshow.Location = New System.Drawing.Point(711, 27)
        Me.txtshow.Name = "txtshow"
        Me.txtshow.ReadOnly = True
        Me.txtshow.Size = New System.Drawing.Size(54, 34)
        Me.txtshow.TabIndex = 388
        '
        'txtidlocation
        '
        Me.txtidlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtidlocation.Location = New System.Drawing.Point(1087, 375)
        Me.txtidlocation.Multiline = True
        Me.txtidlocation.Name = "txtidlocation"
        Me.txtidlocation.ReadOnly = True
        Me.txtidlocation.Size = New System.Drawing.Size(39, 32)
        Me.txtidlocation.TabIndex = 387
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(904, 375)
        Me.txtlocation.Multiline = True
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.ReadOnly = True
        Me.txtlocation.Size = New System.Drawing.Size(177, 32)
        Me.txtlocation.TabIndex = 380
        '
        'ListViewlocat
        '
        Me.ListViewlocat.BackColor = System.Drawing.Color.White
        Me.ListViewlocat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader1})
        Me.ListViewlocat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewlocat.FullRowSelect = True
        Me.ListViewlocat.GridLines = True
        Me.ListViewlocat.HideSelection = False
        Me.ListViewlocat.Location = New System.Drawing.Point(375, 300)
        Me.ListViewlocat.Name = "ListViewlocat"
        Me.ListViewlocat.Size = New System.Drawing.Size(360, 187)
        Me.ListViewlocat.TabIndex = 385
        Me.ListViewlocat.UseCompatibleStateImageBehavior = False
        Me.ListViewlocat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "ID"
        Me.ColumnHeader28.Width = 0
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "LOCATION"
        Me.ColumnHeader29.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Description"
        Me.ColumnHeader1.Width = 149
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(797, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 34)
        Me.Label4.TabIndex = 381
        Me.Label4.Text = "LOCATION :"
        '
        'ListViewsection
        '
        Me.ListViewsection.BackColor = System.Drawing.Color.White
        Me.ListViewsection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25})
        Me.ListViewsection.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewsection.FullRowSelect = True
        Me.ListViewsection.GridLines = True
        Me.ListViewsection.HideSelection = False
        Me.ListViewsection.Location = New System.Drawing.Point(132, 300)
        Me.ListViewsection.Name = "ListViewsection"
        Me.ListViewsection.Size = New System.Drawing.Size(237, 187)
        Me.ListViewsection.TabIndex = 384
        Me.ListViewsection.UseCompatibleStateImageBehavior = False
        Me.ListViewsection.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "ID"
        Me.ColumnHeader24.Width = 50
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "SECTION"
        Me.ColumnHeader25.Width = 180
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(904, 422)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(76, 42)
        Me.btnsave.TabIndex = 382
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'ListViewfloor
        '
        Me.ListViewfloor.BackColor = System.Drawing.Color.White
        Me.ListViewfloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListViewfloor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewfloor.FullRowSelect = True
        Me.ListViewfloor.GridLines = True
        Me.ListViewfloor.HideSelection = False
        Me.ListViewfloor.Location = New System.Drawing.Point(12, 300)
        Me.ListViewfloor.Name = "ListViewfloor"
        Me.ListViewfloor.Size = New System.Drawing.Size(114, 187)
        Me.ListViewfloor.TabIndex = 383
        Me.ListViewfloor.UseCompatibleStateImageBehavior = False
        Me.ListViewfloor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 40
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "FLOOR"
        Me.ColumnHeader12.Width = 70
        '
        'ListViewshowdata
        '
        Me.ListViewshowdata.BackColor = System.Drawing.Color.White
        Me.ListViewshowdata.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader16, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewshowdata.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewshowdata.FullRowSelect = True
        Me.ListViewshowdata.GridLines = True
        Me.ListViewshowdata.HideSelection = False
        Me.ListViewshowdata.Location = New System.Drawing.Point(826, 58)
        Me.ListViewshowdata.Name = "ListViewshowdata"
        Me.ListViewshowdata.Size = New System.Drawing.Size(336, 236)
        Me.ListViewshowdata.TabIndex = 379
        Me.ListViewshowdata.UseCompatibleStateImageBehavior = False
        Me.ListViewshowdata.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "TYPE"
        Me.ColumnHeader16.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NAME"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "STATUS"
        Me.ColumnHeader5.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 34)
        Me.Label1.TabIndex = 378
        Me.Label1.Text = "Search :"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(117, 26)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(389, 29)
        Me.txtsearch.TabIndex = 376
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(512, 21)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(69, 36)
        Me.btnsearch.TabIndex = 377
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(771, 191)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 386
        Me.PictureBox2.TabStop = False
        '
        'EDIT_SECTION_GROUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 740)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.txtshow)
        Me.Controls.Add(Me.txtidlocation)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ListViewlocat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListViewsection)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ListViewfloor)
        Me.Controls.Add(Me.ListViewshowdata)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EDIT_SECTION_GROUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDIT_SECTION_GROUP"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCATION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtshow As System.Windows.Forms.TextBox
    Friend WithEvents txtidlocation As System.Windows.Forms.TextBox
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListViewlocat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListViewsection As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ListViewfloor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewshowdata As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
End Class
