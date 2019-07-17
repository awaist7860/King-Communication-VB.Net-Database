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
        Me.SuspendLayout()
        '
        'btnAddCustomerForm
        '
        Me.btnAddCustomerForm.Location = New System.Drawing.Point(64, 52)
        Me.btnAddCustomerForm.Name = "btnAddCustomerForm"
        Me.btnAddCustomerForm.Size = New System.Drawing.Size(86, 62)
        Me.btnAddCustomerForm.TabIndex = 0
        Me.btnAddCustomerForm.Text = "Add  A Customer"
        Me.btnAddCustomerForm.UseVisualStyleBackColor = True
        '
        'btnShowCustomerForm
        '
        Me.btnShowCustomerForm.Location = New System.Drawing.Point(64, 145)
        Me.btnShowCustomerForm.Name = "btnShowCustomerForm"
        Me.btnShowCustomerForm.Size = New System.Drawing.Size(86, 58)
        Me.btnShowCustomerForm.TabIndex = 1
        Me.btnShowCustomerForm.Text = "View A customer"
        Me.btnShowCustomerForm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customers Menu"
        '
        'Customers_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 261)
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
End Class
