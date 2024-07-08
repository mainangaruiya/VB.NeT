Public MustInherit Class Account
    Protected id As Integer
    Protected balance As Integer
    Protected annualIntrestrate As Double
    Protected datecreated As Date

    Public Function getmonthlyIntrestRate() As Double
        Dim monthlyintrestrate As Double
        monthlyintrestrate = (annualIntrestrate / 12) / 100.0
        Return monthlyintrestrate
    End Function
    Public Function getmonthlyintrest() As Double
        Dim monthlyintrest As Double
        monthlyintrest = balance * getmonthlyIntrestRate()
        Return getmonthlyintrest
    End Function
    Public MustOverride Sub Withdrawal(amount As Double)
    Public MustOverride Sub deposit(amount As Double)


End Class
