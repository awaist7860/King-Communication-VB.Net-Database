Public Class Repair_Menu_Fom

    Private Sub Repair_Menu_Fom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
        Dim NameofFile As String
        NameofFile = "RepairDetails.dat"
        FileOpen(2, NameofFile, OpenMode.Random, , , Len(oneRepair))
        noOfRecords = LOF(2) / Len(oneRepair)
        FileClose(2)
    End Sub

    Private Sub btnAddRepair_Click(sender As Object, e As EventArgs) Handles btnAddRepair.Click
        Add_a_repair_form.Show()

    End Sub

    Private Sub btnShowOrChange_Click(sender As Object, e As EventArgs) Handles btnShowOrChange.Click
        Display_Or_Ammened_A_Repair_form.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Welcome_Form.Close()


    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class