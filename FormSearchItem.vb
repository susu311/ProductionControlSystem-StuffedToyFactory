Public Class FormSearchItem
    Inherits System.Windows.Forms.Form
    Dim ListAll As Boolean
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
    Friend WithEvents DataGridSearchItem As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxEmployeeID As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDesignNo As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonListAll As System.Windows.Forms.Button
    Friend WithEvents ComboBoxItemID As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxItemInfo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCategory As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxCategory As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchItem))
        Me.DataGridSearchItem = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox
        Me.CheckBoxCategory = New System.Windows.Forms.CheckBox
        Me.ComboBoxItemID = New System.Windows.Forms.ComboBox
        Me.CheckBoxItemInfo = New System.Windows.Forms.CheckBox
        Me.ButtonListAll = New System.Windows.Forms.Button
        Me.ComboBoxEmployeeID = New System.Windows.Forms.ComboBox
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.CheckBoxEmployeeID = New System.Windows.Forms.CheckBox
        Me.CheckBoxDesignNo = New System.Windows.Forms.CheckBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        CType(Me.DataGridSearchItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSearchItem
        '
        Me.DataGridSearchItem.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchItem.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchItem.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchItem.CaptionText = "Item Info:"
        Me.DataGridSearchItem.DataMember = ""
        Me.DataGridSearchItem.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchItem.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchItem.Location = New System.Drawing.Point(8, 128)
        Me.DataGridSearchItem.Name = "DataGridSearchItem"
        Me.DataGridSearchItem.ReadOnly = True
        Me.DataGridSearchItem.Size = New System.Drawing.Size(688, 408)
        Me.DataGridSearchItem.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ComboBoxCategory)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCategory)
        Me.GroupBox1.Controls.Add(Me.ComboBoxItemID)
        Me.GroupBox1.Controls.Add(Me.CheckBoxItemInfo)
        Me.GroupBox1.Controls.Add(Me.ButtonListAll)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEmployeeID)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.CheckBoxEmployeeID)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 120)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.ItemHeight = 13
        Me.ComboBoxCategory.Location = New System.Drawing.Point(152, 16)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(216, 21)
        Me.ComboBoxCategory.TabIndex = 117
        '
        'CheckBoxCategory
        '
        Me.CheckBoxCategory.Location = New System.Drawing.Point(40, 16)
        Me.CheckBoxCategory.Name = "CheckBoxCategory"
        Me.CheckBoxCategory.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxCategory.TabIndex = 116
        Me.CheckBoxCategory.Text = "Category"
        '
        'ComboBoxItemID
        '
        Me.ComboBoxItemID.ItemHeight = 13
        Me.ComboBoxItemID.Location = New System.Drawing.Point(152, 40)
        Me.ComboBoxItemID.Name = "ComboBoxItemID"
        Me.ComboBoxItemID.Size = New System.Drawing.Size(216, 21)
        Me.ComboBoxItemID.TabIndex = 115
        '
        'CheckBoxItemInfo
        '
        Me.CheckBoxItemInfo.Location = New System.Drawing.Point(40, 40)
        Me.CheckBoxItemInfo.Name = "CheckBoxItemInfo"
        Me.CheckBoxItemInfo.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxItemInfo.TabIndex = 114
        Me.CheckBoxItemInfo.Text = "Item Information"
        '
        'ButtonListAll
        '
        Me.ButtonListAll.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonListAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListAll.ForeColor = System.Drawing.Color.White
        Me.ButtonListAll.Image = CType(resources.GetObject("ButtonListAll.Image"), System.Drawing.Image)
        Me.ButtonListAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonListAll.Location = New System.Drawing.Point(416, 16)
        Me.ButtonListAll.Name = "ButtonListAll"
        Me.ButtonListAll.Size = New System.Drawing.Size(96, 40)
        Me.ButtonListAll.TabIndex = 113
        Me.ButtonListAll.Text = "&List All"
        Me.ButtonListAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxEmployeeID
        '
        Me.ComboBoxEmployeeID.DropDownWidth = 400
        Me.ComboBoxEmployeeID.ItemHeight = 13
        Me.ComboBoxEmployeeID.Location = New System.Drawing.Point(152, 88)
        Me.ComboBoxEmployeeID.Name = "ComboBoxEmployeeID"
        Me.ComboBoxEmployeeID.Size = New System.Drawing.Size(216, 21)
        Me.ComboBoxEmployeeID.TabIndex = 112
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.ItemHeight = 13
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(152, 64)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(216, 21)
        Me.ComboBoxDesignNo.TabIndex = 111
        '
        'CheckBoxEmployeeID
        '
        Me.CheckBoxEmployeeID.BackColor = System.Drawing.Color.White
        Me.CheckBoxEmployeeID.ForeColor = System.Drawing.Color.DarkBlue
        Me.CheckBoxEmployeeID.Location = New System.Drawing.Point(40, 88)
        Me.CheckBoxEmployeeID.Name = "CheckBoxEmployeeID"
        Me.CheckBoxEmployeeID.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxEmployeeID.TabIndex = 106
        Me.CheckBoxEmployeeID.Text = "Employee ID"
        '
        'CheckBoxDesignNo
        '
        Me.CheckBoxDesignNo.BackColor = System.Drawing.Color.White
        Me.CheckBoxDesignNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.CheckBoxDesignNo.Location = New System.Drawing.Point(40, 64)
        Me.CheckBoxDesignNo.Name = "CheckBoxDesignNo"
        Me.CheckBoxDesignNo.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxDesignNo.TabIndex = 105
        Me.CheckBoxDesignNo.Text = "Design No"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearch.Location = New System.Drawing.Point(416, 64)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(96, 40)
        Me.ButtonSearch.TabIndex = 104
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(544, 16)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(104, 40)
        Me.ButtonPrintPreview.TabIndex = 103
        Me.ButtonPrintPreview.Text = "&PrintPreview"
        Me.ButtonPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClose.Location = New System.Drawing.Point(544, 64)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(104, 40)
        Me.ButtonClose.TabIndex = 102
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormSearchItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 542)
        Me.Controls.Add(Me.DataGridSearchItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Items"
        CType(Me.DataGridSearchItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormSearchItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setGridData(DataGridSearchItem, "Select ItemID, ItemName, Category, DesignNo, DesignName,SampleWidth, SampleHeight, EmployeeID, EmployeeName from VIEWItemInfo where ItemID<0 Order By ItemID")
            AddtoCombo(ComboBoxItemID, "Item", "convert (nvarchar (10), ItemID)+ ':' + ItemName", "ItemID", , "ItemID")
            AddtoCombo(ComboBoxDesignNo, "Designs", "convert(nvarchar(20), DesignNo)+ ':'+ DesignName", "DesignNo")
            AddtoCombo(ComboBoxEmployeeID, "Employees", "EmployeeName+ ','+ Post +','+ Address", "EmployeeID")
            AddtoCombo(ComboBoxCategory, "Categories", "CategoryName")
            CheckBoxItemInfo.Checked = False
            CheckBoxDesignNo.Checked = False
            CheckBoxEmployeeID.Checked = False
            CheckBoxCategory.Checked = False
            ComboBoxDesignNo.Enabled = CheckBoxDesignNo.Checked
            ComboBoxEmployeeID.Enabled = CheckBoxEmployeeID.Checked
            ComboBoxCategory.Enabled = CheckBoxCategory.Checked
            ComboBoxItemID.Enabled = CheckBoxItemInfo.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            Dim Search As String = ""
            If (CheckBoxDesignNo.Checked = True) And ComboBoxDesignNo.SelectedIndex >= 0 Then Search = " Where DesignNo=" & ComboBoxDesignNo.SelectedValue
            If (CheckBoxEmployeeID.Checked = True) And ComboBoxEmployeeID.SelectedIndex >= 0 Then Search = IIf(Search.Trim.Length > 0, Search & " And ", " Where") & " EmployeeID=" & ComboBoxEmployeeID.SelectedValue
            If (CheckBoxItemInfo.Checked = True) And ComboBoxItemID.SelectedIndex >= 0 Then Search = IIf(Search.Trim.Length > 0, Search & " And ", " Where") & " ItemID=" & ComboBoxItemID.SelectedValue
            If (CheckBoxCategory.Checked = True) And ComboBoxCategory.SelectedIndex >= 0 Then Search = IIf(Search.Trim.Length > 0, Search & " And ", " Where") & " Category='" & ComboBoxCategory.Text & "'"
            setGridData(DataGridSearchItem, "Select ItemID, ItemName, Category, DesignNo, DesignName,SampleWidth, SampleHeight, EmployeeID, EmployeeName from VIEWItemInfo " & Search & " Order By ItemID")
            If getGridRowsCount(DataGridSearchItem) <= 0 Then
                MsgBox("There is no record.")
            End If
            ListAll = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub


    Private Sub CheckBoxDesignNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDesignNo.CheckedChanged
        ComboBoxDesignNo.Enabled = CheckBoxDesignNo.Checked
    End Sub

    Private Sub CheckBoxEmployeeID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEmployeeID.CheckedChanged
        ComboBoxEmployeeID.Enabled = CheckBoxEmployeeID.Checked
    End Sub

    Private Sub CheckBoxCategory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxCategory.CheckedChanged
        ComboBoxCategory.Enabled = CheckBoxCategory.Checked
    End Sub

    Private Sub CheckBoxItemInfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxItemInfo.CheckedChanged
        ComboBoxItemID.Enabled = CheckBoxItemInfo.Checked
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        If getGridRowsCount(DataGridSearchItem) > 0 Then PrintData()
    End Sub
    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportSearchItemInfo
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            If ListAll = False Then
                Try
                    Dim Search As String = ""
                    If (CheckBoxDesignNo.Checked = True) And ComboBoxDesignNo.SelectedIndex >= 0 Then Search = "{VIEWItemInfo.DesignNo}=" & ComboBoxDesignNo.SelectedValue
                    If (CheckBoxEmployeeID.Checked = True) And ComboBoxEmployeeID.SelectedIndex >= 0 Then Search = IIf(Search.Trim.Length > 0, Search & " And ", "") & " {VIEWItemInfo.EmployeeID}=" & ComboBoxEmployeeID.SelectedValue
                    If (CheckBoxItemInfo.Checked = True) And ComboBoxItemID.SelectedIndex >= 0 Then Search = IIf(Search.Trim.Length > 0, Search & " And ", "") & " {VIEWItemInfo.ItemID}=" & ComboBoxItemID.SelectedValue
                    If (CheckBoxCategory.Checked = True) And ComboBoxCategory.SelectedIndex >= 0 Then Search = IIf(Search.Trim.Length > 0, Search & " And ", "") & " {VIEWItemInfo.Category}='" & ComboBoxCategory.Text & "'"
                    f_report.CrystalReportViewer1.SelectionFormula = Search '"" & IIf(RadioButtonCustomerID.Checked = True, "{VIEWCustomerInfo.CustomerID}=" & Val(ComboBoxCustomerID.Text), "{VIEWCustomerInfo.CustomerName} Like '*" & TextBoxCustomerName.Text & "*'") & IIf(CheckBoxOrder.Checked = True, " and {VIEWCustomerInfo.MadeOrders}>0", "") & IIf(CheckBoxJob.Checked = True, " and {VIEWCustomerInfo.AppointedJobs}>0", "") & IIf(CheckBoxCompleteJob.Checked = True, " and {VIEWCustomerInfo.CompletedJobs}>0", "") & IIf(CheckBoxPaidJobs.Checked = True, " and {VIEWCustomerInfo.PaidJobs}>0", "")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
                End Try
            End If
            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonListAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListAll.Click
        setGridData(DataGridSearchItem, "Select ItemID, ItemName, Category, DesignNo, DesignName,SampleWidth, SampleHeight, EmployeeID, EmployeeName from VIEWItemInfo Order By ItemID")
        ListAll = True
    End Sub
End Class
