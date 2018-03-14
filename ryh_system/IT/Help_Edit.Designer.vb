<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_Edit
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListViewbacklog = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnxclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnxdelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnxsave = New DevComponents.DotNetBar.ButtonX()
        Me.txtnameedit = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxlocation = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxtypeproedit = New System.Windows.Forms.ComboBox()
        Me.txteditproedit = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtproedit = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxoffedit = New System.Windows.Forms.ComboBox()
        Me.txtidedit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxstatedit = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewhelp2 = New System.Windows.Forms.ListView()
        Me.name_container = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.agent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListViewbacklog)
        Me.GroupBox3.Location = New System.Drawing.Point(667, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 319)
        Me.GroupBox3.TabIndex = 408
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BACKLOG"
        '
        'ListViewbacklog
        '
        Me.ListViewbacklog.BackColor = System.Drawing.Color.White
        Me.ListViewbacklog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewbacklog.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewbacklog.FullRowSelect = True
        Me.ListViewbacklog.GridLines = True
        Me.ListViewbacklog.HideSelection = False
        Me.ListViewbacklog.Location = New System.Drawing.Point(6, 19)
        Me.ListViewbacklog.Name = "ListViewbacklog"
        Me.ListViewbacklog.Size = New System.Drawing.Size(277, 276)
        Me.ListViewbacklog.TabIndex = 407
        Me.ListViewbacklog.UseCompatibleStateImageBehavior = False
        Me.ListViewbacklog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "BACKLOG"
        Me.ColumnHeader8.Width = 220
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnxclear)
        Me.GroupBox2.Controls.Add(Me.btnxdelete)
        Me.GroupBox2.Controls.Add(Me.btnxsave)
        Me.GroupBox2.Controls.Add(Me.txtnameedit)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.ComboBoxlocation)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ComboBoxtypeproedit)
        Me.GroupBox2.Controls.Add(Me.txteditproedit)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtproedit)
        Me.GroupBox2.Controls.Add(Me.ComboBoxoffedit)
        Me.GroupBox2.Controls.Add(Me.txtidedit)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBoxstatedit)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 308)
        Me.GroupBox2.TabIndex = 407
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EDIT"
        '
        'btnxclear
        '
        Me.btnxclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxclear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxclear.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnxclear.Location = New System.Drawing.Point(216, 269)
        Me.btnxclear.Name = "btnxclear"
        Me.btnxclear.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnxclear.Size = New System.Drawing.Size(73, 32)
        Me.btnxclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnxclear.Symbol = ""
        Me.btnxclear.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnxclear.TabIndex = 406
        Me.btnxclear.Text = "Clear"
        '
        'btnxdelete
        '
        Me.btnxdelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxdelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxdelete.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnxdelete.Location = New System.Drawing.Point(295, 269)
        Me.btnxdelete.Name = "btnxdelete"
        Me.btnxdelete.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnxdelete.Size = New System.Drawing.Size(73, 32)
        Me.btnxdelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnxdelete.Symbol = ""
        Me.btnxdelete.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnxdelete.TabIndex = 405
        Me.btnxdelete.Text = "Delete"
        '
        'btnxsave
        '
        Me.btnxsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxsave.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnxsave.Location = New System.Drawing.Point(135, 269)
        Me.btnxsave.Name = "btnxsave"
        Me.btnxsave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnxsave.Size = New System.Drawing.Size(75, 32)
        Me.btnxsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnxsave.Symbol = ""
        Me.btnxsave.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnxsave.TabIndex = 404
        Me.btnxsave.Text = "Save"
        '
        'txtnameedit
        '
        Me.txtnameedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtnameedit.Location = New System.Drawing.Point(129, 38)
        Me.txtnameedit.Name = "txtnameedit"
        Me.txtnameedit.Size = New System.Drawing.Size(241, 22)
        Me.txtnameedit.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(72, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 324
        Me.Label18.Text = "USER :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(81, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 331
        Me.Label15.Text = "JOB :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(43, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 333
        Me.Label14.Text = "LOCATION :"
        '
        'ComboBoxlocation
        '
        Me.ComboBoxlocation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxlocation.FormattingEnabled = True
        Me.ComboBoxlocation.Location = New System.Drawing.Point(130, 87)
        Me.ComboBoxlocation.Name = "ComboBoxlocation"
        Me.ComboBoxlocation.Size = New System.Drawing.Size(239, 21)
        Me.ComboBoxlocation.TabIndex = 386
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(47, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 334
        Me.Label13.Text = "PROBLEM :"
        '
        'ComboBoxtypeproedit
        '
        Me.ComboBoxtypeproedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxtypeproedit.FormattingEnabled = True
        Me.ComboBoxtypeproedit.Items.AddRange(New Object() {"คอมพิวเตอร์", "เครื่องพิมพ์", "เครื่องสแกน", "กล้องวงจรปิด", "Network", "INTERNET", "Hims", "LAB", "X-RAY", "SERVER", "อื่นๆ"})
        Me.ComboBoxtypeproedit.Location = New System.Drawing.Point(129, 63)
        Me.ComboBoxtypeproedit.Name = "ComboBoxtypeproedit"
        Me.ComboBoxtypeproedit.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxtypeproedit.TabIndex = 3
        '
        'txteditproedit
        '
        Me.txteditproedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txteditproedit.Location = New System.Drawing.Point(129, 165)
        Me.txteditproedit.Name = "txteditproedit"
        Me.txteditproedit.Size = New System.Drawing.Size(240, 51)
        Me.txteditproedit.TabIndex = 7
        Me.txteditproedit.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(53, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 335
        Me.Label12.Text = "OFFICER :"
        '
        'txtproedit
        '
        Me.txtproedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtproedit.Location = New System.Drawing.Point(129, 111)
        Me.txtproedit.Name = "txtproedit"
        Me.txtproedit.Size = New System.Drawing.Size(240, 51)
        Me.txtproedit.TabIndex = 5
        Me.txtproedit.Text = ""
        '
        'ComboBoxoffedit
        '
        Me.ComboBoxoffedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxoffedit.FormattingEnabled = True
        Me.ComboBoxoffedit.Location = New System.Drawing.Point(129, 219)
        Me.ComboBoxoffedit.Name = "ComboBoxoffedit"
        Me.ComboBoxoffedit.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxoffedit.TabIndex = 6
        '
        'txtidedit
        '
        Me.txtidedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtidedit.Location = New System.Drawing.Point(129, 13)
        Me.txtidedit.Name = "txtidedit"
        Me.txtidedit.ReadOnly = True
        Me.txtidedit.Size = New System.Drawing.Size(50, 22)
        Me.txtidedit.TabIndex = 342
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(65, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 336
        Me.Label11.Text = "SLOVE :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(93, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 13)
        Me.Label22.TabIndex = 341
        Me.Label22.Text = "ID :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(59, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 337
        Me.Label10.Text = "STATUS :"
        '
        'ComboBoxstatedit
        '
        Me.ComboBoxstatedit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxstatedit.FormattingEnabled = True
        Me.ComboBoxstatedit.Items.AddRange(New Object() {"กำลังดำเนินการ", "เสร็จเรียบร้อย", "ส่งบริษัทนอก"})
        Me.ComboBoxstatedit.Location = New System.Drawing.Point(129, 244)
        Me.ComboBoxstatedit.Name = "ComboBoxstatedit"
        Me.ComboBoxstatedit.Size = New System.Drawing.Size(241, 21)
        Me.ComboBoxstatedit.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListViewhelp2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1064, 250)
        Me.GroupBox1.TabIndex = 409
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SHOW"
        '
        'ListViewhelp2
        '
        Me.ListViewhelp2.BackColor = System.Drawing.Color.White
        Me.ListViewhelp2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.name_container, Me.agent, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9})
        Me.ListViewhelp2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewhelp2.FullRowSelect = True
        Me.ListViewhelp2.GridLines = True
        Me.ListViewhelp2.HideSelection = False
        Me.ListViewhelp2.Location = New System.Drawing.Point(6, 16)
        Me.ListViewhelp2.Name = "ListViewhelp2"
        Me.ListViewhelp2.Size = New System.Drawing.Size(1046, 219)
        Me.ListViewhelp2.TabIndex = 343
        Me.ListViewhelp2.UseCompatibleStateImageBehavior = False
        Me.ListViewhelp2.View = System.Windows.Forms.View.Details
        '
        'name_container
        '
        Me.name_container.Text = "ID"
        Me.name_container.Width = 40
        '
        'agent
        '
        Me.agent.Text = "TYPE"
        Me.agent.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SECTION"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "STATUS"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PROBLEM"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATE"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SLOVE"
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "OFFICER"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "LOCATION"
        Me.ColumnHeader9.Width = 120
        '
        'Help_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1214, 583)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Help_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help_Edit"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewbacklog As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnxclear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnxdelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnxsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtnameedit As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxlocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxtypeproedit As System.Windows.Forms.ComboBox
    Friend WithEvents txteditproedit As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtproedit As System.Windows.Forms.RichTextBox
    Friend WithEvents ComboBoxoffedit As System.Windows.Forms.ComboBox
    Friend WithEvents txtidedit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxstatedit As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewhelp2 As System.Windows.Forms.ListView
    Friend WithEvents name_container As System.Windows.Forms.ColumnHeader
    Friend WithEvents agent As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
