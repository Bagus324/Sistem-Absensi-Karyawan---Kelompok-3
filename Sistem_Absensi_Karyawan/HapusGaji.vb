Public Class HapusGaji
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblNama.Text = Penggajian.selectedNamaData
        LblBln.Text = Penggajian.selectedBulanData

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnHapusGajih_Click(sender As Object, e As EventArgs) Handles BtnHapusGajih.Click
        Penggajian.fungsi.DeleteGajihByIDDatabase(Penggajian.selectedData)
        Me.Close()
    End Sub
End Class