Option Explicit Off
Imports System

Module Program
    Sub Main()
        Dim x(,) As Integer = {{20, 30, 40}, {51, 52, 53}}
        
        ' Print the original array
        For i = LBound(x, 1) To UBound(x, 1) Step 1
            For j = LBound(x, 2) To UBound(x, 2) Step 1
                Console.Write(x(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next
        
        Console.WriteLine(vbNewLine & "Creating a new array")
        
        ' Create a new larger array
        Dim newX(2, 2) As Integer
        
        ' Copy the original elements to the new array
        For i As Integer = 0 To Math.Min(UBound(x, 1), UBound(newX, 1))
            For j As Integer = 0 To Math.Min(UBound(x, 2), UBound(newX, 2))
                newX(i, j) = x(i, j)
            Next
        Next
        
        ' Assign the new array back to x
        x = newX
        
        ' Print the resized array
        For i = LBound(x, 1) To UBound(x, 1) Step 1
            For j = LBound(x, 2) To UBound(x, 2) Step 1
                Console.Write(x(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next
        
        Console.ReadKey()
    End Sub
End Module
