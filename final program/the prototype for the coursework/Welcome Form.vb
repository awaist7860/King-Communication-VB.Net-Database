Public Class Welcome_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWelcome.Click
        'This opens the password form
        Form1.Show()
        'this hides the current form, if it is closed, then the whole application is closed
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Welcome_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblKingCommunication.Click

    End Sub
End Class