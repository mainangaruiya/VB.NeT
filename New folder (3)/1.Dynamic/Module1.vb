Module Module1

    Sub Main()
        Dim i As Integer
        Dim j As Integer
        Dim x(,) As Integer = {{20, 30, 35}, {23, 40, 59}}
        For i = LBound(x, 1) To UBound(x, 1) Step 1

            For j = LBound(x, 2) To UBound(x, 2) Step 1
                Console.Write(x(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next

        Console.WriteLine(vbNewLine & "Creating a new array")

        ReDim Preserve x(1, 3)

        For i = LBound(x, 1) To UBound(x, 1) Step 1

            For j = LBound(x, 2) To UBound(x, 2) Step 1
                Console.Write(x(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
