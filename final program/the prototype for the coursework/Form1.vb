Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'The 2 users that are able to access the application
        If txtUsername.Text = "Awais" And txtPassword.Text = "12345" Or txtUsername.Text = "User2" And txtPassword.Text = "11111" Then
            'if the correct username and password is entered, then the main menu is shown
            Form2.Show()
            Me.Close()
        ElseIf txtPassword.Text = "" Or txtUsername.Text = "" Then
            'this is a pressence check to see if data is entered
            MsgBox("Please type a username and a password")
        Else
            'if the username or password is incorrect, the a message box will appear
            MsgBox("Sorry, username or password is incorrect")
        End If
    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        MsgBox("Please ring or text this number to retrieve the password 07457186802")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
End Class
