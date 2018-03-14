Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data


Public Class frmdevice_other
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


    Private Sub frmdevice_other_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxotherb.Text = mySqlReader("name")
                tab4model.Text = mySqlReader("model")
                tab4id.Text = mySqlReader("iddata_device")
                tab4detail.Text = mySqlReader("detail")
                tab4serial.Text = mySqlReader("serialnumber")
                tab4price.Text = mySqlReader("price")
                ComboBoxtypeother.Text = mySqlReader("s_type")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        sql.Close()


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM brand order by idbrand ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ComboBoxotherb.Items.Clear()
        
            While (mySqlReader.Read())
                ComboBoxotherb.Items.Add(mySqlReader("brand_name"))
             
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnsaveother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveother.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxotherb.Text & "' , model = '" & tab4model.Text & "' , serialnumber = '" & tab4serial.Text & "', detail = '" & tab4detail.Text & "',price = '" & tab4price.Text & "' ,s_type = '" & ComboBoxtypeother.Text & "' WHERE iddata_device = " & tab4id.Text & "; "

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