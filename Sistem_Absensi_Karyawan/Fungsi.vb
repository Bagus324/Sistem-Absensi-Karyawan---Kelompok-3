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
    Private database As String = "sistemabsensikaryawan"
    'sampe sini
    '======================================================
    'GS
    Private Shared nama As String
    Private Shared nik As String
    Private Shared alamat As String
    Private Shared namaJabatan As String
    Private Shared gajih As String
    Private Shared tgajih As String
    Private Shared bulan As String
    '==================================================Penggajigan=================================
    Public Function GetDataGajiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_data, id_karyawan, id_bulan, total_gajih FROM penggajian"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataGajiByIDDatabase(ID As Integer) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_data, id_karyawan, id_bulan, total_gajih FROM penggajian WHERE id_data='" & ID & "';"

            sqlRead = sqlCommand.ExecuteReader
            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
            End While
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
    Public Function ngitung(ID As Integer) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT waktu_absen_masuk, waktu_absen_keluar FROM absensi WHERE id_absensi='13';"

            sqlRead = sqlCommand.ExecuteReader
            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
            End While
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
    '==================================================KARYAWAN====================================
    Public Function AddDataKaryawanDatabase(nik As String,
                                        nama As String,
                                        alamat As String,
                                        jabatan As String
                                        )
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO karyawan (nik, nama_karyawan, alamat, id_jabatan) VALUE ('" & nik & "', '" & nama & "', '" & alamat &
            "', (SELECT id_jabatan FROM jabatan WHERE nama_jabatan='" & jabatan & "'));"

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
                                  d.nama_karyawan AS 'Nama Karyawan',
                                  d.alamat AS 'Alamat',
                                  j.nama_jabatan AS 'Jabatan'
                                  FROM karyawan d
                                  LEFT JOIN jabatan j ON d.id_jabatan = j.id_jabatan"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataKaryawanByIDDatabase(ID As Integer) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT d.id_karyawan,
                                  d.nik, 
                                  d.nama_karyawan, 
                                  d.alamat, 
                                  j.nama_jabatan
                                  FROM karyawan d JOIN jabatan j
                                  ON d.id_jabatan=j.id_jabatan WHERE id_karyawan='" & ID & "';"

            sqlRead = sqlCommand.ExecuteReader
            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
                result.Add(sqlRead.GetString(4).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
    Public Function UpdateDataKaryawanByIDDatabase(ID As Integer,
                                                  nik As String,
                                                  nama As String,
                                                  alamat As String,
                                                  jabatan As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE karyawan SET " &
                       "nik='" & nik & "', " &
                       "nama_karyawan='" & nama & "', " &
                       "alamat='" & alamat & "', " &
                       "id_jabatan=(SELECT id_jabatan FROM jabatan WHERE nama_jabatan='" & jabatan & "') " &
                       "WHERE id_karyawan=" & ID


        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()
    End Function
    Public Function DeleteDataByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM karyawan WHERE id_karyawan = '" & ID & "'"

            Debug.WriteLine(sqlQuery)

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
    '============================================JABATAN===================================================
    Public Function AddDataJabatanDatabase(gajih As String,
                                           nama As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jabatan (nama_jabatan, gajih_perhari) VALUE ('" & nama & "', '" & gajih & "');"

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
    Public Function GetDataJabatanDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jabatan, nama_jabatan, gajih_perhari FROM jabatan"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function CmBJabatan() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama_jabatan FROM jabatan"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataJabatanByIDDatabase(ID As Integer) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_jabatan, nama_jabatan, gajih_perhari FROM jabatan WHERE id_jabatan='" & ID & "';"
            sqlRead = sqlCommand.ExecuteReader
            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
    Public Function UpdateDataJabatanByIDDatabase(ID As Integer,
                                                  nama As String,
                                                  gajih As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE jabatan SET " &
                       "nama_jabatan='" & nama & "', " &
                       "gajih_perhari='" & gajih & "' " &
                       "WHERE id_jabatan=" & ID

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()
    End Function
    Public Function DeleteDataJabatanByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jabatan WHERE id_jabatan = '" & ID & "'"

            Debug.WriteLine(sqlQuery)

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
    '==============================================GS======================================================
    Public Property namaKaryawan() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property
    Public Property namaJabatanGS() As String
        Get
            Return namaJabatan
        End Get
        Set(ByVal value As String)
            namaJabatan = value
        End Set
    End Property
    Public Property gajihJabatan() As String
        Get
            Return gajih
        End Get
        Set(ByVal value As String)
            gajih = value
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
    Public Property TotalGajih() As String
        Get
            Return tgajih
        End Get
        Set(ByVal value As String)
            tgajih = value
        End Set
    End Property
    Public Property BulanGS() As String
        Get
            Return bulan
        End Get
        Set(ByVal value As String)
            bulan = value
        End Set
    End Property
End Class
