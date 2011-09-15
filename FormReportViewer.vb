Public Class FormReportViewer
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(840, 664)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FormReportViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 666)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Viewer"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public MyDBase

    Private Sub FormReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormReportViewer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CrystalReportViewer1.Width = Me.Width - 20
        CrystalReportViewer1.Height = Me.Height - 20
    End Sub
    Public Sub RSelect()
        Dim DBConnection As CrystalDecisions.Shared.ConnectionInfo = New CrystalDecisions.Shared.ConnectionInfo
        With DBConnection
            .ServerName = "(local)"
            .DatabaseName = "StuffedToy"
            .UserId = "sa"
            .Password = ""
        End With

        Dim TableInfo As CrystalDecisions.Shared.TableLogOnInfo = New CrystalDecisions.Shared.TableLogOnInfo
        Dim myDatabase As Object = MyDbase
        Dim myTables As Object = myDatabase.Tables()
        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table

        For Each myTable In myTables
            TableInfo = myTable.LogOnInfo
            TableInfo.ConnectionInfo = DBConnection
            myTable.ApplyLogOnInfo(TableInfo)
        Next
    End Sub

    'Public Sub RSelect()
    '    Dim DBConnection = New CrystalDecisions.Shared.ConnectionInfo

    '    With DBConnection
    '        .ServerName = System.Windows.Forms.Application.StartupPath & "\Database.mdb"
    '        .DatabaseName = System.Windows.Forms.Application.StartupPath & "\Database.mdb"
    '        .UserId = "Admin"
    '        .Password = ""
    '    End With

    '    Dim TableInfo = New CrystalDecisions.Shared.TableLogOnInfo
    '    Dim myDatabase = MyDbase
    '    Dim myTables = myDatabase.Tables()
    '    Dim myTable As CrystalDecisions.CrystalReports.Engine.Table

    '    For Each myTable In myTables
    '        TableInfo = myTable.LogOnInfo
    '        TableInfo.ConnectionInfo = DBConnection
    '        myTable.ApplyLogOnInfo(TableInfo)
    '    Next
    'End Sub
End Class
