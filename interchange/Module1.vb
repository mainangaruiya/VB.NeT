Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("Enter the value of a and b")
        a = CInt(Console.ReadLine())
        b = CInt(Console.ReadLine())
        Console.WriteLine("before interchanged a= " & a & "and b =" & b)
        interchange(a, b)
        Console.WriteLine("after interchanged a = " & a & "and b=" & b)
        Console.ReadKey()
    End Sub
    Sub interchange(ByRef x As Integer, ByRef y As Integer) ''PRAMETERS
        Dim empty As Integer
        empty = x
        x = y
        y = empty


    End Sub

End Module
