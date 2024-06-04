Module VBModule
    Sub Main()
        DIM row,col As Integer
        Dim student() As String = {"sct221-0000/2022","sct221-0001/2022","sct221-0002/2022","sct221-0003/2022"}
        Dim marks(,) As Integer = {{9,23,29,52,35},{4,19,26,48,29},{1,32,27,46,30},{12,28,31,61,28}}
        Console.WriteLine("student REgno          cat1   cat2    cat3    cat4    exam  avg  grade")
        
        
        For row = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.Write(student(row) & vbTab)
            For col = LBound(marks, 2) To UBound(marks, 2) Step 1
                Console.Write(marks(row, col) & vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
