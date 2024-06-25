Module Module1
    Private no1, no2 As Integer
    Public Sub getnumbers() ''member 1
        Console.WriteLine("Enter first number")
        no1 = CInt(Console.ReadLine())
        Console.WriteLine("Enter second number")
        no2 = CInt(Console.ReadLine())
    End Sub
    Public Sub display()
        Dim sum As Integer
        sum = no1 + no2
        Console.WriteLine("sum = " & sum)
    End Sub

    Sub Main()
        getnumbers()
        display()
        Console.ReadKey()

    End Sub

End Module
