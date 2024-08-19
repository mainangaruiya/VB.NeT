Public Class Student
    Private name As String
    Private age As Integer

    Public Sub New()
        name = "jkuat"
        age = 20
    End Sub
    Public Sub New(ByVal n As String, ByVal a As Integer)
        name = n
        age = a

    End Sub
    Public Sub getdetails()
        Console.WriteLine("Enter the name ")
        ProName = Console.ReadLine()
        Console.WriteLine("Enter the age ")
        age = CInt(Console.ReadLine())

    End Sub
    Public Sub print()
        Console.WriteLine("Name : " & ProName & vbNewLine & "Age : " & age)
    End Sub

    Public writeOnly Property ProName 'indirect access
        Get
            Return name
        End Get
        Set(ByVal value)

            If value = "" Then
                Console.WriteLine("Name cannot be empty ")
                name = "Lab 2"
            Else
                name = value
            End If


        End Set
    End Property
End Class