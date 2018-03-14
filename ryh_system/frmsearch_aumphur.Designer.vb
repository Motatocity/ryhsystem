<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsearch_aumphur
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
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.DateTimePicker2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DateTimePicker1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.llogin = New System.Windows.Forms.Label()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(17, 108)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 22
        Me.LabelX4.Text = "End Date"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(17, 69)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 21
        Me.LabelX5.Text = "Start Date"
        '
        'DateTimePicker2
        '
        '
        '
        '
        Me.DateTimePicker2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimePicker2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimePicker2.ButtonDropDown.Visible = True
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker2.IsPopupCalendarOpen = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(107, 108)
        '
        '
        '
        Me.DateTimePicker2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePicker2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimePicker2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimePicker2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker2.MonthCalendar.DisplayMonth = New Date(2013, 10, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DateTimePicker2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimePicker2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePicker2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimePicker2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePicker2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimePicker2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker2.MonthCalendar.TodayButtonVisible = True
        Me.DateTimePicker2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 24)
        Me.DateTimePicker2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimePicker2.TabIndex = 20
        '
        'DateTimePicker1
        '
        '
        '
        '
        Me.DateTimePicker1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimePicker1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimePicker1.ButtonDropDown.Visible = True
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.IsPopupCalendarOpen = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 67)
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimePicker1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.MonthCalendar.DisplayMonth = New Date(2013, 10, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DateTimePicker1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimePicker1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimePicker1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 24)
        Me.DateTimePicker1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimePicker1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.llogin)
        Me.Panel2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(2, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1199, 53)
        Me.Panel2.TabIndex = 180
        '
        'llogin
        '
        Me.llogin.AutoSize = True
        Me.llogin.Font = New System.Drawing.Font("Cordia New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.llogin.Location = New System.Drawing.Point(3, 3)
        Me.llogin.Name = "llogin"
        Me.llogin.Size = New System.Drawing.Size(469, 45)
        Me.llogin.TabIndex = 0
        Me.llogin.Text = "ค้นหาข้อมูลคนไข้ ที่มาทำการรักษา แยกตาม อำเภอ"
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.Color.White
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView4.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(17, 148)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(587, 427)
        Me.ListView4.TabIndex = 205
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID"
        Me.ColumnHeader10.Width = 61
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "จังหวัด"
        Me.ColumnHeader11.Width = 180
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "อำเภอ"
        Me.ColumnHeader12.Width = 144
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "จำนวน"
        Me.ColumnHeader13.Width = 190
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(17, 600)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(119, 32)
        Me.LabelX1.TabIndex = 206
        Me.LabelX1.Text = "จำนวนคนไข้ทั้งหมด"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.TextBox1.Location = New System.Drawing.Point(128, 600)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 34)
        Me.TextBox1.TabIndex = 207
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(274, 602)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(44, 32)
        Me.LabelX2.TabIndex = 208
        Me.LabelX2.Text = "คน"
        '
        'frmsearch_aumphur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 686)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsearch_aumphur"
        Me.Text = "frmsearch_aumphur"
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateTimePicker2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DateTimePicker1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents llogin As System.Windows.Forms.Label
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
