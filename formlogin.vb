Public Class FormLogin
    Inherits System.Windows.Forms.Form
    Public UserType As String = "", EmployeeID As Int16 = -1
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
    Friend WithEvents LabelLoginName As System.Windows.Forms.Label
    Friend WithEvents TextBoxLoginName As System.Windows.Forms.TextBox
    Friend WithEvents LabelLoginPassword As System.Windows.Forms.Label
    Friend WithEvents TextBoxLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents LabelMessage1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormLogin))
        Me.LabelLoginName = New System.Windows.Forms.Label
        Me.TextBoxLoginName = New System.Windows.Forms.TextBox
        Me.LabelLoginPassword = New System.Windows.Forms.Label
        Me.TextBoxLoginPassword = New System.Windows.Forms.TextBox
        Me.ButtonLogin = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.LabelMessage1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LabelLoginName
        '
        Me.LabelLoginName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoginName.Location = New System.Drawing.Point(16, 80)
        Me.LabelLoginName.Name = "LabelLoginName"
        Me.LabelLoginName.Size = New System.Drawing.Size(88, 24)
        Me.LabelLoginName.TabIndex = 0
        Me.LabelLoginName.Text = "LoginName"
        '
        'TextBoxLoginName
        '
        Me.TextBoxLoginName.Location = New System.Drawing.Point(120, 80)
        Me.TextBoxLoginName.Name = "TextBoxLoginName"
        Me.TextBoxLoginName.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxLoginName.TabIndex = 1
        Me.TextBoxLoginName.Text = ""
        '
        'LabelLoginPassword
        '
        Me.LabelLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoginPassword.Location = New System.Drawing.Point(8, 120)
        Me.LabelLoginPassword.Name = "LabelLoginPassword"
        Me.LabelLoginPassword.Size = New System.Drawing.Size(96, 24)
        Me.LabelLoginPassword.TabIndex = 2
        Me.LabelLoginPassword.Text = "LoginPassword"
        '
        'TextBoxLoginPassword
        '
        Me.TextBoxLoginPassword.Location = New System.Drawing.Point(120, 120)
        Me.TextBoxLoginPassword.Name = "TextBoxLoginPassword"
        Me.TextBoxLoginPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLoginPassword.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxLoginPassword.TabIndex = 3
        Me.TextBoxLoginPassword.Text = ""
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.White
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.Color.DarkBlue
        Me.ButtonLogin.Image = CType(resources.GetObject("ButtonLogin.Image"), System.Drawing.Image)
        Me.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogin.Location = New System.Drawing.Point(32, 160)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(88, 40)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Log &In"
        Me.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.White
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(160, 160)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(96, 40)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "&Cancel"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMessage1
        '
        Me.LabelMessage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMessage1.Location = New System.Drawing.Point(16, 16)
        Me.LabelMessage1.Name = "LabelMessage1"
        Me.LabelMessage1.Size = New System.Drawing.Size(288, 40)
        Me.LabelMessage1.TabIndex = 14
        Me.LabelMessage1.Text = " *** LoginName and Login Password are not matched.  Please retype:"
        '
        'FormLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(312, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxLoginPassword)
        Me.Controls.Add(Me.TextBoxLoginName)
        Me.Controls.Add(Me.LabelLoginPassword)
        Me.Controls.Add(Me.LabelLoginName)
        Me.Controls.Add(Me.LabelMessage1)
        Me.ForeColor = System.Drawing.Color.White
        Me.KeyPreview = True
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Try
            Dim A_Command As New OleDb.OleDbDataAdapter("Select UserType,EmployeeID from Employees Where LoginStatus='Y' And LoginName='" & TextBoxLoginName.Text & "' And LoginPassword='" & TextBoxLoginPassword.Text & "' And Status='Current'", sqlString)
            Dim ADataSet As New DataSet
            ADataSet.Clear()
            A_Command.Fill(ADataSet, "srcTable")
            UserType = ""
            If ADataSet.Tables("srcTable").Rows.Count > 0 Then
                UserType = ADataSet.Tables("srcTable").Rows(0).Item(0).ToString
                EmployeeID = ADataSet.Tables("srcTable").Rows(0).Item(1).ToString
                Me.Close()
            Else
                LabelMessage1.Visible = True
            End If
            ADataSet.Dispose()
            A_Command.Dispose()
            A_Command = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        TextBoxLoginName.Text = vbNullString
        TextBoxLoginPassword.Text = vbNullString
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelMessage1.Visible = False
    End Sub

    Private Sub TextBoxLoginName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxLoginName.KeyPress
        Try
            Dim ASCII As Short = Asc(e.KeyChar)
            If ASCII = 13 Then
                TextBoxLoginPassword.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub TextBoxLoginPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxLoginPassword.KeyPress
        Try
            Dim ASCII As Short = Asc(e.KeyChar)
            If ASCII = 13 Then
                ButtonLogin_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
End Class
