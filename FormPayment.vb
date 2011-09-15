Public Class FormPayment
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
    Friend WithEvents LabelInvoiceBill As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelAmountPaid As System.Windows.Forms.Label
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents LabelPaymentDate As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxJobNo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelJobNo As System.Windows.Forms.Label
    Friend WithEvents TextBoxBillNo As System.Windows.Forms.Label
    Friend WithEvents LabelBillNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxUnitPrice As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents TextBoxConfirmedDate As System.Windows.Forms.Label
    Friend WithEvents LabelConfirmedDate As System.Windows.Forms.Label
    Friend WithEvents TextBoxDeliveryDate As System.Windows.Forms.Label
    Friend WithEvents LabelDeliveryDate As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents TextBoxCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddress As System.Windows.Forms.Label
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotalAmount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSaleType As System.Windows.Forms.Label
    Friend WithEvents LabelSaleType As System.Windows.Forms.Label
    Friend WithEvents TextBoxCustomerID As System.Windows.Forms.Label
    Friend WithEvents TextBoxAmountPaid As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormPayment))
        Me.LabelInvoiceBill = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBoxDeliveryDate = New System.Windows.Forms.Label
        Me.LabelDeliveryDate = New System.Windows.Forms.Label
        Me.TextBoxConfirmedDate = New System.Windows.Forms.Label
        Me.LabelConfirmedDate = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DateTimePickerPaymentDate = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxType = New System.Windows.Forms.ComboBox
        Me.LabelType = New System.Windows.Forms.Label
        Me.LabelPaymentDate = New System.Windows.Forms.Label
        Me.ComboBoxJobNo = New System.Windows.Forms.ComboBox
        Me.LabelJobNo = New System.Windows.Forms.Label
        Me.TextBoxBillNo = New System.Windows.Forms.Label
        Me.LabelBillNo = New System.Windows.Forms.Label
        Me.TextBoxAmountPaid = New System.Windows.Forms.TextBox
        Me.LabelAmountPaid = New System.Windows.Forms.Label
        Me.LabelCustomerID = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBoxSaleType = New System.Windows.Forms.Label
        Me.LabelSaleType = New System.Windows.Forms.Label
        Me.TextBoxTotalAmount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxCustomerID = New System.Windows.Forms.Label
        Me.LabelCustomerName = New System.Windows.Forms.Label
        Me.TextBoxAddress = New System.Windows.Forms.Label
        Me.TextBoxCompanyName = New System.Windows.Forms.Label
        Me.TextBoxCustomerName = New System.Windows.Forms.Label
        Me.LabelAddress = New System.Windows.Forms.Label
        Me.TextBoxUnitPrice = New System.Windows.Forms.Label
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.Groupbuttons.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelInvoiceBill
        '
        Me.LabelInvoiceBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelInvoiceBill.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInvoiceBill.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelInvoiceBill.Location = New System.Drawing.Point(8, 0)
        Me.LabelInvoiceBill.Name = "LabelInvoiceBill"
        Me.LabelInvoiceBill.Size = New System.Drawing.Size(56, 24)
        Me.LabelInvoiceBill.TabIndex = 31
        Me.LabelInvoiceBill.Text = "Bill"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDeliveryDate)
        Me.GroupBox1.Controls.Add(Me.LabelDeliveryDate)
        Me.GroupBox1.Controls.Add(Me.TextBoxConfirmedDate)
        Me.GroupBox1.Controls.Add(Me.LabelConfirmedDate)
        Me.GroupBox1.Controls.Add(Me.Groupbuttons)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPaymentDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxType)
        Me.GroupBox1.Controls.Add(Me.LabelType)
        Me.GroupBox1.Controls.Add(Me.LabelPaymentDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxJobNo)
        Me.GroupBox1.Controls.Add(Me.LabelJobNo)
        Me.GroupBox1.Controls.Add(Me.TextBoxBillNo)
        Me.GroupBox1.Controls.Add(Me.LabelBillNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 256)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill Info:"
        '
        'TextBoxDeliveryDate
        '
        Me.TextBoxDeliveryDate.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxDeliveryDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxDeliveryDate.Location = New System.Drawing.Point(120, 96)
        Me.TextBoxDeliveryDate.Name = "TextBoxDeliveryDate"
        Me.TextBoxDeliveryDate.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxDeliveryDate.TabIndex = 82
        '
        'LabelDeliveryDate
        '
        Me.LabelDeliveryDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeliveryDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelDeliveryDate.Location = New System.Drawing.Point(16, 96)
        Me.LabelDeliveryDate.Name = "LabelDeliveryDate"
        Me.LabelDeliveryDate.Size = New System.Drawing.Size(96, 16)
        Me.LabelDeliveryDate.TabIndex = 81
        Me.LabelDeliveryDate.Text = "Delivery Date"
        Me.LabelDeliveryDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxConfirmedDate
        '
        Me.TextBoxConfirmedDate.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxConfirmedDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxConfirmedDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxConfirmedDate.Location = New System.Drawing.Point(120, 72)
        Me.TextBoxConfirmedDate.Name = "TextBoxConfirmedDate"
        Me.TextBoxConfirmedDate.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxConfirmedDate.TabIndex = 80
        '
        'LabelConfirmedDate
        '
        Me.LabelConfirmedDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConfirmedDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelConfirmedDate.Location = New System.Drawing.Point(16, 72)
        Me.LabelConfirmedDate.Name = "LabelConfirmedDate"
        Me.LabelConfirmedDate.Size = New System.Drawing.Size(96, 16)
        Me.LabelConfirmedDate.TabIndex = 79
        Me.LabelConfirmedDate.Text = "Confirmed Date"
        Me.LabelConfirmedDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(24, 168)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(304, 80)
        Me.Groupbuttons.TabIndex = 74
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
        Me.ButtonSave.Size = New System.Drawing.Size(120, 56)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "&Save and &Print"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(184, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DateTimePickerPaymentDate
        '
        Me.DateTimePickerPaymentDate.Location = New System.Drawing.Point(120, 128)
        Me.DateTimePickerPaymentDate.Name = "DateTimePickerPaymentDate"
        Me.DateTimePickerPaymentDate.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePickerPaymentDate.TabIndex = 72
        '
        'ComboBoxType
        '
        Me.ComboBoxType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxType.Items.AddRange(New Object() {"Cash", "Credit Card", "Cheque", "Transfer by Bank"})
        Me.ComboBoxType.Location = New System.Drawing.Point(120, 152)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(232, 21)
        Me.ComboBoxType.TabIndex = 70
        '
        'LabelType
        '
        Me.LabelType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelType.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelType.Location = New System.Drawing.Point(24, 152)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(88, 16)
        Me.LabelType.TabIndex = 68
        Me.LabelType.Text = "Type"
        Me.LabelType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPaymentDate
        '
        Me.LabelPaymentDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaymentDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPaymentDate.Location = New System.Drawing.Point(24, 128)
        Me.LabelPaymentDate.Name = "LabelPaymentDate"
        Me.LabelPaymentDate.Size = New System.Drawing.Size(88, 16)
        Me.LabelPaymentDate.TabIndex = 67
        Me.LabelPaymentDate.Text = "Payment Date"
        Me.LabelPaymentDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxJobNo
        '
        Me.ComboBoxJobNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxJobNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxJobNo.Location = New System.Drawing.Point(120, 48)
        Me.ComboBoxJobNo.Name = "ComboBoxJobNo"
        Me.ComboBoxJobNo.Size = New System.Drawing.Size(232, 21)
        Me.ComboBoxJobNo.TabIndex = 63
        '
        'LabelJobNo
        '
        Me.LabelJobNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJobNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelJobNo.Location = New System.Drawing.Point(40, 48)
        Me.LabelJobNo.Name = "LabelJobNo"
        Me.LabelJobNo.Size = New System.Drawing.Size(72, 16)
        Me.LabelJobNo.TabIndex = 62
        Me.LabelJobNo.Text = "Job No"
        Me.LabelJobNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxBillNo
        '
        Me.TextBoxBillNo.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxBillNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxBillNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxBillNo.Location = New System.Drawing.Point(120, 24)
        Me.TextBoxBillNo.Name = "TextBoxBillNo"
        Me.TextBoxBillNo.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxBillNo.TabIndex = 61
        '
        'LabelBillNo
        '
        Me.LabelBillNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelBillNo.Location = New System.Drawing.Point(40, 24)
        Me.LabelBillNo.Name = "LabelBillNo"
        Me.LabelBillNo.Size = New System.Drawing.Size(72, 16)
        Me.LabelBillNo.TabIndex = 60
        Me.LabelBillNo.Text = "Bill No"
        Me.LabelBillNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxAmountPaid
        '
        Me.TextBoxAmountPaid.Location = New System.Drawing.Point(120, 200)
        Me.TextBoxAmountPaid.Name = "TextBoxAmountPaid"
        Me.TextBoxAmountPaid.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxAmountPaid.TabIndex = 73
        Me.TextBoxAmountPaid.Text = ""
        '
        'LabelAmountPaid
        '
        Me.LabelAmountPaid.AutoSize = True
        Me.LabelAmountPaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountPaid.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelAmountPaid.Location = New System.Drawing.Point(40, 200)
        Me.LabelAmountPaid.Name = "LabelAmountPaid"
        Me.LabelAmountPaid.Size = New System.Drawing.Size(75, 17)
        Me.LabelAmountPaid.TabIndex = 69
        Me.LabelAmountPaid.Text = "Amount Paid"
        Me.LabelAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.AutoSize = True
        Me.LabelCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerID.Location = New System.Drawing.Point(40, 24)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(74, 17)
        Me.LabelCustomerID.TabIndex = 64
        Me.LabelCustomerID.Text = "Customer ID"
        Me.LabelCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxSaleType)
        Me.GroupBox2.Controls.Add(Me.LabelSaleType)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotalAmount)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxCustomerID)
        Me.GroupBox2.Controls.Add(Me.LabelCustomerName)
        Me.GroupBox2.Controls.Add(Me.TextBoxAddress)
        Me.GroupBox2.Controls.Add(Me.TextBoxCompanyName)
        Me.GroupBox2.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBox2.Controls.Add(Me.LabelAddress)
        Me.GroupBox2.Controls.Add(Me.TextBoxUnitPrice)
        Me.GroupBox2.Controls.Add(Me.LabelCustomerID)
        Me.GroupBox2.Controls.Add(Me.TextBoxAmountPaid)
        Me.GroupBox2.Controls.Add(Me.LabelAmountPaid)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(392, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 256)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jobs info:"
        '
        'TextBoxSaleType
        '
        Me.TextBoxSaleType.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSaleType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxSaleType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxSaleType.Location = New System.Drawing.Point(120, 152)
        Me.TextBoxSaleType.Name = "TextBoxSaleType"
        Me.TextBoxSaleType.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxSaleType.TabIndex = 82
        '
        'LabelSaleType
        '
        Me.LabelSaleType.AutoSize = True
        Me.LabelSaleType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaleType.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSaleType.Location = New System.Drawing.Point(40, 152)
        Me.LabelSaleType.Name = "LabelSaleType"
        Me.LabelSaleType.Size = New System.Drawing.Size(60, 17)
        Me.LabelSaleType.TabIndex = 81
        Me.LabelSaleType.Text = "Sale Type"
        Me.LabelSaleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxTotalAmount
        '
        Me.TextBoxTotalAmount.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxTotalAmount.Location = New System.Drawing.Point(120, 176)
        Me.TextBoxTotalAmount.Name = "TextBoxTotalAmount"
        Me.TextBoxTotalAmount.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxTotalAmount.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(40, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Total Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCustomerID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(120, 24)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxCustomerID.TabIndex = 78
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerName.Location = New System.Drawing.Point(20, 48)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(94, 17)
        Me.LabelCustomerName.TabIndex = 77
        Me.LabelCustomerName.Text = "Customer Name"
        Me.LabelCustomerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxAddress.Location = New System.Drawing.Point(120, 96)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(256, 48)
        Me.TextBoxAddress.TabIndex = 76
        '
        'TextBoxCompanyName
        '
        Me.TextBoxCompanyName.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCompanyName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCompanyName.Location = New System.Drawing.Point(120, 72)
        Me.TextBoxCompanyName.Name = "TextBoxCompanyName"
        Me.TextBoxCompanyName.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxCompanyName.TabIndex = 75
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxCustomerName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(120, 48)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxCustomerName.TabIndex = 74
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelAddress.Location = New System.Drawing.Point(64, 96)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(50, 17)
        Me.LabelAddress.TabIndex = 69
        Me.LabelAddress.Text = "Address"
        Me.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxUnitPrice
        '
        Me.TextBoxUnitPrice.AutoSize = True
        Me.TextBoxUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUnitPrice.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxUnitPrice.Location = New System.Drawing.Point(20, 72)
        Me.TextBoxUnitPrice.Name = "TextBoxUnitPrice"
        Me.TextBoxUnitPrice.Size = New System.Drawing.Size(94, 17)
        Me.TextBoxUnitPrice.TabIndex = 68
        Me.TextBoxUnitPrice.Text = "Company Name"
        Me.TextBoxUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.DataGridData.Location = New System.Drawing.Point(8, 296)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(776, 264)
        Me.DataGridData.TabIndex = 79
        '
        'FormPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.DataGridData)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelInvoiceBill)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.Groupbuttons.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NewData()
        Try
            TextBoxBillNo.Text = GenerateNewID("Payment", "BillNo")
            ComboBoxJobNo.SelectedIndex = -1
            ComboBoxJobNo.SelectedIndex = -1
            TextBoxConfirmedDate.Text = vbNullString
            TextBoxAddress.Text = vbNullString
            TextBoxCompanyName.Text = vbNullString
            TextBoxConfirmedDate.Text = vbNullString
            TextBoxCustomerName.Text = vbNullString
            TextBoxDeliveryDate.Text = vbNullString
            TextBoxSaleType.Text = vbNullString
            TextBoxTotalAmount.Text = vbNullString
            TextBoxUnitPrice.Text = vbNullString
            TextBoxCustomerID.Text = vbNullString
            TextBoxAmountPaid.Text = vbNullString
            ComboBoxType.SelectedIndex = -1
            ComboBoxType.SelectedIndex = -1
            setGridData(DataGridData, "SELECT DesignNo, DesignName, SampleWidth, SampleHeight, Qty,UnitPrice, Amount FROM VIEWJobs WHERE JobNo=0 ORDER BY DesignNo")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
    Private Sub FormPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddtoCombo(ComboBoxJobNo, "Jobs", "JobNo")
            NewData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ComboBoxJobNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxJobNo.SelectedIndexChanged
        Try
            If ComboBoxJobNo.Text.Trim.Length > 0 And ComboBoxJobNo.Text <> "System.Data.DataRowView" Then
                Dim OleDbDataAdapter As New OleDb.OleDbDataAdapter("SELECT DISTINCT ConfirmedDate, DeliveryDate, CustomerID, CustomerName, CompanyName," & _
                "Address, SaleType, TotalAmount FROM VIEWJobs WHERE JobNo =" & Val(ComboBoxJobNo.Text) & "", sqlString)
                Dim DataSetData As New DataSet
                OleDbDataAdapter.Fill(DataSetData, "Table")
                With DataSetData.Tables(0)
                    If .Rows.Count > 0 Then
                        TextBoxConfirmedDate.Text = "" & .Rows(0).Item(0)
                        TextBoxDeliveryDate.Text = "" & .Rows(0).Item(1)
                        TextBoxCustomerID.Text = "" & .Rows(0).Item(2)
                        TextBoxCustomerName.Text = "" & .Rows(0).Item(3)
                        TextBoxCompanyName.Text = "" & .Rows(0).Item(4)
                        TextBoxAddress.Text = "" & .Rows(0).Item(5)
                        TextBoxSaleType.Text = "" & .Rows(0).Item(6)
                        TextBoxTotalAmount.Text = "" & .Rows(0).Item(7)
                    End If
                    setGridData(DataGridData, "SELECT DesignNo, DesignName, SampleWidth, SampleHeight, Qty, UnitPrice, Amount FROM VIEWJobs WHERE JobNo=" & Val(ComboBoxJobNo.Text) & " ORDER BY DesignNo")
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub PrintData()
        Try
            Dim f_report As New FormReportViewer
            Dim rptReport As New CrystalReportPayment
            rptReport.SetDatabaseLogon("sa", "", "(local)", "StuffedToy")
            rptReport.Load()
            f_report.CrystalReportViewer1.ReportSource = rptReport
            f_report.CrystalReportViewer1.SelectionFormula = "{VIEWPayments.BillNo}=" & TextBoxBillNo.Text
            f_report.MyDBase = rptReport.Database
            f_report.RSelect()
            f_report.CrystalReportViewer1.RefreshReport()
            f_report.CrystalReportViewer1.Show()
            f_report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If ComboBoxJobNo.Text.Trim.Length < 0 Then
                MsgBox("Job No must be fill.", MsgBoxStyle.Information, AppTitle)
                ComboBoxJobNo.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerPaymentDate.Value, Now()) Then
                MsgBox("Payment Date must be less then Today Date.", MsgBoxStyle.Information, AppTitle)
                DateTimePickerPaymentDate.Focus()
            ElseIf ComboBoxType.Text.Trim.Length < 0 Then
                MsgBox("You must fill Bill Type", MsgBoxStyle.Information, AppTitle)
                ComboBoxType.Focus()
            ElseIf TextBoxAmountPaid.Text.Trim.Length < 0 Or IsNumeric(TextBoxAmountPaid.Text.Trim) = False And Val(TextBoxAmountPaid.Text) > 0 Then
                MsgBox("You must fill Amount Paid with numeric only.", MsgBoxStyle.Information, AppTitle)
                TextBoxAmountPaid.Focus()
            Else
                SavingData("Insert Into Payment Values(" & TextBoxBillNo.Text & "," & ComboBoxJobNo.Text & "," & TextBoxCustomerID.Text & ",'" & TextBoxDeliveryDate.Text & "','" & SQLDateTime(DateTimePickerPaymentDate.Value, Main.SQLDType.sqlDateOnly, True) & "','" & ComboBoxType.Text & "'," & Val(TextBoxAmountPaid.Text) & ")")
                If MessageBox.Show("Do you want to print this Payment.", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then PrintData()
                NewData()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    
End Class
