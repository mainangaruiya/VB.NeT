Public Class Form1

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form properties
        Me.Text = "Login"
        Me.Size = New Size(400, 200) ' Increased size for a larger form

        ' Create and set properties for controls
        Dim lblUsername As New Label With {.Text = "Username:", .Location = New Point(20, 40), .AutoSize = True}
        Dim lblPassword As New Label With {.Text = "Password:", .Location = New Point(20, 80), .AutoSize = True}

        Dim txtUsername As New TextBox With {.Name = "txtUsername", .Location = New Point(120, 40), .Size = New Size(250, 25)}
        Dim txtPassword As New TextBox With {.Name = "txtPassword", .Location = New Point(120, 80), .Size = New Size(250, 25), .UseSystemPasswordChar = True}

        Dim btnLogin As New Button With {.Text = "Login", .Location = New Point(80, 130), .Size = New Size(80, 35)}
        Dim btnCancel As New Button With {.Text = "Cancel", .Location = New Point(240, 130), .Size = New Size(80, 35)}

        Dim lblMessage As New Label With {.Name = "lblMessage", .Location = New Point(20, 170), .Size = New Size(340, 25), .ForeColor = Color.Red, .TextAlign = ContentAlignment.MiddleCenter}

        ' Add controls to the form
        Me.Controls.Add(lblUsername)
        Me.Controls.Add(lblPassword)
        Me.Controls.Add(txtUsername)
        Me.Controls.Add(txtPassword)
        Me.Controls.Add(btnLogin)
        Me.Controls.Add(btnCancel)
        Me.Controls.Add(lblMessage)

        ' Add event handlers
        AddHandler btnLogin.Click, AddressOf btnLogin_Click
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        ' Dummy credentials for demonstration purposes
        Dim validUsername As String = "admin"
        Dim validPassword As String = "password"

        Dim txtUsername = CType(Me.Controls("txtUsername"), TextBox)
        Dim txtPassword = CType(Me.Controls("txtPassword"), TextBox)
        Dim lblMessage = CType(Me.Controls("lblMessage"), Label)

        If txtUsername.Text = validUsername And txtPassword.Text = validPassword Then
            ' Open the main form
            Dim mainForm As New MainForm()
            mainForm.Show()
            Me.Hide()
        Else
            ' Display the error message
            lblMessage.Text = "Contact Admin"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        ' Close the application
        Me.Close()
    End Sub

End Class
