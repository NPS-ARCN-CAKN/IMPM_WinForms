<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProtocolAvailableLabel As System.Windows.Forms.Label
        Dim DataAvailableLabel As System.Windows.Forms.Label
        Dim DeliverablesScheduleLabel As System.Windows.Forms.Label
        Dim SOPsWrittenLabel As System.Windows.Forms.Label
        Dim DMChapterWrittenLabel As System.Windows.Forms.Label
        Dim DMSystemPlanExistsLabel As System.Windows.Forms.Label
        Dim DMSystemBuiltLabel As System.Windows.Forms.Label
        Dim ProtocolDirectoryLabel As System.Windows.Forms.Label
        Dim DataDirectoryLabel As System.Windows.Forms.Label
        Dim CurrentStatusLabel As System.Windows.Forms.Label
        Dim VwVitalSignOverviewGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TblVitalSignsGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblProtocolDeliverablesGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ProtocolDeliverablesCardViewGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblProtocolRemeasurementsGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignProtocolsGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignDataManagementSummaryGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignTasksGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignWorkLogGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vwVitalSignWorkLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.VwVitalSignOverviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVitalSignOverviewTableAdapter = New IMPM.AKRODataSetTableAdapters.vwVitalSignOverviewTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.TblContactsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblContactsTableAdapter()
        Me.TblProtocolDeliverablesTableAdapter = New IMPM.AKRODataSetTableAdapters.tblProtocolDeliverablesTableAdapter()
        Me.TblProtocolRemeasurementsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblProtocolRemeasurementsTableAdapter()
        Me.TblVitalSignDataManagementSummaryTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignDataManagementSummaryTableAdapter()
        Me.TblVitalSignObjectivesTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignObjectivesTableAdapter()
        Me.TblVitalSignProtocolsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignProtocolsTableAdapter()
        Me.TblVitalSignsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignsTableAdapter()
        Me.TblVitalSignTasksTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignTasksTableAdapter()
        Me.TblVitalSignWorkLogTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignWorkLogTableAdapter()
        Me.VwVitalSignOverviewGridEX = New Janus.Windows.GridEX.GridEX()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.VitalSignPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VitalSignTabControl = New System.Windows.Forms.TabControl()
        Me.OverviewTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignsGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProtocolsTabPage = New System.Windows.Forms.TabPage()
        Me.ProtocolTabControl = New System.Windows.Forms.TabControl()
        Me.DeliverablesTabPage = New System.Windows.Forms.TabPage()
        Me.ProtocolDeliverablesSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TblProtocolDeliverablesGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblProtocolDeliverablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblVitalSignProtocolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProtocolDeliverablesCardViewGridEX = New Janus.Windows.GridEX.GridEX()
        Me.RemeasurementsTabPage = New System.Windows.Forms.TabPage()
        Me.TblProtocolRemeasurementsGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblProtocolRemeasurementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblVitalSignProtocolsGridEX = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.GenerateDeliverablesDirectoriesCreationScriptButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenDeliverablesScheduleFormToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateDeliverablesDirectoriesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditDeliverableToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ObjectivesTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignObjectivesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblVitalSignObjectivesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblVitalSignObjectivesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataManagementMilestonesTabPage = New System.Windows.Forms.TabPage()
        Me.OpenDataDirectoryButton = New System.Windows.Forms.Button()
        Me.OpenProtocolDirectoryButton = New System.Windows.Forms.Button()
        Me.ProtocolAvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataManagementMilestonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataAvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeliverablesScheduleCheckBox = New System.Windows.Forms.CheckBox()
        Me.SOPsWrittenCheckBox = New System.Windows.Forms.CheckBox()
        Me.DMChapterWrittenCheckBox = New System.Windows.Forms.CheckBox()
        Me.DMSystemPlanExistsCheckBox = New System.Windows.Forms.CheckBox()
        Me.DMSystemBuiltCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProtocolDirectoryTextBox = New System.Windows.Forms.TextBox()
        Me.DataDirectoryTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentStatusTextBox = New System.Windows.Forms.TextBox()
        Me.DataManagementOverviewTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignDataManagementSummaryGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignDataManagementSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignTasksGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSWorkLogTabPage = New System.Windows.Forms.TabPage()
        Me.WorkLogSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TblVitalSignWorkLogGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignWorkLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogEntryRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.WorkLogToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EditLogEntryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.WorkLogFontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.WorkLogReportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.WorkLogTabControl = New System.Windows.Forms.TabControl()
        Me.WorkLogEditorTabPage = New System.Windows.Forms.TabPage()
        Me.SitesTabPage = New System.Windows.Forms.TabPage()
        Me.VitalSignOverviewToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OpenProjectDirectoryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenWebProfileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenProjectReferenceToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenProtocolTrackerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenProgramManagerReportServerURLToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VitalSignHeaderPanel = New System.Windows.Forms.Panel()
        Me.VitalSignHeaderLabel = New System.Windows.Forms.Label()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkTasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VitalSignTasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.vwVitalSignWorkLogTableAdapter = New IMPM.AKRODataSetTableAdapters.vwVitalSignWorkLogTableAdapter()
        Me.DataManagementMilestonesTableAdapter = New IMPM.AKRODataSetTableAdapters.DataManagementMilestonesTableAdapter()
        Me.VwContactsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwContactsLookupTableAdapter = New IMPM.AKRODataSetTableAdapters.vwContactsLookupTableAdapter()
        ProtocolAvailableLabel = New System.Windows.Forms.Label()
        DataAvailableLabel = New System.Windows.Forms.Label()
        DeliverablesScheduleLabel = New System.Windows.Forms.Label()
        SOPsWrittenLabel = New System.Windows.Forms.Label()
        DMChapterWrittenLabel = New System.Windows.Forms.Label()
        DMSystemPlanExistsLabel = New System.Windows.Forms.Label()
        DMSystemBuiltLabel = New System.Windows.Forms.Label()
        ProtocolDirectoryLabel = New System.Windows.Forms.Label()
        DataDirectoryLabel = New System.Windows.Forms.Label()
        CurrentStatusLabel = New System.Windows.Forms.Label()
        CType(Me.vwVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignOverviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignOverviewGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.VitalSignPanel.SuspendLayout()
        Me.VitalSignTabControl.SuspendLayout()
        Me.OverviewTabPage.SuspendLayout()
        CType(Me.TblVitalSignsGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProtocolsTabPage.SuspendLayout()
        Me.ProtocolTabControl.SuspendLayout()
        Me.DeliverablesTabPage.SuspendLayout()
        CType(Me.ProtocolDeliverablesSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProtocolDeliverablesSplitContainer.Panel1.SuspendLayout()
        Me.ProtocolDeliverablesSplitContainer.Panel2.SuspendLayout()
        Me.ProtocolDeliverablesSplitContainer.SuspendLayout()
        CType(Me.TblProtocolDeliverablesGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProtocolDeliverablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignProtocolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProtocolDeliverablesCardViewGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RemeasurementsTabPage.SuspendLayout()
        CType(Me.TblProtocolRemeasurementsGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProtocolRemeasurementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignProtocolsGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ObjectivesTabPage.SuspendLayout()
        CType(Me.TblVitalSignObjectivesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignObjectivesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblVitalSignObjectivesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblVitalSignObjectivesBindingNavigator.SuspendLayout()
        Me.DataManagementMilestonesTabPage.SuspendLayout()
        CType(Me.DataManagementMilestonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataManagementOverviewTabPage.SuspendLayout()
        CType(Me.TblVitalSignDataManagementSummaryGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignDataManagementSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TasksTabPage.SuspendLayout()
        CType(Me.TblVitalSignTasksGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VSWorkLogTabPage.SuspendLayout()
        CType(Me.WorkLogSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkLogSplitContainer.Panel1.SuspendLayout()
        Me.WorkLogSplitContainer.Panel2.SuspendLayout()
        Me.WorkLogSplitContainer.SuspendLayout()
        CType(Me.TblVitalSignWorkLogGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkLogToolStrip.SuspendLayout()
        Me.WorkLogTabControl.SuspendLayout()
        Me.VitalSignOverviewToolStrip.SuspendLayout()
        Me.VitalSignHeaderPanel.SuspendLayout()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuStrip.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        CType(Me.VwContactsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProtocolAvailableLabel
        '
        ProtocolAvailableLabel.AutoSize = True
        ProtocolAvailableLabel.Location = New System.Drawing.Point(40, 51)
        ProtocolAvailableLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProtocolAvailableLabel.Name = "ProtocolAvailableLabel"
        ProtocolAvailableLabel.Size = New System.Drawing.Size(193, 25)
        ProtocolAvailableLabel.TabIndex = 0
        ProtocolAvailableLabel.Text = "Protocol Available:"
        '
        'DataAvailableLabel
        '
        DataAvailableLabel.AutoSize = True
        DataAvailableLabel.Location = New System.Drawing.Point(40, 92)
        DataAvailableLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataAvailableLabel.Name = "DataAvailableLabel"
        DataAvailableLabel.Size = New System.Drawing.Size(159, 25)
        DataAvailableLabel.TabIndex = 2
        DataAvailableLabel.Text = "Data Available:"
        '
        'DeliverablesScheduleLabel
        '
        DeliverablesScheduleLabel.AutoSize = True
        DeliverablesScheduleLabel.Location = New System.Drawing.Point(40, 138)
        DeliverablesScheduleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DeliverablesScheduleLabel.Name = "DeliverablesScheduleLabel"
        DeliverablesScheduleLabel.Size = New System.Drawing.Size(235, 25)
        DeliverablesScheduleLabel.TabIndex = 4
        DeliverablesScheduleLabel.Text = "Deliverables Schedule:"
        '
        'SOPsWrittenLabel
        '
        SOPsWrittenLabel.AutoSize = True
        SOPsWrittenLabel.Location = New System.Drawing.Point(40, 185)
        SOPsWrittenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SOPsWrittenLabel.Name = "SOPsWrittenLabel"
        SOPsWrittenLabel.Size = New System.Drawing.Size(151, 25)
        SOPsWrittenLabel.TabIndex = 6
        SOPsWrittenLabel.Text = "SOPs Written:"
        '
        'DMChapterWrittenLabel
        '
        DMChapterWrittenLabel.AutoSize = True
        DMChapterWrittenLabel.Location = New System.Drawing.Point(40, 234)
        DMChapterWrittenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DMChapterWrittenLabel.Name = "DMChapterWrittenLabel"
        DMChapterWrittenLabel.Size = New System.Drawing.Size(204, 25)
        DMChapterWrittenLabel.TabIndex = 8
        DMChapterWrittenLabel.Text = "DMChapter Written:"
        '
        'DMSystemPlanExistsLabel
        '
        DMSystemPlanExistsLabel.AutoSize = True
        DMSystemPlanExistsLabel.Location = New System.Drawing.Point(40, 280)
        DMSystemPlanExistsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DMSystemPlanExistsLabel.Name = "DMSystemPlanExistsLabel"
        DMSystemPlanExistsLabel.Size = New System.Drawing.Size(237, 25)
        DMSystemPlanExistsLabel.TabIndex = 10
        DMSystemPlanExistsLabel.Text = "DMSystem Plan Exists:"
        '
        'DMSystemBuiltLabel
        '
        DMSystemBuiltLabel.AutoSize = True
        DMSystemBuiltLabel.Location = New System.Drawing.Point(40, 323)
        DMSystemBuiltLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DMSystemBuiltLabel.Name = "DMSystemBuiltLabel"
        DMSystemBuiltLabel.Size = New System.Drawing.Size(172, 25)
        DMSystemBuiltLabel.TabIndex = 12
        DMSystemBuiltLabel.Text = "DMSystem Built:"
        '
        'ProtocolDirectoryLabel
        '
        ProtocolDirectoryLabel.AutoSize = True
        ProtocolDirectoryLabel.Location = New System.Drawing.Point(40, 366)
        ProtocolDirectoryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProtocolDirectoryLabel.Name = "ProtocolDirectoryLabel"
        ProtocolDirectoryLabel.Size = New System.Drawing.Size(190, 25)
        ProtocolDirectoryLabel.TabIndex = 14
        ProtocolDirectoryLabel.Text = "Protocol Directory:"
        '
        'DataDirectoryLabel
        '
        DataDirectoryLabel.AutoSize = True
        DataDirectoryLabel.Location = New System.Drawing.Point(40, 406)
        DataDirectoryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataDirectoryLabel.Name = "DataDirectoryLabel"
        DataDirectoryLabel.Size = New System.Drawing.Size(156, 25)
        DataDirectoryLabel.TabIndex = 16
        DataDirectoryLabel.Text = "Data Directory:"
        '
        'CurrentStatusLabel
        '
        CurrentStatusLabel.AutoSize = True
        CurrentStatusLabel.Location = New System.Drawing.Point(40, 446)
        CurrentStatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CurrentStatusLabel.Name = "CurrentStatusLabel"
        CurrentStatusLabel.Size = New System.Drawing.Size(159, 25)
        CurrentStatusLabel.TabIndex = 18
        CurrentStatusLabel.Text = "Current Status:"
        '
        'vwVitalSignWorkLogBindingSource
        '
        Me.vwVitalSignWorkLogBindingSource.DataMember = "vwVitalSignWorkLog"
        Me.vwVitalSignWorkLogBindingSource.DataSource = Me.AKRODataSet
        '
        'AKRODataSet
        '
        Me.AKRODataSet.DataSetName = "AKRODataSet"
        Me.AKRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataManagementMilestonesTableAdapter = Me.DataManagementMilestonesTableAdapter
        Me.TableAdapterManager.tblContactsTableAdapter = Me.TblContactsTableAdapter
        Me.TableAdapterManager.tblNetworksTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworkTasksTableAdapter = Nothing
        Me.TableAdapterManager.tblProtocolDeliverablesTableAdapter = Me.TblProtocolDeliverablesTableAdapter
        Me.TableAdapterManager.tblProtocolRemeasurementsTableAdapter = Me.TblProtocolRemeasurementsTableAdapter
        Me.TableAdapterManager.tblVitalSignDataManagementSummaryTableAdapter = Me.TblVitalSignDataManagementSummaryTableAdapter
        Me.TableAdapterManager.tblVitalSignObjectivesTableAdapter = Me.TblVitalSignObjectivesTableAdapter
        Me.TableAdapterManager.tblVitalSignProtocolsTableAdapter = Me.TblVitalSignProtocolsTableAdapter
        Me.TableAdapterManager.tblVitalSignsTableAdapter = Me.TblVitalSignsTableAdapter
        Me.TableAdapterManager.tblVitalSignTasksTableAdapter = Me.TblVitalSignTasksTableAdapter
        Me.TableAdapterManager.tblVitalSignWorkLogTableAdapter = Me.TblVitalSignWorkLogTableAdapter
        Me.TableAdapterManager.UpdateOrder = IMPM.AKRODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblContactsTableAdapter
        '
        Me.TblContactsTableAdapter.ClearBeforeFill = True
        '
        'TblProtocolDeliverablesTableAdapter
        '
        Me.TblProtocolDeliverablesTableAdapter.ClearBeforeFill = True
        '
        'TblProtocolRemeasurementsTableAdapter
        '
        Me.TblProtocolRemeasurementsTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignDataManagementSummaryTableAdapter
        '
        Me.TblVitalSignDataManagementSummaryTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignObjectivesTableAdapter
        '
        Me.TblVitalSignObjectivesTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignProtocolsTableAdapter
        '
        Me.TblVitalSignProtocolsTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignsTableAdapter
        '
        Me.TblVitalSignsTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignTasksTableAdapter
        '
        Me.TblVitalSignTasksTableAdapter.ClearBeforeFill = True
        '
        'TblVitalSignWorkLogTableAdapter
        '
        Me.TblVitalSignWorkLogTableAdapter.ClearBeforeFill = True
        '
        'VwVitalSignOverviewGridEX
        '
        Me.VwVitalSignOverviewGridEX.DataSource = Me.VwVitalSignOverviewBindingSource
        VwVitalSignOverviewGridEX_DesignTimeLayout.LayoutString = resources.GetString("VwVitalSignOverviewGridEX_DesignTimeLayout.LayoutString")
        Me.VwVitalSignOverviewGridEX.DesignTimeLayout = VwVitalSignOverviewGridEX_DesignTimeLayout
        Me.VwVitalSignOverviewGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VwVitalSignOverviewGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.VwVitalSignOverviewGridEX.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VwVitalSignOverviewGridEX.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.VwVitalSignOverviewGridEX.FilterRowFormatStyle.ForeColor = System.Drawing.Color.Gray
        Me.VwVitalSignOverviewGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.VwVitalSignOverviewGridEX.Location = New System.Drawing.Point(0, 49)
        Me.VwVitalSignOverviewGridEX.Name = "VwVitalSignOverviewGridEX"
        Me.VwVitalSignOverviewGridEX.RecordNavigator = True
        Me.VwVitalSignOverviewGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.VwVitalSignOverviewGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.VwVitalSignOverviewGridEX.SelectOnExpand = False
        Me.VwVitalSignOverviewGridEX.SettingsKey = "VwVitalSignOverviewGridEX"
        Me.VwVitalSignOverviewGridEX.Size = New System.Drawing.Size(588, 1055)
        Me.VwVitalSignOverviewGridEX.TabIndex = 1
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 67)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.VwVitalSignOverviewGridEX)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.VitalSignPanel)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.VitalSignTabControl)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.VitalSignOverviewToolStrip)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.VitalSignHeaderPanel)
        Me.MainSplitContainer.Size = New System.Drawing.Size(1776, 1104)
        Me.MainSplitContainer.SplitterDistance = 588
        Me.MainSplitContainer.TabIndex = 2
        '
        'VitalSignPanel
        '
        Me.VitalSignPanel.BackColor = System.Drawing.Color.White
        Me.VitalSignPanel.Controls.Add(Me.Label1)
        Me.VitalSignPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.VitalSignPanel.Location = New System.Drawing.Point(0, 0)
        Me.VitalSignPanel.Name = "VitalSignPanel"
        Me.VitalSignPanel.Size = New System.Drawing.Size(588, 49)
        Me.VitalSignPanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ARCN/CAKN Vital Signs"
        '
        'VitalSignTabControl
        '
        Me.VitalSignTabControl.Controls.Add(Me.OverviewTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.ProtocolsTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.ObjectivesTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.DataManagementMilestonesTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.DataManagementOverviewTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.TasksTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.VSWorkLogTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.SitesTabPage)
        Me.VitalSignTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VitalSignTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitalSignTabControl.Location = New System.Drawing.Point(0, 81)
        Me.VitalSignTabControl.Name = "VitalSignTabControl"
        Me.VitalSignTabControl.SelectedIndex = 0
        Me.VitalSignTabControl.Size = New System.Drawing.Size(1184, 1023)
        Me.VitalSignTabControl.TabIndex = 0
        '
        'OverviewTabPage
        '
        Me.OverviewTabPage.Controls.Add(Me.TblVitalSignsGridEX)
        Me.OverviewTabPage.Location = New System.Drawing.Point(4, 34)
        Me.OverviewTabPage.Name = "OverviewTabPage"
        Me.OverviewTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.OverviewTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.OverviewTabPage.TabIndex = 0
        Me.OverviewTabPage.Text = "Overview"
        Me.OverviewTabPage.UseVisualStyleBackColor = True
        '
        'TblVitalSignsGridEX
        '
        Me.TblVitalSignsGridEX.CardWidth = 1142
        Me.TblVitalSignsGridEX.DataSource = Me.TblVitalSignsBindingSource
        TblVitalSignsGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignsGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignsGridEX.DesignTimeLayout = TblVitalSignsGridEX_DesignTimeLayout
        Me.TblVitalSignsGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignsGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TblVitalSignsGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignsGridEX.Name = "TblVitalSignsGridEX"
        Me.TblVitalSignsGridEX.Size = New System.Drawing.Size(1170, 979)
        Me.TblVitalSignsGridEX.TabIndex = 0
        Me.TblVitalSignsGridEX.View = Janus.Windows.GridEX.View.SingleCard
        '
        'TblVitalSignsBindingSource
        '
        Me.TblVitalSignsBindingSource.DataMember = "vwVitalSignOverview_tblVitalSigns"
        Me.TblVitalSignsBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'ProtocolsTabPage
        '
        Me.ProtocolsTabPage.Controls.Add(Me.ProtocolTabControl)
        Me.ProtocolsTabPage.Controls.Add(Me.TblVitalSignProtocolsGridEX)
        Me.ProtocolsTabPage.Controls.Add(Me.ToolStrip2)
        Me.ProtocolsTabPage.Location = New System.Drawing.Point(4, 34)
        Me.ProtocolsTabPage.Name = "ProtocolsTabPage"
        Me.ProtocolsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProtocolsTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.ProtocolsTabPage.TabIndex = 2
        Me.ProtocolsTabPage.Text = "Protocols, deliverables and remeasurements"
        Me.ProtocolsTabPage.UseVisualStyleBackColor = True
        '
        'ProtocolTabControl
        '
        Me.ProtocolTabControl.Controls.Add(Me.DeliverablesTabPage)
        Me.ProtocolTabControl.Controls.Add(Me.RemeasurementsTabPage)
        Me.ProtocolTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProtocolTabControl.Location = New System.Drawing.Point(3, 402)
        Me.ProtocolTabControl.Name = "ProtocolTabControl"
        Me.ProtocolTabControl.SelectedIndex = 0
        Me.ProtocolTabControl.Size = New System.Drawing.Size(1170, 580)
        Me.ProtocolTabControl.TabIndex = 1
        '
        'DeliverablesTabPage
        '
        Me.DeliverablesTabPage.Controls.Add(Me.ProtocolDeliverablesSplitContainer)
        Me.DeliverablesTabPage.Location = New System.Drawing.Point(4, 34)
        Me.DeliverablesTabPage.Name = "DeliverablesTabPage"
        Me.DeliverablesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DeliverablesTabPage.Size = New System.Drawing.Size(1162, 542)
        Me.DeliverablesTabPage.TabIndex = 0
        Me.DeliverablesTabPage.Text = "Deliverables schedule"
        Me.DeliverablesTabPage.UseVisualStyleBackColor = True
        '
        'ProtocolDeliverablesSplitContainer
        '
        Me.ProtocolDeliverablesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProtocolDeliverablesSplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.ProtocolDeliverablesSplitContainer.Name = "ProtocolDeliverablesSplitContainer"
        '
        'ProtocolDeliverablesSplitContainer.Panel1
        '
        Me.ProtocolDeliverablesSplitContainer.Panel1.AutoScroll = True
        Me.ProtocolDeliverablesSplitContainer.Panel1.Controls.Add(Me.TblProtocolDeliverablesGridEX)
        '
        'ProtocolDeliverablesSplitContainer.Panel2
        '
        Me.ProtocolDeliverablesSplitContainer.Panel2.Controls.Add(Me.ProtocolDeliverablesCardViewGridEX)
        Me.ProtocolDeliverablesSplitContainer.Size = New System.Drawing.Size(1156, 536)
        Me.ProtocolDeliverablesSplitContainer.SplitterDistance = 385
        Me.ProtocolDeliverablesSplitContainer.TabIndex = 2
        '
        'TblProtocolDeliverablesGridEX
        '
        Me.TblProtocolDeliverablesGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblProtocolDeliverablesGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblProtocolDeliverablesGridEX.DataSource = Me.TblProtocolDeliverablesBindingSource
        TblProtocolDeliverablesGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblProtocolDeliverablesGridEX_DesignTimeLayout.LayoutString")
        Me.TblProtocolDeliverablesGridEX.DesignTimeLayout = TblProtocolDeliverablesGridEX_DesignTimeLayout
        Me.TblProtocolDeliverablesGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblProtocolDeliverablesGridEX.GroupByBoxVisible = False
        Me.TblProtocolDeliverablesGridEX.Location = New System.Drawing.Point(0, 0)
        Me.TblProtocolDeliverablesGridEX.Name = "TblProtocolDeliverablesGridEX"
        Me.TblProtocolDeliverablesGridEX.Size = New System.Drawing.Size(385, 536)
        Me.TblProtocolDeliverablesGridEX.TabIndex = 0
        '
        'TblProtocolDeliverablesBindingSource
        '
        Me.TblProtocolDeliverablesBindingSource.DataMember = "FK_tblProtocolDeliverables_tblVitalSignProtocols"
        Me.TblProtocolDeliverablesBindingSource.DataSource = Me.TblVitalSignProtocolsBindingSource
        '
        'TblVitalSignProtocolsBindingSource
        '
        Me.TblVitalSignProtocolsBindingSource.DataMember = "FK_tblVitalSignProtocols_tblVitalSigns"
        Me.TblVitalSignProtocolsBindingSource.DataSource = Me.TblVitalSignsBindingSource
        '
        'ProtocolDeliverablesCardViewGridEX
        '
        Me.ProtocolDeliverablesCardViewGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ProtocolDeliverablesCardViewGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ProtocolDeliverablesCardViewGridEX.AlternatingColors = True
        Me.ProtocolDeliverablesCardViewGridEX.CardWidth = 713
        Me.ProtocolDeliverablesCardViewGridEX.DataSource = Me.TblProtocolDeliverablesBindingSource
        ProtocolDeliverablesCardViewGridEX_DesignTimeLayout.LayoutString = resources.GetString("ProtocolDeliverablesCardViewGridEX_DesignTimeLayout.LayoutString")
        Me.ProtocolDeliverablesCardViewGridEX.DesignTimeLayout = ProtocolDeliverablesCardViewGridEX_DesignTimeLayout
        Me.ProtocolDeliverablesCardViewGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProtocolDeliverablesCardViewGridEX.GroupByBoxVisible = False
        Me.ProtocolDeliverablesCardViewGridEX.Location = New System.Drawing.Point(0, 0)
        Me.ProtocolDeliverablesCardViewGridEX.Name = "ProtocolDeliverablesCardViewGridEX"
        Me.ProtocolDeliverablesCardViewGridEX.Size = New System.Drawing.Size(767, 536)
        Me.ProtocolDeliverablesCardViewGridEX.TabIndex = 0
        Me.ProtocolDeliverablesCardViewGridEX.View = Janus.Windows.GridEX.View.SingleCard
        '
        'RemeasurementsTabPage
        '
        Me.RemeasurementsTabPage.Controls.Add(Me.TblProtocolRemeasurementsGridEX)
        Me.RemeasurementsTabPage.Location = New System.Drawing.Point(4, 34)
        Me.RemeasurementsTabPage.Name = "RemeasurementsTabPage"
        Me.RemeasurementsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.RemeasurementsTabPage.Size = New System.Drawing.Size(1162, 542)
        Me.RemeasurementsTabPage.TabIndex = 1
        Me.RemeasurementsTabPage.Text = "Remeasurements"
        Me.RemeasurementsTabPage.UseVisualStyleBackColor = True
        '
        'TblProtocolRemeasurementsGridEX
        '
        Me.TblProtocolRemeasurementsGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblProtocolRemeasurementsGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblProtocolRemeasurementsGridEX.DataSource = Me.TblProtocolRemeasurementsBindingSource
        TblProtocolRemeasurementsGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblProtocolRemeasurementsGridEX_DesignTimeLayout.LayoutString")
        Me.TblProtocolRemeasurementsGridEX.DesignTimeLayout = TblProtocolRemeasurementsGridEX_DesignTimeLayout
        Me.TblProtocolRemeasurementsGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblProtocolRemeasurementsGridEX.GroupByBoxVisible = False
        Me.TblProtocolRemeasurementsGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblProtocolRemeasurementsGridEX.Name = "TblProtocolRemeasurementsGridEX"
        Me.TblProtocolRemeasurementsGridEX.Size = New System.Drawing.Size(1156, 536)
        Me.TblProtocolRemeasurementsGridEX.TabIndex = 0
        '
        'TblProtocolRemeasurementsBindingSource
        '
        Me.TblProtocolRemeasurementsBindingSource.DataMember = "FK_tblVitalSignRemeasurements_tblVitalSignProtocols"
        Me.TblProtocolRemeasurementsBindingSource.DataSource = Me.TblVitalSignProtocolsBindingSource
        '
        'TblVitalSignProtocolsGridEX
        '
        Me.TblVitalSignProtocolsGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignProtocolsGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignProtocolsGridEX.DataSource = Me.TblVitalSignProtocolsBindingSource
        TblVitalSignProtocolsGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignProtocolsGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignProtocolsGridEX.DesignTimeLayout = TblVitalSignProtocolsGridEX_DesignTimeLayout
        Me.TblVitalSignProtocolsGridEX.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblVitalSignProtocolsGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblVitalSignProtocolsGridEX.GroupByBoxVisible = False
        Me.TblVitalSignProtocolsGridEX.Hierarchical = True
        Me.TblVitalSignProtocolsGridEX.Location = New System.Drawing.Point(3, 35)
        Me.TblVitalSignProtocolsGridEX.Name = "TblVitalSignProtocolsGridEX"
        Me.TblVitalSignProtocolsGridEX.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.TblVitalSignProtocolsGridEX.RecordNavigator = True
        Me.TblVitalSignProtocolsGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignProtocolsGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.TblVitalSignProtocolsGridEX.Size = New System.Drawing.Size(1170, 367)
        Me.TblVitalSignProtocolsGridEX.TabIndex = 0
        Me.TblVitalSignProtocolsGridEX.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[Default]
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateDeliverablesDirectoriesCreationScriptButton, Me.ToolStripSeparator4, Me.OpenDeliverablesScheduleFormToolStripButton, Me.ToolStripSeparator5, Me.CreateDeliverablesDirectoriesToolStripButton, Me.ToolStripSeparator6, Me.EditDeliverableToolStripButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(1170, 32)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'GenerateDeliverablesDirectoriesCreationScriptButton
        '
        Me.GenerateDeliverablesDirectoriesCreationScriptButton.Image = CType(resources.GetObject("GenerateDeliverablesDirectoriesCreationScriptButton.Image"), System.Drawing.Image)
        Me.GenerateDeliverablesDirectoriesCreationScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerateDeliverablesDirectoriesCreationScriptButton.Name = "GenerateDeliverablesDirectoriesCreationScriptButton"
        Me.GenerateDeliverablesDirectoriesCreationScriptButton.Size = New System.Drawing.Size(441, 29)
        Me.GenerateDeliverablesDirectoriesCreationScriptButton.Text = "Generate deliverables directories generation script..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'OpenDeliverablesScheduleFormToolStripButton
        '
        Me.OpenDeliverablesScheduleFormToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenDeliverablesScheduleFormToolStripButton.Image = CType(resources.GetObject("OpenDeliverablesScheduleFormToolStripButton.Image"), System.Drawing.Image)
        Me.OpenDeliverablesScheduleFormToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenDeliverablesScheduleFormToolStripButton.Name = "OpenDeliverablesScheduleFormToolStripButton"
        Me.OpenDeliverablesScheduleFormToolStripButton.Size = New System.Drawing.Size(197, 29)
        Me.OpenDeliverablesScheduleFormToolStripButton.Text = "Deliverables schedule..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'CreateDeliverablesDirectoriesToolStripButton
        '
        Me.CreateDeliverablesDirectoriesToolStripButton.Image = CType(resources.GetObject("CreateDeliverablesDirectoriesToolStripButton.Image"), System.Drawing.Image)
        Me.CreateDeliverablesDirectoriesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CreateDeliverablesDirectoriesToolStripButton.Name = "CreateDeliverablesDirectoriesToolStripButton"
        Me.CreateDeliverablesDirectoriesToolStripButton.Size = New System.Drawing.Size(283, 29)
        Me.CreateDeliverablesDirectoriesToolStripButton.Text = "Create deliverables directories..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'EditDeliverableToolStripButton
        '
        Me.EditDeliverableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditDeliverableToolStripButton.Enabled = False
        Me.EditDeliverableToolStripButton.Image = CType(resources.GetObject("EditDeliverableToolStripButton.Image"), System.Drawing.Image)
        Me.EditDeliverableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditDeliverableToolStripButton.Name = "EditDeliverableToolStripButton"
        Me.EditDeliverableToolStripButton.Size = New System.Drawing.Size(196, 29)
        Me.EditDeliverableToolStripButton.Text = "Edit current deliverable"
        '
        'ObjectivesTabPage
        '
        Me.ObjectivesTabPage.AutoScroll = True
        Me.ObjectivesTabPage.Controls.Add(Me.TblVitalSignObjectivesDataGridView)
        Me.ObjectivesTabPage.Controls.Add(Me.tblVitalSignObjectivesBindingNavigator)
        Me.ObjectivesTabPage.Location = New System.Drawing.Point(4, 34)
        Me.ObjectivesTabPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ObjectivesTabPage.Name = "ObjectivesTabPage"
        Me.ObjectivesTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.ObjectivesTabPage.TabIndex = 5
        Me.ObjectivesTabPage.Text = "Objectives"
        Me.ObjectivesTabPage.UseVisualStyleBackColor = True
        '
        'TblVitalSignObjectivesDataGridView
        '
        Me.TblVitalSignObjectivesDataGridView.AllowUserToOrderColumns = True
        Me.TblVitalSignObjectivesDataGridView.AutoGenerateColumns = False
        Me.TblVitalSignObjectivesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblVitalSignObjectivesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TblVitalSignObjectivesDataGridView.DataSource = Me.TblVitalSignObjectivesBindingSource
        Me.TblVitalSignObjectivesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignObjectivesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblVitalSignObjectivesDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TblVitalSignObjectivesDataGridView.Name = "TblVitalSignObjectivesDataGridView"
        Me.TblVitalSignObjectivesDataGridView.Size = New System.Drawing.Size(1176, 954)
        Me.TblVitalSignObjectivesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Objective"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Objective"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 300
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 600
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VSObjectiveID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VSObjectiveID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "VSID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "VSID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TblVitalSignObjectivesBindingSource
        '
        Me.TblVitalSignObjectivesBindingSource.DataMember = "vwVitalSignOverview_tblVitalSignObjectives"
        Me.TblVitalSignObjectivesBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'tblVitalSignObjectivesBindingNavigator
        '
        Me.tblVitalSignObjectivesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.tblVitalSignObjectivesBindingNavigator.BindingSource = Me.TblVitalSignObjectivesBindingSource
        Me.tblVitalSignObjectivesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.tblVitalSignObjectivesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.tblVitalSignObjectivesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblVitalSignObjectivesBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tblVitalSignObjectivesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.tblVitalSignObjectivesBindingNavigator.Location = New System.Drawing.Point(0, 954)
        Me.tblVitalSignObjectivesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.tblVitalSignObjectivesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.tblVitalSignObjectivesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.tblVitalSignObjectivesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.tblVitalSignObjectivesBindingNavigator.Name = "tblVitalSignObjectivesBindingNavigator"
        Me.tblVitalSignObjectivesBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.tblVitalSignObjectivesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.tblVitalSignObjectivesBindingNavigator.Size = New System.Drawing.Size(1176, 31)
        Me.tblVitalSignObjectivesBindingNavigator.TabIndex = 1
        Me.tblVitalSignObjectivesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'DataManagementMilestonesTabPage
        '
        Me.DataManagementMilestonesTabPage.AutoScroll = True
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.OpenDataDirectoryButton)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.OpenProtocolDirectoryButton)
        Me.DataManagementMilestonesTabPage.Controls.Add(ProtocolAvailableLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.ProtocolAvailableCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(DataAvailableLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.DataAvailableCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(DeliverablesScheduleLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.DeliverablesScheduleCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(SOPsWrittenLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.SOPsWrittenCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(DMChapterWrittenLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.DMChapterWrittenCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(DMSystemPlanExistsLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.DMSystemPlanExistsCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(DMSystemBuiltLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.DMSystemBuiltCheckBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(ProtocolDirectoryLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.ProtocolDirectoryTextBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(DataDirectoryLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.DataDirectoryTextBox)
        Me.DataManagementMilestonesTabPage.Controls.Add(CurrentStatusLabel)
        Me.DataManagementMilestonesTabPage.Controls.Add(Me.CurrentStatusTextBox)
        Me.DataManagementMilestonesTabPage.Location = New System.Drawing.Point(4, 34)
        Me.DataManagementMilestonesTabPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataManagementMilestonesTabPage.Name = "DataManagementMilestonesTabPage"
        Me.DataManagementMilestonesTabPage.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataManagementMilestonesTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.DataManagementMilestonesTabPage.TabIndex = 6
        Me.DataManagementMilestonesTabPage.Text = "Data management milestones"
        Me.DataManagementMilestonesTabPage.UseVisualStyleBackColor = True
        '
        'OpenDataDirectoryButton
        '
        Me.OpenDataDirectoryButton.Location = New System.Drawing.Point(1047, 402)
        Me.OpenDataDirectoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpenDataDirectoryButton.Name = "OpenDataDirectoryButton"
        Me.OpenDataDirectoryButton.Size = New System.Drawing.Size(112, 35)
        Me.OpenDataDirectoryButton.TabIndex = 21
        Me.OpenDataDirectoryButton.Text = "Open..."
        Me.OpenDataDirectoryButton.UseVisualStyleBackColor = True
        '
        'OpenProtocolDirectoryButton
        '
        Me.OpenProtocolDirectoryButton.Location = New System.Drawing.Point(1047, 362)
        Me.OpenProtocolDirectoryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpenProtocolDirectoryButton.Name = "OpenProtocolDirectoryButton"
        Me.OpenProtocolDirectoryButton.Size = New System.Drawing.Size(112, 35)
        Me.OpenProtocolDirectoryButton.TabIndex = 20
        Me.OpenProtocolDirectoryButton.Text = "Open..."
        Me.OpenProtocolDirectoryButton.UseVisualStyleBackColor = True
        '
        'ProtocolAvailableCheckBox
        '
        Me.ProtocolAvailableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "ProtocolAvailable", True))
        Me.ProtocolAvailableCheckBox.Location = New System.Drawing.Point(320, 46)
        Me.ProtocolAvailableCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProtocolAvailableCheckBox.Name = "ProtocolAvailableCheckBox"
        Me.ProtocolAvailableCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.ProtocolAvailableCheckBox.TabIndex = 1
        Me.ProtocolAvailableCheckBox.UseVisualStyleBackColor = True
        '
        'DataManagementMilestonesBindingSource
        '
        Me.DataManagementMilestonesBindingSource.DataMember = "FK_DataManagementMilestones_tblVitalSigns"
        Me.DataManagementMilestonesBindingSource.DataSource = Me.TblVitalSignsBindingSource
        '
        'DataAvailableCheckBox
        '
        Me.DataAvailableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "DataAvailable", True))
        Me.DataAvailableCheckBox.Location = New System.Drawing.Point(320, 92)
        Me.DataAvailableCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataAvailableCheckBox.Name = "DataAvailableCheckBox"
        Me.DataAvailableCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.DataAvailableCheckBox.TabIndex = 3
        Me.DataAvailableCheckBox.UseVisualStyleBackColor = True
        '
        'DeliverablesScheduleCheckBox
        '
        Me.DeliverablesScheduleCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "DeliverablesSchedule", True))
        Me.DeliverablesScheduleCheckBox.Location = New System.Drawing.Point(320, 134)
        Me.DeliverablesScheduleCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeliverablesScheduleCheckBox.Name = "DeliverablesScheduleCheckBox"
        Me.DeliverablesScheduleCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.DeliverablesScheduleCheckBox.TabIndex = 5
        Me.DeliverablesScheduleCheckBox.UseVisualStyleBackColor = True
        '
        'SOPsWrittenCheckBox
        '
        Me.SOPsWrittenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "SOPsWritten", True))
        Me.SOPsWrittenCheckBox.Location = New System.Drawing.Point(320, 180)
        Me.SOPsWrittenCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SOPsWrittenCheckBox.Name = "SOPsWrittenCheckBox"
        Me.SOPsWrittenCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.SOPsWrittenCheckBox.TabIndex = 7
        Me.SOPsWrittenCheckBox.UseVisualStyleBackColor = True
        '
        'DMChapterWrittenCheckBox
        '
        Me.DMChapterWrittenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "DMChapterWritten", True))
        Me.DMChapterWrittenCheckBox.Location = New System.Drawing.Point(320, 223)
        Me.DMChapterWrittenCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DMChapterWrittenCheckBox.Name = "DMChapterWrittenCheckBox"
        Me.DMChapterWrittenCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.DMChapterWrittenCheckBox.TabIndex = 9
        Me.DMChapterWrittenCheckBox.UseVisualStyleBackColor = True
        '
        'DMSystemPlanExistsCheckBox
        '
        Me.DMSystemPlanExistsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "DMSystemPlanExists", True))
        Me.DMSystemPlanExistsCheckBox.Location = New System.Drawing.Point(320, 269)
        Me.DMSystemPlanExistsCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DMSystemPlanExistsCheckBox.Name = "DMSystemPlanExistsCheckBox"
        Me.DMSystemPlanExistsCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.DMSystemPlanExistsCheckBox.TabIndex = 11
        Me.DMSystemPlanExistsCheckBox.UseVisualStyleBackColor = True
        '
        'DMSystemBuiltCheckBox
        '
        Me.DMSystemBuiltCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataManagementMilestonesBindingSource, "DMSystemBuilt", True))
        Me.DMSystemBuiltCheckBox.Location = New System.Drawing.Point(320, 315)
        Me.DMSystemBuiltCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DMSystemBuiltCheckBox.Name = "DMSystemBuiltCheckBox"
        Me.DMSystemBuiltCheckBox.Size = New System.Drawing.Size(156, 37)
        Me.DMSystemBuiltCheckBox.TabIndex = 13
        Me.DMSystemBuiltCheckBox.UseVisualStyleBackColor = True
        '
        'ProtocolDirectoryTextBox
        '
        Me.ProtocolDirectoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataManagementMilestonesBindingSource, "ProtocolDirectory", True))
        Me.ProtocolDirectoryTextBox.Location = New System.Drawing.Point(266, 362)
        Me.ProtocolDirectoryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProtocolDirectoryTextBox.Name = "ProtocolDirectoryTextBox"
        Me.ProtocolDirectoryTextBox.Size = New System.Drawing.Size(770, 30)
        Me.ProtocolDirectoryTextBox.TabIndex = 15
        '
        'DataDirectoryTextBox
        '
        Me.DataDirectoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataManagementMilestonesBindingSource, "DataDirectory", True))
        Me.DataDirectoryTextBox.Location = New System.Drawing.Point(266, 402)
        Me.DataDirectoryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataDirectoryTextBox.Name = "DataDirectoryTextBox"
        Me.DataDirectoryTextBox.Size = New System.Drawing.Size(770, 30)
        Me.DataDirectoryTextBox.TabIndex = 17
        '
        'CurrentStatusTextBox
        '
        Me.CurrentStatusTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataManagementMilestonesBindingSource, "CurrentStatus", True))
        Me.CurrentStatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentStatusTextBox.Location = New System.Drawing.Point(266, 442)
        Me.CurrentStatusTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CurrentStatusTextBox.Multiline = True
        Me.CurrentStatusTextBox.Name = "CurrentStatusTextBox"
        Me.CurrentStatusTextBox.Size = New System.Drawing.Size(892, 501)
        Me.CurrentStatusTextBox.TabIndex = 19
        '
        'DataManagementOverviewTabPage
        '
        Me.DataManagementOverviewTabPage.Controls.Add(Me.TblVitalSignDataManagementSummaryGridEX)
        Me.DataManagementOverviewTabPage.Location = New System.Drawing.Point(4, 34)
        Me.DataManagementOverviewTabPage.Name = "DataManagementOverviewTabPage"
        Me.DataManagementOverviewTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataManagementOverviewTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.DataManagementOverviewTabPage.TabIndex = 4
        Me.DataManagementOverviewTabPage.Text = "Data management summary"
        Me.DataManagementOverviewTabPage.UseVisualStyleBackColor = True
        '
        'TblVitalSignDataManagementSummaryGridEX
        '
        Me.TblVitalSignDataManagementSummaryGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignDataManagementSummaryGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignDataManagementSummaryGridEX.AlternatingColors = True
        Me.TblVitalSignDataManagementSummaryGridEX.CardBorders = False
        Me.TblVitalSignDataManagementSummaryGridEX.CardHeaders = False
        Me.TblVitalSignDataManagementSummaryGridEX.CardWidth = 742
        Me.TblVitalSignDataManagementSummaryGridEX.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.DiaplayedCells
        Me.TblVitalSignDataManagementSummaryGridEX.DataSource = Me.TblVitalSignDataManagementSummaryBindingSource
        TblVitalSignDataManagementSummaryGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignDataManagementSummaryGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignDataManagementSummaryGridEX.DesignTimeLayout = TblVitalSignDataManagementSummaryGridEX_DesignTimeLayout
        Me.TblVitalSignDataManagementSummaryGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignDataManagementSummaryGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.TblVitalSignDataManagementSummaryGridEX.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TblVitalSignDataManagementSummaryGridEX.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.TblVitalSignDataManagementSummaryGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblVitalSignDataManagementSummaryGridEX.FrozenColumns = -1
        Me.TblVitalSignDataManagementSummaryGridEX.GroupByBoxVisible = False
        Me.TblVitalSignDataManagementSummaryGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignDataManagementSummaryGridEX.Name = "TblVitalSignDataManagementSummaryGridEX"
        Me.TblVitalSignDataManagementSummaryGridEX.RecordNavigator = True
        Me.TblVitalSignDataManagementSummaryGridEX.RowFormatStyle.FontSize = 10.0!
        Me.TblVitalSignDataManagementSummaryGridEX.RowFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TblVitalSignDataManagementSummaryGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignDataManagementSummaryGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.TblVitalSignDataManagementSummaryGridEX.Size = New System.Drawing.Size(1170, 979)
        Me.TblVitalSignDataManagementSummaryGridEX.TabIndex = 0
        Me.TblVitalSignDataManagementSummaryGridEX.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[Default]
        '
        'TblVitalSignDataManagementSummaryBindingSource
        '
        Me.TblVitalSignDataManagementSummaryBindingSource.DataMember = "vwVitalSignOverview_tblVitalSignDataManagementSummary"
        Me.TblVitalSignDataManagementSummaryBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'TasksTabPage
        '
        Me.TasksTabPage.Controls.Add(Me.TblVitalSignTasksGridEX)
        Me.TasksTabPage.Location = New System.Drawing.Point(4, 34)
        Me.TasksTabPage.Name = "TasksTabPage"
        Me.TasksTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TasksTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.TasksTabPage.TabIndex = 3
        Me.TasksTabPage.Text = "Tasks"
        Me.TasksTabPage.UseVisualStyleBackColor = True
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
        Me.TblVitalSignTasksGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
        Me.TblVitalSignTasksGridEX.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TblVitalSignTasksGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignTasksGridEX.Name = "TblVitalSignTasksGridEX"
        Me.TblVitalSignTasksGridEX.RecordNavigator = True
        Me.TblVitalSignTasksGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignTasksGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.TblVitalSignTasksGridEX.Size = New System.Drawing.Size(1170, 979)
        Me.TblVitalSignTasksGridEX.TabIndex = 0
        '
        'TblVitalSignTasksBindingSource
        '
        Me.TblVitalSignTasksBindingSource.DataMember = "vwVitalSignOverview_tblVitalSignTasks"
        Me.TblVitalSignTasksBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'VSWorkLogTabPage
        '
        Me.VSWorkLogTabPage.Controls.Add(Me.WorkLogSplitContainer)
        Me.VSWorkLogTabPage.Controls.Add(Me.WorkLogToolStrip)
        Me.VSWorkLogTabPage.Controls.Add(Me.WorkLogTabControl)
        Me.VSWorkLogTabPage.Location = New System.Drawing.Point(4, 34)
        Me.VSWorkLogTabPage.Name = "VSWorkLogTabPage"
        Me.VSWorkLogTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VSWorkLogTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.VSWorkLogTabPage.TabIndex = 1
        Me.VSWorkLogTabPage.Text = "Work log"
        Me.VSWorkLogTabPage.UseVisualStyleBackColor = True
        '
        'WorkLogSplitContainer
        '
        Me.WorkLogSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkLogSplitContainer.Location = New System.Drawing.Point(3, 35)
        Me.WorkLogSplitContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WorkLogSplitContainer.Name = "WorkLogSplitContainer"
        '
        'WorkLogSplitContainer.Panel1
        '
        Me.WorkLogSplitContainer.Panel1.AutoScroll = True
        Me.WorkLogSplitContainer.Panel1.Controls.Add(Me.TblVitalSignWorkLogGridEX)
        '
        'WorkLogSplitContainer.Panel2
        '
        Me.WorkLogSplitContainer.Panel2.Controls.Add(Me.LogEntryRichTextBox)
        Me.WorkLogSplitContainer.Size = New System.Drawing.Size(1170, 947)
        Me.WorkLogSplitContainer.SplitterDistance = 327
        Me.WorkLogSplitContainer.SplitterWidth = 6
        Me.WorkLogSplitContainer.TabIndex = 2
        '
        'TblVitalSignWorkLogGridEX
        '
        Me.TblVitalSignWorkLogGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignWorkLogGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignWorkLogGridEX.AlternatingColors = True
        Me.TblVitalSignWorkLogGridEX.DataSource = Me.TblVitalSignWorkLogBindingSource
        TblVitalSignWorkLogGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignWorkLogGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignWorkLogGridEX.DesignTimeLayout = TblVitalSignWorkLogGridEX_DesignTimeLayout
        Me.TblVitalSignWorkLogGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignWorkLogGridEX.GroupByBoxVisible = False
        Me.TblVitalSignWorkLogGridEX.Location = New System.Drawing.Point(0, 0)
        Me.TblVitalSignWorkLogGridEX.Name = "TblVitalSignWorkLogGridEX"
        Me.TblVitalSignWorkLogGridEX.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.TblVitalSignWorkLogGridEX.RecordNavigator = True
        Me.TblVitalSignWorkLogGridEX.Size = New System.Drawing.Size(327, 947)
        Me.TblVitalSignWorkLogGridEX.TabIndex = 1
        Me.TblVitalSignWorkLogGridEX.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        '
        'TblVitalSignWorkLogBindingSource
        '
        Me.TblVitalSignWorkLogBindingSource.DataMember = "FK_tblVitalSignDataManagementLog_tblVitalSigns"
        Me.TblVitalSignWorkLogBindingSource.DataSource = Me.TblVitalSignsBindingSource
        Me.TblVitalSignWorkLogBindingSource.Sort = "LogDate DESC"
        '
        'LogEntryRichTextBox
        '
        Me.LogEntryRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVitalSignWorkLogBindingSource, "LogEntry", True))
        Me.LogEntryRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogEntryRichTextBox.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogEntryRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.LogEntryRichTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LogEntryRichTextBox.Name = "LogEntryRichTextBox"
        Me.LogEntryRichTextBox.Size = New System.Drawing.Size(837, 947)
        Me.LogEntryRichTextBox.TabIndex = 0
        Me.LogEntryRichTextBox.Text = ""
        '
        'WorkLogToolStrip
        '
        Me.WorkLogToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.WorkLogToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditLogEntryToolStripButton, Me.ToolStripSeparator9, Me.WorkLogFontToolStripButton, Me.ToolStripSeparator10, Me.WorkLogReportToolStripButton})
        Me.WorkLogToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.WorkLogToolStrip.Name = "WorkLogToolStrip"
        Me.WorkLogToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.WorkLogToolStrip.Size = New System.Drawing.Size(1170, 32)
        Me.WorkLogToolStrip.TabIndex = 1
        Me.WorkLogToolStrip.Text = "ToolStrip1"
        '
        'EditLogEntryToolStripButton
        '
        Me.EditLogEntryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditLogEntryToolStripButton.Image = CType(resources.GetObject("EditLogEntryToolStripButton.Image"), System.Drawing.Image)
        Me.EditLogEntryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditLogEntryToolStripButton.Name = "EditLogEntryToolStripButton"
        Me.EditLogEntryToolStripButton.Size = New System.Drawing.Size(134, 29)
        Me.EditLogEntryToolStripButton.Text = "Edit log entry..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 32)
        '
        'WorkLogFontToolStripButton
        '
        Me.WorkLogFontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.WorkLogFontToolStripButton.Image = CType(resources.GetObject("WorkLogFontToolStripButton.Image"), System.Drawing.Image)
        Me.WorkLogFontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WorkLogFontToolStripButton.Name = "WorkLogFontToolStripButton"
        Me.WorkLogFontToolStripButton.Size = New System.Drawing.Size(64, 29)
        Me.WorkLogFontToolStripButton.Text = "Font..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 32)
        '
        'WorkLogReportToolStripButton
        '
        Me.WorkLogReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.WorkLogReportToolStripButton.Image = CType(resources.GetObject("WorkLogReportToolStripButton.Image"), System.Drawing.Image)
        Me.WorkLogReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WorkLogReportToolStripButton.Name = "WorkLogReportToolStripButton"
        Me.WorkLogReportToolStripButton.Size = New System.Drawing.Size(155, 29)
        Me.WorkLogReportToolStripButton.Text = "Work log report..."
        '
        'WorkLogTabControl
        '
        Me.WorkLogTabControl.Controls.Add(Me.WorkLogEditorTabPage)
        Me.WorkLogTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkLogTabControl.Location = New System.Drawing.Point(3, 3)
        Me.WorkLogTabControl.Name = "WorkLogTabControl"
        Me.WorkLogTabControl.SelectedIndex = 0
        Me.WorkLogTabControl.Size = New System.Drawing.Size(1170, 979)
        Me.WorkLogTabControl.TabIndex = 2
        '
        'WorkLogEditorTabPage
        '
        Me.WorkLogEditorTabPage.Location = New System.Drawing.Point(4, 34)
        Me.WorkLogEditorTabPage.Name = "WorkLogEditorTabPage"
        Me.WorkLogEditorTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.WorkLogEditorTabPage.Size = New System.Drawing.Size(1162, 941)
        Me.WorkLogEditorTabPage.TabIndex = 1
        Me.WorkLogEditorTabPage.Text = "Edit work log"
        Me.WorkLogEditorTabPage.UseVisualStyleBackColor = True
        '
        'SitesTabPage
        '
        Me.SitesTabPage.Location = New System.Drawing.Point(4, 34)
        Me.SitesTabPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SitesTabPage.Name = "SitesTabPage"
        Me.SitesTabPage.Size = New System.Drawing.Size(1176, 985)
        Me.SitesTabPage.TabIndex = 7
        Me.SitesTabPage.Text = "Sites"
        Me.SitesTabPage.UseVisualStyleBackColor = True
        '
        'VitalSignOverviewToolStrip
        '
        Me.VitalSignOverviewToolStrip.BackColor = System.Drawing.Color.White
        Me.VitalSignOverviewToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VitalSignOverviewToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenProjectDirectoryToolStripButton, Me.ToolStripSeparator2, Me.OpenWebProfileToolStripButton, Me.ToolStripSeparator3, Me.OpenProjectReferenceToolStripButton, Me.ToolStripSeparator7, Me.OpenProtocolTrackerToolStripButton, Me.ToolStripSeparator8, Me.OpenProgramManagerReportServerURLToolStripButton})
        Me.VitalSignOverviewToolStrip.Location = New System.Drawing.Point(0, 49)
        Me.VitalSignOverviewToolStrip.Name = "VitalSignOverviewToolStrip"
        Me.VitalSignOverviewToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.VitalSignOverviewToolStrip.Size = New System.Drawing.Size(1184, 32)
        Me.VitalSignOverviewToolStrip.TabIndex = 1
        Me.VitalSignOverviewToolStrip.Text = "ToolStrip3"
        '
        'OpenProjectDirectoryToolStripButton
        '
        Me.OpenProjectDirectoryToolStripButton.Image = CType(resources.GetObject("OpenProjectDirectoryToolStripButton.Image"), System.Drawing.Image)
        Me.OpenProjectDirectoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenProjectDirectoryToolStripButton.Name = "OpenProjectDirectoryToolStripButton"
        Me.OpenProjectDirectoryToolStripButton.Size = New System.Drawing.Size(215, 29)
        Me.OpenProjectDirectoryToolStripButton.Text = "Open project directory"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'OpenWebProfileToolStripButton
        '
        Me.OpenWebProfileToolStripButton.Image = CType(resources.GetObject("OpenWebProfileToolStripButton.Image"), System.Drawing.Image)
        Me.OpenWebProfileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenWebProfileToolStripButton.Name = "OpenWebProfileToolStripButton"
        Me.OpenWebProfileToolStripButton.Size = New System.Drawing.Size(186, 29)
        Me.OpenWebProfileToolStripButton.Text = "Open web profile..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'OpenProjectReferenceToolStripButton
        '
        Me.OpenProjectReferenceToolStripButton.Image = CType(resources.GetObject("OpenProjectReferenceToolStripButton.Image"), System.Drawing.Image)
        Me.OpenProjectReferenceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenProjectReferenceToolStripButton.Name = "OpenProjectReferenceToolStripButton"
        Me.OpenProjectReferenceToolStripButton.Size = New System.Drawing.Size(239, 29)
        Me.OpenProjectReferenceToolStripButton.Text = "Open Data Store Project..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'OpenProtocolTrackerToolStripButton
        '
        Me.OpenProtocolTrackerToolStripButton.Image = CType(resources.GetObject("OpenProtocolTrackerToolStripButton.Image"), System.Drawing.Image)
        Me.OpenProtocolTrackerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenProtocolTrackerToolStripButton.Name = "OpenProtocolTrackerToolStripButton"
        Me.OpenProtocolTrackerToolStripButton.Size = New System.Drawing.Size(223, 29)
        Me.OpenProtocolTrackerToolStripButton.Text = "Open protocol tracker..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'OpenProgramManagerReportServerURLToolStripButton
        '
        Me.OpenProgramManagerReportServerURLToolStripButton.Image = CType(resources.GetObject("OpenProgramManagerReportServerURLToolStripButton.Image"), System.Drawing.Image)
        Me.OpenProgramManagerReportServerURLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenProgramManagerReportServerURLToolStripButton.Name = "OpenProgramManagerReportServerURLToolStripButton"
        Me.OpenProgramManagerReportServerURLToolStripButton.Size = New System.Drawing.Size(77, 29)
        Me.OpenProgramManagerReportServerURLToolStripButton.Text = "SSRS"
        '
        'VitalSignHeaderPanel
        '
        Me.VitalSignHeaderPanel.BackColor = System.Drawing.Color.White
        Me.VitalSignHeaderPanel.Controls.Add(Me.VitalSignHeaderLabel)
        Me.VitalSignHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.VitalSignHeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.VitalSignHeaderPanel.Name = "VitalSignHeaderPanel"
        Me.VitalSignHeaderPanel.Size = New System.Drawing.Size(1184, 49)
        Me.VitalSignHeaderPanel.TabIndex = 1
        '
        'VitalSignHeaderLabel
        '
        Me.VitalSignHeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VitalSignHeaderLabel.AutoSize = True
        Me.VitalSignHeaderLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitalSignHeaderLabel.Location = New System.Drawing.Point(16, 12)
        Me.VitalSignHeaderLabel.Name = "VitalSignHeaderLabel"
        Me.VitalSignHeaderLabel.Size = New System.Drawing.Size(260, 29)
        Me.VitalSignHeaderLabel.TabIndex = 0
        Me.VitalSignHeaderLabel.Text = "VitalSignHeaderLabel"
        '
        'TblContactsBindingSource
        '
        Me.TblContactsBindingSource.DataMember = "tblContacts"
        Me.TblContactsBindingSource.DataSource = Me.AKRODataSet
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunctionsToolStripMenuItem, Me.ViewsToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MainMenuStrip.Size = New System.Drawing.Size(1776, 35)
        Me.MainMenuStrip.TabIndex = 2
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'FunctionsToolStripMenuItem
        '
        Me.FunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.FunctionsToolStripMenuItem.Name = "FunctionsToolStripMenuItem"
        Me.FunctionsToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.FunctionsToolStripMenuItem.Text = "Functions"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(232, 30)
        Me.SaveToolStripMenuItem.Text = "Save to database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(232, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(232, 30)
        Me.SettingsToolStripMenuItem.Text = "Settings..."
        '
        'ViewsToolStripMenuItem
        '
        Me.ViewsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkTasksToolStripMenuItem, Me.VitalSignTasksToolStripMenuItem, Me.ContactsToolStripMenuItem})
        Me.ViewsToolStripMenuItem.Name = "ViewsToolStripMenuItem"
        Me.ViewsToolStripMenuItem.Size = New System.Drawing.Size(69, 29)
        Me.ViewsToolStripMenuItem.Text = "Views"
        '
        'NetworkTasksToolStripMenuItem
        '
        Me.NetworkTasksToolStripMenuItem.Name = "NetworkTasksToolStripMenuItem"
        Me.NetworkTasksToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.NetworkTasksToolStripMenuItem.Text = "Network tasks..."
        '
        'VitalSignTasksToolStripMenuItem
        '
        Me.VitalSignTasksToolStripMenuItem.Name = "VitalSignTasksToolStripMenuItem"
        Me.VitalSignTasksToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.VitalSignTasksToolStripMenuItem.Text = "Vital Sign tasks..."
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.ContactsToolStripMenuItem.Text = "Contacts..."
        '
        'MainToolStrip
        '
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.RefreshToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 35)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.MainToolStrip.Size = New System.Drawing.Size(1776, 32)
        Me.MainToolStrip.TabIndex = 3
        Me.MainToolStrip.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(172, 29)
        Me.ToolStripButton1.Text = "Save to database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(137, 29)
        Me.RefreshToolStripButton.Text = "Refresh dataset"
        '
        'vwVitalSignWorkLogTableAdapter
        '
        Me.vwVitalSignWorkLogTableAdapter.ClearBeforeFill = True
        '
        'DataManagementMilestonesTableAdapter
        '
        Me.DataManagementMilestonesTableAdapter.ClearBeforeFill = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1776, 1171)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Name = "Form1"
        Me.Text = "Program Manager: NPS Arctic and Central Alaska Inventory and Monitoring Networks"
        CType(Me.vwVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignOverviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignOverviewGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.PerformLayout()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.VitalSignPanel.ResumeLayout(False)
        Me.VitalSignPanel.PerformLayout()
        Me.VitalSignTabControl.ResumeLayout(False)
        Me.OverviewTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignsGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProtocolsTabPage.ResumeLayout(False)
        Me.ProtocolsTabPage.PerformLayout()
        Me.ProtocolTabControl.ResumeLayout(False)
        Me.DeliverablesTabPage.ResumeLayout(False)
        Me.ProtocolDeliverablesSplitContainer.Panel1.ResumeLayout(False)
        Me.ProtocolDeliverablesSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.ProtocolDeliverablesSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProtocolDeliverablesSplitContainer.ResumeLayout(False)
        CType(Me.TblProtocolDeliverablesGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProtocolDeliverablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignProtocolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProtocolDeliverablesCardViewGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RemeasurementsTabPage.ResumeLayout(False)
        CType(Me.TblProtocolRemeasurementsGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProtocolRemeasurementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignProtocolsGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ObjectivesTabPage.ResumeLayout(False)
        Me.ObjectivesTabPage.PerformLayout()
        CType(Me.TblVitalSignObjectivesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignObjectivesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblVitalSignObjectivesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblVitalSignObjectivesBindingNavigator.ResumeLayout(False)
        Me.tblVitalSignObjectivesBindingNavigator.PerformLayout()
        Me.DataManagementMilestonesTabPage.ResumeLayout(False)
        Me.DataManagementMilestonesTabPage.PerformLayout()
        CType(Me.DataManagementMilestonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataManagementOverviewTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignDataManagementSummaryGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignDataManagementSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TasksTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignTasksGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VSWorkLogTabPage.ResumeLayout(False)
        Me.VSWorkLogTabPage.PerformLayout()
        Me.WorkLogSplitContainer.Panel1.ResumeLayout(False)
        Me.WorkLogSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.WorkLogSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkLogSplitContainer.ResumeLayout(False)
        CType(Me.TblVitalSignWorkLogGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkLogToolStrip.ResumeLayout(False)
        Me.WorkLogToolStrip.PerformLayout()
        Me.WorkLogTabControl.ResumeLayout(False)
        Me.VitalSignOverviewToolStrip.ResumeLayout(False)
        Me.VitalSignOverviewToolStrip.PerformLayout()
        Me.VitalSignHeaderPanel.ResumeLayout(False)
        Me.VitalSignHeaderPanel.PerformLayout()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        CType(Me.VwContactsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AKRODataSet As AKRODataSet
    Friend WithEvents VwVitalSignOverviewBindingSource As BindingSource
    Friend WithEvents VwVitalSignOverviewTableAdapter As AKRODataSetTableAdapters.vwVitalSignOverviewTableAdapter
    Friend WithEvents TableAdapterManager As AKRODataSetTableAdapters.TableAdapterManager
    Friend WithEvents VwVitalSignOverviewGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents TblVitalSignsTableAdapter As AKRODataSetTableAdapters.tblVitalSignsTableAdapter
    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents VitalSignTabControl As TabControl
    Friend WithEvents OverviewTabPage As TabPage
    Friend WithEvents VSWorkLogTabPage As TabPage
    Friend WithEvents TblVitalSignsBindingSource As BindingSource
    Friend WithEvents TblVitalSignsGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents VitalSignHeaderPanel As Panel
    Friend WithEvents VitalSignHeaderLabel As Label
    Friend WithEvents TblVitalSignWorkLogTableAdapter As AKRODataSetTableAdapters.tblVitalSignWorkLogTableAdapter
    Friend WithEvents TblVitalSignWorkLogBindingSource As BindingSource
    Friend WithEvents ProtocolsTabPage As TabPage
    Friend WithEvents TblVitalSignProtocolsBindingSource As BindingSource
    Friend WithEvents TblVitalSignProtocolsTableAdapter As AKRODataSetTableAdapters.tblVitalSignProtocolsTableAdapter
    Friend WithEvents TblVitalSignProtocolsGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents TasksTabPage As TabPage
    Friend WithEvents TblProtocolDeliverablesBindingSource As BindingSource
    Friend WithEvents TblProtocolDeliverablesTableAdapter As AKRODataSetTableAdapters.tblProtocolDeliverablesTableAdapter
    Friend WithEvents TblProtocolRemeasurementsBindingSource As BindingSource
    Friend WithEvents TblProtocolRemeasurementsTableAdapter As AKRODataSetTableAdapters.tblProtocolRemeasurementsTableAdapter
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents FunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataManagementOverviewTabPage As TabPage
    Friend WithEvents TblVitalSignDataManagementSummaryBindingSource As BindingSource
    Friend WithEvents TblVitalSignDataManagementSummaryTableAdapter As AKRODataSetTableAdapters.tblVitalSignDataManagementSummaryTableAdapter
    Friend WithEvents TblVitalSignDataManagementSummaryGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents TblVitalSignTasksBindingSource As BindingSource
    Friend WithEvents TblVitalSignTasksTableAdapter As AKRODataSetTableAdapters.tblVitalSignTasksTableAdapter
    Friend WithEvents TblVitalSignTasksGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents vwVitalSignWorkLogBindingSource As BindingSource
    Friend WithEvents vwVitalSignWorkLogTableAdapter As AKRODataSetTableAdapters.vwVitalSignWorkLogTableAdapter
    Friend WithEvents WorkLogTabControl As TabControl
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents GenerateDeliverablesDirectoriesCreationScriptButton As ToolStripButton
    Friend WithEvents VitalSignPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RefreshToolStripButton As ToolStripButton
    Friend WithEvents VitalSignOverviewToolStrip As ToolStrip
    Friend WithEvents OpenProjectDirectoryToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents OpenWebProfileToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents OpenProjectReferenceToolStripButton As ToolStripButton
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents OpenDeliverablesScheduleFormToolStripButton As ToolStripButton
    Friend WithEvents WorkLogToolStrip As ToolStrip
    Friend WithEvents EditLogEntryToolStripButton As ToolStripButton
    Friend WithEvents ObjectivesTabPage As TabPage
    Friend WithEvents TblVitalSignObjectivesBindingSource As BindingSource
    Friend WithEvents TblVitalSignObjectivesTableAdapter As AKRODataSetTableAdapters.tblVitalSignObjectivesTableAdapter
    Friend WithEvents TblVitalSignObjectivesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents tblVitalSignObjectivesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblContactsBindingSource As BindingSource
    Friend WithEvents TblContactsTableAdapter As AKRODataSetTableAdapters.tblContactsTableAdapter
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CreateDeliverablesDirectoriesToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents DataManagementMilestonesTabPage As TabPage
    Friend WithEvents ProtocolAvailableCheckBox As CheckBox
    Friend WithEvents DataAvailableCheckBox As CheckBox
    Friend WithEvents DeliverablesScheduleCheckBox As CheckBox
    Friend WithEvents SOPsWrittenCheckBox As CheckBox
    Friend WithEvents DMChapterWrittenCheckBox As CheckBox
    Friend WithEvents DMSystemPlanExistsCheckBox As CheckBox
    Friend WithEvents DMSystemBuiltCheckBox As CheckBox
    Friend WithEvents ProtocolDirectoryTextBox As TextBox
    Friend WithEvents DataDirectoryTextBox As TextBox
    Friend WithEvents CurrentStatusTextBox As TextBox
    Friend WithEvents DataManagementMilestonesBindingSource As BindingSource
    Friend WithEvents DataManagementMilestonesTableAdapter As AKRODataSetTableAdapters.DataManagementMilestonesTableAdapter
    Friend WithEvents OpenDataDirectoryButton As Button
    Friend WithEvents OpenProtocolDirectoryButton As Button
    Friend WithEvents SitesTabPage As TabPage
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents OpenProtocolTrackerToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents OpenProgramManagerReportServerURLToolStripButton As ToolStripButton
    Friend WithEvents ViewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetworkTasksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VitalSignTasksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VwContactsLookupBindingSource As BindingSource
    Friend WithEvents VwContactsLookupTableAdapter As AKRODataSetTableAdapters.vwContactsLookupTableAdapter
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkLogSplitContainer As SplitContainer
    Friend WithEvents LogEntryRichTextBox As RichTextBox
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents WorkLogFontToolStripButton As ToolStripButton
    Friend WithEvents WorkLogEditorTabPage As TabPage
    Friend WithEvents TblVitalSignWorkLogGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents WorkLogReportToolStripButton As ToolStripButton
    Friend WithEvents EditDeliverableToolStripButton As ToolStripButton
    Friend WithEvents ProtocolDeliverablesSplitContainer As SplitContainer
    Friend WithEvents TblProtocolDeliverablesGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents ProtocolDeliverablesCardViewGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents ProtocolTabControl As TabControl
    Friend WithEvents DeliverablesTabPage As TabPage
    Friend WithEvents RemeasurementsTabPage As TabPage
    Friend WithEvents TblProtocolRemeasurementsGridEX As Janus.Windows.GridEX.GridEX
End Class
