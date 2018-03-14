<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_sms
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_sms))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.แผนก = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ข้อความ = New DevComponents.DotNetBar.LabelItem()
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.TextBoxItem2 = New DevComponents.DotNetBar.TextBoxItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.ribbonBar8 = New DevComponents.DotNetBar.RibbonBar()
        Me.itemContainer11 = New DevComponents.DotNetBar.ItemContainer()
        Me.checkBoxItem4 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem5 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem6 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.ComboBoxItem2 = New DevComponents.DotNetBar.TextBoxItem()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.ApplicationButton1 = New DevComponents.DotNetBar.ApplicationButton()
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader11, Me.ColumnHeader2, Me.แผนก, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("CordiaUPC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 183)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(848, 373)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Employee Code"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "HN"
        Me.ColumnHeader3.Width = 98
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID Thai Number"
        Me.ColumnHeader11.Width = 171
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name - Lastname"
        Me.ColumnHeader2.Width = 156
        '
        'แผนก
        '
        Me.แผนก.Text = "แผนก"
        Me.แผนก.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tell"
        Me.ColumnHeader4.Width = 229
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(109, Byte), Integer))
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.ForeColor = System.Drawing.Color.White
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ApplicationButton1, Me.RibbonTabItem1, Me.RibbonTabItem2})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.QatCustomizeItem1})
        Me.RibbonControl1.Size = New System.Drawing.Size(903, 154)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 11
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel1.Controls.Add(Me.ribbonBar8)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(903, 98)
        '
        '
        '
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ข้อความ, Me.TextBoxItem1, Me.ButtonItem2})
        Me.RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar1.Location = New System.Drawing.Point(433, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(330, 95)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.RibbonBar1.TabIndex = 8
        Me.RibbonBar1.Text = "ข้อความ"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ข้อความ
        '
        Me.ข้อความ.Name = "ข้อความ"
        Me.ข้อความ.Text = "ข้อความ"
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.TextBoxHeight = 45
        Me.TextBoxItem1.TextBoxWidth = 250
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Stretch = True
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Symbol = ""
        Me.ButtonItem2.Text = "Send"
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
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.TextBoxItem2, Me.LabelItem2})
        Me.RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar2.Location = New System.Drawing.Point(318, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(115, 95)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.RibbonBar2.TabIndex = 7
        Me.RibbonBar2.Text = "จำนวน"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'TextBoxItem2
        '
        Me.TextBoxItem2.Name = "TextBoxItem2"
        Me.TextBoxItem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxItem2.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "คน"
        '
        'ribbonBar8
        '
        Me.ribbonBar8.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar8.ContainerControlProcessDialogKey = True
        Me.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar8.DragDropSupport = True
        Me.ribbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer11, Me.LabelItem1, Me.ComboBoxItem2})
        Me.ribbonBar8.ItemSpacing = 4
        Me.ribbonBar8.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ribbonBar8.Location = New System.Drawing.Point(3, 0)
        Me.ribbonBar8.Name = "ribbonBar8"
        Me.ribbonBar8.Size = New System.Drawing.Size(315, 95)
        Me.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ribbonBar8.TabIndex = 5
        Me.ribbonBar8.Text = "Options"
        '
        '
        '
        Me.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'itemContainer11
        '
        '
        '
        '
        Me.itemContainer11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemContainer11.Name = "itemContainer11"
        Me.itemContainer11.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.checkBoxItem4, Me.checkBoxItem5, Me.checkBoxItem6})
        '
        '
        '
        Me.itemContainer11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'checkBoxItem4
        '
        Me.checkBoxItem4.Checked = True
        Me.checkBoxItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxItem4.Name = "checkBoxItem4"
        Me.checkBoxItem4.Text = "All "
        '
        'checkBoxItem5
        '
        Me.checkBoxItem5.Name = "checkBoxItem5"
        Me.checkBoxItem5.Text = "พนักงาน Full Time"
        '
        'checkBoxItem6
        '
        Me.checkBoxItem6.Name = "checkBoxItem6"
        Me.checkBoxItem6.Text = "พนักงาน Part Time"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = " แผนก"
        '
        'ComboBoxItem2
        '
        Me.ComboBoxItem2.Name = "ComboBoxItem2"
        Me.ComboBoxItem2.TextBoxWidth = 120
        Me.ComboBoxItem2.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(903, 154)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'ApplicationButton1
        '
        Me.ApplicationButton1.AutoExpandOnClick = True
        Me.ApplicationButton1.CanCustomize = False
        Me.ApplicationButton1.Image = CType(resources.GetObject("ApplicationButton1.Image"), System.Drawing.Image)
        Me.ApplicationButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ApplicationButton1.ImagePaddingHorizontal = 0
        Me.ApplicationButton1.ImagePaddingVertical = 0
        Me.ApplicationButton1.Name = "ApplicationButton1"
        Me.ApplicationButton1.ShowSubItems = False
        Me.ApplicationButton1.Text = "&File"
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Checked = True
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RibbonPanel1
        Me.RibbonTabItem1.Text = "ส่ง SMS แบบ Forward"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel2
        Me.RibbonTabItem2.Text = "ส่งแบบเลือกข้อมูล"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ระบบ Send SMS"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "ComboItem1"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "text"
        '
        'main_sms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 568)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_sms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_sms"
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents แผนก As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ApplicationButton1 As DevComponents.DotNetBar.ApplicationButton
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Private WithEvents ribbonBar8 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents itemContainer11 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents checkBoxItem4 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem5 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem6 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents TextBoxItem2 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ข้อความ As DevComponents.DotNetBar.LabelItem
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboBoxItem2 As DevComponents.DotNetBar.TextBoxItem

  
End Class
