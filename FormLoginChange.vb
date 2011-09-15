Public Class FormLoginChange
    Inherits System.Windows.Forms.Form
    Public EmployeeID As Int16
    Public LoginName As String

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
    Friend WithEvents TextBoxConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLoginName As System.Windows.Forms.TextBox
    Friend WithEvents LabelLoginOldPassword As System.Windows.Forms.Label
    Friend WithEvents LabelLoginName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelConfirmNewPassword As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxNewPassword As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox
        Me.TextBoxLoginPassword = New System.Windows.Forms.TextBox
        Me.TextBoxLoginName = New System.Windows.Forms.TextBox
        Me.LabelConfirmNewPassword = New System.Windows.Forms.Label
        Me.LabelLoginOldPassword = New System.Windows.Forms.Label
        Me.LabelLoginName = New System.Windows.Forms.Label
        Me.TextBoxNewPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.Groupbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(144, 88)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxConfirmPassword.TabIndex = 65
        Me.TextBoxConfirmPassword.Text = ""
        '
        'TextBoxLoginPassword
        '
        Me.TextBoxLoginPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxLoginPassword.Location = New System.Drawing.Point(144, 40)
        Me.TextBoxLoginPassword.Name = "TextBoxLoginPassword"
        Me.TextBoxLoginPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLoginPassword.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxLoginPassword.TabIndex = 63
        Me.TextBoxLoginPassword.Text = ""
        '
        'TextBoxLoginName
        '
        Me.TextBoxLoginName.BackColor = System.Drawing.Color.White
        Me.TextBoxLoginName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLoginName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxLoginName.Location = New System.Drawing.Point(144, 16)
        Me.TextBoxLoginName.Name = "TextBoxLoginName"
        Me.TextBoxLoginName.ReadOnly = True
        Me.TextBoxLoginName.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxLoginName.TabIndex = 62
        Me.TextBoxLoginName.Text = ""
        '
        'LabelConfirmNewPassword
        '
        Me.LabelConfirmNewPassword.BackColor = System.Drawing.Color.White
        Me.LabelConfirmNewPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConfirmNewPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelConfirmNewPassword.Location = New System.Drawing.Point(0, 88)
        Me.LabelConfirmNewPassword.Name = "LabelConfirmNewPassword"
        Me.LabelConfirmNewPassword.Size = New System.Drawing.Size(136, 23)
        Me.LabelConfirmNewPassword.TabIndex = 64
        Me.LabelConfirmNewPassword.Text = "Confirm New Password"
        Me.LabelConfirmNewPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelLoginOldPassword
        '
        Me.LabelLoginOldPassword.BackColor = System.Drawing.Color.White
        Me.LabelLoginOldPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoginOldPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelLoginOldPassword.Location = New System.Drawing.Point(8, 40)
        Me.LabelLoginOldPassword.Name = "LabelLoginOldPassword"
        Me.LabelLoginOldPassword.Size = New System.Drawing.Size(128, 16)
        Me.LabelLoginOldPassword.TabIndex = 61
        Me.LabelLoginOldPassword.Text = "Login Old Password"
        Me.LabelLoginOldPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelLoginName
        '
        Me.LabelLoginName.BackColor = System.Drawing.Color.White
        Me.LabelLoginName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoginName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelLoginName.Location = New System.Drawing.Point(64, 16)
        Me.LabelLoginName.Name = "LabelLoginName"
        Me.LabelLoginName.Size = New System.Drawing.Size(72, 16)
        Me.LabelLoginName.TabIndex = 60
        Me.LabelLoginName.Text = "Login Name"
        Me.LabelLoginName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxNewPassword
        '
        Me.TextBoxNewPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxNewPassword.Location = New System.Drawing.Point(144, 64)
        Me.TextBoxNewPassword.Name = "TextBoxNewPassword"
        Me.TextBoxNewPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNewPassword.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxNewPassword.TabIndex = 67
        Me.TextBoxNewPassword.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Login New Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonCancel)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(8, 120)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(328, 48)
        Me.Groupbuttons.TabIndex = 68
        Me.Groupbuttons.TabStop = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(123, 16)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Canc&el"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(24, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "&Save"
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(224, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "&Close"
        '
        'FormLoginChange
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(352, 174)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.TextBoxNewPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Controls.Add(Me.TextBoxLoginPassword)
        Me.Controls.Add(Me.TextBoxLoginName)
        Me.Controls.Add(Me.LabelConfirmNewPassword)
        Me.Controls.Add(Me.LabelLoginOldPassword)
        Me.Controls.Add(Me.LabelLoginName)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormLoginChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login Change"
        Me.Groupbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Clear()
    End Sub

    Private Sub Clear()
        'TextBoxLoginName.Text = vbNullString
        TextBoxLoginPassword.Text = vbNullString
        TextBoxConfirmPassword.Text = vbNullString
        TextBoxNewPassword.Text = vbNullString
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If StrComp(TextBoxConfirmPassword.Text, TextBoxNewPassword.Text) <> 0 Then
                MsgBox("New Password and Confirm Password are not same.", MsgBoxStyle.Information, AppTitle)
                TextBoxNewPassword.Focus()
            ElseIf TextBoxNewPassword.Text.Trim.Length <= 5 Then
                MsgBox("Password must alease 5 character.", MsgBoxStyle.Information, AppTitle)
                TextBoxLoginPassword.Focus()
            ElseIf StrComp(TextBoxNewPassword.Text, TextBoxConfirmPassword.Text, CompareMethod.Binary) <> 0 Then
                MsgBox("Your new Password is not same.", MsgBoxStyle.Information, AppTitle)
                TextBoxNewPassword.Focus()
            ElseIf FindData("Employees", "LoginName", "EmployeeID=" & EmployeeID & " and LoginStatus='Y' and LoginName='" & TextBoxLoginName.Text & "' and LoginPassword='" & TextBoxLoginPassword.Text & "'") > 0 Then
                SavingData("Update Employees Set LoginPassword='" & TextBoxNewPassword.Text & "' Where EmployeeID=" & EmployeeID)
                TextBoxConfirmPassword.Text = vbNullString
                TextBoxNewPassword.Text = vbNullString
                TextBoxLoginPassword.Text = vbNullString
                ButtonClose.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub FormLoginChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxLoginName.Text = LoginName
    End Sub
End Class
