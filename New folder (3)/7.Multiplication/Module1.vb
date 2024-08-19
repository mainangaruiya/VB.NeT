Module Multiplication

    Sub Main()

        Console.WriteLine("Using Do...While loop:")
        Dim i As Integer = 1
        Do While i <= 7
            Dim j As Integer = 1
            Do While j <= 7
                Console.Write((i * j).ToString().PadLeft(4) & " ")
                j += 1
            Loop
            Console.WriteLine()
            i += 1
        Loop

        Console.WriteLine("Using While loop:")
        i = 1
        While i <= 7
            Dim j As Integer = 1
            While j <= 7
                Console.Write((i * j).ToString().PadLeft(4) & " ")
                j += 1
            End While
            Console.WriteLine()
            i += 1
        End While

        Console.WriteLine("Using For loop:")
        For i = 1 To 7
            For j = 1 To 7
                Console.Write((i * j).ToString().PadLeft(4) & " ")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()

    End Sub

End Module
