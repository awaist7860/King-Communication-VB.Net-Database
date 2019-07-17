Public Class Customers_Menu

    Private Sub btnAddCustomerForm_Click(sender As Object, e As EventArgs) Handles btnAddCustomerForm.Click
        Add_Customer.Show()
    End Sub
    Private Sub btnShowCustomerForm_Click(sender As Object, e As EventArgs) Handles btnShowCustomerForm.Click
        Show_or_Ammend_Customer.Show()
    End Sub

    Private Sub Customers_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
        Dim Filename As String
        Filename = "CustomerDetails.dat"
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        NumberOfRecords = LOF(1) / Len(OneCustomer)
        FileClose(1)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Welcome_Form.Close()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class