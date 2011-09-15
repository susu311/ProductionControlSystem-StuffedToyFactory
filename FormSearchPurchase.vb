Public Class FormSearchPurchase
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridSearchPurchaseInfo As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridSearchPurchaseDetailsInfo As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonListAll As System.Windows.Forms.Button
    Friend WithEvents CheckBoxByDate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxItemID As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxItemID As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxSupplierID As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxSupplierID As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxDate As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTo As System.Windows.Forms.Label
    Friend WithEvents Labelfrom As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchPurchase))
        Me.DataGridSearchPurchaseInfo = New System.Windows.Forms.DataGrid
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.ButtonListAll = New System.Windows.Forms.Button
        Me.DataGridSearchPurchaseDetailsInfo = New System.Windows.Forms.DataGrid
        Me.CheckBoxByDate = New System.Windows.Forms.CheckBox
        Me.CheckBoxSupplierID = New System.Windows.Forms.CheckBox
        Me.ComboBoxSupplierID = New System.Windows.Forms.ComboBox
        Me.ComboBoxItemID = New System.Windows.Forms.ComboBox
        Me.CheckBoxItemID = New System.Windows.Forms.CheckBox
        Me.GroupBoxDate = New System.Windows.Forms.GroupBox
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker
        Me.LabelTo = New System.Windows.Forms.Label
        Me.Labelfrom = New System.Windows.Forms.Label
        CType(Me.DataGridSearchPurchaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridSearchPurchaseDetailsInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSearchPurchaseInfo
        '
        Me.DataGridSearchPurchaseInfo.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchPurchaseInfo.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchPurchaseInfo.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchPurchaseInfo.CaptionText = "Purchase Info:"
        Me.DataGridSearchPurchaseInfo.DataMember = ""
        Me.DataGridSearchPurchaseInfo.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchPurchaseInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchPurchaseInfo.Location = New System.Drawing.Point(8, 96)
        Me.DataGridSearchPurchaseInfo.Name = "DataGridSearchPurchaseInfo"
        Me.DataGridSearchPurchaseInfo.ReadOnly = True
        Me.DataGridSearchPurchaseInfo.Size = New System.Drawing.Size(776, 200)
        Me.DataGridSearchPurchaseInfo.TabIndex = 76
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSearch)
        Me.Groupbuttons.Controls.Add(Me.ButtonPrintPreview)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Controls.Add(Me.ButtonListAll)
        Me.Groupbuttons.Location = New System.Drawing.Point(496, 8)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(288, 80)
        Me.Groupbuttons.TabIndex = 77
        Me.Groupbuttons.TabStop = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSearch.Location = New System.Drawing.Point(72, 16)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSearch.TabIndex = 12
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(136, 16)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(80, 56)
        Me.ButtonPrintPreview.TabIndex = 11
        Me.ButtonPrintPreview.Text = "&PrintPreview"
        Me.ButtonPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(224, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonListAll
        '
        Me.ButtonListAll.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonListAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListAll.ForeColor = System.Drawing.Color.White
        Me.ButtonListAll.Image = CType(resources.GetObject("ButtonListAll.Image"), System.Drawing.Image)
        Me.ButtonListAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonListAll.Location = New System.Drawing.Point(8, 16)
        Me.ButtonListAll.Name = "ButtonListAll"
        Me.ButtonListAll.Size = New System.Drawing.Size(56, 56)
        Me.ButtonListAll.TabIndex = 13
        Me.ButtonListAll.Text = "&List All"
        Me.ButtonListAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DataGridSearchPurchaseDetailsInfo
        '
        Me.DataGridSearchPurchaseDetailsInfo.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchPurchaseDetailsInfo.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchPurchaseDetailsInfo.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchPurchaseDetailsInfo.CaptionText = "Item Info:"
        Me.DataGridSearchPurchaseDetailsInfo.DataMember = ""
        Me.DataGridSearchPurchaseDetailsInfo.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchPurchaseDetailsInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchPurchaseDetailsInfo.Location = New System.Drawing.Point(8, 304)
        Me.DataGridSearchPurchaseDetailsInfo.Name = "DataGridSearchPurchaseDetailsInfo"
        Me.DataGridSearchPurchaseDetailsInfo.ReadOnly = True
        Me.DataGridSearchPurchaseDetailsInfo.Size = New System.Drawing.Size(776, 216)
        Me.DataGridSearchPurchaseDetailsInfo.TabIndex = 85
        '
        'CheckBoxByDate
        '
        Me.CheckBoxByDate.Location = New System.Drawing.Point(32, 8)
        Me.CheckBoxByDate.Name = "CheckBoxByDate"
        Me.CheckBoxByDate.Size = New System.Drawing.Size(136, 16)
        Me.CheckBoxByDate.TabIndex = 86
        Me.CheckBoxByDate.Text = " &Using Purchase Date"
        '
        'CheckBoxSupplierID
        '
        Me.CheckBoxSupplierID.Location = New System.Drawing.Point(264, 24)
        Me.CheckBoxSupplierID.Name = "CheckBoxSupplierID"
        Me.CheckBoxSupplierID.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxSupplierID.TabIndex = 87
        Me.CheckBoxSupplierID.Text = "&Supplier ID"
        '
        'ComboBoxSupplierID
        '
        Me.ComboBoxSupplierID.Location = New System.Drawing.Point(344, 24)
        Me.ComboBoxSupplierID.Name = "ComboBoxSupplierID"
        Me.ComboBoxSupplierID.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxSupplierID.TabIndex = 88
        '
        'ComboBoxItemID
        '
        Me.ComboBoxItemID.Location = New System.Drawing.Point(344, 64)
        Me.ComboBoxItemID.Name = "ComboBoxItemID"
        Me.ComboBoxItemID.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxItemID.TabIndex = 89
        '
        'CheckBoxItemID
        '
        Me.CheckBoxItemID.Location = New System.Drawing.Point(264, 64)
        Me.CheckBoxItemID.Name = "CheckBoxItemID"
        Me.CheckBoxItemID.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxItemID.TabIndex = 87
        Me.CheckBoxItemID.Text = "&Item ID"
        '
        'GroupBoxDate
        '
        Me.GroupBoxDate.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBoxDate.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBoxDate.Controls.Add(Me.LabelTo)
        Me.GroupBoxDate.Controls.Add(Me.Labelfrom)
        Me.GroupBoxDate.Location = New System.Drawing.Point(16, 8)
        Me.GroupBoxDate.Name = "GroupBoxDate"
        Me.GroupBoxDate.Size = New System.Drawing.Size(216, 80)
        Me.GroupBoxDate.TabIndex = 90
        Me.GroupBoxDate.TabStop = False
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DateTimePickerTo.Location = New System.Drawing.Point(56, 50)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePickerTo.TabIndex = 87
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(56, 26)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePickerFrom.TabIndex = 86
        '
        'LabelTo
        '
        Me.LabelTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelTo.Location = New System.Drawing.Point(24, 50)
        Me.LabelTo.Name = "LabelTo"
        Me.LabelTo.Size = New System.Drawing.Size(32, 16)
        Me.LabelTo.TabIndex = 85
        Me.LabelTo.Text = "To"
        Me.LabelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelfrom
        '
        Me.Labelfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Labelfrom.Location = New System.Drawing.Point(16, 26)
        Me.Labelfrom.Name = "Labelfrom"
        Me.Labelfrom.Size = New System.Drawing.Size(44, 16)
        Me.Labelfrom.TabIndex = 84
        Me.Labelfrom.Text = "From"
        Me.Labelfrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormSearchPurchase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 534)
        Me.Controls.Add(Me.CheckBoxByDate)
        Me.Controls.Add(Me.GroupBoxDate)
        Me.Controls.Add(Me.ComboBoxItemID)
        Me.Controls.Add(Me.ComboBoxSupplierID)
        Me.Controls.Add(Me.CheckBoxSupplierID)
        Me.Controls.Add(Me.DataGridSearchPurchaseDetailsInfo)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridSearchPurchaseInfo)
        Me.Controls.Add(Me.CheckBoxItemID)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Purchase"
        CType(Me.DataGridSearchPurchaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridSearchPurchaseDetailsInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Search As String = ""

    Private Sub FormSearchPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setGridData(DataGridSearchPurchaseInfo, "Select PurchaseID,PurchaseDate, SupplierID,SupplierName,CompanyName,Address,TotalAmount from VIEWPurchaseInfo where PurchaseID<0 Order By PurchaseID")
            setGridData(DataGridSearchPurchaseDetailsInfo, "Select ItemID,Category,ItemName,PurchasePrice,PurchaseQty,Amount from VIEWPurchaseDetails Where PurchaseID<0")
            AddtoCombo(Me.ComboBoxSupplierID, "Suppliers", "SupplierName + ','+ CompanyName+ ','+ Address", "SupplierID")
            AddtoCombo(ComboBoxItemID, "Item", "convert( nvarchar(10),ItemID) + ':' + ItemName", "ItemID")
            CheckBoxSupplierID.Checked = False
            CheckBoxItemID.Checked = False
            CheckBoxByDate.Checked = False
            ComboBoxSupplierID.Enabled = CheckBoxSupplierID.Checked
            ComboBoxItemID.Enabled = CheckBoxItemID.Checked
            DateTimePickerFrom.Enabled = CheckBoxByDate.Checked
            DateTimePickerTo.Enabled = CheckBoxByDate.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        PrintData()
    End Sub

    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportPurchaseInfo
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            Dim SelectionFormula As String = ""
            If CheckBoxSupplierID.Checked = True Then SelectionFormula = "{ViewPurchaseInfo.SupplierID}=" & Val(ComboBoxSupplierID.SelectedValue)
            If CheckBoxItemID.Checked = True Then SelectionFormula = SelectionFormula & IIf(SelectionFormula.Length > 0, " And ", "") & "{ViewPurchaseInfo.ItemID}=" & Val(ComboBoxItemID.SelectedValue)
            If CheckBoxByDate.Checked = True Then SelectionFormula = SelectionFormula & IIf(SelectionFormula.Length > 0, " And ", "") & "{ViewPurchaseInfo.PurchaseDate}>=#" & SQLDateTime(DateTimePickerFrom.Value, Main.SQLDType.sqlDateOnly, True) & "# and {ViewPurchaseInfo.PurchaseDate}<=#" & SQLDateTime(DateTimePickerTo.Value, Main.SQLDType.sqlDateOnly, True) & "#"

            f_report.CrystalReportViewer1.SelectionFormula = SelectionFormula ' "PurchaseDate}>=#" & SQLDateTime(DateTimePickerFrom.Value, Main.SQLDType.sqlDateOnly, True) & "# and {ViewPurchaseInfo.PurchaseDate}<=#" & SQLDateTime(DateTimePickerTo.Value, Main.SQLDType.sqlDateOnly, True) & "#"
            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            Dim SQL As String = "Select distinct PurchaseID,PurchaseDate, SupplierID,SupplierName,CompanyName,Address, TotalAmount from ViewPurchaseInfo"
            Search = ""
            If CheckBoxSupplierID.Checked = True Then Search = " Where SupplierID=" & Val(ComboBoxSupplierID.SelectedValue)
            If CheckBoxItemID.Checked = True Then Search = Search & IIf(Search.Length > 0, " And ", " Where ") & "ItemID=" & Val(ComboBoxItemID.SelectedValue)
            If CheckBoxByDate.Checked = True Then Search = Search & IIf(Search.Length > 0, " And ", " Where ") & "PurchaseDate Between '" & SQLDateTime(DateTimePickerFrom.Value, Main.SQLDType.sqlDateOnly, True) & "' and '" & SQLDateTime(DateTimePickerTo.Value, Main.SQLDType.sqlDateOnly, True) & "'"
            setGridData(DataGridSearchPurchaseInfo, SQL & Search & " Order By PurchaseID")
            Try
                SQL = "Select Distinct ItemID,Category,ItemName,PurchasePrice,PurchaseQty,Amount from ViewPurchaseInfo"
                setGridData(DataGridSearchPurchaseDetailsInfo, SQL & Search & IIf(Search.Length > 0, " And ", " Where ") & " PurchaseID=" & Val(DataGridSearchPurchaseInfo.Item(DataGridSearchPurchaseInfo.CurrentCell.RowNumber, 0)))
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub DataGridSearchPurchaseInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridSearchPurchaseInfo.Click
        Try
            Dim SQL As String = "Select Distinct ItemID,Category,ItemName,PurchasePrice,PurchaseQty,Amount from ViewPurchaseInfo"
            setGridData(DataGridSearchPurchaseDetailsInfo, SQL & Search & IIf(Search.Trim.Length > 0, " And ", " Where ") & "PurchaseID=" & Val(DataGridSearchPurchaseInfo.Item(DataGridSearchPurchaseInfo.CurrentCell.RowNumber, 0)))
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub CheckBoxSupplierID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSupplierID.CheckedChanged
        ComboBoxSupplierID.Enabled = CheckBoxSupplierID.Checked
    End Sub

    Private Sub CheckBoxItemID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxItemID.CheckedChanged
        ComboBoxItemID.Enabled = CheckBoxItemID.Checked
    End Sub

    Private Sub CheckBoxByDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxByDate.CheckedChanged
        DateTimePickerFrom.Enabled = CheckBoxByDate.Checked
        DateTimePickerTo.Enabled = CheckBoxByDate.Checked
    End Sub

    Private Sub ButtonListAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListAll.Click
        Try
            Dim SQL As String = "Select distinct PurchaseID,PurchaseDate, SupplierID,SupplierName,CompanyName,Address, TotalAmount from ViewPurchaseInfo"
            Search = ""
            CheckBoxSupplierID.Checked = False
            CheckBoxItemID.Checked = False
            CheckBoxByDate.Checked = False
            setGridData(DataGridSearchPurchaseInfo, SQL & Search & " Order By PurchaseID")
            Try
                SQL = "Select Distinct ItemID,Category,ItemName,PurchasePrice,PurchaseQty,Amount from ViewPurchaseInfo"
                setGridData(DataGridSearchPurchaseDetailsInfo, SQL & Search & IIf(Search.Length > 0, " And ", " Where ") & " PurchaseID=" & Val(DataGridSearchPurchaseInfo.Item(DataGridSearchPurchaseInfo.CurrentCell.RowNumber, 0)))
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
End Class

