﻿Imports Janus.Windows.GridEX

Public Class NetworkTasksForm
    ''' <summary>
    ''' Saves the changes to the database.
    ''' </summary>
    Private Sub Save()
        Try
            Me.Validate()
            Me.TblNetworkTasksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub NetworkTasksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the data from the database into the table adapters
        Me.TblContactsTableAdapter.Fill(Me.AKRODataSet.tblContacts)
        Me.TblNetworkTasksTableAdapter.Fill(Me.AKRODataSet.tblNetworkTasks)

        'maximize
        Me.WindowState = FormWindowState.Maximized

        'set default values
        Dim GridEX As GridEX = Me.TblNetworkTasksGridEX
        Try
            GridEX.Tables("tblNetworkTasks").Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.Tables("tblNetworkTasks").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            GridEX.Tables("tblNetworkTasks").Columns("RecordUpdatedDate").DefaultValue = Now
            GridEX.Tables("tblNetworkTasks").Columns("RecordUpdatedBy").DefaultValue = My.User.Name
            GridEX.Tables("tblNetworkTasks").Columns("FiscalYear").DefaultValue = Now.Year
            GridEX.Tables("tblNetworkTasks").Columns("DateDue").DefaultValue = Now.AddDays(30)
            GridEX.Tables("tblNetworkTasks").Columns("DateAssigned").DefaultValue = Now
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        'set up static dropdowns
        Try
            With GridEX.Tables("tblNetworkTasks").Columns("NetworkID")
                .AutoComplete = True
                .HasValueList = True
                .LimitToList = False
            End With
            Dim List As GridEXValueListItemCollection = GridEX.Tables("tblNetworkTasks").Columns("NetworkID").ValueList
            List.Clear()
            List.Add(1, "ARCN")
            List.Add(2, "CAKN")
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        'load the AssignedTo column dropdown
        Try
            With GridEX.RootTable.Columns("AssignedTo")
                .AutoSize()
                .AllowSort = True
                .AutoComplete = True
                .Caption = "Assigned to"
                .HasValueList = True
                .LimitToList = True
            End With

            Dim AssignedToList As GridEXValueListItemCollection = GridEX.Tables("tblNetworkTasks").Columns("AssignedTo").ValueList
            AssignedToList.Clear()
            Dim ContactsDataView As DataView = Me.AKRODataSet.tblContacts.DefaultView
            ContactsDataView.Sort = "Lastname,Firstname"
            For Each Row As DataRowView In ContactsDataView
                Dim ContactName As String = Row.Item("Lastname").ToString.Trim & ", " & Row.Item("Firstname").ToString.Trim
                Dim ContactID As Integer = Row.Item("ContactID")
                AssignedToList.Add(ContactID, ContactName)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        Save()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ConfirmSaveChanges()
        Me.Close()
    End Sub


    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Save()
    End Sub

    Private Sub NetworkTasksForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmSaveChanges()
    End Sub

    Private Sub ConfirmSaveChanges()
        If Me.AKRODataSet.HasChanges = True Then
            If MsgBox("Save changes?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                Save()
            End If
        End If
    End Sub
End Class