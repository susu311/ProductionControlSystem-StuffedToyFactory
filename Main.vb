Module Main
    Public AppTitle As String, sqlString As String, SelectionFormula As String, ReportType As String

    Public Enum SQLDType
        sqlDateOnly = 0
        sqlDateTime = 0
    End Enum

    Public Sub main()
        Try
            AppTitle = "Stuffed Toy Production Control System"
            sqlString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=StuffedToy;Data Source=(LOCAL)"
            Dim a As New FormMain
            a.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function AddtoCombo(ByRef cbo As ComboBox, ByVal TableName As String, ByVal Field1 As String, Optional ByVal Field2 As String = "", Optional ByVal WhereCondition As String = "", Optional ByVal ExtraPara As String = "")
        Try
            Dim i As Int16
            Dim SQL = "Select Distinct " & IIf(ExtraPara.Trim.Length > 0, ExtraPara & " as ExtraPara,", "") & _
            Field1 & " as Field1 " & IIf(Field2.Trim.Length > 0, "," & Field2 & " as Field2", "") & _
            " from " & TableName & IIf(WhereCondition.Trim.Length > 0, " Where " & WhereCondition, "") & _
            "  Order By " & IIf(ExtraPara.Trim.Length > 0, ExtraPara & ",", "") & Field1
            Dim A_Command As New OleDb.OleDbDataAdapter(SQL, sqlString)
            Dim ADataSet As New DataSet
            ADataSet.Clear()
            A_Command.Fill(ADataSet, "" & TableName & "")
            If ADataSet.Tables("" & TableName).Rows.Count > 0 Then
                cbo.DataSource = ADataSet.Tables("" & TableName)
                cbo.DisplayMember = "Field1"
                If Field2.Trim.Length > 0 Then cbo.ValueMember = "Field2"
            End If
            A_Command.Dispose()
            A_Command = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, AppTitle)
            Err.Clear()
        End Try
    End Function

    Function getGridRowsCount(ByRef grd As System.Windows.Forms.DataGrid) As Int64
        Try
            Dim DT As DataTable
            DT = grd.DataSource
            getGridRowsCount = Val(DT.Rows.Count)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, AppTitle)
            Err.Clear()
        End Try
    End Function

    Function setGridData(ByRef grd As System.Windows.Forms.DataGrid, ByVal sql As String)
        Try
            Dim i As Int16
            'Dim mCommand As New OleDb.OleDbConnection
            Dim A_Command As New OleDb.OleDbDataAdapter(sql, sqlString)
            Dim ADataSet As New DataSet
            A_Command.Fill(ADataSet, "TableName")
            i = ADataSet.Tables(0).Rows.Count
            If ADataSet.Tables(0).Rows.Count > 0 Then
                grd.DataSource = ADataSet.Tables(0)
                grd.Refresh()
                grd.Select(0)
            Else
                grd.DataSource = ADataSet.Tables(0)
                grd.Refresh()
            End If
            A_Command.Dispose()
            A_Command = Nothing
            'mCommand.Close()
            'mCommand.Dispose()
            setGridData = i
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
            Err.Clear()
        End Try
    End Function

    Function setCountry(ByRef cbo As ComboBox)
        With cbo.Items
            .Clear()
            .Add("afghanistan")
            .Add("Albania")
            .Add("American Samoa")
            .Add("Angola")
            .Add("Armenia")
            .Add("Aruba")
            .Add("Austria")
            .Add("Brazil")
            .Add("Cambodia")
            .Add("Cameroon")
            .Add("Canada")
            .Add("China")
            .Add("Cyprus")
            .Add("Congo")
            .Add("Cuba")
            .Add("Denmark")
            .Add("Dominica")
            .Add("English")
            .Add("France")
            .Add("Germany")
            .Add("Greece")
            .Add("Greenland")
            .Add("Haiti")
            .Add("Iraq")
            .Add("Italy")
            .Add("Jamaica")
            .Add("Japan")
            .Add("Jordan")
            .Add("Korea")
            .Add("Kuwait")
            .Add("Kyrgyzstan")
            .Add("Latvia")
            .Add("Liberia")
            .Add("Libya")
            .Add("Malawi")
            .Add("Malaysia")
            .Add("Mexico")
            .Add("Myanmar")
            .Add("Nepal")
            .Add("Nigeria")
            .Add("North Korea")
            .Add("Norway")
            .Add("Pakistan")
            .Add("Panama")
            .Add("Papua New Guinea")
            .Add("Paraguay")
            .Add("Peru")
            .Add("Philippines")
            .Add("Poland")
            .Add("Qatar")
            .Add("Russia")
            .Add("Singapore")
            .Add("Somalia")
            .Add("South Africa")
            .Add("Spain")
            .Add("Sri Lanka")
            .Add("Sudan")
            .Add("Swaziland")
            .Add("Sweden")
            .Add("Switzerland")
            .Add("Syria")
            .Add("Taiwan")
            .Add("Thailand")
            .Add("Tonga")
            .Add("Turkey")
            .Add("Uganda")
            .Add("United Kingdom")
            .Add("United States")
            .Add("Uruguay")
            .Add("Vietnam")
            .Add("Virgin Islands")
            .Add("Yeman")
            .Add("Zambia")
            .Add("Zimbabwe")
        End With
        cbo.Sorted = True
    End Function

    Public Function GenerateNewID(ByVal Table As String, ByVal IDField As String, Optional ByVal Condition As String = "") As String
        Dim i As Int64 = 1
        Try
            Dim sql As String
            sql = ("Select max(" & IDField.Trim() & ") as MaxID from " & Table & IIf(Condition.Trim() <> "", " Where " & Condition, ""))
            'Dim mCommand As New OleDb.OleDbConnection
            Dim A_Command As New OleDb.OleDbDataAdapter(sql, sqlString)
            Dim ADataSet As New DataSet
            A_Command.Fill(ADataSet, "TableName")
            If ADataSet.Tables(0).Rows.Count > 0 Then i += Val("" & ADataSet.Tables(0).Rows(0).Item(0))
            A_Command.Dispose()
            A_Command = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        GenerateNewID = "" & i
    End Function

    Public Function SavingData(ByVal sql As String, Optional ByVal SaveMsg As Boolean = True) As Boolean
        Try
            Dim mCommand As New OleDb.OleDbConnection
            Dim A_Command As New OleDb.OleDbCommand
            mCommand.ConnectionString = sqlString
            mCommand.Open()
            A_Command.Connection = mCommand
            A_Command.CommandText = sql
            A_Command.ExecuteNonQuery()
            A_Command.Dispose()
            A_Command = Nothing
            mCommand.Close()
            mCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
            Err.Clear()
            SavingData = False
            Exit Function
        End Try
        If SaveMsg Then MsgBox("Save successfully", MsgBoxStyle.Information, AppTitle)
        SavingData = True
    End Function

    Public Function FindData(ByVal Table As String, ByVal Fields As String, Optional ByVal Condition As String = Nothing) As Int64
        Dim i As Int64 = 0
        Try
            Dim sql As String
            sql = ("Select count(" & Fields.Trim() & ") as FindRecord from " & Table & IIf(Condition.Trim() <> "", " Where " & Condition, ""))
            'Dim mCommand As New OleDb.OleDbConnection
            Dim A_Command As New OleDb.OleDbDataAdapter(sql, sqlString)
            Dim ADataSet As New DataSet
            A_Command.Fill(ADataSet, "TableName")
            If ADataSet.Tables(0).Rows.Count > 0 Then i += Val("" & ADataSet.Tables(0).Rows(0).Item(0))
            A_Command.Dispose()
            A_Command = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Err.Clear()
        End Try
        FindData = "" & i
    End Function

    Public Function CalculateDuration(ByVal Sd As Date, ByVal ED As Date) As Int64
        Try
            If FormatDateTime(Sd, DateFormat.ShortDate) > FormatDateTime(ED, DateFormat.ShortDate) Then
                MessageBox.Show("Start Date is greater than  End Date", AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CalculateDuration = -1
            Else
                Dim DAYS As Long
                DAYS = Math.Abs(DateDiff(DateInterval.Day, CDate(FormatDateTime(Sd, DateFormat.ShortDate)), CDate(FormatDateTime(ED, DateFormat.ShortDate))))
                CalculateDuration = DAYS + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Err.Clear()
        End Try
    End Function

    Public Function SQLDateTime(ByVal DT As Date, Optional ByVal SQLDTtype As SQLDType = SQLDType.sqlDateOnly, Optional ByVal ForSQLServer As Boolean = False) As String
        If ForSQLServer = True Then
            If SQLDTtype = SQLDType.sqlDateOnly Then
                SQLDateTime = FormatDateTime(DT, DateFormat.ShortDate) ' "yyyy-mm-dd")
            Else
                SQLDateTime = FormatDateTime(DT, DateFormat.LongDate) ' "yyyy-mm-dd hh:mm:ss AMPM")
            End If
        Else
            If SQLDTtype = SQLDType.sqlDateOnly Then
                SQLDateTime = FormatDateTime(DT, DateFormat.ShortDate) ' "yyyy/mm/dd")
            Else
                SQLDateTime = FormatDateTime(DT, DateFormat.LongDate) '"yyyy/mm/dd hh:mm:ss AMPM")
            End If
        End If
    End Function

    Public Function AddMonthtoCombo(ByRef cbo As ComboBox, Optional ByVal ShowByName As Boolean = True)
        Try
            Dim i As Int16
            For i = 1 To 12
                cbo.Items.Add("" & MonthName(i).ToString)
            Next
        Catch ex As Exception

        End Try
    End Function
    Public Function AddYearToCombo(ByRef cbo As ComboBox, Optional ByVal ShowByName As Boolean = True)
        Try
            Dim i As Int16
            For i = Val(Now.Year.ToString) To 1990 Step -1
                cbo.Items.Add("" & i)
            Next
        Catch ex As Exception

        End Try
    End Function

    Public Function GetData(ByVal Table As String, ByVal Fields As String, Optional ByVal Condition As String = Nothing) As String
        Dim i As Int64 = 0
        Try
            Dim sql As String
            sql = ("Select Distinct " & Fields.Trim() & " as FindRecord from " & Table & IIf(Condition.Trim() <> "", " Where " & Condition, ""))
            'Dim mCommand As New OleDb.OleDbConnection
            Dim A_Command As New OleDb.OleDbDataAdapter(sql, sqlString)
            Dim ADataSet As New DataSet
            A_Command.Fill(ADataSet, "TableName")
            If ADataSet.Tables(0).Rows.Count > 0 Then
                GetData = ADataSet.Tables(0).Rows(0).Item(0)
            End If
            A_Command.Dispose()
            A_Command = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Err.Clear()
        End Try
    End Function
End Module