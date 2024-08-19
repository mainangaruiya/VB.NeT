Public Class Form1
    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim age As Integer
        Dim dob As Date
        dob = CDate(DateTimePicker1.Value)
        age = Now().Year - dob.Year
        LBLOUTPUT.Text = "your age = " & age


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
