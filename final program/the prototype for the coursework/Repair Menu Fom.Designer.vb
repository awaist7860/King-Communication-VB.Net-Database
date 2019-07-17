<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repair_Menu_Fom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRepairMenu = New System.Windows.Forms.Label()
        Me.btnDisplayOrAmendARepair = New System.Windows.Forms.Button()
        Me.btnAddRepair = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRepairMenu
        '
        Me.lblRepairMenu.AutoSize = True
        Me.lblRepairMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepairMenu.Location = New System.Drawing.Point(25, 21)
        Me.lblRepairMenu.Name = "lblRepairMenu"
        Me.lblRepairMenu.Size = New System.Drawing.Size(123, 25)
        Me.lblRepairMenu.TabIndex = 5
        Me.lblRepairMenu.Text = "Repair Menu"
        '
        'btnDisplayOrAmendARepair
        '
        Me.btnDisplayOrAmendARepair.Location = New System.Drawing.Point(28, 125)
        Me.btnDisplayOrAmendARepair.Name = "btnDisplayOrAmendARepair"
        Me.btnDisplayOrAmendARepair.Size = New System.Drawing.Size(120, 52)
        Me.btnDisplayOrAmendARepair.TabIndex = 4
        Me.btnDisplayOrAmendARepair.Text = "Display Or Amened A Repair"
        Me.btnDisplayOrAmendARepair.UseVisualStyleBackColor = True
        '
        'btnAddRepair
        '
        Me.btnAddRepair.Location = New System.Drawing.Point(28, 68)
        Me.btnAddRepair.Name = "btnAddRepair"
        Me.btnAddRepair.Size = New System.Drawing.Size(120, 51)
        Me.btnAddRepair.TabIndex = 3
        Me.btnAddRepair.Text = "Add A Repair"
        Me.btnAddRepair.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(28, 240)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 51)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(28, 183)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(116, 51)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Repair_Menu_Fom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(179, 303)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblRepairMenu)
        Me.Controls.Add(Me.btnDisplayOrAmendARepair)
        Me.Controls.Add(Me.btnAddRepair)
        Me.Name = "Repair_Menu_Fom"
        Me.Text = "Repair_Menu_Fom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRepairMenu As System.Windows.Forms.Label
    Friend WithEvents btnDisplayOrAmendARepair As System.Windows.Forms.Button
    Friend WithEvents btnAddRepair As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
