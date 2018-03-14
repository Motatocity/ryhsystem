<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_Show
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtshowreport = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxsearchtype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxsearchagen = New System.Windows.Forms.ComboBox()
        Me.ComboBoxsearchname = New System.Windows.Forms.ComboBox()
        Me.ListViewshow = New System.Windows.Forms.ListView()
        Me.name_container = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ButtonX1.Location = New System.Drawing.Point(505, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14)
        Me.ButtonX1.Size = New System.Drawing.Size(88, 39)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 415
        Me.ButtonX1.Text = "ALL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(630, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 414
        Me.Label5.Text = "จำนวนงาน"
        '
        'txtshowreport
        '
        Me.txtshowreport.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtshowreport.Location = New System.Drawing.Point(633, 29)
        Me.txtshowreport.Name = "txtshowreport"
        Me.txtshowreport.ReadOnly = True
        Me.txtshowreport.Size = New System.Drawing.Size(62, 22)
        Me.txtshowreport.TabIndex = 413
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(331, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "TYPE"
        '
        'ComboBoxsearchtype
        '
        Me.ComboBoxsearchtype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxsearchtype.FormattingEnabled = True
        Me.ComboBoxsearchtype.Items.AddRange(New Object() {"คอมพิวเตอร์", "เครื่องพิมพ์", "เครื่องสแกน", "กล้องวงจรปิด", "LAN", "INTERNET", "Hims", "LAB", "X-RAY", "SERVER", "อื่นๆ"})
        Me.ComboBoxsearchtype.Location = New System.Drawing.Point(334, 29)
        Me.ComboBoxsearchtype.Name = "ComboBoxsearchtype"
        Me.ComboBoxsearchtype.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxsearchtype.TabIndex = 411
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(172, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 410
        Me.Label2.Text = "SECTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "OFFICER"
        '
        'ComboBoxsearchagen
        '
        Me.ComboBoxsearchagen.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxsearchagen.FormattingEnabled = True
        Me.ComboBoxsearchagen.Location = New System.Drawing.Point(175, 29)
        Me.ComboBoxsearchagen.Name = "ComboBoxsearchagen"
        Me.ComboBoxsearchagen.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxsearchagen.TabIndex = 408
        '
        'ComboBoxsearchname
        '
        Me.ComboBoxsearchname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBoxsearchname.FormattingEnabled = True
        Me.ComboBoxsearchname.Location = New System.Drawing.Point(16, 29)
        Me.ComboBoxsearchname.Name = "ComboBoxsearchname"
        Me.ComboBoxsearchname.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxsearchname.TabIndex = 407
        '
        'ListViewshow
        '
        Me.ListViewshow.BackColor = System.Drawing.Color.White
        Me.ListViewshow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.name_container, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader1})
        Me.ListViewshow.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListViewshow.FullRowSelect = True
        Me.ListViewshow.GridLines = True
        Me.ListViewshow.HideSelection = False
        Me.ListViewshow.Location = New System.Drawing.Point(3, 56)
        Me.ListViewshow.Name = "ListViewshow"
        Me.ListViewshow.Size = New System.Drawing.Size(1032, 476)
        Me.ListViewshow.TabIndex = 406
        Me.ListViewshow.UseCompatibleStateImageBehavior = False
        Me.ListViewshow.View = System.Windows.Forms.View.Details
        '
        'name_container
        '
        Me.name_container.Text = "ID"
        Me.name_container.Width = 46
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DETAIL"
        Me.ColumnHeader7.Width = 187
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SLOVE"
        Me.ColumnHeader8.Width = 176
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "USER"
        Me.ColumnHeader9.Width = 97
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "STATUS"
        Me.ColumnHeader10.Width = 95
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "OFFICER"
        Me.ColumnHeader11.Width = 131
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DATE"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SECTION"
        Me.ColumnHeader1.Width = 180
        '
        'Help_Show
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1103, 544)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtshowreport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxsearchtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxsearchagen)
        Me.Controls.Add(Me.ComboBoxsearchname)
        Me.Controls.Add(Me.ListViewshow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Help_Show"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help_Show"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtshowreport As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxsearchtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxsearchagen As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxsearchname As System.Windows.Forms.ComboBox
    Friend WithEvents ListViewshow As System.Windows.Forms.ListView
    Friend WithEvents name_container As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
