Public Class FormPurchase
    Inherits System.Windows.Forms.Form
    Dim DataTableItemDetails As New DataTable

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
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxSupplierID As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSupplierID As System.Windows.Forms.Label
    Friend WithEvents LabelPurchaseDate As System.Windows.Forms.Label
    Friend WithEvents LabelPurchaseID As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPurchaseID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxItemID As System.Windows.Forms.ComboBox
    Friend WithEvents LabelItemID As System.Windows.Forms.Label
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPurchasePrice As System.Windows.Forms.TextBox
    Friend WithEvents LabelPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents TextBoxPurchaseQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAmount As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormPurchase))
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePickerOrderDate = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxSupplierID = New System.Windows.Forms.ComboBox
        Me.TextBoxPurchaseID = New System.Windows.Forms.Label
        Me.LabelSupplierID = New System.Windows.Forms.Label
        Me.LabelPurchaseDate = New System.Windows.Forms.Label
        Me.LabelPurchaseID = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBoxAmount = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ButtonRemove = New System.Windows.Forms.Button
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.TextBoxDescription = New System.Windows.Forms.TextBox
        Me.TextBoxPurchaseQuantity = New System.Windows.Forms.TextBox
        Me.TextBoxPurchasePrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxItemID = New System.Windows.Forms.ComboBox
        Me.LabelPurchasePrice = New System.Windows.Forms.Label
        Me.LabelItemID = New System.Windows.Forms.Label
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Purchase Detail:"
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderFont = New System.Drawing.Font("Chiller", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(8, 224)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(752, 336)
        Me.DataGridData.TabIndex = 51
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(16, 136)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(312, 80)
        Me.Groupbuttons.TabIndex = 52
        Me.Groupbuttons.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(72, 16)
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
        Me.ButtonClose.Location = New System.Drawing.Point(176, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(64, 56)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePickerOrderDate)
        Me.GroupBox2.Controls.Add(Me.ComboBoxSupplierID)
        Me.GroupBox2.Controls.Add(Me.TextBoxPurchaseID)
        Me.GroupBox2.Controls.Add(Me.LabelSupplierID)
        Me.GroupBox2.Controls.Add(Me.LabelPurchaseDate)
        Me.GroupBox2.Controls.Add(Me.LabelPurchaseID)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 120)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'DateTimePickerOrderDate
        '
        Me.DateTimePickerOrderDate.Location = New System.Drawing.Point(128, 48)
        Me.DateTimePickerOrderDate.Name = "DateTimePickerOrderDate"
        Me.DateTimePickerOrderDate.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePickerOrderDate.TabIndex = 56
        '
        'ComboBoxSupplierID
        '
        Me.ComboBoxSupplierID.DropDownWidth = 630
        Me.ComboBoxSupplierID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxSupplierID.Location = New System.Drawing.Point(128, 80)
        Me.ComboBoxSupplierID.Name = "ComboBoxSupplierID"
        Me.ComboBoxSupplierID.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxSupplierID.TabIndex = 55
        '
        'TextBoxPurchaseID
        '
        Me.TextBoxPurchaseID.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPurchaseID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxPurchaseID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxPurchaseID.Location = New System.Drawing.Point(128, 16)
        Me.TextBoxPurchaseID.Name = "TextBoxPurchaseID"
        Me.TextBoxPurchaseID.Size = New System.Drawing.Size(160, 23)
        Me.TextBoxPurchaseID.TabIndex = 54
        '
        'LabelSupplierID
        '
        Me.LabelSupplierID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupplierID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelSupplierID.Location = New System.Drawing.Point(16, 80)
        Me.LabelSupplierID.Name = "LabelSupplierID"
        Me.LabelSupplierID.TabIndex = 53
        Me.LabelSupplierID.Text = "Supplier ID"
        Me.LabelSupplierID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPurchaseDate
        '
        Me.LabelPurchaseDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPurchaseDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPurchaseDate.Location = New System.Drawing.Point(16, 48)
        Me.LabelPurchaseDate.Name = "LabelPurchaseDate"
        Me.LabelPurchaseDate.TabIndex = 52
        Me.LabelPurchaseDate.Text = "Purchase Date"
        Me.LabelPurchaseDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPurchaseID
        '
        Me.LabelPurchaseID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPurchaseID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPurchaseID.Location = New System.Drawing.Point(8, 16)
        Me.LabelPurchaseID.Name = "LabelPurchaseID"
        Me.LabelPurchaseID.Size = New System.Drawing.Size(104, 23)
        Me.LabelPurchaseID.TabIndex = 51
        Me.LabelPurchaseID.Text = "Purchase ID"
        Me.LabelPurchaseID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ButtonRemove)
        Me.GroupBox3.Controls.Add(Me.ButtonAdd)
        Me.GroupBox3.Controls.Add(Me.TextBoxDescription)
        Me.GroupBox3.Controls.Add(Me.TextBoxPurchaseQuantity)
        Me.GroupBox3.Controls.Add(Me.TextBoxPurchasePrice)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ComboBoxItemID)
        Me.GroupBox3.Controls.Add(Me.LabelPurchasePrice)
        Me.GroupBox3.Controls.Add(Me.LabelItemID)
        Me.GroupBox3.Location = New System.Drawing.Point(344, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 216)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxAmount.Location = New System.Drawing.Point(139, 96)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(160, 23)
        Me.TextBoxAmount.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 23)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Amount"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.White
        Me.ButtonRemove.Location = New System.Drawing.Point(315, 80)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(77, 32)
        Me.ButtonRemove.TabIndex = 64
        Me.ButtonRemove.Text = "&Remove"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(315, 24)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(77, 32)
        Me.ButtonAdd.TabIndex = 63
        Me.ButtonAdd.Text = "&Add"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.AllowDrop = True
        Me.TextBoxDescription.Location = New System.Drawing.Point(139, 128)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(261, 72)
        Me.TextBoxDescription.TabIndex = 62
        Me.TextBoxDescription.Text = ""
        '
        'TextBoxPurchaseQuantity
        '
        Me.TextBoxPurchaseQuantity.Location = New System.Drawing.Point(139, 72)
        Me.TextBoxPurchaseQuantity.Name = "TextBoxPurchaseQuantity"
        Me.TextBoxPurchaseQuantity.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxPurchaseQuantity.TabIndex = 61
        Me.TextBoxPurchaseQuantity.Text = ""
        '
        'TextBoxPurchasePrice
        '
        Me.TextBoxPurchasePrice.Location = New System.Drawing.Point(139, 48)
        Me.TextBoxPurchasePrice.Name = "TextBoxPurchasePrice"
        Me.TextBoxPurchasePrice.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxPurchasePrice.TabIndex = 60
        Me.TextBoxPurchasePrice.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(24, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Description"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Purchase Quantity"
        '
        'ComboBoxItemID
        '
        Me.ComboBoxItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxItemID.DropDownWidth = 300
        Me.ComboBoxItemID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxItemID.Location = New System.Drawing.Point(139, 24)
        Me.ComboBoxItemID.Name = "ComboBoxItemID"
        Me.ComboBoxItemID.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxItemID.TabIndex = 57
        '
        'LabelPurchasePrice
        '
        Me.LabelPurchasePrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPurchasePrice.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPurchasePrice.Location = New System.Drawing.Point(24, 48)
        Me.LabelPurchasePrice.Name = "LabelPurchasePrice"
        Me.LabelPurchasePrice.Size = New System.Drawing.Size(112, 23)
        Me.LabelPurchasePrice.TabIndex = 53
        Me.LabelPurchasePrice.Text = "Purchase Price"
        '
        'LabelItemID
        '
        Me.LabelItemID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItemID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelItemID.Location = New System.Drawing.Point(24, 24)
        Me.LabelItemID.Name = "LabelItemID"
        Me.LabelItemID.Size = New System.Drawing.Size(120, 23)
        Me.LabelItemID.TabIndex = 51
        Me.LabelItemID.Text = "Item"
        '
        'FormPurchase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 566)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridData)
        Me.MaximizeBox = False
        Me.Name = "FormPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase"
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SetDataGridData()
        Try
            Dim dgStyle1 As DataGridTableStyle
            DataTableItemDetails.Columns.Add("Item", Type.GetType("System.String"))
            DataTableItemDetails.Columns.Add("Description", Type.GetType("System.String"))
            DataTableItemDetails.Columns.Add("Purchase Price", Type.GetType("System.Int64"))
            DataTableItemDetails.Columns.Add("Purchase Quantity", Type.GetType("System.Int64"))
            DataTableItemDetails.Columns.Add("Amount", Type.GetType("System.Int64"))
            DataTableItemDetails.Columns.Add("ItemID", Type.GetType("System.Int64"))
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
            colStyle(0).HeaderText = " Item "
            colStyle(0).Width = 180
            colStyle(0).NullText = ""
            colStyle(0).ReadOnly = True
            colStyle(1).HeaderText = " Description "
            colStyle(1).Width = 180
            colStyle(1).NullText = ""
            colStyle(1).ReadOnly = True
            colStyle(2).HeaderText = " Purchase Price "
            colStyle(2).Width = 90
            colStyle(2).NullText = 0
            colStyle(3).HeaderText = " Purchase Quantity "
            colStyle(3).Width = 90
            colStyle(3).NullText = 0
            colStyle(3).ReadOnly = True
            colStyle(4).HeaderText = " Amount "
            colStyle(4).Width = 500
            colStyle(4).NullText = ""
            colStyle(5).HeaderText = " Item ID "
            colStyle(5).Width = 0
            colStyle(5).NullText = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            Err.Clear()
        End Try
    End Sub

    Private Sub FormPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxPurchaseID.Text = GenerateNewID("Purchases", "PurchaseID")
        AddtoCombo(Me.ComboBoxSupplierID, "Suppliers", "SupplierName + ','+ CompanyName+ ','+ Address", "SupplierID")
        AddtoCombo(ComboBoxItemID, "Item", "convert( nvarchar(10),ItemID) + ':' + ItemName", "ItemID")
        SetDataGridData()
        NewData()
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Try
            If ComboBoxItemID.Text.Trim.Length <= 0 Then
                MsgBox("You must first choose Item No", MsgBoxStyle.Information, AppTitle)
                ComboBoxItemID.Focus()
            ElseIf TextBoxPurchasePrice.Text.Trim.Length <= 0 Then
                MsgBox("You must fill purchase price you have purchased", MsgBoxStyle.Information, AppTitle)
                TextBoxPurchasePrice.Focus()
            ElseIf IsNumeric(TextBoxPurchasePrice.Text) = False Then
                MsgBox("You must fill numbers only", MsgBoxStyle.Information, AppTitle)
            ElseIf IsNumeric(TextBoxPurchaseQuantity.Text) = False Then
                MsgBox("You must fill  numbers only", MsgBoxStyle.Information, AppTitle)
                TextBoxPurchaseQuantity.Focus()
            ElseIf TextBoxDescription.Text.Trim.Length <= 0 Then
                MsgBox("You need to write brief description for particular items you have received", MsgBoxStyle.Information, AppTitle)
                TextBoxDescription.Focus()
            Else
                Dim i As Int16
                For i = 0 To Val(DataTableItemDetails.Rows.Count) - 1
                    With DataTableItemDetails.Rows(i)
                        If .Item(0).ToString = ComboBoxItemID.Text Then
                            If MessageBox.Show(ComboBoxItemID.Text & " is already existing. Do you want to Update?", AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
                                .Item(2) = TextBoxPurchasePrice.Text
                                .Item(3) = TextBoxPurchaseQuantity.Text
                                .Item(4) = TextBoxAmount.Text
                            End If
                            Exit Sub
                        End If
                    End With
                Next
                Dim row As DataRow
                row = DataTableItemDetails.NewRow
                row.Item(0) = ComboBoxItemID.Text
                row.Item(5) = ComboBoxItemID.SelectedValue.ToString
                row.Item(1) = TextBoxDescription.Text
                row.Item(2) = TextBoxPurchasePrice.Text
                row.Item(3) = TextBoxPurchaseQuantity.Text
                row.Item(4) = TextBoxAmount.Text
                DataTableItemDetails.Rows.Add(row)
                ComboBoxItemID.SelectedIndex = -1
                TextBoxPurchaseQuantity.Text = vbNullString
                TextBoxPurchasePrice.Text = vbNullString
                TextBoxAmount.Text = vbNullString
                ComboBoxItemID.SelectedIndex = -1
                ComboBoxItemID.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        Try
            If DataGridData.CurrentRowIndex >= 0 Then
                If MessageBox.Show("Are you sure to remove the selected row.", AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    DataTableItemDetails.Rows.RemoveAt(DataGridData.CurrentRowIndex)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub NewData()
        ComboBoxSupplierID.SelectedIndex = -1
        ComboBoxItemID.SelectedIndex = -1
        DataTableItemDetails.Rows.Clear()
        DateTimePickerOrderDate.Value = Now()
        TextBoxPurchasePrice.Text = vbNullString
        TextBoxPurchaseQuantity.Text = vbNullString
        TextBoxDescription.Text = vbNullString
        TextBoxPurchaseID.Text = GenerateNewID("Purchases", "PurchaseID")
        ComboBoxSupplierID.SelectedIndex = -1
        ComboBoxItemID.SelectedIndex = -1
    End Sub
    Private Sub TextBoxPurchaseQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPurchaseQuantity.TextChanged
        Try
            TextBoxAmount.Text = Val(TextBoxPurchaseQuantity.Text) * Val(TextBoxPurchasePrice.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxPurchasePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPurchasePrice.TextChanged
        TextBoxPurchaseQuantity_TextChanged(sender, e)
    End Sub

    Private Sub ComboBoxItemID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxItemID.SelectedIndexChanged
        Try
            If ComboBoxItemID.Text.Trim.Length > 0 And ComboBoxItemID.Text <> "System.Data.DataRowView" Then
                Dim OleDbDataAdapter As New OleDb.OleDbDataAdapter("Select Description From Item where ItemID=" & Val(ComboBoxItemID.SelectedValue.ToString), sqlString)
                Dim DataSetData As New DataSet
                OleDbDataAdapter.Fill(DataSetData, "Item")
                If DataSetData.Tables(0).Rows.Count > 0 Then
                    TextBoxDescription.Text = DataSetData.Tables(0).Rows(0).Item(0)
                Else
                    TextBoxDescription.Text = vbNullString
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxPurchaseID.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Purchase ID", MsgBoxStyle.Information, AppTitle)
                'ElseIf DateDiff(DateInterval.Day, DateTimePickerOrderDate.Value, Date.Today()) < 0 Then
            ElseIf ComboBoxSupplierID.Text.Trim.Length <= 0 Then
                MsgBox("You must fill Supplier Information.", MsgBoxStyle.Information, AppTitle)
                ComboBoxSupplierID.Focus()
            ElseIf DateDiff(DateInterval.Day, DateTimePickerOrderDate.Value, Now()) > 0 Then
                MsgBox("Purchase date is false", MsgBoxStyle.Information, AppTitle)
                DateTimePickerOrderDate.Focus()
            ElseIf DataTableItemDetails.Rows.Count <= 0 Then
                MsgBox("You must fill Purchase Information.", MsgBoxStyle.Information, AppTitle)
                ComboBoxItemID.Focus()
            Else
                SavingData("Insert Into Purchases Values(" & TextBoxPurchaseID.Text & ", '" & SQLDateTime(DateTimePickerOrderDate.Value, Main.SQLDType.sqlDateOnly, True) & "'," & ComboBoxSupplierID.SelectedValue.ToString & ")", False)
                Dim i As Int16
                With DataTableItemDetails
                    For i = 0 To .Rows.Count - 1
                        With .Rows(i)
                            SavingData("Insert Into PurchaseDetail Values(" & GenerateNewID("PurchaseDetail", "PurchaseDetailID") & ", " & TextBoxPurchaseID.Text & "," & .Item(5) & "," & .Item(2) & ", " & .Item(3) & "," & .Item(4) & ")", False)
                        End With
                    Next
                End With
                MsgBox("Purchasing Data are saved successfully.", MsgBoxStyle.Information, AppTitle)
                NewData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
End Class
