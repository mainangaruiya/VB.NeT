Module Module1

    Sub Main()
        Dim example As Actuate = New Actuate(1122, 20000, 4.5)
        example.withdraw(2500)
        example.deposit(3000)
        example.print()
        Console.ReadKey()

    End Sub

End Module
