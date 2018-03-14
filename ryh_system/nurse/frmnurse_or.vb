Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmnurse_or
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

    Dim sumall As Integer




    Private Sub frmnurse_or_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        call_or()

    End Sub


    Public Sub call_or()


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
        mySqlCommand.CommandText = "call summantion_or('OR','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            DataGridView1.Rows.Clear()

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridView1.Rows.Add({"1. Scope + OR เล็ก [A]", CInt(mySqlReader("scope")) + CInt(mySqlReader("small")), "4.7", (CInt(mySqlReader("scope")) + CInt(mySqlReader("small"))) * 4.7})
                sumtotal_scope = (CInt(mySqlReader("scope")) + CInt(mySqlReader("small")))
                DataGridView1.Rows.Add({"2. Minor case[B]", CInt(mySqlReader("minorcase")), "4.7", CInt(mySqlReader("minorcase")) * 6.3})
                sumtotal_minor = CInt(mySqlReader("minorcase"))
                DataGridView1.Rows.Add({"3. Major case[C]", CInt(mySqlReader("majorcase")), "7.8", CInt(mySqlReader("majorcase")) * 7.8})

                sumtotal_major = CInt(mySqlReader("majorcase"))
                sumall = CInt(mySqlReader("sumall"))
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





        TextBoxX7.Text = Math.Round(((sumtotal_scope * 4.7) + (sumtotal_minor * 6.3) + (sumtotal_major * 7.8)) / sumall, 0)

        TextBoxX8.Text = Math.Round((CInt(TextBoxX7.Text) * sumall * 1.17 * 1.2) / (7), 0)
        TextBoxX3.Text = Math.Round(CInt(TextBoxX8.Text) * 6 * valuedate, 0)
        TextBoxX2.Text = Math.Round(CInt(TextBoxX3.Text) / valuedate, 0)
        TextBoxX1.Text = Math.Round(CInt(TextBoxX2.Text) / 8, 0)


        TextBoxX14.Text = CStr(Math.Round((sumall * CInt(TextBoxX7.Text) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"




    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

    End Sub
End Class