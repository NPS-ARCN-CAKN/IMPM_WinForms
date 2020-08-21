Imports Janus.Windows.GridEX
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'load the dataset
        LoadDataset()


        'set up the gridexs
        SetUpGridEX(Me.VwVitalSignOverviewGridEX)
        SetUpGridEX(TblVitalSignsGridEX)
        SetUpGridEX(TblVitalSignWorkLogGridEX)
        'Me.TblVitalSignWorkLogGridEX.NewRowPosition = NewRowPosition.TopRow
        SetUpGridEX(TblVitalSignProtocolsGridEX)
        SetUpGridEX(TblVitalSignTasksGridEX)
        SetUpGridEX(TblVitalSignDataManagementSummaryGridEX)
        SetUpGridEX(TblProtocolDeliverablesGridEX)
        SetUpGridEX(TblProtocolRemeasurementsGridEX)
        SetUpGridEX(ProtocolDeliverablesCardViewGridEX)

        'maximize the form
        Me.WindowState = FormWindowState.Maximized

        'set up static dropdowns
        With Me.TblVitalSignProtocolsGridEX.Tables("tblProtocolDeliverables").Columns("Responsibility")
            .AutoComplete = True
            .HasValueList = True
            .LimitToList = False
        End With
        Dim List As GridEXValueListItemCollection = Me.TblVitalSignProtocolsGridEX.Tables("tblProtocolDeliverables").Columns("Responsibility").ValueList
        List.Clear()
        List.Add("PI", "PI")
        List.Add("DM", "DM")
        List.Add("PI,DM", "PI,DM")


        'set default values
        SetVitalSignTasksGridEXDefaultValues()
        SetVitalSignWorkLogGridEXDefaultValues()
        SetVitalSignProtocolsGridEXDefaultValues()
        SetProtocolDeliverablesGridEXDefaultValues()
        SetProtocolRemeasurementsGridexDefaultValues()

        'load the tasks GridEX contacts dropdown
        Try
            Me.TblVitalSignTasksGridEX.DropDowns("ContactsDropDown").SetDataBinding(AKRODataSet, "vwContactsLookup")
            Me.TblVitalSignsGridEX.DropDowns("ContactsDropDown").SetDataBinding(AKRODataSet, "vwContactsLookup")
            Me.VwVitalSignOverviewGridEX.DropDowns("ContactsDropDown").SetDataBinding(AKRODataSet, "vwContactsLookup")
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        'refresh the work log report
        'Me.WorkLogReportViewer.RefreshReport()
    End Sub



    Private Sub LoadDataset()
        Try
            Me.AKRODataSet.Clear()

            Me.TblVitalSignsTableAdapter.Fill(Me.AKRODataSet.tblVitalSigns)
            Me.VwVitalSignOverviewTableAdapter.Fill(Me.AKRODataSet.vwVitalSignOverview)
            Me.TblContactsTableAdapter.Fill(Me.AKRODataSet.tblContacts)
            Me.VwContactsLookupTableAdapter.Fill(Me.AKRODataSet.vwContactsLookup)
            Me.TblVitalSignObjectivesTableAdapter.Fill(Me.AKRODataSet.tblVitalSignObjectives)
            Me.TblVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.tblVitalSignWorkLog)
            Me.TblVitalSignTasksTableAdapter.Fill(Me.AKRODataSet.tblVitalSignTasks)
            Me.TblVitalSignDataManagementSummaryTableAdapter.Fill(Me.AKRODataSet.tblVitalSignDataManagementSummary)
            Me.TblVitalSignProtocolsTableAdapter.Fill(Me.AKRODataSet.tblVitalSignProtocols)
            Me.TblProtocolRemeasurementsTableAdapter.Fill(Me.AKRODataSet.tblProtocolRemeasurements)
            Me.TblProtocolDeliverablesTableAdapter.Fill(Me.AKRODataSet.tblProtocolDeliverables)
            'this table adapter load is causing constraint errors and I can't figure out wwy
            'Me.vwVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.vwVitalSignWorkLog)
            Me.DataManagementMilestonesTableAdapter.Fill(Me.AKRODataSet.DataManagementMilestones)



            'load gridex dropdowns with values
            LoadDropDowns()

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadDropDowns()
        Try
            'load the vital sign status dropdown
            With Me.TblVitalSignsGridEX.RootTable.Columns("Status")
                .AutoSize()
                .AllowSort = True
                .AutoComplete = True
                .Caption = "Status"
                .HasValueList = True
                .LimitToList = True
            End With
            Dim List As GridEXValueListItemCollection = Me.TblVitalSignsGridEX.RootTable.Columns("Status").ValueList
            List.Clear()
            List.Add("Deferred", "Deferred")
            List.Add("In development", "In development")
            List.Add("Monitoring", "Monitoring")

            'load the project leader column dropdown
            With Me.TblVitalSignsGridEX.RootTable.Columns("ProjectLeadContactID")
                .AutoSize()
                .AllowSort = True
                .AutoComplete = True
                .Caption = "Project leader"
                .HasValueList = True
                .LimitToList = True
            End With
            List = Me.TblVitalSignsGridEX.RootTable.Columns("ProjectLeadContactID").ValueList
            List.Clear()
            Dim ContactsDataView As DataView = Me.AKRODataSet.tblContacts.DefaultView
            ContactsDataView.Sort = "Lastname,Firstname"
            For Each Row As DataRowView In ContactsDataView
                Dim ContactName As String = Row.Item("Lastname").ToString.Trim & ", " & Row.Item("Firstname")
                Dim ContactID As Integer = Row.Item("ContactID")
                List.Add(ContactID, ContactName)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub



    Private Sub VwVitalSignOverviewGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles VwVitalSignOverviewGridEX.SelectionChanged
        'save the dataset, if it has changes
        SaveDataset()

        'change the vital sign header text to match the current vs
        Me.VitalSignHeaderLabel.Text = "Vital Sign"
        If Not Me.VwVitalSignOverviewGridEX.CurrentRow Is Nothing Then
            If Not Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("NetworkVSName") Is Nothing Then
                Dim Acronym As String = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("Acronym").Value
                Dim VSName As String = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("NetworkVSName").Value
                Dim VSID As Integer = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("VSID").Value
                Dim ProjectIRMAReferenceCode As Integer
                If Not Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("IRMAProjectReference") Is Nothing Then
                    If Not IsDBNull(Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("IRMAProjectReference").Value) Then
                        ProjectIRMAReferenceCode = Me.VwVitalSignOverviewGridEX.CurrentRow.Cells("IRMAProjectReference").Value
                    End If
                End If
                Me.VitalSignHeaderLabel.Text = Acronym & " " & VSName

                'filter the worklog report to the current record
                'Dim MyReportParameter As New ReportParameter("VSIDReportParameter", VSID)
                'Me.WorkLogReportViewer.LocalReport.SetParameters(MyReportParameter)
                'Me.WorkLogReportViewer.RefreshReport()

                'set up the protocol remeasurement gridex's project column's default value to match the project
                If Not IsDBNull(ProjectIRMAReferenceCode) Then
                    With Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignRemeasurements").Columns("ProjectIRMAReferenceCode")
                        .AllowSort = True
                        .AutoComplete = True
                        .HasValueList = True
                        .LimitToList = False
                    End With
                    Dim List As GridEXValueListItemCollection = Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignRemeasurements").Columns("ProjectIRMAReferenceCode").ValueList
                        List.Clear()
                        List.Add(ProjectIRMAReferenceCode, ProjectIRMAReferenceCode)
                    End If

                End If
            End If
    End Sub




    ''' <summary>
    ''' Ends all editing on BindingSources and saves the dataset to the database.
    ''' </summary>
    Private Sub SaveDataset()
        If AKRODataSet.HasChanges = True Then
            Try
                Me.TblVitalSignsBindingSource.EndEdit()
                Me.TblVitalSignWorkLogBindingSource.EndEdit()
                Me.TblVitalSignProtocolsBindingSource.EndEdit()
                Me.TblProtocolDeliverablesBindingSource.EndEdit()
                Me.TblProtocolRemeasurementsBindingSource.EndEdit()
                Me.TblVitalSignDataManagementSummaryBindingSource.EndEdit()
                Me.TblVitalSignTasksBindingSource.EndEdit()
                Me.TblVitalSignObjectivesBindingSource.EndEdit()
                Me.TblContactsBindingSource.EndEdit()
                Me.VwVitalSignOverviewBindingSource.EndEdit()
                Me.DataManagementMilestonesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)
            Catch ex As Exception
                Me.TblVitalSignsBindingSource.CancelEdit()
                Me.TblVitalSignWorkLogBindingSource.CancelEdit()
                Me.TblVitalSignProtocolsBindingSource.CancelEdit()
                Me.TblProtocolDeliverablesBindingSource.CancelEdit()
                Me.TblProtocolRemeasurementsBindingSource.CancelEdit()
                Me.TblVitalSignDataManagementSummaryBindingSource.CancelEdit()
                Me.TblVitalSignTasksBindingSource.CancelEdit()
                Me.TblVitalSignObjectivesBindingSource.CancelEdit()
                Me.TblContactsBindingSource.CancelEdit()
                Me.VwVitalSignOverviewBindingSource.CancelEdit()
                Me.DataManagementMilestonesBindingSource.CancelEdit()
                MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveDataset()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        SaveDataset()
    End Sub

    Private Sub TblVitalSignProtocolsGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles TblVitalSignProtocolsGridEX.SelectionChanged
        SetVitalSignProtocolsGridEXDefaultValues()
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

    Private Sub TblVitalSignWorkLogGridEX_SelectionChanged(sender As Object, e As EventArgs)
        'commit the change
        Try
            Me.TblVitalSignWorkLogBindingSource.EndEdit()
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





    Private Sub GenerateDeliverablesDirectoriesCreationScriptButton_Click(sender As Object, e As EventArgs) Handles GenerateDeliverablesDirectoriesCreationScriptButton.Click
        Try
            If Not Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID") Is Nothing And Not Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolTitle") Is Nothing Then
                Dim ProtocolID As Integer = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID").Value

                'get the protocol title
                Dim ProtocolTitle As String = ""
                If Not IsDBNull(Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolTitle").Value) Then
                    ProtocolTitle = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolTitle").Value
                End If

                'get the protocol Version
                Dim ProtocolVersion As String = 0
                If Not IsDBNull(Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("Version").Value) Then
                    ProtocolVersion = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("Version").Value
                End If

                'get the deliverables for the currently selected protocol version
                Dim DeliverablesDataView As New DataView(Me.AKRODataSet.Tables("tblProtocolDeliverables"), "ProtocolID=" & ProtocolID, "DeliverableIdentifier", DataViewRowState.CurrentRows)
                Dim Script As String = "REM Script to create deliverable directories for " & vbNewLine
                Script = Script & "REM " & ProtocolTitle & vbNewLine
                Script = Script & "REM Version: " & ProtocolVersion & vbNewLine
                Script = Script & "REM Instructions: Put this batch file in a new empty deliverables directory and then execute it to create a subdirectory for each deliverable type." & vbNewLine
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
        Dim DSForm As New DeliverablesScheduleForm(Me.TblVitalSignProtocolsGridEX.CurrentRow)
        DSForm.DeliverablesScheduleDataView = DSDataView
        DSForm.ShowDialog()
    End Sub


    Private Sub TblVitalSignWorkLogGridEX_DoubleClick(sender As Object, e As EventArgs)
        ToggleGridEXView(TblVitalSignWorkLogGridEX)
    End Sub

    ''' <summary>
    ''' Returns the current Vital Sign ID (VSID) value 
    ''' </summary>
    ''' <returns>VSID. Integer.</returns>
    Private Function GetCurrentVSID() As Integer
        Dim VSID As Integer = 0
        Try
            'get the current row of the  GridEX
            If Not Me.TblVitalSignsGridEX.CurrentRow Is Nothing Then
                If Not Me.TblVitalSignsGridEX.CurrentRow.Cells("VSID") Is Nothing Then
                    VSID = Me.TblVitalSignsGridEX.CurrentRow.Cells("VSID").Value
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return VSID
    End Function

    ''' <summary>
    ''' Returns the current Vital Sign name 
    ''' </summary>
    ''' <returns>Vital Sign name. String.</returns>
    Private Function GetCurrentVSName() As String
        Dim VSName As String = ""
        Try
            'get the current row of the  GridEX
            If Not Me.TblVitalSignsGridEX.CurrentRow Is Nothing Then
                If Not Me.TblVitalSignsGridEX.CurrentRow.Cells("NetworkVSName") Is Nothing Then
                    VSName = Me.TblVitalSignsGridEX.CurrentRow.Cells("NetworkVSName").Value
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return VSName
    End Function


    ''' <summary>
    ''' Returns the DeliverableID of the currently selected deliverable in the protocols GridEX
    ''' </summary>
    ''' <returns></returns>
    Private Function GetCurrentDeliverableID() As String
        Dim DeliverableID As Integer = 0
        Try
            'get the current row of the  GridEX
            If Not Me.TblVitalSignProtocolsGridEX.CurrentRow Is Nothing Then
                Dim CurrentDataRowView As DataRowView = Me.TblVitalSignProtocolsGridEX.CurrentRow.DataRow
                If Not CurrentDataRowView.Item("DeliverableID") Is Nothing Then
                    DeliverableID = CurrentDataRowView.Item("DeliverableID")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return DeliverableID
    End Function

    ''' <summary>
    ''' Returns the current Vital Sign work log VSDMLogID value
    ''' </summary>
    ''' <returns>VSDMLogID. Integer.</returns>
    Private Function GetCurrentWorkLogID() As Integer
        Dim VSDMLogID As Integer = 0
        Try
            'get the current row of the  GridEX
            If Not Me.TblVitalSignWorkLogGridEX.CurrentRow Is Nothing Then
                Dim CurrentRow As GridEXRow = Me.TblVitalSignWorkLogGridEX.CurrentRow
                'loop through the columns and look for the VSDMLogID column
                For i As Integer = 0 To CurrentRow.Cells.Count - 1
                    If CurrentRow.Cells(i).Column.Key = "VSDMLogID" Then
                        'if there is a value
                        If Not IsDBNull(CurrentRow.Cells(i).Value) And CurrentRow.Cells(i).Value > 0 Then
                            VSDMLogID = CurrentRow.Cells(i).Value
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return VSDMLogID
    End Function

    Private Sub EditLogEntryToolStripButton_Click(sender As Object, e As EventArgs) Handles EditLogEntryToolStripButton.Click
        'get the current VSDMLogID and submit it to a WorkLogForm
        Dim VSDMLogID As Integer = GetCurrentWorkLogID()
        If VSDMLogID > 0 Then
            Me.TblVitalSignWorkLogBindingSource.EndEdit()
            Dim LogEntryDataRow() As Data.DataRow
            LogEntryDataRow = Me.AKRODataSet.Tables("tblVitalSignWorkLog").Select("VSDMLogID = " & VSDMLogID)
            Dim WorkLogForm As New WorkLogForm(LogEntryDataRow(0))
            WorkLogForm.ShowDialog()

        End If
    End Sub

    Private Sub CreateDeliverablesDirectoriesToolStripButton_Click(sender As Object, e As EventArgs) Handles CreateDeliverablesDirectoriesToolStripButton.Click
        CreateDeliverablesDirectories()
    End Sub

    Private Sub CreateDeliverablesDirectories()
        Dim RootDirectory As String = ""

        Try
            'make sure we have a valid protocolid from the current row of the datagridview
            If Not Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID") Is Nothing Then
                'get the current protocolid
                Dim ProtocolID As Integer = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("ProtocolID").Value
                Dim VSID As Integer = Me.TblVitalSignProtocolsGridEX.CurrentRow.Cells("VSID").Value

                'try to get the files directory
                Dim FilesDirectory As String = ""
                If Not Me.TblVitalSignsGridEX.CurrentRow.Cells("FilesDirectory") Is Nothing Then
                    FilesDirectory = Me.TblVitalSignsGridEX.CurrentRow.Cells("FilesDirectory").Value
                End If

                'make a savefiledialog. we could use a folderbrowserdialog but those suck.
                Dim SFD As New SaveFileDialog
                SFD.Title = "Select directory"
                SFD.OverwritePrompt = False

                'see if the vital sign files directory attribute exists, if so use it
                If My.Computer.FileSystem.DirectoryExists(FilesDirectory) Then
                    'make a /Data directory if it doesn't have it already
                    'Dim DataDirectory As String = FilesDirectory & "\Data"
                    'If My.Computer.FileSystem.DirectoryExists(DataDirectory) = False Then
                    '    My.Computer.FileSystem.CreateDirectory(DataDirectory)
                    'End If
                    'set the initial directory to the vital sign's directory
                    SFD.InitialDirectory = FilesDirectory
                End If

                'at this point user should have chosen a directory
                If SFD.ShowDialog = DialogResult.OK Then
                    'make a fileinfo so we can get at the directory name
                    Dim FileInfo As New System.IO.FileInfo(SFD.FileName)
                    RootDirectory = FileInfo.DirectoryName

                    'get the deliverables for the current protocolid into a dataview so we can loop through them
                    Dim DeliverablesDataView As New DataView(Me.AKRODataSet.Tables("tblProtocolDeliverables"), "ProtocolID=" & ProtocolID, "DeliverableIdentifier", DataViewRowState.CurrentRows)
                    For Each Row As DataRowView In DeliverablesDataView
                        Dim Identifier As String = Row.Item("DeliverableIdentifier")
                        Dim Desc As String = Row.Item("Deliverable")
                        Dim DeliverablesDirectoryPath As String = RootDirectory & "\" & Identifier & " " & Desc
                        If My.Computer.FileSystem.DirectoryExists(RootDirectory) Then
                            'we don't want to overwrite an existing directory
                            If My.Computer.FileSystem.DirectoryExists(DeliverablesDirectoryPath) = False Then
                                'create the directory
                                My.Computer.FileSystem.CreateDirectory(DeliverablesDirectoryPath)
                            End If

                        End If
                    Next
                Else
                    MsgBox("No protocol selected. Select a protocol in the grid.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenProtocolDirectoryButton_Click(sender As Object, e As EventArgs) Handles OpenProtocolDirectoryButton.Click
        Try
            Process.Start(Me.ProtocolDirectoryTextBox.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OpenDataDirectoryButton_Click(sender As Object, e As EventArgs) Handles OpenDataDirectoryButton.Click
        Try
            Process.Start(Me.DataDirectoryTextBox.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataManagementMilestonesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DataManagementMilestonesBindingSource.CurrentChanged


    End Sub

    Private Sub OpenProtocolTrackerToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenProtocolTrackerToolStripButton.Click
        'the gridex contains a column called IRMAProtocolTrackerID which is the unique ID of the Vital Sign (not the protocol as the website implies)
        'in the IRMA Data Store protocol tracker website (see My.Settings.IRMAProtocolTrackerID)
        'this sub will get the currently selected row in the GridEX, identify the IRMAProtocolTrackerID value
        'and attempt to construct a URL and open it using a process
        Try
            'get the current row of the VS GridEX
            If Not Me.TblVitalSignsGridEX.CurrentRow Is Nothing Then
                Dim CurrentRow As GridEXRow = Me.TblVitalSignsGridEX.CurrentRow
                'loop through the columns and look for the IRMAProtocolTrackerID column
                For i As Integer = 0 To CurrentRow.Cells.Count - 1
                    If CurrentRow.Cells(i).Column.Key = "IRMAProtocolTrackerID" Then
                        'if there is a value
                        If Not IsDBNull(CurrentRow.Cells(i).Value) Then
                            Dim IRMAProtocolTrackerID As String = CurrentRow.Cells(i).Value
                            Dim URL As String = My.Settings.IRMAProtocolTrackerURLPrefix & IRMAProtocolTrackerID
                            'try to start it using the default program (probably file explorer)
                            Try
                                Process.Start(URL)
                            Catch ex As Exception
                                MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                            End Try
                        Else
                            'try to open the protocol tracker to the main inventory
                            Try
                                Process.Start(My.Settings.IRMAProtocolTrackerURLPrefix)
                            Catch ex As Exception
                                MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                            End Try
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub ProtocolDirectoryTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ProtocolDirectoryTextBox.Validating
        Try
            'make sure the protocol directory exists
            If Me.ProtocolDirectoryTextBox.Text.Trim <> "" Then
                If My.Computer.FileSystem.DirectoryExists(Me.ProtocolDirectoryTextBox.Text.Trim) = False Then
                    Me.ProtocolDirectoryTextBox.ForeColor = Color.Red
                Else
                    Me.ProtocolDirectoryTextBox.ForeColor = Color.Black
                End If
            Else
                Me.ProtocolDirectoryTextBox.ForeColor = Color.Black
            End If
        Catch ex As Exception
            Me.ProtocolDirectoryTextBox.ForeColor = Color.Black
            Me.DataDirectoryTextBox.ForeColor = Color.Black
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub DataDirectoryTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DataDirectoryTextBox.Validating
        Try
            'make sure the data directory exists
            If Me.DataDirectoryTextBox.Text.Trim <> "" Then
                If My.Computer.FileSystem.DirectoryExists(Me.DataDirectoryTextBox.Text.Trim) = False Then
                    Me.DataDirectoryTextBox.ForeColor = Color.Red
                Else
                    Me.DataDirectoryTextBox.ForeColor = Color.Black
                End If
            Else
                Me.DataDirectoryTextBox.ForeColor = Color.Black
            End If

        Catch ex As Exception
            Me.ProtocolDirectoryTextBox.ForeColor = Color.Black
            Me.DataDirectoryTextBox.ForeColor = Color.Black
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub



    Private Sub OpenProgramManagerReportServerURLToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenProgramManagerReportServerURLToolStripButton.Click
        Try
            'open the program manager sql server report server url
            Process.Start(My.Settings.ProgramManagerReportServerURL)
        Catch ex As Exception
            MsgBox(ex.Message & " Possibly the URL for the Sql Server Reporting Server is incorrectly set in Settings." & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub NetworkTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkTasksToolStripMenuItem.Click
        Dim NetworkTasksForm As New NetworkTasksForm
        NetworkTasksForm.Show()
    End Sub



    Private Sub TblVitalSignProtocolsGridEX_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles TblVitalSignProtocolsGridEX.RowDoubleClick
        'try to open the double clicked protocol item's IRMA Data Store reference code in a browser
        OpenProtocolItemIRMAReferenceCode(Me.TblVitalSignProtocolsGridEX)
    End Sub

    Private Sub OpenProtocolItemIRMAReferenceCode(GridEX As GridEX)
        Try
            Dim CellText As String = "" 'the IRMA Data Store reference code for the clicked item
            Dim CellColumnName As String = "" 'the column name
            If Not GridEX.CurrentRow Is Nothing And Not GridEX.CurrentColumn Is Nothing Then
                CellColumnName = GridEX.CurrentColumn.Key
                CellText = GridEX.CurrentRow.Cells(GridEX.CurrentColumn.Index).Text
            End If

            'try to open the URL with reference code for the protocol item
            If (IsNumeric(CellText)) = True And (CellColumnName = "IRMAReferenceCode" Or CellColumnName = "DateNarrativePublished" Or CellColumnName = "DQSReferenceCode" Or CellColumnName = "PIPSourceReferenceCode" Or CellColumnName = "QAPReferenceCode") Then
                Process.Start(My.Settings.IRMADataStoreURLPrefix.Trim & CellText)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub VitalSignTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VitalSignTasksToolStripMenuItem.Click
        Dim VSTasksForm As New VitalSignTasksMasterForm
        VSTasksForm.Show()
        SaveDataset()
        LoadDataset()
    End Sub

    Private Sub TblVitalSignsGridEX_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles TblVitalSignsGridEX.CellUpdated
        'update the RecordUpdatedDate and RecordUpdatedBy cells
        UpdateRecordUpdatedFields(Me.TblVitalSignsGridEX)
    End Sub



    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem.Click
        Dim ContactsForm As New ContactsForm
        ContactsForm.ShowDialog()
        SaveDataset()
        LoadDataset()
    End Sub

    Private Sub TblVitalSignWorkLogGridEX_CellEdited(sender As Object, e As ColumnActionEventArgs)
        'set the default values
        SetVitalSignWorkLogGridEXDefaultValues()
        'UpdateRecordUpdatedFields(Me.TblVitalSignWorkLogGridEX)
    End Sub

    Private Sub TblVitalSignTasksGridEX_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles TblVitalSignTasksGridEX.CellEdited
        'set the default values
        SetVitalSignTasksGridEXDefaultValues()
        'update the RecordUpdatedDate and RecordUpdatedBy cells
        UpdateRecordUpdatedFields(Me.TblVitalSignTasksGridEX)
    End Sub

    ''' <summary>
    ''' Revises the default values for the Vital Sign tasks gridex
    ''' </summary>
    Private Sub SetVitalSignTasksGridEXDefaultValues()
        Try
            Dim GridEX As GridEX = Me.TblVitalSignTasksGridEX
            GridEX.RootTable.Columns("DateDue").DefaultValue = Now.AddDays(30)
            GridEX.RootTable.Columns("DateAssigned").DefaultValue = Now
            GridEX.RootTable.Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.RootTable.Columns("RecordInsertedBy").DefaultValue = My.User.Name
            GridEX.RootTable.Columns("RecordUpdatedDate").DefaultValue = Now
            GridEX.RootTable.Columns("RecordUpdatedBy").DefaultValue = My.User.Name
            GridEX.RootTable.Columns("AssignedTo").DefaultValue = 3
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Revises the default values for the Vital Sign work log gridex
    ''' </summary>
    Private Sub SetVitalSignWorkLogGridEXDefaultValues()
        'set default values
        Dim GridEX As GridEX = Me.TblVitalSignWorkLogGridEX
        Try
            GridEX.RootTable.Columns("LogDate").DefaultValue = Now
            GridEX.RootTable.Columns("Username").DefaultValue = My.User.Name
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Revises the default values for the Vital Sign work log gridex
    ''' </summary>
    Private Sub SetVitalSignProtocolsGridEXDefaultValues()
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

    Private Sub SetProtocolRemeasurementsGridexDefaultValues()
        'set default values
        Dim GridEX As GridEX = Me.TblProtocolRemeasurementsGridEX
        Try
            GridEX.RootTable.Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.RootTable.Columns("RecordInsertedBy").DefaultValue = My.User.Name
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SetProtocolDeliverablesGridEXDefaultValues()
        'set default values
        Dim GridEX As GridEX = Me.TblProtocolDeliverablesGridEX
        Try
            GridEX.RootTable.Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.RootTable.Columns("RecordInsertedBy").DefaultValue = My.User.Name
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LogEntryRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles LogEntryRichTextBox.TextChanged
        SetVitalSignWorkLogGridEXDefaultValues()

        'UpdateRecordUpdatedFields(Me.TblVitalSignWorkLogGridEX)
    End Sub

    Private Sub WorkLogFontToolStripButton_Click(sender As Object, e As EventArgs) Handles WorkLogFontToolStripButton.Click
        Dim FD As New FontDialog()
        FD.Font = Me.LogEntryRichTextBox.Font
        FD.ShowDialog()
        Dim WorkLogFont As Font = FD.Font
        Me.LogEntryRichTextBox.Font = WorkLogFont
    End Sub

    Private Sub WorkLogReportToolStripButton_Click(sender As Object, e As EventArgs) Handles WorkLogReportToolStripButton.Click
        Dim CurrentVSID As Integer = GetCurrentVSID()
        If CurrentVSID > 0 Then
            Dim WorkLogReportForm As New WorkLogReportForm(AKRODataSet.tblVitalSignWorkLog, GetCurrentVSID, GetCurrentVSName() & " Work Log")
            WorkLogReportForm.ShowDialog()
        Else
            MsgBox("No Vital Sign is currently selected.")
        End If

    End Sub

    Private Sub EditDeliverableToolStripButton_Click(sender As Object, e As EventArgs) Handles EditDeliverableToolStripButton.Click
        'get the current deliverableid
        Dim DeliverableForm As New DeliverableForm
        DeliverableForm.Show()
        'GetCurrentDeliverableID()
    End Sub

    Private Sub GenerateProtocolSummaryToolStripButton_Click(sender As Object, e As EventArgs) Handles GenerateProtocolSummaryToolStripButton.Click
        Dim CurrentVSID As Integer = GetCurrentVSID()
        Dim VSSummary As String = GetVitalSignSummary(CurrentVSID)
        Dim ProtocolSummaryForm As New GenericOutputForm("Protocols summary", VSSummary)
        ProtocolSummaryForm.ShowDialog()
    End Sub

    Private Sub GetRemeasurementVerbageToolStripButton_Click(sender As Object, e As EventArgs) Handles GetRemeasurementVerbageToolStripButton.Click
        'generate boilerplate text for the remeasurement dataset for dumping into IRMA Data Store
        Dim BP As String = GetCurrentRemeasurementDatasetVerbage(",")

        Dim VerbageForm As New GenericOutputForm("Remeasurement Dataset Verbage", BP)
        VerbageForm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Generates boilerplate verbage that can be cut and pasted into an IRMA Dataset Reference for a Vital Sign's remeasurement deliverables
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCurrentRemeasurementDatasetVerbage(Delimiter As String) As String
        Dim V As String = "Failed to retrieve the verbage for this remeasurement (GetCurrentRemeasurementDatasetVerbage())" 'the verbage

        Try
            'Dim CurrentVSID As String = GetCurrentGridEXCellValue(Me.TblVitalSignsGridEX, "VSID")
            Dim CurrentProtocolID As String = GetCurrentGridEXCellValue(Me.TblVitalSignProtocolsGridEX, "ProtocolID")
            Dim CurrentRemeasurementID As String = GetCurrentGridEXCellValue(Me.TblProtocolRemeasurementsGridEX, "RemeasurementID")
            If CurrentProtocolID <> "" And CurrentRemeasurementID <> "" Then
                'Dataset overview --------------------------------------------------------------------
                Dim DatasetTitle As String = GetCurrentGridEXCellValue(TblProtocolRemeasurementsGridEX, "Description")
                'Dim VitalSign As String = GetCurrentGridEXCellValue(Me.TblVitalSignsGridEX, "VitalSign")
                Dim ProtocolCitation As String = GetCurrentGridEXCellValue(Me.TblVitalSignProtocolsGridEX, "ProtocolCitation")
                Dim Version As String = GetCurrentGridEXCellValue(Me.TblVitalSignProtocolsGridEX, "Version")
                Dim IRMAReferenceCode As String = GetCurrentGridEXCellValue(Me.TblVitalSignProtocolsGridEX, "IRMAReferenceCode")

                'title
                V = DatasetTitle & vbNewLine & vbNewLine

                'sensitivity statement
                V = V & "--- SENSITIVITY STATEMENT - MODIFY/DELETE AS NEEDED ---" & vbNewLine & vbNewLine
                V = V & "[SENSITIVE DATA. NPS internal use only]. This dataset contains information about a species of commercial interest Or threatened Or endangered species. " & vbNewLine & vbNewLine

                'data quality statement
                V = V & "--- RAW/PROVISIONAL DATA STATEMENT - MODIFY/DELETE AS NEEDED ---" & vbNewLine & vbNewLine
                V = V & "CAUTION: This dataset contains archived raw field data deliverable files that have not been certified for analytical use. The data in this dataset may be incomplete and/or not processed for quality. These deliverables are archived for future quality checking purposes by NPS scientists. Certified data is available. Contact the project leader."
                V = V & vbNewLine & vbNewLine

                'protocol reference
                V = V & "Data deliverables For this monitoring program are defined In " & ProtocolCitation & ", Version " & Version & ", IRMA reference code " & IRMAReferenceCode & ". This protocol Is available through the National Park Service's Integrated Resource Management Applications Data Store." & vbNewLine & vbNewLine


                'deliverables schedule --------------------------------------------------------------------
                V = V & "Deliverables Schedule" & vbNewLine & vbNewLine
                Dim Sql As String = "SELECT DeliverableIdentifier, Deliverable, SOP, SOPVersion, Format, Schedule, Responsibility, DeliverableDescription, DataHandling, QAQC, DocumentNotes, NetworkID, VSID, ProtocolID, DocumentID, DeliverableID, Archival, Specifications, 
                         FileNamingScheme, BuilderTasks, ValidatorTasks, CertifierTasks
