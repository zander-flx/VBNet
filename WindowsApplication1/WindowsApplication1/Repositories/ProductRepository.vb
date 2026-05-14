Imports MySql.Data.MySqlClient
Imports Point_of_Sale_System.Data
Imports Point_of_Sale_System.Models


Namespace Repositories
    Public Class ProductRepository
        Private ReadOnly _factory As New DBConnectionFactory()

        Public Function GetAll(Optional IncludeInactive As Boolean = False) As List(Of Product)
            Dim products As New List(Of Product)()
            Using connection = _factory.CreateConnection()
                connection.Open()
                Dim sql = ""
                If Not IncludeInactive Then
                    sql &= ""
                End If
                sql &= ""

                Using command As New MySqlCommand(sql, connection)
                    Using reader = command
                    End Using
                End Using
            End Using
        End Function

        Private Sub FillProductParameters(command As MySqlCommand, product As Product)
            command.Parameters.AddWithValue("@barcode", product.Barcode)
            command.Parameters.AddWithValue("@name", product.Name)
            command.Parameters.AddWithValue("@price", product.Price)
            command.Parameters.AddWithValue("@stock", product.StockQuantity)
            command.Parameters.AddWithValue("@active", product.IsActive)
        End Sub
        Private Function MapProduct(reader As MySqlDataReader) As Product
            Return New Product With {
                .Id = Convert.ToInt32(reader("id")),
                .Barcode = reader("barcode").ToString(),
                .Name = reader("name").ToString(),
                .Price = Convert.ToDecimal(reader("price")),
                .StockQuantity = Convert.ToInt32(reader("stock")),
                .IsActive = Convert.ToBoolean(reader("is_active"))
            }
        End Function
    End Class
End Namespace
