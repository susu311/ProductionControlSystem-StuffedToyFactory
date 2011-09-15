Public Class FormSearchEmployeeStatus
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
    Friend WithEvents GroupBoxViewOption As System.Windows.Forms.GroupBox
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents RadioButtonListAll As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridSearchEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents RadioButtonRetired As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonResigned As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDismissed As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCurrent As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSearchEmployeeStatus))
        Me.GroupBoxViewOption = New System.Windows.Forms.GroupBox
        Me.RadioButtonRetired = New System.Windows.Forms.RadioButton
        Me.RadioButtonResigned = New System.Windows.Forms.RadioButton
        Me.RadioButtonDismissed = New System.Windows.Forms.RadioButton
        Me.RadioButtonCurrent = New System.Windows.Forms.RadioButton
        Me.RadioButtonListAll = New System.Windows.Forms.RadioButton
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.DataGridSearchEmployee = New System.Windows.Forms.DataGrid
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.GroupBoxViewOption.SuspendLayout()
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxViewOption
        '
        Me.GroupBoxViewOption.Controls.Add(Me.RadioButtonRetired)
        Me.GroupBoxViewOption.Controls.Add(Me.RadioButtonResigned)
        Me.GroupBoxViewOption.Controls.Add(Me.RadioButtonDismissed)
        Me.GroupBoxViewOption.Controls.Add(Me.RadioButtonCurrent)
        Me.GroupBoxViewOption.Controls.Add(Me.RadioButtonListAll)
        Me.GroupBoxViewOption.Controls.Add(Me.LabelStatus)
        Me.GroupBoxViewOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxViewOption.Location = New System.Drawing.Point(8, 8)
        Me.GroupBoxViewOption.Name = "GroupBoxViewOption"
        Me.GroupBoxViewOption.Size = New System.Drawing.Size(560, 72)
        Me.GroupBoxViewOption.TabIndex = 0
        Me.GroupBoxViewOption.TabStop = False
        Me.GroupBoxViewOption.Text = "View Options"
        '
        'RadioButtonRetired
        '
        Me.RadioButtonRetired.Location = New System.Drawing.Point(480, 24)
        Me.RadioButtonRetired.Name = "RadioButtonRetired"
        Me.RadioButtonRetired.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonRetired.TabIndex = 57
        Me.RadioButtonRetired.Text = "Retired"
        Me.RadioButtonRetired.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'RadioButtonResigned
        '
        Me.RadioButtonResigned.Location = New System.Drawing.Point(384, 24)
        Me.RadioButtonResigned.Name = "RadioButtonResigned"
        Me.RadioButtonResigned.Size = New System.Drawing.Size(96, 24)
        Me.RadioButtonResigned.TabIndex = 56
        Me.RadioButtonResigned.Text = "Resigned"
        Me.RadioButtonResigned.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'RadioButtonDismissed
        '
        Me.RadioButtonDismissed.Location = New System.Drawing.Point(280, 24)
        Me.RadioButtonDismissed.Name = "RadioButtonDismissed"
        Me.RadioButtonDismissed.Size = New System.Drawing.Size(96, 16)
        Me.RadioButtonDismissed.TabIndex = 55
        Me.RadioButtonDismissed.Text = "Dismissed"
        '
        'RadioButtonCurrent
        '
        Me.RadioButtonCurrent.Location = New System.Drawing.Point(192, 24)
        Me.RadioButtonCurrent.Name = "RadioButtonCurrent"
        Me.RadioButtonCurrent.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonCurrent.TabIndex = 54
        Me.RadioButtonCurrent.Text = "Current"
        '
        'RadioButtonListAll
        '
        Me.RadioButtonListAll.Location = New System.Drawing.Point(96, 24)
        Me.RadioButtonListAll.Name = "RadioButtonListAll"
        Me.RadioButtonListAll.Size = New System.Drawing.Size(64, 16)
        Me.RadioButtonListAll.TabIndex = 53
        Me.RadioButtonListAll.Text = "List All"
        '
        'LabelStatus
        '
        Me.LabelStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelStatus.Location = New System.Drawing.Point(8, 24)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(64, 23)
        Me.LabelStatus.TabIndex = 52
        Me.LabelStatus.Text = "By Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridSearchEmployee
        '
        Me.DataGridSearchEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchEmployee.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionText = "Employees Info:"
        Me.DataGridSearchEmployee.DataMember = ""
        Me.DataGridSearchEmployee.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchEmployee.Location = New System.Drawing.Point(8, 88)
        Me.DataGridSearchEmployee.Name = "DataGridSearchEmployee"
        Me.DataGridSearchEmployee.Size = New System.Drawing.Size(776, 472)
        Me.DataGridSearchEmployee.TabIndex = 49
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonPrintPreview)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(576, 8)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(208, 72)
        Me.Groupbuttons.TabIndex = 50
        Me.Groupbuttons.TabStop = False
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(16, 8)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(104, 56)
        Me.ButtonPrintPreview.TabIndex = 11
        Me.ButtonPrintPreview.Text = "&Print Preview"
        Me.ButtonPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(136, 8)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FormSearchEmployeeStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridSearchEmployee)
        Me.Controls.Add(Me.GroupBoxViewOption)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSearchEmployeeStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Employees"
        Me.GroupBoxViewOption.ResumeLayout(False)
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormSearchEmployeeStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setGridData(DataGridSearchEmployee, "Select EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status from Employees Order By EmployeeID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub RadioButtonListAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonListAll.CheckedChanged
        Try
            setGridData(DataGridSearchEmployee, "Select EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status from Employees Order By EmployeeID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonCurrent.CheckedChanged
        Try
            setGridData(DataGridSearchEmployee, "Select EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status from Employees Where Status='Current' Order By EmployeeID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDismissed.CheckedChanged
        Try
            setGridData(DataGridSearchEmployee, "Select EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status from Employees Where Status='Dismissed' Order By EmployeeID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonResigned.CheckedChanged
        Try
            setGridData(DataGridSearchEmployee, "Select EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status from Employees Where Status='Resigned' Order By EmployeeID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRetired.CheckedChanged
        Try
            setGridData(DataGridSearchEmployee, "Select EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status from Employees Where Status='Retired' Order By EmployeeID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPreview.Click
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportSearchEmployeeStatus

            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport

            If RadioButtonListAll.Checked = False Then f_report.CrystalReportViewer1.SelectionFormula = "{Employees.Status}='" & IIf(RadioButtonDismissed.Checked = True, "Dismissed", IIf(RadioButtonCurrent.Checked = True, "Current", IIf(RadioButtonResigned.Checked = True, "Resigned", "Retired"))) & "'"
            f_report.MyDbase = rptReport.Database
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



