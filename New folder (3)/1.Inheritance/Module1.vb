Module Module1

    Sub Main()
        Dim cir1 As Circle = New Circle()
        Dim rect1 As Rectangle = New Rectangle()
        cir1.getdimension()
        cir1.computearea()
        cir1.computeperimeter()
        cir1.print()

        rect1.getdimension()
        rect1.computearea()
        rect1.computeperimeter()
        rect1.print()
        Console.ReadKey()
    End Sub

End Module
