Public Class Invoice
    'Setting the global variables to be used in the form
    Public Filename As String
    Public recordPosition As Integer
    Dim listboxformat As String = "{0, -5}{1, -6}{2, -15}{3, -15}"
    Public NameOfFile As String
    Dim myFormat As String = "{0, -5}{1,-30}{2,-12}"
    Public PositionOfRecord As Integer
    Public OrderFile As String
    Public orderpositionofrecord As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'As the form is loading, it will close the main menu
        Form2.Close()
        'assigning the file to a variable name
        NameOfFile = "RepairDetails.dat"
        Filename = "CustomerDetails.dat"
        OrderFile = "orderfile.dat"
        lblNumberOfRecords.Text = NumberOfRecords
    End Sub
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        'When the button is clicekd then the main menu is shown and this form is closed
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomerDetails.SelectedIndexChanged
        'This clears the the 3 customer textboxes
        txtCustFor.Clear()
        txtCustNo.Clear()
        txtCustSur.Clear()
        Dim place As Integer
        'This puts any item that is clicekd into the 3 customer text boxes
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        FileGet(1, OneCustomer)
        recordPosition = recordPosition + 1
        txtCustNo.Text = OneCustomer.CustomerNo
        txtCustFor.Text = OneCustomer.Forname
        txtCustSur.Text = OneCustomer.Surname
        'Closing the file
        FileClose(1)
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnShowCustomer.Click
        'Local Varable
        Dim index As Integer
        'assigning the file to a variable name
        Filename = "CustomerDetails.dat"
        'Closing the file to make sure it closed
        FileClose(1)
        'clearing the listbox
        lstCustomerDetails.Items.Clear()
        'Opening the fie to show all the customer in a listbox
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCustomer))
        NumberOfRecords = LOF(1) / Len(OneCustomer)
        MsgBox(" NR" & NumberOfRecords)
        'Looping through each record and showing it in the listbox until there are no more in the file
        For index = 1 To NumberOfRecords
            FileGet(1, OneCustomer)
            lstCustomerDetails.Items.Add(String.Format(listboxformat, OneCustomer.CustomerNo, OneCustomer.Tittle, OneCustomer.Forname, OneCustomer.Surname))
        Next index
        'closing the file at the end
        FileClose(1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShowRepair.Click
        'Local variable
        Dim index As Integer
        'Closing the file to make sure it closed
        FileClose(2)
        'clearing the lstbox
        lstRepairDetails.Items.Clear()
        'Opening the fie to show all the customer in a listbox
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        noOfRecords = LOF(2) / Len(oneRepair)
        MsgBox(" NR" & noOfRecords)
        'Looping through each record and showing it in the listbox until there are no more in the file
        For index = 1 To noOfRecords
            FileGet(2, oneRepair)
            lstRepairDetails.Items.Add(String.Format(myFormat, oneRepair.RepairNo, oneRepair.RepairName, oneRepair.RepairPrice))
        Next index
        'closing the file at the end
        FileClose(2)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'assigning the file to a variable name
        OrderFile = "orderfile.dat"
        'This is where all the data in the textboxes gets put into the variables decalred in the module in the cutomerType structureOneOrder.CustNo = txtCustNo.Text
        OneOrder.CustFor = txtCustFor.Text
        OneOrder.CustSur = txtCustSur.Text
        OneOrder.RepNo = txtCustNo.Text
        OneOrder.RepName = txtRepName.Text
        OneOrder.RepPrice = txtRepPrice.Text
        FileOpen(3, OrderFile, OpenMode.Random, , , Len(OneOrder))
        FilePut(3, OneOrder, orderpositionofrecord + 1)
        'the file closes
        FileClose(3)
        'Once the data is saved and the file is closed, the text boxes are cleared
        txtCustNo.Clear()
        txtCustFor.Clear()
        txtCustSur.Clear()
        txtRepNo.Clear()
        txtRepName.Clear()
        txtRepPrice.Clear()
        'This shows how many records are in the file
        lblNumberOfRecords.Text = NumberOfRecords
        MsgBox("Record Saved")
        NumberOfRecords = NumberOfRecords + 1
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCustFor.TextChanged

    End Sub
    Private Sub lstRepairDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRepairDetails.SelectedIndexChanged
        'This clears the the 3 customer textboxes
        txtRepNo.Clear()
        txtRepName.Clear()
        txtRepPrice.Clear()
        Dim place2 As Integer
        'This puts any item that is clicekd into the 3 customer text boxes
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        FileGet(2, oneRepair)
        PositionOfRecord = PositionOfRecord + 1
        txtRepNo.Text = oneRepair.RepairNo
        txtRepName.Text = oneRepair.RepairName
        txtRepPrice.Text = oneRepair.RepairPrice
        'This closes the file again
        FileClose(2)
    End Sub
    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        'Local variable
        Dim index3 As Integer
        'Closing the file to make sure it closed
        FileClose(3)
        'clearing the listbox
        lstViewOrders.Items.Clear()
        'Opening the fie to show all the customer in a listbox
        FileOpen(3, OrderFile, OpenMode.Random, , , Len(OneOrder))
        orderpositionofrecord = LOF(3) / Len(OneOrder)
        MsgBox(" NR" & orderpositionofrecord)
        'Looping through each record and showing it in the listbox until there are no more in the file
        For index3 = 1 To orderpositionofrecord
            FileGet(3, OneOrder)
            lstViewOrders.Items.Add(String.Format(myFormat, OneOrder.CustFor, OneOrder.RepName, OneOrder.RepPrice))
        Next index3
        'closing the file at the end
        FileClose(3)
    End Sub

    Private Sub label_Click(sender As Object, e As EventArgs) Handles lblRepPrice.Click

    End Sub
End Class