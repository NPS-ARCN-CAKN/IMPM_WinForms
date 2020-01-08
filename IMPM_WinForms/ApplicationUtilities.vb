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

End Module
