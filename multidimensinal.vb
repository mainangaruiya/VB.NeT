Module VBModule
    Sub Main()
        Dim avgscore As Double
        Dim row, col As Integer
        Dim totalcats As Integer = 0
        Dim project, exam As Integer
        Dim student() As String = {"sct221-0000/2022", "sct221-0001/2022", "sct221-0002/2022", "sct221-0003/2022"}
        Dim marks(,) As Integer = {{9, 23, 29, 52, 35}, {4, 19, 26, 48, 29}, {1, 32, 27, 46, 30}, {12, 28, 31, 61, 28}}
        Console.WriteLine("student REgno          cat1   cat2    cat3    project  exam     avg  grade")
        
        For row = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.Write(student(row) & vbTab)
            For col = LBound(marks, 2) To UBound(marks, 2) Step 1
                Console.Write(marks(row, col) & vbTab)
                If (col <= 2) Then
                    totalcats = totalcats + marks(row, col)
                ElseIf (col = 3) Then
                    project = marks(row, col)
                Else 
                    exam = marks(row, col)
                End If
            Next
            avgscore = ((totalcats / 120) * 20) + ((project / 70) * 10) + exam
            Console.Write(avgscore.ToString("0.00") & vbTab)
            Dim grade As Char
            If (avgscore <= 39) Then
                grade = "E"
            ElseIf (avgscore <= 49) Then
                grade = "D"
            ElseIf (avgscore <= 59) Then
                grade = "C"
            ElseIf (avgscore <= 69) Then
                grade = "B"
            Else 
                grade = "A"
            End If
            Console.Write(grade)
            Console.WriteLine()
        Next
    End Sub
End Module
