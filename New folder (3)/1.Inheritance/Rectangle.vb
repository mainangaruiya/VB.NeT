Public Class Rectangle
    Inherits Shape
    Private length As Double
    Private width As Double

    Public Sub getdimension()
        Console.WriteLine("Enter the length of the rectangle : ")
        length = CDbl(Console.ReadLine())
        Console.WriteLine("Enter the width of the rectangle  : ")
        width = CDbl(Console.ReadLine())
    End Sub
    Public Sub computearea()
        area = length * width
    End Sub

    Public Sub computeperimeter()
        perimeter = 2 * (length + width)
    End Sub

End Class
