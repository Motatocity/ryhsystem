﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Public Class frmOilAfterform
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcontainer As String
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim id_hn As String
    Dim mysql As MySqlConnection
    Dim rpt1 As New reportOilCompany
    Dim cryRpt As New ReportDocument
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idhn As String)
        mysqlpass = mysql_pass
        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        id_hn = idhn
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub frmOilAfterform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;user id=june;password=software;database=rajyindee_db;Character Set=utf8;"
        Try
            mysql.Open()
            ''MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try


        CrystalReportViewer1.ReportSource = rpt1


        CrystalReportViewer1.Refresh()

        If packageoil.checkaddress = True Then
            rpt1.SetParameterValue("address", "Address( ที่อยู่ )  " + packageoil.address)
        Else
            rpt1.SetParameterValue("address", "")
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        default_font()
        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh where idhealthycare = '" & id_hn & "'"
        ' mySqlCommand.CommandText = 
        MySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = MySqlCommand

        Try
            mySqlReader = MySqlCommand.ExecuteReader



            While (mySqlReader.Read())
                'same all page
                Dim hn_string As String

                Dim hn_start As String
                Dim hn_first As String
                hn_string = mySqlReader("p_id")

                hn_start = hn_string.Substring(hn_string.Length - 2)

                hn_first = Microsoft.VisualBasic.Left(hn_string, hn_string.Length - 2)
                rpt1.SetParameterValue("hn", hn_first + "-" + hn_start)
                rpt1.SetParameterValue("name", mySqlReader("p_name"))
                rpt1.SetParameterValue("lastname", mySqlReader("p_lastname"))
                rpt1.SetParameterValue("age", mySqlReader("p_age"))
                rpt1.SetParameterValue("date_exam", mySqlReader("p_date"))
                'tap1 package6
                rpt1.SetParameterValue("height", mySqlReader("p_height"))
                rpt1.SetParameterValue("weight", mySqlReader("p_weight"))
                rpt1.SetParameterValue("bmi", mySqlReader("p_bmi"))
                rpt1.SetParameterValue("pulse", mySqlReader("p_pulse"))
                rpt1.SetParameterValue("blood_pressure", mySqlReader("p_blood_pre"))
                rpt1.SetParameterValue("eye_right", mySqlReader("p_eyeright"))
                rpt1.SetParameterValue("eye_left", mySqlReader("p_eyeleft"))
                ''  rpt1.SetParameterValue("blood_pressure_result", mySqlReader("blood_pressure_result"))
                '' rpt1.SetParameterValue("eye_result_txt", mySqlReader("eye_result"))
                'tab2 package6
                rpt1.SetParameterValue("blood_group", mySqlReader("blo_gro"))
                rpt1.SetParameterValue("blood_rh", mySqlReader("blo_rhe"))
                rpt1.SetParameterValue("cbc_hb", mySqlReader("blo_cbc_hb"))
                rpt1.SetParameterValue("cbc_hct", mySqlReader("blo_cbc_hct"))
                rpt1.SetParameterValue("cbc_wbc", mySqlReader("blo_cbc_wbc"))
                rpt1.SetParameterValue("cbc_n", mySqlReader("blo_cbc_n"))
                rpt1.SetParameterValue("cbc_e", mySqlReader("blo_cbc_e"))
                rpt1.SetParameterValue("cbc_b", mySqlReader("blo_cbc_b"))
                rpt1.SetParameterValue("cbc_l", mySqlReader("blo_cbc_l"))
                rpt1.SetParameterValue("cbc_m", mySqlReader("blo_cbc_m"))
                'tab3 package6
                rpt1.SetParameterValue("color", mySqlReader("uri_col"))
                rpt1.SetParameterValue("appearance", mySqlReader("uri_app"))
                rpt1.SetParameterValue("albumin", mySqlReader("uri_alb"))
                rpt1.SetParameterValue("glucose", mySqlReader("uri_glu"))
                rpt1.SetParameterValue("spgr", mySqlReader("uri_spg"))
                rpt1.SetParameterValue("blood", mySqlReader("uri_blo"))
                rpt1.SetParameterValue("ph", mySqlReader("uri_ph"))
                If mySqlReader("uri_rbe").ToString.Length <> 8 And mySqlReader("uri_rbe").ToString.Length <> 5 Then
                    rpt1.SetParameterValue("rbc", mySqlReader("uri_rbe") + "   Cells/HP")
                Else
                    rpt1.SetParameterValue("rbc", mySqlReader("uri_rbe"))
                End If
                rpt1.SetParameterValue("wbc_urine", mySqlReader("uri_wbc"))
                rpt1.SetParameterValue("epi", mySqlReader("uri_epi"))
                'tab4 package6
                rpt1.SetParameterValue("x_ray", mySqlReader("xray"))
                rpt1.SetParameterValue("vdrl", mySqlReader("vdrl"))
                'tab4_result_us.Text = mySqlReader("result_us")
                rpt1.SetParameterValue("fbs", mySqlReader("che_fbs"))
                rpt1.SetParameterValue("hiv", mySqlReader("hiv"))
                'tab5 packge6
                rpt1.SetParameterValue("bun", mySqlReader("che_bun"))
                rpt1.SetParameterValue("creatinine", mySqlReader("che_cre"))
                rpt1.SetParameterValue("uric_acid", mySqlReader("che_uri"))
                rpt1.SetParameterValue("cholesterol", mySqlReader("che_cho"))
                rpt1.SetParameterValue("trigyceride", mySqlReader("che_tri"))
                rpt1.SetParameterValue("hdl", mySqlReader("che_hdl"))
                rpt1.SetParameterValue("ldl", mySqlReader("che_ldl"))
                rpt1.SetParameterValue("sgot", mySqlReader("che_sgo"))
                rpt1.SetParameterValue("sgpt", mySqlReader("che_sgp"))
                rpt1.SetParameterValue("alkaline", mySqlReader("che_alk"))
                rpt1.SetParameterValue("afp", mySqlReader("che_afp"))
                'tab6 
                If mySqlReader("vir_sag").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("sag", "-")
                Else
                    rpt1.SetParameterValue("sag", mySqlReader("vir_sag"))
                End If

                If mySqlReader("vir_sab").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("sab", "-")
                Else
                    rpt1.SetParameterValue("sab", mySqlReader("vir_sab"))
                End If

                If mySqlReader("vir_cab").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("cab", "-")
                Else
                    rpt1.SetParameterValue("cab", mySqlReader("vir_cab"))
                End If

                If mySqlReader("vir_igg").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("igg", "-")
                Else
                    rpt1.SetParameterValue("igg", mySqlReader("vir_igg"))
                End If



                If mySqlReader("vir_igm").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("igm", "-")
                Else
                    rpt1.SetParameterValue("igm", mySqlReader("vir_igm"))
                End If



                rpt1.SetParameterValue("cea", mySqlReader("che_cea"))
                rpt1.SetParameterValue("mercury", mySqlReader("che_mer"))


                If mySqlReader("sto_wbc").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("stool_wbc", "-")
                Else
                    rpt1.SetParameterValue("stool_wbc", mySqlReader("sto_wbc"))
                End If

                If mySqlReader("sto_rbc").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("stool_rbc", "-")
                Else
                    rpt1.SetParameterValue("stool_rbc", mySqlReader("sto_rbc"))
                End If


                If mySqlReader("sto_ova").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("stool_parasite", "-")
                Else
                    rpt1.SetParameterValue("stool_parasite", mySqlReader("sto_ova"))
                End If


                If mySqlReader("sto_occ").ToString.Trim = "-" Then
                    rpt1.SetParameterValue("stool_blood", "-")
                Else
                    rpt1.SetParameterValue("stool_blood", mySqlReader("sto_occ"))
                End If






                If mySqlReader("phy_eye") = "0" Then
                    rpt1.SetParameterValue("eye_n", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("eye_ab", "<font></font>")
                ElseIf mySqlReader("phy_eye") = "1" Then
                    rpt1.SetParameterValue("eye_n", "<font></font>")
                    rpt1.SetParameterValue("eye_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_eye") = "2" Then
                    rpt1.SetParameterValue("eye_n", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("eye_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_nec") = "0" Then
                    rpt1.SetParameterValue("neck_n", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("neck_ab", "<font></font>")
                ElseIf mySqlReader("phy_nec") = "1" Then
                    rpt1.SetParameterValue("neck_n", "<font></font>")
                    rpt1.SetParameterValue("neck_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_nec") = "2" Then
                    rpt1.SetParameterValue("neck_n", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("neck_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_hea") = "0" Then
                    rpt1.SetParameterValue("heart_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("heat_ab", "<font></font>")
                ElseIf mySqlReader("phy_hea") = "1" Then
                    rpt1.SetParameterValue("heart_a", "<font></font>")
                    rpt1.SetParameterValue("heat_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_hea") = "2" Then
                    rpt1.SetParameterValue("heart_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("heat_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_vas") = "0" Then
                    rpt1.SetParameterValue("vac_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("vac_ab", "<font></font>")
                ElseIf mySqlReader("phy_vas") = "1" Then
                    rpt1.SetParameterValue("vac_a", "<font></font>")
                    rpt1.SetParameterValue("vac_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_vas") = "2" Then
                    rpt1.SetParameterValue("vac_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("vac_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_lun_che") = "0" Then
                    rpt1.SetParameterValue("lungs_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("lungs_ab", "<font></font>")
                ElseIf mySqlReader("phy_lun_che") = "1" Then
                    rpt1.SetParameterValue("lungs_a", "<font></font>")
                    rpt1.SetParameterValue("lungs_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_lun_che") = "2" Then
                    rpt1.SetParameterValue("lungs_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("lungs_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_abd") = "0" Then
                    rpt1.SetParameterValue("ab_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("ab_ab", "<font></font>")
                ElseIf mySqlReader("phy_abd") = "1" Then
                    rpt1.SetParameterValue("ab_a", "<font></font>")
                    rpt1.SetParameterValue("ab_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_abd") = "2" Then
                    rpt1.SetParameterValue("ab_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("ab_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_lym") = "0" Then
                    rpt1.SetParameterValue("lym_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("lym_ab", "<font></font>")
                ElseIf mySqlReader("phy_lym") = "1" Then
                    rpt1.SetParameterValue("lym_a", "<font></font>")
                    rpt1.SetParameterValue("lym_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_lym") = "2" Then
                    rpt1.SetParameterValue("lym_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("lym_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_gus") = "0" Then
                    rpt1.SetParameterValue("gu_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("gu_ab", "<font></font>")
                ElseIf mySqlReader("phy_gus") = "1" Then
                    rpt1.SetParameterValue("gu_a", "<font></font>")
                    rpt1.SetParameterValue("gu_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_gus") = "2" Then
                    rpt1.SetParameterValue("gu_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("gu_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_ext") = "0" Then
                    rpt1.SetParameterValue("ex_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("ex_ab", "<font></font>")
                ElseIf mySqlReader("phy_ext") = "1" Then
                    rpt1.SetParameterValue("ex_a", "<font></font>")
                    rpt1.SetParameterValue("ex_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_ext") = "2" Then
                    rpt1.SetParameterValue("ex_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("ex_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_spi") = "0" Then
                    rpt1.SetParameterValue("spine_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("spine_ab", "<font></font>")
                ElseIf mySqlReader("phy_spi") = "1" Then
                    rpt1.SetParameterValue("spine_a", "<font></font>")
                    rpt1.SetParameterValue("spine_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_spi") = "2" Then
                    rpt1.SetParameterValue("spine_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("spine_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_ski") = "0" Then
                    rpt1.SetParameterValue("skin_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("skin_ab", "<font></font>")
                ElseIf mySqlReader("phy_ski") = "1" Then
                    rpt1.SetParameterValue("skin_a", "<font></font>")
                    rpt1.SetParameterValue("skin_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_ski") = "2" Then
                    rpt1.SetParameterValue("skin_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("skin_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_aud") = "0" Then
                    rpt1.SetParameterValue("audio_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("audio_ab", "<font></font>")
                ElseIf mySqlReader("phy_aud") = "1" Then
                    rpt1.SetParameterValue("audio_a", "<font></font>")
                    rpt1.SetParameterValue("audio_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_aud") = "2" Then
                    rpt1.SetParameterValue("audio_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("audio_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_lun_tes") = "0" Then
                    rpt1.SetParameterValue("lung_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("lung_ab", "<font></font>")
                ElseIf mySqlReader("phy_lun_tes") = "1" Then
                    rpt1.SetParameterValue("lung_a", "<font></font>")
                    rpt1.SetParameterValue("lung_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_lun_tes") = "2" Then
                    rpt1.SetParameterValue("lung_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("lung_ab", "<p align='center' ><font>-</font></p>")
                End If

                If mySqlReader("phy_ekg_oil") = "0" Then
                    rpt1.SetParameterValue("ekg_a", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("ekg_ab", "<font></font>")
                ElseIf mySqlReader("phy_ekg_oil") = "1" Then
                    rpt1.SetParameterValue("ekg_a", "<font></font>")
                    rpt1.SetParameterValue("ekg_ab", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("phy_ekg_oil") = "2" Then
                    rpt1.SetParameterValue("ekg_a", "<p align='center' ><font>-</font></p>")
                    rpt1.SetParameterValue("ekg_ab", "<p align='center' ><font>-</font></p>")
                End If


                If mySqlReader("glass") = "1" Then
                    rpt1.SetParameterValue("glass_1", "<font></font>")
                    rpt1.SetParameterValue("glass_2", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("glass") = "0" Then
                    rpt1.SetParameterValue("glass_2", "<font></font>")
                    rpt1.SetParameterValue("glass_1", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("glass") = "3" Then
                    rpt1.SetParameterValue("glass_2", "<font></font>")
                    rpt1.SetParameterValue("glass_1", "<font></font>")
                End If

                If mySqlReader("fit_oil") = "1" Then
                    rpt1.SetParameterValue("3", "<font>___</font>")
                    rpt1.SetParameterValue("2", "<font>___</font>")
                    rpt1.SetParameterValue("1", "<p align='center' ><font>&#10003;</font></p>")
                ElseIf mySqlReader("fit_oil") = "2" Then
                    rpt1.SetParameterValue("3", "<font>___</font>")
                    rpt1.SetParameterValue("2", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("1", "<font>___</font>")
                ElseIf mySqlReader("fit_oil") = "3" Then
                    rpt1.SetParameterValue("2", "<font>___</font>")
                    rpt1.SetParameterValue("3", "<p align='center' ><font>&#10003;</font></p>")
                    rpt1.SetParameterValue("1", "<font>___</font>")
                End If
                rpt1.SetParameterValue("color_blind", mySqlReader("blind"))

                rpt1.SetParameterValue("company_name", mySqlReader("p_company"))
                rpt1.SetParameterValue("psa", mySqlReader("che_pap"))

                rpt1.SetParameterValue("license", mySqlReader("license"))
                rpt1.SetParameterValue("summary", mySqlReader("result_all"))
                rpt1.SetParameterValue("doctor_name", mySqlReader("doctor_name"))
                rpt1.SetParameterValue("name_lastname", mySqlReader("p_name") + "   " + mySqlReader("p_lastname"))
                rpt1.SetParameterValue("other_fit", mySqlReader("result_fit"))
                rpt1.SetParameterValue("amphetamine", mySqlReader("amphetamine"))
                rpt1.SetParameterValue("stool_culture", mySqlReader("stool_culture"))

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


        If packageoil.spec = "1" Then
            rpt1.SetParameterValue("8", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf packageoil.spec = "0" Then
            rpt1.SetParameterValue("8", "<font>___</font>")
        End If

        If packageoil.fitair = "1" Then
            rpt1.SetParameterValue("4", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf packageoil.fitair = "0" Then
            rpt1.SetParameterValue("4", "<font>___</font>")
        End If


        If packageoil.fitbreath = "1" Then
            rpt1.SetParameterValue("5", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf packageoil.fitbreath = "0" Then
            rpt1.SetParameterValue("5", "<font>___</font>")
        End If

        If packageoil.fitcrance = "1" Then
            rpt1.SetParameterValue("9", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf packageoil.fitcrance = "0" Then
            rpt1.SetParameterValue("9", "<font>___</font>")
        End If

        If packageoil.fitemergency = "1" Then
            rpt1.SetParameterValue("6", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf packageoil.fitemergency = "0" Then
            rpt1.SetParameterValue("6", "<font>___</font>")
        End If
        If packageoil.fitfood = "1" Then
            rpt1.SetParameterValue("7", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf packageoil.fitemergency = "0" Then
            rpt1.SetParameterValue("7", "<font>___</font>")
        End If


        rpt1.SetParameterValue("datenow", packageoil.datetime)

    End Sub

    Public Sub default_font()
        rpt1.SetParameterValue("hn", "-")
        rpt1.SetParameterValue("stool_culture", " ")
        rpt1.SetParameterValue("name", "-")
        rpt1.SetParameterValue("lastname", "-")
        rpt1.SetParameterValue("age", "-")
        rpt1.SetParameterValue("date_exam", "-")
        rpt1.SetParameterValue("weight", "-")
        rpt1.SetParameterValue("height", "-")
        rpt1.SetParameterValue("pulse", "-")
        rpt1.SetParameterValue("blood_pressure", "-")
        rpt1.SetParameterValue("eye_right", "-")
        rpt1.SetParameterValue("eye_left", "-")
        rpt1.SetParameterValue("fbs", "-")
        rpt1.SetParameterValue("creatinine", "-")
        rpt1.SetParameterValue("cholesterol", "-")
        rpt1.SetParameterValue("trigyceride", "-")
        rpt1.SetParameterValue("sgot", "-")
        rpt1.SetParameterValue("sgpt", "-")
        rpt1.SetParameterValue("alkaline", "-")
        rpt1.SetParameterValue("uric_acid", "-")
        rpt1.SetParameterValue("hdl", "-")
        rpt1.SetParameterValue("ldl", "-")
        rpt1.SetParameterValue("afp", "-")
        rpt1.SetParameterValue("psa", "-")
        rpt1.SetParameterValue("cea", "-")
        rpt1.SetParameterValue("mercury", "-")
        rpt1.SetParameterValue("blood_group", "-")
        rpt1.SetParameterValue("blood_rh", "-")
        rpt1.SetParameterValue("cbc_wbc", "-")
        rpt1.SetParameterValue("cbc_hct", "-")
        rpt1.SetParameterValue("cbc_hb", "-")
        rpt1.SetParameterValue("cbc_l", "-")
        rpt1.SetParameterValue("cbc_m", "-")
        rpt1.SetParameterValue("cbc_e", "-")
        rpt1.SetParameterValue("cbc_b", "-")
        rpt1.SetParameterValue("cbc_n", "-")
        rpt1.SetParameterValue("color", "-")
        rpt1.SetParameterValue("spgr", "-")
        rpt1.SetParameterValue("albumin", "-")
        rpt1.SetParameterValue("blood", "-")
        rpt1.SetParameterValue("epi", "-")
        rpt1.SetParameterValue("appearance", "-")
        rpt1.SetParameterValue("ph", "-")
        rpt1.SetParameterValue("glucose", "-")
        rpt1.SetParameterValue("rbc", "-")
        rpt1.SetParameterValue("wbc_urine", "-")
        rpt1.SetParameterValue("stool_wbc", "-")
        rpt1.SetParameterValue("stool_rbc", "-")
        rpt1.SetParameterValue("stool_parasite", "-")
        rpt1.SetParameterValue("stool_blood", "-")
        rpt1.SetParameterValue("x_ray", "-")
        rpt1.SetParameterValue("hiv", "-")
        rpt1.SetParameterValue("vdrl", "-")
        rpt1.SetParameterValue("sag", "-")
        rpt1.SetParameterValue("sab", "-")
        rpt1.SetParameterValue("cab", "-")
        rpt1.SetParameterValue("igg", "-")
        rpt1.SetParameterValue("igm", "-")

        rpt1.SetParameterValue("summary", "-")

        rpt1.SetParameterValue("mercury", "-")

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class