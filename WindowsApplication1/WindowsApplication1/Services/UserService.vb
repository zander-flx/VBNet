Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Repositories

Namespace Services

    Public Class UserService

        Private ReadOnly _users As New UserRepository()

        Private ReadOnly _hasher As New PasswordHasher()

        Public Function GetAll() As List(Of AppUser)

            Return _users.GetAll()

        End Function

        Public Sub Save(
            user As AppUser,
            plainPassword As String
        )

            ValidateUser(user)

            Dim updatePassword =
                Not String.IsNullOrWhiteSpace(plainPassword)

            If updatePassword Then

                user.PasswordHash =
                    _hasher.HashPassword(plainPassword)

            End If

            If user.Id = 0 Then

                If Not updatePassword Then
                    Throw New ArgumentException(
                        "Password is required for new users."
                    )
                End If

                _users.Add(user)

            Else

                _users.Update(user, updatePassword)

            End If

        End Sub

        Public Sub Deactivate(userId As Integer)

            _users.Deactivate(userId)

        End Sub

        Private Sub ValidateUser(user As AppUser)

            If String.IsNullOrWhiteSpace(user.FullName) Then
                Throw New ArgumentException(
                    "Full name is required."
                )
            End If

            If String.IsNullOrWhiteSpace(user.Username) Then
                Throw New ArgumentException(
                    "Username is required."
                )
            End If

            If user.Role <> "admin" _
                AndAlso user.Role <> "cashier" Then

                Throw New ArgumentException(
                    "Role must be admin or cashier."
                )

            End If

        End Sub

    End Class

End Namespace