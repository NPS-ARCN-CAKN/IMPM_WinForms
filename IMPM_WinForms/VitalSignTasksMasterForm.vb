﻿Public Class VitalSignTasksMasterForm
    Private Sub TblVitalSignTasksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
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

        'set up ContactsDropDown using the GridEX designer, then set the data binding in code here to retrieve the records
        Try
            Me.TblVitalSignTasksGridEX.DropDowns("ContactsDropDown").SetDataBinding(AKRODataSet, "tblContacts")
            Me.TblVitalSignTasksGridEX.DropDowns("VitalSignsDropDown").SetDataBinding(AKRODataSet, "vwVitalSignOverview")
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub
End Class