Public Class SignUp
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        SignIn.Users.UsernameProperty = TextBoxUsername.Text
        SignIn.Users.PasswordProperty = TextBoxPassword.Text
        SignIn.Users.emailProperty = TextBoxEmail.Text

        SignIn.Users.addDataUsersDatabase(SignIn.Users.UsernameProperty,
                                            SignIn.Users.PasswordProperty,
                                            SignIn.Users.emailProperty,
                                            SignIn.Users.fotoProperty)
        Me.Close()
    End Sub

    Private Sub BtnGambar_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        OFDGambar.Title = "Open Gambar Koleksi"
        OFDGambar.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OFDGambar.ShowDialog()

        Dim pickoleksi As String = OFDGambar.FileName

        PBGambar.Load(pickoleksi)
        PBGambar.SizeMode = PictureBoxSizeMode.StretchImage
        SignIn.Users.fotoProperty = pickoleksi.ToString()
        SignIn.Users.fotoProperty = SignIn.Users.fotoProperty.Replace("\", "/")

    End Sub


End Class