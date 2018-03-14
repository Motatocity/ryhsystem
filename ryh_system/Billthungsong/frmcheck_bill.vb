Imports MySql.Data.MySqlClient

Public Class frmcheck_bill
    Dim mysql As MySqlConnection = frmmain_thungsong.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader

    Dim sum As Integer
    Dim sumshare As Integer

    Dim check As Boolean
    Dim intbindex As Integer
    Public Shared idlast As Integer
    Public Shared thaitext As String
    Public Shared age As String
    Private Sub frmcheck_bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
            TextBox5.AutoCompleteCustomSource.Add("กรุงไทย")
            TextBox5.AutoCompleteCustomSource.Add("กรุงเทพ")
            TextBox5.AutoCompleteCustomSource.Add("กรุงศรีอยุธยา")
            TextBox5.AutoCompleteCustomSource.Add("กสิกรไทย")
            TextBox5.AutoCompleteCustomSource.Add("เกียรตินาคิน")
            TextBox5.AutoCompleteCustomSource.Add("ซีไอเอ็มบีไทย")
            TextBox5.AutoCompleteCustomSource.Add("ทหารไทย")
            TextBox5.AutoCompleteCustomSource.Add("ทิสโก้")
            TextBox5.AutoCompleteCustomSource.Add("ไทยพาณิชย์")
            TextBox5.AutoCompleteCustomSource.Add("ธนชาต")
            TextBox5.AutoCompleteCustomSource.Add("ออมสิน")
            mysql.Close()

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "SELECT * FROM thungsongdb where idthungsongdb = '" & frmmain_thungsong.idkey & "' ;"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    TextBox1.Text = mySqlReader("name2")

                    TextBox2.Text = mySqlReader("address")
                    TextBox4.Text = mySqlReader("idcardname")

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()




            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Dim sql As String
            sql = "SELECT thungsong_round1 ,thungsong_round.idthungsong_round ,thungsong_rundsum , thungsong_rundshare , thungsong_sum ,thungsong_sumshare  ,thungsong_roundbill , thungsong_rundstat FROM (SELECT SUM(thungsong_sum) AS thungsong_sum  ,SUM(thungsong_sumshare)  as thungsong_sumshare  , idthungsong_round FROM rajyindee_db.thungsong_rec GROUP by idthungsong_round  ) AS A  RIGHT JOIN  thungsong_round ON A.idthungsong_round = thungsong_round.idthungsong_round   where thungsong_roundbill = '" & frmmain_thungsong.idkey & "' order by idthungsong_round ASC ; ;"

            '    mySqlCommand.CommandText = "SELECT * FROM thungsong_round where thungsong_roundbill = '" & frmmain_thungsong.idkey & "' order by idthungsong_round ASC ;"
            mySqlCommand.CommandText = sql
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    If mySqlReader("thungsong_rundstat") = 1 Then
                        check = True
                    Else
                        check = False
                    End If

                    DataGridViewX1.Rows.Add({mySqlReader("thungsong_round1"), mySqlReader("thungsong_rundshare"), mySqlReader("thungsong_rundsum"), mySqlReader("thungsong_sum"), check, mySqlReader("thungsong_rundstat"), mySqlReader("idthungsong_round")})




                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()


            For i As Integer = 0 To DataGridViewX1.Rows.Count - 1

                If DataGridViewX1.Rows(i).Cells(4).Value = "True" And DataGridViewX1.Rows(i).Cells(5).Value = "1" Then
                    DataGridViewX1.Rows(i).Cells(3).Style.BackColor = Color.DeepSkyBlue

                End If

                If DataGridViewX1.Rows(i).Cells(5).Value = "1" Then
                    DataGridViewX1.Rows(i).ReadOnly = True
                End If

            Next

            callculate_sum()
        ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then

            TextBox5.AutoCompleteCustomSource.Add("กสิกรไทย")
            TextBox5.AutoCompleteCustomSource.Add("ทหารไทย")
            TextBox5.AutoCompleteCustomSource.Add("ไทยพาณิชย์")


            TextBox6.AutoCompleteCustomSource.Add("ถนนราษฎร์ยินดี (หาดใหญ่)")
            TextBox6.AutoCompleteCustomSource.Add("ถนนจุติอนุสรณ์ (หาดใหญ่)")
            TextBox6.AutoCompleteCustomSource.Add("ถนนศรีภูวนารถ (หาดใหญ่)")




            TextBox7.AutoCompleteCustomSource.Add("ถนนราษฎร์ยินดี (หาดใหญ่)")
            TextBox7.AutoCompleteCustomSource.Add("ถนนจุติอนุสรณ์ (หาดใหญ่)")
            TextBox7.AutoCompleteCustomSource.Add("ถนนศรีภูวนารถ (หาดใหญ่)")

            mysql.Close()

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "SELECT * FROM ryh_main where idryh_main = '" & frmmain_thungsong.idkey & "' ;"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    TextBox1.Text = mySqlReader("name")

                    TextBox2.Text = mySqlReader("address")
                    TextBox4.Text = mySqlReader("IDCARD")
                    TextBox8.Text = mySqlReader("tell")
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()





            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            mySqlCommand.CommandText = "SELECT * from rajyindee_db.ryh_sumdetail  where idryh_main = '" & frmmain_thungsong.idkey & "';"


            'mySqlCommand.CommandText = "SELECT * FROM thungsong_round where thungsong_roundbill = '" & frmmain_thungsong.idkey & "' order by idthungsong_round ASC ;"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    If mySqlReader("checkryh") = 1 Then
                        check = True
                    Else
                        check = False
                    End If

                    DataGridViewX1.Rows.Add({mySqlReader("count"), mySqlReader("sum"), mySqlReader("sum") * 3, 0, check, mySqlReader("idryh_sumdetail")})




                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()





        End If


    End Sub
    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Try


            intbindex = e.RowIndex

            callculate_sum()
            TextBox9.Text = DataGridViewX1.Rows(intbindex).Cells(0).Value
            TextBox9.Tag = DataGridViewX1.Rows(intbindex).Cells(6).Value

            LabelX4.Text = DataGridViewX1.Rows(intbindex).Cells(1).Value
            If IsDBNull(DataGridViewX1.Rows(intbindex).Cells(3).Value) Then

                TextBox10.Text = DataGridViewX1.Rows(intbindex).Cells(2).Value

            Else

                TextBox10.Text = DataGridViewX1.Rows(intbindex).Cells(2).Value - DataGridViewX1.Rows(intbindex).Cells(3).Value

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        TextBox11.Text = TextBox10.Text

    End Sub




    Public Sub searchDBGridnew()

        DataGridViewX1.Rows.Clear()
        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            'mySqlCommand.CommandText = "SELECT ryh_sumdetail.count as count  , ryh_sumdetail.sum as sum ,checkryh ,idryh_sumdetail FROM ryh_main JOIN ryh_sum  ON ryh_main.idryh_main = ryh_sum.ID JOIN ryh_sumdetail ON ryh_sum.idryh_sum = ryh_sumdetail.idryh_sum  where idryh_main = '" & frmmain_thungsong.idkey & "' ORDER BY idryh_sumdetail; "
            mySqlCommand.CommandText = "SELECT thungsong_round1 ,thungsong_round.idthungsong_round ,thungsong_rundsum , thungsong_rundshare , thungsong_sum ,thungsong_sumshare  ,thungsong_roundbill , thungsong_rundstat FROM (SELECT SUM(thungsong_sum) AS thungsong_sum  ,SUM(thungsong_sumshare)  as thungsong_sumshare  , idthungsong_round FROM rajyindee_db.thungsong_rec GROUP by idthungsong_round  ) AS A  RIGHT JOIN  thungsong_round ON A.idthungsong_round = thungsong_round.idthungsong_round   where thungsong_roundbill = '" & frmmain_thungsong.idkey & "' order by idthungsong_round ASC ; ;"


            'mySqlCommand.CommandText = "SELECT * FROM thungsong_round where thungsong_roundbill = '" & frmmain_thungsong.idkey & "' order by idthungsong_round ASC ;"
            ' mySqlCommand.CommandText = 
            ' mySqlCommand.CommandText = Sql
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    If mySqlReader("thungsong_rundstat") = 1 Then
                        check = True
                    Else
                        check = False
                    End If

                    DataGridViewX1.Rows.Add({mySqlReader("thungsong_round1"), mySqlReader("thungsong_rundshare"), mySqlReader("thungsong_rundsum"), mySqlReader("thungsong_sum"), check, mySqlReader("thungsong_rundstat"), mySqlReader("idthungsong_round")})




                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()


            For i As Integer = 0 To DataGridViewX1.Rows.Count - 1

                If DataGridViewX1.Rows(i).Cells(4).Value = "True" And DataGridViewX1.Rows(i).Cells(5).Value = "1" Then
                    DataGridViewX1.Rows(i).Cells(3).Style.BackColor = Color.DeepSkyBlue

                End If

                If DataGridViewX1.Rows(i).Cells(5).Value = "1" Then
                    DataGridViewX1.Rows(i).ReadOnly = True
                End If

            Next
        ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            mySqlCommand.CommandText = "SELECT * from rajyindee_db.ryh_sumdetail  where idryh_main = '" & frmmain_thungsong.idkey & "';"




            'mySqlCommand.CommandText = "SELECT * FROM thungsong_round where thungsong_roundbill = '" & frmmain_thungsong.idkey & "' order by idthungsong_round ASC ;"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    If mySqlReader("checkryh") = 1 Then
                        check = True
                    Else
                        check = False
                    End If

                    DataGridViewX1.Rows.Add({mySqlReader("count"), mySqlReader("sum"), mySqlReader("sum") * 3, 0, check, mySqlReader("idryh_sumdetail")})



                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()



        End If


    End Sub



    Public Sub callculate_sum()
        Try
            If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
                Dim sumtotal As Double = 0
                Dim sumbuy As Double = 0



                For i As Integer = 0 To DataGridViewX1.Rows.Count - 1

                    If IsDBNull(DataGridViewX1.Rows(i).Cells(3).Value) Then
                    Else
                        sumbuy += CInt(DataGridViewX1.Rows(i).Cells(3).Value)

                    End If




                    sumtotal += DataGridViewX1.Rows(i).Cells(2).Value


                Next

                LabelX2.Text = CStr(sumtotal * 0.1) + ".00"
                LabelX4.Text = CStr(sumbuy * 0.1) + ".00"
                LabelX3.Text = CStr(sumtotal - sumbuy) + ".00"
                LabelX1.Text = CStr(sumbuy) + ".00"

                Label17.Text = ThaiBahtText(CDbl(TextBox11.Text))
            ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then


                Dim sumtotal As Double = 0
                Dim sumbuy As Double = 0



                For i As Integer = 0 To DataGridViewX1.Rows.Count - 1


                    If IsDBNull(DataGridViewX1.Rows(i).Cells(3).Value) Then
                    Else
                        sumbuy += CInt(DataGridViewX1.Rows(i).Cells(3).Value)

                    End If


                    '   MsgBox(DataGridViewX1.Rows(i).Cells(2).Value)
                    sumtotal += CDbl(DataGridViewX1.Rows(i).Cells(2).Value)


                Next

                'LabelX2.Text = CDbl(sumtotal / 1.5)
                'LabelX4.Text = CDbl(sumbuy / 1.5)
                'LabelX3.Text = CDbl(sumtotal - sumbuy)
                'LabelX1.Text = CDbl(sumbuy)
                Label17.Text = ThaiBahtText(CDbl(TextBox11.Text))

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Label17.Text = ThaiBahtText(CDbl(TextBox11.Text))
        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
            age = TextBox3.Text
            savedata()
            searchDBGridnew()
            thaitext = Label17.Text
            Try
                Dim nextform As frmrpt_bill = New frmrpt_bill
                nextform.Show()
            Catch ex As Exception

            End Try
        ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then
            age = TextBox3.Text
            savedatarajyindee()
            searchDBGridnew()
            thaitext = Label17.Text
            Try
                Dim nextform As frmrpt_bill = New frmrpt_bill
                nextform.Show()
            Catch ex As Exception

            End Try
        End If

    End Sub
    Public Sub savedatarajyindee()
        Dim stringtype As String
        callculate_sum()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        If RadioButton1.Checked = True Then
            stringtype = "โอน"
        ElseIf RadioButton2.Checked = True Then
            stringtype = "เช็ค"
        ElseIf RadioButton3.Checked = True Then
            stringtype = "เงินสด"
        End If

        Try


            If RadioButton1.Checked = True Then
                stringtype = "โอน"
            ElseIf RadioButton2.Checked = True Then
                stringtype = "เช็ค"
            ElseIf RadioButton3.Checked = True Then
                stringtype = "เงินสด"
            End If
            mySqlCommand.Parameters.Clear()
            Dim doccode As String

            doccode = GENDOC.getIDform("RV")
            ' MsgBox(CInt(TextBox11.Text) / 1.5)
            mySqlCommand.CommandText = "insert into ryh_billdet ( idryh_sumdet,ryh_billcol,ryh_type, ryh_sum, ryh_sumshare,ryh_bank,ryh_bankid,ryh_date,ryh_date1,ryh_banksub,ryh_billdetcol,ryh_doccode) values  ( @idryh_sumdet,@ryh_billcol,@ryh_type, @ryh_sum, @ryh_sumshare,@ryh_bank,@ryh_bankid,@ryh_date,@ryh_date1,@ryh_banksub , @ryh_billdetcol,@ryh_doccode);SELECT LAST_INSERT_ID();"
            mySqlCommand.Connection = mysql
            mySqlCommand.Parameters.AddWithValue("@idryh_sumdet", DataGridViewX1.Rows(intbindex).Cells(5).Value)
            mySqlCommand.Parameters.AddWithValue("@ryh_billcol", "")
            mySqlCommand.Parameters.AddWithValue("@ryh_type", stringtype)
            mySqlCommand.Parameters.AddWithValue("@ryh_sum", TextBox11.Text)
            mySqlCommand.Parameters.AddWithValue("@ryh_sumshare", LabelX4.Text)
            mySqlCommand.Parameters.AddWithValue("@ryh_bank", TextBox5.Text)
            mySqlCommand.Parameters.AddWithValue("@ryh_bankid", TextBox7.Text)
            Dim date1 As Date
            date1 = DateTimePicker1.Value
            mySqlCommand.Parameters.AddWithValue("@ryh_date", date1.Year.ToString + date1.ToString("-MM-dd"))
            date1 = DateTimePicker2.Value
            mySqlCommand.Parameters.AddWithValue("@ryh_date1", date1.Year.ToString + date1.ToString("-MM-dd"))
            mySqlCommand.Parameters.AddWithValue("@ryh_banksub", TextBox6.Text)
            mySqlCommand.Parameters.AddWithValue("@ryh_billdetcol", 0)
            mySqlCommand.Parameters.AddWithValue("@ryh_doccode", doccode)

            idlast = mySqlCommand.ExecuteScalar()

            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Dim commandtext2 As String
            Try
                commandtext2 = "UPDATE ryh_sumdetail SET checkryh = '1'  WHERE idryh_sumdetail = " & DataGridViewX1.Rows(intbindex).Cells(5).Value & "; "
                mySqlCommand.CommandText = commandtext2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try








        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub savedata()
        Dim stringtype As String
        callculate_sum()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        If TextBox9.Text.Trim = "" Then
            MsgBox("กรุณาเลือกงวดที่ชำระ")
            Exit Sub
        End If

        Try


            If RadioButton1.Checked = True Then
                stringtype = "โอน"
            ElseIf RadioButton2.Checked = True Then
                stringtype = "เช็ค"
            ElseIf RadioButton3.Checked = True Then
                stringtype = "เงินสด"
            End If
            mySqlCommand.Parameters.Clear()
            'mySqlCommand.CommandText = "insert into thungsong_bill ( idname,thungsong_billcol,thungsong_type, thungsong_sum, thungsong_sumshare,thungsong_bank,thungsong_bankid,thungsong_date,thungsong_date1,thungsong_banksub) values  ( @idname,@thungsong_billcol,@thungsong_type, @thungsong_sum, @thungsong_sumshare,@thungsong_bank,@thungsong_bankid,@thungsong_date,@thungsong_date1,@thungsong_banksub);SELECT LAST_INSERT_ID();"
            'mySqlCommand.Connection = mysql
            'mySqlCommand.Parameters.AddWithValue("@idname", frmmain_thungsong.idkey)
            'mySqlCommand.Parameters.AddWithValue("@thungsong_billcol", "")
            'mySqlCommand.Parameters.AddWithValue("@thungsong_type", stringtype)
            'mySqlCommand.Parameters.AddWithValue("@thungsong_sum", LabelX1.Text)
            'mySqlCommand.Parameters.AddWithValue("@thungsong_sumshare", LabelX4.Text)
            'mySqlCommand.Parameters.AddWithValue("@thungsong_bank", TextBox5.Text)
            'mySqlCommand.Parameters.AddWithValue("@thungsong_bankid", TextBox7.Text)
            'mySqlCommand.Parameters.AddWithValue("@thungsong_date", DateTimePicker1.Value.ToString("dd-MM-yyyy"))
            'mySqlCommand.Parameters.AddWithValue("@thungsong_date1", DateTimePicker2.Value.ToString("dd-MM-yyyy"))
            'mySqlCommand.Parameters.AddWithValue("@thungsong_banksub", TextBox6.Text)
            'idlast = mySqlCommand.ExecuteScalar()



            mySqlCommand.CommandText = "insert into thungsong_rec ( thungsong_type,thungsong_sum,thungsong_sumshare, thungsong_bank, thungsong_bankid,thungsong_banksub,thungsong_date,thungsong_date1,idthungsong_round) values  ( @thungsong_type,@thungsong_sum,@thungsong_sumshare, @thungsong_bank, @thungsong_bankid,@thungsong_banksub,@thungsong_date,@thungsong_date1,@idthungsong_round);SELECT LAST_INSERT_ID();"

            mySqlCommand.Connection = mysql

            mySqlCommand.Parameters.AddWithValue("@thungsong_type", stringtype)
            mySqlCommand.Parameters.AddWithValue("@thungsong_sum", TextBox11.Text)
            mySqlCommand.Parameters.AddWithValue("@thungsong_sumshare", CInt(TextBox11.Text) * 0.1)
            mySqlCommand.Parameters.AddWithValue("@thungsong_bank", TextBox5.Text)
            mySqlCommand.Parameters.AddWithValue("@thungsong_bankid", TextBox7.Text)
            mySqlCommand.Parameters.AddWithValue("@thungsong_date", DateTimePicker1.Value.Year.ToString + DateTimePicker1.Value.ToString("-MM-dd"))
            mySqlCommand.Parameters.AddWithValue("@thungsong_date1", DateTimePicker2.Value.Year.ToString + DateTimePicker2.Value.ToString("-MM-dd"))
            mySqlCommand.Parameters.AddWithValue("@thungsong_banksub", TextBox6.Text)
            mySqlCommand.Parameters.AddWithValue("@idthungsong_round", Convert.ToString(TextBox9.Tag))
            idlast = mySqlCommand.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        Dim commandText2 As String


        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Try
            commandText2 = "UPDATE thungsong_round SET thungsong_rundstat = '1'   WHERE idthungsong_round = " & DataGridViewX1.Rows(intbindex).Cells(5).Value & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





    End Sub
    Dim suffix() As String = {"", "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน"}
    Dim numSpeak() As String = {"", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}


    Public Function ThaiBahtText(ByVal m As Double) As String

        Dim s1 As String = ""    ' ---- ส่วนที่เกินหลักล้านขึ้นไป  (ล้าน)
        Dim s2 As String = ""    ' ---- ส่วนจำนวนเต็ม              (บาท)
        Dim s3 As String = ""   ' ---- ส่วนสตางค์                 (สตางค์)
        Dim result As New System.Text.StringBuilder
        If (m = 0) Then Return ("ศูนย์บาท") ' ---- ศูนย์บาทถ้วน ???
        splitCurr(m, s1, s2, s3)            ' now 'm' split to 3 parts in 's1' & 's2' & 's3'
        If (s1.Length > 0) Then result.Append(Speak(s1) & "ล้าน")
        If (s2.Length > 0) Then result.Append(Speak(s2) & "บาท")
        If (s3.Length > 0) Then
            result.Append(speakStang(s3) & "สตางค์")
        Else
            result.Append("ถ้วน")
        End If
        Return (result.ToString)
    End Function
    Private Function Speak(ByVal s As String) As String
        Dim c As Integer
        Dim result As New System.Text.StringBuilder
        Dim L As Integer
        If (s.Length = 0) Then Return ("")
        L = s.Length
        For i As Integer = 1 To L
            If (s.Chars(i - 1) = "-") Then
                result.Append("ติดลบ")
            Else
                c = Val(s.Chars(i - 1))
                If ((i = L) And (c = 1)) Then
                    If (L = 1) Then
                        Return ("หนึ่ง")
                    End If
                    If (L > 1) And (s.Chars(L - 2) = "0") Then
                        result.Append("หนึ่ง")
                    Else
                        result.Append("เอ็ด")
                    End If
                ElseIf ((i = L - 1) And (c = 2)) Then
                    result.Append("ยี่สิบ")
                ElseIf ((i = L - 1) And (c = 1)) Then
                    result.Append("สิบ")
                Else
                    If (c <> 0) Then
                        result.Append(numSpeak(c) & suffix(L - i + 1))
                    End If
                End If
            End If
        Next
        Return (result.ToString())
    End Function
    Private Function speakStang(ByVal s As String) As String
        Dim i, L As Integer
        Dim c As Integer
        Dim result As New System.Text.StringBuilder
        L = s.Length
        If (L = 0) Then Return ("")
        If (L = 1) Then s = s & "0" : L = 2
        If (L > 2) Then s = s.Substring(0, 2) : L = 2
        For i = 1 To 2
            c = Val(s.Chars(i - 1)) ' --- CInt(Mid$(s, i, 1))
            If ((i = L) And (c = 1)) Then
                If (CInt(Mid$(s, 1, 1)) = 0) Then
                    result.Append("หนึ่ง")
                Else
                    result.Append("เอ็ด")
                End If
            ElseIf ((i = L - 1) And (c = 2)) Then
                result.Append("ยี่สิบ")
            ElseIf ((i = L - 1) And (c = 1)) Then
                result.Append("สิบ")
            Else
                If (c <> 0) Then
                    result.Append(numSpeak(c) & suffix(2 - i + 1))
                End If
            End If
        Next
        Return (result.ToString())
    End Function
    Private Sub splitCurr(ByVal m As Double,
            ByRef s1 As String,
            ByRef s2 As String,
            ByRef s3 As String)
        Dim s As String
        Dim L, position As Integer
        s = CStr(m)
        position = s.IndexOf(".") + 1 ' --- InStr( 1, s, ".")
        If (position <> 0) Then
            'this currency have a point
            s1 = s.Substring(0, position - 1) '  Mid$(s, 1, position - 1)
            s3 = s.Substring(position) '  Mid$(s, position + 1, 2)
            If s3 = "00" Then s3 = ""
        Else
            s1 = s
            s3 = ""
        End If
        L = s1.Length
        If (L > 6) Then
            s2 = s1.Substring(L - 5 - 1) ' --- Mid$(s1, L - 5, 99)
            s1 = s1.Substring(0, L - 6) '  Mid$(s1, 1, L - 6)
        Else
            s2 = s1
            s1 = ""
        End If
        If (Not IsNumeric(s1)) Then s1 = ""
        If (Not IsNumeric(s2)) Then s2 = ""
        If (Val(s1) = 0) Then s1 = ""
        If (Val(s2) = 0) Then s2 = ""
    End Sub
    Public Sub updateTHUNGSONG()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim commandText2 As String


        Try
            commandText2 = "UPDATE thungsongdb SET name2 = '" & TextBox1.Text & "' ,  idcardname ='" & TextBox4.Text & "',  address ='" & TextBox2.Text & "',tell ='" & TextBox8.Text & "' WHERE idthungsongDB = " & frmmain_thungsong.idkey & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '  Me.Close()
    End Sub
    Public Sub updateRAJYINDEE()

        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim commandText2 As String


        Try
            commandText2 = "UPDATE ryh_main SET name = '" & TextBox1.Text & "' ,  IDCARD ='" & TextBox4.Text & "',  address ='" & TextBox2.Text & "',tell ='" & TextBox8.Text & "' WHERE idryh_main = " & frmmain_thungsong.idkey & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
            updateTHUNGSONG()
        ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then
            updateRAJYINDEE()
        End If
    End Sub
