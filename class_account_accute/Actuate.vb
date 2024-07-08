Public Class Actuate
    Inherits Account

    Public Sub New()
        pro_id = 1100
        pro_balance = 5000
        pro_annualinterestRate = 2.5
        datecreated = Now()
    End Sub
    Public Sub New(ByVal accid As Integer, ByVal accbalance As Double, ByVal accannualinterestRate As Double)
        pro_id = accid
        pro_balance = accbalance
        pro_annualinterestRate = accannualinterestRate
        datecreated = Now()
    End Sub
    Public Property pro_id
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property pro_balance
        Get
            Return balance
        End Get
        Set(value)
            balance = value
        End Set
    End Property
    Public Property pro_annualinterestRate
        Get
            Return annualIntrestrate
        End Get
        Set(value)
            annualIntrestrate = value
        End Set
    End Property
    Public ReadOnly Property pro_datecreated
        Get
            Return datecreated
        End Get
    End Property
    Public Sub print()
        Console.WriteLine("Account id:" & pro_id)
        Console.WriteLine("Date created:" & pro_datecreated)
        Console.WriteLine("AnnualinterestRate:" & pro_annualinterestRate)
        Console.WriteLine("Monthlyinterest:" & getmonthlyintrest())
        Console.WriteLine("Balance:" & pro_balance + getmonthlyintrest())
    End Sub
    Public Overrides Sub withdrawal(amount As Double)

        pro_balance = pro_balance - amount
    End Sub

    Public Overrides Sub deposit(amount As Double)

        pro_balance = pro_balance + amount
    End Sub
End Class