Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports AcceleratedIdeas

Public Class main
    Public Sql As MySqlConnection
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim db_name As String
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As frmpackage5 = New frmpackage5(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As frmpackage4 = New frmpackage4(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AiTabPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)


    End Sub

    Private Sub AiTabPanel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        mysql = New MySqlConnection
        'mysql_pass = "stomsite"
        'ip_connect = "127.0.0.1"
        '  ip_connect = "119.59.99.151"

        ' user_namedb = "tmcport_shipping"
        ' db_name = "tmcport_shipping"

        ip_connect = "192.0.0.204"
        mysql_pass = "sa"
        user_namedb = "sa"
        db_name = "lab_rajyindee"

        mysql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As frmpackage2 = New frmpackage2(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As frmpackage6 = New frmpackage6(mysql_pass, ip_connect, user_namedb, db_name, "0", "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As frm_add_lab = New frm_add_lab(mysql_pass, ip_connect, user_namedb, db_name)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As company_oil = New company_oil(mysql_pass, ip_connect, user_namedb, db_name)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserControl12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub CrumbBar1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.CrumbBarSelectionEventArgs)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim NextForm As frmpackage1 = New frmpackage1(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ItemPanel1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Dim NextForm As frmpackage3 = New frmpackage3(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Dim NextForm As frmpackage4 = New frmpackage4(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Dim NextForm As frmpackage6 = New frmpackage6(mysql_pass, ip_connect, user_namedb, db_name, "0", "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        Dim NextForm As frmpackage5 = New frmpackage5(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()

    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        Dim NextForm As company_oil = New company_oil(mysql_pass, ip_connect, user_namedb, db_name)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        Dim NextForm As oil_company = New oil_company(mysql_pass, ip_connect, user_namedb, db_name)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub RibbonTabItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX9.Click
        Dim NextForm As chack_package = New chack_package(mysql_pass, ip_connect, user_namedb, db_name)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim NextForm As frmpackage2 = New frmpackage2(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub ButtonX10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        Dim NextForm As frmpackage_extra = New frmpackage_extra(mysql_pass, ip_connect, user_namedb, db_name, "0", "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Package6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RibbonControl1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub ButtonX11_Click(sender As Object, e As EventArgs) Handles ButtonX11.Click
        Dim NextForm As frmrpt_checkuprecheck = New frmrpt_checkuprecheck()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub
End Class