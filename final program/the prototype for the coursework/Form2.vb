Public Class Form2
    Public NameOfFile As String
    Public Filename As String
    Public OrderFile As String
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        'this shows the customers menu
        Customers_Menu.Show()
    End Sub
    Private Sub btnRepairs_Click(sender As Object, e As EventArgs) Handles btnRepairs.Click
        'this shows he repair menu
        Repair_Menu_Fom.Show()
    End Sub
    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        'this shows the invoice form
        Invoice.Show()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'assigning the file to a variable name
        NameOfFile = "RepairDetails.dat"
        Filename = "CustomerDetails.dat"
        OrderFile = "orderfile.dat"
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
End Class