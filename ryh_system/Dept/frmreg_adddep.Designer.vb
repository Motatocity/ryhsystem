<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreg_adddep
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
        Me.txtcustomer_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.llogin = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcustomer_address
        '
        Me.txtcustomer_address.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.txtcustomer_address.Location = New System.Drawing.Point(132, 131)
        Me.txtcustomer_address.Name = "txtcustomer_address"
        Me.txtcustomer_address.Size = New System.Drawing.Size(101, 34)
        Me.txtcustomer_address.TabIndex = 178
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 26)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "ชื่อย่อ"
        '
        'txtcustomer
        '
        Me.txtcustomer.BackColor = System.Drawing.SystemColors.Window
        Me.txtcustomer.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomer.Location = New System.Drawing.Point(131, 83)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(421, 34)
        Me.txtcustomer.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 26)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "ชื่อแผนก"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.llogin)
        Me.Panel2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 53)
        Me.Panel2.TabIndex = 181
        '
        'llogin
        '
        Me.llogin.AutoSize = True
        Me.llogin.Font = New System.Drawing.Font("Cordia New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.llogin.Location = New System.Drawing.Point(3, 3)
        Me.llogin.Name = "llogin"
        Me.llogin.Size = New System.Drawing.Size(113, 45)
        Me.llogin.TabIndex = 0
        Me.llogin.Text = "เพิ่ม แผนก"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(452, 134)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.ButtonX1.Size = New System.Drawing.Size(111, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 25.0!
        Me.ButtonX1.TabIndex = 182
        Me.ButtonX1.Text = "Save"
        '
        'frmreg_adddep
        '
        Me.ClientSize = New System.Drawing.Size(598, 204)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtcustomer_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmreg_adddep"
        Me.Text = "frmreg_adddep"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcustomer_address As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents llogin As System.Windows.Forms.Label
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
