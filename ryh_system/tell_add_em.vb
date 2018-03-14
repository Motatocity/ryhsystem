Imports MySql.Data.MySqlClient
Public Class tell_add_em
    Dim id_primay As String
    Dim mysql As MySqlConnection
    Dim stat As String
    Public Sub New(ByRef status As String)
        InitializeComponent()
        stat = status
    End Sub

    Private Sub tell_add_em_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=telephone;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub

    Private Sub btn_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_home.Click

        Dim NextForm As tell_main = New tell_main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()


    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Try
            mySqlCommand.CommandText = "INSERT INTO manage (user_name,mobile_tel,house_tel,dep_name,clinic_tel,branch_name) VALUES ('" & txt_name.Text & "','" & Txt_mobile.Text & "','" & Txt_home.Text & "', '" & Combo_sec.Text & "','" & txt_clinic.Text & "','" & Txt_bra.Text & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()

            clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub

        End Try
    End Sub


    Public Sub clear()
        txt_name.Text = ""
        Txt_bra.Text = ""
        txt_clinic.Text = ""
        Txt_mobile.Text = ""
        Txt_home.Text = ""
        Combo_sec.Text = ""
    End Sub
End Class