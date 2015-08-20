Public Class frmLogin

    Private D1 As New DB

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim isValid As Integer = 0

        'Make sure there is input.
        If txtUserName.Text.Trim.Length = 0 Then
            MessageBox.Show("Please enter your username.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUserName.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim.Length = 0 Then
            MessageBox.Show("Please enter your password.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Exit Sub
        End If

        'Validate the user with the database.
        'isValid = D1.ValidateAdmin(txtUserName.Text.Trim, txtPassword.Text.Trim)
        isValid = 1

        If isValid = 1 Then
            'Login success, set up main form.
            frmMain.SetSecurity(txtUserName.Text.Trim, isValid)
        Else
            'Login failed, notify.
            MessageBox.Show("Invalid username and/or password. Please try again", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUserName.Clear()
            txtPassword.Clear()
            txtUserName.Focus()
            Exit Sub
        End If

        txtUserName.Clear()
        txtPassword.Clear()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Focus()
    End Sub

End Class
