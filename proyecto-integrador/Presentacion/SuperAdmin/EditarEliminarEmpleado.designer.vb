<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarEliminarEmpleado
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
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BAEstado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBBuscarApellido = New System.Windows.Forms.TextBox()
        Me.CBPerfil = New System.Windows.Forms.ComboBox()
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
        Me.LCont = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNuevCont = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBBuscaPerfil = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBActCont = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBHash = New System.Windows.Forms.TextBox()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.DGV1.Size = New System.Drawing.Size(920, 183)
        Me.DGV1.TabIndex = 7
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.proyecto_integrador.My.Resources.Resources.cerrar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.Location = New System.Drawing.Point(866, 409)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(84, 70)
        Me.BCancelar.TabIndex = 15
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Image = Global.proyecto_integrador.My.Resources.Resources.lapiz
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BEditar.Location = New System.Drawing.Point(866, 322)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(82, 70)
        Me.BEditar.TabIndex = 14
        Me.BEditar.Text = "Guardar Cambios"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BAEstado
        '
        Me.BAEstado.Location = New System.Drawing.Point(866, 496)
        Me.BAEstado.Name = "BAEstado"
        Me.BAEstado.Size = New System.Drawing.Size(84, 70)
        Me.BAEstado.TabIndex = 13
        Me.BAEstado.Text = "Mostrar Inactivos"
        Me.BAEstado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Buscar por perfil"
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
        'CBPerfil
        '
        Me.CBPerfil.FormattingEnabled = True
        Me.CBPerfil.Location = New System.Drawing.Point(153, 202)
        Me.CBPerfil.Name = "CBPerfil"
        Me.CBPerfil.Size = New System.Drawing.Size(226, 21)
        Me.CBPerfil.TabIndex = 28
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
        Me.PanelPrincipal.Location = New System.Drawing.Point(32, 301)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(401, 281)
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
        'LCont
        '
        Me.LCont.AutoSize = True
        Me.LCont.BackColor = System.Drawing.Color.Transparent
        Me.LCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCont.ForeColor = System.Drawing.Color.White
        Me.LCont.Location = New System.Drawing.Point(20, 136)
        Me.LCont.Name = "LCont"
        Me.LCont.Size = New System.Drawing.Size(129, 50)
        Me.LCont.TabIndex = 23
        Me.LCont.Text = "Nueva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Perfil:"
        '
        'TBNuevCont
        '
        Me.TBNuevCont.Location = New System.Drawing.Point(153, 161)
        Me.TBNuevCont.Name = "TBNuevCont"
        Me.TBNuevCont.Size = New System.Drawing.Size(226, 20)
        Me.TBNuevCont.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Usuario:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(153, 33)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(226, 20)
        Me.TBUsuario.TabIndex = 27
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBEstado.Location = New System.Drawing.Point(153, 243)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(226, 21)
        Me.CBEstado.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Estado:"
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
        'CBBuscaPerfil
        '
        Me.CBBuscaPerfil.FormattingEnabled = True
        Me.CBBuscaPerfil.Location = New System.Drawing.Point(188, 26)
        Me.CBBuscaPerfil.Name = "CBBuscaPerfil"
        Me.CBBuscaPerfil.Size = New System.Drawing.Size(152, 21)
        Me.CBBuscaPerfil.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TBActCont)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TBUsuario)
        Me.Panel1.Controls.Add(Me.TBNuevCont)
        Me.Panel1.Controls.Add(Me.CBEstado)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LCont)
        Me.Panel1.Controls.Add(Me.CBPerfil)
        Me.Panel1.Location = New System.Drawing.Point(449, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 281)
        Me.Panel1.TabIndex = 34
        '
        'TBActCont
        '
        Me.TBActCont.Location = New System.Drawing.Point(153, 101)
        Me.TBActCont.Name = "TBActCont"
        Me.TBActCont.Size = New System.Drawing.Size(226, 20)
        Me.TBActCont.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 50)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Actual:"
        '
        'TBHash
        '
        Me.TBHash.Location = New System.Drawing.Point(602, 598)
        Me.TBHash.Name = "TBHash"
        Me.TBHash.Size = New System.Drawing.Size(100, 20)
        Me.TBHash.TabIndex = 35
        Me.TBHash.Visible = False
        '
        'EditarEliminarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.TBHash)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CBBuscaPerfil)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBBuscarApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.BAEstado)
        Me.Controls.Add(Me.DGV1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarEliminarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar/Eliminar Empleado"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents BCancelar As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents BAEstado As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBBuscarApellido As TextBox
    Friend WithEvents CBPerfil As ComboBox
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
    Friend WithEvents LCont As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBNuevCont As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents LID As Label
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBBuscaPerfil As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBActCont As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBHash As TextBox
End Class
