Module moduloProducto
    Public GLO_CodProductoModificar As Integer

    Public Sub ConsultarProductoModificar()

        GLO_CodProductoModificar = Form1.tablaProductos.SelectedRows.Item(0).Cells(0).Value
        Dim Consulta As String = "Select * from productos where id_productos= " & GLO_CodProductoModificar


        If Conexion.ConexionMySQL() Then
            Glocomando.CommandText = Consulta
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader


            Dim dt As New DataTable
            dt.Load(Glodatareader)


            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            Try
                venta_productos.txtIdProducto.Text = Trim((CStr(row("id_productos"))))
                venta_productos.txtNombre.Text = Trim((CStr(row("nombre"))))
                venta_productos.txtMarca.Text = Trim((CStr(row("marca"))))
                venta_productos.txtCantidadDisponible.Text = ((CStr(row("cantidad"))))
                venta_productos.txtPrecio.Text = ((CStr(row("precio"))))
                'venta_productos.txtCantidad.Text = ((CStr(row("cantidad"))))
                
                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If
    End Sub
End Module
