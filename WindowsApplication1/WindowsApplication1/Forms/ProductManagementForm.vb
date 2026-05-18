Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services
Public Class ProductManagementForm
    Private ReadOnly _service As New ProductService()

    Private _selectedId As Integer = 0

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub ProductManagementForm_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        LoadProducts()

    End Sub

    Private Sub LoadProducts(Optional term As String = "")

        ProductsGrid.DataSource = Nothing

        ProductsGrid.DataSource = _service.Search(term)

        ProductsGrid.ClearSelection()

        ClearForm()

    End Sub

    Private Sub ClearForm()

        _selectedId = 0

        BarcodeTextBox.Clear()

        NameTextBox.Clear()

        PriceInput.Value = 0

        StockInput.Value = 0

        ActiveCheckBox.Checked = True

    End Sub

    Private Sub ProductsGrid_SelectionChanged(
    sender As Object,
    e As EventArgs
) Handles ProductsGrid.SelectionChanged

        If ProductsGrid.SelectedRows.Count = 0 _
            OrElse ProductsGrid.CurrentRow Is Nothing _
            OrElse ProductsGrid.CurrentRow.DataBoundItem Is Nothing Then

            Return

        End If

        Dim product =
            DirectCast(
                ProductsGrid.CurrentRow.DataBoundItem,
                Product
            )

        _selectedId = product.Id

        BarcodeTextBox.Text = product.Barcode

        NameTextBox.Text = product.Name

        PriceInput.Value = product.Price

        StockInput.Value = product.StockQuantity

        ActiveCheckBox.Checked = product.IsActive

    End Sub

    Private Sub SaveButton_Click(
    sender As Object,
    e As EventArgs
) Handles SaveButton.Click

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

            MessageBox.Show(
                "Product saved.",
                "Products",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Products",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        End Try

    End Sub

    Private Sub NewButton_Click(
    sender As Object,
    e As EventArgs
) Handles NewButton.Click

        ClearForm()

    End Sub

    Private Sub DeleteButton_Click(
    sender As Object,
    e As EventArgs
) Handles DeactivateButton.Click

        If _selectedId = 0 Then
            Return
        End If

        If MessageBox.Show(
            "Deactivate this product?",
            "Products",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then

            _service.Deactivate(_selectedId)

            LoadProducts(SearchTextBox.Text)

        End If

    End Sub

    Private Sub SearchButton_Click(
    sender As Object,
    e As EventArgs
) Handles SearchButton.Click

        LoadProducts(SearchTextBox.Text)

    End Sub
End Class