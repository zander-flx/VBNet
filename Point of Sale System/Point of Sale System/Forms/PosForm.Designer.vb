<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosForm
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.ScanLabel = New System.Windows.Forms.Label()
        Me.HintLabel = New System.Windows.Forms.Label()
        Me.ScanTextBox = New System.Windows.Forms.TextBox()
        Me.CartGrid = New System.Windows.Forms.DataGridView()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LineTotal = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(151, 26)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Cashier POS"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(14, 35)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(142, 17)
        Me.UserLabel.TabIndex = 1
        Me.UserLabel.Text = "Logged in as Cashier"
        '
        'ScanLabel
        '
        Me.ScanLabel.AutoSize = True
        Me.ScanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanLabel.Location = New System.Drawing.Point(14, 95)
        Me.ScanLabel.Name = "ScanLabel"
        Me.ScanLabel.Size = New System.Drawing.Size(133, 17)
        Me.ScanLabel.TabIndex = 2
        Me.ScanLabel.Text = "Scan/Type Barcode"
        '
        'HintLabel
        '
        Me.HintLabel.AutoSize = True
        Me.HintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HintLabel.Location = New System.Drawing.Point(285, 95)
        Me.HintLabel.Name = "HintLabel"
        Me.HintLabel.Size = New System.Drawing.Size(295, 17)
        Me.HintLabel.TabIndex = 3
        Me.HintLabel.Text = "Example: 480000000001 or 3*480000000001"
        '
        'ScanTextBox
        '
        Me.ScanTextBox.Location = New System.Drawing.Point(12, 115)
        Me.ScanTextBox.Name = "ScanTextBox"
        Me.ScanTextBox.Size = New System.Drawing.Size(776, 20)
        Me.ScanTextBox.TabIndex = 4
        '
        'CartGrid
        '
        Me.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartGrid.Location = New System.Drawing.Point(12, 141)
        Me.CartGrid.Name = "CartGrid"
        Me.CartGrid.Size = New System.Drawing.Size(776, 150)
        Me.CartGrid.TabIndex = 5
        '
        'RemoveButton
        '
        Me.RemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(13, 381)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(101, 34)
        Me.RemoveButton.TabIndex = 6
        Me.RemoveButton.Text = "Remove Item"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(135, 381)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(101, 34)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear Cart"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LineTotal
        '
        Me.LineTotal.AutoSize = True
        Me.LineTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineTotal.Location = New System.Drawing.Point(423, 383)
        Me.LineTotal.Name = "LineTotal"
        Me.LineTotal.Size = New System.Drawing.Size(124, 26)
        Me.LineTotal.TabIndex = 8
        Me.LineTotal.Text = "Total: 0.00"
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(683, 381)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(101, 34)
        Me.LogoutButton.TabIndex = 10
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(576, 381)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(101, 34)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save Sale"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(9, 425)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(199, 17)
        Me.StatusLabel.TabIndex = 12
        Me.StatusLabel.Text = "Staatus message appear here"
        '
        'PosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.LineTotal)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.CartGrid)
        Me.Controls.Add(Me.ScanTextBox)
        Me.Controls.Add(Me.HintLabel)
        Me.Controls.Add(Me.ScanLabel)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "PosForm"
        Me.Text = "POS Demo - Cashier"
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents ScanLabel As Label
    Friend WithEvents HintLabel As Label
    Friend WithEvents ScanTextBox As TextBox
    Friend WithEvents CartGrid As DataGridView
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents LineTotal As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents StatusLabel As Label
End Class
