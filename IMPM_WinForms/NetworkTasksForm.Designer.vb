<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkTasksForm
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
        Dim TblNetworkTasksGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetworkTasksForm))
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.TblNetworkTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblNetworkTasksTableAdapter = New IMPM.AKRODataSetTableAdapters.tblNetworkTasksTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.TblNetworkTasksGridEX = New Janus.Windows.GridEX.GridEX()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblContactsTableAdapter()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNetworkTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNetworkTasksGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AKRODataSet
        '
        Me.AKRODataSet.DataSetName = "AKRODataSet"
        Me.AKRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblNetworkTasksBindingSource
        '
        Me.TblNetworkTasksBindingSource.DataMember = "tblNetworkTasks"
        Me.TblNetworkTasksBindingSource.DataSource = Me.AKRODataSet
        '
        'TblNetworkTasksTableAdapter
        '
        Me.TblNetworkTasksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataManagementMilestonesTableAdapter = Nothing
        Me.TableAdapterManager.tblContactsTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworksTableAdapter = Nothing
        Me.TableAdapterManager.tblNetworkTasksTableAdapter = Me.TblNetworkTasksTableAdapter
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
        'TblNetworkTasksGridEX
        '
        Me.TblNetworkTasksGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblNetworkTasksGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblNetworkTasksGridEX.AlternatingColors = True
        Me.TblNetworkTasksGridEX.DataSource = Me.TblNetworkTasksBindingSource
        TblNetworkTasksGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblNetworkTasksGridEX_DesignTimeLayout.LayoutString")
        Me.TblNetworkTasksGridEX.DesignTimeLayout = TblNetworkTasksGridEX_DesignTimeLayout
        Me.TblNetworkTasksGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblNetworkTasksGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
        Me.TblNetworkTasksGridEX.FilterRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.TblNetworkTasksGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TblNetworkTasksGridEX.Location = New System.Drawing.Point(0, 49)
        Me.TblNetworkTasksGridEX.Name = "TblNetworkTasksGridEX"
        Me.TblNetworkTasksGridEX.RecordNavigator = True
        Me.TblNetworkTasksGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblNetworkTasksGridEX.Size = New System.Drawing.Size(1184, 712)
        Me.TblNetworkTasksGridEX.TabIndex = 3
        Me.TblNetworkTasksGridEX.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SaveToolStripMenuItem.Text = "Functions"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.SaveToolStripMenuItem1.Text = "Save..."
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
        Me.ToolStrip1.TabIndex = 4
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
        'TblContactsBindingSource
        '
        Me.TblContactsBindingSource.DataMember = "tblContacts"
        Me.TblContactsBindingSource.DataSource = Me.AKRODataSet
        '
        'TblContactsTableAdapter
        '
        Me.TblContactsTableAdapter.ClearBeforeFill = True
        '
        'NetworkTasksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.TblNetworkTasksGridEX)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NetworkTasksForm"
        Me.Text = "NetworkTasksForm"
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNetworkTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNetworkTasksGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AKRODataSet As AKRODataSet
    Friend WithEvents TblNetworkTasksBindingSource As BindingSource
    Friend WithEvents TblNetworkTasksTableAdapter As AKRODataSetTableAdapters.tblNetworkTasksTableAdapter
    Friend WithEvents TableAdapterManager As AKRODataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblNetworkTasksGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents TblContactsBindingSource As BindingSource
    Friend WithEvents TblContactsTableAdapter As AKRODataSetTableAdapters.tblContactsTableAdapter
End Class
