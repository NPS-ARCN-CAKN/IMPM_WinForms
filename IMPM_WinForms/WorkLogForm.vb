Public Class WorkLogForm

    Private _LogEntryDataRow As DataRow
    Public Property LogEntryDataRow() As DataRow
        Get
            Return _LogEntryDataRow
        End Get
        Set(ByVal value As DataRow)
            _LogEntryDataRow = value
        End Set
    End Property

    Public Sub New(LogEntryDataRow As DataRow)
        InitializeComponent()
        Me.LogEntryDataRow = LogEntryDataRow
        Me.LogEntryRichTextBox.Text = _LogEntryDataRow.Item("LogEntry")
        'WorkLogRow(0)("CompanyName") = "Updated Company Name"
        'WorkLogRow(0)("City") = "Seattle"
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        CommitEdit()

    End Sub

    Private Sub CommitEdit()
        _LogEntryDataRow.Item("LogEntry") = Me.LogEntryRichTextBox.Text
    End Sub

    Private Sub WorkLogForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CommitEdit()
    End Sub
End Class