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
End Module
