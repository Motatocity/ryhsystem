<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcloth_add
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
        Me.DGVCLOTH = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.editMasgrpusr = New DevComponents.DotNetBar.ButtonX()
        Me.addMasgrpusr = New DevComponents.DotNetBar.ButtonX()
        Me.clothcheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clothname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVCLOTH
        '
        Me.ContextMenuBar1.SetContextMenuEx(Me.DGVCLOTH, Me.ButtonItem3)
        Me.DGVCLOTH.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DGVCLOTH.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DGVCLOTH.Location = New System.Drawing.Point(14, 131)
        Me.DGVCLOTH.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DGVCLOTH.Name = "DGVCLOTH"
        GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn1.Name = "ID"
        GridColumn1.Width = 70
        GridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn2.Name = "ชื่อ"
        GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn3.Name = "สถานะ"
        GridColumn3.Width = 70
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn1)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn2)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn3)
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
        Me.DGVCLOTH.Size = New System.Drawing.Size(423, 187)
        Me.DGVCLOTH.TabIndex = 316
        Me.DGVCLOTH.Text = "SuperGridControl3"
        '
        'editMasgrpusr
        '
        Me.editMasgrpusr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.editMasgrpusr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.editMasgrpusr.Location = New System.Drawing.Point(244, 94)
        Me.editMasgrpusr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.editMasgrpusr.Name = "editMasgrpusr"
        Me.editMasgrpusr.Size = New System.Drawing.Size(52, 28)
        Me.editMasgrpusr.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.editMasgrpusr.TabIndex = 321
        Me.editMasgrpusr.Text = "แก้ไข"
        '
        'addMasgrpusr
        '
        Me.addMasgrpusr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.addMasgrpusr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.addMasgrpusr.Location = New System.Drawing.Point(174, 94)
        Me.addMasgrpusr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addMasgrpusr.Name = "addMasgrpusr"
        Me.addMasgrpusr.Size = New System.Drawing.Size(52, 28)
        Me.addMasgrpusr.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.addMasgrpusr.TabIndex = 320
        Me.addMasgrpusr.Text = "เพิ่ม"
        '
        'clothcheck
        '
        Me.clothcheck.AutoSize = True
        Me.clothcheck.Location = New System.Drawing.Point(61, 73)
        Me.clothcheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.clothcheck.Name = "clothcheck"
        Me.clothcheck.Size = New System.Drawing.Size(137, 20)
        Me.clothcheck.TabIndex = 319
        Me.clothcheck.Text = "สถานะการเปิดใช้งาน"
        Me.clothcheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 318
        Me.Label1.Text = "ชื่อ"
        '
        'clothname
        '
        Me.clothname.Location = New System.Drawing.Point(61, 40)
        Me.clothname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.clothname.Name = "clothname"
        Me.clothname.Size = New System.Drawing.Size(235, 23)
        Me.clothname.TabIndex = 317
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 19)
        Me.Label2.TabIndex = 322
        Me.Label2.Text = "เพิ่มข้อมูลชื่อประเภทผ้า ต่าง ๆ"
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(244, 12)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(186, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ContextMenuBar1.TabIndex = 323
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.AutoExpandOnClick = True
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.ButtonItem1})
        Me.ButtonItem3.Text = "MENU2"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "แก้ไขข้อมูล"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ยกเลิกใช้งาน"
        '
        'frmcloth_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 347)
        Me.Controls.Add(Me.ContextMenuBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.editMasgrpusr)
        Me.Controls.Add(Me.addMasgrpusr)
        Me.Controls.Add(Me.clothcheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clothname)
        Me.Controls.Add(Me.DGVCLOTH)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmcloth_add"
        Me.Text = "frmcloth_add"
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVCLOTH As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents editMasgrpusr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents addMasgrpusr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents clothcheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clothname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
End Class
