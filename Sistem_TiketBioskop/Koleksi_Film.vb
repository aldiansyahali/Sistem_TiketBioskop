Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Koleksi_Film

    Private Judul_Film As String
    Private GambarFilm As String
    Private Genre As String
    Private Deskripsi As String
    Private Director As String
    Private Duration As String
    Private Date_Released As String
    Private Bahasa As String
    Private Harga_Film As String
    Private Kategori As New List(Of String)
    Private listkoleksi As New List(Of String)

    'Database Global Variable
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "tiket_bioskop"

    Public Property Judul_FilmProperty() As String
        Get
            Return Judul_Film
        End Get
        Set(ByVal value As String)
            Judul_Film = value
        End Set
    End Property

    Public Property GambarFilmProperty() As String
        Get
            Return GambarFilm
        End Get
        Set(ByVal value As String)
            GambarFilm = value
        End Set
    End Property

    Public Property GenreProperty() As String
        Get
            Return Genre
        End Get
        Set(ByVal value As String)
            Genre = value
        End Set
    End Property

    Public Property DeskripsiProperty() As String
        Get
            Return Deskripsi
        End Get
        Set(ByVal value As String)
            Deskripsi = value
        End Set
    End Property

    Public Property DirectorProperty() As String
        Get
            Return Director
        End Get
        Set(ByVal value As String)
            Director = value
        End Set
    End Property

    Public Property DurationProperty() As String
        Get
            Return Duration
        End Get
        Set(ByVal value As String)
            Duration = value
        End Set
    End Property

    Public Property Date_ReleasedProperty() As String
        Get
            Return Date_Released
        End Get
        Set(ByVal value As String)
            Date_Released = value
        End Set
    End Property

    Public Property BahasaProperty() As String
        Get
            Return Bahasa
        End Get
        Set(ByVal value As String)
            Bahasa = value
        End Set
    End Property

    Public Property Harga_FilmProperty() As String
        Get
            Return Harga_Film
        End Get
        Set(ByVal value As String)
            Harga_Film = value
        End Set
    End Property

    Public Function AddKategori(value As String)
        Kategori.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return Kategori
        End Get
    End Property

    Public Function SetKategori(kategori_data As List(Of String)) As List(Of String)
        Kategori = kategori_data
    End Function

    Public Function resetKategori()
        Kategori.Clear()
    End Function

    Public Function addKoleksi(value As String)
        listkoleksi.Add(value)
        Return ""
    End Function

    Public Function RemoveKoleksi(value As String)
        listkoleksi.Remove(value)
        Return ""
    End Function

    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listkoleksi
        End Get
    End Property

    Public Function AddKoleksiDataTable(GambarFilm As String,
                                        Judul_Film As String,
                                        Genre As String,
                                        Deskripsi As String,
                                        Director As String,
                                        Duration As String,
                                        Date_Released As String,
                                        Bahasa As String,
                                        Harga_Film As String)

        koleksiDataTable.Add({GambarFilm,
                             Judul_Film,
                             Genre,
                             Deskripsi,
                             Director,
                             Duration,
                             Date_Released,
                             Bahasa,
                             Harga_Film})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "Server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_film As 'ID',
                                  nama_film As 'Judul Film',
                                  genre As 'Genre Film',
                                  deskripsi As 'Deskripsi',
                                  director As 'Director',
                                  duration As 'Duration',
                                  date_released As 'Tanggal Rilis',
                                  bahasa As 'Bahasa',
                                  harga_film As 'Harga Film'
                                  FROM film"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddKoleksiDatabase(GambarFilm As String,
                                       Judul_Film As String,
                                       Genre As String,
                                       Deskripsi As String,
                                       Director As String,
                                       Duration As String,
                                       Date_Released As String,
                                       Bahasa As String,
                                       Harga_Film As String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
                + "password =" + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "insert into film (nama_film, gambarfilm, genre, deskripsi, director, duration,
                        date_released, bahasa, harga_film) value ('" _
                        & Judul_Film & "', '" _
                        & GambarFilm & "', '" _
                        & Genre & "', '" _
                        & Deskripsi & "', '" _
                        & Director & "', '" _
                        & Duration & "', '" _
                        & Date_Released & "', '" _
                        & Bahasa & "', '" _
                        & Harga_Film & "')"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "Server =" + server + ";" + "user id =" + username + ";" _
                                   + "password =" + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_film,
                                  nama_film,
                                  gambarfilm,
                                  genre,
                                  deskripsi,
                                  director,
                                  duration,
                                  date_released,
                                  bahasa,
                                  harga_film
                                  FROM film
                                  WHERE id_film='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  GambarFilm As String,
                                                  Judul_Film As String,
                                                  Genre As String,
                                                  Deskripsi As String,
                                                  Director As String,
                                                  Duration As String,
                                                  Date_Released As String,
                                                  Bahasa As String,
                                                  Harga_Film As String)

        dbConn.ConnectionString = "Server =" + server + ";" + "user id =" + username + ";" _
                                   + "password =" + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE film SET " &
                       "nama_film='" & Judul_Film & "', " &
                       "gambarfilm='" & GambarFilm & "', " &
                       "genre='" & Genre & "', " &
                       "deskripsi='" & Deskripsi & "', " &
                       "director='" & Director & "', " &
                       "duration='" & Duration & "', " &
                       "date_released='" & Date_Released & "', " &
                       "bahasa='" & Bahasa & "', " &
                       "harga_film='" & Harga_Film & "' " &
                       "WHERE id_film='" & ID & "'"

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

    Public Function RemoveDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "Server =" + server + ";" + "user id =" + username + ";" _
                                  + "password =" + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE From film " &
                       "WHERE id_film='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
