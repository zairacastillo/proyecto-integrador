<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarMisVentas
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LDni1 = New System.Windows.Forms.Label()
        Me.LVende1 = New System.Windows.Forms.Label()
        Me.LVende = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DVGDetalleFac = New System.Windows.Forms.DataGridView()
        Me.DVentas = New System.Windows.Forms.DataGridView()
        Me.ID_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI_Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver_mas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(516, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIS VENTAS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(972, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Vendedor/a"
        '
        'LDni1
        '
        Me.LDni1.AutoSize = True
        Me.LDni1.BackColor = System.Drawing.Color.Transparent
        Me.LDni1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni1.ForeColor = System.Drawing.Color.White
        Me.LDni1.Location = New System.Drawing.Point(910, 86)
        Me.LDni1.Name = "LDni1"
        Me.LDni1.Size = New System.Drawing.Size(81, 20)
        Me.LDni1.TabIndex = 92
        Me.LDni1.Text = "________"
        '
        'LVende1
        '
        Me.LVende1.AutoSize = True
        Me.LVende1.BackColor = System.Drawing.Color.Transparent
        Me.LVende1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVende1.ForeColor = System.Drawing.Color.White
        Me.LVende1.Location = New System.Drawing.Point(1045, 58)
        Me.LVende1.Name = "LVende1"
        Me.LVende1.Size = New System.Drawing.Size(81, 20)
        Me.LVende1.TabIndex = 93
        Me.LVende1.Text = "________"
        '
        'LVende
        '
        Me.LVende.AutoSize = True
        Me.LVende.BackColor = System.Drawing.Color.Transparent
        Me.LVende.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVende.ForeColor = System.Drawing.Color.White
        Me.LVende.Location = New System.Drawing.Point(1045, 102)
        Me.LVende.Name = "LVende"
        Me.LVende.Size = New System.Drawing.Size(81, 20)
        Me.LVende.TabIndex = 91
        Me.LVende.Text = "________"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 57)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Buscar Fecha "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.White
        Me.LFechaH.Location = New System.Drawing.Point(118, 212)
        Me.LFechaH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(68, 13)
        Me.LFechaH.TabIndex = 99
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.White
        Me.LFechaD.Location = New System.Drawing.Point(116, 169)
        Me.LFechaD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(71, 13)
        Me.LFechaD.TabIndex = 98
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(204, 206)
        Me.DTPHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(83, 20)
        Me.DTPHasta.TabIndex = 97
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(204, 169)
        Me.DTPDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(83, 20)
        Me.DTPDesde.TabIndex = 96
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(838, 479)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DVGDetalleFac
        '
        Me.DVGDetalleFac.AllowUserToAddRows = False
        Me.DVGDetalleFac.AllowUserToDeleteRows = False
        Me.DVGDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDetalleFac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Precio_Unitario, Me.Cantidad, Me.Subtotal})
        Me.DVGDetalleFac.Location = New System.Drawing.Point(633, 255)
        Me.DVGDetalleFac.Margin = New System.Windows.Forms.Padding(2)
        Me.DVGDetalleFac.Name = "DVGDetalleFac"
        Me.DVGDetalleFac.ReadOnly = True
        Me.DVGDetalleFac.RowHeadersWidth = 51
        Me.DVGDetalleFac.RowTemplate.Height = 24
        Me.DVGDetalleFac.Size = New System.Drawing.Size(554, 209)
        Me.DVGDetalleFac.TabIndex = 102
        '
        'DVentas
        '
        Me.DVentas.AllowUserToAddRows = False
        Me.DVentas.AllowUserToDeleteRows = False
        Me.DVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Factura, Me.DNI_Vendedor, Me.DNI_Cliente, Me.Fecha, Me.Total, Me.Ver_mas})
        Me.DVentas.Location = New System.Drawing.Point(-50, 255)
        Me.DVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.DVentas.Name = "DVentas"
        Me.DVentas.ReadOnly = True
        Me.DVentas.RowHeadersWidth = 51
        Me.DVentas.RowTemplate.Height = 24
        Me.DVentas.Size = New System.Drawing.Size(653, 209)
        Me.DVentas.TabIndex = 100
        '
        'ID_Factura
        '
        Me.ID_Factura.HeaderText = "ID_Factura"
        Me.ID_Factura.Name = "ID_Factura"
        Me.ID_Factura.ReadOnly = True
        '
        'DNI_Vendedor
        '
        Me.DNI_Vendedor.HeaderText = "DNI_Vendedor"
        Me.DNI_Vendedor.Name = "DNI_Vendedor"
        Me.DNI_Vendedor.ReadOnly = True
        '
        'DNI_Cliente
        '
        Me.DNI_Cliente.HeaderText = "DNI_Cliente"
        Me.DNI_Cliente.Name = "DNI_Cliente"
        Me.DNI_Cliente.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Ver_mas
        '
        Me.Ver_mas.HeaderText = "Ver_mas"
        Me.Ver_mas.Name = "Ver_mas"
        Me.Ver_mas.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio_Unitario
        '
        Me.Precio_Unitario.HeaderText = "Precio_Unitario"
        Me.Precio_Unitario.Name = "Precio_Unitario"
        Me.Precio_Unitario.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'ListarMisVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(1157, 529)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DVGDetalleFac)
        Me.Controls.Add(Me.DVentas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LDni1)
        Me.Controls.Add(Me.LVende1)
        Me.Controls.Add(Me.LVende)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListarMisVentas"
        Me.Text = "ListarVentas"
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LDni1 As Label
    Friend WithEvents LVende1 As Label
    Friend WithEvents LVende As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents DVGDetalleFac As DataGridView
    Friend WithEvents DVentas As DataGridView
    Friend WithEvents ID_Factura As DataGridViewTextBoxColumn
    Friend WithEvents DNI_Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents DNI_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Ver_mas As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Unitario As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
