Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim user = usernameTextBox.Text.Trim()
        Dim pass = passwordTextBox.Text
        Dim msg As String = String.Empty
        If SessionManager.Validate(user, pass, msg) Then

            ' Successful login: open main and hide login

            Dim dashboard As New main()
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show(msg, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub createAccountButton_Click(sender As Object, e As EventArgs) Handles createAccountButton.Click

        ' Open create account form and hide login

        Dim ca As New createaccount()
        ca.Show()
        Me.Hide()
    End Sub
End Class
