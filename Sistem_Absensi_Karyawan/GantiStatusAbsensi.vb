Public Class GantiStatusAbsensi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        FormAbsensi.absensi.namaProperty = TextBoxNama.Text
        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToString("yyyy/MM/dd")
        FormAbsensi.absensi.AbsenMasukProperty = DtpAbsenMasuk.Value.ToString("HH:mm:ss")
        FormAbsensi.absensi.AbsenKeluarProperty = DtpAbsenKeluar.Value.ToString("HH:mm:ss")

        FormAbsensi.absensi.AddDataAbsensiDatabase(FormAbsensi.absensi.namaProperty,
                                                FormAbsensi.absensi.TanggalProperty,
                                                FormAbsensi.absensi.AbsenMasukProperty,
                                                FormAbsensi.absensi.AbsenKeluarProperty)

        Dim infotambahabsensi = New InfoAbsensi

        infotambahabsensi.Show()
        Me.Close()
    End Sub
End Class