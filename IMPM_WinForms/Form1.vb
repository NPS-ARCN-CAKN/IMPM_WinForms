Imports Janus.Windows.GridEX
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblVitalSignsTableAdapter.Fill(Me.AKRODataSet.tblVitalSigns)
        Me.TblVitalSignDataManagementSummaryTableAdapter.Fill(Me.AKRODataSet.tblVitalSignDataManagementSummary)
        Me.VwVitalSignOverviewTableAdapter.Fill(Me.AKRODataSet.vwVitalSignOverview)
        Me.TblVitalSignProtocolsTableAdapter.Fill(Me.AKRODataSet.tblVitalSignProtocols)
        Me.TblProtocolRemeasurementsTableAdapter.Fill(Me.AKRODataSet.tblProtocolRemeasurements)
        Me.TblProtocolDeliverablesTableAdapter.Fill(Me.AKRODataSet.tblProtocolDeliverables)
        Me.TblVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.tblVitalSignWorkLog)
        Me.TblVitalSignTasksTableAdapter.Fill(Me.AKRODataSet.tblVitalSignTasks)
        Me.TblVitalSignTasksTableAdapter.Fill(Me.AKRODataSet.tblVitalSignTasks)

        'set up the gridexs
        SetUpGridEX(Me.VwVitalSignOverviewGridEX)
        SetUpGridEX(TblVitalSignsGridEX)
        SetUpGridEX(TblVitalSignWorkLogGridEX)
        SetUpGridEX(TblVitalSignProtocolsGridEX)
        SetUpGridEX(TblVitalSignTasksGridEX)


        'maximize the form
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub SetUpGridEX(GridEX As GridEX)
        'set up the gridex
        Dim MyFont As New Font("Sans Serif", 10, FontStyle.Regular)
        Dim MyFormatStyle As New GridEXFormatStyle()
        With MyFormatStyle
            .Font = MyFont
            .TextAlignment = TextAlignment.Near
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
            .ColumnAutoSizeMode = ColumnAutoSizeMode.DiaplayedCells
            '.ColumnAutoResize = True
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
                Me.VitalSignHeaderLabel.Text = Acronym & " " & VSName
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
        Try
            Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignProtocols").Columns("RecordInsertedDate").DefaultValue = Now
            Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignProtocols").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignProtocols").Columns("Version").DefaultValue = 0
            Me.TblVitalSignProtocolsGridEX.Tables("tblProtocolDeliverables").Columns("RecordInsertedDate").DefaultValue = Now
            Me.TblVitalSignProtocolsGridEX.Tables("tblProtocolDeliverables").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignRemeasurements").Columns("RecordInsertedDate").DefaultValue = Now
            Me.TblVitalSignProtocolsGridEX.Tables("tblVitalSignRemeasurements").Columns("RecordInsertedBy").DefaultValue = My.User.Name
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


End Class
