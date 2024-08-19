Public Class Actuate
    Inherits Account

    Public Overrides Sub withdraw(amount As Double)
        Pro_balance = Pro_balance - amount
    End Sub

    Public Overrides Sub deposit(amount As Double)
        Pro_balance = Pro_balance + amount
    End Sub

    Public Sub New()
        Pro_id = 1100
        Pro_balance = 5000
        Pro_annualInterestRate = 2.5
        dateCreated = Now()
    End Sub

    Public Sub New(ByVal accid As Integer, ByVal accbal As Double, ByVal annualIRate As Double)
        Pro_id = accid
        Pro_balance = accbal
        Pro_annualInterestRate = annualIRate
        dateCreated = Now()

    End Sub

    Public Property Pro_id
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property Pro_balance
        Get
            Return balance
        End Get
        Set(value)
            balance = value
        End Set
    End Property

    Public Property Pro_annualInterestRate
        Get
            Return annualInterestRate
        End Get
        Set(value)
            annualInterestRate = value
        End Set
    End Property

    Public ReadOnly Property Pro_dateCreated
        Get
            Return dateCreated
        End Get

    End Property

    Public Sub print()
        Console.WriteLine("Account id : " & Pro_id)
        Console.WriteLine("Date created : " & Pro_dateCreated)
        Console.WriteLine("Annual interest rate  : " & Pro_annualInterestRate)
        Console.WriteLine("Monthly interest : " & getMonthlyInterest())
        Console.WriteLine("Balance : " & Pro_balance + getMonthlyInterest())

    End Sub



End Class
