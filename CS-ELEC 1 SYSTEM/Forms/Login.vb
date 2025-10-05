Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Password 15px below Username
        Password.Location = New Point(28, Username.Bottom + 15)

        ' Show Password checkbox 6px below Password
        Showpass.Location = New Point(35, Password.Bottom + 8)

        ' Roles ComboBox 15px below Show Password
        Roles.Location = New Point(28, Showpass.Bottom + 15)

        ' Login button 20px below Roles
        LoginBtn.Location = New Point(28, Roles.Bottom + 25)
    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged
        If Showpass.Checked Then
            Password.PasswordChar = ""
        Else
            Password.PasswordChar = "*"
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click


        Dim repo As New UserRepository()
        Dim User As UserDetails = repo.ValidateLogin(Username.Text, Password.Text)
        If User IsNot Nothing Then
            If User.UserRoles = "Cashier" Then
                MainMenu.Show()
            Else
                ManagerDashboard.Show()
            End If
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class