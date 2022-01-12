Public Class home
    Public Shared formJabatan As Jabatan
    Public Shared formKaryawan As Karyawan
    Public Shared formGaji As Penggajian


    Private Sub Karyawan_Click(sender As Object, e As EventArgs) Handles BtnKaryawan.Click
        formKaryawan = New Karyawan
        formKaryawan.Show()
    End Sub

    Private Sub Jabatan_Click(sender As Object, e As EventArgs) Handles BtnJabatan.Click
        formJabatan = New Jabatan
        formJabatan.Show()
    End Sub

    Private Sub BtnGaji_Click(sender As Object, e As EventArgs) Handles BtnGaji.Click
        formGaji = New Penggajian
        formGaji.Show()
    End Sub
End Class