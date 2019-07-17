<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers_Menu
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
        Me.btnAddCustomerForm = New System.Windows.Forms.Button()
        Me.btnShowCustomerForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddCustomerForm
        '
        Me.btnAddCustomerForm.Location = New System.Drawing.Point(50, 37)
        Me.btnAddCustomerForm.Name = "btnAddCustomerForm"
        Me.btnAddCustomerForm.Size = New System.Drawing.Size(86, 62)
        Me.btnAddCustomerForm.TabIndex = 0
        Me.btnAddCustomerForm.Text = "Add  A Customer"
        Me.btnAddCustomerForm.UseVisualStyleBackColor = True
        '
        'btnShowCustomerForm
        '
        Me.btnShowCustomerForm.Location = New System.Drawing.Point(50, 105)
        Me.btnShowCustomerForm.Name = "btnShowCustomerForm"
        Me.btnShowCustomerForm.Size = New System.Drawing.Size(86, 58)
        Me.btnShowCustomerForm.TabIndex = 1
        Me.btnShowCustomerForm.Text = "View A customer"
        Me.btnShowCustomerForm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customers Menu"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(50, 232)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 57)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(50, 169)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(86, 57)
        Me.btnMainMenu.TabIndex = 4
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Customers_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 297)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShowCustomerForm)
        Me.Controls.Add(Me.btnAddCustomerForm)
        Me.Name = "Customers_Menu"
        Me.Text = "Customers_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddCustomerForm As System.Windows.Forms.Button
    Friend WithEvents btnShowCustomerForm As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
