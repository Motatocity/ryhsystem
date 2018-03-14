<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT_FLOOR
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
        Me.txtidfloor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnamefloor = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListViewfloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtidfloor
        '
        Me.txtidfloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidfloor.Location = New System.Drawing.Point(96, 38)
        Me.txtidfloor.Name = "txtidfloor"
        Me.txtidfloor.ReadOnly = True
        Me.txtidfloor.Size = New System.Drawing.Size(54, 34)
        Me.txtidfloor.TabIndex = 350
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidfloor)
        Me.GroupBox1.Controls.Add(Me.txtnamefloor)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 212)
        Me.GroupBox1.TabIndex = 361
        Me.GroupBox1.TabStop = False
        '
        'txtnamefloor
        '
        Me.txtnamefloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamefloor.Location = New System.Drawing.Point(96, 78)
        Me.txtnamefloor.Name = "txtnamefloor"
        Me.txtnamefloor.Size = New System.Drawing.Size(150, 34)
        Me.txtnamefloor.TabIndex = 351
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(187, 166)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 40)
        Me.btndelete.TabIndex = 355
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 26)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "ID :"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(86, 166)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 40)
        Me.btnsave.TabIndex = 354
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 26)
        Me.Label4.TabIndex = 353
        Me.Label4.Text = "FLOOR :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(484, 524)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 360
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(570, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 359
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListViewfloor
        '
        Me.ListViewfloor.BackColor = System.Drawing.Color.White
        Me.ListViewfloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListViewfloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewfloor.FullRowSelect = True
        Me.ListViewfloor.GridLines = True
        Me.ListViewfloor.HideSelection = False
        Me.ListViewfloor.Location = New System.Drawing.Point(25, 38)
        Me.ListViewfloor.Name = "ListViewfloor"
        Me.ListViewfloor.Size = New System.Drawing.Size(257, 484)
        Me.ListViewfloor.TabIndex = 348
        Me.ListViewfloor.UseCompatibleStateImageBehavior = False
        Me.ListViewfloor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 70
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "FLOOR"
        Me.ColumnHeader21.Width = 180
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewfloor)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 545)
        Me.GroupBox2.TabIndex = 362
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FLOOR"
        '
        'EDIT_FLOOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "EDIT_FLOOR"
        Me.Text = "EDIT_FLOOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtidfloor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnamefloor As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListViewfloor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
