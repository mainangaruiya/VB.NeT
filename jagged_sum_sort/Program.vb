Imports System

Module Program
    Sub Main()
        Dim row, col, sum
        Dim jagged()() As Integer = New Integer(3)() {}
        jagged(0) = {9, 12, 38, 31}
        jagged(1) = {4}
        jagged(2) = {11, 12, 29}
        jagged(3) = {7, 9}
        For row = LBound(jagged) To UBound(jagged) Step 1
            sum = 0
            For col = LBound(jagged(row)) To UBound(jagged(row)) Step 1
                Console.Write(jagged(row)(col) & vbTab)
                sum = sum + jagged(row)(col)
            Next
            Console.Write("The Sum =" & sum)
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
        Console.ReadKey()
    End Sub
End Module