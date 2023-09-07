<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaFactura
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.NroFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.DTPFecnac = New System.Windows.Forms.DateTimePicker()
        Me.TBCant = New System.Windows.Forms.TextBox()
        Me.LFecnac = New System.Windows.Forms.Label()
        Me.LCodigo = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFact, Me.Nombre, Me.Precio, Me.Cantidad, Me.Total, Me.FechaFactura})
        Me.DGV1.Location = New System.Drawing.Point(45, 378)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(931, 164)
        Me.DGV1.TabIndex = 5
        '
        'NroFact
        '
        Me.NroFact.HeaderText = "Nro Factura"
        Me.NroFact.Name = "NroFact"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'FechaFactura
        '
        Me.FechaFactura.HeaderText = "Fecha Factura"
        Me.FechaFactura.Name = "FechaFactura"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.bg
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.TBTotal)
        Me.PanelPrincipal.Controls.Add(Me.Label2)
        Me.PanelPrincipal.Controls.Add(Me.TBPrecio)
        Me.PanelPrincipal.Controls.Add(Me.Label1)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Controls.Add(Me.BAgregar)
        Me.PanelPrincipal.Controls.Add(Me.DTPFecnac)
        Me.PanelPrincipal.Controls.Add(Me.TBCant)
        Me.PanelPrincipal.Controls.Add(Me.LFecnac)
        Me.PanelPrincipal.Controls.Add(Me.LCodigo)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(263, 12)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(401, 341)
        Me.PanelPrincipal.TabIndex = 3
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(124, 182)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(254, 20)
        Me.TBTotal.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total:"
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(124, 82)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(254, 20)
        Me.TBPrecio.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Precio:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(124, 35)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(254, 20)
        Me.TBNombre.TabIndex = 4
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(16, 27)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(93, 25)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.proyecto_integrador.My.Resources.Resources.diskette
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(143, 280)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BAgregar.Size = New System.Drawing.Size(110, 47)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'DTPFecnac
        '
        Me.DTPFecnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecnac.Location = New System.Drawing.Point(236, 238)
        Me.DTPFecnac.Name = "DTPFecnac"
        Me.DTPFecnac.Size = New System.Drawing.Size(142, 20)
        Me.DTPFecnac.TabIndex = 6
        '
        'TBCant
        '
        Me.TBCant.Location = New System.Drawing.Point(124, 133)
        Me.TBCant.Name = "TBCant"
        Me.TBCant.Size = New System.Drawing.Size(254, 20)
        Me.TBCant.TabIndex = 5
        '
        'LFecnac
        '
        Me.LFecnac.AutoSize = True
        Me.LFecnac.BackColor = System.Drawing.Color.Transparent
        Me.LFecnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecnac.ForeColor = System.Drawing.Color.White
        Me.LFecnac.Location = New System.Drawing.Point(16, 233)
        Me.LFecnac.Name = "LFecnac"
        Me.LFecnac.Size = New System.Drawing.Size(163, 25)
        Me.LFecnac.TabIndex = 2
        Me.LFecnac.Text = "Fecha Factura: "
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.ForeColor = System.Drawing.Color.White
        Me.LCodigo.Location = New System.Drawing.Point(16, 125)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(104, 25)
        Me.LCodigo.TabIndex = 1
        Me.LCodigo.Text = "Cantidad:"
        '
        'NuevaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(1020, 554)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Name = "NuevaFactura"
        Me.Text = "NuevaFactura"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents BAgregar As Button
    Friend WithEvents DTPFecnac As DateTimePicker
    Friend WithEvents TBCant As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LFecnac As Label
    Friend WithEvents LCodigo As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NroFact As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents FechaFactura As DataGridViewTextBoxColumn
End Class
