Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmcheck_sms_nud
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection2
    Private Sub frmcheck_sms_nud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql.Close()
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        Dim tell1 As String = ""
        Dim tell2 As String = ""

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM message_tell order by idmessage_tell desc limit 100;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridViewX1.Rows.Clear()

            While (mySqlReader.Read())

                If mySqlReader("tell1") Is DBNull.Value Then
                    tell1 = ""
                Else

                    tell1 = mySqlReader("tell1")
                End If

                If mySqlReader("tell2") Is DBNull.Value Then
                    tell2 = ""
                Else

                    tell2 = mySqlReader("tell2")
                End If



                DataGridViewX1.Rows.Add({mySqlReader("hn"), mySqlReader("name"), mySqlReader("opd"), mySqlReader("cod"), mySqlReader("date_send"), mySqlReader("date_assign"), tell1, tell2})

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub
    Public Sub searchtell()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        Dim tell1 As String = ""
        Dim tell2 As String = ""
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM message_tell where hn like'%" & TextBoxX1.Text & "%' or name like'%" & TextBoxX1.Text & "%' or tell1 like'%" & TextBoxX1.Text & "%' or tell2 like'%" & TextBoxX1.Text & "%'  order by idmessage_tell  limit 100;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridViewX1.Rows.Clear()

            While (mySqlReader.Read())

                If mySqlReader("tell1") Is DBNull.Value Then
                    tell1 = ""
                Else

                    tell1 = mySqlReader("tell1")
                End If

                If mySqlReader("tell2") Is DBNull.Value Then
                    tell2 = ""
                Else

                    tell2 = mySqlReader("tell2")
                End If



                DataGridViewX1.Rows.Add({mySqlReader("hn"), mySqlReader("name"), mySqlReader("opd"), mySqlReader("cod"), mySqlReader("date_send"), mySqlReader("date_assign"), tell1, tell2})

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub TextBoxX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchtell()
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        searchtell()
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
End Class