<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdevice_printer
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Radiolaserwb = New System.Windows.Forms.RadioButton()
        Me.Radiolaserc = New System.Windows.Forms.RadioButton()
        Me.Radiodot = New System.Windows.Forms.RadioButton()
        Me.Radioinkjet = New System.Windows.Forms.RadioButton()
        Me.Radiosticker = New System.Windows.Forms.RadioButton()
        Me.Radioinkall = New System.Windows.Forms.RadioButton()
        Me.Radiolaserall = New System.Windows.Forms.RadioButton()
        Me.Radiolasermulti = New System.Windows.Forms.RadioButton()
        Me.ComboBoxprinb = New System.Windows.Forms.ComboBox()
        Me.tab2price = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tab2id = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tab2serial = New System.Windows.Forms.TextBox()
        Me.tab2detail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tab2model = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsaveprin = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Radiolaserwb)
        Me.GroupBox2.Controls.Add(Me.Radiolaserc)
        Me.GroupBox2.Controls.Add(Me.Radiodot)
        Me.GroupBox2.Controls.Add(Me.Radioinkjet)
        Me.GroupBox2.Controls.Add(Me.Radiosticker)
        Me.GroupBox2.Controls.Add(Me.Radioinkall)
        Me.GroupBox2.Controls.Add(Me.Radiolaserall)
        Me.GroupBox2.Controls.Add(Me.Radiolasermulti)
        Me.GroupBox2.Location = New System.Drawing.Point(316, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 211)
        Me.GroupBox2.TabIndex = 214
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Type"
        '
        'Radiolaserwb
        '
        Me.Radiolaserwb.AutoSize = True
        Me.Radiolaserwb.Location = New System.Drawing.Point(12, 33)
        Me.Radiolaserwb.Name = "Radiolaserwb"
        Me.Radiolaserwb.Size = New System.Drawing.Size(119, 17)
        Me.Radiolaserwb.TabIndex = 9
        Me.Radiolaserwb.TabStop = True
        Me.Radiolaserwb.Text = "Laser Printer ขาว-ดำ"
        Me.Radiolaserwb.UseVisualStyleBackColor = True
        '
        'Radiolaserc
        '
        Me.Radiolaserc.AutoSize = True
        Me.Radiolaserc.Location = New System.Drawing.Point(12, 69)
        Me.Radiolaserc.Name = "Radiolaserc"
        Me.Radiolaserc.Size = New System.Drawing.Size(93, 17)
        Me.Radiolaserc.TabIndex = 8
        Me.Radiolaserc.TabStop = True
        Me.Radiolaserc.Text = "Laser Printer สี"
        Me.Radiolaserc.UseVisualStyleBackColor = True
        '
        'Radiodot
        '
        Me.Radiodot.AutoSize = True
        Me.Radiodot.Location = New System.Drawing.Point(161, 33)
        Me.Radiodot.Name = "Radiodot"
        Me.Radiodot.Size = New System.Drawing.Size(105, 17)
        Me.Radiodot.TabIndex = 10
        Me.Radiodot.TabStop = True
        Me.Radiodot.Text = "Dot-matrix Printer"
        Me.Radiodot.UseVisualStyleBackColor = True
        '
        'Radioinkjet
        '
        Me.Radioinkjet.AutoSize = True
        Me.Radioinkjet.Location = New System.Drawing.Point(161, 69)
        Me.Radioinkjet.Name = "Radioinkjet"
        Me.Radioinkjet.Size = New System.Drawing.Size(84, 17)
        Me.Radioinkjet.TabIndex = 11
        Me.Radioinkjet.TabStop = True
        Me.Radioinkjet.Text = "Inkjet Printer"
        Me.Radioinkjet.UseVisualStyleBackColor = True
        '
        'Radiosticker
        '
        Me.Radiosticker.AutoSize = True
        Me.Radiosticker.Location = New System.Drawing.Point(11, 95)
        Me.Radiosticker.Name = "Radiosticker"
        Me.Radiosticker.Size = New System.Drawing.Size(91, 17)
        Me.Radiosticker.TabIndex = 12
        Me.Radiosticker.TabStop = True
        Me.Radiosticker.Text = "Sticker Printer"
        Me.Radiosticker.UseVisualStyleBackColor = True
        '
        'Radioinkall
        '
        Me.Radioinkall.AutoSize = True
        Me.Radioinkall.Location = New System.Drawing.Point(11, 131)
        Me.Radioinkall.Name = "Radioinkall"
        Me.Radioinkall.Size = New System.Drawing.Size(96, 17)
        Me.Radioinkall.TabIndex = 131
        Me.Radioinkall.TabStop = True
        Me.Radioinkall.Text = "Inkjet-all in one"
        Me.Radioinkall.UseVisualStyleBackColor = True
        '
        'Radiolaserall
        '
        Me.Radiolaserall.AutoSize = True
        Me.Radiolaserall.Location = New System.Drawing.Point(161, 95)
        Me.Radiolaserall.Name = "Radiolaserall"
        Me.Radiolaserall.Size = New System.Drawing.Size(96, 17)
        Me.Radiolaserall.TabIndex = 132
        Me.Radiolaserall.TabStop = True
        Me.Radiolaserall.Text = "Laser-all in one"
        Me.Radiolaserall.UseVisualStyleBackColor = True
        '
        'Radiolasermulti
        '
        Me.Radiolasermulti.AutoSize = True
        Me.Radiolasermulti.Location = New System.Drawing.Point(161, 131)
        Me.Radiolasermulti.Name = "Radiolasermulti"
        Me.Radiolasermulti.Size = New System.Drawing.Size(113, 17)
        Me.Radiolasermulti.TabIndex = 133
        Me.Radiolasermulti.TabStop = True
        Me.Radiolasermulti.Text = "Laser-multifunction"
        Me.Radiolasermulti.UseVisualStyleBackColor = True
        '
        'ComboBoxprinb
        '
        Me.ComboBoxprinb.FormattingEnabled = True
        Me.ComboBoxprinb.Location = New System.Drawing.Point(115, 53)
        Me.ComboBoxprinb.Name = "ComboBoxprinb"
        Me.ComboBoxprinb.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxprinb.TabIndex = 213
        '
        'tab2price
        '
        Me.tab2price.Location = New System.Drawing.Point(115, 172)
        Me.tab2price.Name = "tab2price"
        Me.tab2price.Size = New System.Drawing.Size(55, 20)
        Me.tab2price.TabIndex = 204
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(72, 172)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(37, 13)
        Me.Label56.TabIndex = 211
        Me.Label56.Text = "Price :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(85, 27)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(24, 13)
        Me.Label36.TabIndex = 210
        Me.Label36.Text = "ID :"
        '
        'tab2id
        '
        Me.tab2id.Location = New System.Drawing.Point(115, 27)
        Me.tab2id.Name = "tab2id"
        Me.tab2id.ReadOnly = True
        Me.tab2id.Size = New System.Drawing.Size(55, 20)
        Me.tab2id.TabIndex = 209
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(32, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 208
        Me.Label18.Text = "Serial Nunber :"
        '
        'tab2serial
        '
        Me.tab2serial.Location = New System.Drawing.Point(115, 106)
        Me.tab2serial.Name = "tab2serial"
        Me.tab2serial.Size = New System.Drawing.Size(180, 20)
        Me.tab2serial.TabIndex = 201
        '
        'tab2detail
        '
        Me.tab2detail.Location = New System.Drawing.Point(115, 132)
        Me.tab2detail.Multiline = True
        Me.tab2detail.Name = "tab2detail"
        Me.tab2detail.Size = New System.Drawing.Size(180, 34)
        Me.tab2detail.TabIndex = 202
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 207
        Me.Label9.Text = "Detail :"
        '
        'tab2model
        '
        Me.tab2model.Location = New System.Drawing.Point(115, 80)
        Me.tab2model.Name = "tab2model"
        Me.tab2model.Size = New System.Drawing.Size(180, 20)
        Me.tab2model.TabIndex = 200
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 205
        Me.Label8.Text = "Model :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Brand :"
        '
        'btnsaveprin
        '
        Me.btnsaveprin.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveprin.Location = New System.Drawing.Point(500, 253)
        Me.btnsaveprin.Name = "btnsaveprin"
        Me.btnsaveprin.Size = New System.Drawing.Size(108, 34)
        Me.btnsaveprin.TabIndex = 203
        Me.btnsaveprin.Text = "EDIT NOW !!"
        Me.btnsaveprin.UseVisualStyleBackColor = True
        '
        'frmdevice_printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 311)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBoxprinb)
        Me.Controls.Add(Me.tab2price)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.tab2id)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tab2serial)
        Me.Controls.Add(Me.tab2detail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tab2model)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsaveprin)
        Me.DoubleBuffered = True
        Me.Name = "frmdevice_printer"
        Me.Text = ";"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Radiolaserwb As System.Windows.Forms.RadioButton
    Friend WithEvents Radiolaserc As System.Windows.Forms.RadioButton
    Friend WithEvents Radiodot As System.Windows.Forms.RadioButton
    Friend WithEvents Radioinkjet As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosticker As System.Windows.Forms.RadioButton
    Friend WithEvents Radioinkall As System.Windows.Forms.RadioButton
    Friend WithEvents Radiolaserall As System.Windows.Forms.RadioButton
    Friend WithEvents Radiolasermulti As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxprinb As System.Windows.Forms.ComboBox
    Friend WithEvents tab2price As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents tab2id As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tab2serial As System.Windows.Forms.TextBox
    Friend WithEvents tab2detail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tab2model As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnsaveprin As System.Windows.Forms.Button
End Class
