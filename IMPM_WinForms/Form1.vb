Imports Janus.Windows.GridEX
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataset()


        'set up the gridexs
        SetUpGridEX(Me.VwVitalSignOverviewGridEX)
        SetUpGridEX(TblVitalSignsGridEX)
        SetUpGridEX(TblVitalSignWorkLogGridEX)
        SetUpGridEX(TblVitalSignProtocolsGridEX)
        SetUpGridEX(TblVitalSignTasksGridEX)


        'maximize the form
        Me.WindowState = FormWindowState.Maximized



        Me.WorkLogReportViewer.RefreshReport()
    End Sub

    Private Sub LoadDataset()
        Me.AKRODataSet.Clear()

        Try
            Me.TblVitalSignsTableAdapter.Fill(Me.AKRODataSet.tblVitalSigns)
            Me.TblVitalSignDataManagementSummaryTableAdapter.Fill(Me.AKRODataSet.tblVitalSignDataManagementSummary)
            Me.VwVitalSignOverviewTableAdapter.Fill(Me.AKRODataSet.vwVitalSignOverview)
            Me.TblVitalSignProtocolsTableAdapter.Fill(Me.AKRODataSet.tblVitalSignProtocols)
            Me.TblProtocolRemeasurementsTableAdapter.Fill(Me.AKRODataSet.tblProtocolRemeasurements)
            Me.TblProtocolDeliverablesTableAdapter.Fill(Me.AKRODataSet.tblProtocolDeliverables)
            Me.TblVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.tblVitalSignWorkLog)
            Me.TblVitalSignTasksTableAdapter.Fill(Me.AKRODataSet.tblVitalSignTasks)
            Me.vwVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.vwVitalSignWorkLog)
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Public Sub SetUpGridEX(GridEX As GridEX)
        'set up the gridex
        Dim MyFont As New Font("Sans Serif", 10, FontStyle.Regular)
        Dim MyFormatStyle As New GridEXFormatStyle()
        With MyFormatStyle
            .Font = MyFont
            .TextAlignment = TextAlignment.Near
        End With

        'filter row style
        Dim FilterRowFont As New Font("Sans Serif", 10, FontStyle.Italic)
        Dim FilterRowFormatStyle As New GridEXFormatStyle()
        With FilterRowFormatStyle
            .Font = MyFont
            .TextAlignment = TextAlignment.Near
            .BackColor = Color.LightYellow
        End With

        'sometimes the column widths get blown out
        'For Each Col As GridEXColumn In GridEX.RootTable.Columns
        '    With Col
        '        .Width = 100
        '        .MaxLength = 800
        '        .MaxLines = 100
        '        .WordWrap = True
        '    End With
        'Next

        'set up the gridex
        With GridEX
            .AlternatingColors = True
            .ColumnAutoSizeMode = ColumnAutoSizeMode.DiaplayedCells
            '.ColumnAutoResize = True
            '.FilterRowFormatStyle = FilterRowFormatStyle
            .Font = MyFont
            .RowHeaders = InheritableBoolean.True
            .NewRowPosition = NewRowPosition.BottomRow
            .SelectOnExpand = False
            .SaveSettings = True
        End With


    End Sub

    Private Sub VwVitalSignOverviewGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles VwVitalSignOverviewGridEX.SelectionChanged
        'save the dataset, if it has changes
        SaveDataset()

        Me.VitalSignHeaderLabel.Text = "Vital Sign"
        If Not Me.VwVitalSignOverviewGridEX.CurrentRow Is Nothing Then
            If Not Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("NetworkVSName") Is Nothing Then
                Dim Acronym As String = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("Acronym").Value
                Dim VSName As String = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("NetworkVSName").Value
                Dim VSID As Integer = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("VSID").Value
                Me.VitalSignHeaderLabel.Text = Acronym & " " & VSName

                'filter the worklog report to the current record
                Dim MyReportParameter As New ReportParameter("VSIDReportParameter", VSID)
                Me.WorkLogReportViewer.LocalReport.SetParameters(MyReportParameter)
                Me.WorkLogReportViewer.RefreshReport()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Ends all editing on BindingSources and saves the dataset to the database.
    ''' </summary>
    Private Sub SaveDataset()
        If AKRODataSet.HasChanges = True Then
            If MsgBox("Save changes to database?", MsgBoxStyle.YesNo, "Dataset has changes") = MsgBoxResult.Yes Then
                Try
                    Me.TblVitalSignsBindingSource.EndEdit()
                    Me.TblVitalSignWorkLogBindingSource.EndEdit()
                    Me.TblVitalSignProtocolsBindingSource.EndEdit()
                    Me.TblProtocolDeliverablesBindingSource.EndEdit()
                    Me.TblProtocolRemeasurementsBindingSource.EndEdit()
                    Me.TblVitalSignDataManagementSummaryBindingSource.EndEdit()
                    Me.TblVitalSignTasksBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)
                Catch ex As Exception
                    Me.TblVitalSignsBindingSource.CancelEdit()
                    Me.TblVitalSignWorkLogBindingSource.CancelEdit()
                    Me.TblVitalSignProtocolsBindingSource.CancelEdit()
                    Me.TblProtocolDeliverablesBindingSource.CancelEdit()
                    Me.TblProtocolRemeasurementsBindingSource.CancelEdit()
                    Me.TblVitalSignDataManagementSummaryBindingSource.EndEdit()
                    Me.TblVitalSignTasksBindingSource.EndEdit()
                    MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                End Try
            End If
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveDataset()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        SaveDataset()
    End Sub

    Private Sub TblVitalSignProtocolsGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles TblVitalSignProtocolsGridEX.SelectionChanged
        'set default values
        Dim GridEX As GridEX = Me.TblVitalSignProtocolsGridEX
        Try
            GridEX.Tables("tblVitalSignProtocols").Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.Tables("tblVitalSignProtocols").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            GridEX.Tables("tblVitalSignProtocols").Columns("Version").DefaultValue = 0
            GridEX.Tables("tblProtocolDeliverables").Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.Tables("tblProtocolDeliverables").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            GridEX.Tables("tblVitalSignRemeasurements").Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.Tables("tblVitalSignRemeasurements").Columns("RecordInsertedBy").DefaultValue = My.User.Name
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SaveDataset()
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveDataset()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SaveDataset()
    End Sub

    Private Sub TblVitalSignDataManagementSummaryGridEX_DoubleClick(sender As Object, e As EventArgs) Handles TblVitalSignDataManagementSummaryGridEX.DoubleClick
        Dim GridEX As GridEX = Me.TblVitalSignDataManagementSummaryGridEX
        If GridEX.View = View.TableView Then
            GridEX.View = View.SingleCard
        Else
            GridEX.View = View.TableView
        End If
    End Sub

    Private Sub TblVitalSignWorkLogGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles TblVitalSignWorkLogGridEX.SelectionChanged
        'set default values
        Try
            Me.TblVitalSignWorkLogGridEX.RootTable.Columns("LogDate").DefaultValue = Now
            Me.TblVitalSignWorkLogGridEX.RootTable.Columns("UserName").DefaultValue = My.User.Name
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Changes the GridEX's view from SingleCard to Card to Table
    ''' </summary>
    ''' <param name="GridEX">GridEX</param>
    Private Sub ToggleGridEXView(GridEX As GridEX)
        If GridEX.View = View.SingleCard Then
            GridEX.View = View.CardView
        ElseIf GridEX.View = View.CardView Then
            GridEX.View = View.TableView
        ElseIf GridEX.View = View.TableView Then
            GridEX.View = View.SingleCard
        End If
    End Sub

    Private Sub TblVitalSignWorkLogGridEX_DoubleClick(sender As Object, e As EventArgs) Handles TblVitalSignWorkLogGridEX.DoubleClick
        ToggleGridEXView(TblVitalSignWorkLogGridEX)
    End Sub

    Private Sub TblVitalSignTasksGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles TblVitalSignTasksGridEX.SelectionChanged
        'set default values
        Try
            Dim GridEX As GridEX = Me.TblVitalSignTasksGridEX
            GridEX.RootTable.Columns("DateAssigned").DefaultValue = Now
            GridEX.RootTable.Columns("BeginDate").DefaultValue = Now
            GridEX.RootTable.Columns("DateDue").DefaultValue = Now.AddDays(30)
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub GenerateDeliverablesDirectoriesCreationScriptButton_Click(sender As Object, e As EventArgs) Handles GenerateDeliverablesDirectoriesCreationScriptButton.Click
        Try
            If Not Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID") Is Nothing And Not Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolTitle") Is Nothing Then
                Dim ProtocolID As Integer = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID").Value
                Dim ProtocolTitle As String = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolTitle").Value

                Dim DeliverablesDataView As New DataView(Me.AKRODataSet.Tables("tblProtocolDeliverables"), "ProtocolID=" & ProtocolID, "DeliverableIdentifier", DataViewRowState.CurrentRows)
                Dim Script As String = "REM Script to create deliverable directories for " & vbNewLine
                Script = Script & "REM " & ProtocolTitle & vbNewLine
                For Each Row As DataRowView In DeliverablesDataView
                    Dim Identifier As String = Row.Item("DeliverableIdentifier")
                    Dim Desc As String = Row.Item("Deliverable")
                    Script = Script & "mkdir """ & Identifier & " " & Desc & """" & vbNewLine
                Next
                Dim ScriptForm As New DeliverablesDirectoryGeneratorForm()
                ScriptForm.Script = Script
                ScriptForm.ShowDialog()
            Else
                MsgBox("Select a protocol")
        End If

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        SaveDataset()
        LoadDataset()
    End Sub


    Private Sub OpenProjectReferenceToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenProjectReferenceToolStripButton.Click
        'the gridex contains a column called IRMAProjectReference which is the unique ID of the Project Reference in the IRMA Data Store
        'this sub will get the currently selected row in the GridEX, identify the IRMAProjectReference value
        'and attempt to construct a URL and open it using a process
        Try
            'get the current row of the VS GridEX
            If Not Me.TblVitalSignsGridEX.CurrentRow Is Nothing Then
                Dim CurrentRow As GridEXRow = Me.TblVitalSignsGridEX.CurrentRow
                'loop through the columns and look for the FilesDirectory columns
                For i As Integer = 0 To CurrentRow.Cells.Count - 1
                    If CurrentRow.Cells(i).Column.Key = "IRMAProjectReference" Then
                        'if there is a value
                        If Not IsDBNull(CurrentRow.Cells(i).Value) Then
                            Dim ReferenceCode As String = CurrentRow.Cells(i).Value
                            Dim URL As String = My.Settings.IRMADataStoreURLPrefix & ReferenceCode
                            'try to start it using the default program (probably file explorer)
                            Try
                                Process.Start(URL)
                            Catch ex As Exception
                                MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                            End Try
                        Else
                            MsgBox("Null")
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenProjectDirectoryToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenProjectDirectoryToolStripButton.Click
        'the gridex contains a column called FilesDirectory where the project's files are stored
        'this sub will get the currently selected row in the GridEX, identify the FilesDirectory value
        'and attempt to open the path using a process (file explorer, most likely)
        Try
            'get the current row of the VS GridEX
            If Not Me.TblVitalSignsGridEX.CurrentRow Is Nothing Then
                Dim CurrentRow As GridEXRow = Me.TblVitalSignsGridEX.CurrentRow
                'loop through the columns and look for the FilesDirectory columns
                For i As Integer = 0 To CurrentRow.Cells.Count - 1
                    If CurrentRow.Cells(i).Column.Key = "FilesDirectory" Then
                        'if there is a value
                        If Not IsDBNull(CurrentRow.Cells(i).Value) Then
                            Dim Directory As String = ""
                            Directory = CurrentRow.Cells(i).Value
                            'if the FilesDirectory value is a valid directory
                            If My.Computer.FileSystem.DirectoryExists(Directory) Then
                                'try to start it using the default program (probably file explorer)
                                Try
                                    Process.Start(Directory)
                                Catch ex As Exception
                                    MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                                End Try
                            Else
                                MsgBox("Directory does not exist.")
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenWebProfileToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenWebProfileToolStripButton.Click
        'the gridex contains a column called URLMoreInfo that contains the Vital Sign's URL
        'this sub will get the currently selected Vital Sign row, identify the URLMoreInfo value
        'and attempt construct a URL and pass it to a process
        Try
            'get the current row of the GridEX
            If Not Me.TblVitalSignsGridEX.CurrentRow Is Nothing Then
                Dim CurrentRow As GridEXRow = Me.TblVitalSignsGridEX.CurrentRow
                'loop through the columns and look for the URLMoreInfo column
                For i As Integer = 0 To CurrentRow.Cells.Count - 1
                    'locate the column
                    If CurrentRow.Cells(i).Column.Key = "URLMoreInfo" Then
                        'if there is a value
                        If Not IsDBNull(CurrentRow.Cells(i).Value) Then
                            Dim URLMoreInfo As String = CurrentRow.Cells(i).Value
                            'try to start it using the default program (probably file explorer)
                            Try
                                Process.Start(URLMoreInfo)
                            Catch ex As Exception
                                MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                            End Try
                        Else
                            MsgBox("Null")
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim SettingsForm As New SettingsForm
        SettingsForm.ShowDialog()
    End Sub

    Private Sub OpenDeliverablesScheduleFormToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenDeliverablesScheduleFormToolStripButton.Click
        'get the current ProtocolID so we can filter on the protocol's deliverables
        Dim ProtocolID As Integer = 0
        If Not Me.TblVitalSignProtocolsGridEX.CurrentRow Is Nothing Then
            If Not Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID") Is Nothing Then
                ProtocolID = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID").Value
            End If
        End If

        'create a filtered, sorted dataview
        Dim DSDataView As DataView = Me.AKRODataSet.Tables("tblProtocolDeliverables").DefaultView
        With DSDataView
            .RowFilter = "ProtocolID = " & ProtocolID
            .Sort = "DeliverableIdentifier"
        End With

        'build the form and give it the dataview
        Dim DSForm As New DeliverablesScheduleForm()
        DSForm.DeliverablesScheduleDataView = DSDataView
        DSForm.ShowDialog()
    End Sub
End Class
