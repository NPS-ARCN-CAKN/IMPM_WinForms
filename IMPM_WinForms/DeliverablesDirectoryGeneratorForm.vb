

Public Class DeliverablesDirectoryGeneratorForm
    Private _Script As String
    Public Property Script() As String
        Get
            Return _Script
        End Get
        Set(ByVal value As String)
            _Script = value
            Me.ScriptTextBox.Text = _Script
        End Set
    End Property

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim SFD As New SaveFileDialog
        With SFD
            .DefaultExt = ".bat"
            .FileName = "CreateDeliverablesDirectories.bat"
            .Filter = "Batch Files | *.bat"
            .InitialDirectory = "C:\"
            .Title = "Save script"
        End With
        If SFD.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SFD.FileName, _Script, False)
        End If
    End Sub
End Class