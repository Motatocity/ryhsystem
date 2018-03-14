Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class frmrpt_bill
    Dim mysql As MySqlConnection = frmmain_thungsong.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim rpt1 As New bill_check
    Dim rpt2 As New bill_checkryh
    Dim ci As New CultureInfo("en-us")
    Private Sub frmrpt_bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim nfi As New System.Globalization.NumberFormatInfo()

        nfi.CurrencyDecimalDigits = 0

        nfi.CurrencySymbol = "$"
        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            '   mySqlCommand.CommandText = "SELECT * FROM thungsong_bill join  thungsongdb on thungsongdb.idthungsongDB = thungsong_bill.idname  where idthungsong_bill = '" & frmcheck_bill.idlast & "' ;"

            mySqlCommand.CommandText = "SELECT * FROM thungsong_rec left join    thungsong_round ON thungsong_rec.idthungsong_round = thungsong_round.idthungsong_round    left join thungsongdb on thungsongdb.idthungsongDB = thungsong_round.thungsong_roundbill  where IDTHUNGSONGBILL = '" & frmcheck_bill.idlast & "' ;"


            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    rpt1.SetParameterValue("idkey", Format(mySqlReader("IDTHUNGSONGBILL"), "0000"))
                    Dim string1 As String = mySqlReader("thungsong_date")
                
                    Dim arr() As String = string1.Split("/")
                    If CInt(arr(2)) > 2300 Then
                        arr(2) = arr(2) - 543
                    End If


                    rpt1.SetParameterValue("datename1", arr(0) & "/" & arr(1) & "/" & arr(2))
                    string1 = mySqlReader("thungsong_date1")
                    arr = string1.Split("/")
                    If CInt(arr(2)) > 2300 Then
                        arr(2) = arr(2) - 543
                    End If
                    rpt1.SetParameterValue("datename", arr(0) & "/" & arr(1) & "/" & arr(2))
                    rpt1.SetParameterValue("nameuser", mySqlReader("name2"))
                    rpt1.SetParameterValue("nameaddress", mySqlReader("address").ToString.Trim)
                    rpt1.SetParameterValue("nameid", mySqlReader("idcardname"))
                    rpt1.SetParameterValue("nameshare", CInt(mySqlReader("thungsong_sumshare")).ToString("N0", ci))
                    rpt1.SetParameterValue("nameprice", " ")
                    If mySqlReader("thungsong_type").ToString = "�Թʴ" Then
                        rpt1.SetParameterValue("price_1", mySqlReader("thungsong_sum"))
                        rpt1.SetParameterValue("pricename1", frmcheck_bill.thaitext)

                        rpt2.SetParameterValue("namecheck", " ")
                        rpt2.SetParameterValue("price", " ")
                        rpt2.SetParameterValue("pricename", " ")


                    Else
                        rpt1.SetParameterValue("namecheck", mySqlReader("thungsong_type"))
                        rpt1.SetParameterValue("price", mySqlReader("thungsong_sum"))
                        rpt1.SetParameterValue("pricename", frmcheck_bill.thaitext)

                        rpt1.SetParameterValue("price_1", "")
                        rpt1.SetParameterValue("pricename1", "")

                    End If

                    rpt1.SetParameterValue("bank", mySqlReader("thungsong_bank"))
                    rpt1.SetParameterValue("banksub", mySqlReader("thungsong_banksub"))
                    rpt1.SetParameterValue("bankid", mySqlReader("thungsong_bankid"))
                    rpt1.SetParameterValue("nameage", frmcheck_bill.age)


                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()






















            CrystalReportViewer1.ReportSource = rpt1
            CrystalReportViewer1.Refresh()




        ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "SELECT *   FROM ryh_main JOIN ryh_sumdetail  ON ryh_main.idryh_main = ryh_sumdetail.idryh_main JOIN ryh_billdet ON ryh_sumdetail.idryh_sumdetail = ryh_billdet.idryh_sumdet   where idryh_billdet  = '" & frmcheck_bill.idlast & "' ;"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    '   rpt2.SetParameterValue("idkey", Format(mySqlReader("idryh_billdet"), "0000"))
                    rpt2.SetParameterValue("idkey", mySqlReader("ryh_doccode"))

                    Dim string1 As Date = mySqlReader("ryh_date")


                    rpt2.SetParameterValue("datename1", string1.ToString("dd-MM-yyyy"))



                    string1 = mySqlReader("ryh_date1")
                    '   arr = string1.Split("-")
                    'If CInt(arr(2)) > 2300 Then
                    '    arr(2) = arr(2) - 543
                    'End If
                    rpt2.SetParameterValue("datename", string1.ToString("dd-MM-yyyy"))



  

                    rpt2.SetParameterValue("nameuser", mySqlReader("name"))
                    rpt2.SetParameterValue("nameaddress", mySqlReader("address").ToString.Trim)
                    rpt2.SetParameterValue("nameid", mySqlReader("IDCARD"))
                    rpt2.SetParameterValue("nameshare", "  ")
                    rpt2.SetParameterValue("nameshare", CInt(mySqlReader("ryh_sumshare")).ToString("N0", ci))
                    rpt2.SetParameterValue("nameprice", " ")
                    If mySqlReader("ryh_type").ToString = "�Թʴ" Then
                        rpt2.SetParameterValue("price_1", mySqlReader("ryh_sum"))
                        rpt2.SetParameterValue("pricename1", frmcheck_bill.thaitext)
                        rpt2.SetParameterValue("namecheck", "   ")
                        rpt2.SetParameterValue("price", "           ")
                        rpt2.SetParameterValue("pricename", "              ")


                    Else
                        rpt2.SetParameterValue("namecheck", mySqlReader("ryh_type"))
                        rpt2.SetParameterValue("price", mySqlReader("ryh_sum"))
                        rpt2.SetParameterValue("pricename", frmcheck_bill.thaitext)

                        rpt2.SetParameterValue("price_1", "          ")
                        rpt2.SetParameterValue("pricename1", "               ")



                    End If

                    rpt2.SetParameterValue("bank", mySqlReader("ryh_bank"))
                    rpt2.SetParameterValue("banksub", mySqlReader("ryh_banksub"))
                    rpt2.SetParameterValue("bankid", mySqlReader("ryh_bankid"))
                    rpt2.SetParameterValue("nameage", frmcheck_bill.age)


                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()



            CrystalReportViewer1.ReportSource = rpt2
            CrystalReportViewer1.Refresh()




        End If
    End Sub



End Class