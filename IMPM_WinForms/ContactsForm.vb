Imports Janus.Windows.GridEX

Public Class ContactsForm
    Private Sub Save()
        Me.Validate()
        Me.TblContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)

    End Sub

    Private Sub ContactsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load data from database
        Me.TblContactsTableAdapter.Fill(Me.AKRODataSet.tblContacts)

        'standard formatting
        SetUpGridEX(Me.TblContactsGridEX)

        'default values
        Try
            Dim GridEX As GridEX = Me.TblContactsGridEX
            GridEX.Tables("tblContacts").Columns("RecordInsertedDate").DefaultValue = Now
            GridEX.Tables("tblContacts").Columns("RecordInsertedBy").DefaultValue = My.User.Name
            GridEX.Tables("tblContacts").Columns("RecordUpdatedDate").DefaultValue = Now
            GridEX.Tables("tblContacts").Columns("RecordUpdatedBy").DefaultValue = My.User.Name
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Save()
    End Sub

    Private Sub ContactsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AKRODataSet.HasChanges = True Then
            If MsgBox("You have unsaved changes. Save changes to the database?", MsgBoxStyle.YesNo, "Save changes?") = MsgBoxResult.Yes Then
                Save()
            End If
        End If
    End Sub

    Private Sub TblContactsGridEX_CellEdited(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles TblContactsGridEX.CellEdited
        'record tracking metadata
        UpdateRecordUpdatedFields(Me.TblContactsGridEX)
    End Sub
End Class