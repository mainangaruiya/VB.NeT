Module Module1

    Sub Main()

        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double

        Console.WriteLine("Enter value 1:")
        num1 = CDbl(Console.ReadLine())

        Console.WriteLine("Enter value 2:")
        num2 = CDbl(Console.ReadLine())

        Console.WriteLine("Enter value 3:")
        num3 = CDbl(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine("Original values:")
        Console.WriteLine("Value 1: " & num1)
        Console.WriteLine("Value 2: " & num2)
        Console.WriteLine("Value 3: " & num3)

        Modify(num1, num2, num3)

        Console.WriteLine()
        Console.WriteLine("Modified values:")
        Console.WriteLine("Value 1: " & num1)
        Console.WriteLine("Value 2: " & num2)
        Console.WriteLine("Value 3: " & num3)

        Console.ReadLine()
        End Sub

    Sub Modify(ByRef number1 As Double, ByRef number2 As Double, ByRef number3 As Double)
        number1 = number1 * 1.1
        number2 = number2 * 0.85
        number3 = number3 * 3
    End Sub



End Module
