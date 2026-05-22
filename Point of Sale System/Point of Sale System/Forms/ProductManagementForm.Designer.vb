<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductManagementForm
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
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ProductsGrid = New System.Windows.Forms.DataGridView()
        Me.ProductsDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.StockLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.StockInput = New System.Windows.Forms.NumericUpDown()
        Me.PriceInput = New System.Windows.Forms.NumericUpDown()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        CType(Me.ProductsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsDetailsGroupBox.SuspendLayout()
        CType(Me.StockInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(71, 10)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(229, 23)
        Me.SearchTextBox.TabIndex = 1
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(319, 6)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(70, 30)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(395, 6)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(70, 30)
        Me.RefreshButton.TabIndex = 3
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ProductsGrid
        '
        Me.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsGrid.Location = New System.Drawing.Point(15, 39)
        Me.ProductsGrid.Name = "ProductsGrid"
        Me.ProductsGrid.Size = New System.Drawing.Size(450, 399)
        Me.ProductsGrid.TabIndex = 4
        '
        'ProductsDetailsGroupBox
        '
        Me.ProductsDetailsGroupBox.Controls.Add(Me.SaveButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.DeleteButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.NewButton)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.StockLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.PriceLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.NameLabel)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.Label2)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.ActiveCheckBox)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.StockInput)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.PriceInput)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.NameTextBox)
        Me.ProductsDetailsGroupBox.Controls.Add(Me.BarcodeTextBox)
        Me.ProductsDetailsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsDetailsGroupBox.Location = New System.Drawing.Point(471, 39)
        Me.ProductsDetailsGroupBox.Name = "ProductsDetailsGroupBox"
        Me.ProductsDetailsGroupBox.Size = New System.Drawing.Size(317, 399)
        Me.ProductsDetailsGroupBox.TabIndex = 5
        Me.ProductsDetailsGroupBox.TabStop = False
        Me.ProductsDetailsGroupBox.Text = "Product Details"
        '
        'StockLabel
        '
        Me.StockLabel.AutoSize = True
        Me.StockLabel.Location = New System.Drawing.Point(6, 205)
        Me.StockLabel.Name = "StockLabel"
        Me.StockLabel.Size = New System.Drawing.Size(43, 17)
        Me.StockLabel.TabIndex = 8
        Me.StockLabel.Text = "Stock"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(6, 150)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(40, 17)
        Me.PriceLabel.TabIndex = 7
        Me.PriceLabel.Text = "Price"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 96)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Barcode"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(87, 257)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(65, 21)
        Me.ActiveCheckBox.TabIndex = 4
        Me.ActiveCheckBox.Text = "Active"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'StockInput
        '
        Me.StockInput.Location = New System.Drawing.Point(87, 203)
        Me.StockInput.Name = "StockInput"
        Me.StockInput.Size = New System.Drawing.Size(224, 23)
        Me.StockInput.TabIndex = 3
        '
        'PriceInput
        '
        Me.PriceInput.Location = New System.Drawing.Point(87, 148)
        Me.PriceInput.Name = "PriceInput"
        Me.PriceInput.Size = New System.Drawing.Size(224, 23)
        Me.PriceInput.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(87, 90)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(224, 23)
        Me.NameTextBox.TabIndex = 1
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Location = New System.Drawing.Point(87, 35)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(224, 23)
        Me.BarcodeTextBox.TabIndex = 0
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(6, 302)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(85, 30)
        Me.NewButton.TabIndex = 9
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(226, 302)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(85, 30)
        Me.DeleteButton.TabIndex = 10
        Me.DeleteButton.Text = "Deactivate"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(117, 302)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(85, 30)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'e
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProductsDetailsGroupBox)
        Me.Controls.Add(Me.ProductsGrid)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "e"
        Me.Text = "Manage Products"
        CType(Me.ProductsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsDetailsGroupBox.ResumeLayout(False)
        Me.ProductsDetailsGroupBox.PerformLayout()
        CType(Me.StockInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents ProductsGrid As DataGridView
    Friend WithEvents ProductsDetailsGroupBox As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents StockInput As NumericUpDown
    Friend WithEvents PriceInput As NumericUpDown
    Friend WithEvents StockLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents SaveButton As Button
End Class
