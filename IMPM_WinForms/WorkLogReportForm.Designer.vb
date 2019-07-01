<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkLogReportForm
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
        Me.WorkLogReportTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'WorkLogReportTextBox
        '
        Me.WorkLogReportTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkLogReportTextBox.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkLogReportTextBox.Location = New System.Drawing.Point(0, 0)
        Me.WorkLogReportTextBox.Multiline = True
        Me.WorkLogReportTextBox.Name = "WorkLogReportTextBox"
        Me.WorkLogReportTextBox.Size = New System.Drawing.Size(1178, 1144)
        Me.WorkLogReportTextBox.TabIndex = 0
        '
        'WorkLogReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 1144)
        Me.Controls.Add(Me.WorkLogReportTextBox)
        Me.Name = "WorkLogReportForm"
        Me.Text = "WorkLogReportForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorkLogReportTextBox As TextBox
End Class
