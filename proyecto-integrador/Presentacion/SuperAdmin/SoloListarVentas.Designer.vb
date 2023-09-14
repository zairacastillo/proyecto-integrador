<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SoloListarVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.NroVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerMas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DTPFecventa = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroVenta, Me.Cliente, Me.Vendedor, Me.Fecha, Me.Total, Me.VerMas})
        Me.DGV1.Location = New System.Drawing.Point(-9, 263)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(931, 189)
        Me.DGV1.TabIndex = 27
        '
        'NroVenta
        '
        Me.NroVenta.HeaderText = "NroVenta"
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
        Me.VerMas.HeaderText = "Ver Mas"
        Me.VerMas.Name = "VerMas"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(385, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 29)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.White
        Me.LFecha.Location = New System.Drawing.Point(478, 62)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(188, 25)
        Me.LFecha.TabIndex = 25
        Me.LFecha.Text = "Buscar por Fecha:"
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.BackColor = System.Drawing.Color.Transparent
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.ForeColor = System.Drawing.Color.White
        Me.LCliente.Location = New System.Drawing.Point(49, 61)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(195, 25)
        Me.LCliente.TabIndex = 23
        Me.LCliente.Text = "Buscar por Cliente:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(258, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 22
        '
        'DTPFecventa
        '
        Me.DTPFecventa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecventa.Location = New System.Drawing.Point(672, 67)
        Me.DTPFecventa.Name = "DTPFecventa"
        Me.DTPFecventa.Size = New System.Drawing.Size(142, 20)
        Me.DTPFecventa.TabIndex = 28
        '
        'ListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(892, 450)
        Me.Controls.Add(Me.DTPFecventa)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LCliente)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ListarVentas"
        Me.Text = "ListarVentas"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents LFecha As Label
    Friend WithEvents LCliente As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NroVenta As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents VerMas As DataGridViewTextBoxColumn
    Friend WithEvents DTPFecventa As DateTimePicker
End Class
