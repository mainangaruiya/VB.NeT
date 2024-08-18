Public MustInherit Class Shape
    Protected area As Double
    Protected perimeter As Double

    Public Overridable Sub print()
        Console.Write("Area = " & area & "perimeter=" & perimeter)

    End Sub
    Public MustOverride Sub getdimension()
    Public MustOverride Sub computearea()
    Public MustOverride Sub computeperimeter()


End Class
