Public Class Show_or_Ammend_Customer
    Public Filename As String
    Public recordPosition As Integer
    Dim myformat As String = "{0,-20}{1, -20}{2, -20}{3, -20}{4,-20}{5, -20}{6, -20}{7, -20}{8, -20}{9, -20}{10, -20}{11, -30}"
    Dim listboxformat As String = "{0, -3}{1, -4}{2, -12}{3, -12}"

    Private Sub btnDisplayTheCustomers_Click(sender As Object, e As EventArgs) Handles btnDisplayTheCustomers.Click
        Dim index As Integer

        FileClose(1)
        lstShowsTheCustomers.Items.Clear()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        MsgBox(" NR" & NumberOfRecords)

        For index = 1 To NumberOfRecords
            FileGet(1, OneCustomer)
            'lstShowsTheCustomers.Items.Add(String.Format(myformat, OneCustomer.CustomerNo, OneCustomer.Tittle, OneCustomer.Forname, OneCustomer.Surname, OneCustomer.DoorNo, OneCustomer.StreetName, OneCustomer.Town, OneCustomer.County, OneCustomer.Postcode, OneCustomer.MobileNo, OneCustomer.LandlineNo, OneCustomer.email))
            lstShowsTheCustomers.Items.Add(String.Format(listboxformat, OneCustomer.CustomerNo, OneCustomer.Tittle, OneCustomer.Forname, OneCustomer.Surname))

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

    Private Sub btnNameSearch_Click(sender As Object, e As EventArgs) Handles btnNameSearch.Click
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        Dim finder As String
        Dim found As Boolean
        finder = txtNameSearch.Text
        Do
            FileGet(1, OneCustomer)
            RecordPosition = RecordPosition + 1
            If finder = Trim(OneCustomer.Forname) Then
                found = True

            End If

        Loop Until EOF(1) Or found = True
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
        FileClose()

    End Sub

    Private Sub lstShowsTheCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShowsTheCustomers.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
        'msgBoxx(OneCustomer.Description)
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        FilePut(1, OneCustomer, recordPosition)
        FileClose(1)
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Welcome_Form.Close()


    End Sub
End Class