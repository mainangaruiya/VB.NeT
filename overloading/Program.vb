Sub Main()
    Dim obj As New overload()

    ' Calling each overload of the add function with different parameters
    Dim result1 As Integer = obj.add(1, 2)
    Dim result2 As Integer = obj.add(1, 2, 3)
    Dim result3 As Integer = obj.add(1, 2, 3, 4)

    Console.WriteLine("Result of obj.add(1, 2): " & result1)
    Console.WriteLine("Result of obj.add(1, 2, 3): " & result2)
    Console.WriteLine("Result of obj.add(1, 2, 3, 4): " & result3)

    Console.ReadLine()
End Sub