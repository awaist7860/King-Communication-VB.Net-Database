<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_or_Ammend_Customer
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
        Me.lstShowsTheCustomers = New System.Windows.Forms.ListBox()
        Me.btnDisplayTheCustomers = New System.Windows.Forms.Button()
        Me.btnMainMenuShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShowsTheCustomers
        '
        Me.lstShowsTheCustomers.FormattingEnabled = True
        Me.lstShowsTheCustomers.Location = New System.Drawing.Point(13, 13)
        Me.lstShowsTheCustomers.Name = "lstShowsTheCustomers"
        Me.lstShowsTheCustomers.Size = New System.Drawing.Size(1059, 225)
        Me.lstShowsTheCustomers.TabIndex = 0
        '
        'btnDisplayTheCustomers
        '
        Me.btnDisplayTheCustomers.Location = New System.Drawing.Point(13, 244)
        Me.btnDisplayTheCustomers.Name = "btnDisplayTheCustomers"
        Me.btnDisplayTheCustomers.Size = New System.Drawing.Size(114, 48)
        Me.btnDisplayTheCustomers.TabIndex = 1
        Me.btnDisplayTheCustomers.Text = "Display Customers"
        Me.btnDisplayTheCustomers.UseVisualStyleBackColor = True
        '
        'btnMainMenuShow
        '
        Me.btnMainMenuShow.Location = New System.Drawing.Point(966, 244)
        Me.btnMainMenuShow.Name = "btnMainMenuShow"
        Me.btnMainMenuShow.Size = New System.Drawing.Size(106, 48)
        Me.btnMainMenuShow.TabIndex = 2
        Me.btnMainMenuShow.Text = "Main Menu"
        Me.btnMainMenuShow.UseVisualStyleBackColor = True
        '
        'Show_or_Ammend_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 301)
        Me.Controls.Add(Me.btnMainMenuShow)
        Me.Controls.Add(Me.btnDisplayTheCustomers)
        Me.Controls.Add(Me.lstShowsTheCustomers)
        Me.Name = "Show_or_Ammend_Customer"
        Me.Text = "Show_or_Ammend_Customer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstShowsTheCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplayTheCustomers As System.Windows.Forms.Button
    Friend WithEvents btnMainMenuShow As System.Windows.Forms.Button
End Class
