<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_LOCATION
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtfloor = New System.Windows.Forms.TextBox()
        Me.txtshowlo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtshowsec = New System.Windows.Forms.TextBox()
        Me.txtsection = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListVieweditsec = New System.Windows.Forms.ListView()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListViewlocation = New System.Windows.Forms.ListView()
        Me.ComboBoxlocat = New System.Windows.Forms.ComboBox()
        Me.btneditlocation = New System.Windows.Forms.Button()
        Me.txtidsection = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtidfloor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(990, 583)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 394
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtfloor
        '
        Me.txtfloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfloor.Location = New System.Drawing.Point(138, 70)
        Me.txtfloor.Multiline = True
        Me.txtfloor.Name = "txtfloor"
        Me.txtfloor.ReadOnly = True
        Me.txtfloor.Size = New System.Drawing.Size(181, 32)
        Me.txtfloor.TabIndex = 366
        '
        'txtshowlo
        '
        Me.txtshowlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtshowlo.Location = New System.Drawing.Point(217, 19)
        Me.txtshowlo.Name = "txtshowlo"
        Me.txtshowlo.ReadOnly = True
        Me.txtshowlo.Size = New System.Drawing.Size(58, 26)
        Me.txtshowlo.TabIndex = 388
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 26)
        Me.Label4.TabIndex = 390
        Me.Label4.Text = "จำนวน"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "LOCATION"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 50
        '
        'txtshowsec
        '
        Me.txtshowsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtshowsec.Location = New System.Drawing.Point(219, 19)
        Me.txtshowsec.Name = "txtshowsec"
        Me.txtshowsec.ReadOnly = True
        Me.txtshowsec.Size = New System.Drawing.Size(58, 26)
        Me.txtshowsec.TabIndex = 387
        '
        'txtsection
        '
        Me.txtsection.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsection.Location = New System.Drawing.Point(138, 108)
        Me.txtsection.Multiline = True
        Me.txtsection.Name = "txtsection"
        Me.txtsection.ReadOnly = True
        Me.txtsection.Size = New System.Drawing.Size(181, 32)
        Me.txtsection.TabIndex = 357
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListVieweditsec)
        Me.GroupBox1.Controls.Add(Me.txtshowsec)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 610)
        Me.GroupBox1.TabIndex = 396
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SECTION"
        '
        'ListVieweditsec
        '
        Me.ListVieweditsec.BackColor = System.Drawing.Color.White
        Me.ListVieweditsec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader1})
        Me.ListVieweditsec.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListVieweditsec.FullRowSelect = True
        Me.ListVieweditsec.GridLines = True
        Me.ListVieweditsec.HideSelection = False
        Me.ListVieweditsec.Location = New System.Drawing.Point(21, 70)
        Me.ListVieweditsec.Name = "ListVieweditsec"
        Me.ListVieweditsec.Size = New System.Drawing.Size(256, 518)
        Me.ListVieweditsec.TabIndex = 364
        Me.ListVieweditsec.UseCompatibleStateImageBehavior = False
        Me.ListVieweditsec.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "ID"
        Me.ColumnHeader21.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SECTION"
        Me.ColumnHeader1.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 26)
        Me.Label3.TabIndex = 389
        Me.Label3.Text = "จำนวน"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(138, 196)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 40)
        Me.btnsave.TabIndex = 358
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(239, 196)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 40)
        Me.btndelete.TabIndex = 359
        Me.btndelete.Text = "Cancel"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 29)
        Me.Label2.TabIndex = 356
        Me.Label2.Text = "SECTION :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewlocation)
        Me.GroupBox2.Controls.Add(Me.txtshowlo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(318, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 610)
        Me.GroupBox2.TabIndex = 397
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOCATION"
        '
        'ListViewlocation
        '
        Me.ListViewlocation.BackColor = System.Drawing.Color.White
        Me.ListViewlocation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewlocation.FullRowSelect = True
        Me.ListViewlocation.GridLines = True
        Me.ListViewlocation.HideSelection = False
        Me.ListViewlocation.Location = New System.Drawing.Point(17, 70)
        Me.ListViewlocation.Name = "ListViewlocation"
        Me.ListViewlocation.Size = New System.Drawing.Size(258, 518)
        Me.ListViewlocation.TabIndex = 372
        Me.ListViewlocation.UseCompatibleStateImageBehavior = False
        Me.ListViewlocation.View = System.Windows.Forms.View.Details
        '
        'ComboBoxlocat
        '
        Me.ComboBoxlocat.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxlocat.FormattingEnabled = True
        Me.ComboBoxlocat.Items.AddRange(New Object() {"เครื่องระบบ", "เครื่องADMIN"})
        Me.ComboBoxlocat.Location = New System.Drawing.Point(138, 146)
        Me.ComboBoxlocat.Name = "ComboBoxlocat"
        Me.ComboBoxlocat.Size = New System.Drawing.Size(181, 34)
        Me.ComboBoxlocat.TabIndex = 371
        '
        'btneditlocation
        '
        Me.btneditlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditlocation.Location = New System.Drawing.Point(876, 583)
        Me.btneditlocation.Name = "btneditlocation"
        Me.btneditlocation.Size = New System.Drawing.Size(108, 40)
        Me.btneditlocation.TabIndex = 395
        Me.btneditlocation.Text = "EDIT / DELETE"
        Me.btneditlocation.UseVisualStyleBackColor = True
        '
        'txtidsection
        '
        Me.txtidsection.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidsection.Location = New System.Drawing.Point(331, 108)
        Me.txtidsection.Multiline = True
        Me.txtidsection.Name = "txtidsection"
        Me.txtidsection.ReadOnly = True
        Me.txtidsection.Size = New System.Drawing.Size(55, 32)
        Me.txtidsection.TabIndex = 369
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 29)
        Me.Label5.TabIndex = 365
        Me.Label5.Text = "FLOOR :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtfloor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtsection)
        Me.GroupBox3.Controls.Add(Me.ComboBoxlocat)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Controls.Add(Me.btndelete)
        Me.GroupBox3.Controls.Add(Me.txtidsection)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtidfloor)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(624, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 249)
        Me.GroupBox3.TabIndex = 398
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ADD LOCATION"
        '
        'txtidfloor
        '
        Me.txtidfloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidfloor.Location = New System.Drawing.Point(331, 70)
        Me.txtidfloor.Multiline = True
        Me.txtidfloor.Name = "txtidfloor"
        Me.txtidfloor.ReadOnly = True
        Me.txtidfloor.Size = New System.Drawing.Size(55, 32)
        Me.txtidfloor.TabIndex = 368
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 29)
        Me.Label6.TabIndex = 367
        Me.Label6.Text = "LOCATION :"
        '
        'ADD_LOCATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 635)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btneditlocation)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ADD_LOCATION"
        Me.Text = "ADD_LOCATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtfloor As System.Windows.Forms.TextBox
    Friend WithEvents txtshowlo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtshowsec As System.Windows.Forms.TextBox
    Friend WithEvents txtsection As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListVieweditsec As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewlocation As System.Windows.Forms.ListView
    Friend WithEvents ComboBoxlocat As System.Windows.Forms.ComboBox
    Friend WithEvents btneditlocation As System.Windows.Forms.Button
    Friend WithEvents txtidsection As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidfloor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
