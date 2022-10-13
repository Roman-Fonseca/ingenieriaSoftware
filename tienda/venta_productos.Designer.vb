<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venta_productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblidProducto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblCantidadDisponible = New System.Windows.Forms.Label()
        Me.txtCantidadDisponible = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblidProducto
        '
        Me.lblidProducto.AutoSize = True
        Me.lblidProducto.Location = New System.Drawing.Point(29, 29)
        Me.lblidProducto.Name = "lblidProducto"
        Me.lblidProducto.Size = New System.Drawing.Size(63, 13)
        Me.lblidProducto.TabIndex = 0
        Me.lblidProducto.Text = "id_producto"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(29, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(42, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "nombre"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(29, 235)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(36, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "precio"
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(29, 188)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(50, 13)
        Me.lblUnidades.TabIndex = 3
        Me.lblUnidades.Text = "unidades"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(133, 26)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProducto.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(133, 188)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(133, 235)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(29, 281)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(133, 274)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 9
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(329, 295)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(75, 23)
        Me.btnVender.TabIndex = 10
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(29, 111)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(36, 13)
        Me.lblMarca.TabIndex = 11
        Me.lblMarca.Text = "marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(133, 111)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 12
        '
        'lblCantidadDisponible
        '
        Me.lblCantidadDisponible.AutoSize = True
        Me.lblCantidadDisponible.Location = New System.Drawing.Point(29, 154)
        Me.lblCantidadDisponible.Name = "lblCantidadDisponible"
        Me.lblCantidadDisponible.Size = New System.Drawing.Size(101, 13)
        Me.lblCantidadDisponible.TabIndex = 13
        Me.lblCantidadDisponible.Text = "Cantidad Disponible"
        '
        'txtCantidadDisponible
        '
        Me.txtCantidadDisponible.Location = New System.Drawing.Point(133, 154)
        Me.txtCantidadDisponible.Name = "txtCantidadDisponible"
        Me.txtCantidadDisponible.ReadOnly = True
        Me.txtCantidadDisponible.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadDisponible.TabIndex = 14
        '
        'venta_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 330)
        Me.Controls.Add(Me.txtCantidadDisponible)
        Me.Controls.Add(Me.lblCantidadDisponible)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.lblUnidades)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblidProducto)
        Me.Name = "venta_productos"
        Me.Text = "venta_productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblidProducto As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblUnidades As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnVender As System.Windows.Forms.Button
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadDisponible As System.Windows.Forms.Label
    Friend WithEvents txtCantidadDisponible As System.Windows.Forms.TextBox
End Class
