Module Module1

    Sub Main()
        Console.Write("Enter the initial tuition fee: ")
        Dim tuition As Double = CDbl(Console.ReadLine())
        Console.Write("Enter the annual increment percentage: ")
        Dim incrementPercent As Double = CDbl(Console.ReadLine()) / 100

        Dim years As Integer = 0
        Dim initialTuition As Double = tuition
        Do
            tuition += tuition * incrementPercent
            years += 1
        Loop Until tuition >= 2 * initialTuition

        Console.WriteLine("It will take " & years & " years for the tuition to double.")

        Console.ReadLine()

    End Sub

End Module
