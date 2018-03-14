Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core

Public Class frmmain_census
    Dim mysql As MySqlConnection
    Dim mysql_ryh As MySqlConnection
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim inbtIndex As Integer
    Dim cmd_result As Integer
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim check As String = "0"
    Public Sub callICU()
        Try
            TextBoxX7.Text = CInt(TextBoxX40.Text) + CInt(TextBoxX10.Text) + CInt(TextBoxX11.Text) + CInt(TextBoxX39.Text)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub callLR()
        Try
            TextBoxX14.Text = CInt(TextBoxX15.Text) + CInt(TextBoxX16.Text) + CInt(TextBoxX20.Text) + CInt(TextBoxX25.Text)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub callOR()
        Try
            TextBoxX17.Text = CInt(TextBoxX18.Text) + CInt(TextBoxX19.Text) + CInt(TextBoxX26.Text) + CInt(TextBoxX27.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmmain_census_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cleartxt()
        If ComboBox1.Text = "ICU" Or ComboBox1.Text = "W3" Or ComboBox1.Text = "W4" Or ComboBox1.Text = "W5" Or ComboBox1.Text = "W6" Then

            TextBoxX7.ReadOnly = False
            TextBoxX8.ReadOnly = False
            TextBoxX9.ReadOnly = False
            TextBoxX10.ReadOnly = False
            TextBoxX11.ReadOnly = False
            TextBoxX12.ReadOnly = False
            TextBoxX13.ReadOnly = False
            TextBoxX39.ReadOnly = False
            TextBoxX44.ReadOnly = False
            TextBoxX7.Text = ""
            TextBoxX8.Text = ""
            TextBoxX9.Text = ""
            TextBoxX10.Text = ""
            TextBoxX11.Text = ""
            TextBoxX12.Text = ""
            TextBoxX13.Text = ""
            TextBoxX39.Text = ""



        ElseIf ComboBox1.Text = "OPD" Then
            TextBoxX24.ReadOnly = False
            TextBoxX31.ReadOnly = False
            TextBoxX35.ReadOnly = False
            TextBoxX36.ReadOnly = False
            TextBoxX37.ReadOnly = False
            TextBoxX41.ReadOnly = False


            TextBoxX24.Text = ""
            TextBoxX31.Text = ""
            TextBoxX35.Text = ""
            TextBoxX36.Text = ""
            TextBoxX37.Text = ""
            TextBoxX41.Text = ""


        ElseIf ComboBox1.Text = "ER" Then
            TextBoxX23.ReadOnly = False
            TextBoxX30.ReadOnly = False
            TextBoxX34.ReadOnly = False
            TextBoxX38.ReadOnly = False
            TextBoxX22.ReadOnly = False
            TextBoxX29.ReadOnly = False
            TextBoxX33.ReadOnly = False
            TextBoxX32.ReadOnly = False


            TextBoxX23.Text = ""
            TextBoxX30.Text = ""
            TextBoxX34.Text = ""
            TextBoxX38.Text = ""
            TextBoxX22.Text = ""
            TextBoxX29.Text = ""
            TextBoxX33.Text = ""
            TextBoxX32.Text = ""


        ElseIf ComboBox1.Text = "LR" Then

            TextBoxX14.ReadOnly = False
            TextBoxX15.ReadOnly = False
            TextBoxX16.ReadOnly = False
            TextBoxX20.ReadOnly = False
            TextBoxX25.ReadOnly = False


            TextBoxX14.Text = ""
            TextBoxX15.Text = ""
            TextBoxX16.Text = ""
            TextBoxX20.Text = ""
            TextBoxX25.Text = ""

        ElseIf ComboBox1.Text = "OR" Then
            TextBoxX17.ReadOnly = False
            TextBoxX18.ReadOnly = False
            TextBoxX19.ReadOnly = False
            TextBoxX26.ReadOnly = False
            TextBoxX27.ReadOnly = False

            TextBoxX17.Text = ""
            TextBoxX18.Text = ""
            TextBoxX19.Text = ""
            TextBoxX26.Text = ""
            TextBoxX27.Text = ""

        ElseIf ComboBox1.Text = "HD" Then
            TextBoxX21.ReadOnly = False
            TextBoxX28.ReadOnly = False

            TextBoxX21.Text = ""
            TextBoxX28.Text = ""


        End If

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
        Try
            MyODBCConnection.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        'Open the connection

        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Try
            inbtIndex = e.RowIndex

            DataGridViewX1.Rows(inbtIndex).Selected = True

            loadname()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewX1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                If DataGridViewX1.Rows(inbtIndex).Cells(0).Value <> "" Then
                    MyODBCConnection.Close()
                    Try
                        If MyODBCConnection.State = ConnectionState.Closed Then

                            MyODBCConnection.Open()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    'MsgBox(inbtIndex)
                    Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'")

                    selectCMD.Connection = MyODBCConnection


                    Try
                        Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                        'start the Read loop
                        While dr.Read
                            DataGridViewX1.Rows(inbtIndex).Cells(1).Value = dr.GetString(0) + "   " + dr.GetString(1)
                        End While

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    'Set the mouse to show a Wait cursor
                    MyODBCConnection.Close()
                End If


            End If
        Catch ex As Exception

        End Try


    End Sub
    Public Sub loadname()
        If DataGridViewX1.Rows(inbtIndex).Cells(0).Value <> "" Then
            MyODBCConnection.Close()
            Try
                If MyODBCConnection.State = ConnectionState.Closed Then

                    MyODBCConnection.Open()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'MsgBox(inbtIndex)
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    DataGridViewX1.Rows(inbtIndex).Cells(1).Value = Trim(dr.GetString(0)) + "   " + Trim(dr.GetString(1))
                End While

            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
            'Set the mouse to show a Wait cursor
            MyODBCConnection.Close()
        End If



    End Sub
    Public Sub loadname1()
        If DataGridViewX2.Rows(inbtIndex).Cells(0).Value <> "" Then
            MyODBCConnection.Close()
            Try
                If MyODBCConnection.State = ConnectionState.Closed Then

                    MyODBCConnection.Open()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'MsgBox(inbtIndex)
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX2.Rows(inbtIndex).Cells(0).Value & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    DataGridViewX2.Rows(inbtIndex).Cells(1).Value = Trim(dr.GetString(0)) + "   " + Trim(dr.GetString(1))
                End While

            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
            'Set the mouse to show a Wait cursor
            MyODBCConnection.Close()
        End If
    End Sub
    Private Sub DataGridViewX2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX2.CellClick
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        'Open the connection

        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Try
            inbtIndex = e.RowIndex

            DataGridViewX2.Rows(inbtIndex).Selected = True

            loadname1()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewX3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX3.CellClick
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        'Open the connection

        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Try
            inbtIndex = e.RowIndex

            DataGridViewX3.Rows(inbtIndex).Selected = True

            loadname3()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadname3()
        If DataGridViewX3.Rows(inbtIndex).Cells(0).Value <> "" Then
            MyODBCConnection.Close()
            Try
                If MyODBCConnection.State = ConnectionState.Closed Then

                    MyODBCConnection.Open()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'MsgBox(inbtIndex)
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX3.Rows(inbtIndex).Cells(0).Value & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    DataGridViewX3.Rows(inbtIndex).Cells(1).Value = Trim(dr.GetString(0)) + "   " + Trim(dr.GetString(1))
                End While

            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
            'Set the mouse to show a Wait cursor
            MyODBCConnection.Close()
        End If
    End Sub
    Public Sub loadname4()
        If DataGridViewX4.Rows(inbtIndex).Cells(0).Value <> "" Then
            MyODBCConnection.Close()
            Try
                If MyODBCConnection.State = ConnectionState.Closed Then

                    MyODBCConnection.Open()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'MsgBox(inbtIndex)
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX4.Rows(inbtIndex).Cells(0).Value & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    DataGridViewX4.Rows(inbtIndex).Cells(1).Value = Trim(dr.GetString(0)) + "   " + Trim(dr.GetString(1))
                End While

            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
            'Set the mouse to show a Wait cursor
            MyODBCConnection.Close()
        End If
    End Sub
    Private Sub DataGridViewX4_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX4.CellClick
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        'Open the connection

        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Try
            inbtIndex = e.RowIndex

            DataGridViewX4.Rows(inbtIndex).Selected = True

            loadname4()

        Catch ex As Exception

        End Try



    End Sub
    Private Sub DataGridViewX2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX2.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                If DataGridViewX2.Rows(inbtIndex).Cells(0).Value <> "" Then
                    MyODBCConnection.Close()
                    Try
                        If MyODBCConnection.State = ConnectionState.Closed Then

                            MyODBCConnection.Open()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    'MsgBox(inbtIndex)
                    Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX2.Rows(inbtIndex).Cells(0).Value & "'")

                    selectCMD.Connection = MyODBCConnection


                    Try
                        Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                        'start the Read loop
                        While dr.Read
                            DataGridViewX2.Rows(inbtIndex).Cells(1).Value = dr.GetString(0) + "   " + dr.GetString(1)
                        End While

                    Catch ex As Exception

                    End Try
                    'Set the mouse to show a Wait cursor
                    MyODBCConnection.Close()
                End If


            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridViewX3_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX3.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                If DataGridViewX3.Rows(inbtIndex).Cells(0).Value <> "" Then
                    MyODBCConnection.Close()
                    Try
                        If MyODBCConnection.State = ConnectionState.Closed Then

                            MyODBCConnection.Open()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    'MsgBox(inbtIndex)
                    Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX3.Rows(inbtIndex).Cells(0).Value & "'")

                    selectCMD.Connection = MyODBCConnection


                    Try
                        Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                        'start the Read loop
                        While dr.Read
                            DataGridViewX3.Rows(inbtIndex).Cells(1).Value = dr.GetString(0) + "   " + dr.GetString(1)
                        End While

                    Catch ex As Exception

                    End Try
                    'Set the mouse to show a Wait cursor
                    MyODBCConnection.Close()
                End If


            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If check = "1" Then

            If ComboBox2.Text.Length > 0 Then
                Dim respone As Object

                Dim size As String
                Dim condition As String



                Dim deatch1 As String = "0"
                Dim refer As String = "0"


                mysql.Close()
                respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
                If respone = 1 Then
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If



                    Try
                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_main (cendep,cendate,cenfate,cenrn,cenpn,cenna,cenwc,check1,checktxt,checktxt1,userrequest,nameuser) VALUES (@cendep,@cendate,@cenfate,@cenrn,@cenpn,@cenna,@cenwc,@check1,@checktxt,@checktxt1,@userrequest,@nameuser); SELECT LAST_INSERT_ID()"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql

                        mySqlCommand.Parameters.AddWithValue("@cendep", ComboBox1.Text)
                        mySqlCommand.Parameters.AddWithValue("@cendate", DateTimeInput1.Value.ToString("dd-MM-yyyy"))

                        mySqlCommand.Parameters.AddWithValue("@cenfate", ComboBox2.Text)
                        mySqlCommand.Parameters.AddWithValue("@cenrn", TextBoxX1.Text)
                        mySqlCommand.Parameters.AddWithValue("@cenpn", TextBoxX2.Text)
                        mySqlCommand.Parameters.AddWithValue("@cenna", TextBoxX3.Text)
                        mySqlCommand.Parameters.AddWithValue("@cenwc", TextBoxX4.Text)
                        If RadioButton1.Checked = True Then
                            mySqlCommand.Parameters.AddWithValue("@check1", "0")
                            mySqlCommand.Parameters.AddWithValue("@checktxt", " ")
                            mySqlCommand.Parameters.AddWithValue("@checktxt1", " ")
                        ElseIf RadioButton2.Checked = True Then
                            mySqlCommand.Parameters.AddWithValue("@check1", "1")
                            mySqlCommand.Parameters.AddWithValue("@checktxt", TextBoxX5.Text)
                            mySqlCommand.Parameters.AddWithValue("@checktxt1", TextBoxX6.Text)
                        End If
                        mySqlCommand.Parameters.AddWithValue("@userrequest", TextBoxX52.Text)
                        mySqlCommand.Parameters.AddWithValue("@nameuser", Label62.Text)
                        cmd_result = CInt(mySqlCommand.ExecuteScalar())


                        mysql.Close()

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        mysql.Close()


                    End Try

                    mysql.Close()
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    If ComboBox1.Text = "IPD" Or ComboBox1.Text = "W3" Or ComboBox1.Text = "W4" Or ComboBox1.Text = "W5" Or ComboBox1.Text = "W6" Or ComboBox1.Text = "ICU" Then
                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_ipd (ipdsum,ipdadmit,ipddc,ipdci,ipdsi,ipdmi,ipdcl,ipdmain,ipdicu,ipdroom) VALUES (@ipdsum,@ipdadmit,@ipddc,@ipdci,@ipdsi,@ipdmi,@ipdcl,@ipdmain,@ipdicu,@ipdroom);"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql
                        mySqlCommand.Parameters.AddWithValue("@ipdsum", TextBoxX7.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipdadmit", TextBoxX8.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipddc", TextBoxX9.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipdci", TextBoxX10.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipdsi", TextBoxX11.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipdmi", TextBoxX12.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipdcl", TextBoxX39.Text)
                        mySqlCommand.Parameters.AddWithValue("@ipdmain", cmd_result)
                        mySqlCommand.Parameters.AddWithValue("@ipdicu", TextBoxX40.Text)

                        mySqlCommand.Parameters.AddWithValue("@ipdroom", TextBoxX44.Text)

                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()

                    ElseIf ComboBox1.Text = "LR" Then
                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_lr (lrsum,lrbirth,lrwbirth,lrns,lrdiag,lrmain,lroperative,lrafterbirth) VALUES (@lrsum,@lrbirth,@lrwbirth,@lrns,@lrdiag,@lrmain,@lroperative,@lrafterbirth);"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql
                        mySqlCommand.Parameters.AddWithValue("@lrsum", TextBoxX14.Text)
                        mySqlCommand.Parameters.AddWithValue("@lrbirth", TextBoxX15.Text)
                        mySqlCommand.Parameters.AddWithValue("@lrwbirth", TextBoxX16.Text)
                        mySqlCommand.Parameters.AddWithValue("@lrns", TextBoxX20.Text)
                        mySqlCommand.Parameters.AddWithValue("@lrdiag", TextBoxX25.Text)
                        mySqlCommand.Parameters.AddWithValue("@lrmain", cmd_result)
                        mySqlCommand.Parameters.AddWithValue("@lroperative", TextBoxX42.Text)
                        mySqlCommand.Parameters.AddWithValue("@lrafterbirth", TextBoxX43.Text)
                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()
                    ElseIf ComboBox1.Text = "OR" Then
                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_or (orsum,ormajor,orminor,orsmall,ormain,orscope) VALUES (@orsum,@ormajor,@orminor,@orsmall,@ormain,@orscope);"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql
                        mySqlCommand.Parameters.AddWithValue("@orsum", TextBoxX17.Text)
                        mySqlCommand.Parameters.AddWithValue("@ormajor", TextBoxX18.Text)
                        mySqlCommand.Parameters.AddWithValue("@orminor", TextBoxX19.Text)
                        mySqlCommand.Parameters.AddWithValue("@orsmall", TextBoxX26.Text)
                        mySqlCommand.Parameters.AddWithValue("@ormain", cmd_result)
                        mySqlCommand.Parameters.AddWithValue("@orscope", TextBoxX27.Text)

                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()



                    ElseIf ComboBox1.Text = "OPD" Then

                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_opd (opdsum,opdgen,opddek,opdcheck,opdadmit,opdmain,opddekhud) VALUES (@opdsum,@opdgen,@opddek,@opdcheck,@opdadmit,@opdmain,@opddekhud);"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql
                        mySqlCommand.Parameters.AddWithValue("@opdsum", TextBoxX24.Text)
                        mySqlCommand.Parameters.AddWithValue("@opdgen", TextBoxX31.Text)
                        mySqlCommand.Parameters.AddWithValue("@opddek", TextBoxX35.Text)
                        mySqlCommand.Parameters.AddWithValue("@opdcheck", TextBoxX36.Text)
                        mySqlCommand.Parameters.AddWithValue("@opdadmit", TextBoxX37.Text)
                        mySqlCommand.Parameters.AddWithValue("@opddekhud", TextBoxX41.Text)
                        mySqlCommand.Parameters.AddWithValue("@opdmain", cmd_result)
                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()

                    ElseIf ComboBox1.Text = "ER" Then

                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_er (ersum,eradmit,erambuin,erambuout,eremergency,erurgent,ernonurgent,ernonacute,ermain) VALUES (@ersum,@eradmit,@erambuin,@erambuout,@eremergency,@erurgent,@ernonurgent,@ernonacute,@ermain);"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql
                        mySqlCommand.Parameters.AddWithValue("@ersum", TextBoxX23.Text)
                        mySqlCommand.Parameters.AddWithValue("@eradmit", TextBoxX30.Text)
                        mySqlCommand.Parameters.AddWithValue("@erambuin", TextBoxX34.Text)
                        mySqlCommand.Parameters.AddWithValue("@erambuout", TextBoxX38.Text)
                        mySqlCommand.Parameters.AddWithValue("@eremergency", TextBoxX22.Text)
                        mySqlCommand.Parameters.AddWithValue("@erurgent", TextBoxX29.Text)
                        mySqlCommand.Parameters.AddWithValue("@ernonurgent", TextBoxX33.Text)
                        mySqlCommand.Parameters.AddWithValue("@ernonacute", TextBoxX32.Text)
                        mySqlCommand.Parameters.AddWithValue("@ermain", cmd_result)

                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()
                    ElseIf ComboBox1.Text = "HD" Or ComboBox1.Text = "MEC" Then


                        mySqlCommand.Parameters.Clear()
                        mySqlCommand.CommandText = "INSERT INTO census_hd (hdsum,hdmec,hdmain,hdegd,hdcolono,hdercp,hdhemo,hdpipe,hdadmit,hdoperative) VALUES (@hdsum,@hdmec,@hdmain,@hdegd,@hdcolono,@hdercp,@hdhemo,@hdpipe,@hdadmit,@hdoperative);"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = mysql
                        mySqlCommand.Parameters.AddWithValue("@hdsum", TextBoxX21.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdmec", TextBoxX28.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdmain", cmd_result)


                        mySqlCommand.Parameters.AddWithValue("@hdegd", TextBoxX45.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdcolono", TextBoxX46.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdercp", TextBoxX47.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdhemo", TextBoxX48.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdpipe", TextBoxX49.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdadmit", TextBoxX50.Text)
                        mySqlCommand.Parameters.AddWithValue("@hdoperative", TextBoxX51.Text)


                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()



                    End If



                    If DataGridViewX1.Rows.Count > 1 Then
                        For i = 0 To DataGridViewX1.Rows.Count - 1
                            mysql.Close()
                            If mysql.State = ConnectionState.Closed Then
                                mysql.Open()
                            End If
                            mySqlCommand.Parameters.Clear()
                            mySqlCommand.CommandText = "INSERT INTO census_cpr (cprmain,cprhn,cprnamelast,cprdx,cprdoctor) VALUES (@cprmain,@cprhn,@cprnamelast,@cprdx,@cprdoctor);"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql
                            mySqlCommand.Parameters.AddWithValue("@cprmain", cmd_result)
                            mySqlCommand.Parameters.AddWithValue("@cprhn", DataGridViewX1.Rows(i).Cells(0).Value)
                            mySqlCommand.Parameters.AddWithValue("@cprnamelast", DataGridViewX1.Rows(i).Cells(1).Value)
                            mySqlCommand.Parameters.AddWithValue("@cprdx", DataGridViewX1.Rows(i).Cells(2).Value)
                            mySqlCommand.Parameters.AddWithValue("@cprdoctor", DataGridViewX1.Rows(i).Cells(3).Value)
                            mySqlCommand.ExecuteNonQuery()
                            mysql.Close()
                        Next
                    End If



                    If DataGridViewX2.Rows.Count > 1 Then
                        For i = 0 To DataGridViewX2.Rows.Count - 1
                            mysql.Close()
                            If mysql.State = ConnectionState.Closed Then
                                mysql.Open()
                            End If

                            mySqlCommand.Parameters.Clear()
                            mySqlCommand.CommandText = "INSERT INTO census_cdc (cdcmain,cdchn,cdcname,cdcdx,cdcfiu) VALUES (@cdcmain,@cdchn,@cdcname,@cdcdx,@cdcfiu);"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql
                            mySqlCommand.Parameters.AddWithValue("@cdcmain", cmd_result)
                            mySqlCommand.Parameters.AddWithValue("@cdchn", DataGridViewX2.Rows(i).Cells(0).Value)
                            mySqlCommand.Parameters.AddWithValue("@cdcname", DataGridViewX2.Rows(i).Cells(1).Value)
                            mySqlCommand.Parameters.AddWithValue("@cdcdx", DataGridViewX2.Rows(i).Cells(2).Value)
                            mySqlCommand.Parameters.AddWithValue("@cdcfiu", DataGridViewX2.Rows(i).Cells(3).Value)
                            mySqlCommand.ExecuteNonQuery()
                            mysql.Close()
                        Next
                    End If




                    If DataGridViewX3.Rows.Count > 1 Then
                        For i = 0 To DataGridViewX3.Rows.Count - 1

                            mysql.Close()
                            If mysql.State = ConnectionState.Closed Then
                                mysql.Open()
                            End If
                            If DataGridViewX3.Rows(i).Cells(3).Value = True Then
                                deatch1 = "1"
                            ElseIf DataGridViewX3.Rows(i).Cells(4).Value = True Then
                                deatch1 = "2"
                            End If
                            mySqlCommand.Parameters.Clear()
                            mySqlCommand.CommandText = "INSERT INTO census_death (deathmain,deathhn,deathname,deathroom,deathcheck) VALUES (@deathmain,@deathhn,@deathname,@deathroom,@deathcheck);"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql
                            mySqlCommand.Parameters.AddWithValue("@deathmain", cmd_result)
                            mySqlCommand.Parameters.AddWithValue("@deathhn", DataGridViewX3.Rows(i).Cells(0).Value)
                            mySqlCommand.Parameters.AddWithValue("@deathname", DataGridViewX3.Rows(i).Cells(1).Value)
                            mySqlCommand.Parameters.AddWithValue("@deathroom", DataGridViewX3.Rows(i).Cells(2).Value)
                            mySqlCommand.Parameters.AddWithValue("@deathcheck", deatch1)
                            mySqlCommand.ExecuteNonQuery()
                            mysql.Close()
                        Next
                    End If

                    If DataGridViewX4.Rows.Count > 1 Then


                        mysql.Close()
                        If mysql.State = ConnectionState.Closed Then
                            mysql.Open()
                        End If
                        For i = 0 To DataGridViewX4.Rows.Count - 1
                            If DataGridViewX4.Rows(i).Cells(2).Value = True Then
                                refer = "1"
                            ElseIf DataGridViewX4.Rows(i).Cells(3).Value = True Then

                                refer = "2"
                            ElseIf DataGridViewX4.Rows(i).Cells(4).Value = True Then
                                refer = "3"
                            End If
                            mySqlCommand.Parameters.Clear()
                            mySqlCommand.CommandText = "INSERT INTO census_refer (refermain,refername,refercheck,referhn) VALUES (@refermain,@refername,@refercheck,@referhn);"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql
                            mySqlCommand.Parameters.AddWithValue("@refermain", cmd_result)
                            mySqlCommand.Parameters.AddWithValue("@refername", DataGridViewX4.Rows(i).Cells(1).Value)
                            mySqlCommand.Parameters.AddWithValue("@refercheck", refer)
                            mySqlCommand.Parameters.AddWithValue("@referhn", DataGridViewX4.Rows(i).Cells(0).Value)


                            mySqlCommand.ExecuteNonQuery()
                            mysql.Close()
                        Next
                    End If


                    MsgBox("บันทึกเสร็จสิ้น")
                    cleartxt()

                End If
            Else
                MsgBox("กรุณาเลือกเวร")

            End If
        Else
            MsgBox("กรุณากรอก User Request")



        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBoxX5.ReadOnly = False
        TextBoxX6.ReadOnly = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBoxX5.ReadOnly = True
        TextBoxX6.ReadOnly = True
    End Sub

    Public Sub listview1()
        If DataGridViewX1.Rows.Count > 0 Then
            For i = 0 To DataGridViewX1.Rows.Count - 1
                Try
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.Parameters.Clear()
                    mySqlCommand.CommandText = "INSERT INTO census_cpr (cprmain,cprhn,cprnamelast,cprdx,cprdoctor) VALUES (@cprmain,@cprhn,@cprnamelast,@cprdx,@cprdoctor);"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.Parameters.AddWithValue("@cprmain", cmd_result)
                    mySqlCommand.Parameters.AddWithValue("@cprhn", DataGridViewX1.Rows(i).Cells(0).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@cprnamelast", DataGridViewX1.Rows(i).Cells(1).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@cprdx", DataGridViewX1.Rows(i).Cells(2).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@cprdoctor", DataGridViewX1.Rows(i).Cells(3).Value.ToString)
                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                    mysql.Close()
                    Exit Sub
                End Try
            Next
        End If

        If DataGridViewX2.Rows.Count > 0 Then
            For i = 0 To DataGridViewX2.Rows.Count - 1
                Try
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.Parameters.Clear()
                    mySqlCommand.CommandText = "INSERT INTO census_cdc (cdcmain,cdchn,cdcname,cdcdx,cdcfiu) VALUES (@cprmain,@cprhn,@cprnamelast,@cprdx,@cprdoctor);"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.Parameters.AddWithValue("@cdcmain", cmd_result)
                    mySqlCommand.Parameters.AddWithValue("@cdchn", DataGridViewX2.Rows(i).Cells(0).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@cdcname", DataGridViewX2.Rows(i).Cells(1).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@cdcdx", DataGridViewX2.Rows(i).Cells(2).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@cdcfiu", DataGridViewX2.Rows(i).Cells(3).Value.ToString)
                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                    mysql.Close()
                    Exit Sub
                End Try
            Next
        End If



        If DataGridViewX3.Rows.Count > 0 Then
            For i = 0 To DataGridViewX3.Rows.Count - 1
                Try
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.Parameters.Clear()
                    mySqlCommand.CommandText = "INSERT INTO census_death (deathhn,deathname,deathroom,deathcheck,deathmain) VALUES (@deathhn,@deathname,@deathroom,@deathcheck,@deathmain);"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.Parameters.AddWithValue("@deathmain", cmd_result)
                    mySqlCommand.Parameters.AddWithValue("@deathhn", DataGridViewX3.Rows(i).Cells(0).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@deathname", DataGridViewX3.Rows(i).Cells(1).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@deathroom", DataGridViewX3.Rows(i).Cells(2).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@deathcheck", DataGridViewX3.Rows(i).Cells(3).Value.ToString)

                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    mysql.Close()
                    Exit Sub
                End Try
            Next
        End If
    End Sub


    Public Sub cleartxt()
        TextBoxX24.ReadOnly = True
        TextBoxX31.ReadOnly = True
        TextBoxX35.ReadOnly = True
        TextBoxX36.ReadOnly = True
        TextBoxX37.ReadOnly = True
        TextBoxX23.ReadOnly = True
        TextBoxX30.ReadOnly = True
        TextBoxX34.ReadOnly = True
        TextBoxX38.ReadOnly = True
        TextBoxX22.ReadOnly = True
        TextBoxX29.ReadOnly = True
        TextBoxX33.ReadOnly = True
        TextBoxX32.ReadOnly = True
        TextBoxX7.ReadOnly = True
        TextBoxX8.ReadOnly = True
        TextBoxX9.ReadOnly = True
        TextBoxX10.ReadOnly = True
        TextBoxX11.ReadOnly = True
        TextBoxX12.ReadOnly = True
        TextBoxX39.ReadOnly = True
        TextBoxX14.ReadOnly = True
        TextBoxX15.ReadOnly = True
        TextBoxX16.ReadOnly = True
        TextBoxX20.ReadOnly = True
        TextBoxX25.ReadOnly = True
        TextBoxX17.ReadOnly = True
        TextBoxX18.ReadOnly = True
        TextBoxX19.ReadOnly = True
        TextBoxX26.ReadOnly = True
        TextBoxX21.ReadOnly = True
        TextBoxX27.ReadOnly = True
        TextBoxX28.ReadOnly = True
        TextBoxX40.ReadOnly = True
        TextBoxX35.ReadOnly = True
        TextBoxX41.ReadOnly = True
        TextBoxX44.ReadOnly = True
        TextBoxX42.ReadOnly = True
        TextBoxX43.ReadOnly = True
        TextBoxX45.ReadOnly = True
        TextBoxX46.ReadOnly = True
        TextBoxX47.ReadOnly = True
        TextBoxX48.ReadOnly = True
        TextBoxX49.ReadOnly = True
        TextBoxX50.ReadOnly = True
        TextBoxX51.ReadOnly = True




        TextBoxX1.Text = ""
        TextBoxX2.Text = ""
        TextBoxX3.Text = ""
        TextBoxX4.Text = ""
        TextBoxX24.Text = ""
        TextBoxX31.Text = ""
        TextBoxX35.Text = ""
        TextBoxX36.Text = ""
        TextBoxX37.Text = ""
        TextBoxX23.Text = ""
        TextBoxX30.Text = ""
        TextBoxX34.Text = ""
        TextBoxX38.Text = ""
        TextBoxX22.Text = ""
        TextBoxX29.Text = ""
        TextBoxX33.Text = ""
        TextBoxX32.Text = ""
        TextBoxX7.Text = ""
        TextBoxX8.Text = ""
        TextBoxX9.Text = ""
        TextBoxX10.Text = ""
        TextBoxX11.Text = ""
        TextBoxX12.Text = ""
        TextBoxX39.Text = ""
        TextBoxX14.Text = ""
        TextBoxX15.Text = ""
        TextBoxX16.Text = ""
        TextBoxX20.Text = ""
        TextBoxX25.Text = ""
        TextBoxX17.Text = ""
        TextBoxX18.Text = ""
        TextBoxX19.Text = ""
        TextBoxX26.Text = ""
        TextBoxX21.Text = ""
        TextBoxX27.Text = ""
        TextBoxX28.Text = ""
        TextBoxX40.Text = ""
        TextBoxX35.Text = ""
        TextBoxX41.Text = ""
        TextBoxX44.Text = ""
        TextBoxX42.Text = ""
        TextBoxX43.Text = ""
        TextBoxX45.Text = ""
        TextBoxX46.Text = ""
        TextBoxX47.Text = ""
        TextBoxX48.Text = ""
        TextBoxX49.Text = ""
        TextBoxX50.Text = ""
        TextBoxX51.Text = ""





        check = "0"
        TextBoxX52.Text = ""
        Label62.Text = ""



    End Sub

    Private Sub DataGridViewX4_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX4.RowLeave
        Try
            If e.ColumnIndex = 0 Then
                If DataGridViewX4.Rows(inbtIndex).Cells(0).Value <> "" Then
                    MyODBCConnection.Close()
                    Try
                        If MyODBCConnection.State = ConnectionState.Closed Then

                            MyODBCConnection.Open()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    'MsgBox(inbtIndex)
                    Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF WHERE RMSHNREF = '" & DataGridViewX4.Rows(inbtIndex).Cells(0).Value & "';")

                    selectCMD.Connection = MyODBCConnection


                    Try
                        Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                        'start the Read loop
                        While dr.Read
                            DataGridViewX4.Rows(inbtIndex).Cells(1).Value = dr.GetString(0) + "   " + dr.GetString(1)
                        End While

                    Catch ex As Exception

                    End Try
                    'Set the mouse to show a Wait cursor
                    MyODBCConnection.Close()
                End If


            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        cleartxt()
        If ComboBox1.Text = "ICU" Or ComboBox1.Text = "W3" Or ComboBox1.Text = "W4" Or ComboBox1.Text = "W5" Or ComboBox1.Text = "W6" Then

            TextBoxX7.ReadOnly = False
            TextBoxX8.ReadOnly = False
            TextBoxX9.ReadOnly = False
            TextBoxX10.ReadOnly = False
            TextBoxX11.ReadOnly = False
            TextBoxX12.ReadOnly = False
            TextBoxX13.ReadOnly = False
            TextBoxX39.ReadOnly = False
            TextBoxX40.ReadOnly = False
            TextBoxX40.Text = ""
            TextBoxX7.Text = ""
            TextBoxX8.Text = ""
            TextBoxX9.Text = ""
            TextBoxX10.Text = ""
            TextBoxX11.Text = ""
            TextBoxX12.Text = ""
            TextBoxX13.Text = ""
            TextBoxX39.Text = ""

        ElseIf ComboBox1.Text = "OPD" Then
            TextBoxX24.ReadOnly = False
            TextBoxX31.ReadOnly = False
            TextBoxX35.ReadOnly = False
            TextBoxX36.ReadOnly = False
            TextBoxX37.ReadOnly = False
            TextBoxX41.ReadOnly = False



            TextBoxX24.Text = ""
            TextBoxX31.Text = ""
            TextBoxX35.Text = ""
            TextBoxX36.Text = ""
            TextBoxX37.Text = ""



        ElseIf ComboBox1.Text = "ER" Then
            TextBoxX23.ReadOnly = False
            TextBoxX30.ReadOnly = False
            TextBoxX34.ReadOnly = False
            TextBoxX38.ReadOnly = False
            TextBoxX22.ReadOnly = False
            TextBoxX29.ReadOnly = False
            TextBoxX33.ReadOnly = False
            TextBoxX32.ReadOnly = False


            TextBoxX23.Text = ""
            TextBoxX30.Text = ""
            TextBoxX34.Text = ""
            TextBoxX38.Text = ""
            TextBoxX22.Text = ""
            TextBoxX29.Text = ""
            TextBoxX33.Text = ""
            TextBoxX32.Text = ""


        ElseIf ComboBox1.Text = "LR" Then

            TextBoxX14.ReadOnly = False
            TextBoxX15.ReadOnly = False
            TextBoxX16.ReadOnly = False
            TextBoxX20.ReadOnly = False
            TextBoxX25.ReadOnly = False


            TextBoxX14.Text = ""
            TextBoxX15.Text = ""
            TextBoxX16.Text = ""
            TextBoxX20.Text = ""
            TextBoxX25.Text = ""

        ElseIf ComboBox1.Text = "OR" Then
            TextBoxX17.ReadOnly = False
            TextBoxX18.ReadOnly = False
            TextBoxX19.ReadOnly = False
            TextBoxX26.ReadOnly = False
            TextBoxX27.ReadOnly = False

            TextBoxX17.Text = ""
            TextBoxX18.Text = ""
            TextBoxX19.Text = ""
            TextBoxX26.Text = ""
            TextBoxX27.Text = ""

        ElseIf ComboBox1.Text = "HD" Or ComboBox1.Text = "MEC" Then
            TextBoxX21.ReadOnly = False
            TextBoxX28.ReadOnly = False
            TextBoxX45.ReadOnly = False
            TextBoxX46.ReadOnly = False
            TextBoxX47.ReadOnly = False
            TextBoxX48.ReadOnly = False
            TextBoxX49.ReadOnly = False
            TextBoxX50.ReadOnly = False
            TextBoxX51.ReadOnly = False



            TextBoxX21.Text = ""
            TextBoxX28.Text = ""
            TextBoxX45.Text = ""
            TextBoxX46.Text = ""
            TextBoxX47.Text = ""
            TextBoxX48.Text = ""
            TextBoxX49.Text = ""
            TextBoxX50.Text = ""
            TextBoxX51.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBoxX8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX40.KeyDown, TextBoxX10.KeyDown, TextBoxX11.KeyDown, TextBoxX12.KeyDown, TextBoxX39.KeyDown

        If Asc(e.KeyCode) <> 13 AndAlso Asc(e.KeyCode) <> 8 _
       AndAlso Not IsNumeric(e.KeyCode) Then

            e.Handled = True
        End If
        callICU()
    End Sub

    Private Sub TextBoxX15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX15.KeyDown, TextBoxX16.KeyDown, TextBoxX20.KeyDown, TextBoxX25.KeyDown

        If Asc(e.KeyCode) <> 13 AndAlso Asc(e.KeyCode) <> 8 _
       AndAlso Not IsNumeric(e.KeyCode) Then

            e.Handled = True
        End If
        callLR()
    End Sub

    Private Sub TextBoxX18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX18.KeyDown, TextBoxX19.KeyDown, TextBoxX26.KeyDown, TextBoxX27.KeyDown


        If Asc(e.KeyCode) <> 13 AndAlso Asc(e.KeyCode) <> 8 _
   AndAlso Not IsNumeric(e.KeyCode) Then

            e.Handled = True
        End If
        callOR()

    End Sub

    Private Sub TextBoxX52_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX52.KeyDown

        If e.KeyCode = Keys.Enter Then

            Label62.Text = ""
            check = "0"
            MyODBCConnection.Close()
            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox("โปรดใช้เครื่องระบบ ในการกรอก Req")
            End Try

            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT TUSUSRCOD,TUSUSRNAM FROM TABUSRV5PF WHERE TUSUSRCOD = '" & TextBoxX52.Text.ToUpper & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    Label62.Text = dr.GetString(1).Trim
                    check = "1"
                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End If


    End Sub
End Class