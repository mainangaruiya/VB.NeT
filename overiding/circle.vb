Imports System.Reflection.Metadata

Inherits shape
Private radius As Integer

Public Sub getdimensions()
    Console.Write("Enter radius:")
    radius = CInt(Console.ReadLine())
End Sub
Public Sub computearea()
    area = Math.PI * Math.Pow(radius, 2)
End Sub
Public Sub computeperimeter()
    perimeter = Math.PI * radius * 2
End Sub
End Class