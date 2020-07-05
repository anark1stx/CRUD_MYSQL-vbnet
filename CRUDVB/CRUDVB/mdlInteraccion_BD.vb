Imports MySql.Data
Imports MySql.Data.MySqlClient

Module mdlInteraccion_BD


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

        cmd.Parameters.Clear()
        Cerrar()
    End Sub

    Public Function Ingresar(usr As String, pwd As String) As Boolean
        Conectar(CONNECTION_STRING())
        Dim ok As Boolean = False
        Dim cmd As New MySqlCommand
        Dim buscar = "SELECT nombre_usuario FROM usuarios WHERE nombre_usuario=@usr"
        With cmd
            .Connection = conn
            .CommandText = buscar
            .Parameters.AddWithValue("@usr", usr)
            Dim r As Integer
            r = .ExecuteNonQuery()
            If r = 0 Then
                Console.WriteLine("usr no existe!!")
                Cerrar()
                ok = False
                Return False
            Else
                Console.WriteLine(.CommandText)
                Console.WriteLine("usr existe!!")
                ok = True
            End If
        End With
        cmd.Parameters.Clear()

        If ok = True Then

            Dim hash As String = ""
            buscar = "SELECT contrasena FROM usuarios WHERE nombre_usuario=@usr"
            With cmd
                .Connection = conn
                .CommandText = buscar
                .Parameters.AddWithValue("@usr", usr)

                Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()
                While sqlReader.Read()
                    hash = sqlReader("contrasena").ToString()
                    Console.WriteLine("la contrasena es: " + hash)
                End While

                Dim okpwd As Boolean = BCrypt.Net.BCrypt.Verify(pwd, hash) 'Este método verifica la contraseña ingresada con el hash desencriptado automáticamente.

                If okpwd Then
                    Console.WriteLine("Correcto!!")
                    Return True
                Else
                    Console.WriteLine("incorrecto!!")
                    Return False
                End If
            End With
        Else
            Return 0
        End If
        Cerrar()
        cmd.Parameters.Clear()
    End Function


    Public Sub Registrar_usr(usr As String, email As String, pwd As String, nom_ap As String)

        Dim rounds As Integer = 13
        Dim contrasena_encriptada = BCrypt.Net.BCrypt.HashPassword(pwd, rounds)
        pwd = contrasena_encriptada

        Conectar(CONNECTION_STRING())
        Dim cmd As New MySqlCommand

        'Dim insert = "INSERT INTO usuarios(nombre_usuario,email,contrasena,nombre_apellido) VALUES (@nombre_usuario, @email, @contrasena @nombre_apellido)"

        Dim insert = "INSERT INTO usuarios(nombre_usuario,email,contrasena,nombre_apellido) VALUES (" + "'" + usr + "'" + "," + "'" + email + "'" + "," + "'" + pwd + "'" + "," + "'" + nom_ap + "'" + ")"
        'Console.WriteLine(wtf)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        Cerrar()

        'No esta funcionando el método que use antes por alguna razón mitica XD:
        'With cmd
        ' .Connection = conn
        ' .CommandText = insert
        ' .Parameters.AddWithValue("@nombre_usuario", usr)
        ' .Parameters.AddWithValue("@email", "'" + email + "'")
        ' .Parameters.AddWithValue("@contrasena", "'" + pwd + "'")
        ' .Parameters.AddWithValue("@nombre_apellido", nom_ap)
        ' Dim r As Integer
        'Console.WriteLine("usuario: " + usr + " correo: " + email + " contrasena: " + pwd + "nombre y apellido: " + nom_ap)
        ' r = .ExecuteNonQuery()
        ' If r > 0 Then
        ' MsgBox("Usuario registrado")
        ' Else
        ' MsgBox("El usuario no fue registrado")
        ' End If
        ' End With



    End Sub

End Module
