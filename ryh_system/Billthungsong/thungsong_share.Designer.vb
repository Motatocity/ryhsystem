<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thungsong_share
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ListRegToday = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNewPerson = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(23, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 28)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "ชื่อผู้ถือหุ้นเดิม : "
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(21, 10)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(87, 28)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "ชื่อผู้ซื้อ : "
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Location = New System.Drawing.Point(114, 7)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.PreventEnterBeep = True
        Me.TextBoxX2.Size = New System.Drawing.Size(243, 23)
        Me.TextBoxX2.TabIndex = 3
        '
        'ListRegToday
        '
        Me.ListRegToday.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.ListRegToday.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ListRegToday.Location = New System.Drawing.Point(9, 36)
        Me.ListRegToday.Name = "ListRegToday"
        Me.ListRegToday.PrimaryGrid.AllowRowHeaderResize = True
        Me.ListRegToday.PrimaryGrid.AllowRowResize = True
        Me.ListRegToday.PrimaryGrid.AllowSelection = False
        Me.ListRegToday.PrimaryGrid.ColumnHeader.RowHeight = 25
        GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn1.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn1.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn1.Name = "งวดที่"
        GridColumn1.ReadOnly = True
        GridColumn1.Width = 70
        GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn2.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn2.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn2.Name = "จำนวนหุ้น"
        GridColumn2.ReadOnly = True
        GridColumn2.Width = 70
        GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn3.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn3.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn3.Name = "จำนวนเงิน"
        GridColumn3.ReadOnly = True
        GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn4.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn4.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn4.Name = "จำนวนเงินที่ชำระแล้ว"
        GridColumn4.Width = 150
        GridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn5.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn5.CellStyles.Default.TextColor = System.Drawing.Color.Transparent
        GridColumn5.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn5.HeaderStyles.Default.TextColor = System.Drawing.Color.Transparent
        GridColumn5.Name = "สถานะ"
        GridColumn5.ReadOnly = True
        GridColumn5.Width = 30
        GridColumn6.Name = "id"
        GridColumn6.Visible = False
        Me.ListRegToday.PrimaryGrid.Columns.Add(GridColumn1)
        Me.ListRegToday.PrimaryGrid.Columns.Add(GridColumn2)
        Me.ListRegToday.PrimaryGrid.Columns.Add(GridColumn3)
        Me.ListRegToday.PrimaryGrid.Columns.Add(GridColumn4)
        Me.ListRegToday.PrimaryGrid.Columns.Add(GridColumn5)
        Me.ListRegToday.PrimaryGrid.Columns.Add(GridColumn6)
        Me.ListRegToday.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle
        Me.ListRegToday.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal
        Me.ListRegToday.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.ListRegToday.PrimaryGrid.MultiSelect = False
        Me.ListRegToday.PrimaryGrid.PrimaryColumnIndex = 1
        Me.ListRegToday.PrimaryGrid.RowWhitespaceClickBehavior = DevComponents.DotNetBar.SuperGrid.RowWhitespaceClickBehavior.ExtendSelection
        Me.ListRegToday.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.ListRegToday.PrimaryGrid.ShowGroupUnderline = False
        Me.ListRegToday.PrimaryGrid.ShowRowHeaders = False
        Me.ListRegToday.Size = New System.Drawing.Size(412, 205)
        Me.ListRegToday.TabIndex = 30
        Me.ListRegToday.Text = "SuperGridControl1"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(733, 248)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(116, 32)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 31
        Me.ButtonX1.Text = "Save"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(18, 37)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(108, 28)
        Me.LabelX3.TabIndex = 32
        Me.LabelX3.Text = "เลขบัตรประชาชน : "
        '
        'TextBoxX4
        '
        '
        '
        '
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX4.Location = New System.Drawing.Point(154, 76)
        Me.TextBoxX4.Multiline = True
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.PreventEnterBeep = True
        Me.TextBoxX4.Size = New System.Drawing.Size(243, 47)
        Me.TextBoxX4.TabIndex = 35
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(117, 73)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(87, 28)
        Me.LabelX4.TabIndex = 34
        Me.LabelX4.Text = "ที่อยู่ : "
        '
        'TextBoxX5
        '
        '
        '
        '
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX5.Location = New System.Drawing.Point(154, 126)
        Me.TextBoxX5.Name = "TextBoxX5"
        Me.TextBoxX5.PreventEnterBeep = True
        Me.TextBoxX5.Size = New System.Drawing.Size(106, 23)
        Me.TextBoxX5.TabIndex = 37
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(67, 123)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(87, 28)
        Me.LabelX5.TabIndex = 36
        Me.LabelX5.Text = "เบอร์โทรศัพท์ : "
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(98, 150)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(87, 28)
        Me.LabelX6.TabIndex = 38
        Me.LabelX6.Text = "ประเภท : "
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(125, 40)
        Me.MaskedTextBox1.Mask = "0 0000 00000 00 0"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(275, 23)
        Me.MaskedTextBox1.TabIndex = 42
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ทั่วไป", "รพ.", "VIP"})
        Me.ComboBox1.Location = New System.Drawing.Point(154, 153)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(106, 24)
        Me.ComboBox1.TabIndex = 43
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.txtNewPerson)
        Me.GroupPanel1.Controls.Add(Me.ComboBox1)
        Me.GroupPanel1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(427, 21)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(423, 221)
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
        Me.GroupPanel1.TabIndex = 44
        Me.GroupPanel1.Text = "ข้อมูลผู้ซื้อหุ้น"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(76, 13)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(324, 23)
        Me.TextBoxX1.TabIndex = 45
        '
        'txtNewPerson
        '
        Me.txtNewPerson.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtNewPerson.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNewPerson.ForeColor = System.Drawing.Color.Crimson
        Me.txtNewPerson.Location = New System.Drawing.Point(266, 154)
        Me.txtNewPerson.Name = "txtNewPerson"
        Me.txtNewPerson.Size = New System.Drawing.Size(124, 23)
        Me.txtNewPerson.TabIndex = 44
        Me.txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่"
        '
        'thungsong_share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 288)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ListRegToday)
        Me.Controls.Add(Me.TextBoxX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "thungsong_share"
        Me.Text = "บันทึกการโอนหุ้น"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ListRegToday As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtNewPerson As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
