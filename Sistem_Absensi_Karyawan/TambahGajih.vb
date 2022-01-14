Public Class TambahGajih
    Private dataBulan As DataTable
    Private dataNama As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dataBulan = Penggajian.fungsi.GetDataBulanDatabase()
        CmBBulan.DataSource = dataBulan
        CmBBulan.DisplayMember = "nama_bulan"
        dataNama = Penggajian.fungsi.GetDataNamaDatabase()
        CmbNama.DataSource = dataNama
        CmbNama.DisplayMember = "nama_karyawan"
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CmBBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBBulan.SelectedIndexChanged
        Penggajian.fungsi.BulanGS = dataBulan.Rows(CmBBulan.SelectedIndex)("id_bulan")
    End Sub

    Private Sub CmbNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNama.SelectedIndexChanged
        Penggajian.fungsi.idKaryawanGaji = dataNama.Rows(CmbNama.SelectedIndex)("id_karyawan")
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        TBTotal.Text = Penggajian.fungsi.NgitungTotal(Penggajian.fungsi.idKaryawanGaji, Penggajian.fungsi.BulanGS).ToString()
        Penggajian.fungsi.TotalGajih = TBTotal.Text
    End Sub

    Private Sub BtnTambahGaji_Click(sender As Object, e As EventArgs) Handles BtnTambahGaji.Click
        Penggajian.fungsi.AddDataGajiDatabase(Penggajian.fungsi.idKaryawanGaji, Penggajian.fungsi.BulanGS, Penggajian.fungsi.TotalGajih)
        Me.Close()
    End Sub

End Class