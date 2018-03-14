Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Public Class frmOilPackage
    Public Sql As MySqlConnection
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Dim id_user As String
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcompany As String = ""
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim id_hn As String = 0
    Dim export_id As String
    Public Shared address As String = ""
    Public Shared tellephone As String = ""
    Public Shared unders As String = ""
    Public Shared sex_fm As String
    Public Shared vir_igt As String = " "
    Public Shared date_string As String = " "
    Public Shared glass As String = " "
    Public Shared license As String = " "
    Public Shared fit_check As String = " "
    Public Shared doctor_name As String = " "
    Public Shared name_lastname As String = " "
    Public Shared name_eng As String = " "
    Public Shared lastname_eng As String = " "
    Public Shared amphetamine As String = " "
    Public Shared datetime As String = ""

    Public Shared checkaddress As Boolean

    Public Shared spec As String = ""
    Public Shared fitair As String = ""
    Public Shared fitbreath As String = ""
    Public Shared fitcrance As String = ""
    Public Shared fitemergency As String = ""
    Public Shared fitfood As String = ""

    Dim check_group As String = ""
    Dim count_group As Integer = 1
    Dim check_form As String = "0"
    Dim count_result As Integer
    Public Shared cbc_result As String = " "
    Public Shared urine_result As String = " "
    Public Shared mercury As String = " "
    Public Shared cea As String = " "
    Public Shared result_all As String = " "
    Public Shared urine_other As String = " "
    Public Shared pap_text As String = " "
    Public Shared pap_result As String = " "
    Public Shared under As String = " "
    Public Shared color_blind As String = " "
    Public Shared igg As String = " "
    Public Shared igm As String = " "
    Public Shared red_homology As String = " "
    Public Shared blood_pressure_result_txt As String = ""
    Public Shared eye_result_txt As String = ""

    Public Shared export_date As String = " "

    Public Shared result_phy As String = " "
    Public Shared result_hematology As String = " "
    Public Shared result_urine As String = " "
    Public Shared result_physical As String = " "
    Public Shared result_xray As String = " "
    Public Shared result_ultrasound As String = " "
    Public Shared result_ekg As String = " "
    Public Shared result_bloodchem As String = " "
    Public Shared result_bun As String = " "
    Public Shared result_creatinine As String = " "
    Public Shared result_uricacid As String = " "
    Public Shared result_cholesterol As String = " "
    Public Shared result_triglyceride As String = " "
    Public Shared result_hdl As String = " "
    Public Shared result_ldl As String = " "
    Public Shared result_sgot As String = " "
    Public Shared result_sgpt As String = " "
    Public Shared result_alkaline As String = " "
    Public Shared result_afp As String = " "
    Public Shared result_pfp As String = " "
    Public Shared result_fbs As String = " "
    Public Shared company_name As String
    Public Shared result_tab1 As String = " "
    Public Shared other_fit As String = " "
    Public Shared phy_height As String = " "
    Public Shared phy_weight As String = " "
    Public Shared phy_bmi As String = " "
    Public Shared phy_bloodpressure As String = " "
    Public Shared phy_pulse As String = " "
    Public Shared phy_eye_left As String = " "
    Public Shared phy_eye_right As String = " "
    Public Shared phy_dental As String = " "
    Public Shared tab2_redcell As String = " "
    Public Shared bmi As String
    Public Shared result_pulserate As String = " "
    Public Shared result_eye As String = " "
    Public Shared check_sub As String = 0
    Public Shared r_eye As String
    Public Shared neck As String
    Public Shared heart As String
    Public Shared vas As String
    Public Shared ab As String
    Public Shared lymp As String
    Public Shared gu As String
    Public Shared ex As String
    Public Shared spine As String
    Public Shared skins As String
    Public Shared audio As String
    Public Shared lung As String
    Public Shared ekg As String
    Public Shared chest As String
    Public Shared teeth As String

    Public Shared Stool_culture As String
    Dim id_hhn As String
    Dim address_text As String = " "
    Dim mysql_ryh As MySqlConnection
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    '  Dim MyODBCConnection As New OdbcConnection("Server=192.0.0.222; dsn=RYHV5; User Id=mse;Password=m0116
    Private myTabRect As Rectangle
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef id_company As String, ByRef idexport As String, ByRef idhn As String)

        mysqlpass = mysql_pass

        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        export_id = idhn
        id_hn = idexport
        idcompany = id_company

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub update_data()
        DateTime = dateconfirm.Text
    End Sub
    Sub setYear()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub
    Private Sub frmOilPackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setYear()

        txtcompany.Text = idcompany
        txtsearch.Text = id_hn
        clear()
        dateconfirm.Text = Date.Now.ToString("dd-MM-yyyy")
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=lab_rajyindee;Character Set =utf8;"
        Try
            mysql.Open()
            ''MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try


        Dim string_redcell As String = ""


        count_result = 1

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

        If id_hn <> "0" And export_id <> "0" Then

            Dim amp As String
            Dim prv As String
            Dim tmp As String
            Dim zipcode As String

            'Open the connection
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
                    address_text = dr.GetString(2).Trim

                    txt_tell.Text = dr.GetString(9).Trim

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
                        address_text = address_text + " ตำบล " + dr.GetString(2).Trim

                    End If
                    If dr.GetString(1) IsNot DBNull.Value Then

                        address_text = address_text + " อำเภอ " + dr.GetString(1).Trim

                    End If
                    If dr.GetString(0) IsNot DBNull.Value Then
                        address_text = address_text + " จังหวัด " + dr.GetString(0).Trim

                    End If

                    address_text = address_text + " " + zipcode
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txt_address.Text = address_text
            MyODBCConnection.Close()


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + id_hn + "' and checkup_export_id like '" + export_id + "' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While mySqlReader.Read()
                    txt_name.Text = mySqlReader("f_name")
                    txt_lastname.Text = mySqlReader("l_name")
                    If mySqlReader("sex_code") = "3" Then
                        txt_sex.Text = "หญิง"
                    Else
                        txt_sex.Text = "ชาย"
                    End If

                    txt_age.Text = mySqlReader("age_y")
                    txt_date.Text = Format(mySqlReader("export_date"), "dd/MM/yyyy")
                    'tab2

                    If mySqlReader("R17") Is "Normal" Then

                        tab2_txt_redcell.Text = "อยู่ในเกณฑ์ปกติ(Normal Value)"

                    ElseIf mySqlReader("R17") Is DBNull.Value Then

                        If mySqlReader("R18") Is DBNull.Value Then

                        Else
                            string_redcell = string_redcell + "Hypochromia-few,"
                        End If

                        If mySqlReader("R19") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Anisocytosis-few,"
                        End If
                        If mySqlReader("R20") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Microcyte-few,"
                        End If
                        If mySqlReader("R21") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Macrocyte-few,"
                        End If
                        If mySqlReader("R22") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Poikilocytosis-few,"
                        End If
                        If mySqlReader("R23") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Ovalocyte-few,"
                        End If

                        If mySqlReader("R24") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Schistocyte-few,"
                        End If
                        If mySqlReader("R25") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Burr-few,"
                        End If
                        If mySqlReader("R26") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Target Cell-few,"
                        End If
                        If mySqlReader("R27") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Polychromasia-few,"
                        End If
                        If mySqlReader("R28") Is DBNull.Value Then
                        Else
                            string_redcell = string_redcell + "Basophilic-few"
                        End If


                        tab2_txt_redcell.Text = string_redcell
                    End If

                    If mySqlReader("R79") Is DBNull.Value Then
                        tab2_txt_groupblood.Text = "-"
                        tab2_txt_groupblood.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_groupblood.Text = mySqlReader("R79")

                    End If
                    If mySqlReader("R80") Is DBNull.Value Then
                        tab2_txt_rh.Text = "-"
                        tab2_txt_rh.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_rh.Text = mySqlReader("R80")

                    End If

                    If mySqlReader("R3") Is DBNull.Value Then
                        tab2_txt_hb.Text = "-"
                        tab2_txt_hb.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_hb.Text = mySqlReader("R3")

                    End If

                    If mySqlReader("R82") Is DBNull.Value Then
                        ComboBox26.Text = "-"
                        ComboBox26.BackColor = Color.DarkSeaGreen
                    Else
                        ComboBox26.Text = mySqlReader("R82")

                    End If
                    If mySqlReader("R52") Is DBNull.Value Then
                        tab3_txt_amphetamine.Text = "-"
                        tab3_txt_amphetamine.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_amphetamine.Text = mySqlReader("R52")

                    End If

                    If mySqlReader("R4") Is DBNull.Value Then
                        tab2_txt_hct.Text = "-"
                        tab2_txt_hct.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_hct.Text = mySqlReader("R4")

                    End If
                    If mySqlReader("R1") Is DBNull.Value Then
                        tab2_txt_wbc.Text = "-"
                        tab2_txt_wbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_wbc.Text = mySqlReader("R1")
                    End If
                    If mySqlReader("R15") Is DBNull.Value Then
                        tab2_txt_atypical.Text = "-"
                        tab2_txt_atypical.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_atypical.Text = mySqlReader("R15")

                    End If

                    If mySqlReader("R14") Is DBNull.Value Then

                        tab2_txt_bashophils.Text = "-"
                        tab2_txt_bashophils.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_bashophils.Text = mySqlReader("R14")
                    End If

                    If mySqlReader("R13") Is DBNull.Value Then
                        tab2_txt_eosinophils.Text = "-"
                        tab2_txt_eosinophils.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_eosinophils.Text = mySqlReader("R13")
                    End If

                    If mySqlReader("R11") Is DBNull.Value Then
                        tab2_txt_lymphocytes.Text = "-"
                        tab2_txt_lymphocytes.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_lymphocytes.Text = mySqlReader("R11")
                    End If

                    If mySqlReader("R12") Is DBNull.Value Then
                        tab2_txt_monocytes.Text = "-"
                        tab2_txt_monocytes.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_monocytes.Text = mySqlReader("R12")
                    End If

                    If mySqlReader("R10") Is DBNull.Value Then
                        tab2_txt_neutrophils.Text = "-"
                        tab2_txt_neutrophils.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_neutrophils.Text = mySqlReader("R10")
                    End If


                    If mySqlReader("R8") Is DBNull.Value Then
                        tab2_txt_plate.Text = "-"
                        tab2_txt_plate.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_plate.Text = mySqlReader("R8")
                    End If


                    ' tab3


                    If mySqlReader("R32") Is DBNull.Value Then
                        tab3_txt_color.Text = "-"
                        tab3_txt_color.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_color.Text = mySqlReader("R32")
                    End If


                    If mySqlReader("R33") Is DBNull.Value Then
                        tab3_txt_appearance.Text = "-"
                        tab3_txt_appearance.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_appearance.Text = mySqlReader("R33")
                    End If

                    If mySqlReader("R34") Is DBNull.Value Then
                        tab3_txt_spgr.Text = "-"
                        tab3_txt_spgr.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_spgr.Text = mySqlReader("R34")
                    End If
                    If mySqlReader("R36") Is DBNull.Value Then
                        tab3_txt_albumin.Text = "-"
                        tab3_txt_albumin.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_albumin.Text = mySqlReader("R36")
                    End If
                    If mySqlReader("R37") Is DBNull.Value Then
                        tab3_txt_glucose.Text = "-"
                        tab3_txt_glucose.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_glucose.Text = mySqlReader("R37")
                    End If


                    If mySqlReader("R41") Is DBNull.Value Then
                        tab3_txt_blood.Text = "-"
                        tab3_txt_blood.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_blood.Text = mySqlReader("R41")
                    End If

                    If mySqlReader("R35") Is DBNull.Value Then
                        tab3_txt_ph.Text = "-"
                        tab3_txt_ph.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_ph.Text = mySqlReader("R35")
                    End If


                    If mySqlReader("R44") Is DBNull.Value Then
                        tab3_txt_rbc.Text = "-"
                        tab3_txt_rbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_rbc.Text = mySqlReader("R44")
                    End If


                    If mySqlReader("R45") Is DBNull.Value Then
                        tab3_txt_wbc.Text = "-"
                        tab3_txt_wbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_wbc.Text = mySqlReader("R45")
                    End If


                    If mySqlReader("R46") Is DBNull.Value Then
                        tab3_txt_epi.Text = "-"
                        tab3_txt_epi.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_epi.Text = mySqlReader("R46")
                    End If


                    'tab4

                    If mySqlReader("R54") Is DBNull.Value Then
                        tab4_txt_fbs.Text = "-"
                        tab4_txt_fbs.BackColor = Color.DarkSeaGreen
                    Else
                        tab4_txt_fbs.Text = mySqlReader("R54")

                        Dim int_fbs As Integer
                        int_fbs = Integer.Parse(tab4_txt_fbs.Text)
                        tab4_txt_fbs.Text = int_fbs

                        If int_fbs >= 70 And int_fbs <= 110 Then
                            tab4_result_fbs.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_fbs > 111 And int_fbs <= 125 Then
                            If check_sub = 0 Then
                                tab4_result_fbs.Text = "การควบคุมน้ำตาลบกพร่อง   ควรลดอาหาร แป้ง รับประทานผัก ผลไม้ มากขึ้น และตรวจซ้ำ 1 เดือน"
                            ElseIf check_sub = 1 Then
                                tab4_result_fbs.Text = "Impaired glucose control : Reduce sweet foods,flour.Eat more fruit and vegetables and repeat blood test in 1 month."

                            End If

                        ElseIf int_fbs > 125 Then
                            If check_sub = 0 Then
                                tab4_result_fbs.Text = "มีภาวะเบาหวาน แนะนำควรพบแพทย์"
                            ElseIf check_sub = 1 Then
                                tab4_result_fbs.Text = "Diabetesv : Consult Doctor."
                            End If


                        ElseIf int_fbs < 50 Then
                            If check_sub = 0 Then
                                tab4_result_fbs.Text = "ภาวะน้ำตาลในเลือดต่ำ  ควรพบแพทย์เพื่อหาสาเหตุ"
                            ElseIf check_sub = 1 Then
                                tab4_result_fbs.Text = "Hypoglycemia : Consult Doctor."
                            End If

                        End If
                    End If





                    'tab5
                    If mySqlReader("R55") Is DBNull.Value Then
                        tab5_txt_bun.Text = "-"
                        tab5_txt_bun.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_bun.Text = mySqlReader("R55")
                        Dim int_bun As Integer
                        int_bun = Integer.Parse(tab5_txt_bun.Text)
                        tab5_txt_bun.Text = int_bun

                        If int_bun >= 7 And int_bun <= 20 Then

                            tab5_result_bun.Text = "อยู่ในเกณฑ์ปกติ (Normal)"


                        ElseIf int_bun > 20 Then
                            If check_sub = 0 Then
                                tab5_result_bun.Text = "การทำงานของไตสูงกว่าปกติ   ตรวจติดตามทุกปี"
                            ElseIf check_sub = 1 Then
                                tab5_result_bun.Text = "The hardness of renal function Follow up every year"
                            End If

                        ElseIf int_bun < 7 Then
                            If check_sub = 0 Then
                                tab5_result_bun.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                            ElseIf check_sub = 1 Then
                                tab5_result_bun.Text = "Non effect to diagnosis"

                            End If

                        End If
                    End If


                    If mySqlReader("R57") Is DBNull.Value Then
                        tab5_txt_cholesterol.Text = "-"
                        tab5_txt_cholesterol.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_cholesterol.Text = mySqlReader("R57")
                        Dim int_cholesterol As Integer
                        int_cholesterol = Integer.Parse(tab5_txt_cholesterol.Text)
                        tab5_txt_cholesterol.Text = int_cholesterol


                        If int_cholesterol >= 0 And int_cholesterol <= 200 Then
                            tab5_result_cholesterol.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_cholesterol > 200 Then

                            If check_sub = 0 Then
                                tab5_result_cholesterol.Text = "ไขมันในเลือดสูง   หลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตาม หรือตามคำแนะนำ ของแพทย์"
                            ElseIf check_sub = 1 Then
                                tab5_result_cholesterol.Text = "High cholesterol levels Dyslipidemia  Avoid or reduce fat food, including seafood , egg, yolks etc. Exercise regulary and Follow up a Doctor's instroduction."

                            End If



                        End If
                    End If

                    If mySqlReader("R56") Is DBNull.Value Then
                        tab5_txt_creatinine.Text = "-"
                        tab5_txt_creatinine.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_creatinine.Text = mySqlReader("R56")
                        Dim int_creatinine As Double
                        int_creatinine = Double.Parse(tab5_txt_creatinine.Text)
                        tab5_txt_creatinine.Text = int_creatinine

                        If int_creatinine >= 0.7 And int_creatinine <= 1.5 Then
                            tab5_result_creatinine.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_creatinine > 1.5 Then
                            If check_sub = 0 Then

                                tab5_result_creatinine.Text = "การทำงานของไตสูงกว่าปกติ   ตรวจติดตามทุกปี"
                            ElseIf check_sub = 1 Then
                                tab5_result_creatinine.Text = "Renal Insuffciency Follow up every year"

                            End If

                        ElseIf int_creatinine < 0.7 Then

                            If check_sub = 0 Then
                                tab5_result_creatinine.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                            ElseIf check_sub = 1 Then
                                tab5_result_creatinine.Text = "Non effect to diagnosis"
                            End If
                        End If

                    End If


                    If mySqlReader("R59") Is DBNull.Value Then
                        tab5_txt_hdl.Text = "-"
                        tab5_txt_hdl.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_hdl.Text = mySqlReader("R59")

                        Dim int_hdl As Integer
                        int_hdl = Integer.Parse(tab5_txt_hdl.Text)
                        tab5_txt_hdl.Text = int_hdl

                        If int_hdl >= 40 And int_hdl <= 60 Then
                            tab5_result_hdl.Text = "อยู่ในเกณฑ์ปกติ (Normal)"

                        ElseIf int_hdl > 60 Then
                            If check_sub = 0 Then
                                tab5_result_hdl.Text = "มีระดับดี   ลดภาวะเสี่ยงจากโรคหลอดเลือดหัวใจและหลอดเลือดสมองตีบ"
                            ElseIf check_sub = 1 Then
                                tab5_result_hdl.Text = "May reduce the risk of Vascular disease and Heart disease."
                            End If

                        ElseIf int_hdl < 40 Then
                            If check_sub = 0 Then
                                tab5_result_hdl.Text = "ต่ำกว่าปกติ   เพิ่มความเสี่ยงต่อโรคหลอดเลือดหัวใจและหลอดเลือดสมองตีบ"

                            ElseIf check_sub = 1 Then
                                tab5_result_hdl.Text = "May increase the risk of Vascular disease and Heart disease. Exercise regulary , no smoking , eat vegetables , more fish."

                            End If

                        End If
                    End If



                    If mySqlReader("R58") Is DBNull.Value Then
                        tab5_txt_trigyceride.Text = "-"
                        tab5_txt_trigyceride.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_trigyceride.Text = mySqlReader("R58")
                        Dim int_trigyceride As Integer
                        int_trigyceride = Integer.Parse(tab5_txt_trigyceride.Text)
                        tab5_txt_trigyceride.Text = int_trigyceride

                        If int_trigyceride >= 10 And int_trigyceride <= 150 Then
                            tab5_result_trigyceride.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_trigyceride > 150 Then
                            If check_sub = 0 Then

                                tab5_result_trigyceride.Text = "ไขมันในเลือดสูง   หลีกเลี่ยงหรือลดอาหารประเภทแป้ง คาร์โบไฮเดรตสูง ของหวาน สุรา เบียร์ เป็นต้น ออกกำลังกายสม่ำเสมอและตรวจติดตาม หรือตามคำแนะนำ ของแพทย์"
                            ElseIf check_sub = 1 Then
                                tab5_result_trigyceride.Text = "High triglyceride levels Dyslipidemia Avoid or reduce flour,carbohydrate,desert,alcohol,beer etc. Exercise regulary and follow up or a Doctor's instroduction."
                            End If


                        End If


                    End If


                    If mySqlReader("R61") Is DBNull.Value Then
                        tab5_txt_uricacid.Text = "-"
                        tab5_txt_uricacid.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_uricacid.Text = mySqlReader("R61")
                        Dim int_uricacid As Double
                        int_uricacid = Double.Parse(tab5_txt_uricacid.Text)
                        tab5_txt_uricacid.Text = int_uricacid

                        If int_uricacid >= 2.5 And int_uricacid <= 8.5 Then
                            tab5_result_uricacid.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_uricacid > 8.5 Then

                            If check_sub = 0 Then

                                tab5_result_uricacid.Text = "สูงกว่าปกติ   ควรหลีกเลี่ยงการรับประทานอาหารประเภทสัตว์ปีก เครื่องในสัตว์ หรือผักบางชนิด ยอดผัก เช่น หน่อไม้ กระถิน กะหล่ำปลี แอลกอฮอล์ เหล้า เบียร์ และตรวจติดตาม"
                            ElseIf check_sub = 1 Then
                                tab5_result_uricacid.Text = "High than normal : Avoid eating poultry,animala'entrails, some vegetables such as asparagus,cabbage etc. alcohol,beer and Follow up."
                            End If


                        ElseIf int_uricacid < 2.5 Then

                            If check_sub = 0 Then
                                tab5_result_uricacid.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                            ElseIf check_sub = 1 Then
                                tab5_result_uricacid.Text = "Non effect to diagnosis : Follow up every year"
                            End If

                        End If

                    End If


                    'tab6

                    If mySqlReader("R66") Is DBNull.Value Then
                        tab6_txt_afp.Text = "-"
                        tab6_txt_afp.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_txt_afp.Text = mySqlReader("R66")


                        Dim int_afp As Double
                        int_afp = Double.Parse(tab6_txt_afp.Text)
                        tab6_txt_afp.Text = int_afp

                        If int_afp >= 0 And int_afp <= 7.51 Then
                            tab6_result_afp.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_afp > 7.51 Then
                            tab6_result_afp.Text = "ค่าบ่งชี้มะเร็งในตับสูงกว่าในปกติ ตรวจติดตามกับอายุรแพทย์ ระบบทางเดินอาหาร"

                        End If

                    End If

                    If mySqlReader("R62") Is DBNull.Value Then
                        tab6_txt_alkaline.Text = "-"
                        tab6_txt_alkaline.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_txt_alkaline.Text = mySqlReader("R62")


                        Dim int_alk As Integer
                        int_alk = Integer.Parse(tab6_txt_alkaline.Text)
                        tab6_txt_alkaline.Text = int_alk
                        If int_alk >= 38 And int_alk <= 126 Then
                            tab6_result_alkaline.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_alk > 126 And int_alk < 199 Then

                            If check_sub = 0 Then
                                tab6_result_alkaline.Text = "สูงกว่าปกติ   แนะนำตรวจติดตามและตรวจซ้ำภายใน 3 เดือน"
                            ElseIf check_sub = 1 Then
                                tab6_result_alkaline.Text = "Follow up and repeated blood test in 3 month"
                            End If

                        ElseIf int_alk > 200 Then
                            If check_sub = 0 Then
                                tab6_result_alkaline.Text = "สงสัยมีภาวะอุดกั้นทางเดินน้ำดี   แนะนำปรึกษาแพทย์"
                            ElseIf check_sub = 1 Then
                                tab6_result_alkaline.Text = "Should Consult a Doctor"
                            End If
                        ElseIf int_alk < 38 Then

                            If check_sub = 0 Then
                                tab6_result_alkaline.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตาม"
                            ElseIf check_sub = 1 Then
                                tab6_result_alkaline.Text = "Non effect to diagnosis  Follow up every year"
                            End If

                        End If


                    End If
                    If mySqlReader("R60") Is DBNull.Value Then
                        tab6_txt_ldl.Text = "-"
                        tab6_txt_ldl.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_txt_ldl.Text = mySqlReader("R60")
                        Dim int_ldl As Integer
                        If IsNumeric(tab6_txt_ldl.Text) Then
                            int_ldl = Integer.Parse(tab6_txt_ldl.Text)
                            tab6_txt_ldl.Text = int_ldl

                            If int_ldl >= 30 And int_ldl <= 100 Then
                                tab6_result_ldl.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_ldl > 100 Then
                                tab6_result_ldl.Text = "ไขมันในเลือดสูง   หลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์ เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตาม หรือตามคำแนะนำของแพทย์"

                            End If
                        End If


                    End If
                    If mySqlReader("R70") Is DBNull.Value Then
                        tab6_txt_sgot.Text = "-"
                        tab6_txt_sgot.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_txt_sgot.Text = mySqlReader("R70")

                        Dim int_sgot As Integer
                        int_sgot = Integer.Parse(tab6_txt_sgot.Text)
                        tab6_txt_sgot.Text = int_sgot


                        If int_sgot >= 15 And int_sgot <= 46 Then
                            tab6_result_sgot.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_sgot > 46 Then

                            If check_sub = 0 Then
                                tab6_result_sgot.Text = "เอนไซม์ตับสูงกว่าปกติ   ควรลดอาหารไขมัน หลีกเลี่ยงแอลกอออล(ถ้าดื่ม) ออกกำลังกายสม่ำเสมอ และตรวจติดตาม"
                            ElseIf check_sub = 1 Then
                                tab6_result_sgot.Text = "High liver enzymes Reduce fat food, avoid alcohol (a drink), Exercise regulary and follow up."
                            End If

                        ElseIf int_sgot < 15 Then
                            If check_sub = 0 Then

                                tab6_result_sgot.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                            ElseIf check_sub = 1 Then
                                tab6_result_sgot.Text = "Non effect to diagnosis  Follow up very Year"
                            End If


                        ElseIf int_sgot > 100 Then
                            If check_sub = 0 Then
                                tab6_result_sgot.Text = "มีภาวะตับอักเสบ"
                            ElseIf check_sub = 1 Then
                                tab6_result_sgot.Text = "Hepatitis"
                            End If
                        End If

                    End If


                    If mySqlReader("R71") Is DBNull.Value Then
                        tab6_txt_sgpt.Text = "-"
                        tab6_txt_sgpt.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_txt_sgpt.Text = mySqlReader("R71")
                        Dim int_sgpt As Integer
                        int_sgpt = Integer.Parse(tab6_txt_sgpt.Text)
                        tab6_txt_sgpt.Text = int_sgpt

                        If int_sgpt >= 13 And int_sgpt <= 69 Then
                            tab6_result_spgt.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                        ElseIf int_sgpt > 69 Then

                            If check_sub = 0 Then
                                tab6_result_spgt.Text = "เอนไซม์ตับสูงกว่าปกติ   ควรลดอาหารไขมัน หลีกเลี่ยงแอลกอออล(ถ้าดื่ม) ออกกำลังกายสม่ำเสมอ และตรวจติดตาม"

                            ElseIf check_sub = 1 Then
                                tab6_result_spgt.Text = "High liver enzymes Reduce fat food,avoid alcohol (a drink) Exercise regulary and follow up."
                            End If

                        ElseIf int_sgpt < 13 Then

                            If check_sub = 0 Then
                                tab6_result_spgt.Text = "ไม่มีผลต่อการวินิจฉัย"
                            ElseIf check_sub = 1 Then
                                tab6_result_spgt.Text = "Non effect to diagnosis "
                            End If

                        End If




                    End If



                    If mySqlReader("R77") Is DBNull.Value Then
                        tab6_stool_wbc.Text = "-"
                        tab6_stool_wbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_stool_wbc.Text = mySqlReader("R77")
                    End If

                    If mySqlReader("R76") Is DBNull.Value Then
                        tab6_stool_rbc.Text = "-"
                        tab6_stool_rbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_stool_rbc.Text = mySqlReader("R76")
                    End If

                    If mySqlReader("R78") Is DBNull.Value Then
                        tab6_stool_parasites.Text = "-"
                        tab6_stool_parasites.BackColor = Color.DarkSeaGreen

                    Else
                        tab6_stool_parasites.Text = mySqlReader("R78")
                    End If

                    If mySqlReader("R75") Is DBNull.Value Then
                        tab6_stool_blood.Text = "-"
                        tab6_stool_blood.BackColor = Color.DarkSeaGreen
                    Else
                        tab6_stool_blood.Text = mySqlReader("R75")
                    End If

                    If mySqlReader("R81") Is DBNull.Value Then
                        tab3_txt_vdrl.Text = "-"
                        tab3_txt_vdrl.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_vdrl.Text = mySqlReader("R81")
                    End If


                    If mySqlReader("R84") Is DBNull.Value Then
                        tab3_txt_hiv.Text = "-"
                        tab3_txt_hiv.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_hiv.Text = mySqlReader("R84")
                    End If

                    If mySqlReader("R63") Is DBNull.Value Then
                        txt_hbsag.Text = "-"
                        txt_hbsag.BackColor = Color.DarkSeaGreen
                    Else
                        txt_hbsag.Text = mySqlReader("R63")
                    End If

                    If mySqlReader("R86") Is DBNull.Value Then
                        txt_anti_igg.Text = "-"
                        txt_anti_igg.BackColor = Color.DarkSeaGreen
                    Else
                        txt_anti_igg.Text = mySqlReader("R86")
                    End If
                    If mySqlReader("R87") Is DBNull.Value Then
                        txt_hav_igm.Text = "-"
                        txt_hav_igm.BackColor = Color.DarkSeaGreen
                    Else
                        txt_hav_igm.Text = mySqlReader("R87")
                    End If



                    If mySqlReader("R64") Is DBNull.Value Then
                        txt_hbsab.Text = "-"
                        txt_hbsab.BackColor = Color.DarkSeaGreen
                    Else
                        txt_hbsab.Text = mySqlReader("R64")
                    End If

                    If mySqlReader("R83") Is DBNull.Value Then
                        txt_hbcab.Text = "-"
                        txt_hbcab.BackColor = Color.DarkSeaGreen
                    Else
                        txt_hbcab.Text = mySqlReader("R83")
                    End If
                    If mySqlReader("R65") Is DBNull.Value Then
                        TextBox5.Text = "-"
                        TextBox5.BackColor = Color.DarkSeaGreen
                    Else
                        TextBox5.Text = mySqlReader("R65")
                    End If

                End While
                mysql.Close()

                Dim date_one As String
                Dim date_two As String
                Dim date_time1() As String
                Dim date_new As String

                date_time1 = Split(txt_date.Text, "/")
                date_one = Trim(date_time1(0).ToString)
                date_two = Trim(date_time1(1).ToString)
                If date_one.Length = 1 Then
                    date_one = "0" + date_one
                End If
                If date_two.Length = 1 Then
                    date_two = "0" + date_two
                End If

                date_new = date_time1(2).ToString + date_two + date_one
                MyODBCConnection.Close()
                If MyODBCConnection.State = ConnectionState.Closed Then
                    MyODBCConnection.Open()
                End If


                selectCMD = New OdbcCommand("SELECT OPHRESULT,OPHOTHTYP,OPHOTHCOD FROM OPDOTHV5PF WHERE OPHREGDTE like '" & date_new & "' and OPHHN like '" & id_hn & "'")

                selectCMD.Connection = MyODBCConnection


                Try
                    'Set the mouse to show a Wait cursor
                    Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                    'start the Read loop
                    While dr.Read
                        'Note: the numbers in double quotes represent the column number from the AS400 database
                        'Add the data to the list view
                        If dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "01" Then
                            tab1_tab_weight.Text = dr.GetString(0).Trim
                        ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "03" Then
                            tab1_txt_height.Text = dr.GetString(0).Trim
                        ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "04" Then
                            tab1_txt_pulserate.Text = dr.GetString(0).Trim
                        ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "05" Then
                            tab1_txt_bloodp.Text = dr.GetString(0).Trim
                        End If
                        'End the loop
                    End While
                    'Reset the cursor


                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                MyODBCConnection.Close()
                bmi_cal()



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If





    End Sub
    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown

        Dim string_count As Integer = 0
        Dim string_redcell As String = " "




        If e.KeyCode = "13" Then
            result_all = ""
            clear()
            id_hn = txtsearch.Text
            export_id = 0
            count_result = 1

            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader




            Dim amp As String
            Dim prv As String
            Dim tmp As String
            Dim zipcode As String
            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If
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
                    address_text = dr.GetString(2).Trim

                    txt_tell.Text = dr.GetString(9).Trim

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










            '   If MyODBCConnection.State = ConnectionState.Closed Then
            'MyODBCConnection.Open()
            '   End If
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
                        address_text = address_text + " ตำบล " + dr.GetString(2).Trim

                    End If
                    If dr.GetString(1) IsNot DBNull.Value Then

                        address_text = address_text + " อำเภอ " + dr.GetString(1).Trim

                    End If
                    If dr.GetString(0) IsNot DBNull.Value Then
                        address_text = address_text + " จังหวัด " + dr.GetString(0).Trim

                    End If

                    address_text = address_text + " " + zipcode
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txt_address.Text = address_text

            MyODBCConnection.Close()




            mysql.Close()

            mysql.ConnectionString = "server=192.0.0.204;user id=sa;password=sa;database=lab_rajyindee;Character Set =utf8;"
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
            mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + txtsearch.Text + "';"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try

                mySqlReader = mySqlCommand.ExecuteReader
                While mySqlReader.Read()
                    string_count = string_count + 1

                End While
                mysql.Close()


                If string_count = 1 Then


                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + txtsearch.Text + "';"
                    mySqlCommand.Connection = mysql
                    mySqlAdaptor.SelectCommand = mySqlCommand

                    mySqlReader = mySqlCommand.ExecuteReader
                    While mySqlReader.Read()

                        txt_name.Text = mySqlReader("f_name")
                        txt_lastname.Text = mySqlReader("l_name")
                        If mySqlReader("sex_code") = "3" Then
                            txt_sex.Text = "หญิง"
                        Else
                            txt_sex.Text = "ชาย"
                        End If
                        txt_date.Text = Format(mySqlReader("export_date"), "dd/MM/yyyy")
                        txt_age.Text = mySqlReader("age_y")


                        'tab2

                        If mySqlReader("R17") Is "Normal" Then

                            tab2_txt_redcell.Text = "อยู่ในเกณฑ์ปกติ(Normal Value)"

                        ElseIf mySqlReader("R17") Is DBNull.Value Then


                            If mySqlReader("R18") Is DBNull.Value Then

                            Else
                                If mySqlReader("R18") = "Few" Then
                                    string_redcell = string_redcell + "Hypochromia-" + mySqlReader("R18") + ","
                                Else
                                    string_redcell = string_redcell + "Hypochromia " + mySqlReader("R18") + ","
                                End If
                            End If

                            If mySqlReader("R19") Is DBNull.Value Then

                            Else
                                If mySqlReader("R19") = "Few" Then
                                    string_redcell = string_redcell + "Anisocytosis-" + mySqlReader("R19") + ","
                                Else
                                    string_redcell = string_redcell + "Anisocytosis " + mySqlReader("R19") + ","
                                End If

                            End If
                            If mySqlReader("R20") Is DBNull.Value Then
                            Else
                                If mySqlReader("R20") = "Few" Then
                                    string_redcell = string_redcell + "Microcyte-" + mySqlReader("R20") + ","
                                Else
                                    string_redcell = string_redcell + "Microcyte " + mySqlReader("R20") + ","
                                End If

                            End If
                            If mySqlReader("R21") Is DBNull.Value Then
                            Else
                                If mySqlReader("R21") = "Few" Then
                                    string_redcell = string_redcell + "Macrocyte-" + mySqlReader("R21") + ","
                                Else
                                    string_redcell = string_redcell + "Macrocyte " + mySqlReader("R21") + ","
                                End If
                            End If
                            If mySqlReader("R22") Is DBNull.Value Then
                            Else
                                If mySqlReader("R22") = "Few" Then
                                    string_redcell = string_redcell + "Poikilocytosis-" + mySqlReader("R22") + ","
                                Else
                                    string_redcell = string_redcell + "Poikilocytosis " + mySqlReader("R22") + ","
                                End If


                            End If
                            If mySqlReader("R23") Is DBNull.Value Then
                            Else
                                If mySqlReader("R23") = "Few" Then
                                    string_redcell = string_redcell + "Ovalocyte-" + mySqlReader("R23") + ","
                                Else
                                    string_redcell = string_redcell + "Ovalocyte " + mySqlReader("R23") + ","
                                End If
                            End If

                            If mySqlReader("R24") Is DBNull.Value Then
                            Else
                                If mySqlReader("R24") = "Few" Then
                                    string_redcell = string_redcell + "Schistocyte-" + mySqlReader("R24") + ","
                                Else
                                    string_redcell = string_redcell + "Schistocyte " + mySqlReader("R24") + ","
                                End If
                            End If
                            If mySqlReader("R25") Is DBNull.Value Then
                            Else
                                If mySqlReader("R25") = "Few" Then
                                    string_redcell = string_redcell + "Burr-" + mySqlReader("R25") + ","
                                Else
                                    string_redcell = string_redcell + "Burr " + mySqlReader("R25") + ","
                                End If
                            End If
                            If mySqlReader("R26") Is DBNull.Value Then
                            Else
                                If mySqlReader("R26") = "Few" Then
                                    string_redcell = string_redcell + "Target Cell-" + mySqlReader("R26") + ","
                                Else
                                    string_redcell = string_redcell + "Target Cell " + mySqlReader("R26") + ","
                                End If

                            End If
                            If mySqlReader("R27") Is DBNull.Value Then
                            Else
                                If mySqlReader("R27") = "Few" Then
                                    string_redcell = string_redcell + "Polychromasia-" + mySqlReader("R27") + ","
                                Else
                                    string_redcell = string_redcell + "Polychromasia " + mySqlReader("R27") + ","
                                End If

                            End If
                            If mySqlReader("R28") Is DBNull.Value Then
                            Else
                                If mySqlReader("R28") = "Few" Then
                                    string_redcell = string_redcell + "Basophilic-" + mySqlReader("R28") + ","
                                Else
                                    string_redcell = string_redcell + "Basophilic " + mySqlReader("R28") + ","
                                End If

                            End If



                            tab2_txt_redcell.Text = string_redcell
                        End If


                        If mySqlReader("R79") Is DBNull.Value Then
                            tab2_txt_groupblood.Text = "-"
                            tab2_txt_groupblood.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_groupblood.Text = mySqlReader("R79")

                        End If
                        If mySqlReader("R80") Is DBNull.Value Then
                            tab2_txt_rh.Text = "-"
                            tab2_txt_rh.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_rh.Text = mySqlReader("R80")

                        End If

                        If mySqlReader("R3") Is DBNull.Value Then
                            tab2_txt_hb.Text = "-"
                            tab2_txt_hb.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_hb.Text = mySqlReader("R3")

                        End If

                        If mySqlReader("R82") Is DBNull.Value Then
                            ComboBox26.Text = "-"
                            ComboBox26.BackColor = Color.DarkSeaGreen
                        Else
                            ComboBox26.Text = mySqlReader("R82")

                        End If
                        If mySqlReader("R52") Is DBNull.Value Then
                            tab3_txt_amphetamine.Text = "-"
                            tab3_txt_amphetamine.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_amphetamine.Text = mySqlReader("R52")

                        End If

                        If mySqlReader("R4") Is DBNull.Value Then
                            tab2_txt_hct.Text = "-"
                            tab2_txt_hct.BackColor = Color.DarkSeaGreen
                        Else

                            tab2_txt_hct.Text = mySqlReader("R4")

                        End If
                        If mySqlReader("R1") Is DBNull.Value Then
                            tab2_txt_wbc.Text = "-"
                            tab2_txt_wbc.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_wbc.Text = mySqlReader("R1")
                        End If
                        If mySqlReader("R15") Is DBNull.Value Then
                            tab2_txt_atypical.Text = "-"
                            tab2_txt_atypical.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_atypical.Text = mySqlReader("R15")

                        End If

                        If mySqlReader("R14") Is DBNull.Value Then

                            tab2_txt_bashophils.Text = "-"
                            tab2_txt_bashophils.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_bashophils.Text = mySqlReader("R14")
                        End If

                        If mySqlReader("R13") Is DBNull.Value Then
                            tab2_txt_eosinophils.Text = "-"
                            tab2_txt_eosinophils.BackColor = Color.DarkSeaGreen
                        Else

                            tab2_txt_eosinophils.Text = mySqlReader("R13")
                        End If

                        If mySqlReader("R11") Is DBNull.Value Then
                            tab2_txt_lymphocytes.Text = "-"
                            tab2_txt_lymphocytes.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_lymphocytes.Text = mySqlReader("R11")
                        End If

                        If mySqlReader("R12") Is DBNull.Value Then
                            tab2_txt_monocytes.Text = "-"
                            tab2_txt_monocytes.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_monocytes.Text = mySqlReader("R12")
                        End If

                        If mySqlReader("R10") Is DBNull.Value Then
                            tab2_txt_neutrophils.Text = "-"
                            tab2_txt_neutrophils.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_neutrophils.Text = mySqlReader("R10")
                        End If


                        If mySqlReader("R8") Is DBNull.Value Then
                            tab2_txt_plate.Text = "-"
                            tab2_txt_plate.BackColor = Color.DarkSeaGreen
                        Else
                            tab2_txt_plate.Text = mySqlReader("R8")
                        End If


                        ' tab3


                        If mySqlReader("R32") Is DBNull.Value Then
                            tab3_txt_color.Text = "-"
                            tab3_txt_color.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_color.Text = mySqlReader("R32")
                        End If


                        If mySqlReader("R33") Is DBNull.Value Then
                            tab3_txt_appearance.Text = "-"
                            tab3_txt_appearance.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_appearance.Text = mySqlReader("R33")
                        End If

                        If mySqlReader("R34") Is DBNull.Value Then
                            tab3_txt_spgr.Text = "-"
                            tab3_txt_spgr.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_spgr.Text = mySqlReader("R34")
                        End If
                        If mySqlReader("R36") Is DBNull.Value Then
                            tab3_txt_albumin.Text = "-"
                            tab3_txt_albumin.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_albumin.Text = mySqlReader("R36")
                        End If
                        If mySqlReader("R37") Is DBNull.Value Then
                            tab3_txt_glucose.Text = "-"
                            tab3_txt_glucose.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_glucose.Text = mySqlReader("R37")
                        End If


                        If mySqlReader("R41") Is DBNull.Value Then
                            tab3_txt_blood.Text = "-"
                            tab3_txt_blood.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_blood.Text = mySqlReader("R41")
                        End If

                        If mySqlReader("R35") Is DBNull.Value Then
                            tab3_txt_ph.Text = "-"
                            tab3_txt_ph.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_ph.Text = mySqlReader("R35")
                        End If


                        If mySqlReader("R44") Is DBNull.Value Then
                            tab3_txt_rbc.Text = "-"
                            tab3_txt_rbc.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_rbc.Text = mySqlReader("R44")
                        End If


                        If mySqlReader("R45") Is DBNull.Value Then
                            tab3_txt_wbc.Text = "-"
                            tab3_txt_wbc.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_wbc.Text = mySqlReader("R45")
                        End If


                        If mySqlReader("R46") Is DBNull.Value Then
                            tab3_txt_epi.Text = "-"
                            tab3_txt_epi.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_epi.Text = mySqlReader("R46")
                        End If


                        'tab4

                        If mySqlReader("R54") Is DBNull.Value Then
                            tab4_txt_fbs.Text = "-"
                            tab4_txt_fbs.BackColor = Color.DarkSeaGreen
                        Else
                            tab4_txt_fbs.Text = mySqlReader("R54")

                            Dim int_fbs As Integer
                            int_fbs = Integer.Parse(tab4_txt_fbs.Text)
                            tab4_txt_fbs.Text = int_fbs

                            If int_fbs >= 70 And int_fbs <= 110 Then
                                tab4_result_fbs.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_fbs > 111 And int_fbs <= 125 Then
                                If check_sub = 0 Then
                                    tab4_result_fbs.Text = "การควบคุมน้ำตาลบกพร่อง   ควรลดอาหาร แป้ง รับประทานผัก ผลไม้ มากขึ้น และตรวจซ้ำ 1 เดือน"
                                ElseIf check_sub = 1 Then
                                    tab4_result_fbs.Text = "Impaired glucose control : Reduce sweet foods,flour.Eat more fruit and vegetables and repeat blood test in 1 month."

                                End If

                            ElseIf int_fbs > 125 Then
                                If check_sub = 0 Then
                                    tab4_result_fbs.Text = "มีภาวะเบาหวาน แนะนำควรพบแพทย์"
                                ElseIf check_sub = 1 Then
                                    tab4_result_fbs.Text = "Consult Doctor."
                                End If


                            ElseIf int_fbs < 50 Then
                                If check_sub = 0 Then
                                    tab4_result_fbs.Text = "ภาวะน้ำตาลในเลือดต่ำ  ควรพบแพทย์เพื่อหาสาเหตุ"
                                ElseIf check_sub = 1 Then
                                    tab4_result_fbs.Text = "Consult Doctor."
                                End If

                            End If
                        End If





                        'tab5
                        If mySqlReader("R55") Is DBNull.Value Then
                            tab5_txt_bun.Text = "-"
                            tab5_txt_bun.BackColor = Color.DarkSeaGreen
                        Else
                            tab5_txt_bun.Text = mySqlReader("R55")
                            Dim int_bun As Integer
                            int_bun = Integer.Parse(tab5_txt_bun.Text)
                            tab5_txt_bun.Text = int_bun

                            If int_bun >= 7 And int_bun <= 20 Then

                                tab5_result_bun.Text = "อยู่ในเกณฑ์ปกติ (Normal)"


                            ElseIf int_bun > 20 Then
                                If check_sub = 0 Then
                                    tab5_result_bun.Text = "การทำงานของไตสูงกว่าปกติ   ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_bun.Text = "The hardness of renal function Follow up every year"
                                End If

                            ElseIf int_bun < 7 Then
                                If check_sub = 0 Then
                                    tab5_result_bun.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_bun.Text = "Non effect to diagnosis"

                                End If

                            End If
                        End If


                        If mySqlReader("R57") Is DBNull.Value Then
                            tab5_txt_cholesterol.Text = "-"
                            tab5_txt_cholesterol.BackColor = Color.DarkSeaGreen
                        Else
                            tab5_txt_cholesterol.Text = mySqlReader("R57")
                            Dim int_cholesterol As Integer
                            int_cholesterol = Integer.Parse(tab5_txt_cholesterol.Text)
                            tab5_txt_cholesterol.Text = int_cholesterol


                            If int_cholesterol >= 0 And int_cholesterol <= 200 Then
                                tab5_result_cholesterol.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_cholesterol > 200 Then

                                If check_sub = 0 Then
                                    tab5_result_cholesterol.Text = "ไขมันในเลือดสูง   หลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตาม หรือตามคำแนะนำ ของแพทย์"
                                ElseIf check_sub = 1 Then
                                    tab5_result_cholesterol.Text = "High cholesterol levels Dyslipidemia  Avoid or reduce fat food, including seafood , egg, yolks etc. Exercise regulary and Follow up a Doctor's instroduction."

                                End If



                            End If
                        End If

                        If mySqlReader("R56") Is DBNull.Value Then
                            tab5_txt_creatinine.Text = "-"
                            tab5_txt_creatinine.BackColor = Color.DarkSeaGreen
                        Else
                            tab5_txt_creatinine.Text = mySqlReader("R56")
                            Dim int_creatinine As Double
                            int_creatinine = Double.Parse(tab5_txt_creatinine.Text)
                            tab5_txt_creatinine.Text = int_creatinine

                            If int_creatinine >= 0.7 And int_creatinine <= 1.5 Then
                                tab5_result_creatinine.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_creatinine > 1.5 Then
                                If check_sub = 0 Then

                                    tab5_result_creatinine.Text = "การทำงานของไตสูงกว่าปกติ   ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_creatinine.Text = "Renal Insuffciency Follow up every year"

                                End If

                            ElseIf int_creatinine < 0.7 Then

                                If check_sub = 0 Then
                                    tab5_result_creatinine.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_creatinine.Text = "Non effect to diagnosis"
                                End If
                            End If

                        End If


                        If mySqlReader("R59") Is DBNull.Value Then
                            tab5_txt_hdl.Text = "-"
                            tab5_txt_hdl.BackColor = Color.DarkSeaGreen
                        Else
                            tab5_txt_hdl.Text = mySqlReader("R59")

                            Dim int_hdl As Integer
                            int_hdl = Integer.Parse(tab5_txt_hdl.Text)
                            tab5_txt_hdl.Text = int_hdl

                            If int_hdl >= 40 And int_hdl <= 60 Then
                                tab5_result_hdl.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_hdl > 60 Then
                                tab5_result_hdl.Text = "มีระดับดี   ลดภาวะเสี่ยงจากโรคหลอดเลือดหัวใจและหลอดเลือดสมองตีบ"
                            ElseIf int_hdl < 40 Then
                                tab5_result_hdl.Text = "ต่ำกว่าปกติ   เพิ่มความเสี่ยงต่อโรคหลอดเลือดหัวใจและหลอดเลือดสมองตีบ"

                            End If
                        End If



                        If mySqlReader("R58") Is DBNull.Value Then
                            tab5_txt_trigyceride.Text = "-"
                            tab5_txt_trigyceride.BackColor = Color.DarkSeaGreen
                        Else
                            tab5_txt_trigyceride.Text = mySqlReader("R58")
                            Dim int_trigyceride As Integer
                            int_trigyceride = Integer.Parse(tab5_txt_trigyceride.Text)
                            tab5_txt_trigyceride.Text = int_trigyceride

                            If int_trigyceride >= 10 And int_trigyceride <= 150 Then
                                tab5_result_trigyceride.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_trigyceride > 150 Then
                                If check_sub = 0 Then

                                    tab5_result_trigyceride.Text = "ไขมันในเลือดสูง   หลีกเลี่ยงหรือลดอาหารประเภทแป้ง คาร์โบไฮเดรตสูง ของหวาน สุรา เบียร์ เป็นต้น ออกกำลังกายสม่ำเสมอและตรวจติดตาม หรือตามคำแนะนำ ของแพทย์"
                                ElseIf check_sub = 1 Then
                                    tab5_result_trigyceride.Text = "High triglyceride levels Dyslipidemia Avoid or reduce flour,carbohydrate,desert,alcohol,beer etc. Exercise regulary and follow up or a Doctor's instroduction."
                                End If


                            End If


                        End If


                        If mySqlReader("R61") Is DBNull.Value Then
                            tab5_txt_uricacid.Text = "-"
                            tab5_txt_uricacid.BackColor = Color.DarkSeaGreen
                        Else
                            tab5_txt_uricacid.Text = mySqlReader("R61")
                            Dim int_uricacid As Double
                            int_uricacid = Double.Parse(tab5_txt_uricacid.Text)
                            tab5_txt_uricacid.Text = int_uricacid

                            If int_uricacid >= 2.5 And int_uricacid <= 8.5 Then
                                tab5_result_uricacid.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_uricacid > 8.5 Then

                                If check_sub = 0 Then

                                    tab5_result_uricacid.Text = "สูงกว่าปกติ   ควรหลีกเลี่ยงการรับประทานอาหารประเภทสัตว์ปีก เครื่องในสัตว์ หรือผักบางชนิด ยอดผัก เช่น หน่อไม้ กระถิน กะหล่ำปลี แอลกอฮอล์ เหล้า เบียร์ และตรวจติดตาม"
                                ElseIf check_sub = 1 Then
                                    tab5_result_uricacid.Text = "High than normal : Avoid eating poultry,animala'entrails, some vegetables such as asparagus,cabbage etc. alcohol,beer and Follow up."
                                End If


                            ElseIf int_uricacid < 2.5 Then

                                If check_sub = 0 Then
                                    tab5_result_uricacid.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_uricacid.Text = "Non effect to diagnosis  : Follow up every year"
                                End If

                            End If

                        End If


                        'tab6

                        If mySqlReader("R66") Is DBNull.Value Then
                            tab6_txt_afp.Text = "-"
                            tab6_txt_afp.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_txt_afp.Text = mySqlReader("R66")


                            Dim int_afp As Double
                            int_afp = Double.Parse(tab6_txt_afp.Text)
                            tab6_txt_afp.Text = int_afp

                            If int_afp >= 0 And int_afp <= 7.51 Then
                                tab6_result_afp.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_afp > 7.51 Then
                                tab6_result_afp.Text = "ค่าบ่งชี้มะเร็งในตับสูงกว่าในปกติ ตรวจติดตามกับอายุรแพทย์ ระบบทางเดินอาหาร"

                            End If

                        End If

                        If mySqlReader("R62") Is DBNull.Value Then
                            tab6_txt_alkaline.Text = "-"
                            tab6_txt_alkaline.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_txt_alkaline.Text = mySqlReader("R62")


                            Dim int_alk As Integer
                            int_alk = Integer.Parse(tab6_txt_alkaline.Text)
                            tab6_txt_alkaline.Text = int_alk
                            If int_alk >= 38 And int_alk <= 126 Then
                                tab6_result_alkaline.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_alk > 126 And int_alk < 199 Then

                                If check_sub = 0 Then
                                    tab6_result_alkaline.Text = "สูงกว่าปกติ   แนะนำตรวจติดตามและตรวจซ้ำภายใน 3 เดือน"
                                ElseIf check_sub = 1 Then
                                    tab6_result_alkaline.Text = "Follow up and Repeated blood test in 3 month"
                                End If

                            ElseIf int_alk > 200 Then
                                If check_sub = 0 Then
                                    tab6_result_alkaline.Text = "สงสัยมีภาวะอุดกั้นทางเดินน้ำดี   แนะนำปรึกษาแพทย์"
                                ElseIf check_sub = 1 Then
                                    tab6_result_alkaline.Text = "Should Consult a Doctor."
                                End If
                            ElseIf int_alk < 38 Then

                                If check_sub = 0 Then
                                    tab6_result_alkaline.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตาม"
                                ElseIf check_sub = 1 Then
                                    tab6_result_alkaline.Text = "Non effect to diagnosis  Follow up every year"
                                End If

                            End If


                        End If
                        If mySqlReader("R60") Is DBNull.Value Then
                            tab6_txt_ldl.Text = "-"
                            tab6_txt_ldl.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_txt_ldl.Text = mySqlReader("R60")
                            If IsNumeric(tab6_txt_ldl.Text) Then
                                Dim int_ldl As Integer
                                int_ldl = Integer.Parse(tab6_txt_ldl.Text)
                                tab6_txt_ldl.Text = int_ldl

                                If int_ldl >= 30 And int_ldl <= 100 Then
                                    tab6_result_ldl.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                                ElseIf int_ldl > 100 Then
                                    tab6_result_ldl.Text = "ไขมันในเลือดสูง   หลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์ เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตาม หรือตามคำแนะนำของแพทย์"

                                End If
                            End If


                        End If
                        If mySqlReader("R70") Is DBNull.Value Then
                            tab6_txt_sgot.Text = "-"
                            tab6_txt_sgot.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_txt_sgot.Text = mySqlReader("R70")

                            Dim int_sgot As Integer
                            int_sgot = Integer.Parse(tab6_txt_sgot.Text)
                            tab6_txt_sgot.Text = int_sgot


                            If int_sgot >= 15 And int_sgot <= 46 Then
                                tab6_result_sgot.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_sgot > 46 Then

                                If check_sub = 0 Then
                                    tab6_result_sgot.Text = "เอนไซม์ตับสูงกว่าปกติ   ควรลดอาหารไขมัน หลีกเลี่ยงแอลกอออล(ถ้าดื่ม) ออกกำลังกายสม่ำเสมอ และตรวจติดตาม"
                                ElseIf check_sub = 1 Then
                                    tab6_result_sgot.Text = "High liver enzymes Reduce fat food, avoid alcohol (a drink), Exercise regulary and follow up."
                                End If

                            ElseIf int_sgot < 15 Then
                                If check_sub = 0 Then

                                    tab6_result_sgot.Text = "ไม่มีผลต่อการวินิจฉัย   ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab6_result_sgot.Text = "Non effect to diagnosis  Follow up very Year"
                                End If


                            ElseIf int_sgot > 100 Then
                                If check_sub = 0 Then
                                    tab6_result_sgot.Text = "มีภาวะตับอักเสบ"
                                ElseIf check_sub = 1 Then
                                    tab6_result_sgot.Text = "Hepatitis"
                                End If
                            End If

                        End If


                        If mySqlReader("R71") Is DBNull.Value Then
                            tab6_txt_sgpt.Text = "-"
                            tab6_txt_sgpt.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_txt_sgpt.Text = mySqlReader("R71")
                            Dim int_sgpt As Integer
                            int_sgpt = Integer.Parse(tab6_txt_sgpt.Text)
                            tab6_txt_sgpt.Text = int_sgpt

                            If int_sgpt >= 13 And int_sgpt <= 69 Then
                                tab6_result_spgt.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_sgpt > 69 Then

                                If check_sub = 0 Then
                                    tab6_result_spgt.Text = "เอนไซม์ตับสูงกว่าปกติ   ควรลดอาหารไขมัน หลีกเลี่ยงแอลกอออล(ถ้าดื่ม) ออกกำลังกายสม่ำเสมอ และตรวจติดตาม"

                                ElseIf check_sub = 1 Then
                                    tab6_result_spgt.Text = "High liver enzymes Reduce fat food,avoid alcohol (a drink) Exercise regulary and follow up."
                                End If

                            ElseIf int_sgpt < 13 Then

                                If check_sub = 0 Then
                                    tab6_result_spgt.Text = "ไม่มีผลต่อการวินิจฉัย"
                                ElseIf check_sub = 1 Then
                                    tab6_result_spgt.Text = "Non effect to diagnosis"
                                End If

                            End If




                        End If



                        If mySqlReader("R77") Is DBNull.Value Then
                            tab6_stool_wbc.Text = "-"
                            tab6_stool_wbc.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_stool_wbc.Text = mySqlReader("R77")
                        End If

                        If mySqlReader("R76") Is DBNull.Value Then
                            tab6_stool_rbc.Text = "-"
                            tab6_stool_rbc.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_stool_rbc.Text = mySqlReader("R76")
                        End If

                        If mySqlReader("R78") Is DBNull.Value Then
                            tab6_stool_parasites.Text = "-"
                            tab6_stool_parasites.BackColor = Color.DarkSeaGreen

                        Else
                            tab6_stool_parasites.Text = mySqlReader("R78")
                        End If

                        If mySqlReader("R75") Is DBNull.Value Then
                            tab6_stool_blood.Text = "-"
                            tab6_stool_blood.BackColor = Color.DarkSeaGreen
                        Else
                            tab6_stool_blood.Text = mySqlReader("R75")
                        End If

                        If mySqlReader("R81") Is DBNull.Value Then
                            tab3_txt_vdrl.Text = "-"
                            tab3_txt_vdrl.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_vdrl.Text = mySqlReader("R81")
                        End If


                        If mySqlReader("R84") Is DBNull.Value Then
                            tab3_txt_hiv.Text = "-"
                            tab3_txt_hiv.BackColor = Color.DarkSeaGreen
                        Else
                            tab3_txt_hiv.Text = mySqlReader("R84")
                        End If

                        If mySqlReader("R63") Is DBNull.Value Then
                            txt_hbsag.Text = "-"
                            txt_hbsag.BackColor = Color.DarkSeaGreen
                        Else
                            txt_hbsag.Text = mySqlReader("R63")
                        End If

                        If mySqlReader("R64") Is DBNull.Value Then
                            txt_hbsab.Text = "-"
                            txt_hbsab.BackColor = Color.DarkSeaGreen
                        Else
                            txt_hbsab.Text = mySqlReader("R64")
                        End If

                        If mySqlReader("R86") Is DBNull.Value Then
                            txt_anti_igg.Text = "-"
                            txt_anti_igg.BackColor = Color.DarkSeaGreen
                        Else
                            txt_anti_igg.Text = mySqlReader("R86")
                        End If
                        If mySqlReader("R87") Is DBNull.Value Then
                            txt_hav_igm.Text = "-"
                            txt_hav_igm.BackColor = Color.DarkSeaGreen
                        Else
                            txt_hav_igm.Text = mySqlReader("R87")
                        End If

                        If mySqlReader("R83") Is DBNull.Value Then
                            txt_hbcab.Text = "-"
                            txt_hbcab.BackColor = Color.DarkSeaGreen
                        Else
                            txt_hbcab.Text = mySqlReader("R83")
                        End If
                        If mySqlReader("R65") Is DBNull.Value Then
                            TextBox5.Text = "-"
                            TextBox5.BackColor = Color.DarkSeaGreen
                        Else
                            TextBox5.Text = mySqlReader("R65")
                        End If


                    End While

                    Dim date_one As String
                    Dim date_two As String
                    Dim date_time1() As String
                    Dim date_new As String

                    date_time1 = Split(txt_date.Text, "/")
                    date_one = Trim(date_time1(0).ToString)
                    date_two = Trim(date_time1(1).ToString)
                    If date_one.Length = 1 Then
                        date_one = "0" + date_one
                    End If
                    If date_two.Length = 1 Then
                        date_two = "0" + date_two
                    End If

                    date_new = date_time1(2).ToString + date_two + date_one
                    MyODBCConnection.Close()
                    If MyODBCConnection.State = ConnectionState.Closed Then
                        MyODBCConnection.Open()
                    End If


                    selectCMD = New OdbcCommand("SELECT OPHRESULT,OPHOTHTYP,OPHOTHCOD FROM OPDOTHV5PF WHERE OPHREGDTE like '" & date_new & "' and OPHHN like '" & id_hn & "'")

                    selectCMD.Connection = MyODBCConnection


                    Try
                        'Set the mouse to show a Wait cursor
                        Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                        'start the Read loop
                        While dr.Read
                            'Note: the numbers in double quotes represent the column number from the AS400 database
                            'Add the data to the list view
                            If dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "01" Then
                                tab1_tab_weight.Text = dr.GetString(0).Trim
                            ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "03" Then
                                tab1_txt_height.Text = dr.GetString(0).Trim
                            ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "04" Then
                                tab1_txt_pulserate.Text = dr.GetString(0).Trim
                            ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "05" Then
                                tab1_txt_bloodp.Text = dr.GetString(0).Trim
                            End If
                            'End the loop
                        End While
                        'Reset the cursor


                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    MyODBCConnection.Close()
                    bmi_cal()


                Else


                    Dim NextForm As frmOilOackage_1 = New frmOilOackage_1(mysqlpass, ipconnect, usernamedb, dbname, txtsearch.Text, idcompany)
                    '  Dim NextForm As main_user = New main_user()
                    NextForm.Show()
                    Me.Close()


                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            mysql.Close()


        End If

    End Sub
    Private Sub clear()
        tab1_txt_bmi.Text = "-"
        tab1_txt_bloodp.Text = "-"
        tab1_txt_eyer.Text = "-"
        tab1_txt_eyel.Text = "-"
        RichTextBox5.Text = "-"
        tab1_txt_pulserate.Text = "-"
        tab1_txt_height.Text = "-"
        tab1_tab_weight.Text = "-"
        check_group = ""
        count_group = 1
        check_form = "0"

        result_all = ""
        urine_other = "-"
        pap_text = "-"
        pap_result = "-"

        red_homology = " "
        address = " "
        export_date = " "
        tellephone = " "
        result_phy = " "
        result_hematology = " "
        result_urine = " "
        result_physical = " "
        result_xray = " "
        result_ultrasound = " "
        result_ekg = " "
        result_bloodchem = " "
        result_bun = " "
        result_creatinine = " "
        result_uricacid = " "
        result_cholesterol = " "
        result_triglyceride = " "
        result_hdl = " "
        result_ldl = " "
        result_sgot = " "
        result_sgpt = " "
        result_alkaline = " "
        result_afp = " "
        result_pfp = " "
        result_fbs = " "
        phy_height = "-"
        phy_weight = "-"
        phy_bmi = "-"
        phy_bloodpressure = " "
        phy_pulse = " "
        phy_eye_left = " "
        phy_eye_right = " "
        phy_dental = " "
        tab2_redcell = " "

        result_pulserate = " "
        result_eye = " "
        under = " "



        TextBox5.Text = "-"
        TextBox5.BackColor = Color.Empty

        txt_hbsab.Text = " "
        txt_hbsab.BackColor = Color.Empty

        txt_hbsag.Text = " "
        txt_hbsag.BackColor = Color.Empty

        txt_hbcab.Text = " "
        txt_hbcab.BackColor = Color.Empty

        tab3_txt_hiv.Text = " "
        tab3_txt_hiv.BackColor = Color.Empty


        tab3_txt_vdrl.Text = " "
        tab3_txt_vdrl.BackColor = Color.Empty

        tab6_stool_blood.Text = " "
        tab6_stool_blood.BackColor = Color.Empty


        tab6_stool_parasites.Text = " "
        tab6_stool_parasites.BackColor = Color.Empty


        tab6_stool_rbc.Text = " "
        tab6_stool_rbc.BackColor = Color.Empty


        tab6_stool_wbc.Text = " "
        tab6_stool_wbc.BackColor = Color.Empty





        tab4_result_phy.Text = " "
        tab4_result_ekg.Text = " "
        tab4_result_x_ray.Text = " "
        tab4_result_vdrl.Text = " "
        tab6_result_psp.Text = " "
        TextBox6.Text = "-"

        tab1_txt_eyel.Text = " "
        tab1_txt_eyer.Text = " "

        'tab2 
        tab2_txt_hb.BackColor = Color.Empty
        tab2_txt_hct.BackColor = Color.Empty
        tab2_txt_atypical.BackColor = Color.Empty
        tab2_txt_bashophils.BackColor = Color.Empty
        tab2_txt_eosinophils.BackColor = Color.Empty
        tab2_txt_groupblood.BackColor = Color.Empty
        tab2_txt_lymphocytes.BackColor = Color.Empty
        tab2_txt_neutrophils.BackColor = Color.Empty
        tab2_txt_plate.BackColor = Color.Empty
        tab2_txt_redcell.BackColor = Color.Empty
        tab2_txt_wbc.BackColor = Color.Empty
        tab2_txt_monocytes.BackColor = Color.Empty

        tab2_txt_monocytes.Text = " "
        tab2_txt_wbc.Text = " "
        tab2_txt_rh.Text = " "
        tab2_txt_wbc.Text = " "
        tab2_txt_hb.Text = " "
        tab2_txt_hct.Text = " "
        tab2_txt_atypical.Text = " "
        tab2_txt_bashophils.Text = " "
        tab2_txt_eosinophils.Text = " "
        tab2_txt_groupblood.Text = " "
        tab2_txt_lymphocytes.Text = " "
        tab2_txt_neutrophils.Text = " "
        tab2_txt_plate.Text = " "
        tab2_txt_redcell.Text = " "
        tab2_txt_rh.Text = " "
        tab2_txt_wbc.Text = " "



        'tab 3
        tab3_txt_albumin.BackColor = Color.Empty
        tab3_txt_albumin.Text = " "

        tab3_txt_appearance.BackColor = Color.Empty
        tab3_txt_appearance.Text = " "

        tab3_txt_blood.BackColor = Color.Empty
        tab3_txt_blood.Text = " "

        tab3_txt_color.BackColor = Color.Empty
        tab3_txt_color.Text = " "



        tab3_txt_epi.BackColor = Color.Empty
        tab3_txt_epi.Text = " "

        tab3_txt_glucose.BackColor = Color.Empty
        tab3_txt_glucose.Text = " "

        tab3_txt_other.BackColor = Color.Empty
        tab3_txt_other.Text = " "

        tab3_txt_ph.BackColor = Color.Empty
        tab3_txt_ph.Text = " "

        tab3_txt_rbc.BackColor = Color.Empty
        tab3_txt_rbc.Text = " "

        tab3_txt_spgr.BackColor = Color.Empty
        tab3_txt_spgr.Text = " "

        tab3_txt_wbc.BackColor = Color.Empty

        tab3_txt_wbc.Text = " "
        tab4_result_ekg.Text = " "
        tab4_result_fbs.Text = " "
        tab4_result_phy.Text = " "
        tab4_result_vdrl.Text = " "
        tab4_result_x_ray.Text = " "

        TextBox5.Text = "-"
        tab4_txt_fbs.Text = " "
        tab4_txt_fbs.BackColor = Color.Empty
        tab4_result_fbs.Text = " "

        'tab5
        tab5_txt_bun.BackColor = Color.Empty
        tab5_txt_bun.Text = " "
        tab5_result_bun.Text = " "

        tab5_txt_cholesterol.BackColor = Color.Empty
        tab5_txt_cholesterol.Text = " "
        tab5_result_cholesterol.Text = " "
        tab5_txt_creatinine.BackColor = Color.Empty
        tab5_txt_creatinine.Text = " "
        tab5_result_creatinine.Text = " "
        tab5_txt_hdl.BackColor = Color.Empty
        tab5_txt_hdl.Text = " "
        tab5_result_hdl.Text = " "
        tab5_txt_trigyceride.BackColor = Color.Empty
        tab5_txt_trigyceride.Text = " "
        tab5_result_trigyceride.Text = " "
        tab5_txt_uricacid.BackColor = Color.Empty
        tab5_txt_uricacid.Text = " "
        tab5_result_uricacid.Text = " "

        'tab6.
        tab6_txt_afp.BackColor = Color.Empty
        tab6_txt_afp.Text = " "
        tab6_result_afp.Text = " "
        tab6_txt_alkaline.BackColor = Color.Empty
        tab6_txt_alkaline.Text = " "
        tab6_result_alkaline.Text = " "
        tab6_txt_ldl.BackColor = Color.Empty
        tab6_txt_ldl.Text = " "
        tab6_result_ldl.Text = " "
        ComboBox19.Text = "-"
        tab6_result_psp.Text = " "

        tab6_txt_sgot.BackColor = Color.Empty
        tab6_txt_sgot.Text = " "
        tab6_result_sgot.Text = " "

        tab6_txt_sgpt.BackColor = Color.Empty
        tab6_txt_sgpt.Text = " "
        tab6_result_spgt.Text = " "

        r_eye1.Checked = True
        neck1.Checked = True
        heart1.Checked = True
        vas1.Checked = True
        chest1.Checked = True
        ab1.Checked = True
        lymp1.Checked = True
        gu1.Checked = True
        ex1.Checked = True
        spine1.Checked = True
        skin1.Checked = True
        audio1.Checked = True
        lung1.Checked = True
        ekg1.Checked = True
        RichTextBox5.Text = ""
        tab1_result_blindness.Text = ""
        tab1_result_eye.Text = ""
        tab1_result_tooth.Text = ""
        ComboBox25.Text = "ปกติ"
        Blind_Color.Text = "ปกติ"
        ComboBox1.Text = "ปกติ"
        ComboBox24.Text = "ปกติ"


        Me.Refresh()
    End Sub
    Private Sub check_radio()
        If r_eye1.Checked = True Then
            r_eye = "Normal"
        ElseIf r_eye2.Checked = True Then
            r_eye = "Abnormal"
        ElseIf r_eye3.Checked = True Then
            r_eye = "NoData"
        End If

        If neck1.Checked = True Then
            neck = "Normal"
        ElseIf neck2.Checked = True Then
            neck = "Abnormal"
        ElseIf neck3.Checked = True Then
            neck = "NoData"
        End If

        If heart1.Checked = True Then
            heart = "Normal"
        ElseIf heart2.Checked = True Then
            heart = "Abnormal"
        ElseIf heart3.Checked = True Then
            heart = "NoData"
        End If

        If vas1.Checked = True Then
            vas = "Normal"
        ElseIf vas2.Checked = True Then
            vas = "Abnormal"
        ElseIf vas3.Checked = True Then
            vas = "NoData"
        End If

        If ab1.Checked = True Then
            ab = "Normal"
        ElseIf ab2.Checked = True Then
            ab = "Abnormal"
        ElseIf ab3.Checked = True Then
            ab = "NoData"
        End If

        If lymp1.Checked = True Then
            lymp = "Normal"
        ElseIf lymp2.Checked = True Then
            lymp = "Abnormal"
        ElseIf lymp3.Checked = True Then
            lymp = "NoData"
        End If

        If gu1.Checked = True Then
            gu = "Normal"
        ElseIf gu2.Checked = True Then
            gu = "Abnormal"
        ElseIf gu3.Checked = True Then
            gu = "NoData"
        End If

        If ex1.Checked = True Then
            ex = "Normal"
        ElseIf ex2.Checked = True Then
            ex = "Abnormal"
        ElseIf ex3.Checked = True Then
            ex = "NoData"
        End If

        If spine1.Checked = True Then
            spine = "Normal"
        ElseIf spine2.Checked = True Then
            spine = "Abnormal"
        ElseIf spine3.Checked = True Then
            spine = "NoData"
        End If

        If skin1.Checked = True Then
            skins = "Normal"
        ElseIf skin2.Checked = True Then
            skins = "Abnormal"
        ElseIf skin3.Checked = True Then
            skins = "NoData"
        End If

        If audio1.Checked = True Then
            audio = "Normal"
        ElseIf audio2.Checked = True Then
            audio = "Abnormal"
        ElseIf audio3.Checked = True Then
            audio = "NoData"
        End If

        If lung1.Checked = True Then
            lung = "Normal"
        ElseIf lung2.Checked = True Then
            lung = "Abnormal"
        ElseIf lung3.Checked = True Then
            lung = "NoData"
        End If

        If ekg1.Checked = True Then
            ekg = "Normal"
        ElseIf ekg2.Checked = True Then
            ekg = "Abnormal"
        ElseIf ekg3.Checked = True Then
            ekg = "NoData"
        End If

        If chest1.Checked = True Then
            chest = "Normal"
        ElseIf chest2.Checked = True Then
            chest = "Abnormal"
        ElseIf chest3.Checked = True Then
            chest = "NoData"

        End If
        If eye_in.Checked = True Then
            glass = "1"
        ElseIf eye_out.Checked = True Then
            glass = "0"
        ElseIf eye_not.Checked = True Then
            glass = "3"
        End If

    End Sub
    Public Sub prnoil()
        company_name = txtcompany.Text
        phy_bloodpressure = tab1_txt_bloodp.Text
        phy_bmi = tab1_txt_bmi.Text
        phy_eye_left = tab1_txt_eyel.Text
        phy_eye_right = tab1_txt_eyer.Text
        phy_height = tab1_txt_height.Text
        phy_weight = tab1_tab_weight.Text
        phy_pulse = tab1_txt_pulserate.Text
        bmi = tab1_txt_bmi.Text
        igg = txt_anti_igg.Text
        igm = txt_hav_igm.Text
        mercury = TextBox6.Text
        cea = TextBox5.Text
        Stool_culture = ComboBox26.Text
        amphetamine = tab3_txt_amphetamine.Text
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        update_data()


        date_string = txt_date.Text
        If CheckBox1.Checked = True Then
            id_hn = txtsearch.Text
            result_xray = tab4_result_x_ray.Text
            count_group = 1
            count_result = 1
            other_fit = txt_other_fit.Text
            checkaddress = CheckBox8.Checked
            address = txt_address.Text
            check_radio()
            prnoil()
            check_box()
            doctor_name = txt_doctor_name.Text
            license = txt_license.Text
            name_lastname = txt_name.Text + " " + txt_lastname.Text
            name_eng = txt_name.Text
            lastname_eng = txt_lastname.Text
            blood_pressure_result_txt = blood_pressure_result.Text
            eye_result_txt = eye_result.Text
            result_all = " "
            result_all = RichTextBox1.Text
            date_string = txt_date.Text

            savedata()

            ipconnect = "192.0.0.204"
            mysqlpass = "sa"
            usernamedb = "sa"
            dbname = "lab_rajyindee"
            Stool_culture = ComboBox26.Text
            color_blind = Blind_Color.Text
            Dim NextForm As prnOilPackage = New prnOilPackage(mysqlpass, ipconnect, usernamedb, dbname, id_hn, export_id)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()

        Else

            date_string = txt_date.Text
            result_xray = tab4_result_x_ray.Text
            count_group = 1
            count_result = 1
            other_fit = txt_other_fit.Text
            result_all = " "

            check_radio()
            prnoil()
            check_box()
            doctor_name = txt_doctor_name.Text
            license = txt_license.Text
            name_lastname = txt_name.Text + " " + txt_lastname.Text
            name_eng = txt_name.Text
            lastname_eng = txt_lastname.Text
            RichTextBox1.Text = result_all
        End If

    End Sub
    Public Sub check_box()


        Dim int_fbs As Integer


        If ComboBox25.Text = "2.สายตามองเห็นชัดลดลง" Then
            result_all = result_all + "- " + RichTextBox5.Text + Environment.NewLine
            count_result = count_result + 1
        ElseIf ComboBox25.Text = "3.สายตาสั้น" Then
            result_all = result_all + "- " + RichTextBox5.Text + Environment.NewLine
            count_result = count_result + 1
        End If


        If Blind_Color.Text = "2.มีภาวะตาบอดสี" Then
            result_all = result_all + "- " + tab1_result_blindness.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox1.Text = "2.ต้อลม" Then
            result_all = result_all + "- " + tab1_result_eye.Text + Environment.NewLine
            count_result = count_result + 1
        ElseIf ComboBox1.Text = "3.ต้อเนื้อ" Then
            result_all = result_all + "- " + tab1_result_eye.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox24.Text = "2.ฟันมีหินปูน" Then
            result_all = result_all + "- " + tab1_result_tooth.Text + Environment.NewLine
            count_result = count_result + 1
        ElseIf ComboBox24.Text = "3.ฟันผุ" Then
            result_all = result_all + "- " + tab1_result_tooth.Text + Environment.NewLine
            count_result = count_result + 1
        End If


        If tab4_result_fbs.Text.Length > 1 Then
            int_fbs = Integer.Parse(tab4_txt_fbs.Text)
            If int_fbs > 111 And int_fbs <= 125 Then
                result_all = result_all + "- " + tab4_result_fbs.Text + Environment.NewLine
                count_result = count_result + 1
            ElseIf int_fbs > 125 Then
                result_all = result_all + "- " + tab4_result_fbs.Text + Environment.NewLine
                count_result = count_result + 1
            ElseIf int_fbs < 50 Then
                result_all = result_all + "- " + tab4_result_fbs.Text + Environment.NewLine
                count_result = count_result + 1
            End If
        End If


        If tab5_txt_bun.Text.Length > 1 Then

            Dim int_bun As Integer
            int_bun = Integer.Parse(tab5_txt_bun.Text)
            If int_bun > 20 Then
                result_all = result_all + "- " + tab5_result_bun.Text + Environment.NewLine
                count_result = count_result + 1
            End If



        End If



        If tab5_txt_creatinine.Text.Length > 1 Then
            Dim int_creatinine As Double
            int_creatinine = Double.Parse(tab5_txt_creatinine.Text)
            If int_creatinine > 1.5 Then
                result_all = result_all + "- " + tab5_result_creatinine.Text + Environment.NewLine
                count_result = count_result + 1
            End If
        End If


        If tab5_result_hdl.Text.Length > 1 Then

            Dim int_hdl As Integer
            int_hdl = Integer.Parse(tab5_txt_hdl.Text)
            If int_hdl < 40 Then
                result_all = result_all + "- " + tab5_result_hdl.Text + Environment.NewLine
                count_result = count_result + 1
            End If

        End If

        Dim int_ldl As Integer = 0
        Dim int_cholesterol As Integer = 0
        Dim int_trigyceride As Integer = 0

        If tab5_txt_cholesterol.Text.Length > 1 Then
            int_cholesterol = Integer.Parse(tab5_txt_cholesterol.Text)

        End If
        If tab5_txt_trigyceride.Text.Length > 1 Then

            int_trigyceride = Integer.Parse(tab5_txt_trigyceride.Text)
        End If


        If tab6_txt_ldl.Text.Length > 1 And IsNumeric(tab6_txt_ldl.Text) Then
            int_ldl = Integer.Parse(tab6_txt_ldl.Text)
        End If

        If int_cholesterol > 200 And int_ldl > 100 And int_trigyceride > 150 Then
            result_all = result_all + "-ไขมันคอเลสเตอรอล , ไขมันไตรกลีเซอไรด์ , ปริมาณไขมันความหนาแน่นต่ำ (LDL)ในเลือดสูง  หลีกเลี่ยงหรือลดอาหารประเภทแป้ง คาร์โบไฮเดรตสูง ของ หวาน สุรา เบียร์ และลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์ ออกกำลังกายสม่ำเสมอ และตรวจติดตาม หรือคำแนะนำของแพทย์" + Environment.NewLine
            count_result = count_result + 1
        Else
            If int_cholesterol > 200 And int_ldl > 100 Then
                result_all = result_all + "-ไขมันคอเลสเตอรอลและปริมาณไขมันความหนาแน่นต่ำ (LDL)ในเลือดสูง แนะนำหลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์ เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตามหรือตามคำแนะนำของแพทย์ " + Environment.NewLine
                count_result = count_result + 1
            ElseIf int_cholesterol > 200 And int_trigyceride > 150 Then
                result_all = result_all + "-ไขมันคอเลสเตอรอลและไขมันไตรกลีเซอไรด์ในเลือดสูง แนะนำหลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์ เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตามหรือตามคำแนะนำของแพทย์ " + Environment.NewLine
                count_result = count_result + 1
            ElseIf int_trigyceride > 150 And int_ldl > 100 Then
                result_all = result_all + "-ไขมันไตรกลีเซอไรด์และปริมาณไขมันความหนาแน่นต่ำ (LDL) ในเลือดสูง แนะนำหลีกเลี่ยงหรือลดอาหารประเภทไขมันมาก ได้แก่ อาหารทะเล ไข่แดง เครื่องในสัตว์ เป็นต้น ออกกำลังกายสม่ำเสมอ และตรวจติดตามหรือตามคำแนะนำของแพทย์ " + Environment.NewLine
                count_result = count_result + 1
            Else
                If int_cholesterol > 200 Then
                    result_all = result_all + "- " + tab5_result_cholesterol.Text + Environment.NewLine
                    count_result = count_result + 1
                End If
                If int_trigyceride > 150 Then
                    result_all = result_all + "- " + tab5_result_trigyceride.Text + Environment.NewLine
                    count_result = count_result + 1
                End If
                If int_ldl > 100 Then
                    result_all = result_all + "- " + tab6_result_ldl.Text + Environment.NewLine
                    count_result = count_result + 1
                End If
            End If

        End If




        If tab5_result_uricacid.Text.Length > 1 Then
            Dim int_uricacid As Double
            int_uricacid = Double.Parse(tab5_txt_uricacid.Text)
            If int_uricacid > 8.5 Then
                result_all = result_all + "- " + tab5_result_uricacid.Text + Environment.NewLine
                count_result = count_result + 1
            End If

        End If




        If tab6_result_afp.Text.Length > 1 Then
            Dim int_afp As Double
            int_afp = Double.Parse(tab6_txt_afp.Text)
            If int_afp > 7.51 Then
                result_all = result_all + "- " + tab6_result_afp.Text + Environment.NewLine
                count_result = count_result + 1
            End If
        End If




        If tab6_result_alkaline.Text.Length > 1 Then

            Dim int_alk As Integer
            int_alk = Integer.Parse(tab6_txt_alkaline.Text)
            If int_alk > 200 Then
                result_all = result_all + "- " + tab6_result_alkaline.Text + Environment.NewLine
                count_result = count_result + 1
            End If

        End If





        If tab6_txt_sgot.Text.Length > 1 Then
            Dim int_sgot As Integer
            int_sgot = Integer.Parse(tab6_txt_sgot.Text)

            If int_sgot > 46 And int_sgot < 100 Then
                result_all = result_all + "- เอนไซม์ตับสูงกว่าปกติ   ควรลดอาหารไขมัน หลีกเลี่ยงแอลกอออล(ถ้าดื่ม) ออกกำลังกายสม่ำเสมอ และตรวจติดตาม" + Environment.NewLine
                count_result = count_result + 1
            ElseIf int_sgot > 100 Then
                result_all = result_all + "- มีภาวะตับอักเสบ" + Environment.NewLine
                count_result = count_result + 1
            End If

        End If





        If tab6_txt_sgpt.Text.Length > 1 Then
            Dim int_sgpt As Integer
            int_sgpt = Integer.Parse(tab6_txt_sgpt.Text)
            If int_sgpt > 69 Then
                result_all = result_all + "- เอนไซม์ตับสูงกว่าปกติ   ควรลดอาหารไขมัน หลีกเลี่ยงแอลกอออล(ถ้าดื่ม) ออกกำลังกายสม่ำเสมอ และตรวจติดตาม" + Environment.NewLine
                count_result = count_result + 1
            End If
        End If



        check_group = ""
        count_group = 1
        check_form = "0"
        ' ตรวจสอบ result box




        If ComboBox3.Text = "2.ผิดปกติ" And tab2_result_txt.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล โลหิตวิทยา" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox3.Text = "2.ผิดปกติ" And tab2_result_txt.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab2_result_txt.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox21.Text = "2.ผิดปกติ" And RichTextBox3.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ผล Hiv Antibody " + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox21.Text = "2.ผิดปกติ" And RichTextBox3.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + RichTextBox3.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox22.Text = "2.ผิดปกติ" And tab6_result_virus_b.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ผล ไวรัสบี " + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox22.Text = "2.ผิดปกติ" And tab6_result_virus_b.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab6_result_virus_b.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox2.Text = "2.ผิดปกติ" And tab6_result_virus_b.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์การตรวจอุจาระ" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox2.Text = "2.ผิดปกติ" And tab6_result_virus_b.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab6_result_stool.Text + Environment.NewLine
            count_result = count_result + 1
        End If


        If ComboBox23.Text = "2.ผิดปกติ" And tab6_result_virus_b.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์การตรวจอุจาระ" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox23.Text = "2.ผิดปกติ" And tab6_result_virus_b.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + RichTextBox4.Text + Environment.NewLine
            count_result = count_result + 1
        End If



        If ComboBox7.Text = "2.ผิดปกติ" And RichTextBox2.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ผล ไวรัสบี " + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox7.Text = "2.ผิดปกติ" And RichTextBox2.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + RichTextBox2.Text + Environment.NewLine
            count_result = count_result + 1
        End If





        If ComboBox8.Text = "2.ผิดปกติ" And tab4_result_phy.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ทั่วไป Physical" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox8.Text = "2.ผิดปกติ" And tab4_result_phy.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab4_result_phy.Text + Environment.NewLine
            count_result = count_result + 1
        End If
        If ComboBox4.Text = "2.ผิดปกติ" And tab4_result_x_ray.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ผล X-Ray" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox4.Text = "2.ผิดปกติ" And tab4_result_x_ray.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab4_result_x_ray.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox5.Text = "2.ผิดปกติ" And tab4_result_vdrl.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ผล VDRL ซิฟิลิส" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox5.Text = "2.ผิดปกติ" And tab4_result_vdrl.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab4_result_vdrl.Text + Environment.NewLine
            count_result = count_result + 1
        End If



        If ComboBox6.Text <> "1.ปกติ" Then

            result_all = result_all + "- " + tab4_result_ekg.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If ComboBox19.Text = "2.ผิดปกติ" And tab6_result_psp.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ผล PAP หรือ PSP" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox19.Text = "2.ผิดปกติ" And tab6_result_psp.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + tab6_result_psp.Text + Environment.NewLine
            count_result = count_result + 1
        End If


        If ComboBox21.Text = "2.ผิดปกติ" And RichTextBox3.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์HIV" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf ComboBox21.Text = "2.ผิดปกติ" And RichTextBox3.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + RichTextBox3.Text + Environment.NewLine
            count_result = count_result + 1
        End If


        If TextBox6.Text = "2.ผิดปกติ" And RichTextBox4.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์ Mercury" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf TextBox6.Text = "2.ผิดปกติ" And RichTextBox4.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + RichTextBox4.Text + Environment.NewLine
            count_result = count_result + 1
        End If

        If TextBox5.Text = "2.ผิดปกติ" And RichTextBox2.Text = "กรุณากรอกข้อมูล" Then
            check_group = check_group + count_group.ToString + ".ตรวจสอบ สรุปผล วิเคราะห์CEA" + Environment.NewLine
            count_group = count_group + 1
            check_form = "1"
        ElseIf TextBox5.Text = "2.ผิดปกติ" And RichTextBox2.Text <> "กรุณากรอกข้อมูล" Then
            result_all = result_all + "- " + RichTextBox4.Text + Environment.NewLine
            count_result = count_result + 1
        End If



        If RadioButton1.Checked = True Then
            fit_check = "1"
        ElseIf RadioButton2.Checked = True Then
            fit_check = "2"
        ElseIf RadioButton3.Checked = True Then
            fit_check = "3"
        End If


    End Sub
    Public Sub bmi_cal()
        Dim height As Double
        Dim weight As Double
        Dim result As Double



        If tab1_tab_weight.Text <> "-" And tab1_txt_height.Text <> "-" Then
            height = tab1_txt_height.Text.Trim
            weight = tab1_tab_weight.Text.Trim
            height = height / 100
            weight = weight / height
            weight = weight / height

            tab1_txt_bmi.Text = Format(weight, "##.##")
        End If
    End Sub
    Private Sub tab1_tab_weight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tab1_tab_weight.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "A" And e.KeyChar.ToString <= "Z") Or (e.KeyChar.ToString >= "a" And e.KeyChar.ToString <= "z") Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    bmi_cal()
                End If
            End If
        End If
    End Sub
    Private Sub tab1_txt_height_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tab1_txt_height.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "A" And e.KeyChar.ToString <= "Z") Or (e.KeyChar.ToString >= "a" And e.KeyChar.ToString <= "z") Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    bmi_cal()
                End If
            End If
        End If
    End Sub
    Private Sub ComboBox8_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedValueChanged
        If ComboBox8.Text = "1.ปกติ" Then
            tab4_result_phy.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox8.Text = "2.ผิดปกติ" Then
            tab4_result_phy.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox19_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox19.SelectedValueChanged
        If ComboBox19.Text = "1.ปกติ" Then
            tab6_result_psp.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox19.Text = "2.ผิดปกติ" Then
            tab6_result_psp.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox4_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedValueChanged
        If ComboBox4.Text = "1.ปกติ" Then
            tab4_result_x_ray.Text = "อยู่ในเกณฑ์ปกติ (Normal Chest)"
        ElseIf ComboBox4.Text = "2.ผิดปกติ" Then
            tab4_result_x_ray.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox6_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedValueChanged
        If ComboBox6.Text = "1.ปกติ" Then
            tab4_result_ekg.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox6.Text = "2.ผิดปกติ" Then
            tab4_result_ekg.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox3_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedValueChanged
        If ComboBox3.Text = "1.ปกติ" Then
            tab2_result_txt.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox3.Text = "2.ผิดปกติ" Then
            tab2_result_txt.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox5_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedValueChanged
        If ComboBox5.Text = "1.ปกติ" Then
            tab4_result_vdrl.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox5.Text = "2.ผิดปกติ" Then
            tab4_result_vdrl.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox21_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox21.SelectedValueChanged
        If ComboBox21.Text = "1.ปกติ" Then
            RichTextBox3.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox21.Text = "2.ผิดปกติ" Then
            RichTextBox3.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox22_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox22.SelectedValueChanged
        If ComboBox22.Text = "1.ปกติ" Then
            tab6_result_virus_b.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox22.Text = "2.ผิดปกติ" Then
            tab6_result_virus_b.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox7_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedValueChanged
        If ComboBox7.Text = "1.ปกติ" Then
            RichTextBox2.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox7.Text = "2.ผิดปกติ" Then
            RichTextBox2.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged
        If ComboBox22.Text = "1.ปกติ" Then
            tab6_result_stool.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox22.Text = "2.ผิดปกติ" Then
            tab6_result_stool.Text = "กรุณากรอกข้อมูล"
        End If
    End Sub
    Private Sub ComboBox23_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox23.SelectedValueChanged
        If ComboBox23.Text = "1.ปกติ" Then
            RichTextBox4.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox23.Text = "2.ผิดปกติ" Then
            RichTextBox4.Text = "กรุณากรอกข้อมูล"
        End If


    End Sub
    Public Sub savedata()


        mysql = New MySqlConnection
        ' mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"

        ipconnect = "ryh1"
        mysqlpass = "software"
        usernamedb = "june"
        dbname = "rajyindee_db"

        mysql.ConnectionString = "server=192.0.0.200;user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try

        Dim phy_eye As String = " "
        If r_eye1.Checked = True Then
            phy_eye = "0"
        ElseIf r_eye2.Checked = True Then
            phy_eye = "1"
        ElseIf r_eye3.Checked = True Then
            phy_eye = "2"
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

        If eye_in.Checked = True Then
            glass = "1"
        ElseIf eye_out.Checked = True Then
            glass = "0"
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


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader



        Try

            mySqlCommand.CommandText = "INSERT INTO healthycare_ryh (p_company,p_id,p_name,p_sex,p_age,p_tell,p_add,p_aid,p_date,p_height,p_weight,p_bmi,p_pulse,p_blood_pre,p_eyeright,p_eyeleft,p_colorbindness,blo_gro,blo_rhe,blo_pla,blo_cbc_hb,blo_cbc_hct,blo_cbc_wbc,blo_cbc_n,blo_cbc_e,blo_cbc_b,blo_cbc_l,blo_cbc_m,blo_cbc_a,blo_redcell,uri_col,uri_app,uri_alb,uri_glu,uri_spg,uri_blo,uri_ph,uri_rbe,uri_wbc,uri_epi,uri_other,result_phy,xray,vdrl,phy_ekg,che_fbs,hiv,che_bun,che_cre,che_uri,che_cho,che_tri,che_hdl,che_ldl,che_sgo,che_sgp,che_alk,che_afp,vir_sag,vir_igg,vir_sab,vir_igm,vir_cab,che_cea,sto_wbc,sto_rbc,sto_ova,sto_occ,che_mer,package_type,date_time,phy_eye,phy_nec,phy_hea,phy_vas,phy_lun_che,phy_abd,phy_lym,phy_gus,phy_ext,phy_spi,phy_ski,phy_aud,phy_lun_tes,phy_ekg_oil,eye_1,result_eye,blind,result_blind,check_eye,result_check_eye,teeth,result_teeth,result_all,doctor_name,license,result_fit,amphetamine,stool_culture,tab2_result,tab4_result_fbs,tab4_result_vdrl,tab4_result_hiv,tab5_result_bun,tab5_result_cholesterol,tab5_result_creatinine,tab5_result_trigyceride,tab5_result_uric_acid,tab5_result_hdl,tab6_result_ldl,tab6_result_alkaline,tab6_result_sgot,tab6_result_afp,tab_result_spgt,tab6_result_psp,tab6_result_virus_b,tab6_result_stool,tab6_result_cea,tab6_result_mercury,p_lastname,glass,fit_oil,fit_spec,fit_air,fit_breath,fit_crane,fit_emergency,fit_food,blood_pressure_result,eye_result) VALUES ('" & txtcompany.Text & "','" & txtsearch.Text & "','" & txt_name.Text & "','" & txt_sex.Text & "','" & txt_age.Text & "','" & txt_tell.Text & "','" & txt_address.Text & "','" & txt_aid.Text & "','" & txt_date.Text & "','" & tab1_txt_height.Text & "','" & tab1_tab_weight.Text & "','" & tab1_txt_bmi.Text & "','" & tab1_txt_pulserate.Text & "','" & tab1_txt_bloodp.Text & "','" & tab1_txt_eyer.Text & "', '" & tab1_txt_eyel.Text & "','" & Blind_Color.Text & "','" & tab2_txt_groupblood.Text & "','" & tab2_txt_rh.Text & "','" & tab2_txt_plate.Text & "','" & tab2_txt_hb.Text & "','" & tab2_txt_hct.Text & "','" & tab2_txt_wbc.Text & "','" & tab2_txt_neutrophils.Text & "','" & tab2_txt_eosinophils.Text & "','" & tab2_txt_bashophils.Text & "','" & tab2_txt_lymphocytes.Text & "','" & tab2_txt_monocytes.Text & "','" & tab2_txt_atypical.Text & "','" & tab2_txt_redcell.Text & "','" & tab3_txt_color.Text & "','" & tab3_txt_appearance.Text & "','" & tab3_txt_albumin.Text & "','" & tab3_txt_glucose.Text & "','" & tab3_txt_spgr.Text & "','" & tab3_txt_blood.Text & "','" & tab3_txt_ph.Text & "','" & tab3_txt_rbc.Text & "','" & tab3_txt_wbc.Text & "','" & tab3_txt_epi.Text & "','" & tab3_txt_other.Text & "','" & tab4_result_phy.Text & "','" & tab4_result_x_ray.Text & "','" & tab3_txt_vdrl.Text & "','" & tab4_result_ekg.Text & "','" & tab4_txt_fbs.Text & "','" & tab3_txt_hiv.Text & "','" & tab5_txt_bun.Text & "','" & tab5_txt_creatinine.Text & "','" & tab5_txt_uricacid.Text & "','" & tab5_txt_cholesterol.Text & "','" & tab5_txt_trigyceride.Text & "','" & tab5_txt_hdl.Text & "','" & tab6_txt_ldl.Text & "','" & tab6_txt_sgot.Text & "','" & tab6_txt_sgpt.Text & "','" & tab6_txt_alkaline.Text & "','" & tab6_txt_afp.Text & "','" & txt_hbsag.Text & "','" & txt_anti_igg.Text & "','" & txt_hbsab.Text & "','" & txt_hav_igm.Text & "','" & txt_hbcab.Text & "','" & TextBox5.Text & "','" & tab6_stool_wbc.Text & "','" & tab6_stool_rbc.Text & "','" & tab6_stool_parasites.Text & "','" & tab6_stool_blood.Text & "','" & TextBox6.Text & "','Oil','" & Date.Now.Date.ToString & "','" & phy_eye & "','" & phy_nec & "','" & phy_hea & "','" & phy_vas & "','" & phy_lun_che & "','" & phy_adb & "','" & phy_lym & "','" & phy_gus & "','" & phy_ext & "','" & phy_spi & "','" & phy_ski & "','" & phy_aud & "','" & phy_lun_tes & "','" & phy_ekg_oil & "','" & ComboBox25.Text & "','" & RichTextBox5.Text & "','" & Blind_Color.Text & "','" & tab1_result_blindness.Text & "','" & ComboBox1.Text & "','" & tab1_result_eye.Text & "','" & ComboBox24.Text & "','" & tab1_result_tooth.Text & "','" & result_all & "','" & txt_doctor_name.Text & "','" & txt_license.Text & "','" & txt_other_fit.Text & "','" & tab3_txt_amphetamine.Text & "','" & ComboBox26.Text & "','" & tab2_result_txt.Text & "','" & tab4_result_fbs.Text & "','" & tab4_result_vdrl.Text & "','" & RichTextBox3.Text & "','" & tab5_result_bun.Text & "','" & tab5_result_cholesterol.Text & "','" & tab5_result_creatinine.Text & "','" & tab5_result_trigyceride.Text & "','" & tab5_result_uricacid.Text & "','" & tab5_result_hdl.Text & "','" & tab6_result_ldl.Text & "','" & tab6_result_alkaline.Text & "','" & tab6_result_sgot.Text & "','" & tab6_result_afp.Text & "','" & tab6_result_spgt.Text & "','" & tab6_result_psp.Text & "','" & tab6_result_virus_b.Text & "','" & tab6_result_stool.Text & "','" & RichTextBox2.Text & "','" & RichTextBox4.Text & "','" & txt_lastname.Text & "','" & glass & "','" & fit_check & "','" & spec & "','" & fitair & "','" & fitbreath & "','" & fitcrance & "','" & fitemergency & "','" & fitfood & "','" & blood_pressure_result.Text & "', '" & eye_result.Text & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            mysql.Close()
            Exit Sub

        End Try

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NextForm As main = New main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub
    Sub ChangFocus(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name.KeyPress, txt_lastname.KeyPress, tab1_txt_height.KeyPress, tab1_tab_weight.KeyPress, tab1_txt_bmi.KeyPress, tab1_txt_pulserate.KeyPress, tab1_txt_bloodp.KeyPress, tab1_txt_eyer.KeyPress, tab1_txt_eyel.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub TabPageEX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageEX7.Click

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
    Private Sub listview1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listview1.Click
        txt_doctor_name.Text = listview1.SelectedItems(0).SubItems(2).Text
        txt_license.Text = listview1.SelectedItems(0).SubItems(0).Text

    End Sub
    Private Sub add_doctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_doctor.Click
        Dim nextform As check_doctor_add = New check_doctor_add(mysqlpass, ipconnect, usernamedb, dbname)
        nextform.Show()
    End Sub
    Private Sub TabPageEX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageEX1.Click

    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        check_sub = "0"
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        check_sub = "1"
    End Sub

    Private Sub Blind_Color_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blind_Color.SelectedIndexChanged
        If Blind_Color.Text = "ปกติ" Then
            tab1_result_blindness.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf Blind_Color.Text = "มีภาวะตาบอดสี" Then
            If check_sub = "0" Then
                tab1_result_blindness.Text = "ควรระมัดระวังในการขับขี่พาหนะ และการทำงานที่เกี่ยวกับสัญญาณไฟสี"
            ElseIf check_sub = "1" Then
                tab1_result_blindness.Text = "Be careful driving and working with the light sign."
            End If


        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "1.ปกติ" Then
            tab1_result_eye.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
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
            tab1_result_tooth.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
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

    Private Sub ComboBox25_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox25.SelectedIndexChanged
        If ComboBox25.Text = "1.ปกติ" Then
            RichTextBox5.Text = "อยู่ในเกณฑ์ปกติ (Normal)"

        ElseIf ComboBox25.Text = "2.สายตามองเห็นชัดลดลง" Then
            If check_sub = "0" Then
                RichTextBox5.Text = "สายตามองเห็นชัดลดลง"
            ElseIf check_sub = "1" Then
                RichTextBox5.Text = "Vision reduced signicantly visoin decrease."
            End If
        ElseIf ComboBox25.Text = "2.สายตาสั้น" Then
            If check_sub = "0" Then
                RichTextBox5.Text = "สายตาสั้น"
            ElseIf check_sub = "1" Then
                RichTextBox5.Text = "Short-sighted"
            End If
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

    Private Sub TabPageEX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageEX2.Click

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub eye_in_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eye_in.CheckedChanged

    End Sub

    Private Sub tab6_result_stool_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab6_result_stool.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub TabPageEX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageEX3.Click

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        update_data()


        date_string = txt_date.Text
        If CheckBox1.Checked = True Then
            id_hn = txtsearch.Text
            result_xray = tab4_result_x_ray.Text
            count_group = 1
            count_result = 1
            other_fit = txt_other_fit.Text
            sex_fm = txt_sex.Text
            check_radio()
            prnoil()
            check_box()
            doctor_name = txt_doctor_name.Text
            license = txt_license.Text
            name_lastname = txt_name.Text + " " + txt_lastname.Text
            name_eng = txt_name.Text
            lastname_eng = txt_lastname.Text
            sex_fm = txt_sex.Text
            result_all = " "
            result_all = RichTextBox1.Text

            blood_pressure_result_txt = blood_pressure_result.Text
            eye_result_txt = eye_result.Text

            date_string = txt_date.Text
            result_pulserate = tab1_txt_pulserate.Text
            cbc_result = tab2_result_txt.Text
            urine_result = TextBox1.Text
            savedata()

            phy_eye_left = tab1_txt_eyel.Text
            phy_eye_right = tab1_txt_eyer.Text
            address = txt_address.Text
            tellephone = txt_tell.Text
            unders = txt_aid.Text
            ipconnect = "192.0.0.204"
            mysqlpass = "sa"
            usernamedb = "sa"
            dbname = "lab_rajyindee"
            Stool_culture = ComboBox26.Text
            color_blind = Blind_Color.Text
            Dim NextForm As frmextra_package = New frmextra_package(mysqlpass, ipconnect, usernamedb, dbname, id_hn, export_id)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()

        Else

            date_string = txt_date.Text
            result_xray = tab4_result_x_ray.Text
            count_group = 1
            count_result = 1
            other_fit = txt_other_fit.Text
            result_all = " "

            check_radio()
            prnoil()
            check_box()
            doctor_name = txt_doctor_name.Text
            license = txt_license.Text
            name_lastname = txt_name.Text + " " + txt_lastname.Text
            name_eng = txt_name.Text
            lastname_eng = txt_lastname.Text
            RichTextBox1.Text = result_all
        End If

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click

  

    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click

   

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ไทย.Click
        Dim name_lastname As String
        Dim company_name As String
        name_lastname = txt_name.Text + "  " + txt_lastname.Text
        company_name = txtcompany.Text

        Dim FrmReportEnv As FrmReportEnv = New FrmReportEnv(name_lastname, company_name, "0")
        FrmReportEnv.Show()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim name_lastname As String
        Dim company_name As String
        name_lastname = txt_name.Text + "  " + txt_lastname.Text
        company_name = txtcompany.Text

        Dim FrmReportEnv As FrmReportEnv = New FrmReportEnv(name_lastname, company_name, "1")
        FrmReportEnv.Show()
    End Sub
End Class