<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHOW_HISTORY_DEVICE
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtedit = New System.Windows.Forms.TextBox()
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ListViewshowdevice = New System.Windows.Forms.ListView()
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lost = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnSuccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListViewshowhis = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(646, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 26)
        Me.Label8.TabIndex = 384
        Me.Label8.Text = "HISTORY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 26)
        Me.Label6.TabIndex = 383
        Me.Label6.Text = "Count :"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtamount.Location = New System.Drawing.Point(75, 122)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(181, 26)
        Me.txtamount.TabIndex = 382
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(846, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 26)
        Me.Label1.TabIndex = 381
        Me.Label1.Text = "ID :"
        '
        'txtedit
        '
        Me.txtedit.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtedit.Location = New System.Drawing.Point(882, 491)
        Me.txtedit.Name = "txtedit"
        Me.txtedit.ReadOnly = True
        Me.txtedit.Size = New System.Drawing.Size(57, 34)
        Me.txtedit.TabIndex = 380
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "HISTORY"
        Me.ColumnHeader33.Width = 180
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(945, 488)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 39)
        Me.btnsave.TabIndex = 379
        Me.btnsave.Text = "Blank"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'ListViewshowdevice
        '
        Me.ListViewshowdevice.BackColor = System.Drawing.Color.White
        Me.ListViewshowdevice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader33, Me.ColumnHeader38})
        Me.ListViewshowdevice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewshowdevice.FullRowSelect = True
        Me.ListViewshowdevice.GridLines = True
        Me.ListViewshowdevice.HideSelection = False
        Me.ListViewshowdevice.Location = New System.Drawing.Point(631, 242)
        Me.ListViewshowdevice.Name = "ListViewshowdevice"
        Me.ListViewshowdevice.Size = New System.Drawing.Size(389, 240)
        Me.ListViewshowdevice.TabIndex = 378
        Me.ListViewshowdevice.UseCompatibleStateImageBehavior = False
        Me.ListViewshowdevice.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "DATE"
        Me.ColumnHeader38.Width = 200
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridViewX1.ContextMenuStrip = Me.ContextMenuStrip2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(286, 9)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.ShowRowErrors = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(799, 193)
        Me.DataGridViewX1.TabIndex = 390
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "DETAIL"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 270
        '
        'Column5
        '
        Me.Column5.HeaderText = "STAT"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "SECTION"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "SERIAL NUMBER"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 160
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.MinimumWidth = 2
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 2
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.delete, Me.Edit, Me.Transfer, Me.Lost, Me.CompleteToolStripMenuItem, Me.UnSuccessToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(135, 136)
        '
        'delete
        '
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(134, 22)
        Me.delete.Text = "Delete"
        '
        'Edit
        '
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(134, 22)
        Me.Edit.Text = "Edit"
        '
        'Transfer
        '
        Me.Transfer.Name = "Transfer"
        Me.Transfer.Size = New System.Drawing.Size(134, 22)
        Me.Transfer.Text = "Transfer"
        '
        'Lost
        '
        Me.Lost.Name = "Lost"
        Me.Lost.Size = New System.Drawing.Size(134, 22)
        Me.Lost.Text = "Lost"
        '
        'CompleteToolStripMenuItem
        '
        Me.CompleteToolStripMenuItem.Name = "CompleteToolStripMenuItem"
        Me.CompleteToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CompleteToolStripMenuItem.Text = "Complete"
        '
        'UnSuccessToolStripMenuItem
        '
        Me.UnSuccessToolStripMenuItem.Name = "UnSuccessToolStripMenuItem"
        Me.UnSuccessToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.UnSuccessToolStripMenuItem.Text = "Incomplete"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListViewshowhis)
        Me.GroupBox3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(614, 274)
        Me.GroupBox3.TabIndex = 391
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Show History"
        '
        'ListViewshowhis
        '
        Me.ListViewshowhis.BackColor = System.Drawing.Color.White
        Me.ListViewshowhis.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewshowhis.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewshowhis.FullRowSelect = True
        Me.ListViewshowhis.GridLines = True
        Me.ListViewshowhis.HideSelection = False
        Me.ListViewshowhis.Location = New System.Drawing.Point(16, 31)
        Me.ListViewshowhis.Name = "ListViewshowhis"
        Me.ListViewshowhis.Size = New System.Drawing.Size(583, 226)
        Me.ListViewshowhis.TabIndex = 349
        Me.ListViewshowhis.UseCompatibleStateImageBehavior = False
        Me.ListViewshowhis.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 32
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PROBLEM"
        Me.ColumnHeader6.Width = 188
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SLOVE"
        Me.ColumnHeader7.Width = 250
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DATE"
        Me.ColumnHeader8.Width = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(8, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 373
        Me.Label4.Text = "LOCATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 374
        Me.Label2.Text = "SECTION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 376
        Me.Label7.Text = "FLOOR"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(75, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox1.TabIndex = 387
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(75, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox2.TabIndex = 388
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(75, 80)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(205, 21)
        Me.ComboBox3.TabIndex = 389
        '
        'SHOW_HISTORY_DEVICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1292, 584)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ListViewshowdevice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SHOW_HISTORY_DEVICE"
        Me.Text = "SHOW_HISTORY_DEVICE"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtedit As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ListViewshowdevice As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewshowhis As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Transfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnSuccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
