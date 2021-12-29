Public Class Hapus_Film
    Private NamaFilm As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        NamaFilm = Film.selectedTableKoleksiNama.ToString()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ''Form_Perpustakaan.Koleksi.RemoveKoleksi(namakoleksi)
        'Form_Perpustakaan.selectedkoleksi = ""
        Film.Koleksi.RemoveDataKoleksiByIDDatabase(Film.selectedTableKoleksi)

        Me.Close()
    End Sub
End Class