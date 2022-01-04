Public Class EditStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtKapasitas.Text = Studio.CStudio.kapasitasProperty
        TxtHargaKursi.Text = Studio.CStudio.harga_kursiProperty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Studio.CStudio.kapasitasProperty = Integer.Parse(TxtKapasitas.Text)
        Studio.CStudio.harga_kursiProperty = Integer.Parse(TxtHargaKursi.Text)

        Studio.CStudio.UpdateDataStudioByIDDatabase(Studio.SelectedTableStudio,
                                                    Studio.CStudio.kapasitasProperty,
                                                    Studio.CStudio.harga_kursiProperty)
        Me.Close()
    End Sub
End Class