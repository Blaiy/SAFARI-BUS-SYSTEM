Public Class FormLogin
    Private Sub Picture_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblUsername_Click(sender As Object, e As EventArgs) Handles LblUsername.Click

    End Sub

    Private Sub LinkLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogIn.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub
End Class
