Public Class FormSearchOrder
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonOrderID As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOrderdate As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxOrderDate As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxOrderID As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridSearchEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents RadioButtonTypeofSales As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTypeofSales As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents RadioButtonDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxSearchOption As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonCustmerInfo As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchOrder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.RadioButtonCustmerInfo = New System.Windows.Forms.RadioButton
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.RadioButtonDesignNo = New System.Windows.Forms.RadioButton
        Me.ComboBoxTypeofSales = New System.Windows.Forms.ComboBox
        Me.RadioButtonTypeofSales = New System.Windows.Forms.RadioButton
        Me.ComboBoxCustomerName = New System.Windows.Forms.ComboBox
        Me.ComboBoxOrderDate = New System.Windows.Forms.ComboBox
        Me.ComboBoxOrderID = New System.Windows.Forms.ComboBox
        Me.RadioButtonOrderID = New System.Windows.Forms.RadioButton
        Me.RadioButtonOrderdate = New System.Windows.Forms.RadioButton
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridSearchEmployee = New System.Windows.Forms.DataGrid
        Me.ComboBoxSearchOption = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCustmerInfo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDesignNo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTypeofSales)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTypeofSales)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCustomerName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxOrderDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxOrderID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOrderID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOrderdate)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 136)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearch.Location = New System.Drawing.Point(64, 96)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(120, 32)
        Me.ButtonSearch.TabIndex = 85
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButtonCustmerInfo
        '
        Me.RadioButtonCustmerInfo.Location = New System.Drawing.Point(392, 24)
        Me.RadioButtonCustmerInfo.Name = "RadioButtonCustmerInfo"
        Me.RadioButtonCustmerInfo.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonCustmerInfo.TabIndex = 84
        Me.RadioButtonCustmerInfo.Text = "Customer"
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.Enabled = False
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(112, 40)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxDesignNo.TabIndex = 83
        '
        'RadioButtonDesignNo
        '
        Me.RadioButtonDesignNo.Location = New System.Drawing.Point(16, 40)
        Me.RadioButtonDesignNo.Name = "RadioButtonDesignNo"
        Me.RadioButtonDesignNo.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonDesignNo.TabIndex = 82
        Me.RadioButtonDesignNo.Text = "Design No"
        '
        'ComboBoxTypeofSales
        '
        Me.ComboBoxTypeofSales.Enabled = False
        Me.ComboBoxTypeofSales.Location = New System.Drawing.Point(480, 64)
        Me.ComboBoxTypeofSales.Name = "ComboBoxTypeofSales"
        Me.ComboBoxTypeofSales.Size = New System.Drawing.Size(224, 21)
        Me.ComboBoxTypeofSales.TabIndex = 81
        '
        'RadioButtonTypeofSales
        '
        Me.RadioButtonTypeofSales.Location = New System.Drawing.Point(392, 64)
        Me.RadioButtonTypeofSales.Name = "RadioButtonTypeofSales"
        Me.RadioButtonTypeofSales.Size = New System.Drawing.Size(88, 16)
        Me.RadioButtonTypeofSales.TabIndex = 78
        Me.RadioButtonTypeofSales.Text = "Type of Sales"
        Me.RadioButtonTypeofSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxCustomerName
        '
        Me.ComboBoxCustomerName.Enabled = False
        Me.ComboBoxCustomerName.Location = New System.Drawing.Point(480, 24)
        Me.ComboBoxCustomerName.Name = "ComboBoxCustomerName"
        Me.ComboBoxCustomerName.Size = New System.Drawing.Size(224, 21)
        Me.ComboBoxCustomerName.TabIndex = 76
        '
        'ComboBoxOrderDate
        '
        Me.ComboBoxOrderDate.Enabled = False
        Me.ComboBoxOrderDate.Location = New System.Drawing.Point(112, 64)
        Me.ComboBoxOrderDate.Name = "ComboBoxOrderDate"
        Me.ComboBoxOrderDate.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxOrderDate.TabIndex = 72
        '
        'ComboBoxOrderID
        '
        Me.ComboBoxOrderID.Enabled = False
        Me.ComboBoxOrderID.Location = New System.Drawing.Point(112, 16)
        Me.ComboBoxOrderID.Name = "ComboBoxOrderID"
        Me.ComboBoxOrderID.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxOrderID.TabIndex = 71
        '
        'RadioButtonOrderID
        '
        Me.RadioButtonOrderID.Checked = True
        Me.RadioButtonOrderID.Location = New System.Drawing.Point(16, 16)
        Me.RadioButtonOrderID.Name = "RadioButtonOrderID"
        Me.RadioButtonOrderID.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonOrderID.TabIndex = 70
        Me.RadioButtonOrderID.TabStop = True
        Me.RadioButtonOrderID.Text = "OrderID"
        '
        'RadioButtonOrderdate
        '
        Me.RadioButtonOrderdate.Location = New System.Drawing.Point(16, 64)
        Me.RadioButtonOrderdate.Name = "RadioButtonOrderdate"
        Me.RadioButtonOrderdate.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonOrderdate.TabIndex = 69
        Me.RadioButtonOrderdate.Text = "Order Date"
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(312, 96)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(120, 32)
        Me.ButtonPrintPreview.TabIndex = 11
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
        Me.ButtonClose.Location = New System.Drawing.Point(576, 96)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(120, 32)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridSearchEmployee
        '
        Me.DataGridSearchEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchEmployee.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionText = "Order Info:"
        Me.DataGridSearchEmployee.DataMember = ""
        Me.DataGridSearchEmployee.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchEmployee.Location = New System.Drawing.Point(8, 168)
        Me.DataGridSearchEmployee.Name = "DataGridSearchEmployee"
        Me.DataGridSearchEmployee.ReadOnly = True
        Me.DataGridSearchEmployee.Size = New System.Drawing.Size(720, 416)
        Me.DataGridSearchEmployee.TabIndex = 70
        '
        'ComboBoxSearchOption
        '
        Me.ComboBoxSearchOption.Items.AddRange(New Object() {"Jobs Confirmed", "Orders Only", "None"})
        Me.ComboBoxSearchOption.Location = New System.Drawing.Point(328, 8)
        Me.ComboBoxSearchOption.Name = "ComboBoxSearchOption"
        Me.ComboBoxSearchOption.Size = New System.Drawing.Size(344, 21)
        Me.ComboBoxSearchOption.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Choose the option whether Orders or Job Confirmed"
        '
        'FormSearchOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(736, 582)
        Me.Controls.Add(Me.ComboBoxSearchOption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridSearchEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Orders"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        If getGridRowsCount(DataGridSearchEmployee) > 0 Then
            Try
                Dim f_report As New FormReportViewer
                Dim rptReport As New CrystalReportSearchOrders
                rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
                rptReport.Load()
                f_report.CrystalReportViewer1.ReportSource = rptReport
                Dim Search As String = IIf(RadioButtonOrderID.Checked = True, "{VIEWOrders.OrderID}=" & Val(ComboBoxOrderID.Text), IIf(RadioButtonDesignNo.Checked = True, "{VIEWOrders.DesignNo}=" & Val(ComboBoxDesignNo.Text), IIf(RadioButtonOrderdate.Checked = True, "{VIEWOrders.OrderDate}=#" & ComboBoxOrderDate.Text & "#", IIf(RadioButtonCustmerInfo.Checked = True, "{VIEWOrders.CustomerID}=" & Val(ComboBoxCustomerName.SelectedValue), _
                                                    IIf(RadioButtonTypeofSales.Checked = True, "{VIEWOrders.SalesType}='" & ComboBoxTypeofSales.Text & "'", "OrderID>0") _
                                                ))))
                Search = Search & IIf(ComboBoxSearchOption.SelectedIndex = 0, " And {VIEWOrders.MadeJob}>0", IIf(ComboBoxSearchOption.SelectedIndex = 1, " And {VIEWOrders.MadeJob}<0", ""))
                f_report.CrystalReportViewer1.SelectionFormula = Search
                f_report.MyDBase = rptReport.Database
                f_report.RSelect()
                f_report.CrystalReportViewer1.RefreshReport()
                f_report.CrystalReportViewer1.Show()
                f_report.Show()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
            End Try
        End If
    End Sub

    Private Sub FormSearchOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddtoCombo(Me.ComboBoxCustomerName, "Customers", "CustomerName + ','+ CompanyName+ ','+ Address", "CustomerID")
            AddtoCombo(Me.ComboBoxOrderDate, "Orders", "OrderDate")
            AddtoCombo(ComboBoxDesignNo, "Designs", "convert( nvarchar(10),DesignNo) + ':' + DesignName", "DesignNo")
            AddtoCombo(Me.ComboBoxOrderID, "Orders", "OrderID")
            AddtoCombo(Me.ComboBoxTypeofSales, "Orders", "SalesType")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub RadioButtonOrderID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOrderID.CheckedChanged
        ComboBoxOrderID.Enabled = RadioButtonOrderID.Checked
    End Sub

    Private Sub RadioButtonDesignNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDesignNo.CheckedChanged
        ComboBoxDesignNo.Enabled = RadioButtonDesignNo.Checked
    End Sub

    Private Sub RadioButtonOrderdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOrderdate.CheckedChanged
        ComboBoxOrderDate.Enabled = RadioButtonOrderdate.Checked
    End Sub

    Private Sub RadioButtonCustmerInfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonCustmerInfo.CheckedChanged
        ComboBoxCustomerName.Enabled = RadioButtonCustmerInfo.Checked
    End Sub

    Private Sub RadioButtonTypeofSales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTypeofSales.CheckedChanged
        ComboBoxTypeofSales.Enabled = RadioButtonTypeofSales.Checked
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            Dim Search As String
            Search = " Where " & IIf(RadioButtonOrderID.Checked = True, "OrderID=" & Val(ComboBoxOrderID.Text), _
                                    IIf(RadioButtonDesignNo.Checked = True, "DesignNo=" & Val(ComboBoxDesignNo.Text), _
                                        IIf(RadioButtonOrderdate.Checked = True, "OrderDate='" & ComboBoxOrderDate.Text & "'", _
                                            IIf(RadioButtonCustmerInfo.Checked = True, "CustomerID=" & Val(ComboBoxCustomerName.SelectedValue), _
                                                IIf(RadioButtonTypeofSales.Checked = True, "SalesType='" & ComboBoxTypeofSales.Text & "'", "OrderID>0") _
                                            ))))
            setGridData(DataGridSearchEmployee, "SELECT OrderID, OrderDate, CustomerID, CustomerName, CompanyName, SalesType, DesignNo, DesignName, Qty AS Quantity, UnitPirce,Amount FROM VIEWOrders " & Search & IIf(ComboBoxSearchOption.SelectedIndex = 0, " And MadeJob is Not NULL", IIf(ComboBoxSearchOption.SelectedIndex = 1, " And MadeJob is NULL", "")) & " ORDER BY OrderID, DesignNo")
            If getGridRowsCount(DataGridSearchEmployee) <= 0 Then
                MsgBox("There is no record.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ComboBoxSearchOption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSearchOption.SelectedIndexChanged

    End Sub
End Class
