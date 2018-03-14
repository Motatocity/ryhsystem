<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister
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
        Dim GridColumn36 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn37 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn38 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn39 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn40 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.DATABASE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PORTTXT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PASTXT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.USERTXT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.IpAddressInput1 = New DevComponents.Editors.IpAddressInput()
        Me.MASDGV = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.IpAddressInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DATABASE
        '
        '
        '
        '
        Me.DATABASE.Border.Class = "TextBoxBorder"
        Me.DATABASE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DATABASE.Location = New System.Drawing.Point(461, 5)
        Me.DATABASE.Name = "DATABASE"
        Me.DATABASE.PreventEnterBeep = True
        Me.DATABASE.Size = New System.Drawing.Size(100, 20)
        Me.DATABASE.TabIndex = 248
        Me.DATABASE.Text = "rajyindee_db"
        Me.DATABASE.WatermarkText = "DATABASE"
        '
        'PORTTXT
        '
        '
        '
        '
        Me.PORTTXT.Border.Class = "TextBoxBorder"
        Me.PORTTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PORTTXT.Location = New System.Drawing.Point(760, 6)
        Me.PORTTXT.Name = "PORTTXT"
        Me.PORTTXT.PreventEnterBeep = True
        Me.PORTTXT.Size = New System.Drawing.Size(76, 20)
        Me.PORTTXT.TabIndex = 247
        Me.PORTTXT.Text = "3306"
        Me.PORTTXT.WatermarkText = "PORT"
        '
        'PASTXT
        '
        '
        '
        '
        Me.PASTXT.Border.Class = "TextBoxBorder"
        Me.PASTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PASTXT.Location = New System.Drawing.Point(673, 6)
        Me.PASTXT.Name = "PASTXT"
        Me.PASTXT.PreventEnterBeep = True
        Me.PASTXT.Size = New System.Drawing.Size(81, 20)
        Me.PASTXT.TabIndex = 246
        Me.PASTXT.Text = "software"
        Me.PASTXT.WatermarkText = "PASS"
        '
        'USERTXT
        '
        '
        '
        '
        Me.USERTXT.Border.Class = "TextBoxBorder"
        Me.USERTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.USERTXT.Location = New System.Drawing.Point(567, 6)
        Me.USERTXT.Name = "USERTXT"
        Me.USERTXT.PreventEnterBeep = True
        Me.USERTXT.Size = New System.Drawing.Size(100, 20)
        Me.USERTXT.TabIndex = 245
        Me.USERTXT.Text = "june"
        Me.USERTXT.WatermarkText = "USER"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(380, 2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.TabIndex = 244
        Me.ButtonX1.Text = "ButtonX1"
        '
        'IpAddressInput1
        '
        Me.IpAddressInput1.AutoOverwrite = True
        '
        '
        '
        Me.IpAddressInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IpAddressInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IpAddressInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IpAddressInput1.ButtonFreeText.Visible = True
        Me.IpAddressInput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.IpAddressInput1.Location = New System.Drawing.Point(842, 4)
        Me.IpAddressInput1.Name = "IpAddressInput1"
        Me.IpAddressInput1.Size = New System.Drawing.Size(175, 22)
        Me.IpAddressInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.IpAddressInput1.TabIndex = 243
        Me.IpAddressInput1.Value = "172.30.10.2"
        '
        'MASDGV
        '
        Me.MASDGV.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.MASDGV.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.MASDGV.Location = New System.Drawing.Point(12, 35)
        Me.MASDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MASDGV.Name = "MASDGV"
        GridColumn36.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn36.Name = "ID"
        GridColumn36.Width = 80
        GridColumn37.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn37.Name = "ชื่อนามสกุล"
        GridColumn37.Width = 150
        GridColumn38.Name = "รหัสประจำตัวประชาชน"
        GridColumn38.Width = 250
        GridColumn39.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn39.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn39.Name = "Check"
        GridColumn40.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn40.Name = "มาแทน"
        Me.MASDGV.PrimaryGrid.Columns.Add(GridColumn36)
        Me.MASDGV.PrimaryGrid.Columns.Add(GridColumn37)
        Me.MASDGV.PrimaryGrid.Columns.Add(GridColumn38)
        Me.MASDGV.PrimaryGrid.Columns.Add(GridColumn39)
        Me.MASDGV.PrimaryGrid.Columns.Add(GridColumn40)
        Me.MASDGV.PrimaryGrid.EnableColumnFiltering = True
        Me.MASDGV.PrimaryGrid.EnableFiltering = True
        Me.MASDGV.PrimaryGrid.EnableRowFiltering = True
        Me.MASDGV.PrimaryGrid.Filter.Visible = True
        Me.MASDGV.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.MASDGV.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.MASDGV.PrimaryGrid.Footer.Text = ""
        Me.MASDGV.PrimaryGrid.MultiSelect = False
        Me.MASDGV.PrimaryGrid.PrimaryColumnIndex = 1
        Me.MASDGV.PrimaryGrid.ShowRowGridIndex = True
        Me.MASDGV.Size = New System.Drawing.Size(1063, 311)
        Me.MASDGV.TabIndex = 242
        Me.MASDGV.Text = "SuperGridControl3"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.TextBox5)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.TextBox4)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TextBox3)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TextBox2)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.TextBox1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 353)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(355, 187)
        Me.GroupControl1.TabIndex = 249
        Me.GroupControl1.Text = "GroupControl1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ผู้มาด้วยตนเอง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "มาแทน"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "จำนวนหุ้น"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(114, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "จำนวนหุ้นทั้งหมด"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(114, 130)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Percent"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "คน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "คน"
        '
        'frmregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 606)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.DATABASE)
        Me.Controls.Add(Me.PORTTXT)
        Me.Controls.Add(Me.PASTXT)
        Me.Controls.Add(Me.USERTXT)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.IpAddressInput1)
        Me.Controls.Add(Me.MASDGV)
        Me.DoubleBuffered = True
        Me.Name = "frmregister"
        Me.Text = "frmregister"
        CType(Me.IpAddressInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DATABASE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PORTTXT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PASTXT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents USERTXT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents IpAddressInput1 As DevComponents.Editors.IpAddressInput
    Friend WithEvents MASDGV As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
