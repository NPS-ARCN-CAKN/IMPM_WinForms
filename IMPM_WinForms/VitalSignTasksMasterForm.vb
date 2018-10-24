Public Class VitalSignTasksMasterForm
    Private Sub VitalSignTasksMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AKRODataSet.vwVitalSignWorkLog' table. You can move, or remove it, as needed.
        Me.VwVitalSignWorkLogTableAdapter.Fill(Me.AKRODataSet.vwVitalSignWorkLog)

    End Sub
End Class