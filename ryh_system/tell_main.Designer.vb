<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tell_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tell_main))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.เบอร์โทรศัพท์บุคลากร = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(248, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 107)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "เบอร์โทรศัพท์ แพทย์"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(212, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 107)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "เบอร์โทรศัพท์บริษัท"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'เบอร์โทรศัพท์บุคลากร
        '
        Me.เบอร์โทรศัพท์บุคลากร.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.เบอร์โทรศัพท์บุคลากร.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.เบอร์โทรศัพท์บุคลากร.ForeColor = System.Drawing.Color.Black
        Me.เบอร์โทรศัพท์บุคลากร.Location = New System.Drawing.Point(380, 108)
        Me.เบอร์โทรศัพท์บุคลากร.Name = "เบอร์โทรศัพท์บุคลากร"
        Me.เบอร์โทรศัพท์บุคลากร.Size = New System.Drawing.Size(107, 107)
        Me.เบอร์โทรศัพท์บุคลากร.TabIndex = 4
        Me.เบอร์โทรศัพท์บุคลากร.Text = "เบอร์โทรศัพท์บุคลากร"
        Me.เบอร์โทรศัพท์บุคลากร.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(349, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 107)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "เบอร์โทรศัพท์ประกัน"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tell_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ryh_system.My.Resources.Resources.login_background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.เบอร์โทรศัพท์บุคลากร)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tell_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบค้นหาโทรศัพท์"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents เบอร์โทรศัพท์บุคลากร As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
