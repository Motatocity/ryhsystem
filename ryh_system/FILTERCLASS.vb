Imports System.Threading

Public Class FILTERCLASS 'คลาสหนูน้อยอะไรหว่า
    Private ctl As TextBox
    Private ctlFocus As TextBox = Nothing
    Private dgvSearch As New DataGridView
    Private dtSearch As DataTable
    Private t As Thread
    Private colWidth() As String
    Private colText() As String
    Private colVisible() As String
    Private colFilter() As String
    Private IsHardFilter As Boolean = False
    Private IsHardFilterStart As Int32 = 0
    Private IsAutoSizeRow As Boolean = False
    Private IsAutoSizeColumn As Boolean = False
    Private IsShowInDown As Boolean = True
    Private IsShowBorder As Boolean = False
    Private tagIndex As Integer = 0
    Private textIndex As Integer = 1
    Private searchHeight As Integer = 0
    Private sql As String = ""
    Private colorX As New List(Of String)
    Dim icon As New PictureBox

    Public Overridable Property SetSql As String
        Get
            Return sql
        End Get
        Set(value As String)
            Me.sql = value
            Call getData()
        End Set
    End Property

    Public Overridable WriteOnly Property SetColText As String
        Set(value As String)
            colText = value.Split(",")
        End Set
    End Property


    Public Overridable WriteOnly Property SetColWidth As String
        Set(value As String)
            colWidth = value.Split(",")
        End Set
    End Property

    Public Overridable WriteOnly Property SetColVisible As String
        Set(value As String)
            colVisible = value.Split(",")
        End Set
    End Property

    Public Overridable WriteOnly Property SetColFilter As String
        Set(value As String)
            colFilter = value.Split(",")
        End Set
    End Property

    Public Overridable WriteOnly Property AutoSizeRows As Boolean
        Set(value As Boolean)
            IsAutoSizeRow = value
            If IsAutoSizeRow = True Then
                dgvSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            End If
        End Set
    End Property

    Public Overridable WriteOnly Property AutoSizeColumn As Boolean
        Set(value As Boolean)
            IsAutoSizeColumn = value
            If IsAutoSizeColumn = True Then
                dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        End Set
    End Property

    Public Overridable WriteOnly Property SetIsHardFilter As String
        Set(value As String)
            IsHardFilter = value
        End Set
    End Property

    Public Overridable WriteOnly Property SetIsHardFilterStart As Int32
        Set(value As Int32)
            IsHardFilterStart = value
        End Set
    End Property

    Public Overridable WriteOnly Property SetShowInDown As Boolean
        Set(value As Boolean)
            IsShowInDown = value
        End Set
    End Property

    Public Overridable WriteOnly Property SetShowBorder As Boolean
        Set(value As Boolean)
            IsShowBorder = value
            If IsShowBorder = False Then
                dgvSearch.BorderStyle = BorderStyle.None
            Else
                dgvSearch.BorderStyle = BorderStyle.FixedSingle
            End If
        End Set
    End Property

    Public Overridable WriteOnly Property SetTagIndex As Integer
        Set(value As Integer)
            tagIndex = value
        End Set
    End Property

    Public Overridable WriteOnly Property SetTextIndex As Integer
        Set(value As Integer)
            textIndex = value
        End Set
    End Property

    Public Overridable WriteOnly Property SetTextBoxFocus As TextBox
        Set(value As TextBox)
            ctlFocus = value
        End Set
    End Property

    Public Sub New(txt As TextBox, sql As String)
        Begin(txt, sql)
    End Sub

    Public Sub New(txt As TextBox, sql As String, ColumnsText As String)
        Begin(txt, sql)
        colText = ColumnsText.Split(",")
    End Sub

    Public Sub New(txt As TextBox, sql As String, ColumnsText As String, ColumnsWidth As String)
        Begin(txt, sql)
        colText = ColumnsText.Split(",")
        colWidth = ColumnsWidth.Split(",")
    End Sub

    Public Sub New(txt As TextBox, sql As String, ColumnsText As String, ColumnsWidth As String, ColumnsVisible As String)
        Begin(txt, sql)
        colText = ColumnsText.Split(",")
        colWidth = ColumnsWidth.Split(",")
        colVisible = ColumnsVisible.Split(",")
    End Sub

    Public Sub New(txt As TextBox, sql As String, ColumnsText As String, ColumnsWidth As String, ColumnsVisible As String, ColumnsFilter As String)
        Begin(txt, sql)
        colText = ColumnsText.Split(",")
        colWidth = ColumnsWidth.Split(",")
        colVisible = ColumnsVisible.Split(",")
        colFilter = ColumnsFilter.Split(",")
    End Sub

    Sub Addicon(ByRef txtbox As TextBox)
        'icon.Image = FRIM.My.Resources.Resources.comboico1
        icon.Tag = "passfilter"
        icon.Size = New Size(15, 15)
        icon.Location = New Point(txtbox.Location.X + txtbox.Size.Width - 18, txtbox.Location.Y + 4)
        icon.BackColor = txtbox.BackColor
        Dim Obj As Control = txtbox.Parent
        Obj.Controls.Add(icon)
        If txtbox.Visible = True And txtbox.Enabled = True Then
            icon.Visible = True
        Else
            icon.Visible = False
        End If
        icon.BringToFront()
    End Sub

    Private Sub Textbox_EnabledChanged(sender As Object, e As EventArgs)
        Dim txtbox As TextBox = CType(sender, TextBox)
        If txtbox.Visible = True And txtbox.Enabled = True Then
            icon.Visible = True
        Else
            icon.Visible = False
        End If
    End Sub

    Private Sub Textbox_VisibleChanged(sender As Object, e As EventArgs)
        Dim txtbox As TextBox = CType(sender, TextBox)
        If txtbox.Visible = True And txtbox.Enabled = True Then
            icon.Visible = True
        Else
            icon.Visible = False
        End If
    End Sub

    Private Sub Begin(txt As TextBox, sqlX As String)
        sql = sqlX
        ctl = txt
        Addicon(txt)
        Me.searchHeight = 200
        With dgvSearch
            .ReadOnly = True
            .Height = Me.searchHeight
            .RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue
            .BackgroundColor = System.Drawing.Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .GridColor = System.Drawing.Color.FromArgb(255, 215, 228, 242)
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 185, 209, 234)
            .Name = "dgvSearch"
            .Parent = txt.FindForm()
            .Visible = False
        End With

        AddHandler txt.EnabledChanged, AddressOf Textbox_EnabledChanged
        AddHandler txt.VisibleChanged, AddressOf Textbox_VisibleChanged

        AddHandler dgvSearch.CellMouseClick, AddressOf Me.dgvSearchClick
        AddHandler dgvSearch.KeyDown, AddressOf Me.dgvSearchKey
        AddHandler dgvSearch.DataBindingComplete, AddressOf Me.dgv_DataBindingComplete

        AddHandler ctl.TextChanged, AddressOf Me.txtTextChange
        AddHandler ctl.KeyUp, AddressOf Me.txtKeyUp
        AddHandler ctl.KeyDown, AddressOf Me.txtKeyDown
        AddHandler ctl.PreviewKeyDown, AddressOf Me.txtPreviewKeyDown
        AddHandler ctl.KeyPress, AddressOf Me.txtKeyPress
        AddHandler ctl.MouseClick, AddressOf Me.txtMouseClick
        AddHandler icon.MouseClick, AddressOf Me.txtMouseClick
        AddHandler txt.Parent.MouseClick, AddressOf Me.parentMouseClick
        AddHandler dgvSearch.Parent.MouseClick, AddressOf Me.parentMouseClick
        Call RecurseControlsAddHandler(dgvSearch.Parent, txt)
        Call getData()
        dgvSearch.BringToFront()

    End Sub

    Private Sub RecurseControlsAddHandler(ByVal ctrX As Control, txt As TextBox)
        If ctrX.HasChildren Then
            For Each c As Control In ctrX.Controls
                If TypeOf (c) Is Panel Then
                    Dim ctx As Panel
                    ctx = CType(c, Panel)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is MaskedTextBox Then
                    Dim ctx As MaskedTextBox
                    ctx = CType(c, MaskedTextBox)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is GroupBox Then
                    Dim ctx As GroupBox
                    ctx = CType(c, GroupBox)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is PictureBox Then
                    Dim ctx As PictureBox
                    ctx = CType(c, PictureBox)
                    If ctx.Tag <> "passfilter" Then
                        AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                    End If
                ElseIf TypeOf (c) Is DataGridView And c.Name.Trim <> "dgvSearch" Then
                    Dim ctx As DataGridView
                    ctx = CType(c, DataGridView)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is DevComponents.DotNetBar.SuperGrid.SuperGridControl Then
                    Dim ctx As DevComponents.DotNetBar.SuperGrid.SuperGridControl
                    ctx = CType(c, DevComponents.DotNetBar.SuperGrid.SuperGridControl)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is DevComponents.DotNetBar.Controls.DataGridViewX Then
                    Dim ctx As DevComponents.DotNetBar.Controls.DataGridViewX
                    ctx = CType(c, DevComponents.DotNetBar.Controls.DataGridViewX)
                    AddHandler ctx.MouseEnter, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is DevComponents.DotNetBar.PanelEx Then
                    Dim ctx As DevComponents.DotNetBar.PanelEx
                    ctx = CType(c, DevComponents.DotNetBar.PanelEx)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                ElseIf TypeOf (c) Is DevComponents.DotNetBar.TabControl Then
                    Dim ctx As DevComponents.DotNetBar.TabControl
                    ctx = CType(c, DevComponents.DotNetBar.TabControl)
                    AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                    AddHandler ctx.SelectedTabChanged, AddressOf Me.parentSelectTabChange
                ElseIf TypeOf (c) Is DevComponents.DotNetBar.Controls.TextBoxX Then
                    If c IsNot txt Then
                        Dim ctx As DevComponents.DotNetBar.Controls.TextBoxX
                        ctx = CType(c, DevComponents.DotNetBar.Controls.TextBoxX)
                        AddHandler ctx.MouseClick, AddressOf Me.parentMouseClick
                    End If
                End If
                RecurseControlsAddHandler(c, txt)
            Next c
        End If
    End Sub

    Private Sub getData()
        Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection
        dtSearch = New DataTable()
        dtSearch = db.GetTable(sql)
        db.Dispose()
    End Sub

    Private Sub ColumnsText()
        If colText Is Nothing Then
            Return
        End If
        For i As Integer = 0 To colText.Length - 1
            dgvSearch.Columns(i).HeaderText = colText(i)
        Next
    End Sub

    Private Sub ColumnsWidth()
        If colWidth Is Nothing Then
            Return
        End If
        For i As Integer = 0 To colWidth.Length - 1
            If i > 0 Then
                dgvSearch.Columns(i).Width = colWidth(i)
                'dgvSearch.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                dgvSearch.Columns(i).Width = colWidth(i)
            End If
        Next
    End Sub

    Private Sub ColumnsVisible()
        If colWidth Is Nothing Then
            Return
        End If

        Dim GridSize As Integer = 0
        For i As Integer = 0 To colVisible.Length - 1
            If colVisible(i).Trim = "0" Then
                dgvSearch.Columns(i).Visible = False
            Else
                dgvSearch.Columns(i).Visible = True
                GridSize += dgvSearch.Columns(i).Width
            End If
        Next
        GridSize += 20
        dgvSearch.Width = GridSize
    End Sub

    Private Sub dgvSearchClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        If e.RowIndex = -1 Then
            Return
        End If
        If ctl.Text.Trim = dgvSearch.Rows(e.RowIndex).Cells(textIndex).Value.ToString.Trim Then
            ctl.Tag = dgvSearch.Rows(e.RowIndex).Cells(tagIndex).Value.ToString
            ctl.Text = ""
        End If
        ctl.Tag = dgvSearch.Rows(e.RowIndex).Cells(tagIndex).Value.ToString
        ctl.Text = dgvSearch.Rows(e.RowIndex).Cells(textIndex).Value.ToString
        dgvSearch.DataSource = Nothing
        dgvSearch.Visible = False
        'ctl.Focus()
        If ctlFocus IsNot Nothing Then
            ctlFocus.Focus()
        Else
            ctl.Focus()
        End If
    End Sub

    Private Sub dgvSearchKey(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            For i As Integer = 0 To dgvSearch.Rows.Count - 1
                If dgvSearch.Rows(i).Cells(textIndex).Selected = True Then
                    If ctl.Text.Trim = dgvSearch.Rows(i).Cells(textIndex).Value.ToString.Trim Then
                        ctl.Tag = dgvSearch.Rows(i).Cells(tagIndex).Value.ToString
                        ctl.Text = ""
                    End If
                    ctl.Tag = dgvSearch.Rows(i).Cells(tagIndex).Value.ToString
                    ctl.Text = dgvSearch.Rows(i).Cells(textIndex).Value.ToString
                    dgvSearch.DataSource = Nothing
                    dgvSearch.Visible = False
                    If ctlFocus IsNot Nothing Then
                        ctlFocus.Focus()
                    Else
                        ctl.Focus()
                    End If
                    Return
                End If
            Next i
        ElseIf e.KeyCode = Keys.Escape Then
            dgvSearch.DataSource = Nothing
            dgvSearch.Visible = False
        End If
    End Sub

    Private Sub txtTextChange(sender As Object, e As EventArgs)
        ctl.SelectionLength = ctl.Text.Length
        If ctl.Text.Trim = "" Then
            ctl.Tag = ""
        End If
    End Sub

    Private Sub txtPreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Tab Then
            dgvSearch.DataSource = Nothing
            dgvSearch.Visible = False
        End If
    End Sub
    Private Sub txtKeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar.ToString.Trim = "'" Or e.KeyChar.ToString.Trim = "[" Or e.KeyChar.ToString.Trim = "]" Or e.KeyChar.ToString.Trim = "\" Or e.KeyChar.ToString.Trim = "%" Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtKeyDown(sender As Object, e As KeyEventArgs)
        If dgvSearch.Visible = True Then
            ctl.Tag = Nothing
            If e.KeyCode = Keys.Enter Then
                If ctl.Focused Then
                    For i As Integer = 0 To dgvSearch.Rows.Count - 1
                        If dgvSearch.Rows(i).Cells(1).Selected = True Then
                            'ctl.Tag = ""
                            ctl.Tag = dgvSearch.Rows(i).Cells(tagIndex).Value.ToString
                            ctl.Text = dgvSearch.Rows(i).Cells(textIndex).Value.ToString
                            ctl.SelectAll()
                            dgvSearch.DataSource = Nothing
                            dgvSearch.Visible = False
                            Return
                        End If
                    Next i
                End If
            End If
        End If
    End Sub

    Private Sub txtKeyUp(sender As Object, e As KeyEventArgs)
        If t IsNot Nothing Then
            If t.IsAlive = True Then
                t.Abort()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            dgvSearch.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            If dgvSearch.Rows.Count = 1 Then
                'ctl.Tag = ""
                ctl.Tag = dgvSearch.Rows(0).Cells(tagIndex).Value.ToString
                ctl.Text = dgvSearch.Rows(0).Cells(textIndex).Value.ToString
                dgvSearch.DataSource = Nothing
                dgvSearch.Visible = False
                Return
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            dgvSearch.DataSource = Nothing
            dgvSearch.Visible = False
        Else
            If IsHardFilter = True Then
                t = New Thread(AddressOf FilterHard)
                t.IsBackground = True
                t.Start()
            Else
                t = New Thread(AddressOf Filter)
                t.IsBackground = True
                t.Start()
            End If
            ctl.Focus()
        End If
    End Sub

    Private Sub parentMouseClick(sender As Object, e As MouseEventArgs)
        dgvSearch.DataSource = Nothing
        dgvSearch.Visible = False
    End Sub

    Private Sub parentSelectTabChange(sender As Object, e As DevComponents.DotNetBar.TabStripTabChangedEventArgs)
        dgvSearch.DataSource = Nothing
        dgvSearch.Visible = False
    End Sub

    Private Sub txtMouseClick(sender As Object, e As MouseEventArgs)
        If dgvSearch.Visible = False Then
            hideSearchControl()
            ctl.SelectAll()
            If dgvSearch.DataSource Is Nothing Then
                With dgvSearch
                    .DataSource = dtSearch
                    calSearchHeight()
                    calLocation()
                    .Visible = True
                    .BringToFront()
                End With
                ColumnsText()
                ColumnsWidth()
                ColumnsVisible()
            Else
                dgvSearch.Visible = True
            End If
            If IsHardFilter = True Then
                FilterHard()
            Else
                Filter()
            End If
        Else
            dgvSearch.DataSource = Nothing
            dgvSearch.Visible = False
        End If

    End Sub

    Private Sub calLocation()
        Dim p As Point = ctl.Location
        Dim parent As Control = ctl.Parent
        While Not (TypeOf parent Is Form)
            If TypeOf parent Is DevComponents.DotNetBar.Controls.GroupPanel Then
                p.Y = p.Y + ctl.Size.Height - 1
                p.X = p.X + 2
            End If
            p.Offset(parent.Location.X, parent.Location.Y)
            parent = parent.Parent
        End While

        If IsShowInDown = True Then
            dgvSearch.Location = New Point(p.X, ctl.Height + p.Y)
        Else
            dgvSearch.Location = New Point(p.X, p.Y - dgvSearch.Height)
        End If
    End Sub

    Private Sub calSearchHeight()
        If dgvSearch.Rows.Count > 0 Then
            dgvSearch.Height = (dgvSearch.Rows.Count * dgvSearch.Rows(dgvSearch.Rows.Count - 1).Height) + 40
        Else
            dgvSearch.Height = (dgvSearch.Rows.Count * 0) + 40
        End If
        If dgvSearch.Height > Me.searchHeight Then
            dgvSearch.Height = Me.searchHeight
        End If
    End Sub

    Private Sub FilterHard()
        If ctl.InvokeRequired Then
            Dim d1 As New D(AddressOf FilterHard)
            ctl.Parent.BeginInvoke(d1, New Object() {})
        Else
            Dim dv As New DataView
            dv = dtSearch.DefaultView
            dgvSearch.Visible = True
            Try
                Convert.ToInt32(ctl.Text.Trim)
                dv.RowFilter = "CONVERT(" + dtSearch.Columns(IsHardFilterStart).ColumnName + ", System.String) LIKE '%" & ctl.Text.Trim & "%'"
            Catch ex As Exception
                dv.RowFilter = "CONVERT(" + dtSearch.Columns(IsHardFilterStart + 1).ColumnName + ", System.String) LIKE '%" & ctl.Text.Trim & "%'"
            End Try
            With dgvSearch
                .DataSource = dv.ToTable
            End With
        End If
    End Sub

    Private Delegate Sub D()
    Private Sub Filter()
        Try
            If ctl.InvokeRequired Then
                Dim d1 As New D(AddressOf Filter)
                ctl.Parent.BeginInvoke(d1, New Object() {})
            Else
                Dim dv As New DataView
                dv = dtSearch.DefaultView
                dgvSearch.Visible = True
                Dim txtFilter As String = ""
                If colFilter Is Nothing Then
                    For i As Integer = 0 To dtSearch.Columns.Count - 1
                        txtFilter += "CONVERT(" + dtSearch.Columns(i).ColumnName + ", System.String) LIKE '%" & String.Format(ctl.Text.Trim) & "%' "
                        txtFilter += "OR "
                    Next i
                Else
                    For i As Integer = 0 To colFilter.Length - 1
                        If colFilter(i).Trim = "1" Then
                            txtFilter += "CONVERT(" + dtSearch.Columns(i).ColumnName + ", System.String) LIKE '%" & String.Format(ctl.Text.Trim) & "%' "
                            txtFilter += "OR "
                        End If
                    Next i
                End If
                txtFilter = txtFilter.Remove(txtFilter.Length - 3, 3)
                dv.RowFilter = txtFilter
                With dgvSearch
                    .DataSource = dv.ToTable
                    If .Rows.Count = 0 Then
                        dgvSearch.Visible = False
                    Else
                        dgvSearch.Visible = True
                    End If
                End With
                calSearchHeight()
                calLocation()
                ColumnsWidth()
                ColumnsVisible()
            End If
        Catch ex As Exception
            MsgBox("error : " & ex.Message)
        End Try
    End Sub

    Private Sub hideSearchControl()
        For Each c As Control In dgvSearch.Parent.Controls
            If c.Name = "dgvSearch" Then
                c.Visible = False
            End If
        Next
    End Sub

    Public Sub SetColor(MyColor As String)
        colorX.Add(MyColor)
    End sub
    Private Sub dgv_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        For i As Integer = 0 To colorX.Count - 1
            Dim arr = colorX(i).Split(",")
            Dim r = Convert.ToInt32(arr(0))
            Dim c = Convert.ToInt32(arr(1))
            Dim cl = Color.FromName(arr(2))
            dgvSearch.Rows(r).Cells(c).Style.BackColor = cl
        Next i
    End Sub

    Function GetRowByID(ByVal n As Integer) As String
        For i As Integer = 0 To dtSearch.Rows.Count - 1
            If dtSearch.Rows(i).Item(tagIndex).ToString = n Then
                Return dtSearch.Rows(i).Item(textIndex).ToString
            End If
        Next i
        Return ""
    End Function

End Class
