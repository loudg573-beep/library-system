Public Class main
    Private Sub PanelReportOptions_Paint(sender As Object, e As PaintEventArgs) Handles PanelReportOptions.Paint

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Prevent access to main unless authenticated

        If Not SessionManager.IsAuthenticated Then
            MessageBox.Show("Please log in to access the application.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Forms.Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ButtonLogOut_Click(sender As Object, e As EventArgs) Handles ButtonLogOut.Click

        ' Logout and return to login form

        SessionManager.Logout()
        My.Forms.Form1.Show()
        Me.Close()
    End Sub

    Private Sub ButtonBorrower_Click(sender As Object, e As EventArgs) Handles ButtonBorrower.Click

    End Sub
End Class