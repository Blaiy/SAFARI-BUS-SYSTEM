Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class FormBooking
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    ' Dim CommandConfirmEmail As MySqlCommand
    'Dim CommandConfirmLicense As MySqlCommand
    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=safaricoach_db"
        Dim Reader As MySqlDataReader
        'Dim LicenseReader As MySqlDataReader


        Try
            MySqlConn.Open()

            Dim Query As String
            Dim Count As Integer
            'Dim LicenseCount As Integer
            Count = 0
            'LicenseCount = 0

            'Dim pattern As String = "^[A-Za-z0-9+_.-]+@(.+)$"
            'Dim PasswordPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
            'Dim Regex As New Regex(pattern)
            'Dim PasswordRegex As New Regex(PasswordPattern)



            Query = "INSERT INTO tickets(CurrentLoc, Destination, StationName, Time, SeatNo, Price) VALUES ('" & ComBoxFrom.Text & "','" & ComBoxTo.Text & "','" & ComBoxStation.Text & "','" & DateTimePickerTicket.Text & "','" & NmrcSeatNo.Text & "','" & NmrcPrice.Text & " ')"
            'QueryEmail = "SELECT * FROM passengers WHERE Email='" & TxtEmail.Text & "'"
            'QueryLicenseNumber = "SELECT * FROM users WHERE LicenseNumber='" & txtSignupLicenseNumber.Text & "'"
            'CommandConfirmEmail = New MySqlCommand(QueryEmail, MySqlConn)
            'CommandConfirmLicense = New MySqlCommand(QueryLicenseNumber, MySqlConn)



            'Reader = CommandConfirmEmail.ExecuteReader
            'While Reader.Read
            'Count = Count + 1
            'End While
            'Reader.Close()

            'LicenseReader = CommandConfirmLicense.ExecuteReader
            'While LicenseReader.Read
            'LicenseCount = LicenseCount + 1
            'End While
            'LicenseReader.Close()


            If True Then

                If Len(ComBoxFrom.Text) = 0 And Len(ComBoxTo.Text) = 0 And Len(ComBoxStation.Text) = 0 And Len(DateTimePickerTicket.Text) = 0 And Len(NmrcSeatNo.Text) And Len(NmrcPrice.Text) = 0 Then
                    MessageBox.Show("Fill the fields required!")
                ElseIf Len(ComBoxFrom.Text) = 0 Then
                    MessageBox.Show("Please your current location")
                ElseIf Len(ComBoxTo.Text) = 0 Then
                    MessageBox.Show("Please enter your destination")
                ElseIf Len(ComBoxStation.Text) = 0 Then
                    MessageBox.Show("Please enter  your current station name")
                ElseIf Len(DateTimePickerTicket.Text) = 0 Then
                    MessageBox.Show("Please enter the date of ticket booking")
                ElseIf Len(NmrcSeatNo.Text) = 0 Then
                    MessageBox.Show("Enter the seat number")
                ElseIf Len(NmrcPrice.Text) = 0 Then
                    MessageBox.Show("Please Enter a valid price as seen on the table")
                ElseIf Count = 0 Then
                    Command = New MySqlCommand(Query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Ticket Booked Successfully")
                    FormLogin.Show()
                    Me.Hide()
                End If
            End If
            ' Reader.Close()
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub
End Class