Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmit_mdept
    Dim inbtIndex As Integer
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection2
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
    Dim check As Boolean = False
    Private Sub frmit_mdept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        searchdata()

    End Sub

    Public Sub searchdata()

        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        DataGridViewX1.Rows.Clear()

        mySqlCommand.CommandText = "SELECT * FROM userdep;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridViewX2.Rows.Add({mySqlReader("iduserdep"), mySqlReader("username"), mySqlReader("password"), mySqlReader("name"), mySqlReader("description"), mySqlReader("dep")})
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub
    Private Sub DataGridViewX1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridViewX1.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
    Private Sub DataGridViewX2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX2.CellClick
        inbtIndex = e.RowIndex
        Try
            idkey = DataGridViewX2.Rows(inbtIndex).Cells(0).Value
        Catch ex As Exception

        End Try





        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        DataGridViewX1.Rows.Clear()

        mySqlCommand.CommandText = "SELECT * FROM nameform left join usernameform on nameform.idform = usernameform.idnameform where idform  = ( Select idnameform from usernameform where iduserdep ='" & idkey & "');"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())



                DataGridViewX1.Rows.Add({mySqlReader("idusernameform"), mySqlReader("nameform"), mySqlReader("namedescription"), False, False})



            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub
    Private Sub DataGridViewX2_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridViewX2.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
End Class