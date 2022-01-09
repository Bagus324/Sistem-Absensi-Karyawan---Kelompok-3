Public Class Hapus
<<<<<<< HEAD
=======

>>>>>>> origin/Daffahakim
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
<<<<<<< HEAD
        LblKoleksiHapus.Text = Karyawan.selectedNamaData
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Karyawan.fungsi.DeleteDataByIDDatabase(Karyawan.selectedData)
=======

        ' Add any initialization after the InitializeComponent() call.
        LblGaji.Text = Penggajian.SelectedGaji.ToString()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Penggajian.Gaji.RemoveGaji(Penggajian.SelectedGaji)
        Penggajian.Gaji.RemoveGajiDataTable(Penggajian.SelectedTabGaji)
>>>>>>> origin/Daffahakim
        Me.Close()
    End Sub
End Class