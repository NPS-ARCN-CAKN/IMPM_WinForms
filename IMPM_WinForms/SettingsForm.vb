Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.SaveMySettingsOnExit = True
        Me.SettingsPropertyGrid.SelectedObject = My.Settings
    End Sub
End Class