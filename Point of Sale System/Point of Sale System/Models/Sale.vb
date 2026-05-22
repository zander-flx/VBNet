Namespace Models
    Public Class Sale
        Public Property Id As Integer
        Public Property CashierId As Integer
        Public Property TotalAmount As Decimal
        Public Property Items As List(Of SaleItem)
    End Class
End Namespace