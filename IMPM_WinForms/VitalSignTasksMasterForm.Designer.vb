<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VitalSignTasksMasterForm
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
        Me.components = New System.ComponentModel.Container()
        Dim TblVitalSignTasksGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VitalSignTasksMasterForm))
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.TblVitalSignTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblVitalSignTasksTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignTasksTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.TblContactsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblContactsTableAdapter()
        Me.TblVitalSignsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignsTableAdapter()
        Me.TblVitalSignTasksGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVitalSignOverviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVitalSignOverviewTableAdapter = New IMPM.AKRODataSetTableAdapters.vwVitalSignOverviewTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToggleCompletedToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VwContactsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwContactsLookupTableAdapter = New IMPM.AKRODataSetTableAdapters.vwContactsLookupTableAdapter()
        Me.TasksSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.NotesRichTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignTasksGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignOverviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.VwContactsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TasksSplitContainer.Panel1.SuspendLayout()
        Me.TasksSplitContainer.Panel2.SuspendLayout()
        Me.TasksSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'AKRODataSet
        '
        Me.AKRODataSet.DataSetName = "AKRODataSet"
        Me.AKRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblVitalSignTasksBindingSource
        '
        Me.TblVitalSignTasksBindingSource.DataMember = "tblVitalSignTasks"
        Me.TblVitalSignTasksBindingSource.DataSource = Me.AKRODataSet
        '
        'TblVitalSignTasksTableAdapter
        '
        Me.TblVitalSignTasksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataManagementMilestonesTableAdapter = Nothing
        Me.TableAdapterManager.tblContactsTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworksTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworkTasksTableAdapter = Nothing
        Me.TableAdapterManager.tblProtocolDeliverablesTableAdapter = Nothing
        Me.TableAdapterManager.tblProtocolRemeasurementsTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignDataManagementSummaryTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignObjectivesTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignProtocolsTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignsTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignTasksTableAdapter = Me.TblVitalSignTasksTableAdapter
        Me.TableAdapterManager.tblVitalSignWorkLogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IMPM.AKRODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblContactsTableAdapter
        '
        Me.TblContactsTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignsTableAdapter
        '
        Me.TblVitalSignsTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignTasksGridEX
        '
        Me.TblVitalSignTasksGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignTasksGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignTasksGridEX.AlternatingColors = True
        Me.TblVitalSignTasksGridEX.DataSource = Me.TblVitalSignTasksBindingSource
        TblVitalSignTasksGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignTasksGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignTasksGridEX.DesignTimeLayout = TblVitalSignTasksGridEX_DesignTimeLayout
        Me.TblVitalSignTasksGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignTasksGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TblVitalSignTasksGridEX.GridLines = Janus.Windows.GridEX.GridLines.None
        Me.TblVitalSignTasksGridEX.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.TblVitalSignTasksGridEX.GroupByBoxFormatStyle.BackColorGradient = System.Drawing.Color.Empty
        Me.TblVitalSignTasksGridEX.GroupByBoxInfoFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.TblVitalSignTasksGridEX.GroupIndent = 64
        Me.TblVitalSignTasksGridEX.GroupRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TblVitalSignTasksGridEX.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.Empty
        Me.TblVitalSignTasksGridEX.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.TblVitalSignTasksGridEX.GroupRowFormatStyle.FontSize = 20.0!
        Me.TblVitalSignTasksGridEX.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.TblVitalSignTasksGridEX.Location = New System.Drawing.Point(0, 0)
        Me.TblVitalSignTasksGridEX.Name = "TblVitalSignTasksGridEX"
        Me.TblVitalSignTasksGridEX.RecordNavigator = True
        Me.TblVitalSignTasksGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignTasksGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable
        Me.TblVitalSignTasksGridEX.Size = New System.Drawing.Size(955, 699)
        Me.TblVitalSignTasksGridEX.TabIndex = 1
        '
        'TblVitalSignsBindingSource
        '
        Me.TblVitalSignsBindingSource.DataMember = "tblVitalSigns"
        Me.TblVitalSignsBindingSource.DataSource = Me.AKRODataSet
        '
        'TblContactsBindingSource
        '
        Me.TblContactsBindingSource.DataMember = "tblContacts"
        Me.TblContactsBindingSource.DataSource = Me.AKRODataSet
        '
        'VwVitalSignOverviewBindingSource
        '
        Me.VwVitalSignOverviewBindingSource.DataMember = "vwVitalSignOverview"
        Me.VwVitalSignOverviewBindingSource.DataSource = Me.AKRODataSet
        '
        'VwVitalSignOverviewTableAdapter
        '
        Me.VwVitalSignOverviewTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.ToggleCompletedToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1342, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToggleCompletedToolStripButton
        '
        Me.ToggleCompletedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToggleCompletedToolStripButton.Image = CType(resources.GetObject("ToggleCompletedToolStripButton.Image"), System.Drawing.Image)
        Me.ToggleCompletedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToggleCompletedToolStripButton.Name = "ToggleCompletedToolStripButton"
        Me.ToggleCompletedToolStripButton.Size = New System.Drawing.Size(100, 22)
        Me.ToggleCompletedToolStripButton.Text = "Show completed"
        '
        'VwContactsLookupBindingSource
        '
        Me.VwContactsLookupBindingSource.DataMember = "vwContactsLookup"
        Me.VwContactsLookupBindingSource.DataSource = Me.AKRODataSet
        '
        'VwContactsLookupTableAdapter
        '
        Me.VwContactsLookupTableAdapter.ClearBeforeFill = True
        '
        'TasksSplitContainer
        '
        Me.TasksSplitContainer.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TblVitalSignTasksBindingSource, "Notes", True))
        Me.TasksSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TasksSplitContainer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TasksSplitContainer.Location = New System.Drawing.Point(0, 25)
        Me.TasksSplitContainer.Name = "TasksSplitContainer"
        '
        'TasksSplitContainer.Panel1
        '
        Me.TasksSplitContainer.Panel1.Controls.Add(Me.TblVitalSignTasksGridEX)
        '
        'TasksSplitContainer.Panel2
        '
        Me.TasksSplitContainer.Panel2.Controls.Add(Me.NotesRichTextBox)
        Me.TasksSplitContainer.Size = New System.Drawing.Size(1342, 699)
        Me.TasksSplitContainer.SplitterDistance = 955
        Me.TasksSplitContainer.TabIndex = 3
        '
        'NotesRichTextBox
        '
        Me.NotesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVitalSignTasksBindingSource, "Notes", True))
        Me.NotesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotesRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.NotesRichTextBox.Name = "NotesRichTextBox"
        Me.NotesRichTextBox.Size = New System.Drawing.Size(383, 699)
        Me.NotesRichTextBox.TabIndex = 0
        Me.NotesRichTextBox.Text = ""
        '
        'VitalSignTasksMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 724)
        Me.Controls.Add(Me.TasksSplitContainer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "VitalSignTasksMasterForm"
        Me.Text = "Vital Sign Tasks"
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignTasksGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignOverviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.VwContactsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TasksSplitContainer.Panel1.ResumeLayout(False)
        Me.TasksSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.TasksSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TasksSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AKRODataSet As AKRODataSet
    Friend WithEvents TblVitalSignTasksBindingSource As BindingSource
    Friend WithEvents TblVitalSignTasksTableAdapter As AKRODataSetTableAdapters.tblVitalSignTasksTableAdapter
    Friend WithEvents TableAdapterManager As AKRODataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblVitalSignTasksGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents TblVitalSignsTableAdapter As AKRODataSetTableAdapters.tblVitalSignsTableAdapter
    Friend WithEvents TblVitalSignsBindingSource As BindingSource
    Friend WithEvents TblContactsTableAdapter As AKRODataSetTableAdapters.tblContactsTableAdapter
    Friend WithEvents TblContactsBindingSource As BindingSource
    Friend WithEvents VwVitalSignOverviewBindingSource As BindingSource
    Friend WithEvents VwVitalSignOverviewTableAdapter As AKRODataSetTableAdapters.vwVitalSignOverviewTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToggleCompletedToolStripButton As ToolStripButton
    Friend WithEvents VwContactsLookupBindingSource As BindingSource
    Friend WithEvents VwContactsLookupTableAdapter As AKRODataSetTableAdapters.vwContactsLookupTableAdapter
    Friend WithEvents TasksSplitContainer As SplitContainer
    Friend WithEvents NotesRichTextBox As RichTextBox
End Class
