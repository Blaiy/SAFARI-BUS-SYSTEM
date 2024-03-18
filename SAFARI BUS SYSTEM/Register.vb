Public Class Register
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstName.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub First_Name_Click(sender As Object, e As EventArgs) Handles LblFirstName.Click

    End Sub

    Private Sub LblQuestion_Click(sender As Object, e As EventArgs) Handles LblQuestion.Click

    End Sub

    Private Sub LinkLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogIn.LinkClicked
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class