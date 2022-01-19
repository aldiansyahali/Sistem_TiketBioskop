Imports System.IO
Public Class TambahStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Studio.CStudio.kapasitasProperty = Integer.Parse(TxtKapasitas.Text)
        Studio.CStudio.harga_kursiProperty = Integer.Parse(TxtHargaKursi.Text)


        Studio.CStudio.AddDataStudioDatabase(Studio.CStudio.kapasitasProperty,
                                             Studio.CStudio.harga_kursiProperty)

        Me.Close()

    End Sub

    Private Sub TxtKapasitas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKapasitas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtHargaKursi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaKursi.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub
End Class