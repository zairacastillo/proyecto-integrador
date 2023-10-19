<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarClientes
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
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.TBEstado = New System.Windows.Forms.TextBox()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.LID = New System.Windows.Forms.Label()
        Me.TBTel = New System.Windows.Forms.TextBox()
        Me.LTel = New System.Windows.Forms.Label()
        Me.TBDirec = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBBuscarAp = New System.Windows.Forms.TextBox()
        Me.BBuscarDni = New System.Windows.Forms.Button()
        Me.BBuscarAp = New System.Windows.Forms.Button()
        Me.BAgregarVenta = New System.Windows.Forms.Button()
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
        Me.DGV1.Location = New System.Drawing.Point(24, 84)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(915, 164)
        Me.DGV1.TabIndex = 5
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.BAgregarVenta)
        Me.PanelPrincipal.Controls.Add(Me.TBEstado)
        Me.PanelPrincipal.Controls.Add(Me.LEstado)
        Me.PanelPrincipal.Controls.Add(Me.TBID)
        Me.PanelPrincipal.Controls.Add(Me.LID)
        Me.PanelPrincipal.Controls.Add(Me.TBTel)
        Me.PanelPrincipal.Controls.Add(Me.LTel)
        Me.PanelPrincipal.Controls.Add(Me.TBDirec)
        Me.PanelPrincipal.Controls.Add(Me.LDireccion)
        Me.PanelPrincipal.Controls.Add(Me.TBCorreo)
        Me.PanelPrincipal.Controls.Add(Me.LCorreo)
        Me.PanelPrincipal.Controls.Add(Me.TBDni)
        Me.PanelPrincipal.Controls.Add(Me.LDni)
        Me.PanelPrincipal.Controls.Add(Me.TBApellido)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.LApellido)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(24, 294)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(915, 297)
        Me.PanelPrincipal.TabIndex = 3
        '
        'TBEstado
        '
        Me.TBEstado.Enabled = False
        Me.TBEstado.Location = New System.Drawing.Point(551, 183)
        Me.TBEstado.Name = "TBEstado"
        Me.TBEstado.ReadOnly = True
        Me.TBEstado.Size = New System.Drawing.Size(254, 20)
        Me.TBEstado.TabIndex = 22
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.BackColor = System.Drawing.Color.Transparent
        Me.LEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.White
        Me.LEstado.Location = New System.Drawing.Point(443, 178)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(85, 25)
        Me.LEstado.TabIndex = 21
        Me.LEstado.Text = "Estado:"
        '
        'TBID
        '
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(551, 145)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(254, 20)
        Me.TBID.TabIndex = 20
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.BackColor = System.Drawing.Color.Transparent
        Me.LID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LID.ForeColor = System.Drawing.Color.White
        Me.LID.Location = New System.Drawing.Point(443, 140)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(38, 25)
        Me.LID.TabIndex = 19
        Me.LID.Text = "ID:"
        '
        'TBTel
        '
        Me.TBTel.Location = New System.Drawing.Point(551, 74)
        Me.TBTel.Name = "TBTel"
        Me.TBTel.Size = New System.Drawing.Size(254, 20)
        Me.TBTel.TabIndex = 18
        '
        'LTel
        '
        Me.LTel.AutoSize = True
        Me.LTel.BackColor = System.Drawing.Color.Transparent
        Me.LTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTel.ForeColor = System.Drawing.Color.White
        Me.LTel.Location = New System.Drawing.Point(443, 69)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(102, 25)
        Me.LTel.TabIndex = 17
        Me.LTel.Text = "Telefono:"
        '
        'TBDirec
        '
        Me.TBDirec.Location = New System.Drawing.Point(551, 109)
        Me.TBDirec.Name = "TBDirec"
        Me.TBDirec.Size = New System.Drawing.Size(254, 20)
        Me.TBDirec.TabIndex = 16
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(443, 104)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(108, 25)
        Me.LDireccion.TabIndex = 15
        Me.LDireccion.Text = "Direccion:"
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(164, 186)
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(254, 20)
        Me.TBCorreo.TabIndex = 14
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.White
        Me.LCorreo.Location = New System.Drawing.Point(59, 180)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(83, 25)
        Me.LCorreo.TabIndex = 13
        Me.LCorreo.Text = "Correo:"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(164, 150)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(254, 20)
        Me.TBDni.TabIndex = 12
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.BackColor = System.Drawing.Color.Transparent
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(59, 144)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(53, 25)
        Me.LDni.TabIndex = 11
        Me.LDni.Text = "DNI:"
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(164, 112)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(254, 20)
        Me.TBApellido.TabIndex = 5
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(164, 69)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(254, 20)
        Me.TBNombre.TabIndex = 4
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.Color.Transparent
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(56, 104)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(95, 25)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "Apellido:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(56, 64)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(93, 25)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(176, 28)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar Cliente DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(498, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Buscar Cliente Apellido"
        '
        'TBBuscarAp
        '
        Me.TBBuscarAp.Location = New System.Drawing.Point(699, 30)
        Me.TBBuscarAp.Name = "TBBuscarAp"
        Me.TBBuscarAp.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscarAp.TabIndex = 13
        '
        'BBuscarDni
        '
        Me.BBuscarDni.Location = New System.Drawing.Point(364, 25)
        Me.BBuscarDni.Name = "BBuscarDni"
        Me.BBuscarDni.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarDni.TabIndex = 15
        Me.BBuscarDni.Text = "Buscar"
        Me.BBuscarDni.UseVisualStyleBackColor = True
        '
        'BBuscarAp
        '
        Me.BBuscarAp.Location = New System.Drawing.Point(887, 28)
        Me.BBuscarAp.Name = "BBuscarAp"
        Me.BBuscarAp.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarAp.TabIndex = 16
        Me.BBuscarAp.Text = "Buscar"
        Me.BBuscarAp.UseVisualStyleBackColor = True
        '
        'BAgregarVenta
        '
        Me.BAgregarVenta.Location = New System.Drawing.Point(825, 109)
        Me.BAgregarVenta.Name = "BAgregarVenta"
        Me.BAgregarVenta.Size = New System.Drawing.Size(75, 67)
        Me.BAgregarVenta.TabIndex = 25
        Me.BAgregarVenta.Text = "Agregar a Venta"
        Me.BAgregarVenta.UseVisualStyleBackColor = True
        '
        'ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.BBuscarAp)
        Me.Controls.Add(Me.BBuscarDni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBBuscarAp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarCliente"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBDirec As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents TBDni As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents TBTel As TextBox
    Friend WithEvents LTel As Label
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBBuscarAp As TextBox
    Friend WithEvents BBuscarDni As Button
    Friend WithEvents BBuscarAp As Button
    Friend WithEvents TBID As TextBox
    Friend WithEvents LID As Label
    Friend WithEvents TBEstado As TextBox
    Friend WithEvents LEstado As Label
    Friend WithEvents BAgregarVenta As Button
End Class
