Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Threading
Imports OfficeOpenXml
Imports Microsoft.Office
Imports Microsoft.Office.Excel
Imports Microsoft.Office.Excel.Interop

Public Class frmmain_thungsong
    Public Shared dbname As String
    Public Shared user As String
    Public Shared password As String
    Public Shared ip As String
    Public Shared mysql As MySqlConnection = New MySqlConnection
    Public Shared mysql1 As MySqlConnection = New MySqlConnection
    Public Shared mysql2 As MySqlConnection = New MySqlConnection
    Public Shared idkey As String
    Public Shared text1 As String

    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader

    Dim inbtIndex As Integer
    Public Shared checkTHUNGANDRYH As String = "0"
    Private Sub frmmain_thungsong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbname = "rajyindee_db"
        user = "june"
        password = "software"
        ip = "ryh1"


        'dbname = "rajyindee_db"
        'user = "myfriends"
        'password = "mftpxFXUpt206854"
        'ip = "192.168.10.222"

        'dbname = "rajyindee_db"
        'user = "root"
        'password = ""
        'ip = "127.0.0.1"

        mysql.Close()
        mysql1.Close()
        mysql2.Close()

        mysql.ConnectionString = "server=" + ip + ";Port=3306;user id=" + user + ";password=" + password + ";database=" + dbname + ";Character Set =utf8"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)


        End Try

        'mysql1.ConnectionString = "server=" + ip + ";user id=" + user + ";password=" + password + ";database=" + dbname + ";Character Set =utf8;"
        'Try
        '    mysql1.Open()
        '    '    MsgBox("CONNECTED TO DATABASE")
        'Catch ex As Exception
        '    MsgBox("Can't Connect to database" + ex.Message)


        'End Try



        'mysql2.ConnectionString = "server=" + ip + ";user id=" + user + ";password=" + password + ";database=rajyindee_db;Character Set =utf8;"
        'Try
        '    mysql2.Open()
        '    '    MsgBox("CONNECTED TO DATABASE")
        'Catch ex As Exception
        '    MsgBox("Can't Connect to database" + ex.Message)


        'End Try

        searchDB()
    End Sub

    Public Sub searchDB()
        mysql.Close()
        Try
            mysql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

        End Try


        If checkTHUNGANDRYH = "0" Then
            Dim count As Integer = 1
            mySqlCommand.CommandText = "SELECT * FROM thungsongdb where thungsongdb.name2 like '%" & TextBoxX1.Text & "%' or thungsongdb.idcardname like '%" & TextBoxX1.Text & "%';"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                DataGridViewX1.Rows.Clear()
                While (mySqlReader.Read())

                    DataGridViewX1.Rows.Add({mySqlReader("idthungsongDB"), mySqlReader("name2"), mySqlReader("idcardname"), mySqlReader("address"), mySqlReader("tell"), mySqlReader("price")})

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()
        ElseIf checkTHUNGANDRYH = "1" Then
            Dim count As Integer = 1
            mySqlCommand.CommandText = "SELECT idryh_main,name   , address,tell,IDCARD FROM ryh_main where ryh_main.name like '%" & TextBoxX1.Text & "%' GROUP BY idryh_main ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                DataGridViewX1.Rows.Clear()
                While (mySqlReader.Read())

                    DataGridViewX1.Rows.Add({mySqlReader("idryh_main"), mySqlReader("name"), mySqlReader("IDCARD"), mySqlReader("address"), mySqlReader("tell")})

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()
        End If





    End Sub

    Public Sub searchDetail()

        mysql.Close()
        Try
            mysql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

        End Try

        Dim stat As String


        Dim count As Integer = 1
        Dim sql As String
     
        If checkTHUNGANDRYH = "0" Then
            'sql = "SELECT thungsong_round1 ,thungsong_round.idthungsong_round ,thungsong_rundsum , thungsong_rundshare , thungsong_sum ,thungsong_sumshare  ,thungsong_roundbill , thungsong_rundstat FROM (SELECT SUM(thungsong_sum) AS thungsong_sum  ,SUM(thungsong_sumshare)  as thungsong_sumshare  , idthungsong_round FROM rajyindee_db.thungsong_rec GROUP by idthungsong_round  ) AS A  RIGHT JOIN  thungsong_round ON A.idthungsong_round = thungsong_round.idthungsong_round   where thungsong_roundbill = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "' order by idthungsong_round ASC ; ;"

            sql = "SELECT thungsong_round1 ,thungsong_round.idthungsong_round ,thungsong_rundsum , thungsong_rundshare , thungsong_sum ,thungsong_sumshare  ,thungsong_roundbill , thungsong_rundstat,name2 FROM (SELECT SUM(thungsong_sum) AS thungsong_sum  ,SUM(thungsong_sumshare)  as thungsong_sumshare  , idthungsong_round FROM rajyindee_db.thungsong_rec GROUP by idthungsong_round) AS A RIGHT JOIN rajyindee_db.thungsong_round ON A.idthungsong_round = thungsong_round.idthungsong_round LEFT JOIN rajyindee_db.share_history ON thungsong_round.idthungsong_round = share_history.bill LEFT JOIN rajyindee_db.thungsongdb ON share_history.person_sell = thungsongdb.idthungsongDB where thungsong_roundbill = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "' order by thungsong_round.idthungsong_round ASC;"

            ' mySqlCommand.CommandText = "SELECT * FROM thungsong_round where thungsong_roundbill = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "' ; "
            mySqlCommand.CommandText = sql
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                DataGridViewX2.Rows.Clear()
                While (mySqlReader.Read())
                    If mySqlReader("thungsong_rundstat") = "0" Then
                        stat = "¬—ß‰¡Ë‰¥È™”√–‡ß‘π"
                    Else
                        stat = "™”√–‡ß‘π‡√’¬∫√ÈÕ¬"
                    End If

                    DataGridViewX2.Rows.Add({mySqlReader("thungsong_round1"), mySqlReader("thungsong_rundshare"), mySqlReader("thungsong_rundsum"), mySqlReader("thungsong_sum"), stat, mySqlReader("thungsong_rundstat"), mySqlReader("name2")})


                    '  DataGridViewX2.Rows.Add({mySqlReader("thungsong_round1"), mySqlReader("thungsong_rundsum"), mySqlReader("thungsong_rundshare"), stat, mySqlReader("thungsong_rundstat")})

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        ElseIf checkTHUNGANDRYH = "1" Then

            mySqlCommand.CommandText = "SELECT ryh_sumdetail.count as count  , ryh_sumdetail.sum as sum ,checkryh,x.name FROM ryh_sumdetail JOIN ryh_main  ON ryh_main.idryh_main  = ryh_sumdetail.idryh_main LEFT JOIN rajyindee_db.share_history ON ryh_sumdetail.idryh_sumdetail = share_history.bill LEFT JOIN rajyindee_db.ryh_main x ON x.idryh_main = share_history.person_sell  where ryh_main.idryh_main = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "' ORDER BY idryh_sumdetail; "
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                DataGridViewX2.Rows.Clear()
                While (mySqlReader.Read())
                    If mySqlReader("checkryh") = "0" Then
                        stat = "¬—ß‰¡Ë‰¥È™”√–‡ß‘π"
                    Else
                        stat = "™”√–‡ß‘π‡√’¬∫√ÈÕ¬"
                    End If
                    DataGridViewX2.Rows.Add({mySqlReader("count"), mySqlReader("sum"), mySqlReader("sum") * 1.5, " ", stat, mySqlReader("checkryh"), mySqlReader("name")})

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        End If
    

        For i As Integer = 0 To DataGridViewX2.Rows.Count - 1

            If DataGridViewX2.Rows(i).Cells(5).Value = 1 Then
                DataGridViewX2.Rows(i).Cells(3).Style.BackColor = Color.DeepSkyBlue
            ElseIf DataGridViewX2.Rows(i).Cells(5).Value = 0 Then
                DataGridViewX2.Rows(i).Cells(3).Style.BackColor = Color.DarkOrange
            End If



        Next

    End Sub



    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        searchDB()
    End Sub

    Private Sub TextBoxX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then

            searchDB()
        End If
    End Sub

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        inbtIndex = e.RowIndex
        '    TextBoxX2



        Try
            txtname.Text = DataGridViewX1.Rows(inbtIndex).Cells(1).Value
            searchDetail()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Dim nextform As New frmrpt_summaryall
        nextform.Show()
    End Sub

    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÕÕ°„∫‡ √®™”√–‡ßπToolStripMenuItem.Click

        idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value

        Dim nextform As frmcheck_bill = New frmcheck_bill
        nextform.Show()

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim nextform As frmrpt_byalone = New frmrpt_byalone
        nextform.Show()
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim nextform As frmrpt_round = New frmrpt_round
        nextform.Show()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click

    End Sub

    Private Sub ·°‰¢¢Õ¡≈™ÕToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ·°‰¢¢Õ¡≈™ÕToolStripMenuItem.Click

        idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value
        Dim nextform As frmedit_user = New frmedit_user
        nextform.Show()
    End Sub

    Private Sub ‡æ¡¢Õ¡≈ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ‡æ¡¢Õ¡≈ToolStripMenuItem.Click
        Dim nextform As frmadd_user = New frmadd_user
        nextform.Show()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        text1 = "(„∫‡ √Á®√—∫‡ß‘π§Ë“®ÕßÀÿÈπ)"
        Dim nextform As frmrpt_env = New frmrpt_env
        nextform.Show()
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        text1 = ""
        Dim nextform As frmrpt_env = New frmrpt_env
        nextform.Show()
    End Sub

    Private Sub ButtonItem5_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonItem5.Click
        Dim nextform As frmsend_msg = New frmsend_msg
        nextform.Show()
    End Sub

    Private Sub ≈∫¢Õ¡≈ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ≈∫¢Õ¡≈ToolStripMenuItem.Click
        deleteData()



    End Sub

    Public Sub deleteData()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim respone As Object

        respone = MsgBox("¬◊π¬—π¢ÈÕ¡Ÿ≈∂Ÿ°µÈÕß", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try

                mySqlCommand.CommandText = "DELETE FROM thungsongdb where idthungsongDB = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "';"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql

                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
                searchDB()

            Catch ex As Exception

                MsgBox(ex.ToString)
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Dim frmrpt As frmrpt_result = New frmrpt_result
        frmrpt.Show()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Dim frmrpt As Form2 = New Form2
        frmrpt.Show()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Dim frmrpt As frmrpt_enva4 = New frmrpt_enva4
        frmrpt.Show()
    End Sub

    Private Sub ReprintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintToolStripMenuItem.Click

        idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value

        Dim nextform As frmreprint = New frmreprint
        nextform.Show()
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click

        FolderBrowserDialog1.Description = "Pick Folder to store Excecl files"
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.SelectedPath = "C:\"
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim t = New Thread(New ThreadStart(AddressOf excelReport))
                t.Start()
                CircularProgress1.IsRunning = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub excelReport()


        Dim pathExcel As String
        Dim count As Integer = 7
        Dim rows As Integer = 5

        pathExcel = FolderBrowserDialog1.SelectedPath
        Dim tmpl As FileInfo = New FileInfo(pathExcel + "\THUNGSONG" + Date.Now.ToString("dd-MM-yyyy") + ".xlsx")
        Dim package As ExcelPackage = New ExcelPackage(tmpl)
        With package
            Dim wrksheet As ExcelWorksheet
            Dim wrksheet1 As ExcelWorksheet
            Dim wrksheet2 As ExcelWorksheet
            wrksheet = package.Workbook.Worksheets.Add("THUNGSONG")
               wrksheet.Column(1).Width = 40
            wrksheet.Column(2).Width = 20
            wrksheet.Column(3).Width = 15
            wrksheet.Column(4).Width = 20
            For i As Integer = 5 To 12
                wrksheet.Column(i).Width = 13
            Next
            wrksheet.Cells(rows, 1).Value = "™◊ËÕºŸÈ∂◊ÕÀÿÈπ"
            wrksheet.Cells(rows, 2).Value = "‡≈¢∑’Ë∫—µ√ª√–™“™π"
            wrksheet.Cells(rows, 3).Value = "®”π«πÀÿÈπ"
            wrksheet.Cells(rows, 4).Value = "®”π«π‡ß‘π√«¡"
            wrksheet.Cells(rows, 5).Value = "®”π«π‡ß‘π"
            wrksheet.Cells(rows, 6).Value = "®”π«π∑’Ë™”√–"
            wrksheet.Cells(rows, 7).Value = "®”π«π‡ß‘π"
            wrksheet.Cells(rows, 8).Value = "®”π«π∑’Ë™”√–"
            wrksheet.Cells(rows, 9).Value = "®”π«π‡ß‘π"
            wrksheet.Cells(rows, 10).Value = "®”π«π∑’Ë™”√–"
            wrksheet.Cells(rows, 11).Value = "®”π«π‡ß‘π"
            wrksheet.Cells(rows, 12).Value = "®”π«π∑’Ë™”√–"
            wrksheet.Cells(rows - 1, 5).Value = "ß«¥∑’Ë 1 (10%)"
            wrksheet.Cells(rows - 1, 5, rows - 1, 5 + 1).Merge = True
            wrksheet.Cells(rows - 1, 5, rows - 1, 5 + 1).Style.Font.Bold = True
            wrksheet.Cells(rows - 1, 5, rows - 1, 5 + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center

            wrksheet.Cells(rows - 1, 7).Value = "ß«¥∑’Ë 2 (30%)"
            wrksheet.Cells(rows - 1, 7, rows - 1, 7 + 1).Merge = True
            wrksheet.Cells(rows - 1, 7, rows - 1, 7 + 1).Style.Font.Bold = True
            wrksheet.Cells(rows - 1, 7, rows - 1, 7 + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center

            wrksheet.Cells(rows - 1, 9).Value = "ß«¥∑’Ë 3 (30%)"
            wrksheet.Cells(rows - 1, 9, rows - 1, 9 + 1).Merge = True
            wrksheet.Cells(rows - 1, 9, rows, 9 + 1).Style.Font.Bold = True
            wrksheet.Cells(rows - 1, 9, rows - 1, 9 + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center

            wrksheet.Cells(rows - 1, 11).Value = "ß«¥∑’Ë 4 (30%)"
            wrksheet.Cells(rows - 1, 11, rows - 1, 11 + 1).Merge = True
            wrksheet.Cells(rows - 1, 11, rows - 1, 11 + 1).Style.Font.Bold = True
            wrksheet.Cells(rows - 1, 11, rows - 1, 11 + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center

            wrksheet.Cells("A5:L5").AutoFilter = True

            Dim sql As String
            sql = "Select  name2,idcardname,price,share, SUM(ROUND_1) AS ROUND_1,SUM(ROUND1) AS ROUND1,SUM(ROUND_2) AS ROUND_2,SUM(ROUND2) AS ROUND2 ,  "
            sql += "SUM(ROUND_3) AS ROUND_3,SUM(ROUND3) AS ROUND3,SUM(ROUND_4) AS ROUND_4 ,SUM(ROUND4) AS ROUND4 FROM   "
            sql += " ( SELECT name2,idcardname,price,rajyindee_db.thungsongdb.share,CASE WHEN (thungsong_round1 = '1') THEN thungsong_rundsum Else 0 END as ROUND_1    "
            sql += "    ,CASE WHEN (thungsong_rundstat = '1' AND   thungsong_round1 = '1') THEN thungsong_rundsum1 Else 0 END as ROUND1  ,  "
            sql += "  CASE WHEN (thungsong_round1 = '2') THEN thungsong_rundsum Else 0 END as ROUND_2  ,  "
            sql += "  CASE WHEN (thungsong_rundstat = '1' AND   thungsong_round1 = '2') THEN thungsong_rundsum1 Else 0 END as ROUND2  , "
            sql += "  CASE WHEN (thungsong_round1 = '3') THEN thungsong_rundsum Else 0 END as ROUND_3 , "
            sql += "  CASE WHEN (thungsong_rundstat = '1' AND   thungsong_round1 = '3') THEN thungsong_rundsum1 Else 0 END as ROUND3  ,  "
            sql += "  CASE WHEN (thungsong_round1 = '4') THEN thungsong_rundsum Else 0 END as ROUND_4 ,  "
            sql += "  CASE WHEN (thungsong_rundstat = '1' AND   thungsong_round1 = '4') THEN thungsong_rundsum1 Else 0 END as ROUND4    "
            sql += " FROM rajyindee_db.thungsongdb join (SELECT  thungsong_roundbill , thungsong_round.idthungsong_round , thungsong_round.thungsong_rundstat , thungsong_round.thungsong_round1 , thungsong_round.thungsong_rundsum   , thungsong_sum1 as thungsong_rundsum1  FROM rajyindee_db.thungsong_round LEFT JOIN  ( SELECT idthungsong_round , SUM(thungsong_sum) as thungsong_sum1  ,sum(thungsong_sumshare) FROM rajyindee_db.thungsong_rec GROUP BY idthungsong_round ) AS A  ON   A.idthungsong_round  = thungsong_round.idthungsong_round ) AS C on idthungsongDB = C.thungsong_roundbill ) AS B  GROUP BY B.name2; "

            Dim con As ConnecDBRYH = ConnecDBRYH.NewConnection
            Dim dt As DataTable
            dt = con.GetTable(sql)
            For a As Integer = 0 To dt.Rows.Count - 1
                rows += 1
                wrksheet.Cells(rows, 1).Value = dt.Rows(a)("name2")
                wrksheet.Cells(rows, 2).Value = dt.Rows(a)("idcardname")
                wrksheet.Cells(rows, 3).Value = dt.Rows(a)("price")
                wrksheet.Cells(rows, 4).Value = dt.Rows(a)("share")
                wrksheet.Cells(rows, 5).Value = dt.Rows(a)("ROUND_1")
                wrksheet.Cells(rows, 6).Value = dt.Rows(a)("ROUND1")
                wrksheet.Cells(rows, 7).Value = dt.Rows(a)("ROUND_2")
                wrksheet.Cells(rows, 8).Value = dt.Rows(a)("ROUND2")
                wrksheet.Cells(rows, 9).Value = dt.Rows(a)("ROUND_3")
                wrksheet.Cells(rows, 10).Value = dt.Rows(a)("ROUND3")
                wrksheet.Cells(rows, 11).Value = dt.Rows(a)("ROUND_4")
                wrksheet.Cells(rows, 12).Value = dt.Rows(a)("ROUND4")
            Next
            wrksheet.Cells(6, 4, dt.Rows.Count + 6, 12).Style.Numberformat.Format = "#,##0"

            wrksheet.Cells(rows + 2, 3).Value = "®”π«π‡ß‘π∑—ÈßÀ¡¥"
            wrksheet.Cells(rows + 2, 4).Formula = "=Sum(" + wrksheet.Cells(6, 4).Address + ":" + wrksheet.Cells(rows, 4).Address + ")"


            wrksheet.Cells(rows + 4, 4).Value = "ß«¥∑’Ë 1"
            wrksheet.Cells(rows + 5, 4).Formula = "=Sum(" + wrksheet.Cells(6, 5).Address + ":" + wrksheet.Cells(rows, 5).Address + ")"
            wrksheet.Cells(rows + 6, 4).Formula = "=Sum(" + wrksheet.Cells(6, 6).Address + ":" + wrksheet.Cells(rows, 6).Address + ")"


            wrksheet.Cells(rows + 4, 5).Value = "ß«¥∑’Ë 2 "
            wrksheet.Cells(rows + 5, 5).Formula = "=Sum(" + wrksheet.Cells(6, 7).Address + ":" + wrksheet.Cells(rows, 7).Address + ")"
            wrksheet.Cells(rows + 6, 5).Formula = "=Sum(" + wrksheet.Cells(6, 8).Address + ":" + wrksheet.Cells(rows, 8).Address + ")"

            wrksheet.Cells(rows + 4, 6).Value = "ß«¥∑’Ë 3"
            wrksheet.Cells(rows + 5, 6).Formula = "=Sum(" + wrksheet.Cells(6, 9).Address + ":" + wrksheet.Cells(rows, 9).Address + ")"
            wrksheet.Cells(rows + 6, 6).Formula = "=Sum(" + wrksheet.Cells(6, 10).Address + ":" + wrksheet.Cells(rows, 10).Address + ")"

            wrksheet.Cells(rows + 4, 7).Value = "ß«¥∑’Ë 4"
            wrksheet.Cells(rows + 5, 7).Formula = "=Sum(" + wrksheet.Cells(6, 11).Address + ":" + wrksheet.Cells(rows, 11).Address + ")"
            wrksheet.Cells(rows + 6, 7).Formula = "=Sum(" + wrksheet.Cells(6, 12).Address + ":" + wrksheet.Cells(rows, 12).Address + ")"


            wrksheet.Cells(rows + 5, 3).Value = "∑—ÈßÀ¡¥"
            wrksheet.Cells(rows + 6, 3).Value = "®”π«π∑’Ë™”√–"





            package.Save()

        End With
        package.Dispose()

        MsgBox("‡Õ° “√‡ √Á® ¡∫Ÿ√≥Ï")

    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        Dim nextform As frmrpt_ryh = New frmrpt_ryh
        nextform.Show()
    End Sub

    Private Sub ButtonItem12_Click(sender As Object, e As EventArgs) Handles ButtonItem12.Click
      
    End Sub

    Private Sub ButtonItem14_Click(sender As Object, e As EventArgs) Handles ButtonItem14.Click
        'Dim nextform As frmsetup_shareryh = New frmsetup_shareryh
        'nextform.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "RAJYINDEE" Then
            checkTHUNGANDRYH = "1"
        ElseIf ComboBox1.Text = "THUNGSONG" Then
            checkTHUNGANDRYH = "0"
        End If
        searchDB()
    End Sub

    Private Sub ButtonItem15_Click(sender As Object, e As EventArgs) Handles ButtonItem15.Click
        Dim nextform As rpt_envryh = New rpt_envryh
        nextform.Show()
    End Sub

    Private Sub CircularProgress1_ValueChanged(sender As Object, e As EventArgs) Handles CircularProgress1.ValueChanged

    End Sub

    Private Sub ButtonItem17_Click(sender As Object, e As EventArgs) Handles ButtonItem17.Click
        Dim nextform As frmrpt_boj5 = New frmrpt_boj5
        nextform.Show()
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        Dim nextform As New frmrpt_monthlyreport
        nextform.Show()
    End Sub

    Private Sub ButtonItem16_Click(sender As Object, e As EventArgs) Handles ButtonItem16.Click
        Dim nextform As frmregister = New frmregister
        nextform.Show()
    End Sub

    Private Sub ButtonItem18_Click(sender As Object, e As EventArgs) Handles ButtonItem18.Click
        Dim nextform As frmeditdetail_bill = New frmeditdetail_bill
        nextform.Show()

 
    End Sub

    Private Sub ButtonItem19_Click(sender As Object, e As EventArgs) Handles ButtonItem19.Click
        Dim nextform As frmedit_detailbillryh = New frmedit_detailbillryh
        nextform.Show()
    End Sub

    Private Sub ‚ÕπÀπToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ‚ÕπÀπToolStripMenuItem.Click
        Dim f_ThongSong As Boolean = True 
        If ComboBox1.SelectedIndex = 1 Then
            f_ThongSong = False
        Else
            f_ThongSong = True
        End If

        Dim frmForwareShare As New thungsong_share(f_ThongSong)
        frmForwareShare.Show()
    End Sub
End Class