End Class
Module GENDOC

    Public Function getIDform(ByVal menuname As String) As String
        Dim sql As String
        Dim dt As New DataTable
        Dim sql1 As String
        Dim condb As ConnecDBRYH
        condb = ConnecDBRYH.NewConnection

        Try
            sql1 = "UPDATE mascmrunning SET isrunning=isrunning+1  WHERE menuname ='" & menuname & "';"
            condb.ExecuteNonQuery(sql1)
            sql = "SELECT * FROM mascmrunning WHERE menuname ='" & menuname & "';"
            Dim USCulture As New System.Globalization.CultureInfo("en-US", True)
            Dim THculture As New System.Globalization.CultureInfo("th-TH", True)

            dt = condb.GetTable(sql)
            Dim docno As String
            docno = If(IsDBNull(dt.Rows(0)("prefixchar")), "", dt.Rows(0)("prefixchar"))
            docno += If(IsDBNull(dt.Rows(0)("showyear")), Date.Now.ToString(dt.Rows(0)("formatdate"), THculture), Date.Now.ToString(dt.Rows(0)("formatdate"), USCulture)) 'set database mascmrunning showyear null = thai  format , 1 = eng format
            docno += If(IsDBNull(dt.Rows(0)("separatechar")), "", dt.Rows(0)("separatechar"))

            Dim countchar As Integer
            Dim isruning As String
            countchar = dt.Rows(0)("countchar")
            isruning = dt.Rows(0)("isrunning")
            For i = 0 To countchar - isruning.Length - 1
                docno += "0"
            Next
            docno += dt.Rows(0)("isrunning").ToString
            Return docno
            '  MsgBox(docno)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

End Module
