Public MustInherit Class Account
    Protected id As Integer
    Protected balance As Double
    Protected annualInterestRate As Double
    Protected dateCreated As Date

    Public Function getMonthlyInterestRate() As Double
        Dim monthlyInterestRate As Double
        monthlyInterestRate = (annualInterestRate / 12) / 100
        Return monthlyInterestRate
    End Function
    Public Function getMonthlyInterest() As Double
        Dim monthlyInterest As Double
        monthlyInterest = balance * getMonthlyInterestRate()
        Return monthlyInterest
    End Function

    Public MustOverride Sub withdraw(ByVal amount As Double)
    Public MustOverride Sub deposit(ByVal amount As Double)



End Class
