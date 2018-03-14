Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Globalization

Public Class FriendsDate
    'Private USASettings As New List(Of RegionalSettings)
    'Private UKSettings As New List(Of RegionalSettings)
    'Private THSettings As New List(Of RegionalSettings)
    Private year As Integer
    Private month As Integer
    Private day As Integer

    Public ReadOnly Property _year
        Get
            Return year
        End Get
    End Property

    Public ReadOnly Property _month
        Get
            Return month
        End Get
    End Property

    Public ReadOnly Property _day
        Get
            Return day
        End Get
    End Property

    Public Shared ReadOnly Property Curdate As DateTime
        Get
            Dim db = ConnecDBRYH.NewConnection
            Dim dt As New DataTable
            dt = db.GetTable("SELECT current_timestamp()")
            db.Dispose()
            If dt.Rows.Count > 0 Then
                Return Convert.ToDateTime(dt.Rows(0)(0))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Class RegionalSettings
        Public entry As String
        Public value As String
        Public Sub New(ByVal key As String, ByVal value As String)
            Me.entry = key : Me.value = value
        End Sub
    End Class
    'Public Sub beforSave()
    '    If MAINFRI.CULTURE = "th-TH" Then
    '        Me.TO_EN_US()
    '        Me.culTure_EN()
    '    End If
    'End Sub

    'Public Sub afterSave()
    '    If MAINFRI.CULTURE = "th-TH" Then
    '        Me.TO_TH()
    '        Me.culTure_TH()
    '    End If
    'End Sub
    Public Sub Date_Diff(ByVal date_birth As Date, ByVal date_now As Date)
        Try
            Dim datediff As TimeSpan
            'Dim date_birth_s() As String = Split(birth_datetimepicker.Text, "-") 'split ??????? Array ??????????
            'Dim date_now_s() As String = Split(Date.Today.ToString("dd-MM-yyyy", USCulture), "-")
            'Dim date_birth As Date
            'Dim date_now As Date
            'date_birth = New System.DateTime(CInt(date_birth_s(2)), CInt(date_birth_s(1)), CInt(date_birth_s(0)), 0, 0, 0)
            'date_now = New System.DateTime(date_now_s(2), date_now_s(1), date_now_s(0), 0, 0, 0)
            DateDiff = date_now.Subtract(date_birth)
            year = CInt(datediff.TotalDays.ToString) \ 365.25
            If CInt(year) < 120 Then
                month = (CInt(datediff.TotalDays.ToString) Mod 365.25) \ 30.583
                day = ((CInt(datediff.TotalDays.ToString) Mod 365.25) Mod 30.583)
            Else
                'loadToastMSG("อายุเกิน 120 ปี โปรดตรวจสอบ")
                year = ""
                month = ""
                day = ""
                'birth_datetimepicker.Focus()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'MsgBox(datediff.)
    End Sub
    Public Sub culTure_TH()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("th-TH")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("th-TH")
    End Sub

    Public Sub culTure_EN()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
    End Sub
    'Public Sub Date_Diff(ByVal date1 As Date, ByVal date2 As Date)
    '    Me.year = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Year, date1, date2))
    '    Me.month = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Month, date1, date2))
    '    Me.day = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Year, date1, date2))
    'End Sub

    'Public Sub Date_Diff(ByVal date1 As String, ByVal date2 As String)
    '    Me.year = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Year, Convert.ToDateTime(date1), Convert.ToDateTime(date2)))
    '    Me.month = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Month, Convert.ToDateTime(date1), Convert.ToDateTime(date2)))
    '    Me.day = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Year, Convert.ToDateTime(date1), Convert.ToDateTime(date2)))
    'End Sub

    Public Sub TO_EN_US()
        Dim USASettings As New List(Of RegionalSettings)
        With USASettings
            .Add(New RegionalSettings("iCountry", "1"))
            .Add(New RegionalSettings("iCurrDigits", "2"))
            .Add(New RegionalSettings("iCurrency", "0"))
            .Add(New RegionalSettings("iDate", "1"))
            .Add(New RegionalSettings("iDigits", "2"))
            .Add(New RegionalSettings("iLZero", "1"))
            .Add(New RegionalSettings("iMeasure", "1"))
            .Add(New RegionalSettings("iNegCurr", "0"))
            .Add(New RegionalSettings("iTime", "0"))
            .Add(New RegionalSettings("iTLZero", "0"))
            .Add(New RegionalSettings("Locale", "00000409"))
            .Add(New RegionalSettings("s1159", "AM"))
            .Add(New RegionalSettings("s2359", "PM"))
            .Add(New RegionalSettings("sCountry", "United States"))
            .Add(New RegionalSettings("sCurrency", "$"))
            .Add(New RegionalSettings("sDate", "/"))
            .Add(New RegionalSettings("sDecimal", "."))
            .Add(New RegionalSettings("sLanguage", "ENU"))
            .Add(New RegionalSettings("sList", ","))
            .Add(New RegionalSettings("sLongDate", "dd/MM/yyyy"))
            .Add(New RegionalSettings("sShortDate", "dd/MM/yyyy"))
            .Add(New RegionalSettings("sThousand", ","))
            .Add(New RegionalSettings("sTime", ":"))
            .Add(New RegionalSettings("sTimeFormat", "h:mm:ss"))
            .Add(New RegionalSettings("iTimePrefix", "0"))
            .Add(New RegionalSettings("sMonDecimalSep", "."))
            .Add(New RegionalSettings("sMonThousandSep", ","))
            .Add(New RegionalSettings("iNegNumber", "1"))
            .Add(New RegionalSettings("sNativeDigits", "0123456789"))
            .Add(New RegionalSettings("NumShape", "1"))
            .Add(New RegionalSettings("iCalendarType", "1"))
            .Add(New RegionalSettings("iFirstDayOfWeek", "6"))
            .Add(New RegionalSettings("iFirstWeekOfYear", "0"))
            .Add(New RegionalSettings("sGrouping", "3;0"))
            .Add(New RegionalSettings("sMonGrouping", "3;0"))
            .Add(New RegionalSettings("sPositiveSign", ""))
            .Add(New RegionalSettings("sNegativeSign", "-"))
        End With

        For Each reg As RegionalSettings In USASettings
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", reg.entry, reg.value)
        Next
        NotifyInternationalChanges()
    End Sub

    Public Sub TO_EN_UK()
        Dim UKSettings As New List(Of RegionalSettings)
        With UKSettings
            .Add(New RegionalSettings("iCountry", "44"))
            .Add(New RegionalSettings("iCurrDigits", "2"))
            .Add(New RegionalSettings("iCurrency", "0"))
            .Add(New RegionalSettings("iDate", "1"))
            .Add(New RegionalSettings("iDigits", "2"))
            .Add(New RegionalSettings("iLZero", "1"))
            .Add(New RegionalSettings("iMeasure", "0"))
            .Add(New RegionalSettings("iNegCurr", "1"))
            .Add(New RegionalSettings("iTime", "1"))
            .Add(New RegionalSettings("iTLZero", "1"))
            .Add(New RegionalSettings("Locale", "00000809"))
            .Add(New RegionalSettings("s1159", "AM"))
            .Add(New RegionalSettings("s2359", "PM"))
            .Add(New RegionalSettings("sCountry", "United Kingdom"))
            .Add(New RegionalSettings("sCurrency", "£"))
            .Add(New RegionalSettings("sDate", "/"))
            .Add(New RegionalSettings("sDecimal", "."))
            .Add(New RegionalSettings("sLanguage", "ENG"))
            .Add(New RegionalSettings("sList", ","))
            .Add(New RegionalSettings("sLongDate", "dd MMMM yyyy"))
            .Add(New RegionalSettings("sShortDate", "dd/MM/yyyy"))
            .Add(New RegionalSettings("sThousand", ","))
            .Add(New RegionalSettings("sTime", ":"))
            .Add(New RegionalSettings("sTimeFormat", "HH:mm:ss"))
            .Add(New RegionalSettings("iTimePrefix", "0"))
            .Add(New RegionalSettings("sMonDecimalSep", "."))
            .Add(New RegionalSettings("sMonThousandSep", ","))
            .Add(New RegionalSettings("iNegNumber", "1"))
            .Add(New RegionalSettings("sNativeDigits", "0123456789"))
            .Add(New RegionalSettings("NumShape", "1"))
            .Add(New RegionalSettings("iCalendarType", "1"))
            .Add(New RegionalSettings("iFirstDayOfWeek", "0"))
            .Add(New RegionalSettings("iFirstWeekOfYear", "0"))
            .Add(New RegionalSettings("sGrouping", "3;0"))
            .Add(New RegionalSettings("sMonGrouping", "3;0"))
            .Add(New RegionalSettings("sPositiveSign", ""))
            .Add(New RegionalSettings("sNegativeSign", "-"))
        End With
        For Each reg As RegionalSettings In UKSettings
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", reg.entry, reg.value)
        Next
        NotifyInternationalChanges()
    End Sub

    Public Sub TO_TH()
        Dim THSettings As New List(Of RegionalSettings)
        With THSettings
            .Add(New RegionalSettings("iCountry", "66"))
            .Add(New RegionalSettings("iCurrDigits", "2"))
            .Add(New RegionalSettings("iCurrency", "0"))
            .Add(New RegionalSettings("iDate", "1"))
            .Add(New RegionalSettings("iDigits", "2"))
            .Add(New RegionalSettings("LocaleName", "th-TH"))
            .Add(New RegionalSettings("iLZero", "0"))
            .Add(New RegionalSettings("iMeasure", "0"))
            .Add(New RegionalSettings("iNegCurr", "1"))
            .Add(New RegionalSettings("iTime", "1"))
            .Add(New RegionalSettings("iTLZero", "1"))
            .Add(New RegionalSettings("Locale", "0000041E"))
            .Add(New RegionalSettings("s1159", "AM"))
            .Add(New RegionalSettings("s2359", "PM"))
            .Add(New RegionalSettings("sCountry", "Thailand"))
            .Add(New RegionalSettings("sCurrency", "฿"))
            .Add(New RegionalSettings("sDate", "/"))
            .Add(New RegionalSettings("sDecimal", "."))
            .Add(New RegionalSettings("sLanguage", "THA"))
            .Add(New RegionalSettings("sList", ","))
            .Add(New RegionalSettings("sLongDate", "dd/MMMM/yyyy"))
            .Add(New RegionalSettings("sShortDate", "dd/MM/yyyy"))
            .Add(New RegionalSettings("sThousand", ","))
            .Add(New RegionalSettings("sTime", ":"))
            .Add(New RegionalSettings("sTimeFormat", "HH:mm:ss"))
            .Add(New RegionalSettings("iTimePrefix", "0"))
            .Add(New RegionalSettings("sMonDecimalSep", "."))
            .Add(New RegionalSettings("sMonThousandSep", ","))
            .Add(New RegionalSettings("iNegNumber", "1"))
            .Add(New RegionalSettings("sNativeDigits", "๐๑๒๓๔๕๖๗๘๙"))
            .Add(New RegionalSettings("NumShape", "1"))
            .Add(New RegionalSettings("iCalendarType", "7"))
            .Add(New RegionalSettings("iFirstDayOfWeek", "0"))
            .Add(New RegionalSettings("iFirstWeekOfYear", "0"))
            .Add(New RegionalSettings("sGrouping", "3;0"))
            .Add(New RegionalSettings("sMonGrouping", "3;0"))
            .Add(New RegionalSettings("sPositiveSign", ""))
            .Add(New RegionalSettings("sNegativeSign", "-"))
        End With
        For Each reg As RegionalSettings In THSettings
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", reg.entry, reg.value)
        Next

        NotifyInternationalChanges()
    End Sub

    'Private Sub US_Set()
    'With USASettings
    '    .Add(New RegionalSettings("iCountry", "1"))
    '    .Add(New RegionalSettings("iCurrDigits", "2"))
    '    .Add(New RegionalSettings("iCurrency", "0"))
    '    .Add(New RegionalSettings("iDate", "1"))
    '    .Add(New RegionalSettings("iDigits", "2"))
    '    .Add(New RegionalSettings("iLZero", "1"))
    '    .Add(New RegionalSettings("iMeasure", "1"))
    '    .Add(New RegionalSettings("iNegCurr", "0"))
    '    .Add(New RegionalSettings("iTime", "0"))
    '    .Add(New RegionalSettings("iTLZero", "0"))
    '    .Add(New RegionalSettings("Locale", "00000409"))
    '    .Add(New RegionalSettings("s1159", "AM"))
    '    .Add(New RegionalSettings("s2359", "PM"))
    '    .Add(New RegionalSettings("sCountry", "United States"))
    '    .Add(New RegionalSettings("sCurrency", "$"))
    '    .Add(New RegionalSettings("sDate", "/"))
    '    .Add(New RegionalSettings("sDecimal", "."))
    '    .Add(New RegionalSettings("sLanguage", "ENU"))
    '    .Add(New RegionalSettings("sList", ","))
    '    .Add(New RegionalSettings("sLongDate", "dddd, MMMM dd, yyyy"))
    '    .Add(New RegionalSettings("sShortDate", "M/d/yyyy"))
    '    .Add(New RegionalSettings("sThousand", ","))
    '    .Add(New RegionalSettings("sTime", ":"))
    '    .Add(New RegionalSettings("sTimeFormat", "h:mm:ss"))
    '    .Add(New RegionalSettings("iTimePrefix", "0"))
    '    .Add(New RegionalSettings("sMonDecimalSep", "."))
    '    .Add(New RegionalSettings("sMonThousandSep", ","))
    '    .Add(New RegionalSettings("iNegNumber", "1"))
    '    .Add(New RegionalSettings("sNativeDigits", "0123456789"))
    '    .Add(New RegionalSettings("NumShape", "1"))
    '    .Add(New RegionalSettings("iCalendarType", "1"))
    '    .Add(New RegionalSettings("iFirstDayOfWeek", "6"))
    '    .Add(New RegionalSettings("iFirstWeekOfYear", "0"))
    '    .Add(New RegionalSettings("sGrouping", "3;0"))
    '    .Add(New RegionalSettings("sMonGrouping", "3;0"))
    '    .Add(New RegionalSettings("sPositiveSign", ""))
    '    .Add(New RegionalSettings("sNegativeSign", "-"))
    'End With
    'End Sub

    'Private Sub UK_Set()
    'With UKSettings
    '    .Add(New RegionalSettings("iCountry", "44"))
    '    .Add(New RegionalSettings("iCurrDigits", "2"))
    '    .Add(New RegionalSettings("iCurrency", "0"))
    '    .Add(New RegionalSettings("iDate", "1"))
    '    .Add(New RegionalSettings("iDigits", "2"))
    '    .Add(New RegionalSettings("iLZero", "1"))
    '    .Add(New RegionalSettings("iMeasure", "0"))
    '    .Add(New RegionalSettings("iNegCurr", "1"))
    '    .Add(New RegionalSettings("iTime", "1"))
    '    .Add(New RegionalSettings("iTLZero", "1"))
    '    .Add(New RegionalSettings("Locale", "00000809"))
    '    .Add(New RegionalSettings("s1159", "AM"))
    '    .Add(New RegionalSettings("s2359", "PM"))
    '    .Add(New RegionalSettings("sCountry", "United Kingdom"))
    '    .Add(New RegionalSettings("sCurrency", "£"))
    '    .Add(New RegionalSettings("sDate", "/"))
    '    .Add(New RegionalSettings("sDecimal", "."))
    '    .Add(New RegionalSettings("sLanguage", "ENG"))
    '    .Add(New RegionalSettings("sList", ","))
    '    .Add(New RegionalSettings("sLongDate", "dd MMMM yyyy"))
    '    .Add(New RegionalSettings("sShortDate", "dd/MM/yyyy"))
    '    .Add(New RegionalSettings("sThousand", ","))
    '    .Add(New RegionalSettings("sTime", ":"))
    '    .Add(New RegionalSettings("sTimeFormat", "HH:mm:ss"))
    '    .Add(New RegionalSettings("iTimePrefix", "0"))
    '    .Add(New RegionalSettings("sMonDecimalSep", "."))
    '    .Add(New RegionalSettings("sMonThousandSep", ","))
    '    .Add(New RegionalSettings("iNegNumber", "1"))
    '    .Add(New RegionalSettings("sNativeDigits", "0123456789"))
    '    .Add(New RegionalSettings("NumShape", "1"))
    '    .Add(New RegionalSettings("iCalendarType", "1"))
    '    .Add(New RegionalSettings("iFirstDayOfWeek", "0"))
    '    .Add(New RegionalSettings("iFirstWeekOfYear", "0"))
    '    .Add(New RegionalSettings("sGrouping", "3;0"))
    '    .Add(New RegionalSettings("sMonGrouping", "3;0"))
    '    .Add(New RegionalSettings("sPositiveSign", ""))
    '    .Add(New RegionalSettings("sNegativeSign", "-"))
    'End With
    'End Sub
    'Private Sub TH_Set()
    'With THSettings
    '    .Add(New RegionalSettings("iCountry", "66"))
    '    .Add(New RegionalSettings("iCurrDigits", "2"))
    '    .Add(New RegionalSettings("iCurrency", "0"))
    '    .Add(New RegionalSettings("iDate", "1"))
    '    .Add(New RegionalSettings("iDigits", "2"))
    '    .Add(New RegionalSettings("LocaleName", "th-TH"))
    '    .Add(New RegionalSettings("iLZero", "0"))
    '    .Add(New RegionalSettings("iMeasure", "0"))
    '    .Add(New RegionalSettings("iNegCurr", "1"))
    '    .Add(New RegionalSettings("iTime", "1"))
    '    .Add(New RegionalSettings("iTLZero", "1"))
    '    .Add(New RegionalSettings("Locale", "0000041E"))
    '    .Add(New RegionalSettings("s1159", "AM"))
    '    .Add(New RegionalSettings("s2359", "PM"))
    '    .Add(New RegionalSettings("sCountry", "Thailand"))
    '    .Add(New RegionalSettings("sCurrency", "฿"))
    '    .Add(New RegionalSettings("sDate", "/"))
    '    .Add(New RegionalSettings("sDecimal", "."))
    '    .Add(New RegionalSettings("sLanguage", "THA"))
    '    .Add(New RegionalSettings("sList", ","))
    '    .Add(New RegionalSettings("sLongDate", "dd MMMM yyyy"))
    '    .Add(New RegionalSettings("sShortDate", "dd-MM-yyyy"))
    '    .Add(New RegionalSettings("sThousand", ","))
    '    .Add(New RegionalSettings("sTime", ":"))
    '    .Add(New RegionalSettings("sTimeFormat", "HH:mm:ss"))
    '    .Add(New RegionalSettings("iTimePrefix", "0"))
    '    .Add(New RegionalSettings("sMonDecimalSep", "."))
    '    .Add(New RegionalSettings("sMonThousandSep", ","))
    '    .Add(New RegionalSettings("iNegNumber", "1"))
    '    .Add(New RegionalSettings("sNativeDigits", "๐๑๒๓๔๕๖๗๘๙"))
    '    .Add(New RegionalSettings("NumShape", "1"))
    '    .Add(New RegionalSettings("iCalendarType", "7"))
    '    .Add(New RegionalSettings("iFirstDayOfWeek", "0"))
    '    .Add(New RegionalSettings("iFirstWeekOfYear", "0"))
    '    .Add(New RegionalSettings("sGrouping", "3;0"))
    '    .Add(New RegionalSettings("sMonGrouping", "3;0"))
    '    .Add(New RegionalSettings("sPositiveSign", ""))
    '    .Add(New RegionalSettings("sNegativeSign", "-"))
    'End With
    'End Sub

    Private Sub NotifyInternationalChanges()
        'Ref: http://msdn.microsoft.com/en-us/library/windows/desktop/ms725497%28v=vs.85%29.aspx
        Dim HWND_BROADCAST As New IntPtr(&HFFFF) 'broadcast to entire system
        Dim Lparam As IntPtr = System.Runtime.InteropServices.Marshal.StringToBSTR("intl")
        SendNotifyMessage(HWND_BROADCAST, &H1A, UIntPtr.Zero, Lparam)
        System.Runtime.InteropServices.Marshal.FreeBSTR(Lparam)
    End Sub

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function SendNotifyMessage(ByVal hWnd As IntPtr, _
                                            ByVal msg As UInt32, _
                                            ByVal wParam As UIntPtr, _
                                            ByVal lParam As IntPtr) As Boolean
    End Function
    Public Function GENBIRTH(ByVal age As Integer) As DateTime
        Dim ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
        Dim sql As String
        Dim a As DateTime
        Dim y As Integer
        sql = "SELECT curdate()"
        a = Convert.ToDateTime(ConnectionDB.GetTable(sql).Rows(0)(0))
        y = Convert.ToInt32(a.ToString("yyyy")) - age
        a = Convert.ToDateTime(y.ToString & "/01/01")
        Return a
    End Function

    Public Shared Function Today() As DateTime
        Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection()
        Dim sql As String
        sql = "SELECT curdate()"
        Dim dt As New DataTable()
        dt = db.GetTable(sql)
        If dt.Rows.Count > 0 Then
            Return Convert.ToDateTime(dt.Rows(0)(0))
        Else
            Return DateTime.Now
        End If
        db.Dispose()
    End Function
End Class
