Public Class EditJadwalTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadComboBoxFilmDatabase()
        ReloadComboBoxStudioDatabase()
        ComboBoxFilm.SelectedValue() = JadwalTayang.CJadwalTayang.id_filmProperty
        ComboBoxStudio.SelectedValue() = JadwalTayang.CJadwalTayang.id_studioProperty
        ' Add any initialization after the InitializeComponent() call.

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
End Class