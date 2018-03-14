<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnure_rpt
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
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.MaskedTextBoxAdv1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxAdv2 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(265, 23)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(73, 27)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 235
        Me.ButtonX2.Text = "ประมวล"
        '
        'MaskedTextBoxAdv1
        '
        '
        '
        '
        Me.MaskedTextBoxAdv1.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv1.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxAdv1.Location = New System.Drawing.Point(174, 25)
        Me.MaskedTextBoxAdv1.Mask = "00-00-0000"
        Me.MaskedTextBoxAdv1.Name = "MaskedTextBoxAdv1"
        Me.MaskedTextBoxAdv1.Size = New System.Drawing.Size(83, 22)
        Me.MaskedTextBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.MaskedTextBoxAdv1.TabIndex = 234
        Me.MaskedTextBoxAdv1.Text = ""
        Me.MaskedTextBoxAdv1.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "ถึง"
        '
        'MaskedTextBoxAdv2
        '
        '
        '
        '
        Me.MaskedTextBoxAdv2.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv2.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxAdv2.Location = New System.Drawing.Point(59, 25)
        Me.MaskedTextBoxAdv2.Mask = "00-00-0000"
        Me.MaskedTextBoxAdv2.Name = "MaskedTextBoxAdv2"
        Me.MaskedTextBoxAdv2.Size = New System.Drawing.Size(83, 22)
        Me.MaskedTextBoxAdv2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.MaskedTextBoxAdv2.TabIndex = 232
        Me.MaskedTextBoxAdv2.Text = ""
        Me.MaskedTextBoxAdv2.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "วันที่"
        '
        'CircularProgress1
        '
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(344, 12)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.CircularProgress1.Size = New System.Drawing.Size(76, 47)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 236
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 237
        '
        'frmnure_rpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 801)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.MaskedTextBoxAdv1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaskedTextBoxAdv2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmnure_rpt"
        Me.Text = "frmnure_rpt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MaskedTextBoxAdv1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxAdv2 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
