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
        Dim VwVitalSignOverviewGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TblVitalSignsGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignWorkLogGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignProtocolsGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignTasksGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim TblVitalSignDataManagementSummaryGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.VwVitalSignOverviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVitalSignOverviewTableAdapter = New IMPM.AKRODataSetTableAdapters.vwVitalSignOverviewTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.TblProtocolDeliverablesTableAdapter = New IMPM.AKRODataSetTableAdapters.tblProtocolDeliverablesTableAdapter()
        Me.TblProtocolRemeasurementsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblProtocolRemeasurementsTableAdapter()
        Me.TblVitalSignDataManagementSummaryTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignDataManagementSummaryTableAdapter()
        Me.TblVitalSignProtocolsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignProtocolsTableAdapter()
        Me.TblVitalSignsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignsTableAdapter()
        Me.TblVitalSignTasksTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignTasksTableAdapter()
        Me.TblVitalSignWorkLogTableAdapter = New IMPM.AKRODataSetTableAdapters.tblVitalSignWorkLogTableAdapter()
        Me.VwVitalSignOverviewGridEX = New Janus.Windows.GridEX.GridEX()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.VitalSignTabControl = New System.Windows.Forms.TabControl()
        Me.OverviewTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignsGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VSWorkLogTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignWorkLogGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignWorkLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProtocolsTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignProtocolsGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignProtocolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignTasksGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataManagementOverviewTabPage = New System.Windows.Forms.TabPage()
        Me.TblVitalSignDataManagementSummaryGridEX = New Janus.Windows.GridEX.GridEX()
        Me.TblVitalSignDataManagementSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VitalSignHeaderLabel = New System.Windows.Forms.Label()
        Me.TblProtocolDeliverablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProtocolRemeasurementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.WorkLogReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vwVitalSignWorkLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vwVitalSignWorkLogTableAdapter = New IMPM.AKRODataSetTableAdapters.vwVitalSignWorkLogTableAdapter()
        Me.WorkLogTabControl = New System.Windows.Forms.TabControl()
        Me.WorkLogReportTabPage = New System.Windows.Forms.TabPage()
        Me.WorkLogEditorTabPage = New System.Windows.Forms.TabPage()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignOverviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignOverviewGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.VitalSignTabControl.SuspendLayout()
        Me.OverviewTabPage.SuspendLayout()
        CType(Me.TblVitalSignsGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VSWorkLogTabPage.SuspendLayout()
        CType(Me.TblVitalSignWorkLogGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProtocolsTabPage.SuspendLayout()
        CType(Me.TblVitalSignProtocolsGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignProtocolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TasksTabPage.SuspendLayout()
        CType(Me.TblVitalSignTasksGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataManagementOverviewTabPage.SuspendLayout()
        CType(Me.TblVitalSignDataManagementSummaryGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVitalSignDataManagementSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblProtocolDeliverablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProtocolRemeasurementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuStrip.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        CType(Me.vwVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkLogTabControl.SuspendLayout()
        Me.WorkLogReportTabPage.SuspendLayout()
        Me.WorkLogEditorTabPage.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.tblNetworksTableAdapter = Nothing
        Me.TableAdapterManager.tblProtocolDeliverablesTableAdapter = Me.TblProtocolDeliverablesTableAdapter
        Me.TableAdapterManager.tblProtocolRemeasurementsTableAdapter = Me.TblProtocolRemeasurementsTableAdapter
        Me.TableAdapterManager.tblVitalSignDataManagementSummaryTableAdapter = Me.TblVitalSignDataManagementSummaryTableAdapter
        Me.TableAdapterManager.tblVitalSignObjectivesTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignProtocolsTableAdapter = Me.TblVitalSignProtocolsTableAdapter
        Me.TableAdapterManager.tblVitalSignsTableAdapter = Me.TblVitalSignsTableAdapter
        Me.TableAdapterManager.tblVitalSignTasksTableAdapter = Me.TblVitalSignTasksTableAdapter
        Me.TableAdapterManager.tblVitalSignWorkLogTableAdapter = Me.TblVitalSignWorkLogTableAdapter
        Me.TableAdapterManager.UpdateOrder = IMPM.AKRODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.VwVitalSignOverviewGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VwVitalSignOverviewGridEX.Location = New System.Drawing.Point(0, 0)
        Me.VwVitalSignOverviewGridEX.Name = "VwVitalSignOverviewGridEX"
        Me.VwVitalSignOverviewGridEX.RecordNavigator = True
        Me.VwVitalSignOverviewGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.VwVitalSignOverviewGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.VwVitalSignOverviewGridEX.SelectOnExpand = False
        Me.VwVitalSignOverviewGridEX.SettingsKey = "VwVitalSignOverviewGridEX"
        Me.VwVitalSignOverviewGridEX.Size = New System.Drawing.Size(394, 698)
        Me.VwVitalSignOverviewGridEX.TabIndex = 1
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 55)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.VwVitalSignOverviewGridEX)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.VitalSignTabControl)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.ToolStrip1)
        Me.MainSplitContainer.Panel2.Controls.Add(Me.Panel1)
        Me.MainSplitContainer.Size = New System.Drawing.Size(1182, 698)
        Me.MainSplitContainer.SplitterDistance = 394
        Me.MainSplitContainer.TabIndex = 2
        '
        'VitalSignTabControl
        '
        Me.VitalSignTabControl.Controls.Add(Me.OverviewTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.VSWorkLogTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.ProtocolsTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.TasksTabPage)
        Me.VitalSignTabControl.Controls.Add(Me.DataManagementOverviewTabPage)
        Me.VitalSignTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VitalSignTabControl.Location = New System.Drawing.Point(0, 65)
        Me.VitalSignTabControl.Name = "VitalSignTabControl"
        Me.VitalSignTabControl.SelectedIndex = 0
        Me.VitalSignTabControl.Size = New System.Drawing.Size(784, 633)
        Me.VitalSignTabControl.TabIndex = 0
        '
        'OverviewTabPage
        '
        Me.OverviewTabPage.Controls.Add(Me.TblVitalSignsGridEX)
        Me.OverviewTabPage.Location = New System.Drawing.Point(4, 25)
        Me.OverviewTabPage.Name = "OverviewTabPage"
        Me.OverviewTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.OverviewTabPage.Size = New System.Drawing.Size(776, 604)
        Me.OverviewTabPage.TabIndex = 0
        Me.OverviewTabPage.Text = "Overview"
        Me.OverviewTabPage.UseVisualStyleBackColor = True
        '
        'TblVitalSignsGridEX
        '
        Me.TblVitalSignsGridEX.CardWidth = 721
        Me.TblVitalSignsGridEX.DataSource = Me.TblVitalSignsBindingSource
        TblVitalSignsGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignsGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignsGridEX.DesignTimeLayout = TblVitalSignsGridEX_DesignTimeLayout
        Me.TblVitalSignsGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignsGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblVitalSignsGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignsGridEX.Name = "TblVitalSignsGridEX"
        Me.TblVitalSignsGridEX.Size = New System.Drawing.Size(770, 598)
        Me.TblVitalSignsGridEX.TabIndex = 0
        Me.TblVitalSignsGridEX.View = Janus.Windows.GridEX.View.SingleCard
        '
        'TblVitalSignsBindingSource
        '
        Me.TblVitalSignsBindingSource.DataMember = "vwVitalSignOverview_tblVitalSigns"
        Me.TblVitalSignsBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'VSWorkLogTabPage
        '
        Me.VSWorkLogTabPage.Controls.Add(Me.WorkLogTabControl)
        Me.VSWorkLogTabPage.Location = New System.Drawing.Point(4, 25)
        Me.VSWorkLogTabPage.Name = "VSWorkLogTabPage"
        Me.VSWorkLogTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VSWorkLogTabPage.Size = New System.Drawing.Size(776, 604)
        Me.VSWorkLogTabPage.TabIndex = 1
        Me.VSWorkLogTabPage.Text = "Work log"
        Me.VSWorkLogTabPage.UseVisualStyleBackColor = True
        '
        'TblVitalSignWorkLogGridEX
        '
        Me.TblVitalSignWorkLogGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignWorkLogGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignWorkLogGridEX.ColumnAutoResize = True
        Me.TblVitalSignWorkLogGridEX.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        Me.TblVitalSignWorkLogGridEX.DataSource = Me.TblVitalSignWorkLogBindingSource
        TblVitalSignWorkLogGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignWorkLogGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignWorkLogGridEX.DesignTimeLayout = TblVitalSignWorkLogGridEX_DesignTimeLayout
        Me.TblVitalSignWorkLogGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignWorkLogGridEX.DynamicFiltering = True
        Me.TblVitalSignWorkLogGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.TblVitalSignWorkLogGridEX.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TblVitalSignWorkLogGridEX.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.TblVitalSignWorkLogGridEX.GroupByBoxVisible = False
        Me.TblVitalSignWorkLogGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignWorkLogGridEX.Name = "TblVitalSignWorkLogGridEX"
        Me.TblVitalSignWorkLogGridEX.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.TblVitalSignWorkLogGridEX.RecordNavigator = True
        Me.TblVitalSignWorkLogGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignWorkLogGridEX.SaveSettings = True
        Me.TblVitalSignWorkLogGridEX.SelectOnExpand = False
        Me.TblVitalSignWorkLogGridEX.SettingsKey = "TblVitalSignWorkLogGridEX"
        Me.TblVitalSignWorkLogGridEX.Size = New System.Drawing.Size(756, 563)
        Me.TblVitalSignWorkLogGridEX.TabIndex = 0
        '
        'TblVitalSignWorkLogBindingSource
        '
        Me.TblVitalSignWorkLogBindingSource.DataMember = "FK_tblVitalSignDataManagementLog_tblVitalSigns"
        Me.TblVitalSignWorkLogBindingSource.DataSource = Me.TblVitalSignsBindingSource
        '
        'ProtocolsTabPage
        '
        Me.ProtocolsTabPage.Controls.Add(Me.TblVitalSignProtocolsGridEX)
        Me.ProtocolsTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ProtocolsTabPage.Name = "ProtocolsTabPage"
        Me.ProtocolsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProtocolsTabPage.Size = New System.Drawing.Size(776, 604)
        Me.ProtocolsTabPage.TabIndex = 2
        Me.ProtocolsTabPage.Text = "Protocols, deliverables and remeasurements"
        Me.ProtocolsTabPage.UseVisualStyleBackColor = True
        '
        'TblVitalSignProtocolsGridEX
        '
        Me.TblVitalSignProtocolsGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignProtocolsGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignProtocolsGridEX.DataSource = Me.TblVitalSignProtocolsBindingSource
        TblVitalSignProtocolsGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblVitalSignProtocolsGridEX_DesignTimeLayout.LayoutString")
        Me.TblVitalSignProtocolsGridEX.DesignTimeLayout = TblVitalSignProtocolsGridEX_DesignTimeLayout
        Me.TblVitalSignProtocolsGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVitalSignProtocolsGridEX.GroupByBoxVisible = False
        Me.TblVitalSignProtocolsGridEX.Hierarchical = True
        Me.TblVitalSignProtocolsGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignProtocolsGridEX.Name = "TblVitalSignProtocolsGridEX"
        Me.TblVitalSignProtocolsGridEX.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.TblVitalSignProtocolsGridEX.RecordNavigator = True
        Me.TblVitalSignProtocolsGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignProtocolsGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.TblVitalSignProtocolsGridEX.Size = New System.Drawing.Size(770, 598)
        Me.TblVitalSignProtocolsGridEX.TabIndex = 0
        Me.TblVitalSignProtocolsGridEX.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[Default]
        '
        'TblVitalSignProtocolsBindingSource
        '
        Me.TblVitalSignProtocolsBindingSource.DataMember = "FK_tblVitalSignProtocols_tblVitalSigns"
        Me.TblVitalSignProtocolsBindingSource.DataSource = Me.TblVitalSignsBindingSource
        '
        'TasksTabPage
        '
        Me.TasksTabPage.Controls.Add(Me.TblVitalSignTasksGridEX)
        Me.TasksTabPage.Location = New System.Drawing.Point(4, 25)
        Me.TasksTabPage.Name = "TasksTabPage"
        Me.TasksTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TasksTabPage.Size = New System.Drawing.Size(776, 604)
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
        Me.TblVitalSignTasksGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.TblVitalSignTasksGridEX.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TblVitalSignTasksGridEX.Location = New System.Drawing.Point(3, 3)
        Me.TblVitalSignTasksGridEX.Name = "TblVitalSignTasksGridEX"
        Me.TblVitalSignTasksGridEX.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.TblVitalSignTasksGridEX.RecordNavigator = True
        Me.TblVitalSignTasksGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignTasksGridEX.Size = New System.Drawing.Size(770, 598)
        Me.TblVitalSignTasksGridEX.TabIndex = 0
        '
        'TblVitalSignTasksBindingSource
        '
        Me.TblVitalSignTasksBindingSource.DataMember = "vwVitalSignOverview_tblVitalSignTasks"
        Me.TblVitalSignTasksBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'DataManagementOverviewTabPage
        '
        Me.DataManagementOverviewTabPage.Controls.Add(Me.TblVitalSignDataManagementSummaryGridEX)
        Me.DataManagementOverviewTabPage.Location = New System.Drawing.Point(4, 25)
        Me.DataManagementOverviewTabPage.Name = "DataManagementOverviewTabPage"
        Me.DataManagementOverviewTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataManagementOverviewTabPage.Size = New System.Drawing.Size(776, 604)
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
        Me.TblVitalSignDataManagementSummaryGridEX.ColumnAutoResize = True
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
        Me.TblVitalSignDataManagementSummaryGridEX.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.TblVitalSignDataManagementSummaryGridEX.RecordNavigator = True
        Me.TblVitalSignDataManagementSummaryGridEX.RowFormatStyle.FontSize = 10.0!
        Me.TblVitalSignDataManagementSummaryGridEX.RowFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TblVitalSignDataManagementSummaryGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblVitalSignDataManagementSummaryGridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.TblVitalSignDataManagementSummaryGridEX.Size = New System.Drawing.Size(770, 598)
        Me.TblVitalSignDataManagementSummaryGridEX.TabIndex = 0
        Me.TblVitalSignDataManagementSummaryGridEX.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[Default]
        '
        'TblVitalSignDataManagementSummaryBindingSource
        '
        Me.TblVitalSignDataManagementSummaryBindingSource.DataMember = "vwVitalSignOverview_tblVitalSignDataManagementSummary"
        Me.TblVitalSignDataManagementSummaryBindingSource.DataSource = Me.VwVitalSignOverviewBindingSource
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 40)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel1.Text = "Vital Sign"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VitalSignHeaderLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 40)
        Me.Panel1.TabIndex = 1
        '
        'VitalSignHeaderLabel
        '
        Me.VitalSignHeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VitalSignHeaderLabel.AutoSize = True
        Me.VitalSignHeaderLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitalSignHeaderLabel.Location = New System.Drawing.Point(15, 10)
        Me.VitalSignHeaderLabel.Name = "VitalSignHeaderLabel"
        Me.VitalSignHeaderLabel.Size = New System.Drawing.Size(211, 24)
        Me.VitalSignHeaderLabel.TabIndex = 0
        Me.VitalSignHeaderLabel.Text = "VitalSignHeaderLabel"
        '
        'TblProtocolDeliverablesBindingSource
        '
        Me.TblProtocolDeliverablesBindingSource.DataMember = "FK_tblProtocolDeliverables_tblVitalSignProtocols"
        Me.TblProtocolDeliverablesBindingSource.DataSource = Me.TblVitalSignProtocolsBindingSource
        '
        'TblProtocolRemeasurementsBindingSource
        '
        Me.TblProtocolRemeasurementsBindingSource.DataMember = "FK_tblVitalSignRemeasurements_tblVitalSignProtocols"
        Me.TblProtocolRemeasurementsBindingSource.DataSource = Me.TblVitalSignProtocolsBindingSource
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunctionsToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(1182, 28)
        Me.MainMenuStrip.TabIndex = 2
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'FunctionsToolStripMenuItem
        '
        Me.FunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FunctionsToolStripMenuItem.Name = "FunctionsToolStripMenuItem"
        Me.FunctionsToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.FunctionsToolStripMenuItem.Text = "Functions"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.SaveToolStripMenuItem.Text = "Save to database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainToolStrip
        '
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1182, 27)
        Me.MainToolStrip.TabIndex = 3
        Me.MainToolStrip.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(147, 24)
        Me.ToolStripButton1.Text = "Save to database"
        '
        'WorkLogReportViewer
        '
        Me.WorkLogReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "WorkLogDataset"
        ReportDataSource1.Value = Me.vwVitalSignWorkLogBindingSource
        Me.WorkLogReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.WorkLogReportViewer.LocalReport.DisplayName = "Work Log Report"
        Me.WorkLogReportViewer.LocalReport.ReportEmbeddedResource = "IMPM.WorkLogReport.rdlc"
        Me.WorkLogReportViewer.Location = New System.Drawing.Point(3, 3)
        Me.WorkLogReportViewer.Name = "WorkLogReportViewer"
        Me.WorkLogReportViewer.Size = New System.Drawing.Size(756, 563)
        Me.WorkLogReportViewer.TabIndex = 1
        '
        'vwVitalSignWorkLogBindingSource
        '
        Me.vwVitalSignWorkLogBindingSource.DataMember = "vwVitalSignWorkLog"
        Me.vwVitalSignWorkLogBindingSource.DataSource = Me.AKRODataSet
        '
        'vwVitalSignWorkLogTableAdapter
        '
        Me.vwVitalSignWorkLogTableAdapter.ClearBeforeFill = True
        '
        'WorkLogTabControl
        '
        Me.WorkLogTabControl.Controls.Add(Me.WorkLogReportTabPage)
        Me.WorkLogTabControl.Controls.Add(Me.WorkLogEditorTabPage)
        Me.WorkLogTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkLogTabControl.Location = New System.Drawing.Point(3, 3)
        Me.WorkLogTabControl.Name = "WorkLogTabControl"
        Me.WorkLogTabControl.SelectedIndex = 0
        Me.WorkLogTabControl.Size = New System.Drawing.Size(770, 598)
        Me.WorkLogTabControl.TabIndex = 2
        '
        'WorkLogReportTabPage
        '
        Me.WorkLogReportTabPage.Controls.Add(Me.WorkLogReportViewer)
        Me.WorkLogReportTabPage.Location = New System.Drawing.Point(4, 25)
        Me.WorkLogReportTabPage.Name = "WorkLogReportTabPage"
        Me.WorkLogReportTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.WorkLogReportTabPage.Size = New System.Drawing.Size(762, 569)
        Me.WorkLogReportTabPage.TabIndex = 0
        Me.WorkLogReportTabPage.Text = "Report"
        Me.WorkLogReportTabPage.UseVisualStyleBackColor = True
        '
        'WorkLogEditorTabPage
        '
        Me.WorkLogEditorTabPage.Controls.Add(Me.TblVitalSignWorkLogGridEX)
        Me.WorkLogEditorTabPage.Location = New System.Drawing.Point(4, 25)
        Me.WorkLogEditorTabPage.Name = "WorkLogEditorTabPage"
        Me.WorkLogEditorTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.WorkLogEditorTabPage.Size = New System.Drawing.Size(762, 569)
        Me.WorkLogEditorTabPage.TabIndex = 1
        Me.WorkLogEditorTabPage.Text = "Edit work log"
        Me.WorkLogEditorTabPage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Name = "Form1"
        Me.Text = "Program Manager: NPS Arctic and Central Alaska Inventory and Monitoring Networks"
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignOverviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignOverviewGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.PerformLayout()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.VitalSignTabControl.ResumeLayout(False)
        Me.OverviewTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignsGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VSWorkLogTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignWorkLogGridEX, System.Configuration.IPersistComponentSettings).LoadComponentSettings()
        CType(Me.TblVitalSignWorkLogGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProtocolsTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignProtocolsGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignProtocolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TasksTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignTasksGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataManagementOverviewTabPage.ResumeLayout(False)
        CType(Me.TblVitalSignDataManagementSummaryGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVitalSignDataManagementSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblProtocolDeliverablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProtocolRemeasurementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        CType(Me.vwVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkLogTabControl.ResumeLayout(False)
        Me.WorkLogReportTabPage.ResumeLayout(False)
        Me.WorkLogEditorTabPage.ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VitalSignHeaderLabel As Label
    Friend WithEvents TblVitalSignWorkLogTableAdapter As AKRODataSetTableAdapters.tblVitalSignWorkLogTableAdapter
    Friend WithEvents TblVitalSignWorkLogBindingSource As BindingSource
    Friend WithEvents TblVitalSignWorkLogGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents ProtocolsTabPage As TabPage
    Friend WithEvents TblVitalSignProtocolsBindingSource As BindingSource
    Friend WithEvents TblVitalSignProtocolsTableAdapter As AKRODataSetTableAdapters.tblVitalSignProtocolsTableAdapter
    Friend WithEvents TblVitalSignProtocolsGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents TasksTabPage As TabPage
    Friend WithEvents TblProtocolDeliverablesBindingSource As BindingSource
    Friend WithEvents TblProtocolDeliverablesTableAdapter As AKRODataSetTableAdapters.tblProtocolDeliverablesTableAdapter
    Friend WithEvents TblProtocolRemeasurementsBindingSource As BindingSource
    Friend WithEvents TblProtocolRemeasurementsTableAdapter As AKRODataSetTableAdapters.tblProtocolRemeasurementsTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents FunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataManagementOverviewTabPage As TabPage
    Friend WithEvents TblVitalSignDataManagementSummaryBindingSource As BindingSource
    Friend WithEvents TblVitalSignDataManagementSummaryTableAdapter As AKRODataSetTableAdapters.tblVitalSignDataManagementSummaryTableAdapter
    Friend WithEvents TblVitalSignDataManagementSummaryGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents TblVitalSignTasksBindingSource As BindingSource
    Friend WithEvents TblVitalSignTasksTableAdapter As AKRODataSetTableAdapters.tblVitalSignTasksTableAdapter
    Friend WithEvents TblVitalSignTasksGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents WorkLogReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vwVitalSignWorkLogBindingSource As BindingSource
    Friend WithEvents vwVitalSignWorkLogTableAdapter As AKRODataSetTableAdapters.vwVitalSignWorkLogTableAdapter
    Friend WithEvents WorkLogTabControl As TabControl
    Friend WithEvents WorkLogReportTabPage As TabPage
    Friend WithEvents WorkLogEditorTabPage As TabPage
End Class
