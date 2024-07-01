Imports System

Module Program
    Sub Main()
        Dim std1 As Student = New Student()
        Dim std2 As Student = New Student("maina", 25)
        std1.print()
        std2.print()

        std2.getdetail()
        std2.print()
        Console.ReadKey()

    End Sub
End Module
