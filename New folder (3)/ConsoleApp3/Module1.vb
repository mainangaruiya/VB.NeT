Module Module1



    Sub Main()

        Dim average As Double
        Dim grade As Char
        Dim row As Integer, col As Integer
        Dim totalcats As Integer, project As Integer, exam As Integer

        Dim regno() As String = {"sct221-0781/2022", "sct221-0782/2022", "sct221-0783/2022", "sct221-0784/2022"}
        Dim mark(,) As Integer = {{9, 23, 29, 52, 35}, {4, 19, 24, 48, 29}, {1, 32, 27, 46, 30}, {12, 28, 31, 61, 28}}

        For row = LBound(mark, 1) To UBound(mark, 1) Step 1
            Console.Write(regno(row) & vbTab)
            totalcats = 0

            For col = LBound(mark, 2) To UBound(mark, 2) Step 1
                Console.Write(mark(row, col) & vbTab)
                If (col <= 2) Then
                    totalcats = totalcats + mark(row, col)
                ElseIf (Col = 3) Then
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



        'For i = LBound(regno) To UBound(regno)

        '    Console.WriteLine("Enter marks for student " & regno(i) & ":")
        '    For j = 0 To 2
        '        Console.Write("Enter marks for CAT " & (j + 1) & " (out of 40): ")
        '        mark(i, j) = CInt(Console.ReadLine())
        '    Next

        '    Console.Write("Enter marks for Project (out of 70): ")
        '    mark(i, 3) = CInt(Console.ReadLine())
        '    Console.Write("Enter marks for Exams (out of 70): ")
        '    mark(i, 4) = CInt(Console.ReadLine())
        'Next


        'For i = LBound(regno) To UBound(regno)
        '        total = 0

        '        For j = 0 To 2
        '            total += mark(i, j) * 0.33
        '        Next

        '        total += mark(i, 4) * 0.5
        '        total += mark(i, 5) * 0.5


        '        average = total


        '        Select Case average
        '            Case >= 70
        '                grade = "A"
        '            Case >= 60
        '                grade = "B"
        '            Case >= 50
        '                grade = "C"
        '            Case >= 40
        '                grade = "D"
        '            Case Else
        '                grade = "F"
        '        End Select


        '        Console.WriteLine("Reg No: " & regno(i) & ", Total Marks: " & total & ", Grade: " & grade)
        '    Next


        Console.ReadLine()


        End Sub

End Module
