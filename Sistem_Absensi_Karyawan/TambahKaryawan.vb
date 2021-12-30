Public Class TambahKaryawan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TbNama.Text = Karyawan.fungsi.namaKaryawan
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Karyawan.fungsi.namaKaryawan = TbNama.Text
        Karyawan.fungsi.nikKaryawan = TbNIK.Text
        Karyawan.fungsi.alamatKaryawan = RTXAlamat.Text
        Karyawan.fungsi.jabatantoID = CmBJabatan.SelectedItem()

        Karyawan.fungsi.AddDataKaryawanDatabase(Karyawan.fungsi.nikKaryawan,
                                                Karyawan.fungsi.namaKaryawan,
                                                Karyawan.fungsi.alamatKaryawan,
                                                Karyawan.fungsi.jabatantoID)
        Me.Close()
    End Sub


End Class