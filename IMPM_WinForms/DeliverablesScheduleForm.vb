Public Class DeliverablesScheduleForm
    Private _DeliverablesScheduleDataView As DataView
    Dim ChooserDataTable As New DataTable
    Public Property DeliverablesScheduleDataView() As DataView
        Get
            Return _DeliverablesScheduleDataView
        End Get
        Set(ByVal value As DataView)
            _DeliverablesScheduleDataView = value

            'load grid
            Try
                Me.DeliverablesScheduleDataGridView.DataSource = _DeliverablesScheduleDataView
            Catch ex As Exception
                MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try

            'create a columns chooser datatable

            Dim SelectedColumn As DataColumn = New DataColumn("Selected")
            SelectedColumn.DataType = System.Type.GetType("System.Boolean")
            Dim ColumnColumn As DataColumn = New DataColumn("Column")
            ColumnColumn.DataType = System.Type.GetType("System.String")
            ChooserDataTable.Columns.Add(SelectedColumn)
            ChooserDataTable.Columns.Add(ColumnColumn)
            Me.ColumnsChooserDataGridView.DataSource = ChooserDataTable

            'build up the chooserdatatable rows
            For Each Col As DataColumn In _DeliverablesScheduleDataView.Table.Columns
                Dim Row As DataRow = ChooserDataTable.NewRow
                Row.Item(0) = False
                Row.Item(1) = Col.ColumnName
                ChooserDataTable.Rows.Add(Row)
            Next



            LoadTextBox()
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.DeliverablesScheduleDataGridView.DataSource = _DeliverablesScheduleDataView
    End Sub

    Private Sub LoadTextBox()
        'load textbox
        Try
            Dim DeliverableIdentifier As String = ""
            Dim Deliverable As String = ""
            Dim SOP As String = ""
            Dim SOPVersion As String = ""
            Dim Format As String = ""
            Dim Schedule As String = ""
            Dim Responsibility As String = ""
            Dim Description As String = ""
            Dim Specifications As String = ""
            Dim FilenamingScheme As String = ""
            For Each Row As DataRowView In _DeliverablesScheduleDataView
                If Not IsDBNull(Row.Item("DeliverableIdentifier")) Then DeliverableIdentifier = Row.Item("DeliverableIdentifier")
                If Not IsDBNull(Row.Item("Deliverable")) Then Deliverable = Row.Item("Deliverable")
                If Not IsDBNull(Row.Item("SOP")) Then SOP = Row.Item("SOP")
                If Not IsDBNull(Row.Item("SOPVersion")) Then SOPVersion = Row.Item("SOPVersion")
                If Not IsDBNull(Row.Item("Format")) Then Format = Row.Item("Format")
                If Not IsDBNull(Row.Item("Schedule")) Then Schedule = Row.Item("Schedule")
                If Not IsDBNull(Row.Item("Responsibility")) Then Responsibility = Row.Item("Responsibility")
                If Not IsDBNull(Row.Item("Description")) Then Description = Row.Item("Description")
                If Not IsDBNull(Row.Item("Specifications")) Then Specifications = Row.Item("Specifications")
                If Not IsDBNull(Row.Item("FileNamingScheme")) Then FilenamingScheme = Row.Item("FileNamingScheme")

                Me.DSTextBox.AppendText(DeliverableIdentifier & ",")
                Me.DSTextBox.AppendText(Deliverable & ",")
                Me.DSTextBox.AppendText(SOP & ",")
                Me.DSTextBox.AppendText(SOPVersion & ",")
                'Me.DSTextBox.AppendText(Format & ",")
                Me.DSTextBox.AppendText(Schedule & ",")
                Me.DSTextBox.AppendText(Responsibility & ",")
                'Me.DSTextBox.AppendText(Description & ",")
                'Me.DSTextBox.AppendText(Specifications)
                Me.DSTextBox.AppendText(vbNewLine & vbNewLine)
            Next


            ''list out in paragraph format
            'For Each Row As DataRowView In _DeliverablesScheduleDataView
            '    If Not IsDBNull(Row.Item("DeliverableIdentifier")) Then DeliverableIdentifier = Row.Item("DeliverableIdentifier")
            '    If Not IsDBNull(Row.Item("Deliverable")) Then Deliverable = Row.Item("Deliverable")
            '    If Not IsDBNull(Row.Item("SOP")) Then SOP = Row.Item("SOP")
            '    If Not IsDBNull(Row.Item("SOPVersion")) Then SOPVersion = Row.Item("SOPVersion")
            '    If Not IsDBNull(Row.Item("Format")) Then Format = Row.Item("Format")
            '    If Not IsDBNull(Row.Item("Schedule")) Then Schedule = Row.Item("Schedule")
            '    If Not IsDBNull(Row.Item("Responsibility")) Then Responsibility = Row.Item("Responsibility")
            '    If Not IsDBNull(Row.Item("Description")) Then Description = Row.Item("Description")
            '    If Not IsDBNull(Row.Item("Specifications")) Then Specifications = Row.Item("Specifications")
            '    If Not IsDBNull(Row.Item("FileNamingScheme")) Then FilenamingScheme = Row.Item("FileNamingScheme")


            '    Dim D As String = "Deliverable "
            '    D = D & DeliverableIdentifier & ": " & Deliverable & vbNewLine
            '    D = D & "Deliverable " & DeliverableIdentifier & " consists of " & Deliverable & "." & vbNewLine & "  Description " & Description & vbNewLine & ". Schedule: " & Schedule & vbNewLine & ". Responsibility: " & Responsibility & "." & vbNewLine
            '    D = D & "Specifications: " & Specifications & vbNewLine
            '    D = D & "File naming scheme: " & FilenamingScheme & vbNewLine


            '    Me.DSTextBox.AppendText(D & vbNewLine & vbNewLine)
            'Next

            'For Each Col As DataColumn In _DeliverablesScheduleDataView.Table.Columns
            '    Debug.Print("Dim " & Col.ColumnName & " As String = """")"
            'Next

            'For Each Col As DataColumn In _DeliverablesScheduleDataView.Table.Columns
            '    Debug.Print("If Not IsDBNull(Row.Item(""" & Col.ColumnName & """)) Then " & Col.ColumnName & " = Row.Item(""" & Col.ColumnName & """)")
            'Next

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


    Private Sub ReviseDGV()
        Dim i As Integer = 0
        For Each Row As DataRow In ChooserDataTable.Rows
            Me.DeliverablesScheduleDataGridView.Columns(i).Visible = Row.Item(0)
            i = i + 1
        Next

    End Sub

    Private Sub ColumnsChooserDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ColumnsChooserDataGridView.CellEndEdit
        Me.ColumnsChooserDataGridView.EndEdit()
        ReviseDGV()
        Me.DeliverablesScheduleDataGridView.Refresh()
    End Sub
End Class