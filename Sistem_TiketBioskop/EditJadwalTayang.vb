Public Class EditJadwalTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadComboBoxFilmDatabase()
        ReloadComboBoxStudioDatabase()

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        ' Add any initialization after the InitializeComponent() call.

        ComboBoxFilm.SelectedValue() = JadwalTayang.CJadwalTayang.id_filmProperty
        ComboBoxStudio.SelectedItem() = JadwalTayang.CJadwalTayang.id_studioProperty.ToString()
        DateTimePicker1.Value = JadwalTayang.CJadwalTayang.tanggalProperty
        ComboBoxMulai.SelectedItem() = JadwalTayang.CJadwalTayang.waktu_mulaiProperty
        ComboBoxSelesai.SelectedItem() = JadwalTayang.CJadwalTayang.waktu_selesaiProperty

    End Sub

    Private Sub ReloadComboBoxFilmDatabase()
        Dim data_film As New DataTable()

        ComboBoxFilm.Items.Clear()
        data_film = JadwalTayang.CJadwalTayang.GetFilmDatabase()

        ComboBoxFilm.DataSource = data_film
        ComboBoxFilm.DisplayMember = "nama_film"
        ComboBoxFilm.ValueMember = "id_film"

    End Sub

    Private Sub ReloadComboBoxStudioDatabase()
        Dim data_studio As New List(Of String)

        ComboBoxStudio.Items.Clear()
        data_studio = JadwalTayang.CJadwalTayang.GetStudioDatabase()

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

        JadwalTayang.CJadwalTayang.UpdateDataJadwalByIDDatabase(JadwalTayang.SelectedTableJadwal,
                                                                JadwalTayang.CJadwalTayang.id_filmProperty,
                                                               JadwalTayang.CJadwalTayang.id_studioProperty,
                                                               JadwalTayang.CJadwalTayang.tanggalProperty,
                                                               JadwalTayang.CJadwalTayang.waktu_mulaiProperty,
                                                               JadwalTayang.CJadwalTayang.waktu_selesaiProperty
                                                                )
        Me.Close()
    End Sub

End Class