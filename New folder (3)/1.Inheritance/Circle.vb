Public Class Circle
    Inherits Shape
    Private radius As Integer
    Public Sub getdimension()
        Console.Write("Enter the radius : ")
        radius = CInt(Console.ReadLine())
    End Sub
    Public Sub computearea()
        area = Math.PI * Math.Pow(radius, 2)
    End Sub
    Public Sub computeperimeter()
        perimeter = Math.PI * radius * 2
    End Sub
    Public Overrides Sub print()
        Console.WriteLine()
        Console.WriteLine("Area of a circle " & area)
        Console.WriteLine("And its Perimeter " & perimeter)
    End Sub
End Class
