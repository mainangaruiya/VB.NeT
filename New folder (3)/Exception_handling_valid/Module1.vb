Module Module1

    Sub Main()

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim proceed As Boolean = True
        Dim validA As Boolean = False

        Do
            Try
                If validA = False Then
                    Console.WriteLine("Enter the value of a: ")
                    a = CInt(Console.ReadLine())
                    validA = True
                End If

                Console.WriteLine("Enter the value of b: ")
                b = CInt(Console.ReadLine())
                c = a / b

                Console.WriteLine("C = " & c)
                proceed = False
            Catch ex As OverflowException
                Console.WriteLine("Overflow error: " & ex.Message)
                validA = False
            Catch ex As InvalidCastException
                Console.WriteLine("Invalid input: " & ex.Message)
                validA = False
            Catch ex As DivideByZeroException
                Console.WriteLine("Cannot divide by zero: " & ex.Message)
            Catch ex As Exception
                Console.WriteLine("An error occurred: " & ex.Message)
                validA = False
            Finally
                Console.WriteLine("The objective is to divide 2 numbers.")
            End Try
        Loop While proceed

        Console.ReadKey()
    End Sub

End Module
