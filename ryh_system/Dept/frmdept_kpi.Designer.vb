<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdept_kpi
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 1000.0R)
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.DateTimePicker2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DateTimePicker1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvItem = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(5, 39)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Yellow}
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "คะแนนประเมิน 1"
        DataPoint1.IsValueShownAsLabel = True
        Series1.Points.Add(DataPoint1)
        Series1.ShadowColor = System.Drawing.SystemColors.ActiveCaption
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.Name = "คะแนนประเมิน 2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(594, 504)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        Me.Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "กราฟแสดงคะแนนประเมิน"
        Me.Chart1.Titles.Add(Title1)
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
        Me.LabelX4.Location = New System.Drawing.Point(198, 12)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(64, 23)
        Me.LabelX4.TabIndex = 23
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
        Me.LabelX5.Location = New System.Drawing.Point(12, 12)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(63, 23)
        Me.LabelX5.TabIndex = 22
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
        Me.DateTimePicker2.Location = New System.Drawing.Point(259, 11)
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
        Me.DateTimePicker2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.DateTimePicker2.TabIndex = 21
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(71, 12)
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
        Me.DateTimePicker1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.DateTimePicker1.TabIndex = 20
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(546, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12)
        Me.ButtonX1.Size = New System.Drawing.Size(77, 32)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "คำนวณ"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"checkup", "er", "child", "mec", "opd", "dm", "visitchild", "ped", "skin", "heart"})
        Me.ComboBox1.Location = New System.Drawing.Point(419, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Dep"
        '
        'dgvItem
        '
        Me.dgvItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItem.BackColor = System.Drawing.Color.White
        Background1.Color1 = System.Drawing.Color.Gray
        Background1.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvItem.DefaultVisualStyles.RowStyles.Default.Background = Background1
        Me.dgvItem.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.dgvItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvItem.ForeColor = System.Drawing.Color.Black
        Me.dgvItem.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.dgvItem.Location = New System.Drawing.Point(605, 42)
        Me.dgvItem.MaximumSize = New System.Drawing.Size(550, 450)
        Me.dgvItem.MinimumSize = New System.Drawing.Size(550, 450)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.PrimaryGrid.AllowRowHeaderResize = True
        Me.dgvItem.PrimaryGrid.AllowRowResize = True
        Me.dgvItem.PrimaryGrid.ColumnHeader.RowHeight = 25
        GridColumn1.Name = "DATE"
        GridColumn1.Width = 70
        GridColumn2.Name = "DEPT"
        GridColumn2.Width = 50
        GridColumn3.DefaultNewRowCellValue = ""
        GridColumn3.Name = "COMMENT"
        GridColumn3.Width = 370
        Me.dgvItem.PrimaryGrid.Columns.Add(GridColumn1)
        Me.dgvItem.PrimaryGrid.Columns.Add(GridColumn2)
        Me.dgvItem.PrimaryGrid.Columns.Add(GridColumn3)
        Me.dgvItem.PrimaryGrid.DefaultRowHeight = 0
        Background2.Color1 = System.Drawing.Color.AliceBlue
        Background2.Color2 = System.Drawing.Color.LightSteelBlue
        Background2.GradientAngle = 45
        Me.dgvItem.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background2
        Me.dgvItem.PrimaryGrid.EnableColumnFiltering = True
        Me.dgvItem.PrimaryGrid.EnableFiltering = True
        Me.dgvItem.PrimaryGrid.EnableRowFiltering = True
        Me.dgvItem.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle
        Me.dgvItem.PrimaryGrid.Filter.Visible = True
        Me.dgvItem.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal
        Me.dgvItem.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.dgvItem.PrimaryGrid.PrimaryColumnIndex = 1
        Me.dgvItem.PrimaryGrid.RowWhitespaceClickBehavior = DevComponents.DotNetBar.SuperGrid.RowWhitespaceClickBehavior.ExtendSelection
        Me.dgvItem.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.dgvItem.PrimaryGrid.ShowGroupUnderline = False
        Me.dgvItem.PrimaryGrid.ShowRowGridIndex = True
        Me.dgvItem.Size = New System.Drawing.Size(550, 450)
        Me.dgvItem.TabIndex = 83
        Me.dgvItem.Text = "SuperGridControl2"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(1025, 4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12)
        Me.ButtonX2.Size = New System.Drawing.Size(77, 32)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 84
        Me.ButtonX2.Text = "Excel"
        '
        'CircularProgress1
        '
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(924, 7)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(75, 23)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 85
        '
        'frmdept_kpi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 613)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.dgvItem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmdept_kpi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdept_kpi"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateTimePicker2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DateTimePicker1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents dgvItem As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
End Class
