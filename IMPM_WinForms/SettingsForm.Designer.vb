<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.SettingsPropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.SuspendLayout()
        '
        'SettingsPropertyGrid
        '
        Me.SettingsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsPropertyGrid.LineColor = System.Drawing.SystemColors.ControlDark
        Me.SettingsPropertyGrid.Location = New System.Drawing.Point(0, 0)
        Me.SettingsPropertyGrid.Name = "SettingsPropertyGrid"
        Me.SettingsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.SettingsPropertyGrid.Size = New System.Drawing.Size(724, 434)
        Me.SettingsPropertyGrid.TabIndex = 0
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 434)
        Me.Controls.Add(Me.SettingsPropertyGrid)
        Me.Name = "SettingsForm"
        Me.Text = "Settings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsPropertyGrid As PropertyGrid
End Class
