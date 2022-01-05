Public Class JadwalTayang
    Public Shared CJadwalTayang As CJadwalTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        CJadwalTayang = New CJadwalTayang()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub JadwalTayang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SignIn.Show()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim Form_TambahJadwal_Tayang = New TambahJadwalTayang()
        Form_TambahJadwal_Tayang.Show()
    End Sub
End Class