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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenericOutputForm))
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.WrapToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputTextBox.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.Location = New System.Drawing.Point(0, 25)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputTextBox.Size = New System.Drawing.Size(785, 459)
        Me.OutputTextBox.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WrapToolStripDropDownButton, Me.ToolStripSeparator1, Me.SaveToFileToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(785, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'WrapToolStripDropDownButton
        '
        Me.WrapToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.WrapToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
        Me.WrapToolStripDropDownButton.Image = CType(resources.GetObject("WrapToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.WrapToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WrapToolStripDropDownButton.Name = "WrapToolStripDropDownButton"
        Me.WrapToolStripDropDownButton.Size = New System.Drawing.Size(48, 22)
        Me.WrapToolStripDropDownButton.Text = "Wrap"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'SaveToFileToolStripButton
        '
        Me.SaveToFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToFileToolStripButton.Image = CType(resources.GetObject("SaveToFileToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToFileToolStripButton.Name = "SaveToFileToolStripButton"
        Me.SaveToFileToolStripButton.Size = New System.Drawing.Size(58, 22)
        Me.SaveToFileToolStripButton.Text = "Save as..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GenericOutputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 484)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GenericOutputForm"
        Me.Text = "GenericOutputForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents WrapToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents OnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveToFileToolStripButton As ToolStripButton
End Class
