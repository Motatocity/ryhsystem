Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class ConnecDBRYH
    Implements IDisposable
    'Private Shared ReadOnly strCommon As String = "server=172.30.10.132;port = 3305;user id=" + "root" + ";password=" + "software" + ";database=hcudb;Character Set =utf8"
    'Private Shared ReadOnly strCommon As String = "server=127.0.0.1;port = 3306;user id=" + "root" + ";password=" + "" + ";database=rajyindee_db;Character Set =utf8"
    Private Shared ReadOnly strCommon As String = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

    ' Private Shared ReadOnly strCommon As String = "server=192.168.10.222;port = 3306;user id=" + "myfriends" + ";password=" + "mftpxFXUpt206854" + ";database=rajyindee_db;Character Set =utf8"

    Public Shared Function NewConnection() As ConnecDBRYH
        Return New ConnecDBRYH(strCommon)
    End Function

    Public mConnection As MySqlConnection
    Private mTransaction As MySqlTransaction
    Private mIsInTransaction As Boolean

    Public Sub New(ByVal connectionString As String)
        mConnection = New MySqlConnection(connectionString)
        mIsInTransaction = False
        Try
            mConnection.Open()
        Catch ex As Exception
            mConnection.Open()
        End Try

    End Sub

    Public Sub BeginTrans()
        If (Not mIsInTransaction) Then
            mTransaction = mConnection.BeginTransaction()
            mIsInTransaction = True
        End If
    End Sub

    Public Sub RollbackTrans()
        If (mIsInTransaction) Then
            mTransaction.Rollback()
            mTransaction.Dispose()
            mIsInTransaction = False
        End If
    End Sub

    Public Sub CommitTrans()
        If (mIsInTransaction) Then
            mTransaction.Commit()
            mTransaction.Dispose()
            mIsInTransaction = False
        End If
    End Sub

    Public Function ExecuteNonQuery(ByVal sql As String) As Integer

        Dim result As Integer
        If (Me.mIsInTransaction) Then
            Using cmd As New MySqlCommand(sql, Me.mConnection, Me.mTransaction)
                result = cmd.ExecuteNonQuery()
            End Using
        Else
            Using cmd As New MySqlCommand(sql, Me.mConnection)
                result = cmd.ExecuteNonQuery()
            End Using
        End If
        Return result

    End Function

    Public Function ExecuteReader(ByVal sql As String) As MySqlDataReader

        Dim mysqlReader As MySqlDataReader
        If (Me.mIsInTransaction) Then
            Using cmd As New MySqlCommand(sql, Me.mConnection, Me.mTransaction)
                mysqlReader = cmd.ExecuteReader()
            End Using
        Else
            Using cmd As New MySqlCommand(sql, Me.mConnection)
                mysqlReader = cmd.ExecuteReader()
            End Using
        End If

        Return mysqlReader
    End Function
    Public Function ExecuteScalar(ByVal sql As String) As Object

        Dim result As Object
        If (Me.mIsInTransaction) Then
            Using cmd As New MySqlCommand(sql, Me.mConnection, Me.mTransaction)
                result = cmd.ExecuteScalar()
            End Using
        Else
            Using cmd As New MySqlCommand(sql, Me.mConnection)
                result = cmd.ExecuteScalar()
            End Using
        End If
        Return result
    End Function

    Public Function GetTable(ByVal sql As String) As DataTable

        Dim result As New DataTable()
        If (Me.mIsInTransaction) Then
            Using selectCommand As New MySqlCommand(sql, Me.mConnection, Me.mTransaction)
                Using adapter As New MySqlDataAdapter(selectCommand)
                    adapter.Fill(result)
                End Using
            End Using
        Else
            Using adapter As New MySqlDataAdapter(sql, Me.mConnection)
                adapter.Fill(result)
            End Using
        End If
        Return result
    End Function

    Public Function GetTable(ByVal sql As String, ByRef DTTABLE As DataTable)

        '  Dim result As New DataTable()
        If (Me.mIsInTransaction) Then
            Using selectCommand As New MySqlCommand(sql, Me.mConnection, Me.mTransaction)
                Using adapter As New MySqlDataAdapter(selectCommand)
                    adapter.Fill(DTTABLE)
                End Using
            End Using
        Else
            Using selectCommand As New MySqlCommand(sql, Me.mConnection)
                Using adapter As New MySqlDataAdapter(selectCommand)
                    adapter.Fill(DTTABLE)
                End Using
            End Using



        End If
        '   Return DTTABLE
    End Function

    Public Function ExecuteScalar_Parameter(ByVal msCmd As MySqlCommand) As Integer
        Dim result As Integer
        If (Me.mIsInTransaction) Then
            msCmd.Connection = Me.mConnection
            msCmd.Transaction = Me.mTransaction
            result = msCmd.ExecuteScalar
        Else
            msCmd.Connection = Me.mConnection
            result = msCmd.ExecuteScalar
        End If
        Return result
    End Function



#Region "IDisposable Support"
    Private disposedValue As Boolean

    Protected Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
            End If

            If (mIsInTransaction) Then
                mTransaction.Rollback()
                mTransaction.Dispose()
            End If
            mConnection.Close()
            mConnection.Dispose()

        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region



End Class
