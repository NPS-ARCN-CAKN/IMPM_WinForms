Public Class GenericOutputForm

    Public Sub New(FormTitle As String, FormText As String)

        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = FormTitle
        Me.OutputRichTextBox.Text = FormText
    End Sub

End Class