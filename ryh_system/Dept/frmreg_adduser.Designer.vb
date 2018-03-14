<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreg_adduser
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(466, 156)
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
        Me.llogin.Size = New System.Drawing.Size(147, 45)
        Me.llogin.TabIndex = 0
        Me.llogin.Text = "เพิ่ม ข้อมูลผู้ใช้"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.llogin)
        Me.Panel2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(17, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 53)
        Me.Panel2.TabIndex = 187
        '
        'txtcustomer_address
        '
        Me.txtcustomer_address.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.txtcustomer_address.Location = New System.Drawing.Point(146, 170)
        Me.txtcustomer_address.Name = "txtcustomer_address"
        Me.txtcustomer_address.Size = New System.Drawing.Size(215, 34)
        Me.txtcustomer_address.TabIndex = 184
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "เบอร์โทร"
        '
        'txtcustomer
        '
        Me.txtcustomer.BackColor = System.Drawing.SystemColors.Window
        Me.txtcustomer.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomer.Location = New System.Drawing.Point(145, 93)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(421, 34)
        Me.txtcustomer.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 26)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "ชื่อ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 26)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "ชื่อเล่น"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.TextBox1.Location = New System.Drawing.Point(146, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 34)
        Me.TextBox1.TabIndex = 190
        '
        'frmreg_adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 241)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtcustomer_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmreg_adduser"
        Me.Text = "frmreg_adduser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
