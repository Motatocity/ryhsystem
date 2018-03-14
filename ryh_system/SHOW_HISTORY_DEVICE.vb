Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class SHOW_HISTORY_DEVICE
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String

    Dim idstring() As String
    Dim idstring2() As String
    Dim idstring3() As String
    Dim idkeyindex As String

    Private Sub SHOW_HISTORY_DEVICE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM floor order by idFloor;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())

                ComboBox1.Items.Add(mySqlReader("idFloor").ToString + "|" + mySqlReader("floor_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub


    Private Sub ListViewlocat_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListViewshowall_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtedit.Text <> "" Then

            savedatablank()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ListViewshowdevice.Items.Clear()

    End Sub
    Private Sub savedatablank()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Complete")
        If respone = 1 Then
            If txtedit.Text <> "" Then

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If

                Try
                    commandText2 = "UPDATE data_device SET state_device = 'ว่าง' , idlocation = '' WHERE iddata_device = " & txtedit.Text & "; "
                    mySqlCommand.CommandText = commandText2
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
            End If
        End If
    End Sub




    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        idkey = ComboBox1.Text
        idstring = Split(idkey, "|")

        ComboBox2.Items.Clear()


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

        mySqlCommand.CommandText = "SELECT * FROM section where idFloor = '" & idstring(0) & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
       
            While (mySqlReader.Read())

             
                ComboBox2.Items.Add(mySqlReader("idsection").ToString + "|" + mySqlReader("section_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged

        ComboBox3.Items.Clear()

        idkey = ComboBox2.Text
        idstring2 = Split(idkey, "|")
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

        mySqlCommand.CommandText = "SELECT location.idlocation,location_name FROM location where idsection = '" & idstring2(0) & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())

             
                ComboBox3.Items.Add(mySqlReader("idlocation").ToString + "|" + mySqlReader("location_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub ComboBox3_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedValueChanged
        DataGridViewX1.Rows.Clear()


        idkey = ComboBox3.Text
        idstring3 = Split(idkey, "|")
        'ดึงข้อมูลจากตาราง 4/7/56
        Dim dpname As String
        dpname = ComboBox2.Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM location where idlocation = '" & idstring3(0) & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                'TextBox1.Text = mySqlReader("description_name")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim strtype As String
        Dim strmodel As String
        Dim checkfull As String = "0"

        Dim count As Integer = 1
        mySqlCommand.CommandText = "SELECT * FROM data_device where idlocation = '" & idstring3(0) & "' ; "
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())


                    If mySqlReader("type") = "Computer" Then
                        strmodel = "Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price")
                End If
                    If mySqlReader("type") = "Monitor" Then
                        strmodel = "Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price")
                    End If
                    If mySqlReader("type") = "Printer" Then
                        strmodel = "Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price")
                    End If
                    If mySqlReader("type") = "Other" Then
                        strmodel = "Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Type :" + mySqlReader("s_type")
                    End If
                    If mySqlReader("type") = "Network" Then
                        strmodel = "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price")
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        strmodel = mySqlReader("detail") + "   Price : " + mySqlReader("price")
                    End If
                    If mySqlReader("state_device") IsNot DBNull.Value Then
                        strtype = mySqlReader("state_device")
                    End If
                'subitem แสดงข้อมูล dpname ที่เก็บมาแสดงในตาราง
                If mySqlReader("checkedfull") Is DBNull.Value Then
                    checkfull = "0"
                Else
                    If mySqlReader("checkedfull") = "" Or mySqlReader("checkedfull") = "0" Then
                        checkfull = "0"
                    ElseIf mySqlReader("checkedfull") = "1" Then
                        checkfull = "1"
                    End If
                End If

                DataGridViewX1.Rows.Add({mySqlReader("iddata_device"), mySqlReader("type"), mySqlReader("name"), strmodel, strtype, idstring2(1), mySqlReader("serialnumber"), checkfull})


                count = count + 1
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtamount.Text = DataGridViewX1.Rows.Count.ToString





        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM helpdesk where idlocation = '" & idstring3(0) & "' ;"
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


        colors()
    End Sub
    Public Sub colors()


        For i As Integer = 0 To DataGridViewX1.Rows.Count - 1

            If DataGridViewX1.Rows(i).Cells(7).Value = "0" Then

            End If

            If DataGridViewX1.Rows(i).Cells(7).Value = "1" Then
                DataGridViewX1.Rows(i).Cells(1).Style.BackColor = Color.ForestGreen
            End If
        Next
    End Sub
    Public Sub searchnewData()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim checkfull As String
        sql.Close()
        DataGridViewX1.Rows.Clear()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim strtype As String
        Dim strmodel As String

        Dim count As Integer = 1
        MySqlCommand.CommandText = "SELECT * FROM data_device where idlocation = '" & idstring3(0) & "' ; "
        MySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = MySqlCommand
        Try
            mySqlReader = MySqlCommand.ExecuteReader

            While (mySqlReader.Read())


                If mySqlReader("type") = "Computer" Then
                    strmodel = "Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price")

                End If
                If mySqlReader("type") = "Monitor" Then
                    strmodel = "Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price")
                End If
                If mySqlReader("type") = "Printer" Then
                    strmodel = "Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price")
                End If
                If mySqlReader("type") = "Other" Then
                    strmodel = "Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Type :" + mySqlReader("s_type")
                End If
                If mySqlReader("type") = "Network" Then
                    strmodel = "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price")
                End If
                If mySqlReader("type") = "Spare Part" Then
                    strmodel = mySqlReader("detail") + "   Price : " + mySqlReader("price")
                End If
                If mySqlReader("state_device") IsNot DBNull.Value Then
                    strtype = mySqlReader("state_device")
                End If
                'subitem แสดงข้อมูล dpname ที่เก็บมาแสดงในตาราง
                If mySqlReader("checkedfull") Is DBNull.Value Then
                    checkfull = "0"
                Else
                    If mySqlReader("checkedfull") = "" Or mySqlReader("checkedfull") = "0" Then
                        checkfull = "0"
                    ElseIf mySqlReader("checkedfull") = "1" Then
                        checkfull = "1"
                    End If
                End If
                DataGridViewX1.Rows.Add({mySqlReader("iddata_device"), mySqlReader("type"), mySqlReader("name"), strmodel, strtype, idstring2(1), mySqlReader("serialnumber"), checkfull})


                count = count + 1
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtamount.Text = DataGridViewX1.Rows.Count.ToString





        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        MySqlCommand.CommandText = "SELECT * FROM helpdesk where idlocation = '" & idstring3(0) & "' ;"
        MySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = MySqlCommand

        Try
            mySqlReader = MySqlCommand.ExecuteReader
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
        colors()

    End Sub
    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick


        ListViewshowdevice.Items.Clear()

        idkey = DataGridViewX1.Rows(0).Cells(0).Value

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

        mySqlCommand.CommandText = "SELECT section_name,date_time_book FROM device_location join section join location where  (device_location.idlocation = location.idlocation and section.idsection = location.idsection )  and iddata_device = '" & idkey & "';"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewshowdevice.Items.Clear()

            While (mySqlReader.Read())

                With ListViewshowdevice.Items.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("date_time_book"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        idkey = DataGridViewX1.Rows(0).Cells(0).Value

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device  where iddata_device = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtedit.Text = mySqlReader("iddata_device")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        txtamount.Text = DataGridViewX1.Rows.Count






       

    End Sub


    Private Sub DataGridViewX1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewX1.CellMouseDown

        idkeyindex = e.RowIndex

       
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim StatusDate As String
        Dim commandText3 As String
        StatusDate = Microsoft.VisualBasic.InputBox("Password")

        If StatusDate.Length = 0 Then
        ElseIf StatusDate.ToString = "2531119" Then

            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            commandText3 = "Delete FROM data_device  where iddata_device = '" & DataGridViewX1.Rows(idkeyindex).Cells(0).Value & "'; "
            mySqlCommand.CommandText = commandText3
            mySqlCommand.CommandType = CommandType.Text
            MySqlCommand.Connection = sql
            MySqlCommand.ExecuteNonQuery()


            Try


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sql.Close()
            searchnewData()


        End If
    End Sub

    Private Sub Lost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lost.Click
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then

            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader
            Dim commandText2 As String

            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            Try
                commandText2 = "UPDATE data_device SET idlocation ='' , state_device ='ชำรุด'  WHERE iddata_device = " & DataGridViewX1.Rows(idkeyindex).Cells(0).Value & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            sql.Close()
            searchnewData()
        End If


    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If DataGridViewX1.Rows(idkeyindex).Cells(1).Value = "Computer" Then
            Dim nextform As frmdevice_computer = New frmdevice_computer(DataGridViewX1.Rows(idkeyindex).Cells(0).Value)
            nextform.Show()
        ElseIf DataGridViewX1.Rows(idkeyindex).Cells(1).Value = "Network" Then
            Dim nextform As frmdevice_network = New frmdevice_network(DataGridViewX1.Rows(idkeyindex).Cells(0).Value)
            nextform.Show()
        ElseIf DataGridViewX1.Rows(idkeyindex).Cells(1).Value = "Spare Part" Then

        ElseIf DataGridViewX1.Rows(idkeyindex).Cells(1).Value = "Printer" Then
            Dim nextform As frmdevice_printer = New frmdevice_printer(DataGridViewX1.Rows(idkeyindex).Cells(0).Value)
            nextform.Show()
        ElseIf DataGridViewX1.Rows(idkeyindex).Cells(1).Value = "Monitor" Then
            Dim nextform As frmdevice_monitor = New frmdevice_monitor(DataGridViewX1.Rows(idkeyindex).Cells(0).Value)
            nextform.Show()
        ElseIf DataGridViewX1.Rows(idkeyindex).Cells(1).Value = "Other" Then

            Dim nextform As frmdevice_other = New frmdevice_other(DataGridViewX1.Rows(idkeyindex).Cells(0).Value)
            nextform.Show()

        End If

    End Sub

    Private Sub Transfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transfer.Click
        Dim nextform As frmdevice_transfer = New frmdevice_transfer(DataGridViewX1.Rows(idkeyindex).Cells(0).Value)
        nextform.Show()
    End Sub

    Private Sub CompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteToolStripMenuItem.Click
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then

            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader
            Dim commandText2 As String

            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            Try
                commandText2 = "UPDATE data_device SET  checkedfull ='1'  WHERE iddata_device = " & DataGridViewX1.Rows(idkeyindex).Cells(0).Value & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            sql.Close()
            searchnewData()
        End If
    End Sub

    Private Sub UnSuccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnSuccessToolStripMenuItem.Click
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then

            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader
            Dim commandText2 As String

            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            Try
                commandText2 = "UPDATE data_device SET  checkedfull ='0'  WHERE iddata_device = " & DataGridViewX1.Rows(idkeyindex).Cells(0).Value & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            sql.Close()
            searchnewData()
        End If
    End Sub
End Class