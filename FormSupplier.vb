Public Class FormSupplier
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
    Friend WithEvents LabelRemark As System.Windows.Forms.Label
    Friend WithEvents LabelEmailAddress As System.Windows.Forms.Label
    Friend WithEvents LabelPhone As System.Windows.Forms.Label
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents LabelCompany As System.Windows.Forms.Label
    Friend WithEvents LabelSupplierName As System.Windows.Forms.Label
    Friend WithEvents LabelSupplierID As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSupplierID As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridSupplier As System.Windows.Forms.DataGrid
    Friend WithEvents TextBoxPhoneNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSupplier))
        Me.LabelRemark = New System.Windows.Forms.Label
        Me.LabelEmailAddress = New System.Windows.Forms.Label
        Me.LabelPhone = New System.Windows.Forms.Label
        Me.LabelAddress = New System.Windows.Forms.Label
        Me.LabelCompany = New System.Windows.Forms.Label
        Me.LabelSupplierName = New System.Windows.Forms.Label
        Me.LabelSupplierID = New System.Windows.Forms.Label
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.TextBoxEmailAddress = New System.Windows.Forms.TextBox
        Me.TextBoxPhoneNo = New System.Windows.Forms.TextBox
        Me.TextBoxCompanyName = New System.Windows.Forms.TextBox
        Me.TextBoxSupplierName = New System.Windows.Forms.TextBox
        Me.TextBoxSupplierID = New System.Windows.Forms.Label
        Me.TextBoxAddress = New System.Windows.Forms.TextBox
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridSupplier = New System.Windows.Forms.DataGrid
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelRemark
        '
        Me.LabelRemark.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRemark.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelRemark.Location = New System.Drawing.Point(0, 232)
        Me.LabelRemark.Name = "LabelRemark"
        Me.LabelRemark.TabIndex = 51
        Me.LabelRemark.Text = "Remark"
        Me.LabelRemark.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEmailAddress
        '
        Me.LabelEmailAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmailAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEmailAddress.Location = New System.Drawing.Point(0, 200)
        Me.LabelEmailAddress.Name = "LabelEmailAddress"
        Me.LabelEmailAddress.TabIndex = 50
        Me.LabelEmailAddress.Text = "Email Address:"
        Me.LabelEmailAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPhone
        '
        Me.LabelPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPhone.Location = New System.Drawing.Point(0, 168)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.TabIndex = 49
        Me.LabelPhone.Text = "Phone No"
        Me.LabelPhone.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelAddress
        '
        Me.LabelAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelAddress.Location = New System.Drawing.Point(0, 112)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.TabIndex = 48
        Me.LabelAddress.Text = "Address"
        Me.LabelAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCompany
        '
        Me.LabelCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompany.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCompany.Location = New System.Drawing.Point(0, 80)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.TabIndex = 46
        Me.LabelCompany.Text = "Company Name"
        Me.LabelCompany.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSupplierName
        '
        Me.LabelSupplierName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupplierName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSupplierName.Location = New System.Drawing.Point(0, 48)
        Me.LabelSupplierName.Name = "LabelSupplierName"
        Me.LabelSupplierName.TabIndex = 45
        Me.LabelSupplierName.Text = "Supplier Name"
        Me.LabelSupplierName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSupplierID
        '
        Me.LabelSupplierID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupplierID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSupplierID.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LabelSupplierID.Location = New System.Drawing.Point(0, 16)
        Me.LabelSupplierID.Name = "LabelSupplierID"
        Me.LabelSupplierID.TabIndex = 44
        Me.LabelSupplierID.Text = "Supplier ID"
        Me.LabelSupplierID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(120, 232)
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxRemark.TabIndex = 58
        Me.TextBoxRemark.Text = ""
        '
        'TextBoxEmailAddress
        '
        Me.TextBoxEmailAddress.Location = New System.Drawing.Point(120, 200)
        Me.TextBoxEmailAddress.Name = "TextBoxEmailAddress"
        Me.TextBoxEmailAddress.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxEmailAddress.TabIndex = 57
        Me.TextBoxEmailAddress.Text = ""
        '
        'TextBoxPhoneNo
        '
        Me.TextBoxPhoneNo.Location = New System.Drawing.Point(120, 168)
        Me.TextBoxPhoneNo.Name = "TextBoxPhoneNo"
        Me.TextBoxPhoneNo.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxPhoneNo.TabIndex = 55
        Me.TextBoxPhoneNo.Text = ""
        '
        'TextBoxCompanyName
        '
        Me.TextBoxCompanyName.Location = New System.Drawing.Point(120, 80)
        Me.TextBoxCompanyName.Name = "TextBoxCompanyName"
        Me.TextBoxCompanyName.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxCompanyName.TabIndex = 54
        Me.TextBoxCompanyName.Text = ""
        '
        'TextBoxSupplierName
        '
        Me.TextBoxSupplierName.Location = New System.Drawing.Point(120, 48)
        Me.TextBoxSupplierName.Name = "TextBoxSupplierName"
        Me.TextBoxSupplierName.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxSupplierName.TabIndex = 53
        Me.TextBoxSupplierName.Text = ""
        '
        'TextBoxSupplierID
        '
        Me.TextBoxSupplierID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSupplierID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxSupplierID.Location = New System.Drawing.Point(120, 16)
        Me.TextBoxSupplierID.Name = "TextBoxSupplierID"
        Me.TextBoxSupplierID.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxSupplierID.TabIndex = 52
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(120, 112)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAddress.Size = New System.Drawing.Size(184, 48)
        Me.TextBoxAddress.TabIndex = 56
        Me.TextBoxAddress.Text = ""
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(8, 264)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(304, 88)
        Me.Groupbuttons.TabIndex = 59
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
        Me.ButtonDelete.Size = New System.Drawing.Size(56, 64)
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
        Me.ButtonSave.Location = New System.Drawing.Point(120, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(56, 64)
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
        Me.ButtonClose.Location = New System.Drawing.Point(216, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 64)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DataGridSupplier
        '
        Me.DataGridSupplier.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSupplier.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSupplier.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSupplier.CaptionText = "Supplier Info:"
        Me.DataGridSupplier.DataMember = ""
        Me.DataGridSupplier.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSupplier.HeaderBackColor = System.Drawing.Color.AliceBlue
        Me.DataGridSupplier.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridSupplier.Location = New System.Drawing.Point(320, 8)
        Me.DataGridSupplier.Name = "DataGridSupplier"
        Me.DataGridSupplier.Size = New System.Drawing.Size(584, 344)
        Me.DataGridSupplier.TabIndex = 60
        '
        'FormSupplier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(912, 366)
        Me.Controls.Add(Me.DataGridSupplier)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.TextBoxRemark)
        Me.Controls.Add(Me.TextBoxEmailAddress)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.TextBoxPhoneNo)
        Me.Controls.Add(Me.TextBoxCompanyName)
        Me.Controls.Add(Me.TextBoxSupplierName)
        Me.Controls.Add(Me.TextBoxSupplierID)
        Me.Controls.Add(Me.LabelRemark)
        Me.Controls.Add(Me.LabelEmailAddress)
        Me.Controls.Add(Me.LabelPhone)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelCompany)
        Me.Controls.Add(Me.LabelSupplierName)
        Me.Controls.Add(Me.LabelSupplierID)
        Me.Name = "FormSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Supplier"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FormCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TextBoxSupplierID.Text = GenerateNewID("Suppliers", "SupplierID") ', "SupplierID ='" & TextBoxCustomerID.Text.Trim & "'")
            setGridData(DataGridSupplier, "Select * from Suppliers")
            ButtonSave.Text = "&Save"
            ButtonDelete.Enabled = False
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
            If TextBoxSupplierID.Text.Trim.Length <= 0 Then
                MsgBox("'Supplier ID' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxSupplierID.Focus()
            ElseIf FindData("Suppliers", "SupplierID", "SupplierID='" & TextBoxSupplierID.Text.Trim & "'") > 0 And ButtonSave.Text.Trim = "&Save" Then
                MsgBox("'Supplier ID' is Duplicate. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxSupplierID.Focus()
            ElseIf FindData("Suppliers", "SupplierID", "SupplierID='" & TextBoxSupplierID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Supplier ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxSupplierID.Focus()
            ElseIf TextBoxSupplierName.Text.Trim.Length <= 0 Then
                MsgBox("'Supplier Name' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxSupplierName.Focus()
            ElseIf TextBoxCompanyName.Text.Trim.Length <= 0 Then
                MsgBox("'Company Name'is empty. Please enter the data", MsgBoxStyle.Information, AppTitle)
                TextBoxCompanyName.Focus()
            ElseIf TextBoxAddress.Text.Trim.Length <= 0 Then
                MsgBox("'Address'is empty. Please enter the data", MsgBoxStyle.Information, AppTitle)
                TextBoxAddress.Focus()
            ElseIf TextBoxPhoneNo.Text.Trim.Length <= 0 Then
                MsgBox("'Phoneno'is empty. Please enter the data", MsgBoxStyle.Information, AppTitle)
                TextBoxPhoneNo.Focus()
            Else
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Suppliers Values('" & TextBoxSupplierID.Text & "','" & TextBoxSupplierName.Text & "','" & TextBoxCompanyName.Text & "','" & TextBoxAddress.Text & "','" & TextBoxPhoneNo.Text & "','" & TextBoxEmailAddress.Text & "','" & TextBoxRemark.Text & "')", True)
                    TextBoxSupplierID.Text = GenerateNewID("Suppliers", "SupplierID")
                ElseIf ButtonSave.Text = "&Update" Then
                    SavingData("Update Suppliers Set SupplierName ='" & TextBoxSupplierName.Text & "', CompanyName='" & TextBoxCompanyName.Text & "', Address= '" & TextBoxAddress.Text & "',  PhoneNo='" & TextBoxPhoneNo.Text & "',Email ='" & TextBoxEmailAddress.Text & "',Remark ='" & TextBoxRemark.Text & "' Where SupplierID='" & TextBoxSupplierID.Text & "';", False)
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
    Private Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim msg As String
        Try
            If TextBoxSupplierID.Text.Trim.Length <= 0 Then
                MsgBox("'Supplier ID' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxSupplierID.Focus()
            ElseIf FindData("Suppliers", "SupplierID", "SupplierID='" & TextBoxSupplierID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Supplier ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxSupplierID.Focus()
            Else

                SavingData("Delete from Suppliers Where SupplierID='" & TextBoxSupplierID.Text & "';", False)
                MsgBox("Delete successfully", MsgBoxStyle.Information, AppTitle)
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
    Private Sub Clear()
        TextBoxSupplierName.Text = vbNullString
        TextBoxCompanyName.Text = vbNullString
        TextBoxAddress.Text = vbNullString
        TextBoxPhoneNo.Text = vbNullString
        TextBoxEmailAddress.Text = vbNullString
        TextBoxRemark.Text = vbNullString
        ButtonSave.Text = "&Save"
        TextBoxSupplierID.Text = GenerateNewID("Suppliers", "SupplierID")
        setGridData(DataGridSupplier, "Select * from Suppliers")
    End Sub

    Private Sub DataGridSupplier_Navigate(ByVal sender As Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridSupplier.Navigate

    End Sub

    Private Sub DataGridSupplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridSupplier.DoubleClick
        Try
            TextBoxSupplierID.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 0)
            TextBoxSupplierName.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 1)
            TextBoxCompanyName.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 2)
            TextBoxAddress.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 3)
            TextBoxPhoneNo.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 4)
            TextBoxEmailAddress.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 5)
            TextBoxRemark.Text = "" & DataGridSupplier.Item(DataGridSupplier.CurrentRowIndex, 6)
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
End Class
