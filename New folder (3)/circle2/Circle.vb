Public Class Circle
    Private radius As Integer
    Private area, perimeter As Double 'fields


    Public Sub getradius()
        Console.WriteLine("Enter the radius : ") 'sub procedure
        radius = CInt(Console.ReadLine())
    End Sub

    Public Function computearea() As Double
        area = Math.PI * Math.Pow(radius, 2) 'function procedure
        Return area

    End Function

    Public Function computeperimeter() As Double
        perimeter = Math.PI * radius * 2
        Return perimeter

    End Function

    Public Sub print()
        Console.WriteLine("Area = " & computearea() & " Perimeter = " & computeperimeter())
    End Sub
End Class
