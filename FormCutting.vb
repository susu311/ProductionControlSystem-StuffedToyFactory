Public Class FormCutting
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBoxEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerCuttingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelCuttingDate As System.Windows.Forms.Label
    Friend WithEvents LabelDesign As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelQualifiedqtu As System.Windows.Forms.Label
    Friend WithEvents TextBoxQualifiedqty As System.Windows.Forms.TextBox
    Friend WithEvents LabelRejected As System.Windows.Forms.Label
    Friend WithEvents TextBoxRejectedQty As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents LabelDesignNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormCutting))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LabelDesignNo = New System.Windows.Forms.Label
        Me.LabelEmployeeID = New System.Windows.Forms.Label
        Me.LabelCutDate = New System.Windows.Forms.Label
        Me.LabelRejected = New System.Windows.Forms.Label
        Me.TextBoxRejectedQty = New System.Windows.Forms.TextBox
        Me.LabelQualifiedqtu = New System.Windows.Forms.Label
        Me.TextBoxQualifiedqty = New System.Windows.Forms.TextBox
        Me.LabelDesign = New System.Windows.Forms.Label
        Me.ComboBoxEmployeeID = New System.Windows.Forms.ComboBox
        Me.DateTimePickerCuttingDate = New System.Windows.Forms.DateTimePicker
        Me.LabelCuttingDate = New System.Windows.Forms.Label
        Me.LabelCustomerID = New System.Windows.Forms.Label
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.TextBoxStatus = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelDesignNo)
        Me.GroupBox3.Controls.Add(Me.LabelEmployeeID)
        Me.GroupBox3.Controls.Add(Me.LabelCutDate)
        Me.GroupBox3.Controls.Add(Me.LabelRejected)
        Me.GroupBox3.Controls.Add(Me.TextBoxRejectedQty)
        Me.GroupBox3.Controls.Add(Me.LabelQualifiedqtu)
        Me.GroupBox3.Controls.Add(Me.TextBoxQualifiedqty)
        Me.GroupBox3.Controls.Add(Me.LabelDesign)
        Me.GroupBox3.Controls.Add(Me.ComboBoxEmployeeID)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerCuttingDate)
        Me.GroupBox3.Controls.Add(Me.LabelCuttingDate)
        Me.GroupBox3.Controls.Add(Me.LabelCustomerID)
        Me.GroupBox3.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 152)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        '
        'LabelDesignNo
        '
        Me.LabelDesignNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDesignNo.Location = New System.Drawing.Point(128, 24)
        Me.LabelDesignNo.Name = "LabelDesignNo"
        Me.LabelDesignNo.Size = New System.Drawing.Size(200, 21)
        Me.LabelDesignNo.TabIndex = 63
        '
        'LabelEmployeeID
        '
        Me.LabelEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEmployeeID.Location = New System.Drawing.Point(128, 72)
        Me.LabelEmployeeID.Name = "LabelEmployeeID"
        Me.LabelEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.LabelEmployeeID.TabIndex = 64
        Me.LabelEmployeeID.Visible = False
        '
        'LabelCutDate
        '
        Me.LabelCutDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelCutDate.Location = New System.Drawing.Point(128, 48)
        Me.LabelCutDate.Name = "LabelCutDate"
        Me.LabelCutDate.Size = New System.Drawing.Size(200, 21)
        Me.LabelCutDate.TabIndex = 63
        Me.LabelCutDate.Visible = False
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
        'LabelQualifiedqtu
        '
        Me.LabelQualifiedqtu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQualifiedqtu.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelQualifiedqtu.Location = New System.Drawing.Point(32, 96)
        Me.LabelQualifiedqtu.Name = "LabelQualifiedqtu"
        Me.LabelQualifiedqtu.Size = New System.Drawing.Size(80, 23)
        Me.LabelQualifiedqtu.TabIndex = 58
        Me.LabelQualifiedqtu.Text = "Qualified Qty"
        Me.LabelQualifiedqtu.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxQualifiedqty
        '
        Me.TextBoxQualifiedqty.AutoSize = False
        Me.TextBoxQualifiedqty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxQualifiedqty.Location = New System.Drawing.Point(128, 96)
        Me.TextBoxQualifiedqty.Name = "TextBoxQualifiedqty"
        Me.TextBoxQualifiedqty.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxQualifiedqty.TabIndex = 59
        Me.TextBoxQualifiedqty.Text = ""
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
        'ComboBoxEmployeeID
        '
        Me.ComboBoxEmployeeID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxEmployeeID.Location = New System.Drawing.Point(128, 72)
        Me.ComboBoxEmployeeID.Name = "ComboBoxEmployeeID"
        Me.ComboBoxEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEmployeeID.TabIndex = 39
        '
        'DateTimePickerCuttingDate
        '
        Me.DateTimePickerCuttingDate.Location = New System.Drawing.Point(128, 48)
        Me.DateTimePickerCuttingDate.Name = "DateTimePickerCuttingDate"
        Me.DateTimePickerCuttingDate.TabIndex = 40
        '
        'LabelCuttingDate
        '
        Me.LabelCuttingDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuttingDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCuttingDate.Location = New System.Drawing.Point(16, 48)
        Me.LabelCuttingDate.Name = "LabelCuttingDate"
        Me.LabelCuttingDate.Size = New System.Drawing.Size(96, 16)
        Me.LabelCuttingDate.TabIndex = 22
        Me.LabelCuttingDate.Text = "Cutting Date"
        Me.LabelCuttingDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerID.Location = New System.Drawing.Point(16, 72)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(96, 16)
        Me.LabelCustomerID.TabIndex = 23
        Me.LabelCustomerID.Text = "Employee ID"
        Me.LabelCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(128, 24)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxDesignNo.TabIndex = 42
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Cutting Info:"
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(8, 176)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(664, 408)
        Me.DataGridData.TabIndex = 43
        '
        'LabelStatus
        '
        Me.LabelStatus.BackColor = System.Drawing.Color.White
        Me.LabelStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelStatus.Location = New System.Drawing.Point(360, 24)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(56, 23)
        Me.LabelStatus.TabIndex = 56
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(376, 88)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(296, 80)
        Me.Groupbuttons.TabIndex = 61
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
        Me.ButtonDelete.Size = New System.Drawing.Size(64, 56)
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
        Me.ButtonSave.Size = New System.Drawing.Size(64, 56)
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
        Me.ButtonClose.Size = New System.Drawing.Size(64, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(424, 16)
        Me.TextBoxStatus.Multiline = True
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxStatus.Size = New System.Drawing.Size(248, 64)
        Me.TextBoxStatus.TabIndex = 62
        Me.TextBoxStatus.Text = ""
        '
        'FormCutting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 590)
        Me.Controls.Add(Me.TextBoxStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridData)
        Me.Name = "FormCutting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cutting Form"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim DesignNo As Int16, EmployeeID As Int16, CuttingsDate As String

    Private Sub FormCutting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "                       Today Date : " & Now.ToShortDateString
        DateTimePickerCuttingDate.Value = Now
        AddtoCombo(ComboBoxDesignNo, "Designs", "'' + CONVERT(nVarChar(20),DesignNo) + ': ' +DesignName", "DesignNo", , "DesignNo")
        AddtoCombo(ComboBoxEmployeeID, "Employees", "EmployeeName+', '+Address", "EmployeeID")
        NewData()
    End Sub

    Private Sub NewData()
        Try
            DesignNo = -1
            EmployeeID = -1
            CuttingsDate = ""
            ComboBoxEmployeeID.SelectedIndex = -1
            TextBoxQualifiedqty.Text = vbNullString
            TextBoxRejectedQty.Text = vbNullString
            TextBoxStatus.Text = vbNullString
            ComboBoxEmployeeID.SelectedIndex = -1
            setGridData(DataGridData, "Select * from VIEWCuttings Where CuttingDate='" & SQLDateTime(DateTimePickerCuttingDate.Value, Main.SQLDType.sqlDateOnly, True) & "'")
            ButtonDelete.Enabled = False
            ButtonSave.Text = "&Save"

            ComboBoxDesignNo.Visible = True
            ComboBoxEmployeeID.Visible = True
            DateTimePickerCuttingDate.Visible = True
            LabelCutDate.Visible = False
            LabelEmployeeID.Visible = False
            LabelDesignNo.Visible = False
            LabelCutDate.Text = vbNullString
            LabelEmployeeID.Text = vbNullString
            LabelDesignNo.Text = vbNullString
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub DateTimePickerCuttingDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerCuttingDate.ValueChanged
        Try
            setGridData(DataGridData, "Select * from VIEWCuttings Where CuttingDate='" & SQLDateTime(DateTimePickerCuttingDate.Value, Main.SQLDType.sqlDateOnly, True) & "'")
            '," & ComboBoxEmployeeID.SelectedValue & "," & TextBoxQualifiedqty.Text & "," & TextBoxRejectedQty.Text & ",'" & TextBoxStatus.Text & "')",)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If ComboBoxDesignNo.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose Design No first.", MsgBoxStyle.Information, AppTitle)
                ComboBoxDesignNo.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerCuttingDate.Value, Now()) < 0 Then
                MsgBox("Please fill the Cutting Date correctly", MsgBoxStyle.Information, AppTitle)
                DateTimePickerCuttingDate.Focus()
            ElseIf ComboBoxEmployeeID.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose Employee ID first", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployeeID.Focus()
            ElseIf TextBoxQualifiedqty.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the qualified quantities for today", MsgBoxStyle.Information, AppTitle)
                TextBoxQualifiedqty.Focus()
            ElseIf IsNumeric(TextBoxQualifiedqty.Text) = False Then
                MsgBox("Only Numbers are allowed to fill the Qualified quantity", MsgBoxStyle.Information, AppTitle)
                TextBoxQualifiedqty.Focus()
            ElseIf TextBoxRejectedQty.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the quantities which are rejected for today", MsgBoxStyle.Information, AppTitle)
                TextBoxQualifiedqty.Focus()
            ElseIf IsNumeric(TextBoxRejectedQty.Text) = False Then
                MsgBox("Only numbers are allowed to fill the rejected quantity", MsgBoxStyle.Information, AppTitle)
                TextBoxQualifiedqty.Focus()
                'ElseIf FindData("cuttings", "DesignNo", "DesignNo=" & ComboBoxDesignNo.SelectedValue & " and CuttingDate='" & DateTimePickerCuttingDate.Value.ToShortDateString & "' and EmployeeID=" & ComboBoxEmployeeID.SelectedValue.ToString) > 0 Then
                '    If MessageBox.Show("Your data is already existing. Do you want to Update Data?", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '        SavingData("Update Cuttings Set Qualifiedqty=" & Val(TextBoxQualifiedqty.Text.Trim) & ",RejectedQty=" & Val(TextBoxRejectedQty.Text.Trim) & _
                '        ",Status='" & IIf(TextBoxStatus.Text.Trim.Length <= 0, "-", TextBoxStatus.Text.Trim) & "' Where DesignNo=" & _
                '        ComboBoxDesignNo.SelectedValue & " and CuttingDate='" & DateTimePickerCuttingDate.Value.ToShortDateString & _
                '        "' and EmployeeID=" & ComboBoxEmployeeID.SelectedValue)
                '        NewData()
                '    End If
            Else

                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Cuttings Values(" & ComboBoxDesignNo.SelectedValue & ",'" & DateTimePickerCuttingDate.Value.ToShortDateString & "'," & ComboBoxEmployeeID.SelectedValue & "," & Val(TextBoxQualifiedqty.Text.Trim) & "," & Val(TextBoxRejectedQty.Text.Trim) & ",'" & IIf(TextBoxStatus.Text.Trim.Length <= 0, "-", TextBoxStatus.Text.Trim) & "')")
                    NewData()
                ElseIf DesignNo > 0 And EmployeeID > 0 And CuttingsDate.Trim.Length > 0 Then
                    'DesignNo=" & ComboBoxDesignNo.SelectedValue & ",CuttingDate='" & _
                    'DateTimePickerCuttingDate.Value.ToShortDateString & "',EmployeeID=" & ComboBoxEmployeeID.SelectedValue & _
                    '",
                    SavingData("Update Cuttings Set Qualifiedqty=" & Val(TextBoxQualifiedqty.Text.Trim) & ",RejectedQty=" & Val(TextBoxRejectedQty.Text.Trim) & _
                    ",Status='" & IIf(TextBoxStatus.Text.Trim.Length <= 0, "-", TextBoxStatus.Text.Trim) & "' Where DesignNo=" & _
                    DesignNo & " and CuttingDate='" & CDate(CuttingsDate).ToShortDateString & _
                    "' and EmployeeID=" & EmployeeID)
                    DesignNo = 0
                    CuttingsDate = vbNullString
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
                CuttingsDate = .Item("CuttingDate")
                LabelCutDate.Text = CDate(CuttingsDate)
                DateTimePickerCuttingDate.Value = CDate(CuttingsDate)
                TextBoxQualifiedqty.Text = Val(.Item(6))
                TextBoxRejectedQty.Text = Val(.Item(7))
                TextBoxStatus.Text = .Item(8)

                ComboBoxDesignNo.Visible = False
                ComboBoxEmployeeID.Visible = False
                DateTimePickerCuttingDate.Visible = False
                LabelCutDate.Visible = True
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
        If CuttingsDate.Trim.Length > 0 And DesignNo > 0 And EmployeeID > 0 Then
            If MessageBox.Show("Are you sure to Delete?", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                SavingData("Delete from Cuttings Where CuttingDate='" & CuttingsDate & "' and DesignNo=" & DesignNo & " and EmployeeID=" & EmployeeID, False)
                MsgBox("Delete successfully")
                NewData()
            End If
        End If
    End Sub

    Private Sub DataGridData_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridData.Navigate

    End Sub
    Friend WithEvents LabelEmployeeID As System.Windows.Forms.Label
    Friend WithEvents LabelCutDate As System.Windows.Forms.Label
End Class
