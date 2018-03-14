Imports MySql.Data.MySqlClient
Public Class tell_search
    Dim mysql As MySqlConnection
    Dim id_key As String
    Private Sub tell_search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        mySqlCommand.CommandText = "SELECT * FROM manage where  dep_name <>'แพทย์/พยาบาล' order by convert(user_name using TIS620);"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("id"))

                    .SubItems.Add(mySqlReader("user_name"))
                    .SubItems.Add(mySqlReader("dep_name"))
                    .SubItems.Add(mySqlReader("mobile_tel"))
                    .SubItems.Add(mySqlReader("house_tel"))
                    .SubItems.Add(mySqlReader("clinic_tel"))
                    .SubItems.Add(mySqlReader("branch_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT DISTINCT dep_name FROM manage ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())
                dep_name.Items.Add(mySqlReader("dep_name"))
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
        mySqlCommand.CommandText = "SELECT * FROM manage where user_name like '%" & TextBox1.Text & "%' and dep_name <> 'แพทย์/พยาบาล' order by convert(user_name using TIS620);"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("id"))

                    .SubItems.Add(mySqlReader("user_name"))
                    .SubItems.Add(mySqlReader("dep_name"))
                    .SubItems.Add(mySqlReader("mobile_tel"))
                    .SubItems.Add(mySqlReader("house_tel"))
                    .SubItems.Add(mySqlReader("clinic_tel"))
                    .SubItems.Add(mySqlReader("branch_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            showdata()

        End If
    End Sub

    Private Sub dep_name_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dep_name.SelectedIndexChanged
        show_dep()

    End Sub
    Public Sub show_dep()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM manage where dep_name like '%" & dep_name.Text & "%' order by convert(user_name using TIS620);"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("id"))

                    .SubItems.Add(mySqlReader("user_name"))
                    .SubItems.Add(mySqlReader("dep_name"))
                    .SubItems.Add(mySqlReader("mobile_tel"))
                    .SubItems.Add(mySqlReader("house_tel"))
                    .SubItems.Add(mySqlReader("clinic_tel"))
                    .SubItems.Add(mySqlReader("branch_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        id_key = ListView1.SelectedItems(0).SubItems(0).Text

    End Sub

    Private Sub ListView1_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.ClientSizeChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NextForm As tell_add_em = New tell_add_em("1")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As tell_edit_em = New tell_edit_em(id_key, "1")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nextform As tell_main = New tell_main
        nextform.Show()
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            showdata()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub
End Class