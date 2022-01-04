Public Class FormAbsensiMasuk


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DtpAbsenMasuk.Format = DateTimePickerFormat.Custom
        DtpAbsenKeluar.Format = DateTimePickerFormat.Custom

        DtpAbsenMasuk.CustomFormat = "yyyy/MM/dd"
        DtpAbsenKeluar.CustomFormat = "yyyy/MM/dd"


    End Sub
    Public Shared absensi As Absensi

    Private Sub BtnTambahAbsensi_Click(sender As Object, e As EventArgs) Handles BtnTambahAbsensi.Click
        FormAbsensi.absensi.namaProperty = Tbxnama.Text.ToString()
        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToShortDateString()
        FormAbsensi.absensi.TanggalProperty = DtpAbsenMasuk.Value.ToShortTimeString()
        FormAbsensi.absensi.TanggalProperty = DtpAbsenKeluar.Value.ToShortTimeString()

        'Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getKategoriItem)
        'FormAbsensi.absensi.AddDataAbsensiDatabase(FormAbsensi.absensi.namaProperty,
        '                                         FormAbsensi.absensi.TanggalProperty,
        '                                         FormAbsensi.absensi.AbsenMasukProperty,
        'FormAbsensi.absensi.AbsenKeluarProperty,
        'convertedAbsensi)

        'Dim infotambah = New Info()

        'infotambah.Show()
        Me.Close()

    End Sub
End Class