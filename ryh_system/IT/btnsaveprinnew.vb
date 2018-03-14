Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class btnsaveprinnew
    'ประกาศตัวแปรตัวเชื่อมต่อ
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Dim idkey1 As String
    Dim idkey2 As String
    Dim idkey3 As String
    Dim idkey4 As String
    Dim idkey5 As String
    Dim idkey6 As String
    Dim idkey7 As String
    Dim idkey8 As String
    Dim idkey9 As String
    Dim idkey10 As String
    Dim idstring() As String
    Dim idstring2() As String
    Dim idstring3() As String
    Private Sub EDIT_DEVICE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        mySqlCommand.CommandText = "SELECT * FROM data_device left join  location on data_device.idlocation = location.idlocation left join section on location.idsection =  section.idsection where type = 'Computer' order by iddata_device  DESC limit 50;"

        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewcom.Items.Clear()

            While (mySqlReader.Read())

                With ListViewcom.Items.Add(mySqlReader("iddata_device"))
                  
                
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add(mySqlReader("model") + "     " + mySqlReader("c_cpu") + "      " + mySqlReader("c_mainboard") + "       " + mySqlReader("c_ram") + "       " + mySqlReader("c_harddisk") + "      " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("section_name") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("section_name"))
                    Else
                        .SubItems.Add(" ")
                    End If
                    If mySqlReader("location_name") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("location_name"))
                    Else
                        .SubItems.Add(" ")
                    End If
                    If mySqlReader("description_name") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("description_name"))
                    Else
                        .SubItems.Add(" ")
                    End If


                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        ''เริ่มต้นหน้าใหม่ TYPE "P"


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM data_device left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection where type = 'Printer' order by iddata_device  DESC limit 50 ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewprin.Items.Clear()

            While (mySqlReader.Read())

                With ListViewprin.Items.Add(mySqlReader("iddata_device"))
                
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("m_size") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("p_type") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
        
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        ''เริ่มต้นหน้าใหม่ TYPE "M"


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM data_device left  join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection where type = 'Monitor' order by iddata_device  DESC limit 50;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewmonitor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewmonitor.Items.Add(mySqlReader("iddata_device"))
                   
                    .SubItems.Add(mySqlReader("name"))


                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("m_size") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
      
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        ''เริ่มต้นหน้าใหม่ TYPE "O"


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection  where type = 'Other' order by iddata_device  DESC limit 50;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewother.Items.Clear()

            While (mySqlReader.Read())

                With ListViewother.Items.Add(mySqlReader("iddata_device"))
              
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
      
                    If mySqlReader("s_type") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("s_type"))
                    End If
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        ''เริ่มต้นหน้าใหม่ TYPE "L"


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM data_device left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection  where type = 'License' order by iddata_device  DESC limit 50;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlicense.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlicense.Items.Add(mySqlReader("iddata_device"))
                  
                    .SubItems.Add(mySqlReader("name"))


                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("     " + mySqlReader("detail") + "     " + mySqlReader("price") + "     " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
       
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        ''เริ่มต้นหน้าใหม่ TYPE "N"


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection where type = 'Network' order by iddata_device  DESC  limit 50;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewnet.Items.Clear()

            While (mySqlReader.Read())

                With ListViewnet.Items.Add(mySqlReader("iddata_device"))
                
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("     " + mySqlReader("serialnumber") + "     " + mySqlReader("c_ipnumber") + "     " + mySqlReader("pass_connect") + "     " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "     " + mySqlReader("price"))
                    End If
                  
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        'เริ่มหน้า Spare Part

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection where type = 'Spare Part' order by iddata_device  DESC limit 50;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewspare.Items.Clear()

            While (mySqlReader.Read())

                With ListViewspare.Items.Add(mySqlReader("iddata_device"))
                  
                    .SubItems.Add(mySqlReader("name"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add(mySqlReader("detail") + "      Price : " + mySqlReader("price"))
                    End If

                    
                    .subitems.add(mySqlReader("serialnumber"))
                    If mySqlReader("s_type") IsNot DBNull.Value Then
                        .subitems.add(mySqlReader("s_type"))
                    End If
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowcom.Text = ListViewcom.Items.Count.ToString
        txtshowmonitor.Text = ListViewmonitor.Items.Count.ToString
        txtshowprin.Text = ListViewprin.Items.Count.ToString
        txtothershow.Text = ListViewother.Items.Count.ToString
        txtshowlicense.Text = ListViewlicense.Items.Count.ToString
        txtshownet.Text = ListViewnet.Items.Count.ToString
        txtshowsp.Text = ListViewspare.Items.Count.ToString

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If


        mySqlCommand.CommandText = "SELECT * FROM type order by idtype ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ComboBoxtypeother.Items.Clear()
            ComboBoxtypespare.Items.Clear()
            While (mySqlReader.Read())
                ComboBoxtypeother.Items.Add(mySqlReader("type_name"))
                ComboBoxtypespare.Items.Add(mySqlReader("type_name"))
                ComboBoxtypenet.Items.Add(mySqlReader("type_name"))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM brand order by idbrand ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ComboBoxotherb.Items.Clear()
            ComboBoxnetb.Items.Clear()
            ComboBoxspareb.Items.Clear()
            ComboBoxcomb.Items.Clear()
            ComboBoxprinb.Items.Clear()
            ComboBoxmonitorb.Items.Clear()
            While (mySqlReader.Read())
                ComboBoxotherb.Items.Add(mySqlReader("brand_name"))
                ComboBoxnetb.Items.Add(mySqlReader("brand_name"))
                ComboBoxspareb.Items.Add(mySqlReader("brand_name"))
                ComboBoxcomb.Items.Add(mySqlReader("brand_name"))
                ComboBoxprinb.Items.Add(mySqlReader("brand_name"))
                ComboBoxmonitorb.Items.Add(mySqlReader("brand_name"))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()




        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM floor order by idFloor;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())

                ComboBox1.Items.Add(mySqlReader("idFloor").ToString + "|" + mySqlReader("floor_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


    End Sub
    Private Sub showdatacom1()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchcom.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device  left join location on data_device.idlocation = location.idlocation left join section on location.idsection =  section.idsection  where  type = 'Computer' and (iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'   or  c_cpu like '%" + key + "%'  or  c_mainboard like '%" + key + "%' or  c_ram like '%" + key + "%' or  c_harddisk like '%" + key + "%' or  c_vgacard like '%" + key + "%'  or  state_device like '%" + key + "%' or  p_type like '%" + key + "%'or  m_size like '%" + key + "%' or  detail like '%" + key + "%'or  c_ipnumber like '%" + key + "%' or  c_ps like '%" + key + "%' or  c_cd like '%" + key + "%' or  c_case like '%" + key + "%' or  serialnumber like '%" + key + "%' or  c_comname like '%" + key + "%'or  c_windows like '%" + key + "%'or  c_office like '%" + key + "%'or  c_other like '%" + key + "%')  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewcom.Items.Clear()

            While (mySqlReader.Read())

                With ListViewcom.Items.Add(mySqlReader("iddata_device"))
                   
                    .SubItems.Add(mySqlReader("name"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add(mySqlReader("model") + "     " + mySqlReader("c_cpu") + "      " + mySqlReader("c_mainboard") + "       " + mySqlReader("c_ram") + "       " + mySqlReader("c_harddisk") + "      " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                  
                    If mySqlReader("section_name") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("section_name"))
                    Else
                        .SubItems.Add(" ")
                    End If
                    If mySqlReader("location_name") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("location_name"))
                    Else
                        .SubItems.Add(" ")
                    End If
                    If mySqlReader("description_name") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("description_name"))
                    Else
                        .SubItems.Add(" ")
                    End If
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


        'แสดงจำนวนข้อมูลในตาราง


        txtshowcom.Text = ListViewcom.Items.Count.ToString
    End Sub
    Private Sub showdataprinter2()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchprin.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM data_device  left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection  where  type = 'Printer' and ( iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'    or  serialnumber like '%" + key + "%'  or  detail like '%" + key + "%' )  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListViewprin.Items.Clear()

            While (mySqlReader.Read())

                With ListViewprin.Items.Add(mySqlReader("iddata_device"))
                
                    .SubItems.Add(mySqlReader("name"))


                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("p_type") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
        
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowprin.Text = ListViewprin.Items.Count.ToString
    End Sub
    Private Sub showdatamonitor3()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchmonitor.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device   left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection where  type = 'Monitor' and (iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'    or  m_size like '%" + key + "%'  or  serialnumber like '%" + key + "%'  or  detail like '%" + key + "%')  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewmonitor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewmonitor.Items.Add(mySqlReader("iddata_device"))
                  
                    .SubItems.Add(mySqlReader("name"))


                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("m_size") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
       
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowmonitor.Text = ListViewmonitor.Items.Count.ToString
    End Sub
    Private Sub showdataother4()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchother.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device  left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection  where  type = 'Other' and ( iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'  or  serialnumber like '%" + key + "%'   or  detail like '%" + key + "%' or  s_type like '%" + key + "%')  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewother.Items.Clear()

            While (mySqlReader.Read())

                With ListViewother.Items.Add(mySqlReader("iddata_device"))
                 
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("     " + mySqlReader("model") + "     " + mySqlReader("detail") + "     " + mySqlReader("serialnumber") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                   
                    If mySqlReader("s_type") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("s_type"))
                    End If
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtothershow.Text = ListViewother.Items.Count.ToString
    End Sub
    Private Sub showdatalicense5()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchother.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device  left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection  where  type = 'License' and ( iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'  or  serialnumber like '%" + key + "%'   or  detail like '%" + key + "%')  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlicense.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlicense.Items.Add(mySqlReader("iddata_device"))
                   
                    .SubItems.Add(mySqlReader("name"))


                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("     " + mySqlReader("detail") + "     " + mySqlReader("price") + "     " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                   
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowlicense.Text = ListViewlicense.Items.Count.ToString
    End Sub
    Private Sub showdatanetwork6()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchother.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device  left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection  where  type = 'Network' and (iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'  or  serialnumber like '%" + key + "%'   or  detail like '%" + key + "%')  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewnet.Items.Clear()

            While (mySqlReader.Read())

                With ListViewnet.Items.Add(mySqlReader("iddata_device"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Computer")
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Printer")
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Monitor")
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Other")
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.add("Licens")
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.add("Network")
                    End If
                    .SubItems.Add(mySqlReader("name"))

                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("     " + mySqlReader("serialnumber") + "     " + mySqlReader("c_ipnumber") + "     " + mySqlReader("pass_connect") + "     " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "     " + mySqlReader("price"))
                    End If
                    If mySqlReader("state_device") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("state_device"))
                    End If
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshownet.Text = ListViewnet.Items.Count.ToString
    End Sub
    Private Sub showdataspare7()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearchspare.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device  left join location on data_device.idlocation = location.idlocation join section on location.idsection =  section.idsection where  type = 'Spare Part' and (iddata_device like '" + key + "' or name like '%" + key + "%'  or  model like '%" + key + "%'  or  serialnumber like '%" + key + "%'   or  detail like '%" + key + "%' or  s_type like '%" + key + "%' )  order by iddata_device DESC;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewspare.Items.Clear()

            While (mySqlReader.Read())

                With ListViewspare.Items.Add(mySqlReader("iddata_device"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Computer")
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Printer")
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Monitor")
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Other")
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.add("Licens")
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.add("Network")
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add("Spare Part")
                    End If
                    .SubItems.Add(mySqlReader("name"))
                    If mySqlReader("type") = "Computer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "CPU : " + mySqlReader("c_cpu") + "mainboard : " + mySqlReader("c_mainboard") + "RAM : " + mySqlReader("c_ram") + "HARDDISK : " + mySqlReader("c_harddisk") + "VGA Card : " + mySqlReader("c_vgacard") + "Ip Number : " + mySqlReader("c_ipnumber") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "PowerSupply : " + mySqlReader("c_ps") + "CD/DVD : " + mySqlReader("c_cd") + "Case : " + mySqlReader("c_case") + "IpAddress : " + mySqlReader("c_ipnumber") + "Computername : " + mySqlReader("c_comname") + " Windows : " + mySqlReader("c_windows") + "Office : " + mySqlReader("c_office") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Monitor" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Size : " + mySqlReader("m_size") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Printer" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Type : " + mySqlReader("p_type") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Other" Then
                        .SubItems.Add("Model : " + mySqlReader("model") + "Detail : " + mySqlReader("detail") + "Serial Number : " + mySqlReader("serialnumber") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "License" Then
                        .SubItems.Add("Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price") + "Amount : " + mySqlReader("amount"))
                    End If
                    If mySqlReader("type") = "Network" Then
                        .SubItems.Add("Serial Number : " + mySqlReader("serialnumber") + "IP Address : " + mySqlReader("c_ipnumber") + "Pass-Connect : " + mySqlReader("pass_connect") + "Pass-Config : " + mySqlReader("pass_config") + "Detail : " + mySqlReader("detail") + "Price : " + mySqlReader("price"))
                    End If
                    If mySqlReader("type") = "Spare Part" Then
                        .subitems.add(mySqlReader("detail") + "      Price : " + mySqlReader("price"))
                    End If

                    If mySqlReader("state_device") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("state_device"))
                    End If
                    .subitems.add(mySqlReader("serialnumber"))
                    If mySqlReader("s_type") IsNot DBNull.Value Then
                        .SubItems.Add(mySqlReader("s_type"))
                    End If
                    .SubItems.Add(mySqlReader("section_name"))
                    .SubItems.Add(mySqlReader("location_name"))
                    .SubItems.Add(mySqlReader("description_name"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowsp.Text = ListViewspare.Items.Count.ToString
    End Sub

    Private Sub txtsearchcom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchcom.KeyDown
        If e.KeyCode = "13" Then
            showdatacom1()
        End If
    End Sub

    Private Sub txtsearchprin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchprin.KeyDown
        If e.KeyCode = "13" Then
            showdataprinter2()
        End If
    End Sub

    Private Sub txtsearchmonitor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchmonitor.KeyDown
        If e.KeyCode = "13" Then
            showdatamonitor3()
        End If
    End Sub

    Private Sub txtsearchother_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchother.KeyDown
        If e.KeyCode = "13" Then
            showdataother4()
        End If
    End Sub

    Private Sub txtsearchlicense_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchlicense.KeyDown
        If e.KeyCode = "13" Then
            showdatalicense5()
        End If
    End Sub

    Private Sub txtsearchnet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchnet.KeyDown
        If e.KeyCode = "13" Then
            showdatanetwork6()
        End If
    End Sub
    ''โค้ดแสดงข้อมูลในตาราง 6/6/56 ***********************************************************

    ''Computer
    Private Sub ListViewcom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewcom.Click
        idkey = ListViewcom.SelectedItems(0).SubItems(0).Text
        idkey4 = ListViewcom.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                ComboBoxcomb.Text = mySqlReader("name")
                tab3model.Text = mySqlReader("model")
                tab3cpu.Text = mySqlReader("c_cpu")
                tab3mb.Text = mySqlReader("c_mainboard")
                tab3ram.Text = mySqlReader("c_ram")
                tab3hd.Text = mySqlReader("c_harddisk")
                tab3vga.Text = mySqlReader("c_vgacard")
                tab3ipnumber.Text = mySqlReader("c_ipnumber")
                tab3detail.Text = mySqlReader("detail")
                tab3ps.Text = mySqlReader("c_ps")
                tab3cd.Text = mySqlReader("c_cd")
                tab3case.Text = mySqlReader("c_case")
                tab3serial.Text = mySqlReader("serialnumber")
                tab3comname.Text = mySqlReader("c_comname")
                tab3windows.Text = mySqlReader("c_windows")
                tab3office.Text = mySqlReader("c_office")
                tab3other.Text = mySqlReader("c_other")
                tab3id.Text = mySqlReader("iddata_device")
                tab3price.Text = mySqlReader("price")
                If mySqlReader("computerhims") = "มี" Then
                    CheckBoxhims.Checked = True
                Else
                    CheckBoxhims.Checked = False
                End If
                If mySqlReader("computerpacs") = "มี" Then
                    CheckBoxpacs.Checked = True
                Else
                    CheckBoxpacs.Checked = False
                End If
                If mySqlReader("computerlab") = "มี" Then
                    CheckBoxlab.Checked = True
                Else
                    CheckBoxlab.Checked = False
                End If
                If mySqlReader("computersystem") = "มี" Then
                    CheckBoxsystem.Checked = True
                Else
                    CheckBoxsystem.Checked = False
                End If
                If mySqlReader("computeradmin") = "มี" Then
                    CheckBoxadmin.Checked = True
                Else
                    CheckBoxadmin.Checked = False
                End If
                If mySqlReader("computerdeep") = "มี" Then
                    CheckBoxdeep.Checked = True
                Else
                    CheckBoxdeep.Checked = False
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewprin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewprin.Click
        idkey1 = ListViewprin.SelectedItems(0).SubItems(0).Text
        idkey5 = ListViewprin.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey1 & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxprinb.Text = mySqlReader("name")
                tab2model.Text = mySqlReader("model")
                tab2id.Text = mySqlReader("iddata_device")
                tab2detail.Text = mySqlReader("detail")
                tab2serial.Text = mySqlReader("serialnumber")
                tab2price.Text = mySqlReader("price")
                If mySqlReader("p_type") = "Laser Printer สี" Then
                    Radiolaserc.Checked = True
                Else
                    Radiolaserc.Checked = False
                End If
                If mySqlReader("p_type") = "Laser Printer ขาว-ดำ" Then
                    Radiolaserwb.Checked = True
                Else
                    Radiolaserwb.Checked = False
                End If
                If mySqlReader("p_type") = "Dot-matrix Printer" Then
                    Radiodot.Checked = True
                Else
                    Radiodot.Checked = False
                End If
                If mySqlReader("p_type") = "Inkjet Printer" Then
                    Radioinkjet.Checked = True
                Else
                    Radioinkjet.Checked = False
                End If
                If mySqlReader("p_type") = "Sticker Printer" Then
                    Radiosticker.Checked = True
                Else
                    Radiosticker.Checked = False
                End If
                If mySqlReader("p_type") = "Inkjet-all in one" Then
                    Radioinkall.Checked = True
                Else
                    Radioinkall.Checked = False
                End If
                If mySqlReader("p_type") = "Laser-all in one" Then
                    Radiolaserall.Checked = True
                Else
                    Radiolaserall.Checked = False
                End If
                If mySqlReader("p_type") = "Laser-multifunction" Then
                    Radiolasermulti.Checked = True
                Else
                    Radiolasermulti.Checked = False
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewmonitor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewmonitor.Click
        idkey = ListViewmonitor.SelectedItems(0).SubItems(0).Text
        idkey6 = ListViewmonitor.SelectedItems(0).SubItems(0).Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxmonitorb.Text = mySqlReader("name")
                tab1model.Text = mySqlReader("model")
                tab1id.Text = mySqlReader("iddata_device")
                tab1detail.Text = mySqlReader("detail")
                tab1serial.Text = mySqlReader("serialnumber")
                tab1size.Text = mySqlReader("m_size")
                tab1price.Text = mySqlReader("price")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewother_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewother.Click
        idkey = ListViewother.SelectedItems(0).SubItems(0).Text
        idkey7 = ListViewother.SelectedItems(0).SubItems(0).Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxotherb.Text = mySqlReader("name")
                tab4model.Text = mySqlReader("model")
                tab4id.Text = mySqlReader("iddata_device")
                tab4detail.Text = mySqlReader("detail")
                tab4serial.Text = mySqlReader("serialnumber")
                tab4price.Text = mySqlReader("price")
                ComboBoxtypeother.Text = mySqlReader("s_type")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewlicense_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlicense.Click
        idkey = ListViewlicense.SelectedItems(0).SubItems(0).Text
        idkey9 = ListViewlicense.SelectedItems(0).SubItems(0).Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                tab5brand.Text = mySqlReader("name")
                tab5detail.Text = mySqlReader("detail")
                tab5id.Text = mySqlReader("iddata_device")
                tab5amount.Text = mySqlReader("amount")
                tab5price.Text = mySqlReader("price")
                If mySqlReader("windows_application") = "OS" Then
                    Radioos.Checked = True
                Else
                    Radioos.Checked = False
                End If
                If mySqlReader("windows_application") = "Application" Then
                    Radioapp.Checked = True
                Else
                    Radioapp.Checked = False
                End If
                ''โค้ดปุ่มเลือกเวลา
                Dim date_as As Date
                date_as = "#" + mySqlReader("startbuy") + "#"
                DateTimePicker1.Value = date_as

                date_as = "#" + mySqlReader("warrant") + "#"
                DateTimePicker2.Value = date_as


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewnet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewnet.Click
        idkey = ListViewnet.SelectedItems(0).SubItems(0).Text
        idkey8 = ListViewnet.SelectedItems(0).SubItems(0).Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxnetb.Text = mySqlReader("name")
                tab6ipnumber.Text = mySqlReader("c_ipnumber")
                tab6id.Text = mySqlReader("iddata_device")
                tab6detail.Text = mySqlReader("detail")
                tab6serial.Text = mySqlReader("serialnumber")
                tab6price.Text = mySqlReader("price")
                tab6passconnect.Text = mySqlReader("pass_connect")
                tab6passconfig.Text = mySqlReader("pass_config")
                tab6model.Text = mySqlReader("model")
                ComboBoxtypenet.Text = mySqlReader("s_type")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub btnsavecom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavecom.Click
        If tab3id.Text <> "" Then

            savedatacom()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub savedatacom()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim computerhims As String
        Dim computerpacs As String
        Dim computerlab As String
        Dim computersystem As String
        Dim computeradmin As String
        Dim computerdeep As String
        If CheckBoxhims.Checked = True Then
            computerhims = "มี"
        ElseIf CheckBoxhims.Checked = False Then
            computerhims = "ไม่มี"
        End If
        If CheckBoxpacs.Checked = True Then
            computerpacs = "มี"
        ElseIf CheckBoxpacs.Checked = False Then
            computerpacs = "ไม่มี"
        End If
        If CheckBoxlab.Checked = True Then
            computerlab = "มี"
        ElseIf CheckBoxlab.Checked = False Then
            computerlab = "ไม่มี"
        End If
        If CheckBoxsystem.Checked = True Then
            computersystem = "มี"
        ElseIf CheckBoxsystem.Checked = False Then
            computersystem = "ไม่มี"
        End If
        If CheckBoxadmin.Checked = True Then
            computeradmin = "มี"
        ElseIf CheckBoxadmin.Checked = False Then
            computeradmin = "ไม่มี"
        End If
        If CheckBoxdeep.Checked = True Then
            computerdeep = "มี"
        ElseIf CheckBoxdeep.Checked = False Then
            computerdeep = "ไม่มี"
        End If

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxcomb.Text & "' , model = '" & tab3model.Text & "' , c_cpu = '" & tab3cpu.Text & "' , c_mainboard = '" & tab3mb.Text & "', c_ram = '" & tab3ram.Text & "' ,c_harddisk = '" & tab3hd.Text & "' ,c_vgacard = '" & tab3vga.Text & "',c_ipnumber = '" & tab3ipnumber.Text & "',detail = '" & tab3detail.Text & "',c_ps = '" & tab3ps.Text & "' ,c_cd = '" & tab3cd.Text & "',c_case = '" & tab3case.Text & "',serialnumber = '" & tab3serial.Text & "',price = '" & tab3price.Text & "',c_comname = '" & tab3comname.Text & "',c_windows = '" & tab3windows.Text & "',c_office = '" & tab3office.Text & "',c_other = '" & tab3other.Text & "',computerhims = '" & computerhims & "',computerpacs = '" & computerpacs & "',computerlab = '" & computerlab & "',computersystem = '" & computersystem & "',computeradmin = '" & computeradmin & "',computerdeep = '" & computerdeep & "' WHERE iddata_device = " & tab3id.Text & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        showdatacom1()
        tab3id.Text = ""
        ComboBoxcomb.Text = ""
        tab3model.Text = ""
        tab3cd.Text = ""
        tab3cpu.Text = ""
        tab3hd.Text = ""
        tab3mb.Text = ""
        tab3vga.Text = ""
        tab3ram.Text = ""
        tab3ipnumber.Text = ""
        tab3serial.Text = ""
        tab3detail.Text = ""
        tab3ps.Text = ""
        tab3case.Text = ""
        tab3comname.Text = ""
        tab3windows.Text = ""
        tab3office.Text = ""
        tab3other.Text = ""
        tab3price.Text = ""
        CheckBoxhims.Checked = False
        CheckBoxpacs.Checked = False
        CheckBoxlab.Checked = False
        CheckBoxsystem.Checked = False
        CheckBoxadmin.Checked = False
        CheckBoxdeep.Checked = False

    End Sub

    Private Sub btnsaveprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveprin.Click
        If tab2id.Text <> "" Then

            savedataprin()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedataprin()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        Dim printer As String
        If Radiolaserc.Checked = True Then
            printer = "Laser Printer สี"
        End If
        If Radiolaserwb.Checked = True Then
            printer = "Laser Printer ขาว-ดำ"
        End If
        If Radiodot.Checked = True Then
            printer = "Dot-matrix Printer"
        End If
        If Radioinkjet.Checked = True Then
            printer = "Inkjet Printer"
        End If
        If Radiosticker.Checked = True Then
            printer = "Sticker Printer"
        End If
        If Radioinkall.Checked = True Then
            printer = "Inkjet-all in one"
        End If
        If Radiolaserall.Checked = True Then
            printer = "Laser-all in one"
        End If
        If Radiolasermulti.Checked = True Then
            printer = "Laser-multifunction"
        End If
        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Complete")
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        If respone = 1 Then


            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxprinb.Text & "' , model = '" & tab2model.Text & "' , serialnumber = '" & tab2serial.Text & "', detail = '" & tab2detail.Text & "', p_type = '" & printer & "', price = '" & tab2price.Text & "' WHERE iddata_device = " & tab2id.Text & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showdataprinter2()
        ComboBoxprinb.Text = ""
        tab2model.Text = ""
        tab2detail.Text = ""
        tab2serial.Text = ""
        tab2price.Text = ""
        Radiolaserc.Checked = False
        Radiolaserwb.Checked = False
        Radiodot.Checked = False
        Radioinkjet.Checked = False
        Radiosticker.Checked = False
        Radioinkall.Checked = False
        Radiolaserall.Checked = False
        Radiolasermulti.Checked = False

    End Sub

    Private Sub btnsavemonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavemonitor.Click
        If tab1id.Text <> "" Then

            savedatamonitor()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedatamonitor()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Complete")

        If respone = 1 Then


            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxmonitorb.Text & "' , model = '" & tab1model.Text & "' , serialnumber = '" & tab1serial.Text & "', detail = '" & tab1detail.Text & "', m_size = '" & tab1size.Text & "',price = '" & tab1price.Text & "' WHERE iddata_device = " & tab1id.Text & "; "

                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql

                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        showdatamonitor3()
        tab1model.Text = ""
        ComboBoxmonitorb.Text = ""
        tab1size.Text = ""
        tab1detail.Text = ""
        tab1serial.Text = ""
        tab1price.Text = ""

    End Sub

    Private Sub btnsaveother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveother.Click
        If tab4id.Text <> "" Then

            savedataother()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedataother()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxotherb.Text & "' , model = '" & tab4model.Text & "' , serialnumber = '" & tab4serial.Text & "', detail = '" & tab4detail.Text & "',price = '" & tab4price.Text & "' ,s_type = '" & ComboBoxtypeother.Text & "' WHERE iddata_device = " & tab4id.Text & "; "

                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showdataother4()
        ComboBoxotherb.Text = ""
        tab4model.Text = ""
        tab4detail.Text = ""
        tab4serial.Text = ""
        tab4price.Text = ""

    End Sub

    Private Sub btnsavelicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavelicense.Click
        If tab5id.Text <> "" Then

            savedatalicense()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedatalicense()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        Dim windows_application As String
        If Radioos.Checked = True Then
            windows_application = "OS"
        End If
        If Radioapp.Checked = True Then
            windows_application = "Application"
        End If

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then

            Try
                commandText2 = "UPDATE data_device SET name = '" & tab5brand.Text & "' , amount = '" & tab5amount.Text & "' , price = '" & tab5price.Text & "', detail = '" & tab5detail.Text & "',windows_application = '" & windows_application & "' WHERE iddata_device = " & tab5id.Text & ";"
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        showdatalicense5()
        tab5brand.Text = ""
        tab5amount.Text = ""
        tab5detail.Text = ""
        tab5price.Text = ""
        Radioos.Checked = False
        Radioapp.Checked = False

    End Sub

    Private Sub btnsavenet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavenet.Click
        If tab6id.Text <> "" Then

            savedatanet()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedatanet()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxnetb.Text & "' , serialnumber = '" & tab6serial.Text & "' , c_ipnumber = '" & tab6ipnumber.Text & "', pass_connect = '" & tab6passconnect.Text & "', pass_config = '" & tab6passconfig.Text & "', detail = '" & tab6detail.Text & "', price = '" & tab6price.Text & "',model = '" & tab6model.Text & "' ,s_type = '" & ComboBoxtypenet.Text & "' WHERE iddata_device = " & tab6id.Text & "; "

                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql

                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        showdatanetwork6()
        ComboBoxnetb.Text = ""
        tab6detail.Text = ""
        tab6serial.Text = ""
        tab6ipnumber.Text = ""
        tab6passconnect.Text = ""
        tab6passconfig.Text = ""
        tab6price.Text = ""
        tab6model.Text = ""
        ComboBoxtypenet.Text = ""

    End Sub

    Private Sub btnsavespare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavespare.Click
        If tab7id.Text <> "" Then

            savedataspare()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedataspare()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE data_device SET name = '" & ComboBoxspareb.Text & "' , model = '" & tab7modelsp.Text & "' , serialnumber = '" & tab7snsp.Text & "', detail = '" & tab7detailsp.Text & "', price = '" & tab7pricesp.Text & "' , s_type = '" & ComboBoxtypespare.Text & "'  WHERE iddata_device = " & tab7id.Text & "; "

                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showdataspare7()
        ComboBoxspareb.Text = ""
        tab7modelsp.Text = ""
        tab7detailsp.Text = ""
        tab7snsp.Text = ""
        tab7pricesp.Text = ""
    End Sub


    Private Sub btndeleteother_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeleteother.Click
        If tab4id.Text <> "" Then

            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub DeleteData4()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab4id.Text <> "" Then

                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab4id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql

                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()
                    showdataother4()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub


    Private Sub btndeletecom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletecom.Click
        If tab3id.Text <> "" Then

            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()

        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub DeleteData1()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab3id.Text <> "" Then

                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab3id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()
                    showdatacom1()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try


                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub

    Private Sub btndeletemonitor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletemonitor.Click
        If tab1id.Text <> "" Then

            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()

        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub DeleteData3()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab1id.Text <> "" Then

                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab1id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql

                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()
                    showdatamonitor3()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub


    Private Sub btndeletelicense_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletelicense.Click
        If tab5id.Text <> "" Then

            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub DeleteData5()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab5id.Text <> "" Then

                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab5id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql

                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()


                    showdatalicense5()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub


    Private Sub btndeletenet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletenet.Click
        If tab6id.Text <> "" Then

            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub
    Private Sub DeleteData6()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab6id.Text <> "" Then

                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab6id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql

                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()
                    showdatanetwork6()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub

    Private Sub btndeletespare_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletespare.Click
        If tab7id.Text <> "" Then
            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub DeleteData7()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab7id.Text <> "" Then

                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab7id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()
                    showdataspare7()
                Catch ex As Exception

                    MsgBox(ex.ToString)

                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub


    Private Sub btnsearchcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchcom.Click
        showdatacom1()
    End Sub

    Private Sub btnsearchprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchprin.Click
        showdataprinter2()

    End Sub

    Private Sub btnsearchmonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchmonitor.Click
        showdatamonitor3()

    End Sub

    Private Sub btnsearchother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchother.Click
        showdataother4()
    End Sub

    Private Sub btnsearchlicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchlicense.Click
        showdatalicense5()
    End Sub

    Private Sub btnsearchnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchnet.Click
        showdatanetwork6()
    End Sub
    Private Sub btnsearchspare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchspare.Click
        showdataspare7()

    End Sub


    Private Sub btndeleteprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeleteprin.Click
        If tab2id.Text <> "" Then
            Dim nextform As PASSWORD = New PASSWORD(idkey1, idkey, mysqlpass, ipconnect, usernamedb, dbname)
            nextform.Show()

        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub DeleteData2()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If tab2id.Text <> "" Then

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & tab2id.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql

                    mySqlCommand.ExecuteNonQuery()
                    showdataprinter2()
                    sql.Close()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If


            End If
        End If

    End Sub

    Private Sub ListViewspare_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewspare.Click
        idkey = ListViewspare.SelectedItems(0).SubItems(0).Text
        idkey10 = ListViewspare.SelectedItems(0).SubItems(0).Text
        idkey2 = ListViewspare.SelectedItems(0).SubItems(5).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBoxspareb.Text = mySqlReader("name")
                tab7modelsp.Text = mySqlReader("model")
                tab7id.Text = mySqlReader("iddata_device")
                tab7detailsp.Text = mySqlReader("detail")
                tab7snsp.Text = mySqlReader("serialnumber")
                tab7pricesp.Text = mySqlReader("price")
                ComboBoxtypespare.Text = mySqlReader("s_type")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub txtsearchspare_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchspare.KeyDown
        If e.KeyCode = "13" Then
            showdataspare7()
        End If
    End Sub





    Private Sub btnaddnewcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnewcom.Click

        If tab3cpu.Text <> "" Then

            savedatacomnew()
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub savedatacomnew()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim computerhims As String
        Dim computerpacs As String
        Dim computerlab As String
        Dim computersystem As String
        Dim computeradmin As String
        Dim computerdeep As String

        If CheckBoxhims.Checked = True Then
            computerhims = "มี"
        ElseIf CheckBoxhims.Checked = False Then
            computerhims = "ไม่มี"
        End If
        If CheckBoxpacs.Checked = True Then
            computerpacs = "มี"
        ElseIf CheckBoxpacs.Checked = False Then
            computerpacs = "ไม่มี"
        End If
        If CheckBoxlab.Checked = True Then
            computerlab = "มี"
        ElseIf CheckBoxlab.Checked = False Then
            computerlab = "ไม่มี"
        End If
        If CheckBoxsystem.Checked = True Then
            computersystem = "มี"
        ElseIf CheckBoxsystem.Checked = False Then
            computersystem = "ไม่มี"
        End If
        If CheckBoxadmin.Checked = True Then
            computeradmin = "มี"
        ElseIf CheckBoxadmin.Checked = False Then
            computeradmin = "ไม่มี"
        End If
        If CheckBoxdeep.Checked = True Then
            computerdeep = "มี"
        ElseIf CheckBoxdeep.Checked = False Then
            computerdeep = "ไม่มี"
        End If

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Try
            mySqlCommand.CommandText = "INSERT INTO data_device (type,name,model,c_cpu,c_mainboard,c_ram,c_harddisk,c_vgacard,c_ipnumber,detail,c_ps,c_cd,c_case,serialnumber,c_comname,c_windows,c_office,c_other,price,state_device,computerhims,computerpacs,computerlab,computersystem,computeradmin,computerdeep,date,idlocation) VALUES ('Computer','" & ComboBoxcomb.Text & "', '" & tab3model.Text & "', '" & tab3cpu.Text & "','" & tab3mb.Text & "','" & tab3ram.Text & "','" & tab3hd.Text & "','" & tab3vga.Text & "','" & tab3ipnumber.Text & "','" & tab3detail.Text & "','" & tab3ps.Text & "','" & tab3cd.Text & "','" & tab3case.Text & "','" & tab3serial.Text & "','" & tab3comname.Text & "','" & tab3windows.Text & "','" & tab3office.Text & "','" & tab3other.Text & "','" & tab3price.Text & "','" & ComboBox4.Text & "','" & computerhims & "','" & computerpacs & "','" & computerlab & "','" & computersystem & "','" & computeradmin & "','" & computerdeep & "','" + Date.Now.ToString + "','" & idstring3(0) & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            MessageBox.Show("เก็บเข้าฐานข้อมูลแล้วจ้า", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''เคลียร์ช่องหลังกรอกเสร็จ

            ' ComboBoxbrand.Text = ""
            'tab3model.Text = ""
            ' tab3cd.Text = ""
            'tab3cpu.Text = ""
            ' tab3hd.Text = ""
            'tab3mb.Text = ""
            ' tab3vga.Text = ""
            ' tab3ram.Text = ""
            ' tab3ipnumber.Text = ""
            ' tab3serial.Text = ""
            'tab3detail.Text = ""
            'tab3ps.Text = ""
            'tab3case.Text = ""
            ' tab3comname.Text = ""
            ' tab3windows.Text = ""
            'tab3office.Text = ""
            'tab3other.Text = ""
            'tab3price.Text = ""
            CheckBoxhims.Checked = False
            CheckBoxpacs.Checked = False
            CheckBoxlab.Checked = False
            CheckBoxsystem.Checked = False
            CheckBoxadmin.Checked = False
            CheckBoxdeep.Checked = False
            showdatacom1()
        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tab2model.Text <> "" Then

            savedataprinnew()
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub savedataprinnew()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim printer As String
        If Radiolaserc.Checked = True Then
            printer = "Laser Printer สี"
        End If
        If Radiolaserwb.Checked = True Then
            printer = "Laser Printer ขาว-ดำ"
        End If
        If Radiodot.Checked = True Then
            printer = "Dot-matrix Printer"
        End If
        If Radioinkjet.Checked = True Then
            printer = "Inkjet Printer"
        End If
        If Radiosticker.Checked = True Then
            printer = "Sticker Printer"
        End If
        If Radioinkall.Checked = True Then
            printer = "Inkjet-all in one"
        End If
        If Radiolaserall.Checked = True Then
            printer = "Laser-all in one"
        End If
        If Radiolasermulti.Checked = True Then
            printer = "Laser-multifunction"
        End If
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            mySqlCommand.CommandText = "INSERT INTO data_device (type,name,model,serialnumber,price,detail,p_type,state_device,date,idlocation) VALUES ('Printer','" & ComboBoxprinb.Text & "', '" & tab2model.Text & "','" & tab2serial.Text & "','" & tab2price.Text & "','" & tab2detail.Text & "','" & printer & "','" & ComboBox4.Text & "','" + Date.Now.ToString + "','" & idstring3(0) & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''เคลียร์ช่องหลังกรอกเสร็จ

            'ComboBoxbrand2.Text = ""
            'tab2model.Text = ""
            'tab2detail.Text = ""
            ''tab2serial.Text = ""
            'tab2price.Text = ""
            Radiolaserc.Checked = False
            Radiolaserwb.Checked = False
            Radiodot.Checked = False
            Radioinkjet.Checked = False
            Radiosticker.Checked = False
            Radioinkall.Checked = False
            Radiolaserall.Checked = False
            Radiolasermulti.Checked = False
            showdataprinter2()
        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub btnsavemonitornew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavemonitornew.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Try
            If tab1model.Text <> "" Then
                mySqlCommand.CommandText = "INSERT INTO data_device (type,name,model,m_size,detail,serialnumber,price,state_device,date,idlocation) VALUES ('Monitor','" & ComboBoxmonitorb.Text & "', '" & tab1model.Text & "', '" & tab1size.Text & "','" & tab1detail.Text & "','" & tab1serial.Text & "','" & tab1price.Text & "','" & ComboBox4.Text & "','" + Date.Now.ToString + "','" & idstring3(0) & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
                MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ''เคลียร์ช่องหลังกรอกเสร็จ

                'tab1model.Text = ""
                'ComboBoxbrand3.Text = ""
                'tab1size.Text = ""
                'tab1detail.Text = ""
                'tab1serial.Text = ""
                'tab1price.Text = ""
                showdatamonitor3()
            Else
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub btnsaveothernew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveothernew.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            If tab4model.Text <> "" And ComboBoxtypeother.Text <> "" Then
                mySqlCommand.CommandText = "INSERT INTO data_device (type,name,model,detail,serialnumber,price,state_device,date,s_type,idlocation) VALUES ('Other', '" & ComboBoxotherb.Text & "',  '" & tab4model.Text & "','" & tab4detail.Text & "', '" & tab4serial.Text & "','" & tab4price.Text & "','" & ComboBox4.Text & "','" + Date.Now.ToString + "','" & ComboBoxtypeother.Text & "','" & idstring3(0) & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
                MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ''เคลียร์ช่องหลังกรอกเสร็จ

                ' ComboBoxbrand4.Text = ""
                'tab4model.Text = ""
                ' tab4detail.Text = ""
                ' tab4serial.Text = ""
                ' tab4price.Text = ""\
                showdataother4()

            Else
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        sql.Close()
    End Sub

    Private Sub btnsavelicensenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavelicensenew.Click
        If tab5brand.Text <> "" Then

            savedatalicensenew()
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub savedatalicensenew()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim windows_application As String
        If Radioos.Checked = True Then
            windows_application = "OS"
        End If
        If Radioapp.Checked = True Then
            windows_application = "Application"
        End If

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            mySqlCommand.CommandText = "INSERT INTO data_device (type,name,price,detail,amount,windows_application,state_device,date,startbuy,warrant,idlocation) VALUES ('License','" & tab5brand.Text & "','" & tab5price.Text & "','" & tab5detail.Text & "','" & tab5amount.Text & "','" & windows_application & "','" & ComboBox4.Text & "','" + Date.Now.ToString + "','" & DateTimePicker1.Value.Date.ToString & "','" & DateTimePicker2.Value.Date.ToString & "','" & idstring3(0) & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''เคลียร์ช่องหลังกรอกเสร็จ

            ' tab5brand.Text = ""
            'tab5amount.Text = ""
            'tab5detail.Text = ""
            'tab5price.Text = ""
            'Radioos.Checked = False
            'Radioapp.Checked = False
            showdatalicense5()
        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub btnsavenetnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavenetnew.Click
        If tab6ipnumber.Text <> "" Then

            savedatanetnew()
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub savedatanetnew()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            mySqlCommand.CommandText = "INSERT INTO data_device (type,name,detail,serialnumber,c_ipnumber,pass_connect,pass_config,price,state_device,date,model,s_type,location) VALUES ('Network', '" & ComboBoxnetb.Text & "',  '" & tab6detail.Text & "','" & tab6serial.Text & "', '" & tab6ipnumber.Text & "','" & tab6passconnect.Text & "','" & tab6passconfig.Text & "','" & tab6price.Text & "','" & ComboBox4.Text & "','" + Date.Now.ToString + "','" & tab6model.Text & "','" & ComboBoxtypenet.Text & "','" & idstring3(0) & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ComboBoxbrand6.Text = ""
            'tab6detail.Text = ""
            'tab6serial.Text = ""
            'tab6ipnumber.Text = ""
            'tab6passconnect.Text = ""
            'tab6passconfig.Text = ""
            'tab6price.Text = ""
            showdatanetwork6()

        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub btnsavesparenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavesparenew.Click
        If tab7modelsp.Text <> "" Then

            savedatasparenew()
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub savedatasparenew()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim check_sum As String = 0

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        'เช็คซ้ำ
        For i = 0 To ListViewspare.Items.Count - 1

            If tab7snsp.Text = ListViewspare.Items(i).SubItems(5).Text Then
                check_sum = "1"
            End If


        Next

        Try
            If idkey2 <> tab7snsp.Text And check_sum = "0" Then

                If tab7modelsp.Text <> "" Then
                    mySqlCommand.CommandText = "INSERT INTO data_device (type,name,model,detail,serialnumber,price,state_device,date,s_type,idlocation) VALUES ('Spare Part', '" & ComboBoxspareb.Text & "',  '" & tab7modelsp.Text & "','" & tab7detailsp.Text & "', '" & tab7snsp.Text & "','" & tab7pricesp.Text & "','" & ComboBox4.Text & "','" + Date.Now.ToString + "','" & ComboBoxtypespare.Text & "','" & idstring3(0) & "');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                    MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showdataspare7()
                    idkey3 = tab7snsp.Text
                Else
                    MessageBox.Show("กรุณาเช็คข้อมูลให้ถูกต้อง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("กรุณาเช็คข้อมูลให้ถูกต้อง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        showdatacom1()
        tab3id.Text = ""
        ComboBoxcomb.Text = ""
        tab3model.Text = ""
        tab3cd.Text = ""
        tab3cpu.Text = ""
        tab3hd.Text = ""
        tab3mb.Text = ""
        tab3vga.Text = ""
        tab3ram.Text = ""
        tab3ipnumber.Text = ""
        tab3serial.Text = ""
        tab3detail.Text = ""
        tab3ps.Text = ""
        tab3case.Text = ""
        tab3comname.Text = ""
        tab3windows.Text = ""
        tab3office.Text = ""
        tab3other.Text = ""
        tab3price.Text = ""
        CheckBoxhims.Checked = False
        CheckBoxpacs.Checked = False
        CheckBoxlab.Checked = False
        CheckBoxsystem.Checked = False
        CheckBoxadmin.Checked = False
        CheckBoxdeep.Checked = False
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged




        idkey = ComboBox1.Text
        idstring = Split(idkey, "|")

        ComboBox2.Items.Clear()


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM section where idFloor = '" & idstring(0) & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())


                ComboBox2.Items.Add(mySqlReader("idsection").ToString + "|" + mySqlReader("section_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged


        ComboBox3.Items.Clear()

        idkey = ComboBox2.Text
        idstring2 = Split(idkey, "|")
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idstring2(0) & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())


                ComboBox3.Items.Add(mySqlReader("idlocation").ToString + "|" + mySqlReader("location_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub ComboBox3_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedValueChanged
        idkey = ComboBox3.Text
        idstring3 = Split(idkey, "|")
        'ดึงข้อมูลจากตาราง 4/7/56
        Dim dpname As String
        dpname = ComboBox2.Text
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM location where idlocation = '" & idstring3(0) & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub
End Class
