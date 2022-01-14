Public Class TambahKaryawan
    Private dataJabatan As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dataJabatan = Karyawan.fungsi.NamaJabatanInKaryawan()
        CmBJabatan.DataSource = dataJabatan
        CmBJabatan.DisplayMember = "nama_jabatan"
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Karyawan.fungsi.namaKaryawan = TbNama.Text
        Karyawan.fungsi.nikKaryawan = TbNIK.Text
        Karyawan.fungsi.alamatKaryawan = RTXAlamat.Text

        Karyawan.fungsi.AddDataKaryawanDatabase(Karyawan.fungsi.nikKaryawan,
                                                Karyawan.fungsi.namaKaryawan,
                                                Karyawan.fungsi.alamatKaryawan,
                                                Karyawan.fungsi.IDJabatanGS)
        Me.Close()
    End Sub

    Private Sub CmBJabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBJabatan.SelectedIndexChanged
        Karyawan.fungsi.IDJabatanGS = dataJabatan.Rows(CmBJabatan.SelectedIndex)("id_jabatan")
    End Sub
End Class