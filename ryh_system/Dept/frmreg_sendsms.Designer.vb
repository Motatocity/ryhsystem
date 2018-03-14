<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreg_sendsms
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.id_customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.MaskedTextBoxAdv1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.RichTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_customer, Me.ColumnHeader1, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 14)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(277, 216)
        Me.ListView1.TabIndex = 201
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
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ชื่อย่อ"
        Me.ColumnHeader7.Width = 62
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.White
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(15, 266)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(411, 216)
        Me.ListView2.TabIndex = 202
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 61
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ชื่อ"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ชื่อเล่น"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "เบอร์โทร"
        Me.ColumnHeader5.Width = 120
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.Color.White
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader14})
        Me.ListView3.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(382, 17)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(379, 216)
        Me.ListView3.TabIndex = 203
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 61
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ชื่อแผนก"
        Me.ColumnHeader8.Width = 235
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ชื่อย่อ"
        Me.ColumnHeader9.Width = 109
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "จำนวน"
        Me.ColumnHeader14.Width = 106
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.Color.White
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView4.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(525, 266)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(438, 216)
        Me.ListView4.TabIndex = 204
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID"
        Me.ColumnHeader10.Width = 61
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ชื่อ"
        Me.ColumnHeader11.Width = 180
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ชื่อเล่น"
        Me.ColumnHeader12.Width = 80
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "เบอร์โทร"
        Me.ColumnHeader13.Width = 120
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(432, 365)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 33)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 205
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(432, 419)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 33)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 206
        Me.ButtonX2.Text = "ทั้งหมด"
        '
        'MaskedTextBoxAdv1
        '
        '
        '
        '
        Me.MaskedTextBoxAdv1.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv1.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.MaskedTextBoxAdv1.Location = New System.Drawing.Point(200, 236)
        Me.MaskedTextBoxAdv1.Mask = "000"
        Me.MaskedTextBoxAdv1.Name = "MaskedTextBoxAdv1"
        Me.MaskedTextBoxAdv1.Size = New System.Drawing.Size(49, 25)
        Me.MaskedTextBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.MaskedTextBoxAdv1.TabIndex = 207
        Me.MaskedTextBoxAdv1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(145, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 26)
        Me.Label1.TabIndex = 208
        Me.Label1.Text = "จำนวน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(264, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 26)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "คน"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(298, 100)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 33)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(767, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 26)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "ข้อความ"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(868, 491)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(95, 42)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.TabIndex = 213
        Me.ButtonX4.Text = "Send"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Location = New System.Drawing.Point(343, 491)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(95, 42)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX5.Symbol = ""
        Me.ButtonX5.TabIndex = 214
        Me.ButtonX5.Text = "Refresh"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(834, 17)
        Me.RichTextBox1.Multiline = True
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(185, 213)
        Me.RichTextBox1.TabIndex = 215
        '
        'frmreg_sendsms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 626)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ButtonX5)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBoxAdv1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmreg_sendsms"
        Me.Text = "frmreg_sendsms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents id_customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MaskedTextBoxAdv1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RichTextBox1 As System.Windows.Forms.TextBox
End Class
