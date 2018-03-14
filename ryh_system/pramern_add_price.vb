Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class pramern_add_price
    Dim mysql As MySqlConnection
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Private Sub pramern_add_price_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            MySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try




        Try
            MyODBCConnection.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT distinct OTBSURGRP from  ORCTABV5PF ")


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                group_sur.Items.Add(dr.GetString(0).Trim)




                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()
    End Sub

    Private Sub group_sur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_sur.SelectedIndexChanged

        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT distinct OTBSURTYP from  ORCTABV5PF  where  OTBSURGRP ='" & group_sur.Text & "'")


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        surtyp.Items.Clear()

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                surtyp.Items.Add(dr.GetString(0).Trim)



                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()

    End Sub

    Private Sub surtyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surtyp.SelectedIndexChanged


        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT distinct OTBSURNAM from  ORCTABV5PF  where  OTBSURGRP ='" & group_sur.Text & "' and OTBSURTYP = '" & surtyp.Text & "'")


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        surDiag.Items.Clear()

        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                surDiag.Items.Add(dr.GetString(0).Trim)




                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        Dim respone As Object


        Dim size As String
        Dim condition As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Try

                mySqlCommand.CommandText = "INSERT INTO pramern_price (group_name,type_name,diag_name,name_thai,otbsurcod) VALUES ('" & group_sur.Text & "','" & surtyp.Text & "', '" & surDiag.Text & "', '" & txt_name_thai.Text & "','" & idlabel.Text & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()

                clear()
                mysql.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
                mysql.Close()
                Exit Sub

            End Try


        End If
    End Sub
    Public Sub clear()
        group_sur.Text = ""
        surtyp.Text = ""
        surDiag.Text = ""
        txt_name_thai.Text = ""
    End Sub

    Private Sub surDiag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surDiag.SelectedIndexChanged

        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT distinct OTBSURCOD from  ORCTABV5PF  where  OTBSURGRP ='" & group_sur.Text & "' and OTBSURTYP = '" & surtyp.Text & "' and OTBSURNAM ='" & surDiag.Text & "'")


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If


        selectCMD.Connection = MyODBCConnection

        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                idlabel.Text = dr.GetString(0).Trim




                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()

    End Sub
End Class