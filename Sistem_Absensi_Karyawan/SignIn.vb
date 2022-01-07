Public Class SignIn
    Public Shadows Users As Users
    Public Shared FormAbsensi As FormAbsensi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FormAbsensi = New FormAbsensi()
        Users = New Users()
    End Sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text
        Dim plainEmail As String = TextBox3.Text


        Dim data_users As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_users.Count > 0 Then
            Users.UsernameProperty = data_users(1)
            FormAbsensi.Show()
            Me.Hide()
        Else
            MessageBox.Show("salah password")
        End If

    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        SignUp.Show()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If MessageBox.Show("Yakin Ingin Membatalkan Login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            FormAbsensi.Close()
            Me.Close()
        End If
    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        OpenFileDialog1.Title = "Open Gambar"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim pickoleksi As String = OpenFileDialog1.FileName

        PictureBox1.Load(pickoleksi)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        Users.fotoProperty = pickoleksi.ToString()
        Users.fotoProperty = Users.fotoProperty.Replace("\", "/")
    End Sub
End Class