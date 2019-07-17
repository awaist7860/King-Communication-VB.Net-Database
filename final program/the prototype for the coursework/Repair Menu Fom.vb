Public Class Repair_Menu_Fom
    Private Sub Repair_Menu_Fom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the forms is loading the main menu closes
        Form2.Close()
        'When the form is loading, the Repair Details file is opened asnd closed aswell
        Dim NameofFile As String
        NameofFile = "RepairDetails.dat"
        FileOpen(2, NameofFile, OpenMode.Random, , , Len(oneRepair))
        noOfRecords = LOF(2) / Len(oneRepair)
        FileClose(2)
    End Sub
    Private Sub btnAddRepair_Click(sender As Object, e As EventArgs) Handles btnAddRepair.Click
        'When this button is cliked then the add repair form opens
        Add_a_repair_form.Show()
    End Sub
    Private Sub btnShowOrChange_Click(sender As Object, e As EventArgs) Handles btnDisplayOrAmendARepair.Click
        'When this button is clicked, then the display or ammenned a repair form opens
        Display_Or_Ammened_A_Repair_form.Show()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'when this button is clicked, then it closes the main form and then the whole applications quits
        Welcome_Form.Close()
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'When the button is clicked then this form is closed and the main menu is shown
        Form2.Show()
        Me.Close()
    End Sub
End Class