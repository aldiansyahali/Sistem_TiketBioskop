Public Class JadwalTayang
    Public Shared CJadwalTayang As CJadwalTayang
    Public Shared SelectedTableJadwal As String
    Public Shared selectedTableNomorJadwal As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        CJadwalTayang = New CJadwalTayang()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DGJadwalTayang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJadwalTayang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGJadwalTayang.Rows(index)

        SelectedTableJadwal = selectedRow.Cells(0).Value
        selectedTableNomorJadwal = selectedRow.Cells(1).Value
    End Sub


    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim Form_TambahJadwal_Tayang = New TambahJadwalTayang()
        Form_TambahJadwal_Tayang.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DGJadwalTayang.DataSource = CJadwalTayang.GetDataJadwalTayangDatabase()
    End Sub

    Private Sub JadwalTayang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnEditJadwal_Click(sender As Object, e As EventArgs) Handles BtnEditJadwal.Click
        If SelectedTableJadwal IsNot Nothing Then
            Dim selectedJadwal As List(Of String) = CJadwalTayang.GetDataJadwalByIDDatabase(SelectedTableJadwal)
            CJadwalTayang.id_filmProperty = selectedJadwal(1)
            CJadwalTayang.id_studioProperty = selectedJadwal(2)
            CJadwalTayang.tanggalProperty = selectedJadwal(3)
            CJadwalTayang.waktu_mulaiProperty = selectedJadwal(4)
            CJadwalTayang.waktu_selesaiProperty = selectedJadwal(5)

            Dim formEdit = New EditJadwalTayang()
            formEdit.Show()

            CJadwalTayang.UpdateDataJadwalByIDDatabase(SelectedTableJadwal,
                                                       CJadwalTayang.id_filmProperty,
                                                       CJadwalTayang.id_studioProperty,
                                                       CJadwalTayang.tanggalProperty,
                                                       CJadwalTayang.waktu_mulaiProperty,
                                                       CJadwalTayang.waktu_selesaiProperty)
        Else
            MessageBox.Show("Tolong pilih salah satu tabel!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hapus = New HapusJadwalTayang()
        hapus.Show()
    End Sub

    Private Sub StudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudioToolStripMenuItem.Click
        Dim studio = New Studio
        studio.Show()

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        SignIn.Show()
    End Sub
End Class