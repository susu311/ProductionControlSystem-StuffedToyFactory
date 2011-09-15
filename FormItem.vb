Public Class FormItem
    Inherits System.Windows.Forms.Form
    Dim ItemID As Int16
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
    Friend WithEvents LabelItemname As System.Windows.Forms.Label
    Friend WithEvents LabelItemID As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemName As System.Windows.Forms.TextBox
    Friend WithEvents LabelCategoryID As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridItems As System.Windows.Forms.DataGrid
    Friend WithEvents Labelupdate As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCategoryName As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormItem))
        Me.LabelItemname = New System.Windows.Forms.Label
        Me.LabelItemID = New System.Windows.Forms.Label
        Me.TextBoxItemName = New System.Windows.Forms.TextBox
        Me.LabelCategoryID = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridItems = New System.Windows.Forms.DataGrid
        Me.Labelupdate = New System.Windows.Forms.Label
        Me.ComboBoxCategoryName = New System.Windows.Forms.ComboBox
        Me.TextBoxDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxItemID = New System.Windows.Forms.Label
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelItemname
        '
        Me.LabelItemname.BackColor = System.Drawing.Color.White
        Me.LabelItemname.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItemname.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelItemname.Location = New System.Drawing.Point(24, 48)
        Me.LabelItemname.Name = "LabelItemname"
        Me.LabelItemname.Size = New System.Drawing.Size(72, 16)
        Me.LabelItemname.TabIndex = 23
        Me.LabelItemname.Text = "Item Name"
        Me.LabelItemname.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelItemID
        '
        Me.LabelItemID.BackColor = System.Drawing.Color.White
        Me.LabelItemID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItemID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelItemID.Location = New System.Drawing.Point(24, 16)
        Me.LabelItemID.Name = "LabelItemID"
        Me.LabelItemID.Size = New System.Drawing.Size(72, 16)
        Me.LabelItemID.TabIndex = 22
        Me.LabelItemID.Text = "Item ID"
        Me.LabelItemID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxItemName
        '
        Me.TextBoxItemName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxItemName.Location = New System.Drawing.Point(104, 48)
        Me.TextBoxItemName.Name = "TextBoxItemName"
        Me.TextBoxItemName.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxItemName.TabIndex = 26
        Me.TextBoxItemName.Text = ""
        '
        'LabelCategoryID
        '
        Me.LabelCategoryID.BackColor = System.Drawing.Color.White
        Me.LabelCategoryID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoryID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelCategoryID.Location = New System.Drawing.Point(0, 80)
        Me.LabelCategoryID.Name = "LabelCategoryID"
        Me.LabelCategoryID.Size = New System.Drawing.Size(96, 16)
        Me.LabelCategoryID.TabIndex = 27
        Me.LabelCategoryID.Text = "Category Name"
        Me.LabelCategoryID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(40, 184)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(176, 160)
        Me.Groupbuttons.TabIndex = 31
        Me.Groupbuttons.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(40, 16)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(96, 32)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(40, 72)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(96, 32)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "&Update"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClose.Location = New System.Drawing.Point(40, 120)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(96, 32)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridItems
        '
        Me.DataGridItems.BackgroundColor = System.Drawing.Color.White
        Me.DataGridItems.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridItems.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridItems.CaptionText = "Item Info:"
        Me.DataGridItems.DataMember = ""
        Me.DataGridItems.GridLineColor = System.Drawing.Color.Black
        Me.DataGridItems.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridItems.Location = New System.Drawing.Point(256, 40)
        Me.DataGridItems.Name = "DataGridItems"
        Me.DataGridItems.Size = New System.Drawing.Size(408, 304)
        Me.DataGridItems.TabIndex = 32
        '
        'Labelupdate
        '
        Me.Labelupdate.BackColor = System.Drawing.Color.White
        Me.Labelupdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelupdate.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelupdate.Location = New System.Drawing.Point(264, 8)
        Me.Labelupdate.Name = "Labelupdate"
        Me.Labelupdate.Size = New System.Drawing.Size(376, 32)
        Me.Labelupdate.TabIndex = 33
        Me.Labelupdate.Text = ">> If you want to update the existing  Item data, double click on Grid line."
        '
        'ComboBoxCategoryName
        '
        Me.ComboBoxCategoryName.ForeColor = System.Drawing.Color.DarkBlue
        Me.ComboBoxCategoryName.Location = New System.Drawing.Point(104, 80)
        Me.ComboBoxCategoryName.Name = "ComboBoxCategoryName"
        Me.ComboBoxCategoryName.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxCategoryName.TabIndex = 34
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxDescription.Location = New System.Drawing.Point(104, 120)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDescription.Size = New System.Drawing.Size(144, 48)
        Me.TextBoxDescription.TabIndex = 36
        Me.TextBoxDescription.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(24, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Description :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxItemID
        '
        Me.TextBoxItemID.BackColor = System.Drawing.Color.White
        Me.TextBoxItemID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxItemID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxItemID.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxItemID.Location = New System.Drawing.Point(104, 16)
        Me.TextBoxItemID.Name = "TextBoxItemID"
        Me.TextBoxItemID.Size = New System.Drawing.Size(144, 16)
        Me.TextBoxItemID.TabIndex = 37
        '
        'FormItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 350)
        Me.Controls.Add(Me.TextBoxItemID)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxCategoryName)
        Me.Controls.Add(Me.Labelupdate)
        Me.Controls.Add(Me.DataGridItems)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.LabelCategoryID)
        Me.Controls.Add(Me.TextBoxItemName)
        Me.Controls.Add(Me.LabelItemname)
        Me.Controls.Add(Me.LabelItemID)
        Me.Name = "FormItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Clear()
            TextBoxItemName.Text = ""
            ButtonSave.Text = "&Save"
            ButtonDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
    Private Sub Clear()
        TextBoxItemName.Text = vbNullString
        ComboBoxCategoryName.SelectedIndex = -1
        TextBoxDescription.Text = vbNullString
        ButtonSave.Text = "&Save"
        TextBoxItemID.Text = GenerateNewID("Item", "ItemID")
        AddtoCombo(ComboBoxCategoryName, "Categories", "CategoryName")
        setGridData(DataGridItems, "Select * from Item")
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxItemID.Text.Trim.Length <= 0 Then
                MsgBox("There is no 'Item ID'. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxItemID.Focus()
            ElseIf FindData("Item", "ItemID", "ItemID='" & TextBoxItemID.Text.Trim & "'") > 0 And ButtonSave.Text.Trim = "&Save" Then
                MsgBox("'Item ID' is Duplicate. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxItemID.Focus()
            ElseIf FindData("Item", "ItemID", "ItemID='" & TextBoxItemID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Item ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxItemID.Focus()
            ElseIf TextBoxItemName.Text.Trim.Length <= 0 Then
                MsgBox("'Item Name' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxItemName.Focus()
            Else
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Item Values('" & TextBoxItemID.Text & "','" & TextBoxItemName.Text & "', '" & ComboBoxCategoryName.Text & "','" & IIf(TextBoxDescription.Text.Trim.Length = 0, "-", TextBoxDescription.Text) & "')", True)
                ElseIf ButtonSave.Text = "&Update" Then
                    SavingData("Update Item Set ItemName='" & TextBoxItemName.Text & "',Category='" & ComboBoxCategoryName.Text & "',Description='" & IIf(TextBoxDescription.Text.Trim.Length = 0, "-", TextBoxDescription.Text) & "' Where ItemID='" & TextBoxItemID.Text & "';", False)
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
        Try
            If TextBoxItemID.Text.Trim.Length <= 0 Then
                MsgBox("'There is no ItemID'. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxItemID.Focus()
            ElseIf FindData("Item", "ItemID", "ItemID='" & TextBoxItemID.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Item ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxItemID.Focus()
            Else
                SavingData("Delete from Item Where ItemID='" & TextBoxItemID.Text & "';", False)
                MsgBox("Delete successfully", MsgBoxStyle.Information, AppTitle)
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridItems.DoubleClick
        Try
            Dim DataTableItems As DataTable = DataGridItems.DataSource
            With DataTableItems.Rows(DataGridItems.CurrentCell.RowNumber)
                ItemID = .Item(0)
                TextBoxItemID.Text = ItemID
                TextBoxItemName.Text = .Item(1)
                ComboBoxCategoryName.Text = .Item(2)
                TextBoxDescription.Text = .Item(3)
            End With
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridItems_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridItems.Navigate

    End Sub


End Class
