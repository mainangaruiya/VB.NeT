Public Class SignupForm
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Perform validation (e.g., check if fields are filled, passwords match, etc.)
        If ValidateInputs() Then
            ' Assuming Login form is named LoginForm
            Dim loginForm As New LoginForm()
            Me.Hide() ' Hide the current signup form
            loginForm.Show() ' Show the login form
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Example validation logic (you can expand this as needed)
        If String.IsNullOrEmpty(txtUsername.Text.Trim()) Then
            MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(txtPassword.Text.Trim()) Then
            MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Add more validation rules here (e.g., password strength, email format, etc.)

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() ' Close the signup form
    End Sub
End Class
