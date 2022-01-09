Public Class Hapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblGaji.Text = Penggajian.SelectedGaji.ToString()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Penggajian.Gaji.RemoveGaji(Penggajian.SelectedGaji)
        Penggajian.Gaji.RemoveGajiDataTable(Penggajian.SelectedTabGaji)
        Me.Close()
    End Sub
End Class