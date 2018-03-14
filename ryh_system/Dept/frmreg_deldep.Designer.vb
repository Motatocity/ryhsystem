<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreg_deldep
    Inherits DevComponents.DotNetBar.RibbonForm


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
        Me.Delete_department = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.TextBoxItem2 = New DevComponents.DotNetBar.TextBoxItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.id_customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Delete_department.SuspendLayout()
        Me.SuspendLayout()
        '
        'Delete_department
        '
        Me.Delete_department.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Delete_department.Controls.Add(Me.RibbonBar2)
        Me.Delete_department.Location = New System.Drawing.Point(5, 485)
        Me.Delete_department.Name = "Delete_department"
        Me.Delete_department.Size = New System.Drawing.Size(824, 100)
        '
        '
        '
        Me.Delete_department.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Delete_department.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Delete_department.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Delete_department.TabIndex = 193
        Me.Delete_department.Visible = False
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.TextBoxItem2, Me.LabelItem2, Me.ButtonItem1})
        Me.RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(411, 100)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 9
        Me.RibbonBar2.Text = "ค้นหา"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Search"
        '
        'TextBoxItem2
        '
        Me.TextBoxItem2.Name = "TextBoxItem2"
        Me.TextBoxItem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxItem2.TextBoxWidth = 300
        Me.TextBoxItem2.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Symbol = ""
        Me.ButtonItem1.SymbolSize = 30.0!
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_customer, Me.ColumnHeader1, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(5, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(545, 320)
        Me.ListView1.TabIndex = 192
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'id_customer
        '
        Me.id_customer.Text = "ID"
        Me.id_customer.Width = 61
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ชื่อแผนก"
        Me.ColumnHeader1.Width = 359
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ชื่อย่อ"
        Me.ColumnHeader7.Width = 109
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(439, 339)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.ButtonX1.Size = New System.Drawing.Size(111, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 25.0!
        Me.ButtonX1.TabIndex = 194
        Me.ButtonX1.Text = "Delete"
        '
        'frmreg_deldep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 599)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Delete_department)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmreg_deldep"
        Me.Text = "frmreg_deldep"
        Me.Delete_department.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Delete_department As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents TextBoxItem2 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents id_customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
