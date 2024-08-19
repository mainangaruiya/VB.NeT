Public Class overload
    Public Function add(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    Public Function add(ByVal a As Integer, ByVal b As Integer, c As Integer) As Integer
        Return a + b + c
    End Function
    Public Function add(ByVal a As String, ByVal b As String) As String
        Return a + b
    End Function

End Class
