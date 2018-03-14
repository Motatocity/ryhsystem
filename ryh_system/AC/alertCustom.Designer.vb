<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alertCustom
    Inherits DevComponents.DotNetBar.Balloon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alertCustom))
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ReflectionImage2 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.SuspendLayout()
        '
        'labelX2
        '
        Me.labelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(84, 66)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(184, 40)
        Me.labelX2.TabIndex = 14
        Me.labelX2.Text = "มีปัญหาการใช้งาน หรือ ข้อสงสัย โทร 258"
        Me.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.labelX2.WordWrap = True
        '
        'labelX1
        '
        Me.labelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.ForeColor = System.Drawing.Color.Blue
        Me.labelX1.Location = New System.Drawing.Point(84, 13)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(184, 31)
        Me.labelX1.TabIndex = 13
        Me.labelX1.Text = "<b>Update โปรแกรม Risk book 24/11/2557 </b>"
        '
        'ReflectionImage2
        '
        Me.ReflectionImage2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionImage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage2.Image = CType(resources.GetObject("ReflectionImage2.Image"), System.Drawing.Image)
        Me.ReflectionImage2.Location = New System.Drawing.Point(12, 6)
        Me.ReflectionImage2.Name = "ReflectionImage2"
        Me.ReflectionImage2.Size = New System.Drawing.Size(64, 100)
        Me.ReflectionImage2.TabIndex = 15
        '
        'alertCustom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 136)
        Me.Controls.Add(Me.ReflectionImage2)
        Me.Controls.Add(Me.labelX2)
        Me.Controls.Add(Me.labelX1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "alertCustom"
        Me.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionImage2 As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
