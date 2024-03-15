<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Registration = New Label()
        LblFirstName = New Label()
        LblLastName = New Label()
        LblPhoneNo = New Label()
        LblEmail = New Label()
        LblPassword = New Label()
        TxtFirstName = New TextBox()
        TxtLastName = New TextBox()
        TxtPhoneNumber = New TextBox()
        TxtEmail = New TextBox()
        TxtPassword = New TextBox()
        BtnRegister = New Button()
        LblQuestion = New Label()
        LinkLogIn = New LinkLabel()
        SuspendLayout()
        ' 
        ' Registration
        ' 
        Registration.AutoSize = True
        Registration.BackColor = Color.DarkCyan
        Registration.Font = New Font("Cambria", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Registration.Location = New Point(118, 36)
        Registration.Name = "Registration"
        Registration.Size = New Size(311, 32)
        Registration.TabIndex = 0
        Registration.Text = "Welcome to Safari Coach"
        ' 
        ' LblFirstName
        ' 
        LblFirstName.AutoSize = True
        LblFirstName.BackColor = Color.Teal
        LblFirstName.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblFirstName.Location = New Point(89, 125)
        LblFirstName.Name = "LblFirstName"
        LblFirstName.Size = New Size(101, 24)
        LblFirstName.TabIndex = 1
        LblFirstName.Text = "First Name"
        ' 
        ' LblLastName
        ' 
        LblLastName.AutoSize = True
        LblLastName.BackColor = Color.Teal
        LblLastName.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblLastName.Location = New Point(89, 193)
        LblLastName.Name = "LblLastName"
        LblLastName.Size = New Size(99, 24)
        LblLastName.TabIndex = 2
        LblLastName.Text = "Last Name"
        ' 
        ' LblPhoneNo
        ' 
        LblPhoneNo.AutoSize = True
        LblPhoneNo.BackColor = Color.Teal
        LblPhoneNo.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPhoneNo.Location = New Point(89, 259)
        LblPhoneNo.Name = "LblPhoneNo"
        LblPhoneNo.Size = New Size(140, 24)
        LblPhoneNo.TabIndex = 4
        LblPhoneNo.Text = "Phone Number"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = Color.Teal
        LblEmail.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblEmail.Location = New Point(89, 322)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(62, 24)
        LblEmail.TabIndex = 5
        LblEmail.Text = "Email "
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.BackColor = Color.Teal
        LblPassword.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPassword.Location = New Point(89, 388)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(92, 24)
        LblPassword.TabIndex = 6
        LblPassword.Text = "Password"
        ' 
        ' TxtFirstName
        ' 
        TxtFirstName.Location = New Point(267, 129)
        TxtFirstName.Name = "TxtFirstName"
        TxtFirstName.Size = New Size(214, 23)
        TxtFirstName.TabIndex = 7
        ' 
        ' TxtLastName
        ' 
        TxtLastName.Location = New Point(267, 197)
        TxtLastName.Name = "TxtLastName"
        TxtLastName.Size = New Size(214, 23)
        TxtLastName.TabIndex = 8
        ' 
        ' TxtPhoneNumber
        ' 
        TxtPhoneNumber.Location = New Point(267, 263)
        TxtPhoneNumber.Name = "TxtPhoneNumber"
        TxtPhoneNumber.Size = New Size(214, 23)
        TxtPhoneNumber.TabIndex = 9
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(267, 326)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(214, 23)
        TxtEmail.TabIndex = 10
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(267, 392)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(214, 23)
        TxtPassword.TabIndex = 11
        ' 
        ' BtnRegister
        ' 
        BtnRegister.BackColor = Color.Goldenrod
        BtnRegister.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnRegister.Location = New Point(181, 450)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(201, 39)
        BtnRegister.TabIndex = 13
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = False
        ' 
        ' LblQuestion
        ' 
        LblQuestion.AutoSize = True
        LblQuestion.BackColor = Color.Transparent
        LblQuestion.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblQuestion.ForeColor = SystemColors.ButtonFace
        LblQuestion.Location = New Point(169, 512)
        LblQuestion.Name = "LblQuestion"
        LblQuestion.Size = New Size(172, 20)
        LblQuestion.TabIndex = 14
        LblQuestion.Text = "Already have an account?"
        ' 
        ' LinkLogIn
        ' 
        LinkLogIn.AutoSize = True
        LinkLogIn.BackColor = Color.Transparent
        LinkLogIn.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLogIn.ForeColor = SystemColors.Control
        LinkLogIn.LinkColor = Color.White
        LinkLogIn.Location = New Point(347, 512)
        LinkLogIn.Name = "LinkLogIn"
        LinkLogIn.Size = New Size(46, 20)
        LinkLogIn.TabIndex = 15
        LinkLogIn.TabStop = True
        LinkLogIn.Text = "Login"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(606, 558)
        Controls.Add(LinkLogIn)
        Controls.Add(LblQuestion)
        Controls.Add(BtnRegister)
        Controls.Add(TxtPassword)
        Controls.Add(TxtEmail)
        Controls.Add(TxtPhoneNumber)
        Controls.Add(TxtLastName)
        Controls.Add(TxtFirstName)
        Controls.Add(LblPassword)
        Controls.Add(LblEmail)
        Controls.Add(LblPhoneNo)
        Controls.Add(LblLastName)
        Controls.Add(LblFirstName)
        Controls.Add(Registration)
        ForeColor = SystemColors.Control
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Registration As Label
    Friend WithEvents LblFirstName As Label
    Friend WithEvents LblLastName As Label
    Friend WithEvents LblPhoneNo As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents TxtPhoneNumber As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents LblQuestion As Label
    Friend WithEvents LinkLogIn As LinkLabel
End Class
