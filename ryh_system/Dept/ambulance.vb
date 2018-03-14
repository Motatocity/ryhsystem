Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Public Class ambulance

    Dim mySql As MySqlConnection
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim db_name As String
    Dim pm_key As String
    Dim dr As String
    Dim rn As String
    Dim pn As String
    Dim na As String
    Dim car As String
    Dim result_price1 As String
    Public Shared result_price As String = " "
    Public Shared car_personal As String = " "
    Public Shared name_personal As String = " "
    Public Shared name_customer As String = " "
    Public Shared address_send As String = " "
    Public Shared diag As String = " "
    Public Shared tellephone As String = " "
    Public Shared age As String = " "
    Public Shared send_txt As String = " "
    Public Shared host_txt As String = " "
    Public Shared host_txt_0 As String = " "
    Public Shared stand_by As String = " "
    Public Shared car_valprice As String = " "
    Public Shared doc_valprice As String = " "
    Public Shared pn_valprice As String = " "
    Public Shared rn_valprice As String = " "
    Public Shared na_valprice As String = " "
    Public Shared pale_valprice As String = " "


    Public Shared hospital_rajyindee As String = "0"
    Public Shared hospital_rajyindee_0 As String = "0"

    Public Shared hospital_moor As String = "0"
    Public Shared hospital_moor_0 As String = "0"

    Public Shared hospital_etc As String = "0"
    Public Shared hospital_etc_0 As String = "0"

    Public Shared hospital_hadyai As String = "0"
    Public Shared hospital_hadyai_0 As String = "0"


    Public Shared hospital_songkla As String = "0"
    Public Shared hospital_songkla_0 As String = "0"
    Public Shared hospital_department As String = "0"
    Public Shared hospital_department_0 As String = "0"

    Public Shared Symptom1_1 As String = "0"
    Public Shared Symptom1_2 As String = "0"
    Public Shared Symptom1_3 As String = "0"
    Public Shared Symptom1_4 As String = "0"
    Public Shared Symptom1_5 As String = "0"
    Public Shared Symptom1_6 As String = "0"
    Public Shared Symptom1_6_text As String = " "

    Public Shared Symptom2_1 As String = "0"
    Public Shared Symptom2_2 As String = "0"
    Public Shared Symptom2_3 As String = "0"
    Public Shared Symptom2_4 As String = "0"
    Public Shared Symptom2_4_text As String = " "

    Public Shared Symptom3_1 As String = "0"
    Public Shared Symptom3_2 As String = "0"


    Public Shared Symptom4_1 As String = "0"
    Public Shared Symptom4_2 As String = "0"

    Public Shared doctor_stat As String = "0"
    Public Shared rn_stat As String = "0"
    Public Shared pn_stat As String = "0"
    Public Shared na_stat As String = "0"
    Public Shared pale_stat As String = "0"


    Public Shared doctor_name As String = " "
    Public Shared rn_name As String = " "
    Public Shared pn_name As String = " "
    Public Shared na_name As String = " "
    Public Shared pale_name As String = " "
    Public Shared price_etc As String = " "
    Public Shared price_car As String = ""

    Private Sub ambulance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mySql = New MySqlConnection
        'mysql_pass = "stomsite"
        ip_connect = "ryh1"
        'ip_connect = "119.59.99.151"

        'user_namedb = "tmcport_shipping"

        'db_name = "tmcport_shipping"

        '  ip_connect = "127.0.0.1"
        mysql_pass = "software"
        user_namedb = "june"
        db_name = "ambu"

        mySql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            mySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If

        mySqlCommand.CommandText = "Select Distinct prov from  ambu ;"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                province.Items.Add(mySqlReader("prov"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

            mySql.Close()
        End Try
        mySql.Close()

    End Sub
    Private Sub province_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles province.SelectedIndexChanged
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If
        default_fon()

        mySqlCommand.CommandText = "Select Distinct ampur from  ambu where prov ='" & province.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand
        amphur.Items.Clear()
        tambol.Items.Clear()

        amphur.Text = ""
        tambol.Text = ""
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                amphur.Items.Add(mySqlReader("ampur"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

            mySql.Close()
        End Try

        mySql.Close()





        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If


        mySqlCommand.CommandText = "Select COUNT(*) AS count_record from  ambu where prov ='" & province.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                If mySqlReader("count_record") = "1" Then
                    Show_price()

                End If
            End While

        Catch ex As Exception

        End Try

        mySql.Close()

    End Sub
    Private Sub amphur_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles amphur.SelectedValueChanged
        default_fon()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If

        mySqlCommand.CommandText = "Select * from  ambu where prov ='" & province.Text & "' and ampur = '" & amphur.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand
        tambol.Items.Clear()
        tambol.Text = ""

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                tambol.Items.Add(mySqlReader("tambul"))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

            mySql.Close()
        End Try

        mySql.Close()




        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If

        mySqlCommand.CommandText = "Select COUNT(*) AS count_record from  ambu where prov ='" & province.Text & "' and ampur = '" & amphur.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                If mySqlReader("count_record") = "1" Then

                    Show_price1()

                End If
            End While

        Catch ex As Exception

        End Try

        mySql.Close()
    End Sub
    Private Sub tambol_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tambol.SelectedValueChanged
        default_fon()
        result_price = "0"
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If

        mySqlCommand.CommandText = "Select * from  ambu where prov ='" & province.Text & "' and ampur = '" & amphur.Text & "' and tambul ='" & tambol.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()

                pm_key = mySqlReader("num")
                dr = mySqlReader("dr")
                rn = mySqlReader("rn")
                pn = mySqlReader("pn")
                na = mySqlReader("na")
                car = mySqlReader("car")
                result_price = mySqlReader("sale")
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

            mySql.Close()
        End Try

        mySql.Close()
    End Sub
    Public Sub Show_price()
        mySql.Close()
        result_price = "0"
        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "Select * from  ambu where prov ='" & province.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                pm_key = mySqlReader("num")
                dr = mySqlReader("dr")
                rn = mySqlReader("rn")
                pn = mySqlReader("pn")
                na = mySqlReader("na")
                car = mySqlReader("car")
                result_price = mySqlReader("sale")
            End While

        Catch ex As Exception

        End Try

        mySql.Close()
    End Sub
    Public Sub Show_price1()
        result_price = "0"
        mySql.Close()
        If mySql.State = ConnectionState.Closed Then
            mySql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "Select * from  ambu where prov ='" & province.Text & "'and ampur = '" & amphur.Text & "';"
        mySqlCommand.Connection = mySql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                pm_key = mySqlReader("num")
                dr = mySqlReader("dr")
                rn = mySqlReader("rn")
                pn = mySqlReader("pn")
                na = mySqlReader("na")
                car = mySqlReader("car")
                result_price = mySqlReader("sale")
            End While

        Catch ex As Exception

        End Try

        mySql.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_personal_price.Text = "0"
        txt_pale_price.Text = "0"
        txt_rn_price.Text = "0"
        txt_pn_price.Text = "0"
        txt_na_price.Text = "0"
        txt_doctor_price.Text = "0"
        price.Text = "0"

        If ComboBox1.Text = "ในประเทศ" Then
            txt_other.Text = CInt(txt_stand_hr.Text) * 1000
        ElseIf ComboBox1.Text = "นอกประเทศ" Then
            txt_other.Text = CInt(txt_stand_hr.Text) * 2000
        End If

        If car_man.Checked = True Then
            price.Text = CInt(price.Text) + CInt(car)
            car_valprice = CInt(car)
            txt_personal_price.Text = car
        End If

        If rn_price.Checked = True Then
            price.Text = CInt(price.Text) + CInt(rn)
            rn_valprice = CInt(rn)
            txt_rn_price.Text = rn
        End If
        If pn_price.Checked = True Then
            price.Text = CInt(price.Text) + CInt(pn)
            pn_valprice = CInt(pn)
            txt_pn_price.Text = pn
        End If

        If na_price.Checked = True Then
            price.Text = CInt(price.Text) + CInt(na)
            na_valprice = CInt(na)
            txt_na_price.Text = na
        End If
        If doctor_price.Checked = True Then
            result_price = CInt(result_price) + CInt(dr)
            price.Text = CInt(price.Text) + CInt(dr)
            doc_valprice = CInt(dr)
            txt_doctor_price.Text = dr
        End If

        If pale_price.Checked = True Then
            price.Text = CInt(price.Text) + CInt(na)
            pale_valprice = CInt(na)
            txt_pale_price.Text = na
        End If
        price.Text = result_price
    End Sub
    Public Sub default_fon()
        price.Text = ""
        car_man.Checked = False
        rn_price.Checked = False
        pn_price.Checked = False
        na_price.Checked = False
        doctor_price.Checked = False
        pale_price.Checked = False
        txt_personal_price.Text = "0"
        txt_doctor_price.Text = "0"
        txt_rn_price.Text = "0"
        txt_pn_price.Text = "0"
        txt_na_price.Text = "0"
        txt_pale_price.Text = "0"

    End Sub
    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        Dim string_count As Integer = 0
        Dim string_redcell As String = " "
        Dim id_hn As String

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim amp As String
        Dim prv As String
        Dim tmp As String
        Dim zipcode As String

        If e.KeyCode = "13" Then


            id_hn = txt_search.Text


            Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")  'Open the connection
            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ' Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGMASV5PF WHERE RMSHNNO='7708' and RMSHNYR = '56'")
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGDETV5PF WHERE RDTHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    txt_address.Text = dr.GetString(2).Trim
                    amp = dr.GetString(4)
                    prv = dr.GetString(3)
                    tmp = dr.GetString(5)
                    zipcode = dr.GetString(6)
                    'End the loop
                End While
                'Reset the cursor

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            MyODBCConnection.Close()

            'ดึงข้อมูล ชื่อ คนป่วย table REGMASV5PF
            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If
            selectCMD = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & id_hn & "'")
            selectCMD.Connection = MyODBCConnection
            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    txt_name.Text = dr.GetString(0).Trim + "  " + dr.GetString(1).Trim
                    'End the loop
                End While
                'Reset the curso
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            'จบข้อมูลชื่อคนป่วย

            MyODBCConnection.Close()

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            selectCMD = New OdbcCommand("SELECT TPVPRVNAM,TMPAMPNAM,TBNTBNNAM FROM TABPRVV5PF,TABAMPV5PF,TABTBNV5PF WHERE TABPRVV5PF.TPVPRVCOD = TABAMPV5PF.TMPPRVCOD AND TABAMPV5PF.TMPAMPCOD = TABTBNV5PF.TBNAMPCOD AND TABAMPV5PF.TMPPRVCOD = TABTBNV5PF.TBNPRVCOD AND (TABAMPV5PF.TMPPRVCOD = '" & prv & "') AND (TABTBNV5PF.TBNTBNCOD = '" & tmp & "') AND (TABAMPV5PF.TMPAMPCOD = '" & amp & "')")

            selectCMD.Connection = MyODBCConnection




            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    If dr.GetString(2) IsNot DBNull.Value Then
                        txt_address.Text = txt_address.Text + " ตำบล " + dr.GetString(2).Trim

                    End If
                    If dr.GetString(1) IsNot DBNull.Value Then

                        txt_address.Text = txt_address.Text + " อำเภอ " + dr.GetString(1).Trim

                    End If
                    If dr.GetString(0) IsNot DBNull.Value Then
                        txt_address.Text = txt_address.Text + " จังหวัด " + dr.GetString(0).Trim

                    End If

                    txt_address.Text = txt_address.Text + " " + zipcode
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If




    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        stand_by = txt_other.Text


        car_valprice = txt_personal_price.Text
        pn_valprice = txt_pn_price.Text
        rn_valprice = txt_rn_price.Text
        na_valprice = txt_na_price.Text
        pale_valprice = txt_pale_price.Text
        doc_valprice = txt_doctor_price.Text



        car_personal = txt_personal.Text
        price_car = price.Text
        age = txt_age.Text
        price_etc = txt_etc.Text
        name_personal = txt_name.Text


        diag = txt_diag.Text




        If ch_host_etc.Checked = True Then
            hospital_department = "1"
            host_txt = ch_host_etc_txt.Text
        Else
            hospital_department = "0"
        End If

        If ch_host_etc_0.Checked = True Then
            hospital_department_0 = "1"
            host_txt_0 = ch_host_etc_txt_0.Text
        Else
            hospital_department_0 = "0"
        End If



        If ch_host_raj.Checked = True Then
            hospital_rajyindee = "1"
        Else
            hospital_rajyindee = "0"
        End If


        If ch_host_raj_0.Checked = True Then
            hospital_rajyindee_0 = "1"
        Else
            hospital_rajyindee_0 = "0"
        End If




        If ch_host_moor.Checked = True Then
            hospital_moor = "1"
        Else
            hospital_moor = "0"
        End If

        If ch_host_moor_0.Checked = True Then
            hospital_moor_0 = "1"
        Else
            hospital_moor_0 = "0"
        End If



        If ch_host_etc.Checked = True Then
            hospital_etc = "1"
        Else
            hospital_etc = "0"
        End If

        If ch_host_etc_0.Checked = True Then
            hospital_etc_0 = "1"
        Else
            hospital_etc_0 = "0"
        End If


        If ch_host_hadyai.Checked = True Then
            hospital_hadyai = "1"
        Else
            hospital_hadyai = "0"
        End If




        If ch_host_hadyai_0.Checked = True Then
            hospital_hadyai_0 = "1"
        Else
            hospital_hadyai_0 = "0"
        End If

        If ch_host_songkla.Checked = True Then
            hospital_songkla = "1"
        Else
            hospital_songkla = "0"
        End If

        If ch_host_songkla_0.Checked = True Then
            hospital_songkla_0 = "1"
        Else
            hospital_songkla_0 = "0"
        End If



        If sym1_1.Checked = True Then
            Symptom1_1 = "1"
        Else
            Symptom1_1 = "0"
        End If


        If sym1_2.Checked = True Then
            Symptom1_2 = "1"
        Else
            Symptom1_2 = "0"
        End If


        If sym1_3.Checked = True Then
            Symptom1_3 = "1"
        Else
            Symptom1_3 = "0"
        End If


        If sym1_4.Checked = True Then
            Symptom1_4 = "1"
        Else
            Symptom1_4 = "0"
        End If


        If sym1_5.Checked = True Then
            Symptom1_5 = "1"
        Else
            Symptom1_5 = "0"
        End If


        If sym1_6.Checked = True Then
            Symptom1_6 = "1"
            Symptom1_6_text = sym1_6_text.Text
        Else
            Symptom1_6 = "0"
        End If


        If sym2_1.Checked = True Then
            Symptom2_1 = "1"
        Else
            Symptom2_1 = "0"
        End If

        If sym2_2.Checked = True Then
            Symptom2_2 = "1"
        Else
            Symptom2_2 = "0"
        End If

        If sym2_3.Checked = True Then
            Symptom2_3 = "1"
        Else
            Symptom2_3 = "0"
        End If


        If sym2_4.Checked = True Then
            Symptom2_4 = "1"
            Symptom2_4_text = sym2_4_text.Text
        Else
            Symptom2_4 = "0"
        End If

        If sym3_1.Checked = True Then
            Symptom3_1 = "1"
        Else
            Symptom3_1 = "0"
        End If


        If sym3_2.Checked = True Then
            Symptom3_2 = "1"
        Else
            Symptom3_2 = "0"
        End If



        If sym4_1.Checked = True Then
            Symptom4_1 = "1"
        Else
            Symptom4_1 = "0"
        End If


        If doctor_price.Checked = True Then
            doctor_stat = "1"
            doctor_name = txt_doctor.Text
        Else
            doctor_stat = "0"
        End If

        If rn_price.Checked = True Then
            rn_stat = "1"
            rn_name = txt_rn.Text
        Else
            rn_stat = "0"
        End If

        If rn_price.Checked = True Then
            rn_stat = "1"
            rn_name = txt_rn.Text
        Else
            rn_stat = "0"
        End If

        If pn_price.Checked = True Then
            pn_stat = "1"
            pn_name = txt_pn.Text
        Else
            pn_stat = "0"
        End If


        If na_price.Checked = True Then
            na_stat = "1"
            na_name = txt_na.Text
        Else
            na_stat = "0"
        End If

        If pale_price.Checked = True Then
            pale_stat = "1"
            pale_name = txt_pale.Text
        Else
            pale_stat = "0"
        End If




        price_etc = txt_etc.Text



        Dim nextform As frm_ambulance_rpt = New frm_ambulance_rpt
        nextform.Show()

 

    End Sub
    Private Sub txt_doctor_price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_doctor_price.KeyDown
        If e.KeyCode = Keys.Enter Then
            car_valprice = txt_personal_price.Text
            pn_valprice = txt_pn_price.Text
            rn_valprice = txt_rn_price.Text
            na_valprice = txt_na_price.Text
            pale_valprice = txt_pale_price.Text
            doc_valprice = txt_doctor_price.Text
            price.Text = (CInt(txt_personal_price.Text) + CInt(txt_pn_price.Text) + CInt(txt_rn_price.Text) + CInt(txt_na_price.Text) + CInt(txt_pale_price.Text) + CInt(txt_doctor_price.Text)) * 2
        End If
    End Sub
    Private Sub txt_na_price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_na_price.KeyDown
        If e.KeyCode = Keys.Enter Then
            car_valprice = txt_personal_price.Text
            pn_valprice = txt_pn_price.Text
            rn_valprice = txt_rn_price.Text
            na_valprice = txt_na_price.Text
            pale_valprice = txt_pale_price.Text
            doc_valprice = txt_doctor_price.Text

            price.Text = (CInt(txt_personal_price.Text) + CInt(txt_pn_price.Text) + CInt(txt_rn_price.Text) + CInt(txt_na_price.Text) + CInt(txt_pale_price.Text) + CInt(txt_doctor_price.Text)) * 2
        End If
    End Sub
    Private Sub txt_pale_price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pale_price.KeyDown
        If e.KeyCode = Keys.Enter Then
            car_valprice = txt_personal_price.Text
            pn_valprice = txt_pn_price.Text
            rn_valprice = txt_rn_price.Text
            na_valprice = txt_na_price.Text
            pale_valprice = txt_pale_price.Text
            doc_valprice = txt_doctor_price.Text
            price.Text = (CInt(txt_personal_price.Text) + CInt(txt_pn_price.Text) + CInt(txt_rn_price.Text) + CInt(txt_na_price.Text) + CInt(txt_pale_price.Text) + CInt(txt_doctor_price.Text)) * 2
        End If
    End Sub
    Private Sub txt_personal_price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_personal_price.KeyDown
        If e.KeyCode = Keys.Enter Then
            car_valprice = txt_personal_price.Text
            pn_valprice = txt_pn_price.Text
            rn_valprice = txt_rn_price.Text
            na_valprice = txt_na_price.Text
            pale_valprice = txt_pale_price.Text
            doc_valprice = txt_doctor_price.Text
            price.Text = (CInt(txt_personal_price.Text) + CInt(txt_pn_price.Text) + CInt(txt_rn_price.Text) + CInt(txt_na_price.Text) + CInt(txt_pale_price.Text) + CInt(txt_doctor_price.Text)) * 2
        End If
    End Sub
    Private Sub txt_pn_price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pn_price.KeyDown
        If e.KeyCode = Keys.Enter Then
            car_valprice = txt_personal_price.Text
            pn_valprice = txt_pn_price.Text
            rn_valprice = txt_rn_price.Text
            na_valprice = txt_na_price.Text
            pale_valprice = txt_pale_price.Text
            doc_valprice = txt_doctor_price.Text

            price.Text = (CInt(txt_personal_price.Text) + CInt(txt_pn_price.Text) + CInt(txt_rn_price.Text) + CInt(txt_na_price.Text) + CInt(txt_pale_price.Text) + CInt(txt_doctor_price.Text)) * 2
        End If
    End Sub
    Private Sub txt_rn_price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_rn_price.KeyDown
        If e.KeyCode = Keys.Enter Then
            car_valprice = txt_personal_price.Text
            pn_valprice = txt_pn_price.Text
            rn_valprice = txt_rn_price.Text
            na_valprice = txt_na_price.Text
            pale_valprice = txt_pale_price.Text
            doc_valprice = txt_doctor_price.Text

            price.Text = (CInt(txt_personal_price.Text) + CInt(txt_pn_price.Text) + CInt(txt_rn_price.Text) + CInt(txt_na_price.Text) + CInt(txt_pale_price.Text) + CInt(txt_doctor_price.Text)) * 2
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged

    End Sub
End Class