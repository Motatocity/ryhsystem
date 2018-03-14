<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnurse_or
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBoxX8 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBoxX14 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.MaskedTextBoxAdv1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxAdv2 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBoxX16 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBoxX12 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBoxX13 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBoxX15 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label36 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(640, 200)
        Me.DataGridView1.TabIndex = 221
        '
        'Column1
        '
        Me.Column1.HeaderText = "ประเภท"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "จำนวนผู้ป่วยต่อวัน"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "ชม. การพยาบาลเฉลี่ย"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 140
        '
        'Column4
        '
        Me.Column4.HeaderText = "รวมชั่วโมง"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel1.Controls.Add(Me.DataGridView1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.DrawTitleBox = False
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 43)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(653, 232)
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
        Me.GroupPanel1.TabIndex = 223
        Me.GroupPanel1.Text = "การคำนวณหาอัตรากำลัง"
        Me.GroupPanel1.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(362, 314)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(22, 17)
        Me.Label24.TabIndex = 229
        Me.Label24.Text = "คน"
        '
        'TextBoxX8
        '
        Me.TextBoxX8.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX8.Border.Class = "TextBoxBorder"
        Me.TextBoxX8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX8.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX8.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX8.Location = New System.Drawing.Point(270, 312)
        Me.TextBoxX8.Name = "TextBoxX8"
        Me.TextBoxX8.PreventEnterBeep = True
        Me.TextBoxX8.Size = New System.Drawing.Size(86, 20)
        Me.TextBoxX8.TabIndex = 228
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(362, 282)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 17)
        Me.Label23.TabIndex = 225
        Me.Label23.Text = "ชั่วโมง"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 313)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(230, 17)
        Me.Label22.TabIndex = 227
        Me.Label22.Text = "อัตรากำลังทางการพยาบาล (Productivity FTE)"
        '
        'TextBoxX7
        '
        Me.TextBoxX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX7.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX7.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX7.Location = New System.Drawing.Point(270, 282)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.PreventEnterBeep = True
        Me.TextBoxX7.Size = New System.Drawing.Size(86, 20)
        Me.TextBoxX7.TabIndex = 224
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 281)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(162, 17)
        Me.Label21.TabIndex = 226
        Me.Label21.Text = "จำนวนชั่วโมงการพยาบาลผู้ป่วยใน"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel3.Controls.Add(Me.TextBoxX14)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.DrawTitleBox = False
        Me.GroupPanel3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupPanel3.Location = New System.Drawing.Point(427, 415)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(210, 56)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 231
        Me.GroupPanel3.Text = "คำนวณ  %  PRODUCTIVITY"
        Me.GroupPanel3.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        '
        'TextBoxX14
        '
        Me.TextBoxX14.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX14.Border.Class = "TextBoxBorder"
        Me.TextBoxX14.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX14.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX14.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX14.Location = New System.Drawing.Point(3, 2)
        Me.TextBoxX14.Name = "TextBoxX14"
        Me.TextBoxX14.PreventEnterBeep = True
        Me.TextBoxX14.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxX14.TabIndex = 219
        '
        'GroupPanel4
        '
        Me.GroupPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel4.Controls.Add(Me.Label1)
        Me.GroupPanel4.Controls.Add(Me.TextBoxX1)
        Me.GroupPanel4.Controls.Add(Me.Label2)
        Me.GroupPanel4.Controls.Add(Me.Label3)
        Me.GroupPanel4.Controls.Add(Me.Label4)
        Me.GroupPanel4.Controls.Add(Me.TextBoxX2)
        Me.GroupPanel4.Controls.Add(Me.Label5)
        Me.GroupPanel4.Controls.Add(Me.TextBoxX3)
        Me.GroupPanel4.Controls.Add(Me.Label6)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.DrawTitleBox = False
        Me.GroupPanel4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupPanel4.Location = New System.Drawing.Point(27, 338)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(374, 124)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 230
        Me.GroupPanel4.Text = "คำนวณบุคลากรต่อวันในการดูแลผู้ป่วย"
        Me.GroupPanel4.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 225
        Me.Label1.Text = "คน/วัน"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(219, 60)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX1.TabIndex = 224
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "คำนวณบุคลากรต่อวันในการดูแลผู้ป่วย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 222
        Me.Label3.Text = "ชั่วโมง/วัน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "ชั่วโมง/ปี"
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(219, 34)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.PreventEnterBeep = True
        Me.TextBoxX2.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX2.TabIndex = 221
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 17)
        Me.Label5.TabIndex = 220
        Me.Label5.Text = "จำนวนชั่วโมงการดูแลผู้ป่วยในแต่ละวัน"
        '
        'TextBoxX3
        '
        Me.TextBoxX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX3.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX3.Location = New System.Drawing.Point(219, 7)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.PreventEnterBeep = True
        Me.TextBoxX3.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX3.TabIndex = 219
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 17)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "จำนวนชั่วโมงการดูแลผู้ป่วยต่อปี"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(262, 10)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(73, 27)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 236
        Me.ButtonX2.Text = "ประมวล"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(592, 7)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(73, 27)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 235
        Me.ButtonX1.Text = "Detail"
        '
        'MaskedTextBoxAdv1
        '
        '
        '
        '
        Me.MaskedTextBoxAdv1.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv1.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxAdv1.Location = New System.Drawing.Point(167, 12)
        Me.MaskedTextBoxAdv1.Mask = "00-00-0000"
        Me.MaskedTextBoxAdv1.Name = "MaskedTextBoxAdv1"
        Me.MaskedTextBoxAdv1.Size = New System.Drawing.Size(89, 22)
        Me.MaskedTextBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.MaskedTextBoxAdv1.TabIndex = 234
        Me.MaskedTextBoxAdv1.Text = ""
        Me.MaskedTextBoxAdv1.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(145, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 17)
        Me.Label7.TabIndex = 233
        Me.Label7.Text = "ถึง"
        '
        'MaskedTextBoxAdv2
        '
        '
        '
        '
        Me.MaskedTextBoxAdv2.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv2.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxAdv2.Location = New System.Drawing.Point(50, 12)
        Me.MaskedTextBoxAdv2.Mask = "00-00-0000"
        Me.MaskedTextBoxAdv2.Name = "MaskedTextBoxAdv2"
        Me.MaskedTextBoxAdv2.Size = New System.Drawing.Size(94, 22)
        Me.MaskedTextBoxAdv2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.MaskedTextBoxAdv2.TabIndex = 232
        Me.MaskedTextBoxAdv2.Text = ""
        Me.MaskedTextBoxAdv2.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 237
        Me.Label8.Text = "วันที่"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel2.Controls.Add(Me.Label37)
        Me.GroupPanel2.Controls.Add(Me.TextBoxX16)
        Me.GroupPanel2.Controls.Add(Me.Label38)
        Me.GroupPanel2.Controls.Add(Me.Label33)
        Me.GroupPanel2.Controls.Add(Me.Label31)
        Me.GroupPanel2.Controls.Add(Me.TextBoxX12)
        Me.GroupPanel2.Controls.Add(Me.Label32)
        Me.GroupPanel2.Controls.Add(Me.Label34)
        Me.GroupPanel2.Controls.Add(Me.TextBoxX13)
        Me.GroupPanel2.Controls.Add(Me.Label35)
        Me.GroupPanel2.Controls.Add(Me.TextBoxX15)
        Me.GroupPanel2.Controls.Add(Me.Label36)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.DrawTitleBox = False
        Me.GroupPanel2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupPanel2.Location = New System.Drawing.Point(427, 280)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(234, 134)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 255
        Me.GroupPanel2.Text = "ค่าเฉลี่ยอัตรากำลังบุคลากรที่เข้ามาทำงาน"
        Me.GroupPanel2.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(163, 83)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(32, 17)
        Me.Label37.TabIndex = 229
        Me.Label37.Text = "อัตรา"
        '
        'TextBoxX16
        '
        Me.TextBoxX16.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX16.Border.Class = "TextBoxBorder"
        Me.TextBoxX16.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX16.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX16.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX16.Location = New System.Drawing.Point(71, 81)
        Me.TextBoxX16.Name = "TextBoxX16"
        Me.TextBoxX16.PreventEnterBeep = True
        Me.TextBoxX16.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX16.TabIndex = 228
        Me.TextBoxX16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(40, 83)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(28, 17)
        Me.Label38.TabIndex = 227
        Me.Label38.Text = "WC"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(163, 57)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(32, 17)
        Me.Label33.TabIndex = 226
        Me.Label33.Text = "อัตรา"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(163, 31)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 17)
        Me.Label31.TabIndex = 225
        Me.Label31.Text = "อัตรา"
        '
        'TextBoxX12
        '
        Me.TextBoxX12.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX12.Border.Class = "TextBoxBorder"
        Me.TextBoxX12.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX12.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX12.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX12.Location = New System.Drawing.Point(71, 55)
        Me.TextBoxX12.Name = "TextBoxX12"
        Me.TextBoxX12.PreventEnterBeep = True
        Me.TextBoxX12.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX12.TabIndex = 224
        Me.TextBoxX12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(40, 57)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(26, 17)
        Me.Label32.TabIndex = 223
        Me.Label32.Text = "NA"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(163, 4)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(32, 17)
        Me.Label34.TabIndex = 219
        Me.Label34.Text = "อัตรา"
        '
        'TextBoxX13
        '
        Me.TextBoxX13.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX13.Border.Class = "TextBoxBorder"
        Me.TextBoxX13.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX13.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX13.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX13.Location = New System.Drawing.Point(71, 29)
        Me.TextBoxX13.Name = "TextBoxX13"
        Me.TextBoxX13.PreventEnterBeep = True
        Me.TextBoxX13.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX13.TabIndex = 221
        Me.TextBoxX13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(40, 31)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(25, 17)
        Me.Label35.TabIndex = 220
        Me.Label35.Text = "PN"
        '
        'TextBoxX15
        '
        Me.TextBoxX15.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX15.Border.Class = "TextBoxBorder"
        Me.TextBoxX15.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX15.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX15.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX15.Location = New System.Drawing.Point(71, 2)
        Me.TextBoxX15.Name = "TextBoxX15"
        Me.TextBoxX15.PreventEnterBeep = True
        Me.TextBoxX15.Size = New System.Drawing.Size(86, 25)
        Me.TextBoxX15.TabIndex = 219
        Me.TextBoxX15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(39, 4)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(26, 17)
        Me.Label36.TabIndex = 215
        Me.Label36.Text = "RN"
        '
        'frmnurse_or
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 595)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.MaskedTextBoxAdv1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MaskedTextBoxAdv2)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.GroupPanel4)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TextBoxX8)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TextBoxX7)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmnurse_or"
        Me.Text = "frmnurse_or"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX8 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBoxX14 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MaskedTextBoxAdv1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxAdv2 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX16 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX12 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX13 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX15 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label36 As System.Windows.Forms.Label
End Class
