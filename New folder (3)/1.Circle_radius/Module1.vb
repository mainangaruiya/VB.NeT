Module Module1

    Sub Main()
        Dim x As Double
        Dim y As Double
        Dim distance As Double

        Console.Write("Enter the co-ordinate of  x :")
        x = CDbl(Console.ReadLine())

        Console.Write("Enter the co-ordinate of  y :")
        y = CDbl(Console.ReadLine())

        distance = Math.Sqrt(x ^ 2 + y ^ 2)

        If distance <= 10 Then
            Console.WriteLine("The point (" & x & ", " & y & ") is inside the circle.")

        Else
            Console.WriteLine("The point ( " & x & "," & y & ") is inside the circle")
        End If

        Console.ReadKey()


    End Sub

End Module
