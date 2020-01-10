<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenericOutputForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OutputRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'OutputRichTextBox
        '
        Me.OutputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputRichTextBox.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.OutputRichTextBox.Name = "OutputRichTextBox"
        Me.OutputRichTextBox.Size = New System.Drawing.Size(1178, 744)
        Me.OutputRichTextBox.TabIndex = 0
        Me.OutputRichTextBox.Text = ""
        '
        'GenericOutputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 744)
        Me.Controls.Add(Me.OutputRichTextBox)
        Me.Name = "GenericOutputForm"
        Me.Text = "GenericOutputForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutputRichTextBox As RichTextBox
End Class
