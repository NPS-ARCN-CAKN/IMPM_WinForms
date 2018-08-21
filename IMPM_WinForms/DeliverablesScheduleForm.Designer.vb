<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliverablesScheduleForm
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
        Me.DeliverablesScheduleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DeliverableIdentifier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deliverable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Format = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Schedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsibility = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DeliverablesScheduleGridTabPage = New System.Windows.Forms.TabPage()
        Me.DeliverablesScheduleTextTabPage = New System.Windows.Forms.TabPage()
        Me.ColumnsChooserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DeliverablesSplitContainer = New System.Windows.Forms.SplitContainer()
        CType(Me.DeliverablesScheduleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.DeliverablesScheduleGridTabPage.SuspendLayout()
        Me.DeliverablesScheduleTextTabPage.SuspendLayout()
        CType(Me.ColumnsChooserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverablesSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeliverablesSplitContainer.Panel1.SuspendLayout()
        Me.DeliverablesSplitContainer.Panel2.SuspendLayout()
        Me.DeliverablesSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeliverablesScheduleDataGridView
        '
        Me.DeliverablesScheduleDataGridView.AllowUserToAddRows = False
        Me.DeliverablesScheduleDataGridView.AllowUserToDeleteRows = False
        Me.DeliverablesScheduleDataGridView.AllowUserToOrderColumns = True
        Me.DeliverablesScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DeliverablesScheduleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DeliverablesScheduleDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DeliverablesScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeliverablesScheduleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeliverableIdentifier, Me.Deliverable, Me.Format, Me.Schedule, Me.Responsibility, Me.Description, Me.SOP, Me.Column1})
        Me.DeliverablesScheduleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliverablesScheduleDataGridView.Location = New System.Drawing.Point(2, 2)
        Me.DeliverablesScheduleDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.DeliverablesScheduleDataGridView.Name = "DeliverablesScheduleDataGridView"
        Me.DeliverablesScheduleDataGridView.ReadOnly = True
        Me.DeliverablesScheduleDataGridView.RowTemplate.Height = 24
        Me.DeliverablesScheduleDataGridView.Size = New System.Drawing.Size(596, 488)
        Me.DeliverablesScheduleDataGridView.TabIndex = 0
        '
        'DeliverableIdentifier
        '
        Me.DeliverableIdentifier.DataPropertyName = "DeliverableIdentifier"
        Me.DeliverableIdentifier.HeaderText = "Identifier"
        Me.DeliverableIdentifier.Name = "DeliverableIdentifier"
        Me.DeliverableIdentifier.ReadOnly = True
        Me.DeliverableIdentifier.Width = 72
        '
        'Deliverable
        '
        Me.Deliverable.DataPropertyName = "Deliverable"
        Me.Deliverable.HeaderText = "Deliverable"
        Me.Deliverable.Name = "Deliverable"
        Me.Deliverable.ReadOnly = True
        Me.Deliverable.Width = 85
        '
        'Format
        '
        Me.Format.DataPropertyName = "Format"
        Me.Format.HeaderText = "Format"
        Me.Format.Name = "Format"
        Me.Format.ReadOnly = True
        Me.Format.Width = 64
        '
        'Schedule
        '
        Me.Schedule.DataPropertyName = "Schedule"
        Me.Schedule.HeaderText = "Schedule"
        Me.Schedule.Name = "Schedule"
        Me.Schedule.ReadOnly = True
        Me.Schedule.Width = 77
        '
        'Responsibility
        '
        Me.Responsibility.DataPropertyName = "Responsibility"
        Me.Responsibility.HeaderText = "Responsibility"
        Me.Responsibility.Name = "Responsibility"
        Me.Responsibility.ReadOnly = True
        Me.Responsibility.Width = 96
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 85
        '
        'SOP
        '
        Me.SOP.DataPropertyName = "SOP"
        Me.SOP.HeaderText = "SOP"
        Me.SOP.Name = "SOP"
        Me.SOP.ReadOnly = True
        Me.SOP.Width = 54
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "SOPVersion"
        Me.Column1.HeaderText = "SOP Version"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 92
        '
        'DSTextBox
        '
        Me.DSTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DSTextBox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DSTextBox.Location = New System.Drawing.Point(2, 2)
        Me.DSTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DSTextBox.Multiline = True
        Me.DSTextBox.Name = "DSTextBox"
        Me.DSTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DSTextBox.Size = New System.Drawing.Size(596, 488)
        Me.DSTextBox.TabIndex = 1
        Me.DSTextBox.WordWrap = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DeliverablesScheduleGridTabPage)
        Me.TabControl1.Controls.Add(Me.DeliverablesScheduleTextTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(608, 518)
        Me.TabControl1.TabIndex = 2
        '
        'DeliverablesScheduleGridTabPage
        '
        Me.DeliverablesScheduleGridTabPage.Controls.Add(Me.DeliverablesScheduleDataGridView)
        Me.DeliverablesScheduleGridTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DeliverablesScheduleGridTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.DeliverablesScheduleGridTabPage.Name = "DeliverablesScheduleGridTabPage"
        Me.DeliverablesScheduleGridTabPage.Padding = New System.Windows.Forms.Padding(2)
        Me.DeliverablesScheduleGridTabPage.Size = New System.Drawing.Size(600, 492)
        Me.DeliverablesScheduleGridTabPage.TabIndex = 0
        Me.DeliverablesScheduleGridTabPage.Text = "Grid"
        Me.DeliverablesScheduleGridTabPage.UseVisualStyleBackColor = True
        '
        'DeliverablesScheduleTextTabPage
        '
        Me.DeliverablesScheduleTextTabPage.Controls.Add(Me.DSTextBox)
        Me.DeliverablesScheduleTextTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DeliverablesScheduleTextTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.DeliverablesScheduleTextTabPage.Name = "DeliverablesScheduleTextTabPage"
        Me.DeliverablesScheduleTextTabPage.Padding = New System.Windows.Forms.Padding(2)
        Me.DeliverablesScheduleTextTabPage.Size = New System.Drawing.Size(600, 492)
        Me.DeliverablesScheduleTextTabPage.TabIndex = 1
        Me.DeliverablesScheduleTextTabPage.Text = "Text"
        Me.DeliverablesScheduleTextTabPage.UseVisualStyleBackColor = True
        '
        'ColumnsChooserDataGridView
        '
        Me.ColumnsChooserDataGridView.AllowUserToAddRows = False
        Me.ColumnsChooserDataGridView.AllowUserToDeleteRows = False
        Me.ColumnsChooserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ColumnsChooserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColumnsChooserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColumnsChooserDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ColumnsChooserDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ColumnsChooserDataGridView.Name = "ColumnsChooserDataGridView"
        Me.ColumnsChooserDataGridView.RowTemplate.Height = 24
        Me.ColumnsChooserDataGridView.Size = New System.Drawing.Size(163, 518)
        Me.ColumnsChooserDataGridView.TabIndex = 1
        '
        'DeliverablesSplitContainer
        '
        Me.DeliverablesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliverablesSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.DeliverablesSplitContainer.Name = "DeliverablesSplitContainer"
        '
        'DeliverablesSplitContainer.Panel1
        '
        Me.DeliverablesSplitContainer.Panel1.Controls.Add(Me.ColumnsChooserDataGridView)
        '
        'DeliverablesSplitContainer.Panel2
        '
        Me.DeliverablesSplitContainer.Panel2.Controls.Add(Me.TabControl1)
        Me.DeliverablesSplitContainer.Size = New System.Drawing.Size(775, 518)
        Me.DeliverablesSplitContainer.SplitterDistance = 163
        Me.DeliverablesSplitContainer.TabIndex = 3
        '
        'DeliverablesScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 518)
        Me.Controls.Add(Me.DeliverablesSplitContainer)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DeliverablesScheduleForm"
        Me.Text = "Deliverables Schedule"
        CType(Me.DeliverablesScheduleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.DeliverablesScheduleGridTabPage.ResumeLayout(False)
        Me.DeliverablesScheduleTextTabPage.ResumeLayout(False)
        Me.DeliverablesScheduleTextTabPage.PerformLayout()
        CType(Me.ColumnsChooserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeliverablesSplitContainer.Panel1.ResumeLayout(False)
        Me.DeliverablesSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.DeliverablesSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeliverablesSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeliverablesScheduleDataGridView As DataGridView
    Friend WithEvents DSTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DeliverablesScheduleGridTabPage As TabPage
    Friend WithEvents DeliverablesScheduleTextTabPage As TabPage
    Friend WithEvents DeliverableIdentifier As DataGridViewTextBoxColumn
    Friend WithEvents Deliverable As DataGridViewTextBoxColumn
    Friend WithEvents Format As DataGridViewTextBoxColumn
    Friend WithEvents Schedule As DataGridViewTextBoxColumn
    Friend WithEvents Responsibility As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents SOP As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnsChooserDataGridView As DataGridView
    Friend WithEvents DeliverablesSplitContainer As SplitContainer
End Class
