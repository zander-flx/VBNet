Imports FoodOrderingSystem.Models
Imports FoodOrderingSystem.Services

Partial Public Class OrderManagementForm
    Private ReadOnly _orderService As New OrderService()
    Private _selectedOrderId As Integer = 0

    Public Sub New()
        InitializeComponent()
        StatusFilterComboBox.SelectedIndex = 0
        LoadOrders()
    End Sub

    Private Sub LoadOrders()
        Dim orders = _orderService.GetAllOrders()
        Dim filter = StatusFilterComboBox.SelectedItem.ToString()
        If filter <> "All" Then orders = orders.Where(Function(o) o.Status = filter).ToList()
        OrdersGrid.DataSource = orders.OrderByDescending(Function(o) o.CreatedAt).ToList()
        OrdersGrid.ClearSelection()
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        OrderNumberLabel.Text = "-"
        CustomerInfoLabel.Text = "-"
        TotalLabel.Text = "-"
        OrderStatusComboBox.SelectedIndex = 0
        _selectedOrderId = 0
    End Sub

    Private Sub StatusFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusFilterComboBox.SelectedIndexChanged
        LoadOrders()
    End Sub

    Private Sub OrdersGrid_SelectionChanged(sender As Object, e As EventArgs) Handles OrdersGrid.SelectionChanged
        If OrdersGrid.CurrentRow Is Nothing OrElse OrdersGrid.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim order = DirectCast(OrdersGrid.CurrentRow.DataBoundItem, Order)
        _selectedOrderId = order.Id
        OrderNumberLabel.Text = order.OrderNumber
        CustomerInfoLabel.Text = $"{order.CustomerName} | {order.OrderType.ToUpper()} | Table: {If(String.IsNullOrWhiteSpace(order.TableNumber), "N/A", order.TableNumber)}"
        TotalLabel.Text = order.TotalAmount.ToString("C2")
        OrderStatusComboBox.SelectedItem = order.Status
    End Sub

    Private Sub UpdateStatusButton_Click(sender As Object, e As EventArgs) Handles UpdateStatusButton.Click
        If _selectedOrderId = 0 Then Return
        Try
            _orderService.UpdateOrderStatus(_selectedOrderId, OrderStatusComboBox.SelectedItem.ToString())
            LoadOrders()
            MessageBox.Show("Status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ViewItemsButton_Click(sender As Object, e As EventArgs) Handles ViewItemsButton.Click
        If _selectedOrderId = 0 Then Return
        Dim order = _orderService.GetOrder(_selectedOrderId)
        If order Is Nothing Then Return
        Dim itemsText = String.Join(vbCrLf, order.Items.Select(Function(i) $"  {i.Quantity}x {i.ItemName} - {i.LineTotal:C2}"))
        MessageBox.Show($"Order: {order.OrderNumber}{vbCrLf}Type: {order.OrderType.ToUpper()}{vbCrLf}{vbCrLf}Items:{vbCrLf}{itemsText}{vbCrLf}{vbCrLf}Total: {order.TotalAmount:C2}", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class