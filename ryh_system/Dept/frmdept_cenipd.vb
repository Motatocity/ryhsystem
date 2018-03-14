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
Public Class frmdept_cenipd
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
    Private Sub frmdept_cenipd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcen()

    End Sub
    Public Sub selectdb()
        Dim key As String
        Dim count As Integer

        count = 0
        checksu = "1"
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM census_main join census_ipd  on census_main.idcensus_main  = census_ipd.ipdmain where idcensus_main ='" & DataGridViewX1.Rows(inbtIndex).Cells(7).Value & "';"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                idmain = mySqlReader("idcensus_main")
                idsubmain = mySqlReader("idcensus_ipd")
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

                TextBoxX7.Text = mySqlReader("ipdsum")
                TextBoxX8.Text = mySqlReader("ipdadmit")
                TextBoxX9.Text = mySqlReader("ipddc")
                TextBoxX40.Text = mySqlReader("ipdicu")
                TextBoxX10.Text = mySqlReader("ipdci")
                TextBoxX11.Text = mySqlReader("ipdsi")
                TextBoxX12.Text = mySqlReader("ipdmi")
                TextBoxX39.Text = mySqlReader("ipdcl")
                TextBoxX44.Text = mySqlReader("ipdroom")

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
    Public Sub loadcen()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM census_main join census_ipd  on census_main.idcensus_main  = census_ipd.ipdmain   where cendep = '" & frmlogin_dept.dept & "' ;"
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
  
        TextBoxX52.Text = ""
        Label62.Text = ""

        TextBoxX2.Text = ""
        ComboBox2.Text = ""
        TextBoxX7.Text = ""
        TextBoxX8.Text = ""
        TextBoxX9.Text = ""
        TextBoxX40.Text = ""
        TextBoxX10.Text = ""
        TextBoxX11.Text = ""
        TextBoxX12.Text = ""
        TextBoxX39.Text = ""
        TextBoxX44.Text = ""



    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        selectdb()

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
                        commandText2 = "UPDATE census_ipd SET ipdsum = '" & TextBoxX7.Text & "',ipdadmit = '" & TextBoxX8.Text & "',ipddc ='" & TextBoxX9.Text & "',ipdsi = '" & TextBoxX11.Text & "',ipdmi ='" & TextBoxX12.Text & "',ipdcl = '" & TextBoxX39.Text & "' , ipdroom ='" & TextBoxX44.Text & "',ipdicu ='" & TextBoxX40.Text & "' , ipdci ='" & TextBoxX10.Text & "' WHERE idcensus_ipd = '" & idsubmain & "'; "


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
End Class