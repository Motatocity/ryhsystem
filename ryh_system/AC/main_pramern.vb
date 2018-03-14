Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports System.Data


Public Class main_pramern
    Dim responseFromServer As String
    Dim mysql As MySqlConnection
    Dim id_key As String
    Dim diff1 As System.TimeSpan

    Dim date1 As Date
    Dim date2 As Date
    Dim subdate1() As String
    Dim subdate2() As String
    Dim valuedate As String

    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim group_id As String
    Dim type_id As String
    Dim diag_id As String
    Dim id_primary As String
    Dim max_df As Long = 0
    Dim min_df As Long = 0
    Dim max_total As Long = 0
    Dim min_total As Long = 0

    Dim total_df As Long
    Dim total_total As Long
    Dim pramern_price As String
    Dim iddoc_no As String
    Dim id_hn As String
    Dim id_an As String
    Dim Date_start_split() As String
    Dim Date_end_split() As String
    Dim counter As Integer = 0

    Dim service As Long = 0
    Dim medical_care As Long = 0
    Dim check_up As Long = 0
    Dim procedures As Long = 0
    Dim drug As Long = 0
    Dim df As Long = 0
    Dim ER As Long = 0
    Dim spawn As Long = 0
    Dim lab As Long = 0
    Dim x_ray As Long = 0
    Dim car_hospital As Long = 0
    Dim ekg As Long = 0
    Dim dental As Long = 0
    Dim physical As Long = 0

    Dim total_sum As Integer = 0
    Dim total_service As Integer = 0


    Private Sub main_pramern_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("ได้ปรับปรุงระบบส่งSMS ใหม่ สามารถทดสอบส่งได่้เลยครับ")
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView3.Items.Clear()
            ListView4.Items.Clear()
            While (mySqlReader.Read())

                With ListView3.Items.Add(mySqlReader("idpramern_price"))

                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("diag_name"))

                End With
                With ListView4.Items.Add(mySqlReader("idpramern_price"))

                    .SubItems.Add(mySqlReader("group_name"))

                    .SubItems.Add(mySqlReader("type_name"))
                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("diag_name"))

                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If










        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM insurance;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView8.Items.Clear()

            While (mySqlReader.Read())

                With ListView8.Items.Add(mySqlReader("idinsurance"))

                    .SubItems.Add(mySqlReader("name_insurance"))
                    .SubItems.Add(mySqlReader("nameof_insurance"))
                    .SubItems.Add(mySqlReader("tell_insurance"))
                    .SubItems.Add(mySqlReader("tell2_insurance"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM kpi_pramern where dep ='ac';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView5.Items.Clear()

            While (mySqlReader.Read())

                With ListView5.Items.Add(mySqlReader("idkpi_pramern"))

                    .SubItems.Add(mySqlReader("point_kpi"))
                    .SubItems.Add(mySqlReader("percent_1"))
                    .SubItems.Add(mySqlReader("date_day"))
                    .SubItems.Add(mySqlReader("timeofday"))
                    .SubItems.Add(mySqlReader("dep"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()




    End Sub
    Private Sub showdatains()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM insurance where name_insurance like '%" & TextBox21.Text & "%' or nameof_insurance ='%" & TextBox21.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView8.Items.Clear()

            While (mySqlReader.Read())

                With ListView8.Items.Add(mySqlReader("idinsurance"))

                    .SubItems.Add(mySqlReader("name_insurance"))
                    .SubItems.Add(mySqlReader("nameof_insurance"))
                    .SubItems.Add(mySqlReader("tell_insurance"))
                    .SubItems.Add(mySqlReader("tell2_insurance"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
    Public Sub search_date()
        clear_data()

        max_df = 0
        min_df = 0
        max_total = 0
        min_total = 0



        TextBox35.Text = "0"
        ผ่าตัด.Text = "0"
        เยี่ยมไข้.Text = "0"
        วิสัญญี.Text = "0"
        รวม.Text = "0"
        อื่นๆ.Text = "0"
        service = 0
        medical_care = 0
        check_up = 0
        procedures = 0
        drug = 0
        df = 0
        ER = 0
        spawn = 0
        lab = 0
        x_ray = 0
        car_hospital = 0
        ekg = 0
        dental = 0
        physical = 0

        total_sum = 0
        total_service = 0




        txt_total.Text = "0"

        txt_total_service.Text = "0"



        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE FROM ORCMASV5PF inner join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "' ")

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView1.Items.Clear()

            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView1.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)

                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetDecimal(4).ToString)

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()
        TextBox6.Text = ListView1.Items.Count

        For counter1 = 0 To ListView1.Items.Count - 1

            id_hn = ListView1.Items(counter1).SubItems(2).Text
            id_an = ListView1.Items(counter1).SubItems(3).Text

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            selectCMD = New OdbcCommand("SELECT IBDDOCTYP,IBDPRDNO,IBDHN,IBDAN,IBDTOTAMT FROM IBLDETV5PF where IBDAN = '" & id_an & "' and IBDHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection

            Dim total_de As Decimal = 0
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader

                total_df = 0
                total_total = 0
                'start the Read loop
                While dr.Read

                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view

                    If dr.GetString(0).Trim = "99" Then ' .SubItems.Add("ค่าบริการ")
                        service = service + dr.GetDecimal(4)
                        total_df = total_df + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "14" Then '.SubItems.Add("เวชภัณฑ์ Ward")
                        medical_care = medical_care + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "13" Then '.SubItems.Add("ตรวจสุขภาพ")
                        check_up = check_up + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "12" Then '.SubItems.Add("ค่าหัตการ")
                        procedures = procedures + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "01" Then '   .SubItems.Add("ยา")
                        drug = drug + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "02" Then '    .SubItems.Add("ค่าแพทย์ DF")
                        df = df + dr.GetDecimal(4)
                        total_df = total_df + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "10" Then '    .SubItems.Add("ห้องผ่าตัด")
                        ER = ER + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "11" Then   '  .SubItems.Add("ห้องคลอด")
                        spawn = spawn + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "03" Then ' .SubItems.Add("Lab")
                        lab = lab + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "04" Then '.SubItems.Add("X-ray")
                        x_ray = x_ray + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "10" Then ' .SubItems.Add("รถพยาบาล")
                        car_hospital = car_hospital + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "07" Then '     .SubItems.Add("EKG")
                        ekg = ekg + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "08" Then '       .SubItems.Add("ทันตกรรม")
                        dental = dental + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "09" Then '           .SubItems.Add("กายภาพ")
                        physical = physical + dr.GetDecimal(4)
                        total_total = total_total + dr.GetDecimal(4)
                    End If


                    'End the loop
                End While
                'Reset the cursor




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MyODBCConnection.Close()
            If max_df = 0 Then
                max_df = total_df
            ElseIf max_df < total_df Then
                max_df = total_df
            End If

            If min_df = 0 Then
                min_df = total_df
            ElseIf min_df > total_df Then
                min_df = total_df
            End If

            If min_total = 0 Then
                min_total = total_total
            ElseIf min_total > total_total Then
                min_total = total_total
            End If

            If max_total = 0 Then
                max_total = total_total
            ElseIf max_total < total_total Then
                max_total = total_total
            End If


        Next


        If service <> 0 Then
            txt_service1.Text = Format(service / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_service1.Text
        End If

        If medical_care <> 0 Then
            txt_medical_care1.Text = Format(medical_care / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_medical_care1.Text

        End If
        If check_up <> 0 Then
            txt_check_up1.Text = Format(check_up / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_check_up1.Text
        End If

        If procedures <> 0 Then
            txt_search_diag.Text = Format(procedures / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_search_diag.Text

        End If

        If drug <> 0 Then
            txt_drug1.Text = Format(drug / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_drug1.Text
        End If

        If df <> 0 Then
            txt_df1.Text = Format(df / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_df1.Text
        End If

        If ER <> 0 Then
            txt_er1.Text = Format(ER / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_er1.Text
        End If

        If spawn <> 0 Then
            txt_spawn1.Text = Format(spawn / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_spawn1.Text
        End If

        If lab <> 0 Then
            txt_lab1.Text = Format(lab / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_lab1.Text
        End If


        If x_ray <> 0 Then
            txt_x_ray1.Text = Format(x_ray / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_x_ray1.Text
        End If

        If car_hospital <> 0 Then
            txt_car_hospital1.Text = Format(car_hospital / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_car_hospital1.Text

        End If
        If ekg <> 0 Then
            txt_ekg1.Text = Format(ekg / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_ekg1.Text

        End If

        If dental <> 0 Then
            txt_dental1.Text = Format(dental / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_dental1.Text
        End If

        If physical <> 0 Then
            txt_physic1.Text = Format(physical / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_physic1.Text

        End If




        txt_total.Text = total_sum + total_service

        txt_total_service.Text = total_service



    End Sub
    Private Sub drcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If



            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT DMSDRCOD,DMSPRENAM,DMSNAME,DMSSURNAM FROM DRMASV5PF where DMSDRCOD like '%" & drcode.Text & "%' or DMSNAME like '%" & drcode.Text & "%' or DMSSURNAM like '" & drcode.Text & "'")

            selectCMD.Connection = MyODBCConnection

            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                ListView2.Items.Clear()

                If dr.HasRows Then
                    While dr.Read
                        With ListView2.Items.Add(dr.GetString("0"))
                            .SubItems.Add(dr.GetString(1) + " " + dr.GetString("2") + " " + dr.GetString("3"))

                        End With
                        'Note: the numbers in double quotes represent the column number from the AS400 database
                        'Add the data to the list view
                        'End the loop
                    End While
                    If pramern_price <> "" Then
                        search_date_dr_check()
                    End If
                Else

                    'Reset the cursor
                End If
                'start the Read loop



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MyODBCConnection.Close()
        End If
    End Sub
    Public Sub search_date_dr_check()

        max_df = 0
        min_df = 0
        max_total = 0
        min_total = 0


        txt_car_hospital1.Text = "0"
        txt_check_up1.Text = "0"
        txt_dental1.Text = "0"
        txt_df1.Text = "0"
        txt_drug1.Text = "0"
        txt_ekg1.Text = "0"
        txt_er1.Text = "0"
        txt_lab1.Text = "0"
        txt_medical_care1.Text = "0"
        txt_physic1.Text = "0"
        txt_search_diag.Text = "0"
        txt_service1.Text = "0"
        txt_spawn1.Text = "0"
        txt_total.Text = "0"
        txt_total_service.Text = "0"
        txt_x_ray1.Text = "0"


        txt_total.Text = "0"

        txt_total_service.Text = "0"


        service = 0
        medical_care = 0
        check_up = 0
        procedures = 0
        drug = 0
        df = 0
        ER = 0
        spawn = 0
        lab = 0
        x_ray = 0
        car_hospital = 0
        ekg = 0
        dental = 0
        physical = 0

        total_sum = 0
        total_service = 0




        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE FROM ORCMASV5PF left join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO left join ORCMPSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMPSV5PF.OMPDOCNO where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "'  and OMPDRCOD = '" & txt_iddrcod.Text & "'")

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView1.Items.Clear()

            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView1.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)

                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetDecimal(4).ToString)

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()
        TextBox6.Text = ListView1.Items.Count

        For counter1 = 0 To ListView1.Items.Count - 1

            id_hn = ListView1.Items(counter1).SubItems(2).Text
            id_an = ListView1.Items(counter1).SubItems(3).Text

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            total_df = 0
            total_total = 0
            selectCMD = New OdbcCommand("SELECT IBDDOCTYP,IBDPRDNO,IBDHN,IBDAN,IBDTOTAMT FROM IBLDETV5PF where IBDAN = '" & id_an & "' and IBDHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection

            Dim total_de As Decimal = 0
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop

                While dr.Read


                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view


                    If dr.GetString(0).Trim = "99" Then ' .SubItems.Add("ค่าบริการ")
                        service = service + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "14" Then '.SubItems.Add("เวชภัณฑ์ Ward")
                        medical_care = medical_care + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "13" Then '.SubItems.Add("ตรวจสุขภาพ")
                        check_up = check_up + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "12" Then '.SubItems.Add("ค่าหัตการ")
                        procedures = procedures + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "01" Then '   .SubItems.Add("ยา")
                        drug = drug + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "02" Then '    .SubItems.Add("ค่าแพทย์ DF")
                        df = df + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "10" Then '    .SubItems.Add("ห้องผ่าตัด")
                        ER = ER + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "11" Then   '  .SubItems.Add("ห้องคลอด")
                        spawn = spawn + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "03" Then ' .SubItems.Add("Lab")
                        lab = lab + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "04" Then '.SubItems.Add("X-ray")
                        x_ray = x_ray + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "10" Then ' .SubItems.Add("รถพยาบาล")
                        car_hospital = car_hospital + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "07" Then '     .SubItems.Add("EKG")
                        ekg = ekg + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "08" Then '       .SubItems.Add("ทันตกรรม")
                        dental = dental + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "09" Then '           .SubItems.Add("กายภาพ")
                        physical = physical + dr.GetDecimal(4)

                    End If


                    'End the loop
                End While
                'Reset the cursor
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MyODBCConnection.Close()
        Next

        If service <> 0 Then
            txt_service1.Text = Format(service / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_service1.Text
        End If

        If medical_care <> 0 Then
            txt_medical_care1.Text = Format(medical_care / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_medical_care1.Text

        End If
        If check_up <> 0 Then
            txt_check_up1.Text = Format(check_up / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_check_up1.Text
        End If

        If procedures <> 0 Then
            txt_search_diag.Text = Format(procedures / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_search_diag.Text

        End If

        If drug <> 0 Then
            txt_drug1.Text = Format(drug / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_drug1.Text
        End If

        If df <> 0 Then
            txt_df1.Text = Format(df / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_df1.Text
        End If

        If ER <> 0 Then
            txt_er1.Text = Format(ER / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_er1.Text
        End If

        If spawn <> 0 Then
            txt_spawn1.Text = Format(spawn / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_spawn1.Text
        End If

        If lab <> 0 Then
            txt_lab1.Text = Format(lab / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_lab1.Text
        End If


        If x_ray <> 0 Then
            txt_x_ray1.Text = Format(x_ray / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_x_ray1.Text
        End If

        If car_hospital <> 0 Then
            txt_car_hospital1.Text = Format(car_hospital / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_car_hospital1.Text

        End If
        If ekg <> 0 Then
            txt_ekg1.Text = Format(ekg / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_ekg1.Text

        End If

        If dental <> 0 Then
            txt_dental1.Text = Format(dental / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_dental1.Text
        End If

        If physical <> 0 Then
            txt_physic1.Text = Format(physical / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_physic1.Text

        End If


        txt_total.Text = total_sum + total_service

        txt_total_service.Text = total_service


    End Sub
    Private Sub ListView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.Click
        txt_iddrcod.Text = ListView2.SelectedItems(0).SubItems(0).Text
        If txt_iddrcod.Text <> "" Then
            search_date_dr_check()
        End If
    End Sub
    Public Sub check_date_diag()

        Date_start_split = Split(date_start.Text, "/")
        Date_end_split = Split(date_end.Text, "/")





        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE FROM ORCMASV5PF left join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO left join ORCMPSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMPSV5PF.OMPDOCNO where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "'  and OMPDRCOD = '" & txt_iddrcod.Text & "'  and OMDSECDTE >= '" & Date_start_split(2) + Date_start_split(1) + Date_start_split(0) & "' and OMDSECDTE <= '" & Date_end_split(2) + Date_end_split(1) + Date_end_split(0) & "'")

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView1.Items.Clear()

            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView1.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)

                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetDecimal(4).ToString)

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        MyODBCConnection.Close()
        TextBox6.Text = ListView1.Items.Count

        For counter1 = 0 To ListView1.Items.Count - 1

            id_hn = ListView1.Items(counter1).SubItems(2).Text
            id_an = ListView1.Items(counter1).SubItems(3).Text

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            total_df = 0
            total_total = 0
            selectCMD = New OdbcCommand("SELECT IBDDOCTYP,IBDPRDNO,IBDHN,IBDAN,IBDTOTAMT FROM IBLDETV5PF where IBDAN = '" & id_an & "' and IBDHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection

            Dim total_de As Decimal = 0
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop

                While dr.Read


                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view


                    If dr.GetString(0).Trim = "99" Then ' .SubItems.Add("ค่าบริการ")
                        service = service + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "14" Then '.SubItems.Add("เวชภัณฑ์ Ward")
                        medical_care = medical_care + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "13" Then '.SubItems.Add("ตรวจสุขภาพ")
                        check_up = check_up + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "12" Then '.SubItems.Add("ค่าหัตการ")
                        procedures = procedures + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "01" Then '   .SubItems.Add("ยา")
                        drug = drug + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "02" Then '    .SubItems.Add("ค่าแพทย์ DF")
                        df = df + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "10" Then '    .SubItems.Add("ห้องผ่าตัด")
                        ER = ER + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "11" Then   '  .SubItems.Add("ห้องคลอด")
                        spawn = spawn + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "03" Then ' .SubItems.Add("Lab")
                        lab = lab + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "04" Then '.SubItems.Add("X-ray")
                        x_ray = x_ray + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "10" Then ' .SubItems.Add("รถพยาบาล")
                        car_hospital = car_hospital + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "07" Then '     .SubItems.Add("EKG")
                        ekg = ekg + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "08" Then '       .SubItems.Add("ทันตกรรม")
                        dental = dental + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "09" Then '           .SubItems.Add("กายภาพ")
                        physical = physical + dr.GetDecimal(4)

                    End If


                    'End the loop
                End While
                'Reset the cursor




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MyODBCConnection.Close()

        Next


        If service <> 0 Then
            txt_service1.Text = Format(service / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_service1.Text
        End If

        If medical_care <> 0 Then
            txt_medical_care1.Text = Format(medical_care / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_medical_care1.Text

        End If
        If check_up <> 0 Then
            txt_check_up1.Text = Format(check_up / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_check_up1.Text
        End If

        If procedures <> 0 Then
            txt_search_diag.Text = Format(procedures / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_search_diag.Text

        End If

        If drug <> 0 Then
            txt_drug1.Text = Format(drug / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_drug1.Text
        End If

        If df <> 0 Then
            txt_df1.Text = Format(df / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_df1.Text
        End If

        If ER <> 0 Then
            txt_er1.Text = Format(ER / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_er1.Text
        End If

        If spawn <> 0 Then
            txt_spawn1.Text = Format(spawn / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_spawn1.Text
        End If

        If lab <> 0 Then
            txt_lab1.Text = Format(lab / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_lab1.Text
        End If


        If x_ray <> 0 Then
            txt_x_ray1.Text = Format(x_ray / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_x_ray1.Text
        End If

        If car_hospital <> 0 Then
            txt_car_hospital1.Text = Format(car_hospital / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_car_hospital1.Text

        End If
        If ekg <> 0 Then
            txt_ekg1.Text = Format(ekg / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_ekg1.Text

        End If

        If dental <> 0 Then
            txt_dental1.Text = Format(dental / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_dental1.Text
        End If

        If physical <> 0 Then
            txt_physic1.Text = Format(physical / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_physic1.Text

        End If


        txt_total.Text = total_sum + total_service

        txt_total_service.Text = total_service

    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If date_end.Text <> "  /  /" And date_start.Text <> "  /  /" And pramern_price <> "" And txt_iddrcod.Text <> "" Then
            check_date_diag()
        End If
    End Sub
    Public Sub clear_data()
        txt_car_hospital1.Text = "0"
        txt_check_up1.Text = "0"
        txt_dental1.Text = "0"
        txt_df1.Text = "0"
        txt_drug1.Text = "0"
        txt_ekg1.Text = "0"
        txt_er1.Text = "0"
        txt_lab1.Text = "0"
        txt_medical_care1.Text = "0"
        txt_physic1.Text = "0"
        txt_search_diag.Text = "0"
        txt_service1.Text = "0"
        txt_spawn1.Text = "0"
        txt_total.Text = "0"
        txt_total_service.Text = "0"
        txt_x_ray1.Text = "0"
        txt_dental1.Text = "0"
        txt_physic1.Text = "0"
        txt_service1.Text = "0"
        txt_drug1.Text = "0"
        txt_er1.Text = "0"
        txt_search_diag.Text = "0"
        txt_total.Text = "0"

        txt_total_service.Text = "0"


        service = 0
        medical_care = 0
        check_up = 0
        procedures = 0
        drug = 0
        df = 0
        ER = 0
        spawn = 0
        lab = 0
        x_ray = 0
        car_hospital = 0
        ekg = 0
        dental = 0
        physical = 0

        total_sum = 0
        total_service = 0



        
    End Sub
    Public Sub showdata()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price where diag_name like '%" & txtsearch_diag.Text & "%'  or name_thai like '%" & txtsearch_diag.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView3.Items.Clear()

            While (mySqlReader.Read())

                With ListView3.Items.Add(mySqlReader("idpramern_price"))

                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("diag_name"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub
    Private Sub ListView3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.Click
        clear_data()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price where idpramern_price = '" & ListView3.SelectedItems(0).SubItems(0).Text & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                group_id = mySqlReader("group_name")
                type_id = mySqlReader("type_name")
                diag_id = mySqlReader("otbsurcod")




            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        search_date()


    End Sub
    Private Sub txtsearch_diag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch_diag.KeyDown
        If e.KeyCode = Keys.Enter Then
            showdata()
        End If
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Dim nextform As pramern_add_price = New pramern_add_price
        nextform.Show()

    End Sub
    Private Sub ButtonX2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim nextform As edit_diag = New edit_diag
        nextform.Show()
    End Sub
    Public Sub showdata1()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price where diag_name like '%" & TextBox1.Text & "%'  or name_thai like '%" & TextBox1.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView4.Items.Clear()

            While (mySqlReader.Read())

                With ListView4.Items.Add(mySqlReader("idpramern_price"))
                    .SubItems.Add(mySqlReader("group_name"))

                    .SubItems.Add(mySqlReader("type_name"))
                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("diag_name"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            showdata1()
        End If
    End Sub
    Public Sub search_date_dr_check1()

        max_df = 0
        min_df = 0
        max_total = 0
        min_total = 0


        txt_car_hospital1.Text = "0"
        txt_check_up1.Text = "0"
        txt_dental1.Text = "0"
        txt_df1.Text = "0"
        txt_drug1.Text = "0"
        txt_ekg1.Text = "0"
        txt_er1.Text = "0"
        txt_lab1.Text = "0"
        txt_medical_care1.Text = "0"
        txt_physic1.Text = "0"
        txt_search_diag.Text = "0"
        txt_service1.Text = "0"
        txt_spawn1.Text = "0"
        txt_total.Text = "0"
        txt_total_service.Text = "0"
        txt_x_ray1.Text = "0"


        txt_total.Text = "0"

        txt_total_service.Text = "0"


        service = 0
        medical_care = 0
        check_up = 0
        procedures = 0
        drug = 0
        df = 0
        ER = 0
        spawn = 0
        lab = 0
        x_ray = 0
        car_hospital = 0
        ekg = 0
        dental = 0
        physical = 0

        total_sum = 0
        total_service = 0




        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE,RMSNAME,RMSSURNAM FROM ORCMASV5PF left join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO left join ORCMPSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMPSV5PF.OMPDOCNO join REGMASV5PF on  REGMASV5PF.RMSHNREF = ORCMASV5PF.OMSHN  where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "'  and OMPDRCOD = '" & txt_iddrcod.Text & "'")

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView6.Items.Clear()

            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView6.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)

                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetString(6).Trim + "   " + dr.GetString(7).Trim)

                    .SubItems.Add(dr.GetDecimal(4).ToString)

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MyODBCConnection.Close()
        TextBox6.Text = ListView6.Items.Count

        For counter1 = 0 To ListView6.Items.Count - 1

            id_hn = ListView6.Items(counter1).SubItems(2).Text
            id_an = ListView6.Items(counter1).SubItems(3).Text

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            total_df = 0
            total_total = 0
            selectCMD = New OdbcCommand("SELECT IBDDOCTYP,IBDPRDNO,IBDHN,IBDAN,IBDTOTAMT FROM IBLDETV5PF where IBDAN = '" & id_an & "' and IBDHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection

            Dim total_de As Decimal = 0
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop

                While dr.Read


                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view


                    If dr.GetString(0).Trim = "99" Then ' .SubItems.Add("ค่าบริการ")
                        service = service + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "14" Then '.SubItems.Add("เวชภัณฑ์ Ward")
                        medical_care = medical_care + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "13" Then '.SubItems.Add("ตรวจสุขภาพ")
                        check_up = check_up + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "12" Then '.SubItems.Add("ค่าหัตการ")
                        procedures = procedures + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "01" Then '   .SubItems.Add("ยา")
                        drug = drug + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "02" Then '    .SubItems.Add("ค่าแพทย์ DF")
                        df = df + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "10" Then '    .SubItems.Add("ห้องผ่าตัด")
                        ER = ER + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "11" Then   '  .SubItems.Add("ห้องคลอด")
                        spawn = spawn + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "03" Then ' .SubItems.Add("Lab")
                        lab = lab + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "04" Then '.SubItems.Add("X-ray")
                        x_ray = x_ray + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "10" Then ' .SubItems.Add("รถพยาบาล")
                        car_hospital = car_hospital + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "07" Then '     .SubItems.Add("EKG")
                        ekg = ekg + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "08" Then '       .SubItems.Add("ทันตกรรม")
                        dental = dental + dr.GetDecimal(4)

                    ElseIf dr.GetString(0).Trim = "09" Then '           .SubItems.Add("กายภาพ")
                        physical = physical + dr.GetDecimal(4)

                    End If


                    'End the loop
                End While
                'Reset the cursor




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MyODBCConnection.Close()

        Next


        If service <> 0 Then
            txt_service1.Text = Format(service / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_service1.Text
        End If

        If medical_care <> 0 Then
            txt_medical_care1.Text = Format(medical_care / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_medical_care1.Text

        End If
        If check_up <> 0 Then
            txt_check_up1.Text = Format(check_up / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_check_up1.Text
        End If

        If procedures <> 0 Then
            txt_search_diag.Text = Format(procedures / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_search_diag.Text

        End If

        If drug <> 0 Then
            txt_drug1.Text = Format(drug / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_drug1.Text
        End If

        If df <> 0 Then
            txt_df1.Text = Format(df / ListView1.Items.Count, "##.##")
            total_service = total_service + txt_df1.Text
        End If

        If ER <> 0 Then
            txt_er1.Text = Format(ER / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_er1.Text
        End If

        If spawn <> 0 Then
            txt_spawn1.Text = Format(spawn / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_spawn1.Text
        End If

        If lab <> 0 Then
            txt_lab1.Text = Format(lab / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_lab1.Text
        End If


        If x_ray <> 0 Then
            txt_x_ray1.Text = Format(x_ray / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_x_ray1.Text
        End If

        If car_hospital <> 0 Then
            txt_car_hospital1.Text = Format(car_hospital / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_car_hospital1.Text

        End If
        If ekg <> 0 Then
            txt_ekg1.Text = Format(ekg / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_ekg1.Text

        End If

        If dental <> 0 Then
            txt_dental1.Text = Format(dental / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_dental1.Text
        End If

        If physical <> 0 Then
            txt_physic1.Text = Format(physical / ListView1.Items.Count, "##.##")
            total_sum = total_sum + txt_physic1.Text

        End If


        txt_total.Text = total_sum + total_service

        txt_total_service.Text = total_service


    End Sub
    Private Sub ListView4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView4.Click
        clear_data()



        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price where idpramern_price = '" & ListView4.SelectedItems(0).SubItems(0).Text & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())

                group_id = mySqlReader("group_name")
                type_id = mySqlReader("type_name")
                diag_id = mySqlReader("otbsurcod")




            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        search_date1()


    End Sub
    Public Sub search_date1()
        clear_data()

        max_df = 0
        min_df = 0
        max_total = 0
        min_total = 0




        service = 0
        medical_care = 0
        check_up = 0
        procedures = 0
        drug = 0
        df = 0
        ER = 0
        spawn = 0
        lab = 0
        x_ray = 0
        car_hospital = 0
        ekg = 0
        dental = 0
        physical = 0

        total_sum = 0
        total_service = 0




        txt_total.Text = "0"

        txt_total_service.Text = "0"



        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If






        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE,RMSNAME,RMSSURNAM,DMSNAME,DMSSURNAM, PDGADMDTE,PDGDCHDTE FROM RYHPFV5.ORCMASV5PF join REGMASV5PF on  REGMASV5PF.RMSHNREF = ORCMASV5PF.OMSHN  join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO  left join ORCMPSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMPSV5PF.OMPDOCNO left join DRMASV5PF on ORCMPSV5PF.OMPDRCOD = DRMASV5PF.DMSDRCOD left join PATDCGV5PF on PATDCGV5PF.PDGAN =  ORCMASV5PF.OMSAN where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "' and OMPPSNTYP ='01'")

        'Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE,RMSNAME,RMSSURNAM FROM ORCMASV5PF join REGMASV5PF on  REGMASV5PF.RMSHNREF = ORCMASV5PF.OMSHN  join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO    where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "' ")


        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView6.Items.Clear()

            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView6.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)

                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim)
                    .SubItems.Add(dr.GetString(6).Trim + "   " + dr.GetString(7).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)

                    .SubItems.Add(dr.GetDecimal(4).ToString)
                    Try
                        If dr.GetString(8) IsNot DBNull.Value And dr.GetString(9) IsNot DBNull.Value Then
                            .SubItems.Add(dr.GetString(8).ToString.Trim + "   " + dr.GetString(9).ToString.Trim)
                        Else

                        End If
                    Catch ex As Exception

                    End Try

                    Try
                        date1 = New System.DateTime(CStr(dr.GetDecimal(11)).Substring(0, 4), CStr(dr.GetDecimal(11)).Substring(4, 2), CStr(dr.GetDecimal(11)).Substring(6, 2), 0, 0, 0)
                        date2 = New System.DateTime(CStr(dr.GetDecimal(10)).Substring(0, 4), CStr(dr.GetDecimal(10)).Substring(4, 2), CStr(dr.GetDecimal(10)).Substring(6, 2), 0, 0, 0)
                        diff1 = date1.Subtract(date2)
                        valuedate = diff1.TotalDays.ToString
                        .SubItems.Add(valuedate)

                    Catch ex As Exception
                        .SubItems.Add("ผู้ป่วยนอก")
                    End Try

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

  
    End Sub
    Private Sub ListView6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView6.Click
        Dim sumtotal As Integer = 0

        Dim roomtotal As Integer = 0


        clear_data()

        If ListView6.SelectedItems(0).SubItems(8).Text <> "ผู้ป่วยนอก" Then



            อื่นๆ.Text = "0"




            อื่นๆ.Text = "0"
            เยี่ยมไข้.Text = "0"
            วิสัญญี.Text = "0"
            TextBox35.Text = "0"
            ผ่าตัด.Text = "0"

            รวม.Text = CDbl(อื่นๆ.Text) + CDbl(ผ่าตัด.Text) + CDbl(เยี่ยมไข้.Text) + CDbl(วิสัญญี.Text) + CDbl(TextBox35.Text)

            รวม.Text = FormatNumber(CDbl(รวม.Text), TriState.True)


            Label28.Text = "จำนวนวันที่พักรักษา  " + ListView6.SelectedItems(0).SubItems(8).Text + "  วัน"


            id_hn = ListView6.SelectedItems(0).SubItems(2).Text
            id_an = ListView6.SelectedItems(0).SubItems(3).Text
            Dim selectCMD As OdbcCommand
            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If
            total_df = 0
            total_total = 0
            selectCMD = New OdbcCommand("SELECT IBDDOCTYP,IBDPRDNO,IBDHN,IBDAN,IBDTOTAMT,IBDRCPCOD,IBDCHRCOD FROM IBLDETV5PF where IBDAN = '" & id_an & "' and IBDHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection

            Dim total_de As Decimal = 0
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader


                'start the Read loop
                While dr.Read

                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    If dr.GetString(0).Trim = "99" Then ' .SubItems.Add("ค่าบริการ")

                        total_df = total_df + dr.GetDecimal(4)
                        If dr.GetString(5).Trim = "43" And dr.GetString(6).Trim = "2" Then

                            ผ่าตัด.Text = CDbl(ผ่าตัด.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "36" And dr.GetString(6).Trim = "2" Then
                            เยี่ยมไข้.Text = CDbl(เยี่ยมไข้.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "45" And dr.GetString(6).Trim = "2" Then
                            วิสัญญี.Text = CDbl(วิสัญญี.Text) + dr.GetDecimal(4)

                        Else
                            sumtotal += dr.GetDecimal(4)
                            total_total = total_total + dr.GetDecimal(4)
                            roomtotal += +dr.GetDecimal(4)

                        End If

                    ElseIf dr.GetString(0).Trim = "14" Then '.SubItems.Add("เวชภัณฑ์ Ward")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "13" Then '.SubItems.Add("ตรวจสุขภาพ")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "12" Then '.SubItems.Add("ค่าหัตการ")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "01" Then '   .SubItems.Add("ยา")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "02" Then '    .SubItems.Add("ค่าแพทย์ DF")

                        total_df = total_df + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "10" Then '    .SubItems.Add("ห้องผ่าตัด")
                        If dr.GetString(5).Trim = "43" And dr.GetString(6).Trim = "2" Then

                            ผ่าตัด.Text = CDbl(ผ่าตัด.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "36" And dr.GetString(6).Trim = "2" Then
                            เยี่ยมไข้.Text = CDbl(เยี่ยมไข้.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "45" And dr.GetString(6).Trim = "2" Then
                            วิสัญญี.Text = CDbl(วิสัญญี.Text) + dr.GetDecimal(4)

                        Else
                            sumtotal += dr.GetDecimal(4)

                            total_total = total_total + dr.GetDecimal(4)
                        End If

                    ElseIf dr.GetString(0).Trim = "11" Then   '  .SubItems.Add("ห้องคลอด")
                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "03" Then ' .SubItems.Add("Lab")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "04" Then '.SubItems.Add("X-ray")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "10" Then ' .SubItems.Add("รถพยาบาล")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "07" Then '     .SubItems.Add("EKG")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "08" Then '       .SubItems.Add("ทันตกรรม")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "09" Then '           .SubItems.Add("กายภาพ")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    End If


                    'End the loop
                End While
                'Reset the cursor




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        ElseIf ListView6.SelectedItems(0).SubItems(8).Text = "ผู้ป่วยนอก" Then




            อื่นๆ.Text = "0"




            อื่นๆ.Text = "0"
            เยี่ยมไข้.Text = "0"
            วิสัญญี.Text = "0"
            TextBox35.Text = "0"
            ผ่าตัด.Text = "0"

            รวม.Text = CDbl(อื่นๆ.Text) + CDbl(ผ่าตัด.Text) + CDbl(เยี่ยมไข้.Text) + CDbl(วิสัญญี.Text) + CDbl(TextBox35.Text)

            รวม.Text = FormatNumber(CDbl(รวม.Text), TriState.True)


            Label28.Text = "จำนวนวันที่พักรักษา  " + ListView6.SelectedItems(0).SubItems(8).Text + "  วัน"


            id_hn = ListView6.SelectedItems(0).SubItems(2).Text
            id_an = ListView6.SelectedItems(0).SubItems(3).Text
            Dim selectCMD As OdbcCommand
            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If
            total_df = 0
            total_total = 0
            selectCMD = New OdbcCommand("SELECT OBDDOCTYP,OBDPRDNO,OBDHN,OBDVN,OBDTOTAMT,OBDRCPCOD,OBDCHRCOD FROM OBLDETV5PF where  OBDHN = '" & id_hn & "'  and OBDDOCDTE ='" & ListView6.SelectedItems(0).SubItems(0).Text & "' ")

            selectCMD.Connection = MyODBCConnection

            Dim total_de As Decimal = 0
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader


                'start the Read loop
                While dr.Read

                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    If dr.GetString(0).Trim = "99" Then ' .SubItems.Add("ค่าบริการ")

                        total_df = total_df + dr.GetDecimal(4)
                        If dr.GetString(5).Trim = "43" And dr.GetString(6).Trim = "2" Then

                            ผ่าตัด.Text = CDbl(ผ่าตัด.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "36" And dr.GetString(6).Trim = "2" Then
                            เยี่ยมไข้.Text = CDbl(เยี่ยมไข้.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "45" And dr.GetString(6).Trim = "2" Then
                            วิสัญญี.Text = CDbl(วิสัญญี.Text) + dr.GetDecimal(4)

                        Else
                            sumtotal += dr.GetDecimal(4)
                            total_total = total_total + dr.GetDecimal(4)
                            roomtotal += +dr.GetDecimal(4)

                        End If

                    ElseIf dr.GetString(0).Trim = "14" Then '.SubItems.Add("เวชภัณฑ์ Ward")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "13" Then '.SubItems.Add("ตรวจสุขภาพ")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "12" Then '.SubItems.Add("ค่าหัตการ")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "01" Then '   .SubItems.Add("ยา")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "02" Then '    .SubItems.Add("ค่าแพทย์ DF")

                        total_df = total_df + dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "10" Then '    .SubItems.Add("ห้องผ่าตัด")
                        If dr.GetString(5).Trim = "43" And dr.GetString(6).Trim = "2" Then

                            ผ่าตัด.Text = CDbl(ผ่าตัด.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "36" And dr.GetString(6).Trim = "2" Then
                            เยี่ยมไข้.Text = CDbl(เยี่ยมไข้.Text) + dr.GetDecimal(4)

                        ElseIf dr.GetString(5).Trim = "45" And dr.GetString(6).Trim = "2" Then
                            วิสัญญี.Text = CDbl(วิสัญญี.Text) + dr.GetDecimal(4)

                        Else
                            sumtotal += dr.GetDecimal(4)

                            total_total = total_total + dr.GetDecimal(4)
                        End If

                    ElseIf dr.GetString(0).Trim = "11" Then   '  .SubItems.Add("ห้องคลอด")
                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "03" Then ' .SubItems.Add("Lab")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "04" Then '.SubItems.Add("X-ray")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "10" Then ' .SubItems.Add("รถพยาบาล")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "07" Then '     .SubItems.Add("EKG")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "08" Then '       .SubItems.Add("ทันตกรรม")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    ElseIf dr.GetString(0).Trim = "09" Then '           .SubItems.Add("กายภาพ")

                        total_total = total_total + dr.GetDecimal(4)
                        roomtotal += +dr.GetDecimal(4)
                    End If


                    'End the loop
                End While
                'Reset the cursor




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try





        End If



        อื่นๆ.Text = roomtotal
        MyODBCConnection.Close()
        TextBox35.Text = sumtotal


        อื่นๆ.Text = FormatNumber(CDbl(อื่นๆ.Text), TriState.True)
        เยี่ยมไข้.Text = FormatNumber(CDbl(เยี่ยมไข้.Text), TriState.True)
        วิสัญญี.Text = FormatNumber(CDbl(วิสัญญี.Text), TriState.True)
        TextBox35.Text = FormatNumber(CDbl(TextBox35.Text), TriState.True)
        ผ่าตัด.Text = FormatNumber(CDbl(ผ่าตัด.Text), TriState.True)

        รวม.Text = CDbl(อื่นๆ.Text) + CDbl(ผ่าตัด.Text) + CDbl(เยี่ยมไข้.Text) + CDbl(วิสัญญี.Text) + CDbl(TextBox35.Text)

        รวม.Text = FormatNumber(CDbl(รวม.Text), TriState.True)


    End Sub
    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        ListView7.Items.Add(TextBoxX1.Text)
        TextBoxX1.Text = ""
    End Sub
    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        For i As Integer = 0 To ListView7.Items.Count - 1
            Dim sms As New SENDSMS
            sms.SENDSMS(ListView7.Items(i).SubItems(0).Text, RichTextBox1.Text)
            'sendmessage(ListView7.Items(i).SubItems(0).Text, RichTextBox1.Text)
        Next
        ListView7.Items.Clear()
        RichTextBox1.Text = ""
    End Sub
    Private Sub sendmessage(ByRef tell_send As String, ByRef message As String)
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
            request.Method = "POST"
            'Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

            Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString(message) + "&msgtype=" + System.Uri.EscapeUriString("0")
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            responseFromServer = reader.ReadToEnd()
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()

            'MessageBox.Show(responseFromServer)
        Catch ex As Exception

        End Try

        'Dim reponse() As String
        '   reponse = responseFromServer.Split("_")
        'MsgBox(reponse(1))
        '' Dim returnData As String = responseFromServer
        '' Dim xml As New Xml.XmlDocument()
        '' xml.LoadXml(returnData)
        ' Dim xnList = xml.SelectNodes("/SMS")
        ' Dim count_node As Integer = xnList.Count
        ' If count_node > 0 Then
        ' For Each xn In xnList
        ''Dim xnSubList = Xml.SelectNodes("/SMS/QUEUE")
        '  Dim countSubNode As Integer = xnSubList.Count
        ' If countSubNode > 0 Then
        ' For Each xnSub In xnSubList
        '    'If xnSub("Status").InnerText.ToString() = "1" Then
        '    Dim msisdnReturn As String = xnSub("Msisdn").InnerText
        '     Dim useCredit As String = xnSub("UsedCredit").InnerText
        '  Dim creditRemain As String = xnSub("RemainCredit").InnerText
        'MsgBox("Send SMS to " + msisdnReturn + " Success.Use credit " + useCredit + " credit, Credit Remain " + creditRemain + " Credit")
        '  Else
        '  Dim sub_status_detail As String = xnSub("Detail").InnerText
        '  MsgBox("Error: " + sub_status_detail)
        ' End If
        ' Next
        ' Else
        'If xn("Status").InnerText = "0" Then
        'Dim status_detail As String = xn("Detail").InnerText
        'MsgBox("Error: " + status_detail)
        ' Else
        'MsgBox("Error: Can not read data(Not XML Format)")
        ' End If
        ' End If
        'Next
        'Else
        ' MsgBox("Error: Can not read data(Not XML Format)")
        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        showdatains()
    End Sub
    Private Sub TextBox21_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox21.KeyDown
        If e.KeyCode = Keys.Enter Then
            showdatains()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nextform As insurance_add = New insurance_add
        nextform.Show()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim nextform As insurance_edit = New insurance_edit(id_key)
        nextform.Show()
    End Sub
    Private Sub ListView8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView8.Click
        id_key = ListView8.SelectedItems(0).SubItems(0).Text
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListView8.SelectedItems.Count > 0 Then
            id_primary = ListView8.SelectedItems(0).SubItems(0).Text

            DeleteDatains()
        End If

    End Sub

    Private Sub DeleteDatains()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If id_primary <> "" Then

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM insurance where idinsurance = '" & id_primary & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql

                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If

                mySqlCommand.CommandText = "SELECT * FROM insurance;"
                ' mySqlCommand.CommandText = 
                mySqlCommand.Connection = mysql
                mySqlAdaptor.SelectCommand = mySqlCommand
                Try
                    mySqlReader = mySqlCommand.ExecuteReader

                    ListView8.Items.Clear()

                    While (mySqlReader.Read())

                        With ListView8.Items.Add(mySqlReader("idinsurance"))

                            .SubItems.Add(mySqlReader("name_insurance"))
                            .SubItems.Add(mySqlReader("nameof_insurance"))
                            .SubItems.Add(mySqlReader("tell_insurance"))
                            .SubItems.Add(mySqlReader("tell2_insurance"))

                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                mysql.Close()
            End If
        End If
    End Sub


    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM kpi_pramern where dep ='ac';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView5.Items.Clear()

            While (mySqlReader.Read())

                With ListView5.Items.Add(mySqlReader("idkpi_pramern"))

                    .SubItems.Add(mySqlReader("point_kpi"))
                    .SubItems.Add(mySqlReader("percent_1"))
                    .SubItems.Add(mySqlReader("date_day"))
                    .SubItems.Add(mySqlReader("timeofday"))
                    .SubItems.Add(mySqlReader("dep"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged

    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        searchDrcode()
    End Sub

    Public Sub searchDrcode()



        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT DMSDRCOD,DMSPRENAM,DMSNAME,DMSSURNAM FROM DRMASV5PF where DMSDRCOD like '%" & TextBox2.Text & "%' or DMSNAME like '%" & TextBox2.Text & "%' or DMSSURNAM like '" & drcode.Text & "'")

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView9.Items.Clear()

            If dr.HasRows Then
                While dr.Read
                    With ListView9.Items.Add(dr.GetString("0"))
                        .SubItems.Add(dr.GetString(1).Trim + " " + dr.GetString("2").Trim + " " + dr.GetString("3").Trim)

                    End With
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    'End the loop
                End While
                If pramern_price <> "" Then

                End If
            Else

                'Reset the cursor
            End If
            'start the Read loop



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()


    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchDrcode()

        End If
    End Sub

    Public Sub searchDiagDr()

        clear_data()

        max_df = 0
        min_df = 0
        max_total = 0
        min_total = 0




        service = 0
        medical_care = 0
        check_up = 0
        procedures = 0
        drug = 0
        df = 0
        ER = 0
        spawn = 0
        lab = 0
        x_ray = 0
        car_hospital = 0
        ekg = 0
        dental = 0
        physical = 0

        total_sum = 0
        total_service = 0




        txt_total.Text = "0"

        txt_total_service.Text = "0"



        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE,RMSNAME,RMSSURNAM,DMSNAME,DMSSURNAM, PDGADMDTE,PDGDCHDTE,OMDSURGRP,OMDSURTYP,OMDSURNAM FROM ORCMASV5PF join REGMASV5PF on  REGMASV5PF.RMSHNREF = ORCMASV5PF.OMSHN  join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO  left join ORCMPSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMPSV5PF.OMPDOCNO left join DRMASV5PF on ORCMPSV5PF.OMPDRCOD = DRMASV5PF.DMSDRCOD left join PATDCGV5PF on PATDCGV5PF.PDGAN =  ORCMASV5PF.OMSAN where OMPDRCOD = '" & ListView9.SelectedItems(0).SubItems(0).Text & "'  and OMPPSNTYP ='01'")

        'Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT OMSDOCDTE,OMSDOCNO,OMSHN,OMSAN,OMSNETAMT,OMSDSE,RMSNAME,RMSSURNAM FROM ORCMASV5PF join REGMASV5PF on  REGMASV5PF.RMSHNREF = ORCMASV5PF.OMSHN  join ORCMDSV5PF ON ORCMASV5PF.OMSDOCNO = ORCMDSV5PF.OMDDOCNO    where OMDSURGRP ='" & group_id & "' and OMDSURTYP = '" & type_id & "' and OMDSURCOD = '" & diag_id & "' ")


        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            ListView10.Items.Clear()

            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView10.Items.Add(dr.GetString(12).Trim)
                    .SubItems.Add(dr.GetString(13).Trim)
                    .SubItems.Add(dr.GetString(14).Trim)
                    .SubItems.Add(dr.GetDecimal(0).ToString)

                    .SubItems.Add(dr.GetString(1))

                    .SubItems.Add(dr.GetDecimal(2).ToString)
                    .SubItems.Add(dr.GetDecimal(3).ToString)
                    .SubItems.Add(dr.GetString(6).Trim + "   " + dr.GetString(7).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)

                    .SubItems.Add(dr.GetDecimal(4).ToString)
                    'Try
                    '    If dr.GetString(8) IsNot DBNull.Value And dr.GetString(9) IsNot DBNull.Value Then
                    '        .SubItems.Add(dr.GetString(8).ToString.Trim + "   " + dr.GetString(9).ToString.Trim)
                    '    Else

                    '    End If
                    'Catch ex As Exception

                    'End Try

                    Try
                        date1 = New System.DateTime(CStr(dr.GetDecimal(11)).Substring(0, 4), CStr(dr.GetDecimal(11)).Substring(4, 2), CStr(dr.GetDecimal(11)).Substring(6, 2), 0, 0, 0)
                        date2 = New System.DateTime(CStr(dr.GetDecimal(10)).Substring(0, 4), CStr(dr.GetDecimal(10)).Substring(4, 2), CStr(dr.GetDecimal(10)).Substring(6, 2), 0, 0, 0)
                        diff1 = date1.Subtract(date2)
                        valuedate = diff1.TotalDays.ToString
                        .SubItems.Add(valuedate)

                    Catch ex As Exception
                        .SubItems.Add("ผู้ป่วยนอก")
                    End Try

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Sub ListView9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView9.Click
        searchDiagDr()

    End Sub
End Class