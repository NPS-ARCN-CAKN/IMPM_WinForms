Public Class DeliverableForm
    Private DeliverableDataRow As DataRow
    Public Property DataRow() As DataRow
        Get
            Return DeliverableDataRow
        End Get
        Set(ByVal value As DataRow)
            DeliverableDataRow = value
        End Set
    End Property
    Private Sub TblProtocolDeliverablesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProtocolDeliverablesBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.TblProtocolDeliverablesBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.AKRODataSet)

    End Sub

    Private Sub DeliverableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AKRODataSet.tblProtocolDeliverables' table. You can move, or remove it, as needed.
        'Me.TblProtocolDeliverablesTableAdapter.Fill(Me.AKRODataSet.tblProtocolDeliverables)
        'Me.DeliverableIdentifierTextBox.DataBindings.Add("Text", AKRODataSet.Tables("tblProtocolDeliverables"), "DeliverableIdentifier")
        'Me.DeliverableIdentifierTextBox.Text = Form1.controls("tbl Me.bindincontext(DataSet, "tablename").current("field")
    End Sub
End Class