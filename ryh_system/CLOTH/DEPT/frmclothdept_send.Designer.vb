<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclothdept_send

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
        Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn7 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.DGVCLOTH = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addMasgrpusr = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'DGVCLOTH
        '
        Me.DGVCLOTH.BackColor = System.Drawing.Color.White
        Me.DGVCLOTH.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DGVCLOTH.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DGVCLOTH.ForeColor = System.Drawing.Color.Black
        Me.DGVCLOTH.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DGVCLOTH.Location = New System.Drawing.Point(12, 14)
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
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn1)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn2)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn3)
        Me.DGVCLOTH.PrimaryGrid.Columns.Add(GridColumn4)
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
        Me.DGVCLOTH.Size = New System.Drawing.Size(727, 209)
        Me.DGVCLOTH.TabIndex = 323
        Me.DGVCLOTH.Text = "SuperGridControl3"
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.BackColor = System.Drawing.Color.White
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SuperGridControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperGridControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridControl1.Location = New System.Drawing.Point(12, 256)
        Me.SuperGridControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn5.Name = "ID"
        GridColumn5.Width = 70
        GridColumn6.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn6.Name = "ชื่อ"
        GridColumn7.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        GridColumn7.Name = "จำนวน"
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn6)
        Me.SuperGridControl1.PrimaryGrid.Columns.Add(GridColumn7)
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
        Me.SuperGridControl1.Size = New System.Drawing.Size(727, 170)
        Me.SuperGridControl1.TabIndex = 324
        Me.SuperGridControl1.Text = "SuperGridControl3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "ผ้าที่ส่งไปยังห้องผ้า"
        '
        'addMasgrpusr
        '
        Me.addMasgrpusr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.addMasgrpusr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.addMasgrpusr.Location = New System.Drawing.Point(647, 435)
        Me.addMasgrpusr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addMasgrpusr.Name = "addMasgrpusr"
        Me.addMasgrpusr.Size = New System.Drawing.Size(92, 28)
        Me.addMasgrpusr.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.addMasgrpusr.TabIndex = 329
        Me.addMasgrpusr.Text = "ส่งผ้า"
        '
        'frmclothdept_send
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 536)
        Me.Controls.Add(Me.addMasgrpusr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SuperGridControl1)
        Me.Controls.Add(Me.DGVCLOTH)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmclothdept_send"
        Me.Text = "frmclothdept_send"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVCLOTH As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents addMasgrpusr As DevComponents.DotNetBar.ButtonX
End Class
