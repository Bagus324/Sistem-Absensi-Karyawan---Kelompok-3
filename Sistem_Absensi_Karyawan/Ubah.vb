Public Class Ubah
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtkaryawan.Text = Penggajian.Gaji.idkaryawanProperty
        txtbulan.Text = Penggajian.Gaji.idbulanProperty
        txttotal.Text = Penggajian.Gaji.totalgajihProperty
        Penggajian.Gaji.resetgajih()

    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        Penggajian.Gaji.idkaryawanProperty = txtkaryawan.Text.ToString()
        Penggajian.Gaji.idbulanProperty = txtbulan.Text.ToString()
        Penggajian.Gaji.totalgajihProperty = txttotal.Text.ToString()

        Dim convertedgaji = Penggajian.Gaji.ConvertGajiToString(Penggajian.Gaji.getGajiItem)

        Penggajian.Gaji.UpdateDataGajiByIDDatabase(Penggajian.SelectedTabGaji,
                                                   Penggajian.Gaji.idkaryawanProperty,
                                                   Penggajian.Gaji.idbulanProperty,
                                                   Penggajian.Gaji.totalgajihProperty,
                                                   convertedgaji)

        Dim infoupdate = New infoupdategaji()
        infoupdate.Show()

        Me.Close()
    End Sub

End Class