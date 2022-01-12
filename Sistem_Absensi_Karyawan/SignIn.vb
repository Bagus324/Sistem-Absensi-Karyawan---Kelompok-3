Public Class SignIn
    Public Shadows Users As Users
    Public Shared Absensi As FormAbsensi
    Public Shared daftar As SignUp

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
    End Sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text
        Absensi = New FormAbsensi


        Dim data_users As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_users.Count > 0 Then
            Users.UsernameProperty = data_users(1)
            Absensi.Show()
            Me.Hide()
        Else
            MessageBox.Show("salah password")
        End If
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        daftar = New SignUp
        daftar.Show()
    End Sub

End Class