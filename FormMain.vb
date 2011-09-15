Public Class FormMain
    Inherits System.Windows.Forms.Form
    Dim LogInName As String, EmployeeID As String

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItemFile As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcess As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessDesign As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessOrder As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessJobConfirmation As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItemEntry As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEntryCategory As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEntryItem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEntrySupplier As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEntryPost As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEntryEmployee As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessPurchase As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEntryCustomer As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessCutting As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessSewing As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessStuffing As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearch As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFilePasswordManager As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFileLogOff As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFileLoginChange As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchEmployeeStatus As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessPackaging As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemProcessPayment As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchPurchasing As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchMonthlyOrderReport As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchannuallyorderreport As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchCutting As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchJob As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemItemInfo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchCustomer As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemJobDelivery As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchSewing As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchStuffing As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchPackaging As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSearchByOrder As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemHelpHelp As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormMain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItemFile = New System.Windows.Forms.MenuItem
        Me.MenuItemFileLoginChange = New System.Windows.Forms.MenuItem
        Me.MenuItemFilePasswordManager = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItemFileLogOff = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItemFileExit = New System.Windows.Forms.MenuItem
        Me.MenuItemEntry = New System.Windows.Forms.MenuItem
        Me.MenuItemEntryCategory = New System.Windows.Forms.MenuItem
        Me.MenuItemEntryItem = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItemEntrySupplier = New System.Windows.Forms.MenuItem
        Me.MenuItemEntryCustomer = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItemEntryPost = New System.Windows.Forms.MenuItem
        Me.MenuItemEntryEmployee = New System.Windows.Forms.MenuItem
        Me.MenuItemProcess = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessDesign = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessOrder = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessJobConfirmation = New System.Windows.Forms.MenuItem
        Me.MenuItemJobDelivery = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessPayment = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessPurchase = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessCutting = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessSewing = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessStuffing = New System.Windows.Forms.MenuItem
        Me.MenuItemProcessPackaging = New System.Windows.Forms.MenuItem
        Me.MenuItemSearch = New System.Windows.Forms.MenuItem
        Me.MenuItemItemInfo = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchCustomer = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchEmployeeStatus = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchByOrder = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchJob = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchPurchasing = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchCutting = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchSewing = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchStuffing = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchPackaging = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchMonthlyOrderReport = New System.Windows.Forms.MenuItem
        Me.MenuItemSearchannuallyorderreport = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItemHelpHelp = New System.Windows.Forms.MenuItem
        Me.MenuItemHelpAbout = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.PictureBox14 = New System.Windows.Forms.PictureBox
        Me.PictureBox15 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox16 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.PictureBox17 = New System.Windows.Forms.PictureBox
        Me.PictureBox18 = New System.Windows.Forms.PictureBox
        Me.PictureBox19 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemFile, Me.MenuItemEntry, Me.MenuItemProcess, Me.MenuItemSearch, Me.MenuItem1})
        '
        'MenuItemFile
        '
        Me.MenuItemFile.Index = 0
        Me.MenuItemFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemFileLoginChange, Me.MenuItemFilePasswordManager, Me.MenuItem7, Me.MenuItemFileLogOff, Me.MenuItem8, Me.MenuItemFileExit})
        Me.MenuItemFile.Text = "&File"
        '
        'MenuItemFileLoginChange
        '
        Me.MenuItemFileLoginChange.Index = 0
        Me.MenuItemFileLoginChange.Text = "Login &Change"
        '
        'MenuItemFilePasswordManager
        '
        Me.MenuItemFilePasswordManager.Index = 1
        Me.MenuItemFilePasswordManager.Text = "&Password Manager"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "-"
        '
        'MenuItemFileLogOff
        '
        Me.MenuItemFileLogOff.Index = 3
        Me.MenuItemFileLogOff.Text = "Log &Off"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "-"
        '
        'MenuItemFileExit
        '
        Me.MenuItemFileExit.Index = 5
        Me.MenuItemFileExit.Text = "E&xit"
        '
        'MenuItemEntry
        '
        Me.MenuItemEntry.Index = 1
        Me.MenuItemEntry.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemEntryCategory, Me.MenuItemEntryItem, Me.MenuItem2, Me.MenuItemEntrySupplier, Me.MenuItemEntryCustomer, Me.MenuItem3, Me.MenuItemEntryPost, Me.MenuItemEntryEmployee})
        Me.MenuItemEntry.Text = "E&ntry"
        '
        'MenuItemEntryCategory
        '
        Me.MenuItemEntryCategory.Index = 0
        Me.MenuItemEntryCategory.Text = "&Category"
        '
        'MenuItemEntryItem
        '
        Me.MenuItemEntryItem.Index = 1
        Me.MenuItemEntryItem.Text = "&Item"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "-"
        '
        'MenuItemEntrySupplier
        '
        Me.MenuItemEntrySupplier.Index = 3
        Me.MenuItemEntrySupplier.Text = "&Supplier"
        '
        'MenuItemEntryCustomer
        '
        Me.MenuItemEntryCustomer.Index = 4
        Me.MenuItemEntryCustomer.Text = "&Customer"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Text = "-"
        '
        'MenuItemEntryPost
        '
        Me.MenuItemEntryPost.Index = 6
        Me.MenuItemEntryPost.Text = "P&ost"
        '
        'MenuItemEntryEmployee
        '
        Me.MenuItemEntryEmployee.Index = 7
        Me.MenuItemEntryEmployee.Text = "&Employee"
        '
        'MenuItemProcess
        '
        Me.MenuItemProcess.Index = 2
        Me.MenuItemProcess.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemProcessDesign, Me.MenuItem4, Me.MenuItemProcessOrder, Me.MenuItemProcessJobConfirmation, Me.MenuItemJobDelivery, Me.MenuItemProcessPayment, Me.MenuItem5, Me.MenuItemProcessPurchase, Me.MenuItem6, Me.MenuItemProcessCutting, Me.MenuItemProcessSewing, Me.MenuItemProcessStuffing, Me.MenuItemProcessPackaging})
        Me.MenuItemProcess.Text = "&Process"
        '
        'MenuItemProcessDesign
        '
        Me.MenuItemProcessDesign.Index = 0
        Me.MenuItemProcessDesign.Text = "&Design"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MenuItemProcessOrder
        '
        Me.MenuItemProcessOrder.Index = 2
        Me.MenuItemProcessOrder.Text = "&Order"
        '
        'MenuItemProcessJobConfirmation
        '
        Me.MenuItemProcessJobConfirmation.Index = 3
        Me.MenuItemProcessJobConfirmation.Text = "&Job Confirmation"
        '
        'MenuItemJobDelivery
        '
        Me.MenuItemJobDelivery.Index = 4
        Me.MenuItemJobDelivery.Text = "Job Delivery"
        '
        'MenuItemProcessPayment
        '
        Me.MenuItemProcessPayment.Index = 5
        Me.MenuItemProcessPayment.Text = "Payment"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "-"
        '
        'MenuItemProcessPurchase
        '
        Me.MenuItemProcessPurchase.Index = 7
        Me.MenuItemProcessPurchase.Text = "P&urchase"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 8
        Me.MenuItem6.Text = "-"
        '
        'MenuItemProcessCutting
        '
        Me.MenuItemProcessCutting.Index = 9
        Me.MenuItemProcessCutting.Text = "Cu&tting"
        '
        'MenuItemProcessSewing
        '
        Me.MenuItemProcessSewing.Index = 10
        Me.MenuItemProcessSewing.Text = "Se&wing "
        '
        'MenuItemProcessStuffing
        '
        Me.MenuItemProcessStuffing.Index = 11
        Me.MenuItemProcessStuffing.Text = "Stu&ffing"
        '
        'MenuItemProcessPackaging
        '
        Me.MenuItemProcessPackaging.Index = 12
        Me.MenuItemProcessPackaging.Text = "Packa&ging"
        '
        'MenuItemSearch
        '
        Me.MenuItemSearch.Index = 3
        Me.MenuItemSearch.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemItemInfo, Me.MenuItemSearchCustomer, Me.MenuItemSearchEmployeeStatus, Me.MenuItem11, Me.MenuItemSearchByOrder, Me.MenuItemSearchJob, Me.MenuItemSearchPurchasing, Me.MenuItem10, Me.MenuItemSearchCutting, Me.MenuItemSearchSewing, Me.MenuItemSearchStuffing, Me.MenuItemSearchPackaging, Me.MenuItem9, Me.MenuItemSearchMonthlyOrderReport, Me.MenuItemSearchannuallyorderreport})
        Me.MenuItemSearch.Text = "Se&arch"
        '
        'MenuItemItemInfo
        '
        Me.MenuItemItemInfo.Index = 0
        Me.MenuItemItemInfo.Text = "&Item Info"
        '
        'MenuItemSearchCustomer
        '
        Me.MenuItemSearchCustomer.Index = 1
        Me.MenuItemSearchCustomer.Text = "Customer Info"
        '
        'MenuItemSearchEmployeeStatus
        '
        Me.MenuItemSearchEmployeeStatus.Index = 2
        Me.MenuItemSearchEmployeeStatus.Text = "&Employee Info"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 3
        Me.MenuItem11.Text = "-"
        '
        'MenuItemSearchByOrder
        '
        Me.MenuItemSearchByOrder.Index = 4
        Me.MenuItemSearchByOrder.Text = "By &Order"
        '
        'MenuItemSearchJob
        '
        Me.MenuItemSearchJob.Index = 5
        Me.MenuItemSearchJob.Text = "By Job"
        '
        'MenuItemSearchPurchasing
        '
        Me.MenuItemSearchPurchasing.Index = 6
        Me.MenuItemSearchPurchasing.Text = "By Purchasing"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "-"
        '
        'MenuItemSearchCutting
        '
        Me.MenuItemSearchCutting.Index = 8
        Me.MenuItemSearchCutting.Text = "By Cutting"
        '
        'MenuItemSearchSewing
        '
        Me.MenuItemSearchSewing.Index = 9
        Me.MenuItemSearchSewing.Text = "By Sewing"
        '
        'MenuItemSearchStuffing
        '
        Me.MenuItemSearchStuffing.Index = 10
        Me.MenuItemSearchStuffing.Text = "By Stuffing"
        '
        'MenuItemSearchPackaging
        '
        Me.MenuItemSearchPackaging.Index = 11
        Me.MenuItemSearchPackaging.Text = "By Packaging"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 12
        Me.MenuItem9.Text = "-"
        '
        'MenuItemSearchMonthlyOrderReport
        '
        Me.MenuItemSearchMonthlyOrderReport.Index = 13
        Me.MenuItemSearchMonthlyOrderReport.Text = "Monthly OrderReceipt Report"
        '
        'MenuItemSearchannuallyorderreport
        '
        Me.MenuItemSearchannuallyorderreport.Index = 14
        Me.MenuItemSearchannuallyorderreport.Text = "Annually OrderReceipt Report"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemHelpHelp, Me.MenuItemHelpAbout})
        Me.MenuItem1.Text = "&Help"
        '
        'MenuItemHelpHelp
        '
        Me.MenuItemHelpHelp.Index = 0
        Me.MenuItemHelpHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItemHelpHelp.Text = "Help"
        '
        'MenuItemHelpAbout
        '
        Me.MenuItemHelpAbout.Index = 1
        Me.MenuItemHelpAbout.Shortcut = System.Windows.Forms.Shortcut.CtrlF1
        Me.MenuItemHelpAbout.Text = "&About"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(224, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(880, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Production Control System for Stuffed Toys Manufacturing"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = CType(configurationAppSettings.GetValue("PictureBox1.AccessibleDescription", GetType(System.String)), String)
        Me.PictureBox1.AccessibleName = CType(configurationAppSettings.GetValue("Crystal bear", GetType(System.String)), String)
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 208)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(512, 272)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(216, 168)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(48, 656)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(144, 656)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1080, 656)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(192, 656)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox10.TabIndex = 11
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(864, 656)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox11.TabIndex = 12
        Me.PictureBox11.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(912, 656)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox13.TabIndex = 14
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(960, 656)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox14.TabIndex = 15
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(0, 656)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(56, 40)
        Me.PictureBox15.TabIndex = 16
        Me.PictureBox15.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1056, 656)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 40)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(936, 400)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox16.TabIndex = 18
        Me.PictureBox16.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(288, 656)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(384, 656)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox9.TabIndex = 21
        Me.PictureBox9.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(480, 656)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox12.TabIndex = 22
        Me.PictureBox12.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(576, 656)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox17.TabIndex = 23
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = CType(resources.GetObject("PictureBox18.Image"), System.Drawing.Image)
        Me.PictureBox18.Location = New System.Drawing.Point(672, 656)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox18.TabIndex = 24
        Me.PictureBox18.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), System.Drawing.Image)
        Me.PictureBox19.Location = New System.Drawing.Point(768, 656)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox19.TabIndex = 25
        Me.PictureBox19.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1176, 656)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(104, 40)
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1278, 719)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Menu = Me.MainMenu1
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItemFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileExit.Click
        End
    End Sub

    Private Sub MenuItemProcessOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemProcessOrder.Click
        Try
            Dim obj As New FormOrder
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessDesign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemProcessDesign.Click
        Try
            Dim obj As New FormDesign
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemEntryCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemEntryCategory.Click
        Try
            Dim obj As New FormCategory
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemEntryItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemEntryItem.Click
        Try
            Dim obj As New FormItem
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemEntryPost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemEntryPost.Click
        Try
            Dim obj As New FormPost
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemEntryCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemEntryCustomer.Click
        Try
            Dim obj As New FormCustomer
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemEntrySupplier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemEntrySupplier.Click
        Try
            Dim obj As New FormSupplier
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemEntryEmployee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemEntryEmployee.Click
        Try
            Dim obj As New FormEmployee
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemFilePasswordManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFilePasswordManager.Click
        Try
            Dim obj As New FormPasswordManager
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemFileLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItemFileLoginChange_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemFileLoginChange.Click
        Try
            Dim obj As New FormLoginChange
            obj.LoginName = LogInName
            obj.EmployeeID = EmployeeID
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub


    Private Sub MenuItemProcessPurchase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemProcessPurchase.Click
        Try
            Dim obj As New FormPurchase
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchEmployeeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchEmployeeStatus.Click
        Try
            Dim obj As New FormSearchEmployeeStatus
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessPackaging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemProcessPackaging.Click
        Try
            Dim obj As New FormPackaging
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessJobConfirmation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemProcessJobConfirmation.Click
        Try
            Dim obj As New FormJobConfirmation
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemProcessPayment.Click
        Try
            Dim obj As New FormPayment
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchJob.Click
        Try
            Dim obj As New FormSearchJob
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchPurchasing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchPurchasing.Click
        Try
            Dim obj As New FormSearchPurchase
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessCutting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemProcessCutting.Click
        Try
            Dim obj As New FormCutting
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessSewing_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemProcessSewing.Click
        Try
            Dim obj As New FormSewing
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemProcessStuffing_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemProcessStuffing.Click
        Try
            Dim obj As New FormStuffing
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchannuallyorderreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchannuallyorderreport.Click
        Try
            Dim obj As New FormAnnuallyOrderReport
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchMonthlyOrderReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchMonthlyOrderReport.Click
        Try
            Dim obj As New FormMonthlyOrderReport
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchCutting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchCutting.Click
        Try
            Dim obj As New FormSearchCutting
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemItemInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemItemInfo.Click
        Try
            Dim obj As New FormSearchItem
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchCustomer.Click
        Try
            Dim obj As New FormSearchCustomer
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemJobDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemJobDelivery.Click
        Try
            Dim obj As New FormJobDelivery
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemFileLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFileLogOff.Click
        Try
            Dim UserType As String = ""
            Dim obj As New FormLogin
            obj.ShowDialog()
            UserType = obj.UserType
            EmployeeID = obj.EmployeeID
            LogInName = obj.TextBoxLoginName.Text
            Me.Text = AppTitle & "                  " & obj.TextBoxLoginName.Text & " (" & UserType & ")"
            MenuItemFileLogOff.Text = "Log &Off " & UserType
            MenuItemLogOff_Process(UserType.ToLower)
            obj.Close()
            obj.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchSewing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchSewing.Click
        Try
            Dim obj As New FormSearchSewing
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchStuffing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchStuffing.Click
        Try
            Dim obj As New FormSearchStuffing
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemLogOff_Process(ByVal UserType As String)
        Try
            Me.MenuItemFileLoginChange.Enabled = True
            Me.MenuItemFilePasswordManager.Enabled = True
            Me.MenuItemEntryCategory.Enabled = True
            Me.MenuItemEntryItem.Enabled = True
            Me.MenuItemEntrySupplier.Enabled = True
            Me.MenuItemEntryCustomer.Enabled = True
            Me.MenuItemEntryPost.Enabled = True
            Me.MenuItemEntryEmployee.Enabled = True
            Me.MenuItemProcessDesign.Enabled = True
            Me.MenuItemProcessOrder.Enabled = True
            Me.MenuItemProcessJobConfirmation.Enabled = True
            Me.MenuItemJobDelivery.Enabled = True
            Me.MenuItemProcessPayment.Enabled = True
            Me.MenuItemProcessPurchase.Enabled = True
            Me.MenuItemProcessCutting.Enabled = True
            Me.MenuItemProcessSewing.Enabled = True
            Me.MenuItemProcessStuffing.Enabled = True
            Me.MenuItemProcessPackaging.Enabled = True
            Me.MenuItemItemInfo.Enabled = True
            Me.MenuItemSearchCustomer.Enabled = True
            Me.MenuItemSearchEmployeeStatus.Enabled = True
            Me.MenuItemSearchJob.Enabled = True
            Me.MenuItemSearchByOrder.Enabled = True
            Me.MenuItemSearchPurchasing.Enabled = True
            Me.MenuItemSearchCutting.Enabled = True
            Me.MenuItemSearchSewing.Enabled = True
            Me.MenuItemSearchStuffing.Enabled = True
            Me.MenuItemSearchPackaging.Enabled = True
            Me.MenuItemSearchMonthlyOrderReport.Enabled = True
            Me.MenuItemSearchannuallyorderreport.Enabled = True
            If UserType = "" Then
                Me.MenuItemFileLoginChange.Enabled = False
                Me.MenuItemFilePasswordManager.Enabled = False
                Me.MenuItemEntryCategory.Enabled = False
                Me.MenuItemEntryItem.Enabled = False
                Me.MenuItemEntrySupplier.Enabled = False
                Me.MenuItemEntryCustomer.Enabled = False
                Me.MenuItemEntryPost.Enabled = False
                Me.MenuItemEntryEmployee.Enabled = False
                Me.MenuItemProcessDesign.Enabled = False
                Me.MenuItemProcessOrder.Enabled = False
                Me.MenuItemProcessJobConfirmation.Enabled = False
                Me.MenuItemJobDelivery.Enabled = False
                Me.MenuItemProcessPayment.Enabled = False
                Me.MenuItemProcessPurchase.Enabled = False
                Me.MenuItemProcessCutting.Enabled = False
                Me.MenuItemProcessSewing.Enabled = False
                Me.MenuItemProcessStuffing.Enabled = False
                Me.MenuItemProcessPackaging.Enabled = False
                Me.MenuItemItemInfo.Enabled = False
                Me.MenuItemSearchCustomer.Enabled = False
                Me.MenuItemSearchEmployeeStatus.Enabled = False
                Me.MenuItemSearchJob.Enabled = False
                Me.MenuItemSearchByOrder.Enabled = False
                Me.MenuItemSearchPurchasing.Enabled = False
                Me.MenuItemSearchCutting.Enabled = False
                Me.MenuItemSearchSewing.Enabled = False
                Me.MenuItemSearchStuffing.Enabled = False
                Me.MenuItemSearchPackaging.Enabled = False
                Me.MenuItemSearchMonthlyOrderReport.Enabled = False
                Me.MenuItemSearchannuallyorderreport.Enabled = False
                Me.MenuItemFileLogOff.Text = "Log &in"
            ElseIf UserType = "manager" Then
                Me.MenuItemFileLoginChange.Enabled = True
                Me.MenuItemFilePasswordManager.Enabled = False
                Me.MenuItemEntryCategory.Enabled = True
                Me.MenuItemEntryItem.Enabled = True
                Me.MenuItemEntrySupplier.Enabled = True
                Me.MenuItemEntryCustomer.Enabled = True
                Me.MenuItemEntryPost.Enabled = True
                Me.MenuItemEntryEmployee.Enabled = True
                Me.MenuItemProcessDesign.Enabled = True
                Me.MenuItemProcessOrder.Enabled = True
                Me.MenuItemProcessJobConfirmation.Enabled = True
                Me.MenuItemJobDelivery.Enabled = True
                Me.MenuItemProcessPayment.Enabled = True
                Me.MenuItemProcessPurchase.Enabled = True
                Me.MenuItemProcessCutting.Enabled = True
                Me.MenuItemProcessSewing.Enabled = True
                Me.MenuItemProcessStuffing.Enabled = True
                Me.MenuItemProcessPackaging.Enabled = True
                Me.MenuItemItemInfo.Enabled = True
                Me.MenuItemSearchCustomer.Enabled = True
                Me.MenuItemSearchEmployeeStatus.Enabled = True
                Me.MenuItemSearchJob.Enabled = True
                Me.MenuItemSearchByOrder.Enabled = True
                Me.MenuItemSearchPurchasing.Enabled = True
                Me.MenuItemSearchCutting.Enabled = True
                Me.MenuItemSearchSewing.Enabled = True
                Me.MenuItemSearchStuffing.Enabled = True
                Me.MenuItemSearchPackaging.Enabled = True
                Me.MenuItemSearchMonthlyOrderReport.Enabled = True
                Me.MenuItemSearchannuallyorderreport.Enabled = True
            ElseIf UserType = "staff" Then
                Me.MenuItemFileLoginChange.Enabled = False
                Me.MenuItemFilePasswordManager.Enabled = False
                Me.MenuItemEntryCategory.Enabled = True
                Me.MenuItemEntryItem.Enabled = True
                Me.MenuItemEntrySupplier.Enabled = True
                Me.MenuItemEntryCustomer.Enabled = True
                Me.MenuItemEntryPost.Enabled = True
                Me.MenuItemEntryEmployee.Enabled = True
                Me.MenuItemProcessDesign.Enabled = True
                Me.MenuItemProcessOrder.Enabled = True
                Me.MenuItemProcessJobConfirmation.Enabled = True
                Me.MenuItemJobDelivery.Enabled = True
                Me.MenuItemProcessPayment.Enabled = True
                Me.MenuItemProcessPurchase.Enabled = True
                Me.MenuItemProcessCutting.Enabled = True
                Me.MenuItemProcessSewing.Enabled = True
                Me.MenuItemProcessStuffing.Enabled = True
                Me.MenuItemProcessPackaging.Enabled = True
                Me.MenuItemItemInfo.Enabled = False
                Me.MenuItemSearchCustomer.Enabled = False
                Me.MenuItemSearchEmployeeStatus.Enabled = False
                Me.MenuItemSearchJob.Enabled = False
                Me.MenuItemSearchByOrder.Enabled = False
                Me.MenuItemSearchPurchasing.Enabled = False
                Me.MenuItemSearchCutting.Enabled = False
                Me.MenuItemSearchSewing.Enabled = False
                Me.MenuItemSearchStuffing.Enabled = False
                Me.MenuItemSearchPackaging.Enabled = False
                Me.MenuItemSearchMonthlyOrderReport.Enabled = False
                Me.MenuItemSearchannuallyorderreport.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchPackaging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchPackaging.Click
        Try
            Dim obj As New FormSearchPackaging
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemSearchByOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSearchByOrder.Click
        Try
            Dim obj As New FormSearchOrder
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = AppTitle
            Dim UserType As String
            Dim obj As New FormLogin
            obj.ShowDialog()
            UserType = obj.UserType
            LogInName = obj.TextBoxLoginName.Text
            EmployeeID = obj.EmployeeID
            Me.Text = AppTitle & "                  " & obj.TextBoxLoginName.Text & " (" & UserType & ")"
            MenuItemFileLogOff.Text = "Log &Off " & UserType
            obj.Close()
            obj.Dispose()
            MenuItemLogOff_Process(UserType.ToLower)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemHelpHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemHelpHelp.Click
        Try
            Help.ShowHelp(Me, System.Windows.Forms.Application.StartupPath & "\StuffedToyHelp.chm")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, AppTitle)
        End Try
    End Sub

    Private Sub MenuItemHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemHelpAbout.Click
        Try
            Dim obj As New FormAbout
            obj.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
End Class
