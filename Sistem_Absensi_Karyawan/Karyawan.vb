Public Class Karyawan
    Public Shared Nambah As TambahKaryawan
    Public Shared UpdateData As EditKaryawan
    Public Shared fungsi As Fungsi
    Public Shared selectedData
    Public Shared selectedNamaData
    Private selectedRow As DataGridViewRow

    Public Sub New()
        fungsi = New Fungsi
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        If (DataGridKaryawan.Rows.Count > 0) Then
            DataGridKaryawan.Rows(0).Cells(0).Selected = True
            selectedRow = DataGridKaryawan.Rows(0)
            selectedData = selectedRow.Cells(0).Value
            selectedNamaData = selectedRow.Cells(2).Value
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Nambah = New TambahKaryawan
        Nambah.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKaryawan.DataSource = fungsi.GetDataKaryawanDatabase()
    End Sub

    Private Sub DataGridKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKaryawan.CellClick
        Dim index As Integer = e.RowIndex
        If (index >= 0) Then
            selectedRow = DataGridKaryawan.Rows(index)
            selectedData = selectedRow.Cells(0).Value
            selectedNamaData = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim column As List(Of String) = fungsi.GetDataKaryawanByIDDatabase(selectedData)
        fungsi.nikKaryawan = column(1)
        fungsi.namaKaryawan = column(2)
        fungsi.alamatKaryawan = column(3)
        fungsi.namaJabatanGS = column(4)

        UpdateData = New EditKaryawan
        UpdateData.Show()

    End Sub

    Private Sub Karyawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formDelete = New HapusKaryawan()
        formDelete.Show()
    End Sub


End Class
