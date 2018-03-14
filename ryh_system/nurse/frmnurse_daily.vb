Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmnurse_daily
    Dim sql As MySqlConnection = frmmain_nurse.mysqlconection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader

    Dim timedate As Integer = 15

    Dim subdate1() As String
    Dim subdate2() As String
    Dim date1 As Date
    Dim date2 As Date
    Dim diff1 As TimeSpan
    Dim valuedate As String
    Dim cenna As Integer
    Dim cenpn As Integer
    Dim cenrn As Integer
    Dim cenwc As Integer
    Dim sumtotal_scope As Integer
    Dim sumtotal_minor As Integer
    Dim sumtotal_major As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        calllr()
        callor()
        caller()
        callopd()
        callhd()

        callipd()
        calletc()

    End Sub
    Public Sub calletc()

        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select * from census_main  where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView7.Rows.Clear()


            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                If Trim(mySqlReader("checktxt")) <> "" And Trim(mySqlReader("checktxt1") <> "") Then
                    DataGridView7.Rows.Add({mySqlReader("cenfate"), mySqlReader("cendep"), mySqlReader("checktxt"), mySqlReader("checktxt1")})

                End If


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Public Sub callor()
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select *  from census_main  join  census_or on census_main.idcensus_main = census_or.ormain where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView3.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView3.Rows.Add({mySqlReader("cenfate"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("ormajor"), mySqlReader("orminor"), mySqlReader("orsmall"), mySqlReader("orscope")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


    End Sub
    Public Sub caller()

        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select * from census_main  join  census_er on census_main.idcensus_main = census_er.ermain where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView2.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView2.Rows.Add({mySqlReader("cenfate"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("eremergency"), mySqlReader("erurgent"), mySqlReader("ernonurgent"), mySqlReader("ernonacute"), mySqlReader("erambuin"), mySqlReader("erambuout")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub
    Public Sub callopd()

        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select * from census_main  join  census_opd on census_main.idcensus_main = census_opd.opdmain where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView4.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView4.Rows.Add({mySqlReader("cenfate"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("opdgen"), mySqlReader("opdcheck"), mySqlReader("opdadmit"), mySqlReader("opddek"), mySqlReader("opddekhud")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub
    Public Sub calllr()
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select * from census_main  join  census_lr on census_main.idcensus_main = census_lr.lrmain where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView1.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView1.Rows.Add({mySqlReader("cenfate"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("lrwbirth"), mySqlReader("lrbirth"), mySqlReader("lrdiag"), mySqlReader("lrns"), mySqlReader("lroperative"), mySqlReader("lrafterbirth")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub
    Public Sub callipd()
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select * from census_main  join  census_ipd on census_main.idcensus_main = census_ipd.ipdmain where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView5.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView5.Rows.Add({mySqlReader("cenfate"), mySqlReader("cendep"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("ipdadmit"), mySqlReader("ipddc"), mySqlReader("ipdicu"), mySqlReader("ipdci"), mySqlReader("ipdsi"), mySqlReader("ipdmi"), mySqlReader("ipdcl"), mySqlReader("ipdroom")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub
    Public Sub callhd()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "Select * from census_main  join  census_hd on census_main.idcensus_main = census_hd.hdmain where  cendate ='" & MaskedTextBoxAdv2.Text & "';"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = sql
        Try
            DataGridView6.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView6.Rows.Add({mySqlReader("cenfate"), mySqlReader("cendep"), mySqlReader("cenrn"), mySqlReader("cenpn"), mySqlReader("cenna"), mySqlReader("cenwc"), mySqlReader("hdmec"), mySqlReader("hdegd"), mySqlReader("hdcolono"), mySqlReader("hdercp"), mySqlReader("hdpipe"), mySqlReader("hdadmit"), mySqlReader("hdoperative"), mySqlReader("hdhemo")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub frmnurse_daily_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
    End Sub



End Class