Imports MySql.Data.MySqlClient
Public Class insurance_search
    Dim mysql As MySqlConnection
    Dim id_key As String
    Dim id_primary As String

    Private Sub insurance_search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee;Character Set =utf8"

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
        mySqlCommand.CommandText = "SELECT * FROM insurance;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idinsurance"))

                    .SubItems.Add(mySqlReader("name_insurance"))
                    .SubItems.Add(mySqlReader("nameof_insurance"))
                    .SubItems.Add(mySqlReader("tell_insurance"))
                    .SubItems.Add(mySqlReader("tell2_insurance"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
    Private Sub showdata()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM insurance where name_insurance like '%" & TextBox1.Text & "%' or nameof_insurance ='%" & TextBox1.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idinsurance"))

                    .SubItems.Add(mySqlReader("name_insurance"))
                    .SubItems.Add(mySqlReader("nameof_insurance"))
                    .SubItems.Add(mySqlReader("tell_insurance"))
                    .SubItems.Add(mySqlReader("tell2_insurance"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        showdata()

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        id_key = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            showdata()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nextform As insurance_add = New insurance_add
        nextform.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim nextform As insurance_edit = New insurance_edit(id_key)
        nextform.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListView1.SelectedItems.Count > 0 Then
            id_primary = ListView1.SelectedItems(0).SubItems(0).Text
            DeleteData()
        End If
    End Sub


    Private Sub DeleteData()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If id_primary <> "" Then

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM insurance where idinsurance = '" & id_primary & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql

                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If

                mySqlCommand.CommandText = "SELECT * FROM insurance;"
                ' mySqlCommand.CommandText = 
                mySqlCommand.Connection = mysql
                mySqlAdaptor.SelectCommand = mySqlCommand
                Try
                    mySqlReader = mySqlCommand.ExecuteReader

                    ListView1.Items.Clear()

                    While (mySqlReader.Read())

                        With ListView1.Items.Add(mySqlReader("idinsurance"))

                            .SubItems.Add(mySqlReader("name_insurance"))
                            .SubItems.Add(mySqlReader("nameof_insurance"))
                            .SubItems.Add(mySqlReader("tell_insurance"))
                            .SubItems.Add(mySqlReader("tell2_insurance"))

                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                mysql.Close()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nextform As tell_main = New tell_main
        nextform.Show()
        Me.Close()
    End Sub
End Class