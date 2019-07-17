Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Awais" And txtPassword.Text = "12345" Or txtUsername.Text = "User2" And txtPassword.Text = "11111" Then
            Form2.Show()
        ElseIf txtPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("Please type a username and a password")
        Else
            MsgBox("Sorry, username or password is incorrect")
        End If

    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        MsgBox("Please ring or text this number to retrieve the password 07457186802")
    End Sub

End Class
