Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services
Imports System.ComponentModel

Partial Public Class ProductManagementForm
    Private ReadOnly _service As New ProductService()
    Private _selectedId As Integer = 0

    Public Sub New()
        InitializeComponent()
        LoadProducts()
    End Sub

    Private Sub LoadProducts(Optional term As String = "")
        ProductsGrid.DataSource = Nothing
        ProductsGrid.DataSource = _service.Search(term)
        ProductsGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        BarcodeTextBox.Text = String.Empty
        NameTextBox.Text = String.Empty
        PriceInput.Value = 0
        StockInput.Value = 0
        ActiveCheckBox.Checked = True
        _selectedId = 0
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadProducts(SearchTextBox.Text)
    End Sub

    Private Sub ProductsGrid_SelectionChanged(sender As Object, e As EventArgs) Handles ProductsGrid.SelectionChanged
        If ProductsGrid.SelectedRows.Count = 0 OrElse ProductsGrid.CurrentRow Is Nothing OrElse ProductsGrid.CurrentRow.DataBoundItem Is Nothing Then
            Return
        End If

        Dim product = DirectCast(ProductsGrid.CurrentRow.DataBoundItem, Product)
        _selectedId = product.Id
        BarcodeTextBox.Text = product.Barcode
        NameTextBox.Text = product.Name
        PriceInput.Value = product.Price
        StockInput.Value = product.StockQuantity
        ActiveCheckBox.Checked = product.IsActive
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim product As New Product With {
                .Id = _selectedId,
                .Barcode = BarcodeTextBox.Text.Trim(),
                .Name = NameTextBox.Text.Trim(),
                .Price = PriceInput.Value,
                .StockQuantity = Convert.ToInt32(StockInput.Value),
                .IsActive = ActiveCheckBox.Checked
            }

            _service.Save(product)
            LoadProducts(SearchTextBox.Text)
            MessageBox.Show("Product saved.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If _selectedId = 0 Then Return
        If MessageBox.Show("Deactivate this product?", "Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _service.Deactivate(_selectedId)
            LoadProducts(SearchTextBox.Text)
        End If
    End Sub
End Class