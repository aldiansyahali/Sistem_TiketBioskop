Public Class HapusStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelStudio.Text = Studio.SelectedTableStudio
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Studio.CStudio.DeleteDataStudioByIDDatabase(Studio.SelectedTableStudio)
        Me.Close()
    End Sub
End Class