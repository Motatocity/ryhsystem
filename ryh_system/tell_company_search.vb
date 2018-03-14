Imports MySql.Data.MySqlClient
Public Class tell_company_search
    Dim mysql As MySqlConnection
    Dim id_key As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim nextform As tell_company_add = New tell_company_add
        nextform.Show()
        Me.Close()

    End Sub

    Private Sub tell_company_search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        mySqlCommand.CommandText = "SELECT * FROM company_tell order by convert(com_name using TIS620);"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idcompany_tell"))

                    .SubItems.Add(mySqlReader("com_name"))
                    .SubItems.Add(mySqlReader("com_address"))
                    .SubItems.Add(mySqlReader("com_tell"))
                    .SubItems.Add(mySqlReader("com_fax"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            showdata()

        End If
    End Sub

    Private Sub showdata()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM company_tell where  com_name like '%" & TextBox1.Text & "%' order by convert(com_name using TIS620);"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()


            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idcompany_tell"))

                    .SubItems.Add(mySqlReader("com_name"))
                    .SubItems.Add(mySqlReader("com_address"))
                    .SubItems.Add(mySqlReader("com_tell"))
                    .SubItems.Add(mySqlReader("com_fax"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nextform As tell_company_edit = New tell_company_edit(id_key)
        nextform.Show()
        Me.Close()


    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        id_key = ListView1.SelectedItems(0).SubItems(0).Text

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim NextForm As tell_main = New tell_main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            showdata()
        End If
    End Sub
End Class