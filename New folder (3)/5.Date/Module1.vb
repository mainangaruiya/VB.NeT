Module Module1

    Sub Main()

        Console.Write("Enter month (1-12): ")
            Dim month As Integer = CInt(Console.ReadLine())
            Console.Write("Enter year: ")
            Dim year As Integer = CInt(Console.ReadLine())

            Dim days As Integer = DateTime.DaysInMonth(year, month)
            Console.WriteLine("Number of days in month " & month & " of year " & year & ": " & days)

            Console.ReadLine()


        End Sub

End Module
