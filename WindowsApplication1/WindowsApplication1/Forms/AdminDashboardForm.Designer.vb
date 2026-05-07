<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardForm
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
        Me.lblAdminDash = New System.Windows.Forms.Label()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.ProductsButton = New System.Windows.Forms.Button()
        Me.UsersButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdminDash
        '
        Me.lblAdminDash.AutoSize = True
        Me.lblAdminDash.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminDash.Location = New System.Drawing.Point(42, 37)
        Me.lblAdminDash.Name = "lblAdminDash"
        Me.lblAdminDash.Size = New System.Drawing.Size(208, 29)
        Me.lblAdminDash.TabIndex = 1
        Me.lblAdminDash.Text = "Admin Dashboard"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Font = New System.Drawing.Font("JetBrains Mono NL", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.Location = New System.Drawing.Point(40, 76)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(133, 14)
        Me.lblLog.TabIndex = 2
        Me.lblLog.Text = "Logged in as Admin"
        '
        'ProductsButton
        '
        Me.ProductsButton.Font = New System.Drawing.Font("JetBrains Mono NL", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsButton.Location = New System.Drawing.Point(45, 98)
        Me.ProductsButton.Name = "ProductsButton"
        Me.ProductsButton.Size = New System.Drawing.Size(203, 30)
        Me.ProductsButton.TabIndex = 3
        Me.ProductsButton.Text = "Manage Products"
        Me.ProductsButton.UseVisualStyleBackColor = True
        '
        'UsersButton
        '
        Me.UsersButton.Font = New System.Drawing.Font("JetBrains Mono NL", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersButton.Location = New System.Drawing.Point(45, 144)
        Me.UsersButton.Name = "UsersButton"
        Me.UsersButton.Size = New System.Drawing.Size(203, 30)
        Me.UsersButton.TabIndex = 4
        Me.UsersButton.Text = "Manage Users"
        Me.UsersButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("JetBrains Mono NL", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(173, 204)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 30)
        Me.LogoutButton.TabIndex = 6
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'AdminDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.UsersButton)
        Me.Controls.Add(Me.ProductsButton)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblAdminDash)
        Me.Name = "AdminDashboardForm"
        Me.Text = "Admin Dashboard Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdminDash As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents ProductsButton As Button
    Friend WithEvents UsersButton As Button
    Friend WithEvents LogoutButton As Button
End Class
