Imports MySql.Data.MySqlClient
Public Class CJadwalTayang
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "tiket_bioskop"


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
End Class
