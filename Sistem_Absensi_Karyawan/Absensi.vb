Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Absensi

    Private listabsensi As New List(Of String)
    Private selectedabsensi As String


    Private nama As String
    Private status As String
    Private tanggal As String
    Private absen_masuk As String
    Private absen_keluar As String
    Private ganti_status As String
    Private absensi_item As New List(Of String)


    'Private absensi As New ArrayList()

    'Private TripleDes As New TripleDESCryptoServiceProvider

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistemabsensikaryawan"

    Public ReadOnly Property getAbsensiItem() As List(Of String)
        Get
            Return absensi_item
        End Get
    End Property


    Public Property namaProperty() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property selectedabsensiProperty() As String
        Get
            Return selectedabsensi
        End Get
        Set(ByVal value As String)
            selectedabsensi = value
        End Set
    End Property

    Public Property TanggalProperty() As Date
        Get
            Return tanggal
        End Get
        Set(ByVal value As Date)
            tanggal = value
        End Set
    End Property

    Public Property AbsenMasukProperty() As String
        Get
            Return absen_masuk
        End Get
        Set(ByVal value As String)
            absen_masuk = value
        End Set
    End Property

    Public Property AbsenKeluarProperty() As String
        Get
            Return absen_keluar
        End Get
        Set(ByVal value As String)
            absen_keluar = value
        End Set
    End Property

    Public Property GantiStatusProperty() As String
        Get
            Return ganti_status
        End Get
        Set(ByVal value As String)
            ganti_status = value
        End Set
    End Property
    Public Property StatusGS() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

    Public Function ConvertAbsensiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToAbsensi(value As String)
        Dim arr() As String = value.Split("|")

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataAbsensiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT a.id_absensi AS 'ID',
                                k.nama_karyawan AS 'Nama Karyawan',
                                a.tanggal_absensi  AS 'Tanggal Absensi ',
                                a.waktu_absen_masuk AS 'Waktu Absen Masuk',
                                a.waktu_absen_keluar AS 'Waktu Absen Keluar',
                                s.nama_status AS 'Status Absen' 
                                FROM absensi a 
                                INNER JOIN karyawan k on a.id_karyawan=k.id_karyawan
                                INNER JOIN status s on a.id_status=s.id_status"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function AddDataAbsensiDatabase(nama As String,
                                          waktu_absen_masuk As String)
        Dim tgl = Date.Now.ToString("yyyy/MM/dd")

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "INSERT INTO absensi (id_karyawan, tanggal_absensi,
                           waktu_absen_masuk, id_status) VALUE(

               
                (select id_karyawan from karyawan where nama_karyawan='" & nama & "'),
                '" & tgl & "', 
                '" & waktu_absen_masuk & "', '2')"


        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()
        dbConn.Close()

        'ex As Exception
        '    Return ex.Message
        'Finally
        '    dbConn.Dispose()

        'End Try

    End Function

    Public Function AbsenKeluarDatabase(nama As String,
                                          waktu_absen_keluar As String)
        Dim tgl = Date.Now.ToString("yyyy/MM/dd")
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE absensi SET waktu_absen_keluar = '" & waktu_absen_keluar & "', id_status='3' " &
                   "WHERE id_karyawan=(select id_karyawan from karyawan where nama_karyawan='" & nama & "')" &
                   "AND tanggal_absensi='" & tgl & "' AND id_status = 2;"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()
        dbConn.Close()


    End Function

    Public Function Upt2DataAbsensiDatabase(
                                         ganti_status As String,
                                             ID As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE absensi SET id_status = '" & ganti_status & "' WHERE id_absensi = '" & ID & "'"


        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()
        dbConn.Close()


    End Function

    Public Function CmBnama() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama_karyawan FROM karyawan"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function CmBnamaKeluar() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama_karyawan FROM karyawan WHERE id_karyawan=(SELECT id_karyawan from absensi WHERE id_status=2)"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function



    Public Function getDataAbsensiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_absensi,
                                id_karyawan,
                                tanggal_absensi,
                                waktu_absen_masuk, 
                                waktu_absen_keluar,
                                id_status
                                FROM absensi 
                                WHERE id_absensi='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function DeleteDataAbsensiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM absensi WHERE id_absensi = '" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function ngitung(nama As String) As DateTime
        Dim tgl = Date.Now.ToString("yyyy/MM/dd")
        Dim abc As DateTime
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT TIMEDIFF(waktu_absen_keluar, waktu_absen_masuk) FROM absensi WHERE id_karyawan=(select id_karyawan from karyawan where nama_karyawan='" & nama & "') AND tanggal_absensi='" & tgl & "';"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            abc = sqlRead.GetString(0)
        End While

        sqlRead.Close()
        dbConn.Close()
        Return abc
    End Function
    Public Function gajihFull(nama As String)
        Dim tgl = Date.Now.ToString("yyyy/MM/dd")
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE absensi SET gajih=(SELECT gajih_perhari from jabatan WHERE id_jabatan=(SELECT id_jabatan FROM karyawan WHERE id_karyawan=(select id_karyawan from karyawan where nama_karyawan='" & nama & "'))) 
WHERE id_karyawan=(select id_karyawan from karyawan where nama_karyawan='" & nama & "') AND tanggal_absensi='" & tgl & "'"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()
        dbConn.Close()
    End Function
    Public Function gajihPenalti(nama As String)
        Dim tgl = Date.Now.ToString("yyyy/MM/dd")
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE absensi SET gajih=
                    (
                        (SELECT gajih_perhari from jabatan WHERE id_jabatan=
                            (SELECT id_jabatan FROM karyawan WHERE id_karyawan=
                                (select id_karyawan from karyawan where nama_karyawan='" & nama & "')))*(98/100))
                    WHERE id_karyawan=(select id_karyawan from karyawan where nama_karyawan='" & nama & "') AND tanggal_absensi='" & tgl & "'"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()
        dbConn.Close()
    End Function
    Public Function GetDataStatusDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_status as 'id_status', nama_status as 'nama_status' from status"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
End Class
