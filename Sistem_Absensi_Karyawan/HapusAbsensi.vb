Public Class HapusAbsensi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNama.Text = FormAbsensi.absensi.namaProperty
        Lbltgl.Text = FormAbsensi.absensi.TanggalProperty
    End Sub

    Private Sub BtnHapusAbsensi_Click(sender As Object, e As EventArgs) Handles BtnHapusAbsensi.Click
        FormAbsensi.absensi.DeleteDataAbsensiByIDDatabase(FormAbsensi.selectedTableAbsensi)
        Me.Close()
    End Sub


End Class