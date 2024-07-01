Public Class Student
    Private name As String
    Private age As Integer

    Public Sub New()
        name = "Jkuat"
        age = "20"
    End Sub
    Public Sub getdetail()
        Console.WriteLine("Enter the name ")
        name = Console.ReadLine()
        Console.WriteLine("Enter the age ")
        age = CInt(Console.ReadLine())
    End Sub
    Public Sub print()
        Console.WriteLine("Name:" & name & " Age:" & age)
    End Sub
    Public WriteOnly Property Proname
        'Get
        '    Return name
        'End Get
        Set(ByVal value)
            If value = "" Then
                Console.WriteLine("name cannot be empty")
                name = "lab 2"
            Else
                name = value

            End If
        End Set
    End Property

    Public Sub New(ByVal n As String, ByVal a As Integer
                    )
        name = n
        age = a
    End Sub
End Class
