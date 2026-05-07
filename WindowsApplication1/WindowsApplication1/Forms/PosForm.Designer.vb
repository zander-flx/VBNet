<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PosForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCashPOS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ScanTextBox = New System.Windows.Forms.TextBox()
        Me.CartGrid = New System.Windows.Forms.DataGridView()
        Me.RemoveButon = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCashPOS
        '
        Me.lblCashPOS.AutoSize = True
        Me.lblCashPOS.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashPOS.Location = New System.Drawing.Point(11, 14)
        Me.lblCashPOS.Name = "lblCashPOS"
        Me.lblCashPOS.Size = New System.Drawing.Size(96, 18)
        Me.lblCashPOS.TabIndex = 0
        Me.lblCashPOS.Text = "Cashier POS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("JetBrains Mono NL", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Logged in as Cashier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("JetBrains Mono NL", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scan/Type Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("JetBrains Mono NL", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Example: "
        '
        'ScanTextBox
        '
        Me.ScanTextBox.Location = New System.Drawing.Point(14, 108)
        Me.ScanTextBox.Name = "ScanTextBox"
        Me.ScanTextBox.Size = New System.Drawing.Size(629, 22)
        Me.ScanTextBox.TabIndex = 4
        '
        'CartGrid
        '
        Me.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartGrid.Location = New System.Drawing.Point(14, 145)
        Me.CartGrid.Name = "CartGrid"
        Me.CartGrid.Size = New System.Drawing.Size(629, 183)
        Me.CartGrid.TabIndex = 5
        '
        'RemoveButon
        '
        Me.RemoveButon.Location = New System.Drawing.Point(14, 350)
        Me.RemoveButon.Name = "RemoveButon"
        Me.RemoveButon.Size = New System.Drawing.Size(106, 30)
        Me.RemoveButon.TabIndex = 6
        Me.RemoveButon.Text = "Remove Item"
        Me.RemoveButon.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(126, 350)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(106, 30)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear Cart"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(537, 350)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(106, 30)
        Me.LogoutButton.TabIndex = 8
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(425, 350)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(106, 30)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "Save Sale"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("JetBrains Mono NL", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("JetBrains Mono NL", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(336, 356)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(40, 18)
        Me.TotalLabel.TabIndex = 11
        Me.TotalLabel.Text = "0.00"
        '
        'PosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 401)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButon)
        Me.Controls.Add(Me.CartGrid)
        Me.Controls.Add(Me.ScanTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCashPOS)
        Me.Font = New System.Drawing.Font("JetBrains Mono NL", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PosForm"
        Me.Text = "Pos Form"
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCashPOS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ScanTextBox As TextBox
    Friend WithEvents CartGrid As DataGridView
    Friend WithEvents RemoveButon As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalLabel As Label
End Class
