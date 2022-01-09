Public Class FormAbsensi

    Public Shared absensi As Absensi

    Public Shared selectedabsensi As String
    Public Shared selectedTableAbsensi As String
    Public Shared selectedTableAbsensiNama As String
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

    Private Sub DataGridViewAbsensi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAbsensi.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridViewAbsensi.Rows(index)

        selectedTableAbsensi = selectedrow.Cells(0).Value
        selectedTableAbsensiNama = selectedrow.Cells(1).Value
    End Sub

    Private Sub AbsensiKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiKeluarToolStripMenuItem.Click
        Dim formabsensikeluar = New FormAbsensiKeluar()
        formabsensikeluar.Show()
    End Sub

    Private Sub GantiStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiStatusToolStripMenuItem.Click
        Dim gantistatus = New GantiStatusAbsensi()
        gantistatus.Show()
    End Sub
End Class