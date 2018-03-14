<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcloth_manage
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
        Dim GridColumn12 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn13 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn14 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn15 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn16 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn17 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn18 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn19 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn20 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn21 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn22 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.Grid1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.deptxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackColor = System.Drawing.Color.White
        Me.Grid1.Enabled = False
        Me.Grid1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Grid1.ForeColor = System.Drawing.Color.Black
        Me.Grid1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Grid1.Location = New System.Drawing.Point(12, 14)
        Me.Grid1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Grid1.Name = "Grid1"
        GridColumn12.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn12.Name = "ชื่อสินค้า"
        GridColumn12.Width = 200
        GridColumn13.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn13.Name = "คงเหลือ"
        GridColumn14.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn14.Name = "ใช้แล้ว"
        GridColumn14.ReadOnly = True
        GridColumn14.Width = 80
        GridColumn15.Name = "รวม"
        GridColumn16.Name = "prdcode"
        GridColumn16.Visible = False
        Me.Grid1.PrimaryGrid.Columns.Add(GridColumn12)
        Me.Grid1.PrimaryGrid.Columns.Add(GridColumn13)
        Me.Grid1.PrimaryGrid.Columns.Add(GridColumn14)
        Me.Grid1.PrimaryGrid.Columns.Add(GridColumn15)
        Me.Grid1.PrimaryGrid.Columns.Add(GridColumn16)
        Me.Grid1.PrimaryGrid.EnableColumnFiltering = True
        Me.Grid1.PrimaryGrid.EnableFiltering = True
        Me.Grid1.PrimaryGrid.EnableRowFiltering = True
        Me.Grid1.PrimaryGrid.Filter.Visible = True
        Me.Grid1.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.Grid1.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.Grid1.PrimaryGrid.Footer.Text = ""
        Me.Grid1.PrimaryGrid.MultiSelect = False
        Me.Grid1.PrimaryGrid.PrimaryColumnIndex = 1
        Me.Grid1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Grid1.PrimaryGrid.ShowRowGridIndex = True
        Me.Grid1.Size = New System.Drawing.Size(854, 181)
        Me.Grid1.TabIndex = 261
        Me.Grid1.Text = "SuperGridControl3"
        '
        'deptxt
        '
        '
        '
        '
        Me.deptxt.Border.Class = "TextBoxBorder"
        Me.deptxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.deptxt.DisabledBackColor = System.Drawing.Color.White
        Me.deptxt.Location = New System.Drawing.Point(85, 202)
        Me.deptxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.deptxt.Name = "deptxt"
        Me.deptxt.PreventEnterBeep = True
        Me.deptxt.Size = New System.Drawing.Size(204, 23)
        Me.deptxt.TabIndex = 263
        Me.deptxt.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "หน่วยงาน :"
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.BackColor = System.Drawing.Color.White
        Me.SuperGridControl1.Enabled = False
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperGridControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridControl1.Location = New System.Drawing.Point(9, 229)
        Me.SuperGridControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        GridColumn17.Name = "หน่วยงาน"
        GridColumn18.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn18.Name = "ชื่อสินค้า"
        GridColumn18.Width = 200
        GridColumn19.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn19.Name = "จำนวน"
        GridColumn20.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn20.Name = "สถานะ"
        GridColumn20.ReadOnly = True
        GridColumn20.Width = 80
        GridColumn21.Name = "เวลา"
        GridColumn22.Name = "prdcode"
        GridColumn22.Visible = False
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn17)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn18)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn19)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn20)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn21)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn22)
        Me.SuperGridControl1.PrimaryGrid.EnableColumnFiltering = True
        Me.SuperGridControl1.PrimaryGrid.EnableFiltering = True
        Me.SuperGridControl1.PrimaryGrid.EnableRowFiltering = True
        Me.SuperGridControl1.PrimaryGrid.Filter.Visible = True
        Me.SuperGridControl1.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.SuperGridControl1.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.SuperGridControl1.PrimaryGrid.Footer.Text = ""
        Me.SuperGridControl1.PrimaryGrid.MultiSelect = False
        Me.SuperGridControl1.PrimaryGrid.PrimaryColumnIndex = 1
        Me.SuperGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.SuperGridControl1.PrimaryGrid.ShowRowGridIndex = True
        Me.SuperGridControl1.Size = New System.Drawing.Size(854, 157)
        Me.SuperGridControl1.TabIndex = 264
        Me.SuperGridControl1.Text = "SuperGridControl3"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(748, 389)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnClear.Size = New System.Drawing.Size(115, 34)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnClear.TabIndex = 336
        Me.btnClear.Text = "CLEAR (F7)"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(627, 389)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnSave.Size = New System.Drawing.Size(115, 34)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnSave.TabIndex = 335
        Me.btnSave.Text = "SAVE (F5)"
        '
        'frmcloth_manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(876, 431)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.SuperGridControl1)
        Me.Controls.Add(Me.deptxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Grid1)
        Me.DoubleBuffered = true
        Me.EnableGlass = false
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmcloth_manage"
        Me.Text = "frmcloth_manage"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Grid1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents deptxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
End Class
