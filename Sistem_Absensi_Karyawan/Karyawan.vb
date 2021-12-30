Public Class Karyawan
    Public Shared Nambah As TambahKaryawan
    Public Shared fungsi As Fungsi
    Public Shared selectedTabKoleksi
    Public Shared selectedTabKoleksiNama

    Public Sub New()
        Nambah = New TambahKaryawan
        fungsi = New Fungsi
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Nambah.show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKaryawan.DataSource = fungsi.GetDataKaryawanDatabase()
    End Sub

    Private Sub DataGridKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKaryawan.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKaryawan.Rows(index)

        selectedTabKoleksi = selectedRow.Cells(0).Value
        selectedTabKoleksiNama = selectedRow.Cells(1).Value
    End Sub
End Class
