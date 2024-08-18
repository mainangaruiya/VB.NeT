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
    Private lblUnitCode As Label
    Private lblUnitType As Label

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form properties
        Me.Text = "Main Form"
        Me.Size = New Size(650, 450) ' Increased size to avoid overlaps

        ' Initialize and add the ComboBoxes
        lblUnitType = New Label With {.Text = "Select Unit:", .Location = New Point(20, 20), .AutoSize = True}
        lblUnitCode = New Label With {.Text = "Unit Code:", .Location = New Point(200, 20), .AutoSize = True}
        cmbUnitCode = New ComboBox With {.Location = New Point(270, 20), .Size = New Size(130, 25)}
        cmbUnit = New ComboBox With {.Location = New Point(90, 20), .Size = New Size(100, 25)}

        ' Add unit names
        cmbUnit.Items.AddRange(New String() {"Application Programming", "Cloud Computing", "Java"})

        ' Initialize and add the exit button
        btnExit = New Button With {.Text = "Exit", .Location = New Point(540, 15), .Size = New Size(90, 30), .Visible = False}

        ' Initialize the TabControl
        tabControl = New TabControl With {.Location = New Point(20, 60), .Size = New Size(600, 330)}

        ' Initialize the TabPages
        tabCats = New TabPage("Cat")
        tabAssignment = New TabPage("Assignment")
        tabExam = New TabPage("Exam")

        ' Add TabPages to the TabControl
        tabControl.TabPages.Add(tabCats)
        tabControl.TabPages.Add(tabAssignment)
        tabControl.TabPages.Add(tabExam)

        ' Add the controls to the form
        Me.Controls.Add(lblUnitType)
        Me.Controls.Add(lblUnitCode)
        Me.Controls.Add(cmbUnitCode)
        Me.Controls.Add(cmbUnit)
        Me.Controls.Add(btnExit)
        Me.Controls.Add(tabControl)

        ' Create and add controls to the Cat TabPage
        Dim lblCat1 As New Label With {.Text = "Cat 1", .Location = New Point(20, 20), .AutoSize = True}
        Dim lblCat2 As New Label With {.Text = "Cat 2", .Location = New Point(20, 50), .AutoSize = True}
        Dim lblCat3 As New Label With {.Text = "Cat 3", .Location = New Point(20, 80), .AutoSize = True}
        Dim txtCatInput1 As New TextBox With {.Location = New Point(100, 20), .Size = New Size(200, 25)}
        Dim txtCatInput2 As New TextBox With {.Location = New Point(100, 50), .Size = New Size(200, 25)}
        Dim txtCatInput3 As New TextBox With {.Location = New Point(100, 80), .Size = New Size(200, 25)}

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
        Dim lblAverageScore As New Label With {.Text = "Average Score:", .Location = New Point(20, 50), .AutoSize = True}
        Dim lblGrade As New Label With {.Text = "Grade:", .Location = New Point(20, 80), .AutoSize = True}
        txtAverageScore = New TextBox With {.Location = New Point(150, 50), .Size = New Size(150, 25)}
        txtGrade = New TextBox With {.Location = New Point(150, 80), .Size = New Size(150, 25)}

        tabExam.Controls.Add(lblExam)
        tabExam.Controls.Add(lblAverageScore)
        tabExam.Controls.Add(lblGrade)
        tabExam.Controls.Add(txtAverageScore)
        tabExam.Controls.Add(txtGrade)

        ' Add event handlers
        AddHandler cmbUnit.SelectedIndexChanged, AddressOf cmbUnit_SelectedIndexChanged
        AddHandler cmbUnitCode.SelectedIndexChanged, AddressOf cmbUnitCode_SelectedIndexChanged
        AddHandler btnExit.Click, AddressOf btnExit_Click

        ' Initialize the unit codes based on the unit
        UpdateUnitCodeList()
    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Update unit codes and show the correct tab based on the selected unit
        UpdateUnitCodeList()
        ' Clear the unit code selection when the unit is changed
        cmbUnitCode.SelectedIndex = -1
        ' Reset the tab to ensure no tab is selected
        tabControl.SelectTab(-1)
        ' Hide the Exit button
        btnExit.Visible = False
    End Sub

    Private Sub cmbUnitCode_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Show the corresponding tab based on the selected unit code
        ShowCorrespondingTab()
    End Sub

    Private Sub ShowCorrespondingTab()
        Dim selectedUnitCode As String = cmbUnitCode.SelectedItem?.ToString()

        If String.IsNullOrEmpty(selectedUnitCode) Then Return

        Select Case selectedUnitCode
            Case "BIT211"
                ShowCatsTab()
            Case "BIT212"
                ShowAssignmentTab()
            Case "BIT213"
                ShowExamTab()
        End Select
    End Sub

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
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim confirmExit As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmExit = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub UpdateUnitCodeList()
        cmbUnitCode.Items.Clear()

        Select Case cmbUnit.SelectedItem?.ToString()
            Case "Application Programming"
                cmbUnitCode.Items.Add("BIT211")
            Case "Cloud Computing"
                cmbUnitCode.Items.Add("BIT212")
            Case "Java"
                cmbUnitCode.Items.Add("BIT213")
        End Select

        ' Automatically select the first item if available
        If cmbUnitCode.Items.Count > 0 Then
            cmbUnitCode.SelectedIndex = -1 ' Reset the selection
        End If
    End Sub

End Class
