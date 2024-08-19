Module Savings

    Sub Main()
        Console.Write("Enter monthly saving amount: ")
        Dim monthlySaving As Double = CDbl(Console.ReadLine())

        Console.Write("Enter annual interest rate (in percentage): ")
        Dim annualInterestRate As Double = CDbl(Console.ReadLine()) / 100

        Console.Write("Enter number of months: ")
        Dim numberOfMonths As Integer = CDbl(Console.ReadLine())

        Dim monthlyInterestRate As Double = annualInterestRate / 12
        Dim totalAmount As Double = 0

        For i As Integer = 1 To numberOfMonths
            totalAmount = (totalAmount + monthlySaving) * (1 + monthlyInterestRate)
        Next

        Console.WriteLine("After " & numberOfMonths & " months, the amount in the savings account is " & Math.Round(totalAmount, 2))

        Console.ReadLine()

    End Sub

End Module
