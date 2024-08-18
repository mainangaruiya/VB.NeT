Module Module1

    Sub Main()
        Dim item() As String = {"sugar", "Rice", "bread", "Milk", "Cakes", "Soap"}
        Dim price() As Integer = {200, 200, 65, 60, 99, 240}
        Dim total As Integer = 0
        Dim payment As Integer
        Dim change As Integer

        For i = 0 To 5 Step 1
            Console.WriteLine(item(i) & vbTab & price(i))
            total = total + price(i)
        Next
        Console.WriteLine("Total cost: " & total)
        Console.WriteLine("Enter amount paid")
        payment = CInt(Console.ReadLine())
        change = payment - total
        Console.WriteLine("Change: " & change)
        Console.ReadKey()
    End Sub

End Module
