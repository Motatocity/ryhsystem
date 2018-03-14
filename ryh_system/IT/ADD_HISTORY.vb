Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class ADD_HISTORY
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey2 As String

    Private Sub ADD_HISTORY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        'key = txtsearchdp.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM floor order by idFloor;"
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

    Private Sub ListViewdp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewsection.Click
        idkey = ListViewsection.SelectedItems(0).SubItems(0).Text
        idkey2 = ListViewsection.SelectedItems(0).SubItems(0).Text

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
            ListViewshowhis.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()




    End Sub

    Private Sub ListViewlocat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlocat.Click
        idkey = ListViewlocat.SelectedItems(0).SubItems(0).Text
        'ดึงข้อมูลจากตาราง 4/7/56
        Dim dpname As String
        dpname = ListViewsection.SelectedItems(0).SubItems(1).Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim count5 As String
        Dim count6 As String
        count6 = ListViewlocat.SelectedItems(0).SubItems(1).Text

        mySqlCommand.CommandText = "SELECT * FROM location where idlocation = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1
        mySqlCommand.CommandText = "SELECT * FROM data_device where idlocation = '" & idkey & "' ; "
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListViewshowall.Items.Clear()
            While (mySqlReader.Read())
                With ListViewshowall.Items.Add(mySqlReader("iddata_device"))
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
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add(mySqlReader("detail") + "      Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("state_device") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("state_device"))
                    End If
                    'subitem แสดงข้อมูล dpname ที่เก็บมาแสดงในตาราง
                    .subitems.add(dpname)

                End With
                count = count + 1
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM helpdesk where idlocation = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListViewshowhis.Items.Clear()

            While (mySqlReader.Read())

                With ListViewshowhis.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("problem"))
                    .subitems.add(mySqlReader("edit_problem"))
                    .subitems.add(mySqlReader("date"))
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


    End Sub


    Private Sub ListViewshowall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewshowall.Click
        idkey = ListViewshowall.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader

        mysqlcommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        mysqlcommand.Connection = sql
        mysqladeptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader
            While (mysqlreader.Read())
                txtid.Text = mysqlreader("iddata_Device")
                txtlocation.Text = mysqlreader("idlocation")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mysqlcommand.CommandText = "SELECT  maintenance_device,date_maintenance,iddata_device FROM maintenance   where    iddata_device = '" & idkey & "';"
        mysqlcommand.Connection = sql
        mysqladeptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader

            ListViewshowhis.Items.Clear()

            While (mysqlreader.Read())

                With ListViewshowhis.Items.Add(mysqlreader("iddata_device"))
                    .SubItems.Add(mysqlreader("maintenance_device"))
                    .SubItems.Add(mysqlreader("date_maintenance"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        'If sql.State = ConnectionState.Closed Then
        '    sql.Open()
        'End If
        'mysqlcommand.CommandText = "SELECT * FROM helpdesk where idlocation = '" & idkey2 & "' ;"
        'mysqlcommand.Connection = sql
        'mysqladeptor.SelectCommand = mysqlcommand

        'Try
        '    mysqlreader = mysqlcommand.ExecuteReader

        '    While (mysqlreader.Read())

        '        With ListViewshowhis.Items.Add(mysqlreader("location"))
        '            .subitems.add(mysqlreader("edit_problem"))
        '            .subitems.add(mysqlreader("date"))
        '        End With
        '    End While

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        'sql.Close()


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try

            If txtid.Text <> "" And txtdetail.Text <> "" Then
                mysqlcommand.CommandText = " INSERT INTO maintenance (maintenance_device,date_maintenance,iddata_device,idsection) VALUES ('" & txtdetail.Text & "','" + Date.Now.ToString + "','" & txtid.Text & "','" & txtlocation.Text & "' ) ;"
                mysqlcommand.CommandType = CommandType.Text
                mysqlcommand.Connection = sql
                mysqlcommand.ExecuteNonQuery()

                txtid.Text = ""
                txtlocation.Text = ""
                txtdetail.Text = ""
            Else
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mysqlcommand.CommandText = "SELECT  maintenance_device,date_maintenance,iddata_device FROM maintenance   where    iddata_device = '" & idkey & "';"
        mysqlcommand.Connection = sql
        mysqladeptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader

            ListViewshowhis.Items.Clear()

            While (mysqlreader.Read())

                With ListViewshowhis.Items.Add(mysqlreader("iddata_device"))
                    .SubItems.Add(mysqlreader("maintenance_device"))
                    .SubItems.Add(mysqlreader("date_maintenance"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
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



End Class