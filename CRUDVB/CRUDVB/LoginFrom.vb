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
        Dim usr As String = txtUsuario.Text
        Dim pwd As String = txtPwd.Text
        Dim creds_ok = Ingresar(usr, pwd)
        If creds_ok Then
            MsgBox("Logeado con exito!")
        Else
            MsgBox("Usuario o contraseña no encontrados")
        End If
    End Sub


    Private Sub btnRegistrarme_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarme.Click
        Dim NomYAp As String = txtNomAp.Text
        Dim correo As String = txtCrearCorreo.Text
        Dim usr As String = txtCrearUsr.Text
        Dim pwd As String = txtCrearContrasena.Text
        Console.WriteLine(NomYAp)
        Console.WriteLine(correo)
        Console.WriteLine(usr)
        Console.WriteLine(pwd)
        Registrar_usr(usr, correo, pwd, NomYAp)
    End Sub
End Class