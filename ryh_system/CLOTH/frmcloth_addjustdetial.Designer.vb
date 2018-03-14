<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcloth_addjustdetial
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
        Me.DGVCLOTHDT = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DGVCLOTHDT
        '
        Me.DGVCLOTHDT.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DGVCLOTHDT.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DGVCLOTHDT.Location = New System.Drawing.Point(3, 46)
        Me.DGVCLOTHDT.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DGVCLOTHDT.Name = "DGVCLOTHDT"
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
        GridColumn5.Name = "วันที่ปรับปรุง"
        GridColumn5.Width = 120
        Me.DGVCLOTHDT.PrimaryGrid.Columns.Add(GridColumn1)
        Me.DGVCLOTHDT.PrimaryGrid.Columns.Add(GridColumn2)
        Me.DGVCLOTHDT.PrimaryGrid.Columns.Add(GridColumn3)
        Me.DGVCLOTHDT.PrimaryGrid.Columns.Add(GridColumn4)
        Me.DGVCLOTHDT.PrimaryGrid.Columns.Add(GridColumn5)
        Me.DGVCLOTHDT.PrimaryGrid.EnableColumnFiltering = True
        Me.DGVCLOTHDT.PrimaryGrid.EnableFiltering = True
        Me.DGVCLOTHDT.PrimaryGrid.EnableRowFiltering = True
        Me.DGVCLOTHDT.PrimaryGrid.Filter.Visible = True
        Me.DGVCLOTHDT.PrimaryGrid.FilterLevel = CType((DevComponents.DotNetBar.SuperGrid.FilterLevel.RootConditional Or DevComponents.DotNetBar.SuperGrid.FilterLevel.Expanded), DevComponents.DotNetBar.SuperGrid.FilterLevel)
        Me.DGVCLOTHDT.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.DGVCLOTHDT.PrimaryGrid.Footer.Text = ""
        Me.DGVCLOTHDT.PrimaryGrid.MultiSelect = False
        Me.DGVCLOTHDT.PrimaryGrid.PrimaryColumnIndex = 1
        Me.DGVCLOTHDT.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.DGVCLOTHDT.PrimaryGrid.ShowRowGridIndex = True
        Me.DGVCLOTHDT.Size = New System.Drawing.Size(803, 399)
        Me.DGVCLOTHDT.TabIndex = 322
        Me.DGVCLOTHDT.Text = "SuperGridControl3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 16)
        Me.Label2.TabIndex = 324
        Me.Label2.Text = "ประวัติการ Adjust อุปกรณ์"
        '
        'frmcloth_addjustdetial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 453)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVCLOTHDT)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "frmcloth_addjustdetial"
        Me.Text = "frmcloth_addjustdetial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVCLOTHDT As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
