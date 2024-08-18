Public Class MainForm
    Private WithEvents cmbUnit As ComboBox
    Private WithEvents tabControl As TabControl
    Private WithEvents tabCats As TabPage
    Private WithEvents tabAssignment As TabPage
    Private WithEvents tabExam As TabPage
    Private WithEvents txtCatInput1 As TextBox
    Private WithEvents txtCatInput2 As TextBox
    Private WithEvents txtCatInput3 As TextBox
    Private WithEvents txtAssignmentInput1 As TextBox
    Private WithEvents txtAssignmentInput2 As TextBox
    Private WithEvents txtExamInput As TextBox
    Private WithEvents txtAverageScore As TextBox
    Private WithEvents txtGrade As TextBox
    Private WithEvents btnExit As Button
    Private rand As New Random()

    Public Sub New()
        InitialComponent()
        InitializeUI()
    End Sub

    Private Sub InitialComponent()
        ' Initialize the form properties
        Me.Text = "Main Form"
        Me.Size = New Size(700, 500)

        ' Initialize and add the ComboBox for selecting units
        cmbUnit = New ComboBox With {.Location = New Point(20, 20), .Size = New Size(200, 25)}
        cmbUnit.Items.AddRange({"Application Programming", "Cloud Computing", "Java"})
        Me.Controls.Add(cmbUnit)

        ' Initialize the TabControl
        tabControl = New TabControl With {.Location = New Point(20, 60), .Size = New Size(650, 380)}
        Me.Controls.Add(tabControl)

        ' Initialize the TabPages
        tabCats = New TabPage("Cats")
        tabAssignment = New TabPage("Assignment")
        tabExam = New TabPage("Exam")
        tabControl.TabPages.AddRange({tabCats, tabAssignment, tabExam})

        ' Controls for Cats TabPage
        txtCatInput1 = New TextBox With {.Location = New Point(20, 20), .Size = New Size(100, 25)}
        txtCatInput2 = New TextBox With {.Location = New Point(20, 50), .Size = New Size(100, 25)}
        txtCatInput3 = New TextBox With {.Location = New Point(20, 80), .Size = New Size(100, 25)}
        tabCats.Controls.AddRange({txtCatInput1, txtCatInput2, txtCatInput3})

        ' Controls for Assignment TabPage
        txtAssignmentInput1 = New TextBox With {.Location = New Point(20, 20), .Size = New Size(100, 25)}
        txtAssignmentInput2 = New TextBox With {.Location = New Point(20, 50), .Size = New Size(100, 25)}
        tabAssignment.Controls.AddRange({txtAssignmentInput1, txtAssignmentInput2})

        ' Controls for Exam TabPage
        txtExamInput = New TextBox With {.Location = New Point(20, 20), .Size = New Size(100, 25)}
        tabExam.Controls.Add(txtExamInput)

        ' Labels for average score and grade
        Dim lblAverageScore As New Label With {.Text = "Average Score:", .Location = New Point(20, 120), .AutoSize = True}
        Dim lblGrade As New Label With {.Text = "Grade:", .Location = New Point(20, 150), .AutoSize = True}
        Me.Controls.AddRange({lblAverageScore, lblGrade})

        ' TextBoxes for average score and grade
        txtAverageScore = New TextBox With {.Location = New Point(120, 120), .Size = New Size(100, 25), .ReadOnly = True}
        txtGrade = New TextBox With {.Location = New Point(120, 150), .Size = New Size(100, 25), .ReadOnly = True}
        Me.Controls.AddRange({txtAverageScore, txtGrade})

        ' Exit button on Exam TabPage
        btnExit = New Button With {.Text = "Exit", .Location = New Point(20, 300), .Size = New Size(100, 25)}
        tabExam.Controls.Add(btnExit)
    End Sub

    Private Sub InitializeUI()
        ' Initialize unit selection
        cmbUnit.SelectedIndex = 0

        ' Event handler for text changed events (for calculating scores)
        AddHandler txtCatInput1.TextChanged, AddressOf ComputeResults
        AddHandler txtCatInput2.TextChanged, AddressOf ComputeResults
        AddHandler txtCatInput3.TextChanged, AddressOf ComputeResults
        AddHandler txtAssignmentInput1.TextChanged, AddressOf ComputeResults
        AddHandler txtAssignmentInput2.TextChanged, AddressOf ComputeResults
        AddHandler txtExamInput.TextChanged, AddressOf ComputeResults
    End Sub

    Private Sub ComputeResults(sender As Object, e As EventArgs)
        ' Calculate total marks and average score
        Dim cat1, cat2, cat3 As Integer
        Dim assignment1, assignment2 As Integer
        Dim examMark As Integer

        Integer.TryParse(txtCatInput1.Text, cat1)
        Integer.TryParse(txtCatInput2.Text, cat2)
        Integer.TryParse(txtCatInput3.Text, cat3)
        Integer.TryParse(txtAssignmentInput1.Text, assignment1)
        Integer.TryParse(txtAssignmentInput2.Text, assignment2)
        Integer.TryParse(txtExamInput.Text, examMark)

        ' Calculate total marks and average score
        Dim totalMarks As Integer = cat1 + cat2 + cat3 + assignment1 + assignment2 + examMark
        Dim averageScore As Double = totalMarks / 6.0 ' Assuming total is out of 100

        ' Display average score
        txtAverageScore.Text = averageScore.ToString("F2")

        ' Determine grade based on average score
        Select Case averageScore * 100
            Case >= 80
                txtGrade.Text = "A"
            Case >= 70
                txtGrade.Text = "B"
            Case >= 60
                txtGrade.Text = "C"
            Case >= 50
                txtGrade.Text = "D"
            Case Else
                txtGrade.Text = "F"
        End Select
    End Sub
End Class
