Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services

Public Class PosForm
    Private ReadOnly _cart As New BindingList(Of SaleItem)()

    Private ReadOnly _scanService As New BarcodeScanService()

    Private ReadOnly _productService As New ProductService()

    Private ReadOnly _saleService As New SaleService()

    Public Sub New()

        InitializeComponent()

        Dim cashierName =
            If(
                Session.CurrentUser Is Nothing,
                "Cashier",
                Session.CurrentUser.FullName
            )

        UserLabel.Text =
            "Logged in as " & cashierName

        CartGrid.DataSource = _cart

    End Sub

    Private Sub PosForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        ScanTextBox.Focus()

    End Sub

    Private Sub ScanTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ScanTextBox.KeyDown

        If e.KeyCode <> Keys.Enter Then
            Return
        End If

        e.SuppressKeyPress = True

        Try

            Dim scan =
                _scanService.Parse(
                    ScanTextBox.Text
                )

            Dim product =
                _productService.FindByBarcode(
                    scan.Barcode
                )

            If product Is Nothing Then

                ShowStatus(
                    "Barcode not found: " & scan.Barcode
                )

                Return

            End If

            AddToCart(product, scan.Quantity)

            ShowStatus(
                "Added " &
                scan.Quantity.ToString() &
                " x " &
                product.Name,
                Color.DarkGreen
            )

        Catch ex As Exception

            ShowStatus(ex.Message)

        Finally

            ScanTextBox.Clear()

            ScanTextBox.Focus()

        End Try

    End Sub

    Private Sub AddToCart(product As Product, quantity As Integer)

        Dim existing =
            _cart.FirstOrDefault(Function(item) item.ProductId = product.Id)

        If existing Is Nothing Then

            _cart.Add(
                New SaleItem With {
                    .ProductId = product.Id,
                    .Barcode = product.Barcode,
                    .ProductName = product.Name,
                    .Quantity = quantity,
                    .UnitPrice = product.Price
                }
            )

        Else

            existing.Quantity += quantity

            _cart.ResetBindings()

        End If

        RefreshTotal()

    End Sub

    Private Sub RefreshTotal()

        LineTotal.Text =
            "Total: " &
            _cart.Sum(Function(item) item.LineTotal).ToString("N2")

    End Sub

    Private Sub ShowStatus(message As String, Optional statusColor As Color = Nothing)

        StatusLabel.Text = message

        If statusColor = Nothing Then
            StatusLabel.ForeColor = Color.DarkRed
        Else
            StatusLabel.ForeColor = statusColor
        End If

    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click

        If CartGrid.CurrentRow Is Nothing _
            OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then

            Return

        End If

        Dim item =
            DirectCast(
                CartGrid.CurrentRow.DataBoundItem,
                SaleItem
            )

        _cart.Remove(item)

        RefreshTotal()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        _cart.Clear()

        RefreshTotal()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Try

            If Session.CurrentUser Is Nothing Then

                MessageBox.Show(
                    "No cashier session found.",
                    "POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If

            Dim saleId =
                _saleService.SaveSale(
                    Session.CurrentUser.Id,
                    _cart.ToList()
                )

            MessageBox.Show(
                "Sale saved. Sale No: " &
                saleId.ToString(),
                "POS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            _cart.Clear()

            RefreshTotal()

            ScanTextBox.Focus()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "POS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        End Try

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click

        If MessageBox.Show(
            "Are you sure you want to logout?",
            "POS",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then

            Session.CurrentUser = Nothing

            Dim login As New LoginForm()

            login.Show()

            Me.Close()

        End If

    End Sub
End Class