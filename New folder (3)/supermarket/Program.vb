Option Explicit Off

Imports System
Imports System.Xml.Serialization
Imports Microsoft.CSharp.RuntimeBinder

Module Program
    Sub Main(args As String())

        Dim i, total, payment, change, points
        Dim item(5) As String ' = {"Sugar", "Rice", "bread", "milk", "cakes", "soap"}
        Dim price(5) As Integer ' = {200, 200, 65, 60, 99, 240}

        For i = LBound(item) To UBound(item) Step 1
            Console.WriteLine("Enter the name of the item picked ")
            item(i) = Console.ReadLine()
            Console.WriteLine("Enter the price for the item :" & item(i))
            price(i) = CInt(Console.ReadLine())


        Next
        total = 0
        For i = LBound(item) To UBound(item) Step 1
            Console.WriteLine(item(i) & vbTab & price(i))
            total = total + price(i)
        Next
        Console.WriteLine("Total cost : " & total)
        Console.WriteLine("Enter the amount tendered : ")
        payment = CInt(Console.ReadLine)
        change = payment - total
        Console.WriteLine("change " & change)
        points = total \ 100
        Console.WriteLine("You have earned " & points & " points")
        Console.ReadKey()




    End Sub
End Module
