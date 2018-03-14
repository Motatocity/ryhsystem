Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmdevice_printer
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
    Private Sub frmdevice_printer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxprinb.Text = mySqlReader("name")
                tab2model.Text = mySqlReader("model")
                tab2id.Text = mySqlReader("iddata_device")
                tab2detail.Text = mySqlReader("detail")
                tab2serial.Text = mySqlReader("serialnumber")
                tab2price.Text = mySqlReader("price")
                If mySqlReader("p_type") = "Laser Printer สี" Then
                    Radiolaserc.Checked = True
                Else
                    Radiolaserc.Checked = False
                End If
                If mySqlReader("p_type") = "Laser Printer ขาว-ดำ" Then
                    Radiolaserwb.Checked = True
                Else
                    Radiolaserwb.Checked = False
                End If
                If mySqlReader("p_type") = "Dot-matrix Printer" Then
                    Radiodot.Checked = True
                Else
                    Radiodot.Checked = False
                End If
                If mySqlReader("p_type") = "Inkjet Printer" Then
                    Radioinkjet.Checked = True
                Else
                    Radioinkjet.Checked = False
                End If
                If mySqlReader("p_type") = "Sticker Printer" Then
                    Radiosticker.Checked = True
                Else
                    Radiosticker.Checked = False
                End If
                If mySqlReader("p_type") = "Inkjet-all in one" Then
                    Radioinkall.Checked = True
                Else
                    Radioinkall.Checked = False
                End If
                If mySqlReader("p_type") = "Laser-all in one" Then
                    Radiolaserall.Checked = True
                Else
                    Radiolaserall.Checked = False
                End If
                If mySqlReader("p_type") = "Laser-multifunction" Then
                    Radiolasermulti.Checked = True
                Else
                    Radiolasermulti.Checked = False
                End If

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
   
            ComboBoxprinb.Items.Clear()

            While (mySqlReader.Read())
    
                ComboBoxprinb.Items.Add(mySqlReader("brand_name"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub btnsaveprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveprin.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        Dim printer As String
        If Radiolaserc.Checked = True Then
            printer = "Laser Printer สี"
        End If
        If Radiolaserwb.Checked = True Then
            printer = "Laser Printer ขาว-ดำ"
        End If
        If Radiodot.Checked = True Then
            printer = "Dot-matrix Printer"
        End If
        If Radioinkjet.Checked = True Then
            printer = "Inkjet Printer"
        End If
        If Radiosticker.Checked = True Then
            printer = "Sticker Printer"
        End If
        If Radioinkall.Checked = True Then
            printer = "Inkjet-all in one"
        End If
        If Radiolaserall.Checked = True Then
            printer = "Laser-all in one"
        End If
        If Radiolasermulti.Checked = True Then
            printer = "Laser-multifunction"
        End If
        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Complete")
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        If respone = 1 Then


            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxprinb.Text & "' , model = '" & tab2model.Text & "' , serialnumber = '" & tab2serial.Text & "', detail = '" & tab2detail.Text & "', p_type = '" & printer & "', price = '" & tab2price.Text & "' WHERE iddata_device = " & tab2id.Text & "; "
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