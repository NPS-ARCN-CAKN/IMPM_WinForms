Imports System.Data.SqlClient
Imports Janus.Windows.GridEX

Module ApplicationUtilities
    Public Sub SetUpGridEX(GridEX As GridEX)
        Try
            'set up the gridex
            Dim MyFont As New Font("Sans Serif", 10, FontStyle.Regular)
            Dim MyFormatStyle As New GridEXFormatStyle()
            With MyFormatStyle
                .Font = MyFont
                .TextAlignment = TextAlignment.Near
            End With

            'filter row style
            Dim FilterRowFont As New Font("Sans Serif", 10, FontStyle.Italic)
            Dim FilterRowFormatStyle As New GridEXFormatStyle()
            With FilterRowFormatStyle
                .Font = MyFont
                .TextAlignment = TextAlignment.Near
                .BackColor = Color.LightYellow
            End With

            'sometimes the column widths get blown out
            'For Each Col As GridEXColumn In GridEX.RootTable.Columns
            '    With Col
            '        .Width = 100
            '        .MaxLength = 800
            '        .MaxLines = 100
            '        .WordWrap = True
            '    End With
            'Next

            'set up the gridex
            With GridEX
                .AlternatingColors = True
                .ColumnAutoSizeMode = ColumnAutoSizeMode.DiaplayedCells
                '.ColumnAutoResize = True
                .Font = MyFont
                .RowHeaders = InheritableBoolean.True
                .NewRowPosition = NewRowPosition.BottomRow
                .SelectOnExpand = False
                .SaveSettings = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


    ''' <summary>
    ''' Runs the query in Sql against a database using ConnectionString and returns the results as a DataTable
    ''' </summary>
    ''' <param name="ConnectionString"></param>
    ''' <param name="Sql"></param>
    ''' <returns>DataTable</returns>
    Public Function GetDataTable(ConnectionString As String, Sql As String) As DataTable

        'the DataTable to return
        Dim MyDataTable As New DataTable
        Try
            'make a SqlConnection using the supplied ConnectionString 
            Dim MySqlConnection As New SqlConnection(ConnectionString)
            Using MySqlConnection
                'make a query using the supplied Sql
                Dim MySqlCommand As SqlCommand = New SqlCommand(Sql, MySqlConnection)

                'open the connection
                MySqlConnection.Open()

                'create a DataReader and execute the SqlCommand
                Dim MyDataReader As SqlDataReader = MySqlCommand.ExecuteReader()

                'load the reader into the datatable
                MyDataTable.Load(MyDataReader)

                'clean up
                MyDataReader.Close()
                MySqlConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Error: Query on " & ConnectionString & " failed. " & ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try

        'return the datatable
        Return MyDataTable
    End Function

    ''' <summary>
    ''' Compares the date value of of the DateDue column of each row in GridEX to Now and sets the OverDue cell value to True where the current date is greater than DateDue. GridEX must contain columns DateDue (Date) and Overdue (boolean)
    ''' </summary>
    ''' <param name="GridEX"></param>
    Public Sub FormatOverDueTasks(GridEX As GridEX)
        Try
            'loop through the tasks gridex
            For Each Row As GridEXRow In GridEX.GetRows
                'make sure there is a DateDue column
                If Not Row.Cells("DateDue") Is Nothing And Not Row.Cells("Overdue") Is Nothing Then
                    'finished tasks have DateDue filled in (not Null) so eliminate finished tasks
                    If Not IsDBNull(Row.Cells("DateDue").Value) = True Then
                        'make sure DueDate is actually a date
                        If IsDate(Row.Cells("DateDue").Value) = True Then
                            Dim DueDateString As String = Row.Cells("DateDue").Value
                            Dim DueDate As DateTime = CDate(DueDateString)
                            Row.BeginEdit()

                            'i had a lot of trouble trying to format the backcolor of overdue rows directly so I ended up putting an Overdue column in the 
                            'GridEX and then using the GridEX designer to put a format condition based on the value of the Overdue column.
                            Row.Cells("Overdue").Value = DueDate < Now
                            Row.EndEdit()
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Updates GridEX's RecordUpdatedDate and RecordUpdatedBy current cells with the current date and user name.  Fire on CellEdited event.
    ''' </summary>
    ''' <param name="GridEX"></param>
    Public Sub UpdateRecordUpdatedFields(GridEX As GridEX)
        Try
            If Not GridEX.CurrentRow.Cells("RecordUpdatedDate") Is Nothing And Not GridEX.CurrentRow.Cells("RecordUpdatedBy") Is Nothing Then
                GridEX.CurrentRow.Cells("RecordUpdatedDate").Value = Now
                GridEX.CurrentRow.Cells("RecordUpdatedBy").Value = My.User.Name
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


    Public Function GetVitalSignSummary(VSID As Integer) As String
        Dim PS As String = ""
        Try
            If VSID > 0 Then
                Dim Sql As String = "SELECT [Network]
      ,[Acronym]
      ,[VitalSign]
      ,[Status]
      ,[ProjectLeader]
      ,[Email]
      ,[DatabaseServer]
      ,[DatabaseName]
      ,[DatabaseFilename]
      ,[FileSharePath]
      ,[ApplicationOverview]
      ,[VSDataManagementOverview]
      ,[DataManagementOverview]
      ,[IRMAProjectReference]
      ,[IRMAProtocolTrackerID]
      ,[DataManagementLead]
      ,[DatabaseOverview]
      ,[DevDatabaseServer]
      ,[DevDatabaseName]
      ,[Notes]
      ,[FilesDirectory]
      ,[URLMoreInfo]
      ,[ImplementationDate]
      ,[ProjectLeadContactID]
      ,[NetworkID]
      ,[VSID]
      ,[VSDMID]
  FROM [AKRO].[dbo].[vwDataManagementSummary] 
  WHERE VSID = " & VSID

                'VS overview
                Dim DMOverviewDataTable As DataTable = GetDataTable(My.Settings.AKROConnectionString, Sql)
                If DMOverviewDataTable.Rows.Count = 1 Then
                    Dim Row As DataRow = DMOverviewDataTable.Rows(0)
                    PS = "Vital Sign Summary: " & Row.Item("VitalSign") & vbNewLine & vbNewLine
                    PS = PS & "Status: " & Row.Item("Status") & vbNewLine
                    PS = PS & "Project Leader: " & Row.Item("ProjectLeader") & vbNewLine
                    PS = PS & "IRMA ProjectReference: " & My.Settings.IRMADataStoreURLPrefix & Row.Item("IRMAProjectReference") & vbNewLine
                    PS = PS & "IRMA ProtocolTracker ID: " & My.Settings.IRMAProtocolTrackerURLPrefix & Row.Item("IRMAProtocolTrackerID") & vbNewLine
                    PS = PS & "Files Directory: " & Row.Item("FilesDirectory") & vbNewLine
                    PS = PS & "Web: " & Row.Item("URLMoreInfo") & vbNewLine
                    PS = PS & "Implementation Date: " & Row.Item("ImplementationDate") & vbNewLine

                    'PROTOCOLS
                    Dim ProtocolsDataTable As DataTable = GetDataTable(My.Settings.AKROConnectionString, "SELECT Citation, Version, IRMAReferenceCode, PIPSourceReferenceCode, DQSReferenceCode, QAPReferenceCode, ProtocolNotes, '" & My.Settings.IRMAProtocolTrackerURLPrefix & "' + Convert(Varchar(20),IRMAProtocolTrackerID) As ProtocolTracker, [Status],ProtocolID
FROM            vwVitalSignProtocols 
WHERE        (VSID = " & VSID & ") ORDER BY Version DESC ")
                    PS = PS & vbNewLine & "Protocols" & vbNewLine & vbNewLine
                    For Each PRow As DataRow In ProtocolsDataTable.Rows
                        PS = PS & PRow.Item("Citation") & vbTab & PRow.Item("Version") & vbNewLine
                        Dim ProtocolID = PRow.Item("ProtocolID")

                        'DELIVERABLES
                        Dim DeliverablesDataTable As DataTable = GetDataTable(My.Settings.AKROConnectionString, "SELECT DeliverableIdentifier,Deliverable,Format,Schedule FROM vwProtocolDeliverables WHERE ProtocolID = " & ProtocolID)
                        PS = PS & vbNewLine & "Protocol deliverables" & vbNewLine
                        PS = PS & DumpDataTableToText(DeliverablesDataTable, "|")
                        'For Each DRow As DataRow In DeliverablesDataTable.Rows
                        '    PS = PS & DRow.Item("DeliverableIdentifier") & vbTab & DRow.Item("Deliverable") & vbTab & DRow.Item("Format") & vbTab & DRow.Item("Schedule") & vbNewLine
                        'Next
                        PS = PS & vbNewLine

                        'RemeasurementS
                        PS = PS & vbNewLine & "Protocol remeasurements" & vbNewLine
                        Dim RemeasurementsQuery As String = "SELECT RemeasurementDescription
--, BeginDate, EndDate
, DeliverablesIRMAReferenceCode, RemeasurementNotes
                        FROM            vwProtocolRemeasurements WHERE ProtocolID = " & ProtocolID & "ORDER BY BeginDate DESC "
                        Dim RemeasurementsDataTable As DataTable = GetDataTable(My.Settings.AKROConnectionString, RemeasurementsQuery)
                        PS = PS & DumpDataTableToText(RemeasurementsDataTable, "|")
                        '                        PS = PS & vbNewLine & "Remeasurements" & vbNewLine
                        '                        For Each RRow As DataRow In RemeasurementsDataTable.Rows
                        '                            PS = PS & RRow.Item("RemeasurementDescription") & vbTab & RRow.Item("BeginDate") & vbTab & RRow.Item("EndDate") & vbTab & RRow.Item("DeliverablesIRMAReferenceCode") & vbNewLine
                        '                        Next
                        PS = PS & vbNewLine & vbNewLine
                    Next

                    PS = PS & vbNewLine & vbNewLine
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        Return PS
    End Function

    ''' <summary>
    ''' Dumps out a DataTable into a more readable text format.
    ''' </summary>
    ''' <param name="Table">DataTable to dump.</param>
    ''' <param name="Delimiter">Delimiter.</param>
    ''' <returns></returns>
    Public Function DumpDataTableToText(Table As DataTable, Delimiter As String) As String
        Dim Dump As String = ""
        Delimiter = Delimiter.Trim
        Try
            If Not Table Is Nothing And Delimiter.Trim.Length > 0 Then
                'build up the header row
                Dim HeaderRow As String = ""
                For Each Col As DataColumn In Table.Columns
                    HeaderRow = HeaderRow & Col.ColumnName.Trim & Delimiter
                Next
                Dump = HeaderRow.Substring(0, HeaderRow.Trim.Length - 1).Trim & vbNewLine

                'dump out the rows
                For Each Row As DataRow In Table.Rows
                    Dim RowText As String = ""

                    For Each Col As DataColumn In Table.Columns
                        RowText = RowText & Row.Item(Col).ToString & Delimiter
                    Next
                    Dump = Dump & RowText.Substring(0, RowText.Trim.Length - 1).Trim & vbNewLine 'trim trailing delimiter
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        Return Dump
    End Function

End Module
