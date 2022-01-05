Public Class Edit_Film

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBox1.Load(Film.Koleksi.GambarFilmProperty)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerReleased.Format = DateTimePickerFormat.Custom
        DateTimePickerReleased.CustomFormat = "yyyy/MM/dd"
        TextBoxJudulFilm.Text = Film.Koleksi.Judul_FilmProperty
        ComboBoxGenre.SelectedItem() = Film.Koleksi.GenreProperty
        RichTextBoxDeskripsi.Text = Film.Koleksi.DeskripsiProperty
        TextBoxDirector.Text = Film.Koleksi.DirectorProperty
        TextBoxDuration.Text = Film.Koleksi.DurationProperty
        DateTimePickerReleased.Value = Film.Koleksi.Date_ReleasedProperty
        TextBoxHargaFilm.Text = Film.Koleksi.Harga_FilmProperty

        If String.Compare(Film.Koleksi.BahasaProperty, "Bahasa Indonesia") = 0 Then
            RB_BhsIndo.Checked = True
        ElseIf String.Compare(Film.Koleksi.BahasaProperty, "Bahasa Inggris") = 0 Then
            RBBhs_Inggris.Checked = True
        End If
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        'Form_Perpustakaan.Koleksi.GambarBukuProperty = OpenFileDialog1.FileName
        Film.Koleksi.GambarFilmProperty = OpenFileDialog1.ToString()
        Film.Koleksi.GambarFilmProperty = Film.Koleksi.GambarFilmProperty.Replace("\", "/")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Film.Koleksi.Judul_FilmProperty = TextBoxJudulFilm.Text.ToString()
        Film.Koleksi.GenreProperty = ComboBoxGenre.SelectedItem().ToString()
        Film.Koleksi.DeskripsiProperty = RichTextBoxDeskripsi.Text.ToString()
        Film.Koleksi.DirectorProperty = TextBoxDirector.Text.ToString()
        Film.Koleksi.DurationProperty = TextBoxDuration.Text.ToString()
        Film.Koleksi.Date_ReleasedProperty = DateTimePickerReleased.Value.ToString("yyyy/MM/dd")
        Film.Koleksi.Harga_FilmProperty = TextBoxHargaFilm.Text.ToString()

        If RB_BhsIndo.Checked Then
            Film.Koleksi.BahasaProperty = "Bahasa Indonesia"
        ElseIf RBBhs_Inggris.Checked Then
            Film.Koleksi.BahasaProperty = "Bahasa Inggris"
        End If

        Dim ConvertedKoleksi = Film.Koleksi.ConvertKoleksiToString(Film.Koleksi.getKategoriItem)

        Film.Koleksi.UpdateDataKoleksiByIDDatabase(Film.selectedTableKoleksi,
                                                   Film.Koleksi.GambarFilmProperty,
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
End Class