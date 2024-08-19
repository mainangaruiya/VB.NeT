Module Rectangle
    Private l, w As Double
    Public Sub getdimensions()
        Console.Write("enter the length : ")
        l = CDbl(Console.ReadLine())
        Console.Write(vbNewLine & "Enter the width : ")
        w = CDbl(Console.ReadLine())

    End Sub

    Public Function computearea() As Double
        Return l * w

    End Function

    Public Function computeperimeter() As Double
        Return 2 * (l + w)

    End Function

    Public Sub print()
        Console.WriteLine("Area = " & computearea() & "Perimeter = " & computeperimeter())
    End Sub
End Module
