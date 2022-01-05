Public Class Studio
    Public Shared CStudio As CStudio
    Public Shared SelectedTableStudio As String
    Public Shadows selectedTableNomorStudio As String
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

    Private Sub DGStudio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGStudio.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGStudio.Rows(index)

        SelectedTableStudio = selectedRow.Cells(0).Value
        selectedTableNomorStudio = selectedRow.Cells(1).Value
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

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If SelectedTableStudio IsNot Nothing Then
            Dim selectedStudio As List(Of String) = CStudio.GetDataStudioByIDDatabase(SelectedTableStudio)
            CStudio.kapasitasProperty = selectedStudio(1)
            CStudio.harga_kursiProperty = selectedStudio(2)

            Dim formEdit = New EditStudio()
            formEdit.Show()

            CStudio.UpdateDataStudioByIDDatabase(SelectedTableStudio,
                                                               CStudio.kapasitasProperty,
                                                               CStudio.harga_kursiProperty)
        Else
            MessageBox.Show("Tolong pilih salah satu tabel!")
        End If
    End Sub

    Private Sub Studio_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SignIn.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim form_hapus = New HapusStudio()
        form_hapus.Show()
    End Sub


End Class
