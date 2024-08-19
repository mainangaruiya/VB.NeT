Public Class Form2
    Private random As New Random()
    Private grade As Integer
    Private WithEvents btn_GenerateNumbers As Button

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_Grade.Items.Add("Grade 1")
        cmb_Grade.Items.Add("Grade 2")
        cmb_Grade.Items.Add("Grade 3")
        cmb_Grade.SelectedIndex = 0
    End Sub

    Private Sub btn_GenerateNumbers_Click(sender As Object, e As EventArgs) Handles btn_GenerateNumbers.Click
        lbl_Number1.Text = ""
        lbl_Number2.Text = ""
        lbl_Question.Text = ""
        txt_Operator.Clear()
        txt_Answer.Clear()

        grade = cmb_Grade.SelectedIndex + 1

        Select Case grade
            Case 1
                lbl_Number1.Text = random.Next(0, 10).ToString()
                lbl_Number2.Text = random.Next(0, 10).ToString()
                lbl_Question.Text = $"What is {lbl_Number1.Text} + {lbl_Number2.Text}?"
                txt_Operator.Text = "+"
            Case 2
                lbl_Number1.Text = random.Next(10, 100).ToString()
                lbl_Number2.Text = random.Next(10, 100).ToString()
                If random.Next(0, 2) = 0 Then
                    lbl_Question.Text = $"What is {lbl_Number1.Text} + {lbl_Number2.Text}?"
                    txt_Operator.Text = "+"
                Else
                    lbl_Question.Text = $"What is {lbl_Number1.Text} - {lbl_Number2.Text}?"
                    txt_Operator.Text = "-"
                End If
            Case 3
                lbl_Number1.Text = random.Next(10, 100).ToString()
                lbl_Number2.Text = random.Next(10, 100).ToString()
                Dim operation As Integer = random.Next(0, 4)
                Select Case operation
                    Case 0
                        lbl_Question.Text = $"What is {lbl_Number1.Text} + {lbl_Number2.Text}?"
                        txt_Operator.Text = "+"
                    Case 1
                        lbl_Question.Text = $"What is {lbl_Number1.Text} - {lbl_Number2.Text}?"
                        txt_Operator.Text = "-"
                    Case 2
                        lbl_Question.Text = $"What is {lbl_Number1.Text} * {lbl_Number2.Text}?"
                        txt_Operator.Text = "*"
                    Case 3
                        lbl_Question.Text = $"What is {lbl_Number1.Text} / {lbl_Number2.Text}?"
                        txt_Operator.Text = "/"
                End Select
                MessageBox.Show($"Numbers generated: {lbl_Number1.Text}, {lbl_Number2.Text}")
        End Select
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim answer As Double

        Try

            number1 = Integer.Parse(lbl_Number1.Text)
            number2 = Integer.Parse(lbl_Number2.Text)


            If Double.TryParse(txt_Answer.Text, answer) AndAlso Not String.IsNullOrWhiteSpace(txt_Operator.Text) Then
                Dim operation As String = txt_Operator.Text.Trim()


                Select Case grade
                    Case 1
                        If operation = "+" AndAlso (number1 + number2 = answer) Then
                            MessageBox.Show("Correct!")
                        Else
                            MessageBox.Show($"Try again! The correct answer is {number1 + number2}.")
                        End If
                    Case 2
                        If operation = "+" AndAlso (number1 + number2 = answer) Then
                            MessageBox.Show("Correct!")
                        ElseIf operation = "-" AndAlso (number1 - number2 = answer) Then
                            MessageBox.Show("Correct!")
                        Else
                            MessageBox.Show($"Try again! The correct answer is {EvaluateExpression(number1, number2, operation)}.")
                        End If
                    Case 3
                        
                        If operation = "+" AndAlso (number1 + number2 = answer) Then
                            MessageBox.Show("Correct!")
                        ElseIf operation = "-" AndAlso (number1 - number2 = answer) Then
                            MessageBox.Show("Correct!")
                        ElseIf operation = "*" AndAlso (number1 * number2 = answer) Then
                            MessageBox.Show("Correct!")
                        ElseIf operation = "/" AndAlso (number2 <> 0) AndAlso (number1 / number2 = answer) Then
                            MessageBox.Show("Correct!")
                        Else
                            MessageBox.Show($"Try again! The correct answer is {EvaluateExpression(number1, number2, operation)}.")
                        End If
                End Select
            Else
                MessageBox.Show("This cannot be empty or invalid.")
            End If
        Catch ex As FormatException
            MessageBox.Show("Error in input format. Please enter valid numbers and operator.")
        Catch ex As DivideByZeroException
            MessageBox.Show("Division by zero is not allowed.")
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}")
        End Try
    End Sub

    Private Function EvaluateExpression(num1 As Integer, num2 As Integer, op As String) As Double
        Select Case op
            Case "+"
                Return num1 + num2
            Case "-"
                Return num1 - num2
            Case "*"
                Return num1 * num2
            Case "/"
                If num2 <> 0 Then
                    Return num1 / num2
                Else
                    Throw New DivideByZeroException("Cannot divide by zero.")
                End If
            Case Else
                Return 0
        End Select
    End Function
End Class
