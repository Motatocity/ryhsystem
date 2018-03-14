<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT_LOCATION
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
        Me.ListViewlocation = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtshowsec = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtshowlo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListVieweditlocation = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidlocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfloor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsection = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewlocation
        '
        Me.ListViewlocation.BackColor = System.Drawing.Color.White
        Me.ListViewlocation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewlocation.FullRowSelect = True
        Me.ListViewlocation.GridLines = True
        Me.ListViewlocation.HideSelection = False
        Me.ListViewlocation.Location = New System.Drawing.Point(18, 67)
        Me.ListViewlocation.Name = "ListViewlocation"
        Me.ListViewlocation.Size = New System.Drawing.Size(289, 595)
        Me.ListViewlocation.TabIndex = 381
        Me.ListViewlocation.UseCompatibleStateImageBehavior = False
        Me.ListViewlocation.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LOCATION"
        Me.ColumnHeader2.Width = 141
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 132
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(804, 634)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 401
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(719, 149)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 32)
        Me.TextBox1.TabIndex = 405
        '
        'txtshowsec
        '
        Me.txtshowsec.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshowsec.Location = New System.Drawing.Point(175, 25)
        Me.txtshowsec.Name = "txtshowsec"
        Me.txtshowsec.ReadOnly = True
        Me.txtshowsec.Size = New System.Drawing.Size(58, 34)
        Me.txtshowsec.TabIndex = 383
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewlocation)
        Me.GroupBox2.Controls.Add(Me.txtshowlo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(263, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 668)
        Me.GroupBox2.TabIndex = 403
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Location"
        '
        'txtshowlo
        '
        Me.txtshowlo.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtshowlo.Location = New System.Drawing.Point(249, 28)
        Me.txtshowlo.Name = "txtshowlo"
        Me.txtshowlo.ReadOnly = True
        Me.txtshowlo.Size = New System.Drawing.Size(58, 34)
        Me.txtshowlo.TabIndex = 384
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(194, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 26)
        Me.Label4.TabIndex = 386
        Me.Label4.Text = "จำนวน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListVieweditlocation)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtshowsec)
        Me.GroupBox1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 668)
        Me.GroupBox1.TabIndex = 402
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section"
        '
        'ListVieweditlocation
        '
        Me.ListVieweditlocation.BackColor = System.Drawing.Color.White
        Me.ListVieweditlocation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListVieweditlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListVieweditlocation.FullRowSelect = True
        Me.ListVieweditlocation.GridLines = True
        Me.ListVieweditlocation.HideSelection = False
        Me.ListVieweditlocation.Location = New System.Drawing.Point(19, 67)
        Me.ListVieweditlocation.Name = "ListVieweditlocation"
        Me.ListVieweditlocation.Size = New System.Drawing.Size(214, 595)
        Me.ListVieweditlocation.TabIndex = 364
        Me.ListVieweditlocation.UseCompatibleStateImageBehavior = False
        Me.ListVieweditlocation.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 0
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "SECTION"
        Me.ColumnHeader21.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 26)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "คลิกเลือก"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 26)
        Me.Label3.TabIndex = 385
        Me.Label3.Text = "จำนวน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(613, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 26)
        Me.Label7.TabIndex = 404
        Me.Label7.Text = "DESCRIPTION :"
        '
        'txtidlocation
        '
        Me.txtidlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidlocation.Location = New System.Drawing.Point(915, 110)
        Me.txtidlocation.Multiline = True
        Me.txtidlocation.Name = "txtidlocation"
        Me.txtidlocation.ReadOnly = True
        Me.txtidlocation.Size = New System.Drawing.Size(55, 32)
        Me.txtidlocation.TabIndex = 400
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(641, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 395
        Me.Label2.Text = "SECTION :"
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(829, 205)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(80, 40)
        Me.btndelete.TabIndex = 393
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(743, 205)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 40)
        Me.btnsave.TabIndex = 392
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(719, 110)
        Me.txtlocation.Multiline = True
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(190, 32)
        Me.txtlocation.TabIndex = 394
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(633, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 26)
        Me.Label6.TabIndex = 399
        Me.Label6.Text = "LOCATION :"
        '
        'txtfloor
        '
        Me.txtfloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfloor.Location = New System.Drawing.Point(719, 34)
        Me.txtfloor.Multiline = True
        Me.txtfloor.Name = "txtfloor"
        Me.txtfloor.ReadOnly = True
        Me.txtfloor.Size = New System.Drawing.Size(71, 32)
        Me.txtfloor.TabIndex = 398
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(653, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 26)
        Me.Label5.TabIndex = 397
        Me.Label5.Text = "FLOOR :"
        '
        'txtsection
        '
        Me.txtsection.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsection.Location = New System.Drawing.Point(719, 72)
        Me.txtsection.Multiline = True
        Me.txtsection.Name = "txtsection"
        Me.txtsection.ReadOnly = True
        Me.txtsection.Size = New System.Drawing.Size(190, 32)
        Me.txtsection.TabIndex = 396
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(890, 634)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 391
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EDIT_LOCATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 732)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtidlocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfloor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsection)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EDIT_LOCATION"
        Me.Text = "EDIT_LOCATION"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewlocation As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtshowsec As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtshowlo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListVieweditlocation As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtidlocation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfloor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsection As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
