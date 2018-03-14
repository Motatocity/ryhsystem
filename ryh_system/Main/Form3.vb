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
Imports System.Threading

Public Class Form3
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
    Public Sub loadfile()
        Dim sql As String
        sql = "SELECT uploadfile.name,filename1,pathfile,idfiledetail FROM rajyindee_db.uploadfile join filedetail ON uploadfile.iduploadfile = filedetail.iduploadfile ;"
        condb.GetTable(sql, dtset.Tables("FILEFTP"))
        GridControl1.DataSource = dtset

    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim pathfile As String
        Dim savefile As String
        pathfile = GridView1.GetDataRow(GridView1.FocusedRowHandle)("pathfile").ToString

        savefile = GridView1.GetDataRow(GridView1.FocusedRowHandle)("filename1").ToString



        FTP.DownloadFile(New WebClient, "DOCUMENT/" & pathfile, "D:\" & savefile)





        'Try
        Dim p As New System.Diagnostics.Process
        '    Dim securePwd As New SecureString()
        '    Dim pass() As String = {"t", "p", "x", "F", "X", "U", "p", "t", "2", "0", "6", "8", "5", "4"}
        '    Dim userPassword As String = "tpxFXUpt206854"
        '    For Each c As Char In userPassword
        '        securePwd.AppendChar(c)
        '    Next c

        '   Dim stringpath() As String = Split(DataGridView2.Rows(inbtIndex1).Cells(1).Value, "/")
        Dim s As New System.Diagnostics.ProcessStartInfo("D:\" + savefile)
        s.UseShellExecute = True

        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
        'Catch ex As Exception


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  SplashScreenManager1.ShowWaitForm()
        loadfile()
        ' SplashScreenManager1.CloseWaitForm()
    End Sub
End Class