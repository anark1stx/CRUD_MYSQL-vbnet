Imports System.IO
Imports MySql.Data
Module mdMYSQL 'Con este modulo manejamos todo lo que tiene que ver con SQL'
    Dim conn As New MySqlClient.MySqlConnection

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
        Dim myConnectionString As String
        myConnectionString = "server=127.0.0.1;" _
            & "uid=mateo;" _
            & "pwd=123;" _
            & "database=item_db"
        Return myConnectionString
    End Function

    'Le pasamos la query por String y llenamos el datagridview de los productos.'
    Public Function Hacer_Consulta(query As String) As DataTable
        Conectar(CONNECTION_STRING())
        Console.WriteLine(query)
        Dim data As New DataTable
        Dim querySQL As New MySqlClient.MySqlCommand
        querySQL.CommandType = CommandType.Text
        querySQL.CommandText = query
        Dim adpt As New MySqlClient.MySqlDataAdapter(querySQL.CommandText, conn)
        adpt.Fill(data)
        Cerrar()
        Return data
    End Function
    Public Function Mostrar_Img(data As DataTable) As Image
        Dim arrImage() As Byte
        arrImage = data.Rows(0).Item("Imagen")
        Dim mstream As New System.IO.MemoryStream(arrImage)
        Return Image.FromStream(mstream)
    End Function

    Public Sub Save(nombre As String, precio As String, cantidad As String, img As Byte())

        Conectar(CONNECTION_STRING())

        Dim cmd As New MySqlClient.MySqlCommand

        Dim insert = "INSERT INTO item_table(Nombre,Precio, Cantidad, Imagen) VALUES (@Nombre, @Precio, @Cantidad, @Imagen)"

        With cmd
            .Connection = conn
            .CommandText = insert
            .Parameters.AddWithValue("@Nombre", nombre)
            .Parameters.AddWithValue("@Precio", precio)
            .Parameters.AddWithValue("@Cantidad", cantidad)
            .Parameters.AddWithValue("@Imagen", img)
            Dim r As Integer
            r = .ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Producto guardado")
            Else
                MsgBox("El producto no fue guardado")
            End If
        End With


        cmd.Parameters.Clear()
        Cerrar()
    End Sub

    Public Sub Edit(id As String, nombre As String, precio As String, cantidad As String, img As Byte())

        Conectar(CONNECTION_STRING())

        Dim cmd As New MySqlClient.MySqlCommand

        Dim update = "UPDATE item_table SET Nombre=@Nombre, Precio=@Precio, Cantidad=@Cantidad, Imagen=@Imagen WHERE ID=@ID"

        With cmd
            .Connection = conn
            .CommandText = update
            .Parameters.AddWithValue("@ID", id)
            .Parameters.AddWithValue("@Nombre", nombre)
            .Parameters.AddWithValue("@Precio", precio)
            .Parameters.AddWithValue("@Cantidad", cantidad)
            .Parameters.AddWithValue("@Imagen", img)
            Dim r As Integer
            r = .ExecuteNonQuery()
            If r > 0 Then
                MsgBox("El producto fue editado")
            Else
                MsgBox("El producto no fue editado")
            End If
        End With


        cmd.Parameters.Clear()
        Cerrar()
    End Sub

    Public Sub Delete(id As String)
        Conectar(CONNECTION_STRING())

        Dim cmd As New MySqlClient.MySqlCommand

        Dim delete = "DELETE FROM item_table WHERE ID=@ID"

        With cmd
            .Connection = conn
            .CommandText = delete
            .Parameters.AddWithValue("@ID", id)
            Dim r As Integer
            r = .ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Producto eliminado")
            Else
                MsgBox("El producto no fue eliminado")
            End If
        End With
        Cerrar()
    End Sub

End Module
