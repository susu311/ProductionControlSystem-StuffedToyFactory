Public Class FormJobConfirmation
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
    Friend WithEvents LabelTotalAmount As System.Windows.Forms.Label
    Friend WithEvents LabelUnitPrice As System.Windows.Forms.Label
    Friend WithEvents LabelQuantity As System.Windows.Forms.Label
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddress As System.Windows.Forms.Label
    Friend WithEvents TextBoxCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.Label
    Friend WithEvents TextBoxCustomerID As System.Windows.Forms.Label
    Friend WithEvents TextBoxSaleType As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOrderDate As System.Windows.Forms.Label
    Friend WithEvents LabelOrderDate As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOrderID As System.Windows.Forms.ComboBox
    Friend WithEvents LabelOrderID As System.Windows.Forms.Label
    Friend WithEvents TextBoxJobNo As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerConfirmedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelJobConfirmedDate As System.Windows.Forms.Label
    Friend WithEvents LabelJobNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormJobConfirmation))
        Me.GroupBoxCustomer = New System.Windows.Forms.GroupBox
        Me.TextBoxSaleType = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxAddress = New System.Windows.Forms.Label
        Me.TextBoxCompanyName = New System.Windows.Forms.Label
        Me.TextBoxCustomerName = New System.Windows.Forms.Label
        Me.TextBoxCustomerID = New System.Windows.Forms.Label
        Me.LabelTotalAmount = New System.Windows.Forms.Label
        Me.LabelUnitPrice = New System.Windows.Forms.Label
        Me.LabelQuantity = New System.Windows.Forms.Label
        Me.LabelCustomerID = New System.Windows.Forms.Label
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBoxOrderDate = New System.Windows.Forms.Label
        Me.LabelOrderDate = New System.Windows.Forms.Label
        Me.ComboBoxOrderID = New System.Windows.Forms.ComboBox
        Me.LabelOrderID = New System.Windows.Forms.Label
        Me.TextBoxJobNo = New System.Windows.Forms.Label
        Me.DateTimePickerConfirmedDate = New System.Windows.Forms.DateTimePicker
        Me.LabelJobConfirmedDate = New System.Windows.Forms.Label
        Me.LabelJobNo = New System.Windows.Forms.Label
        Me.GroupBoxCustomer.SuspendLayout()
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCustomer
        '
        Me.GroupBoxCustomer.Controls.Add(Me.TextBoxSaleType)
        Me.GroupBoxCustomer.Controls.Add(Me.Label2)
        Me.GroupBoxCustomer.Controls.Add(Me.TextBoxAddress)
        Me.GroupBoxCustomer.Controls.Add(Me.TextBoxCompanyName)
        Me.GroupBoxCustomer.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBoxCustomer.Controls.Add(Me.TextBoxCustomerID)
        Me.GroupBoxCustomer.Controls.Add(Me.LabelTotalAmount)
        Me.GroupBoxCustomer.Controls.Add(Me.LabelUnitPrice)
        Me.GroupBoxCustomer.Controls.Add(Me.LabelQuantity)
        Me.GroupBoxCustomer.Controls.Add(Me.LabelCustomerID)
        Me.GroupBoxCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCustomer.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBoxCustomer.Location = New System.Drawing.Point(384, 11)
        Me.GroupBoxCustomer.Name = "GroupBoxCustomer"
        Me.GroupBoxCustomer.Size = New System.Drawing.Size(392, 245)
        Me.GroupBoxCustomer.TabIndex = 52
        Me.GroupBoxCustomer.TabStop = False
        Me.GroupBoxCustomer.Text = "Customer Information"
        '
        'TextBoxSaleType
        '
        Me.TextBoxSaleType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxSaleType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSaleType.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxSaleType.Location = New System.Drawing.Point(120, 200)
        Me.TextBoxSaleType.Name = "TextBoxSaleType"
        Me.TextBoxSaleType.Size = New System.Drawing.Size(256, 23)
        Me.TextBoxSaleType.TabIndex = 33
        Me.TextBoxSaleType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(8, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Sale Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxAddress.Location = New System.Drawing.Point(120, 112)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(256, 80)
        Me.TextBoxAddress.TabIndex = 31
        Me.TextBoxAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxCompanyName
        '
        Me.TextBoxCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCompanyName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCompanyName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxCompanyName.Location = New System.Drawing.Point(120, 80)
        Me.TextBoxCompanyName.Name = "TextBoxCompanyName"
        Me.TextBoxCompanyName.Size = New System.Drawing.Size(256, 23)
        Me.TextBoxCompanyName.TabIndex = 30
        Me.TextBoxCompanyName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomerName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(120, 48)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(256, 23)
        Me.TextBoxCustomerName.TabIndex = 29
        Me.TextBoxCustomerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(120, 16)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(256, 23)
        Me.TextBoxCustomerID.TabIndex = 28
        Me.TextBoxCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelTotalAmount
        '
        Me.LabelTotalAmount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAmount.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTotalAmount.Location = New System.Drawing.Point(8, 112)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(104, 23)
        Me.LabelTotalAmount.TabIndex = 27
        Me.LabelTotalAmount.Text = "Address"
        Me.LabelTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelUnitPrice
        '
        Me.LabelUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitPrice.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelUnitPrice.Location = New System.Drawing.Point(8, 80)
        Me.LabelUnitPrice.Name = "LabelUnitPrice"
        Me.LabelUnitPrice.Size = New System.Drawing.Size(104, 23)
        Me.LabelUnitPrice.TabIndex = 26
        Me.LabelUnitPrice.Text = "Company Name"
        Me.LabelUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelQuantity
        '
        Me.LabelQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuantity.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelQuantity.Location = New System.Drawing.Point(8, 48)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(104, 23)
        Me.LabelQuantity.TabIndex = 25
        Me.LabelQuantity.Text = "Customer Name"
        Me.LabelQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerID.Location = New System.Drawing.Point(16, 16)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(96, 23)
        Me.LabelCustomerID.TabIndex = 24
        Me.LabelCustomerID.Text = "Customer ID"
        Me.LabelCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Job Detail: "
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(8, 264)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(776, 312)
        Me.DataGridData.TabIndex = 43
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(72, 179)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(224, 80)
        Me.Groupbuttons.TabIndex = 54
        Me.Groupbuttons.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(32, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(128, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxOrderDate)
        Me.GroupBox3.Controls.Add(Me.LabelOrderDate)
        Me.GroupBox3.Controls.Add(Me.ComboBoxOrderID)
        Me.GroupBox3.Controls.Add(Me.LabelOrderID)
        Me.GroupBox3.Controls.Add(Me.TextBoxJobNo)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerConfirmedDate)
        Me.GroupBox3.Controls.Add(Me.LabelJobConfirmedDate)
        Me.GroupBox3.Controls.Add(Me.LabelJobNo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 144)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Job Information"
        '
        'TextBoxOrderDate
        '
        Me.TextBoxOrderDate.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxOrderDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxOrderDate.Location = New System.Drawing.Point(136, 80)
        Me.TextBoxOrderDate.Name = "TextBoxOrderDate"
        Me.TextBoxOrderDate.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxOrderDate.TabIndex = 45
        '
        'LabelOrderDate
        '
        Me.LabelOrderDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelOrderDate.Location = New System.Drawing.Point(48, 80)
        Me.LabelOrderDate.Name = "LabelOrderDate"
        Me.LabelOrderDate.Size = New System.Drawing.Size(72, 16)
        Me.LabelOrderDate.TabIndex = 44
        Me.LabelOrderDate.Text = "Order Date"
        Me.LabelOrderDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxOrderID
        '
        Me.ComboBoxOrderID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxOrderID.Location = New System.Drawing.Point(136, 48)
        Me.ComboBoxOrderID.Name = "ComboBoxOrderID"
        Me.ComboBoxOrderID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxOrderID.TabIndex = 43
        '
        'LabelOrderID
        '
        Me.LabelOrderID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelOrderID.Location = New System.Drawing.Point(40, 48)
        Me.LabelOrderID.Name = "LabelOrderID"
        Me.LabelOrderID.Size = New System.Drawing.Size(72, 16)
        Me.LabelOrderID.TabIndex = 42
        Me.LabelOrderID.Text = "Order ID"
        Me.LabelOrderID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxJobNo
        '
        Me.TextBoxJobNo.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxJobNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxJobNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxJobNo.Location = New System.Drawing.Point(136, 16)
        Me.TextBoxJobNo.Name = "TextBoxJobNo"
        Me.TextBoxJobNo.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxJobNo.TabIndex = 30
        '
        'DateTimePickerConfirmedDate
        '
        Me.DateTimePickerConfirmedDate.Location = New System.Drawing.Point(136, 112)
        Me.DateTimePickerConfirmedDate.Name = "DateTimePickerConfirmedDate"
        Me.DateTimePickerConfirmedDate.TabIndex = 40
        '
        'LabelJobConfirmedDate
        '
        Me.LabelJobConfirmedDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJobConfirmedDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelJobConfirmedDate.Location = New System.Drawing.Point(24, 112)
        Me.LabelJobConfirmedDate.Name = "LabelJobConfirmedDate"
        Me.LabelJobConfirmedDate.Size = New System.Drawing.Size(96, 16)
        Me.LabelJobConfirmedDate.TabIndex = 22
        Me.LabelJobConfirmedDate.Text = "Confirmed Date"
        Me.LabelJobConfirmedDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelJobNo
        '
        Me.LabelJobNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJobNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelJobNo.Location = New System.Drawing.Point(48, 16)
        Me.LabelJobNo.Name = "LabelJobNo"
        Me.LabelJobNo.Size = New System.Drawing.Size(72, 16)
        Me.LabelJobNo.TabIndex = 21
        Me.LabelJobNo.Text = "Job No"
        Me.LabelJobNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FormJobConfirmation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 582)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.GroupBoxCustomer)
        Me.Controls.Add(Me.DataGridData)
        Me.Name = "FormJobConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job Confirmation"
        Me.GroupBoxCustomer.ResumeLayout(False)
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormJobConfirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddtoCombo(ComboBoxOrderID, "Orders", "OrderID")
            TextBoxOrderDate.Text = vbNullString
            DateTimePickerConfirmedDate.Value = Now
            'DateTimePickerDeliveryDate.Value = Now
            TextBoxCustomerID.Text = vbNullString
            TextBoxCustomerName.Text = vbNullString
            TextBoxCompanyName.Text = vbNullString
            TextBoxAddress.Text = vbNullString
            TextBoxSaleType.Text = vbNullString
            ComboBoxOrderID.SelectedIndex = -1
            ComboBoxOrderID.SelectedIndex = -1
            TextBoxJobNo.Text = GenerateNewID("Jobs", "JobNo")
            setGridData(DataGridData, "Select DesignNo,DesignName,SampleWidth,SampleHeight,Qty,UnitPirce,Amount from ViewOrders Where OrderID=0")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If ComboBoxOrderID.Text.Trim.Length <= 0 Then
                MsgBox("Order must fill Order ID.", MsgBoxStyle.Information, AppTitle)
                ComboBoxOrderID.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerConfirmedDate.Value, Now.Today) > 0 Then
                MsgBox("Confirmed Date must be later than today date.", MsgBoxStyle.Information, AppTitle)
                DateTimePickerConfirmedDate.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerConfirmedDate.Value, CDate(TextBoxOrderDate.Text)) > 0 Then
                MsgBox("Confirmed Date must be later than Order date.", MsgBoxStyle.Information, AppTitle)
                DateTimePickerConfirmedDate.Focus()
            Else
                SavingData("Insert Into Jobs Values(" & TextBoxJobNo.Text & "," & ComboBoxOrderID.Text & ",'" & SQLDateTime(CDate(DateTimePickerConfirmedDate.Value), Main.SQLDType.sqlDateOnly, True) & "',NULL,'" & TextBoxSaleType.Text & "')", False)
                Dim i As Int16
                Dim DataTableData As DataTable = DataGridData.DataSource
                For i = 0 To DataTableData.Rows.Count - 1
                    SavingData("Insert Into JobDetail values(" & GenerateNewID("JobDetail", "JobDetailID") & "," & TextBoxJobNo.Text & "," & DataTableData.Rows(i).Item(0) & "," & DataTableData.Rows(i).Item(4) & "," & DataTableData.Rows(i).Item(5) & ", " & DataTableData.Rows(i).Item(6) & ")", False)
                Next
                MsgBox("Save successfully", MsgBoxStyle.Information, AppTitle)
                FormJobConfirmation_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxOrderID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxOrderID.SelectedIndexChanged
        Try
            If ComboBoxOrderID.SelectedIndex >= 0 And ComboBoxOrderID.Text <> "System.Data.DataRowView" Then
                Dim DataSetData As New DataSet
                Dim OleDbAdapter As New OleDb.OleDbDataAdapter("Select * from ViewOrders Where OrderID=" & Val(ComboBoxOrderID.Text), sqlString)
                OleDbAdapter.Fill(DataSetData, "ViewOrders")
                With DataSetData
                    If .Tables(0).Rows.Count <= 0 Then
                        MsgBox("Order ID was not found.", MsgBoxStyle.Information, AppTitle)
                        ComboBoxOrderID.Focus()
                    Else
                        TextBoxOrderDate.Text = FormatDateTime(.Tables(0).Rows(0).Item(1), DateFormat.ShortDate)
                        TextBoxCustomerID.Text = .Tables(0).Rows(0).Item(2)
                        TextBoxCustomerName.Text = .Tables(0).Rows(0).Item(3)
                        TextBoxCompanyName.Text = .Tables(0).Rows(0).Item(4)
                        TextBoxAddress.Text = .Tables(0).Rows(0).Item(5)
                        TextBoxSaleType.Text = .Tables(0).Rows(0).Item(6)
                        setGridData(DataGridData, "Select DesignNo,DesignName,SampleWidth,SampleHeight,Qty,UnitPirce,Amount from ViewOrders Where OrderID=" & Val(ComboBoxOrderID.Text))
                    End If
                End With
                DataSetData.Dispose()
                OleDbAdapter.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
