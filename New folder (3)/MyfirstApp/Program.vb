Imports System

Module Program
    Sub Main(args As String())
        Dim dob As Date
        Dim age As Integer
        Console.WriteLine("Enter your date of birth")
        dob = CDate(Console.ReadLine())
        age = Now().Year - dob.Year
        Console.WriteLine("your age = " & age)
        Console.ReadKey()







    End Sub
End Module
