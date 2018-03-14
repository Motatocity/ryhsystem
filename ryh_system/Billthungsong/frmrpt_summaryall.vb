Public Class frmrpt_summaryall

    Private Sub frmrpt_summaryall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim check As String
        If RadioButton1.Checked = True Then
            check = "0"
            sql = "SELECT ryh_main.name  as name , SUM( ryh_sumdetail.sum ) as TOTAL ,  (SUM( ryh_sumdetail.sum ) * 1.5 ) as SUMBATH ,  MAX(CASE WHEN count = '1' and checkryh = '1' THEN ryh_billdet.ryh_sum ELSE 0 END) ROUND1 , MAX(CASE WHEN count = '1'  THEN ROUND(ryh_sumdetail.sum*1.5) ELSE 0 END)  as ROUNDS1  ,  MAX(CASE WHEN count = '1' and checkryh = '1' THEN ryh_billdet.ryh_sum ELSE 0 END) ROUND1  , MAX(CASE WHEN count = '2'  THEN  ROUND(ryh_sumdetail.sum*1.5) ELSE 0 END)  as ROUNDS2   , MAX(CASE WHEN count = '2' and checkryh = '1' THEN ryh_billdet.ryh_sum ELSE 0 END) ROUND2 , MAX(CASE WHEN count = '3' and checkryh = '1' THEN ryh_billdet.ryh_sum ELSE 0 END)  as ROUND3, MAX(CASE WHEN count = '3'  THEN ROUND(ryh_sumdetail.sum*1.5) ELSE 0 END)  as ROUNDS3  FROM rajyindee_db.ryh_main join  ryh_sumdetail  ON ryh_main.idryh_main =ryh_sumdetail.idryh_main   left join ryh_billdet ON ryh_billdet.idryh_sumdet = ryh_sumdetail.idryh_sumdetail group by  ryh_main.name "
        ElseIf RadioButton2.Checked = True Then
            check = "1"
            sql = "select  idthungsongDB , thungsongdb.name2 as name, thungsongdb.share as total , share , idcardname from thungsongdb left join (SELECT sum( CASE when thungsong_round.thungsong_rundstat ='1' then   thungsong_round.thungsong_rundsum  else   0 end) as  share ,  thungsong_roundbill thungsong_round ) as thungsong_round  on thungsongdb.idthungsongDB = thungsong_round.thungsong_roundbill  group by idthungsongDB ORDER BY total;"
            '  Dim set1 As DataSet = New DataSet("thungsong")
        End If
        If CheckBox1.Checked = True Then
            sql += " ORDER BY TOTAL DESC ;"
        Else
            sql += " ORDER BY  name DESC ;"
        End If


        Dim nextform As frmrpt_summary = New frmrpt_summary(sql, check)
        nextform.Show()
    End Sub
End Class