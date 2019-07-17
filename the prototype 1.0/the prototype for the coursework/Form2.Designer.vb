<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnRepairs = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu"
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(12, 44)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(150, 50)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnRepairs
        '
        Me.btnRepairs.Location = New System.Drawing.Point(12, 100)
        Me.btnRepairs.Name = "btnRepairs"
        Me.btnRepairs.Size = New System.Drawing.Size(150, 50)
        Me.btnRepairs.TabIndex = 2
        Me.btnRepairs.Text = "Repairs"
        Me.btnRepairs.UseVisualStyleBackColor = True
        '
        'btnInvoice
        '
        Me.btnInvoice.Location = New System.Drawing.Point(12, 156)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(150, 50)
        Me.btnInvoice.TabIndex = 3
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 222)
        Me.Controls.Add(Me.btnInvoice)
        Me.Controls.Add(Me.btnRepairs)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents btnRepairs As System.Windows.Forms.Button
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
End Class
