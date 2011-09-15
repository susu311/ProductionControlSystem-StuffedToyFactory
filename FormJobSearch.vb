Public Class FormJobSearch
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
    Friend WithEvents DataGridSearchEmployee As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxJobNo As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonJobNo As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelSearchJobs As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxTypeofSale As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerdeliverydateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerdelieverydatafrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDesignName As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxCustomerName As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxtypeofsale As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxDeliveryDate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxConfirmedDate As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormJobSearch))
        Me.DataGridSearchEmployee = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePickerdeliverydateto = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerdelieverydatafrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxTypeofSale = New System.Windows.Forms.TextBox
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerfrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxDesignNo = New System.Windows.Forms.TextBox
        Me.ComboBoxJobNo = New System.Windows.Forms.ComboBox
        Me.RadioButtonJobNo = New System.Windows.Forms.RadioButton
        Me.ButtonPrintPreview = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.LabelSearchJobs = New System.Windows.Forms.Label
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RadioButtonDesignNo = New System.Windows.Forms.RadioButton
        Me.RadioButtonDesignName = New System.Windows.Forms.RadioButton
        Me.CheckBoxCustomerName = New System.Windows.Forms.CheckBox
        Me.CheckBoxtypeofsale = New System.Windows.Forms.CheckBox
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox
        Me.CheckBoxDeliveryDate = New System.Windows.Forms.CheckBox
        Me.CheckBoxConfirmedDate = New System.Windows.Forms.CheckBox
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSearchEmployee
        '
        Me.DataGridSearchEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridSearchEmployee.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridSearchEmployee.CaptionText = "Job Info:"
        Me.DataGridSearchEmployee.DataMember = ""
        Me.DataGridSearchEmployee.GridLineColor = System.Drawing.Color.Black
        Me.DataGridSearchEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSearchEmployee.Location = New System.Drawing.Point(16, 216)
        Me.DataGridSearchEmployee.Name = "DataGridSearchEmployee"
        Me.DataGridSearchEmployee.Size = New System.Drawing.Size(776, 312)
        Me.DataGridSearchEmployee.TabIndex = 73
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxConfirmedDate)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDeliveryDate)
        Me.GroupBox1.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBox1.Controls.Add(Me.CheckBoxtypeofsale)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCustomerName)
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDesignName)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdeliverydateto)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdelieverydatafrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxTypeofSale)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerfrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxDesignNo)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDesignNo)
        Me.GroupBox1.Controls.Add(Me.ComboBoxJobNo)
        Me.GroupBox1.Controls.Add(Me.RadioButtonJobNo)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 168)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'DateTimePickerdeliverydateto
        '
        Me.DateTimePickerdeliverydateto.Location = New System.Drawing.Point(672, 16)
        Me.DateTimePickerdeliverydateto.Name = "DateTimePickerdeliverydateto"
        Me.DateTimePickerdeliverydateto.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerdeliverydateto.TabIndex = 98
        '
        'DateTimePickerdelieverydatafrom
        '
        Me.DateTimePickerdelieverydatafrom.Location = New System.Drawing.Point(544, 16)
        Me.DateTimePickerdelieverydatafrom.Name = "DateTimePickerdelieverydatafrom"
        Me.DateTimePickerdelieverydatafrom.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerdelieverydatafrom.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(648, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(512, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "From"
        '
        'TextBoxTypeofSale
        '
        Me.TextBoxTypeofSale.Location = New System.Drawing.Point(512, 80)
        Me.TextBoxTypeofSale.Name = "TextBoxTypeofSale"
        Me.TextBoxTypeofSale.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxTypeofSale.TabIndex = 93
        Me.TextBoxTypeofSale.Text = ""
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(272, 104)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerTo.TabIndex = 87
        '
        'DateTimePickerfrom
        '
        Me.DateTimePickerfrom.Location = New System.Drawing.Point(144, 104)
        Me.DateTimePickerfrom.Name = "DateTimePickerfrom"
        Me.DateTimePickerfrom.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerfrom.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 24)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 24)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "From"
        '
        'TextBoxDesignNo
        '
        Me.TextBoxDesignNo.Location = New System.Drawing.Point(112, 48)
        Me.TextBoxDesignNo.Name = "TextBoxDesignNo"
        Me.TextBoxDesignNo.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxDesignNo.TabIndex = 83
        Me.TextBoxDesignNo.Text = ""
        '
        'ComboBoxJobNo
        '
        Me.ComboBoxJobNo.Location = New System.Drawing.Point(112, 16)
        Me.ComboBoxJobNo.Name = "ComboBoxJobNo"
        Me.ComboBoxJobNo.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxJobNo.TabIndex = 71
        '
        'RadioButtonJobNo
        '
        Me.RadioButtonJobNo.Checked = True
        Me.RadioButtonJobNo.Location = New System.Drawing.Point(8, 16)
        Me.RadioButtonJobNo.Name = "RadioButtonJobNo"
        Me.RadioButtonJobNo.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonJobNo.TabIndex = 70
        Me.RadioButtonJobNo.TabStop = True
        Me.RadioButtonJobNo.Text = "Job No"
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintPreview.Image = CType(resources.GetObject("ButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ButtonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(592, 104)
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
        Me.ButtonClose.Location = New System.Drawing.Point(704, 104)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelSearchJobs
        '
        Me.LabelSearchJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSearchJobs.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearchJobs.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSearchJobs.Location = New System.Drawing.Point(8, 8)
        Me.LabelSearchJobs.Name = "LabelSearchJobs"
        Me.LabelSearchJobs.Size = New System.Drawing.Size(112, 24)
        Me.LabelSearchJobs.TabIndex = 71
        Me.LabelSearchJobs.Text = "Search Jobs"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSearch.Location = New System.Drawing.Point(512, 104)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSearch.TabIndex = 101
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 20)
        Me.TextBox1.TabIndex = 100
        Me.TextBox1.Text = ""
        '
        'RadioButtonDesignNo
        '
        Me.RadioButtonDesignNo.BackColor = System.Drawing.Color.White
        Me.RadioButtonDesignNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.RadioButtonDesignNo.Location = New System.Drawing.Point(8, 48)
        Me.RadioButtonDesignNo.Name = "RadioButtonDesignNo"
        Me.RadioButtonDesignNo.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonDesignNo.TabIndex = 82
        Me.RadioButtonDesignNo.Text = "Design No"
        '
        'RadioButtonDesignName
        '
        Me.RadioButtonDesignName.BackColor = System.Drawing.Color.White
        Me.RadioButtonDesignName.ForeColor = System.Drawing.Color.DarkBlue
        Me.RadioButtonDesignName.Location = New System.Drawing.Point(8, 74)
        Me.RadioButtonDesignName.Name = "RadioButtonDesignName"
        Me.RadioButtonDesignName.Size = New System.Drawing.Size(96, 16)
        Me.RadioButtonDesignName.TabIndex = 99
        Me.RadioButtonDesignName.Text = "Design Name"
        '
        'CheckBoxCustomerName
        '
        Me.CheckBoxCustomerName.Location = New System.Drawing.Point(408, 48)
        Me.CheckBoxCustomerName.Name = "CheckBoxCustomerName"
        Me.CheckBoxCustomerName.Size = New System.Drawing.Size(112, 16)
        Me.CheckBoxCustomerName.TabIndex = 102
        Me.CheckBoxCustomerName.Text = "Customer Name"
        '
        'CheckBoxtypeofsale
        '
        Me.CheckBoxtypeofsale.Location = New System.Drawing.Point(408, 80)
        Me.CheckBoxtypeofsale.Name = "CheckBoxtypeofsale"
        Me.CheckBoxtypeofsale.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxtypeofsale.TabIndex = 103
        Me.CheckBoxtypeofsale.Text = "Type of Sale"
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(512, 48)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(256, 20)
        Me.TextBoxCustomerName.TabIndex = 104
        Me.TextBoxCustomerName.Text = ""
        '
        'CheckBoxDeliveryDate
        '
        Me.CheckBoxDeliveryDate.Location = New System.Drawing.Point(408, 16)
        Me.CheckBoxDeliveryDate.Name = "CheckBoxDeliveryDate"
        Me.CheckBoxDeliveryDate.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxDeliveryDate.TabIndex = 105
        Me.CheckBoxDeliveryDate.Text = "Delivery Date"
        '
        'CheckBoxConfirmedDate
        '
        Me.CheckBoxConfirmedDate.Location = New System.Drawing.Point(8, 104)
        Me.CheckBoxConfirmedDate.Name = "CheckBoxConfirmedDate"
        Me.CheckBoxConfirmedDate.Size = New System.Drawing.Size(104, 16)
        Me.CheckBoxConfirmedDate.TabIndex = 106
        Me.CheckBoxConfirmedDate.Text = "Confirmed Date"
        '
        'FormJobSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 534)
        Me.Controls.Add(Me.DataGridSearchEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelSearchJobs)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "FormJobSearch"
        Me.Text = "FormJobSearch"
        CType(Me.DataGridSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBoxtypeofsale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxtypeofsale.CheckedChanged

    End Sub
End Class
