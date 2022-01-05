Public Class FormAbsensi

    Public Shared absensi As Absensi

    Public Shared selectedkoleksi As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub FormAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ListBoxAbsensi.Items.Clear()
        ReloadDataTableDatabase()
    End Sub


    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = absensi.GetDataAbsensiDatabase
    End Sub
    Private Sub AbsensiMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiMasukToolStripMenuItem.Click
        Dim formabsensimasuk = New FormAbsensiMasuk()
        formabsensimasuk.Show()
    End Sub

    Private Sub ListBoxAbsensi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAbsensi.SelectedIndexChanged
        selectedkoleksi = ListBoxAbsensi.SelectedItem
    End Sub


End Class