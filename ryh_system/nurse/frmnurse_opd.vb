Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmnurse_opd
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
    Private Sub frmnurse_opd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

    End Sub
    Public Sub callculat_opd()


        subdate2 = Split(MaskedTextBoxAdv2.Text, "-")
        subdate1 = Split(MaskedTextBoxAdv1.Text, "-")
        date1 = New System.DateTime(subdate1(2), subdate1(1), subdate1(0), 0, 0, 0)
        date2 = New System.DateTime(subdate2(2), subdate2(1), subdate2(0), 0, 0, 0)
        diff1 = date1.Subtract(date2)
        valuedate = diff1.TotalDays.ToString
        If valuedate = "0" Then
            valuedate = "1"
        Else
            valuedate = CInt(valuedate) + 1
        End If
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "call summation_opd('OPD','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                TextBoxX1.Text = CInt(mySqlReader("opdgen"))
                TextBoxX3.Text = CInt(mySqlReader("opdcheck"))
                TextBoxX4.Text = CInt(mySqlReader("opdadmit"))
                TextBoxX5.Text = CInt(mySqlReader("opddek"))
                TextBoxX2.Text = CInt(mySqlReader("opddekhud"))
                TextBoxX6.Text = CInt(mySqlReader("opdsum"))
                cenna = CInt(mySqlReader("cenna"))
                cenrn = CInt(mySqlReader("cenrn"))
                cenpn = CInt(mySqlReader("cenpn"))
                cenwc = CInt(mySqlReader("cenwc"))

                TextBoxX15.Text = cenrn
                TextBoxX13.Text = cenpn
                TextBoxX12.Text = cenna
                TextBoxX16.Text = cenwc
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        callculat_opd()
    End Sub
End Class