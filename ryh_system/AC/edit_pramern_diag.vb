Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class edit_pramern_diag
    Dim id_pramern As String
    Dim mysql As MySqlConnection
    Public Sub New(ByRef idpramern As String)

        ' This call is required by the Windows Form Designer.

        id_pramern = idpramern
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub edit_pramern_diag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySql = New MySqlConnection
        MySql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            MySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try


        If MySql.State = ConnectionState.Closed Then
            MySql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price where idpramern_price = '" & id_pramern & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = MySql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader


            While (mySqlReader.Read())
                txt_name_thai.Text = mySqlReader("name_thai")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MySql.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim commandText2 As String
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        commandText2 = "UPDATE pramern_price SET  name_thai =  '" & txt_name_thai.Text & "'  WHERE idpramern_price = " & id_pramern & "; "
        mySqlCommand.CommandText = commandText2
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql

        mySqlCommand.ExecuteNonQuery()
        mysql.Close()
        Me.Close()

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Me.Close()
    End Sub
End Class