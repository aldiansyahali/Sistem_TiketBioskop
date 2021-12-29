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
End Class