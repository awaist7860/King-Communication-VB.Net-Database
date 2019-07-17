Public Class Add_Customer
    'Setting the global variables to be used in the form
    Public Filename As String
    Public NumberOfRecords As Integer
    Dim myformat As String = "{0,-3}{1, -4}{2, -20}{3, -20}{4,-3}{5, -20}{6, -20}{7, -20}{8, -7}{9, -11}{10, -11}{11, -30}"
    Dim OneCustomer As CustomerType
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'This will open the main menu
        Form2.Show()
        'this will close this form
        Me.Close()
    End Sub

    Public Sub Add_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads, it will close the customer menu
        Customers_Menu.Close()
        'When the form loads, it will close the main menu
        Form2.Close()
        'this will add a customer to the customer details file
        Filename = "CustomerDetails.dat"
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        NumberOfRecords = LOF(1) / Len(OneCustomer)
        lblNumberOfRecords.Text = NumberOfRecords
        FileClose(1)
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        'Validation rule on the customer NO using a hashing algorithm
        'This get the first 3 charecters of a name, does some calculations assigns number to them, and does calulations on them
        Dim i As Short
        Dim charFirstName() As Char = txtForname.Text.ToCharArray
        i = 0
        For i = 0 To 2
            If charFirstName(i) = "A" Then
                charFirstName(i) = ChrW(1)
            ElseIf charFirstName(i) = "B" Then
                charFirstName(i) = ChrW(2)
            ElseIf charFirstName(i) = "C" Then
                charFirstName(i) = ChrW(3)
            ElseIf charFirstName(i) = "D" Then
                charFirstName(i) = ChrW(4)
            ElseIf charFirstName(i) = "E" Then
                charFirstName(i) = ChrW(5)
            ElseIf charFirstName(i) = "F" Then
                charFirstName(i) = ChrW(6)
            ElseIf charFirstName(i) = "G" Then
                charFirstName(i) = ChrW(7)
            ElseIf charFirstName(i) = "H" Then
                charFirstName(i) = ChrW(8)
            ElseIf charFirstName(i) = "I" Then
                charFirstName(i) = ChrW(9)
            ElseIf charFirstName(i) = "J" Then
                charFirstName(i) = ChrW(10)
            ElseIf charFirstName(i) = "K" Then
                charFirstName(i) = ChrW(11)
            ElseIf charFirstName(i) = "L" Then
                charFirstName(i) = ChrW(12)
            ElseIf charFirstName(i) = "M" Then
                charFirstName(i) = ChrW(13)
            ElseIf charFirstName(i) = "N" Then
                charFirstName(i) = ChrW(14)
            ElseIf charFirstName(i) = "O" Then
                charFirstName(i) = ChrW(15)
            ElseIf charFirstName(i) = "P" Then
                charFirstName(i) = ChrW(16)
            ElseIf charFirstName(i) = "Q" Then
                charFirstName(i) = ChrW(17)
            ElseIf charFirstName(i) = "R" Then
                charFirstName(i) = ChrW(18)
            ElseIf charFirstName(i) = "S" Then
                charFirstName(i) = ChrW(19)
            ElseIf charFirstName(i) = "T" Then
                charFirstName(i) = ChrW(20)
            ElseIf charFirstName(i) = "U" Then
                charFirstName(i) = ChrW(21)
            ElseIf charFirstName(i) = "V" Then
                charFirstName(i) = ChrW(22)
            ElseIf charFirstName(i) = "W" Then
                charFirstName(i) = ChrW(23)
            ElseIf charFirstName(i) = "X" Then
                charFirstName(i) = ChrW(24)
            ElseIf charFirstName(i) = "Y" Then
                charFirstName(i) = ChrW(25)
            ElseIf charFirstName(i) = "Z" Then
                charFirstName(i) = ChrW(26)
            Else
                charFirstName(i) = ChrW(0)
            End If
            i = i + 1
        Next
        'This is where all the data in the textboxes gets put into the variables decalred in the module in the cutomerType structure
        OneCustomer.CustomerNo = AscW(charFirstName(0)) + AscW(charFirstName(1)) * 2 + AscW(charFirstName(2)) * 3 + (NumberOfRecords + 1) * 100
        OneCustomer.Tittle = txtTittle.Text
        OneCustomer.Forname = txtForname.Text
        OneCustomer.Surname = txtSurname.Text
        OneCustomer.DoorNo = txtDoorNo.Text
        OneCustomer.StreetName = txtStreetName.Text
        OneCustomer.Town = txtTown.Text
        OneCustomer.County = txtCounty.Text
        OneCustomer.Postcode = txtPostcode.Text
        OneCustomer.MobileNo = txtMobileNo.Text
        OneCustomer.LandlineNo = txtLandlineNo.Text
        OneCustomer.email = txtEmail.Text
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        FilePut(1, OneCustomer, NumberOfRecords + 1)
        'the file closes
        FileClose(1)
        'Once the data is saved and the file is closed, the text boxes are cleared
        txtCounty.Clear()
        txtCustomerNo.Clear()
        txtDoorNo.Clear()
        txtEmail.Clear()
        txtForname.Clear()
        txtForname.Clear()
        txtLandlineNo.Clear()
        txtMobileNo.Clear()
        txtPostcode.Clear()
        txtStreetName.Clear()
        txtSurname.Clear()
        txtTittle.Clear()
        txtTown.Clear()
        'This shows how many records are in the file
        lblNumberOfRecords.Text = NumberOfRecords
        MsgBox("Record Saved")
        NumberOfRecords = NumberOfRecords + 1
    End Sub
    Private Sub lstShowCustomerDetails_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCounty.TextChanged

    End Sub
    Private Sub lblNumberOfRecords_Click(sender As Object, e As EventArgs) Handles lblNumberOfRecords.Click

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub

    Private Sub txtDoorNo_TextChanged(sender As Object, e As EventArgs) Handles txtDoorNo.TextChanged

    End Sub

    Private Sub txtStreetName_TextChanged(sender As Object, e As EventArgs) Handles txtStreetName.TextChanged

    End Sub

    Private Sub txtPostcode_TextChanged(sender As Object, e As EventArgs) Handles txtPostcode.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDoorNo.Click

    End Sub
End Class