<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_pramern_diag
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
        Me.txt_name_thai = New System.Windows.Forms.TextBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'txt_name_thai
        '
        Me.txt_name_thai.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name_thai.Location = New System.Drawing.Point(141, 122)
        Me.txt_name_thai.Name = "txt_name_thai"
        Me.txt_name_thai.Size = New System.Drawing.Size(190, 29)
        Me.txt_name_thai.TabIndex = 336
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.CommandParameter = ""
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(275, 183)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(109, 38)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 342
        Me.ButtonX2.Text = "บันทึก"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.CommandParameter = ""
        Me.ButtonX4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.Location = New System.Drawing.Point(35, 183)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(109, 38)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.TabIndex = 343
        Me.ButtonX4.Text = "Home"
        '
        'labelX4
        '
        Me.labelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX4.ForeColor = System.Drawing.Color.Black
        Me.labelX4.Location = New System.Drawing.Point(35, 36)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(248, 35)
        Me.labelX4.TabIndex = 344
        Me.labelX4.Text = "เพิ่มข้อมูลโรคประเมินราคา"
        Me.labelX4.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.labelX4.WordWrap = True
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(64, 120)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(71, 35)
        Me.LabelX1.TabIndex = 345
        Me.LabelX1.Text = "ชื่อโรค"
        Me.LabelX1.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.LabelX1.WordWrap = True
        '
        'edit_pramern_diag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 280)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.labelX4)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.txt_name_thai)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "edit_pramern_diag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_name_thai As System.Windows.Forms.TextBox
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
