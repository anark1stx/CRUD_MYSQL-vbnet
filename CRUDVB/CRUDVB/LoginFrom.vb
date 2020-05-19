Public Class LoginFrom

    Private Sub LoginFrom_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub btnRegistrarses_Click(sender As Object, e As EventArgs) Handles btnRegistrarses.Click
        trsLogintoRegister.Hide(pnlLogin)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        trsLogintoRegister.Show(pnlLogin)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As String = txtUsuario.Text
        Dim password As String = txtPwd.Text

    End Sub
End Class