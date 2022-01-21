Public Class TambahJabatan
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Jabatan.fungsi.gajihJabatan = TBGajih.Text
        Jabatan.fungsi.namaJabatanGS = TBJabatan.Text

        Jabatan.fungsi.AddDataJabatanDatabase(Jabatan.fungsi.gajihJabatan,
                                              Jabatan.fungsi.namaJabatanGS)
        Me.Close()
    End Sub


End Class