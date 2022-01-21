Public Class FormAbsensiKeluar
    Public Shared x As DateTime
    Public Shared y
    Public Sub New()
        If warning.WarningInt = 1 Then
            Me.Close()
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim listnama As List(Of String) = FormAbsensi.absensi.CmBnamaKeluar()
        ComboBox1.Items.Clear()
        For Each list In listnama
            ComboBox1.Items.Add(list)
        Next


    End Sub

    Private Sub BtnTambahAbsensi_Click(sender As Object, e As EventArgs) Handles BtnTambahAbsensi.Click


        FormAbsensi.absensi.TanggalProperty = DtpTanggal.Value.ToString("yyyy/MM/dd")
        'FormAbsensi.absensi.AbsenMasukProperty = DtpAbsenMasuk.Value.ToString("HH:mm:ss")
        FormAbsensi.absensi.AbsenKeluarProperty = DtpAbsenKeluar.Value.ToString("HH:mm:ss")

        'Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getAbsensiItem)
        FormAbsensi.absensi.namaProperty = ComboBox1.SelectedItem()
        FormAbsensi.absensi.AbsenKeluarDatabase(FormAbsensi.absensi.namaProperty,
                                                FormAbsensi.absensi.AbsenKeluarProperty)
        x = FormAbsensi.absensi.ngitung(FormAbsensi.absensi.namaProperty)
        If Integer.Parse(x.Hour) < 8 Then
            FormAbsensi.absensi.gajihPenalti(FormAbsensi.absensi.namaProperty)
        Else
            FormAbsensi.absensi.gajihFull(FormAbsensi.absensi.namaProperty)
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FormAbsensiKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class