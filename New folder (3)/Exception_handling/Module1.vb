Module Module1

    Sub Main()
        Dim a As Integer, b As Integer, c As Integer
        Dim proceed As Boolean = True


        Do
            Try
                Console.WriteLine("Enter the values of a and b respectively : ")

                a = CInt(Console.ReadLine()) 'if  a is correct dont ask for a agai only ask for b ,listen to source of exception redirect program to source of exception
                b = CInt(Console.ReadLine())
                c = a / b

                Console.WriteLine("C = " & c)

                proceed = False
                'Catch ex1 As System.OverflowException
                '    Console.WriteLine(ex1.Message)
                'Catch ex2 As System.InvalidCastException
                '    Console.WriteLine(ex2.Message)
                'Catch ex3 As System.DivideByZeroException
                '    Console.WriteLine(ex3.Message)

            Catch ex As System.Exception
                Console.WriteLine(ex.Message)

            Finally
                Console.WriteLine("The objective is to divide 2 numbers ")

            End Try
        Loop While (proceed = True)
        Console.ReadKey()



    End Sub

End Module
