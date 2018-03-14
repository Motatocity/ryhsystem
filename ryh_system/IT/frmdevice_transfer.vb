Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmdevice_transfer
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim idkey1 As String
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String

    Dim idstring() As String
    Dim idstring2() As String
    Dim idstring3() As String
    Dim idkeyindex As String

    Public Sub New(ByRef id1 As String)
        idkey1 = id1
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmdevice_transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql.Close()
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
        Dim key As String
        Dim count As Integer

        count = 0

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM floor order by idFloor;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())

                ComboBox1.Items.Add(mySqlReader("idFloor").ToString + "|" + mySqlReader("floor_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        idkey = ComboBox1.Text
        idstring = Split(idkey, "|")

        ComboBox2.Items.Clear()


        If Sql.State = ConnectionState.Closed Then
            Sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If Sql.State = ConnectionState.Closed Then
            Sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM section where idFloor = '" & idstring(0) & "' ;"
        mySqlCommand.Connection = Sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())


                ComboBox2.Items.Add(mySqlReader("idsection").ToString + "|" + mySqlReader("section_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Sql.Close()
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged
        ComboBox3.Items.Clear()

        idkey = ComboBox2.Text
        idstring2 = Split(idkey, "|")
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

        mySqlCommand.CommandText = "SELECT location.idlocation,location_name,c_ipnumber FROM location left join data_device on location.idlocation = data_device.idlocation where idsection = '" & idstring2(0) & "' and type = 'Computer' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())


                ComboBox3.Items.Add(mySqlReader("idlocation").ToString + "|" + mySqlReader("location_name") + "|" + mySqlReader("c_ipnumber"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub

    Private Sub ComboBox3_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedValueChanged
        idkey = ComboBox3.Text
        idstring3 = Split(idkey, "|")

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        savedata()

    End Sub
    Private Sub savedata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        Dim commandText As String
        Dim commandText2 As String
        Dim commandText3 As String
        Dim counter1 As Integer = 0
     
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            commandText = "UPDATE data_device SET state_device = 'ถูกใช้งาน' , idlocation = '" & idstring3(0) & "' WHERE iddata_device = '" & idkey1 & "' "
            mySqlCommand.CommandText = commandText
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            sql.Close()

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            Try
                mySqlCommand.CommandText = "INSERT INTO device_location (iddata_device,idlocation,date_time_book) VALUES ('" & idkey1 & "',  '" & idstring3(0) & "','" & Date.Now.ToString & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            sql.Close()
            Me.Close()
        End If

     


    End Sub

End Class