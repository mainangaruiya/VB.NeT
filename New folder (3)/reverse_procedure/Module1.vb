Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("Enter the value of a and b") 'arguments
        a = CInt(Console.ReadLine())
        b = CInt(Console.ReadLine())
        Console.WriteLine("Before interchanging a = " & a & " and b = " & b)
        interchange(a, b)
        Console.WriteLine("After interchanging a = " & a & " and b = " & b)
        Console.ReadKey()

    End Sub
    Sub interchange(ByRef x As Integer, ByRef y As Integer) 'parameters change to pointers
        Dim empty As Integer
        empty = x
        x = y
        y = empty
    End Sub

End Module
