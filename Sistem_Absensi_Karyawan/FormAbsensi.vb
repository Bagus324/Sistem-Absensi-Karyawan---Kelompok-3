Public Class FormAbsensi

    Public Shared absensi As Absensi

    Public Shared selectedabsensi As String
    Public Shared selectedTableAbsensi As String
    Public Sub New()

        absensi = New Absensi()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub



    Private Sub FormAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub


    Private Sub ReloadDataTableDatabase()
        DataGridViewAbsensi.DataSource = absensi.GetDataAbsensiDatabase()
    End Sub
    Private Sub AbsensiMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiMasukToolStripMenuItem.Click
        Dim formabsensimasuk = New FormAbsensiMasuk()
        formabsensimasuk.Show()
    End Sub

    Private Sub BtnTampilan_Click(sender As Object, e As EventArgs) Handles BtnTampilan.Click
        Dim selectedabsensi As List(Of String) = absensi.getDataAbsensiByIDDatabase(selectedTableAbsensi)

        absensi.namaProperty = selectedabsensi(1)
        absensi.TanggalProperty = selectedabsensi(2)
        absensi.AbsenKeluarProperty = selectedabsensi(3)
        absensi.AbsenKeluarProperty = selectedabsensi(4)


        Dim info = New InfoAbsensi
        info.Show()
        Me.Close()

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedabsensi As List(Of String) = absensi.getDataAbsensiByIDDatabase(selectedTableAbsensi)

        absensi.namaProperty = selectedabsensi(1)
        absensi.TanggalProperty = selectedabsensi(2)
        absensi.AbsenKeluarProperty = selectedabsensi(3)
        absensi.AbsenKeluarProperty = selectedabsensi(4)

        Dim editabsen = New GantiStatusAbsensi()
        editabsen.Show()


    End Sub
End Class