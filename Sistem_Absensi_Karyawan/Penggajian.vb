Public Class Penggajian
    Public Shared fungsi As Fungsi
    Public Shared selectedData
    Public Shared selectedNamaData
    Public Shared ubahGaji As EditGaji
    Public Sub New()
        fungsi = New Fungsi
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridGaji.DataSource = fungsi.GetDataGajiDatabase()
    End Sub
    Private Sub Penggajian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridGaji_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridGaji.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridGaji.Rows(index)

        selectedData = selectedRow.Cells(0).Value
        selectedNamaData = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim column As List(Of String) = fungsi.GetDataGajiByIDDatabase(selectedData)

        fungsi.namaKaryawan = column(1)
        fungsi.BulanGS = column(2)
        fungsi.TotalGajih = column(3)

        ubahGaji = New EditGaji
        ubahGaji.Show()
    End Sub
End Class