Imports MySql.Data.MySqlClient

Public Class frmreprint
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

    Private Sub frmreprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
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


            ' mySqlCommand.CommandText = "SELECT * FROM thungsong_bill where idname = '" & frmmain_thungsong.idkey & "' ;"
            mySqlCommand.CommandText = "SELECT * FROM thungsong_rec left join    thungsong_round ON thungsong_rec.idthungsong_round = thungsong_round.idthungsong_round    left join thungsongdb on thungsongdb.idthungsongDB = thungsong_round.thungsong_roundbill  where idthungsongDB = '" & frmmain_thungsong.idkey & "' ;"

            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    DataGridViewX1.Rows.Add({mySqlReader("IDTHUNGSONGBILL"), mySqlReader("thungsong_sumshare"), mySqlReader("thungsong_sum")})




                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()

        Else

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

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()




            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If


            ' mySqlCommand.CommandText = "SELECT * FROM thungsong_bill where idname = '" & frmmain_thungsong.idkey & "' ;"
            mySqlCommand.CommandText = "SELECT * FROM ryh_billdet left join    ryh_sumdetail ON ryh_billdet.idryh_sumdet = ryh_sumdetail.idryh_sumdetail   left join  ryh_main on ryh_main.idryh_main  = ryh_sumdetail.idryh_main  WHERE ryh_main.idryh_main = '" & frmmain_thungsong.idkey & "' and  ryh_billdetcol <> 1 ;"

            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    DataGridViewX1.Rows.Add({mySqlReader("idryh_billdet"), mySqlReader("ryh_sumshare"), mySqlReader("ryh_sum")})




                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()


        End If
    
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
    Private Sub splitCurr(ByVal m As Double, _
            ByRef s1 As String, _
            ByRef s2 As String, _
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

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        If DataGridViewX1.RowCount > 0 Then


            If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
                Try


                    intbindex = e.RowIndex



                    TextBox8.Text = DataGridViewX1.Rows(intbindex).Cells(0).Value

                    LabelX1.Text = DataGridViewX1.Rows(intbindex).Cells(2).Value

                    callculate_sum()


                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If


                    '    mySqlCommand.CommandText = "SELECT * FROM thungsong_bill where idthungsong_bill = '" & DataGridViewX1.Rows(intbindex).Cells(0).Value & "';"

                    mySqlCommand.CommandText = "SELECT * FROM thungsong_rec left join    thungsong_round ON thungsong_rec.idthungsong_round = thungsong_round.idthungsong_round    left join thungsongdb on thungsongdb.idthungsongDB = thungsong_round.thungsong_roundbill  where IDTHUNGSONGBILL = '" & DataGridViewX1.Rows(intbindex).Cells(0).Value & "' ;"

                    ' mySqlCommand.CommandText = 
                    mySqlCommand.Connection = mysql
                    mySqlAdaptor.SelectCommand = mySqlCommand
                    Try
                        mySqlReader = mySqlCommand.ExecuteReader
                        While (mySqlReader.Read())

                            If mySqlReader("thungsong_type") = "โอน" Then
                                RadioButton1.Checked = True
                            ElseIf mySqlReader("thungsong_type") = "เงินสด" Then
                                RadioButton3.Checked = True

                            Else
                                RadioButton2.Checked = True
                            End If

                            TextBox5.Text = mySqlReader("thungsong_bank")

                            TextBox7.Text = mySqlReader("thungsong_bankid")
                            TextBox6.Text = mySqlReader("thungsong_banksub")

                        End While
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    mysql.Close()
                Catch ex As Exception

                End Try
            Else


                intbindex = e.RowIndex



                TextBox8.Text = DataGridViewX1.Rows(intbindex).Cells(0).Value

                LabelX1.Text = DataGridViewX1.Rows(intbindex).Cells(2).Value

                callculate_sum()


                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If


                '    mySqlCommand.CommandText = "SELECT * FROM thungsong_bill where idthungsong_bill = '" & DataGridViewX1.Rows(intbindex).Cells(0).Value & "';"

                mySqlCommand.CommandText = "SELECT * FROM ryh_billdet   where idryh_billdet = '" & DataGridViewX1.Rows(intbindex).Cells(0).Value & "' ;"

                ' mySqlCommand.CommandText = 
                mySqlCommand.Connection = mysql
                mySqlAdaptor.SelectCommand = mySqlCommand
                Try
                    mySqlReader = mySqlCommand.ExecuteReader
                    While (mySqlReader.Read())

                        If mySqlReader("ryh_type") = "โอน" Then
                            RadioButton1.Checked = True
                        ElseIf mySqlReader("ryh_type") = "เงินสด" Then
                            RadioButton3.Checked = True

                        Else
                            RadioButton2.Checked = True
                        End If

                        TextBox5.Text = mySqlReader("ryh_bank")

                        TextBox7.Text = mySqlReader("ryh_bankid")
                        TextBox6.Text = mySqlReader("ryh_banksub")

                    End While
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                mysql.Close()



            End If



        End If





    End Sub
    Public Sub callculate_sum()
        Dim sumtotal As Integer = 0
        Dim sumbuy As Integer = 0



        Label17.Text = ThaiBahtText(CDbl(LabelX1.Text))
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Dim typebank As String
            Dim commandText2 As String

            If RadioButton1.Checked = True Then
                typebank = "โอน"
            End If
            If RadioButton2.Checked = True Then
                typebank = "เช็ค"
            End If
            If RadioButton3.Checked = True Then
                typebank = "เงินสด"
            End If

            Try
                commandText2 = "UPDATE thungsong_rec SET thungsong_type = '" & typebank & "' ,  thungsong_bank ='" & TextBox5.Text & "',  thungsong_bankid ='" & TextBox7.Text & "',thungsong_banksub ='" & TextBox6.Text & "' WHERE IDTHUNGSONGBILL = " & TextBox8.Text & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MsgBox("Update Complete")
        Else
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Dim typebank As String
            Dim commandText2 As String

            If RadioButton1.Checked = True Then
                typebank = "โอน"
            End If
            If RadioButton2.Checked = True Then
                typebank = "เช็ค"
            End If
            If RadioButton3.Checked = True Then
                typebank = "เงินสด"
            End If
            Try
                commandText2 = "UPDATE ryh_billdet SET ryh_type = '" & typebank & "' ,  ryh_bank ='" & TextBox5.Text & "',  ryh_bankid ='" & TextBox7.Text & "',ryh_banksub ='" & TextBox6.Text & "' WHERE idryh_billdet = " & TextBox8.Text & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MsgBox("Update Complete")
        End If
     
        ' Me.Close()

    End Sub


    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        age = TextBox3.Text
        idlast = TextBox8.Text
        thaitext = Label17.Text
        Try
            Dim nextform As frmrptbillreprint = New frmrptbillreprint
            nextform.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class