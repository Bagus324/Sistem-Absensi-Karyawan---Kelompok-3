Public Class GantiStatusAbsensi
    Private dataStatus As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TBNama.Text = FormAbsensi.absensi.namaProperty
        dataStatus = FormAbsensi.absensi.GetDataStatusDatabase()
        ComboBoxStatus.DataSource = dataStatus
        ComboBoxStatus.DisplayMember = "nama_status"
        If FormAbsensi.selectedTableAbsensiStatus = 3 Then
            ComboBoxStatus.SelectedIndex = 1
        Else
            ComboBoxStatus.SelectedIndex = 0
        End If
        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub BtnStatus_Click(sender As Object, e As EventArgs) Handles BtnStatus.Click
        FormAbsensi.absensi.GantiStatusProperty = dataStatus.Rows(ComboBoxStatus.SelectedIndex)("id_status")
        MessageBox.Show(FormAbsensi.absensi.namaProperty)


        'Dim convertedAbsensi = FormAbsensi.absensi.ConvertAbsensiToString(FormAbsensi.absensi.getAbsensiItem)

        FormAbsensi.absensi.Upt2DataAbsensiDatabase(FormAbsensi.absensi.GantiStatusProperty, FormAbsensi.selectedTableAbsensi)
        Me.Close()
    End Sub

    Private Sub GantiStatusAbsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class