Public Class FormEmployee
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
    Friend WithEvents TextBoxEmployeeID As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEducation As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents LabelPost As System.Windows.Forms.Label
    Friend WithEvents LabelPhone As System.Windows.Forms.Label
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents LabelEmployedDate As System.Windows.Forms.Label
    Friend WithEvents LabelEducation As System.Windows.Forms.Label
    Friend WithEvents LabelEmployeeName As System.Windows.Forms.Label
    Friend WithEvents LabelEmployeeID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPost As System.Windows.Forms.ComboBox
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEmployedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Labelupdate As System.Windows.Forms.Label
    Friend WithEvents ComboBoxStatus As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormEmployee))
        Me.TextBoxEmployeeID = New System.Windows.Forms.Label
        Me.TextBoxAddress = New System.Windows.Forms.TextBox
        Me.TextBoxPhoneNo = New System.Windows.Forms.TextBox
        Me.TextBoxEducation = New System.Windows.Forms.TextBox
        Me.TextBoxEmployeeName = New System.Windows.Forms.TextBox
        Me.LabelPost = New System.Windows.Forms.Label
        Me.LabelPhone = New System.Windows.Forms.Label
        Me.LabelAddress = New System.Windows.Forms.Label
        Me.LabelEmployedDate = New System.Windows.Forms.Label
        Me.LabelEducation = New System.Windows.Forms.Label
        Me.LabelEmployeeName = New System.Windows.Forms.Label
        Me.LabelEmployeeID = New System.Windows.Forms.Label
        Me.ComboBoxPost = New System.Windows.Forms.ComboBox
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridEmployee = New System.Windows.Forms.DataGrid
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.DateTimePickerEmployedDate = New System.Windows.Forms.DateTimePicker
        Me.Labelupdate = New System.Windows.Forms.Label
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxEmployeeID
        '
        Me.TextBoxEmployeeID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxEmployeeID.Location = New System.Drawing.Point(139, 16)
        Me.TextBoxEmployeeID.Name = "TextBoxEmployeeID"
        Me.TextBoxEmployeeID.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxEmployeeID.TabIndex = 22
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(139, 144)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAddress.Size = New System.Drawing.Size(133, 40)
        Me.TextBoxAddress.TabIndex = 28
        Me.TextBoxAddress.Text = ""
        '
        'TextBoxPhoneNo
        '
        Me.TextBoxPhoneNo.Location = New System.Drawing.Point(136, 192)
        Me.TextBoxPhoneNo.Name = "TextBoxPhoneNo"
        Me.TextBoxPhoneNo.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxPhoneNo.TabIndex = 26
        Me.TextBoxPhoneNo.Text = ""
        '
        'TextBoxEducation
        '
        Me.TextBoxEducation.Location = New System.Drawing.Point(139, 80)
        Me.TextBoxEducation.Name = "TextBoxEducation"
        Me.TextBoxEducation.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxEducation.TabIndex = 25
        Me.TextBoxEducation.Text = ""
        '
        'TextBoxEmployeeName
        '
        Me.TextBoxEmployeeName.Location = New System.Drawing.Point(139, 48)
        Me.TextBoxEmployeeName.Name = "TextBoxEmployeeName"
        Me.TextBoxEmployeeName.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxEmployeeName.TabIndex = 24
        Me.TextBoxEmployeeName.Text = ""
        '
        'LabelPost
        '
        Me.LabelPost.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPost.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPost.Location = New System.Drawing.Point(32, 224)
        Me.LabelPost.Name = "LabelPost"
        Me.LabelPost.Size = New System.Drawing.Size(96, 23)
        Me.LabelPost.TabIndex = 35
        Me.LabelPost.Text = "Post"
        Me.LabelPost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPhone
        '
        Me.LabelPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPhone.Location = New System.Drawing.Point(32, 192)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(96, 23)
        Me.LabelPhone.TabIndex = 34
        Me.LabelPhone.Text = "Phone No"
        Me.LabelPhone.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelAddress
        '
        Me.LabelAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelAddress.Location = New System.Drawing.Point(32, 144)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(96, 23)
        Me.LabelAddress.TabIndex = 33
        Me.LabelAddress.Text = "Address"
        Me.LabelAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEmployedDate
        '
        Me.LabelEmployedDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployedDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEmployedDate.Location = New System.Drawing.Point(32, 112)
        Me.LabelEmployedDate.Name = "LabelEmployedDate"
        Me.LabelEmployedDate.Size = New System.Drawing.Size(96, 23)
        Me.LabelEmployedDate.TabIndex = 32
        Me.LabelEmployedDate.Text = "Employed Date"
        Me.LabelEmployedDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEducation
        '
        Me.LabelEducation.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEducation.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEducation.Location = New System.Drawing.Point(32, 80)
        Me.LabelEducation.Name = "LabelEducation"
        Me.LabelEducation.Size = New System.Drawing.Size(96, 23)
        Me.LabelEducation.TabIndex = 31
        Me.LabelEducation.Text = "Education"
        Me.LabelEducation.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEmployeeName
        '
        Me.LabelEmployeeName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployeeName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEmployeeName.Location = New System.Drawing.Point(32, 48)
        Me.LabelEmployeeName.Name = "LabelEmployeeName"
        Me.LabelEmployeeName.Size = New System.Drawing.Size(96, 23)
        Me.LabelEmployeeName.TabIndex = 30
        Me.LabelEmployeeName.Text = "Employee Name"
        Me.LabelEmployeeName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEmployeeID
        '
        Me.LabelEmployeeID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployeeID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEmployeeID.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LabelEmployeeID.Location = New System.Drawing.Point(32, 16)
        Me.LabelEmployeeID.Name = "LabelEmployeeID"
        Me.LabelEmployeeID.Size = New System.Drawing.Size(96, 23)
        Me.LabelEmployeeID.TabIndex = 29
        Me.LabelEmployeeID.Text = "Employee ID"
        Me.LabelEmployeeID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxPost
        '
        Me.ComboBoxPost.Location = New System.Drawing.Point(136, 224)
        Me.ComboBoxPost.Name = "ComboBoxPost"
        Me.ComboBoxPost.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxPost.TabIndex = 38
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(48, 336)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(160, 208)
        Me.Groupbuttons.TabIndex = 47
        Me.Groupbuttons.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(32, 16)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(96, 48)
        Me.ButtonDelete.TabIndex = 10
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
        Me.ButtonSave.Location = New System.Drawing.Point(32, 84)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(96, 48)
        Me.ButtonSave.TabIndex = 11
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
        Me.ButtonClose.Location = New System.Drawing.Point(32, 152)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(96, 48)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridEmployee
        '
        Me.DataGridEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridEmployee.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridEmployee.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridEmployee.CaptionText = "Employee Info:"
        Me.DataGridEmployee.DataMember = ""
        Me.DataGridEmployee.GridLineColor = System.Drawing.Color.Black
        Me.DataGridEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridEmployee.Location = New System.Drawing.Point(280, 8)
        Me.DataGridEmployee.Name = "DataGridEmployee"
        Me.DataGridEmployee.ReadOnly = True
        Me.DataGridEmployee.Size = New System.Drawing.Size(504, 536)
        Me.DataGridEmployee.TabIndex = 48
        '
        'LabelStatus
        '
        Me.LabelStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelStatus.Location = New System.Drawing.Point(32, 256)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(96, 23)
        Me.LabelStatus.TabIndex = 50
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePickerEmployedDate
        '
        Me.DateTimePickerEmployedDate.Location = New System.Drawing.Point(139, 112)
        Me.DateTimePickerEmployedDate.Name = "DateTimePickerEmployedDate"
        Me.DateTimePickerEmployedDate.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePickerEmployedDate.TabIndex = 51
        '
        'Labelupdate
        '
        Me.Labelupdate.BackColor = System.Drawing.Color.White
        Me.Labelupdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelupdate.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelupdate.Location = New System.Drawing.Point(24, 288)
        Me.Labelupdate.Name = "Labelupdate"
        Me.Labelupdate.Size = New System.Drawing.Size(256, 40)
        Me.Labelupdate.TabIndex = 52
        Me.Labelupdate.Text = ">> If you want to update the existing  Item data, double click on Grid line."
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Current", "Dismissed", "Resigned", "Retired"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(136, 256)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxStatus.TabIndex = 53
        '
        'FormEmployee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.Labelupdate)
        Me.Controls.Add(Me.DateTimePickerEmployedDate)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.DataGridEmployee)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.ComboBoxPost)
        Me.Controls.Add(Me.LabelPost)
        Me.Controls.Add(Me.LabelPhone)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelEmployedDate)
        Me.Controls.Add(Me.LabelEducation)
        Me.Controls.Add(Me.LabelEmployeeName)
        Me.Controls.Add(Me.LabelEmployeeID)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.TextBoxPhoneNo)
        Me.Controls.Add(Me.TextBoxEducation)
        Me.Controls.Add(Me.TextBoxEmployeeName)
        Me.Controls.Add(Me.TextBoxEmployeeID)
        Me.Name = "FormEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Registration"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxEmployeeName.Text.Trim.Length <= 0 Then
                MsgBox("Please fill Employee Name.", MsgBoxStyle.Information, AppTitle)
                TextBoxEmployeeName.Focus()
            ElseIf TextBoxEducation.Text.Trim.Length <= 0 Then
                MsgBox("Please fill Employee Education Standard.", MsgBoxStyle.Information, AppTitle)
                TextBoxEducation.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerEmployedDate.Value, Now()) < 0 Then
                MsgBox("Please fill Employee's Employement Date correctly.", MsgBoxStyle.Information, AppTitle)
                DateTimePickerEmployedDate.Focus()
            ElseIf TextBoxAddress.Text.Trim.Length <= 0 Then
                MsgBox("Please fill Employee fully address.", MsgBoxStyle.Information, AppTitle)
                TextBoxAddress.Focus()
            ElseIf ComboBoxPost.Text.Trim.Length <= 0 Then
                MsgBox("Please fill Employee Post.", MsgBoxStyle.Information, AppTitle)
                ComboBoxPost.Focus()
            ElseIf ComboBoxStatus.Text.Trim.Length <= 0 Then
                MsgBox("Please choose the Employee Status.", MsgBoxStyle.Information, AppTitle)
                ComboBoxStatus.Focus()
            Else
                'If RadioButtonLoginStatusYes.Checked = True Then
                '    If TextBoxLoginName.Text.Trim.Length <= 0 Then
                '        MsgBox("Login Name must be fill.", MsgBoxStyle.Information, AppTitle)
                '        TextBoxLoginName.Focus()
                '        Exit Sub
                '    ElseIf FindData("Employees", "LoginName", "LoginName='" & TextBoxLoginName.Text & "'") > 0 Then
                '        MsgBox("'" & TextBoxLoginName.Text & "' Login Name is already existing. Please choose Another Name.", MsgBoxStyle.Information, AppTitle)
                '        TextBoxLoginName.Focus()
                '        Exit Sub
                '    ElseIf TextBoxPassword.Text.Length < 5 Then
                '        MsgBox("Password must be alease 5 character.", MsgBoxStyle.Information, AppTitle)
                '        TextBoxPassword.Focus()
                '        Exit Sub
                '    ElseIf TextBoxPassword.Text <> TextBoxConfirmPassword.Text Then
                '        MsgBox("Your password and confirm password are not same. Please refill your password.", MsgBoxStyle.Information, AppTitle)
                '        TextBoxPassword.Focus()
                '        Exit Sub
                '    ElseIf ComboBoxUserType.Text.Length <= 0 Then
                '        MsgBox("Password must choose User Type.", MsgBoxStyle.Information, AppTitle)
                '        ComboBoxUserType.Focus()
                '        Exit Sub
                '    End If
                'End If
                If TextBoxPhoneNo.Text.Trim.Length <= 0 Then TextBoxPhoneNo.Text = "-"
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Employees(EmployeeID,EmployeeName,Education,EmployedDate,Address,PhoneNo,Post,Status) Values(" & _
                    TextBoxEmployeeID.Text & ",'" & TextBoxEmployeeName.Text & "','" & TextBoxEducation.Text & "','" & DateTimePickerEmployedDate.Value & "','" & TextBoxAddress.Text & "','" & TextBoxPhoneNo.Text & "','" & ComboBoxPost.Text & "','" & ComboBoxStatus.Text &  "')")
                ElseIf ButtonSave.Text = "&Update" Then
                    SavingData("Update Employees Set EmployeeName='" & TextBoxEmployeeName.Text & "',Education='" & TextBoxEducation.Text & "',EmployedDate='" & DateTimePickerEmployedDate.Value & "',Address='" & TextBoxAddress.Text & "',PhoneNo='" & TextBoxPhoneNo.Text & "',Post='" & ComboBoxPost.Text & "',Status='" & ComboBoxStatus.Text & "' Where EmployeeID=" & TextBoxEmployeeID.Text)
                End If
                ButtonSave.Text = "&Save"
                ButtonDelete.Enabled = False
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setGridData(DataGridEmployee, "SELECT EmployeeID, EmployeeName, Education, EmployedDate, Address, PhoneNo, Post, Status FROM Employees ORDER BY EmployeeID")
            TextBoxEmployeeID.Text = GenerateNewID("Employees", "EmployeeID")
            AddtoCombo(ComboBoxPost, "Post", "PostName")
            ButtonSave.Text = "&Save"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridEmployee_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridEmployee.DoubleClick
        Try
            TextBoxEmployeeID.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 0)
            TextBoxEmployeeName.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 1)
            TextBoxEducation.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 2)
            DateTimePickerEmployedDate.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 3)
            TextBoxAddress.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 4)
            TextBoxPhoneNo.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 5)
            ComboBoxPost.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 6)
            ComboBoxStatus.Text = DataGridEmployee.Item(DataGridEmployee.CurrentRowIndex, 7)
            TextBoxEmployeeName.Focus()
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim msg As String
        Try
            If TextBoxEmployeeID.Text.Trim.Length <= 0 Then
                MsgBox("'Employee ID' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxEmployeeID.Focus()
            ElseIf FindData("Employees", "EmployeeID", "EmployeeID='" & TextBoxEmployeeID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Employee ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxEmployeeID.Focus()
            Else
                SavingData("Delete from Employees Where EmployeeID='" & TextBoxEmployeeID.Text & "';", False)
                MsgBox("Delete successfully", MsgBoxStyle.Information, AppTitle)
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
    Private Sub Clear()
        TextBoxEmployeeName.Text = vbNullString
        TextBoxEducation.Text = vbNullString
        TextBoxAddress.Text = vbNullString
        TextBoxPhoneNo.Text = vbNullString
        ComboBoxPost.SelectedIndex = -1
        ComboBoxStatus.SelectedIndex = -1
        ButtonSave.Text = "&Save"
        TextBoxEmployeeID.Text = GenerateNewID("Employees", "EmployeeID")
        setGridData(DataGridEmployee, "Select * from Employees")
    End Sub

    Private Sub DataGridEmployee_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridEmployee.Navigate

    End Sub
End Class

