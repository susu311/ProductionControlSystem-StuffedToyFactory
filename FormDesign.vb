Imports System.Data.SqlClient
Public Class FormDesign
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
    Friend WithEvents LabelDesignName As System.Windows.Forms.Label
    Friend WithEvents LabelDesignNo As System.Windows.Forms.Label
    Friend WithEvents TextBoxDesignName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDesignNo As System.Windows.Forms.Label
    Friend WithEvents LabelEmployeeID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents Groupbuttons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents DataGridDesignDetail As System.Windows.Forms.DataGrid
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBoxImageSample As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonImage As System.Windows.Forms.Button
    Friend WithEvents PictureBoxDesign As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxWidth As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHeight As System.Windows.Forms.TextBox
    Friend WithEvents LabelHeight As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDesign))
        Me.LabelDesignName = New System.Windows.Forms.Label
        Me.LabelDesignNo = New System.Windows.Forms.Label
        Me.TextBoxDesignName = New System.Windows.Forms.TextBox
        Me.TextBoxDesignNo = New System.Windows.Forms.Label
        Me.LabelEmployeeID = New System.Windows.Forms.Label
        Me.ComboBoxEmployeeID = New System.Windows.Forms.ComboBox
        Me.Groupbuttons = New System.Windows.Forms.GroupBox
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.DataGridDesignDetail = New System.Windows.Forms.DataGrid
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBoxImageSample = New System.Windows.Forms.GroupBox
        Me.TextBoxHeight = New System.Windows.Forms.TextBox
        Me.LabelHeight = New System.Windows.Forms.Label
        Me.TextBoxWidth = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonImage = New System.Windows.Forms.Button
        Me.PictureBoxDesign = New System.Windows.Forms.PictureBox
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Groupbuttons.SuspendLayout()
        CType(Me.DataGridDesignDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxImageSample.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDesignName
        '
        Me.LabelDesignName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesignName.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelDesignName.Location = New System.Drawing.Point(16, 48)
        Me.LabelDesignName.Name = "LabelDesignName"
        Me.LabelDesignName.TabIndex = 41
        Me.LabelDesignName.Text = "Design Name"
        Me.LabelDesignName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelDesignNo
        '
        Me.LabelDesignNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesignNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelDesignNo.Location = New System.Drawing.Point(48, 16)
        Me.LabelDesignNo.Name = "LabelDesignNo"
        Me.LabelDesignNo.Size = New System.Drawing.Size(64, 23)
        Me.LabelDesignNo.TabIndex = 40
        Me.LabelDesignNo.Text = "Design No"
        Me.LabelDesignNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxDesignName
        '
        Me.TextBoxDesignName.AutoSize = False
        Me.TextBoxDesignName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxDesignName.Location = New System.Drawing.Point(128, 48)
        Me.TextBoxDesignName.Name = "TextBoxDesignName"
        Me.TextBoxDesignName.Size = New System.Drawing.Size(256, 24)
        Me.TextBoxDesignName.TabIndex = 43
        Me.TextBoxDesignName.Text = ""
        '
        'TextBoxDesignNo
        '
        Me.TextBoxDesignNo.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDesignNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBoxDesignNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxDesignNo.Location = New System.Drawing.Point(128, 16)
        Me.TextBoxDesignNo.Name = "TextBoxDesignNo"
        Me.TextBoxDesignNo.Size = New System.Drawing.Size(256, 23)
        Me.TextBoxDesignNo.TabIndex = 42
        '
        'LabelEmployeeID
        '
        Me.LabelEmployeeID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployeeID.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelEmployeeID.Location = New System.Drawing.Point(16, 80)
        Me.LabelEmployeeID.Name = "LabelEmployeeID"
        Me.LabelEmployeeID.TabIndex = 46
        Me.LabelEmployeeID.Text = "Employee ID"
        Me.LabelEmployeeID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBoxEmployeeID
        '
        Me.ComboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEmployeeID.DropDownWidth = 450
        Me.ComboBoxEmployeeID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBoxEmployeeID.Location = New System.Drawing.Point(128, 72)
        Me.ComboBoxEmployeeID.Name = "ComboBoxEmployeeID"
        Me.ComboBoxEmployeeID.Size = New System.Drawing.Size(256, 21)
        Me.ComboBoxEmployeeID.TabIndex = 47
        '
        'Groupbuttons
        '
        Me.Groupbuttons.Controls.Add(Me.ButtonSave)
        Me.Groupbuttons.Controls.Add(Me.ButtonClose)
        Me.Groupbuttons.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Groupbuttons.Location = New System.Drawing.Point(32, 136)
        Me.Groupbuttons.Name = "Groupbuttons"
        Me.Groupbuttons.Size = New System.Drawing.Size(360, 88)
        Me.Groupbuttons.TabIndex = 48
        Me.Groupbuttons.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(80, 16)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(64, 64)
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
        Me.ButtonClose.Location = New System.Drawing.Point(208, 16)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(64, 64)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DataGridDesignDetail
        '
        Me.DataGridDesignDetail.BackgroundColor = System.Drawing.Color.White
        Me.DataGridDesignDetail.CaptionBackColor = System.Drawing.Color.DarkBlue
        Me.DataGridDesignDetail.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridDesignDetail.CaptionText = "Design Detail: "
        Me.DataGridDesignDetail.DataMember = ""
        Me.DataGridDesignDetail.GridLineColor = System.Drawing.Color.Black
        Me.DataGridDesignDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDesignDetail.Location = New System.Drawing.Point(8, 232)
        Me.DataGridDesignDetail.Name = "DataGridDesignDetail"
        Me.DataGridDesignDetail.RowHeadersVisible = False
        Me.DataGridDesignDetail.Size = New System.Drawing.Size(776, 328)
        Me.DataGridDesignDetail.TabIndex = 49
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.jpg"
        '
        'GroupBoxImageSample
        '
        Me.GroupBoxImageSample.Controls.Add(Me.TextBoxHeight)
        Me.GroupBoxImageSample.Controls.Add(Me.LabelHeight)
        Me.GroupBoxImageSample.Controls.Add(Me.TextBoxWidth)
        Me.GroupBoxImageSample.Controls.Add(Me.Label1)
        Me.GroupBoxImageSample.Controls.Add(Me.ButtonImage)
        Me.GroupBoxImageSample.Controls.Add(Me.PictureBoxDesign)
        Me.GroupBoxImageSample.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBoxImageSample.Location = New System.Drawing.Point(408, 8)
        Me.GroupBoxImageSample.Name = "GroupBoxImageSample"
        Me.GroupBoxImageSample.Size = New System.Drawing.Size(376, 216)
        Me.GroupBoxImageSample.TabIndex = 52
        Me.GroupBoxImageSample.TabStop = False
        Me.GroupBoxImageSample.Text = "Image Sample"
        '
        'TextBoxHeight
        '
        Me.TextBoxHeight.Location = New System.Drawing.Point(248, 112)
        Me.TextBoxHeight.Name = "TextBoxHeight"
        Me.TextBoxHeight.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxHeight.TabIndex = 57
        Me.TextBoxHeight.Text = ""
        '
        'LabelHeight
        '
        Me.LabelHeight.Location = New System.Drawing.Point(248, 88)
        Me.LabelHeight.Name = "LabelHeight"
        Me.LabelHeight.Size = New System.Drawing.Size(104, 23)
        Me.LabelHeight.TabIndex = 56
        Me.LabelHeight.Text = "Height"
        '
        'TextBoxWidth
        '
        Me.TextBoxWidth.Location = New System.Drawing.Point(248, 48)
        Me.TextBoxWidth.Name = "TextBoxWidth"
        Me.TextBoxWidth.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxWidth.TabIndex = 55
        Me.TextBoxWidth.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(248, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Width"
        '
        'ButtonImage
        '
        Me.ButtonImage.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonImage.ForeColor = System.Drawing.Color.White
        Me.ButtonImage.Image = CType(resources.GetObject("ButtonImage.Image"), System.Drawing.Image)
        Me.ButtonImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonImage.Location = New System.Drawing.Point(256, 152)
        Me.ButtonImage.Name = "ButtonImage"
        Me.ButtonImage.Size = New System.Drawing.Size(88, 40)
        Me.ButtonImage.TabIndex = 53
        Me.ButtonImage.Text = "Get &Image"
        Me.ButtonImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBoxDesign
        '
        Me.PictureBoxDesign.Image = CType(resources.GetObject("PictureBoxDesign.Image"), System.Drawing.Image)
        Me.PictureBoxDesign.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxDesign.Name = "PictureBoxDesign"
        Me.PictureBoxDesign.Size = New System.Drawing.Size(220, 170)
        Me.PictureBoxDesign.TabIndex = 52
        Me.PictureBoxDesign.TabStop = False
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.AutoSize = False
        Me.TextBoxRemark.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxRemark.Location = New System.Drawing.Point(128, 104)
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(256, 24)
        Me.TextBoxRemark.TabIndex = 54
        Me.TextBoxRemark.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(16, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Remark"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FormDesign
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.TextBoxRemark)
        Me.Controls.Add(Me.TextBoxDesignName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxImageSample)
        Me.Controls.Add(Me.Groupbuttons)
        Me.Controls.Add(Me.ComboBoxEmployeeID)
        Me.Controls.Add(Me.LabelEmployeeID)
        Me.Controls.Add(Me.TextBoxDesignNo)
        Me.Controls.Add(Me.LabelDesignName)
        Me.Controls.Add(Me.LabelDesignNo)
        Me.Controls.Add(Me.DataGridDesignDetail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Design Form"
        Me.Groupbuttons.ResumeLayout(False)
        CType(Me.DataGridDesignDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxImageSample.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim DataTableDesignDetail As New DataTable

    Private Sub SetDataGridDesignDetail()
        Try
            Dim dgStyle1 As DataGridTableStyle
            DataTableDesignDetail.Columns.Add("ItemID", Type.GetType("System.String"))
            DataTableDesignDetail.Columns.Add("ItemName", Type.GetType("System.String"))
            DataTableDesignDetail.Columns.Add("ItemWidth", Type.GetType("System.Int64"))
            DataTableDesignDetail.Columns.Add("ItemLength", Type.GetType("System.Int64"))
            DataTableDesignDetail.Columns.Add("ItemQuantity", Type.GetType("System.Int64"))
            DataTableDesignDetail.Columns.Add("Description", Type.GetType("System.String"))
            With DataGridDesignDetail
                .DataSource = DataTableDesignDetail
            End With
            dgStyle1 = New DataGridTableStyle
            With dgStyle1
                .MappingName = DataTableDesignDetail.TableName
                .AlternatingBackColor = System.Drawing.Color.FromArgb(CType(241, Byte), CType(249, Byte), CType(255, Byte))
                .HeaderBackColor = System.Drawing.Color.FromArgb(CType(216, Byte), CType(233, Byte), CType(250, Byte))
                .SelectionBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
                .GridLineColor = System.Drawing.Color.Gainsboro
            End With
            DataGridDesignDetail.TableStyles.Add(dgStyle1)
            Dim colStyle As GridColumnStylesCollection
            colStyle = DataGridDesignDetail.TableStyles(0).GridColumnStyles
            colStyle(0).HeaderText = " Item Code "
            colStyle(0).Width = 45
            colStyle(0).NullText = ""
            colStyle(1).HeaderText = " Item Name "
            colStyle(1).Width = 180
            colStyle(1).NullText = ""
            colStyle(1).ReadOnly = True
            colStyle(2).HeaderText = " Item Width "
            colStyle(2).Width = 90
            colStyle(2).NullText = 0
            colStyle(3).HeaderText = " Item Length "
            colStyle(3).Width = 90
            colStyle(3).NullText = 0
            colStyle(4).HeaderText = " Item Quantity "
            colStyle(4).Width = 99
            colStyle(4).NullText = 0
            colStyle(5).HeaderText = " Description "
            colStyle(5).Width = 360
            colStyle(5).NullText = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            Err.Clear()
        End Try
    End Sub
    Private Sub ButtonImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonImage.Click
        Try
            OpenFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath ' & "\Image"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.ToString.Trim.Length > 0 Then
                Me.PictureBoxDesign.Image = Image.FromFile(OpenFileDialog1.FileName)
                PictureBoxDesign.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub DataGridDesignDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridDesignDetail.CurrentCellChanged
        If DataGridDesignDetail.CurrentRowIndex > 0 Then
            If IsNumeric(DataTableDesignDetail.Rows(DataGridDesignDetail.CurrentCell.RowNumber - 1).Item(0)) = False Then
                MsgBox("Item Code is numeric only", MsgBoxStyle.Information, AppTitle)
            ElseIf DataGridDesignDetail.CurrentCell.ColumnNumber = 0 Then
                FindItem()
                'DataTableDesignDetail.Rows(DataGridDesignDetail.CurrentCell().RowNumber - 1).Item(1) = ""
            End If
        End If
    End Sub

    Private Sub NewData()
        TextBoxDesignNo.Text = GenerateNewID("Designs", "DesignNo")
        TextBoxDesignName.Text = vbNullString
        ComboBoxEmployeeID.SelectedIndex = -1
        TextBoxRemark.Text = vbNullString
        TextBoxWidth.Text = vbNullString
        TextBoxHeight.Text = vbNullString
        DataTableDesignDetail.Clear()
    End Sub

    Private Sub FormDesign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddtoCombo(ComboBoxEmployeeID, "Employees", "convert(nvarchar(8),EmployeeID)+':'+EmployeeName+','+Post", "EmployeeID")
            SetDataGridDesignDetail()
            NewData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub FindItem()
        Try
            If IsNumeric(DataTableDesignDetail.Rows(DataGridDesignDetail.CurrentCell.RowNumber - 1).Item(0)) = False Then
                MsgBox("Item Code is numeric only", MsgBoxStyle.Information, AppTitle)
            ElseIf DataGridDesignDetail.CurrentCell.ColumnNumber = 0 Then
                Dim sql As String = "Select ItemName from Item Where ItemID=" & DataTableDesignDetail.Rows(DataGridDesignDetail.CurrentCell.RowNumber - 1).Item(0)
                Dim ACommand As New OleDb.OleDbDataAdapter(sql, sqlString)
                Dim ADataSet As New DataSet
                ACommand.Fill(ADataSet, "Items")
                If ADataSet.Tables(0).Rows.Count > 0 Then
                    DataTableDesignDetail.Rows(DataGridDesignDetail.CurrentCell.RowNumber - 1).Item(1) = ADataSet.Tables(0).Rows(0).Item(0)
                Else
                    MsgBox(DataTableDesignDetail.Rows(DataGridDesignDetail.CurrentCell.RowNumber - 1).Item(0) & " is not found.", MsgBoxStyle.Information, AppTitle)
                End If
                ADataSet.Dispose()
                ACommand.Dispose()
                ADataSet = Nothing
                ACommand = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxDesignName.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter Design Name.", MsgBoxStyle.Information, AppTitle)
                TextBoxDesignName.Focus()
            ElseIf ComboBoxEmployeeID.Text.Trim.Length <= 0 Then
                MsgBox("You need to choose employee ID.", MsgBoxStyle.Information, AppTitle)
                ComboBoxEmployeeID.Focus()
            ElseIf TextBoxHeight.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the height of design.", MsgBoxStyle.Information, AppTitle)
                TextBoxHeight.Focus()
            ElseIf IsNumeric(TextBoxHeight.Text.Trim) Then
                MsgBox("Only Numbers are allowed for height", MsgBoxStyle.Information, AppTitle)
                TextBoxHeight.Focus()
            ElseIf TextBoxWidth.Text.Trim.Length <= 0 Then
                MsgBox("You need to enter the width of design.", MsgBoxStyle.Information, AppTitle)
                TextBoxWidth.Focus()
            ElseIf IsNumeric(TextBoxWidth.Text.Trim) Then
                MsgBox("Only Numbers are allowed for width", MsgBoxStyle.Information, AppTitle)
                TextBoxHeight.Focus()
            ElseIf DataTableDesignDetail.Rows.Count <= 0 Then
                MsgBox("You need to fill Item Information in the Grid", MsgBoxStyle.Information, AppTitle)
                DataGridDesignDetail.Focus()
            Else
                Dim SamplePicture() As Byte
                Dim PictureDesign As New System.IO.MemoryStream
                PictureBoxDesign.Image.Save(PictureDesign, PictureBoxDesign.Image.RawFormat.Png)
                SamplePicture = PictureDesign.GetBuffer
                Dim db_comm As New SqlConnection("Persist Security info=false; user id=sa; password=; initial catalog=StuffedToy; data source=(local)")
                Dim cmd = New SqlCommand("InsertDesign", db_comm)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.Add(New SqlParameter("@DesignNo", SqlDbType.Int, 4)).Value = TextBoxDesignNo.Text
                    .Parameters.Add(New SqlParameter("@DesignName", SqlDbType.NVarChar, 30)).Value = TextBoxDesignName.Text
                    .Parameters.Add(New SqlParameter("@Image", SqlDbType.Image)).Value = SamplePicture
                    .Parameters.Add(New SqlParameter("@EmployeeID", SqlDbType.Int, 4)).Value = ComboBoxEmployeeID.SelectedValue
                    .Parameters.Add(New SqlParameter("@SampleWidth", SqlDbType.Int, 4)).Value = TextBoxWidth.Text
                    .Parameters.Add(New SqlParameter("@SampleHeight", SqlDbType.Int, 4)).Value = TextBoxHeight.Text
                    .Parameters.Add(New SqlParameter("@Remark", SqlDbType.NVarChar, 50)).Value = TextBoxRemark.Text
                End With
                db_comm.Open()
                Dim Affect = cmd.ExecuteNonQuery()
                Dim i As Int16
                With DataTableDesignDetail
                    For i = 0 To .Rows.Count - 1
                        SavingData("Insert Into DesignDetails Values(" & GenerateNewID("DesignDetails", "DesignDetailID") & "," & TextBoxDesignNo.Text & "," & _
                        .Rows(i).Item(0) & "," & .Rows(i).Item(2) & ", " & .Rows(i).Item(3) & "," & .Rows(i).Item(4) & ",'" & .Rows(i).Item(5) & "')", False)
                    Next
                End With
                MsgBox("Save successfully", MsgBoxStyle.Information, AppTitle)
                NewData()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub
End Class
