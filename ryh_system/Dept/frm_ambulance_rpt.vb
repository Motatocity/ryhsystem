Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_ambulance_rpt
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
    Dim rpt1 As New rpt_ambulance

    Dim cryRpt As New ReportDocument


    Private Sub frm_ambulance_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CrystalReportViewer1.ReportSource = rpt1
        CrystalReportViewer1.Refresh()
        rpt1.SetParameterValue("car_valprice", ambulance.car_valprice)
        rpt1.SetParameterValue("doc_valprice", ambulance.doc_valprice)
        rpt1.SetParameterValue("rn_valprice", ambulance.rn_valprice)
        rpt1.SetParameterValue("pn_valprice", ambulance.pn_valprice)
        rpt1.SetParameterValue("na_valprice", ambulance.na_valprice)
        rpt1.SetParameterValue("pale_valprice", ambulance.pale_valprice)
        rpt1.SetParameterValue("price_standby", ambulance.stand_by)
        rpt1.SetParameterValue("customer", ambulance.name_customer)
        rpt1.SetParameterValue("personal", ambulance.name_personal)
        rpt1.SetParameterValue("age", ambulance.age)
        rpt1.SetParameterValue("diag", ambulance.diag)
        rpt1.SetParameterValue("address", ambulance.send_txt)
        rpt1.SetParameterValue("other_txt", ambulance.host_txt)
        If ambulance.hospital_rajyindee = "1" Then
            rpt1.SetParameterValue("rj", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("rj", "<font></font>")
        End If

        If ambulance.hospital_rajyindee_0 = "1" Then
            rpt1.SetParameterValue("rj1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("rj1", "<font></font>")
        End If


        If ambulance.hospital_moor = "1" Then
            rpt1.SetParameterValue("mor", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("mor", "<font></font>")
        End If
        If ambulance.hospital_moor_0 = "1" Then
            rpt1.SetParameterValue("mor1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("mor1", "<font></font>")
        End If

        If ambulance.hospital_hadyai = "1" Then
            rpt1.SetParameterValue("hd", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("hd", "<font></font>")
        End If
        If ambulance.hospital_hadyai_0 = "1" Then
            rpt1.SetParameterValue("hd1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("hd1", "<font></font>")
        End If


        If ambulance.hospital_songkla = "1" Then
            rpt1.SetParameterValue("songkla", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("songkla", "<font></font>")
        End If

        If ambulance.hospital_songkla_0 = "1" Then
            rpt1.SetParameterValue("songkla1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("songkla1", "<font></font>")
        End If

        If ambulance.hospital_department = "1" Then
            rpt1.SetParameterValue("dep", "<font>&#10003;</font>")
            rpt1.SetParameterValue("dep_name", " ")

        Else
            rpt1.SetParameterValue("dep", "<font></font>")
            rpt1.SetParameterValue("dep_name", " ")
        End If



        If ambulance.hospital_department_0 = "1" Then
            rpt1.SetParameterValue("dep1", "<font>&#10003;</font>")
            rpt1.SetParameterValue("dep_name1", " ")

        Else
            rpt1.SetParameterValue("dep1", "<font></font>")
            rpt1.SetParameterValue("dep_name1", " ")
        End If


        If ambulance.Symptom1_1 = "1" Then
            rpt1.SetParameterValue("sym1_1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym1_1", "<font></font>")
        End If

        If ambulance.Symptom1_2 = "1" Then
            rpt1.SetParameterValue("sym1_2", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym1_2", "<font></font>")
        End If

        If ambulance.Symptom1_3 = "1" Then
            rpt1.SetParameterValue("sym1_3", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym1_3", "<font></font>")
        End If

        If ambulance.Symptom1_4 = "1" Then
            rpt1.SetParameterValue("sym1_4", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym1_4", "<font></font>")
        End If

        If ambulance.Symptom1_5 = "1" Then
            rpt1.SetParameterValue("sym1_5", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym1_5", "<font></font>")
        End If

        If ambulance.Symptom1_6 = "1" Then
            rpt1.SetParameterValue("sym1_6", "<font>&#10003;</font>")
            rpt1.SetParameterValue("sym1_6_txt", ambulance.Symptom1_6_text)
        Else
            rpt1.SetParameterValue("sym1_6", "<font></font>")
            rpt1.SetParameterValue("sym1_6_txt", "........................")
        End If

        If ambulance.Symptom2_1 = "1" Then
            rpt1.SetParameterValue("sym2_1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym2_1", "<font></font>")
        End If

        If ambulance.Symptom2_2 = "1" Then
            rpt1.SetParameterValue("sym2_2", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym2_2", "<font></font>")
        End If


        If ambulance.Symptom2_3 = "1" Then
            rpt1.SetParameterValue("sym2_3", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym2_3", "<font></font>")
        End If

        If ambulance.Symptom2_4 = "1" Then
            rpt1.SetParameterValue("sym2_4", "<font>&#10003;</font>")
            rpt1.SetParameterValue("sym2_5_txt", ambulance.Symptom2_4_text)
        Else
            rpt1.SetParameterValue("sym2_4", "<font></font>")
            rpt1.SetParameterValue("sym2_5_txt", ".........................")
        End If

        If ambulance.Symptom3_1 = "1" Then
            rpt1.SetParameterValue("sym3_1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym3_1", "<font></font>")
        End If

        If ambulance.Symptom3_2 = "1" Then
            rpt1.SetParameterValue("sym3_2", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym3_2", "<font></font>")
        End If

        If ambulance.Symptom4_1 = "1" Then
            rpt1.SetParameterValue("sym4_1", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym4_1", "<font></font>")
        End If


        If ambulance.Symptom4_2 = "1" Then
            rpt1.SetParameterValue("sym4_2", "<font>&#10003;</font>")
        Else
            rpt1.SetParameterValue("sym4_2", "<font></font>")
        End If


        If ambulance.doctor_stat = "1" Then
            rpt1.SetParameterValue("doctor_price", "<font>&#10003;</font>")
            rpt1.SetParameterValue("doctor_name", ambulance.doctor_name)
        Else
            rpt1.SetParameterValue("doctor_price", "<font></font>")
            rpt1.SetParameterValue("doctor_name", ambulance.doctor_name)
        End If

        If ambulance.rn_stat = "1" Then
            rpt1.SetParameterValue("rn_price", "<font>&#10003;</font>")
            rpt1.SetParameterValue("rn_name", ambulance.rn_name)
        Else
            rpt1.SetParameterValue("rn_price", "<font></font>")
            rpt1.SetParameterValue("rn_name", ambulance.rn_name)
        End If


        rpt1.SetParameterValue("car_man", ambulance.car_personal)

        If ambulance.pn_stat = "1" Then
            rpt1.SetParameterValue("pn_price", "<font>&#10003;</font>")
            rpt1.SetParameterValue("pn_name", ambulance.pn_name)
        Else
            rpt1.SetParameterValue("pn_price", "<font></font>")
            rpt1.SetParameterValue("pn_name", ambulance.pn_name)
        End If

        If ambulance.na_stat = "1" Then
            rpt1.SetParameterValue("na_price", "<font>&#10003;</font>")
            rpt1.SetParameterValue("na_name", ambulance.na_name)
        Else
            rpt1.SetParameterValue("na_price", "<font></font>")
            rpt1.SetParameterValue("na_name", ambulance.na_name)
        End If

        If ambulance.pale_stat = "1" Then
            rpt1.SetParameterValue("pale_price", "<font>&#10003;</font>")
            rpt1.SetParameterValue("pale_name", ambulance.pale_name)
        Else
            rpt1.SetParameterValue("pale_price", "<font></font>")
            rpt1.SetParameterValue("pale_name", ambulance.pale_name)
        End If



        rpt1.SetParameterValue("price_car", ambulance.price_car)
        rpt1.SetParameterValue("price_etc", ambulance.price_etc)
    End Sub


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class