FROM            vwProtocolDeliverables
WHERE        (ProtocolID = " & CurrentProtocolID & ")"

                'dump out the deliverables into a readable string
                'also build out the specifications
                Dim DeliverablesDataTable As DataTable = GetDataTable(My.Settings.AKROConnectionString, Sql)

                'build a header line
                V = V & "Identifier,Deliverable,Format,Schedule" & vbNewLine
                'dump out the deliverables in a readable table format
                Dim Specs As String = ""
                For Each Row As DataRow In DeliverablesDataTable.Rows
                    V = V & Row.Item("DeliverableIDentifier") & Delimiter & Row.Item("Deliverable") & Delimiter & Row.Item("Format") & Delimiter & Row.Item("Schedule") & vbNewLine

                    Specs = Specs & Row.Item("DeliverableIDentifier") & ": " & Row.Item("Deliverable") & vbNewLine & "Format: " & Row.Item("Format") & vbNewLine & "Schedule: " & Row.Item("Schedule") & vbNewLine & "Description: " & Row.Item("DeliverableDescription") & vbNewLine & vbNewLine
                Next

                'output the extended specifications
                V = V & vbNewLine & "Specifications" & vbNewLine
                V = V & Specs & vbNewLine & vbNewLine




                V = V & "U.S. Government Works" & vbNewLine & "Data and content created by government employees within the scope of their employment are not subject to domestic copyright protection under 17 U.S.C. § 105. Government works are by default in the U.S. Public Domain." & vbNewLine

            End If

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        Return V
    End Function


    Private Sub CurrentRemeasurementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentRemeasurementToolStripMenuItem.Click
        OpenCurrentRemeasurementDataset()
    End Sub

    Private Sub OpenCurrentRemeasurementDataset()
        Try
            'open the ref code using the default application
            Dim IRMAReferenceCode As String = GetCurrentGridEXCellValue(Me.TblProtocolRemeasurementsGridEX, "DeliverablesIRMAReferenceCode")
            If IsNumeric(IRMAReferenceCode) Then
                If CInt(IRMAReferenceCode) > 0 Then
                    Dim URL As String = My.Settings.IRMADataStoreURLPrefix & IRMAReferenceCode
                    Process.Start(URL)
                End If

            Else
                MsgBox("Please select a remeasurement with a valid Data Store reference code.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub AllRemeasurementsShownBelowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllRemeasurementsShownBelowToolStripMenuItem.Click
        Try
            'loop through all the dataset references in the remeasurements grid and open them using default application
            For Each Row As GridEXRow In Me.TblProtocolRemeasurementsGridEX.GetRows
                If Not Row Is Nothing Then
                    If Not Row.Cells("DeliverablesIRMAReferenceCode") Is Nothing Then
                        If Not Row.Cells("DeliverablesIRMAReferenceCode").Value Is Nothing Then
                            If Not IsDBNull(Row.Cells("DeliverablesIRMAReferenceCode").Value) Then
                                Dim RefCode As String = Row.Cells("DeliverablesIRMAReferenceCode").Value
                                If IsNumeric(RefCode) Then
                                    If CInt(RefCode) > 0 Then
                                        Dim URL As String = My.Settings.IRMADataStoreURLPrefix & RefCode
                                        Process.Start(URL)
                                    End If
                                End If

                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenDatasetsToolStripSplitButton_ButtonClick(sender As Object, e As EventArgs) Handles OpenDatasetsToolStripSplitButton.ButtonClick
        OpenCurrentRemeasurementDataset()
    End Sub
End Class
