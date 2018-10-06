
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Public Class packageoil
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim health As String
    Dim mysql As MySqlConnection
    Dim mysql_ryh As MySqlConnection
    Dim check_sub As String = "0"
    Dim fit_check As String = "0"
    Public Shared address As String = ""
    Public Shared tellephone As String = ""
    Public Shared unders As String = ""
    Public Shared sex_fm As String = ""
    Public Shared result_pulserate As String = ""
    Public Shared eye_left As String
    Public Shared eye_right As String

    Public Shared spec As String = ""
    Public Shared fitair As String = ""
    Public Shared fitbreath As String = ""
    Public Shared fitcrance As String = ""
    Public Shared fitemergency As String = ""
    Public Shared fitfood As String = ""
    Public Shared datetime As String = ""
    Public Shared checkaddress As Boolean

    Public Shared cbc_result As String
    Public Shared urine_result As String

    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idhealthycare As String)
        InitializeComponent()
        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        health = idhealthycare
    End Sub
    Sub setYear()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub
    Private Sub packageoil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setYear()
        dateconfirm.Text = Date.Now.ToString("dd/MM/yyyy")
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
        mysql_ryh.ConnectionString = "server=192.0.0.200;user id=june;password=software;database=rajyindee_db;Character Set=utf8;"

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

        MySqlCommand.CommandText = "SELECT * FROM name_doctor;"
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


        'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"
        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh where idhealthycare = '" & health & "'"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())
                'same all page
                blood_pressure_result.Text = mySqlReader("blood_pressure_result")
                eye_result.Text = mySqlReader("eye_result")
                txtsearch.Text = mySqlReader("p_id")
                txt_name.Text = mySqlReader("p_name")
                txt_lastname.Text = mySqlReader("p_lastname")
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
                tab3_txt_vdrl.Text = mySqlReader("vdrl")
                'tab4_result_us.Text = mySqlReader("result_us")
                tab4_result_ekg.Text = mySqlReader("phy_ekg")
                tab4_txt_fbs.Text = mySqlReader("che_fbs")
                tab3_txt_hiv.Text = mySqlReader("hiv")
                'tab5 packge6
                tab5_txt_bun.Text = mySqlReader("che_bun")
                tab5_txt_creatinine.Text = mySqlReader("che_cre")
                tab5_txt_uricacid.Text = mySqlReader("che_uri")
                tab5_txt_cholesterol.Text = mySqlReader("che_cho")
                tab5_txt_trigyceride.Text = mySqlReader("che_tri")
                tab5_txt_hdl.Text = mySqlReader("che_hdl")

                tab6_txt_ldl.Text = mySqlReader("che_ldl")
                tab6_txt_sgot.Text = mySqlReader("che_sgo")
                tab6_txt_sgpt.Text = mySqlReader("che_sgp")
                tab6_txt_alkaline.Text = mySqlReader("che_alk")
                tab6_txt_afp.Text = mySqlReader("che_afp")

                'tab6 package6
                txt_hbsag.Text = mySqlReader("vir_sag")
                txt_hbsab.Text = mySqlReader("vir_sab")
                txt_hbcab.Text = mySqlReader("vir_cab")
                txt_anti_igg.Text = mySqlReader("vir_igg")
                txt_hav_igm.Text = mySqlReader("vir_igm")
                TextBox5.Text = mySqlReader("che_cea")
                TextBox6.Text = mySqlReader("che_mer")
                tab6_stool_wbc.Text = mySqlReader("sto_wbc")
                tab6_stool_rbc.Text = mySqlReader("sto_rbc")
                tab6_stool_parasites.Text = mySqlReader("sto_ova")
                tab6_stool_blood.Text = mySqlReader("sto_occ")


                Try
                    If mySqlReader("fit_spec") = "" And mySqlReader("fit_spec") = "0" Then
                        CheckBox2.Checked = False
                    ElseIf mySqlReader("fit_spec") = "1" Then
                        CheckBox2.Checked = True
                    End If
                Catch ex As Exception
                    CheckBox2.Checked = False
                End Try




                Try
                    If mySqlReader("fit_air") = "" And mySqlReader("fit_air") = "0" Then
                        CheckBox3.Checked = False
                    ElseIf mySqlReader("fit_air") = "1" Then
                        CheckBox3.Checked = True
                    End If
                Catch ex As Exception
                    CheckBox3.Checked = False
                End Try

                Try
                    If mySqlReader("fit_breath") = "" And mySqlReader("fit_breath") = "0" Then
                        CheckBox4.Checked = False
                    ElseIf mySqlReader("fit_breath") = "1" Then
                        CheckBox4.Checked = True
                    End If
                Catch ex As Exception
                    CheckBox4.Checked = False
                End Try

                Try
                    If mySqlReader("fit_crane") = "" And mySqlReader("fit_crane") = "0" Then
                        CheckBox5.Checked = False
                    ElseIf mySqlReader("fit_crane") = "1" Then
                        CheckBox5.Checked = True
                    End If
                Catch ex As Exception
                    CheckBox5.Checked = False
                End Try



                Try
                    If mySqlReader("fit_emergency") = "" And mySqlReader("fit_emergency") = "0" Then
                        CheckBox6.Checked = False
                    ElseIf mySqlReader("fit_emergency") = "1" Then
                        CheckBox6.Checked = True
                    End If
                Catch ex As Exception
                    CheckBox6.Checked = False
                End Try



                Try
                    If mySqlReader("fit_food") = "" And mySqlReader("fit_food") = "0" Then
                        CheckBox7.Checked = False
                    ElseIf mySqlReader("fit_food") = "1" Then
                        CheckBox7.Checked = True
                    End If
                Catch ex As Exception
                    CheckBox7.Checked = False
                End Try




                If mySqlReader("phy_eye") = "0" Then
                    r_eye1.Checked = True
                ElseIf mySqlReader("phy_eye") = "1" Then
                    r_eye2.Checked = True
                ElseIf mySqlReader("phy_eye") = "2" Then
                    r_eye3.Checked = True
                End If

                If mySqlReader("phy_nec") = "0" Then
                    neck1.Checked = True
                ElseIf mySqlReader("phy_nec") = "1" Then
                    neck2.Checked = True
                ElseIf mySqlReader("phy_nec") = "2" Then
                    neck3.Checked = True
                End If

                If mySqlReader("phy_hea") = "0" Then
                    heart1.Checked = True
                ElseIf mySqlReader("phy_hea") = "1" Then
                    heart2.Checked = True
                ElseIf mySqlReader("phy_hea") = "2" Then
                    heart3.Checked = True
                End If

                If mySqlReader("phy_vas") = "0" Then
                    vas1.Checked = True
                ElseIf mySqlReader("phy_vas") = "1" Then
                    vas2.Checked = True
                ElseIf mySqlReader("phy_vas") = "2" Then
                    vas3.Checked = True
                End If

                If mySqlReader("phy_lun_che") = "0" Then
                    chest1.Checked = True
                ElseIf mySqlReader("phy_lun_che") = "1" Then
                    chest2.Checked = True
                ElseIf mySqlReader("phy_lun_che") = "2" Then
                    chest3.Checked = True
                End If

                If mySqlReader("phy_abd") = "0" Then
                    ab1.Checked = True
                ElseIf mySqlReader("phy_abd") = "1" Then
                    ab2.Checked = True
                ElseIf mySqlReader("phy_abd") = "2" Then
                    ab3.Checked = True
                End If

                If mySqlReader("phy_lym") = "0" Then
                    lymp1.Checked = True
                ElseIf mySqlReader("phy_lym") = "1" Then
                    lymp2.Checked = True
                ElseIf mySqlReader("phy_lym") = "2" Then
                    lymp3.Checked = True
                End If

                If mySqlReader("phy_gus") = "0" Then
                    gu1.Checked = True
                ElseIf mySqlReader("phy_gus") = "1" Then
                    gu2.Checked = True
                ElseIf mySqlReader("phy_gus") = "2" Then
                    gu3.Checked = True
                End If

                If mySqlReader("phy_ext") = "0" Then
                    ex1.Checked = True
                ElseIf mySqlReader("phy_ext") = "1" Then
                    ex2.Checked = True
                ElseIf mySqlReader("phy_ext") = "2" Then
                    ex3.Checked = True
                End If

                If mySqlReader("phy_spi") = "0" Then
                    spine1.Checked = True
                ElseIf mySqlReader("phy_spi") = "1" Then
                    spine2.Checked = True
                ElseIf mySqlReader("phy_spi") = "2" Then
                    spine3.Checked = True
                End If

                If mySqlReader("phy_ski") = "0" Then
                    skin1.Checked = True
                ElseIf mySqlReader("phy_ski") = "1" Then
                    skin2.Checked = True
                ElseIf mySqlReader("phy_ski") = "2" Then
                    skin3.Checked = True
                End If

                If mySqlReader("phy_aud") = "0" Then
                    audio1.Checked = True
                ElseIf mySqlReader("phy_aud") = "1" Then
                    audio2.Checked = True
                ElseIf mySqlReader("phy_aud") = "2" Then
                    audio3.Checked = True
                End If

                If mySqlReader("phy_lun_tes") = "0" Then
                    lung1.Checked = True
                ElseIf mySqlReader("phy_lun_tes") = "1" Then
                    lung2.Checked = True
                ElseIf mySqlReader("phy_lun_tes") = "2" Then
                    lung3.Checked = True
                End If

                If mySqlReader("phy_ekg_oil") = "0" Then
                    ekg1.Checked = True
                ElseIf mySqlReader("phy_ekg_oil") = "1" Then
                    ekg2.Checked = True
                ElseIf mySqlReader("phy_ekg_oil") = "2" Then
                    ekg3.Checked = True
                End If


                If IsDBNull(mySqlReader("phy_ust")) Then
                    ust3.Checked = True
                Else
                    If mySqlReader("phy_ust") = "0" Then
                        ust1.Checked = True
                    ElseIf mySqlReader("phy_ust") = "1" Then
                        ust2.Checked = True
                    ElseIf mySqlReader("phy_ust") = "2" Then
                        ust3.Checked = True
                    End If

                End If



                If IsDBNull(mySqlReader("phy_est")) Then
                    est3.Checked = True
                Else
                    If mySqlReader("phy_est") = "0" Then
                        est1.Checked = True
                    ElseIf mySqlReader("phy_est") = "1" Then
                        est2.Checked = True
                    ElseIf mySqlReader("phy_est") = "2" Then
                        est3.Checked = True
                    End If

                End If


                If IsDBNull(mySqlReader("ex_date")) Then


                Else
                    txtCertExp.Text = mySqlReader("ex_date")
                End If


                If mySqlReader("glass") = "1" Then
                    eye_in.Checked = True
                ElseIf mySqlReader("glass") = "0" Then

                    eye_out.Checked = True
                ElseIf mySqlReader("glass") = "3" Then
                    eye_not.Checked = True
                End If

                ComboBox25.Text = mySqlReader("eye_1")
                RichTextBox5.Text = mySqlReader("result_eye")
                Blind_Color.Text = mySqlReader("blind")
                tab1_result_blindness.Text = mySqlReader("result_blind")
                ComboBox1.Text = mySqlReader("check_eye")
                tab1_result_eye.Text = mySqlReader("result_check_eye")
                ComboBox24.Text = mySqlReader("teeth")
                tab1_result_tooth.Text = mySqlReader("result_teeth")
                RichTextBox1.Text = mySqlReader("result_all")
                txt_doctor_name.Text = mySqlReader("doctor_name")
                txt_license.Text = mySqlReader("license")
                txt_other_fit.Text = mySqlReader("result_fit")
                txtcompany.Text = mySqlReader("p_company")


                tab3_txt_amphetamine.Text = mySqlReader("amphetamine")

                ComboBox26.Text = mySqlReader("amphetamine")
                tab2_result_txt.Text = mySqlReader("tab2_result")
                tab4_result_fbs.Text = mySqlReader("tab4_result_fbs")
                tab4_result_vdrl.Text = mySqlReader("tab4_result_vdrl")

                RichTextBox3.Text = mySqlReader("tab4_result_hiv")
                tab5_result_bun.Text = mySqlReader("tab5_result_bun")
                tab5_result_cholesterol.Text = mySqlReader("tab5_result_cholesterol")
                tab5_result_creatinine.Text = mySqlReader("tab5_result_creatinine")
                tab5_result_trigyceride.Text = mySqlReader("tab5_result_trigyceride")
                tab5_result_uricacid.Text = mySqlReader("tab5_result_uric_acid")
                tab5_result_hdl.Text = mySqlReader("tab5_result_hdl")
                tab6_result_ldl.Text = mySqlReader("tab6_result_ldl")
                tab6_result_alkaline.Text = mySqlReader("tab6_result_alkaline")
                tab6_result_sgot.Text = mySqlReader("tab6_result_sgot")
                tab6_result_afp.Text = mySqlReader("tab6_result_afp")
                tab6_result_spgt.Text = mySqlReader("tab_result_spgt")
                tab6_result_psp.Text = mySqlReader("tab6_result_psp")
                tab6_result_virus_b.Text = mySqlReader("tab6_result_virus_b")
                tab6_result_stool.Text = mySqlReader("tab6_result_stool")

                RichTextBox2.Text = mySqlReader("tab6_result_cea")
                RichTextBox4.Text = mySqlReader("tab6_result_mercury")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
    Private Sub txt_search_doctor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search_doctor.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_data_name()

        End If
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "1.ปกติ" Then
        ElseIf ComboBox6.Text = "2.การเต้นหัวใจผิดปกติ" Then
            tab4_result_ekg.Text = "การเต้นของหัวใจผิดปกติ แนะนำปรึกษาแพทย์,เข้าได้กับกล้ามเนื้อหัวใจขาดเลือด"
        ElseIf ComboBox6.Text = "3.หัวใจเต้นช้ากว่าปกติ" Then
            tab4_result_ekg.Text = "หัวใจเต้นช้ากว่าปกติ ควรสังเกตอาการผิดปกติ เช่น หน้ามืด แน่นหน้าอก แนะนำปรึกษาแพทย์"
        ElseIf ComboBox6.Text = "4.หัวใจเต้นเร็วกว่าปกติ" Then
            tab4_result_ekg.Text = "แนะนำปรึกษาแพทย์"
        ElseIf ComboBox6.Text = "5.หัวใจโตกว่าปกติ" Then
            tab4_result_ekg.Text = "แนะนำปรึกษาแพทย์"
        ElseIf ComboBox6.Text = "6.การนำไฟฟ้าหัวใจซึกขวาช้ากว่าปกติ" Then
            tab4_result_ekg.Text = "แนะนำปรึกษาแพทย์"
        End If
    End Sub
    Private Sub ComboBox25_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox25.SelectedIndexChanged
        If ComboBox25.Text = "1.ปกติ" Then
            RichTextBox5.Text = ""

        ElseIf ComboBox25.Text = "2.สายตามองเห็นชัดลดลง" Then
            If check_sub = "0" Then
                RichTextBox5.Text = "สายตามองชัดลดลง"
            ElseIf check_sub = "1" Then
                RichTextBox5.Text = "Visionn reduced signicantly visoin decrease."
            End If
        ElseIf ComboBox25.Text = "2.สายตาสั้น" Then
            If check_sub = "0" Then
                RichTextBox5.Text = "สายตาสั้น"
            ElseIf check_sub = "1" Then
                RichTextBox5.Text = "Short-sighted"
            End If
        End If
    End Sub
    Private Sub Blind_Color_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blind_Color.SelectedIndexChanged
        If Blind_Color.Text = "1.ปกติ" Then
            tab1_result_blindness.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf Blind_Color.Text = "2.มีภาวะตาบอดสี" Then
            If check_sub = "0" Then
                tab1_result_blindness.Text = "ควรระมัดระวังในการขับขี่พาหนะ และการทำงานที่เกี่ยวกับสัญญาณไฟสี"
            ElseIf check_sub = "1" Then
                tab1_result_blindness.Text = "Be careful driving and working with the light sign."
            End If


        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "1.ปกติ" Then
            tab1_result_eye.Text = ""
        ElseIf ComboBox1.Text = "2.ต้อลม" Then
            If check_sub = "0" Then
                tab1_result_eye.Text = "ต้อลม ควรสวมแว่นกันแดดกันลม สม่ำเสมอ หากเป็นมากขึ้น แนะนำปรึกษาจักษุแพทย์"
            ElseIf check_sub = "1" Then
                tab1_result_eye.Text = "Pinguecula Always wear sunglasses, if's worse consult Ophthalmologist."
            End If
        ElseIf ComboBox1.Text = "3.ต้อเนื้อ" Then
            If check_sub = "0" Then
                tab1_result_eye.Text = "ควรสวมแว่นกันแดดกันลม สม่ำเสมอ หากเป็นมากขึ้น แนะนำปรึกษาจักษุแพทย์"
            ElseIf check_sub = "1" Then
                tab1_result_eye.Text = "Pterygium Always wear sunglasses, if's worse consult Ophthalmologist."
            End If
        End If
    End Sub
    Private Sub ComboBox24_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox24.SelectedIndexChanged
        If ComboBox24.Text = "1.ปกติ" Then
            tab1_result_tooth.Text = ""
        ElseIf ComboBox24.Text = "2.ฟันมีหินปูน" Then
            If check_sub = "0" Then
                tab1_result_tooth.Text = "ฟันมีหินปูน "
            ElseIf check_sub = "1" Then
                tab1_result_tooth.Text = "Dental plaque Advice see Dentist"
            End If

        ElseIf ComboBox24.Text = "3.ฟันผุ" Then
            If check_sub = "0" Then
                tab1_result_tooth.Text = "ฟันผุ"
            ElseIf check_sub = "1" Then
                tab1_result_tooth.Text = "Dental caries Advice see Dentist"
            End If
        End If
    End Sub
    Public Sub update_data()
        datetime = dateconfirm.Text
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        update_data()

        Dim commandText2 As String
        Dim glass As String
        If eye_in.Checked = True Then
            glass = "1"
        ElseIf eye_out.Checked = True Then
            glass = "0"
        ElseIf eye_not.Checked = True Then
            glass = "3"
        End If

        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        checkaddress = CheckBox8.Checked
        address = txt_address.Text
        Dim phy_eye As String = " "
        If r_eye1.Checked = True Then
            phy_eye = "0"
        ElseIf r_eye2.Checked = True Then
            phy_eye = "1"
        ElseIf r_eye3.Checked = True Then
            phy_eye = "2"
        End If

        If RadioButton1.Checked = True Then
            fit_check = "1"
        ElseIf RadioButton2.Checked = True Then
            fit_check = "2"
        ElseIf RadioButton3.Checked = True Then
            fit_check = "3"
        End If

        Dim phy_nec As String = " "
        If neck1.Checked = True Then
            phy_nec = "0"
        ElseIf neck2.Checked = True Then
            phy_nec = "1"
        ElseIf neck3.Checked = True Then
            phy_nec = "2"
        End If

        Dim phy_hea As String = " "
        If heart1.Checked = True Then
            phy_hea = "0"
        ElseIf heart2.Checked = True Then
            phy_hea = "1"
        ElseIf heart3.Checked = True Then
            phy_hea = "2"
        End If

        Dim phy_vas As String = " "
        If vas1.Checked = True Then
            phy_vas = "0"
        ElseIf vas2.Checked = True Then
            phy_vas = "1"
        ElseIf vas3.Checked = True Then
            phy_vas = "2"
        End If

        Dim phy_lun_che As String = " "

        If chest1.Checked = True Then
            phy_lun_che = "0"
        ElseIf chest2.Checked = True Then
            phy_lun_che = "1"
        ElseIf chest3.Checked = True Then
            phy_lun_che = "2"
        End If

        Dim phy_adb As String = " "

        If ab1.Checked = True Then
            phy_adb = "0"
        ElseIf ab2.Checked = True Then
            phy_adb = "1"
        ElseIf ab3.Checked = True Then
            phy_adb = "2"
        End If

        Dim phy_lym As String = " "

        If lymp1.Checked = True Then
            phy_lym = "0"
        ElseIf lymp2.Checked = True Then
            phy_lym = "1"
        ElseIf lymp3.Checked = True Then
            phy_lym = "2"
        End If

        Dim phy_gus As String = " "

        If gu1.Checked = True Then
            phy_gus = "0"
        ElseIf gu2.Checked = True Then
            phy_gus = "1"
        ElseIf gu3.Checked = True Then
            phy_gus = "2"
        End If

        Dim phy_ext As String = " "

        If ex1.Checked = True Then
            phy_ext = "0"
        ElseIf ex2.Checked = True Then
            phy_ext = "1"
        ElseIf ex3.Checked = True Then
            phy_ext = "2"
        End If

        Dim phy_spi As String = " "

        If spine1.Checked = True Then
            phy_spi = "0"
        ElseIf spine2.Checked = True Then
            phy_spi = "1"
        ElseIf spine3.Checked = True Then
            phy_spi = "2"
        End If

        Dim phy_ski As String = " "

        If skin1.Checked = True Then
            phy_ski = "0"
        ElseIf skin2.Checked = True Then
            phy_ski = "1"
        ElseIf skin3.Checked = True Then
            phy_ski = "2"
        End If

        Dim phy_aud As String = " "

        If audio1.Checked = True Then
            phy_aud = "0"
        ElseIf audio2.Checked = True Then
            phy_aud = "1"
        ElseIf audio3.Checked = True Then
            phy_aud = "2"
        End If

        Dim phy_lun_tes As String = " "

        If lung1.Checked = True Then
            phy_lun_tes = "0"
        ElseIf lung2.Checked = True Then
            phy_lun_tes = "1"
        ElseIf lung3.Checked = True Then
            phy_lun_tes = "2"
        End If

        Dim phy_ekg_oil As String = " "

        If ekg1.Checked = True Then
            phy_ekg_oil = "0"
        ElseIf ekg2.Checked = True Then
            phy_ekg_oil = "1"
        ElseIf ekg3.Checked = True Then
            phy_ekg_oil = "2"
        End If

        Dim eye_vision As String

        If eye_in.Checked = True Then
            eye_vision = "1"
        Else
            eye_vision = "0"
        End If




        If CheckBox2.Checked = True Then
            spec = "1"
        Else
            spec = "0"
        End If

        If CheckBox3.Checked = True Then
            fitair = "1"
        Else
            fitair = "0"
        End If

        If CheckBox4.Checked = True Then
            fitbreath = "1"
        Else
            fitbreath = "0"
        End If

        If CheckBox5.Checked = True Then
            fitcrance = "1"
        Else
            fitcrance = "0"
        End If

        If CheckBox6.Checked = True Then
            fitemergency = "1"
        Else
            fitemergency = "0"
        End If

        If CheckBox7.Checked = True Then
            fitfood = "1"
        Else
            fitfood = "0"
        End If
        Dim ust As String
        If ust1.Checked = True Then
            ust = "0"

        ElseIf ust2.Checked = True Then
            ust = "1"

        ElseIf ust3.Checked = True Then

            ust = "2"

        End If


        Dim phy_est As String = ""
        If est1.Checked = True Then
            phy_est = "0"
        ElseIf est2.Checked = True Then
            phy_est = "1"

        ElseIf est3.Checked = True Then
            phy_est = "2"

        End If



        commandText2 = "UPDATE healthycare_ryh SET p_company = '" & txtcompany.Text & "' , p_id = '" & txtsearch.Text & "' , p_name = '" & txt_name.Text & "' , p_height = '" & tab1_txt_height.Text & "'  , p_weight = '" & tab1_tab_weight.Text & "', p_sex = '" & txt_sex.Text & "' , p_age = '" & txt_age.Text & "' , p_tell = '" & txt_tell.Text & "', p_add = '" & txt_address.Text & "', p_aid = '" & txt_aid.Text & "' , p_date = '" & txt_date.Text & "', p_pulse = '" & tab1_txt_pulserate.Text & "', p_bmi = '" & tab1_txt_bmi.Text & "',p_blood_pre = '" & tab1_txt_bloodp.Text & "',p_typevision = '" & eye_vision & "', p_eyeright = '" & tab1_txt_eyer.Text & "', p_eyeleft = '" & tab1_txt_eyel.Text & "',p_colorbindness = '" & Blind_Color.Text & "',phy_eye = '" & phy_eye & "' , phy_nec = '" & phy_nec & "' , phy_lun_che = '" & phy_lun_che & "', phy_hea = '" & phy_hea & "',phy_vas ='" & phy_vas & "' ,phy_abd ='" & phy_adb & "',phy_lym ='" & phy_lym & "',phy_gus = '" & phy_gus & "',phy_ext ='" & phy_ext & "', phy_spi ='" & phy_spi & "',  phy_ski = '" & phy_ski & "', phy_aud ='" & phy_aud & "',phy_lun_tes = '" & phy_lun_tes & "',phy_ekg_oil ='" & phy_ekg_oil & "',che_fbs = '" & tab4_txt_fbs.Text & "', che_bun ='" & tab5_txt_bun.Text & "',che_cre = '" & tab5_txt_creatinine.Text & "' ,che_cho = '" & tab5_txt_cholesterol.Text & "',che_tri = '" & tab5_txt_trigyceride.Text & "',che_sgo ='" & tab6_txt_sgot.Text & "' ,  che_sgp = '" & tab6_txt_sgpt.Text & "', che_alk = '" & tab6_txt_alkaline.Text & "' , che_uri = '" & tab5_txt_uricacid.Text & "',che_hdl = '" & tab5_txt_hdl.Text & "', che_ldl = '" & tab6_txt_ldl.Text & " ' ,che_afp = '" & tab6_txt_afp.Text & "',che_cea = '" & TextBox5.Text & "',che_mer = '" & TextBox6.Text & "' ,blo_gro = '" & tab2_txt_groupblood.Text & "', blo_rhe = '" & tab2_txt_rh.Text & "',blo_pla = '" & tab2_txt_plate.Text & "', tab6_result_psp = '" & tab6_result_psp.Text & "' , blo_redcell = '" & tab2_txt_redcell.Text & "' , blo_cbc_wbc = '" & tab2_txt_wbc.Text & "' ,blo_cbc_hct ='" & tab2_txt_hct.Text & "',blo_cbc_hb = '" & tab2_txt_hb.Text & "',blo_cbc_l ='" & tab2_txt_lymphocytes.Text & "',blo_cbc_m = '" & tab2_txt_monocytes.Text & "',blo_cbc_e = '" & tab2_txt_eosinophils.Text & "',blo_cbc_b = '" & tab2_txt_bashophils.Text & "',blo_cbc_n = '" & tab2_txt_neutrophils.Text & "',blo_cbc_a = '" & tab2_txt_atypical.Text & "',uri_col = '" & tab3_txt_color.Text & "',uri_spg='" & tab3_txt_spgr.Text & "', uri_alb = '" & tab3_txt_albumin.Text & "', uri_blo = '" & tab3_txt_blood.Text & "',uri_epi = '" & tab3_txt_epi.Text & "', uri_app = '" & tab3_txt_appearance.Text & "', uri_ph = '" & tab3_txt_ph.Text & "', uri_glu = '" & tab3_txt_glucose.Text & "',uri_rbe='" & tab3_txt_rbc.Text & "',uri_wbc = '" & tab3_txt_wbc.Text & "', uri_other = '" & tab3_txt_other.Text & "',sto_wbc = '" & tab6_stool_wbc.Text & "',sto_rbc = '" & tab6_stool_rbc.Text & "',sto_ova = '" & tab6_stool_parasites.Text & "',sto_occ='" & tab6_stool_blood.Text & "',xray = '" & tab4_result_x_ray.Text & "' ,result_phy ='" & tab4_result_phy.Text & "',result_psp='" & tab6_result_psp.Text & "',hiv = '" & tab3_txt_hiv.Text & "',vdrl  ='" & tab3_txt_vdrl.Text & "',vir_sag = '" & txt_hbsag.Text & "',vir_sab='" & txt_hbsab.Text & "' ,vir_cab='" & txt_hbcab.Text & "',vir_igg='" & txt_anti_igg.Text & "',vir_igm ='" & txt_hav_igm.Text & "',package_type ='Oil',result_eye='" & RichTextBox5.Text & "',eye_1='" & ComboBox25.Text & "',blind ='" & Blind_Color.Text & "',result_blind ='" & tab1_result_blindness.Text & "',check_eye = '" & ComboBox1.Text & "' ,result_check_eye ='" & tab1_result_eye.Text & "',teeth='" & ComboBox24.Text & "',result_teeth='" & tab1_result_tooth.Text & "',result_all ='" & MySqlHelper.EscapeString(RichTextBox1.Text) & "',doctor_name = '" & txt_doctor_name.Text & "',license = '" & txt_license.Text & "',result_fit='" & txt_other_fit.Text & "',amphetamine = '" & tab3_txt_amphetamine.Text & "',stool_culture = '" & ComboBox26.Text & "',tab2_result='" & tab2_result_txt.Text & "',tab4_result_fbs ='" & tab4_result_fbs.Text & "',tab4_result_vdrl='" & tab4_result_vdrl.Text & "',tab4_result_hiv='" & RichTextBox3.Text & "',tab5_result_bun ='" & tab5_result_bun.Text & "',tab5_result_cholesterol ='" & tab5_result_cholesterol.Text & "',tab5_result_creatinine = '" & tab5_result_creatinine.Text & "',tab5_result_trigyceride='" & tab5_result_trigyceride.Text & "',tab5_result_uric_acid ='" & tab5_result_trigyceride.Text & "',tab5_result_hdl ='" & tab5_result_hdl.Text & "',tab6_result_ldl ='" & tab6_result_ldl.Text & "',tab6_result_alkaline='" & tab6_result_alkaline.Text & "' ,tab6_result_sgot='" & tab6_result_sgot.Text & "',tab6_result_afp='" & tab6_result_afp.Text & "',tab_result_spgt ='" & tab6_result_spgt.Text & "',tab6_result_psp='" & tab6_result_psp.Text & "',tab6_result_virus_b ='" & tab6_result_virus_b.Text & "',tab6_result_stool ='" & tab6_result_stool.Text & "',tab6_result_cea ='" & RichTextBox2.Text & "',tab6_result_mercury ='" & RichTextBox4.Text & "',p_lastname ='" & txt_lastname.Text & "',che_pap='" & ComboBox19.Text & "',glass ='" & glass & "' ,fit_oil = '" & fit_check & "', fit_spec= '" & spec & "' , fit_air ='" & fitair & "' , fit_breath= '" & fitbreath & "', fit_crane = '" & fitcrance & "', fit_emergency = '" & fitemergency & "' , fit_food ='" & fitfood & "',phy_est = '" & phy_est & "' , phy_ust = '" & ust & "' WHERE idhealthycare = " & health & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()

        Dim NextForm As frmOilAfterform = New frmOilAfterform(mysqlpass, ipconnect, usernamedb, dbname, health)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim NextForm As chack_package = New chack_package(mysqlpass, ipconnect, usernamedb, dbname)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub TabPageEX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageEX5.Click

    End Sub

    Private Sub listview1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listview1.Click
        txt_doctor_name.Text = listview1.SelectedItems(0).SubItems(2).Text
        txt_license.Text = listview1.SelectedItems(0).SubItems(0).Text
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        update_data()

        Dim commandText2 As String
        Dim glass As String
        If CheckBox2.Checked = True Then
            spec = "1"
        Else
            spec = "0"
        End If

        If CheckBox3.Checked = True Then
            fitair = "1"
        Else
            fitair = "0"
        End If

        If CheckBox4.Checked = True Then
            fitbreath = "1"
        Else
            fitbreath = "0"
        End If

        If CheckBox5.Checked = True Then
            fitcrance = "1"
        Else
            fitcrance = "0"
        End If

        If CheckBox6.Checked = True Then
            fitemergency = "1"
        Else
            fitemergency = "0"
        End If

        If CheckBox7.Checked = True Then
            fitfood = "1"
        Else
            fitfood = "0"
        End If


        If eye_in.Checked = True Then
            glass = "1"
        ElseIf eye_out.Checked = True Then
            glass = "0"
        End If
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim phy_eye As String = " "
        If r_eye1.Checked = True Then
            phy_eye = "0"
        ElseIf r_eye2.Checked = True Then
            phy_eye = "1"
        ElseIf r_eye3.Checked = True Then
            phy_eye = "2"
        End If

        If RadioButton1.Checked = True Then
            fit_check = "1"
        ElseIf RadioButton2.Checked = True Then
            fit_check = "2"
        ElseIf RadioButton3.Checked = True Then
            fit_check = "3"
        End If

        Dim phy_nec As String = " "
        If neck1.Checked = True Then
            phy_nec = "0"
        ElseIf neck2.Checked = True Then
            phy_nec = "1"
        ElseIf neck3.Checked = True Then
            phy_nec = "2"
        End If

        Dim phy_hea As String = " "
        If heart1.Checked = True Then
            phy_hea = "0"
        ElseIf heart2.Checked = True Then
            phy_hea = "1"
        ElseIf heart3.Checked = True Then
            phy_hea = "2"
        End If

        Dim phy_vas As String = " "
        If vas1.Checked = True Then
            phy_vas = "0"
        ElseIf vas2.Checked = True Then
            phy_vas = "1"
        ElseIf vas3.Checked = True Then
            phy_vas = "2"
        End If

        Dim phy_lun_che As String = " "
        If chest1.Checked = True Then
            phy_lun_che = "0"
        ElseIf chest2.Checked = True Then
            phy_lun_che = "1"
        ElseIf chest3.Checked = True Then
            phy_lun_che = "2"
        End If
        sex_fm = txt_sex.Text
        Dim phy_adb As String = " "
        If ab1.Checked = True Then
            phy_adb = "0"
        ElseIf ab2.Checked = True Then
            phy_adb = "1"
        ElseIf ab3.Checked = True Then
            phy_adb = "2"
        End If

        Dim phy_lym As String = " "
        If lymp1.Checked = True Then
            phy_lym = "0"
        ElseIf lymp2.Checked = True Then
            phy_lym = "1"
        ElseIf lymp3.Checked = True Then
            phy_lym = "2"
        End If

        Dim phy_gus As String = " "
        If gu1.Checked = True Then
            phy_gus = "0"
        ElseIf gu2.Checked = True Then
            phy_gus = "1"
        ElseIf gu3.Checked = True Then
            phy_gus = "2"
        End If

        Dim phy_ext As String = " "
        If ex1.Checked = True Then
            phy_ext = "0"
        ElseIf ex2.Checked = True Then
            phy_ext = "1"
        ElseIf ex3.Checked = True Then
            phy_ext = "2"
        End If

        Dim phy_spi As String = " "
        If spine1.Checked = True Then
            phy_spi = "0"
        ElseIf spine2.Checked = True Then
            phy_spi = "1"
        ElseIf spine3.Checked = True Then
            phy_spi = "2"
        End If

        Dim phy_ski As String = " "
        If skin1.Checked = True Then
            phy_ski = "0"
        ElseIf skin2.Checked = True Then
            phy_ski = "1"
        ElseIf skin3.Checked = True Then
            phy_ski = "2"
        End If

        Dim phy_aud As String = " "
        If audio1.Checked = True Then
            phy_aud = "0"
        ElseIf audio2.Checked = True Then
            phy_aud = "1"
        ElseIf audio3.Checked = True Then
            phy_aud = "2"
        End If

        Dim phy_lun_tes As String = " "
        If lung1.Checked = True Then
            phy_lun_tes = "0"
        ElseIf lung2.Checked = True Then
            phy_lun_tes = "1"
        ElseIf lung3.Checked = True Then
            phy_lun_tes = "2"
        End If

        Dim phy_ekg_oil As String = " "
        If ekg1.Checked = True Then
            phy_ekg_oil = "0"
        ElseIf ekg2.Checked = True Then
            phy_ekg_oil = "1"
        ElseIf ekg3.Checked = True Then
            phy_ekg_oil = "2"
        End If

        Dim ust As String
        If ust1.Checked = True Then
            ust = "0"

        ElseIf ust2.Checked = True Then
            ust = "1"

        ElseIf ust3.Checked = True Then

            ust = "2"

        End If


        Dim est As String
        If est1.Checked = True Then
            est = "0"

        ElseIf est2.Checked = True Then
            est = "1"

        ElseIf est3.Checked = True Then

            est = "2"


        End If




        Dim eye_vision As String

        If eye_in.Checked = True Then
            eye_vision = "1"
        Else
            eye_vision = "0"
        End If


        cbc_result = tab2_result_txt.Text
        urine_result = RichTextBox6.Text



        result_pulserate = tab1_txt_pulserate.Text

        eye_left = tab1_txt_eyel.Text
        eye_right = tab1_txt_eyer.Text

        address = txt_address.Text
        tellephone = txt_tell.Text
        unders = txt_aid.Text


        commandText2 = "UPDATE healthycare_ryh SET blood_pressure_result = '" & blood_pressure_result.Text & "',eye_result = '" & eye_result.Text & "',p_company = '" & txtcompany.Text & "' , p_id = '" & txtsearch.Text & "' , p_name = '" & txt_name.Text & "' , p_height = '" & tab1_txt_height.Text & "'  , p_weight = '" & tab1_tab_weight.Text & "', p_sex = '" & txt_sex.Text & "' , p_age = '" & txt_age.Text & "' , p_tell = '" & txt_tell.Text & "', p_add = '" & txt_address.Text & "', p_aid = '" & txt_aid.Text & "' , p_date = '" & txt_date.Text & "', p_pulse = '" & tab1_txt_pulserate.Text & "', p_bmi = '" & tab1_txt_bmi.Text & "',p_blood_pre = '" & tab1_txt_bloodp.Text & "',p_typevision = '" & eye_vision & "', p_eyeright = '" & tab1_txt_eyer.Text & "', p_eyeleft = '" & tab1_txt_eyel.Text & "',p_colorbindness = '" & Blind_Color.Text & "',phy_eye = '" & phy_eye & "' , phy_nec = '" & phy_nec & "' , phy_lun_che = '" & phy_lun_che & "', phy_hea = '" & phy_hea & "',phy_vas ='" & phy_vas & "' ,phy_abd ='" & phy_adb & "',phy_lym ='" & phy_lym & "',phy_gus = '" & phy_gus & "',phy_ext ='" & phy_ext & "', phy_spi ='" & phy_spi & "',  phy_ski = '" & phy_ski & "', phy_aud ='" & phy_aud & "',phy_lun_tes = '" & phy_lun_tes & "',phy_ekg_oil ='" & phy_ekg_oil & "',che_fbs = '" & tab4_txt_fbs.Text & "', che_bun ='" & tab5_txt_bun.Text & "',che_cre = '" & tab5_txt_creatinine.Text & "' ,che_cho = '" & tab5_txt_cholesterol.Text & "',che_tri = '" & tab5_txt_trigyceride.Text & "',che_sgo ='" & tab6_txt_sgot.Text & "' ,  che_sgp = '" & tab6_txt_sgpt.Text & "', che_alk = '" & tab6_txt_alkaline.Text & "' , che_uri = '" & tab5_txt_uricacid.Text & "',che_hdl = '" & tab5_txt_hdl.Text & "', che_ldl = '" & tab6_txt_ldl.Text & " ' ,che_afp = '" & tab6_txt_afp.Text & "',che_cea = '" & TextBox5.Text & "',che_mer = '" & TextBox6.Text & "' ,blo_gro = '" & tab2_txt_groupblood.Text & "', blo_rhe = '" & tab2_txt_rh.Text & "',blo_pla = '" & tab2_txt_plate.Text & "', tab6_result_psp = '" & tab6_result_psp.Text & "' , blo_redcell = '" & tab2_txt_redcell.Text & "' , blo_cbc_wbc = '" & tab2_txt_wbc.Text & "' ,blo_cbc_hct ='" & tab2_txt_hct.Text & "',blo_cbc_hb = '" & tab2_txt_hb.Text & "',blo_cbc_l ='" & tab2_txt_lymphocytes.Text & "',blo_cbc_m = '" & tab2_txt_monocytes.Text & "',blo_cbc_e = '" & tab2_txt_eosinophils.Text & "',blo_cbc_b = '" & tab2_txt_bashophils.Text & "',blo_cbc_n = '" & tab2_txt_neutrophils.Text & "',blo_cbc_a = '" & tab2_txt_atypical.Text & "',uri_col = '" & tab3_txt_color.Text & "',uri_spg='" & tab3_txt_spgr.Text & "', uri_alb = '" & tab3_txt_albumin.Text & "', uri_blo = '" & tab3_txt_blood.Text & "',uri_epi = '" & tab3_txt_epi.Text & "', uri_app = '" & tab3_txt_appearance.Text & "', uri_ph = '" & tab3_txt_ph.Text & "', uri_glu = '" & tab3_txt_glucose.Text & "',uri_rbe='" & tab3_txt_rbc.Text & "',uri_wbc = '" & tab3_txt_wbc.Text & "', uri_other = '" & tab3_txt_other.Text & "',sto_wbc = '" & tab6_stool_wbc.Text & "',sto_rbc = '" & tab6_stool_rbc.Text & "',sto_ova = '" & tab6_stool_parasites.Text & "',sto_occ='" & tab6_stool_blood.Text & "',xray = '" & tab4_result_x_ray.Text & "' ,result_phy ='" & tab4_result_phy.Text & "',result_psp='" & tab6_result_psp.Text & "',hiv = '" & tab3_txt_hiv.Text & "',vdrl  ='" & tab3_txt_vdrl.Text & "',vir_sag = '" & txt_hbsag.Text & "',vir_sab='" & txt_hbsab.Text & "' ,vir_cab='" & txt_hbcab.Text & "',vir_igg='" & txt_anti_igg.Text & "',vir_igm ='" & txt_hav_igm.Text & "',package_type ='Oil',result_eye='" & RichTextBox5.Text & "',eye_1='" & ComboBox25.Text & "',blind ='" & Blind_Color.Text & "',result_blind ='" & tab1_result_blindness.Text & "',check_eye = '" & ComboBox1.Text & "' ,result_check_eye ='" & tab1_result_eye.Text & "',teeth='" & ComboBox24.Text & "',result_teeth='" & tab1_result_tooth.Text & "',result_all ='" & RichTextBox1.Text & "',doctor_name = '" & txt_doctor_name.Text & "',license = '" & txt_license.Text & "',result_fit='" & txt_other_fit.Text & "',amphetamine = '" & tab3_txt_amphetamine.Text & "',stool_culture = '" & ComboBox26.Text & "',tab2_result='" & tab2_result_txt.Text & "',tab4_result_fbs ='" & tab4_result_fbs.Text & "',tab4_result_vdrl='" & tab4_result_vdrl.Text & "',tab4_result_hiv='" & RichTextBox3.Text & "',tab5_result_bun ='" & tab5_result_bun.Text & "',tab5_result_cholesterol ='" & tab5_result_cholesterol.Text & "',tab5_result_creatinine = '" & tab5_result_creatinine.Text & "',tab5_result_trigyceride='" & tab5_result_trigyceride.Text & "',tab5_result_uric_acid ='" & tab5_result_trigyceride.Text & "',tab5_result_hdl ='" & tab5_result_hdl.Text & "',tab6_result_ldl ='" & tab6_result_ldl.Text & "',tab6_result_alkaline='" & tab6_result_alkaline.Text & "' ,tab6_result_sgot='" & tab6_result_sgot.Text & "',tab6_result_afp='" & tab6_result_afp.Text & "',tab_result_spgt ='" & tab6_result_spgt.Text & "',tab6_result_psp='" & tab6_result_psp.Text & "',tab6_result_virus_b ='" & tab6_result_virus_b.Text & "',tab6_result_stool ='" & tab6_result_stool.Text & "',tab6_result_cea ='" & RichTextBox2.Text & "',tab6_result_mercury ='" & RichTextBox4.Text & "',p_lastname ='" & txt_lastname.Text & "',che_pap='" & ComboBox19.Text & "',glass ='" & glass & "' ,fit_oil = '" & fit_check & "', fit_spec= '" & spec & "' , fit_air ='" & fitair & "' , fit_breath= '" & fitbreath & "', fit_crane = '" & fitcrance & "', fit_emergency = '" & fitemergency & "' , fit_food ='" & fitfood & "'  , phy_est ='" & est & "'  , phy_ust = '" & ust & "'  WHERE idhealthycare = " & health & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()

        Dim NextForm As frmextra_packageb = New frmextra_packageb(mysqlpass, ipconnect, usernamedb, dbname, health)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        check_sub = "0"
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        check_sub = "1"
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim name_lastname As String
        Dim company_name As String
        name_lastname = txt_name.Text + "  " + txt_lastname.Text
        company_name = txtcompany.Text

        Dim FrmReportEnv As FrmReportEnv = New FrmReportEnv(name_lastname, company_name, "0")
        FrmReportEnv.Show()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim name_lastname As String
        Dim company_name As String
        name_lastname = txt_name.Text + "  " + txt_lastname.Text
        company_name = txtcompany.Text

        Dim FrmReportEnv As FrmReportEnv = New FrmReportEnv(name_lastname, company_name, "1")
        FrmReportEnv.Show()
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        update_data()

        Dim commandText2 As String
        Dim glass As String
        If eye_in.Checked = True Then
            glass = "1"
        ElseIf eye_out.Checked = True Then
            glass = "0"
        ElseIf eye_not.Checked = True Then
            glass = "3"
        End If

        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        checkaddress = CheckBox8.Checked
        address = txt_address.Text
        Dim phy_eye As String = " "
        If r_eye1.Checked = True Then
            phy_eye = "0"
        ElseIf r_eye2.Checked = True Then
            phy_eye = "1"
        ElseIf r_eye3.Checked = True Then
            phy_eye = "2"
        End If

        If RadioButton1.Checked = True Then
            fit_check = "1"
        ElseIf RadioButton2.Checked = True Then
            fit_check = "2"
        ElseIf RadioButton3.Checked = True Then
            fit_check = "3"
        End If

        Dim phy_nec As String = " "
        If neck1.Checked = True Then
            phy_nec = "0"
        ElseIf neck2.Checked = True Then
            phy_nec = "1"
        ElseIf neck3.Checked = True Then
            phy_nec = "2"
        End If

        Dim phy_hea As String = " "
        If heart1.Checked = True Then
            phy_hea = "0"
        ElseIf heart2.Checked = True Then
            phy_hea = "1"
        ElseIf heart3.Checked = True Then
            phy_hea = "2"
        End If

        Dim phy_vas As String = " "
        If vas1.Checked = True Then
            phy_vas = "0"
        ElseIf vas2.Checked = True Then
            phy_vas = "1"
        ElseIf vas3.Checked = True Then
            phy_vas = "2"
        End If

        Dim phy_lun_che As String = " "

        If chest1.Checked = True Then
            phy_lun_che = "0"
        ElseIf chest2.Checked = True Then
            phy_lun_che = "1"
        ElseIf chest3.Checked = True Then
            phy_lun_che = "2"
        End If

        Dim phy_adb As String = " "

        If ab1.Checked = True Then
            phy_adb = "0"
        ElseIf ab2.Checked = True Then
            phy_adb = "1"
        ElseIf ab3.Checked = True Then
            phy_adb = "2"
        End If

        Dim phy_lym As String = " "

        If lymp1.Checked = True Then
            phy_lym = "0"
        ElseIf lymp2.Checked = True Then
            phy_lym = "1"
        ElseIf lymp3.Checked = True Then
            phy_lym = "2"
        End If



        Dim phy_gus As String = " "

        If gu1.Checked = True Then
            phy_gus = "0"
        ElseIf gu2.Checked = True Then
            phy_gus = "1"
        ElseIf gu3.Checked = True Then
            phy_gus = "2"
        End If

        Dim phy_ext As String = " "

        If ex1.Checked = True Then
            phy_ext = "0"
        ElseIf ex2.Checked = True Then
            phy_ext = "1"
        ElseIf ex3.Checked = True Then
            phy_ext = "2"
        End If

        Dim phy_spi As String = " "

        If spine1.Checked = True Then
            phy_spi = "0"
        ElseIf spine2.Checked = True Then
            phy_spi = "1"
        ElseIf spine3.Checked = True Then
            phy_spi = "2"
        End If

        Dim phy_ski As String = " "

        If skin1.Checked = True Then
            phy_ski = "0"
        ElseIf skin2.Checked = True Then
            phy_ski = "1"
        ElseIf skin3.Checked = True Then
            phy_ski = "2"
        End If

        Dim phy_aud As String = " "

        If audio1.Checked = True Then
            phy_aud = "0"
        ElseIf audio2.Checked = True Then
            phy_aud = "1"
        ElseIf audio3.Checked = True Then
            phy_aud = "2"
        End If

        Dim phy_lun_tes As String = " "

        If lung1.Checked = True Then
            phy_lun_tes = "0"
        ElseIf lung2.Checked = True Then
            phy_lun_tes = "1"
        ElseIf lung3.Checked = True Then
            phy_lun_tes = "2"
        End If

        Dim phy_ekg_oil As String = " "

        If ekg1.Checked = True Then
            phy_ekg_oil = "0"
        ElseIf ekg2.Checked = True Then
            phy_ekg_oil = "1"
        ElseIf ekg3.Checked = True Then
            phy_ekg_oil = "2"
        End If

        Dim eye_vision As String

        If eye_in.Checked = True Then
            eye_vision = "1"
        Else
            eye_vision = "0"
        End If




        If CheckBox2.Checked = True Then
            spec = "1"
        Else
            spec = "0"
        End If

        If CheckBox3.Checked = True Then
            fitair = "1"
        Else
            fitair = "0"
        End If

        If CheckBox4.Checked = True Then
            fitbreath = "1"
        Else
            fitbreath = "0"
        End If

        If CheckBox5.Checked = True Then
            fitcrance = "1"
        Else
            fitcrance = "0"
        End If

        If CheckBox6.Checked = True Then
            fitemergency = "1"
        Else
            fitemergency = "0"
        End If

        If CheckBox7.Checked = True Then
            fitfood = "1"
        Else
            fitfood = "0"
        End If

        Dim ust As String
        If ust1.Checked = True Then
            ust = "0"

        ElseIf ust2.Checked = True Then
            ust = "1"

        ElseIf ust3.Checked = True Then

            ust = "2"

        End If


        Dim phy_est As String = ""
        If est1.Checked = True Then
            phy_est = "0"
        ElseIf est2.Checked = True Then
            phy_est = "1"

        ElseIf est3.Checked = True Then
            phy_est = "2"

        End If


        commandText2 = "UPDATE healthycare_ryh SET p_company = '" & txtcompany.Text & "' , p_id = '" & txtsearch.Text & "' , p_name = '" & txt_name.Text & "' , p_height = '" & tab1_txt_height.Text & "'  , p_weight = '" & tab1_tab_weight.Text & "', p_sex = '" & txt_sex.Text & "' , p_age = '" & txt_age.Text & "' , p_tell = '" & txt_tell.Text & "', p_add = '" & txt_address.Text & "', p_aid = '" & txt_aid.Text & "' , p_date = '" & txt_date.Text & "', p_pulse = '" & tab1_txt_pulserate.Text & "', p_bmi = '" & tab1_txt_bmi.Text & "',p_blood_pre = '" & tab1_txt_bloodp.Text & "',p_typevision = '" & eye_vision & "', p_eyeright = '" & tab1_txt_eyer.Text & "', p_eyeleft = '" & tab1_txt_eyel.Text & "',p_colorbindness = '" & Blind_Color.Text & "',phy_eye = '" & phy_eye & "' , phy_nec = '" & phy_nec & "' , phy_lun_che = '" & phy_lun_che & "', phy_hea = '" & phy_hea & "',phy_vas ='" & phy_vas & "' ,phy_abd ='" & phy_adb & "',phy_lym ='" & phy_lym & "',phy_gus = '" & phy_gus & "',phy_ext ='" & phy_ext & "', phy_spi ='" & phy_spi & "',  phy_ski = '" & phy_ski & "', phy_aud ='" & phy_aud & "',phy_lun_tes = '" & phy_lun_tes & "',phy_ekg_oil ='" & phy_ekg_oil & "',che_fbs = '" & tab4_txt_fbs.Text & "', che_bun ='" & tab5_txt_bun.Text & "',che_cre = '" & tab5_txt_creatinine.Text & "' ,che_cho = '" & tab5_txt_cholesterol.Text & "',che_tri = '" & tab5_txt_trigyceride.Text & "',che_sgo ='" & tab6_txt_sgot.Text & "' ,  che_sgp = '" & tab6_txt_sgpt.Text & "', che_alk = '" & tab6_txt_alkaline.Text & "' , che_uri = '" & tab5_txt_uricacid.Text & "',che_hdl = '" & tab5_txt_hdl.Text & "', che_ldl = '" & tab6_txt_ldl.Text & " ' ,che_afp = '" & tab6_txt_afp.Text & "',che_cea = '" & TextBox5.Text & "',che_mer = '" & TextBox6.Text & "' ,blo_gro = '" & tab2_txt_groupblood.Text & "', blo_rhe = '" & tab2_txt_rh.Text & "',blo_pla = '" & tab2_txt_plate.Text & "', tab6_result_psp = '" & tab6_result_psp.Text & "' , blo_redcell = '" & tab2_txt_redcell.Text & "' , blo_cbc_wbc = '" & tab2_txt_wbc.Text & "' ,blo_cbc_hct ='" & tab2_txt_hct.Text & "',blo_cbc_hb = '" & tab2_txt_hb.Text & "',blo_cbc_l ='" & tab2_txt_lymphocytes.Text & "',blo_cbc_m = '" & tab2_txt_monocytes.Text & "',blo_cbc_e = '" & tab2_txt_eosinophils.Text & "',blo_cbc_b = '" & tab2_txt_bashophils.Text & "',blo_cbc_n = '" & tab2_txt_neutrophils.Text & "',blo_cbc_a = '" & tab2_txt_atypical.Text & "',uri_col = '" & tab3_txt_color.Text & "',uri_spg='" & tab3_txt_spgr.Text & "', uri_alb = '" & tab3_txt_albumin.Text & "', uri_blo = '" & tab3_txt_blood.Text & "',uri_epi = '" & tab3_txt_epi.Text & "', uri_app = '" & tab3_txt_appearance.Text & "', uri_ph = '" & tab3_txt_ph.Text & "', uri_glu = '" & tab3_txt_glucose.Text & "',uri_rbe='" & tab3_txt_rbc.Text & "',uri_wbc = '" & tab3_txt_wbc.Text & "', uri_other = '" & tab3_txt_other.Text & "',sto_wbc = '" & tab6_stool_wbc.Text & "',sto_rbc = '" & tab6_stool_rbc.Text & "',sto_ova = '" & tab6_stool_parasites.Text & "',sto_occ='" & tab6_stool_blood.Text & "',xray = '" & tab4_result_x_ray.Text & "' ,result_phy ='" & tab4_result_phy.Text & "',result_psp='" & tab6_result_psp.Text & "',hiv = '" & tab3_txt_hiv.Text & "',vdrl  ='" & tab3_txt_vdrl.Text & "',vir_sag = '" & txt_hbsag.Text & "',vir_sab='" & txt_hbsab.Text & "' ,vir_cab='" & txt_hbcab.Text & "',vir_igg='" & txt_anti_igg.Text & "',vir_igm ='" & txt_hav_igm.Text & "',package_type ='Oil',result_eye='" & RichTextBox5.Text & "',eye_1='" & ComboBox25.Text & "',blind ='" & Blind_Color.Text & "',result_blind ='" & tab1_result_blindness.Text & "',check_eye = '" & ComboBox1.Text & "' ,result_check_eye ='" & tab1_result_eye.Text & "',teeth='" & ComboBox24.Text & "',result_teeth='" & tab1_result_tooth.Text & "',result_all ='" & MySqlHelper.EscapeString(RichTextBox1.Text) & "',doctor_name = '" & txt_doctor_name.Text & "',license = '" & txt_license.Text & "',result_fit='" & txt_other_fit.Text & "',amphetamine = '" & tab3_txt_amphetamine.Text & "',stool_culture = '" & ComboBox26.Text & "',tab2_result='" & tab2_result_txt.Text & "',tab4_result_fbs ='" & tab4_result_fbs.Text & "',tab4_result_vdrl='" & tab4_result_vdrl.Text & "',tab4_result_hiv='" & RichTextBox3.Text & "',tab5_result_bun ='" & tab5_result_bun.Text & "',tab5_result_cholesterol ='" & tab5_result_cholesterol.Text & "',tab5_result_creatinine = '" & tab5_result_creatinine.Text & "',tab5_result_trigyceride='" & tab5_result_trigyceride.Text & "',tab5_result_uric_acid ='" & tab5_result_trigyceride.Text & "',tab5_result_hdl ='" & tab5_result_hdl.Text & "',tab6_result_ldl ='" & tab6_result_ldl.Text & "',tab6_result_alkaline='" & tab6_result_alkaline.Text & "' ,tab6_result_sgot='" & tab6_result_sgot.Text & "',tab6_result_afp='" & tab6_result_afp.Text & "',tab_result_spgt ='" & tab6_result_spgt.Text & "',tab6_result_psp='" & tab6_result_psp.Text & "',tab6_result_virus_b ='" & tab6_result_virus_b.Text & "',tab6_result_stool ='" & tab6_result_stool.Text & "',tab6_result_cea ='" & RichTextBox2.Text & "',tab6_result_mercury ='" & RichTextBox4.Text & "',p_lastname ='" & txt_lastname.Text & "',che_pap='" & ComboBox19.Text & "',glass ='" & glass & "' ,fit_oil = '" & fit_check & "', fit_spec= '" & spec & "' , fit_air ='" & fitair & "' , fit_breath= '" & fitbreath & "', fit_crane = '" & fitcrance & "', fit_emergency = '" & fitemergency & "' , fit_food ='" & fitfood & "' , phy_est ='" & phy_est & "'  , phy_ust = '" & ust & "' WHERE idhealthycare = " & health & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()

        Dim NextForm As frmOilAfterform = New frmOilAfterform(mysqlpass, ipconnect, usernamedb, dbname, health, True)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
    End Sub


End Class