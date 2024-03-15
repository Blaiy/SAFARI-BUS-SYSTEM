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
        First_Name = New Label()
        Last_Name = New Label()
        Phone_Number = New Label()
        Email_ID = New Label()
        Password = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmailID = New TextBox()
        txtPassword = New TextBox()
        btnRegister = New Button()
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
        ' First_Name
        ' 
        First_Name.AutoSize = True
        First_Name.BackColor = Color.Teal
        First_Name.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        First_Name.Location = New Point(89, 125)
        First_Name.Name = "First_Name"
        First_Name.Size = New Size(101, 24)
        First_Name.TabIndex = 1
        First_Name.Text = "First Name"
        ' 
        ' Last_Name
        ' 
        Last_Name.AutoSize = True
        Last_Name.BackColor = Color.Teal
        Last_Name.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Last_Name.Location = New Point(89, 193)
        Last_Name.Name = "Last_Name"
        Last_Name.Size = New Size(99, 24)
        Last_Name.TabIndex = 2
        Last_Name.Text = "Last Name"
        ' 
        ' Phone_Number
        ' 
        Phone_Number.AutoSize = True
        Phone_Number.BackColor = Color.Teal
        Phone_Number.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Phone_Number.Location = New Point(89, 259)
        Phone_Number.Name = "Phone_Number"
        Phone_Number.Size = New Size(140, 24)
        Phone_Number.TabIndex = 4
        Phone_Number.Text = "Phone Number"
        ' 
        ' Email_ID
        ' 
        Email_ID.AutoSize = True
        Email_ID.BackColor = Color.Teal
        Email_ID.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Email_ID.Location = New Point(89, 322)
        Email_ID.Name = "Email_ID"
        Email_ID.Size = New Size(79, 24)
        Email_ID.TabIndex = 5
        Email_ID.Text = "Email ID"
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.BackColor = Color.Teal
        Password.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(89, 388)
        Password.Name = "Password"
        Password.Size = New Size(92, 24)
        Password.TabIndex = 6
        Password.Text = "Password"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(296, 125)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(214, 23)
        txtFirstName.TabIndex = 7
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(296, 193)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(214, 23)
        txtLastName.TabIndex = 8
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(296, 263)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(214, 23)
        txtPhoneNumber.TabIndex = 9
        ' 
        ' txtEmailID
        ' 
        txtEmailID.Location = New Point(296, 326)
        txtEmailID.Name = "txtEmailID"
        txtEmailID.Size = New Size(214, 23)
        txtEmailID.TabIndex = 10
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(296, 392)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(214, 23)
        txtPassword.TabIndex = 11
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Goldenrod
        btnRegister.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(170, 457)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(201, 39)
        btnRegister.TabIndex = 13
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(606, 558)
        Controls.Add(btnRegister)
        Controls.Add(txtPassword)
        Controls.Add(txtEmailID)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(Password)
        Controls.Add(Email_ID)
        Controls.Add(Phone_Number)
        Controls.Add(Last_Name)
        Controls.Add(First_Name)
        Controls.Add(Registration)
        ForeColor = SystemColors.ButtonFace
        Name = "Register"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Registration As Label
    Friend WithEvents First_Name As Label
    Friend WithEvents Last_Name As Label
    Friend WithEvents Phone_Number As Label
    Friend WithEvents Email_ID As Label
    Friend WithEvents Password As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmailID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
End Class
