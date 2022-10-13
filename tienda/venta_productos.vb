Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class venta_productos
    Public precio As Double = 0
    Public cantidad As Double = 0
    Public total As Double = 0


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblidProducto.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblPrecio.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblUnidades.Click

    End Sub

    Private Sub venta_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtUnidades.LostFocus
        If Me.txtUnidades.Text <> "" Then
            If IsNumeric(Me.cantidad) Then
                cantidad = Convert.ToDouble(Me.txtUnidades.Text)
            ElseIf Me.txtUnidades.Text = "" Then
                MsgBox("Precio Costo no es valido")
            End If
            precio = Convert.ToDouble(Me.txtPrecio.Text)
            total = precio * cantidad
            Me.txtTotal.Text = Convert.ToString(total)


        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtUnidades.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        'Conexion funciona
        Dim Conn As MySqlConnection = New MySqlConnection("server=ROMAN ; DataBase= tienda; user id= rootdos; password =rootroot12345")
        Conn.Open()

        Dim myTransaccion As MySqlTransaction

        Dim Comando As MySqlClient.MySqlCommand

        myTransaccion = Conn.BeginTransaction()

        Dim id_productos As Integer = Convert.ToInt16(Me.txtIdProducto.Text)
        'Dim nombre As String = Me.txtNombre.Text
        'Dim marca As String = Me.txtMarca.Text
        'Dim precio As String = Me.txtPrecio.Text
        Dim cantidadDisponible As Double = Convert.ToDouble(Me.txtCantidadDisponible.Text)
        Dim unidades As Double = Convert.ToDouble(Me.txtUnidades.Text)
        Dim LOC_consulta As String

        'Dim cantidadDisponibleNUM As Double = cantidadDisponible - unidades

        'Las siguientes lineas sirven para comprobar que la cantidad de productos por vender no superen a los productos en stock'
        Dim sql As String = " SELECT cantidad FROM productos WHERE id_productos= '" & Me.txtIdProducto.Text & "'"
        Dim cmd As New MySqlCommand(sql, Conn)
        cmd.Parameters.AddWithValue("id_productos", Convert.ToInt32(Me.txtIdProducto.Text))
        Dim temp As Object = cmd.ExecuteScalar()

        If temp IsNot Nothing Then

            Dim cant As Integer = Convert.ToInt32(temp)

            If Convert.ToInt32(Me.txtUnidades.Text) > cant Then
                MessageBox.Show("No se puede realizar la compra ya que excede")
            Else
                Try
                    LOC_consulta = "update productos set productos.cantidad=productos.cantidad- '" & txtUnidades.Text & "' where id_productos= '" & id_productos & "'"

                    Comando = New MySqlClient.MySqlCommand(LOC_consulta, Conn)

                    Comando.Transaction = myTransaccion

                    Comando.ExecuteNonQuery()



                    myTransaccion.Commit()

                    MsgBox("Datos Ingresados")

                Catch ex As Exception

                    myTransaccion.Rollback()

                    MsgBox(ex.Message)

                End Try

                Conn.Close()
            End If

        End If


        'Try
        'LOC_consulta = "update productos set productos.cantidad=productos.cantidad- '" & txtUnidades.Text & "' where id_productos= '" & id_productos & "'"
        '
        'Comando = New MySqlClient.MySqlCommand(LOC_consulta, Conn)

        'Comando.Transaction = myTransaccion

        'Comando.ExecuteNonQuery()



        'myTransaccion.Commit()

        'MsgBox("Datos Ingresados")

        'Catch ex As Exception

        'myTransaccion.Rollback()

        'MsgBox(ex.Message)

        'End Try

        'Conn.Close()



    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblMarca.Click

    End Sub
End Class