Public Class GenericOutputForm

    Public Sub New(FormTitle As String, FormText As String)

        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = FormTitle
        Me.OutputTextBox.Text = FormText
    End Sub

    Private Sub GenericOutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem.Click
        Me.OutputTextBox.WordWrap = True
    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem.Click
        Me.OutputTextBox.WordWrap = False
    End Sub
End Class