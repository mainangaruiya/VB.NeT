Option Explicit Off ' Option Explicit is turned off

Module Program
    Sub Main()
        Dim item() As String 
        Dim price() As Integer

        Console.WriteLine("Enter the number of items: ")
        Dim numItems As Integer = CInt(Console.ReadLine()) ' Prompt for the number of items

        ReDim item(numItems - 1) ' Resize arrays based on the number of items
        ReDim price(numItems - 1)

        For i As Integer = LBound(item) To UBound(item) ' Loop through each item
            Console.WriteLine("Enter the name of item #" & (i + 1) & ":")
            item(i) = Console.ReadLine() ' Read item name
            Console.WriteLine("Enter the price of " & item(i) & ":")
            price(i) = CInt(Console.ReadLine()) ' Read item price
        Next

        Dim total As Integer = 0 ' Initialize total to 0

        For i As Integer = 0 To UBound(item) ' Loop through each item
            Console.WriteLine(item(i) & vbTab & price(i)) ' Output item name and price
            total += price(i) ' Accumulate total price
        Next

        Console.WriteLine("Total cost: " & total) ' Output total cost

        Console.WriteLine("Enter amount paid:")
        Dim payment As Integer = CInt(Console.ReadLine()) ' Read payment amount

        Dim change As Integer = payment - total ' Calculate change
        Console.WriteLine("Change: " & change) ' Output change
        Console.ReadKey()

    End Sub
End Module
