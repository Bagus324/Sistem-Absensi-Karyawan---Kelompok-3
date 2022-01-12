Public Class EditKaryawan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TbNama.Text = Karyawan.fungsi.namaKaryawan
        TbNIK.Text = Karyawan.fungsi.nikKaryawan
        RTXAlamat.Text = Karyawan.fungsi.alamatKaryawan
        CmBJabatan.SelectedItem() = Karyawan.fungsi.namaJabatanGS
        Dim listjabatan As List(Of String) = Karyawan.fungsi.CmBJabatan()
        CmBJabatan.Items.Clear()
        For Each list In listjabatan
            CmBJabatan.Items.Add(list)
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Karyawan.fungsi.namaKaryawan = TbNama.Text
        Karyawan.fungsi.nikKaryawan = TbNIK.Text
        Karyawan.fungsi.alamatKaryawan = RTXAlamat.Text
        Karyawan.fungsi.namaJabatanGS = CmBJabatan.SelectedItem()

        Karyawan.fungsi.UpdateDataKaryawanByIDDatabase(Karyawan.selectedData,
                                                        Karyawan.fungsi.nikKaryawan,
                                                        Karyawan.fungsi.namaKaryawan,
                                                        Karyawan.fungsi.alamatKaryawan,
                                                        Karyawan.fungsi.namaJabatanGS)
        Me.Close()
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class