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
Public Class frmdept_uploadfile
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Private WithEvents UploadClient As New System.Net.WebClient()
    Private WithEvents DownloadClient As New System.Net.WebClient()
    Dim mysql As MySqlConnection
    Private ftp As New FTP("172.30.10.0", "anonymous", "")
    Dim idcreatefolder As String = ""
    Dim inbtIndex As Integer
    Private Sub frmdept_uploadfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        searchdb()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim dialogOpenFiles As New Microsoft.Win32.OpenFileDialog1

        'dialogOpenFiles.Multiselect = True
        'dialogOpenFiles.Filter = "‰ø≈Ï·∫∫∑’Ë 1|*.jpg|‰ø≈Ï·∫∫∑’Ë 2|*.doc|‰ø≈Ï·∫∫∑’Ë 3|*.*"

        'If dialogOpenFiles.ShowDialog Then
        '    Dim i As String

        '    For Each i In dialogOpenFiles.FileNames
        '        Me.lstFileName.Items.Add(i)
        '    Next i
        'End If


        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                Dim text As String = File.ReadAllText(path)

                ' For debugging.
                Me.Text = text.Length.ToString
                For Each item As String In OpenFileDialog1.FileNames
                    DataGridView1.Rows.Add({item, System.IO.Path.GetFileName(item)})


                Next
            
                'DataGridView1.Rows.Add({OpenFileDialog1.FileName, System.IO.Path.GetFileName(OpenFileDialog1.FileName)})




            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Try
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "INSERT INTO uploadfile (name,pathname,date_time,dept) VALUES (@name,@pathname,@date_time,@dept); SELECT LAST_INSERT_ID()"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.Parameters.AddWithValue("@name", "")
            'MySqlCommand.Parameters.AddWithValue("@cendate", DateTimeInput1.Value.ToString("dd-MM-yyyy"))

            mySqlCommand.Parameters.AddWithValue("@pathname", "")
            mySqlCommand.Parameters.AddWithValue("@date_time", "")
            mySqlCommand.Parameters.AddWithValue("@dept", "REG")
            'MySqlCommand.Parameters.AddWithValue("@cenna", TextBoxX3.Text)
            'MySqlCommand.Parameters.AddWithValue("@cenwc", TextBoxX4.Text)
            idcreatefolder = CInt(mySqlCommand.ExecuteScalar())






        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





        ftp.CreateDirectory("/" + idcreatefolder.ToString, False)
        Dim idcreatefolder1 As Integer

        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                mysql.Close()
                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "INSERT INTO filedetail (filename,iduploadfile,pathfile,description,filename1) VALUES (@filename,@iduploadfile,@pathfile,@description,@filename1); SELECT LAST_INSERT_ID()"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql

                mySqlCommand.Parameters.AddWithValue("@filename", DataGridView1.Rows(i).Cells(0).Value)
                'MySqlCommand.Parameters.AddWithValue("@cendate", DateTimeInput1.Value.ToString("dd-MM-yyyy"))

                mySqlCommand.Parameters.AddWithValue("@iduploadfile", idcreatefolder)
                mySqlCommand.Parameters.AddWithValue("@pathfile", idcreatefolder + "/" + DataGridView1.Rows(i).Cells(1).Value)
                mySqlCommand.Parameters.AddWithValue("@description", "REG")
                mySqlCommand.Parameters.AddWithValue("@filename1", DataGridView1.Rows(i).Cells(1).Value)
                'MySqlCommand.Parameters.AddWithValue("@cenna", TextBoxX3.Text)
                'MySqlCommand.Parameters.AddWithValue("@cenwc", TextBoxX4.Text)
                idcreatefolder1 = CInt(mySqlCommand.ExecuteScalar())



                ftp.UploadFile(UploadClient, DataGridView1.Rows(i).Cells(0).Value, "/" + idcreatefolder + "/" + DataGridView1.Rows(i).Cells(1).Value, False)

            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        searchdb()


    End Sub
    Public Sub searchdb()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM filedetail ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridView1.Rows.Clear()


            While (mySqlReader.Read())


                DataGridView2.Rows.Add({mySqlReader("filename"), mySqlReader("pathfile")})
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As New System.Diagnostics.Process
        Dim securePwd As New SecureString()
        Dim pass() As String = {"k", "s", "9", "l", "f", "j"}
        Dim userPassword As String = "ks9lfj"
        For Each c As Char In userPassword
            securePwd.AppendChar(c)
        Next c


        Dim s As New System.Diagnostics.ProcessStartInfo("\\172.30.10.0\F\Book1.xlsx")
        s.UseShellExecute = True

        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub



    Private Sub Column3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Column3.Click
        Try
            Dim p As New System.Diagnostics.Process
            Dim securePwd As New SecureString()
            Dim pass() As String = {"k", "s", "9", "l", "f", "j"}
            Dim userPassword As String = "ks9lfj"
            For Each c As Char In userPassword
                securePwd.AppendChar(c)
            Next c

            Dim stringpath() As String = Split(DataGridView2.Rows(inbtIndex).Cells(1).Value, "/")
            Dim s As New System.Diagnostics.ProcessStartInfo("\\172.30.10.0\f\" + stringpath(0) + "\" + stringpath(1))
            s.UseShellExecute = True

            s.WindowStyle = ProcessWindowStyle.Normal
            p.StartInfo = s
            p.Start()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        inbtIndex = e.RowIndex

    End Sub
End Class
#Region " FTPClient Helper "

' [ FTPClient Helper ]
'
' 


Public Class FTP

#Region " Variables "

    Private conn As New FtpClient

    ''' <summary>
    ''' The FTP site.
    ''' </summary>
    Private Property host As String = String.Empty

    ''' <summary>
    ''' The user name.
    ''' </summary>
    Private Property user As String = String.Empty

    ''' <summary>
    ''' The user password.
    ''' </summary>
    Private Property pass As String = String.Empty

    ' Friend m_reset As New ManualResetEvent(False) ' Use it for CallBacks

#End Region

#Region " Constructor "

    ''' <summary>
    ''' .
    ''' </summary>
    ''' <param name="host">Indicates the ftp site.</param>
    ''' <param name="user">Indicates the username.</param>
    ''' <param name="pass">Indicates the password.</param>
    Public Sub New(ByVal host As String,
                   ByVal user As String,
                   ByVal pass As String)

        If Not host.ToLower.StartsWith("ftp://") Then
            Me.host = "ftp://" & host
        Else
            Me.host = host
        End If

        If Me.host.Last = "/" Then
            Me.host = Me.host.Remove(Me.host.Length - 1)
        End If

        Me.user = user
        Me.pass = pass

        With conn
            .Host = If(host.Last = "/", host.Remove(host.Length - 1), host)
            .Credentials = New NetworkCredential(Me.user, Me.pass)
        End With

    End Sub

#End Region

#Region " Public Methods "

    ''' <summary>
    ''' Connects to server.
    ''' </summary>
    Public Sub Connect()
        conn.Connect()
    End Sub

    ''' <summary>
    ''' Disconnects from server.
    ''' </summary>
    Public Sub Disconnect()
        conn.Disconnect()
    End Sub

    ''' <summary>
    ''' Creates a directory on server.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    ''' <param name="force">Try to force all non-existant pieces of the path to be created.</param>
    Public Sub CreateDirectory(ByVal directorypath As String, ByVal force As Boolean)
        conn.CreateDirectory(directorypath, force)
    End Sub

    ''' <summary>
    ''' Creates a directory on server.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    ''' <param name="force">Try to force all non-existant pieces of the path to be created.</param>
    ''' <param name="FtpListOption">Options that dictate how a list is performed ans what information is gathered.</param>
    Public Sub DeleteDirectory(ByVal directorypath As String,
                               ByVal force As Boolean,
                               Optional ByVal FtpListOption As FtpListOption =
                               FtpListOption.AllFiles Or FtpListOption.ForceList)

        ' Remove the directory and all objects beneath it. The last parameter
        ' forces System.Net.FtpClient to use LIST -a for getting a list of objects
        ' beneath the specified directory.
        conn.DeleteDirectory(directorypath, force, FtpListOption)

    End Sub

    ''' <summary>
    ''' Deletes a file on server.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Sub DeleteFile(ByVal filepath As String)
        conn.DeleteFile(filepath)
    End Sub

    ''' <summary>
    ''' Checks if a directory exist on server.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    Public Function DirectoryExists(ByVal directorypath As String) As Boolean
        Return conn.DirectoryExists(directorypath)
    End Function

    ''' <summary>
    ''' Executes a command on server.
    ''' </summary>
    ''' <param name="command">Indicates the command to execute on the server.</param>
    ''' <returns>Returns an object containing the server reply information.</returns>
    Public Function Execute(ByVal command As String) As FtpReply
        Return (InlineAssignHelper(New FtpReply, conn.Execute(command)))
    End Function

    ''' <summary>
    ''' Tries to execute a command on server.
    ''' </summary>
    ''' <param name="command">Indicates the command to execute on the server.</param>
    ''' <returns>Returns TRUE if command execution successfull, otherwise returns False.</returns>
    Public Function TryExecute(ByVal command As String) As Boolean
        Dim reply As FtpReply = Nothing
        Return (InlineAssignHelper(reply, conn.Execute(command))).Success
    End Function

    ''' <summary>
    ''' Checks if a file exist on server.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    ''' <param name="FtpListOption">Options that dictate how a list is performed ans what information is gathered.</param>
    Public Function FileExists(ByVal filepath As String,
                               Optional ByVal FtpListOption As FtpListOption =
                               FtpListOption.AllFiles Or FtpListOption.ForceList) As Boolean

        ' The last parameter forces System.Net.FtpClient to use LIST -a 
        ' for getting a list of objects in the parent directory.
        Return conn.FileExists(filepath, FtpListOption)

    End Function

    ''' <summary>
    ''' Retrieves a checksum of the given file
    ''' using a checksumming method that the server supports, if any.
    ''' The algorithm used goes in this order: 
    ''' 1. HASH command (server preferred algorithm).
    ''' 2. MD5 / XMD5 commands 
    ''' 3. XSHA1 command 
    ''' 4. XSHA256 command 
    ''' 5. XSHA512 command
    ''' 6. XCRC command
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Function GetChecksum(ByVal filepath As String) As FtpHash
        Return conn.GetChecksum(filepath)
    End Function

    ''' <summary>
    ''' Gets the checksum of file on server and compare it with the checksum of local file.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    ''' <param name="localfilepath">Indicates the local disk file path.</param>
    ''' <param name="algorithm">Indicates the algorithm that should be used to verify checksums.</param>
    ''' <returns>Returns TRUE if both checksums are equal, otherwise returns False.</returns>
    Public Function VerifyChecksum(ByVal filepath As String,
                                   ByVal localfilepath As String,
                                   ByVal algorithm As FtpHashAlgorithm) As Boolean

        Dim hash As FtpHash = Nothing

        hash = conn.GetChecksum(filepath)
        ' Make sure it returned a, to the best of our knowledge, valid hash object. 
        ' The commands for retrieving checksums are
        ' non-standard extensions to the protocol so we have to
        ' presume that the response was in a format understood by
        ' System.Net.FtpClient and parsed correctly.
        '
        ' In addition, there is no built-in support for verifying CRC hashes. 
        ' You will need to write you own or use a third-party solution.
        If hash.IsValid AndAlso hash.Algorithm <> algorithm Then
            Return hash.Verify(localfilepath)
        Else
            Return Nothing
        End If

    End Function

    ''' <summary>
    ''' Gets the size of file.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Function GetFileSize(ByVal filepath As String) As Long
        Return conn.GetFileSize(filepath)
    End Function

    ''' <summary>
    ''' Gets the currently HASH algorithm used for the HASH command on server.
    ''' </summary>
    Public Function GetHashAlgorithm() As FtpHashAlgorithm
        Return conn.GetHashAlgorithm()
    End Function

    ''' <summary>
    ''' Gets the modified time of file.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Function GetModifiedTime(ByVal filepath As String) As Date
        Return conn.GetModifiedTime(filepath)
    End Function

    ''' <summary>
    ''' Returns a file/directory listing using the NLST command.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp file path.</param>
    Public Function GetNameListing(ByVal directorypath As String) As String()
        Return conn.GetNameListing(directorypath)
    End Function

    ''' <summary>
    ''' Gets the current working directory on server.
    ''' </summary>
    Public Function GetWorkingDirectory() As String
        Return conn.GetWorkingDirectory()
    End Function

    ''' <summary>
    ''' Opens the specified file to be appended to...
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Function OpenAppend(ByVal filepath As String) As IO.Stream
        Return conn.OpenAppend(filepath)
    End Function

    ''' <summary>
    ''' Opens the specified file for reading.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Function OpenRead(ByVal filepath As String) As IO.Stream
        Return conn.OpenRead(filepath)
    End Function

    ''' <summary>
    ''' Opens the specified file for writing.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    Public Function OpenWrite(ByVal filepath As String) As IO.Stream
        Return conn.OpenWrite(filepath)
    End Function

    ''' <summary>
    ''' Rename a file on the server.
    ''' </summary>
    ''' <param name="filepath">Indicates the ftp file path.</param>
    ''' <param name="newfilepath">Indicates the new ftp file path.</param>
    Public Sub RenameFile(ByVal filepath As String, ByVal newfilepath As String)
        If conn.FileExists(filepath) Then
            conn.Rename(filepath, newfilepath)
        Else
            Throw New Exception(filepath & " File does not exist on server.")
        End If
    End Sub

    ''' <summary>
    ''' Rename a directory on the server.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp file path.</param>
    ''' <param name="newdirectorypath">Indicates the new ftp file path.</param>
    Public Sub RenameDirectory(ByVal directorypath As String, ByVal newdirectorypath As String)
        If conn.DirectoryExists(directorypath) Then
            conn.Rename(directorypath, newdirectorypath)
        Else
            Throw New Exception(directorypath & " Directory does not exist on server.")
        End If
    End Sub

    ''' <summary>
    ''' Tells the server wich hash algorithm to use for the HASH command.
    ''' </summary>
    ''' <param name="algorithm">Indicates the HASH algorithm.</param>
    Public Function SetHashAlgorithm(ByVal algorithm As FtpHashAlgorithm) As Boolean
        If conn.HashAlgorithms.HasFlag(algorithm) Then
            conn.SetHashAlgorithm(algorithm)
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Sets the working directory on the server.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    Public Sub SetWorkingDirectory(ByVal directorypath As String)
        conn.SetWorkingDirectory(directorypath)
    End Sub

    ''' <summary>
    ''' Gets a directory list on the specified path.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    ''' <param name="FtpListOption">Options that dictate how a list is performed ans what information is gathered.</param>
    Public Function GetDirectories(ByVal directorypath As String,
                                   Optional ByVal FtpListOption As FtpListOption =
                                   FtpListOption.AllFiles) As FtpListItem()

        Return conn.GetListing(directorypath, FtpListOption).
               Where(Function(item) item.Type = FtpFileSystemObjectType.Directory)

    End Function

    ''' <summary>
    ''' Gets a file list on the specified path.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    ''' <param name="FtpListOption">Options that dictate how a list is performed ans what information is gathered.</param>
    Public Function GetFiles(ByVal directorypath As String,
                             Optional ByVal FtpListOption As FtpListOption =
                             FtpListOption.AllFiles) As FtpListItem()

        Return conn.GetListing(directorypath, FtpListOption).
               Where(Function(item) item.Type = FtpFileSystemObjectType.File)

    End Function

    ''' <summary>
    ''' Gets a link list on the specified path.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    ''' <param name="FtpListOption">Options that dictate how a list is performed ans what information is gathered.</param>
    Public Function GetLinks(ByVal directorypath As String,
                             Optional ByVal FtpListOption As FtpListOption =
                             FtpListOption.AllFiles) As FtpListItem()

        Return conn.GetListing(directorypath, FtpListOption).
               Where(Function(item) item.Type = FtpFileSystemObjectType.Link)

    End Function

    ''' <summary>
    ''' Gets a file/folder list on the specified path.
    ''' </summary>
    ''' <param name="directorypath">Indicates the ftp directory path.</param>
    ''' <param name="FtpListOption">Options that dictate how a list is performed ans what information is gathered.</param>
    Public Function GetListing(ByVal directorypath As String,
                               Optional ByVal FtpListOption As FtpListOption =
                               FtpListOption.AllFiles) As FtpListItem()

        Return conn.GetListing(directorypath, FtpListOption)

    End Function

    ''' <summary>
    ''' Log to a console window
    ''' </summary>
    Public Sub LogToConsole()
        FtpTrace.AddListener(New ConsoleTraceListener())
        ' now use System.Net.FtpCLient as usual and the server transactions
        ' will be written to the Console window.
    End Sub

    ''' <summary>
    ''' Log to a text file
    ''' </summary>
    ''' <param name="filepath">Indicates the file where to save the log.</param>
    Public Sub LogToFile(ByVal filepath As String)
        FtpTrace.AddListener(New TextWriterTraceListener(filepath))
        ' now use System.Net.FtpCLient as usual and the server transactions
        ' will be written to the specified log file.
    End Sub

    ''' <summary>
    ''' Uploads a file to FTP.
    ''' </summary>
    ''' <param name="UploadClient">Indicates the WebClient object to upload the file.</param>
    ''' <param name="filepath">Indicates the ftp fle path.</param>
    ''' <param name="localfilepath">Specifies the local path where to save the downloaded file.</param>
    ''' <param name="Asynchronous">Indicates whether the download should be an Asynchronous operation, 
    ''' to raise WebClient events.</param>
    Public Sub UploadFile(ByRef UploadClient As WebClient,
                          ByVal localfilepath As String,
                          Optional ByVal filepath As String = Nothing,
                          Optional ByVal Asynchronous As Boolean = False)

        If filepath Is Nothing Then
            filepath = Me.host & "/" & New IO.FileInfo(localfilepath).Name
        ElseIf filepath.StartsWith("/") Then
            filepath = Me.host & filepath
        Else
            filepath = Me.host & "/" & filepath
        End If

        With UploadClient
            .Credentials = New NetworkCredential(Me.user, Me.pass)
            If Asynchronous Then
                .UploadFileAsync(New Uri(filepath), "STOR", localfilepath)
            Else
                .UploadFile(New Uri(filepath), "STOR", localfilepath)
            End If
        End With

    End Sub

    ''' <summary>
    ''' Downloads a file from FTP.
    ''' </summary>
    ''' <param name="DownloadClient">Indicates the WebClient object to download the file.</param>
    ''' <param name="filepath">Indicates the ftp fle path.</param>
    ''' <param name="localfilepath">Specifies the local path where to save the downloaded file.</param>
    ''' <param name="Asynchronous">Indicates whether the download should be an Asynchronous operation, 
    ''' to raise WebClient events.</param>
    Public Sub DownloadFile(ByRef DownloadClient As WebClient,
                            ByVal filepath As String,
                            ByVal localfilepath As String,
                            Optional ByVal Asynchronous As Boolean = False)

        Try

            If filepath.StartsWith("/") Then
                filepath = Me.host & filepath
            Else
                filepath = Me.host & "/" & filepath
            End If

            With DownloadClient
                .Credentials = New NetworkCredential(Me.user, Me.pass)
                If Asynchronous Then
                    .DownloadFileAsync(New Uri(filepath), localfilepath)
                Else
                    .DownloadFile(New Uri(filepath), localfilepath)
                End If
            End With

        Catch ex As WebException
            MsgBox(ex.ToString)
        End Try

    End Sub

#End Region

#Region " Miscellaneous methods "

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

#End Region

End Class

#End Region