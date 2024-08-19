Module Module1

    Sub Main()
        Dim x As Double
        Dim y As Double

        Console.WriteLine("Enter the coordinate for :")
        x = CDbl(Console.ReadLine())

        Console.WriteLine("Enter the coordinate for :")
        y = CDbl(Console.ReadLine())


        Select Case True
            Case x > 0 And y > 0
                Console.WriteLine("The cordinate " & x & "," & y & " is in the first quadrant")
            Case x < 0 And y > 0
                Console.WriteLine("The cordinate " & x & "," & y & " is in the second quadrant")
            Case x < 0 And y < 0
                Console.WriteLine("The cordinate " & x & "," & y & " is in the third quadrant")
            Case x > 0 And y < 0
                Console.WriteLine("The cordinate " & x & "," & y & " is in the fourth quadrant")

        End Select

        Console.ReadKey()

    End Sub

End Module
