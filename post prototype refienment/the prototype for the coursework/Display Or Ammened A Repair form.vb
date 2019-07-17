Public Class Display_Or_Ammened_A_Repair_form
    Public NameOfFile As String
    Dim myFormat As String = "{0, -3}{1,-12}{2,-8}"
    Dim PositionOfRecord As Integer


    Private Sub Display_Or_Ammened_A_Repair_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Repair_Menu_Fom.Close()
        Form2.Close()

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub btnShowRepairs_Click(sender As Object, e As EventArgs) Handles btnShowRepairs.Click
        Dim index As Integer
        NameOfFile = "RepairDetails.dat"
        lstShowRepairs.Items.Clear()

        FileClose(2)

        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        MsgBox("Number of Records = " & noOfRecords)

        For index = 1 To noOfRecords
            FileGet(2, oneRepair)
            lstShowRepairs.Items.Add(String.Format(myFormat, oneRepair.RepairNo, oneRepair.RepairName, oneRepair.RepairPrice))

        Next index
        FileClose(2)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Welcome_Form.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub txtRepairNO_TextChanged(sender As Object, e As EventArgs) Handles txtRepairNO.TextChanged

    End Sub
End Class