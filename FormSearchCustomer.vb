Public Class FormSearchCustomer
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
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonCustomerID As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxJob As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOrder As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButtonCustomerName As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxCompleteJob As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPaidJobs As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridSearchCustomer As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchCustomer))
        Me.DataGridSearchCustomer = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBoxPaidJobs = New System.Windows.Forms.CheckBox
        Me.CheckBoxCompleteJob = New System.Windows.Forms.CheckBox
        Me.CheckBoxJob = New System.Windows.Forms.CheckBox
        Me.CheckBoxOrder = New System.Windows.Forms.CheckBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox
        Me.RadioButtonCustomerName = New System.Windows.Forms.RadioButton
        Me.ComboBoxCustomerID = New System.Windows.Forms.ComboBox
        Me.RadioButtonCustomerID = New System.Windows.Forms.RadioButton
        CType(Me.DataGridSearchCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSearchCustomer
        '
        Me.DataGridSearchCustomer.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchCustomer.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchCustomer.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchCustomer.CaptionText = "Customers Info:"
        Me.DataGridSearchCustomer.DataMember = ""
        Me.DataGridSearchCustomer.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchCustomer.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchCustomer.Location = New System.Drawing.Point(16, 152)
        Me.DataGridSearchCustomer.Name = "DataGridSearchCustomer"
        Me.DataGridSearchCustomer.ReadOnly = True
        Me.DataGridSearchCustomer.Size = New System.Drawing.Size(544, 384)
        Me.DataGridSearchCustomer.TabIndex = 79
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxPaidJobs)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCompleteJob)
        Me.GroupBox1.Controls.Add(Me.CheckBoxJob)
        Me.GroupBox1.Controls.Add(Me.CheckBoxOrder)
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCustomerName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCustomerID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCustomerID)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 144)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        '
        'CheckBoxPaidJobs
        '
        Me.CheckBoxPaidJobs.Location = New System.Drawing.Point(376, 112)
        Me.CheckBoxPaidJobs.Name = "CheckBoxPaidJobs"
        Me.CheckBoxPaidJobs.Size = New System.Drawing.Size(112, 16)
        Me.CheckBoxPaidJobs.TabIndex = 108
        Me.CheckBoxPaidJobs.Text = "Paid Jobs"
        '
        'CheckBoxCompleteJob
        '
        Me.CheckBoxCompleteJob.Location = New System.Drawing.Point(376, 80)
        Me.CheckBoxCompleteJob.Name = "CheckBoxCompleteJob"
        Me.CheckBoxCompleteJob.Size = New System.Drawing.Size(112, 16)
        Me.CheckBoxCompleteJob.TabIndex = 107
        Me.CheckBoxCompleteJob.Text = "Completed Jobs"
        '
        'CheckBoxJob
        '
        Me.CheckBoxJob.Location = New System.Drawing.Point(376, 48)
        Me.CheckBoxJob.Name = "CheckBoxJob"
        Me.CheckBoxJob.Size = New System.Drawing.Size(104, 16)
        Me.CheckBoxJob.TabIndex = 106
        Me.CheckBoxJob.Text = "Appointed Jobs"
        '
        'CheckBoxOrder
        '
        Me.CheckBoxOrder.Location = New System.Drawing.Point(376, 16)
        Me.CheckBoxOrder.Name = "CheckBoxOrder"
        Me.CheckBoxOrder.Size = New System.Drawing.Size(120, 16)
        Me.CheckBoxOrder.TabIndex = 105
        Me.CheckBoxOrder.Text = "Made  orders"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSearch.Location = New System.Drawing.Point(48, 80)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSearch.TabIndex = 104
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
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(136, 80)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(88, 56)
        Me.ButtonPrintPreview.TabIndex = 103
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
        Me.ButtonClose.Location = New System.Drawing.Point(256, 80)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 102
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(112, 48)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxCustomerName.TabIndex = 83
        Me.TextBoxCustomerName.Text = ""
        '
        'RadioButtonCustomerName
        '
        Me.RadioButtonCustomerName.BackColor = System.Drawing.Color.White
        Me.RadioButtonCustomerName.ForeColor = System.Drawing.Color.DarkBlue
        Me.RadioButtonCustomerName.Location = New System.Drawing.Point(8, 48)
        Me.RadioButtonCustomerName.Name = "RadioButtonCustomerName"
        Me.RadioButtonCustomerName.Size = New System.Drawing.Size(104, 16)
        Me.RadioButtonCustomerName.TabIndex = 82
        Me.RadioButtonCustomerName.Text = "Customer Name"
        '
        'ComboBoxCustomerID
        '
        Me.ComboBoxCustomerID.Location = New System.Drawing.Point(112, 16)
        Me.ComboBoxCustomerID.Name = "ComboBoxCustomerID"
        Me.ComboBoxCustomerID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxCustomerID.TabIndex = 71
        '
        'RadioButtonCustomerID
        '
        Me.RadioButtonCustomerID.BackColor = System.Drawing.Color.White
        Me.RadioButtonCustomerID.Checked = True
        Me.RadioButtonCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.RadioButtonCustomerID.Location = New System.Drawing.Point(8, 16)
        Me.RadioButtonCustomerID.Name = "RadioButtonCustomerID"
        Me.RadioButtonCustomerID.Size = New System.Drawing.Size(96, 16)
        Me.RadioButtonCustomerID.TabIndex = 70
        Me.RadioButtonCustomerID.TabStop = True
        Me.RadioButtonCustomerID.Text = "Customer ID"
        '
        'FormSearchCustomer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 542)
        Me.Controls.Add(Me.DataGridSearchCustomer)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Searching Customers"
        CType(Me.DataGridSearchCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            setGridData(DataGridSearchCustomer, "Select CustomerID, CustomerName, CompanyName, Address, Country, PhoneNo, EMail from VIEWCustomerInfo Where " & IIf(RadioButtonCustomerID.Checked = True, "CustomerID=" & Val(ComboBoxCustomerID.Text), "CustomerName Like '%" & TextBoxCustomerName.Text & "%'") & IIf(CheckBoxOrder.Checked = True, " and MadeOrders is Not Null ", "") & IIf(CheckBoxJob.Checked = True, " and AppointedJobs is Not Null", "") & IIf(CheckBoxCompleteJob.Checked = True, " and CompletedJobs is Not Null", "") & IIf(CheckBoxPaidJobs.Checked = True, " and PaidJobs is Not Null", ""))
            If getGridRowsCount(DataGridSearchCustomer) <= 0 Then
                MsgBox("Record not Found.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub FormSearchCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddtoCombo(ComboBoxCustomerID, "Customers", "CustomerID")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        If getGridRowsCount(DataGridSearchCustomer) > 0 Then PrintData()
    End Sub

    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportSearchCustomerInfo
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            f_report.CrystalReportViewer1.SelectionFormula = "" & IIf(RadioButtonCustomerID.Checked = True, "{VIEWCustomerInfo.CustomerID}=" & Val(ComboBoxCustomerID.Text), "{VIEWCustomerInfo.CustomerName} Like '*" & TextBoxCustomerName.Text & "*'") & IIf(CheckBoxOrder.Checked = True, " and {VIEWCustomerInfo.MadeOrders}>0", "") & IIf(CheckBoxJob.Checked = True, " and {VIEWCustomerInfo.AppointedJobs}>0", "") & IIf(CheckBoxCompleteJob.Checked = True, " and {VIEWCustomerInfo.CompletedJobs}>0", "") & IIf(CheckBoxPaidJobs.Checked = True, " and {VIEWCustomerInfo.PaidJobs}>0", "")

            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class
