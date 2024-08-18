Public Class overload
    Public Function add(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function
    Public Function add(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer

        Return a + b + c
    End Function
    Public Function add(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer

        Return a + b + c + d
    End Function


End Class
