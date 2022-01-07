Public Class Penggajian
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus = New Hapus()
        Hapus.Show()
    End Sub

    Private Sub btnHitungGaji_Click(sender As Object, e As EventArgs) Handles btnHitungGaji.Click
        Dim Hitung = New Hitung()
        Hitung.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ubah = New Ubah()
        Ubah.Show()
    End Sub
End Class