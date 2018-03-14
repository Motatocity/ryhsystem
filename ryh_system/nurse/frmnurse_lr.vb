Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmnurse_lr
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

    Private Sub frmnurse_lr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
    End Sub


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click



        callculate_lr()


    End Sub
    Public Sub callculate_lr()
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
        mySqlCommand.CommandText = "call summation('LR','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                TextBoxX1.Text = CInt(mySqlReader("lrwbirth"))
                TextBoxX4.Text = CInt(mySqlReader("lrns"))
                TextBoxX3.Text = CInt(mySqlReader("lrdiag"))
                TextBoxX5.Text = CInt(mySqlReader("lrbirth"))
                TextBoxX17.Text = CInt(mySqlReader("lroperative"))
                TextBoxX18.Text = CInt(mySqlReader("lrafterbirth"))

                TextBoxX6.Text = CInt(mySqlReader("STD"))
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



        TextBoxX7.Text = Math.Round((CInt(TextBoxX1.Text) * 7.5 + CInt(TextBoxX3.Text) * 5.5 + CInt(TextBoxX4.Text) * 3.5 + CInt(TextBoxX5.Text) * 1.5) / CInt(TextBoxX6.Text), 0)
        TextBoxX8.Text = Math.Round((CInt(TextBoxX7.Text) * CInt(TextBoxX6.Text) * 1.17 * 1.2) / (7), 0)
        TextBoxX9.Text = Math.Round(CInt(TextBoxX8.Text) * 6 * valuedate, 0)
        TextBoxX10.Text = Math.Round(CInt(TextBoxX9.Text) / valuedate, 0)
        TextBoxX11.Text = Math.Round(CInt(TextBoxX10.Text) / 8, 0)

        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add({"RN", 0.65 * CInt(TextBoxX8.Text), 0.65 * 0.5 * CInt(TextBoxX8.Text), 0.65 * 0.3 * CInt(TextBoxX8.Text), 0.65 * 0.2 * CInt(TextBoxX8.Text)})
        DataGridView1.Rows.Add({"PN", 0.25 * CInt(TextBoxX8.Text), 0.25 * 0.5 * CInt(TextBoxX8.Text), 0.25 * 0.3 * CInt(TextBoxX8.Text), 0.25 * 0.2 * CInt(TextBoxX8.Text)})
        DataGridView1.Rows.Add({"NA", 0.1 * CInt(TextBoxX8.Text), 0.1 * 0.5 * CInt(TextBoxX8.Text), 0.1 * 0.3 * CInt(TextBoxX8.Text), 0.1 * 0.2 * CInt(TextBoxX8.Text)})


        TextBoxX14.Text = CStr(Math.Round((CInt(TextBoxX6.Text) * CInt(TextBoxX7.Text) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"




    End Sub

End Class