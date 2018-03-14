Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmdept_cenhd
    Dim mysql As MySqlConnection = frmlogin_dept.mysql
    Dim mysql_ryh As MySqlConnection
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim inbtIndex As Integer
    Dim cmd_result As Integer
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim check As String = "0"

    Dim checksu As String = "0"
    Dim idmain As String = ""
    Dim idsubmain As String = ""
    Private Sub frmdept_cenhd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcen()
    End Sub
    Public Sub loadcen()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM census_main join census_hd  on census_main.idcensus_main  = census_hd.hdmain   where cendep = '" & Trim(frmlogin_dept.dept) & "' ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridViewX1.Rows.Clear()


            While (mySqlReader.Read())


                DataGridViewX1.Rows.Add({mySqlReader("cendate"), mySqlReader("cenfate"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("nameuser"), mySqlReader("idcensus_main")})
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub
    Public Sub selectdb()
        Dim key As String
        Dim count As Integer

        count = 0
        checksu = "1"
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM census_main join census_hd  on census_main.idcensus_main  = census_hd.hdmain where idcensus_main ='" & DataGridViewX1.Rows(inbtIndex).Cells(7).Value & "';"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                idmain = mySqlReader("idcensus_main")
                idsubmain = mySqlReader("idcensus_hd")
                DateTimeInput1.Text = mySqlReader("cendate").ToString + " 00:00"
                ComboBox2.Text = mySqlReader("cenfate")
                TextBoxX1.Text = mySqlReader("cenrn")
                TextBoxX2.Text = mySqlReader("cenpn")
                TextBoxX3.Text = mySqlReader("cenna")
                TextBoxX4.Text = mySqlReader("cenwc")
                If mySqlReader("check1") = "1" Then
                    RadioButton1.Checked = True

                Else
                    RadioButton2.Checked = True

                End If
                TextBoxX5.Text = mySqlReader("checktxt")
                TextBoxX6.Text = mySqlReader("checktxt1")

                TextBoxX21.Text = mySqlReader("hdsum")
                TextBoxX28.Text = mySqlReader("hdmec")
                TextBoxX45.Text = mySqlReader("hdegd")
                TextBoxX46.Text = mySqlReader("hdcolono")
                TextBoxX47.Text = mySqlReader("hdercp")
                TextBoxX7.Text = mySqlReader("hdhemo")
                TextBoxX49.Text = mySqlReader("hdpipe")
                TextBoxX50.Text = mySqlReader("hdadmit")
                TextBoxX51.Text = mySqlReader("hdoperative")

                'TextBoxX24.Text = mySqlReader("opdsum")
                'TextBoxX31.Text = mySqlReader("opdgen")
                'TextBoxX35.Text = mySqlReader("opddek")
                'TextBoxX36.Text = mySqlReader("opdcheck")
                'TextBoxX37.Text = mySqlReader("opdadmit")
                'TextBoxX41.Text = mySqlReader("opddekhud")
                'ComboBox2.Text = mySqlReader("cenfate")
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub
    Public Sub cleartxt()
        idsubmain = ""
        idmain = ""
        checksu = "0"
        check = "0"

        TextBoxX1.Text = ""
        TextBoxX3.Text = ""
        TextBoxX4.Text = ""
        TextBoxX5.Text = ""
        TextBoxX6.Text = ""
        TextBoxX21.Text = ""
        TextBoxX28.Text = ""
        TextBoxX45.Text = ""
        TextBoxX46.Text = ""
        TextBoxX47.Text = ""
        TextBoxX49.Text = ""
        TextBoxX50.Text = ""
        TextBoxX51.Text = ""
        TextBoxX52.Text = ""
        TextBoxX7.Text = ""
        Label62.Text = ""
        TextBoxX2.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub TextBoxX52_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX52.KeyDown
        If e.KeyCode = Keys.Enter Then

            Label62.Text = ""
            check = "0"
            MyODBCConnection.Close()
            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox("�ô������ͧ�к� 㹡�á�͡ Req")
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

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        inbtIndex = e.RowIndex
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        If check = "1" Then

            If ComboBox2.Text.Length > 0 Then
                Dim respone As Object
                Dim size As String
                Dim condition As String
                Dim deatch1 As String = "0"
                Dim refer As String = "0"

                Dim commandText2 As String = ""
                mysql.Close()
                respone = MsgBox("�׹�ѹ�����Ŷ١��ͧ", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
                If respone = 1 Then

                    If checksu = "0" Then

                        mysql.Close()

                        If mysql.State = ConnectionState.Closed Then
                            mysql.Open()
                        End If



                        Try
                            mySqlCommand.Parameters.Clear()
                            mySqlCommand.CommandText = "INSERT INTO census_main (cendep,cendate,cenfate,cenrn,cenpn,cenna,cenwc,check1,checktxt,checktxt1,userrequest,nameuser) VALUES (@cendep,@cendate,@cenfate,@cenrn,@cenpn,@cenna,@cenwc,@check1,@checktxt,@checktxt1,@userrequest,@nameuser); SELECT LAST_INSERT_ID()"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql

                            mySqlCommand.Parameters.AddWithValue("@cendep", frmlogin_dept.dept)
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

                            If mysql.State = ConnectionState.Closed Then
                                mysql.Open()
                            End If


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
                            mySqlCommand.Parameters.AddWithValue("@hdhemo", TextBoxX7.Text)
                            mySqlCommand.Parameters.AddWithValue("@hdpipe", TextBoxX49.Text)
                            mySqlCommand.Parameters.AddWithValue("@hdadmit", TextBoxX50.Text)
                            mySqlCommand.Parameters.AddWithValue("@hdoperative", TextBoxX51.Text)


                            mySqlCommand.ExecuteNonQuery()
                            mysql.Close()


                        Catch ex As Exception
                            MsgBox(ex.ToString)
                            mysql.Close()
                            cleartxt()

                        End Try
                    ElseIf checksu = "1" Then
                        Dim check1 As String = "0"

                        mysql.Close()

                        If mysql.State = ConnectionState.Closed Then
                            mysql.Open()
                        End If

                        If RadioButton1.Checked = True Then
                            check1 = "1"
                        ElseIf RadioButton2.Checked = True Then
                            check1 = "0"
                        End If
                        commandText2 = "UPDATE    census_main SET cendate ='" & DateTimeInput1.Value.ToString("dd-MM-yyyy") & "' , cenfate ='" & ComboBox2.Text & "',cenrn ='" & TextBoxX1.Text & "',cenpn ='" & TextBoxX2.Text & "', cenna ='" & TextBoxX3.Text & "' ,cenwc ='" & TextBoxX4.Text & "', check1 ='" & check1 & "',checktxt='" & TextBoxX5.Text & "',checktxt1='" & TextBoxX6.Text & "', userrequest ='" & TextBoxX52.Text & "',nameuser ='" & Label62.Text & "' WHERE idcensus_main = '" & idmain & "'; "

                        mySqlCommand.CommandText = commandText2

                        mySqlCommand.Connection = mysql
                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()

                        mysql.Close()

                        If mysql.State = ConnectionState.Closed Then
                            mysql.Open()
                        End If
                        commandText2 = "UPDATE census_hd SET hdsum = '" & TextBoxX21.Text & "',hdadmit = '" & TextBoxX50.Text & "',hdmec ='" & TextBoxX28.Text & "',hdegd = '" & TextBoxX45.Text & "',hdcolono ='" & TextBoxX46.Text & "',hdercp = '" & TextBoxX47.Text & "' , hdpipe ='" & TextBoxX49.Text & "',hdoperative ='" & TextBoxX51.Text & "'  WHERE idcensus_hd = '" & idsubmain & "'; "


                        mySqlCommand.CommandText = commandText2

                        mySqlCommand.Connection = mysql
                        mySqlCommand.ExecuteNonQuery()
                        mysql.Close()


                        cleartxt()

                    End If
                End If
            End If

        Else

            MsgBox("��سҡ�͡ User Request")
        End If

        loadcen()


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        selectdb()
    End Sub
End Class