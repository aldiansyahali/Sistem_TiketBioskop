Imports System.IO

Public Class SignUp
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtNama.Text.Length > 0 And TxtEmail.Text.Length > 0 And TxtPassword.Text.Length > 0 Then
            SignIn.Users.AddUsersDatabase(TxtNama.Text, TxtEmail.Text, TxtPassword.Text)
            Me.Close()

        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class