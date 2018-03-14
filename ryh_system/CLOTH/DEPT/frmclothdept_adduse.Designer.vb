<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclothdept_adduse
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
        Dim GridColumn7 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.DGVCLOTH = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.addMasgrpusr = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'DGVCLOTH
        '
        Me.DGVCLOTH.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DGVCLOTH.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DGVCLOTH.Location = New System.Drawing.Point(3, 14)
        Me.DGVCLOTH.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DGVCLOTH.Name = "DGVCLOTH"
        GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn1.Name = "ID"
        GridColumn1.Width = 45
        GridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn2.Name = "ชื่อ"
        GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn3.Name = "ทั้งหมด"
        GridColumn3.Width = 75
        GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn4.Name = "เหลือ"
        GridColumn4.Width = 75
        GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn5.Name = "ใช้งานแล้ว"
        GridColumn5.Width = 75
        GridColumn6.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn6.Name = "เพิ่มใช้งานแล้ว"
        GridColumn6.Width = 75
        GridColumn7.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn7.Name = "รวมใช้งานแล้ว"
        GridColumn7.Width = 75
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn1)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn2)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn3)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn4)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn5)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn6)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn7)
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
        Me.DGVCLOTH.Size = New System.Drawing.Size(779, 376)
        Me.DGVCLOTH.TabIndex = 322
        Me.DGVCLOTH.Text = "SuperGridControl3"
        '
        'addMasgrpusr
        '
        Me.addMasgrpusr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.addMasgrpusr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.addMasgrpusr.Location = New System.Drawing.Point(689, 394)
        Me.addMasgrpusr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addMasgrpusr.Name = "addMasgrpusr"
        Me.addMasgrpusr.Size = New System.Drawing.Size(92, 28)
        Me.addMasgrpusr.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.addMasgrpusr.TabIndex = 329
        Me.addMasgrpusr.Text = "ปรับปรุงยอด"
        '
        'frmclothdept_adduse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 430)
        Me.Controls.Add(Me.addMasgrpusr)
        Me.Controls.Add(Me.DGVCLOTH)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmclothdept_adduse"
        Me.Text = "frmclothdept_adduse"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVCLOTH As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents addMasgrpusr As DevComponents.DotNetBar.ButtonX
End Class
