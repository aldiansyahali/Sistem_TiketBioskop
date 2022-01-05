Public Class Tambah_Film

    Public Shared Bhs
    Public Shared Kategori As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerReleased.Format = DateTimePickerFormat.Custom
        DateTimePickerReleased.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    'Pictfoto1.Load(OpenFileDialog1.FileName)

        'End If

        OpenFileDialog1.ShowDialog()
        Dim pictfoto1Dir As String = OpenFileDialog1.FileName
        PictureBox1.Load(pictfoto1Dir)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'Form_Perpustakaan.Koleksi.GambarBukuProperty = OpenFileDialog1.FileName
        Film.Koleksi.GambarFilmProperty = pictfoto1Dir.ToString()
        Film.Koleksi.GambarFilmProperty = Film.Koleksi.GambarFilmProperty.Replace("\", "/")
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Film.Koleksi.Judul_FilmProperty = TextBoxJudulFilm.Text.ToString()
        Film.Koleksi.GenreProperty = ComboBoxGenre.SelectedItem().ToString()
        Film.Koleksi.DeskripsiProperty = RichTextBoxDeskripsi.Text.ToString()
        Film.Koleksi.DirectorProperty = TextBoxDirector.Text.ToString()
        Film.Koleksi.DurationProperty = TextBoxDuration.Text.ToString()
        Film.Koleksi.Date_ReleasedProperty = DateTimePickerReleased.Value.ToString("yyyy/MM/dd")
        Film.Koleksi.BahasaProperty = Bhs.ToString()
        Film.Koleksi.Harga_FilmProperty = TextBoxHargaFilm.Text.ToString()

        Dim convertedKoleksi = Film.Koleksi.ConvertKoleksiToString(Film.Koleksi.getKategoriItem)
        'MessageBox.Show(convertedKoleksi)
        Film.Koleksi.AddKoleksiDatabase(Film.Koleksi.GambarFilmProperty,
                                        Film.Koleksi.Judul_FilmProperty,
                                        Film.Koleksi.GenreProperty,
                                        Film.Koleksi.DeskripsiProperty,
                                        Film.Koleksi.DirectorProperty,
                                        Film.Koleksi.DurationProperty,
                                        Film.Koleksi.Date_ReleasedProperty,
                                        Film.Koleksi.BahasaProperty,
                                        Film.Koleksi.Harga_FilmProperty)

        Me.Close()
    End Sub

    Private Sub RB_BhsIndo_CheckedChanged(sender As Object, e As EventArgs) Handles RB_BhsIndo.CheckedChanged
        Bhs = "Bahasa Indonesia"
    End Sub

    Private Sub RBBhs_Inggris_CheckedChanged(sender As Object, e As EventArgs) Handles RBBhs_Inggris.CheckedChanged
        Bhs = "Bahasa Inggris"
    End Sub
End Class