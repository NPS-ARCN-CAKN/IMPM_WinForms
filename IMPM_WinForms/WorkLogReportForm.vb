Public Class WorkLogReportForm

    Public Sub New(WorkLogDataTable As DataTable, VSID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' dump out the work log
        Try
            'isolate the work log items to just the current vs
            Dim WorkLogDataView As New DataView(WorkLogDataTable, "VSID=" & VSID.ToString, "LogDate DESC", DataViewRowState.CurrentRows)

            'convert the dataview back to a datatable
            Dim WLDT As DataTable = WorkLogDataView.ToTable

            'ensure the columns we need exist
            If Not WLDT.Columns("Username") Is Nothing And Not WLDT.Columns("LogDate") Is Nothing And Not WLDT.Columns("LogEntry") Is Nothing Then
                'loop through the rows and dump it out
                For Each Row As DataRow In WLDT.Rows
                    Dim UserName As String = Row.Item("UserName").ToString
                    Dim LogDate As String = Row.Item("LogDate").ToString
                    Dim LogEntry As String = Row.Item("LogEntry").ToString
                    Me.WorkLogReportTextBox.AppendText(LogDate & " (" & UserName & ")" & vbNewLine & LogEntry & vbNewLine & vbNewLine)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub


End Class