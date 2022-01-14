Public Class FormAbsensiMasuk


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DtpAbsenMasuk.CustomFormat = DateTime.Now.ToString("HH:mm")
        ' Add any initialization after the InitializeComponent() call.
        'DtpAbsenMasuk.Format = DateTimePickerFormat.Custom
        'DtpAbsenKeluar.Format = DateTimePickerFormat.Custom

        Dim listnama As List(Of String) = FormAbsensi.absensi.CmBnama()
        ComboBox1.Items.Clear()
        For Each list In listnama
            ComboBox1.Items.Add(list)
        Next



    End Sub

    Public Shared absensi As Absensi
    Private Sub BtnTambahAbsensi_Click(sender As Object, e As EventArgs) Handles BtnTambahAbsensi.Click

        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToString("yyyy/MM/dd")
        FormAbsensi.absensi.AbsenMasukProperty = DtpAbsenMasuk.Value.ToString("HH:mm:ss")
        'FormAbsensi.absensi.AbsenKeluarProperty = DtpAbsenKeluar.Value.ToString("HH:mm:ss")

        'Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getAbsensiItem)
        FormAbsensi.absensi.namaProperty = ComboBox1.SelectedItem()
        FormAbsensi.absensi.AddDataAbsensiDatabase(FormAbsensi.absensi.namaProperty,
                                                FormAbsensi.absensi.AbsenMasukProperty)
        Me.Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class