<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteEmpleado
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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BReporte = New System.Windows.Forms.Button()
        Me.BAEstado = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBBuscarApellido = New System.Windows.Forms.TextBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.LID = New System.Windows.Forms.Label()
        Me.TBDirec = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.TBTel = New System.Windows.Forms.TextBox()
        Me.LTel = New System.Windows.Forms.Label()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(28, 78)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(920, 186)
        Me.DGV1.TabIndex = 7
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.proyecto_integrador.My.Resources.Resources.cerrar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.Location = New System.Drawing.Point(812, 509)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(84, 70)
        Me.BCancelar.TabIndex = 15
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BReporte
        '
        Me.BReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BReporte.Location = New System.Drawing.Point(814, 419)
        Me.BReporte.Name = "BReporte"
        Me.BReporte.Size = New System.Drawing.Size(82, 70)
        Me.BReporte.TabIndex = 14
        Me.BReporte.Text = "Generar Reporte"
        Me.BReporte.UseVisualStyleBackColor = True
        '
        'BAEstado
        '
        Me.BAEstado.Location = New System.Drawing.Point(812, 289)
        Me.BAEstado.Name = "BAEstado"
        Me.BAEstado.Size = New System.Drawing.Size(84, 70)
        Me.BAEstado.TabIndex = 13
        Me.BAEstado.Text = "Mostrar Inactivos"
        Me.BAEstado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(402, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Buscar Empleado Apellido"
        '
        'TBBuscarApellido
        '
        Me.TBBuscarApellido.Location = New System.Drawing.Point(627, 27)
        Me.TBBuscarApellido.Name = "TBBuscarApellido"
        Me.TBBuscarApellido.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscarApellido.TabIndex = 19
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.TBID)
        Me.PanelPrincipal.Controls.Add(Me.LID)
        Me.PanelPrincipal.Controls.Add(Me.TBDirec)
        Me.PanelPrincipal.Controls.Add(Me.LDireccion)
        Me.PanelPrincipal.Controls.Add(Me.TBTel)
        Me.PanelPrincipal.Controls.Add(Me.LTel)
        Me.PanelPrincipal.Controls.Add(Me.TBCorreo)
        Me.PanelPrincipal.Controls.Add(Me.LCorreo)
        Me.PanelPrincipal.Controls.Add(Me.TBDni)
        Me.PanelPrincipal.Controls.Add(Me.LDni)
        Me.PanelPrincipal.Controls.Add(Me.TBApellido)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.LApellido)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(98, 298)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(427, 281)
        Me.PanelPrincipal.TabIndex = 22
        '
        'TBID
        '
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(140, 239)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(238, 20)
        Me.TBID.TabIndex = 32
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.BackColor = System.Drawing.Color.Transparent
        Me.LID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LID.ForeColor = System.Drawing.Color.White
        Me.LID.Location = New System.Drawing.Point(19, 234)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(38, 25)
        Me.LID.TabIndex = 31
        Me.LID.Text = "ID:"
        '
        'TBDirec
        '
        Me.TBDirec.Location = New System.Drawing.Point(140, 202)
        Me.TBDirec.Name = "TBDirec"
        Me.TBDirec.Size = New System.Drawing.Size(238, 20)
        Me.TBDirec.TabIndex = 18
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(16, 197)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(108, 25)
        Me.LDireccion.TabIndex = 17
        Me.LDireccion.Text = "Direccion:"
        '
        'TBTel
        '
        Me.TBTel.Location = New System.Drawing.Point(140, 166)
        Me.TBTel.Name = "TBTel"
        Me.TBTel.Size = New System.Drawing.Size(238, 20)
        Me.TBTel.TabIndex = 18
        '
        'LTel
        '
        Me.LTel.AutoSize = True
        Me.LTel.BackColor = System.Drawing.Color.Transparent
        Me.LTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTel.ForeColor = System.Drawing.Color.White
        Me.LTel.Location = New System.Drawing.Point(19, 161)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(102, 25)
        Me.LTel.TabIndex = 17
        Me.LTel.Text = "Telefono:"
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(140, 127)
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(238, 20)
        Me.TBCorreo.TabIndex = 14
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.White
        Me.LCorreo.Location = New System.Drawing.Point(19, 121)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(83, 25)
        Me.LCorreo.TabIndex = 13
        Me.LCorreo.Text = "Correo:"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(140, 91)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(238, 20)
        Me.TBDni.TabIndex = 12
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.BackColor = System.Drawing.Color.Transparent
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(19, 85)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(53, 25)
        Me.LDni.TabIndex = 11
        Me.LDni.Text = "DNI:"
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(140, 55)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(238, 20)
        Me.TBApellido.TabIndex = 5
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(140, 17)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(238, 20)
        Me.TBNombre.TabIndex = 4
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.Color.Transparent
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(19, 47)
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
        Me.LNombre.Location = New System.Drawing.Point(19, 12)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(93, 25)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(854, 24)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BBuscar.TabIndex = 32
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.Transparent
        Me.LFechaH.Location = New System.Drawing.Point(635, 468)
        Me.LFechaH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(68, 13)
        Me.LFechaH.TabIndex = 131
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.Transparent
        Me.LFechaD.Location = New System.Drawing.Point(635, 430)
        Me.LFechaD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(71, 13)
        Me.LFechaD.TabIndex = 130
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(710, 462)
        Me.DTPHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(83, 20)
        Me.DTPHasta.TabIndex = 129
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(710, 426)
        Me.DTPDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(83, 20)
        Me.DTPDesde.TabIndex = 128
        '
        'ReporteEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBBuscarApellido)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BReporte)
        Me.Controls.Add(Me.BAEstado)
        Me.Controls.Add(Me.DGV1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar/Eliminar Empleado"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents BCancelar As Button
    Friend WithEvents BReporte As Button
    Friend WithEvents BAEstado As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TBBuscarApellido As TextBox
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents TBDirec As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents TBTel As TextBox
    Friend WithEvents LTel As Label
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents TBDni As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents LID As Label
    Friend WithEvents BBuscar As Button
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
End Class
