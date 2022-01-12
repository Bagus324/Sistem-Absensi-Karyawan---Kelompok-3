Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Gaji

    Private Listgaji As New List(Of String)
    Private selectedgaji As String
    Private gajiDataTable As New ArrayList()

    Private id_karyawan As String
    Private id_bulan As String
    Private total_gajih As Integer
    Private gajih As New List(Of String)

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistemabsensikaryawan"

    Public Function RemoveGajiDataTable(index As Integer)
        gajiDataTable.Remove(index)
    End Function

    Public Function RemoveGaji(Value As String)
        Listgaji.Remove(Value)
        Return ""
    End Function

    Public Property idkaryawanProperty() As String
        Get
            Return id_karyawan
        End Get
        Set(ByVal value As String)
            id_karyawan = value
        End Set
    End Property

    Public Property idbulanProperty() As String
        Get
            Return id_bulan
        End Get
        Set(ByVal value As String)
            id_bulan = value
        End Set
    End Property

    Public Property totalgajihProperty() As String
        Get
            Return total_gajih
        End Get
        Set(ByVal value As String)
            total_gajih = value
        End Set
    End Property

    Public Function ConvertGajiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to String.
        Dim res = builder.ToString()
        Return res
    End Function

    Public ReadOnly Property getGajiItem() As List(Of String)
        Get
            Return gajih
        End Get
    End Property

    Public Function resetgajih()
        gajih.Clear()
        Return ""
    End Function

    Public Function GetDataGajiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_Karyawan AS 'id_karyawan',
                                id_bulan AS 'id_bulan',
                                total_gajih  AS 'total_gajih '
                                FROM penggajian"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function getDataGajiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan,
                                id_bulan,
                                total_gajih
                                FROM penggajian
                                WHERE id_karyawan='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())


        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataGajiByIDDatabase(id_karyawan As String,
                                                  id_bulan As String,
                                                  total_gajih As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET" &
                "id_karyawan ='" & id_karyawan & "', " &
                "id_bulan ='" & id_bulan & "', " &
                "total_gajih ='" & total_gajih & "', " &
                "WHERE id_gaji ='" & id_karyawan & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)


        dbConn.ConnectionString = "Server =" + server + ";" + "User id =" + username + ";" + "Password =" + password + ";" + "Database =" + database

        'Try
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "DELETE FROM Gaji " &
                "WHERE id_karyawan ='" & ID & "'"

        Debug.WriteLine(sqlQuery)

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        'Perpustakaan.sqlDt.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()


        'Catch ex As Exception
        'Return ex.Message
        'Finally
        'dbConn.Dispose()
        'End Try
    End Function

End Class
