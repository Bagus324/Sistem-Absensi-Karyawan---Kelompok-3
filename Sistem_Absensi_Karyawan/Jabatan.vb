Public Class Jabatan
    Public Shared fungsi As Fungsi
    Public Shared addJabatan As TambahJabatan
    Public Shared editJabatan As EditJabatan
    Public Shared selectedData
    Public Shared selectedDataJabatan
    Public Sub New()
        fungsi = New Fungsi
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        addJabatan = New TambahJabatan
        addJabatan.Show()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridJabatan.DataSource = fungsi.GetDataJabatanDatabase()
    End Sub

    Private Sub Jabatan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridJabatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJabatan.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridJabatan.Rows(index)

        selectedData = selectedRow.Cells(0).Value
        selectedDataJabatan = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim column As List(Of String) = fungsi.GetDataJabatanByIDDatabase(selectedData)

        fungsi.namaJabatanGS = column(1)
        fungsi.gajihJabatan = column(2)

        editJabatan = New EditJabatan
        editJabatan.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formDelete = New HapusJabatan()
        formDelete.Show()
    End Sub
End Class