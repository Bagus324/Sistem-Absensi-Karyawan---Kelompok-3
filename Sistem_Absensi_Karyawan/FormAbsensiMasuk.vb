Public Class FormAbsensiMasuk


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DtpAbsenMasuk.Format = DateTimePickerFormat.Custom
        DtpAbsenKeluar.Format = DateTimePickerFormat.Custom





    End Sub

    Public Shared absensi As Absensi
    Private Sub BtnTambahAbsensi_Click(sender As Object, e As EventArgs) Handles BtnTambahAbsensi.Click
        FormAbsensi.absensi.namaProperty = TextBoxNama.Text.ToString()
        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToShortDateString()
        FormAbsensi.absensi.TanggalProperty = DtpAbsenMasuk.Value.ToShortTimeString()
        FormAbsensi.absensi.TanggalProperty = DtpAbsenKeluar.Value.ToShortTimeString()

        Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getAbsensiItem)

        FormAbsensi.absensi.AddDataAbsensiDatabase(FormAbsensi.absensi.namaProperty,
                                                FormAbsensi.absensi.TanggalProperty,
                                                FormAbsensi.absensi.AbsenMasukProperty,
                                                FormAbsensi.absensi.AbsenKeluarProperty,
                                                convertedAbsensi)

        Dim infotambahabsensi = New InfoAbsensi()

        infotambahabsensi.Show()
        Me.Close()

    End Sub
End Class