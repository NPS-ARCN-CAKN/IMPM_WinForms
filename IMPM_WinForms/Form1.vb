Imports Janus.Windows.GridEX
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VwVitalSignOverviewTableAdapter.Fill(Me.AKRODataSet.vwVitalSignOverview)
        Me.TblVitalSignsTableAdapter.Fill(Me.AKRODataSet.tblVitalSigns)
        Me.TblVitalSignProtocolsTableAdapter.Fill(Me.AKRODataSet.tblVitalSignProtocols)
        Me.TblProtocolRemeasurementsTableAdapter.Fill(Me.AKRODataSet.tblProtocolRemeasurements)
        Me.TblProtocolDeliverablesTableAdapter.Fill(Me.AKRODataSet.tblProtocolDeliverables)
        Me.TblVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.tblVitalSignWorkLog)

        'set up the gridexs
        SetUpGridEX(Me.VwVitalSignOverviewGridEX)
        SetUpGridEX(TblVitalSignsGridEX)
        SetUpGridEX(TblVitalSignWorkLogGridEX)
        SetUpGridEX(TblVitalSignProtocolsGridEX)


        'maximize the form
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub SetUpGridEX(GridEX As GridEX)
        Dim MyFont As New Font("Sans Serif", 10, FontStyle.Regular)
        With GridEX
            .Font = MyFont
            .RowHeaders = InheritableBoolean.True
            .NewRowPosition = NewRowPosition.BottomRow
            .SelectOnExpand = False
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

    Private Sub SaveDataset()
        If AKRODataSet.HasChanges = True Then
            If MsgBox("Save changes to database?", MsgBoxStyle.YesNo, "Dataset has changes") = MsgBoxResult.Yes Then
                Try
                    Me.TblVitalSignsBindingSource.EndEdit()
                    Me.TblVitalSignWorkLogBindingSource.EndEdit()
                    Me.TblVitalSignProtocolsBindingSource.EndEdit()
                    Me.TblProtocolDeliverablesBindingSource.EndEdit()
                    Me.TblProtocolRemeasurementsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)
                Catch ex As Exception
                    Me.TblVitalSignsBindingSource.CancelEdit()
                    Me.TblVitalSignWorkLogBindingSource.CancelEdit()
                    Me.TblVitalSignProtocolsBindingSource.CancelEdit()
                    Me.TblProtocolDeliverablesBindingSource.CancelEdit()
                    Me.TblProtocolRemeasurementsBindingSource.CancelEdit()
                    MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
                End Try
            End If
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveDataset()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
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
End Class
