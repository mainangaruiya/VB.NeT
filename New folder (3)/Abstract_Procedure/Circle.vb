Public Class Circle
    Inherits Shape
    Private radius As Integer

    Public Overrides Sub getdimension()
        Console.WriteLine("Enter the radius : ")
        radius = CInt(Console.ReadLine)
    End Sub

    Public Overrides Sub computearea()
        area = Math.PI * Math.Pow(radius, 2)
    End Sub

    Public Overrides Sub computeperimeter()
        perimeter = Math.PI * radius * 2
    End Sub
End Class
