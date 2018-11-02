Imports Janus.Windows.GridEX

Module ApplicationUtilities
    Public Sub SetUpGridEX(GridEX As GridEX)
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
            '.FilterRowFormatStyle = FilterRowFormatStyle
            .Font = MyFont
            .RowHeaders = InheritableBoolean.True
            .NewRowPosition = NewRowPosition.TopRow
            .SelectOnExpand = False
            .SaveSettings = True
        End With
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GridEX"></param>
    Public Sub FormatOverDueTasks(GridEX As GridEX)
        Try
            'loop through the tasks gridex
            For Each Row As GridEXRow In GridEX.GetRows
                'make sure there is a DateDue column
                If Not Row.Cells("DateDue") Is Nothing Then
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

End Module
