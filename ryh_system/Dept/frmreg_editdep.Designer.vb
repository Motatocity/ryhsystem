<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreg_editdep
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.llogin = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtcustomer_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.TextBoxItem2 = New DevComponents.DotNetBar.TextBoxItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Edit_department = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2.SuspendLayout()
        Me.Edit_department.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(462, 135)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.ButtonX1.Size = New System.Drawing.Size(111, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 25.0!
        Me.ButtonX1.TabIndex = 188
        Me.ButtonX1.Text = "Save"
        '
        'llogin
        '
        Me.llogin.AutoSize = True
        Me.llogin.Font = New System.Drawing.Font("Cordia New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.llogin.Location = New System.Drawing.Point(3, 3)
        Me.llogin.Name = "llogin"
        Me.llogin.Size = New System.Drawing.Size(117, 45)
        Me.llogin.TabIndex = 0
        Me.llogin.Text = "แก้ไขแผนก"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.llogin)
        Me.Panel2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(13, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 53)
        Me.Panel2.TabIndex = 187
        '
        'txtcustomer_address
        '
        Me.txtcustomer_address.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.txtcustomer_address.Location = New System.Drawing.Point(142, 132)
        Me.txtcustomer_address.Name = "txtcustomer_address"
        Me.txtcustomer_address.Size = New System.Drawing.Size(101, 34)
        Me.txtcustomer_address.TabIndex = 184
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 26)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "ชื่อย่อ"
        '
        'txtcustomer
        '
        Me.txtcustomer.BackColor = System.Drawing.SystemColors.Window
        Me.txtcustomer.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomer.Location = New System.Drawing.Point(141, 84)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(421, 34)
        Me.txtcustomer.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 26)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "ชื่อแผนก"
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
        'Edit_department
        '
        Me.Edit_department.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Edit_department.Controls.Add(Me.RibbonBar2)
        Me.Edit_department.Location = New System.Drawing.Point(13, 512)
        Me.Edit_department.Name = "Edit_department"
        Me.Edit_department.Size = New System.Drawing.Size(824, 100)
        '
        '
        '
        Me.Edit_department.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Edit_department.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Edit_department.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Edit_department.TabIndex = 191
        Me.Edit_department.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ชื่อแผนก"
        Me.ColumnHeader1.Width = 359
        '
        'id_customer
        '
        Me.id_customer.Text = "ID"
        Me.id_customer.Width = 61
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_customer, Me.ColumnHeader1, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(17, 184)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(545, 320)
        Me.ListView1.TabIndex = 189
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ชื่อย่อ"
        Me.ColumnHeader7.Width = 109
        '
        'frmreg_editdep
        '
        Me.ClientSize = New System.Drawing.Size(870, 626)
        Me.Controls.Add(Me.Edit_department)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtcustomer_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmreg_editdep"
        Me.Text = "frmreg_editdep"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Edit_department.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents llogin As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtcustomer_address As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents TextBoxItem2 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Edit_department As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents id_customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
