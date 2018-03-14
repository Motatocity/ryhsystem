Imports MySql.Data.MySqlClient
Public Class tell_doctor_search
    Dim mysql As MySqlConnection
    Dim id_key As String
    Dim id_primary As String
    Public Class manage
        Public Property m_make As String
        Public Property m_model As String
        Public Property m_year As String

        Public Sub New(ByVal make, ByRef model, ByVal year)
            m_make = make
            m_model = model
            m_year = year
        End Sub
        
    End Class
    Private Sub tell_doctor_search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"
        'DataGridView1.AutoGenerateColumns = False

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

        Dim DGVCombo As New DataGridViewComboBoxColumn
        Dim TextBox1 As New DataGridViewTextBoxColumn
        Dim TextBox2 As New DataGridViewCheckBoxColumn
        DataGridView1.AutoGenerateColumns = False
        Dim dt As New DataTable("Names")
        dt.Columns.Add("State")
        dt.Columns.Add("Name")
        dt.Columns.Add("test")


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM company_name;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            Dim datatypes As New ArrayList()
            While (mySqlReader.Read())
                dt.LoadDataRow(New Object() {mySqlReader("idcompany_name"), mySqlReader("com_name"), ""}, True)
            
                'datatypes.Add(New manage(mySqlReader("com_name"), mySqlReader("com_tell"), "1"))

            End While
            DataGridView1.DataSource = dt
            DataGridView1.AllowUserToAddRows = False
            Dim dtCombo = dt.Copy
            dtCombo.TableName = "States"

            DGVCombo.DataSource = dtCombo
            DGVCombo.DisplayMember = "Name"
            DGVCombo.ValueMember = "State"
            DGVCombo.DataPropertyName = "State"

            TextBox1.DataPropertyName = "State"



            DataGridView1.Columns.Add(TextBox1)
            DataGridView1.Columns.Add(DGVCombo)
            DataGridView1.Columns.Add(TextBox2)



            'DataGridView1.Columns.Add("ID", "Product ID")
            'DataGridView1.Columns.Add("Name", "Product Name")
            'DataGridView1.Columns.Add("Description", "Description")
            'Dim bindingsource As New BindingSource
            'bindingsource.Add("Type A")
            'bindingsource.Add("Type B")
            'bindingsource.Add("Type C")
            'Dim comboBoxCol As New DataGridViewComboBoxColumn

            ''  DataGridView1.DataSource = datatypes
            'comboBoxCol.HeaderText = "Types"

            ''---data bind it---
            'comboBoxCol.DataSource = bindingsource
            ' DataGridView1.Columns.Add(comboBoxCol)

            'DataGridView1.DataSource = datatypes

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As tell_edit_em = New tell_edit_em(id_key, "2")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NextForm As tell_add_em = New tell_add_em("2")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nextform As tell_main = New tell_main
        nextform.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        showdata()

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
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
        mySqlCommand.CommandText = "SELECT * FROM manage where user_name like '%" & TextBox1.Text & "%' and dep_name = 'แพทย์/พยาบาล' order by convert(user_name using TIS620);"
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

    Private Sub ListView1_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles ListView1.ChangeUICues

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        id_key = ListView1.SelectedItems(0).SubItems(0).Text
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

                    mySqlCommand.CommandText = "DELETE FROM manage where id = '" & id_primary & "';"
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


                mySqlCommand.CommandText = "SELECT * FROM manage where dep_name = 'แพทย์/พยาบาล' order by convert(user_name using TIS620);"
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
            Else
                MsgBox("กรุณาเลือกข้อมูลในตารางที่จะลบออก")
            End If
        End If
    End Sub


End Class