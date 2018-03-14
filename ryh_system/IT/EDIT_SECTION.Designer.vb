<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT_SECTION
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListVieweditsec = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtnamefloor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtshowcount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidsec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtsection = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(521, 574)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 371
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(607, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 370
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListVieweditsec
        '
        Me.ListVieweditsec.BackColor = System.Drawing.Color.White
        Me.ListVieweditsec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader1})
        Me.ListVieweditsec.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListVieweditsec.FullRowSelect = True
        Me.ListVieweditsec.GridLines = True
        Me.ListVieweditsec.HideSelection = False
        Me.ListVieweditsec.Location = New System.Drawing.Point(15, 31)
        Me.ListVieweditsec.Name = "ListVieweditsec"
        Me.ListVieweditsec.Size = New System.Drawing.Size(326, 514)
        Me.ListVieweditsec.TabIndex = 351
        Me.ListVieweditsec.UseCompatibleStateImageBehavior = False
        Me.ListVieweditsec.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 50
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "FLOOR"
        Me.ColumnHeader21.Width = 70
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SECTION"
        Me.ColumnHeader1.Width = 200
        '
        'txtnamefloor
        '
        Me.txtnamefloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamefloor.Location = New System.Drawing.Point(85, 71)
        Me.txtnamefloor.Name = "txtnamefloor"
        Me.txtnamefloor.ReadOnly = True
        Me.txtnamefloor.Size = New System.Drawing.Size(69, 34)
        Me.txtnamefloor.TabIndex = 357
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 551)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 26)
        Me.Label1.TabIndex = 367
        Me.Label1.Text = "จำนวน"
        '
        'txtshowcount
        '
        Me.txtshowcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtshowcount.Location = New System.Drawing.Point(287, 551)
        Me.txtshowcount.Name = "txtshowcount"
        Me.txtshowcount.ReadOnly = True
        Me.txtshowcount.Size = New System.Drawing.Size(54, 29)
        Me.txtshowcount.TabIndex = 366
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListVieweditsec)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtshowcount)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 602)
        Me.GroupBox1.TabIndex = 372
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Section"
        '
        'txtidsec
        '
        Me.txtidsec.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidsec.Location = New System.Drawing.Point(85, 31)
        Me.txtidsec.Name = "txtidsec"
        Me.txtidsec.ReadOnly = True
        Me.txtidsec.Size = New System.Drawing.Size(54, 34)
        Me.txtidsec.TabIndex = 356
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 26)
        Me.Label2.TabIndex = 358
        Me.Label2.Text = "รหัส :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 26)
        Me.Label5.TabIndex = 363
        Me.Label5.Text = "แผนก :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnamefloor)
        Me.GroupBox2.Controls.Add(Me.txtidsec)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.txtsection)
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 286)
        Me.GroupBox2.TabIndex = 373
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 26)
        Me.Label4.TabIndex = 359
        Me.Label4.Text = "ชั้น :"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(129, 223)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 40)
        Me.btnsave.TabIndex = 360
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtsection
        '
        Me.txtsection.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsection.Location = New System.Drawing.Point(85, 111)
        Me.txtsection.Name = "txtsection"
        Me.txtsection.Size = New System.Drawing.Size(210, 34)
        Me.txtsection.TabIndex = 362
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(215, 223)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(80, 40)
        Me.btndelete.TabIndex = 361
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'EDIT_SECTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 679)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "EDIT_SECTION"
        Me.Text = "EDIT_SECTION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListVieweditsec As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtnamefloor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtshowcount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidsec As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtsection As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
