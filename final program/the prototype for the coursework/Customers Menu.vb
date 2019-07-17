Public Class Customers_Menu
    Private Sub btnAddCustomerForm_Click(sender As Object, e As EventArgs) Handles btnAddCustomerForm.Click
        'When this button is clicked, it will show the add customer form
        Add_Customer.Show()
    End Sub
    Private Sub btnShowCustomerForm_Click(sender As Object, e As EventArgs) Handles btnShowCustomerForm.Click
        'When this button is clicked, it will show the ammened a customer form
        Show_or_Ammend_Customer.Show()
    End Sub
    Private Sub Customers_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When this form is loading, t will cloe the main menu
        Form2.Close()
        'As the form is loading it will open and close the customer details file
        Dim Filename As String
        Filename = "CustomerDetails.dat"
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        NumberOfRecords = LOF(1) / Len(OneCustomer)
        FileClose(1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'When this button is clicked, it will open the main menu and close itself
        Form2.Show()
        Me.Close()
    End Sub
End Class