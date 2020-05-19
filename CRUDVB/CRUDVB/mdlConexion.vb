Imports System.Configuration
Imports System.IO
Imports MySql.Data
Module mdlConexion 'Con este modulo manejamos todo lo que tiene que ver con SQL'
    Public conn As New MySqlClient.MySqlConnection

    'Método para conectarnos a la BD'
    Public Sub Conectar(connection_string As String)
        Try
            conn.ConnectionString = connection_string
            conn.Open()
            'MsgBox("Base de datos: " + conn.Database) <<--- MOSTRAR LA BD QUE ESTAMOS USANDO
        Catch ex As MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Cerrar conexión'
    Public Sub Cerrar()
        conn.Close()
    End Sub

    'Retornamos los datos de la conexión como String'
    Public Function CONNECTION_STRING() As String
        Dim myConnectionString As String = ConfigurationManager.ConnectionStrings("MySqlConnectionString").ToString() 'Connection string está encriptado en App.config :) https://stackoverflow.com/questions/11637348/encrypt-connection-string-in-app-config
        Return myConnectionString
    End Function


End Module
