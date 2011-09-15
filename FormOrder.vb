Public Class FormOrder
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
    Friend WithEvents LabelDesign As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents LabelOrderDate As System.Windows.Forms.Label
    Friend WithEvents LabelOrderID As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents TextBoxUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOrderID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTotalAmount As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTypeOfSales As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormOrder))
        Me.LabelTotalAmount = New System.Windows.Forms.Label
        Me.LabelUnitPrice = New System.Windows.Forms.Label
        Me.LabelQuantity = New System.Windows.Forms.Label
        Me.LabelDesign = New System.Windows.Forms.Label
        Me.LabelCustomerID = New System.Windows.Forms.Label
        Me.LabelOrderDate = New System.Windows.Forms.Label
        Me.LabelOrderID = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.TextBoxUnitPrice = New System.Windows.Forms.TextBox
        Me.ComboBoxDesignNo = New System.Windows.Forms.ComboBox
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox
        Me.TextBoxOrderID = New System.Windows.Forms.Label
        Me.ComboBoxCustomerID = New System.Windows.Forms.ComboBox
        Me.DateTimePickerOrderDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxTypeOfSales = New System.Windows.Forms.ComboBox
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.ButtonRemove = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBoxTotalAmount = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTotalAmount
        '
        Me.LabelTotalAmount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAmount.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTotalAmount.Location = New System.Drawing.Point(8, 112)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(80, 23)
        Me.LabelTotalAmount.TabIndex = 27
        Me.LabelTotalAmount.Text = "Amount"
        Me.LabelTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelUnitPrice
        '
        Me.LabelUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitPrice.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelUnitPrice.Location = New System.Drawing.Point(8, 80)
        Me.LabelUnitPrice.Name = "LabelUnitPrice"
        Me.LabelUnitPrice.Size = New System.Drawing.Size(80, 23)
        Me.LabelUnitPrice.TabIndex = 26
        Me.LabelUnitPrice.Text = "Unit Price"
        Me.LabelUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelQuantity
        '
        Me.LabelQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuantity.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelQuantity.Location = New System.Drawing.Point(8, 48)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(80, 23)
        Me.LabelQuantity.TabIndex = 25
        Me.LabelQuantity.Text = "Quantity"
        Me.LabelQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelDesign
        '
        Me.LabelDesign.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesign.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelDesign.Location = New System.Drawing.Point(16, 16)
        Me.LabelDesign.Name = "LabelDesign"
        Me.LabelDesign.Size = New System.Drawing.Size(72, 23)
        Me.LabelDesign.TabIndex = 24
        Me.LabelDesign.Text = "Design No"
        Me.LabelDesign.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCustomerID.Location = New System.Drawing.Point(13, 88)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(88, 16)
        Me.LabelCustomerID.TabIndex = 23
        Me.LabelCustomerID.Text = "Customer ID"
        Me.LabelCustomerID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelOrderDate
        '
        Me.LabelOrderDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelOrderDate.Location = New System.Drawing.Point(13, 56)
        Me.LabelOrderDate.Name = "LabelOrderDate"
        Me.LabelOrderDate.Size = New System.Drawing.Size(88, 16)
        Me.LabelOrderDate.TabIndex = 22
        Me.LabelOrderDate.Text = "Order Date"
        Me.LabelOrderDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelOrderID
        '
        Me.LabelOrderID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrderID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelOrderID.Location = New System.Drawing.Point(37, 24)
        Me.LabelOrderID.Name = "LabelOrderID"
        Me.LabelOrderID.Size = New System.Drawing.Size(64, 24)
        Me.LabelOrderID.TabIndex = 21
        Me.LabelOrderID.Text = "Order ID :"
        Me.LabelOrderID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(264, 152)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(208, 80)
        Me.Groupbuttons.TabIndex = 38
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
        Me.ButtonSave.Size = New System.Drawing.Size(64, 56)
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
        Me.ButtonClose.Location = New System.Drawing.Point(112, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(64, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxUnitPrice
        '
        Me.TextBoxUnitPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxUnitPrice.Location = New System.Drawing.Point(104, 80)
        Me.TextBoxUnitPrice.Name = "TextBoxUnitPrice"
        Me.TextBoxUnitPrice.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxUnitPrice.TabIndex = 37
        Me.TextBoxUnitPrice.Text = ""
        '
        'ComboBoxDesignNo
        '
        Me.ComboBoxDesignNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDesignNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxDesignNo.Location = New System.Drawing.Point(104, 16)
        Me.ComboBoxDesignNo.Name = "ComboBoxDesignNo"
        Me.ComboBoxDesignNo.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxDesignNo.TabIndex = 34
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.AutoSize = False
        Me.TextBoxQuantity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxQuantity.Location = New System.Drawing.Point(104, 48)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxQuantity.TabIndex = 31
        Me.TextBoxQuantity.Text = ""
        '
        'TextBoxOrderID
        '
        Me.TextBoxOrderID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxOrderID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxOrderID.Location = New System.Drawing.Point(104, 24)
        Me.TextBoxOrderID.Name = "TextBoxOrderID"
        Me.TextBoxOrderID.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxOrderID.TabIndex = 30
        '
        'ComboBoxCustomerID
        '
        Me.ComboBoxCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCustomerID.DropDownWidth = 500
        Me.ComboBoxCustomerID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxCustomerID.Location = New System.Drawing.Point(104, 80)
        Me.ComboBoxCustomerID.Name = "ComboBoxCustomerID"
        Me.ComboBoxCustomerID.Size = New System.Drawing.Size(232, 21)
        Me.ComboBoxCustomerID.TabIndex = 39
        '
        'DateTimePickerOrderDate
        '
        Me.DateTimePickerOrderDate.Location = New System.Drawing.Point(104, 56)
        Me.DateTimePickerOrderDate.Name = "DateTimePickerOrderDate"
        Me.DateTimePickerOrderDate.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePickerOrderDate.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(13, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Types of Sales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxTypeOfSales
        '
        Me.ComboBoxTypeOfSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTypeOfSales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxTypeOfSales.Items.AddRange(New Object() {"Free On Board", "Cost and Freight", "Cost Insurance Freight"})
        Me.ComboBoxTypeOfSales.Location = New System.Drawing.Point(104, 112)
        Me.ComboBoxTypeOfSales.Name = "ComboBoxTypeOfSales"
        Me.ComboBoxTypeOfSales.Size = New System.Drawing.Size(232, 21)
        Me.ComboBoxTypeOfSales.TabIndex = 42
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Order Detail: "
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(8, 240)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(776, 352)
        Me.DataGridData.TabIndex = 43
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(304, 32)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 32)
        Me.ButtonAdd.TabIndex = 44
        Me.ButtonAdd.Text = "&Add"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.White
        Me.ButtonRemove.Location = New System.Drawing.Point(304, 88)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(75, 32)
        Me.ButtonRemove.TabIndex = 45
        Me.ButtonRemove.Text = "&Remove"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelTotalAmount)
        Me.GroupBox2.Controls.Add(Me.LabelUnitPrice)
        Me.GroupBox2.Controls.Add(Me.TextBoxUnitPrice)
        Me.GroupBox2.Controls.Add(Me.ButtonRemove)
        Me.GroupBox2.Controls.Add(Me.ButtonAdd)
        Me.GroupBox2.Controls.Add(Me.LabelQuantity)
        Me.GroupBox2.Controls.Add(Me.LabelDesign)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDesignNo)
        Me.GroupBox2.Controls.Add(Me.TextBoxQuantity)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotalAmount)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 144)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'TextBoxTotalAmount
        '
        Me.TextBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxTotalAmount.Location = New System.Drawing.Point(104, 112)
        Me.TextBoxTotalAmount.Name = "TextBoxTotalAmount"
        Me.TextBoxTotalAmount.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxTotalAmount.TabIndex = 49
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxOrderID)
        Me.GroupBox3.Controls.Add(Me.ComboBoxCustomerID)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerOrderDate)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ComboBoxTypeOfSales)
        Me.GroupBox3.Controls.Add(Me.LabelOrderDate)
        Me.GroupBox3.Controls.Add(Me.LabelOrderID)
        Me.GroupBox3.Controls.Add(Me.LabelCustomerID)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 144)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        '
        'FormOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 598)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridData)
        Me.Name = "FormOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim DataTableItemDetails As New DataTable

    Private Sub SetDataGridData()
        Try
            Dim dgStyle1 As DataGridTableStyle
            DataTableItemDetails.Columns.Add("Design", Type.GetType("System.String"))
            DataTableItemDetails.Columns.Add("DesignNo", Type.GetType("System.Int64"))
            DataTableItemDetails.Columns.Add("UnitPrice", Type.GetType("System.Int64"))
            DataTableItemDetails.Columns.Add("Quantity", Type.GetType("System.Int64"))
            DataTableItemDetails.Columns.Add("Amount", Type.GetType("System.Int64"))
            With DataGridData
                .DataSource = DataTableItemDetails
            End With
            dgStyle1 = New DataGridTableStyle
            With dgStyle1
                .MappingName = DataTableItemDetails.TableName
                .AlternatingBackColor = System.Drawing.Color.FromArgb(CType(241, Byte), CType(249, Byte), CType(255, Byte))
                .HeaderBackColor = System.Drawing.Color.FromArgb(CType(216, Byte), CType(233, Byte), CType(250, Byte))
                .SelectionBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
                .GridLineColor = System.Drawing.Color.Gainsboro
            End With
            DataGridData.TableStyles.Add(dgStyle1)
            Dim colStyle As GridColumnStylesCollection
            colStyle = DataGridData.TableStyles(0).GridColumnStyles
            colStyle(0).HeaderText = " Design "
            colStyle(0).Width = 180
            colStyle(0).NullText = ""
            colStyle(0).ReadOnly = True
            colStyle(1).HeaderText = " Design No "
            colStyle(1).Width = 0
            colStyle(1).NullText = 0
            colStyle(1).ReadOnly = True
            colStyle(2).HeaderText = " Unit Price "
            colStyle(2).Width = 90
            colStyle(2).NullText = 0
            colStyle(3).HeaderText = " Quantity "
            colStyle(3).Width = 90
            colStyle(3).NullText = 0
            colStyle(3).ReadOnly = True
            colStyle(4).HeaderText = " Amount "
            colStyle(4).Width = 90
            colStyle(4).NullText = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Err.Clear()
        End Try
    End Sub

    Private Sub FormOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxOrderID.Text = GenerateNewID("Orders", "OrderID")
        AddtoCombo(Me.ComboBoxCustomerID, "Customers", "CustomerName + ','+ CompanyName+ ','+ Address", "CustomerID")
        AddtoCombo(ComboBoxDesignNo, "Designs", "convert( nvarchar(10),DesignNo) + ':' + DesignName", "DesignNo")
        SetDataGridData()
        NewData()
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub TextBoxQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxQuantity.TextChanged
        CalcualteAmount()
    End Sub
    Private Sub CalcualteAmount()
        Try
            TextBoxTotalAmount.Text = Val(TextBoxUnitPrice.Text) * Val(TextBoxQuantity.Text)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub TextBoxUnitPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUnitPrice.TextChanged
        CalcualteAmount()
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Try
            If ComboBoxDesignNo.Text.Trim.Length <= 0 Then
                MsgBox("You must first choose Design No", MsgBoxStyle.Information, AppTitle)
                ComboBoxDesignNo.Focus()
            ElseIf TextBoxQuantity.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Quantity", MsgBoxStyle.Information, AppTitle)
                TextBoxQuantity.Focus()
            ElseIf IsNumeric(TextBoxQuantity.Text) = False Then
                MsgBox("You must fill Quantity is number only", MsgBoxStyle.Information, AppTitle)
                TextBoxQuantity.Focus()
            ElseIf TextBoxUnitPrice.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Unit Price", MsgBoxStyle.Information, AppTitle)
                TextBoxUnitPrice.Focus()
            ElseIf IsNumeric(TextBoxUnitPrice.Text) = False Then
                MsgBox("You must fill Unit Price is number only", MsgBoxStyle.Information, AppTitle)
                TextBoxUnitPrice.Focus()
            Else
                Dim i As Int16
                For i = 0 To Val(DataTableItemDetails.Rows.Count) - 1
                    With DataTableItemDetails.Rows(i)
                        If .Item(0).ToString = ComboBoxDesignNo.Text Then
                            If MessageBox.Show(ComboBoxDesignNo.Text & " is already existing. Do you want to Update?", AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
                                .Item(2) = TextBoxQuantity.Text
                                .Item(3) = TextBoxUnitPrice.Text
                                .Item(4) = TextBoxTotalAmount.Text
                            End If
                            Exit Sub
                        End If
                    End With
                Next
                Dim row As DataRow
                row = DataTableItemDetails.NewRow
                row.Item(0) = ComboBoxDesignNo.Text
                row.Item(1) = ComboBoxDesignNo.SelectedValue.ToString
                row.Item(2) = TextBoxQuantity.Text
                row.Item(3) = TextBoxUnitPrice.Text
                row.Item(4) = TextBoxTotalAmount.Text
                DataTableItemDetails.Rows.Add(row)
                ComboBoxDesignNo.SelectedIndex = -1
                TextBoxQuantity.Text = vbNullString
                TextBoxUnitPrice.Text = vbNullString
                TextBoxTotalAmount.Text = vbNullString
                ComboBoxDesignNo.SelectedIndex = -1
                ComboBoxDesignNo.Focus()
                'FormOrder_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        Try
            If DataGridData.CurrentRowIndex >= 0 Then
                If MessageBox.Show("Are you sure to delete your selected row.", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    DataTableItemDetails.Rows.RemoveAt(DataGridData.CurrentRowIndex)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub NewData()
        ComboBoxCustomerID.SelectedIndex = -1
        ComboBoxDesignNo.SelectedIndex = -1
        ComboBoxTypeOfSales.SelectedIndex = -1
        DateTimePickerOrderDate.Value = Now()
        TextBoxQuantity.Text = vbNullString
        TextBoxUnitPrice.Text = vbNullString
        TextBoxTotalAmount.Text = vbNullString
        DataTableItemDetails.Rows.Clear()
        ComboBoxCustomerID.SelectedIndex = -1
        ComboBoxDesignNo.SelectedIndex = -1
        ComboBoxTypeOfSales.SelectedIndex = -1
        TextBoxOrderID.Text = GenerateNewID("Orders", "OrderID")
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxOrderID.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Order ID", MsgBoxStyle.Information, AppTitle)
                'ElseIf DateDiff(DateInterval.Day, DateTimePickerOrderDate.Value, Date.Today()) < 0 Then
            ElseIf ComboBoxCustomerID.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Customer Information.", MsgBoxStyle.Information, AppTitle)
                ComboBoxCustomerID.Focus()
            ElseIf ComboBoxTypeOfSales.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Type of Sales Information.", MsgBoxStyle.Information, AppTitle)
                ComboBoxTypeOfSales.Focus()
            ElseIf DataTableItemDetails.Rows.Count <= 0 Then
                MsgBox("You must fill Order Information.", MsgBoxStyle.Information, AppTitle)
                ComboBoxDesignNo.Focus()
            Else
                SavingData("Insert Into Orders Values(" & TextBoxOrderID.Text & ", '" & DateTimePickerOrderDate.Value & "'," & ComboBoxCustomerID.SelectedValue.ToString & ",'" & ComboBoxTypeOfSales.Text & "')", False)
                Dim i As Int16
                With DataTableItemDetails
                    For i = 0 To .Rows.Count - 1
                        With .Rows(i)
                            SavingData("Insert Into OrderDetail Values(" & GenerateNewID("OrderDetail", "OrderDetailID") & ", " & TextBoxOrderID.Text & "," & .Item(1) & "," & .Item(2) & ", " & .Item(3) & "," & .Item(4) & ")", False)
                        End With
                    Next
                End With
                MsgBox("Order save successfully.", MsgBoxStyle.Information, AppTitle)
                NewData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ComboBoxDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDesignNo.SelectedIndexChanged

    End Sub

    Private Sub DataGridData_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridData.Navigate

    End Sub
End Class
