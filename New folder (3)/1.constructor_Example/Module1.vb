Module Module1

    Sub Main()
        Dim std1 As Student = New Student() 'object created using default constructor
        Dim std2 As Student = New Student("Mohammed", 25)
        std1.print()
        std2.print()
        std2.getdetails()
        std2.print()
        std1.print()
        Console.ReadKey()
    End Sub

End Module
