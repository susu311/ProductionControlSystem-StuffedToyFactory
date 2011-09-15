Public Class FormSewing
    Inherits System.Windows.Forms.Form
    Dim DesignNo As Int16, EmployeeID As Int16, SewingDate As String
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
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelRejected As System.Windows.Forms.Label
    Friend WithEvents TextBoxRejectedQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelDesign As System.Windows.Forms.Label
    Friend WithEvents LabelSewingDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents TextBoxQualifiedQty As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerSewingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelDesignNo As System.Windows.Forms.Label
    Friend WithEvents LabelEmployeeID As System.Windows.Forms.Label
    Friend WithEvents LabelSewDate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSewing))
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelRejected = New System.Windows.Forms.Label
        Me.TextBoxRejectedQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxQualifiedQty = New System.Windows.Forms.TextBox
        Me.LabelDesign = New System.Windows.Forms.Label
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.ComboBoxEmployeeID = New System.Windows.Forms.ComboBox
        Me.DateTimePickerSewingDate = New System.Windows.Forms.DateTimePicker
        Me.LabelSewingDate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxStatus = New System.Windows.Forms.TextBox
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.LabelDesignNo = New System.Windows.Forms.Label
        Me.LabelEmployeeID = New System.Windows.Forms.Label
        Me.LabelSewDate = New System.Windows.Forms.Label
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Sewing Info:"
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(8, 168)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(656, 360)
        Me.DataGridData.TabIndex = 43
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(376, 72)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(280, 80)
        Me.Groupbuttons.TabIndex = 62
        Me.Groupbuttons.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonDelete.Location = New System.Drawing.Point(16, 16)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(56, 56)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(112, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "&Update"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelRejected)
        Me.GroupBox1.Controls.Add(Me.TextBoxRejectedQty)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxQualifiedQty)
        Me.GroupBox1.Controls.Add(Me.LabelDesign)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEmployeeID)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerSewingDate)
        Me.GroupBox1.Controls.Add(Me.LabelSewingDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 152)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'LabelRejected
        '
        Me.LabelRejected.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRejected.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelRejected.Location = New System.Drawing.Point(32, 120)
        Me.LabelRejected.Name = "LabelRejected"
        Me.LabelRejected.Size = New System.Drawing.Size(80, 23)
        Me.LabelRejected.TabIndex = 60
        Me.LabelRejected.Text = "Rejected Qty"
        Me.LabelRejected.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxRejectedQty
        '
        Me.TextBoxRejectedQty.AutoSize = False
        Me.TextBoxRejectedQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxRejectedQty.Location = New System.Drawing.Point(128, 120)
        Me.TextBoxRejectedQty.Name = "TextBoxRejectedQty"
        Me.TextBoxRejectedQty.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxRejectedQty.TabIndex = 61
        Me.TextBoxRejectedQty.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(32, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Qualified Qty"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxQualifiedQty
        '
        Me.TextBoxQualifiedQty.AutoSize = False
        Me.TextBoxQualifiedQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxQualifiedQty.Location = New System.Drawing.Point(128, 96)
        Me.TextBoxQualifiedQty.Name = "TextBoxQualifiedQty"
        Me.TextBoxQualifiedQty.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxQualifiedQty.TabIndex = 59
        Me.TextBoxQualifiedQty.Text = ""
        '
        'LabelDesign
        '
        Me.LabelDesign.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesign.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelDesign.Location = New System.Drawing.Point(40, 24)
        Me.LabelDesign.Name = "LabelDesign"
        Me.LabelDesign.Size = New System.Drawing.Size(72, 23)
        Me.LabelDesign.TabIndex = 41
        Me.LabelDesign.Text = "Design No"
        Me.LabelDesign.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(128, 24)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxDesignNo.TabIndex = 42
        '
        'ComboBoxEmployeeID
        '
        Me.ComboBoxEmployeeID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxEmployeeID.Location = New System.Drawing.Point(128, 72)
        Me.ComboBoxEmployeeID.Name = "ComboBoxEmployeeID"
        Me.ComboBoxEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEmployeeID.TabIndex = 39
        '
        'DateTimePickerSewingDate
        '
        Me.DateTimePickerSewingDate.Location = New System.Drawing.Point(128, 48)
        Me.DateTimePickerSewingDate.Name = "DateTimePickerSewingDate"
        Me.DateTimePickerSewingDate.TabIndex = 40
        '
        'LabelSewingDate
        '
        Me.LabelSewingDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSewingDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSewingDate.Location = New System.Drawing.Point(16, 48)
        Me.LabelSewingDate.Name = "LabelSewingDate"
        Me.LabelSewingDate.Size = New System.Drawing.Size(96, 16)
        Me.LabelSewingDate.TabIndex = 22
        Me.LabelSewingDate.Text = "Sewing Date"
        Me.LabelSewingDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Employee ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(416, 24)
        Me.TextBoxStatus.Multiline = True
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxStatus.Size = New System.Drawing.Size(240, 48)
        Me.TextBoxStatus.TabIndex = 65
        Me.TextBoxStatus.Text = ""
        '
        'LabelStatus
        '
        Me.LabelStatus.BackColor = System.Drawing.Color.White
        Me.LabelStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelStatus.Location = New System.Drawing.Point(360, 24)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(56, 16)
        Me.LabelStatus.TabIndex = 64
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelDesignNo
        '
        Me.LabelDesignNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDesignNo.Location = New System.Drawing.Point(144, 24)
        Me.LabelDesignNo.Name = "LabelDesignNo"
        Me.LabelDesignNo.Size = New System.Drawing.Size(200, 21)
        Me.LabelDesignNo.TabIndex = 67
        '
        'LabelEmployeeID
        '
        Me.LabelEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEmployeeID.Location = New System.Drawing.Point(144, 72)
        Me.LabelEmployeeID.Name = "LabelEmployeeID"
        Me.LabelEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.LabelEmployeeID.TabIndex = 68
        Me.LabelEmployeeID.Visible = False
        '
        'LabelSewDate
        '
        Me.LabelSewDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSewDate.Location = New System.Drawing.Point(144, 48)
        Me.LabelSewDate.Name = "LabelSewDate"
        Me.LabelSewDate.Size = New System.Drawing.Size(200, 21)
        Me.LabelSewDate.TabIndex = 66
        Me.LabelSewDate.Visible = False
        '
        'FormSewing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 534)
        Me.Controls.Add(Me.LabelDesignNo)
        Me.Controls.Add(Me.LabelEmployeeID)
        Me.Controls.Add(Me.LabelSewDate)
        Me.Controls.Add(Me.TextBoxStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridData)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormSewing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sewing"
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormSewing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "         Today Date :" & Now.ToShortDateString
        DateTimePickerSewingDate.Value = Now
        AddtoCombo(ComboBoxDesignNo, "Designs", "''+ CONVERT(nVarChar(20),DesignNo)+': '+DesignName", "DesignNo", , "DesignNo")
        AddtoCombo(ComboBoxEmployeeID, "Employees", "EmployeeName+', '+Post", "EmployeeID")
        NewData()
    End Sub
    Private Sub NewData()
        Try
            DesignNo = -1
            EmployeeID = -1
            SewingDate = ""
            ComboBoxEmployeeID.SelectedIndex = -1
            TextBoxQualifiedQty.Text = vbNullString
            TextBoxRejectedQty.Text = vbNullString
            TextBoxStatus.Text = vbNullString
            setGridData(DataGridData, "Select* from VIEWSewing Where SewingDate ='" & SQLDateTime(DateTimePickerSewingDate.Value, Main.SQLDType.sqlDateOnly, True) & "'")
            ButtonDelete.Enabled = False
            ButtonSave.Text = "&Save"

            ComboBoxDesignNo.Visible = True
            ComboBoxEmployeeID.Visible = True
            DateTimePickerSewingDate.Visible = True
            LabelSewDate.Visible = False
            LabelEmployeeID.Visible = False
            LabelDesignNo.Visible = False
            LabelSewDate.Text = vbNullString
            LabelEmployeeID.Text = vbNullString
            LabelDesignNo.Text = vbNullString
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub DateTimePickerSewingDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerSewingDate.ValueChanged
        Try
            setGridData(DataGridData, "Select * from VIEWSewing Where SewingDate= '" & SQLDateTime(DateTimePickerSewingDate.Value, Main.SQLDType.sqlDateOnly, True) & "'")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If ComboBoxDesignNo.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose Design No first. ", MsgBoxStyle.Information, AppTitle)
                ComboBoxDesignNo.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerSewingDate.Value, Now()) < 0 Then
                MsgBox("Please fill the Sewing Date correctly", MsgBoxStyle.Information, AppTitle)
                DateTimePickerSewingDate.Focus()
            ElseIf ComboBoxEmployeeID.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose EmployeeID first", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployeeID.Focus()
            ElseIf TextBoxQualifiedQty.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the qualified quantities for today", MsgBoxStyle.Information, AppTitle)
                TextBoxQualifiedQty.Focus()
            ElseIf IsNumeric(TextBoxQualifiedQty.Text) = False Then
                MsgBox("Only numbers are allowed to fill the Qualified qty", MsgBoxStyle.Information, AppTitle)
            ElseIf TextBoxRejectedQty.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the rejected quantities for today", MsgBoxStyle.Information, AppTitle)
                TextBoxRejectedQty.Focus()
            ElseIf IsNumeric(TextBoxRejectedQty.Text) = False Then
                MsgBox("Only numbers are allowed to fill the Rejected qty", MsgBoxStyle.Information, AppTitle)
                TextBoxRejectedQty.Focus()
            Else
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Sewings Values(" & ComboBoxDesignNo.SelectedValue & ",'" & DateTimePickerSewingDate.Value.ToShortDateString & "'," & ComboBoxEmployeeID.SelectedValue & "," & Val(TextBoxQualifiedQty.Text.Trim) & "," & Val(TextBoxRejectedQty.Text.Trim) & ",'" & IIf(TextBoxStatus.Text.Trim.Length <= 0, "-", TextBoxStatus.Text.Trim) & "')")
                    NewData()
                ElseIf DesignNo > 0 And EmployeeID > 0 And SewingDate.Trim.Length > 0 Then
                    SavingData("Update Sewings Set QualifiedQty =" & Val(TextBoxQualifiedQty.Text.Trim) & ",RejectedQty =" & Val(TextBoxRejectedQty.Text.Trim) & _
                    ",Status ='" & IIf(TextBoxStatus.Text.Trim.Length < 0, "-", TextBoxStatus.Text.Trim) & "'Where DesignNo=" & DesignNo & " and SewingDate='" & CDate(SewingDate).ToShortDateString & _
                    "' and EmployeeID=" & EmployeeID)
                    DesignNo = 0
                    SewingDate = vbNullString
                    EmployeeID = 0
                    NewData()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub DataGridData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridData.DoubleClick
        Try
            Dim DataTableItems As DataTable = DataGridData.DataSource
            With DataTableItems.Rows(DataGridData.CurrentCell.RowNumber)
                DesignNo = .Item(0)
                LabelDesignNo.Text = DesignNo & ": " & .Item(1)
                ComboBoxDesignNo.Text = LabelDesignNo.Text
                EmployeeID = .Item(2)
                LabelEmployeeID.Text = .Item(3) & ", " & .Item(4)
                ComboBoxEmployeeID.Text = LabelEmployeeID.Text
                SewingDate = .Item("SewingDate")
                LabelSewDate.Text = SewingDate
                DateTimePickerSewingDate.Value = CDate(SewingDate)
                TextBoxQualifiedQty.Text = Val(.Item("Qualifiedqty"))
                TextBoxRejectedQty.Text = Val(.Item("RejectedQty"))
                TextBoxStatus.Text = .Item("Status")
                ComboBoxDesignNo.Visible = False
                ComboBoxEmployeeID.Visible = False
                DateTimePickerSewingDate.Visible = False
                LabelSewDate.Visible = True
                LabelEmployeeID.Visible = True
                LabelDesignNo.Visible = True
            End With
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If SewingDate.Trim.Length > 0 And DesignNo > 0 And EmployeeID > 0 Then
            If MessageBox.Show("Are you sure to Delete?", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                SavingData("Delete from Sewings Where SewingDate='" & SewingDate & "' and DesignNo=" & DesignNo & " and EmployeeID=" & EmployeeID, False)
                MsgBox("Delete successfully")
                NewData()
            End If
        End If
    End Sub

    Private Sub DataGridData_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridData.Navigate

    End Sub
End Class
