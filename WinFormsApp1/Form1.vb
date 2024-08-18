Public Class Form1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Label1
            .Text = "first_name"
            .ForeColor = Color.Blue
            .Font = New Font("Times New Roman", 12, FontStyle.Bold)
        End With
        Cbocourse.Items.Add("Bsc It")
        Cbocourse.Items.AddRange(New String() {"BBC", "DIT", "CIT "})



    End Sub
    Private hobbies As New ArrayList()
    Private Sub gethobbies()

        'If Chmovies.Checked = True Then
        '    ArrayList.Add(Chmovies.Text)
        'End If
        'If chcclub.Checked = True Then
        '    arraylist1.Add(chcclub.Text)
        'End If
        'If chcswimming.Checked = True Then
        '    arraylist1.Add(chcswimming.Text)
        ''End If

    End Sub
    Private Sub printdetails()
        lstoutpu.items.add
    End Sub

    Private Function pickidentification() As String
        If RBnId.Checked = True Then
            RbnPs.Checked = False
            RbnB.Checked = False
            Return RBnId.Text
        End If
        If RbnPs.Checked = True Then
            RBnId.Checked = False
            RbnB.Checked = False
            Return RbnPs.Text
        End If
        If RbnOther.Checked = True Then
            RbnMale.Checked = False
            RbnFemale.Checked = False
            Return RbnOther.Text
        End If
    End Function
    Public Function pickgender()
        If RbnMale.Checked = True Then
            RbnFemale.Checked = False
            RbnOther.Checked = False
            Return RbnMale.Text
        End If
        If RbnFemale.Checked = True Then
            RbnMale.Checked = False
            RbnOther.Checked = False
            Return RbnFemale.Text
        End If
        If RbnB.Checked = True Then
            RbnPs.Checked = False
            RBnId.Checked = False
            Return RbnB.Text
        End If

    End Function
    Public Function pickreligion()
        If RbnMuslim.Checked = True Then
            RbnHindu.Checked = False
            RBnChristian.Checked = False
            Return RbnMuslim.Text
        End If
        If RBnChristian.Checked = True Then
            RbnMuslim.Checked = False
            RbnHindu.Checked = False
            Return RBnChristian.Text
        End If
        If RbnHindu.Checked = True Then
            RBnChristian.Checked = False
            RbnMuslim.Checked = False
            Return RbnB.Text
        End If

    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chmovies.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RbnB_CheckedChanged(sender As Object, e As EventArgs) Handles RbnB.CheckedChanged

    End Sub
End Class
