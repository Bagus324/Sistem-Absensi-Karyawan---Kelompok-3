Public Class HapusKaryawan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblKoleksiHapus.Text = Karyawan.selectedNamaData
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Karyawan.fungsi.DeleteDataByIDDatabase(Karyawan.selectedData)
        Me.Close()
    End Sub


End Class