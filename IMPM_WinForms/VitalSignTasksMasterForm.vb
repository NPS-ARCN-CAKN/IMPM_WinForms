Imports Janus.Windows.GridEX

Public Class VitalSignTasksMasterForm
    Private Sub Save()
        Me.Validate()
        Me.TblVitalSignTasksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)
    End Sub

    Private Sub VitalSignTasksMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblVitalSignTasksBindingSource.Filter = "DateCompleted is NULL"
        Me.ToggleCompletedToolStripButton.Text = "Show completed"
        Me.TblVitalSignTasksBindingSource.Sort = "DateDue DESC"

        'load data from database
        Me.TblVitalSignsTableAdapter.Fill(Me.AKRODataSet.tblVitalSigns)
        Me.TblVitalSignTasksTableAdapter.Fill(Me.AKRODataSet.tblVitalSignTasks)
        Me.TblContactsTableAdapter.Fill(Me.AKRODataSet.tblContacts)
        Me.VwVitalSignOverviewTableAdapter.Fill(Me.AKRODataSet.vwVitalSignOverview)

        'set up ContactsDropDown using the GridEX designer, then set the data binding in code here to retrieve the records
        Try
            Me.TblVitalSignTasksGridEX.DropDowns("ContactsDropDown").SetDataBinding(AKRODataSet, "tblContacts")
            Me.TblVitalSignTasksGridEX.DropDowns("VitalSignsDropDown").SetDataBinding(AKRODataSet, "vwVitalSignOverview")
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        FormatOverDueTasks()


    End Sub

    Private Sub FormatOverDueTasks()
        Try
            For Each Row As GridEXRow In Me.TblVitalSignTasksGridEX.GetRows
                If Not Row.Cells("DateDue") Is Nothing Then
                    'finished tasks have DateDue not Null so eliminate finished tasks
                    If Not IsDBNull(Row.Cells("DateDue").Value) = True Then
                        Dim DueDateString As String = Row.Cells("DateDue").Value
                        Dim DueDate As DateTime = CDate(DueDateString)
                        Row.BeginEdit()
                        Row.Cells("Overdue").Value = DueDate < Now
                        Row.EndEdit()
                    End If
                End If
            Next
            Me.TblVitalSignTasksBindingSource.EndEdit()

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Save()
    End Sub

    Private Sub VitalSignTasksMasterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AKRODataSet.HasChanges = True Then
            If MsgBox("You have unsaved changes. Save changes to the database?", MsgBoxStyle.YesNo, "Save changes?") = MsgBoxResult.Yes Then
                Save()
            End If
        End If
    End Sub

    Private Sub ToggleCompletedToolStripButton_Click(sender As Object, e As EventArgs) Handles ToggleCompletedToolStripButton.Click
        If Me.ToggleCompletedToolStripButton.Text = "Show completed" Then
            Me.TblVitalSignTasksBindingSource.RemoveFilter()
            Me.ToggleCompletedToolStripButton.Text = "Hide completed"
        Else
            Me.TblVitalSignTasksBindingSource.Filter = "DateCompleted is NULL"
            Me.ToggleCompletedToolStripButton.Text = "Show completed"
        End If
    End Sub

    Private Sub TblVitalSignTasksGridEX_Paint(sender As Object, e As PaintEventArgs) Handles TblVitalSignTasksGridEX.Paint
        FormatOverDueTasks()
    End Sub
End Class