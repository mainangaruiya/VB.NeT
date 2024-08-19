<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Txt_fname = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Txt_Mname = New TextBox()
        Label3 = New Label()
        Txt_Sname = New TextBox()
        Label4 = New Label()
        Dtp_dob = New DateTimePicker()
        rbn_id = New RadioButton()
        rbn_pass = New RadioButton()
        rbn_birthcert = New RadioButton()
        Label6 = New Label()
        Txt_DocNo = New TextBox()
        rbn_male = New RadioButton()
        rbn_female = New RadioButton()
        rbn_other = New RadioButton()
        rbn_christian = New RadioButton()
        rbn_muslim = New RadioButton()
        rbn_hindu = New RadioButton()
        cbocourse = New Label()
        cbo_course = New ComboBox()
        Label10 = New Label()
        lst_output = New ListBox()
        chc_movies = New CheckBox()
        Chc_clubbing = New CheckBox()
        Chc_swimming = New CheckBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        btndisplay = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Txt_fname
        ' 
        Txt_fname.Location = New Point(172, 80)
        Txt_fname.Name = "Txt_fname"
        Txt_fname.PasswordChar = "*"c
        Txt_fname.Size = New Size(150, 31)
        Txt_fname.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 2
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(368, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 26)
        Label2.TabIndex = 3
        Label2.Text = "Middle Name"
        ' 
        ' Txt_Mname
        ' 
        Txt_Mname.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Txt_Mname.Location = New Point(566, 74)
        Txt_Mname.Name = "Txt_Mname"
        Txt_Mname.Size = New Size(128, 31)
        Txt_Mname.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(787, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 5
        Label3.Text = "Surname"
        ' 
        ' Txt_Sname
        ' 
        Txt_Sname.Location = New Point(896, 74)
        Txt_Sname.Name = "Txt_Sname"
        Txt_Sname.Size = New Size(150, 31)
        Txt_Sname.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(133, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 25)
        Label4.TabIndex = 7
        Label4.Text = "Date of Birth"
        ' 
        ' Dtp_dob
        ' 
        Dtp_dob.Format = DateTimePickerFormat.Short
        Dtp_dob.Location = New Point(22, 182)
        Dtp_dob.Name = "Dtp_dob"
        Dtp_dob.Size = New Size(300, 31)
        Dtp_dob.TabIndex = 8
        ' 
        ' rbn_id
        ' 
        rbn_id.AutoSize = True
        rbn_id.Location = New Point(6, 46)
        rbn_id.Name = "rbn_id"
        rbn_id.Size = New Size(126, 29)
        rbn_id.TabIndex = 10
        rbn_id.TabStop = True
        rbn_id.Text = "National ID"
        rbn_id.UseVisualStyleBackColor = True
        ' 
        ' rbn_pass
        ' 
        rbn_pass.AutoSize = True
        rbn_pass.Location = New Point(151, 46)
        rbn_pass.Name = "rbn_pass"
        rbn_pass.Size = New Size(105, 29)
        rbn_pass.TabIndex = 11
        rbn_pass.TabStop = True
        rbn_pass.Text = "Passport"
        rbn_pass.UseVisualStyleBackColor = True
        ' 
        ' rbn_birthcert
        ' 
        rbn_birthcert.AutoSize = True
        rbn_birthcert.Location = New Point(276, 46)
        rbn_birthcert.Name = "rbn_birthcert"
        rbn_birthcert.Size = New Size(153, 29)
        rbn_birthcert.TabIndex = 12
        rbn_birthcert.TabStop = True
        rbn_birthcert.Text = "Birth certificate"
        rbn_birthcert.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(914, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 25)
        Label6.TabIndex = 13
        Label6.Text = "ID DOC NO"
        ' 
        ' Txt_DocNo
        ' 
        Txt_DocNo.Location = New Point(894, 172)
        Txt_DocNo.Name = "Txt_DocNo"
        Txt_DocNo.Size = New Size(150, 31)
        Txt_DocNo.TabIndex = 14
        ' 
        ' rbn_male
        ' 
        rbn_male.AutoSize = True
        rbn_male.Location = New Point(6, 43)
        rbn_male.Name = "rbn_male"
        rbn_male.Size = New Size(75, 29)
        rbn_male.TabIndex = 16
        rbn_male.TabStop = True
        rbn_male.Text = "Male"
        rbn_male.UseVisualStyleBackColor = True
        ' 
        ' rbn_female
        ' 
        rbn_female.AutoSize = True
        rbn_female.Location = New Point(95, 44)
        rbn_female.Name = "rbn_female"
        rbn_female.Size = New Size(93, 29)
        rbn_female.TabIndex = 17
        rbn_female.TabStop = True
        rbn_female.Text = "Female"
        rbn_female.UseVisualStyleBackColor = True
        ' 
        ' rbn_other
        ' 
        rbn_other.AutoSize = True
        rbn_other.Location = New Point(212, 44)
        rbn_other.Name = "rbn_other"
        rbn_other.Size = New Size(82, 29)
        rbn_other.TabIndex = 18
        rbn_other.TabStop = True
        rbn_other.Text = "Other"
        rbn_other.UseVisualStyleBackColor = True
        ' 
        ' rbn_christian
        ' 
        rbn_christian.AutoSize = True
        rbn_christian.Location = New Point(16, 30)
        rbn_christian.Name = "rbn_christian"
        rbn_christian.Size = New Size(105, 29)
        rbn_christian.TabIndex = 20
        rbn_christian.TabStop = True
        rbn_christian.Text = "Christian"
        rbn_christian.UseVisualStyleBackColor = True
        ' 
        ' rbn_muslim
        ' 
        rbn_muslim.AutoSize = True
        rbn_muslim.Location = New Point(16, 65)
        rbn_muslim.Name = "rbn_muslim"
        rbn_muslim.Size = New Size(95, 29)
        rbn_muslim.TabIndex = 21
        rbn_muslim.TabStop = True
        rbn_muslim.Text = "Muslim"
        rbn_muslim.UseVisualStyleBackColor = True
        ' 
        ' rbn_hindu
        ' 
        rbn_hindu.AutoSize = True
        rbn_hindu.Location = New Point(16, 100)
        rbn_hindu.Name = "rbn_hindu"
        rbn_hindu.Size = New Size(85, 29)
        rbn_hindu.TabIndex = 22
        rbn_hindu.TabStop = True
        rbn_hindu.Text = "Hindu"
        rbn_hindu.UseVisualStyleBackColor = True
        ' 
        ' cbocourse
        ' 
        cbocourse.AutoSize = True
        cbocourse.Location = New Point(711, 260)
        cbocourse.Name = "cbocourse"
        cbocourse.Size = New Size(67, 25)
        cbocourse.TabIndex = 23
        cbocourse.Text = "Course"
        ' 
        ' cbo_course
        ' 
        cbo_course.FormattingEnabled = True
        cbo_course.Location = New Point(699, 304)
        cbo_course.Name = "cbo_course"
        cbo_course.Size = New Size(182, 33)
        cbo_course.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(923, 264)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 25)
        Label10.TabIndex = 25
        Label10.Text = "Hobbies"
        ' 
        ' lst_output
        ' 
        lst_output.FormattingEnabled = True
        lst_output.ItemHeight = 25
        lst_output.Location = New Point(12, 409)
        lst_output.Name = "lst_output"
        lst_output.Size = New Size(421, 179)
        lst_output.TabIndex = 28
        ' 
        ' chc_movies
        ' 
        chc_movies.AutoSize = True
        chc_movies.Location = New Point(923, 339)
        chc_movies.Name = "chc_movies"
        chc_movies.Size = New Size(179, 29)
        chc_movies.TabIndex = 29
        chc_movies.Text = "Watching  Movies"
        chc_movies.UseVisualStyleBackColor = True
        ' 
        ' Chc_clubbing
        ' 
        Chc_clubbing.AutoSize = True
        Chc_clubbing.Location = New Point(923, 373)
        Chc_clubbing.Name = "Chc_clubbing"
        Chc_clubbing.Size = New Size(110, 29)
        Chc_clubbing.TabIndex = 30
        Chc_clubbing.Text = "Clubbing"
        Chc_clubbing.UseVisualStyleBackColor = True
        ' 
        ' Chc_swimming
        ' 
        Chc_swimming.AutoSize = True
        Chc_swimming.Location = New Point(924, 409)
        Chc_swimming.Name = "Chc_swimming"
        Chc_swimming.Size = New Size(122, 29)
        Chc_swimming.TabIndex = 31
        Chc_swimming.Text = "Swimming"
        Chc_swimming.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbn_male)
        GroupBox1.Controls.Add(rbn_female)
        GroupBox1.Controls.Add(rbn_other)
        GroupBox1.Location = New Point(22, 235)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 89)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbn_christian)
        GroupBox2.Controls.Add(rbn_muslim)
        GroupBox2.Controls.Add(rbn_hindu)
        GroupBox2.Location = New Point(528, 288)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(166, 150)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "Religion"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbn_id)
        GroupBox3.Controls.Add(rbn_pass)
        GroupBox3.Controls.Add(rbn_birthcert)
        GroupBox3.Location = New Point(368, 138)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(475, 96)
        GroupBox3.TabIndex = 34
        GroupBox3.TabStop = False
        GroupBox3.Text = "Idenntification doc"
        ' 
        ' btndisplay
        ' 
        btndisplay.Location = New Point(25, 348)
        btndisplay.Name = "btndisplay"
        btndisplay.Size = New Size(112, 34)
        btndisplay.TabIndex = 35
        btndisplay.Text = "Display"
        btndisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1250, 698)
        Controls.Add(btndisplay)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Chc_swimming)
        Controls.Add(Chc_clubbing)
        Controls.Add(chc_movies)
        Controls.Add(lst_output)
        Controls.Add(Label10)
        Controls.Add(cbo_course)
        Controls.Add(cbocourse)
        Controls.Add(Txt_DocNo)
        Controls.Add(Label6)
        Controls.Add(Dtp_dob)
        Controls.Add(Label4)
        Controls.Add(Txt_Sname)
        Controls.Add(Label3)
        Controls.Add(Txt_Mname)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txt_fname)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Mname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Sname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dtp_dob As DateTimePicker
    Friend WithEvents rbn_id As RadioButton
    Friend WithEvents rbn_pass As RadioButton
    Friend WithEvents rbn_birthcert As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_DocNo As TextBox
    Friend WithEvents rbn_male As RadioButton
    Friend WithEvents rbn_female As RadioButton
    Friend WithEvents rbn_other As RadioButton
    Friend WithEvents rbn_christian As RadioButton
    Friend WithEvents rbn_muslim As RadioButton
    Friend WithEvents rbn_hindu As RadioButton
    Friend WithEvents cbocourse As Label
    Friend WithEvents cbo_course As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lst_output As ListBox
    Friend WithEvents chc_movies As CheckBox
    Friend WithEvents Chc_clubbing As CheckBox
    Friend WithEvents Chc_swimming As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btndisplay As Button

End Class
