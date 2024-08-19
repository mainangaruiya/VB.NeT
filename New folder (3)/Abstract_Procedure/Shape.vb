Imports System.Security.Cryptography.X509Certificates

Public MustInherit Class Shape 'Abstract class - incomplete class and you cant create an object from an abstract class
    Protected area As Double
    Protected perimeter As Double
    Public Overridable Sub print()
        Console.WriteLine("Area = " & area & "Perimeter = " & perimeter)

    End Sub
    Public MustOverride Sub getdimension()
    Public MustOverride Sub computearea()
    Public MustOverride Sub computeperimeter()


End Class
