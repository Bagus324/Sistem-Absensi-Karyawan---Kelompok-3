Public Class infoupdategaji
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Lblidk.Text = Penggajian.Gaji.idkaryawanProperty
        Lblidb.Text = Penggajian.Gaji.idbulanProperty
        Lblttg.Text = Penggajian.Gaji.totalgajihProperty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Penggajian.Gaji.idkaryawanProperty = ""
        Penggajian.Gaji.idbulanProperty = ""
        Penggajian.Gaji.totalgajihProperty = ""

        Penggajian.Gaji.getGajiItem.Clear()
        Me.Close()
    End Sub
End Class