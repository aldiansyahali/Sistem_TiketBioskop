Public Class Tambah_Film

    Public Shared Bhs
    Public Shared Kategori As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
        Film.Koleksi.Harga_FilmProperty = TextBoxHargaFilm.Text.ToString()

        Dim convertedKoleksi = Film.Koleksi.ConvertKoleksiToString(Film.Koleksi.getKategoriItem)
        MessageBox.Show(convertedKoleksi)
        Film.Koleksi.AddKoleksiDatabase(Film.Koleksi.Judul_FilmProperty,
                                        Film.Koleksi.Harga_FilmProperty)
        'Buka Form Info Koleksi
        '==========================================================
        'Form_Perpustakaan.Koleksi.addKoleksi(TextBoxNama.Text)
        Dim InfoTambahKoleksi_form = New Film()
        Film.Show()
        Me.Close()

        'Form_Perpustakaan.Koleksi.addKoleksi(Form_Perpustakaan.Koleksi.Nama_KoleksiProperty)
    End Sub

    Private Sub RadioButtonIndo_CheckedChanged(sender As Object, e As EventArgs) Handles RB_BhsIndo.CheckedChanged
        Bhs = "Bahasa Indonesia"
    End Sub

    Private Sub RadioButtonIng_CheckedChanged(sender As Object, e As EventArgs) Handles RBBhs_Inggris.CheckedChanged
        Bhs = "Bahasa Inggris"
    End Sub
End Class