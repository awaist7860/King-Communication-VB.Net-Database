Public Class Form2

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Customers_Menu.Show()
    End Sub

    Private Sub btnRepairs_Click(sender As Object, e As EventArgs) Handles btnRepairs.Click
        Repairs.Show()
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Invoice.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class