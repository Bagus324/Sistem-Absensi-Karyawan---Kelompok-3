Public Class HapusJabatan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblKoleksiHapus.Text = Jabatan.selectedDataJabatan
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Jabatan.fungsi.DeleteDataJabatanByIDDatabase(Jabatan.selectedData)
        Me.Close()
    End Sub

    Private Sub HapusJabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class