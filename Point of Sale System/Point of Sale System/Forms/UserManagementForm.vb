Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services
Imports System.ComponentModel

Partial Public Class UserManagementForm
    Private ReadOnly _service As New UserService()
    Private _selectedId As Integer = 0
    Private _hasher As New PasswordHasher

    Public Sub New()
        InitializeComponent()
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        UsersGrid.DataSource = Nothing
        UsersGrid.DataSource = _service.GetAll()
        UsersGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub ValidateUser(user As AppUser, plainPassword As String)
        If String.IsNullOrWhiteSpace(user.FullName) Then
            Throw New ArgumentException("Full name is required.")
        End If
        If String.IsNullOrWhiteSpace(user.Username) Then
            Throw New ArgumentException("Username is required.")
        End If
        If user.Id = 0 AndAlso String.IsNullOrWhiteSpace(plainPassword) Then
            Throw New ArgumentException("Password is required for new users.")
        End If
        If user.Role <> "admin" AndAlso user.Role <> "cashier" Then
            Throw New ArgumentException("Role must be admin or cashier.")
        End If
        Dim shouldUpdatePassword = Not String.IsNullOrWhiteSpace(plainPassword)
        If shouldUpdatePassword Then
            user.PasswordHash = _hasher.HashPassword(plainPassword)
        End If
    End Sub

    Private Sub ClearForm()
        FullNameTextBox.Text = String.Empty
        UsernameTextBox.Text = String.Empty
        PasswordTextBox.Text = String.Empty
        RoleComboBox.SelectedItem = "cashier"
        ActiveCheckBox.Checked = True
        _selectedId = 0
    End Sub

    Private Sub UsersGrid_SelectionChanged(sender As Object, e As EventArgs) Handles UsersGrid.SelectionChanged
        If UsersGrid.SelectedRows.Count = 0 OrElse UsersGrid.CurrentRow Is Nothing OrElse
            UsersGrid.CurrentRow.DataBoundItem Is Nothing Then
            Return
        End If
        Dim user = DirectCast(UsersGrid.CurrentRow.DataBoundItem, AppUser)
        _selectedId = user.Id
        FullNameTextBox.Text = user.FullName
        UsernameTextBox.Text = user.Username
        PasswordTextBox.Clear()
        RoleComboBox.SelectedItem = user.Role
        ActiveCheckBox.Checked = user.IsActive
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim role = If(RoleComboBox.SelectedItem Is Nothing, "cashier", RoleComboBox.SelectedItem.ToString())
            Dim user As New AppUser With {
                 .Id = _selectedId,
                 .FullName = FullNameTextBox.Text.Trim(),
                 .Username = UsernameTextBox.Text.Trim(),
                 .Role = role,
                 .IsActive = ActiveCheckBox.Checked
                 }
            _service.Save(user, PasswordTextBox.Text)
            LoadUsers()
            MessageBox.Show("User saved.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub DeactivateButton_Click(sender As Object, e As EventArgs) Handles DeactivateButton.Click
        If _selectedId = 0 Then Return
        If MessageBox.Show("Deactivate this user?", "Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _service.Deactivate(_selectedId)
            LoadUsers()
        End If
    End Sub
End Class