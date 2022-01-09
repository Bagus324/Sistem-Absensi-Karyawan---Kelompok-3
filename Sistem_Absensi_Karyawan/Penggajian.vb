Public Class Penggajian

    Public Shared Gaji As Gaji

    Public Shared SelectedGaji As String
    Public Shared SelectedTabGaji As String
    Public Shared SelectedTabGajiNama As String

    Public Sub New()
        Gaji = New Gaji()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = Gaji.GetDataGajiDatabase()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus = New Hapus()
        Hapus.Show()
    End Sub

    Private Sub btnHitungGaji_Click(sender As Object, e As EventArgs) Handles btnHitungGaji.Click
        Dim Hitung = New Hitung()
        Hitung.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedgaji As List(Of String) = Gaji.getDataGajiByIDDatabase(SelectedTabGaji)

        Gaji.idkaryawanProperty = selectedgaji(1)
        Gaji.idbulanProperty = selectedgaji(2)
        Gaji.totalgajihProperty = selectedgaji(3)

        Dim Ubah = New Ubah()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        SelectedTabGaji = selectedRow.Cells(0).Value
        SelectedTabGajiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub Penggajian_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class