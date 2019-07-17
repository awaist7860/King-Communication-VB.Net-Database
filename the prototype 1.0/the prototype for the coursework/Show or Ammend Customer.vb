Public Class Show_or_Ammend_Customer
    Public Filename As String

    Dim myformat As String = "{0,-20}{1, -20}{2, -20}{3, -20}{4,-20}{5, -20}{6, -20}{7, -20}{8, -20}{9, -20}{10, -20}{11, -30}"

    Private Sub btnDisplayTheCustomers_Click(sender As Object, e As EventArgs) Handles btnDisplayTheCustomers.Click
        Dim index As Integer

        FileClose(1)
        lstShowsTheCustomers.Items.Clear()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        MsgBox(" NR" & NumberOfRecords)

        For index = 1 To NumberOfRecords
            FileGet(1, OneCustomer)
            lstShowsTheCustomers.Items.Add(String.Format(myformat, OneCustomer.CustomerNo, OneCustomer.Tittle, OneCustomer.Forname, OneCustomer.Surname, OneCustomer.DoorNo, OneCustomer.StreetName, OneCustomer.Town, OneCustomer.City, OneCustomer.Postcode, OneCustomer.MobileNo, OneCustomer.LandlineNo, OneCustomer.email))
        Next index
        FileClose(1)
    End Sub

    Private Sub Show_or_Ammend_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customers_Menu.Close()
        Form2.Close()
        Filename = "CustomerDetails.dat"
    End Sub

    Private Sub btnMainMenuShow_Click(sender As Object, e As EventArgs) Handles btnMainMenuShow.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class