Imports MySql.Data.MySqlClient
Public Class tell_company_edit
    Dim id_primay As String
    Dim mysql As MySqlConnection
    Public Sub New(ByRef id_key As String)
        InitializeComponent()
        id_primay = id_key
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim commandText2 As String
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        commandText2 = "UPDATE company_tell SET com_name = '" & txt_comname.Text & "' , com_address = '" & txt_comaddress.Text & "' , com_tell = '" & txt_comtell.Text & "' , com_fax = '" & txt_comfax.Text & "'  WHERE idcompany_tell = " & id_primay & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()
        Dim nextform As tell_company_search = New tell_company_search
        nextform.Show()
        Me.Close()





    End Sub

    Private Sub tell_company_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        mySqlCommand.CommandText = "SELECT * FROM company_tell where idcompany_tell = '" & id_primay & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader


            While (mySqlReader.Read())
                txt_comname.Text = mySqlReader("com_name")
                txt_comaddress.Text = mySqlReader("com_address")
                txt_comtell.Text = mySqlReader("com_tell")
                txt_comfax.Text = mySqlReader("com_fax")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nextform As tell_company_search = New tell_company_search
        nextform.Show()
        Me.Close()
    End Sub
End Class