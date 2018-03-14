<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcloth_addjust1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deptname = New System.Windows.Forms.TextBox()
        Me.DGVCLOTH = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addMasgrpusr = New DevComponents.DotNetBar.ButtonX()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.IDMAS = New System.Windows.Forms.TextBox()
        Me.total = New DevComponents.Editors.IntegerInput()
        Me.totaluse = New DevComponents.Editors.IntegerInput()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totaluse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 320
        Me.Label1.Text = "แผนก"
        '
        'deptname
        '
        Me.deptname.Location = New System.Drawing.Point(64, 18)
        Me.deptname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.deptname.Name = "deptname"
        Me.deptname.Size = New System.Drawing.Size(170, 22)
        Me.deptname.TabIndex = 319
        '
        'DGVCLOTH
        '
        Me.ContextMenuBar1.SetContextMenuEx(Me.DGVCLOTH, Me.ButtonItem3)
        Me.DGVCLOTH.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DGVCLOTH.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DGVCLOTH.Location = New System.Drawing.Point(12, 49)
        Me.DGVCLOTH.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DGVCLOTH.Name = "DGVCLOTH"
        GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn1.Name = "ID"
        GridColumn1.Width = 70
        GridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn2.Name = "ชื่อ"
        GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn3.Name = "จำนวน"
        GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn4.Name = "ใช้งานแล้ว"
        GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn5.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn5.Name = "สถานะ"
        GridColumn5.Width = 70
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn1)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn2)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn3)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn4)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn5)
        Me.DGVCLOTH.PrimaryGrid.EnableColumnFiltering = True
        Me.DGVCLOTH.PrimaryGrid.EnableFiltering = True
        Me.DGVCLOTH.PrimaryGrid.EnableRowFiltering = True
        Me.DGVCLOTH.PrimaryGrid.Filter.Visible = True
        Me.DGVCLOTH.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.DGVCLOTH.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.DGVCLOTH.PrimaryGrid.Footer.Text = ""
        Me.DGVCLOTH.PrimaryGrid.MultiSelect = False
        Me.DGVCLOTH.PrimaryGrid.PrimaryColumnIndex = 1
        Me.DGVCLOTH.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.DGVCLOTH.PrimaryGrid.ShowRowGridIndex = True
        Me.DGVCLOTH.Size = New System.Drawing.Size(615, 186)
        Me.DGVCLOTH.TabIndex = 321
        Me.DGVCLOTH.Text = "SuperGridControl3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 323
        Me.Label2.Text = "Product"
        '
        'product
        '
        Me.product.Location = New System.Drawing.Point(83, 244)
        Me.product.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(170, 22)
        Me.product.TabIndex = 322
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 325
        Me.Label3.Text = "จำนวน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 14)
        Me.Label4.TabIndex = 326
        Me.Label4.Text = "ใช้งานแล้ว"
        '
        'addMasgrpusr
        '
        Me.addMasgrpusr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.addMasgrpusr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.addMasgrpusr.Location = New System.Drawing.Point(191, 331)
        Me.addMasgrpusr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addMasgrpusr.Name = "addMasgrpusr"
        Me.addMasgrpusr.Size = New System.Drawing.Size(92, 28)
        Me.addMasgrpusr.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.addMasgrpusr.TabIndex = 328
        Me.addMasgrpusr.Text = "เพิ่มปรับปรุงยอด"
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(280, 21)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(89, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ContextMenuBar1.TabIndex = 329
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.AutoExpandOnClick = True
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.ButtonItem2})
        Me.ButtonItem3.Text = "MENU2"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Symbol = ""
        Me.ButtonItem5.Text = "ปรับปรุงยอด"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Symbol = ""
        Me.ButtonItem2.Text = "รายละเอียดการปรับปรุงยอด"
        '
        'IDMAS
        '
        Me.IDMAS.Location = New System.Drawing.Point(259, 244)
        Me.IDMAS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IDMAS.Name = "IDMAS"
        Me.IDMAS.ReadOnly = True
        Me.IDMAS.Size = New System.Drawing.Size(24, 22)
        Me.IDMAS.TabIndex = 330
        '
        'total
        '
        '
        '
        '
        Me.total.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.total.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.total.Location = New System.Drawing.Point(83, 273)
        Me.total.Name = "total"
        Me.total.ShowUpDown = True
        Me.total.Size = New System.Drawing.Size(90, 22)
        Me.total.TabIndex = 331
        '
        'totaluse
        '
        '
        '
        '
        Me.totaluse.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.totaluse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.totaluse.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.totaluse.Location = New System.Drawing.Point(83, 309)
        Me.totaluse.Name = "totaluse"
        Me.totaluse.ShowUpDown = True
        Me.totaluse.Size = New System.Drawing.Size(90, 22)
        Me.totaluse.TabIndex = 332
        '
        'frmcloth_addjust1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 417)
        Me.Controls.Add(Me.totaluse)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.IDMAS)
        Me.Controls.Add(Me.ContextMenuBar1)
        Me.Controls.Add(Me.addMasgrpusr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.DGVCLOTH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deptname)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "frmcloth_addjust1"
        Me.Text = "frmcloth_addjust1"
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totaluse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deptname As System.Windows.Forms.TextBox
    Friend WithEvents DGVCLOTH As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents product As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents addMasgrpusr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents IDMAS As System.Windows.Forms.TextBox
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents total As DevComponents.Editors.IntegerInput
    Friend WithEvents totaluse As DevComponents.Editors.IntegerInput
End Class
