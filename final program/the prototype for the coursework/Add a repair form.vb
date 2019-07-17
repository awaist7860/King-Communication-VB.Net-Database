Public Class Add_a_repair_form
    'Setting the global variables to be used in the form
    Public NameOfFile As String
    Dim myFormat As String = "{0, -3}{1,-12}{2,-8}"
    Dim oneRepair As RepairType
    Private Sub Add_a_repair_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads, it will close the repair menu
        Repair_Menu_Fom.Close()
        'When the form loads, it will close the main menu
        Form2.Close()
        'this will add a repair to the repair details file
        NameOfFile = "RepairDetails.dat"
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        noOfRecords = LOF(2) / Len(oneRepair)
        lblNoOfRecords.Text = noOfRecords
        FileClose(2)
    End Sub
    Private Sub txtRepairID_TextChanged(sender As Object, e As EventArgs) Handles txtRepairNo.TextChanged

    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'This will open the main menu
        Form2.Show()
        'this will close this form
        Me.Close()
    End Sub
    Private Sub btnAddRepair_Click(sender As Object, e As EventArgs) Handles btnAddRepair.Click
        'Validation rule on the customer No using a hashing algorithm
        'This get the first 3 charecters of a name, does some calculations assigns number to them, and does calulations on them
        'Copied from the customer form
        Dim i As Short
        Dim charFirstName() As Char = txtRepairName.Text.ToCharArray
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
        'This is where all the data in the textboxes gets put into the variables decalred in the module in the repairType structure
        oneRepair.RepairNo = AscW(charFirstName(0)) + AscW(charFirstName(1)) * 2 + AscW(charFirstName(2)) * 3 + (noOfRecords + 1) * 100
        oneRepair.RepairName = txtRepairName.Text
        oneRepair.RepairPrice = txtRepairPrice.Text
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        FilePut(2, oneRepair, noOfRecords + 1)
        'the file closes
        FileClose(2)
        'Once the data is saved and the file is closed, the text boxes are cleared
        txtRepairName.Clear()
        txtRepairNo.Clear()
        txtRepairPrice.Clear()
        MsgBox("Record Saved")
        noOfRecords = noOfRecords + 1
        'This shows how many records are in the file
        lblNoOfRecords.Text = noOfRecords
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblNoOfRecords.Click

    End Sub
End Class