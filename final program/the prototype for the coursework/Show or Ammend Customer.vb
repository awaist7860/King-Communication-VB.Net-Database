Public Class Show_or_Ammend_Customer
    'Setting the global variables to be used in the form
    Public Filename As String
    Public recordPosition As Integer
    Dim myformat As String = "{0,-20}{1, -20}{2, -20}{3, -20}{4,-20}{5, -20}{6, -20}{7, -20}{8, -20}{9, -20}{10, -20}{11, -30}"
    Dim listboxformat As String = "{0, -5}{1, -6}{2, -15}{3, -15}"
    Private Sub btnDisplayTheCustomers_Click(sender As Object, e As EventArgs) Handles btnDisplayTheCustomers.Click
        'Local variable
        Dim index As Integer
        'Closing the file to make sure it closed
        FileClose(1)
        'clearing the listbox
        lstShowsTheCustomers.Items.Clear()
        'Opening the fie to show all the customer in a listbox
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        MsgBox(" NR" & NumberOfRecords)
        'Looping through each record and showing it in the listbox until there are no more in the file
        For index = 1 To NumberOfRecords
            FileGet(1, OneCustomer)
            lstShowsTheCustomers.Items.Add(String.Format(listboxformat, OneCustomer.CustomerNo, OneCustomer.Tittle, OneCustomer.Forname, OneCustomer.Surname))
        Next index
        'closing the file at the end
        FileClose(1)
    End Sub
    Private Sub Show_or_Ammend_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'As the form is loading, it will close the customer menu form and the main menu form
        Customers_Menu.Close()
        Form2.Close()
        'assigning the file to a variable name
        Filename = "CustomerDetails.dat"
    End Sub
    Private Sub btnMainMenuShow_Click(sender As Object, e As EventArgs) Handles btnMainMenuShow.Click
        'When the button is clicekd then the main menu is shown and this form is closed
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnNameSearch_Click(sender As Object, e As EventArgs) Handles btnNameSearch.Click
        'This is a search funtion
        'It opens the file, then it stores what ever the user has typed into the searchbox in to the finder variable
        'Then a do loop until is running, it goes thorugh each recorduntil it has fnd it or if it has reached the end of the file
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        Dim finder As String
        Dim found As Boolean
        finder = txtNameSearch.Text
        Do
            FileGet(1, OneCustomer)
            recordPosition = recordPosition + 1
            If finder = Trim(OneCustomer.Forname) Then
                found = True
            End If
        Loop Until EOF(1) Or found = True
        'If it has found the record, then it pulls all of the data and puts it in the textboxes
        Dim position1 As Integer
        txtCustomerNo2.Text = position1
        MsgBox(OneCustomer.Surname)
        txtSurname2.Text = OneCustomer.Surname
        txtCounty2.Text = OneCustomer.County
        txtCustomerNo2.Text = OneCustomer.CustomerNo
        txtDoorNo2.Text = OneCustomer.DoorNo
        txtEmail2.Text = OneCustomer.email
        txtForname2.Text = OneCustomer.Forname
        txtLandlineNo2.Text = OneCustomer.LandlineNo
        txtMobileNo2.Text = OneCustomer.MobileNo
        txtPostcode2.Text = OneCustomer.Postcode
        txtStreetName2.Text = OneCustomer.StreetName
        txtTittle2.Text = OneCustomer.Tittle
        txtTown2.Text = OneCustomer.Town
        'Then the file closes
        FileClose()
    End Sub
    Private Sub lstShowsTheCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShowsTheCustomers.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'This updates the record in the file with new information
        OneCustomer.CustomerNo = txtCustomerNo2.Text
        OneCustomer.Tittle = txtTittle2.Text
        OneCustomer.Forname = txtForname2.Text
        OneCustomer.Surname = txtSurname2.Text
        OneCustomer.DoorNo = txtDoorNo2.Text
        OneCustomer.StreetName = txtStreetName2.Text
        OneCustomer.Town = txtTown2.Text
        OneCustomer.County = txtCounty2.Text
        OneCustomer.Postcode = txtPostcode2.Text
        OneCustomer.MobileNo = txtMobileNo2.Text
        OneCustomer.LandlineNo = txtLandlineNo2.Text
        OneCustomer.email = txtEmail2.Text
        'This opens the file
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        'This stores anything that is enterd in the textboxes in the same location where the record was
        FilePut(1, OneCustomer, recordPosition)
        'The file closes again
        FileClose(1)
        'when the button s clicked, then the text boxes clear
        txtCounty2.Clear()
        txtCustomerNo2.Clear()
        txtDoorNo2.Clear()
        txtEmail2.Clear()
        txtForname2.Clear()
        txtForname2.Clear()
        txtLandlineNo2.Clear()
        txtMobileNo2.Clear()
        txtPostcode2.Clear()
        txtStreetName2.Clear()
        txtSurname2.Clear()
        txtTittle2.Clear()
        txtTown2.Clear()
        MsgBox("Record Saved")
        NumberOfRecords = NumberOfRecords + 1
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
    Private Sub txtCustomerNo2_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerNo2.TextChanged

    End Sub
    Private Sub txtNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtNameSearch.TextChanged

    End Sub
End Class