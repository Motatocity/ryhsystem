<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pramern_add_price
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pramern_add_price))
        Me.surDiag = New System.Windows.Forms.ComboBox()
        Me.surtyp = New System.Windows.Forms.ComboBox()
        Me.group_sur = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name_thai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.idlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'surDiag
        '
        Me.surDiag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.surDiag.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.surDiag.FormattingEnabled = True
        Me.surDiag.Location = New System.Drawing.Point(156, 157)
        Me.surDiag.Name = "surDiag"
        Me.surDiag.Size = New System.Drawing.Size(224, 34)
        Me.surDiag.TabIndex = 104
        '
        'surtyp
        '
        Me.surtyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.surtyp.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.surtyp.FormattingEnabled = True
        Me.surtyp.Location = New System.Drawing.Point(156, 116)
        Me.surtyp.Name = "surtyp"
        Me.surtyp.Size = New System.Drawing.Size(121, 34)
        Me.surtyp.TabIndex = 103
        '
        'group_sur
        '
        Me.group_sur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.group_sur.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.group_sur.FormattingEnabled = True
        Me.group_sur.Location = New System.Drawing.Point(156, 72)
        Me.group_sur.Name = "group_sur"
        Me.group_sur.Size = New System.Drawing.Size(121, 34)
        Me.group_sur.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(53, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 26)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(52, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 26)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "กลุ่มโรค"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(53, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 26)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "ชื่อโรค"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(53, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 26)
        Me.Label4.TabIndex = 332
        Me.Label4.Text = "ชื่อโรคภาษาไทย"
        '
        'txt_name_thai
        '
        Me.txt_name_thai.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name_thai.Location = New System.Drawing.Point(156, 201)
        Me.txt_name_thai.Name = "txt_name_thai"
        Me.txt_name_thai.Size = New System.Drawing.Size(190, 29)
        Me.txt_name_thai.TabIndex = 331
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 37)
        Me.Label5.TabIndex = 333
        Me.Label5.Text = "เพิ่มข้อมูลโรคประเมินราคา"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(374, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 39)
        Me.Button1.TabIndex = 334
        Me.Button1.Text = "บันทึก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Button2.Location = New System.Drawing.Point(32, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 39)
        Me.Button2.TabIndex = 335
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'idlabel
        '
        Me.idlabel.AutoSize = True
        Me.idlabel.BackColor = System.Drawing.Color.Transparent
        Me.idlabel.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.idlabel.Location = New System.Drawing.Point(386, 165)
        Me.idlabel.Name = "idlabel"
        Me.idlabel.Size = New System.Drawing.Size(24, 26)
        Me.idlabel.TabIndex = 336
        Me.idlabel.Text = "ID"
        '
        'pramern_add_price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 354)
        Me.Controls.Add(Me.idlabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_name_thai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.surDiag)
        Me.Controls.Add(Me.surtyp)
        Me.Controls.Add(Me.group_sur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pramern_add_price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pramern_add_price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents surDiag As System.Windows.Forms.ComboBox
    Friend WithEvents surtyp As System.Windows.Forms.ComboBox
    Friend WithEvents group_sur As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_name_thai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents idlabel As System.Windows.Forms.Label
End Class
