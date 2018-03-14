Public Class frmdept_tool
    Dim connect As ConnecDBRYH = ConnecDBRYH.NewConnection
    Dim checksaveedit As Boolean
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub frmdept_tool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler DataInformation.GetCellStyle, AddressOf SuperGridControl1GetCellStyle
        loadTool()
        loadDept()
        loaddata()
    End Sub
    Public Sub loadTool()
        connect = ConnecDBRYH.NewConnection
        Dim sql As String = "Select idgroup_tool AS 'ID', group_tool.name As 'ชื่อเครื่องมือ',category_tool,category_name As 'GROUP' FROM group_tool join category_tool on category_tool.idcategory = group_tool.category_tool;"
        SuperGridControl3.PrimaryGrid.DataSource = connect.GetTable(sql)
        connect.Dispose()
    End Sub
    Public Sub loaddata()
        Dim sql As String
        Dim dbtable As DataTable
        sql = "Select idtool as 'ID' ,category_name as 'GROUP' ,group_tool.name as 'ชื่อเครื่องมือ' ,numbertool as 'รหัส' ,product as 'ยี่ห้อ' ,dep  as 'Department', case tool_stat when '2' then 'ใช้งาน'  when '1' then 'ซ่อม' when '0' then 'ยกเลิก' ELSE 'unknow' end as 'สถานะ' ,number_product as 'รุ่น',serial_product as 'Serial',iduserdep,idgroup_tool,category_tool.idcategory,price_product as 'Price' , group_tool.idgroup_tool  as 'idgroup_tool' , celibration,tool_stat,date_register as 'วันที่รับ' , iddept from tool_main join userdep on tool_main.iddept = userdep.iduserdep join group_tool on group_tool.idgroup_tool =  tool_main.idcategory join  category_tool on group_tool.category_tool = category_tool.idcategory;"
        connect = ConnecDBRYH.NewConnection
        dbtable = connect.GetTable(sql)
        DataInformation.PrimaryGrid.DataSource = dbtable
        connect.Dispose()


    End Sub

    Public Sub loadMove()

    End Sub
    Public Sub loadDept()
        Dim sql As String
        Dim dbtable As DataTable

        connect = ConnecDBRYH.NewConnection
        sql = "Select dep,iduserdep from userdep;"
        dbtable = connect.GetTable(sql)
        Try
            With ComboBox1
                .DataSource = dbtable
                .DisplayMember = "dep"
                .ValueMember = "iduserdep"
                .BindingContext = BindingContext
            End With
            With ComboBoxEx2
                .DataSource = dbtable
                .DisplayMember = "dep"
                .ValueMember = "iduserdep"
                .BindingContext = BindingContext
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        connect.Dispose()
    End Sub

    Private Sub SuperGridControl3_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles SuperGridControl3.CellClick
        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow
        TextBoxX2.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ชื่อเครื่องมือ").Value()
        TextBoxX9.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value()


    End Sub

    Private Sub SuperGridControl2_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles SuperGridControl2.CellClick

        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow

        Dim idkey As String
        idkey = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value()

    End Sub
    Public Sub loadDataSQL()

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If checksaveedit = False Then
            saveData()
            clear()

        Else
            Dim editStat As Integer
            editStat = MsgBox("ท่านต้องการบันทึกข้อมูลใหม่ใช่หรือไม่", MsgBoxStyle.OkCancel)
            If editStat = 1 Then
                saveData()
            End If
            clear()

        End If

    End Sub
    Public Sub saveData()
        Dim datearray() As String
        Dim checktool As Integer = 0
        Dim checkcelibration As Integer = 0
        If ComboBox1.SelectedValue < 0 Then
            MsgBox("กรุณาระบุ แผนก")
            Exit Sub
        End If
        If TextBoxX9.Text.ToString.Length = 0 Then
            MsgBox("กรุณาเลือก ชนิดเครื่องมือ")
            Exit Sub
        End If
        If RadioButton1.Checked = True Then

            checktool = 2
        ElseIf RadioButton2.Checked = True Then


            checktool = 1
        ElseIf RadioButton3.Checked = True Then

            checktool = 0
        End If

        If CheckBox1.Checked = True Then
            checkcelibration = 1
        Else
            checkcelibration = 0
        End If
        datearray = Split(MaskedTextBoxAdv1.Text, "/")
        Dim sql As String
        Dim idlast As String
        connect = ConnecDBRYH.NewConnection
        sql = "Insert into tool_main"
        sql += "(iddept,idcategory,numbertool,product,number_product,serial_product,price_product,date_register,celibration,tool_stat)"
        sql += " VALUES "
        sql += "('" & ComboBox1.SelectedValue & "','" & TextBoxX9.Text.ToString & "','" & TextBoxX1.Text.ToString & "','" & TextBoxX4.Text.ToString & "','" & TextBoxX5.Text.ToString & "','" & TextBoxX6.Text.ToString & "','" & TextBoxX7.Text.ToString & "','" & datearray(2).ToString + datearray(1).ToString + datearray(0).ToString & "','" & checkcelibration & "','" & checktool & "');"
        sql += " SELECT LAST_INSERT_ID();"
        idlast = connect.ExecuteScalar(sql)
        connect.Dispose()


        connect = ConnecDBRYH.NewConnection
        sql = "Insert into tool_move"
        sql += "( idtool , iddept , date_move) "
        sql += " VALUES "
        sql += "('" & idlast & "','" & ComboBox1.SelectedValue & "', '" & Date.Now.ToString("dd/MM/yyy") & "')"
        connect.ExecuteNonQuery(sql)
        connect.Dispose()
        loaddata()
        clear()
    End Sub

    Private Sub DataInformation_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles DataInformation.CellClick
        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow
        Dim celibration As Integer
        Dim stat As Integer
        Dim date_register As String

        TextBoxX3.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value()
        TextBoxX2.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ชื่อเครื่องมือ").Value()
        TextBoxX1.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("รหัส").Value()
        TextBoxX4.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ยี่ห้อ").Value()
        TextBoxX5.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("รุ่น").Value()
        TextBoxX7.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("Price").Value()
        TextBoxX6.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("Serial").Value()
        TextBoxX9.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("idgroup_tool").Value()
        celibration = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("celibration").Value()
        stat = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("tool_stat").Value()

        date_register = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("วันที่รับ").Value()
        ComboBox1.SelectedValue = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("iddept").Value()

        If celibration = 1 Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        If stat = 0 Then
            RadioButton3.Checked = True
        ElseIf stat = 1 Then
            RadioButton2.Checked = True
        ElseIf stat = 2 Then
            RadioButton1.Checked = True
        End If
        'MsgBox(Mid(date_register, 7, 2))
        'MsgBox(Mid(date_register, 5, 2))
        'MsgBox(Mid(date_register, 1, 4))
        MaskedTextBoxAdv1.Text = Mid(date_register, 7, 2) + "/" + Mid(date_register, 5, 2) + "/" + Mid(date_register, 1, 4)

        checksaveedit = True
    End Sub


    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click

        If checksaveedit = True Then

            Dim datearray() As String
            Dim checktool As Integer = 0
            Dim checkcelibration As Integer = 0
            If ComboBox1.SelectedValue < 0 Then
                MsgBox("กรุณาระบุ แผนก")
                Exit Sub
            End If
            If TextBoxX9.Text.ToString.Length = 0 Then
                MsgBox("กรุณาเลือก ชนิดเครื่องมือ")
                Exit Sub
            End If
            If RadioButton1.Checked = True Then

                checktool = 2
            ElseIf RadioButton2.Checked = True Then


                checktool = 1
            ElseIf RadioButton3.Checked = True Then

                checktool = 0
            End If

            If CheckBox1.Checked = True Then
                checkcelibration = 1
            Else
                checkcelibration = 0
            End If
            datearray = Split(MaskedTextBoxAdv1.Text, "/")
            Dim sql As String
            sql = "UPDATE tool_main SET "
            sql += "iddept ='" & ComboBox1.SelectedValue & "', "
            sql += "idcategory ='" & TextBoxX9.Text.ToString & "', "
            sql += "numbertool ='" & TextBoxX1.Text.ToString & "', "
            sql += "product ='" & TextBoxX4.Text.ToString & "', "
            sql += "number_product ='" & TextBoxX5.Text.ToString & "', "
            sql += "serial_product ='" & TextBoxX6.Text.ToString & "', "
            sql += "price_product ='" & TextBoxX7.Text.ToString & "', "
            sql += "date_register ='" & datearray(2).ToString + datearray(1).ToString + datearray(0).ToString & "', "
            sql += "celibration ='" & checkcelibration & "', "
            sql += "tool_stat ='" & checktool & "' "
            sql += " where idtool='" & TextBoxX3.Text.ToString & "';"
            connect = ConnecDBRYH.NewConnection
            connect.ExecuteNonQuery(sql)
            connect.Dispose()
            checksaveedit = False
            loaddata()
            clear()
        End If
    End Sub

    Public Sub clear()
        TextBoxX3.Clear()
        ComboBox1.SelectedValue = 0
        TextBoxX1.Clear()
        TextBoxX2.Clear()
        TextBoxX9.Clear()
        TextBoxX4.Clear()
        TextBoxX5.Clear()
        TextBoxX7.Clear()
        TextBoxX6.Clear()
        MaskedTextBoxAdv1.Clear()
        CheckBox1.Checked = False
        RadioButton1.Checked = True
        checksaveedit = False
    End Sub
    Private Sub SuperGridControl1GetCellStyle(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridGetCellStyleEventArgs)
        If e.GridCell.GridColumn.Name.Equals("สถานะ") = True Then
            If CStr(e.GridCell.Value).Equals("ซ่อม") = True Then
                e.Style.Background.Color1 = Color.Yellow
                e.Style.Background.Color2 = Color.Plum
            End If
            If CStr(e.GridCell.Value).Equals("ยกเลิก") = True Then
                e.Style.Background.Color1 = Color.Red
                e.Style.Background.Color2 = Color.Plum
            End If
        End If






    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

    End Sub
    Public Sub savemove()

    End Sub
End Class