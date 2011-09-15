Public Class FormCategory
    Inherits System.Windows.Forms.Form
    Dim OrgCategory As String
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
    Friend WithEvents TextBoxCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Labelupdate As System.Windows.Forms.Label
    Friend WithEvents DataGridData As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormCategory))
        Me.TextBoxCategoryName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridData = New System.Windows.Forms.DataGrid
        Me.Labelupdate = New System.Windows.Forms.Label
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxCategoryName
        '
        Me.TextBoxCategoryName.Location = New System.Drawing.Point(120, 16)
        Me.TextBoxCategoryName.Name = "TextBoxCategoryName"
        Me.TextBoxCategoryName.Size = New System.Drawing.Size(176, 20)
        Me.TextBoxCategoryName.TabIndex = 7
        Me.TextBoxCategoryName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Category Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridData
        '
        Me.DataGridData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridData.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridData.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridData.CaptionText = "Category Info:"
        Me.DataGridData.DataMember = ""
        Me.DataGridData.GridLineColor = System.Drawing.Color.Black
        Me.DataGridData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridData.Location = New System.Drawing.Point(24, 160)
        Me.DataGridData.Name = "DataGridData"
        Me.DataGridData.ReadOnly = True
        Me.DataGridData.Size = New System.Drawing.Size(272, 160)
        Me.DataGridData.TabIndex = 13
        '
        'Labelupdate
        '
        Me.Labelupdate.BackColor = System.Drawing.Color.White
        Me.Labelupdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelupdate.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelupdate.Location = New System.Drawing.Point(32, 128)
        Me.Labelupdate.Name = "Labelupdate"
        Me.Labelupdate.Size = New System.Drawing.Size(256, 32)
        Me.Labelupdate.TabIndex = 34
        Me.Labelupdate.Text = ">> If you want to update the existing  Category data, double click on Grid line."
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonDelete.Location = New System.Drawing.Point(8, 16)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(56, 56)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(96, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "&Update"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.Location = New System.Drawing.Point(184, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Groupbuttons
        '
        Me.Groupbuttons.BackColor = System.Drawing.Color.White
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(24, 40)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(272, 80)
        Me.Groupbuttons.TabIndex = 23
        Me.Groupbuttons.TabStop = False
        '
        'FormCategory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 326)
        Me.Controls.Add(Me.Labelupdate)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCategoryName)
        Me.Name = "FormCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        CType(Me.DataGridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxCategoryName.Text.Trim.Length <= 0 Then
                MsgBox("'Category Name' is empty. Please enter Category Name", MsgBoxStyle.Information, AppTitle)
                TextBoxCategoryName.Focus()
            ElseIf FindData("Categories", "CategoryName", "CategoryName='" & TextBoxCategoryName.Text.Trim & "'") > 0 And ButtonSave.Text.Trim = "&Save" Then
                MsgBox("'Post Name'is duplicate. Please try again", MsgBoxStyle.Information, AppTitle)
                TextBoxCategoryName.Focus()
            ElseIf FindData("Categories", "CategoryName", "CategoryName ='" & OrgCategory & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Category Name' has not found. Please Enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCategoryName.Focus()
            Else
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Categories Values ('" & TextBoxCategoryName.Text & "')", True)
                    MsgBox("Save successfully", MsgBoxStyle.Information, AppTitle)
                ElseIf ButtonSave.Text = "&Update" Then
                    SavingData("Update Categories Set CategoryName ='" & TextBoxCategoryName.Text & "' Where CategoryName='" & OrgCategory & "';", False)
                    MsgBox("Update successfully", MsgBoxStyle.Information, AppTitle)
                    OrgCategory = vbNullString
                End If

                setGridData(DataGridData, "Select * from Categories")
                TextBoxCategoryName.Text = ""
                ButtonSave.Text = "&Save"
                ButtonDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            If TextBoxCategoryName.Text.Trim.Length <= 0 Then
                MsgBox("'Category Name' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCategoryName.Focus()
            ElseIf FindData("Categories", "CategoryName", "CategoryName ='" & TextBoxCategoryName.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Category ID' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxCategoryName.Focus()
            Else
                SavingData("Delete from Categories Where CategoryName='" & TextBoxCategoryName.Text & "';", False)
                MsgBox("Delete successfully", MsgBoxStyle.Information, AppTitle)
                setGridData(DataGridData, "Select * from Categories")
                TextBoxCategoryName.Text = ""
                ButtonSave.Text = "&Save"
                ButtonDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub FormCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setGridData(DataGridData, "Select * from Categories")
            TextBoxCategoryName.Text = ""
            ButtonSave.Text = "&Save"
            ButtonDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridData.DoubleClick
        Try
            'TextBoxCategoryID.Text = DataGridData.Text()
            Dim DataTableCategory As DataTable = DataGridData.DataSource
            OrgCategory = DataTableCategory.Rows(DataGridData.CurrentCell.RowNumber).Item(0)
            TextBoxCategoryName.Text = OrgCategory
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
End Class
