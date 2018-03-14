Imports System.Net
Imports System.Net.FtpClient
Imports System.Net.FtpClient.Extensions
Imports System.IO
Imports System.Security
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports System.Text
Imports System.Web
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports System.Data
Imports frmdept_uploadfile
Imports System.Threading

Public Class frmupload_reg
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim dtset As DataSet = New DataSet1
    Private WithEvents UploadClient As New System.Net.WebClient()
    Private WithEvents DownloadClient As New System.Net.WebClient()
    Private ftp As New FTP("ryh1", "admin", "tpxFXUpt206854")


    Dim condb As ConnecDBRYH = ConnecDBRYH.NewConnection

    Dim mysql As MySqlConnection

    Dim idcreatefolder As String = ""
    Dim inbtIndex As Integer
    Dim inbtIndex1 As Integer
    Dim a As FILTERCLASS
    Public Delegate Sub DelegateSub(ByVal x As Integer)
    Private Sub showResult(ByVal Num As Integer)
        If Label10.InvokeRequired Then
            Dim dlg As New DelegateSub(AddressOf showResult)
            Me.Invoke(dlg, Num)

        Else
            CircularProgress1.IsRunning = False

            searchTypeDB()

        End If
    End Sub
    Private Sub แกไขหวขอToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles แกไขหวขอToolStripMenuItem.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim StatusDate As String
        Dim commandText3 As String
        StatusDate = Microsoft.VisualBasic.InputBox("Password")


        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        commandText3 = "Delete FROM uploadfile  where iduploadfile = '" & DataGridView1.Rows(inbtIndex).Cells(1).Value & "'; "
        mySqlCommand.CommandText = commandText3
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.Connection = mysql
        mySqlCommand.ExecuteNonQuery()


        Try


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        mysql.Close()

        searchSubject()


    End Sub
   
    Private Sub frmupload_reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        Try

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If


            ftp.Connect()


        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        searchSubject()



    End Sub
    Public Sub searchContent()
        Try
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            mySqlCommand.CommandText = "SELECT * FROM filedetail where  filename1  like  '%" & TextBoxX1.Text & "%' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand


            mySqlReader = mySqlCommand.ExecuteReader

            DataGridView2.Rows.Clear()


            While (mySqlReader.Read())


                DataGridView2.Rows.Add({mySqlReader("filename"), mySqlReader("pathfile"), mySqlReader("filename1"), mySqlReader("idfiledetail")})
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Public Sub searchTypeDB()
        Try
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            mySqlCommand.CommandText = "SELECT * FROM filedetail where  iduploadfile  = '" & DataGridView1.Rows(inbtIndex).Cells(1).Value & "'  ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand


            mySqlReader = mySqlCommand.ExecuteReader

            DataGridView2.Rows.Clear()


            While (mySqlReader.Read())


                DataGridView2.Rows.Add({mySqlReader("filename"), mySqlReader("pathfile"), mySqlReader("filename1"), mySqlReader("idfiledetail")})
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub
   

    Private Sub เพมหวขอToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เพมหวขอToolStripMenuItem.Click


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim StatusDate As String
        Dim commandText3 As String
        StatusDate = Microsoft.VisualBasic.InputBox("หัวข้อ")




        Try
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "INSERT INTO uploadfile (name,pathname,date_time,dept) VALUES (@name,@pathname,@date_time,@dept); SELECT LAST_INSERT_ID()"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.Parameters.AddWithValue("@name", StatusDate.ToString)
            'MySqlCommand.Parameters.AddWithValue("@cendate", DateTimeInput1.Value.ToString("dd-MM-yyyy"))

            mySqlCommand.Parameters.AddWithValue("@pathname", "")
            mySqlCommand.Parameters.AddWithValue("@date_time", DateTime.Now.ToString("dd-MM-yyyy"))
            mySqlCommand.Parameters.AddWithValue("@dept", frmlogin_dept.dept)
            'MySqlCommand.Parameters.AddWithValue("@cenna", TextBoxX3.Text)
            'MySqlCommand.Parameters.AddWithValue("@cenwc", TextBoxX4.Text)
            idcreatefolder = CInt(mySqlCommand.ExecuteScalar())






        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        searchSubject()


    End Sub
    Public Sub searchSubject()


        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM uploadfile  ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridView1.Rows.Clear()


            While (mySqlReader.Read())


                DataGridView1.Rows.Add({mySqlReader("name"), mySqlReader("iduploadfile")})
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()




    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        inbtIndex = e.RowIndex
        searchTypeDB()



    End Sub
    Private Sub excelReport()
        Dim path As String = OpenFileDialog1.FileName
        Try
            ' Read in text.

            Dim text As String = System.IO.File.ReadAllText(path)

            ' For debugging.

            ftp.Disconnect()
            ftp.Connect()
            ftp.CreateDirectory("DOCUMENT/" & DataGridView1.Rows(inbtIndex).Cells(1).Value.ToString, False)



            For Each item As String In OpenFileDialog1.FileNames




                Dim idcreatefolder1 As Integer

                Try


                    mysql.Close()
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.Parameters.Clear()
                    mySqlCommand.CommandText = "INSERT INTO filedetail (filename,iduploadfile,pathfile,description,filename1) VALUES (@filename,@iduploadfile,@pathfile,@description,@filename1); SELECT LAST_INSERT_ID()"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql

                    mySqlCommand.Parameters.AddWithValue("@filename", item)
                    'MySqlCommand.Parameters.AddWithValue("@cendate", DateTimeInput1.Value.ToString("dd-MM-yyyy"))

                    mySqlCommand.Parameters.AddWithValue("@iduploadfile", DataGridView1.Rows(inbtIndex).Cells(1).Value.ToString)
                    mySqlCommand.Parameters.AddWithValue("@pathfile", DataGridView1.Rows(inbtIndex).Cells(1).Value.ToString + "/" + System.IO.Path.GetFileName(item))
                    mySqlCommand.Parameters.AddWithValue("@description", "REG")
                    mySqlCommand.Parameters.AddWithValue("@filename1", System.IO.Path.GetFileName(item))
                    'MySqlCommand.Parameters.AddWithValue("@cenna", TextBoxX3.Text)
                    'MySqlCommand.Parameters.AddWithValue("@cenwc", TextBoxX4.Text)
                    idcreatefolder1 = CInt(mySqlCommand.ExecuteScalar())



                    ftp.UploadFile(UploadClient, item, "DOCUMENT/" + DataGridView1.Rows(inbtIndex).Cells(1).Value.ToString + "/" + System.IO.Path.GetFileName(item), False)
                    mysql.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try





            Next

            'DataGridView1.Rows.Add({OpenFileDialog1.FileName, System.IO.Path.GetFileName(OpenFileDialog1.FileName)})




        Catch ex As Exception

            ' Report an error.
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub เพมไฟลToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เพมไฟลToolStripMenuItem.Click

        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            ' Test result.
            If result = Windows.Forms.DialogResult.OK Then
                Dim t = New Thread(New ThreadStart(AddressOf excelReport))
                t.Start()
                CircularProgress1.IsRunning = True
                searchTypeDB()

            End If

        Catch ex As Exception

        End Try



        ' Get the file name.



    End Sub


    Private Sub Column3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Column3.Click


        ftp.DownloadFile(New WebClient, "DOCUMENT/" + DataGridView2.Rows(inbtIndex1).Cells(1).Value, "D:\" + DataGridView2.Rows(inbtIndex1).Cells(2).Value)





        'Try
        Dim p As New System.Diagnostics.Process
        '    Dim securePwd As New SecureString()
        '    Dim pass() As String = {"t", "p", "x", "F", "X", "U", "p", "t", "2", "0", "6", "8", "5", "4"}
        '    Dim userPassword As String = "tpxFXUpt206854"
        '    For Each c As Char In userPassword
        '        securePwd.AppendChar(c)
        '    Next c

        Dim stringpath() As String = Split(DataGridView2.Rows(inbtIndex1).Cells(1).Value, "/")
        Dim s As New System.Diagnostics.ProcessStartInfo("D:\" + stringpath(1))
        s.UseShellExecute = True

        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        inbtIndex1 = e.RowIndex
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        searchContent()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        ftp.DownloadFile(DownloadClient, "24/STFIDTAX.txt", "C:\STFIDTAX.txt", False)
        '  ftp.UploadFile(UploadClient, item, "/" + DataGridView1.Rows(inbtIndex).Cells(1).Value.ToString + "/" + System.IO.Path.GetFileName(item), False)

    End Sub

    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchContent()
        End If
    End Sub

   

    Private Sub ButtonX2_Click_1(sender As Object, e As EventArgs)
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            ' Test result.
            If result = Windows.Forms.DialogResult.OK Then
                Dim t = New Thread(New ThreadStart(AddressOf excelReport))
                t.Start()
                CircularProgress1.IsRunning = True
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class

