Public Class Hapus_Film
    Private namafilm As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        namafilm = Film.selectedTableKoleksiNama.ToString()
        LabelNamaFilm.Text = namafilm
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ''Film.Koleksi.RemoveKoleksi(namafilm)
        'Film.selectedkoleksi = ""
        Film.Koleksi.RemoveDataKoleksiByIDDatabase(Film.selectedTableKoleksi)

        Me.Close()
    End Sub
End Class