<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaVenta
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.DTPFecventa = New System.Windows.Forms.DateTimePicker()
        Me.LFecnac = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.NroVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerMas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(375, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 29)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(21, 39)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(158, 25)
        Me.LNombre.TabIndex = 22
        Me.LNombre.Text = "Buscar Cliente:"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(185, 44)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(169, 20)
        Me.TBBuscar.TabIndex = 21
        '
        'DTPFecventa
        '
        Me.DTPFecventa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecventa.Location = New System.Drawing.Point(626, 39)
        Me.DTPFecventa.Name = "DTPFecventa"
        Me.DTPFecventa.Size = New System.Drawing.Size(142, 20)
        Me.DTPFecventa.TabIndex = 26
        '
        'LFecnac
        '
        Me.LFecnac.AutoSize = True
        Me.LFecnac.BackColor = System.Drawing.Color.Transparent
        Me.LFecnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecnac.ForeColor = System.Drawing.Color.White
        Me.LFecnac.Location = New System.Drawing.Point(547, 34)
        Me.LFecnac.Name = "LFecnac"
        Me.LFecnac.Size = New System.Drawing.Size(84, 25)
        Me.LFecnac.TabIndex = 25
        Me.LFecnac.Text = "Fecha: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(375, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 29)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.BackColor = System.Drawing.Color.Transparent
        Me.LProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.ForeColor = System.Drawing.Color.White
        Me.LProducto.Location = New System.Drawing.Point(21, 149)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(177, 25)
        Me.LProducto.TabIndex = 28
        Me.LProducto.Text = "Buscar Producto:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(185, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 27
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroVenta, Me.Cliente, Me.Vendedor, Me.Fecha, Me.Total, Me.VerMas})
        Me.DGV1.Location = New System.Drawing.Point(-28, 275)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(931, 203)
        Me.DGV1.TabIndex = 30
        '
        'NroVenta
        '
        Me.NroVenta.HeaderText = "Nro Venta"
        Me.NroVenta.Name = "NroVenta"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'VerMas
        '
        Me.VerMas.HeaderText = "VerMas"
        Me.VerMas.Name = "VerMas"
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LProducto)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DTPFecventa)
        Me.Controls.Add(Me.LFecnac)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.TBBuscar)
        Me.Name = "NuevaVenta"
        Me.Text = "NuevaVenta"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents LNombre As Label
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents DTPFecventa As DateTimePicker
    Friend WithEvents LFecnac As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LProducto As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents NroVenta As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents VerMas As DataGridViewTextBoxColumn
End Class
