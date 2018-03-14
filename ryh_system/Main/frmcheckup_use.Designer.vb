<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheckup_use
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
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim GridColumn8 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn9 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn10 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn11 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn12 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim GridColumn13 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn14 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.DataInformation = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuspendLayout()
        '
        'DataInformation
        '
        Me.DataInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Background3.Color1 = System.Drawing.Color.Gray
        Background3.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataInformation.DefaultVisualStyles.RowStyles.Default.Background = Background3
        Me.DataInformation.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DataInformation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataInformation.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DataInformation.Location = New System.Drawing.Point(-2, 28)
        Me.DataInformation.Name = "DataInformation"
        Me.DataInformation.PrimaryGrid.AllowRowHeaderResize = True
        Me.DataInformation.PrimaryGrid.AllowRowResize = True
        Me.DataInformation.PrimaryGrid.ColumnHeader.RowHeight = 25
        GridColumn8.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn8.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn8.Name = "Date"
        GridColumn8.ReadOnly = True
        GridColumn9.Name = "วันหมดอายุ"
        GridColumn10.Name = "วันที่ใช้"
        GridColumn11.Name = "LOTCARD"
        GridColumn12.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn12.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Padding2.Left = 4
        Padding2.Right = 6
        GridColumn12.CellStyles.Default.ImagePadding = Padding2
        GridColumn12.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn12.Name = "HN"
        GridColumn12.ReadOnly = True
        GridColumn12.Width = 90
        GridColumn13.CellStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn13.HeaderStyles.Default.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridColumn13.Name = "ชื่อ - นามสกุล"
        GridColumn13.ReadOnly = True
        GridColumn13.Width = 230
        GridColumn14.Name = "สถานะ"
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn8)
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn9)
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn10)
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn11)
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn12)
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn13)
        Me.DataInformation.PrimaryGrid.Columns.Add(GridColumn14)
        Me.DataInformation.PrimaryGrid.DefaultRowHeight = 0
        Background4.Color1 = System.Drawing.Color.AliceBlue
        Background4.Color2 = System.Drawing.Color.LightSteelBlue
        Background4.GradientAngle = 45
        Me.DataInformation.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background4
        Me.DataInformation.PrimaryGrid.EnableColumnFiltering = True
        Me.DataInformation.PrimaryGrid.EnableFiltering = True
        Me.DataInformation.PrimaryGrid.EnableRowFiltering = True
        Me.DataInformation.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle
        Me.DataInformation.PrimaryGrid.Filter.Visible = True
        Me.DataInformation.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal
        Me.DataInformation.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.DataInformation.PrimaryGrid.PrimaryColumnIndex = 1
        Me.DataInformation.PrimaryGrid.RowWhitespaceClickBehavior = DevComponents.DotNetBar.SuperGrid.RowWhitespaceClickBehavior.ExtendSelection
        Me.DataInformation.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.DataInformation.PrimaryGrid.ShowGroupUnderline = False
        Me.DataInformation.PrimaryGrid.ShowRowHeaders = False
        Me.DataInformation.Size = New System.Drawing.Size(824, 441)
        Me.DataInformation.TabIndex = 50
        Me.DataInformation.Text = "SuperGridControl2"
        '
        'frmcheckup_use
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 481)
        Me.Controls.Add(Me.DataInformation)
        Me.EnableGlass = False
        Me.Name = "frmcheckup_use"
        Me.Text = "frmcheckup_use"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents DataInformation As DevComponents.DotNetBar.SuperGrid.SuperGridControl
End Class
