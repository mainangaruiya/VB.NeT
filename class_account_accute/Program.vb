Imports System

Module Program
    Sub Main()
        Dim actuate1 As Actuate = New Actuate(1122, 2000, 4.5)
        actuate1.Withdrawal(2500)
        actuate1.Withdrawal(3000)
        actuate1.print()

        Console.ReadKey()


    End Sub
End Module
