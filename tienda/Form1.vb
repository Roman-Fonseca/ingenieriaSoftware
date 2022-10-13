Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1

    'Dim conexion As New MySqlConnection("server=localhost; database=tienda; user id=root; password=root")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            conexion.ConexionMySQL()
            MsgBox("conexion exitosa")

        Catch ex As Exception
            MsgBox("conexion fallida")
            GloconexionDB.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCargarTabla.Click
        Dim conexion As New MySqlConnection("server=ROMAN ;DataBase=tienda;user id=rootdos;password=rootroot12345")
        'conexion.ConexionMySQL()
        Dim adaptador As MySqlDataAdapter
        Dim tablaDatos As DataTable
        Dim consultaSQl As String

        Try
            consultaSQl = "SELECT * FROM productos"
            adaptador = New MySqlDataAdapter(consultaSQl, conexion)
            tablaDatos = New DataTable
            adaptador.Fill(tablaDatos)
            tablaProductos.DataSource = tablaDatos
        Catch ex As Exception
            MsgBox("Fallo al cargar la tabla")
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnVender.Click
        moduloProducto.ConsultarProductoModificar()
        GLO_CodProductoModificar = tablaProductos.SelectedRows.Item(0).Cells(0).Value
        venta_productos.txtIdProducto.Enabled = False
        venta_productos.Show()
    End Sub
End Class
