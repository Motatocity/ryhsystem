<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreg_edituser
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
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Edit_user = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.TextBoxItem2 = New DevComponents.DotNetBar.TextBoxItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.id_customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.llogin = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtcustomer_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Edit_user.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Symbol = ""
        Me.ButtonItem1.SymbolSize = 30.0!
        '
        'Edit_user
        '
        Me.Edit_user.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Edit_user.Controls.Add(Me.RibbonBar2)
        Me.Edit_user.Location = New System.Drawing.Point(10, 521)
        Me.Edit_user.Name = "Edit_user"
        Me.Edit_user.Size = New System.Drawing.Size(824, 100)
        '
        '
        '
        Me.Edit_user.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Edit_user.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Edit_user.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Edit_user.TabIndex = 199
        Me.Edit_user.Visible = False
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
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_customer, Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(14, 246)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(545, 267)
        Me.ListView1.TabIndex = 198
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
        Me.ColumnHeader1.Text = "ชื่อ"
        Me.ColumnHeader1.Width = 245
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ชื่อเล่น"
        Me.ColumnHeader7.Width = 109
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "เบอร์โทร"
        Me.ColumnHeader2.Width = 124
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.llogin)
        Me.Panel2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(10, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 53)
        Me.Panel2.TabIndex = 196
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.TextBox1.Location = New System.Drawing.Point(113, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 34)
        Me.TextBox1.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 26)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "ชื่อเล่น"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(431, 161)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.ButtonX1.Size = New System.Drawing.Size(111, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 25.0!
        Me.ButtonX1.TabIndex = 195
        Me.ButtonX1.Text = "Save"
        '
        'txtcustomer_address
        '
        Me.txtcustomer_address.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.txtcustomer_address.Location = New System.Drawing.Point(113, 170)
        Me.txtcustomer_address.Name = "txtcustomer_address"
        Me.txtcustomer_address.Size = New System.Drawing.Size(215, 34)
        Me.txtcustomer_address.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "เบอร์โทร"
        '
        'txtcustomer
        '
        Me.txtcustomer.BackColor = System.Drawing.SystemColors.Window
        Me.txtcustomer.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomer.Location = New System.Drawing.Point(112, 93)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(421, 34)
        Me.txtcustomer.TabIndex = 191
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 26)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "ชื่อ"
        '
        'frmreg_edituser
        '
        Me.ClientSize = New System.Drawing.Size(844, 645)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Edit_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.txtcustomer_address)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcustomer)
        Me.Name = "frmreg_edituser"
        Me.Text = "frmreg_edituser"
        Me.Edit_user.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Edit_user As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents TextBoxItem2 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents id_customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents llogin As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtcustomer_address As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
