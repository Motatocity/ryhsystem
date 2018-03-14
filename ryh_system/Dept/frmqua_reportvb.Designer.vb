<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmqua_reportvb
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX35 = New DevComponents.DotNetBar.LabelX()
        Me.MaskedTextBoxAdv3 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.date_eta_penang = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.ID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(7, 49)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.Size = New System.Drawing.Size(1153, 503)
        Me.DataGridViewX1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "วันที่"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ฝ่าย"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "หน่วย"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "ประเภท"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "ความรุนแรง"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "เหตุการณ์"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 250
        '
        'Column7
        '
        Me.Column7.HeaderText = "สรุปเหตุการณ์"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 250
        '
        'Column8
        '
        Me.Column8.HeaderText = "สถานะ"
        Me.Column8.Name = "Column8"
        '
        'ID
        '
        Me.ID.HeaderText = "Column9"
        Me.ID.MinimumWidth = 2
        Me.ID.Name = "ID"
        Me.ID.Width = 2
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(791, 8)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(89, 36)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "ประมวลผล"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(7, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(60, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "ค้นหาตาม"
        '
        'LabelX35
        '
        Me.LabelX35.BackColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX35.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX35.ForeColor = System.Drawing.Color.Black
        Me.LabelX35.Location = New System.Drawing.Point(153, 13)
        Me.LabelX35.Name = "LabelX35"
        Me.LabelX35.Size = New System.Drawing.Size(11, 30)
        Me.LabelX35.TabIndex = 231
        Me.LabelX35.Text = "to"
        '
        'MaskedTextBoxAdv3
        '
        Me.MaskedTextBoxAdv3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MaskedTextBoxAdv3.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv3.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv3.ForeColor = System.Drawing.Color.Black
        Me.MaskedTextBoxAdv3.Location = New System.Drawing.Point(176, 17)
        Me.MaskedTextBoxAdv3.Mask = "00/00/0000"
        Me.MaskedTextBoxAdv3.Name = "MaskedTextBoxAdv3"
        Me.MaskedTextBoxAdv3.Size = New System.Drawing.Size(84, 19)
        Me.MaskedTextBoxAdv3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.MaskedTextBoxAdv3.TabIndex = 230
        Me.MaskedTextBoxAdv3.Text = ""
        '
        'date_eta_penang
        '
        Me.date_eta_penang.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.date_eta_penang.BackgroundStyle.Class = "TextBoxBorder"
        Me.date_eta_penang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_eta_penang.ButtonClear.Visible = True
        Me.date_eta_penang.ForeColor = System.Drawing.Color.Black
        Me.date_eta_penang.Location = New System.Drawing.Point(60, 17)
        Me.date_eta_penang.Mask = "00/00/0000"
        Me.date_eta_penang.Name = "date_eta_penang"
        Me.date_eta_penang.Size = New System.Drawing.Size(84, 19)
        Me.date_eta_penang.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.date_eta_penang.TabIndex = 229
        Me.date_eta_penang.Text = ""
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox4.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.Black
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "ต่ำ", "ปานกลาง", "สูง"})
        Me.ComboBox4.Location = New System.Drawing.Point(537, 12)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(113, 28)
        Me.ComboBox4.TabIndex = 235
        Me.ComboBox4.Text = "ทั้งหมด"
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(457, 12)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(88, 30)
        Me.LabelX12.TabIndex = 234
        Me.LabelX12.Text = "ระดับความรุนแรง"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox2.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Clinic", "Non-Clinic"})
        Me.ComboBox2.Location = New System.Drawing.Point(356, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(89, 28)
        Me.ComboBox2.TabIndex = 233
        Me.ComboBox2.Text = "ทั้งหมด"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(267, 12)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(81, 30)
        Me.LabelX9.TabIndex = 232
        Me.LabelX9.Text = "ประเภทความเสี่ยง"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(1071, 4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(89, 36)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 236
        Me.ButtonX2.Text = "Excel"
        '
        'CircularProgress1
        '
        Me.CircularProgress1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(1013, 5)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.MediumSeaGreen
        Me.CircularProgress1.Size = New System.Drawing.Size(52, 37)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 237
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(808, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 238
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem1.Text = "Delete"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(656, 10)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(32, 30)
        Me.LabelX2.TabIndex = 239
        Me.LabelX2.Text = "แผนก"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("CordiaUPC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"OPD", "W3", "W4", "W5", "W6", "AC", "LR", "ACC", "ANL", "APP", "ICU", "OR", "MEC", "LAB", "AS", "CSSD", "DNT", "FNC", "FOD", "HHC", "HM", "IBL", "MKT", "NSD", "OBL", "PRX", "PSN", "PT", "REG", "SB", "UR", "ER", "DBL", "XCU", "FII", "SM"})
        Me.ComboBox1.Location = New System.Drawing.Point(689, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(88, 28)
        Me.ComboBox1.TabIndex = 240
        Me.ComboBox1.Text = "ทั้งหมด"
        '
        'frmqua_reportvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1172, 564)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.LabelX12)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX35)
        Me.Controls.Add(Me.MaskedTextBoxAdv3)
        Me.Controls.Add(Me.date_eta_penang)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmqua_reportvb"
        Me.Text = "MetroForm"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
    Friend WithEvents MaskedTextBoxAdv3 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents date_eta_penang As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
