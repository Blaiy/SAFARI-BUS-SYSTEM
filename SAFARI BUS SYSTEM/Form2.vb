﻿Public Class Form2
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim selectedIcon As New System.Drawing.Bitmap(My.Resources.selected)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.booked)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon
                AddHandler c.Click, AddressOf PictureBox1_Click
            End If
        Next
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = selectedIcon
        ElseIf CType(sender, PictureBox).Image Is selectedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

End Class