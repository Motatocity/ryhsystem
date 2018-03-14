<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrpt_computer
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
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport21 = New ryh_system.CrystalReport2()
        Me.SuspendLayout()
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.BackColor = System.Drawing.Color.White
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperGridControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridControl1.Location = New System.Drawing.Point(77, 249)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        Me.SuperGridControl1.Size = New System.Drawing.Size(669, 384)
        Me.SuperGridControl1.TabIndex = 0
        Me.SuperGridControl1.Text = "SuperGridControl1"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport21
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(920, 680)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'frmrpt_computer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 680)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.SuperGridControl1)
        Me.Name = "frmrpt_computer"
        Me.Text = "frmrpt_computer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As ryh_system.CrystalReport2
End Class
