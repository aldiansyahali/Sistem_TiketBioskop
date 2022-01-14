Public Class TambahStudio
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Studio.ClassStudio.kapasitas_kursiproperty = TxtBoxKapasitas.Text.ToString()
        Studio.ClassStudio.harga_kursiproperty = TxtBoxHarga.Text.ToString()

        Studio.ClassStudio.AddDataKoleksiDatabase(Studio.ClassStudio.kapasitas_kursiproperty, Studio.ClassStudio.harga_kursiproperty)

        Me.Close()

    End Sub

End Class