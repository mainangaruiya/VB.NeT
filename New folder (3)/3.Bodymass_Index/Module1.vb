Module Module1

    Sub Main()
        Dim height As Double
        Dim weight As Double
        Dim BMI As Double

        Console.Write("Enter height of the patient in meters:")
        height = CDbl(Console.ReadLine())

        Console.Write("Enter weight of the patient in kilograms:")
        weight = CDbl(Console.ReadLine())

        BMI = (weight / (height ^ 2))

        If BMI < 18.5 Then
            Console.Write("BMI = " & BMI & vbTab & "The patient is underweight")
        ElseIf BMI >= 18.5 And BMI < 25.0 Then
            Console.WriteLine("BMI = " & BMI & vbTab & "The patient's BMI is normal")
        ElseIf BMI >= 25.0 And BMI < 30.0 Then
            Console.WriteLine("BMI = " & BMI & vbTab & "The patient is overweight")
        ElseIf BMI > 30 Then
            Console.WriteLine("BMI = " & BMI & vbTab & "The patient is obese")

        End If






    End Sub

End Module
