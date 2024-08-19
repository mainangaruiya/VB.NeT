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
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        LBLOUTPUT = New Label()
        Button = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 25)
        Label1.TabIndex = 0
        Label1.Text = "Date of Birth"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(98, 106)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 1
        ' 
        ' LBLOUTPUT
        ' 
        LBLOUTPUT.AutoSize = True
        LBLOUTPUT.Location = New Point(131, 164)
        LBLOUTPUT.Name = "LBLOUTPUT"
        LBLOUTPUT.Size = New Size(63, 25)
        LBLOUTPUT.TabIndex = 2
        LBLOUTPUT.Text = "Label2"
        ' 
        ' Button
        ' 
        Button.Location = New Point(410, 107)
        Button.Name = "Button"
        Button.Size = New Size(199, 34)
        Button.TabIndex = 3
        Button.Text = "Compute age"
        Button.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(645, 450)
        Controls.Add(Button)
        Controls.Add(LBLOUTPUT)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LBLOUTPUT As Label
    Friend WithEvents Button As Button

End Class
