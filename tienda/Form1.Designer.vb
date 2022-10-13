<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnCargarTabla = New System.Windows.Forms.Button()
        Me.tablaProductos = New System.Windows.Forms.DataGridView()
        Me.btnVender = New System.Windows.Forms.Button()
        CType(Me.tablaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(26, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(94, 23)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnCargarTabla
        '
        Me.btnCargarTabla.Location = New System.Drawing.Point(328, 12)
        Me.btnCargarTabla.Name = "btnCargarTabla"
        Me.btnCargarTabla.Size = New System.Drawing.Size(94, 23)
        Me.btnCargarTabla.TabIndex = 1
        Me.btnCargarTabla.Text = "Cargar_tabla"
        Me.btnCargarTabla.UseVisualStyleBackColor = True
        '
        'tablaProductos
        '
        Me.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaProductos.Location = New System.Drawing.Point(12, 84)
        Me.tablaProductos.Name = "tablaProductos"
        Me.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaProductos.Size = New System.Drawing.Size(424, 206)
        Me.tablaProductos.TabIndex = 2
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(12, 312)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(94, 23)
        Me.btnVender.TabIndex = 3
        Me.btnVender.Text = "Vender Producto"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 347)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.tablaProductos)
        Me.Controls.Add(Me.btnCargarTabla)
        Me.Controls.Add(Me.btnConectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tablaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents btnCargarTabla As System.Windows.Forms.Button
    Friend WithEvents tablaProductos As System.Windows.Forms.DataGridView
    Friend WithEvents btnVender As System.Windows.Forms.Button

End Class
