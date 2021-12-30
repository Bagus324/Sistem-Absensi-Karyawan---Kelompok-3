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
    Private Shared nama As String
    Private Shared nik As String
    Private Shared alamat As String
    Private Shared id_jabatan As String
    Private Shared jabatan As String
    Public Function AddDataKaryawanDatabase(nik As String,
                                        nama As String,
                                        alamat As String,
                                        id_jabatan As String
                                        )
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO data_karyawan (nik, nama, alamat, id_jabatan) VALUE ('" & nik & "', '" & nama & "', '" & alamat & "', '" & id_jabatan & "');"

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
    Public Function GetDataKaryawanDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT 
                                  d.id_karyawan AS 'ID',
                                  d.nik AS 'NIK',
                                  d.nama AS 'Nama Karyawan',
                                  d.alamat AS 'Alamat',
                                  j.nama_jabatan AS 'Jabatan'
                                  FROM data_karyawan d
                                  LEFT JOIN jabatan j ON d.id_jabatan = j.id_jabatan"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Property namaKaryawan() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property nikKaryawan() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property alamatKaryawan() As String
        Get
            Return alamat
        End Get
        Set(ByVal value As String)
            alamat = value
        End Set
    End Property
    Public Property jabatantoID() As String
        Get
            Return id_jabatan
        End Get
        Set(ByVal value As String)
            If value = "OB" Then
                id_jabatan = 1
            ElseIf value = "SO" Then
                id_jabatan = 2
            ElseIf value = "OM" Then
                id_jabatan = 3
            Else
                id_jabatan = 4
            End If
        End Set
    End Property

    Public Property IDtojabatan() As String
        Get
            Return jabatan
        End Get
        Set(ByVal value As String)
            If value = 1 Then
                id_jabatan = "OB"
            ElseIf value = 2 Then
                id_jabatan = "SO"
            ElseIf value = 3 Then
                id_jabatan = "OM"
            Else
                id_jabatan = "BM"
            End If
        End Set
    End Property
End Class
