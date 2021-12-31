﻿Public Class Karyawan
    Public Shared Nambah As TambahKaryawan
    Public Shared UpdateData As Edit
    Public Shared fungsi As Fungsi
    Public Shared selectedData
    Public Shared selectedNamaData

    Public Sub New()
        fungsi = New Fungsi
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Nambah = New TambahKaryawan
        Nambah.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKaryawan.DataSource = fungsi.GetDataKaryawanDatabase()
    End Sub

    Private Sub DataGridKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKaryawan.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKaryawan.Rows(index)

        selectedData = selectedRow.Cells(0).Value
        selectedNamaData = selectedRow.Cells(2).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim column As List(Of String) = fungsi.GetDataKaryawanByIDDatabase(selectedData)

        fungsi.nikKaryawan = column(1)
        fungsi.namaKaryawan = column(2)
        fungsi.alamatKaryawan = column(3)
        fungsi.IDtojabatan = column(4)

        UpdateData = New Edit
        UpdateData.Show()

    End Sub

    Private Sub Karyawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formDelete = New Hapus()
        formDelete.Show()
    End Sub
End Class
