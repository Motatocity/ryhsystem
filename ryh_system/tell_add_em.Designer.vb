<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tell_add_em
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tell_add_em))
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_clinic = New System.Windows.Forms.TextBox()
        Me.Txt_home = New System.Windows.Forms.TextBox()
        Me.Txt_mobile = New System.Windows.Forms.TextBox()
        Me.Combo_sec = New System.Windows.Forms.ComboBox()
        Me.Txt_bra = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(26, 386)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(85, 43)
        Me.btn_home.TabIndex = 189
        Me.btn_home.Text = "HOME"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(403, 386)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(85, 43)
        Me.btn_save.TabIndex = 188
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_clinic
        '
        Me.txt_clinic.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.txt_clinic.Location = New System.Drawing.Point(217, 319)
        Me.txt_clinic.Name = "txt_clinic"
        Me.txt_clinic.Size = New System.Drawing.Size(182, 34)
        Me.txt_clinic.TabIndex = 187
        '
        'Txt_home
        '
        Me.Txt_home.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Txt_home.Location = New System.Drawing.Point(217, 275)
        Me.Txt_home.Name = "Txt_home"
        Me.Txt_home.Size = New System.Drawing.Size(182, 34)
        Me.Txt_home.TabIndex = 186
        '
        'Txt_mobile
        '
        Me.Txt_mobile.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Txt_mobile.Location = New System.Drawing.Point(217, 236)
        Me.Txt_mobile.Name = "Txt_mobile"
        Me.Txt_mobile.Size = New System.Drawing.Size(182, 34)
        Me.Txt_mobile.TabIndex = 185
        '
        'Combo_sec
        '
        Me.Combo_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_sec.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Combo_sec.FormattingEnabled = True
        Me.Combo_sec.Items.AddRange(New Object() {"เจ้าหน้าที่ / พนักงาน", "แพทย์ / พยาบาล", "ผู้บริหาร / หัวหน้างาน", "ผู้บริหาร"})
        Me.Combo_sec.Location = New System.Drawing.Point(217, 153)
        Me.Combo_sec.Name = "Combo_sec"
        Me.Combo_sec.Size = New System.Drawing.Size(141, 34)
        Me.Combo_sec.TabIndex = 184
        '
        'Txt_bra
        '
        Me.Txt_bra.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Txt_bra.Location = New System.Drawing.Point(217, 196)
        Me.Txt_bra.Name = "Txt_bra"
        Me.Txt_bra.Size = New System.Drawing.Size(182, 34)
        Me.Txt_bra.TabIndex = 183
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.txt_name.Location = New System.Drawing.Point(217, 113)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(223, 34)
        Me.txt_name.TabIndex = 182
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(123, 319)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 26)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "เบอร์คลีนิก  ::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(132, 283)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 26)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "เบอร์บ้าน  ::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(125, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 26)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "เบอร์มือถือ  ::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(154, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 26)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "สาขา  ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(149, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 26)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "แผนก  ::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(142, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "ชื่อ สกุล  ::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "เพิ่มข้อมูลบุคลากร"
        '
        'tell_add_em
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ryh_system.My.Resources.Resources.maintel3
        Me.ClientSize = New System.Drawing.Size(516, 458)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_clinic)
        Me.Controls.Add(Me.Txt_home)
        Me.Controls.Add(Me.Txt_mobile)
        Me.Controls.Add(Me.Combo_sec)
        Me.Controls.Add(Me.Txt_bra)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tell_add_em"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tell_add_em"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_home As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_clinic As System.Windows.Forms.TextBox
    Friend WithEvents Txt_home As System.Windows.Forms.TextBox
    Friend WithEvents Txt_mobile As System.Windows.Forms.TextBox
    Friend WithEvents Combo_sec As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_bra As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
