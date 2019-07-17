Public Class Display_Or_Ammened_A_Repair_form
    'Setting the global variables to be used in the form
    Public NameOfFile As String
    Dim myFormat As String = "{0, -5}{1,-15}{2,-12}"
    Public PositionOfRecord As Integer
    Private Sub Display_Or_Ammened_A_Repair_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads, the repair menu closes and the main menu closes
        Repair_Menu_Fom.Close()
        Form2.Close()
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'When the button is clicekd then the main menu is shown and this form is closed form
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub btnShowRepairs_Click(sender As Object, e As EventArgs) Handles btnShowRepairs.Click
        'Local variable
        Dim index As Integer
        'assigning the file to a variable name
        NameOfFile = "RepairDetails.dat"
        'clearing the lstbox
        lstShowRepairs.Items.Clear()
        'Closing the file to make sure it closed
        FileClose(2)
        'Opening the fie to show all the customer in a listbox
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        MsgBox("Number of Records = " & noOfRecords)
        'Looping through each record and showing it in the listbox until there are no more in the file
        For index = 1 To noOfRecords
            FileGet(2, oneRepair)
            lstShowRepairs.Items.Add(String.Format(myFormat, oneRepair.RepairNo, oneRepair.RepairName, oneRepair.RepairPrice))
        Next index
        'closing the file at the end
        FileClose(2)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'This is a search funtion
        'It opens the file, then it stores what ever the user has typed into the searchbox in to the finder variable
        'Then a do loop until is running, it goes thorugh each recorduntil it has fnd it or if it has reached the end of the file
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        Dim finder As String
        Dim Found As Boolean
        finder = txtSearchRepair.Text
        Do
            FileGet(2, oneRepair)
            PositionOfRecord = PositionOfRecord + 1
            If finder = Trim(oneRepair.RepairName) Then
                Found = True
            End If
        Loop Until EOF(2) Or Found = True
        'If it has found the record, then it pulls all of the data and puts it in the textboxes
        Dim Position1 As Integer
        txtRepairNO.Text = oneRepair.RepairNo
        txtRepairName.Text = oneRepair.RepairName
        txtRepairPrice.Text = oneRepair.RepairPrice
        'Then the file closes
        FileClose(2)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'This updates the record in the file with new information
        oneRepair.RepairName = txtRepairName.Text
        oneRepair.RepairNo = txtRepairNO.Text
        oneRepair.RepairPrice = txtRepairPrice.Text
        'This opens the file
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        'This stores anything that is enterd in the textboxes in the same location where the record was
        FilePut(2, oneRepair, PositionOfRecord)
        'The file closes again
        FileClose(2)
        'when the button s clicked, then the text boxes clear
        txtRepairName.Clear()
        txtRepairNO.Clear()
        txtRepairPrice.Clear()
        txtSearchRepair.Clear()
        MsgBox("Record Saved")
        noOfRecords = noOfRecords + 1
    End Sub
    Private Sub lstShowRepairs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShowRepairs.SelectedIndexChanged

    End Sub
End Class