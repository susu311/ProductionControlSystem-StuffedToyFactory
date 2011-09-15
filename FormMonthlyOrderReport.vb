Public Class FormMonthlyOrderReport
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxmonth As System.Windows.Forms.ComboBox
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridOrderInfo As System.Windows.Forms.DataGrid
    Friend WithEvents LabelYear As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormMonthlyOrderReport))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxmonth = New System.Windows.Forms.ComboBox
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridOrderInfo = New System.Windows.Forms.DataGrid
        Me.LabelYear = New System.Windows.Forms.Label
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridOrderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose a month for orders report at "
        '
        'ComboBoxmonth
        '
        Me.ComboBoxmonth.Location = New System.Drawing.Point(192, 32)
        Me.ComboBoxmonth.Name = "ComboBoxmonth"
        Me.ComboBoxmonth.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxmonth.TabIndex = 1
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSearch)
        Me.Groupbuttons.Controls.Add(Me.ButtonPrintPreview)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(344, 0)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(288, 80)
        Me.Groupbuttons.TabIndex = 78
        Me.Groupbuttons.TabStop = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSearch.Location = New System.Drawing.Point(24, 16)
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
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(104, 16)
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
        Me.ButtonClose.Location = New System.Drawing.Point(208, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DataGridOrderInfo
        '
        Me.DataGridOrderInfo.BackgroundColor = System.Drawing.Color.White
        Me.DataGridOrderInfo.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridOrderInfo.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridOrderInfo.DataMember = ""
        Me.DataGridOrderInfo.GridLineColor = System.Drawing.Color.Black
        Me.DataGridOrderInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridOrderInfo.Location = New System.Drawing.Point(8, 88)
        Me.DataGridOrderInfo.Name = "DataGridOrderInfo"
        Me.DataGridOrderInfo.Size = New System.Drawing.Size(624, 320)
        Me.DataGridOrderInfo.TabIndex = 79
        '
        'LabelYear
        '
        Me.LabelYear.Location = New System.Drawing.Point(192, 8)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(120, 23)
        Me.LabelYear.TabIndex = 80
        '
        'FormMonthlyOrderReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 422)
        Me.Controls.Add(Me.LabelYear)
        Me.Controls.Add(Me.DataGridOrderInfo)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.ComboBoxmonth)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormMonthlyOrderReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monthly Order Report"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridOrderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormMonthlyOrderReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddMonthtoCombo(ComboBoxmonth)
            LabelYear.Text = Now.Year.ToString
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            setGridData(DataGridOrderInfo, "SELECT DISTINCT JobNo, ConfirmedDate, DeliveryDate, SaleType, CustomerID, CustomerName, CompanyName, Address, TotalAmount FROM VIEWJobs WHERE (DATENAME(month, ConfirmedDate) = '" & ComboBoxmonth.Text & "') AND (DATENAME(Year, ConfirmedDate) = DATENAME(Year, GetDate()))")
            If getGridRowsCount(DataGridOrderInfo) <= 0 Then
                MsgBox("There is no record for this month.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        If getGridRowsCount(DataGridOrderInfo) > 0 Then PrintData()
    End Sub

    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportMonthlyOrderReciptReport
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            f_report.CrystalReportViewer1.SelectionFormula = "{Command.SearchMonth}='" & ComboBoxmonth.Text & "'"
            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    
End Class
