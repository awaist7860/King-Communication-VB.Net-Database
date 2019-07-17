<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_a_repair_form
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
        Me.lblRepairNo = New System.Windows.Forms.Label()
        Me.lblRepairName = New System.Windows.Forms.Label()
        Me.lblRepairPrice = New System.Windows.Forms.Label()
        Me.txtRepairNo = New System.Windows.Forms.TextBox()
        Me.txtRepairName = New System.Windows.Forms.TextBox()
        Me.txtRepairPrice = New System.Windows.Forms.TextBox()
        Me.lblAddARepairLogo = New System.Windows.Forms.Label()
        Me.btnAddRepair = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblNoOfRecords = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRepairNo
        '
        Me.lblRepairNo.AutoSize = True
        Me.lblRepairNo.Location = New System.Drawing.Point(12, 61)
        Me.lblRepairNo.Name = "lblRepairNo"
        Me.lblRepairNo.Size = New System.Drawing.Size(55, 13)
        Me.lblRepairNo.TabIndex = 0
        Me.lblRepairNo.Text = "Repair No"
        '
        'lblRepairName
        '
        Me.lblRepairName.AutoSize = True
        Me.lblRepairName.Location = New System.Drawing.Point(12, 112)
        Me.lblRepairName.Name = "lblRepairName"
        Me.lblRepairName.Size = New System.Drawing.Size(69, 13)
        Me.lblRepairName.TabIndex = 1
        Me.lblRepairName.Text = "Repair Name"
        '
        'lblRepairPrice
        '
        Me.lblRepairPrice.AutoSize = True
        Me.lblRepairPrice.Location = New System.Drawing.Point(11, 164)
        Me.lblRepairPrice.Name = "lblRepairPrice"
        Me.lblRepairPrice.Size = New System.Drawing.Size(65, 13)
        Me.lblRepairPrice.TabIndex = 2
        Me.lblRepairPrice.Text = "Repair Price"
        '
        'txtRepairNo
        '
        Me.txtRepairNo.Location = New System.Drawing.Point(87, 54)
        Me.txtRepairNo.Name = "txtRepairNo"
        Me.txtRepairNo.ReadOnly = True
        Me.txtRepairNo.Size = New System.Drawing.Size(181, 20)
        Me.txtRepairNo.TabIndex = 3
        '
        'txtRepairName
        '
        Me.txtRepairName.Location = New System.Drawing.Point(87, 105)
        Me.txtRepairName.Name = "txtRepairName"
        Me.txtRepairName.Size = New System.Drawing.Size(181, 20)
        Me.txtRepairName.TabIndex = 4
        '
        'txtRepairPrice
        '
        Me.txtRepairPrice.Location = New System.Drawing.Point(87, 157)
        Me.txtRepairPrice.Name = "txtRepairPrice"
        Me.txtRepairPrice.Size = New System.Drawing.Size(181, 20)
        Me.txtRepairPrice.TabIndex = 5
        '
        'lblAddARepairLogo
        '
        Me.lblAddARepairLogo.AutoSize = True
        Me.lblAddARepairLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddARepairLogo.Location = New System.Drawing.Point(51, 9)
        Me.lblAddARepairLogo.Name = "lblAddARepairLogo"
        Me.lblAddARepairLogo.Size = New System.Drawing.Size(125, 25)
        Me.lblAddARepairLogo.TabIndex = 6
        Me.lblAddARepairLogo.Text = "Add a Repair"
        '
        'btnAddRepair
        '
        Me.btnAddRepair.Location = New System.Drawing.Point(274, 157)
        Me.btnAddRepair.Name = "btnAddRepair"
        Me.btnAddRepair.Size = New System.Drawing.Size(96, 23)
        Me.btnAddRepair.TabIndex = 7
        Me.btnAddRepair.Text = "Add Repair"
        Me.btnAddRepair.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(274, 54)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(96, 23)
        Me.btnMainMenu.TabIndex = 8
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblNoOfRecords
        '
        Me.lblNoOfRecords.AutoSize = True
        Me.lblNoOfRecords.Location = New System.Drawing.Point(274, 108)
        Me.lblNoOfRecords.Name = "lblNoOfRecords"
        Me.lblNoOfRecords.Size = New System.Drawing.Size(39, 13)
        Me.lblNoOfRecords.TabIndex = 9
        Me.lblNoOfRecords.Text = "Label5"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(295, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Add_a_repair_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 205)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblNoOfRecords)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnAddRepair)
        Me.Controls.Add(Me.lblAddARepairLogo)
        Me.Controls.Add(Me.txtRepairPrice)
        Me.Controls.Add(Me.txtRepairName)
        Me.Controls.Add(Me.txtRepairNo)
        Me.Controls.Add(Me.lblRepairPrice)
        Me.Controls.Add(Me.lblRepairName)
        Me.Controls.Add(Me.lblRepairNo)
        Me.Name = "Add_a_repair_form"
        Me.Text = "Add_a_repair_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRepairNo As System.Windows.Forms.Label
    Friend WithEvents lblRepairName As System.Windows.Forms.Label
    Friend WithEvents lblRepairPrice As System.Windows.Forms.Label
    Friend WithEvents txtRepairNo As System.Windows.Forms.TextBox
    Friend WithEvents txtRepairName As System.Windows.Forms.TextBox
    Friend WithEvents txtRepairPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblAddARepairLogo As System.Windows.Forms.Label
    Friend WithEvents btnAddRepair As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblNoOfRecords As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
