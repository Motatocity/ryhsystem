Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class CONNECTDB

    'Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
    '    grid = e.GridPanel.ActiveRow
    '    f.TXT_CID.Text = grid.Cells.Item(2).Value


    Implements IDisposable
    Private Shared strCommon As String
    'Private Shared ReadOnly strCommon As String = "server=192.168.4.249;port = 3306;user id=" + "root" + ";password=" + "ks9lfj" + ";database=myfriendsdb;Character Set =utf8"

    Public Shared Function NewConnection(IP As String, USER As String, PASS As String, PORT As String, DATATBASE As String) As CONNECTDB
        strCommon = "server=" + IP + ";" + "port = " & PORT & ";user id=" & USER & ";password=" & PASS & ";database=" & DATATBASE & ";Character Set =utf8"
        Return New CONNECTDB(strCommon)
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
            MsgBox(ex.ToString)
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
