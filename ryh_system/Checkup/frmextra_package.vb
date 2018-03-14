Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Public Class frmextra_package
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcontainer As String
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim export_id As String
    Dim id_hn As String
    Dim mysql As MySqlConnection
    Dim rpt1 As New CrystalReport1
    Dim cryRpt As New ReportDocument
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idhn As String, ByRef idexport As String)
        InitializeComponent()
        mysqlpass = mysql_pass
        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        export_id = idexport
        id_hn = idhn

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmextra_package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try

        Dim hn_start As String
        Dim hn_first As String

        hn_start = id_hn.Substring(id_hn.Length - 2)

        hn_first = Microsoft.VisualBasic.Left(id_hn, id_hn.Length - 2)
        CrystalReportViewer1.ReportSource = rpt1


        CrystalReportViewer1.Refresh()
        default_font()
        check_table()
        rpt1.SetParameterValue("sex", frmOilPackage.sex_fm)
        rpt1.SetParameterValue("test_date", frmOilPackage.date_string)
        If frmOilPackage.amphetamine.ToString.Trim = "-" Then
            rpt1.SetParameterValue("amphetamine", "ไม่ได้ตรวจ")
        Else
            rpt1.SetParameterValue("amphetamine", frmOilPackage.amphetamine)
        End If

        rpt1.SetParameterValue("blood_pressure_result", frmOilPackage.blood_pressure_result_txt)
        rpt1.SetParameterValue("eye_result_txt", frmOilPackage.eye_result_txt)

          rpt1.SetParameterValue("x_ray", frmOilPackage.result_xray)
        rpt1.SetParameterValue("id_hn", hn_first + "-" + hn_start)
        rpt1.SetParameterValue("name", frmOilPackage.name_eng + "  " + frmOilPackage.lastname_eng)
        If frmOilPackage.phy_eye_left.ToString.Trim = "-" And frmOilPackage.phy_eye_right.ToString.Trim = "-" Then
            rpt1.SetParameterValue("left_eye", "ไม่ได้ตรวจ")
            rpt1.SetParameterValue("right_eye", "")
        Else
            rpt1.SetParameterValue("left_eye", frmOilPackage.phy_eye_left)
            rpt1.SetParameterValue("right_eye", frmOilPackage.phy_eye_right)
        End If

        rpt1.SetParameterValue("pulse_rate", frmOilPackage.result_pulserate)
        rpt1.SetParameterValue("summary", frmOilPackage.result_all)
        If frmOilPackage.Stool_culture = "-" Then
            rpt1.SetParameterValue("stool_culture", "ไม่ได้ตรวจ")
        Else
            rpt1.SetParameterValue("stool_culture", "<b>" + frmOilPackage.Stool_culture + "<b>")
        End If
          
      
        rpt1.SetParameterValue("cbc_result", frmOilPackage.cbc_result)
        rpt1.SetParameterValue("urine_result", frmOilPackage.urine_result)
        If frmOilPackage.color_blind.ToString.Trim = "-" Then
            rpt1.SetParameterValue("color_blind", "ไม่ได้ตรวจ")
        Else
            rpt1.SetParameterValue("color_blind", frmOilPackage.color_blind)
        End If

        rpt1.SetParameterValue("doctor_name", frmOilPackage.doctor_name)

        rpt1.SetParameterValue("address", frmOilPackage.address)

        rpt1.SetParameterValue("tell", frmOilPackage.tellephone)

        rpt1.SetParameterValue("under", frmOilPackage.unders)

        If frmOilPackage.glass = "1" Then
            rpt1.SetParameterValue("glass_1", "<font></font>")
            rpt1.SetParameterValue("glass_2", "<p  ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.glass = "0" Then
            rpt1.SetParameterValue("glass_2", "<font></font>")
            rpt1.SetParameterValue("glass_1", "<p  ><font>&#10003;</font></p>")
        Else
            rpt1.SetParameterValue("glass_2", "<font></font>")
            rpt1.SetParameterValue("glass_1", "<font></font>")


        End If




        If id_hn <> "0" And export_id <> "0" Then
            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + id_hn + "' and checkup_export_id like '" + export_id + "' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While mySqlReader.Read()


                    rpt1.SetParameterValue("age", mySqlReader("age_y"))


                    If mySqlReader("R79") Is DBNull.Value Then
                        rpt1.SetParameterValue("blood_group", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("blood_group", "<b>" + mySqlReader("R79") + "<b>")
                    End If

                    If mySqlReader("R80") Is DBNull.Value Then
                        rpt1.SetParameterValue("blood_rh", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("blood_rh", "<b>" + mySqlReader("R80") + "<b>")

                    End If

                    If mySqlReader("R3") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_hb", "-")
                    Else
                        rpt1.SetParameterValue("cbc_hb", mySqlReader("R3"))

                    End If
                    If mySqlReader("R4") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_hct", "-")
                    Else

                        rpt1.SetParameterValue("cbc_hct", mySqlReader("R4"))

                    End If
                    If mySqlReader("R1") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_wbc", "-")
                    Else

                        rpt1.SetParameterValue("cbc_wbc", mySqlReader("R1"))
                    End If


                    If mySqlReader("R14") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_b", "-")
                    Else
                        rpt1.SetParameterValue("cbc_b", mySqlReader("R14"))
                    End If


                    If mySqlReader("R13") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_e", "-")
                    Else

                        rpt1.SetParameterValue("cbc_e", mySqlReader("R13"))
                    End If



                    If mySqlReader("R11") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_l", "-")
                    Else
                        rpt1.SetParameterValue("cbc_l", mySqlReader("R11"))
                    End If

                    If mySqlReader("R12") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_m", "-")
                    Else
                        rpt1.SetParameterValue("cbc_m", mySqlReader("R12"))
                    End If


                    If mySqlReader("R10") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_n", "-")
                    Else
                        rpt1.SetParameterValue("cbc_n", mySqlReader("R10"))
                    End If



                    ' tab3


                    If mySqlReader("R32") Is DBNull.Value Then
                        rpt1.SetParameterValue("color", "-")
                    Else
                        rpt1.SetParameterValue("color", mySqlReader("R32"))
                    End If


                    If mySqlReader("R33") Is DBNull.Value Then
                        rpt1.SetParameterValue("appearance", "-")
                    Else
                        rpt1.SetParameterValue("appearance", mySqlReader("R33"))
                    End If

                    If mySqlReader("R37") Is DBNull.Value Then
                        rpt1.SetParameterValue("glucose", "-")
                    Else
                        rpt1.SetParameterValue("glucose", mySqlReader("R37"))
                    End If


                    If mySqlReader("R41") Is DBNull.Value Then
                        rpt1.SetParameterValue("blood", "-")
                    Else
                        rpt1.SetParameterValue("blood", mySqlReader("R41"))
                    End If

                    If mySqlReader("R35") Is DBNull.Value Then
                        rpt1.SetParameterValue("ph", "-")
                    Else
                        rpt1.SetParameterValue("ph", mySqlReader("R35"))
                    End If


                    If mySqlReader("R44") Is DBNull.Value Then
                        rpt1.SetParameterValue("rbc", "-")
                    Else

                        If Trim(mySqlReader("R44")).Length <> 8 And Trim(mySqlReader("R44")).Length <> 5 Then
                            rpt1.SetParameterValue("rbc", mySqlReader("R44") + "   Cells/HP")
                        Else

                            rpt1.SetParameterValue("rbc", mySqlReader("R44"))
                        End If

                    End If



                    If mySqlReader("R45") Is DBNull.Value Then
                        rpt1.SetParameterValue("wbc_urine", "-")
                    Else
                        rpt1.SetParameterValue("wbc_urine", mySqlReader("R45"))
                    End If

                    If mySqlReader("R54") Is DBNull.Value Then
                        rpt1.SetParameterValue("fbs", "-")
                    Else
                        rpt1.SetParameterValue("fbs", mySqlReader("R54"))

                    End If


                    If mySqlReader("R46") Is DBNull.Value Then
                        rpt1.SetParameterValue("epi", "-")
                    Else
                        rpt1.SetParameterValue("epi", mySqlReader("R46"))
                    End If
                    If mySqlReader("R36") Is DBNull.Value Then
                        rpt1.SetParameterValue("albumin", "-")
                    Else
                        rpt1.SetParameterValue("albumin", mySqlReader("R36"))
                    End If
                    If mySqlReader("R34") Is DBNull.Value Then
                        rpt1.SetParameterValue("spgr", "-")
                    Else
                        rpt1.SetParameterValue("spgr", mySqlReader("R34"))
                    End If


                    'tab5
                    If mySqlReader("R55") Is DBNull.Value Then
                        rpt1.SetParameterValue("bun", "-")

                    Else
                        rpt1.SetParameterValue("bun", mySqlReader("R55"))
                    End If

                    If mySqlReader("R57") Is DBNull.Value Then
                        rpt1.SetParameterValue("cholesterol", "-")

                    Else
                        rpt1.SetParameterValue("cholesterol", mySqlReader("R57"))
                    End If

                    If mySqlReader("R56") Is DBNull.Value Then
                        rpt1.SetParameterValue("creatinine", "-")

                    Else
                        rpt1.SetParameterValue("creatinine", mySqlReader("R56"))
                    End If




                    If mySqlReader("R59") Is DBNull.Value Then
                        rpt1.SetParameterValue("hdl", "-")

                    Else
                        rpt1.SetParameterValue("hdl", mySqlReader("R59"))
                    End If



                    If mySqlReader("R58") Is DBNull.Value Then
                        rpt1.SetParameterValue("trigyceride", "-")


                    Else
                        rpt1.SetParameterValue("trigyceride", mySqlReader("R58"))
                    End If


                    If mySqlReader("R61") Is DBNull.Value Then
                        rpt1.SetParameterValue("uric_acid", "-")

                    Else
                        rpt1.SetParameterValue("uric_acid", mySqlReader("R61"))
                    End If


                    'tab6

                    If mySqlReader("R66") Is DBNull.Value Then
                        rpt1.SetParameterValue("afp", "-")

                    Else
                        rpt1.SetParameterValue("afp", mySqlReader("R66"))
                    End If

                    If mySqlReader("R62") Is DBNull.Value Then
                        rpt1.SetParameterValue("alkaline", "-")

                    Else
                        rpt1.SetParameterValue("alkaline", mySqlReader("R62"))
                    End If
                    If mySqlReader("R60") Is DBNull.Value Then
                        rpt1.SetParameterValue("ldl", "-")

                    Else
                        rpt1.SetParameterValue("ldl", mySqlReader("R60"))
                    End If
                    If mySqlReader("R70") Is DBNull.Value Then
                        rpt1.SetParameterValue("sgot", "-")

                    Else
                        rpt1.SetParameterValue("sgot", mySqlReader("R70"))
                    End If

                    If mySqlReader("R71") Is DBNull.Value Then
                        rpt1.SetParameterValue("sgpt", "-")

                    Else
                        rpt1.SetParameterValue("sgpt", mySqlReader("R71"))
                    End If


                    If mySqlReader("R77") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_wbc", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_wbc", "<b>" + mySqlReader("R77") + "<b>")
                    End If


                    If mySqlReader("R76") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_rbc", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_rbc", "<b>" + mySqlReader("R76") + "<b>")
                    End If

                    If mySqlReader("R78") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_parasite", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_parasite", "<b>" + mySqlReader("R78") + "<b>")
                    End If

                    If mySqlReader("R75") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_blood", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_blood", "<b>" + mySqlReader("R75") + "<b>")
                    End If

                    If mySqlReader("R81") Is DBNull.Value Then
                        rpt1.SetParameterValue("vdrl", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("vdrl", mySqlReader("R81"))
                    End If


                    If mySqlReader("R84") Is DBNull.Value Then
                        rpt1.SetParameterValue("hiv", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("hiv", mySqlReader("R84"))
                    End If

                    If mySqlReader("R63") Is DBNull.Value Then
                        rpt1.SetParameterValue("sag", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("sag", "<b>" + mySqlReader("R63") + "<b>")
                    End If

                    If mySqlReader("R64") Is DBNull.Value Then
                        rpt1.SetParameterValue("sab", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("sab", "<b>" + mySqlReader("R64") + "<b>")
                    End If
                    If mySqlReader("R65") Is DBNull.Value Then
                        rpt1.SetParameterValue("cea", "-")
                    Else
                        rpt1.SetParameterValue("cea", mySqlReader("R65"))
                    End If
                    If mySqlReader("R66") Is DBNull.Value Then
                        rpt1.SetParameterValue("afp", "-")
                    Else
                        rpt1.SetParameterValue("afp", mySqlReader("R66"))
                    End If


                    If mySqlReader("R83") Is DBNull.Value Then
                        rpt1.SetParameterValue("cab", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("cab", "<b>" + mySqlReader("R83") + "<b>")
                    End If

                    If mySqlReader("R67") Is DBNull.Value Then
                        rpt1.SetParameterValue("psa", "-")
                    Else
                        rpt1.SetParameterValue("psa", mySqlReader("R67"))
                    End If




                End While
                mysql.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + id_hn + "' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While mySqlReader.Read()
                    rpt1.SetParameterValue("age", mySqlReader("age_y"))


                    If mySqlReader("R79") Is DBNull.Value Then
                        rpt1.SetParameterValue("blood_group", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("blood_group", mySqlReader("R79"))
                    End If

                    If mySqlReader("R80") Is DBNull.Value Then
                        rpt1.SetParameterValue("blood_rh", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("blood_rh", mySqlReader("R80"))

                    End If

                    If mySqlReader("R3") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_hb", "-")
                    Else
                        rpt1.SetParameterValue("cbc_hb", mySqlReader("R3"))

                    End If
                    If mySqlReader("R4") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_hct", "-")
                    Else

                        rpt1.SetParameterValue("cbc_hct", mySqlReader("R4"))

                    End If
                    If mySqlReader("R1") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_wbc", "-")
                    Else

                        rpt1.SetParameterValue("cbc_wbc", mySqlReader("R1"))
                    End If


                    If mySqlReader("R14") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_b", "-")
                    Else
                        rpt1.SetParameterValue("cbc_b", mySqlReader("R14"))
                    End If


                    If mySqlReader("R13") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_e", "-")
                    Else

                        rpt1.SetParameterValue("cbc_e", mySqlReader("R13"))
                    End If



                    If mySqlReader("R11") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_l", "-")
                    Else
                        rpt1.SetParameterValue("cbc_l", mySqlReader("R11"))
                    End If

                    If mySqlReader("R12") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_m", "-")
                    Else
                        rpt1.SetParameterValue("cbc_m", mySqlReader("R12"))
                    End If


                    If mySqlReader("R10") Is DBNull.Value Then
                        rpt1.SetParameterValue("cbc_n", "-")
                    Else
                        rpt1.SetParameterValue("cbc_n", mySqlReader("R10"))
                    End If



                    ' tab3


                    If mySqlReader("R32") Is DBNull.Value Then
                        rpt1.SetParameterValue("color", "-")
                    Else
                        rpt1.SetParameterValue("color", mySqlReader("R32"))
                    End If


                    If mySqlReader("R33") Is DBNull.Value Then
                        rpt1.SetParameterValue("appearance", "-")
                    Else
                        rpt1.SetParameterValue("appearance", mySqlReader("R33"))
                    End If

                    If mySqlReader("R37") Is DBNull.Value Then
                        rpt1.SetParameterValue("glucose", "-")
                    Else
                        rpt1.SetParameterValue("glucose", mySqlReader("R37"))
                    End If


                    If mySqlReader("R41") Is DBNull.Value Then
                        rpt1.SetParameterValue("blood", "-")
                    Else
                        rpt1.SetParameterValue("blood", mySqlReader("R41"))
                    End If

                    If mySqlReader("R35") Is DBNull.Value Then
                        rpt1.SetParameterValue("ph", "-")
                    Else
                        rpt1.SetParameterValue("ph", mySqlReader("R35"))
                    End If


                    If mySqlReader("R44") Is DBNull.Value Then
                        rpt1.SetParameterValue("rbc", "-")
                    Else

                        If Trim(mySqlReader("R44")).Length <> 8 And Trim(mySqlReader("R44")).Length <> 5 Then
                            rpt1.SetParameterValue("rbc", mySqlReader("R44") + "   Cells/HP")
                        Else

                            rpt1.SetParameterValue("rbc", mySqlReader("R44"))
                        End If

                    End If



                    If mySqlReader("R45") Is DBNull.Value Then
                        rpt1.SetParameterValue("wbc_urine", "-")
                    Else
                        rpt1.SetParameterValue("wbc_urine", mySqlReader("R45"))
                    End If

                    If mySqlReader("R54") Is DBNull.Value Then
                        rpt1.SetParameterValue("fbs", "-")
                    Else
                        rpt1.SetParameterValue("fbs", mySqlReader("R54"))

                    End If


                    If mySqlReader("R46") Is DBNull.Value Then
                        rpt1.SetParameterValue("epi", "-")
                    Else
                        rpt1.SetParameterValue("epi", mySqlReader("R46"))
                    End If
                    If mySqlReader("R36") Is DBNull.Value Then
                        rpt1.SetParameterValue("albumin", "-")
                    Else
                        rpt1.SetParameterValue("albumin", mySqlReader("R36"))
                    End If
                    If mySqlReader("R34") Is DBNull.Value Then
                        rpt1.SetParameterValue("spgr", "-")
                    Else
                        rpt1.SetParameterValue("spgr", mySqlReader("R34"))
                    End If


                    'tab5
                    If mySqlReader("R55") Is DBNull.Value Then
                        rpt1.SetParameterValue("bun", "-")

                    Else
                        rpt1.SetParameterValue("bun", mySqlReader("R55"))
                    End If

                    If mySqlReader("R57") Is DBNull.Value Then
                        rpt1.SetParameterValue("cholesterol", "-")

                    Else
                        rpt1.SetParameterValue("cholesterol", mySqlReader("R57"))
                    End If

                    If mySqlReader("R56") Is DBNull.Value Then
                        rpt1.SetParameterValue("creatinine", "-")

                    Else
                        rpt1.SetParameterValue("creatinine", mySqlReader("R56"))
                    End If




                    If mySqlReader("R59") Is DBNull.Value Then
                        rpt1.SetParameterValue("hdl", "-")

                    Else
                        rpt1.SetParameterValue("hdl", mySqlReader("R59"))
                    End If



                    If mySqlReader("R58") Is DBNull.Value Then
                        rpt1.SetParameterValue("trigyceride", "-")


                    Else
                        rpt1.SetParameterValue("trigyceride", mySqlReader("R58"))
                    End If


                    If mySqlReader("R61") Is DBNull.Value Then
                        rpt1.SetParameterValue("uric_acid", "-")

                    Else
                        rpt1.SetParameterValue("uric_acid", mySqlReader("R61"))
                    End If


                    'tab6

                    If mySqlReader("R66") Is DBNull.Value Then
                        rpt1.SetParameterValue("afp", "-")

                    Else
                        rpt1.SetParameterValue("afp", mySqlReader("R66"))
                    End If

                    If mySqlReader("R62") Is DBNull.Value Then
                        rpt1.SetParameterValue("alkaline", "-")

                    Else
                        rpt1.SetParameterValue("alkaline", mySqlReader("R62"))
                    End If
                    If mySqlReader("R60") Is DBNull.Value Then
                        rpt1.SetParameterValue("ldl", "-")

                    Else
                        rpt1.SetParameterValue("ldl", mySqlReader("R60"))
                    End If
                    If mySqlReader("R70") Is DBNull.Value Then
                        rpt1.SetParameterValue("sgot", "-")

                    Else
                        rpt1.SetParameterValue("sgot", mySqlReader("R70"))
                    End If

                    If mySqlReader("R71") Is DBNull.Value Then
                        rpt1.SetParameterValue("sgpt", "-")

                    Else
                        rpt1.SetParameterValue("sgpt", mySqlReader("R71"))
                    End If



                    If mySqlReader("R77") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_wbc", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_wbc", "<b>" + mySqlReader("R77") + "<b>")
                    End If


                    If mySqlReader("R76") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_rbc", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_rbc", "<b>" + mySqlReader("R76") + "<b>")
                    End If

                    If mySqlReader("R78") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_parasite", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_parasite", "<b>" + mySqlReader("R78") + "<b>")
                    End If

                    If mySqlReader("R75") Is DBNull.Value Then
                        rpt1.SetParameterValue("stool_blood", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("stool_blood", "<b>" + mySqlReader("R75") + "<b>")
                    End If

                    If mySqlReader("R81") Is DBNull.Value Then
                        rpt1.SetParameterValue("vdrl", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("vdrl", mySqlReader("R81"))
                    End If


                    If mySqlReader("R84") Is DBNull.Value Then
                        rpt1.SetParameterValue("hiv", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("hiv", mySqlReader("R84"))
                    End If

                    If mySqlReader("R63") Is DBNull.Value Then
                        rpt1.SetParameterValue("sag", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("sag", "<b>" + mySqlReader("R63") + "<b>")
                    End If

                    If mySqlReader("R64") Is DBNull.Value Then
                        rpt1.SetParameterValue("sab", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("sab", "<b>" + mySqlReader("R64") + "<b>")
                    End If
                    If mySqlReader("R65") Is DBNull.Value Then
                        rpt1.SetParameterValue("cea", "-")
                    Else
                        rpt1.SetParameterValue("cea", mySqlReader("R65"))
                    End If
                    If mySqlReader("R66") Is DBNull.Value Then
                        rpt1.SetParameterValue("afp", "-")
                    Else
                        rpt1.SetParameterValue("afp", mySqlReader("R66"))
                    End If


                    If mySqlReader("R83") Is DBNull.Value Then
                        rpt1.SetParameterValue("cab", "ไม่ได้ตรวจ")
                    Else
                        rpt1.SetParameterValue("cab", "<b>" + mySqlReader("R83") + "<b>")
                    End If

                    If mySqlReader("R67") Is DBNull.Value Then
                        rpt1.SetParameterValue("psa", "-")
                    Else
                        rpt1.SetParameterValue("psa", mySqlReader("R67"))
                    End If




                End While
                mysql.Close()



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        End If

    End Sub
    Public Sub default_font()
        rpt1.SetParameterValue("id_hn", "-")
        rpt1.SetParameterValue("stool_culture", " ")
        rpt1.SetParameterValue("name", "-")

        rpt1.SetParameterValue("test_date", "-")
        rpt1.SetParameterValue("age", "-")
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
        rpt1.SetParameterValue("sag", "ไม่ได้ตรวจ")
        rpt1.SetParameterValue("sab", "ไม่ได้ตรวจ")
        rpt1.SetParameterValue("cab", "ไม่ได้ตรวจ")
        rpt1.SetParameterValue("igg", "ไม่ได้ตรวจ")
        rpt1.SetParameterValue("igm", "ไม่ได้ตรวจ")

        rpt1.SetParameterValue("summary", "-")

        rpt1.SetParameterValue("mercury", "-")

    End Sub
    Public Sub check_table()





        rpt1.SetParameterValue("company_name", frmOilPackage.company_name)
        rpt1.SetParameterValue("height", frmOilPackage.phy_height)
        rpt1.SetParameterValue("weight", frmOilPackage.phy_weight)
        rpt1.SetParameterValue("pulse", frmOilPackage.phy_pulse)
        rpt1.SetParameterValue("blood_pressure", frmOilPackage.phy_bloodpressure)
        rpt1.SetParameterValue("eye_right", frmOilPackage.phy_eye_right)
        rpt1.SetParameterValue("eye_left", frmOilPackage.phy_eye_left)
        rpt1.SetParameterValue("mercury", frmOilPackage.mercury)
        rpt1.SetParameterValue("bmi", frmOilPackage.bmi)
        rpt1.SetParameterValue("cea", frmOilPackage.cea)

        rpt1.SetParameterValue("igg", frmOilPackage.igg)
        rpt1.SetParameterValue("igm", frmOilPackage.igm)




        If frmOilPackage.r_eye = "Normal" Then
            rpt1.SetParameterValue("eye_n", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("eye_ab", "<font></font>")
        ElseIf frmOilPackage.r_eye = "Abnormal" Then

            rpt1.SetParameterValue("eye_n", "<font></font>")

            rpt1.SetParameterValue("eye_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.r_eye = "NoData" Then
            rpt1.SetParameterValue("eye_n", "<p align='center' ><font>-</font></p>")

            rpt1.SetParameterValue("eye_ab", "<p align='center' ><font>-</font></p>")
        End If


        If frmOilPackage.neck = "Normal" Then
            rpt1.SetParameterValue("neck_n", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("neck_ab", "")
        ElseIf frmOilPackage.neck = "Abnormal" Then
            rpt1.SetParameterValue("neck_n", "")
            rpt1.SetParameterValue("neck_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.neck = "NoData" Then
            rpt1.SetParameterValue("neck_n", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("neck_ab", "<p align='center' ><font>-</font></p>")
        End If


        If frmOilPackage.heart = "Normal" Then
            rpt1.SetParameterValue("heart_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("heat_ab", "")
        ElseIf frmOilPackage.heart = "Abnormal" Then
            rpt1.SetParameterValue("heart_a", "")
            rpt1.SetParameterValue("heat_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.heart = "NoData" Then
            rpt1.SetParameterValue("heart_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("heat_ab", "<p align='center' ><font>-</font></p>")
        End If


        If frmOilPackage.vas = "Normal" Then
            rpt1.SetParameterValue("vac_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("vac_ab", "")
        ElseIf frmOilPackage.vas = "Abnormal" Then
            rpt1.SetParameterValue("vac_a", "")
            rpt1.SetParameterValue("vac_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.vas = "NoData" Then
            rpt1.SetParameterValue("vac_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("vac_ab", "<p align='center' ><font>-</font></p>")
        End If


        If frmOilPackage.chest = "Normal" Then
            rpt1.SetParameterValue("lungs_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("lungs_ab", "")
        ElseIf frmOilPackage.chest = "Abnormal" Then
            rpt1.SetParameterValue("lungs_a", "")
            rpt1.SetParameterValue("lungs_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.chest = "NoData" Then
            rpt1.SetParameterValue("lungs_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("lungs_ab", "<p align='center' ><font>-</font></p>")
        End If

        If frmOilPackage.ab = "Normal" Then
            rpt1.SetParameterValue("ab_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("ab_ab", "")
        ElseIf frmOilPackage.ab = "Abnormal" Then
            rpt1.SetParameterValue("ab_a", "")
            rpt1.SetParameterValue("ab_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.ab = "NoData" Then
            rpt1.SetParameterValue("ab_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("ab_ab", "<p align='center' ><font>-</font></p>")
        End If

        If frmOilPackage.lymp = "Normal" Then
            rpt1.SetParameterValue("lym_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("lym_ab", "")
        ElseIf frmOilPackage.lymp = "Abnormal" Then
            rpt1.SetParameterValue("lym_a", "")
            rpt1.SetParameterValue("lym_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.lymp = "NoData" Then
            rpt1.SetParameterValue("lym_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("lym_ab", "<p align='center' ><font>-</font></p>")
        End If

        If frmOilPackage.gu = "Normal" Then
            rpt1.SetParameterValue("gu_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("gu_ab", "")
        ElseIf frmOilPackage.gu = "Abnormal" Then
            rpt1.SetParameterValue("gu_a", "")
            rpt1.SetParameterValue("gu_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.gu = "NoData" Then
            rpt1.SetParameterValue("gu_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("gu_ab", "<p align='center' ><font>-</font></p>")
        End If


        If frmOilPackage.ex = "Normal" Then
            rpt1.SetParameterValue("ex_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("ex_ab", "")
        ElseIf frmOilPackage.ex = "Abnormal" Then
            rpt1.SetParameterValue("ex_a", "")
            rpt1.SetParameterValue("ex_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.ex = "NoData" Then
            rpt1.SetParameterValue("ex_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("ex_ab", "<p align='center' ><font>-</font></p>")
        End If

        If frmOilPackage.spine = "Normal" Then
            rpt1.SetParameterValue("spine_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("spine_ab", "")
        ElseIf frmOilPackage.spine = "Abnormal" Then
            rpt1.SetParameterValue("spine_a", "")
            rpt1.SetParameterValue("spine_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.spine = "NoData" Then
            rpt1.SetParameterValue("spine_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("spine_ab", "<p align='center' ><font>-</font></p>")
        End If



        If frmOilPackage.skins = "Normal" Then
            rpt1.SetParameterValue("skin_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("skin_ab", "")
        ElseIf frmOilPackage.skins = "Abnormal" Then
            rpt1.SetParameterValue("skin_a", "")
            rpt1.SetParameterValue("skin_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.skins = "NoData" Then
            rpt1.SetParameterValue("skin_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("skin_ab", "<p align='center' ><font>-</font></p>")
        End If



        If frmOilPackage.audio = "Normal" Then
            rpt1.SetParameterValue("audio_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("audio_ab", "")
        ElseIf frmOilPackage.audio = "Abnormal" Then
            rpt1.SetParameterValue("audio_a", "")
            rpt1.SetParameterValue("audio_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.audio = "NoData" Then
            rpt1.SetParameterValue("audio_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("audio_ab", "<p align='center' ><font>-</font></p>")
        End If



        If frmOilPackage.lung = "Normal" Then
            rpt1.SetParameterValue("lung_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("lung_ab", "")
        ElseIf frmOilPackage.lung = "Abnormal" Then
            rpt1.SetParameterValue("lung_a", "")
            rpt1.SetParameterValue("lung_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.lung = "NoData" Then
            rpt1.SetParameterValue("lung_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("lung_ab", "<p align='center' ><font>-</font></p>")
        End If


        If frmOilPackage.ekg = "Normal" Then
            rpt1.SetParameterValue("ekg_a", "<p align='center' ><font>&#10003;</font></p>")
            rpt1.SetParameterValue("ekg_ab", "")
        ElseIf frmOilPackage.ekg = "Abnormal" Then
            rpt1.SetParameterValue("ekg_a ", "")
            rpt1.SetParameterValue("ekg_ab", "<p align='center' ><font>&#10003;</font></p>")
        ElseIf frmOilPackage.ekg = "NoData" Then
            rpt1.SetParameterValue("ekg_a", "<p align='center' ><font>-</font></p>")
            rpt1.SetParameterValue("ekg_ab", "<p align='center' ><font>-</font></p>")
        End If








    End Sub
End Class