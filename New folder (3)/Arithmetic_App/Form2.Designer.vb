<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lbl_Grade = New Label()
        lbl_Number1 = New Label()
        lbl_Number2 = New Label()
        lbl_Question = New Label()
        lbl_Operator = New Label()
        cmb_Grade = New ComboBox()
        txt_Operator = New TextBox()
        txt_Answer = New TextBox()
        lbl_answer = New Label()
        btn_Exit = New Button()
        btn_Submit = New Button()
        btn_Generate = New Button()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' lbl_Grade
        ' 
        lbl_Grade.AutoSize = True
        lbl_Grade.Location = New Point(250, 7)
        lbl_Grade.Name = "lbl_Grade"
        lbl_Grade.Size = New Size(150, 25)
        lbl_Grade.TabIndex = 0
        lbl_Grade.Text = "Select your grade"
        ' 
        ' lbl_Number1
        ' 
        lbl_Number1.AutoSize = True
        lbl_Number1.Location = New Point(192, 141)
        lbl_Number1.Name = "lbl_Number1"
        lbl_Number1.Size = New Size(101, 25)
        lbl_Number1.TabIndex = 1
        lbl_Number1.Text = "Number 1 :"
        ' 
        ' lbl_Number2
        ' 
        lbl_Number2.AutoSize = True
        lbl_Number2.Location = New Point(192, 175)
        lbl_Number2.Name = "lbl_Number2"
        lbl_Number2.Size = New Size(101, 25)
        lbl_Number2.TabIndex = 2
        lbl_Number2.Text = "Number 2 :"
        ' 
        ' lbl_Question
        ' 
        lbl_Question.AutoSize = True
        lbl_Question.Location = New Point(155, 383)
        lbl_Question.Name = "lbl_Question"
        lbl_Question.Size = New Size(218, 25)
        lbl_Question.TabIndex = 3
        lbl_Question.Text = "Question will appear here "
        ' 
        ' lbl_Operator
        ' 
        lbl_Operator.AutoSize = True
        lbl_Operator.Location = New Point(141, 227)
        lbl_Operator.Name = "lbl_Operator"
        lbl_Operator.Size = New Size(93, 25)
        lbl_Operator.TabIndex = 4
        lbl_Operator.Text = "Operator :"
        ' 
        ' cmb_Grade
        ' 
        cmb_Grade.FormattingEnabled = True
        cmb_Grade.Location = New Point(240, 35)
        cmb_Grade.Name = "cmb_Grade"
        cmb_Grade.Size = New Size(182, 33)
        cmb_Grade.TabIndex = 5
        ' 
        ' txt_Operator
        ' 
        txt_Operator.Location = New Point(240, 224)
        txt_Operator.Name = "txt_Operator"
        txt_Operator.Size = New Size(173, 31)
        txt_Operator.TabIndex = 6
        ToolTip1.SetToolTip(txt_Operator, "Enter operator (+, -, *, /)")
        ' 
        ' txt_Answer
        ' 
        txt_Answer.Location = New Point(240, 274)
        txt_Answer.Name = "txt_Answer"
        txt_Answer.Size = New Size(173, 31)
        txt_Answer.TabIndex = 7
        ToolTip2.SetToolTip(txt_Answer, "Enter your answer ")
        ' 
        ' lbl_answer
        ' 
        lbl_answer.AutoSize = True
        lbl_answer.Location = New Point(155, 280)
        lbl_answer.Name = "lbl_answer"
        lbl_answer.Size = New Size(79, 25)
        lbl_answer.TabIndex = 8
        lbl_answer.Text = "Answer :"
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Location = New Point(357, 332)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(112, 34)
        btn_Exit.TabIndex = 9
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_Submit
        ' 
        btn_Submit.Location = New Point(192, 332)
        btn_Submit.Name = "btn_Submit"
        btn_Submit.Size = New Size(112, 34)
        btn_Submit.TabIndex = 10
        btn_Submit.Text = "Submit Answer"
        btn_Submit.UseVisualStyleBackColor = True
        ' 
        ' btn_Generate
        ' 
        btn_Generate.Location = New Point(192, 85)
        btn_Generate.Name = "btn_Generate"
        btn_Generate.Size = New Size(277, 34)
        btn_Generate.TabIndex = 11
        btn_Generate.Text = "Generate Random Numbers"
        btn_Generate.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(299, 135)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(299, 172)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 13
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btn_Generate)
        Controls.Add(btn_Submit)
        Controls.Add(btn_Exit)
        Controls.Add(lbl_answer)
        Controls.Add(txt_Answer)
        Controls.Add(txt_Operator)
        Controls.Add(cmb_Grade)
        Controls.Add(lbl_Operator)
        Controls.Add(lbl_Question)
        Controls.Add(lbl_Number2)
        Controls.Add(lbl_Number1)
        Controls.Add(lbl_Grade)
        Name = "Form2"
        Text = "Calculations"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_Grade As Label
    Friend WithEvents lbl_Number1 As Label
    Friend WithEvents lbl_Number2 As Label
    Friend WithEvents lbl_Question As Label
    Friend WithEvents lbl_Operator As Label
    Friend WithEvents cmb_Grade As ComboBox
    Friend WithEvents txt_Operator As TextBox
    Friend WithEvents txt_Answer As TextBox
    Friend WithEvents lbl_answer As Label
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Submit As Button
    Friend WithEvents btn_Generate As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
