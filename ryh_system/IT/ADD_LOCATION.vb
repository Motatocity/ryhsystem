Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class ADD_LOCATION
    Dim sql As MySqlConnection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)
        InitializeComponent()
        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
    End Sub
    Private Sub ADD_LOCATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = New MySqlConnection
        sql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM section  where idsection ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListVieweditsec.Items.Clear()

            While (mySqlReader.Read())

                With ListVieweditsec.Items.Add(mySqlReader("idsection"))
                    .SubItems.Add(mySqlReader("section_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowsec.Text = ListVieweditsec.Items.Count.ToString
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            ''เช็คข้อมูลที่บังคับป้อน
            If ComboBoxlocat.Text <> "" And txtidfloor.Text <> "" Then
                mySqlCommand.CommandText = "INSERT INTO location (location_name,idFloor,idsection) VALUES ('" & ComboBoxlocat.Text & "','" & txtidfloor.Text & "' ,'" & txtidsection.Text & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
                MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsection.Text = ""
                txtfloor.Text = ""
                txtidfloor.Text = ""
                ComboBoxlocat.Text = ""
                txtidsection.Text = ""

            Else
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocation.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocation.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub ListVieweditsec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListVieweditsec.Click
        idkey = ListVieweditsec.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocation.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocation.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If


        mySqlCommand.CommandText = "SELECT * FROM section join floor where (section.idFloor = floor.idFloor)and  idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtidsection.Text = mySqlReader("idsection")
                txtfloor.Text = mySqlReader("floor_name")
                txtsection.Text = mySqlReader("section_name")
                txtidfloor.Text = mySqlReader("idFloor")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        txtshowlo.Text = ListViewlocation.Items.Count.ToString

    End Sub

    Private Sub btneditlocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditlocation.Click
        Dim NextForm As EDIT_LOCATION = New EDIT_LOCATION(mysqlpass, ipconnect, usernamedb, dbname)
        NextForm.Show()
        Me.Hide()
    End Sub

    Private Sub ListViewlocation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlocation.Click


    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        txtfloor.Text = ""
        txtidfloor.Text = ""
        txtidsection.Text = ""
        txtsection.Text = ""
        ComboBoxlocat.Text = ""
        ComboBoxlocat.Focus()

    End Sub
End Class