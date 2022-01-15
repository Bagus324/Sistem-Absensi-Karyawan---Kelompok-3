Public Class FormAbsensi

    Public Shared absensi As Absensi

    Public Shared selectedabsensi As String
    Public Shared selectedTableAbsensi As String
    Public Shared selectedTableAbsensiNama As String
    Public Shared selectedTableAbsensiTanggal As String
    Public Shared selectedTableAbsensiStatus As String
    Public Shared x As DateTime
    Public Shared y
    Private selectedRow As DataGridViewRow
    Public Sub New()

        absensi = New Absensi()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
        If (DataGridViewAbsensi.Rows.Count > 0) Then
            DataGridViewAbsensi.Rows(0).Cells(0).Selected = True
            selectedRow = DataGridViewAbsensi.Rows(0)
            selectedTableAbsensi = selectedRow.Cells(0).Value
            absensi.namaProperty = selectedRow.Cells(1).Value
        End If
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


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedabsensi As List(Of String) = absensi.getDataAbsensiByIDDatabase(selectedTableAbsensi)


        absensi.AbsenKeluarProperty = selectedabsensi(3)
        absensi.AbsenKeluarProperty = selectedabsensi(4)

        Dim editabsen = New GantiStatusAbsensi()
        editabsen.Show()


    End Sub

    Private Sub DataGridViewAbsensi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAbsensi.CellClick
        Dim index As Integer = e.RowIndex
        If (index >= 0) Then
            selectedRow = DataGridViewAbsensi.Rows(index)
            selectedTableAbsensi = selectedRow.Cells(0).Value
            absensi.namaProperty = selectedRow.Cells(1).Value
            absensi.TanggalProperty = selectedRow.Cells(2).Value
            absensi.StatusGS = selectedRow.Cells(5).Value
        End If
    End Sub

    Private Sub AbsensiKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiKeluarToolStripMenuItem.Click
        Dim formabsensikeluar = New FormAbsensiKeluar()
        formabsensikeluar.Show()
    End Sub

    Private Sub BtnHapusAbsensi_Click(sender As Object, e As EventArgs) Handles BtnHapusAbsensi.Click
        Dim hapus = New HapusAbsensi()
        hapus.Show()
    End Sub
End Class