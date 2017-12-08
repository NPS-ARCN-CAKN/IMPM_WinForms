Public Class DeliverablesScheduleForm
    Private _DeliverablesScheduleDataView As DataView

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
            For Each Row As DataRowView In _DeliverablesScheduleDataView
                Dim DeliverableIdentifier As String = ""
                If Not IsDBNull(Row.Item("DeliverableIdentifier")) Then DeliverableIdentifier = Row.Item("DeliverableIdentifier")

                Dim Deliverable As String = ""
                If Not IsDBNull(Row.Item("Deliverable")) Then Deliverable = Row.Item("Deliverable")

                Dim SOP As String = ""
                If Not IsDBNull(Row.Item("SOP")) Then SOP = Row.Item("SOP")

                Dim SOPVersion As String = ""
                If Not IsDBNull(Row.Item("SOPVersion")) Then SOPVersion = Row.Item("SOPVersion")

                Dim Format As String = ""
                If Not IsDBNull(Row.Item("Format")) Then Format = Row.Item("Format")

                Dim Schedule As String = ""
                If Not IsDBNull(Row.Item("Schedule")) Then Schedule = Row.Item("Schedule")

                Dim Responsibility As String = ""
                If Not IsDBNull(Row.Item("Responsibility")) Then Responsibility = Row.Item("Responsibility")

                Dim Description As String = ""
                If Not IsDBNull(Row.Item("Description")) Then Description = Row.Item("Description")

                Dim Specifications As String = ""
                If Not IsDBNull(Row.Item("Specifications")) Then Specifications = Row.Item("Specifications")

                Me.DSTextBox.AppendText(DeliverableIdentifier & ",")
                Me.DSTextBox.AppendText(Deliverable & ",")
                Me.DSTextBox.AppendText(SOP & ",")
                Me.DSTextBox.AppendText(SOPVersion & ",")
                'Me.DSTextBox.AppendText(Format & ",")
                Me.DSTextBox.AppendText(Schedule & ",")
                Me.DSTextBox.AppendText(Responsibility & ",")
                'Me.DSTextBox.AppendText(Description & ",")
                'Me.DSTextBox.AppendText(Specifications)
                Me.DSTextBox.AppendText(vbNewLine)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub
End Class