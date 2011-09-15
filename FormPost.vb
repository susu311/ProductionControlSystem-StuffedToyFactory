Public Class FormPost
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
    Friend WithEvents Labelupdate As System.Windows.Forms.Label
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents LabelPost As System.Windows.Forms.Label
    Friend WithEvents DataGridPost As System.Windows.Forms.DataGrid
    Friend WithEvents TextBoxPostName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormPost))
        Me.Labelupdate = New System.Windows.Forms.Label
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridPost = New System.Windows.Forms.DataGrid
        Me.LabelPost = New System.Windows.Forms.Label
        Me.TextBoxPostName = New System.Windows.Forms.TextBox
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridPost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelupdate
        '
        Me.Labelupdate.BackColor = System.Drawing.Color.White
        Me.Labelupdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelupdate.ForeColor = System.Drawing.Color.DarkBlue
        Me.Labelupdate.Location = New System.Drawing.Point(8, 136)
        Me.Labelupdate.Name = "Labelupdate"
        Me.Labelupdate.Size = New System.Drawing.Size(304, 32)
        Me.Labelupdate.TabIndex = 40
        Me.Labelupdate.Text = ">> If you want to update the existing  Category data, double click on Grid line."
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonDelete)
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Location = New System.Drawing.Point(24, 48)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(272, 80)
        Me.Groupbuttons.TabIndex = 39
        Me.Groupbuttons.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonDelete.Location = New System.Drawing.Point(16, 16)
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
        Me.ButtonSave.Location = New System.Drawing.Point(104, 16)
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
        Me.ButtonClose.Location = New System.Drawing.Point(192, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 56)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DataGridPost
        '
        Me.DataGridPost.BackgroundColor = System.Drawing.Color.White
        Me.DataGridPost.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridPost.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridPost.DataMember = ""
        Me.DataGridPost.GridLineColor = System.Drawing.Color.Black
        Me.DataGridPost.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridPost.Location = New System.Drawing.Point(8, 168)
        Me.DataGridPost.Name = "DataGridPost"
        Me.DataGridPost.ReadOnly = True
        Me.DataGridPost.Size = New System.Drawing.Size(312, 184)
        Me.DataGridPost.TabIndex = 37
        '
        'LabelPost
        '
        Me.LabelPost.BackColor = System.Drawing.SystemColors.Window
        Me.LabelPost.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPost.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelPost.Location = New System.Drawing.Point(24, 16)
        Me.LabelPost.Name = "LabelPost"
        Me.LabelPost.Size = New System.Drawing.Size(72, 16)
        Me.LabelPost.TabIndex = 36
        Me.LabelPost.Text = "Post Name"
        Me.LabelPost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxPostName
        '
        Me.TextBoxPostName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBoxPostName.Location = New System.Drawing.Point(104, 16)
        Me.TextBoxPostName.Name = "TextBoxPostName"
        Me.TextBoxPostName.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxPostName.TabIndex = 35
        Me.TextBoxPostName.Text = ""
        '
        'FormPost
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(328, 358)
        Me.Controls.Add(Me.Labelupdate)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.DataGridPost)
        Me.Controls.Add(Me.LabelPost)
        Me.Controls.Add(Me.TextBoxPostName)
        Me.Name = "FormPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Post"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridPost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim OrgPost As String

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxPostName.Text.Trim.Length <= 0 Then
                MsgBox("'Post Name' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxPostName.Focus()
            ElseIf FindData("Post", "PostName", "PostName ='" & TextBoxPostName.Text.Trim & "'") > 0 And ButtonSave.Text.Trim = "&Save" Then
                MsgBox("'Post Name' is Duplicate. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxPostName.Focus()
            ElseIf FindData("Post", "PostName", "PostName='" & OrgPost & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Post Name' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxPostName.Focus()
            Else
                If ButtonSave.Text = "&Save" Then
                    SavingData("Insert Into Post Values('" & TextBoxPostName.Text & "')", True)
                    MsgBox("Save successfully", MsgBoxStyle.Information, AppTitle)
                ElseIf ButtonSave.Text = "&Update" Then
                    SavingData("Update Post Set PostName='" & TextBoxPostName.Text & "' Where PostName ='" & OrgPost & "';", False)
                    MsgBox("Update successfully", MsgBoxStyle.Information, AppTitle)
                    OrgPost = vbNullString
                End If
                setGridData(DataGridPost, "Select * from Post")
                TextBoxPostName.Text = ""
                ButtonSave.Text = "&Save"
                ButtonDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            If TextBoxPostName.Text.Trim.Length <= 0 Then
                MsgBox("'Post Name' is empty. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxPostName.Focus()
            ElseIf FindData("Post", "PostName", "PostName ='" & TextBoxPostName.Text.Trim & "'") <= 0 And ButtonSave.Text.Trim = "&Update" Then
                MsgBox("'Post Name' has not found. Please enter", MsgBoxStyle.Information, AppTitle)
                TextBoxPostName.Focus()
            Else
                SavingData("Delete from Post Where PostName ='" & TextBoxPostName.Text & "';", False)
                MsgBox("Delete successfully", MsgBoxStyle.Information, AppTitle)

                setGridData(DataGridPost, "Select * from Post")
                TextBoxPostName.Text = ""
                ButtonSave.Text = "&Save"
                ButtonDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub FormPost_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setGridData(DataGridPost, "Select * from Post")
            TextBoxPostName.Text = ""
            ButtonSave.Text = "&Save"
            ButtonDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridPost_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridPost.DoubleClick
        Try
            TextBoxPostName.Text = DataGridPost.Item(DataGridPost.CurrentRowIndex, 0)
            OrgPost = TextBoxPostName.Text
            ButtonSave.Text = "&Update"
            ButtonDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub DataGridPost_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridPost.Navigate

    End Sub
End Class
