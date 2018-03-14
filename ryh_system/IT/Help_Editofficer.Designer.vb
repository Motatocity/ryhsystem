<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_Editofficer
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
        Me.btnxback = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListViewofficer = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.txtnameofficer = New System.Windows.Forms.TextBox()
        Me.btnxsave = New DevComponents.DotNetBar.ButtonX()
        Me.txtidofficer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnxback
        '
        Me.btnxback.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxback.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxback.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxback.Location = New System.Drawing.Point(538, 207)
        Me.btnxback.Name = "btnxback"
        Me.btnxback.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14, 2, 2, 14)
        Me.btnxback.Size = New System.Drawing.Size(82, 39)
        Me.btnxback.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnxback.Symbol = ""
        Me.btnxback.TabIndex = 407
        Me.btnxback.Text = "BACK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewofficer)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 519)
        Me.GroupBox2.TabIndex = 406
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OFFICER"
        '
        'ListViewofficer
        '
        Me.ListViewofficer.BackColor = System.Drawing.Color.White
        Me.ListViewofficer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListViewofficer.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewofficer.FullRowSelect = True
        Me.ListViewofficer.GridLines = True
        Me.ListViewofficer.HideSelection = False
        Me.ListViewofficer.Location = New System.Drawing.Point(18, 19)
        Me.ListViewofficer.Name = "ListViewofficer"
        Me.ListViewofficer.Size = New System.Drawing.Size(257, 484)
        Me.ListViewofficer.TabIndex = 364
        Me.ListViewofficer.UseCompatibleStateImageBehavior = False
        Me.ListViewofficer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 70
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "OFFICER"
        Me.ColumnHeader21.Width = 180
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonX6)
        Me.GroupBox1.Controls.Add(Me.txtnameofficer)
        Me.GroupBox1.Controls.Add(Me.btnxsave)
        Me.GroupBox1.Controls.Add(Me.txtidofficer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(320, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 189)
        Me.GroupBox1.TabIndex = 405
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDIT"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX6.Location = New System.Drawing.Point(178, 118)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.ButtonX6.Size = New System.Drawing.Size(81, 32)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.Symbol = ""
        Me.ButtonX6.TabIndex = 406
        Me.ButtonX6.Text = "Delete"
        '
        'txtnameofficer
        '
        Me.txtnameofficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtnameofficer.Location = New System.Drawing.Point(99, 66)
        Me.txtnameofficer.Name = "txtnameofficer"
        Me.txtnameofficer.Size = New System.Drawing.Size(150, 29)
        Me.txtnameofficer.TabIndex = 367
        '
        'btnxsave
        '
        Me.btnxsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxsave.Location = New System.Drawing.Point(86, 118)
        Me.btnxsave.Name = "btnxsave"
        Me.btnxsave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnxsave.Size = New System.Drawing.Size(86, 32)
        Me.btnxsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnxsave.Symbol = ""
        Me.btnxsave.TabIndex = 405
        Me.btnxsave.Text = "Save"
        '
        'txtidofficer
        '
        Me.txtidofficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtidofficer.Location = New System.Drawing.Point(99, 31)
        Me.txtidofficer.Name = "txtidofficer"
        Me.txtidofficer.ReadOnly = True
        Me.txtidofficer.Size = New System.Drawing.Size(54, 29)
        Me.txtidofficer.TabIndex = 366
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 26)
        Me.Label2.TabIndex = 368
        Me.Label2.Text = "ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 26)
        Me.Label4.TabIndex = 369
        Me.Label4.Text = "BRAND :"
        '
        'Help_Editofficer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(642, 546)
        Me.Controls.Add(Me.btnxback)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Help_Editofficer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help_Editofficer"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnxback As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewofficer As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtnameofficer As System.Windows.Forms.TextBox
    Friend WithEvents btnxsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtidofficer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
