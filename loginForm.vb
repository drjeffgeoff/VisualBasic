Public Class loginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Hardcoded username and password
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            ' Open the Data Entry Form if login is successful
            Dim dataEntryForm As New DataEntryForm
            dataEntryForm.Show()
            Me.Hide() ' Hide the Login Form
        Else
            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
