Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmdevice_monitor
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Public Sub New(ByRef idstring As String)
        idkey = idstring
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmdevice_monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Sql.State = ConnectionState.Closed Then
            Sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = Sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxmonitorb.Text = mySqlReader("name")
                tab1model.Text = mySqlReader("model")
                tab1id.Text = mySqlReader("iddata_device")
                tab1detail.Text = mySqlReader("detail")
                tab1serial.Text = mySqlReader("serialnumber")
                tab1size.Text = mySqlReader("m_size")
                tab1price.Text = mySqlReader("price")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM brand order by idbrand ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
     
            ComboBoxmonitorb.Items.Clear()
            While (mySqlReader.Read())
           
                ComboBoxmonitorb.Items.Add(mySqlReader("brand_name"))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()




    End Sub

    Private Sub btnsavemonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavemonitor.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Complete")

        If respone = 1 Then


            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxmonitorb.Text & "' , model = '" & tab1model.Text & "' , serialnumber = '" & tab1serial.Text & "', detail = '" & tab1detail.Text & "', m_size = '" & tab1size.Text & "',price = '" & tab1price.Text & "' WHERE iddata_device = " & tab1id.Text & "; "

                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql

                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        Me.Close()
    End Sub
End Class