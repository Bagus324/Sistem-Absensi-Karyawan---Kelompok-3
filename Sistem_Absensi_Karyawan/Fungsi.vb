Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Fungsi
    'Database Global Variabel
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "karyawan"
    'sampe sini
    '======================================================
    'GS
    Private Shared foto As String
    Public Function AddDataKaryawanDatabase(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As Date,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String
                                        )
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO karyawan(nama_koleksi, dir_gambar, 
                        deskripsi, penerbit, jenis_koleksi, 
                        tahun_terbit, lokasi, tanggal_masuk_koleksi, 
                        stock, bahasa, kategori) VALUE(
                        '" & nama_koleksi &
                        "', '" & dir_gambar &
                        "', '" & deskripsi_koleksi &
                        "', '" & penerbit_koleksi &
                        "', '" & jenis_koleksi &
                        "', '" & tahun_terbit &
                        "', '" & lokasi_rak &
                        "', '" & tglmsk &
                        "', '" & stock_koleksi &
                        "', '" & bahasa_koleksi &
                        "', '" & kategori_koleksi &
                        "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Property fotoKaryawan() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property
End Class
