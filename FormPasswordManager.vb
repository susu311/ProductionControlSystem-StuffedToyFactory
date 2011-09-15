Public Class FormPasswordManager
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
    Friend WithEvents LabelUserType As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelLoginPassword As System.Windows.Forms.Label
    Friend WithEvents LabelLoginName As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxEmployee As System.Windows.Forms.Label
    Friend WithEvents TextBoxLoginName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelPasswordManager As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormPasswordManager))
        Me.LabelUserType = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.TextBoxLoginPassword = New System.Windows.Forms.TextBox
        Me.TextBoxLoginName = New System.Windows.Forms.TextBox
        Me.LabelLoginPassword = New System.Windows.Forms.Label
        Me.LabelLoginName = New System.Windows.Forms.Label
        Me.ComboBoxUserType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxEmployee = New System.Windows.Forms.ComboBox
        Me.TextBoxEmployee = New System.Windows.Forms.Label
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelPasswordManager = New System.Windows.Forms.Label
        Me.Groupbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelUserType
        '
        Me.LabelUserType.BackColor = System.Drawing.Color.White
        Me.LabelUserType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserType.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelUserType.Location = New System.Drawing.Point(40, 114)
        Me.LabelUserType.Name = "LabelUserType"
        Me.LabelUserType.Size = New System.Drawing.Size(72, 16)
        Me.LabelUserType.TabIndex = 46
        Me.LabelUserType.Text = "User Type"
        Me.LabelUserType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(16, 224)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(432, 80)
        Me.Groupbuttons.TabIndex = 44
        Me.Groupbuttons.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonDelete.Location = New System.Drawing.Point(40, 16)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(56, 56)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(192, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(336, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxLoginPassword
        '
        Me.TextBoxLoginPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxLoginPassword.Location = New System.Drawing.Point(120, 171)
        Me.TextBoxLoginPassword.Name = "TextBoxLoginPassword"
        Me.TextBoxLoginPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLoginPassword.Size = New System.Drawing.Size(328, 20)
        Me.TextBoxLoginPassword.TabIndex = 42
        Me.TextBoxLoginPassword.Text = ""
        '
        'TextBoxLoginName
        '
        Me.TextBoxLoginName.BackColor = System.Drawing.Color.White
        Me.TextBoxLoginName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLoginName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxLoginName.Location = New System.Drawing.Point(120, 143)
        Me.TextBoxLoginName.Name = "TextBoxLoginName"
        Me.TextBoxLoginName.Size = New System.Drawing.Size(328, 20)
        Me.TextBoxLoginName.TabIndex = 41
        Me.TextBoxLoginName.Text = ""
        '
        'LabelLoginPassword
        '
        Me.LabelLoginPassword.BackColor = System.Drawing.Color.White
        Me.LabelLoginPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoginPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelLoginPassword.Location = New System.Drawing.Point(16, 170)
        Me.LabelLoginPassword.Name = "LabelLoginPassword"
        Me.LabelLoginPassword.Size = New System.Drawing.Size(96, 16)
        Me.LabelLoginPassword.TabIndex = 40
        Me.LabelLoginPassword.Text = "Login Password"
        Me.LabelLoginPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelLoginName
        '
        Me.LabelLoginName.BackColor = System.Drawing.Color.White
        Me.LabelLoginName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoginName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelLoginName.Location = New System.Drawing.Point(40, 143)
        Me.LabelLoginName.Name = "LabelLoginName"
        Me.LabelLoginName.Size = New System.Drawing.Size(72, 16)
        Me.LabelLoginName.TabIndex = 39
        Me.LabelLoginName.Text = "Login Name"
        Me.LabelLoginName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxUserType
        '
        Me.ComboBoxUserType.ForeColor = System.Drawing.Color.DarkBlue
        Me.ComboBoxUserType.Items.AddRange(New Object() {"Administrator", "Manager", "Staff"})
        Me.ComboBoxUserType.Location = New System.Drawing.Point(120, 114)
        Me.ComboBoxUserType.Name = "ComboBoxUserType"
        Me.ComboBoxUserType.Size = New System.Drawing.Size(328, 21)
        Me.ComboBoxUserType.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(16, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Employee Info :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(0, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Employee ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxEmployee
        '
        Me.ComboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEmployee.Location = New System.Drawing.Point(120, 56)
        Me.ComboBoxEmployee.Name = "ComboBoxEmployee"
        Me.ComboBoxEmployee.Size = New System.Drawing.Size(328, 21)
        Me.ComboBoxEmployee.TabIndex = 56
        '
        'TextBoxEmployee
        '
        Me.TextBoxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxEmployee.Location = New System.Drawing.Point(120, 85)
        Me.TextBoxEmployee.Name = "TextBoxEmployee"
        Me.TextBoxEmployee.Size = New System.Drawing.Size(328, 21)
        Me.TextBoxEmployee.TabIndex = 57
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(120, 199)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(328, 20)
        Me.TextBoxConfirmPassword.TabIndex = 59
        Me.TextBoxConfirmPassword.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(0, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Confirm Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'LabelPasswordManager
        '
        Me.LabelPasswordManager.BackColor = System.Drawing.Color.White
        Me.LabelPasswordManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPasswordManager.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPasswordManager.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPasswordManager.Location = New System.Drawing.Point(56, 8)
        Me.LabelPasswordManager.Name = "LabelPasswordManager"
        Me.LabelPasswordManager.Size = New System.Drawing.Size(216, 24)
        Me.LabelPasswordManager.TabIndex = 53
        Me.LabelPasswordManager.Text = "Password Manager"
        '
        'FormPasswordManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(464, 310)
        Me.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxEmployee)
        Me.Controls.Add(Me.ComboBoxEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelPasswordManager)
        Me.Controls.Add(Me.ComboBoxUserType)
        Me.Controls.Add(Me.LabelUserType)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.TextBoxLoginPassword)
        Me.Controls.Add(Me.TextBoxLoginName)
        Me.Controls.Add(Me.LabelLoginPassword)
        Me.Controls.Add(Me.LabelLoginName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormPasswordManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Password Manager"
        Me.Groupbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormPasswordManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddtoCombo(ComboBoxEmployee, "Employees", "EmployeeID")    '"EmployeeName + ' : ' + Post", "EmployeeID")
        ButtonSave.Text = "&Save"
    End Sub

    Private Sub ComboBoxEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEmployee.SelectedIndexChanged
        '        If ComboBoxEmployee.Text.Trim.Length > 0 Then TextBoxEmployee.Text = FindData("Employees", "EmployeeName+' : '+Post", "EmployeeID=" & ComboBoxEmployee.Text)
        Dim sql As String
        Try
            If ComboBoxEmployee.SelectedIndex >= 0 And ComboBoxEmployee.Text <> "System.Data.DataRowView" Then
                sql = "SELECT EmployeeName+' : '+Post as EmpInfo FROM Employees WHERE EmployeeID=" & ComboBoxEmployee.Text.Trim
                Dim A_Command As New OleDb.OleDbDataAdapter(sql, sqlString)
                Dim ADataSet As New DataSet
                A_Command.Fill(ADataSet, "TableName")
                If ADataSet.Tables(0).Rows.Count > 0 Then
                    With ADataSet.Tables(0).Rows(0)
                        TextBoxEmployee.Text = .Item(0)
                    End With
                Else
                    TextBoxEmployee.Text = vbNullString
                End If
                A_Command.Dispose()
                A_Command = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If ComboBoxEmployee.Text.Trim.Length <= 0 Then
                MsgBox("You must first choose the Employee ID.", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployee.Focus()
            ElseIf ComboBoxUserType.Text.Trim.Length <= 0 Then
                MsgBox("You must first choose the User Type.", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployee.Focus()
            ElseIf FindData("Employees", "LoginName", "LoginName='" & TextBoxLoginName.Text & "'") > 0 Then
                MsgBox("'" & TextBoxLoginName.Text & "' is already existing login name.", MsgBoxStyle.Information, AppTitle)
                TextBoxLoginName.Focus()
            ElseIf TextBoxLoginPassword.Text.Trim.Length <= 5 Then
                MsgBox("Password must alease 5 character.", MsgBoxStyle.Information, AppTitle)
                TextBoxLoginPassword.Focus()
            ElseIf StrComp(TextBoxLoginPassword.Text, TextBoxConfirmPassword.Text, CompareMethod.Binary) <> 0 Then
                MsgBox("Login Password and Confirm Password is not save.", MsgBoxStyle.Information, AppTitle)
                TextBoxLoginPassword.Focus()
            Else
                SavingData("Update Employees Set LoginName='" & TextBoxLoginName.Text & "', LoginPassword='" & TextBoxLoginPassword.Text & "', UserType='" & ComboBoxUserType.Text & "', LoginStatus='Y' Where EmployeeID=" & ComboBoxEmployee.Text)
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            If ComboBoxEmployee.Text.Trim.Length <= 0 Then
                MsgBox("You must first choose the Employee ID.", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployee.Focus()
            Else
                SavingData("Update Employees Set LoginName='', LoginPassword='', UserType='', LoginStatus='N' Where EmployeeID=" & ComboBoxEmployee.Text, False)
                Clear()
                MsgBox("Delete Successfully.", MsgBoxStyle.Information, AppTitle)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try

    End Sub

    Private Sub Clear()
        ComboBoxEmployee.SelectedIndex = -1
        ComboBoxUserType.SelectedIndex = -1
        TextBoxEmployee.Text = vbNullString
        TextBoxLoginName.Text = vbNullString
        TextBoxConfirmPassword.Text = vbNullString
        TextBoxLoginPassword.Text = vbNullString
    End Sub
End Class
