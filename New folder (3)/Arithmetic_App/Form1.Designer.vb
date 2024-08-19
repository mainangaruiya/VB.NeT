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
        components = New ComponentModel.Container()
        dtp_Dob = New DateTimePicker()
        lbl_Dob = New Label()
        btn_login = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        SuspendLayout()
        ' 
        ' dtp_Dob
        ' 
        dtp_Dob.Location = New Point(211, 205)
        dtp_Dob.Name = "dtp_Dob"
        dtp_Dob.Size = New Size(300, 31)
        dtp_Dob.TabIndex = 0
        ' 
        ' lbl_Dob
        ' 
        lbl_Dob.AutoSize = True
        lbl_Dob.Location = New Point(256, 153)
        lbl_Dob.Name = "lbl_Dob"
        lbl_Dob.Size = New Size(201, 25)
        lbl_Dob.TabIndex = 1
        lbl_Dob.Text = "Enter your Date Of Birth"
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(211, 313)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(300, 43)
        btn_login.TabIndex = 2
        btn_login.Text = "Proceed"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_login)
        Controls.Add(lbl_Dob)
        Controls.Add(dtp_Dob)
        Name = "Form1"
        Text = "Login form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtp_Dob As DateTimePicker
    Friend WithEvents lbl_Dob As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip

End Class
