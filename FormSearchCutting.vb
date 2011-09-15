Public Class FormSearchCutting
    Inherits System.Windows.Forms.Form
    Dim Search As String = ""

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
    Friend WithEvents DataGridSearchCutting As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxSearchWithDate As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonListAll As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents CheckBoxDesignNo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEmployeeID As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Labelfrom As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchCutting))
        Me.DataGridSearchCutting = New System.Windows.Forms.DataGrid
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonListAll = New System.Windows.Forms.Button
        Me.ComboBoxEmployeeID = New System.Windows.Forms.ComboBox
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.CheckBoxSearchWithDate = New System.Windows.Forms.CheckBox
        Me.CheckBoxDesignNo = New System.Windows.Forms.CheckBox
        Me.CheckBoxEmployeeID = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePickerfrom = New System.Windows.Forms.DateTimePicker
        Me.Labelfrom = New System.Windows.Forms.Label
        CType(Me.DataGridSearchCutting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSearchCutting
        '
        Me.DataGridSearchCutting.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchCutting.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchCutting.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchCutting.CaptionText = "Cutting Info:"
        Me.DataGridSearchCutting.DataMember = ""
        Me.DataGridSearchCutting.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchCutting.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchCutting.Location = New System.Drawing.Point(8, 192)
        Me.DataGridSearchCutting.Name = "DataGridSearchCutting"
        Me.DataGridSearchCutting.ReadOnly = True
        Me.DataGridSearchCutting.Size = New System.Drawing.Size(776, 328)
        Me.DataGridSearchCutting.TabIndex = 76
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSearch.Location = New System.Drawing.Point(224, 16)
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
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(312, 16)
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
        Me.ButtonClose.Location = New System.Drawing.Point(432, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Groupbuttons
        '
        Me.Groupbuttons.BackColor = System.Drawing.Color.White
        Me.Groupbuttons.Controls.Add(Me.ButtonClear)
        Me.Groupbuttons.Controls.Add(Me.ButtonSearch)
        Me.Groupbuttons.Controls.Add(Me.ButtonPrintPreview)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Controls.Add(Me.ButtonListAll)
        Me.Groupbuttons.ForeColor = System.Drawing.Color.DarkBlue
        Me.Groupbuttons.Location = New System.Drawing.Point(128, 104)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(512, 80)
        Me.Groupbuttons.TabIndex = 82
        Me.Groupbuttons.TabStop = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Image = CType(resources.GetObject("ButtonClear.Image"), System.Drawing.Image)
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClear.Location = New System.Drawing.Point(24, 16)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClear.TabIndex = 94
        Me.ButtonClear.Text = "&Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonListAll
        '
        Me.ButtonListAll.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonListAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListAll.ForeColor = System.Drawing.Color.White
        Me.ButtonListAll.Image = CType(resources.GetObject("ButtonListAll.Image"), System.Drawing.Image)
        Me.ButtonListAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonListAll.Location = New System.Drawing.Point(120, 16)
        Me.ButtonListAll.Name = "ButtonListAll"
        Me.ButtonListAll.Size = New System.Drawing.Size(56, 56)
        Me.ButtonListAll.TabIndex = 93
        Me.ButtonListAll.Text = "&List All"
        Me.ButtonListAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBoxEmployeeID
        '
        Me.ComboBoxEmployeeID.Location = New System.Drawing.Point(496, 72)
        Me.ComboBoxEmployeeID.Name = "ComboBoxEmployeeID"
        Me.ComboBoxEmployeeID.Size = New System.Drawing.Size(272, 21)
        Me.ComboBoxEmployeeID.TabIndex = 89
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(496, 32)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(272, 21)
        Me.ComboBoxDesignNo.TabIndex = 90
        '
        'CheckBoxSearchWithDate
        '
        Me.CheckBoxSearchWithDate.Location = New System.Drawing.Point(48, 8)
        Me.CheckBoxSearchWithDate.Name = "CheckBoxSearchWithDate"
        Me.CheckBoxSearchWithDate.Size = New System.Drawing.Size(120, 24)
        Me.CheckBoxSearchWithDate.TabIndex = 93
        Me.CheckBoxSearchWithDate.Text = "Search with &Date"
        '
        'CheckBoxDesignNo
        '
        Me.CheckBoxDesignNo.Location = New System.Drawing.Point(416, 32)
        Me.CheckBoxDesignNo.Name = "CheckBoxDesignNo"
        Me.CheckBoxDesignNo.Size = New System.Drawing.Size(88, 16)
        Me.CheckBoxDesignNo.TabIndex = 94
        Me.CheckBoxDesignNo.Text = "DesignNo"
        '
        'CheckBoxEmployeeID
        '
        Me.CheckBoxEmployeeID.Location = New System.Drawing.Point(416, 72)
        Me.CheckBoxEmployeeID.Name = "CheckBoxEmployeeID"
        Me.CheckBoxEmployeeID.Size = New System.Drawing.Size(88, 16)
        Me.CheckBoxEmployeeID.TabIndex = 95
        Me.CheckBoxEmployeeID.Text = "EmployeeID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerfrom)
        Me.GroupBox1.Controls.Add(Me.Labelfrom)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 80)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(88, 48)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePickerTo.TabIndex = 93
        Me.DateTimePickerTo.Value = New Date(2007, 10, 21, 16, 27, 51, 750)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(40, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "To"
        '
        'DateTimePickerfrom
        '
        Me.DateTimePickerfrom.Location = New System.Drawing.Point(88, 24)
        Me.DateTimePickerfrom.Name = "DateTimePickerfrom"
        Me.DateTimePickerfrom.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePickerfrom.TabIndex = 91
        Me.DateTimePickerfrom.Value = New Date(2007, 10, 21, 16, 27, 49, 953)
        '
        'Labelfrom
        '
        Me.Labelfrom.BackColor = System.Drawing.Color.White
        Me.Labelfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfrom.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelfrom.Location = New System.Drawing.Point(32, 24)
        Me.Labelfrom.Name = "Labelfrom"
        Me.Labelfrom.Size = New System.Drawing.Size(40, 16)
        Me.Labelfrom.TabIndex = 92
        Me.Labelfrom.Text = "From"
        '
        'FormSearchCutting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 534)
        Me.Controls.Add(Me.CheckBoxSearchWithDate)
        Me.Controls.Add(Me.ComboBoxEmployeeID)
        Me.Controls.Add(Me.ComboBoxDesignNo)
        Me.Controls.Add(Me.CheckBoxDesignNo)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridSearchCutting)
        Me.Controls.Add(Me.CheckBoxEmployeeID)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchCutting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Cutting"
        CType(Me.DataGridSearchCutting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormSearchCutting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setGridData(DataGridSearchCutting, "Select DesignNo,DesignName, EmployeeID,EmployeeName, CuttingDate,Qualifiedqty, RejectedQty, Status from VIEWCuttings Where DesignNo<0 Order By DesignNo")
        AddtoCombo(ComboBoxDesignNo, "Designs", "'' + CONVERT(nVarChar(20),DesignNo) + ': ' +DesignName", "DesignNo", , "DesignNo")
        AddtoCombo(ComboBoxEmployeeID, "Employees", "EmployeeName +', '+Post +','+ Address", "EmployeeID")
        DateTimePickerfrom.Enabled = CheckBoxSearchWithDate.Checked
        DateTimePickerTo.Enabled = CheckBoxSearchWithDate.Checked
        CheckBoxDesignNo.Checked = False
        CheckBoxEmployeeID.Checked = False
        ComboBoxDesignNo.Enabled = CheckBoxDesignNo.Checked
        ComboBoxEmployeeID.Enabled = CheckBoxEmployeeID.Checked
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            Dim SQL As String = "Select Distinct DesignNo,DesignName, EmployeeID,EmployeeName, CuttingDate, Qualifiedqty, RejectedQty, Status from VIEWCuttings"
            Search = ""
            If CheckBoxDesignNo.Checked = True Then Search = " Where DesignNo=" & Val(ComboBoxDesignNo.SelectedValue)
            If CheckBoxEmployeeID.Checked = True Then Search = Search & IIf(Search.Length > 0, " And ", " Where ") & " EmployeeID=" & Val(ComboBoxEmployeeID.SelectedValue)
            If CheckBoxSearchWithDate.Checked = True Then Search = Search & IIf(Search.Length > 0, " And ", " Where ") & "CuttingDate Between '" & SQLDateTime(DateTimePickerfrom.Value, Main.SQLDType.sqlDateOnly, True) & "' and '" & SQLDateTime(DateTimePickerTo.Value, Main.SQLDType.sqlDateOnly, True) & "'"
            setGridData(DataGridSearchCutting, SQL & Search & " Order By DesignNo")
            If getGridRowsCount(DataGridSearchCutting) <= 0 Then
                MsgBox("There is no record.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub CheckBoxSearchWithDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSearchWithDate.CheckedChanged
        DateTimePickerfrom.Enabled = CheckBoxSearchWithDate.Checked
        DateTimePickerTo.Enabled = CheckBoxSearchWithDate.Checked
    End Sub


    Private Sub ButtonListAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListAll.Click
        Try
            Dim SQL As String = "Select Distinct DesignNo, DesignName, EmployeeID, EmployeeName, CuttingDate, Qualifiedqty, RejectedQty, Status from VIEWCuttings"
            setGridData(DataGridSearchCutting, SQL & " Order By DesignNo")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        ComboBoxDesignNo.SelectedIndex = -1
        ComboBoxEmployeeID.SelectedIndex = -1
        CheckBoxSearchWithDate.Checked = False
        DateTimePickerfrom.Enabled = CheckBoxSearchWithDate.Checked
        DateTimePickerTo.Enabled = CheckBoxSearchWithDate.Checked
        setGridData(DataGridSearchCutting, "Select DesignNo, DesignName,EmployeeID,EmployeeName, CuttingDate, QualifiedQty,RejectedQty,Status from VIEWCuttings Where EmployeeID<-1 and DesignNo<=-1")
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        If getGridRowsCount(DataGridSearchCutting) > 0 Then PrintData()
    End Sub
    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportSearchCutting
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            Dim SelectionFormula As String = ""
            If CheckBoxDesignNo.Checked = True Then SelectionFormula = "{VIEWCuttings.DesignNo}=" & Val(ComboBoxDesignNo.SelectedValue)
            If CheckBoxEmployeeID.Checked = True Then SelectionFormula = "{VIEWCuttings.EmployeeID}=" & Val(ComboBoxEmployeeID.SelectedValue)
            If CheckBoxSearchWithDate.Checked = True Then SelectionFormula = SelectionFormula & IIf(SelectionFormula.Length > 0, " And ", "") & "{VIEWCuttings.CuttingDate}>=#" & SQLDateTime(DateTimePickerfrom.Value, Main.SQLDType.sqlDateOnly, True) & "# and {VIEWCuttings.CuttingDate}<=#" & SQLDateTime(DateTimePickerTo.Value, Main.SQLDType.sqlDateOnly, True) & "#"
            f_report.CrystalReportViewer1.SelectionFormula = SelectionFormula
            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub CheckBoxDesignNo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxDesignNo.CheckedChanged
        ComboBoxDesignNo.Enabled = CheckBoxDesignNo.Checked
    End Sub

    Private Sub CheckBoxEmployeeID_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxEmployeeID.CheckedChanged
        ComboBoxEmployeeID.Enabled = CheckBoxEmployeeID.Checked
    End Sub
End Class
