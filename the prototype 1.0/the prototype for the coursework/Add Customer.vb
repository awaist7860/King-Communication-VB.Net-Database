Public Class Add_Customer
    Public Filename As String
    Public NumberOfRecords As Integer
    Dim myformat As String = "{0,-6}{1, -4}{2, -12}{3, -12}{4,-3}{5, -12}{6, -12}{7, -15}{8, -8}{9, -13}{10, -13}{11, -20}"
    Dim OneCustomer As CustomerType
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Form2.Show()
        Me.Close()
    End Sub

    Public Sub Add_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customers_Menu.Close()
        Form2.Close()

        Filename = "CustomerDetails.dat"
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        NumberOfRecords = LOF(1) / Len(OneCustomer)
        lblNumberOfRecords.Text = NumberOfRecords
        FileClose(1)

        'make a number of customer label
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

        OneCustomer.CustomerNo = txtCustomerNo.Text
        OneCustomer.Tittle = txtTittle.Text
        OneCustomer.Forname = txtForname.Text
        OneCustomer.Surname = txtSurname.Text
        OneCustomer.DoorNo = txtDoorNo.Text
        OneCustomer.StreetName = txtStreetName.Text
        OneCustomer.Town = txtTown.Text
        OneCustomer.City = txtCity.Text
        OneCustomer.Postcode = txtPostcode.Text
        OneCustomer.MobileNo = txtMobileNo.Text
        OneCustomer.LandlineNo = txtLandlineNo.Text
        OneCustomer.email = txtEmail.Text
        'msgBoxx(OneCustomer.Description)
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        FilePut(1, OneCustomer, NumberOfRecords + 1)
        FileClose(1)
        MsgBox("Record Saved")
        NumberOfRecords = NumberOfRecords + 1
    End Sub


    Private Sub lstShowCustomerDetails_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class