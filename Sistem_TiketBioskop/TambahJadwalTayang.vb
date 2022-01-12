Imports System.IO
Public Class TambahJadwalTayang
    Public Shared CJadwalTayang As CJadwalTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        CJadwalTayang = New CJadwalTayang()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TambahJadwalTayang_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReloadComboBoxFilmDatabase()
        ReloadComboBoxStudioDatabase()
    End Sub

    Private Sub ReloadComboBoxFilmDatabase()
        Dim data_film As New DataTable()

        ComboBoxFilm.Items.Clear()
        data_film = CJadwalTayang.GetFilmDatabase()

        ComboBoxFilm.DataSource = data_film
        ComboBoxFilm.DisplayMember = "nama_film"
        ComboBoxFilm.ValueMember = "id_film"
        ComboBoxFilm.SelectedIndex = -1

    End Sub

    Private Sub ReloadComboBoxStudioDatabase()
        Dim data_studio As New List(Of String)

        ComboBoxStudio.Items.Clear()
        data_studio = CJadwalTayang.GetStudioDatabase()

        For Each studio In data_studio
            ComboBoxStudio.Items.Add(studio)
        Next
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        JadwalTayang.CJadwalTayang.id_filmProperty = ComboBoxFilm.SelectedValue()
        JadwalTayang.CJadwalTayang.id_studioProperty = ComboBoxStudio.SelectedItem()
        JadwalTayang.CJadwalTayang.tanggalProperty = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        JadwalTayang.CJadwalTayang.waktu_mulaiProperty = ComboBoxMulai.SelectedItem().ToString()
        JadwalTayang.CJadwalTayang.waktu_selesaiProperty = ComboBoxSelesai.SelectedItem().ToString()

        JadwalTayang.CJadwalTayang.AddDataJadwalTayangDatabase(JadwalTayang.CJadwalTayang.id_filmProperty,
                                                               JadwalTayang.CJadwalTayang.id_studioProperty,
                                                               JadwalTayang.CJadwalTayang.tanggalProperty,
                                                               JadwalTayang.CJadwalTayang.waktu_mulaiProperty,
                                                               JadwalTayang.CJadwalTayang.waktu_selesaiProperty
                                                                )
        Me.Close()
    End Sub

End Class