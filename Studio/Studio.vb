Public Class Studio
    Public Shared ClassStudio As ClassStudio
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New()
        ClassStudio = New ClassStudio()
        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim form1 = New TambahStudio
        form1.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGrid.DataSource = ClassStudio.GetDataKoleksiDatabase()
    End Sub

    Private Sub Studio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGrid.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim SelectedKoleksi As List(Of String) = ClassStudio.GetDataKoleksiByIDDatabase(selectedTableKoleksi)
        ClassStudio.kapasitas_kursiproperty = SelectedKoleksi(1)
        ClassStudio.harga_kursiproperty = SelectedKoleksi(2)
        Dim form2 = New EditStudio
        form2.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim form3 = New HapusStudio
        form3.Show()
    End Sub
End Class
