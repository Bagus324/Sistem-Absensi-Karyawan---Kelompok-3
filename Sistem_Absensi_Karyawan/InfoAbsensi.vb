Public Class InfoAbsensi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblInfoNama.Text = FormAbsensi.absensi.namaProperty
        LblInfoTanggal.Text = FormAbsensi.absensi.TanggalProperty
        LblInfoAbsenMasuk.Text = FormAbsensi.absensi.AbsenMasukProperty
        LblInfoAbsenKeluar.Text = FormAbsensi.absensi.AbsenKeluarProperty


    End Sub
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        FormAbsensi.absensi.namaProperty = ""
        FormAbsensi.absensi.TanggalProperty = ""
        FormAbsensi.absensi.AbsenMasukProperty = ""
        FormAbsensi.absensi.AbsenKeluarProperty = ""

        Me.Close()
    End Sub

End Class