<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdevice_monitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdevice_monitor))
        Me.ComboBoxmonitorb = New System.Windows.Forms.ComboBox()
        Me.tab1price = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tab1id = New System.Windows.Forms.TextBox()
        Me.tab1serial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnsavemonitor = New System.Windows.Forms.Button()
        Me.tab1detail = New System.Windows.Forms.TextBox()
        Me.tab1model = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tab1size = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBoxmonitorb
        '
        Me.ComboBoxmonitorb.FormattingEnabled = True
        Me.ComboBoxmonitorb.Location = New System.Drawing.Point(131, 34)
        Me.ComboBoxmonitorb.Name = "ComboBoxmonitorb"
        Me.ComboBoxmonitorb.Size = New System.Drawing.Size(181, 21)
        Me.ComboBoxmonitorb.TabIndex = 214
        '
        'tab1price
        '
        Me.tab1price.Location = New System.Drawing.Point(131, 179)
        Me.tab1price.Name = "tab1price"
        Me.tab1price.Size = New System.Drawing.Size(170, 20)
        Me.tab1price.TabIndex = 205
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(88, 179)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(37, 13)
        Me.Label57.TabIndex = 212
        Me.Label57.Text = "Price :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(101, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 13)
        Me.Label35.TabIndex = 211
        Me.Label35.Text = "ID :"
        '
        'tab1id
        '
        Me.tab1id.Location = New System.Drawing.Point(131, 8)
        Me.tab1id.Name = "tab1id"
        Me.tab1id.ReadOnly = True
        Me.tab1id.Size = New System.Drawing.Size(57, 20)
        Me.tab1id.TabIndex = 210
        '
        'tab1serial
        '
        Me.tab1serial.Location = New System.Drawing.Point(132, 113)
        Me.tab1serial.Name = "tab1serial"
        Me.tab1serial.Size = New System.Drawing.Size(180, 20)
        Me.tab1serial.TabIndex = 201
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "Brand :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(87, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 209
        Me.Label17.Text = "Serial :"
        '
        'btnsavemonitor
        '
        Me.btnsavemonitor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavemonitor.Location = New System.Drawing.Point(264, 247)
        Me.btnsavemonitor.Name = "btnsavemonitor"
        Me.btnsavemonitor.Size = New System.Drawing.Size(110, 39)
        Me.btnsavemonitor.TabIndex = 204
        Me.btnsavemonitor.Text = "EDIT NOW !!"
        Me.btnsavemonitor.UseVisualStyleBackColor = True
        '
        'tab1detail
        '
        Me.tab1detail.Location = New System.Drawing.Point(131, 139)
        Me.tab1detail.Multiline = True
        Me.tab1detail.Name = "tab1detail"
        Me.tab1detail.Size = New System.Drawing.Size(181, 34)
        Me.tab1detail.TabIndex = 203
        '
        'tab1model
        '
        Me.tab1model.Location = New System.Drawing.Point(132, 61)
        Me.tab1model.Name = "tab1model"
        Me.tab1model.Size = New System.Drawing.Size(180, 20)
        Me.tab1model.TabIndex = 198
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 208
        Me.Label7.Text = "Detail :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(83, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 202
        Me.Label14.Text = "Model :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(92, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 13)
        Me.Label22.TabIndex = 207
        Me.Label22.Text = "Size :"
        '
        'tab1size
        '
        Me.tab1size.Location = New System.Drawing.Point(131, 87)
        Me.tab1size.Name = "tab1size"
        Me.tab1size.Size = New System.Drawing.Size(75, 20)
        Me.tab1size.TabIndex = 200
        '
        'frmdevice_monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 298)
        Me.Controls.Add(Me.ComboBoxmonitorb)
        Me.Controls.Add(Me.tab1price)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.tab1id)
        Me.Controls.Add(Me.tab1serial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnsavemonitor)
        Me.Controls.Add(Me.tab1detail)
        Me.Controls.Add(Me.tab1model)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tab1size)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmdevice_monitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxmonitorb As System.Windows.Forms.ComboBox
    Friend WithEvents tab1price As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents tab1id As System.Windows.Forms.TextBox
    Friend WithEvents tab1serial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnsavemonitor As System.Windows.Forms.Button
    Friend WithEvents tab1detail As System.Windows.Forms.TextBox
    Friend WithEvents tab1model As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tab1size As System.Windows.Forms.TextBox
End Class
