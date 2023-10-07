<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarEliminarProducto
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
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.CBCateg = New System.Windows.Forms.ComboBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.TBEstado = New System.Windows.Forms.TextBox()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LID = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BActivarElim = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BBuscarCat = New System.Windows.Forms.Button()
        Me.BBuscarNombre = New System.Windows.Forms.Button()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.bg
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.CBCateg)
        Me.PanelPrincipal.Controls.Add(Me.LCategoria)
        Me.PanelPrincipal.Controls.Add(Me.TBEstado)
        Me.PanelPrincipal.Controls.Add(Me.LEstado)
        Me.PanelPrincipal.Controls.Add(Me.TBStock)
        Me.PanelPrincipal.Controls.Add(Me.LStock)
        Me.PanelPrincipal.Controls.Add(Me.TBDescripcion)
        Me.PanelPrincipal.Controls.Add(Me.TBPrecio)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.TBID)
        Me.PanelPrincipal.Controls.Add(Me.LPrecio)
        Me.PanelPrincipal.Controls.Add(Me.LDescripcion)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Controls.Add(Me.LID)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(110, 239)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(546, 328)
        Me.PanelPrincipal.TabIndex = 0
        '
        'CBCateg
        '
        Me.CBCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCateg.FormattingEnabled = True
        Me.CBCateg.Location = New System.Drawing.Point(389, 145)
        Me.CBCateg.Name = "CBCateg"
        Me.CBCateg.Size = New System.Drawing.Size(126, 28)
        Me.CBCateg.TabIndex = 22
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.White
        Me.LCategoria.Location = New System.Drawing.Point(276, 144)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(111, 25)
        Me.LCategoria.TabIndex = 21
        Me.LCategoria.Text = "Categoria:"
        '
        'TBEstado
        '
        Me.TBEstado.Location = New System.Drawing.Point(119, 105)
        Me.TBEstado.Name = "TBEstado"
        Me.TBEstado.ReadOnly = True
        Me.TBEstado.Size = New System.Drawing.Size(130, 20)
        Me.TBEstado.TabIndex = 20
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.BackColor = System.Drawing.Color.Transparent
        Me.LEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.White
        Me.LEstado.Location = New System.Drawing.Point(20, 100)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(85, 25)
        Me.LEstado.TabIndex = 19
        Me.LEstado.Text = "Estado:"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(393, 105)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(122, 20)
        Me.TBStock.TabIndex = 18
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.Color.White
        Me.LStock.Location = New System.Drawing.Point(276, 100)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(72, 25)
        Me.LStock.TabIndex = 17
        Me.LStock.Text = "Stock:"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(161, 212)
        Me.TBDescripcion.Multiline = True
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(354, 68)
        Me.TBDescripcion.TabIndex = 16
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(393, 61)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(122, 20)
        Me.TBPrecio.TabIndex = 7
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(119, 148)
        Me.TBNombre.Multiline = True
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(130, 39)
        Me.TBNombre.TabIndex = 5
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(119, 60)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(130, 20)
        Me.TBID.TabIndex = 4
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.Color.White
        Me.LPrecio.Location = New System.Drawing.Point(276, 54)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(79, 25)
        Me.LPrecio.TabIndex = 3
        Me.LPrecio.Text = "Precio:"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.ForeColor = System.Drawing.Color.White
        Me.LDescripcion.Location = New System.Drawing.Point(20, 206)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(131, 25)
        Me.LDescripcion.TabIndex = 2
        Me.LDescripcion.Text = "Descripcion:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(20, 144)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(93, 25)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre:"
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.BackColor = System.Drawing.Color.Transparent
        Me.LID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LID.ForeColor = System.Drawing.Color.White
        Me.LID.Location = New System.Drawing.Point(20, 55)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(38, 25)
        Me.LID.TabIndex = 0
        Me.LID.Text = "ID:"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Precio, Me.Stock, Me.Categoria, Me.Descripcion, Me.Estado, Me.Seleccionar})
        Me.DGV1.Location = New System.Drawing.Point(23, 61)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(942, 164)
        Me.DGV1.TabIndex = 2
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.proyecto_integrador.My.Resources.Resources.cerrar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.Location = New System.Drawing.Point(769, 445)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(87, 60)
        Me.BCancelar.TabIndex = 15
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Image = Global.proyecto_integrador.My.Resources.Resources.lapiz
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BEditar.Location = New System.Drawing.Point(774, 348)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(82, 64)
        Me.BEditar.TabIndex = 14
        Me.BEditar.Text = "Guardar Cambios"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BActivarElim
        '
        Me.BActivarElim.Location = New System.Drawing.Point(765, 258)
        Me.BActivarElim.Name = "BActivarElim"
        Me.BActivarElim.Size = New System.Drawing.Size(91, 60)
        Me.BActivarElim.TabIndex = 13
        Me.BActivarElim.Text = "Activar/Eliminar"
        Me.BActivarElim.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar Producto"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(686, 21)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscar.TabIndex = 17
        '
        'CBCategoria
        '
        Me.CBCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Location = New System.Drawing.Point(160, 18)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(154, 28)
        Me.CBCategoria.TabIndex = 19
        Me.CBCategoria.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(450, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar Producto Nombre"
        '
        'BBuscarCat
        '
        Me.BBuscarCat.Location = New System.Drawing.Point(328, 19)
        Me.BBuscarCat.Name = "BBuscarCat"
        Me.BBuscarCat.Size = New System.Drawing.Size(91, 24)
        Me.BBuscarCat.TabIndex = 22
        Me.BBuscarCat.Text = "Buscar"
        Me.BBuscarCat.UseVisualStyleBackColor = True
        '
        'BBuscarNombre
        '
        Me.BBuscarNombre.Location = New System.Drawing.Point(874, 18)
        Me.BBuscarNombre.Name = "BBuscarNombre"
        Me.BBuscarNombre.Size = New System.Drawing.Size(91, 24)
        Me.BBuscarNombre.TabIndex = 23
        Me.BBuscarNombre.Text = "Buscar"
        Me.BBuscarNombre.UseVisualStyleBackColor = True
        '
        'EditarEliminarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 579)
        Me.Controls.Add(Me.BBuscarNombre)
        Me.Controls.Add(Me.BBuscarCat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.BActivarElim)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Name = "EditarEliminarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar/eliminar Producto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBID As TextBox
    Friend WithEvents LPrecio As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LID As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents TBEstado As TextBox
    Friend WithEvents LEstado As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents BActivarElim As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Seleccionar As DataGridViewButtonColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents BBuscarCat As Button
    Friend WithEvents BBuscarNombre As Button
    Friend WithEvents CBCateg As ComboBox
End Class
