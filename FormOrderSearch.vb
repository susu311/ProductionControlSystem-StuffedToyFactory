Public Class FormOrderSearch
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
    Friend WithEvents LabelSearchEmployee As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonOrderID As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOrderdate As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxOrderDate As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxOrderID As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridSearchEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBoxDeliverydate As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtondeliverydate As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTypeofSales As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTypeofSales As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents RadioButtonDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxDesignNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormOrderSearch))
        Me.LabelSearchEmployee = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButtonDesignNo = New System.Windows.Forms.RadioButton
        Me.ComboBoxTypeofSales = New System.Windows.Forms.ComboBox
        Me.ComboBoxDeliverydate = New System.Windows.Forms.ComboBox
        Me.RadioButtondeliverydate = New System.Windows.Forms.RadioButton
        Me.RadioButtonTypeofSales = New System.Windows.Forms.RadioButton
        Me.ComboBoxCustomerName = New System.Windows.Forms.ComboBox
        'Me.RadioButtonCustomerName = New System.Windows.Forms.RadioButton
        Me.ComboBoxOrderDate = New System.Windows.Forms.ComboBox
        Me.ComboBoxOrderID = New System.Windows.Forms.ComboBox
        Me.RadioButtonOrderID = New System.Windows.Forms.RadioButton
        Me.RadioButtonOrderdate = New System.Windows.Forms.RadioButton
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridSearchEmployee = New System.Windows.Forms.DataGrid
        Me.TextBoxDesignNo = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSearchEmployee
        '
        Me.LabelSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSearchEmployee.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearchEmployee.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSearchEmployee.Location = New System.Drawing.Point(0, 0)
        Me.LabelSearchEmployee.Name = "LabelSearchEmployee"
        Me.LabelSearchEmployee.Size = New System.Drawing.Size(200, 24)
        Me.LabelSearchEmployee.TabIndex = 23
        Me.LabelSearchEmployee.Text = "Search Orders"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDesignNo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTypeofSales)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDeliverydate)
        Me.GroupBox1.Controls.Add(Me.RadioButtondeliverydate)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTypeofSales)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCustomerName)

        Me.GroupBox1.Controls.Add(Me.ComboBoxOrderDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxOrderID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOrderID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOrderdate)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 136)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDesignNo
        '
        Me.RadioButtonDesignNo.Location = New System.Drawing.Point(32, 48)
        Me.RadioButtonDesignNo.Name = "RadioButtonDesignNo"
        Me.RadioButtonDesignNo.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonDesignNo.TabIndex = 82
        Me.RadioButtonDesignNo.Text = "Design No"
        '
        'ComboBoxTypeofSales
        '
        Me.ComboBoxTypeofSales.Location = New System.Drawing.Point(488, 48)
        Me.ComboBoxTypeofSales.Name = "ComboBoxTypeofSales"
        Me.ComboBoxTypeofSales.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxTypeofSales.TabIndex = 81
        '
        'ComboBoxDeliverydate
        '
        Me.ComboBoxDeliverydate.Location = New System.Drawing.Point(104, 112)
        Me.ComboBoxDeliverydate.Name = "ComboBoxDeliverydate"
        Me.ComboBoxDeliverydate.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxDeliverydate.TabIndex = 80
        Me.ComboBoxDeliverydate.Visible = False
        '
        'RadioButtondeliverydate
        '
        Me.RadioButtondeliverydate.Location = New System.Drawing.Point(16, 112)
        Me.RadioButtondeliverydate.Name = "RadioButtondeliverydate"
        Me.RadioButtondeliverydate.Size = New System.Drawing.Size(96, 16)
        Me.RadioButtondeliverydate.TabIndex = 79
        Me.RadioButtondeliverydate.Text = "Delivery Date"
        Me.RadioButtondeliverydate.Visible = False
        '
        'RadioButtonTypeofSales
        '
        Me.RadioButtonTypeofSales.Location = New System.Drawing.Point(392, 48)
        Me.RadioButtonTypeofSales.Name = "RadioButtonTypeofSales"
        Me.RadioButtonTypeofSales.Size = New System.Drawing.Size(88, 16)
        Me.RadioButtonTypeofSales.TabIndex = 78
        Me.RadioButtonTypeofSales.Text = "Type of Sales"
        Me.RadioButtonTypeofSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxCustomerName
        '
        Me.ComboBoxCustomerName.Location = New System.Drawing.Point(488, 16)
        Me.ComboBoxCustomerName.Name = "ComboBoxCustomerName"
        Me.ComboBoxCustomerName.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxCustomerName.TabIndex = 76
        '
        'RadioButtonCustomerName
        '
        'Me.RadioButtonCustomerName.Location = New System.Drawing.Point(392, 16)
        'Me.RadioButtonCustomerName.Name = "RadioButtonCustomerName"
        'Me.RadioButtonCustomerName.Size = New System.Drawing.Size(104, 16)
        'Me.RadioButtonCustomerName.TabIndex = 75
        'Me.RadioButtonCustomerName.Text = "CustomerName"
        'Me.RadioButtonCustomerName.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ComboBoxOrderDate
        '
        Me.ComboBoxOrderDate.Location = New System.Drawing.Point(104, 80)
        Me.ComboBoxOrderDate.Name = "ComboBoxOrderDate"
        Me.ComboBoxOrderDate.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxOrderDate.TabIndex = 72
        '
        'ComboBoxOrderID
        '
        Me.ComboBoxOrderID.Location = New System.Drawing.Point(104, 16)
        Me.ComboBoxOrderID.Name = "ComboBoxOrderID"
        Me.ComboBoxOrderID.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxOrderID.TabIndex = 71
        '
        'RadioButtonOrderID
        '
        Me.RadioButtonOrderID.Checked = True
        Me.RadioButtonOrderID.Location = New System.Drawing.Point(40, 16)
        Me.RadioButtonOrderID.Name = "RadioButtonOrderID"
        Me.RadioButtonOrderID.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonOrderID.TabIndex = 70
        Me.RadioButtonOrderID.TabStop = True
        Me.RadioButtonOrderID.Text = "OrderID"
        '
        'RadioButtonOrderdate
        '
        Me.RadioButtonOrderdate.Location = New System.Drawing.Point(32, 80)
        Me.RadioButtonOrderdate.Name = "RadioButtonOrderdate"
        Me.RadioButtonOrderdate.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonOrderdate.TabIndex = 69
        Me.RadioButtonOrderdate.Text = "Order Date"
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(488, 72)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(88, 56)
        Me.ButtonPrintPreview.TabIndex = 11
        Me.ButtonPrintPreview.Text = "&PrintPreview"
        Me.ButtonPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(632, 72)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DataGridSearchEmployee
        '
        Me.DataGridSearchEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchEmployee.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.DataMember = ""
        Me.DataGridSearchEmployee.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchEmployee.Location = New System.Drawing.Point(8, 184)
        Me.DataGridSearchEmployee.Name = "DataGridSearchEmployee"
        Me.DataGridSearchEmployee.Size = New System.Drawing.Size(776, 376)
        Me.DataGridSearchEmployee.TabIndex = 70
        '
        'TextBoxDesignNo
        '
        Me.TextBoxDesignNo.Location = New System.Drawing.Point(104, 48)
        Me.TextBoxDesignNo.Name = "TextBoxDesignNo"
        Me.TextBoxDesignNo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxDesignNo.TabIndex = 83
        Me.TextBoxDesignNo.Text = ""
        '
        'FormOrderSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.DataGridSearchEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelSearchEmployee)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormOrderSearch"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
End Class
