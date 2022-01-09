Public Class GantiStatusAbsensi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim listnama As List(Of String) = FormAbsensi.absensi.CmBnama()
        ComboBox1.Items.Clear()
        For Each list In listnama
            ComboBox1.Items.Add(list)
        Next

    End Sub

    Private Sub BtnStatus_Click(sender As Object, e As EventArgs) Handles BtnStatus.Click
        FormAbsensi.absensi.namaProperty = ComboBox1.SelectedItem()
        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToString("yyyy/MM/dd")
        FormAbsensi.absensi.GantiStatusProperty = ComboBoxStatus.Text


        'Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getAbsensiItem)

        FormAbsensi.absensi.Upt2DataAbsensiDatabase(FormAbsensi.absensi.namaProperty,
                                                FormAbsensi.absensi.TanggalProperty,
                                                FormAbsensi.absensi.GantiStatusProperty)

        Dim infotambahabsensi = New InfoAbsensi

        infotambahabsensi.Show()
        Me.Close()
    End Sub
End Class