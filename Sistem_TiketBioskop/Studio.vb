Public Class Studio
    Public Shared CStudio As CStudio
    Public Sub New()

        ' This call is required by the designer.
        CStudio = New CStudio()

        InitializeComponent()

        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Studio_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DGStudio.DataSource = CStudio.GetDataStudioDatabase()
    End Sub

    Private Sub TambahStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahStudioToolStripMenuItem.Click
        Dim form_tambah = New TambahStudio
        form_tambah.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah_studio = New TambahStudio
        tambah_studio.Show()
    End Sub

End Class
