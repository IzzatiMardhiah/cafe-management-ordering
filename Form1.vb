Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TbUserName.Text = "" Or TbPassword.Text = "" Then
            MsgBox("Enter UserName and Password")
        ElseIf TbUserName.Text = "Admin" And TbPassword.Text = "Password" Then
            Dim obj = New itemsvb
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong User or Password")
            TbUserName.Text = ""
            TbPassword.Text = ""
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim obj = New orders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class
