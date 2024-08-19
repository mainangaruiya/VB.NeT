Module Module1

    Sub Main()
        Dim average As Double
        Dim grade As Char
        Dim row As Integer, col As Integer
        Dim totalcats As Integer, project As Integer, exam As Integer

        Dim regno(3) As String '= {"sct221-0781/2022", "sct221-0782/2022", "sct221-0783/2022", "sct221-0784/2022"}
        Dim mark(3, 4) As Integer '= {{9, 23, 29, 52, 35}, {4, 19, 24, 48, 29}, {1, 32, 27, 46, 30}, {12, 28, 31, 61, 28}}

        For row = LBound(mark, 1) To UBound(mark, 1) Step 1
            Console.WriteLine("Enter registration number for student" & (row + 1))
            regno(row) = Console.ReadLine

            For col = LBound(mark, 2) To UBound(mark, 2) Step 1
                If (col = 0) Then
                    Console.WriteLine("Enter mark for Cat 1 marks /40")
                    mark(row, col) = CInt(Console.ReadLine())
                ElseIf (col = 1) Then
                    Console.WriteLine("Enter mark for Cat 2 marks /40")
                    mark(row, col) = CInt(Console.ReadLine())

                ElseIf (col = 2) Then
                    Console.WriteLine("Enter mark for Cat 3 marks /40")
                    mark(row, col) = CInt(Console.ReadLine())

                ElseIf (col = 3) Then
                    Console.WriteLine("Enter mark for project /70")
                    mark(row, col) = CInt(Console.ReadLine())
                Else
                    Console.WriteLine("Enter marks for exam /70")
                    mark(row, col) = CInt(Console.ReadLine())
                End If
            Next
        Next

        For row = LBound(mark, 1) To UBound(mark, 1) Step 1
            Console.Write(regno(row) & vbTab)
            totalcats = 0

            For col = LBound(mark, 2) To UBound(mark, 2) Step 1
                Console.Write(mark(row, col) & vbTab)
                If (col <= 2) Then
                    totalcats = totalcats + mark(row, col)
                ElseIf (col = 3) Then
                    project = mark(row, col)
                Else
                    exam = mark(row, col)

                End If
            Next
            average = ((totalcats / 120) * 20) + ((project / 70) * 10) + exam
            Console.Write(Format(average, "0.00") & vbTab)

            If (average <= 39) Then
                grade = CChar("E")
            ElseIf (average <= 49) Then
                grade = CChar("D")
            ElseIf (average <= 59) Then
                grade = CChar("C")
            ElseIf (average <= 69) Then
                grade = CChar("B")
            Else
                grade = CChar("A")


            End If
            Console.Write(grade)
            Console.WriteLine()



        Next
        Console.ReadKey()
    End Sub

End Module
