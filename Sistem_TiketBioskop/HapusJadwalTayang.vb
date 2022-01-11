Public Class HapusJadwalTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LabelJadwal.Text = JadwalTayang.SelectedTableJadwal
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        JadwalTayang.CJadwalTayang.DeleteDataJadwalByIDDatabase(JadwalTayang.SelectedTableJadwal)
        Me.Close()
    End Sub
End Class