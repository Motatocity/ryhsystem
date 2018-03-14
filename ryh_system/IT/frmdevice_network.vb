Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmdevice_network
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


    Private Sub frmdevice_network_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                ComboBoxnetb.Text = mySqlReader("name")
                tab6ipnumber.Text = mySqlReader("c_ipnumber")
                tab6id.Text = mySqlReader("iddata_device")
                tab6detail.Text = mySqlReader("detail")
                tab6serial.Text = mySqlReader("serialnumber")
                tab6price.Text = mySqlReader("price")
                tab6passconnect.Text = mySqlReader("pass_connect")
                tab6passconfig.Text = mySqlReader("pass_config")
                tab6model.Text = mySqlReader("model")
                ComboBoxtypenet.Text = mySqlReader("s_type")

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
            ComboBoxnetb.Items.Clear()
      
            While (mySqlReader.Read())
                ComboBoxnetb.Items.Add(mySqlReader("brand_name"))
         
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()





    End Sub

    Private Sub btnsavenet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavenet.Click
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
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxnetb.Text & "' , serialnumber = '" & tab6serial.Text & "' , c_ipnumber = '" & tab6ipnumber.Text & "', pass_connect = '" & tab6passconnect.Text & "', pass_config = '" & tab6passconfig.Text & "', detail = '" & tab6detail.Text & "', price = '" & tab6price.Text & "',model = '" & tab6model.Text & "' ,s_type = '" & ComboBoxtypenet.Text & "' WHERE iddata_device = " & tab6id.Text & "; "

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