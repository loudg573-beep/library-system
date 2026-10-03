Public Class createaccount
    Private Sub createaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ' Show login form again and close this form

        My.Forms.Form1.Show()
        Me.Close()
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked

        ' Navigate back to login

        My.Forms.Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ' Collect inputs and attempt to register

        Dim studentId = txtStudentID.Text.Trim()
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text
        Dim confirm = txtConfirm.Text

        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If password <> confirm Then
            MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim msg As String = String.Empty
        If SessionManager.Register(username, password, msg) Then
            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Return to login form so user can sign in

            My.Forms.Form1.Show()
            Me.Close()
        Else
            MessageBox.Show(msg, "Create Account Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class