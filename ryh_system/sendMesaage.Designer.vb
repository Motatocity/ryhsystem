<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sendMesaage
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.sendmassage = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.sendto = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ryh_system.My.Resources.Resources.User_With_Frame
        Me.PictureBox2.Location = New System.Drawing.Point(32, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ryh_system.My.Resources.Resources.w8_power
        Me.PictureBox1.Location = New System.Drawing.Point(479, 296)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(371, 252)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(94, 35)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 13
        Me.ButtonX1.Text = "Send Message"
        '
        'sendmassage
        '
        Me.sendmassage.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sendmassage.Border.Class = "TextBoxBorder"
        Me.sendmassage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sendmassage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendmassage.ForeColor = System.Drawing.Color.Black
        Me.sendmassage.Location = New System.Drawing.Point(149, 132)
        Me.sendmassage.Multiline = True
        Me.sendmassage.Name = "sendmassage"
        Me.sendmassage.Size = New System.Drawing.Size(316, 114)
        Me.sendmassage.TabIndex = 12
        Me.sendmassage.WatermarkText = "ระบุข้อความ"
        '
        'sendto
        '
        Me.sendto.AutoCompleteCustomSource.AddRange(New String() {"พี่น้อย", "พี่ตูน", "พี่นุช", "แผนก IT"})
        Me.sendto.DisplayMember = "Text"
        Me.sendto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.sendto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendto.FormattingEnabled = True
        Me.sendto.ItemHeight = 23
        Me.sendto.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.sendto.Location = New System.Drawing.Point(149, 32)
        Me.sendto.Name = "sendto"
        Me.sendto.Size = New System.Drawing.Size(201, 29)
        Me.sendto.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.sendto.TabIndex = 11
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "พี่น้อย"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "พี่ตูน"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "พี่นุช"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "แผนก IT"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ryh_system.My.Resources.Resources.Documents_Library
        Me.PictureBox3.Location = New System.Drawing.Point(32, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(88, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'sendMesaage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ryh_system.My.Resources.Resources.login_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 387)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.sendmassage)
        Me.Controls.Add(Me.sendto)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sendMesaage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sendMesaage"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents sendmassage As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents sendto As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
