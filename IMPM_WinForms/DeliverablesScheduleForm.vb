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


            ReviseDGV()
        End Set
    End Property


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
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
        Dim Grid As DataGridView = Me.DeliverablesScheduleDataGridView
        'first make unneeded columns invisible
        Dim i As Integer = 0
        For Each Row As DataRow In ChooserDataTable.Rows
            Grid.Columns(i).Visible = Row.Item(0)
            i = i + 1
        Next

        'clean the textbox
        Me.DSTextBox.Text = ""

        'dump out the selected columns to the text box

        'start with the column headers
        Dim Headers As String = ""
        For Each Col As DataGridViewColumn In Grid.Columns
            If Col.Visible = True Then
                Headers = Headers & Col.HeaderText & ","
            End If
        Next
        If Headers.Trim.Length > 0 Then
            Me.DSTextBox.Text = Headers.Trim.Substring(0, Headers.Trim.Length - 1) & vbNewLine
        End If

        'now dump out the visible cells of the deliverables dgv to the textbox
        Dim Specs As String = vbNewLine & vbNewLine & "Deliverable Specifications" & vbNewLine
        For Each Row As DataGridViewRow In Grid.Rows
            Dim RowText As String = ""
            For Each Col As DataGridViewColumn In Grid.Columns
                If Col.Visible = True Then
                    If Not IsDBNull(Row.Cells(Col.Name).Value) Then
                        RowText = RowText & Row.Cells(Col.Name).Value & ","
                    Else
                        RowText = RowText & ","
                    End If
                End If
            Next

            'write the deliverables to the text box
            If RowText.Trim.Length > 0 Then
                Me.DSTextBox.AppendText(RowText.Trim.Substring(0, RowText.Trim.Length - 1) & vbNewLine)
            End If

            'write out extended properties of each deliverable

            Dim ID As String = IIf(IsDBNull(Row.Cells(0).Value) = False, Row.Cells(0).Value.trim, "NULL")
            Dim Deliverable As String = IIf(IsDBNull(Row.Cells(1).Value) = False, Row.Cells(1).Value.trim, "NULL")
            Specs = Specs & ID & vbNewLine & Deliverable & "." & vbNewLine & vbNewLine

        Next

        Me.DSTextBox.AppendText(Specs)
    End Sub

    Private Sub ColumnsChooserDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ColumnsChooserDataGridView.CellEndEdit
        Me.ColumnsChooserDataGridView.EndEdit()

        'Me.DeliverablesScheduleDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Converts a DataTable to a string of delimited values such as CSV
    ''' </summary>
    ''' <param name="DataTable">DataTable to convert. DataTable</param>
    ''' <param name="Delimiter">Values separator</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function DataTableToCSV(DataTable As DataTable, Delimiter As String) As String
        Dim CSV As String = ""
        Try
            'output the headers
            For Each Column As DataColumn In DataTable.Columns
                CSV = CSV & Column.ColumnName & Delimiter
            Next
            CSV = CSV.Substring(0, CSV.Trim.Length - 1) & vbNewLine

            'output the rows
            For Each Row As DataRow In DataTable.Rows
                For Each Column As DataColumn In DataTable.Columns
                    CSV = CSV & Row.Item(Column.ColumnName) & Delimiter
                Next
                CSV = CSV.Substring(0, CSV.Trim.Length - 1) & vbNewLine
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return CSV
    End Function

    Private Sub ColumnsChooserDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ColumnsChooserDataGridView.CellValueChanged
        ReviseDGV()
    End Sub
End Class