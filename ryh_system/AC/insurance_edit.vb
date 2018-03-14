Imports MySql.Data.MySqlClient
Public Class insurance_edit
    Dim id_primay As String
    Dim mysql As MySqlConnection
    Public Sub New(ByRef primay As String)
        id_primay = primay
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub insurance_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

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
        mySqlCommand.CommandText = "SELECT * FROM insurance where idinsurance = '" & id_primay & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader


            While (mySqlReader.Read())
                txt_comname.Text = mySqlReader("name_insurance")
                txt_comaddress.Text = mySqlReader("nameof_insurance")
                txt_comtell.Text = mySqlReader("tell_insurance")
                txt_comfax.Text = mySqlReader("tell2_insurance")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click


        Dim commandText2 As String
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        commandText2 = "UPDATE insurance SET name_insurance = '" & txt_comname.Text & "' , nameof_insurance = '" & txt_comaddress.Text & "' , tell_insurance = '" & txt_comtell.Text & "' , tell2_insurance = '" & txt_comfax.Text & "'  WHERE idinsurance = " & id_primay & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()
        Me.Close()
    End Sub
End Class