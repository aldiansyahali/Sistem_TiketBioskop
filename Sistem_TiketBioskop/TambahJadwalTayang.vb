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
        ComboBoxFilm.DisplayMember = "film"
        ComboBoxFilm.ValueMember = "id"
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

End Class