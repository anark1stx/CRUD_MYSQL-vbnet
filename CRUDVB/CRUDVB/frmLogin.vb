Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NomYAp As String = txtCrearNombre.Text
        Dim correo As String = txtCrearCorreo.Text
        Dim usr As String = txtCrearUsuario.Text
        Dim pwd As String = txtCrearContrasena.Text
        Console.WriteLine(NomYAp)
        Console.WriteLine(correo)
        Console.WriteLine(usr)
        Console.WriteLine(pwd)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class