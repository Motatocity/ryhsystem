Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Public Class prnOilPackage
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
    Dim rpt1 As New reportOilCompany
    Dim rpt2 As New reportOilCompany_2
    Dim newReport_oil As Boolean
    Dim cryRpt As New ReportDocument

    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idhn As String, ByRef idexport As String, Optional newReport As Boolean = False)
        InitializeComponent()
        mysqlpass = mysql_pass
        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        export_id = idexport
        id_hn = idhn
        newReport_oil = newReport
    End Sub

    Private Sub prnOilPackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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



        If newReport_oil = False Then
            CrystalReportViewer2.ReportSource = rpt1
            CrystalReportViewer2.Refresh()
            default_font()
            check_table()
            rpt1.SetParameterValue("datenow", frmOilPackage.datetime)
            rpt1.SetParameterValue("date_exam", frmOilPackage.date_string)
            rpt1.SetParameterValue("amphetamine", frmOilPackage.amphetamine)
            rpt1.SetParameterValue("x_ray", frmOilPackage.result_xray)
            rpt1.SetParameterValue("hn", hn_first + "-" + hn_start)
            rpt1.SetParameterValue("name", frmOilPackage.name_eng)
            rpt1.SetParameterValue("lastname", frmOilPackage.lastname_eng)

            rpt1.SetParameterValue("vir_total", frmOilPackage.vir_total)


            rpt1.SetParameterValue("other_fit", frmOilPackage.other_fit)
            rpt1.SetParameterValue("summary", frmOilPackage.result_all)
            rpt1.SetParameterValue("stool_culture", frmOilPackage.Stool_culture)
            rpt1.SetParameterValue("color_blind", frmOilPackage.color_blind)

            rpt1.SetParameterValue("doctor_name", frmOilPackage.doctor_name)
            rpt1.SetParameterValue("license", frmOilPackage.license)
            rpt1.SetParameterValue("name_lastname", frmOilPackage.name_lastname)
            If frmOilPackage.checkaddress = True Then
                rpt1.SetParameterValue("address", "Address( ที่อยู่ ) " + frmOilPackage.address)
            Else
                rpt1.SetParameterValue("address", "")

            End If
            If frmOilPackage.glass = "1" Then
                rpt1.SetParameterValue("glass_1", "<font></font>")
                rpt1.SetParameterValue("glass_2", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.glass = "0" Then
                rpt1.SetParameterValue("glass_2", "<font></font>")
                rpt1.SetParameterValue("glass_1", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.glass = "3" Then
                rpt1.SetParameterValue("glass_2", "<font></font>")
                rpt1.SetParameterValue("glass_1", "<font></font>")
            End If

            If frmOilPackage.fit_check = "1" Then
                rpt1.SetParameterValue("3", "<font>___</font>")
                rpt1.SetParameterValue("2", "<font>___</font>")
                rpt1.SetParameterValue("1", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fit_check = "2" Then
                rpt1.SetParameterValue("3", "<font>___</font>")
                rpt1.SetParameterValue("2", "<p align='center' ><font>&#10003;</font></p>")
                rpt1.SetParameterValue("1", "<font>___</font>")
            ElseIf frmOilPackage.fit_check = "3" Then
                rpt1.SetParameterValue("2", "<font>___</font>")
                rpt1.SetParameterValue("3", "<p align='center' ><font>&#10003;</font></p>")
                rpt1.SetParameterValue("1", "<font>___</font>")
            End If


            If frmOilPackage.spec = "1" Then
                rpt1.SetParameterValue("8", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.spec = "0" Then
                rpt1.SetParameterValue("8", "<font>___</font>")
            End If

            If frmOilPackage.fitair = "1" Then
                rpt1.SetParameterValue("4", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitair = "0" Then
                rpt1.SetParameterValue("4", "<font>___</font>")
            End If


            If frmOilPackage.fitbreath = "1" Then
                rpt1.SetParameterValue("5", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitbreath = "0" Then
                rpt1.SetParameterValue("5", "<font>___</font>")
            End If

            If frmOilPackage.fitcrance = "1" Then
                rpt1.SetParameterValue("9", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitcrance = "0" Then
                rpt1.SetParameterValue("9", "<font>___</font>")
            End If

            If frmOilPackage.fitemergency = "1" Then
                rpt1.SetParameterValue("6", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitemergency = "0" Then
                rpt1.SetParameterValue("6", "<font>___</font>")
            End If
            If frmOilPackage.fitfood = "1" Then
                rpt1.SetParameterValue("7", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitfood = "0" Then
                rpt1.SetParameterValue("7", "<font>___</font>")
            End If

        Else
            CrystalReportViewer2.ReportSource = rpt2
            CrystalReportViewer2.Refresh()
            default_font()
            check_table()
            rpt2.SetParameterValue("datenow", frmOilPackage.datetime)
            rpt2.SetParameterValue("date_exam", frmOilPackage.date_string)
            rpt2.SetParameterValue("amphetamine", frmOilPackage.amphetamine)
            rpt2.SetParameterValue("x_ray", frmOilPackage.result_xray)
            rpt2.SetParameterValue("hn", hn_first + "-" + hn_start)
            rpt2.SetParameterValue("name", frmOilPackage.name_eng)
            rpt2.SetParameterValue("lastname", frmOilPackage.lastname_eng)

            rpt2.SetParameterValue("vir_total", frmOilPackage.vir_total)


            rpt2.SetParameterValue("other_fit", frmOilPackage.other_fit)
            rpt2.SetParameterValue("summary", frmOilPackage.result_all)
            rpt2.SetParameterValue("stool_culture", frmOilPackage.Stool_culture)
            rpt2.SetParameterValue("color_blind", frmOilPackage.color_blind)

            rpt2.SetParameterValue("doctor_name", frmOilPackage.doctor_name)
            rpt2.SetParameterValue("license", frmOilPackage.license)
            rpt2.SetParameterValue("name_lastname", frmOilPackage.name_lastname)
            If frmOilPackage.checkaddress = True Then
                rpt2.SetParameterValue("address", "Address( ที่อยู่ ) " + frmOilPackage.address)
            Else
                rpt2.SetParameterValue("address", "")

            End If
            If frmOilPackage.glass = "1" Then
                rpt2.SetParameterValue("glass_1", "<font></font>")
                rpt2.SetParameterValue("glass_2", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.glass = "0" Then
                rpt2.SetParameterValue("glass_2", "<font></font>")
                rpt2.SetParameterValue("glass_1", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.glass = "3" Then
                rpt2.SetParameterValue("glass_2", "<font></font>")
                rpt2.SetParameterValue("glass_1", "<font></font>")
            End If

            If frmOilPackage.fit_check = "1" Then
                rpt2.SetParameterValue("3", "<font>___</font>")
                rpt2.SetParameterValue("2", "<font>___</font>")
                rpt2.SetParameterValue("1", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fit_check = "2" Then
                rpt2.SetParameterValue("3", "<font>___</font>")
                rpt2.SetParameterValue("2", "<p align='center' ><font>&#10003;</font></p>")
                rpt2.SetParameterValue("1", "<font>___</font>")
            ElseIf frmOilPackage.fit_check = "3" Then
                rpt2.SetParameterValue("2", "<font>___</font>")
                rpt2.SetParameterValue("3", "<p align='center' ><font>&#10003;</font></p>")
                rpt2.SetParameterValue("1", "<font>___</font>")
            End If


            If frmOilPackage.spec = "1" Then
                rpt2.SetParameterValue("8", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.spec = "0" Then
                rpt2.SetParameterValue("8", "<font>___</font>")
            End If

            If frmOilPackage.fitair = "1" Then
                rpt2.SetParameterValue("4", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitair = "0" Then
                rpt2.SetParameterValue("4", "<font>___</font>")
            End If


            If frmOilPackage.fitbreath = "1" Then
                rpt2.SetParameterValue("5", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitbreath = "0" Then
                rpt2.SetParameterValue("5", "<font>___</font>")
            End If

            If frmOilPackage.fitcrance = "1" Then
                rpt2.SetParameterValue("9", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitcrance = "0" Then
                rpt2.SetParameterValue("9", "<font>___</font>")
            End If

            If frmOilPackage.fitemergency = "1" Then
                rpt2.SetParameterValue("6", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitemergency = "0" Then
                rpt2.SetParameterValue("6", "<font>___</font>")
            End If
            If frmOilPackage.fitfood = "1" Then
                rpt2.SetParameterValue("7", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.fitfood = "0" Then
                rpt2.SetParameterValue("7", "<font>___</font>")
            End If

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
                    If newReport_oil = False Then


                        rpt1.SetParameterValue("age", mySqlReader("age_y"))


                        If mySqlReader("R79") Is DBNull.Value Then
                            rpt1.SetParameterValue("blood_group", "-")
                        Else
                            rpt1.SetParameterValue("blood_group", mySqlReader("R79"))
                        End If

                        If mySqlReader("R80") Is DBNull.Value Then
                            rpt1.SetParameterValue("blood_rh", "-")
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
                            rpt1.SetParameterValue("stool_wbc", "-")
                        Else
                            rpt1.SetParameterValue("stool_wbc", mySqlReader("R77"))
                        End If

                        If mySqlReader("R76") Is DBNull.Value Then
                            rpt1.SetParameterValue("stool_rbc", "-")
                        Else
                            rpt1.SetParameterValue("stool_rbc", mySqlReader("R76"))
                        End If

                        If mySqlReader("R78") Is DBNull.Value Then
                            rpt1.SetParameterValue("stool_parasite", "-")
                        Else
                            rpt1.SetParameterValue("stool_parasite", mySqlReader("R78"))
                        End If

                        If mySqlReader("R75") Is DBNull.Value Then
                            rpt1.SetParameterValue("stool_blood", "-")
                        Else
                            rpt1.SetParameterValue("stool_blood", mySqlReader("R75"))
                        End If

                        If mySqlReader("R81") Is DBNull.Value Then
                            rpt1.SetParameterValue("vdrl", "-")
                        Else
                            rpt1.SetParameterValue("vdrl", mySqlReader("R81"))
                        End If


                        If mySqlReader("R84") Is DBNull.Value Then
                            rpt1.SetParameterValue("hiv", "-")
                        Else
                            rpt1.SetParameterValue("hiv", mySqlReader("R84"))
                        End If

                        If mySqlReader("R63") Is DBNull.Value Then
                            rpt1.SetParameterValue("sag", "-")
                        Else
                            rpt1.SetParameterValue("sag", mySqlReader("R63"))
                        End If

                        If mySqlReader("R64") Is DBNull.Value Then
                            rpt1.SetParameterValue("sab", "-")
                        Else
                            rpt1.SetParameterValue("sab", mySqlReader("R64"))
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
                            rpt1.SetParameterValue("cab", "-")
                        Else
                            rpt1.SetParameterValue("cab", mySqlReader("R83"))
                        End If

                        If mySqlReader("R67") Is DBNull.Value Then
                            rpt1.SetParameterValue("psa", "-")
                        Else
                            rpt1.SetParameterValue("psa", mySqlReader("R67"))
                        End If



                    Else


                        rpt2.SetParameterValue("age", mySqlReader("age_y"))


                        If mySqlReader("R79") Is DBNull.Value Then
                            rpt2.SetParameterValue("blood_group", "-")
                        Else
                            rpt2.SetParameterValue("blood_group", mySqlReader("R79"))
                        End If

                        If mySqlReader("R80") Is DBNull.Value Then
                            rpt2.SetParameterValue("blood_rh", "-")
                        Else
                            rpt2.SetParameterValue("blood_rh", mySqlReader("R80"))

                        End If

                        If mySqlReader("R3") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_hb", "-")
                        Else
                            rpt2.SetParameterValue("cbc_hb", mySqlReader("R3"))

                        End If
                        If mySqlReader("R4") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_hct", "-")
                        Else

                            rpt2.SetParameterValue("cbc_hct", mySqlReader("R4"))

                        End If
                        If mySqlReader("R1") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_wbc", "-")
                        Else

                            rpt2.SetParameterValue("cbc_wbc", mySqlReader("R1"))
                        End If


                        If mySqlReader("R14") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_b", "-")
                        Else
                            rpt2.SetParameterValue("cbc_b", mySqlReader("R14"))
                        End If


                        If mySqlReader("R13") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_e", "-")
                        Else

                            rpt2.SetParameterValue("cbc_e", mySqlReader("R13"))
                        End If



                        If mySqlReader("R11") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_l", "-")
                        Else
                            rpt2.SetParameterValue("cbc_l", mySqlReader("R11"))
                        End If

                        If mySqlReader("R12") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_m", "-")
                        Else
                            rpt2.SetParameterValue("cbc_m", mySqlReader("R12"))
                        End If


                        If mySqlReader("R10") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_n", "-")
                        Else
                            rpt2.SetParameterValue("cbc_n", mySqlReader("R10"))
                        End If



                        ' tab3


                        If mySqlReader("R32") Is DBNull.Value Then
                            rpt2.SetParameterValue("color", "-")
                        Else
                            rpt2.SetParameterValue("color", mySqlReader("R32"))
                        End If


                        If mySqlReader("R33") Is DBNull.Value Then
                            rpt2.SetParameterValue("appearance", "-")
                        Else
                            rpt2.SetParameterValue("appearance", mySqlReader("R33"))
                        End If

                        If mySqlReader("R37") Is DBNull.Value Then
                            rpt2.SetParameterValue("glucose", "-")
                        Else
                            rpt2.SetParameterValue("glucose", mySqlReader("R37"))
                        End If


                        If mySqlReader("R41") Is DBNull.Value Then
                            rpt2.SetParameterValue("blood", "-")
                        Else
                            rpt2.SetParameterValue("blood", mySqlReader("R41"))
                        End If

                        If mySqlReader("R35") Is DBNull.Value Then
                            rpt2.SetParameterValue("ph", "-")
                        Else
                            rpt2.SetParameterValue("ph", mySqlReader("R35"))
                        End If


                        If mySqlReader("R44") Is DBNull.Value Then
                            rpt2.SetParameterValue("rbc", "-")
                        Else

                            If Trim(mySqlReader("R44")).Length <> 8 And Trim(mySqlReader("R44")).Length <> 5 Then
                                rpt2.SetParameterValue("rbc", mySqlReader("R44") + "   Cells/HP")
                            Else

                                rpt2.SetParameterValue("rbc", mySqlReader("R44"))
                            End If

                        End If



                        If mySqlReader("R45") Is DBNull.Value Then
                            rpt2.SetParameterValue("wbc_urine", "-")
                        Else
                            rpt2.SetParameterValue("wbc_urine", mySqlReader("R45"))
                        End If

                        If mySqlReader("R54") Is DBNull.Value Then
                            rpt2.SetParameterValue("fbs", "-")
                        Else
                            rpt2.SetParameterValue("fbs", mySqlReader("R54"))

                        End If


                        If mySqlReader("R46") Is DBNull.Value Then
                            rpt2.SetParameterValue("epi", "-")
                        Else
                            rpt2.SetParameterValue("epi", mySqlReader("R46"))
                        End If
                        If mySqlReader("R36") Is DBNull.Value Then
                            rpt2.SetParameterValue("albumin", "-")
                        Else
                            rpt2.SetParameterValue("albumin", mySqlReader("R36"))
                        End If
                        If mySqlReader("R34") Is DBNull.Value Then
                            rpt2.SetParameterValue("spgr", "-")
                        Else
                            rpt2.SetParameterValue("spgr", mySqlReader("R34"))
                        End If


                        'tab5
                        If mySqlReader("R55") Is DBNull.Value Then
                            rpt2.SetParameterValue("bun", "-")

                        Else
                            rpt2.SetParameterValue("bun", mySqlReader("R55"))
                        End If

                        If mySqlReader("R57") Is DBNull.Value Then
                            rpt2.SetParameterValue("cholesterol", "-")

                        Else
                            rpt2.SetParameterValue("cholesterol", mySqlReader("R57"))
                        End If

                        If mySqlReader("R56") Is DBNull.Value Then
                            rpt2.SetParameterValue("creatinine", "-")

                        Else
                            rpt2.SetParameterValue("creatinine", mySqlReader("R56"))
                        End If




                        If mySqlReader("R59") Is DBNull.Value Then
                            rpt2.SetParameterValue("hdl", "-")

                        Else
                            rpt2.SetParameterValue("hdl", mySqlReader("R59"))
                        End If



                        If mySqlReader("R58") Is DBNull.Value Then
                            rpt2.SetParameterValue("trigyceride", "-")


                        Else
                            rpt2.SetParameterValue("trigyceride", mySqlReader("R58"))
                        End If


                        If mySqlReader("R61") Is DBNull.Value Then
                            rpt2.SetParameterValue("uric_acid", "-")

                        Else
                            rpt2.SetParameterValue("uric_acid", mySqlReader("R61"))
                        End If


                        'tab6

                        If mySqlReader("R66") Is DBNull.Value Then
                            rpt2.SetParameterValue("afp", "-")

                        Else
                            rpt2.SetParameterValue("afp", mySqlReader("R66"))
                        End If

                        If mySqlReader("R62") Is DBNull.Value Then
                            rpt2.SetParameterValue("alkaline", "-")

                        Else
                            rpt2.SetParameterValue("alkaline", mySqlReader("R62"))
                        End If
                        If mySqlReader("R60") Is DBNull.Value Then
                            rpt2.SetParameterValue("ldl", "-")

                        Else
                            rpt2.SetParameterValue("ldl", mySqlReader("R60"))
                        End If
                        If mySqlReader("R70") Is DBNull.Value Then
                            rpt2.SetParameterValue("sgot", "-")

                        Else
                            rpt2.SetParameterValue("sgot", mySqlReader("R70"))
                        End If

                        If mySqlReader("R71") Is DBNull.Value Then
                            rpt2.SetParameterValue("sgpt", "-")

                        Else
                            rpt2.SetParameterValue("sgpt", mySqlReader("R71"))
                        End If


                        If mySqlReader("R77") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_wbc", "-")
                        Else
                            rpt2.SetParameterValue("stool_wbc", mySqlReader("R77"))
                        End If

                        If mySqlReader("R76") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_rbc", "-")
                        Else
                            rpt2.SetParameterValue("stool_rbc", mySqlReader("R76"))
                        End If

                        If mySqlReader("R78") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_parasite", "-")
                        Else
                            rpt2.SetParameterValue("stool_parasite", mySqlReader("R78"))
                        End If

                        If mySqlReader("R75") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_blood", "-")
                        Else
                            rpt2.SetParameterValue("stool_blood", mySqlReader("R75"))
                        End If

                        If mySqlReader("R81") Is DBNull.Value Then
                            rpt2.SetParameterValue("vdrl", "-")
                        Else
                            rpt2.SetParameterValue("vdrl", mySqlReader("R81"))
                        End If


                        If mySqlReader("R84") Is DBNull.Value Then
                            rpt2.SetParameterValue("hiv", "-")
                        Else
                            rpt2.SetParameterValue("hiv", mySqlReader("R84"))
                        End If

                        If mySqlReader("R63") Is DBNull.Value Then
                            rpt2.SetParameterValue("sag", "-")
                        Else
                            rpt2.SetParameterValue("sag", mySqlReader("R63"))
                        End If

                        If mySqlReader("R64") Is DBNull.Value Then
                            rpt2.SetParameterValue("sab", "-")
                        Else
                            rpt2.SetParameterValue("sab", mySqlReader("R64"))
                        End If
                        If mySqlReader("R65") Is DBNull.Value Then
                            rpt2.SetParameterValue("cea", "-")
                        Else
                            rpt2.SetParameterValue("cea", mySqlReader("R65"))
                        End If
                        If mySqlReader("R66") Is DBNull.Value Then
                            rpt2.SetParameterValue("afp", "-")
                        Else
                            rpt2.SetParameterValue("afp", mySqlReader("R66"))
                        End If


                        If mySqlReader("R83") Is DBNull.Value Then
                            rpt2.SetParameterValue("cab", "-")
                        Else
                            rpt2.SetParameterValue("cab", mySqlReader("R83"))
                        End If

                        If mySqlReader("R67") Is DBNull.Value Then
                            rpt2.SetParameterValue("psa", "-")
                        Else
                            rpt2.SetParameterValue("psa", mySqlReader("R67"))
                        End If



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

                    If newReport_oil = False Then
                        rpt1.SetParameterValue("age", mySqlReader("age_y"))


                        If mySqlReader("R79") Is DBNull.Value Then
                            rpt1.SetParameterValue("blood_group", "-")
                        Else
                            rpt1.SetParameterValue("blood_group", mySqlReader("R79"))
                        End If

                        If mySqlReader("R80") Is DBNull.Value Then
                            rpt1.SetParameterValue("blood_rh", "-")
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
                                rpt1.SetParameterValue("rbc", mySqlReader("R44") + " Cells/HP")
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
                            rpt1.SetParameterValue("stool_wbc", "-")
                        Else
                            rpt1.SetParameterValue("stool_wbc", mySqlReader("R77"))
                        End If

                        If mySqlReader("R76") Is DBNull.Value Then
                            rpt1.SetParameterValue("stool_rbc", "-")
                        Else
                            rpt1.SetParameterValue("stool_rbc", mySqlReader("R76"))
                        End If

                        If mySqlReader("R78") Is DBNull.Value Then
                            rpt1.SetParameterValue("stool_parasite", "-")
                        Else
                            rpt1.SetParameterValue("stool_parasite", mySqlReader("R78"))
                        End If

                        If mySqlReader("R75") Is DBNull.Value Then
                            rpt1.SetParameterValue("stool_blood", "-")
                        Else
                            rpt1.SetParameterValue("stool_blood", mySqlReader("R75"))
                        End If

                        If mySqlReader("R81") Is DBNull.Value Then
                            rpt1.SetParameterValue("vdrl", "-")
                        Else
                            rpt1.SetParameterValue("vdrl", mySqlReader("R81"))
                        End If


                        If mySqlReader("R84") Is DBNull.Value Then
                            rpt1.SetParameterValue("hiv", "-")
                        Else
                            rpt1.SetParameterValue("hiv", mySqlReader("R84"))
                        End If

                        If mySqlReader("R63") Is DBNull.Value Then
                            rpt1.SetParameterValue("sag", "-")
                        Else
                            rpt1.SetParameterValue("sag", mySqlReader("R63"))
                        End If

                        If mySqlReader("R64") Is DBNull.Value Then
                            rpt1.SetParameterValue("sab", "-")
                        Else
                            rpt1.SetParameterValue("sab", mySqlReader("R64"))
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
                            rpt1.SetParameterValue("cab", "-")
                        Else
                            rpt1.SetParameterValue("cab", mySqlReader("R83"))
                        End If

                        If mySqlReader("R67") Is DBNull.Value Then
                            rpt1.SetParameterValue("psa", "-")
                        Else
                            rpt1.SetParameterValue("psa", mySqlReader("R67"))
                        End If

                    Else
                        rpt2.SetParameterValue("age", mySqlReader("age_y"))


                        If mySqlReader("R79") Is DBNull.Value Then
                            rpt2.SetParameterValue("blood_group", "-")
                        Else
                            rpt2.SetParameterValue("blood_group", mySqlReader("R79"))
                        End If

                        If mySqlReader("R80") Is DBNull.Value Then
                            rpt2.SetParameterValue("blood_rh", "-")
                        Else
                            rpt2.SetParameterValue("blood_rh", mySqlReader("R80"))

                        End If

                        If mySqlReader("R3") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_hb", "-")
                        Else
                            rpt2.SetParameterValue("cbc_hb", mySqlReader("R3"))

                        End If
                        If mySqlReader("R4") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_hct", "-")
                        Else

                            rpt2.SetParameterValue("cbc_hct", mySqlReader("R4"))

                        End If
                        If mySqlReader("R1") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_wbc", "-")
                        Else

                            rpt2.SetParameterValue("cbc_wbc", mySqlReader("R1"))
                        End If


                        If mySqlReader("R14") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_b", "-")
                        Else
                            rpt2.SetParameterValue("cbc_b", mySqlReader("R14"))
                        End If


                        If mySqlReader("R13") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_e", "-")
                        Else

                            rpt2.SetParameterValue("cbc_e", mySqlReader("R13"))
                        End If



                        If mySqlReader("R11") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_l", "-")
                        Else
                            rpt2.SetParameterValue("cbc_l", mySqlReader("R11"))
                        End If

                        If mySqlReader("R12") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_m", "-")
                        Else
                            rpt2.SetParameterValue("cbc_m", mySqlReader("R12"))
                        End If


                        If mySqlReader("R10") Is DBNull.Value Then
                            rpt2.SetParameterValue("cbc_n", "-")
                        Else
                            rpt2.SetParameterValue("cbc_n", mySqlReader("R10"))
                        End If



                        ' tab3


                        If mySqlReader("R32") Is DBNull.Value Then
                            rpt2.SetParameterValue("color", "-")
                        Else
                            rpt2.SetParameterValue("color", mySqlReader("R32"))
                        End If


                        If mySqlReader("R33") Is DBNull.Value Then
                            rpt2.SetParameterValue("appearance", "-")
                        Else
                            rpt2.SetParameterValue("appearance", mySqlReader("R33"))
                        End If

                        If mySqlReader("R37") Is DBNull.Value Then
                            rpt2.SetParameterValue("glucose", "-")
                        Else
                            rpt2.SetParameterValue("glucose", mySqlReader("R37"))
                        End If


                        If mySqlReader("R41") Is DBNull.Value Then
                            rpt2.SetParameterValue("blood", "-")
                        Else
                            rpt2.SetParameterValue("blood", mySqlReader("R41"))
                        End If

                        If mySqlReader("R35") Is DBNull.Value Then
                            rpt2.SetParameterValue("ph", "-")
                        Else
                            rpt2.SetParameterValue("ph", mySqlReader("R35"))
                        End If



                        If mySqlReader("R44") Is DBNull.Value Then
                            rpt2.SetParameterValue("rbc", "-")
                        Else

                            If Trim(mySqlReader("R44")).Length <> 8 And Trim(mySqlReader("R44")).Length <> 5 Then
                                rpt2.SetParameterValue("rbc", mySqlReader("R44") + " Cells/HP")
                            Else

                                rpt2.SetParameterValue("rbc", mySqlReader("R44"))
                            End If

                        End If



                        If mySqlReader("R45") Is DBNull.Value Then
                            rpt2.SetParameterValue("wbc_urine", "-")
                        Else
                            rpt2.SetParameterValue("wbc_urine", mySqlReader("R45"))
                        End If

                        If mySqlReader("R54") Is DBNull.Value Then
                            rpt2.SetParameterValue("fbs", "-")
                        Else
                            rpt2.SetParameterValue("fbs", mySqlReader("R54"))

                        End If


                        If mySqlReader("R46") Is DBNull.Value Then
                            rpt2.SetParameterValue("epi", "-")
                        Else
                            rpt2.SetParameterValue("epi", mySqlReader("R46"))
                        End If
                        If mySqlReader("R36") Is DBNull.Value Then
                            rpt2.SetParameterValue("albumin", "-")
                        Else
                            rpt2.SetParameterValue("albumin", mySqlReader("R36"))
                        End If
                        If mySqlReader("R34") Is DBNull.Value Then
                            rpt2.SetParameterValue("spgr", "-")
                        Else
                            rpt2.SetParameterValue("spgr", mySqlReader("R34"))
                        End If


                        'tab5
                        If mySqlReader("R55") Is DBNull.Value Then
                            rpt2.SetParameterValue("bun", "-")

                        Else
                            rpt2.SetParameterValue("bun", mySqlReader("R55"))
                        End If

                        If mySqlReader("R57") Is DBNull.Value Then
                            rpt2.SetParameterValue("cholesterol", "-")

                        Else
                            rpt2.SetParameterValue("cholesterol", mySqlReader("R57"))
                        End If

                        If mySqlReader("R56") Is DBNull.Value Then
                            rpt2.SetParameterValue("creatinine", "-")

                        Else
                            rpt2.SetParameterValue("creatinine", mySqlReader("R56"))
                        End If




                        If mySqlReader("R59") Is DBNull.Value Then
                            rpt2.SetParameterValue("hdl", "-")

                        Else
                            rpt2.SetParameterValue("hdl", mySqlReader("R59"))
                        End If



                        If mySqlReader("R58") Is DBNull.Value Then
                            rpt2.SetParameterValue("trigyceride", "-")


                        Else
                            rpt2.SetParameterValue("trigyceride", mySqlReader("R58"))
                        End If


                        If mySqlReader("R61") Is DBNull.Value Then
                            rpt2.SetParameterValue("uric_acid", "-")

                        Else
                            rpt2.SetParameterValue("uric_acid", mySqlReader("R61"))
                        End If


                        'tab6

                        If mySqlReader("R66") Is DBNull.Value Then
                            rpt2.SetParameterValue("afp", "-")

                        Else
                            rpt2.SetParameterValue("afp", mySqlReader("R66"))
                        End If

                        If mySqlReader("R62") Is DBNull.Value Then
                            rpt2.SetParameterValue("alkaline", "-")

                        Else
                            rpt2.SetParameterValue("alkaline", mySqlReader("R62"))
                        End If
                        If mySqlReader("R60") Is DBNull.Value Then
                            rpt2.SetParameterValue("ldl", "-")

                        Else
                            rpt2.SetParameterValue("ldl", mySqlReader("R60"))
                        End If
                        If mySqlReader("R70") Is DBNull.Value Then
                            rpt2.SetParameterValue("sgot", "-")

                        Else
                            rpt2.SetParameterValue("sgot", mySqlReader("R70"))
                        End If


                        If mySqlReader("R71") Is DBNull.Value Then
                            rpt2.SetParameterValue("sgpt", "-")

                        Else
                            rpt2.SetParameterValue("sgpt", mySqlReader("R71"))
                        End If


                        If mySqlReader("R77") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_wbc", "-")
                        Else
                            rpt2.SetParameterValue("stool_wbc", mySqlReader("R77"))
                        End If

                        If mySqlReader("R76") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_rbc", "-")
                        Else
                            rpt2.SetParameterValue("stool_rbc", mySqlReader("R76"))
                        End If

                        If mySqlReader("R78") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_parasite", "-")
                        Else
                            rpt2.SetParameterValue("stool_parasite", mySqlReader("R78"))
                        End If

                        If mySqlReader("R75") Is DBNull.Value Then
                            rpt2.SetParameterValue("stool_blood", "-")
                        Else
                            rpt2.SetParameterValue("stool_blood", mySqlReader("R75"))
                        End If

                        If mySqlReader("R81") Is DBNull.Value Then
                            rpt2.SetParameterValue("vdrl", "-")
                        Else
                            rpt2.SetParameterValue("vdrl", mySqlReader("R81"))
                        End If


                        If mySqlReader("R84") Is DBNull.Value Then
                            rpt2.SetParameterValue("hiv", "-")
                        Else
                            rpt2.SetParameterValue("hiv", mySqlReader("R84"))
                        End If

                        If mySqlReader("R63") Is DBNull.Value Then
                            rpt2.SetParameterValue("sag", "-")
                        Else
                            rpt2.SetParameterValue("sag", mySqlReader("R63"))
                        End If

                        If mySqlReader("R64") Is DBNull.Value Then
                            rpt2.SetParameterValue("sab", "-")
                        Else
                            rpt2.SetParameterValue("sab", mySqlReader("R64"))
                        End If
                        If mySqlReader("R65") Is DBNull.Value Then
                            rpt2.SetParameterValue("cea", "-")
                        Else
                            rpt2.SetParameterValue("cea", mySqlReader("R65"))
                        End If
                        If mySqlReader("R66") Is DBNull.Value Then
                            rpt2.SetParameterValue("afp", "-")
                        Else
                            rpt2.SetParameterValue("afp", mySqlReader("R66"))
                        End If


                        If mySqlReader("R83") Is DBNull.Value Then
                            rpt2.SetParameterValue("cab", "-")
                        Else
                            rpt2.SetParameterValue("cab", mySqlReader("R83"))
                        End If

                        If mySqlReader("R67") Is DBNull.Value Then
                            rpt2.SetParameterValue("psa", "-")
                        Else
                            rpt2.SetParameterValue("psa", mySqlReader("R67"))
                        End If


                    End If





                End While
                mysql.Close()



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        End If




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



        rpt2.SetParameterValue("hn", "-")
        rpt2.SetParameterValue("stool_culture", " ")
        rpt2.SetParameterValue("name", "-")
        rpt2.SetParameterValue("lastname", "-")
        rpt2.SetParameterValue("age", "-")
        rpt2.SetParameterValue("date_exam", "-")
        rpt2.SetParameterValue("weight", "-")
        rpt2.SetParameterValue("height", "-")
        rpt2.SetParameterValue("pulse", "-")
        rpt2.SetParameterValue("blood_pressure", "-")
        rpt2.SetParameterValue("eye_right", "-")
        rpt2.SetParameterValue("eye_left", "-")
        rpt2.SetParameterValue("fbs", "-")
        rpt2.SetParameterValue("creatinine", "-")
        rpt2.SetParameterValue("cholesterol", "-")
        rpt2.SetParameterValue("trigyceride", "-")
        rpt2.SetParameterValue("sgot", "-")
        rpt2.SetParameterValue("sgpt", "-")
        rpt2.SetParameterValue("alkaline", "-")
        rpt2.SetParameterValue("uric_acid", "-")
        rpt2.SetParameterValue("hdl", "-")
        rpt2.SetParameterValue("ldl", "-")
        rpt2.SetParameterValue("afp", "-")
        rpt2.SetParameterValue("psa", "-")
        rpt2.SetParameterValue("cea", "-")
        rpt2.SetParameterValue("mercury", "-")
        rpt2.SetParameterValue("blood_group", "-")
        rpt2.SetParameterValue("blood_rh", "-")
        rpt2.SetParameterValue("cbc_wbc", "-")
        rpt2.SetParameterValue("cbc_hct", "-")
        rpt2.SetParameterValue("cbc_hb", "-")
        rpt2.SetParameterValue("cbc_l", "-")
        rpt2.SetParameterValue("cbc_m", "-")
        rpt2.SetParameterValue("cbc_e", "-")
        rpt2.SetParameterValue("cbc_b", "-")
        rpt2.SetParameterValue("cbc_n", "-")
        rpt2.SetParameterValue("color", "-")
        rpt2.SetParameterValue("spgr", "-")
        rpt2.SetParameterValue("albumin", "-")
        rpt2.SetParameterValue("blood", "-")
        rpt2.SetParameterValue("epi", "-")
        rpt2.SetParameterValue("appearance", "-")
        rpt2.SetParameterValue("ph", "-")
        rpt2.SetParameterValue("glucose", "-")
        rpt2.SetParameterValue("rbc", "-")
        rpt2.SetParameterValue("wbc_urine", "-")
        rpt2.SetParameterValue("stool_wbc", "-")
        rpt2.SetParameterValue("stool_rbc", "-")
        rpt2.SetParameterValue("stool_parasite", "-")
        rpt2.SetParameterValue("stool_blood", "-")
        rpt2.SetParameterValue("x_ray", "-")
        rpt2.SetParameterValue("hiv", "-")
        rpt2.SetParameterValue("vdrl", "-")
        rpt2.SetParameterValue("sag", "-")
        rpt2.SetParameterValue("sab", "-")
        rpt2.SetParameterValue("cab", "-")
        rpt2.SetParameterValue("igg", "-")
        rpt2.SetParameterValue("igm", "-")

        rpt2.SetParameterValue("summary", "-")

        rpt2.SetParameterValue("mercury", "-")


    End Sub
    Public Sub check_table()


        If newReport_oil = False Then

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


            If frmOilPackage.est = "Normal" Then
                rpt1.SetParameterValue("est_a", "<p align='center' ><font>&#10003;</font></p>")
                rpt1.SetParameterValue("est_ab", "")
            ElseIf frmOilPackage.est = "Abnormal" Then
                rpt1.SetParameterValue("est_a ", "")
                rpt1.SetParameterValue("est_ab", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.est = "NoData" Then
                rpt1.SetParameterValue("est_a", "<p align='center' ><font>-</font></p>")
                rpt1.SetParameterValue("est_ab", "<p align='center' ><font>-</font></p>")
            End If

            If frmOilPackage.ust = "Normal" Then
                rpt1.SetParameterValue("ust_a", "<p align='center' ><font>&#10003;</font></p>")
                rpt1.SetParameterValue("ust_ab", "")
            ElseIf frmOilPackage.ust = "Abnormal" Then
                rpt1.SetParameterValue("ust_a ", "")
                rpt1.SetParameterValue("ust_ab", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.ust = "NoData" Then
                rpt1.SetParameterValue("ust_a", "<p align='center' ><font>-</font></p>")
                rpt1.SetParameterValue("ust_ab", "<p align='center' ><font>-</font></p>")
            End If




        Else


            rpt2.SetParameterValue("company_name", frmOilPackage.company_name)
            rpt2.SetParameterValue("height", frmOilPackage.phy_height)
            rpt2.SetParameterValue("weight", frmOilPackage.phy_weight)
            rpt2.SetParameterValue("pulse", frmOilPackage.phy_pulse)
            rpt2.SetParameterValue("blood_pressure", frmOilPackage.phy_bloodpressure)
            rpt2.SetParameterValue("eye_right", frmOilPackage.phy_eye_right)
            rpt2.SetParameterValue("eye_left", frmOilPackage.phy_eye_left)
            rpt2.SetParameterValue("mercury", frmOilPackage.mercury)
            rpt2.SetParameterValue("bmi", frmOilPackage.bmi)
            rpt2.SetParameterValue("cea", frmOilPackage.cea)

            rpt2.SetParameterValue("igg", frmOilPackage.igg)
            rpt2.SetParameterValue("igm", frmOilPackage.igm)



            rpt2.SetParameterValue("symbol_text", "<p align='center' ><font>&#10003; = 'ปกติ (Normal)'</font> <br> <font>&#10005; = 'ผิดปกติ (Abnormal)'</font> </p>")

            If frmOilPackage.r_eye = "Normal" Then
                rpt2.SetParameterValue("eye_n", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.r_eye = "Abnormal" Then

                rpt2.SetParameterValue("eye_n", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.r_eye = "NoData" Then
                rpt2.SetParameterValue("eye_n", "<p align='center' ><font>-</font></p>")

            End If






            If frmOilPackage.neck = "Normal" Then
                rpt2.SetParameterValue("neck_n", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.neck = "Abnormal" Then
                rpt2.SetParameterValue("neck_n", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.neck = "NoData" Then
                rpt2.SetParameterValue("neck_n", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.heart = "Normal" Then
                rpt2.SetParameterValue("heart_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.heart = "Abnormal" Then
                rpt2.SetParameterValue("heart_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.heart = "NoData" Then
                rpt2.SetParameterValue("heart_a", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.vas = "Normal" Then
                rpt2.SetParameterValue("vac_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.vas = "Abnormal" Then
                rpt2.SetParameterValue("vac_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.vas = "NoData" Then
                rpt2.SetParameterValue("vac_a", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.chest = "Normal" Then
                rpt2.SetParameterValue("lungs_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.chest = "Abnormal" Then
                rpt2.SetParameterValue("lungs_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.chest = "NoData" Then
                rpt2.SetParameterValue("lungs_a", "<p align='center' ><font>-</font></p>")
            End If

            If frmOilPackage.ab = "Normal" Then
                rpt2.SetParameterValue("ab_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.ab = "Abnormal" Then
                rpt2.SetParameterValue("ab_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.ab = "NoData" Then
                rpt2.SetParameterValue("ab_a", "<p align='center' ><font>-</font></p>")
            End If

            If frmOilPackage.lymp = "Normal" Then
                rpt2.SetParameterValue("lym_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.lymp = "Abnormal" Then
                rpt2.SetParameterValue("lym_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.lymp = "NoData" Then
                rpt2.SetParameterValue("lym_a", "<p align='center' ><font>-</font></p>")
            End If

            If frmOilPackage.gu = "Normal" Then
                rpt2.SetParameterValue("gu_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.gu = "Abnormal" Then
                rpt2.SetParameterValue("gu_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.gu = "NoData" Then
                rpt2.SetParameterValue("gu_a", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.ex = "Normal" Then
                rpt2.SetParameterValue("ex_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.ex = "Abnormal" Then
                rpt2.SetParameterValue("ex_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.ex = "NoData" Then
                rpt2.SetParameterValue("ex_a", "<p align='center' ><font>-</font></p>")
            End If

            If frmOilPackage.spine = "Normal" Then
                rpt2.SetParameterValue("spine_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.spine = "Abnormal" Then
                rpt2.SetParameterValue("spine_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.spine = "NoData" Then
                rpt2.SetParameterValue("spine_a", "<p align='center' ><font>-</font></p>")
            End If



            If frmOilPackage.skins = "Normal" Then
                rpt2.SetParameterValue("skin_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.skins = "Abnormal" Then
                rpt2.SetParameterValue("skin_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.skins = "NoData" Then
                rpt2.SetParameterValue("skin_a", "<p align='center' ><font>-</font></p>")
            End If



            If frmOilPackage.audio = "Normal" Then
                rpt2.SetParameterValue("audio_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.audio = "Abnormal" Then
                rpt2.SetParameterValue("audio_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.audio = "NoData" Then
                rpt2.SetParameterValue("audio_a", "<p align='center' ><font>-</font></p>")
            End If



            If frmOilPackage.lung = "Normal" Then
                rpt2.SetParameterValue("lung_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.lung = "Abnormal" Then
                rpt2.SetParameterValue("lung_a", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.lung = "NoData" Then
                rpt2.SetParameterValue("lung_a", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.ekg = "Normal" Then
                rpt2.SetParameterValue("ekg_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.ekg = "Abnormal" Then
                rpt2.SetParameterValue("ekg_a ", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.ekg = "NoData" Then
                rpt2.SetParameterValue("ekg_a", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.est = "Normal" Then
                rpt2.SetParameterValue("est_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.est = "Abnormal" Then
                rpt2.SetParameterValue("est_a ", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.est = "NoData" Then
                rpt2.SetParameterValue("est_a", "<p align='center' ><font>-</font></p>")
            End If


            If frmOilPackage.ust = "Normal" Then
                rpt2.SetParameterValue("ust_a", "<p align='center' ><font>&#10003;</font></p>")
            ElseIf frmOilPackage.ust = "Abnormal" Then
                rpt2.SetParameterValue("ust_a ", "<p align='center' ><font>&#10005;</font></p>")
            ElseIf frmOilPackage.ust = "NoData" Then
                rpt2.SetParameterValue("ust_a", "<p align='center' ><font>-</font></p>")
            End If






        End If








    End Sub

End Class