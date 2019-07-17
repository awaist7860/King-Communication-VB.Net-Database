<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Or_Ammened_A_Repair_form
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
        Me.lstShowRepairs = New System.Windows.Forms.ListBox()
        Me.btnShowRepairs = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.txtSearchRepair = New System.Windows.Forms.TextBox()
        Me.txtRepairNO = New System.Windows.Forms.TextBox()
        Me.txtRepairName = New System.Windows.Forms.TextBox()
        Me.txtRepairPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDisplayARepair = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstShowRepairs
        '
        Me.lstShowRepairs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShowRepairs.FormattingEnabled = True
        Me.lstShowRepairs.ItemHeight = 14
        Me.lstShowRepairs.Location = New System.Drawing.Point(12, 49)
        Me.lstShowRepairs.Name = "lstShowRepairs"
        Me.lstShowRepairs.Size = New System.Drawing.Size(231, 116)
        Me.lstShowRepairs.TabIndex = 0
        '
        'btnShowRepairs
        '
        Me.btnShowRepairs.Location = New System.Drawing.Point(261, 209)
        Me.btnShowRepairs.Name = "btnShowRepairs"
        Me.btnShowRepairs.Size = New System.Drawing.Size(96, 74)
        Me.btnShowRepairs.TabIndex = 1
        Me.btnShowRepairs.Text = "Show Repairs"
        Me.btnShowRepairs.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(191, 178)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 68)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search For Repair Name"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(261, 129)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(96, 74)
        Me.btnMainMenu.TabIndex = 3
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'txtSearchRepair
        '
        Me.txtSearchRepair.Location = New System.Drawing.Point(12, 203)
        Me.txtSearchRepair.Name = "txtSearchRepair"
        Me.txtSearchRepair.Size = New System.Drawing.Size(173, 20)
        Me.txtSearchRepair.TabIndex = 4
        '
        'txtRepairNO
        '
        Me.txtRepairNO.Location = New System.Drawing.Point(102, 252)
        Me.txtRepairNO.Name = "txtRepairNO"
        Me.txtRepairNO.ReadOnly = True
        Me.txtRepairNO.Size = New System.Drawing.Size(153, 20)
        Me.txtRepairNO.TabIndex = 5
        '
        'txtRepairName
        '
        Me.txtRepairName.Location = New System.Drawing.Point(102, 302)
        Me.txtRepairName.Name = "txtRepairName"
        Me.txtRepairName.Size = New System.Drawing.Size(153, 20)
        Me.txtRepairName.TabIndex = 6
        '
        'txtRepairPrice
        '
        Me.txtRepairPrice.Location = New System.Drawing.Point(102, 349)
        Me.txtRepairPrice.Name = "txtRepairPrice"
        Me.txtRepairPrice.Size = New System.Drawing.Size(153, 20)
        Me.txtRepairPrice.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Repair NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Repair Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Repair Price"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(261, 289)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 74)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(261, 49)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 74)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDisplayARepair
        '
        Me.lblDisplayARepair.AutoSize = True
        Me.lblDisplayARepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayARepair.Location = New System.Drawing.Point(6, 9)
        Me.lblDisplayARepair.Name = "lblDisplayARepair"
        Me.lblDisplayARepair.Size = New System.Drawing.Size(213, 31)
        Me.lblDisplayARepair.TabIndex = 14
        Me.lblDisplayARepair.Text = "Display a Repair"
        '
        'Display_Or_Ammened_A_Repair_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 405)
        Me.Controls.Add(Me.lblDisplayARepair)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRepairPrice)
        Me.Controls.Add(Me.txtRepairName)
        Me.Controls.Add(Me.txtRepairNO)
        Me.Controls.Add(Me.txtSearchRepair)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnShowRepairs)
        Me.Controls.Add(Me.lstShowRepairs)
        Me.Name = "Display_Or_Ammened_A_Repair_form"
        Me.Text = "Display_Or_Ammened_A_Repair_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstShowRepairs As System.Windows.Forms.ListBox
    Friend WithEvents btnShowRepairs As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents txtSearchRepair As System.Windows.Forms.TextBox
    Friend WithEvents txtRepairNO As System.Windows.Forms.TextBox
    Friend WithEvents txtRepairName As System.Windows.Forms.TextBox
    Friend WithEvents txtRepairPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblDisplayARepair As System.Windows.Forms.Label
End Class
