Imports System.Configuration
Imports MySql.Data.MySqlClient
Namespace Data1
    Public Class DBConnectionFactory
        Public Function CreateConnection() As MySqlConnection
            Dim settings = ConfigurationManager.ConnectionStrings("PosDB")
            If settings Is Nothing Then
                Throw New InvalidOperationException("Missing PosDB connection string in App.config")
            End If
            Return New MySqlConnection(settings.ConnectionString)
        End Function
    End Class
End Namespace
