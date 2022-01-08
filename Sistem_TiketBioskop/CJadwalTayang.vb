Imports MySql.Data.MySqlClient
Imports System.Text
Public Class CJadwalTayang
    Private id_film As Integer
    Private id_studio As Integer
    Private tanggal As String
    Private waktu_mulai As String
    Private waktu_selesai As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "tiket_bioskop"


    Public Property id_filmProperty() As Integer
        Get
            Return id_film
        End Get
        Set(ByVal value As Integer)
            id_film = value
        End Set
    End Property
    Public Property id_studioProperty() As Integer
        Get
            Return id_studio
        End Get
        Set(ByVal value As Integer)
            id_studio = value
        End Set
    End Property

    Public Property tanggalProperty() As String
        Get
            Return tanggal
        End Get
        Set(ByVal value As String)
            tanggal = value
        End Set
    End Property

    Public Property waktu_mulaiProperty() As String
        Get
            Return waktu_mulai
        End Get
        Set(ByVal value As String)
            waktu_mulai = value
        End Set
    End Property

    Public Property waktu_selesaiProperty() As String
        Get
            Return waktu_selesai
        End Get
        Set(ByVal value As String)
            waktu_selesai = value
        End Set
    End Property


    Public Function GetStudioDatabase() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id
                                    FROM studio"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

        Return result
    End Function

    Public Function GetFilmDatabase() As DataTable
        Dim result As New DataTable()

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_film, nama_film
                                    FROM film"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

        Return result
    End Function

    Public Function AddDataJadwalTayangDatabase(id_film As Integer,
                                            id_studio As Integer,
                                            tanggal As Date,
                                            waktu_mulai As String,
                                            waktu_selesai As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jadwal_tayang(id_film, id_studio, tanggal,
                        waktu_mulai, waktu_selesai) VALUE('" _
                        & id_film & "', '" _
                        & id_studio & "', '" _
                        & tanggal.ToString("yyyy/MM/dd") & "', '" _
                        & waktu_mulai & "', '" _
                        & waktu_selesai & "')"

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

        Return 0
    End Function

    Public Function GetDataJadwalTayangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT j.id_jadwal_tayang as ID, f.nama_film AS Film,
                                s.id AS studio, j.waktu_mulai AS 'Waktu Mulai',
                                j.waktu_selesai AS 'Waktu Selesai' FROM jadwal_tayang j
	                            INNER JOIN film f ON j.id_film = f.id_film
	                            INNER JOIN studio s ON j.id_studio = s.id"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
End Class
