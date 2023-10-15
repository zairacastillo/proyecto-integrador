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
        Me.BCliente = New System.Windows.Forms.Button()
        Me.TBClienteA = New System.Windows.Forms.TextBox()
        Me.BProducto = New System.Windows.Forms.Button()
        Me.TBProducto = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCompra = New System.Windows.Forms.Button()
        Me.TBClienteN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPFecnac = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.TBVendedorA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBUnitario = New System.Windows.Forms.TextBox()
        Me.BAgregarProd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TBVendedorN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCliente
        '
        Me.BCliente.Location = New System.Drawing.Point(880, 93)
        Me.BCliente.Name = "BCliente"
        Me.BCliente.Size = New System.Drawing.Size(56, 24)
        Me.BCliente.TabIndex = 24
        Me.BCliente.Text = "Buscar Cliente"
        Me.BCliente.UseVisualStyleBackColor = True
        '
        'TBClienteA
        '
        Me.TBClienteA.Location = New System.Drawing.Point(517, 93)
        Me.TBClienteA.Name = "TBClienteA"
        Me.TBClienteA.ReadOnly = True
        Me.TBClienteA.Size = New System.Drawing.Size(158, 20)
        Me.TBClienteA.TabIndex = 21
        '
        'BProducto
        '
        Me.BProducto.Location = New System.Drawing.Point(313, 44)
        Me.BProducto.Name = "BProducto"
        Me.BProducto.Size = New System.Drawing.Size(58, 29)
        Me.BProducto.TabIndex = 29
        Me.BProducto.Text = "Buscar"
        Me.BProducto.UseVisualStyleBackColor = True
        '
        'TBProducto
        '
        Me.TBProducto.Location = New System.Drawing.Point(128, 48)
        Me.TBProducto.Name = "TBProducto"
        Me.TBProducto.ReadOnly = True
        Me.TBProducto.Size = New System.Drawing.Size(169, 20)
        Me.TBProducto.TabIndex = 27
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.PrecioUnitario, Me.Cantidad, Me.Subtotal, Me.Eliminar})
        Me.DGV1.Location = New System.Drawing.Point(17, 451)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(931, 108)
        Me.DGV1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Detalle: "
        '
        'BCompra
        '
        Me.BCompra.Location = New System.Drawing.Point(781, 575)
        Me.BCompra.Name = "BCompra"
        Me.BCompra.Size = New System.Drawing.Size(95, 29)
        Me.BCompra.TabIndex = 34
        Me.BCompra.Text = "Confirmar"
        Me.BCompra.UseVisualStyleBackColor = True
        '
        'TBClienteN
        '
        Me.TBClienteN.Location = New System.Drawing.Point(695, 93)
        Me.TBClienteN.Name = "TBClienteN"
        Me.TBClienteN.ReadOnly = True
        Me.TBClienteN.Size = New System.Drawing.Size(169, 20)
        Me.TBClienteN.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(398, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha:"
        '
        'DTPFecnac
        '
        Me.DTPFecnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecnac.Location = New System.Drawing.Point(129, 93)
        Me.DTPFecnac.Name = "DTPFecnac"
        Me.DTPFecnac.Size = New System.Drawing.Size(142, 20)
        Me.DTPFecnac.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ID Venta:"
        '
        'TBID
        '
        Me.TBID.BackColor = System.Drawing.SystemColors.Control
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(134, 30)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(169, 20)
        Me.TBID.TabIndex = 40
        Me.TBID.Text = "1"
        '
        'TBVendedorA
        '
        Me.TBVendedorA.Location = New System.Drawing.Point(517, 35)
        Me.TBVendedorA.Name = "TBVendedorA"
        Me.TBVendedorA.ReadOnly = True
        Me.TBVendedorA.Size = New System.Drawing.Size(158, 20)
        Me.TBVendedorA.TabIndex = 42
        Me.TBVendedorA.Text = "a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(398, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Vendedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(510, 574)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Total:"
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(582, 579)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.ReadOnly = True
        Me.TBTotal.Size = New System.Drawing.Size(169, 20)
        Me.TBTotal.TabIndex = 43
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(128, 97)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.ReadOnly = True
        Me.TBStock.Size = New System.Drawing.Size(169, 20)
        Me.TBStock.TabIndex = 45
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(577, 48)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(169, 20)
        Me.TBCantidad.TabIndex = 47
        '
        'TBUnitario
        '
        Me.TBUnitario.Location = New System.Drawing.Point(577, 102)
        Me.TBUnitario.Name = "TBUnitario"
        Me.TBUnitario.ReadOnly = True
        Me.TBUnitario.Size = New System.Drawing.Size(169, 20)
        Me.TBUnitario.TabIndex = 49
        '
        'BAgregarProd
        '
        Me.BAgregarProd.Location = New System.Drawing.Point(290, 145)
        Me.BAgregarProd.Name = "BAgregarProd"
        Me.BAgregarProd.Size = New System.Drawing.Size(58, 29)
        Me.BAgregarProd.TabIndex = 51
        Me.BAgregarProd.Text = "Agregar"
        Me.BAgregarProd.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(403, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 29)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.bg
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BAgregarProd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TBCantidad)
        Me.Panel1.Controls.Add(Me.BProducto)
        Me.Panel1.Controls.Add(Me.TBUnitario)
        Me.Panel1.Controls.Add(Me.TBProducto)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TBStock)
        Me.Panel1.Location = New System.Drawing.Point(17, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 196)
        Me.Panel1.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 25)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Producto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(412, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 25)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Precio Unitario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 25)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Stock:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(412, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Cantidad:"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.bg
        Me.Panel2.Controls.Add(Me.TBVendedorN)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBClienteA)
        Me.Panel2.Controls.Add(Me.BCliente)
        Me.Panel2.Controls.Add(Me.TBClienteN)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DTPFecnac)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TBID)
        Me.Panel2.Controls.Add(Me.TBVendedorA)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(949, 140)
        Me.Panel2.TabIndex = 54
        '
        'TBVendedorN
        '
        Me.TBVendedorN.Location = New System.Drawing.Point(695, 35)
        Me.TBVendedorN.Name = "TBVendedorN"
        Me.TBVendedorN.ReadOnly = True
        Me.TBVendedorN.Size = New System.Drawing.Size(169, 20)
        Me.TBVendedorN.TabIndex = 43
        Me.TBVendedorN.Text = "a"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(22, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 25)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Cabecera"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(35, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 25)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Producto"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "SubTotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(976, 635)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BCompra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.TBTotal)
        Me.Name = "NuevaVenta"
        Me.Text = "NuevaVenta"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCliente As Button
    Friend WithEvents TBClienteA As TextBox
    Friend WithEvents BProducto As Button
    Friend WithEvents TBProducto As TextBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BCompra As Button
    Friend WithEvents TBClienteN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPFecnac As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents TBVendedorA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents TBStock As TextBox
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TBUnitario As TextBox
    Friend WithEvents BAgregarProd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TBVendedorN As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
End Class
