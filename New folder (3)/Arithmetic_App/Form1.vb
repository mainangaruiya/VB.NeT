Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_Dob.MaxDate = Today
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Dim DOB As Date = dtp_Dob.Value
            Dim age As Integer = Date.Now.Year - DOB.Year

            If Date.Now < DOB.AddYears(age) Then
                age -= 1
            End If

            If age < 4 Then
                MessageBox.Show("Oops! You are too young for this.")
            ElseIf age > 8 Then
                MessageBox.Show("Ooh, this is too basic for you.")
            Else
                Dim form2 As New Form2()
                form2.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your age: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
