Public Class EditGaji
    Private dataBulan As DataTable
    Private dataNama As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TBGajih.Text = Penggajian.fungsi.TotalGajih
        TbNama.Text = Penggajian.selectedNamaData
        TbBulan.Text = Penggajian.selectedBulanData
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Penggajian.fungsi.TotalGajih = TBGajih.Text
        Penggajian.fungsi.EditTotalGaji(Penggajian.selectedData, Penggajian.fungsi.TotalGajih)
        Me.Close()
    End Sub


End Class