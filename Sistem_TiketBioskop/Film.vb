Public Class Film

    Public Shared Koleksi As Koleksi_Film
    Public Shared listkoleksi As New List(Of String)
    Public Shared selectedkoleksi As String
    Public Shared selectedTableKoleksi As String
    Public Shared selectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Koleksi = New Koleksi_Film()
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridViewFilm.DataSource = Koleksi.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim button_tambah = New Tambah_Film()
        button_tambah.Show()
    End Sub
    Private Sub Film_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub
    Public Sub UpdateDataTableArrayList()
        DataGridViewFilm.Rows.Clear()
        For Each rowKoleksi In Koleksi.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)}
            DataGridViewFilm.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub DataGridViewFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFilm.CellClick
        'selectedkoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewFilm.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If selectedTableKoleksi IsNot Nothing Then
            'MessageBox.Show(selectedTableKoleksi)

            Dim selectedkoleksi As List(Of String) = Koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            Koleksi.GambarFilmProperty = selectedkoleksi(2)
            Koleksi.Judul_FilmProperty = selectedkoleksi(1)
            Koleksi.GenreProperty = selectedkoleksi(3)
            Koleksi.DeskripsiProperty = selectedkoleksi(4)
            Koleksi.DirectorProperty = selectedkoleksi(5)
            Koleksi.DurationProperty = selectedkoleksi(6)
            Koleksi.Date_ReleasedProperty = selectedkoleksi(7)
            Koleksi.BahasaProperty = selectedkoleksi(8)
            Koleksi.Harga_FilmProperty = selectedkoleksi(9)

            Dim formupdate = New Edit_Film()
            Edit_Film.Show()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formHapus = New Hapus_Film()
        formHapus.Show()
    End Sub
End Class