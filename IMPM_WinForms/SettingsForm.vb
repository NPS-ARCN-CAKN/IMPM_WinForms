Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.SaveMySettingsOnExit = True
        Me.SettingsPropertyGrid.SelectedObject = My.Settings
    End Sub

    Private Sub SettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class