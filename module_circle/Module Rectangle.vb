Module Module_Rectangle
    Private l, w As Double
    Public Sub getdimension()
        Console.Write("Enter the length")
        l = CDbl(Console.ReadLine())
        Console.Write("Enter the length")
        w = CDbl(Console.ReadLine())
    End Sub
    Public Function computearea() As Double
        Return l * w
    End Function
    Public Function computeperimeter() As Double
        Return 2 * (l + w)
    End Function
    Public Sub primnt()
        Console.WriteLine("Area = " & computearea(), "perimeter = " & computearea())

    End Sub


End Module
