Public Class EditGaji
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TBGajih.Text = Penggajian.fungsi.TotalGajih
        TbNama.Text = Penggajian.fungsi.namaKaryawan
        TbBulan.Text = Penggajian.fungsi.BulanGS
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class