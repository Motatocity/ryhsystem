<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_diag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_diag))
        Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsearch_diag = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListViewEx1
        '
        Me.ListViewEx1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ListViewEx1.Border.Class = "ListViewBorder"
        Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListViewEx1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewEx1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListViewEx1.ForeColor = System.Drawing.Color.Black
        Me.ListViewEx1.FullRowSelect = True
        Me.ListViewEx1.GridLines = True
        Me.ListViewEx1.Location = New System.Drawing.Point(32, 85)
        Me.ListViewEx1.Name = "ListViewEx1"
        Me.ListViewEx1.Size = New System.Drawing.Size(522, 236)
        Me.ListViewEx1.TabIndex = 0
        Me.ListViewEx1.UseCompatibleStateImageBehavior = False
        Me.ListViewEx1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ชื่อโรค"
        Me.ColumnHeader2.Width = 228
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Diag"
        Me.ColumnHeader3.Width = 206
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(32, 334)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 34)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX2.TabIndex = 349
        Me.ButtonX2.Text = "Home"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(479, 334)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 34)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX1.TabIndex = 350
        Me.ButtonX1.Text = "Edit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(31, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 26)
        Me.Label4.TabIndex = 351
        Me.Label4.Text = "ค้นหาข้อมูลโรค"
        '
        'txtsearch_diag
        '
        Me.txtsearch_diag.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_diag.Location = New System.Drawing.Point(129, 45)
        Me.txtsearch_diag.Name = "txtsearch_diag"
        Me.txtsearch_diag.Size = New System.Drawing.Size(425, 30)
        Me.txtsearch_diag.TabIndex = 352
        '
        'edit_diag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 382)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsearch_diag)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ListViewEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "edit_diag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsearch_diag As System.Windows.Forms.TextBox
End Class
