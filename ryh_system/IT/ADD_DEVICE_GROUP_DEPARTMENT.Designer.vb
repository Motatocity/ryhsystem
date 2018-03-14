<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_DEVICE_GROUP_DEPARTMENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_DEVICE_GROUP_DEPARTMENT))
        Me.txtidlocation = New System.Windows.Forms.TextBox()
        Me.ListViewlocat = New System.Windows.Forms.ListView()
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListViewsection = New System.Windows.Forms.ListView()
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.ListViewfloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.ListViewshow = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewshowdata = New System.Windows.Forms.ListView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidlocation
        '
        Me.txtidlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidlocation.Location = New System.Drawing.Point(1131, 441)
        Me.txtidlocation.Multiline = True
        Me.txtidlocation.Name = "txtidlocation"
        Me.txtidlocation.ReadOnly = True
        Me.txtidlocation.Size = New System.Drawing.Size(56, 32)
        Me.txtidlocation.TabIndex = 371
        '
        'ListViewlocat
        '
        Me.ListViewlocat.BackColor = System.Drawing.Color.White
        Me.ListViewlocat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader28, Me.ColumnHeader29})
        Me.ListViewlocat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewlocat.FullRowSelect = True
        Me.ListViewlocat.GridLines = True
        Me.ListViewlocat.HideSelection = False
        Me.ListViewlocat.Location = New System.Drawing.Point(399, 312)
        Me.ListViewlocat.Name = "ListViewlocat"
        Me.ListViewlocat.Size = New System.Drawing.Size(254, 180)
        Me.ListViewlocat.TabIndex = 370
        Me.ListViewlocat.UseCompatibleStateImageBehavior = False
        Me.ListViewlocat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "ID"
        Me.ColumnHeader28.Width = 50
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "LOCATION"
        Me.ColumnHeader29.Width = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(723, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 366
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
        Me.ListViewsection.Location = New System.Drawing.Point(146, 312)
        Me.ListViewsection.Name = "ListViewsection"
        Me.ListViewsection.Size = New System.Drawing.Size(236, 180)
        Me.ListViewsection.TabIndex = 369
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
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnsave.Location = New System.Drawing.Point(1006, 347)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(76, 42)
        Me.btnsave.TabIndex = 367
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtsearch.Location = New System.Drawing.Point(90, 21)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(303, 22)
        Me.txtsearch.TabIndex = 360
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(408, 12)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(69, 36)
        Me.btnsearch.TabIndex = 361
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'ListViewfloor
        '
        Me.ListViewfloor.BackColor = System.Drawing.Color.White
        Me.ListViewfloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListViewfloor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewfloor.FullRowSelect = True
        Me.ListViewfloor.GridLines = True
        Me.ListViewfloor.HideSelection = False
        Me.ListViewfloor.Location = New System.Drawing.Point(9, 312)
        Me.ListViewfloor.Name = "ListViewfloor"
        Me.ListViewfloor.Size = New System.Drawing.Size(117, 180)
        Me.ListViewfloor.TabIndex = 368
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "Search :"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "STATUS"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "NAME"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TYPE"
        Me.ColumnHeader2.Width = 58
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtlocation.Location = New System.Drawing.Point(808, 309)
        Me.txtlocation.Multiline = True
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.ReadOnly = True
        Me.txtlocation.Size = New System.Drawing.Size(262, 32)
        Me.txtlocation.TabIndex = 365
        '
        'ListViewshow
        '
        Me.ListViewshow.BackColor = System.Drawing.Color.White
        Me.ListViewshow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader13})
        Me.ListViewshow.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewshow.FullRowSelect = True
        Me.ListViewshow.GridLines = True
        Me.ListViewshow.HideSelection = False
        Me.ListViewshow.Location = New System.Drawing.Point(13, 76)
        Me.ListViewshow.Name = "ListViewshow"
        Me.ListViewshow.Size = New System.Drawing.Size(554, 217)
        Me.ListViewshow.TabIndex = 364
        Me.ListViewshow.UseCompatibleStateImageBehavior = False
        Me.ListViewshow.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DETAIL"
        Me.ColumnHeader9.Width = 135
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "STATUS"
        Me.ColumnHeader10.Width = 61
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "SERIAL NUMBER"
        Me.ColumnHeader13.Width = 114
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DETAIL"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NAME"
        Me.ColumnHeader5.Width = 83
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TYPE"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 51
        '
        'ListViewshowdata
        '
        Me.ListViewshowdata.BackColor = System.Drawing.Color.White
        Me.ListViewshowdata.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListViewshowdata.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewshowdata.FullRowSelect = True
        Me.ListViewshowdata.GridLines = True
        Me.ListViewshowdata.HideSelection = False
        Me.ListViewshowdata.Location = New System.Drawing.Point(629, 76)
        Me.ListViewshowdata.Name = "ListViewshowdata"
        Me.ListViewshowdata.Size = New System.Drawing.Size(462, 227)
        Me.ListViewshowdata.TabIndex = 363
        Me.ListViewshowdata.UseCompatibleStateImageBehavior = False
        Me.ListViewshowdata.View = System.Windows.Forms.View.Details
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(570, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 372
        Me.PictureBox2.TabStop = False
        '
        'ADD_DEVICE_GROUP_DEPARTMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 544)
        Me.Controls.Add(Me.txtidlocation)
        Me.Controls.Add(Me.ListViewlocat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListViewsection)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.ListViewfloor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.ListViewshow)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ListViewshowdata)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADD_DEVICE_GROUP_DEPARTMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD_DEVICE_GROUP_DEPARTMENT"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtidlocation As System.Windows.Forms.TextBox
    Friend WithEvents ListViewlocat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListViewsection As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents ListViewfloor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents ListViewshow As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListViewshowdata As System.Windows.Forms.ListView
End Class
