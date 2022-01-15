Public Class Penggajian
    Public Shared fungsi As Fungsi
    Public Shared selectedData
    Public Shared selectedNamaData
    Public Shared selectedBulanData
    Public Shared ubahGaji As EditGaji
    Public Shared tambahGaji As TambahGajih
    Public Shared hapusGajih As HapusGaji
    Private selectedRow As DataGridViewRow
    Public Sub New()
        fungsi = New Fungsi
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        If (DataGridGaji.Rows.Count > 0) Then
            DataGridGaji.Rows(0).Cells(0).Selected = True
            selectedRow = DataGridGaji.Rows(0)
            selectedData = selectedRow.Cells(0).Value
            selectedNamaData = selectedRow.Cells(2).Value
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridGaji.DataSource = fungsi.GetDataGajiDatabase()
    End Sub
    Private Sub Penggajian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridGaji_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridGaji.CellClick
        Dim index As Integer = e.RowIndex
        If (index >= 0) Then
            selectedRow = DataGridGaji.Rows(index)
            selectedData = selectedRow.Cells(0).Value
            selectedNamaData = selectedRow.Cells(1).Value
            selectedBulanData = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim column As List(Of String) = fungsi.GetDataGajiByIDDatabase(selectedData)

        fungsi.namaKaryawan = column(1)
        fungsi.BulanGS = column(2)
        fungsi.TotalGajih = column(3)

        ubahGaji = New EditGaji
        ubahGaji.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        tambahGaji = New TambahGajih
        tambahGaji.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        hapusGajih = New HapusGaji
        hapusGajih.Show()
    End Sub


End Class