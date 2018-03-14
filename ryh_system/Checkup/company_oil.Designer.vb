<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class company_oil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(company_oil))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comaddress = New System.Windows.Forms.RichTextBox()
        Me.txt_comfax = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_comtell = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_comname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพิ่มข้อมูลบริษัท"
        '
        'txt_comaddress
        '
        Me.txt_comaddress.BackColor = System.Drawing.SystemColors.Window
        Me.txt_comaddress.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comaddress.Location = New System.Drawing.Point(118, 122)
        Me.txt_comaddress.Name = "txt_comaddress"
        Me.txt_comaddress.Size = New System.Drawing.Size(337, 96)
        Me.txt_comaddress.TabIndex = 2
        Me.txt_comaddress.Text = ""
        '
        'txt_comfax
        '
        Me.txt_comfax.BackColor = System.Drawing.SystemColors.Window
        Me.txt_comfax.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comfax.Location = New System.Drawing.Point(118, 281)
        Me.txt_comfax.Name = "txt_comfax"
        Me.txt_comfax.Size = New System.Drawing.Size(283, 34)
        Me.txt_comfax.TabIndex = 4
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = Global.ryh_system.My.Resources.Resources.Add
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(373, 348)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(82, 41)
        Me.btnsave.TabIndex = 127
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 26)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "FAX :"
        '
        'txt_comtell
        '
        Me.txt_comtell.BackColor = System.Drawing.SystemColors.Window
        Me.txt_comtell.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comtell.Location = New System.Drawing.Point(118, 233)
        Me.txt_comtell.Name = "txt_comtell"
        Me.txt_comtell.Size = New System.Drawing.Size(283, 34)
        Me.txt_comtell.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "TELLEPHONE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "ADDRESS :"
        '
        'txt_comname
        '
        Me.txt_comname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_comname.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comname.Location = New System.Drawing.Point(118, 79)
        Me.txt_comname.Name = "txt_comname"
        Me.txt_comname.Size = New System.Drawing.Size(337, 34)
        Me.txt_comname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 26)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "NAME :"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.ryh_system.My.Resources.Resources.home32
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(32, 348)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 41)
        Me.Button3.TabIndex = 161
        Me.Button3.Text = "Home"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 45)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "เพิ่มข้อมูลบริษัท"
        '
        'company_oil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ryh_system.My.Resources.Resources.main
        Me.ClientSize = New System.Drawing.Size(505, 421)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_comaddress)
        Me.Controls.Add(Me.txt_comfax)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_comtell)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_comname)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "company_oil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "company_oil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_comaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_comfax As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_comtell As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_comname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

