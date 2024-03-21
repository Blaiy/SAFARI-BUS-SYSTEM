Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class FormLogin
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim IsAdminCommand As MySqlCommand
    Private Sub LinkLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogIn.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=safaricoach_db"
        Dim Reader As MySqlDataReader
        'Dim IsAdmin As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM passengers WHERE Email='" & TxtUsername.Text.ToLower & "'AND Password='" & TxtPasswd.Text & "' "
            'Dim IsAdminQuery = "SELECT * FROM passengers WHERE email='" & TxtUsername.Text.ToLower & "' AND is_Admin='1'"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader
            'IsAdminCommand = New MySqlCommand(IsAdminQuery, MySqlConn)

            Dim Count As Integer
            Count = 0
            Dim CountAdmin As Integer = 0
            Dim Pattern As String = "^[A-Za-z0-9+_.-]+@(.+)$"
            Dim Regex As New Regex(Pattern)

            While Reader.Read
                Count = Count + 1
            End While
            Reader.Close()


            If Len(TxtUsername.Text) = 0 And Len(TxtPasswd.Text) = 0 Then
                MessageBox.Show("Please fill the required fields!")
            ElseIf Len(TxtUsername.Text) = 0 Then
                MessageBox.Show("Please enter your email address")
            ElseIf Not Regex.IsMatch(TxtUsername.Text) Then
                MessageBox.Show("Please enter a valid email address.")
            ElseIf Len(TxtPasswd.Text) = 0 Then
                MessageBox.Show("Please enter your password")
            Else
                If Count = 1 Then
                    'IsAdmin = IsAdminCommand.ExecuteReader
                    'While IsAdmin.Read
                    'CountAdmin = CountAdmin + 1
                    'End While
                    'IsAdmin.Close()

                    'If CountAdmin = 1 Then
                    'adminDashboard.Show()
                    'Else
                    'dashboard.Show()
                    'End If
                    FormBooking.Show()
                    Me.Hide()
                ElseIf Count > 1 Then
                    MessageBox.Show("Duplicate email and password entries")
                Else
                    MessageBox.Show("Connection failed")
                End If
            End If

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub
End Class
