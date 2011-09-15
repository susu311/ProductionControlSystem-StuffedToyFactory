Public Class FormCustomer
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
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxCustomerID As System.Windows.Forms.Label
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents LabelCountry As System.Windows.Forms.Label
    Friend WithEvents LabelPhone As System.Windows.Forms.Label
    Friend WithEvents LabelEMail As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxEMail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPhoneno As System.Windows.Forms.TextBox
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridCustomer As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormCustomer))
        Me.LabelCustomerID = New System.Windows.Forms.Label
        Me.LabelCustomerName = New System.Windows.Forms.Label
        Me.LabelCompanyName = New System.Windows.Forms.Label
        Me.TextBoxCustomerID = New System.Windows.Forms.Label
        Me.LabelAddress = New System.Windows.Forms.Label
        Me.LabelCountry = New System.Windows.Forms.Label
        Me.LabelPhone = New System.Windows.Forms.Label
        Me.LabelEMail = New System.Windows.Forms.Label
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.DataGridCustomer = New System.Windows.Forms.DataGrid
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.TextBoxAddress = New System.Windows.Forms.TextBox
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox
        Me.TextBoxCompanyName = New System.Windows.Forms.TextBox
        Me.ComboBoxCountry = New System.Windows.Forms.ComboBox
        Me.TextBoxEMail = New System.Windows.Forms.TextBox
        Me.TextBoxStatus = New System.Windows.Forms.TextBox
        Me.TextBoxPhoneno = New System.Windows.Forms.TextBox
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        CType(Me.DataGridCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerID.Location = New System.Drawing.Point(14, 16)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.TabIndex = 0
        Me.LabelCustomerID.Text = "Customer ID :"
        Me.LabelCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerName.Location = New System.Drawing.Point(14, 40)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.TabIndex = 1
        Me.LabelCustomerName.Text = "Customer Name"
        Me.LabelCustomerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompanyName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCompanyName.Location = New System.Drawing.Point(14, 64)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.TabIndex = 2
        Me.LabelCompanyName.Text = "Company Name"
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCustomerID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(134, 16)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(192, 23)
        Me.TextBoxCustomerID.TabIndex = 3
        '
        'LabelAddress
        '
        Me.LabelAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelAddress.Location = New System.Drawing.Point(14, 88)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.TabIndex = 4
        Me.LabelAddress.Text = "Address :"
        Me.LabelAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCountry
        '
        Me.LabelCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountry.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCountry.Location = New System.Drawing.Point(14, 176)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.TabIndex = 5
        Me.LabelCountry.Text = "Country"
        Me.LabelCountry.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPhone
        '
        Me.LabelPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPhone.Location = New System.Drawing.Point(14, 200)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.TabIndex = 6
        Me.LabelPhone.Text = "Phone No"
        Me.LabelPhone.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEMail
        '
        Me.LabelEMail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEMail.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEMail.Location = New System.Drawing.Point(14, 224)
        Me.LabelEMail.Name = "LabelEMail"
        Me.LabelEMail.TabIndex = 7
        Me.LabelEMail.Text = "E-Mail Address"
        Me.LabelEMail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStatus
        '
        Me.LabelStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelStatus.Location = New System.Drawing.Point(14, 248)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.TabIndex = 8
        Me.LabelStatus.Text = "Status :"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridCustomer
        '
        Me.DataGridCustomer.BackgroundColor = System.Drawing.Color.White
        Me.DataGridCustomer.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridCustomer.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridCustomer.CaptionText = "Customer Info:"
        Me.DataGridCustomer.DataMember = ""
        Me.DataGridCustomer.GridLineColor = System.Drawing.Color.Black
        Me.DataGridCustomer.HeaderBackColor = System.Drawing.Color.AliceBlue
        Me.DataGridCustomer.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridCustomer.Location = New System.Drawing.Point(336, 8)
        Me.DataGridCustomer.Name = "DataGridCustomer"
        Me.DataGridCustomer.ReadOnly = True
        Me.DataGridCustomer.Size = New System.Drawing.Size(576, 360)
        Me.DataGridCustomer.TabIndex = 12
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
        Me.ButtonSave.Size = New System.Drawing.Size(75, 64)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "&Update"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonDelete.Location = New System.Drawing.Point(16, 16)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 64)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(208, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 64)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.AutoSize = False
        Me.TextBoxAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxAddress.Location = New System.Drawing.Point(134, 88)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(192, 80)
        Me.TextBoxAddress.TabIndex = 13
        Me.TextBoxAddress.Text = ""
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(134, 40)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxCustomerName.TabIndex = 14
        Me.TextBoxCustomerName.Text = ""
        '
        'TextBoxCompanyName
        '
        Me.TextBoxCompanyName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCompanyName.Location = New System.Drawing.Point(134, 64)
        Me.TextBoxCompanyName.Name = "TextBoxCompanyName"
        Me.TextBoxCompanyName.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxCompanyName.TabIndex = 15
        Me.TextBoxCompanyName.Text = ""
        '
        'ComboBoxCountry
        '
        Me.ComboBoxCountry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxCountry.Location = New System.Drawing.Point(134, 176)
        Me.ComboBoxCountry.Name = "ComboBoxCountry"
        Me.ComboBoxCountry.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxCountry.TabIndex = 16
        '
        'TextBoxEMail
        '
        Me.TextBoxEMail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxEMail.Location = New System.Drawing.Point(134, 224)
        Me.TextBoxEMail.Name = "TextBoxEMail"
        Me.TextBoxEMail.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxEMail.TabIndex = 18
        Me.TextBoxEMail.Text = ""
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxStatus.Location = New System.Drawing.Point(134, 248)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxStatus.TabIndex = 19
        Me.TextBoxStatus.Text = ""
        '
        'TextBoxPhoneno
        '
        Me.TextBoxPhoneno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxPhoneno.Location = New System.Drawing.Point(134, 200)
        Me.TextBoxPhoneno.Name = "TextBoxPhoneno"
        Me.TextBoxPhoneno.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxPhoneno.TabIndex = 21
        Me.TextBoxPhoneno.Text = ""
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(24, 280)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(304, 88)
        Me.Groupbuttons.TabIndex = 22
        Me.Groupbuttons.TabStop = False
        '
        'FormCustomer
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 382)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.TextBoxPhoneno)
        Me.Controls.Add(Me.TextBoxStatus)
        Me.Controls.Add(Me.TextBoxEMail)
        Me.Controls.Add(Me.ComboBoxCountry)
        Me.Controls.Add(Me.TextBoxCompanyName)
        Me.Controls.Add(Me.TextBoxCustomerName)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.DataGridCustomer)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.LabelEMail)
        Me.Controls.Add(Me.LabelPhone)
        Me.Controls.Add(Me.LabelCountry)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.TextBoxCustomerID)
        Me.Controls.Add(Me.LabelCompanyName)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.LabelCustomerID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Registeration Form"
        CType(Me.DataGridCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Clear()
            ButtonSave.Text = "&Save"
            ButtonDelete.Enabled = False
            setCountry(ComboBoxCountry)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxCustomerID.Text.Trim.Length <= 0 Then
                MsgBox("'Customer ID' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCustomerID.Focus()
            ElseIf FindData("Customers", "CustomerID", "CustomerID='" & TextBoxCustomerID.Text.Trim & "'") > 0 And ButtonSave.Text.Trim = "&Save" Then
                MsgBox("'Customer ID' is Duplicate. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCustomerID.Focus()
            ElseIf FindData("Customers", "CustomerID", "CustomerID='" & TextBoxCustomerID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Customer ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCustomerID.Focus()
            ElseIf TextBoxCustomerName.Text.Trim.Length <= 0 Then
                MsgBox("'Customer Name' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCustomerName.Focus()
            ElseIf TextBoxCompanyName.Text.Trim.Length <= 0 Then
                MsgBox("'Company Name'is empty. Please enter the data", MsgBoxStyle.Information, AppTitle)
                TextBoxCompanyName.Focus()
            ElseIf TextBoxAddress.Text.Trim.Length <= 0 Then
                MsgBox("'Address'is empty. Please enter the data", MsgBoxStyle.Information, AppTitle)
                TextBoxAddress.Focus()
            ElseIf ComboBoxCountry.Text.Trim.Length <= 0 Then
                MsgBox("'Country'has not chosen. Please choose a country", MsgBoxStyle.Information, AppTitle)
                ComboBoxCountry.Focus()
            ElseIf TextBoxPhoneno.Text.Trim.Length <= 0 Then
                MsgBox("'Phoneno'is empty. Please enter the data", MsgBoxStyle.Information, AppTitle)
                TextBoxPhoneno.Focus()
            Else
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Customers Values('" & TextBoxCustomerID.Text & "','" & TextBoxCustomerName.Text & "','" & TextBoxCompanyName.Text & "','" & TextBoxAddress.Text & "','" & ComboBoxCountry.Text & "','" & TextBoxPhoneno.Text & "','" & TextBoxEMail.Text & "','" & TextBoxStatus.Text & "')", True)
                ElseIf ButtonSave.Text = "&Update" Then
                    SavingData("Update Customers Set CustomerName='" & TextBoxCustomerName.Text & "', CompanyName='" & TextBoxCompanyName.Text & "', Address= '" & TextBoxAddress.Text & "',Country='" & ComboBoxCountry.Text & "', PhoneNo='" & TextBoxPhoneno.Text & "',Email ='" & TextBoxEMail.Text & "',Status ='" & TextBoxStatus.Text & "' Where CustomerID='" & TextBoxCustomerID.Text & "';", False)
                    MsgBox("Update successfully", MsgBoxStyle.Information, AppTitle)
                End If
                Clear()
                ButtonSave.Text = "&Save"
                ButtonDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridCustomer.DoubleClick
        Try
            TextBoxCustomerID.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 0)
            TextBoxCustomerName.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 1)
            TextBoxCompanyName.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 2)
            TextBoxAddress.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 3)
            ComboBoxCountry.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 4)
            TextBoxPhoneno.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 5)
            TextBoxEMail.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 6)
            TextBoxStatus.Text = "" & DataGridCustomer.Item(DataGridCustomer.CurrentRowIndex, 7)
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim msg As String
        Try
            If TextBoxCustomerID.Text.Trim.Length <= 0 Then
                MsgBox("'Customer ID' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCustomerID.Focus()
            ElseIf FindData("Customers", "CustomerID", "CustomerID='" & TextBoxCustomerID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Customer ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCustomerID.Focus()
            Else
                SavingData("Delete from Customers Where CustomerID='" & TextBoxCustomerID.Text & "';", False)
                MsgBox("Delete successfully", MsgBoxStyle.Information, AppTitle)
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
    Private Sub Clear()
        TextBoxCustomerName.Text = vbNullString
        TextBoxCompanyName.Text = vbNullString
        TextBoxAddress.Text = vbNullString
        ComboBoxCountry.SelectedIndex = -1
        TextBoxPhoneno.Text = vbNullString
        TextBoxEMail.Text = vbNullString
        TextBoxStatus.Text = vbNullString
        ButtonSave.Text = "&Save"
        TextBoxCustomerID.Text = GenerateNewID("Customers", "CustomerID")
        setGridData(DataGridCustomer, "Select * from Customers")
    End Sub

End Class
