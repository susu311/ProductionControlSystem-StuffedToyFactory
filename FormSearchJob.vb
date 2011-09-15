Public Class FormSearchJob
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
    Friend WithEvents DataGridSearchEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxJobNo As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonJobNo As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerdeliverydateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerdelieverydatafrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents RadioButtonDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxCustomerName As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxtypeofsale As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxDeliveryDate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxConfirmedDate As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxOrderID As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonOrderID As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxSaleType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchJob))
        Me.DataGridSearchEmployee = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBoxSaleType = New System.Windows.Forms.ComboBox
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.ComboBoxOrderID = New System.Windows.Forms.ComboBox
        Me.RadioButtonOrderID = New System.Windows.Forms.RadioButton
        Me.CheckBoxConfirmedDate = New System.Windows.Forms.CheckBox
        Me.CheckBoxDeliveryDate = New System.Windows.Forms.CheckBox
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox
        Me.CheckBoxtypeofsale = New System.Windows.Forms.CheckBox
        Me.CheckBoxCustomerName = New System.Windows.Forms.CheckBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.DateTimePickerdeliverydateto = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerdelieverydatafrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerfrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButtonDesignNo = New System.Windows.Forms.RadioButton
        Me.ComboBoxJobNo = New System.Windows.Forms.ComboBox
        Me.RadioButtonJobNo = New System.Windows.Forms.RadioButton
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSearchEmployee
        '
        Me.DataGridSearchEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchEmployee.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionText = "Job Info:"
        Me.DataGridSearchEmployee.DataMember = ""
        Me.DataGridSearchEmployee.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchEmployee.Location = New System.Drawing.Point(7, 184)
        Me.DataGridSearchEmployee.Name = "DataGridSearchEmployee"
        Me.DataGridSearchEmployee.ReadOnly = True
        Me.DataGridSearchEmployee.Size = New System.Drawing.Size(776, 376)
        Me.DataGridSearchEmployee.TabIndex = 73
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxSaleType)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxOrderID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOrderID)
        Me.GroupBox1.Controls.Add(Me.CheckBoxConfirmedDate)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDeliveryDate)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBox1.Controls.Add(Me.CheckBoxtypeofsale)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCustomerName)
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdeliverydateto)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdelieverydatafrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerfrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDesignNo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxJobNo)
        Me.GroupBox1.Controls.Add(Me.RadioButtonJobNo)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 168)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'ComboBoxSaleType
        '
        Me.ComboBoxSaleType.Location = New System.Drawing.Point(497, 77)
        Me.ComboBoxSaleType.Name = "ComboBoxSaleType"
        Me.ComboBoxSaleType.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxSaleType.TabIndex = 110
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(97, 74)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxDesignNo.TabIndex = 109
        '
        'ComboBoxOrderID
        '
        Me.ComboBoxOrderID.Location = New System.Drawing.Point(97, 45)
        Me.ComboBoxOrderID.Name = "ComboBoxOrderID"
        Me.ComboBoxOrderID.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxOrderID.TabIndex = 108
        '
        'RadioButtonOrderID
        '
        Me.RadioButtonOrderID.Checked = True
        Me.RadioButtonOrderID.Location = New System.Drawing.Point(9, 48)
        Me.RadioButtonOrderID.Name = "RadioButtonOrderID"
        Me.RadioButtonOrderID.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonOrderID.TabIndex = 107
        Me.RadioButtonOrderID.TabStop = True
        Me.RadioButtonOrderID.Text = "OrderID"
        '
        'CheckBoxConfirmedDate
        '
        Me.CheckBoxConfirmedDate.Location = New System.Drawing.Point(9, 120)
        Me.CheckBoxConfirmedDate.Name = "CheckBoxConfirmedDate"
        Me.CheckBoxConfirmedDate.Size = New System.Drawing.Size(104, 16)
        Me.CheckBoxConfirmedDate.TabIndex = 106
        Me.CheckBoxConfirmedDate.Text = "Confirmed Date"
        '
        'CheckBoxDeliveryDate
        '
        Me.CheckBoxDeliveryDate.Location = New System.Drawing.Point(393, 16)
        Me.CheckBoxDeliveryDate.Name = "CheckBoxDeliveryDate"
        Me.CheckBoxDeliveryDate.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxDeliveryDate.TabIndex = 105
        Me.CheckBoxDeliveryDate.Text = "Delivery Date"
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(497, 48)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxCustomerName.TabIndex = 104
        Me.TextBoxCustomerName.Text = ""
        '
        'CheckBoxtypeofsale
        '
        Me.CheckBoxtypeofsale.Location = New System.Drawing.Point(393, 80)
        Me.CheckBoxtypeofsale.Name = "CheckBoxtypeofsale"
        Me.CheckBoxtypeofsale.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxtypeofsale.TabIndex = 103
        Me.CheckBoxtypeofsale.Text = "Type of Sale"
        '
        'CheckBoxCustomerName
        '
        Me.CheckBoxCustomerName.Location = New System.Drawing.Point(393, 48)
        Me.CheckBoxCustomerName.Name = "CheckBoxCustomerName"
        Me.CheckBoxCustomerName.Size = New System.Drawing.Size(112, 16)
        Me.CheckBoxCustomerName.TabIndex = 102
        Me.CheckBoxCustomerName.Text = "Customer Name"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSearch.Location = New System.Drawing.Point(408, 104)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(55, 56)
        Me.ButtonSearch.TabIndex = 101
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DateTimePickerdeliverydateto
        '
        Me.DateTimePickerdeliverydateto.Location = New System.Drawing.Point(657, 16)
        Me.DateTimePickerdeliverydateto.Name = "DateTimePickerdeliverydateto"
        Me.DateTimePickerdeliverydateto.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerdeliverydateto.TabIndex = 98
        '
        'DateTimePickerdelieverydatafrom
        '
        Me.DateTimePickerdelieverydatafrom.Location = New System.Drawing.Point(529, 16)
        Me.DateTimePickerdelieverydatafrom.Name = "DateTimePickerdelieverydatafrom"
        Me.DateTimePickerdelieverydatafrom.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerdelieverydatafrom.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(633, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(497, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "From"
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(152, 136)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.TabIndex = 87
        '
        'DateTimePickerfrom
        '
        Me.DateTimePickerfrom.Location = New System.Drawing.Point(152, 112)
        Me.DateTimePickerfrom.Name = "DateTimePickerfrom"
        Me.DateTimePickerfrom.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 24)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 24)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "From"
        '
        'RadioButtonDesignNo
        '
        Me.RadioButtonDesignNo.BackColor = System.Drawing.Color.White
        Me.RadioButtonDesignNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.RadioButtonDesignNo.Location = New System.Drawing.Point(9, 76)
        Me.RadioButtonDesignNo.Name = "RadioButtonDesignNo"
        Me.RadioButtonDesignNo.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonDesignNo.TabIndex = 82
        Me.RadioButtonDesignNo.Text = "Design No"
        '
        'ComboBoxJobNo
        '
        Me.ComboBoxJobNo.Location = New System.Drawing.Point(97, 16)
        Me.ComboBoxJobNo.Name = "ComboBoxJobNo"
        Me.ComboBoxJobNo.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxJobNo.TabIndex = 71
        '
        'RadioButtonJobNo
        '
        Me.RadioButtonJobNo.Checked = True
        Me.RadioButtonJobNo.Location = New System.Drawing.Point(9, 20)
        Me.RadioButtonJobNo.Name = "RadioButtonJobNo"
        Me.RadioButtonJobNo.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonJobNo.TabIndex = 70
        Me.RadioButtonJobNo.TabStop = True
        Me.RadioButtonJobNo.Text = "Job No"
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(536, 104)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(88, 56)
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
        Me.ButtonClose.Location = New System.Drawing.Point(696, 104)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FormSearchJob
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.DataGridSearchEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Jobs"
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            Dim Search As String = ""
            Search = " Where " & IIf(RadioButtonJobNo.Checked = True And (ComboBoxJobNo.Text.Length) > 0 And ComboBoxJobNo.Text <> "System.Data.DataRowView", "JobNo=" & (ComboBoxJobNo.Text), IIf(RadioButtonOrderID.Checked = True And ComboBoxOrderID.Text.Length > 0 And ComboBoxOrderID.Text <> "System.Data.DataRowView", "OrderID=" & ComboBoxOrderID.Text, IIf(RadioButtonDesignNo.Checked = True And ComboBoxDesignNo.Text.Length > 0 And ComboBoxDesignNo.Text <> "System.Data.DataRowView", "DesignNo=" & ComboBoxDesignNo.Text, "JobNo>0")))
            If CheckBoxConfirmedDate.Checked = True And DateTimePickerfrom.Value < DateTimePickerTo.Value Then Search = Search & " And ConfirmedDate Between '" & DateTimePickerfrom.Value.ToShortDateString & "' and '" & DateTimePickerTo.Value.ToShortDateString & "'"
            If CheckBoxDeliveryDate.Checked = True And DateTimePickerdelieverydatafrom.Value < DateTimePickerdeliverydateto.Value Then Search = Search & " And DeliveryDate Between '" & DateTimePickerdelieverydatafrom.Value.ToShortDateString & "' and '" & DateTimePickerdeliverydateto.Value.ToShortDateString & "'"
            If CheckBoxCustomerName.Checked = True Then Search = Search & " And CustomerName Like '%" & TextBoxCustomerName.Text & "%'"
            If CheckBoxtypeofsale.Checked = True Then Search = Search & " And SaleType='" & ComboBoxSaleType.Text & "'"
            setGridData(DataGridSearchEmployee, "SELECT JobNo, OrderID, DesignNo, DesignName, Qty, UnitPrice, Amount, ConfirmedDate, DeliveryDate, SaleType, CustomerID, CustomerName, CompanyName, OrderDate FROM VIEWJobs " & Search & " ORDER BY JobNo, OrderID, DesignNo")
            If getGridRowsCount(DataGridSearchEmployee) <= 0 Then
                MsgBox("There is no record.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub FormSearchJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddtoCombo(ComboBoxDesignNo, "VIEWJobs", "DesignNo")
            AddtoCombo(ComboBoxJobNo, "VIEWJobs", "JobNo")
            AddtoCombo(ComboBoxOrderID, "VIEWJobs", "OrderID")
            AddtoCombo(ComboBoxSaleType, "VIEWJobs", "SaleType")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub RadioButtonJobNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonJobNo.CheckedChanged
        ComboBoxJobNo.Enabled = RadioButtonJobNo.Checked
    End Sub

    Private Sub RadioButtonOrderID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOrderID.CheckedChanged
        ComboBoxOrderID.Enabled = RadioButtonOrderID.Checked
    End Sub

    Private Sub RadioButtonDesignNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDesignNo.CheckedChanged
        ComboBoxDesignNo.Enabled = RadioButtonDesignNo.Checked
    End Sub

    Private Sub CheckBoxConfirmedDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxConfirmedDate.CheckedChanged
        DateTimePickerfrom.Enabled = CheckBoxConfirmedDate.Checked
        DateTimePickerTo.Enabled = CheckBoxConfirmedDate.Checked
    End Sub

    Private Sub CheckBoxDeliveryDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDeliveryDate.CheckedChanged
        DateTimePickerdelieverydatafrom.Enabled = CheckBoxDeliveryDate.Checked
        DateTimePickerdeliverydateto.Enabled = CheckBoxDeliveryDate.Checked
    End Sub

    Private Sub CheckBoxCustomerName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxCustomerName.CheckedChanged
        TextBoxCustomerName.Enabled = CheckBoxCustomerName.Checked
    End Sub

    Private Sub CheckBoxtypeofsale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxtypeofsale.CheckedChanged
        ComboBoxSaleType.Enabled = CheckBoxtypeofsale.Checked
    End Sub

    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportSearchJobs
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            Dim Search As String = IIf(RadioButtonJobNo.Checked = True And (ComboBoxJobNo.Text.Length) > 0 And ComboBoxJobNo.Text <> "System.Data.DataRowView", "{Command.JobNo}=" & (ComboBoxJobNo.Text), IIf(RadioButtonOrderID.Checked = True And ComboBoxOrderID.Text.Length > 0 And ComboBoxOrderID.Text <> "System.Data.DataRowView", "{Command.OrderID}=" & ComboBoxOrderID.Text, IIf(RadioButtonDesignNo.Checked = True And ComboBoxDesignNo.Text.Length > 0 And ComboBoxDesignNo.Text <> "System.Data.DataRowView", "{Command.DesignNo}=" & ComboBoxDesignNo.Text, "{Command.JobNo}>0")))
            If CheckBoxConfirmedDate.Checked = True And DateTimePickerfrom.Value < DateTimePickerTo.Value Then Search = Search & " And {Command.ConfirmedDate}>=#" & DateTimePickerfrom.Value.ToShortDateString & "# and {Command.ConfirmedDate}<=#" & DateTimePickerTo.Value.ToShortDateString & "#"
            If CheckBoxDeliveryDate.Checked = True And DateTimePickerdelieverydatafrom.Value < DateTimePickerdeliverydateto.Value Then Search = Search & " And {Command.DeliveryDate}>=#" & DateTimePickerdelieverydatafrom.Value.ToShortDateString & "# and {Command.DeliveryDate}<=#" & DateTimePickerdeliverydateto.Value.ToShortDateString & "#"
            If CheckBoxCustomerName.Checked = True Then Search = Search & " And {Command.CustomerName} Like '%" & TextBoxCustomerName.Text & "%'"
            If CheckBoxtypeofsale.Checked = True Then Search = Search & " And {Command.SaleType}='" & ComboBoxSaleType.Text & "'"

            f_report.CrystalReportViewer1.SelectionFormula = Search ' "PurchaseDate}>=#" & SQLDateTime(DateTimePickerFrom.Value, Main.SQLDType.sqlDateOnly, True) & "# and {ViewPurchaseInfo.PurchaseDate}<=#" & SQLDateTime(DateTimePickerTo.Value, Main.SQLDType.sqlDateOnly, True) & "#"
            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        If getGridRowsCount(DataGridSearchEmployee) > 0 Then PrintData()
    End Sub
End Class
