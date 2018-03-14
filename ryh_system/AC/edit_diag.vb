Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class edit_diag
    Dim mysql As MySqlConnection

    Private Sub edit_diag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        mySqlCommand.CommandText = "SELECT * FROM pramern_price ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewEx1.Items.Clear()

            While (mySqlReader.Read())

                With ListViewEx1.Items.Add(mySqlReader("idpramern_price"))

                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("diag_name"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub


    Public Sub showdata()



        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM pramern_price where diag_name like '%" & txtsearch_diag.Text & "%'  or name_thai like '%" & txtsearch_diag.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewEx1.Items.Clear()

            While (mySqlReader.Read())

                With ListViewEx1.Items.Add(mySqlReader("idpramern_price"))

                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("diag_name"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

    Private Sub ListViewEx1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewEx1.Click



    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        If ListViewEx1.SelectedItems.Count > 0 Then
            Dim nexform As edit_pramern_diag = New edit_pramern_diag(ListViewEx1.SelectedItems(0).SubItems(0).Text)
            nexform.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub
End Class