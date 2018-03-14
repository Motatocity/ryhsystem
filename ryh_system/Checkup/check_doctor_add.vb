Imports MySql.Data.MySqlClient
Public Class check_doctor_add
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcheck_name As String
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim db_name As String
    Dim export_id As String
    Dim id_hn As String
    Public respone As Object
    Dim mysql As MySqlConnection
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub check_doctor_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        'mysql_pass = "stomsite"
        ip_connect = "ryh1"
        'ip_connect = "119.59.99.151"

        'user_namedb = "tmcport_shipping"

        'db_name = "tmcport_shipping"

        '  ip_connect = "127.0.0.1"
        mysql_pass = "software"
        user_namedb = "june"
        db_name = "rajyindee_db"

        mysql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Try
            mySqlCommand.CommandText = "INSERT INTO name_doctor (name_eng,name_thai,license) VALUES ('" & txt_name_eng.Text & "','" & txt_name_thai.Text & "','" & txt_license.Text & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()


        Catch ex As Exception

            MsgBox("Please check your data again!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
            Exit Sub

        End Try
    End Sub
End Class