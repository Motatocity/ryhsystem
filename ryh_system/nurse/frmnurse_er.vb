Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class frmnurse_er
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
    Dim ersum As Integer
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
    Private Sub frmnurse_er_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If


    End Sub


    Public Sub callculate_er()
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
        mySqlCommand.CommandText = "call summation_er('ER','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                TextBoxX1.Text = CInt(mySqlReader("eremergency"))
                TextBoxX3.Text = CInt(mySqlReader("erurgent"))
                TextBoxX4.Text = CInt(mySqlReader("ernonurgent"))
                TextBoxX5.Text = CInt(mySqlReader("ernonacute"))
                TextBoxX2.Text = CInt(mySqlReader("erambuin"))
                TextBoxX6.Text = CInt(mySqlReader("erambuout"))
                ersum = CInt(mySqlReader("ersum"))
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



        TextBoxX7.Text = Math.Round(((CInt(TextBoxX1.Text) * 3.2 + CInt(TextBoxX3.Text) * 2.5 + CInt(TextBoxX4.Text) * 0.5 + CInt(TextBoxX5.Text) * 0.25 + CInt(TextBoxX2.Text) * 0.5 + CInt(TextBoxX6.Text) * 1.5)) / ersum, 2)
        TextBoxX8.Text = Math.Round((CDbl(TextBoxX7.Text) * ersum * 1.17 * 1.2) / (7), 2)
        TextBoxX9.Text = Math.Round(CInt(TextBoxX8.Text) * 6 * valuedate, 2)
        TextBoxX10.Text = Math.Round(CInt(TextBoxX9.Text) / valuedate, 2)
        TextBoxX11.Text = Math.Round(CInt(TextBoxX10.Text) / 8, 2)

        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add({"RN", 0.65 * CInt(TextBoxX8.Text), 0.65 * 0.5 * CInt(TextBoxX8.Text), 0.65 * 0.3 * CInt(TextBoxX8.Text), 0.65 * 0.2 * CInt(TextBoxX8.Text)})
        DataGridView1.Rows.Add({"PN", 0.25 * CInt(TextBoxX8.Text), 0.25 * 0.5 * CInt(TextBoxX8.Text), 0.25 * 0.3 * CInt(TextBoxX8.Text), 0.25 * 0.2 * CInt(TextBoxX8.Text)})
        DataGridView1.Rows.Add({"NA", 0.1 * CInt(TextBoxX8.Text), 0.1 * 0.5 * CInt(TextBoxX8.Text), 0.1 * 0.3 * CInt(TextBoxX8.Text), 0.1 * 0.2 * CInt(TextBoxX8.Text)})


        TextBoxX14.Text = CStr(Math.Round((CDbl(TextBoxX7.Text) * ersum * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"






    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        callculate_er()
    End Sub
End Class