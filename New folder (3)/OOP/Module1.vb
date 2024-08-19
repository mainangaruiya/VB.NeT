Module Module1

    ' Private no1, no2 As Integer 'field variables
    Public Sub getnumbers()
        Dim no1, no2 As Integer
        Console.WriteLine("Enter the first number : ")
        no1 = CInt(Console.ReadLine())

        Console.WriteLine("Enter the second number : ")
        no2 = CInt(Console.ReadLine())

    End Sub

    Public Sub display()
        Dim sum As Integer
        ' sum = no1 + no2
        Console.WriteLine("sum = " & sum)

    End Sub





    Sub Main()
        getnumbers()
        display()
        Console.ReadLine()

    End Sub

End Module
