Public Class FormAbsensi

    Public Shared absensi As Absensi

    Public Shared selectedkoleksi As String
    Public Sub New()

        absensi = New Absensi()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub



    Private Sub FormAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub


    Private Sub ReloadDataTableDatabase()
        DataGridViewAbsensi.DataSource = absensi.GetDataAbsensiDatabase()
    End Sub
    Private Sub AbsensiMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiMasukToolStripMenuItem.Click
        Dim formabsensimasuk = New FormAbsensiMasuk()
        formabsensimasuk.Show()
    End Sub

    'Private Sub ListBoxAbsensi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAbsensi.SelectedIndexChanged
    '    selectedkoleksi = ListBoxAbsensi.SelectedItem
    'End Sub


End Class