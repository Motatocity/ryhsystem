Imports MySql.Data.MySqlClient
Public Class tell_edit_em
    Dim id_primay As String
    Dim mysql As MySqlConnection
    Dim stat As String

    Public Sub New(ByRef id_key As String, ByRef status As String)
        InitializeComponent()
        id_primay = id_key
        stat = status
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim commandText2 As String
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        If Combo_sec.Text <> "" Then
            commandText2 = "UPDATE manage SET user_name = '" & txt_name.Text & "' , mobile_tel = '" & txt_mobile.Text & "' , house_tel = '" & txt_home.Text & "' , dep_name = '" & Combo_sec.Text & "' , clinic_tel = '" & txt_clinic.Text & "' , branch_name = '" & txt_bra.Text & "' WHERE id = " & id_primay & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()


            If stat = "1" Then
                Dim nextform As tell_search = New tell_search
                nextform.Show()
                Me.Close()
            ElseIf stat = "2" Then
                Dim nextform As tell_doctor_search = New tell_doctor_search
                nextform.Show()
                Me.Close()

            End If

        End If





    End Sub

    Private Sub tell_edit_em_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
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


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM manage where  id = '" & id_primay & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                txt_name.Text = mySqlReader("user_name")
                txt_bra.Text = mySqlReader("branch_name")
                txt_mobile.Text = mySqlReader("mobile_tel")
                txt_home.Text = mySqlReader("house_tel")
                txt_clinic.Text = mySqlReader("clinic_tel")
                Combo_sec.Text = mySqlReader("dep_name")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
    End Sub

    Private Sub btn_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_home.Click
        Dim NextForm As tell_main = New tell_main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub
End Class