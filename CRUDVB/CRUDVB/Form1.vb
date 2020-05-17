Public Class Form1

    Dim selectedRow As String 'Variable para guardar la row seleccionada'
    Dim modoEdicion As Boolean = 0 'Variable para saber si cuando demos en guardar la sentencia va a ser insert o update.'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llenar la tabla con todos los datos que tenemos en la BD:'
        dgvProductos.DataSource = Hacer_Consulta("SELECT ID, Nombre, Precio, Cantidad FROM item_table")
    End Sub

    Private Sub cerrar_ventana(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.Closing

        If MessageBox.Show("Seguro que quiere salir?", "Cerrar)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Cerrar()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub pboxProducto_Subir_Click(sender As Object, e As EventArgs) Handles pboxProducto_Subir.Click
        Dim imgpath As String 'dónde está la imagen que se va a subir'
        Try
            Dim OFD As FileDialog = New OpenFileDialog() 'Esto es lo que nos abre el menú de windows para seleccionar archivos.'

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif" 'Extensiones admitidas para que no te enchufen una reverse shell.'

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pboxProducto_Subir.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim arrImage() As Byte

        Dim mstream As New System.IO.MemoryStream()
        pboxProducto_Subir.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        Dim datosCompletos As Boolean = True

        If txtNombre.Text = "" Then
            MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datosCompletos = False
            Return
        End If

        If txtPrecio.Text = "" Then
            MessageBox.Show("Ingrese un precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datosCompletos = False
            Return
        End If

        If txtCantidad.Text = "" Then
            MessageBox.Show("Ingrese una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datosCompletos = False
            Return
        End If

        If datosCompletos Then
            Dim nombre As String = txtNombre.Text
            Dim precio As String = txtPrecio.Text
            Dim cantidad As String = txtCantidad.Text
            If modoEdicion = 0 Then
                Save(nombre, precio, cantidad, arrImage)
            Else
                Edit(txtID.Text, nombre, precio, cantidad, arrImage)
            End If


        End If

    End Sub

    Private Sub btnLimpiarTodo_Click(sender As Object, e As EventArgs) Handles btnLimpiarTodo.Click
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        pboxProducto_Subir.ImageLocation = Nothing
        modoEdicion = 0
    End Sub


    'Al hacer click en editar, mandar todos los datos del producto seleccionado a la sección de añadir y editar productos.'
    'Habría que crear algo para hacer que el boton guardar distinga entre añadir un nuevo registro y editar uno ya existente.'

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtNombre.Text = dgvProductos.Rows(selectedRow).Cells("Nombre").Value.ToString

        txtID.Text = dgvProductos.Rows(selectedRow).Cells("ID").Value.ToString

        txtPrecio.Text = String.Format(dgvProductos.Rows(selectedRow).Cells("Precio").Value.ToString).Replace(",", ".") 'Por alguna razón carga el decimal con , en vez de con . lo cual causa un error al ejecutar la query'

        txtCantidad.Text = dgvProductos.Rows(selectedRow).Cells("Cantidad").Value.ToString

        pboxProducto_Subir.Image = pboxProducto_seleccionado.Image

        modoEdicion = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Delete(dgvProductos.Rows(selectedRow).Cells("ID").Value.ToString)
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        dgvProductos.DataSource = Hacer_Consulta("SELECT ID, Nombre, Precio, Cantidad FROM item_table")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim filter As String = ""
        If chkID.Checked Then
            filter = "ID"
        ElseIf chkNombre.Checked Then
            filter = "Nombre"
        Else
            filter = "Nombre"
        End If

        'Llenar la tabla con el filtro y el contenido especificado 
        'Al nombre le ponemos LIKE ya que no tiene que ser estricta la busqueda, pero con la ID si y por eso ponemos =
        If filter.Equals("Nombre") Then
            dgvProductos.DataSource = Hacer_Consulta("SELECT ID, Nombre, Precio, Cantidad FROM item_table WHERE " + filter + " LIKE '%\" + txtBuscar.Text + "%'")
        ElseIf filter.Equals("ID") Then
            dgvProductos.DataSource = Hacer_Consulta("SELECT ID, Nombre, Precio, Cantidad FROM item_table WHERE " + filter + "='" + txtBuscar.Text + "'")
        End If

    End Sub

    Private Sub dgvProductos_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductos.CellMouseDown
        Try
            If e.Button = MouseButtons.Left Then
                dgvProductos.CurrentCell = dgvProductos(e.ColumnIndex, e.RowIndex)
                Dim i As Integer
                With dgvProductos
                    i = .CurrentRow.Index
                    Dim id As String = .Rows(i).Cells("ID").Value.ToString
                    selectedRow = i
                    Dim query As String = "SELECT * FROM item_table WHERE ID='" + id + "'"
                    pboxProducto_seleccionado.Image = Mostrar_Img(Hacer_Consulta(query))
                End With
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

End Class
