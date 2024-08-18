Public Class MainForm

    Private WithEvents tabControl As TabControl
    Private tabCats As TabPage
    Private tabAssignment As TabPage
    Private tabExam As TabPage
    Private cmbUnitCode As ComboBox
    Private cmbUnit As ComboBox
    Private btnExit As Button
    Private txtAssignmentInput1 As TextBox
    Private txtAssignmentInput2 As TextBox
    Private txtAverageScore As TextBox
    Private txtGrade As TextBox
    Private txtExamInput As TextBox
    Private txtCatInput1 As TextBox
    Private txtCatInput2 As TextBox
    Private txtCatInput3 As TextBox
    Private lblUnitCode As Label
    Private lblUnitType As Label
    Private lblExamInput As Label
    Private lblAverageScore As Label
    Private lblGrade As Label

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form properties
        Me.Text = "Main Form"
        Me.Size = New Size(700, 500) ' Increased size to avoid overlaps

        ' Initialize and add the ComboBoxes
        lblUnitType = New Label With {.Text = "Select Unit:", .Location = New Point(20, 20), .AutoSize = True}
        lblUnitCode = New Label With {.Text = "Unit Code:", .Location = New Point(200, 20), .AutoSize = True}
        cmbUnitCode = New ComboBox With {.Location = New Point(270, 20), .Size = New Size(130, 25)}
        cmbUnit = New ComboBox With {.Location = New Point(90, 20), .Size = New Size(100, 25)}

        ' Add unit names
        cmbUnit.Items.AddRange(New String() {"Application Programming", "Cloud Computing", "Java"})

        ' Initialize the TabControl
        tabControl = New TabControl With {.Location = New Point(20, 60), .Size = New Size(650, 380)}

        ' Initialize the TabPages
        tabCats = New TabPage("Cat")
        tabAssignment = New TabPage("Assignment")
        tabExam = New TabPage("Exam")

        ' Add TabPages to the TabControl
        tabControl.TabPages.Add(tabCats)
        tabControl.TabPages.Add(tabAssignment)
        tabControl.TabPages.Add(tabExam)

        ' Create and add controls to the Cat TabPage
        Dim lblCat1 As New Label With {.Text = "Cat 1", .Location = New Point(20, 20), .AutoSize = True}
        Dim lblCat2 As New Label With {.Text = "Cat 2", .Location = New Point(20, 50), .AutoSize = True}
        Dim lblCat3 As New Label With {.Text = "Cat 3", .Location = New Point(20, 80), .AutoSize = True}
        txtCatInput1 = New TextBox With {.Location = New Point(100, 20), .Size = New Size(200, 25)}
        txtCatInput2 = New TextBox With {.Location = New Point(100, 50), .Size = New Size(200, 25)}
        txtCatInput3 = New TextBox With {.Location = New Point(100, 80), .Size = New Size(200, 25)}

        tabCats.Controls.Add(lblCat1)
        tabCats.Controls.Add(lblCat2)
        tabCats.Controls.Add(lblCat3)
        tabCats.Controls.Add(txtCatInput1)
        tabCats.Controls.Add(txtCatInput2)
        tabCats.Controls.Add(txtCatInput3)

        ' Create and add controls to the Assignment TabPage
        Dim lblAssignment1 As New Label With {.Text = "Assignment 1", .Location = New Point(20, 20), .AutoSize = True}
        Dim lblAssignment2 As New Label With {.Text = "Assignment 2", .Location = New Point(20, 50), .AutoSize = True}
        txtAssignmentInput1 = New TextBox With {.Location = New Point(130, 20), .Size = New Size(200, 25)}
        txtAssignmentInput2 = New TextBox With {.Location = New Point(130, 50), .Size = New Size(200, 25)}

        tabAssignment.Controls.Add(lblAssignment1)
        tabAssignment.Controls.Add(lblAssignment2)
        tabAssignment.Controls.Add(txtAssignmentInput1)
        tabAssignment.Controls.Add(txtAssignmentInput2)

        ' Create and add controls to the Exam TabPage
        Dim lblExam As New Label With {.Text = "Exam", .Location = New Point(20, 20), .AutoSize = True}
        lblExamInput = New Label With {.Text = "Exam Input:", .Location = New Point(20, 50), .AutoSize = True}
        lblAverageScore = New Label With {.Text = "Average Score:", .Location = New Point(20, 80), .AutoSize = True}
        lblGrade = New Label With {.Text = "Grade:", .Location = New Point(20, 110), .AutoSize = True}
        txtExamInput = New TextBox With {.Location = New Point(150, 50), .Size = New Size(150, 25)}
        txtAverageScore = New TextBox With {.Location = New Point(150, 80), .Size = New Size(150, 25), .ReadOnly = True}
        txtGrade = New TextBox With {.Location = New Point(150, 110), .Size = New Size(150, 25), .ReadOnly = True}
        btnExit = New Button With {.Text = "Exit", .Location = New Point(580, 15), .Size = New Size(90, 30), .Visible = False}

        tabExam.Controls.Add(lblExam)
        tabExam.Controls.Add(lblExamInput)
        tabExam.Controls.Add(txtExamInput)
        tabExam.Controls.Add(lblAverageScore)
        tabExam.Controls.Add(txtAverageScore)
        tabExam.Controls.Add(lblGrade)
        tabExam.Controls.Add(txtGrade)

        ' Add the controls to the form
        Me.Controls.Add(lblUnitType)
        Me.Controls.Add(lblUnitCode)
        Me.Controls.Add(cmbUnitCode)
        Me.Controls.Add(cmbUnit)
        Me.Controls.Add(tabControl)
        Me.Controls.Add(btnExit)

        ' Add event handlers
        AddHandler cmbUnit.SelectedIndexChanged, AddressOf cmbUnit_SelectedIndexChanged
        AddHandler cmbUnitCode.SelectedIndexChanged, AddressOf cmbUnitCode_SelectedIndexChanged
        AddHandler btnExit.Click, AddressOf btnExit_Click
        AddHandler txtExamInput.TextChanged, AddressOf ComputeResults
        AddHandler txtAssignmentInput1.TextChanged, AddressOf ComputeResults
        AddHandler txtAssignmentInput2.TextChanged, AddressOf ComputeResults
        AddHandler txtCatInput1.TextChanged, AddressOf ComputeResults
        AddHandler txtCatInput2.TextChanged, AddressOf ComputeResults
        AddHandler txtCatInput3.TextChanged, AddressOf ComputeResults

        ' Initialize the unit codes based on the unit
        UpdateUnitCodeList()
    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Update unit codes and show the correct tab based on the selected unit
        UpdateUnitCodeList()
        ' Clear the unit code selection when the unit is changed
        cmbUnitCode.SelectedIndex = -1
        ' Reset the tab to ensure no tab is selected
        tabControl.SelectedIndex = -1
        ' Hide the Exit button
        btnExit.Visible = False
    End Sub

    Private Sub cmbUnitCode_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Show the corresponding tab based on the selected unit code
        ' ShowCorrespondingTab()
    End Sub

    'Private Sub ShowCorrespondingTab()
    '    Dim selectedUnitCode As String = cmbUnitCode.SelectedItem?.ToString()

    '    If String.IsNullOrEmpty(selectedUnitCode) Then Return

    '    Select Case selectedUnitCode
    '        Case "BIT211"
    '            ShowCatsTab()
    '        Case "BIT212"
    '            ShowAssignmentTab()
    '        Case "BIT213"
    '            ShowExamTab()
    '    End Select
    'End Sub

    Private Sub ShowCatsTab()
        tabControl.SelectTab(tabCats)
        ' Hide the Exit button
        btnExit.Visible = False
    End Sub

    Private Sub ShowAssignmentTab()
        tabControl.SelectTab(tabAssignment)
        ' Hide the Exit button
        btnExit.Visible = False
    End Sub

    Private Sub ShowExamTab()
        tabControl.SelectTab(tabExam)
        ' Show the Exit button
        btnExit.Visible = True
        ' Compute results when the Exam tab is selected
        ComputeResults(Nothing, Nothing)
    End Sub

    Private Sub ComputeResults(sender As Object, e As EventArgs)
        ' Ensure text fields are parsed correctly
        Dim cat1 As Integer = If(Integer.TryParse(txtCatInput1.Text, cat1), cat1, 0)
        Dim cat2 As Integer = If(Integer.TryParse(txtCatInput2.Text, cat2), cat2, 0)
        Dim cat3 As Integer = If(Integer.TryParse(txtCatInput3.Text, cat3), cat3, 0)
        Dim assignment1 As Integer = If(Integer.TryParse(txtAssignmentInput1.Text, assignment1), assignment1, 0)
        Dim assignment2 As Integer = If(Integer.TryParse(txtAssignmentInput2.Text, assignment2), assignment2, 0)
        Dim exam As Integer = If(Integer.TryParse(txtExamInput.Text, exam), exam, 0)

        ' Compute average score
        Dim averageScore As Double = (cat1 + cat2 + cat3 + assignment1 + assignment2 + exam) / 6
        txtAverageScore.Text = averageScore.ToString("F2")

        ' Determine grade
        Dim grade As String
        Select Case averageScore
            Case >= 70
                grade = "A"
            Case >= 60
                grade = "B"
            Case >= 50
                grade = "C"
            Case >= 40
                grade = "D"
            Case Else
                grade = "F"
        End Select
        txtGrade.Text = grade
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        ' Close the form
        Me.Close()
    End Sub

    Private Sub UpdateUnitCodeList()
        cmbUnitCode.Items.Clear()
        Select Case cmbUnit.SelectedItem?.ToString()
            Case "Application Programming"
                cmbUnitCode.Items.AddRange(New String() {"BIT211"})
            Case "Cloud Computing"
                cmbUnitCode.Items.AddRange(New String() {"BIT212"})
            Case "Java"
                cmbUnitCode.Items.AddRange(New String() {"BIT213"})
        End Select
    End Sub

End Class
