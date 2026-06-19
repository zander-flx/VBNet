Imports System.ComponentModel
Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class OrderForm
    Private ReadOnly _cart As New BindingList(Of OrderItem)()
    Private ReadOnly _itemService As New MenuItemService()
    Private ReadOnly _catService As New CategoryService()
    Private ReadOnly _orderService As New OrderService()

    Public Sub New()
        InitializeComponent()
        UserLabel.Text = "Staff: " & If(Session.CurrentUser Is Nothing, "Guest", Session.CurrentUser.FullName)
        CartGrid.DataSource = _cart
        LoadCategories()
        LoadMenu()
    End Sub

    Private Sub LoadCategories()
        Dim cats = _catService.GetAll()
        cats.Insert(0, New Category With {.Id = 0, .Name = "All"})
        CategoryComboBox.DataSource = cats
        CategoryComboBox.DisplayMember = "Name"
        CategoryComboBox.ValueMember = "Id"
        CategoryComboBox.SelectedIndex = 0
    End Sub

    Private Sub LoadMenu()
        Dim catId = If(CategoryComboBox.SelectedValue, 0)
        Dim items = If(catId = 0, _itemService.GetAll(), _itemService.GetByCategory(catId))
        If Not String.IsNullOrWhiteSpace(SearchTextBox.Text) Then
            items = items.Where(Function(i) i.Name.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList()
        End If
        MenuGrid.DataSource = items
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        LoadMenu()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadMenu()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If MenuGrid.CurrentRow Is Nothing OrElse MenuGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        AddToCart(DirectCast(MenuGrid.CurrentRow.DataBoundItem, MenuItem))
    End Sub

    Private Sub MenuGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MenuGrid.CellDoubleClick
        If e.RowIndex >= 0 AndAlso MenuGrid.Rows(e.RowIndex).DataBoundItem IsNot Nothing Then
            AddToCart(DirectCast(MenuGrid.Rows(e.RowIndex).DataBoundItem, MenuItem))
        End If
    End Sub

    Private Sub AddToCart(menuItem As MenuItem)
        If Not menuItem.IsAvailable Then
            MessageBox.Show("This item is currently unavailable.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim existing = _cart.FirstOrDefault(Function(c) c.MenuItemId = menuItem.Id)
        If existing Is Nothing Then
            _cart.Add(New OrderItem With {
                .MenuItemId = menuItem.Id,
                .ItemName = menuItem.Name,
                .Quantity = 1,
                .UnitPrice = menuItem.Price,
                .SpecialInstructions = ""
            })
        Else
            existing.Quantity += 1
            _cart.ResetBindings()
        End If
        RefreshTotal()
    End Sub

    Private Sub QuantityPlusButton_Click(sender As Object, e As EventArgs) Handles QuantityPlusButton.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        DirectCast(CartGrid.CurrentRow.DataBoundItem, OrderItem).Quantity += 1
        _cart.ResetBindings()
        RefreshTotal()
    End Sub

    Private Sub QuantityMinusButton_Click(sender As Object, e As EventArgs) Handles QuantityMinusButton.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim item = DirectCast(CartGrid.CurrentRow.DataBoundItem, OrderItem)
        If item.Quantity > 1 Then
            item.Quantity -= 1
        Else
            _cart.Remove(item)
        End If
        _cart.ResetBindings()
        RefreshTotal()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        _cart.Remove(DirectCast(CartGrid.CurrentRow.DataBoundItem, OrderItem))
        RefreshTotal()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        _cart.Clear()
        RefreshTotal()
    End Sub

    Private Sub RefreshTotal()
        TotalLabel.Text = "Total: " & _cart.Sum(Function(i) i.LineTotal).ToString("C2")
    End Sub

    Private Sub OrderTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderTypeComboBox.SelectedIndexChanged
        Dim type = OrderTypeComboBox.SelectedItem.ToString()
        TableNumberTextBox.Enabled = (type = "Dine-in")
        AddressTextBox.Enabled = (type = "Delivery")
        If Not TableNumberTextBox.Enabled Then TableNumberTextBox.Clear()
        If Not AddressTextBox.Enabled Then AddressTextBox.Clear()
    End Sub

    Private Sub PlaceOrderButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        Try
            If _cart.Count = 0 Then Throw New ArgumentException("Cart is empty.")
            If Session.CurrentUser Is Nothing Then Throw New InvalidOperationException("Session expired. Please login again.")

            Dim orderType = OrderTypeComboBox.SelectedItem.ToString().ToLower()
            Dim order As New Order With {
                .CashierId = Session.CurrentUser.Id,
                .orderType = orderType,
                .TableNumber = If(orderType = "dine-in", TableNumberTextBox.Text.Trim(), ""),
                .CustomerName = CustomerNameTextBox.Text.Trim(),
                .CustomerPhone = CustomerPhoneTextBox.Text.Trim(),
                .CustomerAddress = If(orderType = "delivery", AddressTextBox.Text.Trim(), ""),
                .TotalAmount = _cart.Sum(Function(i) i.LineTotal),
                .Status = "pending",
                .Notes = NotesTextBox.Text.Trim(),
                .Items = _cart.ToList()
            }

            Dim id = _orderService.SaveOrder(order)
            MessageBox.Show($"Order Placed Successfully!{vbCrLf}Order No: {order.OrderNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset Form
            _cart.Clear()
            RefreshTotal()
            CustomerNameTextBox.Clear()
            CustomerPhoneTextBox.Clear()
            TableNumberTextBox.Clear()
            AddressTextBox.Clear()
            NotesTextBox.Clear()
            OrderTypeComboBox.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Close()
    End Sub
End Class