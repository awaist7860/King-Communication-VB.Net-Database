<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblInvoiceLogo = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstRepairDetails = New System.Windows.Forms.ListBox()
        Me.lstCustomerDetails = New System.Windows.Forms.ListBox()
        Me.txtCustNo = New System.Windows.Forms.TextBox()
        Me.lblCustNo = New System.Windows.Forms.Label()
        Me.lblCustFor = New System.Windows.Forms.Label()
        Me.txtCustFor = New System.Windows.Forms.TextBox()
        Me.txtCustSur = New System.Windows.Forms.TextBox()
        Me.lblCustSur = New System.Windows.Forms.Label()
        Me.txtRepPrice = New System.Windows.Forms.TextBox()
        Me.lblRepPrice = New System.Windows.Forms.Label()
        Me.txtRepName = New System.Windows.Forms.TextBox()
        Me.lblRepName = New System.Windows.Forms.Label()
        Me.lblRepNo = New System.Windows.Forms.Label()
        Me.txtRepNo = New System.Windows.Forms.TextBox()
        Me.btnShowCustomer = New System.Windows.Forms.Button()
        Me.btnShowRepair = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lblRepairs = New System.Windows.Forms.Label()
        Me.lblNumberOfRecords = New System.Windows.Forms.Label()
        Me.lstViewOrders = New System.Windows.Forms.ListBox()
        Me.btnViewOrders = New System.Windows.Forms.Button()
        Me.lblTextForNoOfRecords = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(450, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 60)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblInvoiceLogo
        '
        Me.lblInvoiceLogo.AutoSize = True
        Me.lblInvoiceLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceLogo.Location = New System.Drawing.Point(244, 12)
        Me.lblInvoiceLogo.Name = "lblInvoiceLogo"
        Me.lblInvoiceLogo.Size = New System.Drawing.Size(108, 31)
        Me.lblInvoiceLogo.TabIndex = 1
        Me.lblInvoiceLogo.Text = "Invoice"
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(431, 176)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(129, 61)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(296, 176)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 61)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save Order"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstRepairDetails
        '
        Me.lstRepairDetails.FormattingEnabled = True
        Me.lstRepairDetails.Location = New System.Drawing.Point(293, 88)
        Me.lstRepairDetails.Name = "lstRepairDetails"
        Me.lstRepairDetails.Size = New System.Drawing.Size(264, 82)
        Me.lstRepairDetails.TabIndex = 5
        '
        'lstCustomerDetails
        '
        Me.lstCustomerDetails.FormattingEnabled = True
        Me.lstCustomerDetails.Location = New System.Drawing.Point(12, 88)
        Me.lstCustomerDetails.Name = "lstCustomerDetails"
        Me.lstCustomerDetails.Size = New System.Drawing.Size(264, 82)
        Me.lstCustomerDetails.TabIndex = 4
        '
        'txtCustNo
        '
        Me.txtCustNo.Location = New System.Drawing.Point(119, 252)
        Me.txtCustNo.Name = "txtCustNo"
        Me.txtCustNo.ReadOnly = True
        Me.txtCustNo.Size = New System.Drawing.Size(157, 20)
        Me.txtCustNo.TabIndex = 6
        '
        'lblCustNo
        '
        Me.lblCustNo.AutoSize = True
        Me.lblCustNo.Location = New System.Drawing.Point(12, 252)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.Size = New System.Drawing.Size(68, 13)
        Me.lblCustNo.TabIndex = 7
        Me.lblCustNo.Text = "Customer No"
        '
        'lblCustFor
        '
        Me.lblCustFor.AutoSize = True
        Me.lblCustFor.Location = New System.Drawing.Point(12, 299)
        Me.lblCustFor.Name = "lblCustFor"
        Me.lblCustFor.Size = New System.Drawing.Size(101, 13)
        Me.lblCustFor.TabIndex = 8
        Me.lblCustFor.Text = "Customer Forename"
        '
        'txtCustFor
        '
        Me.txtCustFor.Location = New System.Drawing.Point(119, 292)
        Me.txtCustFor.Name = "txtCustFor"
        Me.txtCustFor.ReadOnly = True
        Me.txtCustFor.Size = New System.Drawing.Size(157, 20)
        Me.txtCustFor.TabIndex = 10
        '
        'txtCustSur
        '
        Me.txtCustSur.Location = New System.Drawing.Point(119, 332)
        Me.txtCustSur.Name = "txtCustSur"
        Me.txtCustSur.ReadOnly = True
        Me.txtCustSur.Size = New System.Drawing.Size(157, 20)
        Me.txtCustSur.TabIndex = 14
        '
        'lblCustSur
        '
        Me.lblCustSur.AutoSize = True
        Me.lblCustSur.Location = New System.Drawing.Point(12, 339)
        Me.lblCustSur.Name = "lblCustSur"
        Me.lblCustSur.Size = New System.Drawing.Size(96, 13)
        Me.lblCustSur.TabIndex = 13
        Me.lblCustSur.Text = "Customer Surname"
        '
        'txtRepPrice
        '
        Me.txtRepPrice.Location = New System.Drawing.Point(400, 332)
        Me.txtRepPrice.Name = "txtRepPrice"
        Me.txtRepPrice.ReadOnly = True
        Me.txtRepPrice.Size = New System.Drawing.Size(157, 20)
        Me.txtRepPrice.TabIndex = 20
        '
        'lblRepPrice
        '
        Me.lblRepPrice.AutoSize = True
        Me.lblRepPrice.Location = New System.Drawing.Point(293, 339)
        Me.lblRepPrice.Name = "lblRepPrice"
        Me.lblRepPrice.Size = New System.Drawing.Size(65, 13)
        Me.lblRepPrice.TabIndex = 19
        Me.lblRepPrice.Text = "Repair Price"
        '
        'txtRepName
        '
        Me.txtRepName.Location = New System.Drawing.Point(400, 292)
        Me.txtRepName.Name = "txtRepName"
        Me.txtRepName.ReadOnly = True
        Me.txtRepName.Size = New System.Drawing.Size(157, 20)
        Me.txtRepName.TabIndex = 18
        '
        'lblRepName
        '
        Me.lblRepName.AutoSize = True
        Me.lblRepName.Location = New System.Drawing.Point(293, 299)
        Me.lblRepName.Name = "lblRepName"
        Me.lblRepName.Size = New System.Drawing.Size(69, 13)
        Me.lblRepName.TabIndex = 17
        Me.lblRepName.Text = "Repair Name"
        '
        'lblRepNo
        '
        Me.lblRepNo.AutoSize = True
        Me.lblRepNo.Location = New System.Drawing.Point(293, 252)
        Me.lblRepNo.Name = "lblRepNo"
        Me.lblRepNo.Size = New System.Drawing.Size(55, 13)
        Me.lblRepNo.TabIndex = 16
        Me.lblRepNo.Text = "Repair No"
        '
        'txtRepNo
        '
        Me.txtRepNo.Location = New System.Drawing.Point(400, 252)
        Me.txtRepNo.Name = "txtRepNo"
        Me.txtRepNo.ReadOnly = True
        Me.txtRepNo.Size = New System.Drawing.Size(157, 20)
        Me.txtRepNo.TabIndex = 15
        '
        'btnShowCustomer
        '
        Me.btnShowCustomer.Location = New System.Drawing.Point(12, 176)
        Me.btnShowCustomer.Name = "btnShowCustomer"
        Me.btnShowCustomer.Size = New System.Drawing.Size(129, 61)
        Me.btnShowCustomer.TabIndex = 21
        Me.btnShowCustomer.Text = "Show Customers"
        Me.btnShowCustomer.UseVisualStyleBackColor = True
        '
        'btnShowRepair
        '
        Me.btnShowRepair.Location = New System.Drawing.Point(147, 176)
        Me.btnShowRepair.Name = "btnShowRepair"
        Me.btnShowRepair.Size = New System.Drawing.Size(129, 61)
        Me.btnShowRepair.TabIndex = 22
        Me.btnShowRepair.Text = "Show Repairs"
        Me.btnShowRepair.UseVisualStyleBackColor = True
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(15, 52)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(95, 20)
        Me.lblCustomers.TabIndex = 23
        Me.lblCustomers.Text = "Customers"
        '
        'lblRepairs
        '
        Me.lblRepairs.AutoSize = True
        Me.lblRepairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepairs.Location = New System.Drawing.Point(289, 52)
        Me.lblRepairs.Name = "lblRepairs"
        Me.lblRepairs.Size = New System.Drawing.Size(71, 20)
        Me.lblRepairs.TabIndex = 24
        Me.lblRepairs.Text = "Repairs"
        '
        'lblNumberOfRecords
        '
        Me.lblNumberOfRecords.AutoSize = True
        Me.lblNumberOfRecords.Location = New System.Drawing.Point(102, 12)
        Me.lblNumberOfRecords.Name = "lblNumberOfRecords"
        Me.lblNumberOfRecords.Size = New System.Drawing.Size(39, 13)
        Me.lblNumberOfRecords.TabIndex = 26
        Me.lblNumberOfRecords.Text = "Label7"
        '
        'lstViewOrders
        '
        Me.lstViewOrders.FormattingEnabled = True
        Me.lstViewOrders.Location = New System.Drawing.Point(12, 371)
        Me.lstViewOrders.Name = "lstViewOrders"
        Me.lstViewOrders.Size = New System.Drawing.Size(387, 82)
        Me.lstViewOrders.TabIndex = 27
        '
        'btnViewOrders
        '
        Me.btnViewOrders.Location = New System.Drawing.Point(428, 382)
        Me.btnViewOrders.Name = "btnViewOrders"
        Me.btnViewOrders.Size = New System.Drawing.Size(129, 61)
        Me.btnViewOrders.TabIndex = 28
        Me.btnViewOrders.Text = "View Orders"
        Me.btnViewOrders.UseVisualStyleBackColor = True
        '
        'lblTextForNoOfRecords
        '
        Me.lblTextForNoOfRecords.AutoSize = True
        Me.lblTextForNoOfRecords.Location = New System.Drawing.Point(12, 12)
        Me.lblTextForNoOfRecords.Name = "lblTextForNoOfRecords"
        Me.lblTextForNoOfRecords.Size = New System.Drawing.Size(81, 13)
        Me.lblTextForNoOfRecords.TabIndex = 25
        Me.lblTextForNoOfRecords.Text = "No. Of Records"
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 468)
        Me.Controls.Add(Me.btnViewOrders)
        Me.Controls.Add(Me.lstViewOrders)
        Me.Controls.Add(Me.lblNumberOfRecords)
        Me.Controls.Add(Me.lblTextForNoOfRecords)
        Me.Controls.Add(Me.lblRepairs)
        Me.Controls.Add(Me.lblCustomers)
        Me.Controls.Add(Me.btnShowRepair)
        Me.Controls.Add(Me.btnShowCustomer)
        Me.Controls.Add(Me.txtRepPrice)
        Me.Controls.Add(Me.lblRepPrice)
        Me.Controls.Add(Me.txtRepName)
        Me.Controls.Add(Me.lblRepName)
        Me.Controls.Add(Me.lblRepNo)
        Me.Controls.Add(Me.txtRepNo)
        Me.Controls.Add(Me.txtCustSur)
        Me.Controls.Add(Me.lblCustSur)
        Me.Controls.Add(Me.txtCustFor)
        Me.Controls.Add(Me.lblCustFor)
        Me.Controls.Add(Me.lblCustNo)
        Me.Controls.Add(Me.txtCustNo)
        Me.Controls.Add(Me.lstRepairDetails)
        Me.Controls.Add(Me.lstCustomerDetails)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.lblInvoiceLogo)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceLogo As System.Windows.Forms.Label
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lstRepairDetails As System.Windows.Forms.ListBox
    Friend WithEvents lstCustomerDetails As System.Windows.Forms.ListBox
    Friend WithEvents txtCustNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCustNo As System.Windows.Forms.Label
    Friend WithEvents lblCustFor As System.Windows.Forms.Label
    Friend WithEvents txtCustFor As System.Windows.Forms.TextBox
    Friend WithEvents txtCustSur As System.Windows.Forms.TextBox
    Friend WithEvents lblCustSur As System.Windows.Forms.Label
    Friend WithEvents txtRepPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblRepPrice As System.Windows.Forms.Label
    Friend WithEvents txtRepName As System.Windows.Forms.TextBox
    Friend WithEvents lblRepName As System.Windows.Forms.Label
    Friend WithEvents lblRepNo As System.Windows.Forms.Label
    Friend WithEvents txtRepNo As System.Windows.Forms.TextBox
    Friend WithEvents btnShowCustomer As System.Windows.Forms.Button
    Friend WithEvents btnShowRepair As System.Windows.Forms.Button
    Friend WithEvents lblCustomers As System.Windows.Forms.Label
    Friend WithEvents lblRepairs As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfRecords As System.Windows.Forms.Label
    Friend WithEvents lstViewOrders As System.Windows.Forms.ListBox
    Friend WithEvents btnViewOrders As System.Windows.Forms.Button
    Friend WithEvents lblTextForNoOfRecords As System.Windows.Forms.Label
End Class
