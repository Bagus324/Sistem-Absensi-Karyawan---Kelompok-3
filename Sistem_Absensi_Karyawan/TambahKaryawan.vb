Public Class TambahKaryawan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim listjabatan As List(Of String) = Karyawan.fungsi.CmBJabatan()
        CmBJabatan.Items.Clear()
        For Each list In listjabatan
            CmBJabatan.Items.Add(list)
        Next
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Karyawan.fungsi.namaKaryawan = TbNama.Text
        Karyawan.fungsi.nikKaryawan = TbNIK.Text
        Karyawan.fungsi.alamatKaryawan = RTXAlamat.Text
        Karyawan.fungsi.namaJabatanGS = CmBJabatan.SelectedItem()

        Karyawan.fungsi.AddDataKaryawanDatabase(Karyawan.fungsi.nikKaryawan,
                                                Karyawan.fungsi.namaKaryawan,
                                                Karyawan.fungsi.alamatKaryawan,
                                                Karyawan.fungsi.namaJabatanGS)
        Me.Close()
    End Sub


End Class