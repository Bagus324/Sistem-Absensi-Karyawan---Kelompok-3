Public Class SignUp
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        If TextBoxUsername.Text.Length > 0 And TextBoxPassword.Text.Length > 0 Then
            SignIn.Users.addDataUsersDatabase(TextBoxUsername.Text, TextBoxPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("lengkapi cuy")
        End If
    End Sub
End Class