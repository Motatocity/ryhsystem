Imports MySql.Data.MySqlClient

Public Class IMPORTCLASS
    Private filePath As String = "" 'ที่เก็บไฟล์
    Private sheetName As String = "" 'ชื่อ Sheet ใน Excel
    Private tableName As String = "" ' ชื่อ table ใน database

    Public Sub New(ByVal tableNameInDatabase As String)
        Me.tableName = "myfriendsdb." & tableNameInDatabase
    End Sub

    Public Function ExcelOpen(ByVal filePath As String, ByVal sheetName As String) As DataTable
        Try
            Dim connstr As String = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" & filePath & ";"
            Dim conn As New Odbc.OdbcConnection(connstr)
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim strSQL As String = "SELECT * FROM [" & sheetName & "$]"
            Dim cmd As New Odbc.OdbcCommand(strSQL, conn)
            Dim dt As New DataTable()
            Dim dr As Odbc.OdbcDataReader
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dt.Load(dr)
            End If
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'version แรก
    Public Sub UPDATE(ByVal dgv As DataGridView)
        Dim PRI As String = getPK()

        Try
            'Gen Column In Table -------------------------------------------------------------------------
            Dim sql As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                If DuplicateCheck(dgv.Rows(i).Cells(PRI).Value.ToString.Trim()) = True Then
                    sql += "UPDATE " & tableName & " SET  "
                    For j As Integer = 0 To dgv.Columns.Count - 1
                        If dgv.Columns(j).Name.Trim <> PRI Then
                            sql += dgv.Columns(j).Name & " = '" & dgv.Rows(i).Cells(j).Value.ToString.Trim & "'"
                            If j <> dgv.Columns.Count - 1 Then
                                sql += ","
                            End If
                        End If
                    Next j
                    sql += "WHERE(" & PRI & "  = '" & dgv.Rows(i).Cells(PRI).Value.ToString.Trim & "' );"
                    dgv.Rows.RemoveAt(i)
                Else
                    dgv.Rows(i).Cells(PRI).ErrorText = "มีข้อมูลนี้ยังไม่มีในระบบ"
                End If
            Next i
            ' Insert SQL --------------------------------------------------------------------------
            If sql.Trim <> "" Then
                Dim db = ConnecDBRYH.NewConnection
                db.BeginTrans()
                Try
                    db.ExecuteNonQuery(sql)
                    db.CommitTrans()
                    MsgBox("แก้ใขสำเร็จ")
                Catch ex As Exception
                    db.RollbackTrans()
                    MsgBox("ไม่สามารถแก้ใขได้เนื่องจาก : " & ex.Message)
                Finally
                    db.Dispose()
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Insert(ByVal dgv As DataGridView)
        Try
            'Gen Column In Table -----------------------------------------------------------------------
            Dim a As Integer = 0
            Dim sql As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            Dim db = ConnecDBRYH.NewConnection
            db.BeginTrans()
            Try
                For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                    sql = " INSERT INTO " & tableName & " ("
                    sql += strCol
                    sql += ") VALUES("
                    For j As Integer = 0 To dgv.Columns.Count - 1
                        sql += "'" & MySqlHelper.EscapeString(dgv.Rows(i).Cells(j).Value.ToString.Trim) & "'"
                        If j <> dgv.Columns.Count - 1 Then
                            sql += ","
                        End If
                    Next j
                    sql += ");"
                    dgv.Rows.RemoveAt(i)

                    ' Insert SQL --------------------------------------------------------------------------
                    If sql.Trim <> "" Then
                        db.ExecuteNonQuery(sql)
                    End If

                    If (a = 1000) Then
                        db.CommitTrans()
                        db.Dispose()
                        db = ConnecDBRYH.NewConnection
                        db.BeginTrans()
                        a = 0
                    ElseIf dgv.Rows.Count = 0 Then
                        db.CommitTrans()
                        db.Dispose()
                    End If
                    a += 1
                Next i

                MsgBox("บันทึกสำเร็จ")
            Catch ex As Exception
                db.RollbackTrans()
                MsgBox("ไม่สามารถบันทึกได้เนื่องจาก : " & ex.Message)
            Finally
                db.Dispose()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertXrayItem(ByVal dgv As DataGridView)
        Dim FKIndex As Integer = 0 'ลำดับตัวเลขของคีย์คู่แข่ง
        Dim FKey As String = "PRDCODE" 'คีย์คู่แข่งที่จะใช้
        Dim PRDKey As String = "" 'คีย์ที่ได้จากตาราง MasProduct
        Dim db = ConnecDBRYH.NewConnection
        db.BeginTrans()
        Try
            'Gen Column In Table -------------------------------------------------------------------------
            Dim sql As String = ""
            Dim sql2 As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Name.Trim = FKey Then
                    FKIndex = c
                End If
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                'InMasPeoduct
                sql2 = "INSERT INTO myfriendsdb.masproduct(PRDNAME,PRDCAT) VALUES("
                sql2 += "'" & dgv.Rows(i).Cells("XRYENAME").Value.ToString.Trim & "',4);"
                sql2 += "SELECT LAST_INSERT_ID();"
                PRDKey = db.ExecuteScalar(sql2)
                'Insert XrayItem
                sql += "INSERT INTO " & tableName & " ("
                sql += strCol
                sql += ") VALUES("
                For j As Integer = 0 To dgv.Columns.Count - 1
                    If j = FKIndex Then
                        sql += "'" & PRDKey & "'"
                    Else
                        If dgv.Columns(j).Name.Trim = "CXRYID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "SXRYID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "PXRYID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "CHKIN" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "STTDATE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "EXPDATE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "COST" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "STATUS" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        Else
                            sql += "'" & dgv.Rows(i).Cells(j).Value.ToString.Trim & "'"
                        End If
                    End If
                    If j <> dgv.Columns.Count - 1 Then
                        sql += ","
                    End If
                Next j
                sql += ");"
                dgv.Rows.RemoveAt(i)
            Next i
            ' Insert SQL --------------------------------------------------------------------------
            db.ExecuteNonQuery(sql)
            db.CommitTrans()
            MsgBox("บันทึกสำเร็จ")
        Catch ex As Exception
            db.RollbackTrans()
            MsgBox("ไม่สามารถบันทึกได้เนื่องจาก : " & ex.Message)
        Finally
            db.Dispose()
        End Try

    End Sub
    Public Sub InsertOperatitem(ByVal dgv As DataGridView)
        Dim FKIndex As Integer = 0 'ลำดับตัวเลขของคีย์คู่แข่ง
        Dim FKey As String = "PRDCODE" 'คีย์คู่แข่งที่จะใช้
        Dim PRDKey As String = "" 'คีย์ที่ได้จากตาราง MasProduct
        Dim db = ConnecDBRYH.NewConnection
        db.BeginTrans()
        Try
            'Gen Column In Table -------------------------------------------------------------------------
            Dim sql As String = ""
            Dim sql2 As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Name.Trim = FKey Then
                    FKIndex = c
                End If
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                'InMasPeoduct
                sql2 = "INSERT INTO myfriendsdb.masproduct(PRDNAME,PRDCAT) VALUES("
                sql2 += "'" & dgv.Rows(i).Cells("OPERATENAME_EN").Value.ToString.Trim & "',3);"
                sql2 += "SELECT LAST_INSERT_ID();"
                PRDKey = db.ExecuteScalar(sql2)
                'Insert XrayItem
                sql += "INSERT INTO " & tableName & " ("
                sql += strCol
                sql += ") VALUES("
                For j As Integer = 0 To dgv.Columns.Count - 1
                    If j = FKIndex Then
                        sql += "'" & PRDKey & "'"
                    Else
                        If dgv.Columns(j).Name.Trim = "CHKIN" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "STTDATE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "EXPDATE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "COST" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "STATUS" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        Else
                            sql += "'" & dgv.Rows(i).Cells(j).Value.ToString.Trim & "'"
                        End If
                    End If
                    If j <> dgv.Columns.Count - 1 Then
                        sql += ","
                    End If
                Next j
                sql += ");"
                dgv.Rows.RemoveAt(i)
            Next i
            ' Insert SQL --------------------------------------------------------------------------
            db.ExecuteNonQuery(sql)
            db.CommitTrans()
            MsgBox("บันทึกสำเร็จ")
        Catch ex As Exception
            db.RollbackTrans()
            MsgBox("ไม่สามารถบันทึกได้เนื่องจาก : " & ex.Message)
        Finally
            db.Dispose()
        End Try

    End Sub
    Public Sub InsertLab_order(ByVal dgv As DataGridView)
        Dim FKIndex As Integer = 0 'ลำดับตัวเลขของคีย์คู่แข่ง
        Dim FKey As String = "PRDCODE" 'คีย์คู่แข่งที่จะใช้
        Dim PRDKey As String = "" 'คีย์ที่ได้จากตาราง MasProduct
        Dim db = ConnecDBRYH.NewConnection
        db.BeginTrans()
        Try
            'Gen Column In Table -------------------------------------------------------------------------
            Dim sql As String = ""
            Dim sql2 As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Name.Trim = FKey Then
                    FKIndex = c
                End If
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                'InMasPeoduct
                sql2 = "INSERT INTO myfriendsdb.masproduct(PRDNAME,PRDCAT) VALUES("
                sql2 += "'" & dgv.Rows(i).Cells("NAME").Value.ToString.Trim & "',5);"
                sql2 += "SELECT LAST_INSERT_ID();"
                PRDKey = db.ExecuteScalar(sql2)
                'Insert XrayItem
                sql += "INSERT INTO " & tableName & " ("
                sql += strCol
                sql += ") VALUES("
                For j As Integer = 0 To dgv.Columns.Count - 1
                    If j = FKIndex Then
                        sql += "'" & PRDKey & "'"
                    Else
                        If dgv.Columns(j).Name.Trim = "LAB_GROUP_CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "PRINT_BARCODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "TAT_LIMIT_DAY" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "TAT_LIMIT_HOUR" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "TAT_LIMIT_MIN" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "STATUS" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "CANCEL_ORDER" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        Else
                            sql += "'" & dgv.Rows(i).Cells(j).Value.ToString.Trim & "'"
                        End If
                    End If
                    If j <> dgv.Columns.Count - 1 Then
                        sql += ","
                    End If
                Next j
                sql += ");"
                dgv.Rows.RemoveAt(i)
            Next i
            ' Insert SQL --------------------------------------------------------------------------
            db.ExecuteNonQuery(sql)
            db.CommitTrans()
            MsgBox("บันทึกสำเร็จ")
        Catch ex As Exception
            db.RollbackTrans()
            MsgBox("ไม่สามารถบันทึกได้เนื่องจาก : " & ex.Message)
        Finally
            db.Dispose()
        End Try

    End Sub

    Public Sub InsertDrugitem(ByVal dgv As DataGridView)
        Dim FKIndex As Integer = 0 'ลำดับตัวเลขของคีย์คู่แข่ง
        Dim FKey As String = "PRDCODE" 'คีย์คู่แข่งที่จะใช้
        Dim PRDKey As String = "" 'คีย์ที่ได้จากตาราง MasProduct
        Dim db = ConnecDBRYH.NewConnection
        db.BeginTrans()
        Try
            'Gen Column In Table -------------------------------------------------------------------------
            Dim sql As String = ""
            Dim sql2 As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Name.Trim = FKey Then
                    FKIndex = c
                End If
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                'InMasPeoduct
                sql2 = "INSERT INTO myfriendsdb.masproduct(PRDNAME,PRDCAT) VALUES("
                sql2 += "'" & dgv.Rows(i).Cells("GENERICNAME").Value.ToString.Trim & "',1);"
                sql2 += "SELECT LAST_INSERT_ID();"
                PRDKey = db.ExecuteScalar(sql2)
                'Insert XrayItem
                sql += "INSERT INTO " & tableName & " ("
                sql += strCol
                sql += ") VALUES("
                For j As Integer = 0 To dgv.Columns.Count - 1
                    If j = FKIndex Then
                        sql += "'" & PRDKey & "'"
                    Else
                        If dgv.Columns(j).Name.Trim = "GDCODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "DACCCODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "ATCL1CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "ATCL2CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "ATCL3CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "ATCL4CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "ATCL5CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "ATC" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "DFORM" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "DGTYID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "INTEN" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "DRGMID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "DRGLIST" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "GENERICNAME" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "TRADENAME" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "DLABEL" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "REMARK" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "KEEPID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "LOCATION" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "STATUS" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "MAXLV" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "MINLV" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "AVGUSE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "REORDER" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "KWORD" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        Else
                            sql += "'" & dgv.Rows(i).Cells(j).Value.ToString.Trim & "'"
                        End If
                    End If
                    If j <> dgv.Columns.Count - 1 Then
                        sql += ","
                    End If
                Next j
                sql += ");"
                dgv.Rows.RemoveAt(i)
            Next i
            ' Insert SQL --------------------------------------------------------------------------
            db.ExecuteNonQuery(sql)
            db.CommitTrans()
            MsgBox("บันทึกสำเร็จ")
        Catch ex As Exception
            db.RollbackTrans()
            MsgBox("ไม่สามารถบันทึกได้เนื่องจาก : " & ex.Message)
        Finally
            db.Dispose()
        End Try
    End Sub
    Public Sub Insertmedsupplyitem(ByVal dgv As DataGridView)
        Dim FKIndex As Integer = 0 'ลำดับตัวเลขของคีย์คู่แข่ง
        Dim FKey As String = "PRDCODE" 'คีย์คู่แข่งที่จะใช้
        Dim PRDKey As String = "" 'คีย์ที่ได้จากตาราง MasProduct
        Dim db = ConnecDBRYH.NewConnection
        db.BeginTrans()
        Try
            'Gen Column In Table -------------------------------------------------------------------------
            Dim sql As String = ""
            Dim sql2 As String = ""
            Dim strCol As String = ""
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Name.Trim = FKey Then
                    FKIndex = c
                End If
                strCol += dgv.Columns(c).Name
                If c <> dgv.Columns.Count - 1 Then
                    strCol += ","
                End If
            Next c
            'Gen SQL  ---------------------------------------------------------------------------
            dgv.AllowUserToAddRows = False
            For i As Integer = dgv.Rows.Count - 1 To 0 Step -1
                'InMasPeoduct
                sql2 = "INSERT INTO myfriendsdb.masproduct(PRDNAME,PRDCAT) VALUES("
                sql2 += "'" & dgv.Rows(i).Cells("MSUPENAME").Value.ToString.Trim & "',2);"
                sql2 += "SELECT LAST_INSERT_ID();"
                PRDKey = db.ExecuteScalar(sql2)
                'Insert XrayItem
                sql += "INSERT INTO " & tableName & " ("
                sql += strCol
                sql += ") VALUES("
                For j As Integer = 0 To dgv.Columns.Count - 1
                    If j = FKIndex Then
                        sql += "'" & PRDKey & "'"
                    Else
                        If dgv.Columns(j).Name.Trim = "CMSUPID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "GMSUPID" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "CODE" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "COST" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "NULL"
                        ElseIf dgv.Columns(j).Name.Trim = "STATUS" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        ElseIf dgv.Columns(j).Name.Trim = "CHKIN" And dgv.Rows(i).Cells(j).Value.ToString.Trim = "" Then
                            sql += "1"
                        Else
                            sql += "'" & dgv.Rows(i).Cells(j).Value.ToString.Trim & "'"
                        End If
                    End If
                    If j <> dgv.Columns.Count - 1 Then
                        sql += ","
                    End If
                Next j
                sql += ");"
                dgv.Rows.RemoveAt(i)
            Next i
            ' Insert SQL --------------------------------------------------------------------------
            db.ExecuteNonQuery(sql)
            db.CommitTrans()
            MsgBox("บันทึกสำเร็จ")
        Catch ex As Exception
            db.RollbackTrans()
            MsgBox("ไม่สามารถบันทึกได้เนื่องจาก : " & ex.Message)
        Finally
            db.Dispose()
        End Try

    End Sub
    Private Function DuplicateCheck(ByVal pkValue As String) As Boolean
        Dim pkName As String 'ตัวแปรชื่อ Primarykey
        pkName = getPK() 'เรียกฟังชั่นหา Primarykey

        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Dim sql As String = "SELECT " & pkName & " FROM " & tableName & " WHERE(" & pkName & " = '" & pkValue & "');"
        dt = db.GetTable(sql)
        db.Dispose()
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function getColumn() As DataTable 'ฟังชั่นหา Column ใน Table
        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Dim sql As String = "SHOW COLUMNS FROM " & tableName & " WHERE(`Key` <> 'PRI');"
        dt = db.GetTable(sql)
        db.Dispose()
        Return dt
    End Function

    Private Function getColumnWithPk() As DataTable 'ฟังชั่นหา Column ใน Table
        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Dim sql As String = "SHOW COLUMNS FROM " & tableName & ");"
        dt = db.GetTable(sql)
        db.Dispose()
        Return dt
    End Function

    Private Function getPK() As String 'ฟังชั่นหา Primarykey
        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Dim sql As String = "SHOW COLUMNS FROM " & tableName & " WHERE(`KEY` = 'PRI') ;"
        dt = db.GetTable(sql)
        db.Dispose()
        Return dt.Rows(0)("Field").ToString.Trim
    End Function
End Class
