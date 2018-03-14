<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_HISTORY
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
        Me.txtdetail = New System.Windows.Forms.RichTextBox()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewfloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.ListViewshowhis = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListViewshowall = New System.Windows.Forms.ListView()
        Me.name_container = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.agent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupbox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewsection = New System.Windows.Forms.ListView()
        Me.ListViewlocat = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.groupbox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdetail
        '
        Me.txtdetail.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetail.Location = New System.Drawing.Point(823, 397)
        Me.txtdetail.Name = "txtdetail"
        Me.txtdetail.Size = New System.Drawing.Size(226, 58)
        Me.txtdetail.TabIndex = 358
        Me.txtdetail.Text = ""
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "FLOOR"
        Me.ColumnHeader12.Width = 70
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 50
        '
        'ListViewfloor
        '
        Me.ListViewfloor.BackColor = System.Drawing.Color.White
        Me.ListViewfloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListViewfloor.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewfloor.FullRowSelect = True
        Me.ListViewfloor.GridLines = True
        Me.ListViewfloor.HideSelection = False
        Me.ListViewfloor.Location = New System.Drawing.Point(16, 29)
        Me.ListViewfloor.Name = "ListViewfloor"
        Me.ListViewfloor.Size = New System.Drawing.Size(126, 244)
        Me.ListViewfloor.TabIndex = 344
        Me.ListViewfloor.UseCompatibleStateImageBehavior = False
        Me.ListViewfloor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "SECTION"
        Me.ColumnHeader21.Width = 170
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 50
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(885, 354)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.ReadOnly = True
        Me.txtlocation.Size = New System.Drawing.Size(56, 34)
        Me.txtlocation.TabIndex = 359
        '
        'ListViewshowhis
        '
        Me.ListViewshowhis.BackColor = System.Drawing.Color.White
        Me.ListViewshowhis.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewshowhis.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewshowhis.FullRowSelect = True
        Me.ListViewshowhis.GridLines = True
        Me.ListViewshowhis.HideSelection = False
        Me.ListViewshowhis.Location = New System.Drawing.Point(16, 31)
        Me.ListViewshowhis.Name = "ListViewshowhis"
        Me.ListViewshowhis.Size = New System.Drawing.Size(664, 226)
        Me.ListViewshowhis.TabIndex = 349
        Me.ListViewshowhis.UseCompatibleStateImageBehavior = False
        Me.ListViewshowhis.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PROBLEM"
        Me.ColumnHeader6.Width = 250
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SLOVE"
        Me.ColumnHeader7.Width = 250
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DATE"
        Me.ColumnHeader8.Width = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewshowall)
        Me.GroupBox2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(652, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 305)
        Me.GroupBox2.TabIndex = 361
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEVICE"
        '
        'ListViewshowall
        '
        Me.ListViewshowall.BackColor = System.Drawing.Color.White
        Me.ListViewshowall.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.name_container, Me.agent, Me.ColumnHeader1, Me.ColumnHeader2, Me.size, Me.ColumnHeader22})
        Me.ListViewshowall.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewshowall.FullRowSelect = True
        Me.ListViewshowall.GridLines = True
        Me.ListViewshowall.HideSelection = False
        Me.ListViewshowall.Location = New System.Drawing.Point(15, 29)
        Me.ListViewshowall.Name = "ListViewshowall"
        Me.ListViewshowall.Size = New System.Drawing.Size(635, 244)
        Me.ListViewshowall.TabIndex = 202
        Me.ListViewshowall.UseCompatibleStateImageBehavior = False
        Me.ListViewshowall.View = System.Windows.Forms.View.Details
        '
        'name_container
        '
        Me.name_container.Text = "ID"
        '
        'agent
        '
        Me.agent.Text = "TYPE"
        Me.agent.Width = 70
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NAME"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DETAIL"
        Me.ColumnHeader2.Width = 180
        '
        'size
        '
        Me.size.Text = "STATUS"
        Me.size.Width = 100
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "SECTION"
        Me.ColumnHeader22.Width = 100
        '
        'groupbox1
        '
        Me.groupbox1.Controls.Add(Me.ListViewfloor)
        Me.groupbox1.Controls.Add(Me.ListViewsection)
        Me.groupbox1.Controls.Add(Me.ListViewlocat)
        Me.groupbox1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox1.Location = New System.Drawing.Point(10, 24)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(636, 305)
        Me.groupbox1.TabIndex = 360
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "Choose"
        '
        'ListViewsection
        '
        Me.ListViewsection.BackColor = System.Drawing.Color.White
        Me.ListViewsection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListViewsection.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewsection.FullRowSelect = True
        Me.ListViewsection.GridLines = True
        Me.ListViewsection.HideSelection = False
        Me.ListViewsection.Location = New System.Drawing.Point(157, 29)
        Me.ListViewsection.Name = "ListViewsection"
        Me.ListViewsection.Size = New System.Drawing.Size(225, 244)
        Me.ListViewsection.TabIndex = 198
        Me.ListViewsection.UseCompatibleStateImageBehavior = False
        Me.ListViewsection.View = System.Windows.Forms.View.Details
        '
        'ListViewlocat
        '
        Me.ListViewlocat.BackColor = System.Drawing.Color.White
        Me.ListViewlocat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewlocat.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListViewlocat.FullRowSelect = True
        Me.ListViewlocat.GridLines = True
        Me.ListViewlocat.HideSelection = False
        Me.ListViewlocat.Location = New System.Drawing.Point(398, 29)
        Me.ListViewlocat.Name = "ListViewlocat"
        Me.ListViewlocat.Size = New System.Drawing.Size(224, 244)
        Me.ListViewlocat.TabIndex = 203
        Me.ListViewlocat.UseCompatibleStateImageBehavior = False
        Me.ListViewlocat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "LOCATION"
        Me.ColumnHeader4.Width = 170
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(823, 489)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 40)
        Me.btnsave.TabIndex = 357
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(758, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 26)
        Me.Label2.TabIndex = 356
        Me.Label2.Text = "DETAIL :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(787, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 26)
        Me.Label1.TabIndex = 355
        Me.Label1.Text = "ID :"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(823, 354)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(56, 34)
        Me.txtid.TabIndex = 354
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListViewshowhis)
        Me.GroupBox3.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 335)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(695, 274)
        Me.GroupBox3.TabIndex = 362
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Show History"
        '
        'ADD_HISTORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 696)
        Me.Controls.Add(Me.txtdetail)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADD_HISTORY"
        Me.Text = "ADD_HISTORY"
        Me.GroupBox2.ResumeLayout(False)
        Me.groupbox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdetail As System.Windows.Forms.RichTextBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewfloor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents ListViewshowhis As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewshowall As System.Windows.Forms.ListView
    Friend WithEvents name_container As System.Windows.Forms.ColumnHeader
    Friend WithEvents agent As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents size As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewsection As System.Windows.Forms.ListView
    Friend WithEvents ListViewlocat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
