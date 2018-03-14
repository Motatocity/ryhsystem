Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmdevice_computer
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
    Private Sub frmdevice_computer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

                ComboBoxcomb.Text = mySqlReader("name")
                tab3model.Text = mySqlReader("model")
                tab3cpu.Text = mySqlReader("c_cpu")
                tab3mb.Text = mySqlReader("c_mainboard")
                tab3ram.Text = mySqlReader("c_ram")
                tab3hd.Text = mySqlReader("c_harddisk")
                tab3vga.Text = mySqlReader("c_vgacard")
                tab3ipnumber.Text = mySqlReader("c_ipnumber")
                tab3detail.Text = mySqlReader("detail")
                tab3ps.Text = mySqlReader("c_ps")
                tab3cd.Text = mySqlReader("c_cd")
                tab3case.Text = mySqlReader("c_case")
                tab3serial.Text = mySqlReader("serialnumber")
                tab3comname.Text = mySqlReader("c_comname")
                tab3windows.Text = mySqlReader("c_windows")
                tab3office.Text = mySqlReader("c_office")
                tab3other.Text = mySqlReader("c_other")
                tab3id.Text = mySqlReader("iddata_device")
                tab3price.Text = mySqlReader("price")
                If mySqlReader("computerhims") = "มี" Then
                    CheckBoxhims.Checked = True
                Else
                    CheckBoxhims.Checked = False
                End If
                If mySqlReader("computerpacs") = "มี" Then
                    CheckBoxpacs.Checked = True
                Else
                    CheckBoxpacs.Checked = False
                End If
                If mySqlReader("computerlab") = "มี" Then
                    CheckBoxlab.Checked = True
                Else
                    CheckBoxlab.Checked = False
                End If
                If mySqlReader("computersystem") = "มี" Then
                    CheckBoxsystem.Checked = True
                Else
                    CheckBoxsystem.Checked = False
                End If
                If mySqlReader("computeradmin") = "มี" Then
                    CheckBoxadmin.Checked = True
                Else
                    CheckBoxadmin.Checked = False
                End If
                If mySqlReader("computerdeep") = "มี" Then
                    CheckBoxdeep.Checked = True
                Else
                    CheckBoxdeep.Checked = False
                End If

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
         
            While (mySqlReader.Read())
                ComboBoxcomb.Items.Add(mySqlReader("brand_name"))
              
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()




    End Sub

    Private Sub btnxsavecom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub btnsavecom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavecom.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim computerhims As String
        Dim computerpacs As String
        Dim computerlab As String
        Dim computersystem As String
        Dim computeradmin As String
        Dim computerdeep As String
        If CheckBoxhims.Checked = True Then
            computerhims = "มี"
        ElseIf CheckBoxhims.Checked = False Then
            computerhims = "ไม่มี"
        End If
        If CheckBoxpacs.Checked = True Then
            computerpacs = "มี"
        ElseIf CheckBoxpacs.Checked = False Then
            computerpacs = "ไม่มี"
        End If
        If CheckBoxlab.Checked = True Then
            computerlab = "มี"
        ElseIf CheckBoxlab.Checked = False Then
            computerlab = "ไม่มี"
        End If
        If CheckBoxsystem.Checked = True Then
            computersystem = "มี"
        ElseIf CheckBoxsystem.Checked = False Then
            computersystem = "ไม่มี"
        End If
        If CheckBoxadmin.Checked = True Then
            computeradmin = "มี"
        ElseIf CheckBoxadmin.Checked = False Then
            computeradmin = "ไม่มี"
        End If
        If CheckBoxdeep.Checked = True Then
            computerdeep = "มี"
        ElseIf CheckBoxdeep.Checked = False Then
            computerdeep = "ไม่มี"
        End If

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxcomb.Text & "' , model = '" & tab3model.Text & "' , c_cpu = '" & tab3cpu.Text & "' , c_mainboard = '" & tab3mb.Text & "', c_ram = '" & tab3ram.Text & "' ,c_harddisk = '" & tab3hd.Text & "' ,c_vgacard = '" & tab3vga.Text & "',c_ipnumber = '" & tab3ipnumber.Text & "',detail = '" & tab3detail.Text & "',c_ps = '" & tab3ps.Text & "' ,c_cd = '" & tab3cd.Text & "',c_case = '" & tab3case.Text & "',serialnumber = '" & tab3serial.Text & "',price = '" & tab3price.Text & "',c_comname = '" & tab3comname.Text & "',c_windows = '" & tab3windows.Text & "',c_office = '" & tab3office.Text & "',c_other = '" & tab3other.Text & "',computerhims = '" & computerhims & "',computerpacs = '" & computerpacs & "',computerlab = '" & computerlab & "',computersystem = '" & computersystem & "',computeradmin = '" & computeradmin & "',computerdeep = '" & computerdeep & "' WHERE iddata_device = " & tab3id.Text & "; "
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