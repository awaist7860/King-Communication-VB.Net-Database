Public Class Add_a_repair_form
    Public NameOfFile As String
    Dim myFormat As String = "{0, -3}{1,-12}{2,-8}"
    Dim oneRepair As RepairType



    Private Sub Add_a_repair_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Repair_Menu_Fom.Close()
        Form2.Close()
        NameOfFile = "RepairDetails.dat"
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        noOfRecords = LOF(2) / Len(oneRepair)
        Label5.Text = noOfRecords
        FileClose(2)
    End Sub

    Private Sub txtRepairID_TextChanged(sender As Object, e As EventArgs) Handles txtRepairNo.TextChanged

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnAddRepair_Click(sender As Object, e As EventArgs) Handles btnAddRepair.Click
        oneRepair.RepairNo = txtRepairNo.Text
        oneRepair.RepairName = txtRepairName.Text
        oneRepair.RepairPrice = txtRepairPrice.Text
        FileOpen(2, NameOfFile, OpenMode.Random, , , Len(oneRepair))
        FilePut(2, oneRepair, noOfRecords + 1)
        FileClose(2)
        txtRepairName.Clear()
        txtRepairNo.Clear()
        txtRepairPrice.Clear()

        MsgBox("Record Saved")
        noOfRecords = noOfRecords + 1
        Label5.Text = noOfRecords
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Welcome_Form.Close()
    End Sub
End Class