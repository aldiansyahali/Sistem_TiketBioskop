Public Class HapusStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        lblStudio.Text = Studio.selectedTableKoleksi
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Studio.ClassStudio.DeleteDataKoleksiByIDDatabase(Studio.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class