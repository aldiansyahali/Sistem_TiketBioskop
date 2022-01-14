Public Class EditStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TxtBoxKapasitas.Text = Studio.ClassStudio.kapasitas_kursiproperty
        TxtBoxHarga.Text = Studio.ClassStudio.harga_kursiproperty
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub BtnEdit_Click_1(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Studio.ClassStudio.kapasitas_kursiproperty = TxtBoxKapasitas.Text.ToString()
        Studio.ClassStudio.harga_kursiproperty = TxtBoxHarga.Text.ToString()

        Studio.ClassStudio.UpdateDataKoleksiByIDDatabase(Studio.selectedTableKoleksi,
                                                         Studio.ClassStudio.kapasitas_kursiproperty,
                                                         Studio.ClassStudio.harga_kursiproperty)
        Me.Close()
    End Sub
End Class