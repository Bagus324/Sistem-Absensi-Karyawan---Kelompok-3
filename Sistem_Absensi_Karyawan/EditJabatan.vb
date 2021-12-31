Public Class EditJabatan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TBGajih.Text = Jabatan.fungsi.gajihJabatan
        TBJabatan.Text = Jabatan.fungsi.namaJabatanGS
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Jabatan.fungsi.gajihJabatan = TBGajih.Text
        Jabatan.fungsi.namaJabatanGS = TBJabatan.Text

        Jabatan.fungsi.UpdateDataJabatanByIDDatabase(Jabatan.selectedData,
                                                     Jabatan.fungsi.namaJabatanGS,
                                                     Jabatan.fungsi.gajihJabatan)

        Me.Close()
    End Sub
End Class