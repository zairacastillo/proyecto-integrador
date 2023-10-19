<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoProducto
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
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.CBCategoria)
        Me.PanelPrincipal.Controls.Add(Me.LCategoria)
        Me.PanelPrincipal.Controls.Add(Me.TBStock)
        Me.PanelPrincipal.Controls.Add(Me.LStock)
        Me.PanelPrincipal.Controls.Add(Me.TBDescripcion)
        Me.PanelPrincipal.Controls.Add(Me.BAgregar)
        Me.PanelPrincipal.Controls.Add(Me.TBPrecio)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.LPrecio)
        Me.PanelPrincipal.Controls.Add(Me.LDescripcion)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(153, 30)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(673, 328)
        Me.PanelPrincipal.TabIndex = 0
        '
        'CBCategoria
        '
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Location = New System.Drawing.Point(474, 107)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(133, 21)
        Me.CBCategoria.TabIndex = 3
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.White
        Me.LCategoria.Location = New System.Drawing.Point(357, 101)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(111, 25)
        Me.LCategoria.TabIndex = 21
        Me.LCategoria.Text = "Categoria:"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(474, 44)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(133, 20)
        Me.TBStock.TabIndex = 18
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.Color.White
        Me.LStock.Location = New System.Drawing.Point(357, 38)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(72, 25)
        Me.LStock.TabIndex = 17
        Me.LStock.Text = "Stock:"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(189, 183)
        Me.TBDescripcion.Multiline = True
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(354, 56)
        Me.TBDescripcion.TabIndex = 16
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.proyecto_integrador.My.Resources.Resources.diskette
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(426, 269)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BAgregar.Size = New System.Drawing.Size(117, 45)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(169, 107)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(133, 20)
        Me.TBPrecio.TabIndex = 7
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(169, 38)
        Me.TBNombre.Multiline = True
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(130, 20)
        Me.TBNombre.TabIndex = 5
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.Color.White
        Me.LPrecio.Location = New System.Drawing.Point(52, 102)
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
        Me.LDescripcion.Location = New System.Drawing.Point(52, 177)
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
        Me.LNombre.Location = New System.Drawing.Point(52, 32)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(93, 25)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre:"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(12, 395)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(936, 208)
        Me.DGV1.TabIndex = 2
        '
        'NuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LPrecio As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents LCategoria As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents CBCategoria As ComboBox
End Class
