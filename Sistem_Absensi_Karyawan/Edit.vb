Public Class Edit
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TbNama.Text = Karyawan.fungsi.namaKaryawan
        TbNIK.Text = Karyawan.fungsi.nikKaryawan
        RTXAlamat.Text = Karyawan.fungsi.alamatKaryawan
        CmBJabatan.SelectedItem() = Karyawan.fungsi.IDtojabatan
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Karyawan.fungsi.namaKaryawan = TbNama.Text
        Karyawan.fungsi.nikKaryawan = TbNIK.Text
        Karyawan.fungsi.alamatKaryawan = RTXAlamat.Text
        Karyawan.fungsi.jabatantoID = CmBJabatan.SelectedItem()

        Karyawan.fungsi.UpdateDataKoleksiByIDDatabase(Karyawan.selectedData,
                                                      Karyawan.fungsi.nikKaryawan,
                                                      Karyawan.fungsi.namaKaryawan,
                                                      Karyawan.fungsi.alamatKaryawan,
                                                      Karyawan.fungsi.jabatantoID)
        Me.Close()
    End Sub
End Class