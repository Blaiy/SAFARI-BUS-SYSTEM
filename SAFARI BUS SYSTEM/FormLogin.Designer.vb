<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        LblUsername = New Label()
        LblPasswd = New Label()
        TxtUsername = New TextBox()
        TxtPasswd = New TextBox()
        BtnLogin = New Button()
        LinkLogIn = New LinkLabel()
        LblQuestion = New Label()
        SuspendLayout()
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.BackColor = Color.Teal
        LblUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblUsername.ForeColor = SystemColors.Control
        LblUsername.Location = New Point(147, 78)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(64, 25)
        LblUsername.TabIndex = 0
        LblUsername.Text = "Email:"
        ' 
        ' LblPasswd
        ' 
        LblPasswd.AutoSize = True
        LblPasswd.BackColor = Color.Teal
        LblPasswd.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPasswd.ForeColor = SystemColors.Control
        LblPasswd.Location = New Point(147, 172)
        LblPasswd.Name = "LblPasswd"
        LblPasswd.Size = New Size(102, 25)
        LblPasswd.TabIndex = 1
        LblPasswd.Text = "Password:"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(147, 115)
        TxtUsername.Multiline = True
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(201, 31)
        TxtUsername.TabIndex = 2
        ' 
        ' TxtPasswd
        ' 
        TxtPasswd.Location = New Point(147, 202)
        TxtPasswd.Multiline = True
        TxtPasswd.Name = "TxtPasswd"
        TxtPasswd.Size = New Size(201, 31)
        TxtPasswd.TabIndex = 3
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Goldenrod
        BtnLogin.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnLogin.Location = New Point(147, 271)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(201, 39)
        BtnLogin.TabIndex = 14
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' LinkLogIn
        ' 
        LinkLogIn.AutoSize = True
        LinkLogIn.BackColor = Color.Transparent
        LinkLogIn.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLogIn.ForeColor = Color.DarkCyan
        LinkLogIn.LinkColor = Color.White
        LinkLogIn.Location = New Point(147, 371)
        LinkLogIn.Name = "LinkLogIn"
        LinkLogIn.Size = New Size(108, 20)
        LinkLogIn.TabIndex = 17
        LinkLogIn.TabStop = True
        LinkLogIn.Text = "Create account"
        ' 
        ' LblQuestion
        ' 
        LblQuestion.AutoSize = True
        LblQuestion.BackColor = Color.Transparent
        LblQuestion.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblQuestion.ForeColor = SystemColors.ActiveCaptionText
        LblQuestion.Location = New Point(144, 342)
        LblQuestion.Name = "LblQuestion"
        LblQuestion.Size = New Size(159, 20)
        LblQuestion.TabIndex = 16
        LblQuestion.Text = "Don't have an account?"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg_tree_rz_png
        ClientSize = New Size(557, 486)
        Controls.Add(LinkLogIn)
        Controls.Add(LblQuestion)
        Controls.Add(BtnLogin)
        Controls.Add(TxtPasswd)
        Controls.Add(TxtUsername)
        Controls.Add(LblPasswd)
        Controls.Add(LblUsername)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPasswd As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPasswd As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LinkLogIn As LinkLabel
    Friend WithEvents LblQuestion As Label
End Class
