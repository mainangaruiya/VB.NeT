Imports System.Runtime.Remoting.Channels

Module Module1

    Sub Main()
        Dim row As Integer
        Dim col As Integer
        Dim sum As Integer
        Dim jagged()() As Integer = New Integer(3)() {({9, 12, 38, 31}), ({4}), ({11, 12, 29}), ({7, 9})}

        For row = LBound(jagged) To UBound(jagged) Step 1
            sum = 0
            For col = LBound(jagged(row)) To UBound(jagged(row)) Step 1
                Console.Write(jagged(row)(col) & vbTab)
                sum = sum + jagged(row)(col)
            Next
            'Console.Write("The sum  = " & sum)
            Console.WriteLine()
        Next


        For row = LBound(jagged) To UBound(jagged) Step 1
            Array.Sort(jagged(row))
            Array.Reverse(jagged(row))
            For col = LBound(jagged(row)) To UBound(jagged(row)) Step 1
                Console.Write(jagged(row)(col) & vbTab)

            Next

            Console.WriteLine()
        Next
    End Sub

End Module
