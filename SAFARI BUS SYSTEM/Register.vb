Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class Register
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim CommandConfirmEmail As MySqlCommand
    Dim CommandConfirmLicense As MySqlCommand

    Private Sub LinkLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogIn.LinkClicked
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'maestro, [3/18/2024 5:17 PM]

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=safaricoach_db"
        Dim Reader As MySqlDataReader
        'Dim LicenseReader As MySqlDataReader


        Try
            MySqlConn.Open()

            Dim Query As String
            Dim QueryEmail As String
            'Dim QueryLicenseNumber As String
            Dim Count As Integer
            Dim LicenseCount As Integer
            Count = 0
            LicenseCount = 0

            Dim pattern As String = "^[A-Za-z0-9+_.-]+@(.+)$"
            Dim PasswordPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
            Dim Regex As New Regex(pattern)
            Dim PasswordRegex As New Regex(PasswordPattern)



            Query = "INSERT INTO passengers(FirstName, LastName, PhoneNumber, Email, Password) VALUES ('" & TxtFirstName.Text & "','" & TxtLastName.Text & "','" & TxtPhoneNumber.Text & "','" & TxtEmail.Text.ToLower & "','" & TxtPassword.Text & "')"
            QueryEmail = "SELECT * FROM passengers WHERE Email='" & TxtEmail.Text & "'"
            'QueryLicenseNumber = "SELECT * FROM users WHERE LicenseNumber='" & txtSignupLicenseNumber.Text & "'"
            CommandConfirmEmail = New MySqlCommand(QueryEmail, MySqlConn)
            'CommandConfirmLicense = New MySqlCommand(QueryLicenseNumber, MySqlConn)



            Reader = CommandConfirmEmail.ExecuteReader
            While Reader.Read
                Count = Count + 1
            End While
            Reader.Close()

            'LicenseReader = CommandConfirmLicense.ExecuteReader
            'While LicenseReader.Read
            'LicenseCount = LicenseCount + 1
            'End While
            'LicenseReader.Close()


            If True Then

                If Len(TxtFirstName.Text) = 0 And Len(TxtLastName.Text) = 0 And Len(TxtPhoneNumber.Text) = 0 And Len(TxtEmail.Text) = 0 And Len(TxtPassword.Text) = 0 Then
                    MessageBox.Show("Fill the fields required!")
                ElseIf Len(TxtFirstName.Text) = 0 Then
                    MessageBox.Show("Please enter your name")
                ElseIf Len(TxtEmail.Text) = 0 Then
                    MessageBox.Show("Please enter your email address")
                ElseIf Not Regex.IsMatch(TxtEmail.Text) Then
                    MessageBox.Show("Please enter a valid email address")
                ElseIf Len(TxtPhoneNumber.Text) = 0 Then
                    MessageBox.Show("Please enter your phone number")
                ElseIf Not IsNumeric(TxtPhoneNumber.Text) Then
                    MessageBox.Show("Phone number cannot contain strings or symbols")

                    ' maestro, [3/18/2024 5:17 PM]
                ElseIf Len(TxtPassword.Text) = 0 Then
                    MessageBox.Show("Please Enter a strong password")
                ElseIf Not PasswordRegex.IsMatch(TxtPassword.Text) Then
                    MessageBox.Show("The password should have a minimum of eight characters, at least one uppercase letter, one lowercase letter, one number and one special character.")
                ElseIf Count = 0 Then
                    Command = New MySqlCommand(Query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Successful Registration")
                    FormLogin.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Email Address already exists, please log in")
                End If
            End If

            Reader.Close()
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub
End Class