Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class ADD_DEVICE_GROUP_DEPARTMENT
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String

    Private Sub ADD_DEVICE_GROUP_DEPARTMENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql.Close()
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearch.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device where (type like '%" + key + "%' or  name like '%" + key + "%'  or  model like '%" + key + "%'   or  c_cpu like '%" + key + "%'  or  c_mainboard like '%" + key + "%' or  c_ram like '%" + key + "%' or  c_harddisk like '%" + key + "%' or  c_vgacard like '%" + key + "%'  or  state_device like '%" + key + "%' or  p_type like '%" + key + "%'or  m_size like '%" + key + "%' or  detail like '%" + key + "%'or  c_ipnumber like '%" + key + "%' or  c_ps like '%" + key + "%' or  c_cd like '%" + key + "%' or  c_case like '%" + key + "%' or  serialnumber like '%" + key + "%' or  c_comname like '%" + key + "%' or  c_windows like '%" + key + "%' or  c_office like '%" + key + "%') and state_device = 'ชำรุด' order by iddata_device;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewshow.Items.Clear()

            While (mySqlReader.Read())

                With ListViewshow.Items.Add(mySqlReader("iddata_device"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Computer")
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Printer")
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Monitor")
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Other")
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.add("Licens")
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.add("Network")
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add("Spare Part")
                    End If
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add(mySqlReader("detail") + "      Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("state_device") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("state_device"))
                    End If
                    .SubItems.Add(mySqlReader("serialnumber"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM floor  order by idFloor;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewfloor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewfloor.Items.Add(mySqlReader("idFloor"))
                    .SubItems.Add(mySqlReader("floor_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub

    Private Sub showdata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearch.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device where (type like '%" + key + "%' or  name like '%" + key + "%'  or  model like '%" + key + "%'   or  c_cpu like '%" + key + "%'  or  c_mainboard like '%" + key + "%' or  c_ram like '%" + key + "%' or  c_harddisk like '%" + key + "%' or  c_vgacard like '%" + key + "%'  or  state_device like '%" + key + "%' or  p_type like '%" + key + "%'or  m_size like '%" + key + "%' or  detail like '%" + key + "%'or  c_ipnumber like '%" + key + "%' or  c_ps like '%" + key + "%' or  c_cd like '%" + key + "%' or  c_case like '%" + key + "%' or  serialnumber like '%" + key + "%' or  c_comname like '%" + key + "%' or  c_windows like '%" + key + "%' or  c_office like '%" + key + "%') and state_device = 'ชำรุด' order by iddata_device;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewshow.Items.Clear()

            While (mySqlReader.Read())

                With ListViewshow.Items.Add(mySqlReader("iddata_device"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Computer")
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Printer")
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Monitor")
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Other")
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.add("Licens")
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.add("Network")
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add("Spare Part")
                    End If
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add(mySqlReader("detail") + "      Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("state_device") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("state_device"))
                    End If
                    .SubItems.Add(mySqlReader("serialnumber"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub showdatadp()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearch.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM department where departmentname like '%" + key + "%' order by idDepartment;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewfloor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewfloor.Items.Add(mySqlReader("idDepartment"))
                    .SubItems.Add(mySqlReader("departmentname"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = "13" Then
            showdata()
        End If
    End Sub

    Private Sub txtsearchdp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = "13" Then
            showdatadp()
        End If
    End Sub

    Private Sub ListViewshow_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewshow.MouseDoubleClick
        add_aoi()
        'เรียกข้อมูลอีอ้อย
        Dim Listview3_Index As Integer
        Listview3_Index = ListViewshow.SelectedIndices(0)
        'ListViewshow.Items.RemoveAt(Listview3_Index)
    End Sub

    Private Sub add_aoi()
        Dim iddata_device As String = ListViewshow.SelectedItems(0).SubItems(0).Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim CheckIndex As Integer
        Dim i As Integer
        Dim CheckData As Boolean

        CheckData = False
        CheckIndex = ListViewshowdata.Items.Count


        For i = 0 To CheckIndex - 1
            If iddata_device <> ListViewshowdata.Items(i).SubItems(0).Text Then

                CheckData = True

            Else

                CheckData = False
                Exit For
            End If
        Next i

        If CheckData = False And CheckIndex <> 0 Then
            MsgBox("มีรายชื่อนี้อยู่แล้ว", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning Message")

        End If

        If CheckData = True Or CheckIndex = 0 Then

            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader

            mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device= '" & iddata_device & "';"
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    With ListViewshowdata.Items.Add(mySqlReader("iddata_device"))
                        If mySqlReader("type") = "Computer" Then
                            .SubItems.Add("Computer")
                        End If
                        If mySqlReader("type") = "Printer" Then
                            .SubItems.Add("Printer")
                        End If
                        If mySqlReader("type") = "Monitor" Then
                            .SubItems.Add("Monitor")
                        End If
                        If mySqlReader("type") = "Other" Then
                            .SubItems.Add("Other")
                        End If
                        If mySqlReader("type") = "License" Then
                            .SubItems.add("Licens")
                        End If
                        If mySqlReader("type") = "Network" Then
                            .SubItems.add("Network")
                        End If
                        If mySqlReader("type") = "Spare Part" Then
                            .subitems.add("Spare Part")
                        End If
                        .SubItems.Add(mySqlReader("name"))

                        If mySqlReader("type") = "Computer" Then
                            .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                        End If
                        If mySqlReader("type") = "Monitor" Then
                            .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                        End If
                        If mySqlReader("type") = "Printer" Then
                            .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                        End If
                        If mySqlReader("type") = "Other" Then
                            .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                        End If
                        If mySqlReader("type") = "License" Then
                            .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                        End If
                        If mySqlReader("type") = "Network" Then
                            .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                        End If
                        If mySqlReader("type") = "Spare Part" Then
                            .subitems.add(mySqlReader("detail") + "      Price : " + mySqlReader("price"))
                        End If
                        If mySqlReader("state_device") IsNot DBNull.Value Then
                            .SubItems.Add(mySqlReader("state_device"))
                        End If
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("ห้ามใส่เครื่องหมาย ' ในช่องค้นหา", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
            End Try
            sql.Close()
        End If
    End Sub

    Private Sub btnsearchdp_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        showdatadp()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        showdata()
    End Sub

    Private Sub แกไขอปกรณToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub ListViewfloor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewfloor.Click
        idkey = ListViewfloor.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM section where idFloor = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewsection.Items.Clear()
            ListViewlocat.Items.Clear()
            While (mySqlReader.Read())

                With ListViewsection.Items.Add(mySqlReader("idsection"))
                    .subitems.add(mySqlReader("section_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewsection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewsection.Click
        idkey = ListViewsection.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocat.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocat.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewlocat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlocat.Click
        idkey = ListViewlocat.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM location  where idlocation = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtidlocation.Text = mySqlReader("idlocation")
                txtlocation.Text = mySqlReader("location_name")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtidlocation.Text <> "" And ListViewshowdata.Items.Count > 0 Then

            savedata()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตาราง", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtlocation.Text = ""
        txtidlocation.Text = ""
        ListViewlocat.Items.Clear()
    End Sub
    Private Sub savedata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        Dim commandText As String
        Dim commandText2 As String
        Dim commandText3 As String
        Dim counter1 As Integer = 0
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        For counter1 = 0 To ListViewshowdata.Items.Count - 1

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            commandText = "UPDATE data_device SET state_device = 'ถูกใช้งาน' , idlocation = '" & txtidlocation.Text & "' WHERE iddata_device = '" & ListViewshowdata.Items(counter1).SubItems(0).Text & "' "
            mySqlCommand.CommandText = commandText
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            sql.Close()

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            Try
                mySqlCommand.CommandText = "INSERT INTO device_location (iddata_device,idlocation,date_time_book) VALUES ('" & ListViewshowdata.Items(counter1).SubItems(0).Text & "',  '" & txtidlocation.Text & "','" & Date.Now.ToString & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            sql.Close()
        Next counter1
        ListViewshowdata.Items.Clear()
        txtidlocation.Text = ""

        showdata()

    End Sub

    Private Sub ListViewshowdata_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewshowdata.DoubleClick
        Dim Listview3_Index As Integer
        Listview3_Index = ListViewshowdata.SelectedIndices(0)
        ListViewshowdata.Items.RemoveAt(Listview3_Index)
    End Sub


End Class