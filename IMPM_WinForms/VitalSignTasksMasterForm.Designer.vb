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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VitalSignTasksMasterForm))
        Dim VwVitalSignWorkLogGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.VwVitalSignWorkLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVitalSignWorkLogTableAdapter = New IMPM.AKRODataSetTableAdapters.vwVitalSignWorkLogTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.VwVitalSignWorkLogBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VwVitalSignWorkLogGridEX = New Janus.Windows.GridEX.GridEX()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVitalSignWorkLogBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VwVitalSignWorkLogBindingNavigator.SuspendLayout()
        CType(Me.VwVitalSignWorkLogGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AKRODataSet
        '
        Me.AKRODataSet.DataSetName = "AKRODataSet"
        Me.AKRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwVitalSignWorkLogBindingSource
        '
        Me.VwVitalSignWorkLogBindingSource.DataMember = "vwVitalSignWorkLog"
        Me.VwVitalSignWorkLogBindingSource.DataSource = Me.AKRODataSet
        '
        'VwVitalSignWorkLogTableAdapter
        '
        Me.VwVitalSignWorkLogTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.tblVitalSignTasksTableAdapter = Nothing
        Me.TableAdapterManager.tblVitalSignWorkLogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IMPM.AKRODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwVitalSignWorkLogBindingNavigator
        '
        Me.VwVitalSignWorkLogBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VwVitalSignWorkLogBindingNavigator.BindingSource = Me.VwVitalSignWorkLogBindingSource
        Me.VwVitalSignWorkLogBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VwVitalSignWorkLogBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VwVitalSignWorkLogBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VwVitalSignWorkLogBindingNavigatorSaveItem})
        Me.VwVitalSignWorkLogBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VwVitalSignWorkLogBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VwVitalSignWorkLogBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VwVitalSignWorkLogBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VwVitalSignWorkLogBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VwVitalSignWorkLogBindingNavigator.Name = "VwVitalSignWorkLogBindingNavigator"
        Me.VwVitalSignWorkLogBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VwVitalSignWorkLogBindingNavigator.Size = New System.Drawing.Size(1184, 25)
        Me.VwVitalSignWorkLogBindingNavigator.TabIndex = 0
        Me.VwVitalSignWorkLogBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'VwVitalSignWorkLogBindingNavigatorSaveItem
        '
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem.Enabled = False
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem.Image = CType(resources.GetObject("VwVitalSignWorkLogBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem.Name = "VwVitalSignWorkLogBindingNavigatorSaveItem"
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.VwVitalSignWorkLogBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VwVitalSignWorkLogGridEX
        '
        Me.VwVitalSignWorkLogGridEX.DataSource = Me.VwVitalSignWorkLogBindingSource
        VwVitalSignWorkLogGridEX_DesignTimeLayout.LayoutString = resources.GetString("VwVitalSignWorkLogGridEX_DesignTimeLayout.LayoutString")
        Me.VwVitalSignWorkLogGridEX.DesignTimeLayout = VwVitalSignWorkLogGridEX_DesignTimeLayout
        Me.VwVitalSignWorkLogGridEX.Location = New System.Drawing.Point(62, 64)
        Me.VwVitalSignWorkLogGridEX.Name = "VwVitalSignWorkLogGridEX"
        Me.VwVitalSignWorkLogGridEX.Size = New System.Drawing.Size(1092, 545)
        Me.VwVitalSignWorkLogGridEX.TabIndex = 1
        '
        'VitalSignTasksMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.VwVitalSignWorkLogGridEX)
        Me.Controls.Add(Me.VwVitalSignWorkLogBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "VitalSignTasksMasterForm"
        Me.Text = "Vital SignT asks"
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignWorkLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVitalSignWorkLogBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VwVitalSignWorkLogBindingNavigator.ResumeLayout(False)
        Me.VwVitalSignWorkLogBindingNavigator.PerformLayout()
        CType(Me.VwVitalSignWorkLogGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AKRODataSet As AKRODataSet
    Friend WithEvents VwVitalSignWorkLogBindingSource As BindingSource
    Friend WithEvents VwVitalSignWorkLogTableAdapter As AKRODataSetTableAdapters.vwVitalSignWorkLogTableAdapter
    Friend WithEvents TableAdapterManager As AKRODataSetTableAdapters.TableAdapterManager
    Friend WithEvents VwVitalSignWorkLogBindingNavigator As BindingNavigator
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
    Friend WithEvents VwVitalSignWorkLogBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VwVitalSignWorkLogGridEX As Janus.Windows.GridEX.GridEX
End Class
