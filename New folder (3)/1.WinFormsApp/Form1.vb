Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private hobbies As New ArrayList()
    Private Sub gethobbies()
        If chc_movies.Checked = True Then
            hobbies.Add(chc_movies.Text)
        End If
        If Chc_clubbing.Checked = True Then
            hobbies.Add(Chc_clubbing.Text)
        End If
        If Chc_swimming.Checked = True Then
            hobbies.Add(Chc_swimming.Text)
        End If

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Label1
            .Text = "FirstName"
            .ForeColor = Color.Blue
            .Font = New Font("Times New roman", 12, FontStyle.Bold)


        End With

        With Label3
            .Text = "SurName"
            .ForeColor = Color.Blue
            .Font = New Font("Times New roman", 12, FontStyle.Bold)
        End With

        cbo_course.Items.Add("Bsc IT")
        cbo_course.Items.Add(New String() {"Bbc", "DIT", "CIT"})




    End Sub

    Private Function pickidentificationdoc() As String
        If rbn_id.Checked = True Then
            rbn_pass.Checked = False
            rbn_birthcert.Checked = False
            Return rbn_id.Text
        ElseIf rbn_pass.Checked = True Then
            rbn_id.Checked = False
            rbn_birthcert.Checked = False
            Return rbn_pass.Text
        Else
            rbn_pass.Checked = False
            rbn_id.Checked = False
            Return rbn_birthcert.Text
        End If
    End Function


    Private Function gender()
        If rbn_male.Checked = True Then
            rbn_female.Checked = False
            rbn_other.Checked = False
            Return rbn_male.Text
        ElseIf rbn_female.Checked = True Then
            rbn_male.Checked = False
            rbn_other.Checked = False
            Return rbn_female.Text
        Else
            rbn_male.Checked = False
            rbn_female.Checked = False
            Return rbn_other.Text

        End If

    End Function

    Private Function religion()
        If rbn_christian.Checked = True Then
            rbn_muslim.Checked = False
            rbn_hindu.Checked = False
            Return rbn_christian.Text
        ElseIf rbn_muslim.Checked = True Then
            rbn_christian.Checked = False
            rbn_hindu.Checked = False
            Return rbn_muslim.Text
        Else
            rbn_muslim.Checked = False
            rbn_christian.Checked = False
            Return rbn_hindu.Text

        End If
    End Function

    Private Sub printdetails()
        lst_output.Items.Clear()
        lst_output.Items.Add("First name : " & Txt_fname.Text)
        lst_output.Items.Add("Middle name : " & Txt_Mname.Text)
        lst_output.Items.Add("Surname : " & Txt_Sname.Text)
        lst_output.Items.Add("Date of birth : " & Dtp_dob.Value)
        lst_output.Items.Add("Identification document : " & pickidentificationdoc())
        lst_output.Items.Add("Id doc no: " & Txt_DocNo.Text)
        lst_output.Items.Add("Gender : " & gender())
        lst_output.Items.Add("Religion : " & religion())
        lst_output.Items.Add("course: " & cbo_course.SelectedItem)
        lst_output.Items.Add("Hobbies : " & vbNewLine)

        Dim i As String
        hobbies.Clear()
        gethobbies()
        For Each i In hobbies
            lst_output.Items.Add(i & vbTab)
        Next

    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_course.SelectedIndexChanged

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        printdetails()
    End Sub

    Private Sub lst_output_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_output.SelectedIndexChanged

    End Sub
End Class
