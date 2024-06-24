Module Program

    Sub Main(args As String())
        Dim values As Double() = {10.0, 20.0, 30.0}
        Dim modifiedValues As Double() = ModifyValues(values)

        Console.WriteLine("Original values:")
        For i As Integer = 0 To values.Length - 1
            Console.WriteLine($"Value {i + 1}: {values(i)}")
        Next

        Console.WriteLine()

        Console.WriteLine("Modified values:")
        For i As Integer = 0 To modifiedValues.Length - 1
            Console.WriteLine($"Value {i + 1}: {modifiedValues(i)}")
        Next

        Console.ReadLine()
    End Sub

    Function ModifyValues(values As Double()) As Double()
        Dim modified As Double() = New Double(values.Length - 1) {}

        For i As Integer = 0 To values.Length - 1
            Select Case i
                Case 0
                    ' Increase by 10%
                    modified(i) = values(i) * 1.1
                Case 1
                    ' Decrease by 15%
                    modified(i) = values(i) * 0.85
                Case 2
                    ' Multiply by 3
                    modified(i) = values(i) * 3.0
                Case Else
                    modified(i) = values(i)
            End Select
        Next

        Return modified
    End Function

End Module
