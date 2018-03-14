Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Public Class package5
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim health As String
    Dim mysql As MySqlConnection
    Dim mysql1 As MySqlConnection

    Dim mysql_ryh As MySqlConnection
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idhealthycare As String)
        InitializeComponent()
        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        health = idhealthycare

    End Sub
    Private Sub package5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader







        mysql_ryh = New MySqlConnection
        mysql_ryh.ConnectionString = "server=ryh1;user id=june;password=software;database=rajyindee_db;Character Set=utf8;"
        Try
            mysql_ryh.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
        If mysql_ryh.State = ConnectionState.Closed Then
            mysql_ryh.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM name_doctor;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql_ryh
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            listview1.Items.Clear()
            While (mySqlReader.Read())
                With listview1.Items.Add(mySqlReader("license"))
                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("name_eng"))


                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql_ryh.Close()

        'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"
        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh where idhealthycare = '" & health & "'"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())
                'same all page
                txtsearch.Text = mySqlReader("p_id")
                txt_name.Text = mySqlReader("p_name")
                txt_sex.Text = mySqlReader("p_sex")
                txt_age.Text = mySqlReader("p_age")
                txt_tell.Text = mySqlReader("p_tell")
                txt_address.Text = mySqlReader("p_add")
                txt_aid.Text = mySqlReader("p_aid")
                txt_date.Text = mySqlReader("p_date")
                'tap1 package6
                tab1_txt_height.Text = mySqlReader("p_height")
                tab1_tab_weight.Text = mySqlReader("p_weight")
                tab1_txt_bmi.Text = mySqlReader("p_bmi")
                tab1_txt_pulserate.Text = mySqlReader("p_pulse")
                tab1_txt_bloodp.Text = mySqlReader("p_blood_pre")
                tab1_txt_eyer.Text = mySqlReader("p_eyeright")
                tab1_txt_eyel.Text = mySqlReader("p_eyeleft")
                'tab2 package6
                tab2_txt_groupblood.Text = mySqlReader("blo_gro")
                tab2_txt_rh.Text = mySqlReader("blo_rhe")
                tab2_txt_plate.Text = mySqlReader("blo_pla")
                tab2_txt_hb.Text = mySqlReader("blo_cbc_hb")
                tab2_txt_hct.Text = mySqlReader("blo_cbc_hct")
                tab2_txt_wbc.Text = mySqlReader("blo_cbc_wbc")
                tab2_txt_neutrophils.Text = mySqlReader("blo_cbc_n")
                tab2_txt_eosinophils.Text = mySqlReader("blo_cbc_e")
                tab2_txt_bashophils.Text = mySqlReader("blo_cbc_b")
                tab2_txt_lymphocytes.Text = mySqlReader("blo_cbc_l")
                tab2_txt_monocytes.Text = mySqlReader("blo_cbc_m")
                tab2_txt_atypical.Text = mySqlReader("blo_cbc_a")
                tab2_txt_redcell.Text = mySqlReader("blo_redcell")
                'tab3 package6
                tab3_txt_color.Text = mySqlReader("uri_col")
                tab3_txt_appearance.Text = mySqlReader("uri_app")
                tab3_txt_albumin.Text = mySqlReader("uri_alb")
                tab3_txt_glucose.Text = mySqlReader("uri_glu")
                tab3_txt_spgr.Text = mySqlReader("uri_spg")
                tab3_txt_blood.Text = mySqlReader("uri_blo")
                tab3_txt_ph.Text = mySqlReader("uri_ph")
                tab3_txt_rbc.Text = mySqlReader("uri_rbe")
                tab3_txt_wbc.Text = mySqlReader("uri_wbc")
                tab3_txt_epi.Text = mySqlReader("uri_epi")
                tab3_txt_other.Text = mySqlReader("uri_other")
                'tab4 package6
                tab4_result_phy.Text = mySqlReader("result_phy")
                tab4_result_x_ray.Text = mySqlReader("xray")
                tab4_result_us.Text = mySqlReader("result_us")
                tab4_result_ekg.Text = mySqlReader("phy_ekg")
                tab4_txt_fbs.Text = mySqlReader("che_fbs")
                'tab5 packge6
                tab5_txt_bun.Text = mySqlReader("che_bun")
                tab5_txt_creatinine.Text = mySqlReader("che_cre")
                tab5_txt_uricacid.Text = mySqlReader("che_uri")
                tab5_txt_cholesterol.Text = mySqlReader("che_cho")
                tab5_txt_trigyceride.Text = mySqlReader("che_tri")
                tab5_txt_hdl.Text = mySqlReader("che_hdl")
                'tab6 package6
                tab6_txt_ldl.Text = mySqlReader("che_ldl")
                tab6_txt_sgot.Text = mySqlReader("che_sgo")
                tab6_txt_sgpt.Text = mySqlReader("che_sgp")
                tab6_txt_alkaline.Text = mySqlReader("che_alk")
                tab6_txt_afp.Text = mySqlReader("che_afp")
                txt_dental.Text = mySqlReader("txt_dental")

                If mySqlReader("che_pap") Is DBNull.Value Then

                Else

                    tab6_txt_pap.Text = mySqlReader("che_pap")
                End If




                tab1_result_eye.Text = mySqlReader("tab1_result_eye")
                tab2_result_redmorphology.Text = mySqlReader("tab2_result_redmorphology")
                tab2_result_platecount.Text = mySqlReader("tab2_result_platecount")
                tab3_txt_comment.Text = mySqlReader("tab3_txt_comment")
                tab4_result_phy.Text = mySqlReader("tab4_result_phy")
                tab4_result_x_ray.Text = mySqlReader("tab4_result_x_ray")
                tab4_result_us.Text = mySqlReader("tab4_result_us")
                tab4_result_ekg.Text = mySqlReader("tab4_result_ekg")
                tab4_result_fbs.Text = mySqlReader("tab4_result_fbs")
                tab5_result_bun.Text = mySqlReader("tab5_result_bun")
                tab5_result_creatinine.Text = mySqlReader("tab5_result_creatinine")
                tab5_result_uricacid.Text = mySqlReader("tab5_result_uric_acid")
                tab5_result_cholesterol.Text = mySqlReader("tab5_result_cholesterol")
                tab5_result_trigyceride.Text = mySqlReader("tab5_result_trigyceride")
                tab5_result_hdl.Text = mySqlReader("tab5_result_hdl")
                tab6_result_ldl.Text = mySqlReader("tab6_result_ldl")
                tab6_result_sgot.Text = mySqlReader("tab6_result_sgot")
                tab6_result_spgt.Text = mySqlReader("tab_result_spgt")
                tab6_result_alkaline.Text = mySqlReader("tab6_result_alkaline")
                tab6_result_afp.Text = mySqlReader("tab6_result_afp")
                tab6_result_psp.Text = mySqlReader("tab6_result_psp")
                If mySqlReader("doctor_name") Is DBNull.Value Then
                    txt_doctor_name.Text = ""
                Else

                    txt_doctor_name.Text = mySqlReader("doctor_name")
                End If
                RichTextBox2.Text = mySqlReader("result_all")


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As chack_package = New chack_package(mysqlpass, ipconnect, usernamedb, dbname)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txt_search_doctor.Text <> "" Then
            search_data_name()

        End If
    End Sub


    Private Sub search_data_name()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mysql_ryh.State = ConnectionState.Closed Then
            mysql_ryh.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM name_doctor where name_thai like '%" & txt_search_doctor.Text & "%' or name_eng like '%" & txt_search_doctor.Text & "%';"
        ' mySqlCommand.CommandText = 
        MySqlCommand.Connection = mysql_ryh
        mySqlAdaptor.SelectCommand = MySqlCommand
        Try
            mySqlReader = MySqlCommand.ExecuteReader

            listview1.Items.Clear()

            While (mySqlReader.Read())

                With listview1.Items.Add(mySqlReader("license"))
                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("name_eng"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql_ryh.Close()

    End Sub

    Private Sub listview1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listview1.Click

        txt_doctor_name.Text = listview1.SelectedItems(0).SubItems(1).Text

    End Sub

    Private Sub txt_search_doctor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search_doctor.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_data_name()
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        mysql.Close()
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim commandText2 As String
        commandText2 = "UPDATE healthycare_ryh SET p_id = '" & txtsearch.Text & "' , p_name = '" & txt_name.Text & "' , p_height = '" & tab1_txt_height.Text & "'  , p_weight = '" & tab1_tab_weight.Text & "', p_sex = '" & txt_sex.Text & "' , p_age = '" & txt_age.Text & "' , p_tell = '" & txt_tell.Text & "', p_add = '" & txt_address.Text & "', p_aid = '" & txt_aid.Text & "' , p_date = '" & txt_date.Text & "', p_pulse = '" & tab1_txt_pulserate.Text & "', p_bmi = '" & tab1_txt_bmi.Text & "',p_blood_pre = '" & tab1_txt_bloodp.Text & "', p_eyeright = '" & tab1_txt_eyer.Text & "', p_eyeleft = '" & tab1_txt_eyel.Text & "',che_fbs = '" & tab4_txt_fbs.Text & "', che_bun ='" & tab5_txt_bun.Text & "',che_cre = '" & tab5_txt_creatinine.Text & "' ,che_cho = '" & tab5_txt_cholesterol.Text & "',che_tri = '" & tab5_txt_trigyceride.Text & "',che_sgo ='" & tab6_txt_sgot.Text & "' ,  che_sgp = '" & tab6_txt_sgpt.Text & "', che_alk = '" & tab6_txt_alkaline.Text & "' , che_uri = '" & tab5_txt_uricacid.Text & "',che_hdl = '" & tab5_txt_hdl.Text & "', che_ldl = '" & tab6_txt_ldl.Text & " ' ,che_afp = '" & tab6_txt_afp.Text & "',blo_gro = '" & tab2_txt_groupblood.Text & "', blo_rhe = '" & tab2_txt_rh.Text & "',blo_pla = '" & tab2_txt_plate.Text & "', tab6_result_psp = '" & tab6_result_psp.Text & "' , blo_redcell = '" & tab2_txt_redcell.Text & "' , blo_cbc_wbc = '" & tab2_txt_wbc.Text & "' ,blo_cbc_hct ='" & tab2_txt_hct.Text & "',blo_cbc_hb = '" & tab2_txt_hb.Text & "',blo_cbc_l ='" & tab2_txt_lymphocytes.Text & "',blo_cbc_m = '" & tab2_txt_monocytes.Text & "',blo_cbc_e = '" & tab2_txt_eosinophils.Text & "',blo_cbc_b = '" & tab2_txt_bashophils.Text & "',blo_cbc_n = '" & tab2_txt_neutrophils.Text & "',blo_cbc_a = '" & tab2_txt_atypical.Text & "',uri_col = '" & tab3_txt_color.Text & "',uri_spg='" & tab3_txt_spgr.Text & "', uri_alb = '" & tab3_txt_albumin.Text & "', uri_blo = '" & tab3_txt_blood.Text & "',uri_epi = '" & tab3_txt_epi.Text & "', uri_app = '" & tab3_txt_appearance.Text & "', uri_ph = '" & tab3_txt_ph.Text & "', uri_glu = '" & tab3_txt_glucose.Text & "',uri_rbe='" & tab3_txt_rbc.Text & "',uri_wbc = '" & tab3_txt_wbc.Text & "', uri_other = '" & tab3_txt_other.Text & "',xray = '" & tab4_result_x_ray.Text & "' ,result_phy ='" & tab4_result_phy.Text & "',result_psp='" & tab6_result_psp.Text & "',result_check_eye ='" & tab1_result_eye.Text & "',result_all ='" & RichTextBox2.Text & "',doctor_name = '" & txt_doctor_name.Text & "',tab4_result_fbs ='" & tab4_result_fbs.Text & "',tab5_result_bun ='" & tab5_result_bun.Text & "',tab5_result_cholesterol ='" & tab5_result_cholesterol.Text & "',tab5_result_creatinine = '" & tab5_result_creatinine.Text & "',tab5_result_trigyceride='" & tab5_result_trigyceride.Text & "',tab5_result_uric_acid ='" & tab5_result_trigyceride.Text & "',tab5_result_hdl ='" & tab5_result_hdl.Text & "',tab6_result_ldl ='" & tab6_result_ldl.Text & "',tab6_result_alkaline='" & tab6_result_alkaline.Text & "' ,tab6_result_sgot='" & tab6_result_sgot.Text & "',tab6_result_afp='" & tab6_result_afp.Text & "',tab_result_spgt ='" & tab6_result_spgt.Text & "',tab6_result_psp='" & tab6_result_psp.Text & "',che_pap='" & ComboBox19.Text & "' WHERE idhealthycare = " & health & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()

    End Sub
End Class