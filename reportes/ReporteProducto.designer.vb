<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteProducto
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
        Me.TBCategoria = New System.Windows.Forms.TextBox()
        Me.TBEstado = New System.Windows.Forms.TextBox()
        Me.LCategoria = New System.Windows.Forms.Label()
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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAEstado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BBuscarNombre = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.BReporte = New System.Windows.Forms.Button()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.TBCategoria)
        Me.PanelPrincipal.Controls.Add(Me.TBEstado)
        Me.PanelPrincipal.Controls.Add(Me.LCategoria)
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
        Me.PanelPrincipal.Location = New System.Drawing.Point(39, 265)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(628, 328)
        Me.PanelPrincipal.TabIndex = 0
        '
        'TBCategoria
        '
        Me.TBCategoria.Enabled = False
        Me.TBCategoria.Location = New System.Drawing.Point(442, 150)
        Me.TBCategoria.Name = "TBCategoria"
        Me.TBCategoria.ReadOnly = True
        Me.TBCategoria.Size = New System.Drawing.Size(161, 20)
        Me.TBCategoria.TabIndex = 25
        '
        'TBEstado
        '
        Me.TBEstado.Enabled = False
        Me.TBEstado.Location = New System.Drawing.Point(130, 104)
        Me.TBEstado.Name = "TBEstado"
        Me.TBEstado.ReadOnly = True
        Me.TBEstado.Size = New System.Drawing.Size(161, 20)
        Me.TBEstado.TabIndex = 24
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.White
        Me.LCategoria.Location = New System.Drawing.Point(329, 144)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(111, 25)
        Me.LCategoria.TabIndex = 21
        Me.LCategoria.Text = "Categoria:"
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.BackColor = System.Drawing.Color.Transparent
        Me.LEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.White
        Me.LEstado.Location = New System.Drawing.Point(31, 99)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(85, 25)
        Me.LEstado.TabIndex = 19
        Me.LEstado.Text = "Estado:"
        '
        'TBStock
        '
        Me.TBStock.Enabled = False
        Me.TBStock.Location = New System.Drawing.Point(442, 99)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.ReadOnly = True
        Me.TBStock.Size = New System.Drawing.Size(161, 20)
        Me.TBStock.TabIndex = 18
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.Color.White
        Me.LStock.Location = New System.Drawing.Point(329, 100)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(72, 25)
        Me.LStock.TabIndex = 17
        Me.LStock.Text = "Stock:"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Enabled = False
        Me.TBDescripcion.Location = New System.Drawing.Point(172, 211)
        Me.TBDescripcion.Multiline = True
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.ReadOnly = True
        Me.TBDescripcion.Size = New System.Drawing.Size(354, 68)
        Me.TBDescripcion.TabIndex = 16
        '
        'TBPrecio
        '
        Me.TBPrecio.Enabled = False
        Me.TBPrecio.Location = New System.Drawing.Point(442, 54)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.ReadOnly = True
        Me.TBPrecio.Size = New System.Drawing.Size(161, 20)
        Me.TBPrecio.TabIndex = 7
        '
        'TBNombre
        '
        Me.TBNombre.Enabled = False
        Me.TBNombre.Location = New System.Drawing.Point(130, 147)
        Me.TBNombre.Multiline = True
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.ReadOnly = True
        Me.TBNombre.Size = New System.Drawing.Size(161, 26)
        Me.TBNombre.TabIndex = 5
        '
        'TBID
        '
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(130, 59)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(161, 20)
        Me.TBID.TabIndex = 4
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.Color.White
        Me.LPrecio.Location = New System.Drawing.Point(329, 54)
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
        Me.LDescripcion.Location = New System.Drawing.Point(31, 205)
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
        Me.LNombre.Location = New System.Drawing.Point(31, 143)
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
        Me.LID.Location = New System.Drawing.Point(31, 54)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(38, 25)
        Me.LID.TabIndex = 0
        Me.LID.Text = "ID:"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(32, 74)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(916, 164)
        Me.DGV1.TabIndex = 2
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.proyecto_integrador.My.Resources.Resources.cerrar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.Location = New System.Drawing.Point(857, 533)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(87, 60)
        Me.BCancelar.TabIndex = 15
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAEstado
        '
        Me.BAEstado.Location = New System.Drawing.Point(853, 265)
        Me.BAEstado.Name = "BAEstado"
        Me.BAEstado.Size = New System.Drawing.Size(91, 60)
        Me.BAEstado.TabIndex = 13
        Me.BAEstado.Text = "Mostrar Inactivos"
        Me.BAEstado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar Producto"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(669, 23)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscar.TabIndex = 17
        '
        'CBCategoria
        '
        Me.CBCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Location = New System.Drawing.Point(176, 20)
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
        Me.Label3.Location = New System.Drawing.Point(433, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar Producto Nombre"
        '
        'BBuscarNombre
        '
        Me.BBuscarNombre.Location = New System.Drawing.Point(857, 20)
        Me.BBuscarNombre.Name = "BBuscarNombre"
        Me.BBuscarNombre.Size = New System.Drawing.Size(91, 24)
        Me.BBuscarNombre.TabIndex = 23
        Me.BBuscarNombre.Text = "Buscar"
        Me.BBuscarNombre.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.Transparent
        Me.LFechaH.Location = New System.Drawing.Point(681, 493)
        Me.LFechaH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(68, 13)
        Me.LFechaH.TabIndex = 119
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.Transparent
        Me.LFechaD.Location = New System.Drawing.Point(681, 455)
        Me.LFechaD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(71, 13)
        Me.LFechaD.TabIndex = 118
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(756, 487)
        Me.DTPHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(83, 20)
        Me.DTPHasta.TabIndex = 117
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(756, 451)
        Me.DTPDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(83, 20)
        Me.DTPDesde.TabIndex = 116
        '
        'BReporte
        '
        Me.BReporte.Location = New System.Drawing.Point(857, 447)
        Me.BReporte.Name = "BReporte"
        Me.BReporte.Size = New System.Drawing.Size(91, 60)
        Me.BReporte.TabIndex = 121
        Me.BReporte.Text = "Generar Reporte"
        Me.BReporte.UseVisualStyleBackColor = True
        '
        'ReporteProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.BReporte)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.BBuscarNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAEstado)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteProducto"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar/eliminar Producto"
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
    Friend WithEvents LEstado As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAEstado As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BBuscarNombre As Button
    Friend WithEvents TBCategoria As TextBox
    Friend WithEvents TBEstado As TextBox
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents BReporte As Button
End Class
