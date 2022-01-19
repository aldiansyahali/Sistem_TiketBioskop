Public Class SignIn
    Public Shared Studio As Studio
    Public Shared Users As Users

    Public Sub New()

        InitializeComponent()
        Users = New Users
        Studio = New Studio
    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim plainEmail As String = TxtEmail.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainEmail, plainPassword)

        If data_user.Count > 0 Then
            Users.emailProperty = data_user(1)
            Studio.Show()
            Me.Hide()
        Else
            MessageBox.Show("Kombinasi Email dan Password Salah")
        End If
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim form_register = New SignUp
        form_register.Show()
    End Sub
End Class