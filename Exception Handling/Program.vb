Imports System
Imports System.Threading

Module Program
    Sub Main()
        Dim proceed As Boolean = true
        Dim a, b, c As Integer
        Do
            Try
                Console.WriteLine("Enter first number a: ")
                a = CInt(Console.ReadLine())
                Console.WriteLine("Enter first number b: ")
                b = CInt(Console.ReadLine())
                c = a \ b
                proceed = False
                Console.WriteLine("c = " & c)
                'Catch ex1 As System.OverflowException
                '    Console.WriteLine(ex1.Message)
                'Catch ex2 As System.InvalidCastException
                '    Console.WriteLine(ex2.Message)
                'Catch ex3 As System.DivideByZeroException
                '    Console.WriteLine(ex3.Message)
            Catch ex As System.Exception
                Console.WriteLine(ex.Message)
            Finally
                Console.WriteLine("the objective is to divide two numbers")
            End Try
        Loop While (proceed)
        Console.ReadKey()
    End Sub
End Module
