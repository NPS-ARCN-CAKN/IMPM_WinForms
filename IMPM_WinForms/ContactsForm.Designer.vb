<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactsForm
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
        Dim TblContactsGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactsForm))
        Me.AKRODataSet = New IMPM.AKRODataSet()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsTableAdapter = New IMPM.AKRODataSetTableAdapters.tblContactsTableAdapter()
        Me.TableAdapterManager = New IMPM.AKRODataSetTableAdapters.TableAdapterManager()
        Me.TblContactsGridEX = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AKRODataSet
        '
        Me.AKRODataSet.DataSetName = "AKRODataSet"
        Me.AKRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataManagementMilestonesTableAdapter = Nothing
        Me.TableAdapterManager.tblContactsTableAdapter = Me.TblContactsTableAdapter
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
        'TblContactsGridEX
        '
        Me.TblContactsGridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblContactsGridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblContactsGridEX.AlternatingColors = True
        Me.TblContactsGridEX.DataSource = Me.TblContactsBindingSource
        TblContactsGridEX_DesignTimeLayout.LayoutString = resources.GetString("TblContactsGridEX_DesignTimeLayout.LayoutString")
        Me.TblContactsGridEX.DesignTimeLayout = TblContactsGridEX_DesignTimeLayout
        Me.TblContactsGridEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblContactsGridEX.Location = New System.Drawing.Point(0, 25)
        Me.TblContactsGridEX.Name = "TblContactsGridEX"
        Me.TblContactsGridEX.RecordNavigator = True
        Me.TblContactsGridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.TblContactsGridEX.Size = New System.Drawing.Size(1184, 736)
        Me.TblContactsGridEX.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
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
        'ContactsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.TblContactsGridEX)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ContactsForm"
        Me.Text = "Network Contacts"
        CType(Me.AKRODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AKRODataSet As AKRODataSet
    Friend WithEvents TblContactsBindingSource As BindingSource
    Friend WithEvents TblContactsTableAdapter As AKRODataSetTableAdapters.tblContactsTableAdapter
    Friend WithEvents TableAdapterManager As AKRODataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblContactsGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
End Class
