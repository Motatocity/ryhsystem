<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_Add
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewsection = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewlocat = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewfloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonX7 = New DevComponents.DotNetBar.ButtonX()
        Me.txtidsection = New System.Windows.Forms.TextBox()
        Me.txtnamesection = New System.Windows.Forms.TextBox()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.btnxsave = New DevComponents.DotNetBar.ButtonX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtidlocat = New System.Windows.Forms.TextBox()
        Me.txtnamelocat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxofficer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproblem = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txteditproblem = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxtype = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxstate = New System.Windows.Forms.ComboBox()
        Me.txtnameperson = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtxphoto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnxbrowse = New DevComponents.DotNetBar.ButtonX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListViewsection)
        Me.GroupBox1.Controls.Add(Me.ListViewlocat)
        Me.GroupBox1.Controls.Add(Me.ListViewfloor)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 147)
        Me.GroupBox1.TabIndex = 396
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOCATION"
        '
        'ListViewsection
        '
        Me.ListViewsection.BackColor = System.Drawing.Color.White
        Me.ListViewsection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListViewsection.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewsection.FullRowSelect = True
        Me.ListViewsection.GridLines = True
        Me.ListViewsection.HideSelection = False
        Me.ListViewsection.Location = New System.Drawing.Point(95, 21)
        Me.ListViewsection.Name = "ListViewsection"
        Me.ListViewsection.Size = New System.Drawing.Size(157, 119)
        Me.ListViewsection.TabIndex = 389
        Me.ListViewsection.UseCompatibleStateImageBehavior = False
        Me.ListViewsection.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 0
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "SECTION"
        Me.ColumnHeader21.Width = 147
        '
        'ListViewlocat
        '
        Me.ListViewlocat.BackColor = System.Drawing.Color.White
        Me.ListViewlocat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader1})
        Me.ListViewlocat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewlocat.FullRowSelect = True
        Me.ListViewlocat.GridLines = True
        Me.ListViewlocat.HideSelection = False
        Me.ListViewlocat.Location = New System.Drawing.Point(258, 21)
        Me.ListViewlocat.Name = "ListViewlocat"
        Me.ListViewlocat.Size = New System.Drawing.Size(277, 119)
        Me.ListViewlocat.TabIndex = 390
        Me.ListViewlocat.UseCompatibleStateImageBehavior = False
        Me.ListViewlocat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "LOCATION"
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Description"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP"
        Me.ColumnHeader1.Width = 102
        '
        'ListViewfloor
        '
        Me.ListViewfloor.BackColor = System.Drawing.Color.White
        Me.ListViewfloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListViewfloor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewfloor.FullRowSelect = True
        Me.ListViewfloor.GridLines = True
        Me.ListViewfloor.HideSelection = False
        Me.ListViewfloor.Location = New System.Drawing.Point(10, 21)
        Me.ListViewfloor.Name = "ListViewfloor"
        Me.ListViewfloor.Size = New System.Drawing.Size(79, 119)
        Me.ListViewfloor.TabIndex = 393
        Me.ListViewfloor.UseCompatibleStateImageBehavior = False
        Me.ListViewfloor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "FLOOR"
        Me.ColumnHeader12.Width = 70
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ButtonX7)
        Me.GroupBox3.Controls.Add(Me.txtidsection)
        Me.GroupBox3.Controls.Add(Me.txtnamesection)
        Me.GroupBox3.Controls.Add(Me.ButtonX6)
        Me.GroupBox3.Controls.Add(Me.btnxsave)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtidlocat)
        Me.GroupBox3.Controls.Add(Me.txtnamelocat)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ComboBoxofficer)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtproblem)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txteditproblem)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ComboBoxtype)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ComboBoxstate)
        Me.GroupBox3.Controls.Add(Me.txtnameperson)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(562, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 290)
        Me.GroupBox3.TabIndex = 398
        Me.GroupBox3.TabStop = False
        '
        'TextBox1
        '
        '
        '
        '
        Me.TextBox1.BackgroundStyle.Class = "TextBoxBorder"
        Me.TextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox1.ButtonClear.Visible = True
        Me.TextBox1.Location = New System.Drawing.Point(87, 116)
        Me.TextBox1.Mask = "00:00"
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 21)
        Me.TextBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.TextBox1.TabIndex = 411
        Me.TextBox1.Text = ""
        Me.TextBox1.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 410
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"กำลังดำเนินการ", "เสร็จเรียบร้อย", "ส่งบริษัทนอก"})
        Me.ComboBox1.Location = New System.Drawing.Point(267, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox1.TabIndex = 409
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(217, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 408
        Me.Label4.Text = "หน่วย :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(37, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 406
        Me.Label3.Text = "Time :"
        '
        'ButtonX7
        '
        Me.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ButtonX7.Location = New System.Drawing.Point(286, 256)
        Me.ButtonX7.Name = "ButtonX7"
        Me.ButtonX7.Size = New System.Drawing.Size(81, 28)
        Me.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX7.Symbol = ""
        Me.ButtonX7.TabIndex = 405
        Me.ButtonX7.Text = "Refresh"
        '
        'txtidsection
        '
        Me.txtidsection.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtidsection.Location = New System.Drawing.Point(87, 14)
        Me.txtidsection.Name = "txtidsection"
        Me.txtidsection.ReadOnly = True
        Me.txtidsection.Size = New System.Drawing.Size(20, 22)
        Me.txtidsection.TabIndex = 405
        '
        'txtnamesection
        '
        Me.txtnamesection.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtnamesection.Location = New System.Drawing.Point(113, 14)
        Me.txtnamesection.Name = "txtnamesection"
        Me.txtnamesection.ReadOnly = True
        Me.txtnamesection.Size = New System.Drawing.Size(57, 22)
        Me.txtnamesection.TabIndex = 404
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ButtonX6.Location = New System.Drawing.Point(211, 263)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.ButtonX6.Size = New System.Drawing.Size(69, 21)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX6.Symbol = ""
        Me.ButtonX6.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX6.TabIndex = 403
        Me.ButtonX6.Text = "Cancel"
        '
        'btnxsave
        '
        Me.btnxsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxsave.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnxsave.Location = New System.Drawing.Point(143, 263)
        Me.btnxsave.Name = "btnxsave"
        Me.btnxsave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnxsave.Size = New System.Drawing.Size(62, 21)
        Me.btnxsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnxsave.Symbol = ""
        Me.btnxsave.SymbolColor = System.Drawing.Color.DarkGreen
        Me.btnxsave.TabIndex = 402
        Me.btnxsave.Text = "Save"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(176, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 388
        Me.Label13.Text = "LOCATION :"
        '
        'txtidlocat
        '
        Me.txtidlocat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtidlocat.Location = New System.Drawing.Point(248, 14)
        Me.txtidlocat.Name = "txtidlocat"
        Me.txtidlocat.ReadOnly = True
        Me.txtidlocat.Size = New System.Drawing.Size(25, 22)
        Me.txtidlocat.TabIndex = 389
        '
        'txtnamelocat
        '
        Me.txtnamelocat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtnamelocat.Location = New System.Drawing.Point(287, 14)
        Me.txtnamelocat.Name = "txtnamelocat"
        Me.txtnamelocat.ReadOnly = True
        Me.txtnamelocat.Size = New System.Drawing.Size(69, 22)
        Me.txtnamelocat.TabIndex = 387
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(12, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 374
        Me.Label7.Text = "PROBLEM :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(18, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 380
        Me.Label16.Text = "SECTION :"
        '
        'ComboBoxofficer
        '
        Me.ComboBoxofficer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxofficer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxofficer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxofficer.FormattingEnabled = True
        Me.ComboBoxofficer.Location = New System.Drawing.Point(87, 89)
        Me.ComboBoxofficer.Name = "ComboBoxofficer"
        Me.ComboBoxofficer.Size = New System.Drawing.Size(118, 21)
        Me.ComboBoxofficer.TabIndex = 368
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(29, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 376
        Me.Label1.Text = "SOLVE :"
        '
        'txtproblem
        '
        Me.txtproblem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtproblem.Location = New System.Drawing.Point(87, 143)
        Me.txtproblem.Name = "txtproblem"
        Me.txtproblem.Size = New System.Drawing.Size(280, 49)
        Me.txtproblem.TabIndex = 367
        Me.txtproblem.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(40, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 371
        Me.Label5.Text = "JOB :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(35, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 362
        Me.Label2.Text = "USER :"
        '
        'txteditproblem
        '
        Me.txteditproblem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txteditproblem.Location = New System.Drawing.Point(87, 195)
        Me.txteditproblem.Name = "txteditproblem"
        Me.txteditproblem.Size = New System.Drawing.Size(280, 45)
        Me.txteditproblem.TabIndex = 369
        Me.txteditproblem.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(208, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 377
        Me.Label9.Text = "STATUS :"
        '
        'ComboBoxtype
        '
        Me.ComboBoxtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxtype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxtype.FormattingEnabled = True
        Me.ComboBoxtype.Items.AddRange(New Object() {"คอมพิวเตอร์", "เครื่องพิมพ์", "เครื่องสแกน", "กล้องวงจรปิด", "Network", "INTERNET", "Hims", "LAB", "X-RAY", "SERVER", "อื่นๆ"})
        Me.ComboBoxtype.Location = New System.Drawing.Point(87, 65)
        Me.ComboBoxtype.Name = "ComboBoxtype"
        Me.ComboBoxtype.Size = New System.Drawing.Size(269, 21)
        Me.ComboBoxtype.TabIndex = 365
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(17, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 379
        Me.Label12.Text = "OFFICER :"
        '
        'ComboBoxstate
        '
        Me.ComboBoxstate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxstate.FormattingEnabled = True
        Me.ComboBoxstate.Items.AddRange(New Object() {"กำลังดำเนินการ", "เสร็จเรียบร้อย", "ส่งบริษัทนอก"})
        Me.ComboBoxstate.Location = New System.Drawing.Point(267, 89)
        Me.ComboBoxstate.Name = "ComboBoxstate"
        Me.ComboBoxstate.Size = New System.Drawing.Size(89, 21)
        Me.ComboBoxstate.TabIndex = 370
        '
        'txtnameperson
        '
        Me.txtnameperson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtnameperson.Location = New System.Drawing.Point(87, 40)
        Me.txtnameperson.Name = "txtnameperson"
        Me.txtnameperson.Size = New System.Drawing.Size(269, 22)
        Me.txtnameperson.TabIndex = 363
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtxphoto)
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btnxbrowse)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 87)
        Me.GroupBox2.TabIndex = 403
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "You Information to save"
        '
        'txtxphoto
        '
        Me.txtxphoto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtxphoto.Border.Class = "TextBoxBorder"
        Me.txtxphoto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtxphoto.DisabledBackColor = System.Drawing.Color.White
        Me.txtxphoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtxphoto.ForeColor = System.Drawing.Color.Black
        Me.txtxphoto.Location = New System.Drawing.Point(217, 14)
        Me.txtxphoto.Name = "txtxphoto"
        Me.txtxphoto.PreventEnterBeep = True
        Me.txtxphoto.Size = New System.Drawing.Size(170, 26)
        Me.txtxphoto.TabIndex = 3
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelX1.Location = New System.Drawing.Point(177, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(39, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "NAME :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 68)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnxbrowse
        '
        Me.btnxbrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxbrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxbrowse.Location = New System.Drawing.Point(393, 18)
        Me.btnxbrowse.Name = "btnxbrowse"
        Me.btnxbrowse.Size = New System.Drawing.Size(65, 30)
        Me.btnxbrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnxbrowse.Symbol = ""
        Me.btnxbrowse.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridViewX1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(15, 297)
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
        Me.DataGridViewX1.Size = New System.Drawing.Size(1076, 207)
        Me.DataGridViewX1.TabIndex = 382
        '
        'Column1
        '
        Me.Column1.HeaderText = "TYPE"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "SECTION"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "LOCATION"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "DESCRIPTION"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "PROBLEM"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 240
        '
        'Column6
        '
        Me.Column6.HeaderText = "SOLVE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 240
        '
        'Column7
        '
        Me.Column7.HeaderText = "STAT"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 85
        '
        'Column8
        '
        Me.Column8.HeaderText = "OFFICE"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.HeaderText = "DATE"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Help_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1103, 544)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Help_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help_Add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewsection As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewlocat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewfloor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidsection As System.Windows.Forms.TextBox
    Friend WithEvents txtnamesection As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnxsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtidlocat As System.Windows.Forms.TextBox
    Friend WithEvents txtnamelocat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxofficer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtproblem As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txteditproblem As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxstate As System.Windows.Forms.ComboBox
    Friend WithEvents txtnameperson As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtxphoto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnxbrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonX7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
