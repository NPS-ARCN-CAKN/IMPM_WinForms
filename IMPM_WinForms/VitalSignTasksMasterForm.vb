﻿Imports Janus.Windows.GridEX

Public Class VitalSignTasksMasterForm
    Private Sub Save()
        Me.Validate()
        Me.TblVitalSignTasksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)
    End Sub

    Private Sub VitalSignTasksMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'load data from database
        Me.TblVitalSignsTableAdapter.Fill(Me.AKRODataSet.tblVitalSigns)
        Me.TblVitalSignTasksTableAdapter.Fill(Me.AKRODataSet.tblVitalSignTasks)
        Me.TblContactsTableAdapter.Fill(Me.AKRODataSet.tblContacts)
        Me.VwVitalSignOverviewTableAdapter.Fill(Me.AKRODataSet.vwVitalSignOverview)

        'filter
        Me.VwContactsLookupTableAdapter.Fill(Me.AKRODataSet.vwContactsLookup)
        Me.TblVitalSignTasksBindingSource.Filter = "DateCompleted is NULL"
        Me.ToggleCompletedToolStripButton.Text = "Show completed"
        Me.TblVitalSignTasksBindingSource.Sort = "DateDue DESC"

        'default values
        Try
            Dim GridEX As GridEX = Me.TblVitalSignTasksGridEX
            GridEX.Tables("tblVitalSignTasks").Columns("DateDue").DefaultValue = Now.AddDays(30)
            GridEX.Tables("tblVitalSignTasks").Columns("DateAssigned").DefaultValue = Now
            GridEX.Tables("tblVitalSignTasks").Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.Tables("tblVitalSignTasks").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            GridEX.Tables("tblVitalSignTasks").Columns("RecordUpdatedDate").DefaultValue = Now
            GridEX.Tables("tblVitalSignTasks").Columns("RecordUpdatedBy").DefaultValue = My.User.Name
            If My.User.Name = "SDMiller" Then
                GridEX.Tables("tblVitalSignTasks").Columns("AssignedTo").DefaultValue = 3
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try


        'set up ContactsDropDown using the GridEX designer, then set the data binding in code here to retrieve the records
        Try
            Me.TblVitalSignTasksGridEX.DropDowns("ContactsDropDown").SetDataBinding(AKRODataSet, "vwContactsLookup")
            Me.TblVitalSignTasksGridEX.DropDowns("VitalSignsDropDown").SetDataBinding(AKRODataSet, "vwVitalSignOverview")
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        'format the gridex
        SetUpGridEX(Me.TblVitalSignTasksGridEX)

        FormatOverDueTasks(Me.TblVitalSignTasksGridEX)


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
        FormatOverDueTasks(Me.TblVitalSignTasksGridEX)
    End Sub

    Private Sub TblVitalSignTasksGridEX_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles TblVitalSignTasksGridEX.CellEdited
        AddCompletedTaskToWorkLog()
    End Sub

    Private Sub TblVitalSignTasksGridEX_Validated(sender As Object, e As EventArgs) Handles TblVitalSignTasksGridEX.Validated
        'update the RecordUpdatedDate and RecordUpdatedBy cells
        UpdateRecordUpdatedFields(Me.TblVitalSignTasksGridEX)
    End Sub

    Private Sub NotesRichTextBox_Validated(sender As Object, e As EventArgs) Handles NotesRichTextBox.Validated
        'update the RecordUpdatedDate and RecordUpdatedBy cells
        UpdateRecordUpdatedFields(Me.TblVitalSignTasksGridEX)
    End Sub

    Private Sub AddCompletedTaskToWorkLog()
        ' Dim CellName As String = Me.TblVitalSignTasksGridEX.RootTable.Columns(e.Column.Index).Key
        'Dim CellValue As Date = GetCurrentDateCompleted()
        'MsgBox(CellValue)
        'NOTE I WANTED TO LOG THE COMPLETED TASK IN THE WORK LOG HERE BUT GOT NO FURTHER
    End Sub

    ''' <summary>
    ''' Returns the value of the currently selected row's DateCompleted value
    ''' </summary>
    ''' <returns></returns>
    Private Function GetCurrentDateCompleted() As Date
        Dim DateCompleted As Date
        Try
            'get the current row of the  GridEX
            If Not Me.TblVitalSignTasksGridEX.CurrentRow Is Nothing Then
                Dim CurrentRow As GridEXRow = Me.TblVitalSignTasksGridEX.CurrentRow
                'loop through the columns and look for the DateCompleted column
                For i As Integer = 0 To CurrentRow.Cells.Count - 1
                    If CurrentRow.Cells(i).Column.Key = "DateCompleted" Then
                        'if there is a value
                        If Not IsDBNull(CurrentRow.Cells(i).Value) Then
                            DateCompleted = CurrentRow.Cells(i).Value
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return DateCompleted
    End Function
End Class