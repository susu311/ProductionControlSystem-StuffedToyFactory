Public Class FormPackaging
    Inherits System.Windows.Forms.Form
    Dim DesignNo As Int16, EmployeeID As Int16, PackagingDate As String
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
    Friend WithEvents LabelDesign As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents DateTimePickerPackagingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelPackagingDate As System.Windows.Forms.Label
    Friend WithEvents LabelRejectedQty As System.Windows.Forms.Label
    Friend WithEvents TextBoxRejectedQty As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelPackagingQty As System.Windows.Forms.Label
    Friend WithEvents TextBoxPackagingQty As System.Windows.Forms.TextBox
    Friend WithEvents LabelDesignNo As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelPackaging As System.Windows.Forms.Label
    Friend WithEvents LabelEmployee As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormPackaging))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LabelRejectedQty = New System.Windows.Forms.Label
        Me.TextBoxRejectedQty = New System.Windows.Forms.TextBox
        Me.LabelPackagingQty = New System.Windows.Forms.Label
        Me.TextBoxPackagingQty = New System.Windows.Forms.TextBox
        Me.LabelDesign = New System.Windows.Forms.Label
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.ComboBoxEmployeeID = New System.Windows.Forms.ComboBox
        Me.LabelCustomerID = New System.Windows.Forms.Label
        Me.LabelPackagingDate = New System.Windows.Forms.Label
        Me.DateTimePickerPackagingDate = New System.Windows.Forms.DateTimePicker
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.LabelDesignNo = New System.Windows.Forms.Label
        Me.LabelPackaging = New System.Windows.Forms.Label
        Me.LabelEmployee = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelRejectedQty)
        Me.GroupBox3.Controls.Add(Me.TextBoxRejectedQty)
        Me.GroupBox3.Controls.Add(Me.LabelPackagingQty)
        Me.GroupBox3.Controls.Add(Me.TextBoxPackagingQty)
        Me.GroupBox3.Controls.Add(Me.LabelDesign)
        Me.GroupBox3.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox3.Controls.Add(Me.ComboBoxEmployeeID)
        Me.GroupBox3.Controls.Add(Me.LabelCustomerID)
        Me.GroupBox3.Controls.Add(Me.LabelPackagingDate)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerPackagingDate)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 152)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'LabelRejectedQty
        '
        Me.LabelRejectedQty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRejectedQty.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelRejectedQty.Location = New System.Drawing.Point(32, 120)
        Me.LabelRejectedQty.Name = "LabelRejectedQty"
        Me.LabelRejectedQty.Size = New System.Drawing.Size(80, 23)
        Me.LabelRejectedQty.TabIndex = 60
        Me.LabelRejectedQty.Text = "Rejected Qty"
        Me.LabelRejectedQty.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'LabelPackagingQty
        '
        Me.LabelPackagingQty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPackagingQty.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPackagingQty.Location = New System.Drawing.Point(24, 96)
        Me.LabelPackagingQty.Name = "LabelPackagingQty"
        Me.LabelPackagingQty.Size = New System.Drawing.Size(88, 23)
        Me.LabelPackagingQty.TabIndex = 58
        Me.LabelPackagingQty.Text = "Packaging Qty"
        Me.LabelPackagingQty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxPackagingQty
        '
        Me.TextBoxPackagingQty.AutoSize = False
        Me.TextBoxPackagingQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxPackagingQty.Location = New System.Drawing.Point(128, 96)
        Me.TextBoxPackagingQty.Name = "TextBoxPackagingQty"
        Me.TextBoxPackagingQty.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxPackagingQty.TabIndex = 59
        Me.TextBoxPackagingQty.Text = ""
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
        Me.ComboBoxDesignNo.ItemHeight = 13
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(128, 24)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxDesignNo.TabIndex = 42
        '
        'ComboBoxEmployeeID
        '
        Me.ComboBoxEmployeeID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxEmployeeID.Location = New System.Drawing.Point(128, 48)
        Me.ComboBoxEmployeeID.Name = "ComboBoxEmployeeID"
        Me.ComboBoxEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEmployeeID.TabIndex = 39
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerID.Location = New System.Drawing.Point(16, 48)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(96, 16)
        Me.LabelCustomerID.TabIndex = 23
        Me.LabelCustomerID.Text = "Employee ID"
        Me.LabelCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPackagingDate
        '
        Me.LabelPackagingDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPackagingDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPackagingDate.Location = New System.Drawing.Point(24, 72)
        Me.LabelPackagingDate.Name = "LabelPackagingDate"
        Me.LabelPackagingDate.Size = New System.Drawing.Size(96, 16)
        Me.LabelPackagingDate.TabIndex = 22
        Me.LabelPackagingDate.Text = "Packaging Date"
        Me.LabelPackagingDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePickerPackagingDate
        '
        Me.DateTimePickerPackagingDate.Location = New System.Drawing.Point(128, 72)
        Me.DateTimePickerPackagingDate.Name = "DateTimePickerPackagingDate"
        Me.DateTimePickerPackagingDate.TabIndex = 40
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Packaging Info:"
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(8, 168)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(616, 400)
        Me.DataGridData.TabIndex = 73
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(512, 40)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(96, 40)
        Me.ButtonDelete.TabIndex = 75
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(360, 40)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(96, 40)
        Me.ButtonSave.TabIndex = 76
        Me.ButtonSave.Text = "&Update"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClose.Location = New System.Drawing.Point(432, 112)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(96, 40)
        Me.ButtonClose.TabIndex = 74
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDesignNo
        '
        Me.LabelDesignNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDesignNo.Location = New System.Drawing.Point(136, 32)
        Me.LabelDesignNo.Name = "LabelDesignNo"
        Me.LabelDesignNo.Size = New System.Drawing.Size(200, 21)
        Me.LabelDesignNo.TabIndex = 62
        '
        'LabelPackaging
        '
        Me.LabelPackaging.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPackaging.Location = New System.Drawing.Point(136, 80)
        Me.LabelPackaging.Name = "LabelPackaging"
        Me.LabelPackaging.Size = New System.Drawing.Size(200, 21)
        Me.LabelPackaging.TabIndex = 77
        '
        'LabelEmployee
        '
        Me.LabelEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEmployee.Location = New System.Drawing.Point(136, 56)
        Me.LabelEmployee.Name = "LabelEmployee"
        Me.LabelEmployee.Size = New System.Drawing.Size(200, 21)
        Me.LabelEmployee.TabIndex = 78
        '
        'FormPackaging
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 574)
        Me.Controls.Add(Me.LabelEmployee)
        Me.Controls.Add(Me.LabelPackaging)
        Me.Controls.Add(Me.LabelDesignNo)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.DataGridData)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormPackaging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Packaging"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormPackaging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "                       Today Date : " & Now.ToShortDateString
        DateTimePickerPackagingDate.Value = Now
        AddtoCombo(ComboBoxDesignNo, "Designs", "'' + CONVERT(nVarChar(20),DesignNo) + ': ' +DesignName", "DesignNo", , "DesignNo")
        AddtoCombo(ComboBoxEmployeeID, "Employees", "EmployeeName+', '+ Post", "EmployeeID")
        NewData()
    End Sub

    Private Sub NewData()
        Try
            DesignNo = -1
            EmployeeID = -1
            PackagingDate = ""
            ComboBoxEmployeeID.SelectedIndex = -1
            TextBoxPackagingQty.Text = vbNullString
            TextBoxRejectedQty.Text = vbNullString
            ComboBoxEmployeeID.SelectedIndex = -1
            setGridData(DataGridData, "Select * from VIEWPackagings Where PackagingDate='" & SQLDateTime(DateTimePickerPackagingDate.Value, Main.SQLDType.sqlDateOnly, True) & "'")
            ButtonDelete.Enabled = False
            ButtonSave.Text = "&Save"

            ComboBoxDesignNo.Visible = True
            ComboBoxEmployeeID.Visible = True
            DateTimePickerPackagingDate.Visible = True
            LabelDesignNo.Visible = False
            LabelPackaging.Visible = False
            LabelEmployee.Visible = False
            LabelPackaging.Text = vbNullString
            LabelEmployee.Text = vbNullString
            LabelDesignNo.Text = vbNullString
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If ComboBoxDesignNo.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose Design No first.", MsgBoxStyle.Information, AppTitle)
                ComboBoxDesignNo.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerPackagingDate.Value, Now()) < 0 Then
                MsgBox("Please fill the Cutting Date correctly", MsgBoxStyle.Information, AppTitle)
                DateTimePickerPackagingDate.Focus()
            ElseIf ComboBoxEmployeeID.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose Employee ID first", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployeeID.Focus()
            ElseIf TextBoxPackagingQty.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the qualified quantities for today", MsgBoxStyle.Information, AppTitle)
                TextBoxPackagingQty.Focus()
            ElseIf IsNumeric(TextBoxPackagingQty.Text) = False Then
                MsgBox("Only Numbers are allowed to fill the Qualified quantity", MsgBoxStyle.Information, AppTitle)
                TextBoxPackagingQty.Focus()
            ElseIf TextBoxRejectedQty.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the quantities which are rejected for today", MsgBoxStyle.Information, AppTitle)
                TextBoxRejectedQty.Focus()
            ElseIf IsNumeric(TextBoxRejectedQty.Text) = False Then
                MsgBox("Only numbers are allowed to fill the rejected quantity", MsgBoxStyle.Information, AppTitle)
                TextBoxRejectedQty.Focus()

            Else

                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Packaging Values(" & ComboBoxDesignNo.SelectedValue & ",'" & DateTimePickerPackagingDate.Value.ToShortDateString & "'," & ComboBoxEmployeeID.SelectedValue & "," & Val(TextBoxPackagingQty.Text.Trim) & "," & Val(TextBoxRejectedQty.Text.Trim) & ")")
                    NewData()
                ElseIf DesignNo > 0 And EmployeeID > 0 And PackagingDate.Trim.Length > 0 Then
                    SavingData("Update Packaging Set PackagingQty=" & Val(TextBoxPackagingQty.Text.Trim) & ",RejectedQty=" & Val(TextBoxRejectedQty.Text.Trim) & _
                    " Where DesignNo=" & _
                    DesignNo & " and PackagingDate='" & CDate(PackagingDate).ToShortDateString & _
                    "' and EmployeeID=" & EmployeeID)
                    DesignNo = 0
                    PackagingDate = vbNullString
                    EmployeeID = 0
                    NewData()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub DateTimePickerPackagingDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerPackagingDate.ValueChanged
        Try
            setGridData(DataGridData, "Select * from VIEWPackagings Where PackagingDate='" & SQLDateTime(DateTimePickerPackagingDate.Value, Main.SQLDType.sqlDateOnly, True) & "'")
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
                EmployeeID = .Item(2)
                LabelEmployee.Text = .Item(3) & ", " & .Item(4)
                ComboBoxEmployeeID.Text = LabelEmployee.Text
                PackagingDate = .Item("PackagingDate")
                LabelPackaging.Text = CDate(PackagingDate)
                DateTimePickerPackagingDate.Value = CDate(LabelPackaging.Text)
                TextBoxPackagingQty.Text = Val(.Item("PackagingQty"))
                TextBoxRejectedQty.Text = Val(.Item("RejectedQty"))

                ComboBoxDesignNo.Visible = False
                ComboBoxEmployeeID.Visible = False
                DateTimePickerPackagingDate.Visible = False
                LabelPackaging.Visible = True
                LabelEmployee.Visible = True
                LabelDesignNo.Visible = True
            End With
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If PackagingDate.Trim.Length > 0 And DesignNo > 0 And EmployeeID > 0 Then
            If MessageBox.Show("Are you sure to Delete?", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                SavingData("Delete from Packaging Where PackagingDate='" & PackagingDate & "' and DesignNo=" & DesignNo & " and EmployeeID=" & EmployeeID, False)
                MsgBox("Delete successfully")
                NewData()
            End If
        End If
    End Sub
End Class
