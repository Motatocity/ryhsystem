<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmedit_detailbillryh
      Inherits DevComponents.DotNetBar.Office2007Form
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
        Dim Background5 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background6 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim Background7 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background8 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.Grid1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackColor = System.Drawing.Color.White
        Background5.Color1 = System.Drawing.Color.AliceBlue
        Background5.Color2 = System.Drawing.Color.AliceBlue
        Me.Grid1.DefaultVisualStyles.CellStyles.Default.Background = Background5
        Background6.Color1 = System.Drawing.Color.AliceBlue
        Background6.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Grid1.DefaultVisualStyles.GridPanelStyle.Background = Background6
        Me.Grid1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Grid1.ForeColor = System.Drawing.Color.Black
        Me.Grid1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Grid1.Location = New System.Drawing.Point(12, 13)
        Me.Grid1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grid1.Name = "Grid1"
        GridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn4.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn4.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn4.Name = "เลขที่ใบเสร็จ"
        GridColumn4.ReadOnly = True
        GridColumn4.Width = 48
        Me.Grid1.PrimaryGrid.Columns.Add(GridColumn4)
        Me.Grid1.PrimaryGrid.EnableColumnFiltering = True
        Me.Grid1.PrimaryGrid.EnableFiltering = True
        Me.Grid1.PrimaryGrid.EnableRowFiltering = True
        Me.Grid1.PrimaryGrid.Filter.Visible = True
        Me.Grid1.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.Grid1.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.Grid1.PrimaryGrid.Footer.Text = ""
        Me.Grid1.PrimaryGrid.MultiSelect = False
        Me.Grid1.PrimaryGrid.PrimaryColumnIndex = 1
        Me.Grid1.PrimaryGrid.RowHeaderWidth = 25
        Me.Grid1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Grid1.PrimaryGrid.ShowRowGridIndex = True
        Me.Grid1.Size = New System.Drawing.Size(131, 356)
        Me.Grid1.TabIndex = 1109
        Me.Grid1.Text = "SuperGridControl3"
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.BackColor = System.Drawing.Color.White
        Background7.Color1 = System.Drawing.Color.AliceBlue
        Background7.Color2 = System.Drawing.Color.AliceBlue
        Me.SuperGridControl1.DefaultVisualStyles.CellStyles.Default.Background = Background7
        Background8.Color1 = System.Drawing.Color.AliceBlue
        Background8.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SuperGridControl1.DefaultVisualStyles.GridPanelStyle.Background = Background8
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperGridControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridControl1.Location = New System.Drawing.Point(170, 13)
        Me.SuperGridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        GridColumn5.Name = "ID"
        GridColumn6.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn6.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn6.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn6.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn6.Name = "รายชื่อผู้ถือหุ้น"
        GridColumn6.ReadOnly = True
        GridColumn6.Width = 48
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn6)
        Me.SuperGridControl1.PrimaryGrid.EnableColumnFiltering = True
        Me.SuperGridControl1.PrimaryGrid.EnableFiltering = True
        Me.SuperGridControl1.PrimaryGrid.EnableRowFiltering = True
        Me.SuperGridControl1.PrimaryGrid.Filter.Visible = True
        Me.SuperGridControl1.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.SuperGridControl1.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.SuperGridControl1.PrimaryGrid.Footer.Text = ""
        Me.SuperGridControl1.PrimaryGrid.MultiSelect = False
        Me.SuperGridControl1.PrimaryGrid.PrimaryColumnIndex = 1
        Me.SuperGridControl1.PrimaryGrid.RowHeaderWidth = 25
        Me.SuperGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.SuperGridControl1.PrimaryGrid.ShowRowGridIndex = True
        Me.SuperGridControl1.Size = New System.Drawing.Size(641, 123)
        Me.SuperGridControl1.TabIndex = 1110
        Me.SuperGridControl1.Text = "SuperGridControl3"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(222, 173)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 1112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(165, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 1111
        Me.Label1.Text = "ชื่อ"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TextBox7)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.TextBox6)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.TextBox5)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.RadioButton3)
        Me.GroupPanel1.Controls.Add(Me.RadioButton2)
        Me.GroupPanel1.Controls.Add(Me.RadioButton1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(168, 199)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(384, 100)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 1113
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.ForeColor = System.Drawing.Color.Black
        Me.TextBox7.Location = New System.Drawing.Point(118, 63)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(236, 20)
        Me.TextBox7.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(65, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "เลขที่"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(119, 37)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(124, 20)
        Me.TextBox6.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(65, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "สาขา"
        '
        'TextBox5
        '
        Me.TextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(118, 8)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(236, 20)
        Me.TextBox5.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(65, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "ธนาคาร"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(3, 49)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "เงินสด"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(3, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "เช็ค"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "โอน"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(238, 148)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(149, 20)
        Me.TextBox4.TabIndex = 1119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(165, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 1118
        Me.Label4.Text = "เลขที่ใบเสร็จ"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.ForeColor = System.Drawing.Color.Black
        Me.TextBox8.Location = New System.Drawing.Point(606, 174)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(77, 20)
        Me.TextBox8.TabIndex = 1121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(552, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 1120
        Me.Label5.Text = "IDUSER"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(736, 346)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.TabIndex = 1122
        Me.ButtonX1.Text = "UPDATE"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(606, 200)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(77, 20)
        Me.TextBox2.TabIndex = 1123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(558, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1124
        Me.Label2.Text = "IDBILL"
        '
        'frmedit_detailbillryh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 591)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SuperGridControl1)
        Me.Controls.Add(Me.Grid1)
        Me.DoubleBuffered = True
        Me.Name = "frmedit_detailbillryh"
        Me.Text = "frmedit_detailbillryh"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
