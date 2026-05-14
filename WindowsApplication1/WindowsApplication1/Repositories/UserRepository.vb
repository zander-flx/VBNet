Public Function FindByUsername(username As String) As AppUser
    Using connection = _factory.CreateConnection()
        connection.Open()
        Using command As New MySqlCommand("SELECT id, full_name, username, password_hash, role, is_active FROM users
WHERE username = @username LIMIT 1", connection)
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