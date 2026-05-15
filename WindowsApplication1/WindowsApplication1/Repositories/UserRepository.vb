Imports MySql.Data.MySqlClient
Imports Point_of_Sale_System.Data
Imports Point_of_Sale_System.Models

Namespace Repositories

    Public Class UserRepository

        Private ReadOnly _factory As New DbConnectionFactory()

        Public Function FindByUsername(username As String) As AppUser

            Using connection = _factory.CreateConnection()

                connection.Open()

                Using command As New MySqlCommand(
                    "SELECT id, full_name, username, password_hash, role, is_active 
             FROM users 
             WHERE username = @username 
             LIMIT 1", connection)

                    command.Parameters.AddWithValue("@username", username)

                    Using reader = command.ExecuteReader()

                        If reader.Read() Then
                            Return MapUser(reader)
                        End If

                    End Using

                End Using

            End Using

            Return Nothing

        End Function

        Private Function MapUser(reader As MySqlDataReader) As AppUser

            Return New AppUser With {
                .Id = Convert.ToInt32(reader("id")),
                .FullName = reader("full_name").ToString(),
                .Username = reader("username").ToString(),
                .PasswordHash = reader("password_hash").ToString(),
                .Role = reader("role").ToString(),
                .IsActive = Convert.ToBoolean(reader("is_active"))
            }

        End Function

    End Class

End Namespace


