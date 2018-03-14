<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check_doctor_add
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(check_doctor_add))
        Me.txt_name_eng = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name_thai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_license = New System.Windows.Forms.TextBox()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'txt_name_eng
        '
        Me.txt_name_eng.BackColor = System.Drawing.Color.Black
        Me.txt_name_eng.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name_eng.ForeColor = System.Drawing.Color.White
        Me.txt_name_eng.Location = New System.Drawing.Point(100, 124)
        Me.txt_name_eng.Name = "txt_name_eng"
        Me.txt_name_eng.Size = New System.Drawing.Size(337, 34)
        Me.txt_name_eng.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "NAME :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 21)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "ชื่อ :"
        '
        'txt_name_thai
        '
        Me.txt_name_thai.BackColor = System.Drawing.Color.Black
        Me.txt_name_thai.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name_thai.ForeColor = System.Drawing.Color.White
        Me.txt_name_thai.Location = New System.Drawing.Point(100, 81)
        Me.txt_name_thai.Name = "txt_name_thai"
        Me.txt_name_thai.Size = New System.Drawing.Size(337, 34)
        Me.txt_name_thai.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Licence :"
        '
        'txt_license
        '
        Me.txt_license.BackColor = System.Drawing.Color.Black
        Me.txt_license.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_license.ForeColor = System.Drawing.Color.White
        Me.txt_license.Location = New System.Drawing.Point(100, 170)
        Me.txt_license.Name = "txt_license"
        Me.txt_license.Size = New System.Drawing.Size(337, 34)
        Me.txt_license.TabIndex = 128
        '
        'labelX4
        '
        Me.labelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX4.ForeColor = System.Drawing.Color.White
        Me.labelX4.Location = New System.Drawing.Point(28, 23)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(248, 35)
        Me.labelX4.TabIndex = 150
        Me.labelX4.Text = "เพิ่มข้อมูลแพทย์"
        Me.labelX4.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.labelX4.WordWrap = True
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.CommandParameter = ""
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(328, 213)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(109, 38)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 151
        Me.ButtonX2.Text = "เพิ่ม"
        '
        'check_doctor_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 263)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.labelX4)
        Me.Controls.Add(Me.txt_license)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_name_thai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name_eng)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "check_doctor_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_name_eng As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_name_thai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_license As System.Windows.Forms.TextBox
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
