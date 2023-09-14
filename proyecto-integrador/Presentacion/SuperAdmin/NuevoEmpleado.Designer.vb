<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoEmpleado
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
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.TBPerfil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBTel = New System.Windows.Forms.TextBox()
        Me.LTel = New System.Windows.Forms.Label()
        Me.TBCont = New System.Windows.Forms.TextBox()
        Me.LCont = New System.Windows.Forms.Label()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.Dni, Me.Telefono, Me.Correo, Me.Contraseña, Me.Usuario, Me.Perfil})
        Me.DGV1.Location = New System.Drawing.Point(-17, 356)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(936, 164)
        Me.DGV1.TabIndex = 7
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.bg
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.TBPerfil)
        Me.PanelPrincipal.Controls.Add(Me.Label2)
        Me.PanelPrincipal.Controls.Add(Me.TBUsuario)
        Me.PanelPrincipal.Controls.Add(Me.Label1)
        Me.PanelPrincipal.Controls.Add(Me.TBTel)
        Me.PanelPrincipal.Controls.Add(Me.LTel)
        Me.PanelPrincipal.Controls.Add(Me.TBCont)
        Me.PanelPrincipal.Controls.Add(Me.LCont)
        Me.PanelPrincipal.Controls.Add(Me.TBCorreo)
        Me.PanelPrincipal.Controls.Add(Me.LCorreo)
        Me.PanelPrincipal.Controls.Add(Me.TBDni)
        Me.PanelPrincipal.Controls.Add(Me.LDni)
        Me.PanelPrincipal.Controls.Add(Me.BAgregar)
        Me.PanelPrincipal.Controls.Add(Me.TBApellido)
        Me.PanelPrincipal.Controls.Add(Me.TBNombre)
        Me.PanelPrincipal.Controls.Add(Me.LApellido)
        Me.PanelPrincipal.Controls.Add(Me.LNombre)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(193, -3)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(401, 356)
        Me.PanelPrincipal.TabIndex = 6
        '
        'TBPerfil
        '
        Me.TBPerfil.Location = New System.Drawing.Point(140, 280)
        Me.TBPerfil.Name = "TBPerfil"
        Me.TBPerfil.Size = New System.Drawing.Size(238, 20)
        Me.TBPerfil.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Perfil:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(140, 243)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(238, 20)
        Me.TBUsuario.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Usuario:"
        '
        'TBTel
        '
        Me.TBTel.Location = New System.Drawing.Point(140, 124)
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
        Me.LTel.Location = New System.Drawing.Point(19, 119)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(102, 25)
        Me.LTel.TabIndex = 17
        Me.LTel.Text = "Telefono:"
        '
        'TBCont
        '
        Me.TBCont.Location = New System.Drawing.Point(140, 205)
        Me.TBCont.Name = "TBCont"
        Me.TBCont.Size = New System.Drawing.Size(238, 20)
        Me.TBCont.TabIndex = 16
        '
        'LCont
        '
        Me.LCont.AutoSize = True
        Me.LCont.BackColor = System.Drawing.Color.Transparent
        Me.LCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCont.ForeColor = System.Drawing.Color.White
        Me.LCont.Location = New System.Drawing.Point(19, 200)
        Me.LCont.Name = "LCont"
        Me.LCont.Size = New System.Drawing.Size(129, 25)
        Me.LCont.TabIndex = 15
        Me.LCont.Text = "Contraseña:"
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(140, 164)
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
        Me.LCorreo.Location = New System.Drawing.Point(19, 158)
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
        'BAgregar
        '
        Me.BAgregar.Image = Global.proyecto_integrador.My.Resources.Resources.diskette
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(156, 306)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BAgregar.Size = New System.Drawing.Size(110, 47)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
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
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Dni
        '
        Me.Dni.HeaderText = "DNI"
        Me.Dni.Name = "Dni"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Correo
        '
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        '
        'Contraseña
        '
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.Name = "Contraseña"
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        '
        'Perfil
        '
        Me.Perfil.HeaderText = "Perfil"
        Me.Perfil.Name = "Perfil"
        '
        'NuevoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(919, 520)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Name = "NuevoEmpleado"
        Me.Text = "NuevoEmpleado"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents TBPerfil As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBTel As TextBox
    Friend WithEvents LTel As Label
    Friend WithEvents TBCont As TextBox
    Friend WithEvents LCont As Label
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents TBDni As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Dni As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Perfil As DataGridViewTextBoxColumn
End Class
