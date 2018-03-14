
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Public Class package1
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim health As String
    Dim mysql As MySqlConnection
    Dim mysql1 As MySqlConnection
    Dim mysql_ryh As MySqlConnection
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idhealthycare As String)

        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        health = idhealthycare
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub package1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySql = New MySqlConnection
        MySql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            MySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"
        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh where idhealthycare = '" & health & "'"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = MySql
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
                'tap1 package1
                tab1_txt_height.Text = mySqlReader("p_height")
                tab1_tab_weight.Text = mySqlReader("p_weight")
                tab1_txt_bmi.Text = mySqlReader("p_bmi")
                tab1_txt_pulserate.Text = mySqlReader("p_pulse")
                tab1_txt_bloodp.Text = mySqlReader("p_blood_pre")
                'tab2 package1
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
                'tab3 package1
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
                'tab4 package1
                tab4_result_phy.Text = mySqlReader("result_phy")
                tab4_result_x_ray.Text = mySqlReader("xray")
                tab4_txt_fbs.Text = mySqlReader("che_fbs")
                'tab5 packge1
                tab5_txt_uricacid.Text = mySqlReader("che_uri")
                tab5_txt_cholesterol.Text = mySqlReader("che_cho")
                tab5_txt_trigyceride.Text = mySqlReader("che_tri")




                tab4_result_phy.Text = mySqlReader("tab4_result_phy")
                tab4_result_x_ray.Text = mySqlReader("tab4_result_x_ray")


                tab4_result_fbs.Text = mySqlReader("tab4_result_fbs")
                tab5_result_trigyceride.Text = mySqlReader("tab5_result_trigyceride")





                tab2_result_redmorphology.Text = mySqlReader("tab2_result_redmorphology")
                tab2_result_platecount.Text = mySqlReader("tab2_result_platecount")
                tab3_txt_comment.Text = mySqlReader("tab3_txt_comment")
                tab4_result_phy.Text = mySqlReader("tab4_result_phy")
                tab4_result_x_ray.Text = mySqlReader("tab4_result_x_ray")


                tab5_result_uricacid.Text = mySqlReader("tab5_result_uric_acid")
                tab5_result_cholesterol.Text = mySqlReader("tab5_result_cholesterol")
                tab5_result_trigyceride.Text = mySqlReader("tab5_result_trigyceride")



                If mySqlReader("doctor_name") Is DBNull.Value Then
                    txt_doctor_name.Text = ""
                Else

                    txt_doctor_name.Text = mySqlReader("doctor_name")
                End If
                RichTextBox2.Text = mySqlReader("result_all")



                'tab6 package1
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MySql.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As main = New main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        mysql.Close()
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim commandText2 As String
        commandText2 = "UPDATE healthycare_ryh SET p_id = '" & txtsearch.Text & "' , p_name = '" & txt_name.Text & "' , p_height = '" & tab1_txt_height.Text & "'  , p_weight = '" & tab1_tab_weight.Text & "', p_sex = '" & txt_sex.Text & "' , p_age = '" & txt_age.Text & "' , p_tell = '" & txt_tell.Text & "', p_add = '" & txt_address.Text & "', p_aid = '" & txt_aid.Text & "' , p_date = '" & txt_date.Text & "', p_pulse = '" & tab1_txt_pulserate.Text & "', p_bmi = '" & tab1_txt_bmi.Text & "',p_blood_pre = '" & tab1_txt_bloodp.Text & "', che_fbs = '" & tab4_txt_fbs.Text & "', che_cho = '" & tab5_txt_cholesterol.Text & "',che_tri = '" & tab5_txt_trigyceride.Text & "',   che_uri = '" & tab5_txt_uricacid.Text & "',blo_gro = '" & tab2_txt_groupblood.Text & "', blo_rhe = '" & tab2_txt_rh.Text & "',blo_pla = '" & tab2_txt_plate.Text & "' , blo_redcell = '" & tab2_txt_redcell.Text & "' , blo_cbc_wbc = '" & tab2_txt_wbc.Text & "' ,blo_cbc_hct ='" & tab2_txt_hct.Text & "',blo_cbc_hb = '" & tab2_txt_hb.Text & "',blo_cbc_l ='" & tab2_txt_lymphocytes.Text & "',blo_cbc_m = '" & tab2_txt_monocytes.Text & "',blo_cbc_e = '" & tab2_txt_eosinophils.Text & "',blo_cbc_b = '" & tab2_txt_bashophils.Text & "',blo_cbc_n = '" & tab2_txt_neutrophils.Text & "',blo_cbc_a = '" & tab2_txt_atypical.Text & "',uri_col = '" & tab3_txt_color.Text & "',uri_spg='" & tab3_txt_spgr.Text & "', uri_alb = '" & tab3_txt_albumin.Text & "', uri_blo = '" & tab3_txt_blood.Text & "',uri_epi = '" & tab3_txt_epi.Text & "', uri_app = '" & tab3_txt_appearance.Text & "', uri_ph = '" & tab3_txt_ph.Text & "', uri_glu = '" & tab3_txt_glucose.Text & "',uri_rbe='" & tab3_txt_rbc.Text & "',uri_wbc = '" & tab3_txt_wbc.Text & "', uri_other = '" & tab3_txt_other.Text & "',xray = '" & tab4_result_x_ray.Text & "' ,result_phy ='" & tab4_result_phy.Text & "',result_all ='" & RichTextBox2.Text & "',doctor_name = '" & txt_doctor_name.Text & "',tab4_result_fbs ='" & tab4_result_fbs.Text & "',tab5_result_cholesterol ='" & tab5_result_cholesterol.Text & "',tab5_result_trigyceride='" & tab5_result_trigyceride.Text & "',tab5_result_uric_acid ='" & tab5_result_trigyceride.Text & "', WHERE idhealthycare = " & health & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()

    End Sub


End Class