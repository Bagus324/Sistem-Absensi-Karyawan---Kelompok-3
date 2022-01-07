Public Class GantiStatusAbsensi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnStatus_Click(sender As Object, e As EventArgs) Handles BtnStatus.Click
        FormAbsensi.absensi.namaProperty = TextBoxNama.Text
        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToString("yyyy/MM/dd")
        FormAbsensi.absensi.GantiStatusAbsensiProperty = ComboBoxStatus.Text


        'Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getAbsensiItem)

        FormAbsensi.absensi.Upt2DataAbsensiDatabase(FormAbsensi.absensi.namaProperty,
                                                FormAbsensi.absensi.TanggalProperty,
                                                FormAbsensi.absensi.GantiStatusAbsensiProperty)

        Dim infotambahabsensi = New InfoAbsensi

        infotambahabsensi.Show()
        Me.Close()
    End Sub
End Class