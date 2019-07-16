<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliverableForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliverableForm))
        Dim DeliverableIdentifierLabel As System.Windows.Forms.Label
        Dim DeliverableLabel As System.Windows.Forms.Label
        Dim SOPLabel As System.Windows.Forms.Label
        Dim SOPVersionLabel As System.Windows.Forms.Label
        Dim FormatLabel As System.Windows.Forms.Label
        Dim ScheduleLabel As System.Windows.Forms.Label
        Dim ResponsibilityLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim SpecificationsLabel As System.Windows.Forms.Label
        Dim FileNamingSchemeLabel As System.Windows.Forms.Label
        Dim DataHandlingLabel As System.Windows.Forms.Label
        Dim QAQCLabel As System.Windows.Forms.Label
        Dim ArchivalLabel As System.Windows.Forms.Label
        Dim BuilderTasksLabel As System.Windows.Forms.Label
        Dim ValidatorTasksLabel As System.Windows.Forms.Label
        Dim CertifierTasksLabel As System.Windows.Forms.Label
        Dim DeliverableIDLabel As System.Windows.Forms.Label
        Dim ProtocolIDLabel As System.Windows.Forms.Label
        Dim RecordInsertedDateLabel As System.Windows.Forms.Label
        Dim RecordInsertedByLabel As System.Windows.Forms.Label
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.TblProtocolDeliverablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProtocolDeliverablesTableAdapter = New IMPM.AKRODataSetTableAdapters.tblProtocolDeliverablesTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.TblProtocolDeliverablesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProtocolDeliverablesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DeliverableIdentifierTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverableTextBox = New System.Windows.Forms.TextBox()
        Me.SOPTextBox = New System.Windows.Forms.TextBox()
        Me.SOPVersionTextBox = New System.Windows.Forms.TextBox()
        Me.FormatTextBox = New System.Windows.Forms.TextBox()
        Me.ScheduleTextBox = New System.Windows.Forms.TextBox()
        Me.ResponsibilityTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.SpecificationsTextBox = New System.Windows.Forms.TextBox()
        Me.FileNamingSchemeTextBox = New System.Windows.Forms.TextBox()
        Me.DataHandlingTextBox = New System.Windows.Forms.TextBox()
        Me.QAQCTextBox = New System.Windows.Forms.TextBox()
        Me.ArchivalTextBox = New System.Windows.Forms.TextBox()
        Me.BuilderTasksTextBox = New System.Windows.Forms.TextBox()
        Me.ValidatorTasksTextBox = New System.Windows.Forms.TextBox()
        Me.CertifierTasksTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverableIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocolIDTextBox = New System.Windows.Forms.TextBox()
        Me.RecordInsertedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RecordInsertedByTextBox = New System.Windows.Forms.TextBox()
        DeliverableIdentifierLabel = New System.Windows.Forms.Label()
        DeliverableLabel = New System.Windows.Forms.Label()
        SOPLabel = New System.Windows.Forms.Label()
        SOPVersionLabel = New System.Windows.Forms.Label()
        FormatLabel = New System.Windows.Forms.Label()
        ScheduleLabel = New System.Windows.Forms.Label()
        ResponsibilityLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        SpecificationsLabel = New System.Windows.Forms.Label()
        FileNamingSchemeLabel = New System.Windows.Forms.Label()
        DataHandlingLabel = New System.Windows.Forms.Label()
        QAQCLabel = New System.Windows.Forms.Label()
        ArchivalLabel = New System.Windows.Forms.Label()
        BuilderTasksLabel = New System.Windows.Forms.Label()
        ValidatorTasksLabel = New System.Windows.Forms.Label()
        CertifierTasksLabel = New System.Windows.Forms.Label()
        DeliverableIDLabel = New System.Windows.Forms.Label()
        ProtocolIDLabel = New System.Windows.Forms.Label()
        RecordInsertedDateLabel = New System.Windows.Forms.Label()
        RecordInsertedByLabel = New System.Windows.Forms.Label()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProtocolDeliverablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProtocolDeliverablesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProtocolDeliverablesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AKRODataSet
        '
        Me.AKRODataSet.DataSetName = "AKRODataSet"
        Me.AKRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProtocolDeliverablesBindingSource
        '
        Me.TblProtocolDeliverablesBindingSource.DataMember = "tblProtocolDeliverables"
        Me.TblProtocolDeliverablesBindingSource.DataSource = Me.AKRODataSet
        '
        'TblProtocolDeliverablesTableAdapter
        '
        Me.TblProtocolDeliverablesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataManagementMilestonesTableAdapter = Nothing
        Me.TableAdapterManager.tblContactsTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworksTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworkTasksTableAdapter = Nothing
        Me.TableAdapterManager.tblProtocolDeliverablesTableAdapter = Me.TblProtocolDeliverablesTableAdapter
        Me.TableAdapterManager.tblProtocolRemeasurementsTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignDataManagementSummaryTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignObjectivesTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignProtocolsTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignsTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignTasksTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignWorkLogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IMPM.AKRODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblProtocolDeliverablesBindingNavigator
        '
        Me.TblProtocolDeliverablesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProtocolDeliverablesBindingNavigator.BindingSource = Me.TblProtocolDeliverablesBindingSource
        Me.TblProtocolDeliverablesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProtocolDeliverablesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProtocolDeliverablesBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TblProtocolDeliverablesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProtocolDeliverablesBindingNavigatorSaveItem})
        Me.TblProtocolDeliverablesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblProtocolDeliverablesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProtocolDeliverablesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProtocolDeliverablesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProtocolDeliverablesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProtocolDeliverablesBindingNavigator.Name = "TblProtocolDeliverablesBindingNavigator"
        Me.TblProtocolDeliverablesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProtocolDeliverablesBindingNavigator.Size = New System.Drawing.Size(1077, 31)
        Me.TblProtocolDeliverablesBindingNavigator.TabIndex = 0
        Me.TblProtocolDeliverablesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblProtocolDeliverablesBindingNavigatorSaveItem
        '
        Me.TblProtocolDeliverablesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProtocolDeliverablesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProtocolDeliverablesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProtocolDeliverablesBindingNavigatorSaveItem.Name = "TblProtocolDeliverablesBindingNavigatorSaveItem"
        Me.TblProtocolDeliverablesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblProtocolDeliverablesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DeliverableIdentifierLabel
        '
        DeliverableIdentifierLabel.AutoSize = True
        DeliverableIdentifierLabel.Location = New System.Drawing.Point(16, 64)
        DeliverableIdentifierLabel.Name = "DeliverableIdentifierLabel"
        DeliverableIdentifierLabel.Size = New System.Drawing.Size(157, 20)
        DeliverableIdentifierLabel.TabIndex = 1
        DeliverableIdentifierLabel.Text = "Deliverable Identifier:"
        '
        'DeliverableIdentifierTextBox
        '
        Me.DeliverableIdentifierTextBox.Location = New System.Drawing.Point(189, 61)
        Me.DeliverableIdentifierTextBox.Name = "DeliverableIdentifierTextBox"
        Me.DeliverableIdentifierTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DeliverableIdentifierTextBox.TabIndex = 2
        '
        'DeliverableLabel
        '
        DeliverableLabel.AutoSize = True
        DeliverableLabel.Location = New System.Drawing.Point(16, 96)
        DeliverableLabel.Name = "DeliverableLabel"
        DeliverableLabel.Size = New System.Drawing.Size(91, 20)
        DeliverableLabel.TabIndex = 3
        DeliverableLabel.Text = "Deliverable:"
        '
        'DeliverableTextBox
        '
        Me.DeliverableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Deliverable", True))
        Me.DeliverableTextBox.Location = New System.Drawing.Point(189, 93)
        Me.DeliverableTextBox.Name = "DeliverableTextBox"
        Me.DeliverableTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DeliverableTextBox.TabIndex = 4
        '
        'SOPLabel
        '
        SOPLabel.AutoSize = True
        SOPLabel.Location = New System.Drawing.Point(16, 128)
        SOPLabel.Name = "SOPLabel"
        SOPLabel.Size = New System.Drawing.Size(46, 20)
        SOPLabel.TabIndex = 5
        SOPLabel.Text = "SOP:"
        '
        'SOPTextBox
        '
        Me.SOPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "SOP", True))
        Me.SOPTextBox.Location = New System.Drawing.Point(189, 125)
        Me.SOPTextBox.Name = "SOPTextBox"
        Me.SOPTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SOPTextBox.TabIndex = 6
        '
        'SOPVersionLabel
        '
        SOPVersionLabel.AutoSize = True
        SOPVersionLabel.Location = New System.Drawing.Point(16, 160)
        SOPVersionLabel.Name = "SOPVersionLabel"
        SOPVersionLabel.Size = New System.Drawing.Size(100, 20)
        SOPVersionLabel.TabIndex = 7
        SOPVersionLabel.Text = "SOPVersion:"
        '
        'SOPVersionTextBox
        '
        Me.SOPVersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "SOPVersion", True))
        Me.SOPVersionTextBox.Location = New System.Drawing.Point(189, 157)
        Me.SOPVersionTextBox.Name = "SOPVersionTextBox"
        Me.SOPVersionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SOPVersionTextBox.TabIndex = 8
        '
        'FormatLabel
        '
        FormatLabel.AutoSize = True
        FormatLabel.Location = New System.Drawing.Point(16, 192)
        FormatLabel.Name = "FormatLabel"
        FormatLabel.Size = New System.Drawing.Size(64, 20)
        FormatLabel.TabIndex = 9
        FormatLabel.Text = "Format:"
        '
        'FormatTextBox
        '
        Me.FormatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Format", True))
        Me.FormatTextBox.Location = New System.Drawing.Point(189, 189)
        Me.FormatTextBox.Name = "FormatTextBox"
        Me.FormatTextBox.Size = New System.Drawing.Size(200, 26)
        Me.FormatTextBox.TabIndex = 10
        '
        'ScheduleLabel
        '
        ScheduleLabel.AutoSize = True
        ScheduleLabel.Location = New System.Drawing.Point(16, 224)
        ScheduleLabel.Name = "ScheduleLabel"
        ScheduleLabel.Size = New System.Drawing.Size(80, 20)
        ScheduleLabel.TabIndex = 11
        ScheduleLabel.Text = "Schedule:"
        '
        'ScheduleTextBox
        '
        Me.ScheduleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Schedule", True))
        Me.ScheduleTextBox.Location = New System.Drawing.Point(189, 221)
        Me.ScheduleTextBox.Name = "ScheduleTextBox"
        Me.ScheduleTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ScheduleTextBox.TabIndex = 12
        '
        'ResponsibilityLabel
        '
        ResponsibilityLabel.AutoSize = True
        ResponsibilityLabel.Location = New System.Drawing.Point(16, 256)
        ResponsibilityLabel.Name = "ResponsibilityLabel"
        ResponsibilityLabel.Size = New System.Drawing.Size(110, 20)
        ResponsibilityLabel.TabIndex = 13
        ResponsibilityLabel.Text = "Responsibility:"
        '
        'ResponsibilityTextBox
        '
        Me.ResponsibilityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Responsibility", True))
        Me.ResponsibilityTextBox.Location = New System.Drawing.Point(189, 253)
        Me.ResponsibilityTextBox.Name = "ResponsibilityTextBox"
        Me.ResponsibilityTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ResponsibilityTextBox.TabIndex = 14
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(16, 288)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(93, 20)
        DescriptionLabel.TabIndex = 15
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(189, 285)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DescriptionTextBox.TabIndex = 16
        '
        'SpecificationsLabel
        '
        SpecificationsLabel.AutoSize = True
        SpecificationsLabel.Location = New System.Drawing.Point(16, 320)
        SpecificationsLabel.Name = "SpecificationsLabel"
        SpecificationsLabel.Size = New System.Drawing.Size(112, 20)
        SpecificationsLabel.TabIndex = 17
        SpecificationsLabel.Text = "Specifications:"
        '
        'SpecificationsTextBox
        '
        Me.SpecificationsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Specifications", True))
        Me.SpecificationsTextBox.Location = New System.Drawing.Point(189, 317)
        Me.SpecificationsTextBox.Name = "SpecificationsTextBox"
        Me.SpecificationsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SpecificationsTextBox.TabIndex = 18
        '
        'FileNamingSchemeLabel
        '
        FileNamingSchemeLabel.AutoSize = True
        FileNamingSchemeLabel.Location = New System.Drawing.Point(16, 352)
        FileNamingSchemeLabel.Name = "FileNamingSchemeLabel"
        FileNamingSchemeLabel.Size = New System.Drawing.Size(159, 20)
        FileNamingSchemeLabel.TabIndex = 19
        FileNamingSchemeLabel.Text = "File Naming Scheme:"
        '
        'FileNamingSchemeTextBox
        '
        Me.FileNamingSchemeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "FileNamingScheme", True))
        Me.FileNamingSchemeTextBox.Location = New System.Drawing.Point(189, 349)
        Me.FileNamingSchemeTextBox.Name = "FileNamingSchemeTextBox"
        Me.FileNamingSchemeTextBox.Size = New System.Drawing.Size(200, 26)
        Me.FileNamingSchemeTextBox.TabIndex = 20
        '
        'DataHandlingLabel
        '
        DataHandlingLabel.AutoSize = True
        DataHandlingLabel.Location = New System.Drawing.Point(16, 384)
        DataHandlingLabel.Name = "DataHandlingLabel"
        DataHandlingLabel.Size = New System.Drawing.Size(115, 20)
        DataHandlingLabel.TabIndex = 21
        DataHandlingLabel.Text = "Data Handling:"
        '
        'DataHandlingTextBox
        '
        Me.DataHandlingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "DataHandling", True))
        Me.DataHandlingTextBox.Location = New System.Drawing.Point(189, 381)
        Me.DataHandlingTextBox.Name = "DataHandlingTextBox"
        Me.DataHandlingTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DataHandlingTextBox.TabIndex = 22
        '
        'QAQCLabel
        '
        QAQCLabel.AutoSize = True
        QAQCLabel.Location = New System.Drawing.Point(16, 416)
        QAQCLabel.Name = "QAQCLabel"
        QAQCLabel.Size = New System.Drawing.Size(59, 20)
        QAQCLabel.TabIndex = 23
        QAQCLabel.Text = "QAQC:"
        '
        'QAQCTextBox
        '
        Me.QAQCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "QAQC", True))
        Me.QAQCTextBox.Location = New System.Drawing.Point(189, 413)
        Me.QAQCTextBox.Name = "QAQCTextBox"
        Me.QAQCTextBox.Size = New System.Drawing.Size(200, 26)
        Me.QAQCTextBox.TabIndex = 24
        '
        'ArchivalLabel
        '
        ArchivalLabel.AutoSize = True
        ArchivalLabel.Location = New System.Drawing.Point(16, 448)
        ArchivalLabel.Name = "ArchivalLabel"
        ArchivalLabel.Size = New System.Drawing.Size(68, 20)
        ArchivalLabel.TabIndex = 25
        ArchivalLabel.Text = "Archival:"
        '
        'ArchivalTextBox
        '
        Me.ArchivalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "Archival", True))
        Me.ArchivalTextBox.Location = New System.Drawing.Point(189, 445)
        Me.ArchivalTextBox.Name = "ArchivalTextBox"
        Me.ArchivalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ArchivalTextBox.TabIndex = 26
        '
        'BuilderTasksLabel
        '
        BuilderTasksLabel.AutoSize = True
        BuilderTasksLabel.Location = New System.Drawing.Point(16, 480)
        BuilderTasksLabel.Name = "BuilderTasksLabel"
        BuilderTasksLabel.Size = New System.Drawing.Size(108, 20)
        BuilderTasksLabel.TabIndex = 27
        BuilderTasksLabel.Text = "Builder Tasks:"
        '
        'BuilderTasksTextBox
        '
        Me.BuilderTasksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "BuilderTasks", True))
        Me.BuilderTasksTextBox.Location = New System.Drawing.Point(189, 477)
        Me.BuilderTasksTextBox.Name = "BuilderTasksTextBox"
        Me.BuilderTasksTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BuilderTasksTextBox.TabIndex = 28
        '
        'ValidatorTasksLabel
        '
        ValidatorTasksLabel.AutoSize = True
        ValidatorTasksLabel.Location = New System.Drawing.Point(16, 512)
        ValidatorTasksLabel.Name = "ValidatorTasksLabel"
        ValidatorTasksLabel.Size = New System.Drawing.Size(122, 20)
        ValidatorTasksLabel.TabIndex = 29
        ValidatorTasksLabel.Text = "Validator Tasks:"
        '
        'ValidatorTasksTextBox
        '
        Me.ValidatorTasksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "ValidatorTasks", True))
        Me.ValidatorTasksTextBox.Location = New System.Drawing.Point(189, 509)
        Me.ValidatorTasksTextBox.Name = "ValidatorTasksTextBox"
        Me.ValidatorTasksTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ValidatorTasksTextBox.TabIndex = 30
        '
        'CertifierTasksLabel
        '
        CertifierTasksLabel.AutoSize = True
        CertifierTasksLabel.Location = New System.Drawing.Point(16, 544)
        CertifierTasksLabel.Name = "CertifierTasksLabel"
        CertifierTasksLabel.Size = New System.Drawing.Size(114, 20)
        CertifierTasksLabel.TabIndex = 31
        CertifierTasksLabel.Text = "Certifier Tasks:"
        '
        'CertifierTasksTextBox
        '
        Me.CertifierTasksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "CertifierTasks", True))
        Me.CertifierTasksTextBox.Location = New System.Drawing.Point(189, 541)
        Me.CertifierTasksTextBox.Name = "CertifierTasksTextBox"
        Me.CertifierTasksTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CertifierTasksTextBox.TabIndex = 32
        '
        'DeliverableIDLabel
        '
        DeliverableIDLabel.AutoSize = True
        DeliverableIDLabel.Location = New System.Drawing.Point(16, 576)
        DeliverableIDLabel.Name = "DeliverableIDLabel"
        DeliverableIDLabel.Size = New System.Drawing.Size(112, 20)
        DeliverableIDLabel.TabIndex = 33
        DeliverableIDLabel.Text = "Deliverable ID:"
        '
        'DeliverableIDTextBox
        '
        Me.DeliverableIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "DeliverableID", True))
        Me.DeliverableIDTextBox.Location = New System.Drawing.Point(189, 573)
        Me.DeliverableIDTextBox.Name = "DeliverableIDTextBox"
        Me.DeliverableIDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DeliverableIDTextBox.TabIndex = 34
        '
        'ProtocolIDLabel
        '
        ProtocolIDLabel.AutoSize = True
        ProtocolIDLabel.Location = New System.Drawing.Point(16, 608)
        ProtocolIDLabel.Name = "ProtocolIDLabel"
        ProtocolIDLabel.Size = New System.Drawing.Size(92, 20)
        ProtocolIDLabel.TabIndex = 35
        ProtocolIDLabel.Text = "Protocol ID:"
        '
        'ProtocolIDTextBox
        '
        Me.ProtocolIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "ProtocolID", True))
        Me.ProtocolIDTextBox.Location = New System.Drawing.Point(189, 605)
        Me.ProtocolIDTextBox.Name = "ProtocolIDTextBox"
        Me.ProtocolIDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProtocolIDTextBox.TabIndex = 36
        '
        'RecordInsertedDateLabel
        '
        RecordInsertedDateLabel.AutoSize = True
        RecordInsertedDateLabel.Location = New System.Drawing.Point(16, 641)
        RecordInsertedDateLabel.Name = "RecordInsertedDateLabel"
        RecordInsertedDateLabel.Size = New System.Drawing.Size(167, 20)
        RecordInsertedDateLabel.TabIndex = 37
        RecordInsertedDateLabel.Text = "Record Inserted Date:"
        '
        'RecordInsertedDateDateTimePicker
        '
        Me.RecordInsertedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblProtocolDeliverablesBindingSource, "RecordInsertedDate", True))
        Me.RecordInsertedDateDateTimePicker.Location = New System.Drawing.Point(189, 637)
        Me.RecordInsertedDateDateTimePicker.Name = "RecordInsertedDateDateTimePicker"
        Me.RecordInsertedDateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.RecordInsertedDateDateTimePicker.TabIndex = 38
        '
        'RecordInsertedByLabel
        '
        RecordInsertedByLabel.AutoSize = True
        RecordInsertedByLabel.Location = New System.Drawing.Point(16, 672)
        RecordInsertedByLabel.Name = "RecordInsertedByLabel"
        RecordInsertedByLabel.Size = New System.Drawing.Size(150, 20)
        RecordInsertedByLabel.TabIndex = 39
        RecordInsertedByLabel.Text = "Record Inserted By:"
        '
        'RecordInsertedByTextBox
        '
        Me.RecordInsertedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProtocolDeliverablesBindingSource, "RecordInsertedBy", True))
        Me.RecordInsertedByTextBox.Location = New System.Drawing.Point(189, 669)
        Me.RecordInsertedByTextBox.Name = "RecordInsertedByTextBox"
        Me.RecordInsertedByTextBox.Size = New System.Drawing.Size(200, 26)
        Me.RecordInsertedByTextBox.TabIndex = 40
        '
        'DeliverableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 785)
        Me.Controls.Add(DeliverableIdentifierLabel)
        Me.Controls.Add(Me.DeliverableIdentifierTextBox)
        Me.Controls.Add(DeliverableLabel)
        Me.Controls.Add(Me.DeliverableTextBox)
        Me.Controls.Add(SOPLabel)
        Me.Controls.Add(Me.SOPTextBox)
        Me.Controls.Add(SOPVersionLabel)
        Me.Controls.Add(Me.SOPVersionTextBox)
        Me.Controls.Add(FormatLabel)
        Me.Controls.Add(Me.FormatTextBox)
        Me.Controls.Add(ScheduleLabel)
        Me.Controls.Add(Me.ScheduleTextBox)
        Me.Controls.Add(ResponsibilityLabel)
        Me.Controls.Add(Me.ResponsibilityTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(SpecificationsLabel)
        Me.Controls.Add(Me.SpecificationsTextBox)
        Me.Controls.Add(FileNamingSchemeLabel)
        Me.Controls.Add(Me.FileNamingSchemeTextBox)
        Me.Controls.Add(DataHandlingLabel)
        Me.Controls.Add(Me.DataHandlingTextBox)
        Me.Controls.Add(QAQCLabel)
        Me.Controls.Add(Me.QAQCTextBox)
        Me.Controls.Add(ArchivalLabel)
        Me.Controls.Add(Me.ArchivalTextBox)
        Me.Controls.Add(BuilderTasksLabel)
        Me.Controls.Add(Me.BuilderTasksTextBox)
        Me.Controls.Add(ValidatorTasksLabel)
        Me.Controls.Add(Me.ValidatorTasksTextBox)
        Me.Controls.Add(CertifierTasksLabel)
        Me.Controls.Add(Me.CertifierTasksTextBox)
        Me.Controls.Add(DeliverableIDLabel)
        Me.Controls.Add(Me.DeliverableIDTextBox)
        Me.Controls.Add(ProtocolIDLabel)
        Me.Controls.Add(Me.ProtocolIDTextBox)
        Me.Controls.Add(RecordInsertedDateLabel)
        Me.Controls.Add(Me.RecordInsertedDateDateTimePicker)
        Me.Controls.Add(RecordInsertedByLabel)
        Me.Controls.Add(Me.RecordInsertedByTextBox)
        Me.Controls.Add(Me.TblProtocolDeliverablesBindingNavigator)
        Me.Name = "DeliverableForm"
        Me.Text = "DeliverableForm"
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProtocolDeliverablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProtocolDeliverablesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProtocolDeliverablesBindingNavigator.ResumeLayout(False)
        Me.TblProtocolDeliverablesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AKRODataSet As AKRODataSet
    Friend WithEvents TblProtocolDeliverablesBindingSource As BindingSource
    Friend WithEvents TblProtocolDeliverablesTableAdapter As AKRODataSetTableAdapters.tblProtocolDeliverablesTableAdapter
    Friend WithEvents TableAdapterManager As AKRODataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProtocolDeliverablesBindingNavigator As BindingNavigator
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
    Friend WithEvents TblProtocolDeliverablesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DeliverableIdentifierTextBox As TextBox
    Friend WithEvents DeliverableTextBox As TextBox
    Friend WithEvents SOPTextBox As TextBox
    Friend WithEvents SOPVersionTextBox As TextBox
    Friend WithEvents FormatTextBox As TextBox
    Friend WithEvents ScheduleTextBox As TextBox
    Friend WithEvents ResponsibilityTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents SpecificationsTextBox As TextBox
    Friend WithEvents FileNamingSchemeTextBox As TextBox
    Friend WithEvents DataHandlingTextBox As TextBox
    Friend WithEvents QAQCTextBox As TextBox
    Friend WithEvents ArchivalTextBox As TextBox
    Friend WithEvents BuilderTasksTextBox As TextBox
    Friend WithEvents ValidatorTasksTextBox As TextBox
    Friend WithEvents CertifierTasksTextBox As TextBox
    Friend WithEvents DeliverableIDTextBox As TextBox
    Friend WithEvents ProtocolIDTextBox As TextBox
    Friend WithEvents RecordInsertedDateDateTimePicker As DateTimePicker
    Friend WithEvents RecordInsertedByTextBox As TextBox
End Class
