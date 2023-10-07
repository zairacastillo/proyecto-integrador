<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SoloListarEmpleados
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
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BBuscarA = New System.Windows.Forms.Button()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.BBuscarU = New System.Windows.Forms.Button()
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
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.DNI, Me.Telefono, Me.Correo, Me.Usuario, Me.Perfil})
        Me.DGV1.Location = New System.Drawing.Point(-27, 255)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(932, 189)
        Me.DGV1.TabIndex = 33
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
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
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
        'BBuscarA
        '
        Me.BBuscarA.Location = New System.Drawing.Point(380, 57)
        Me.BBuscarA.Name = "BBuscarA"
        Me.BBuscarA.Size = New System.Drawing.Size(65, 30)
        Me.BBuscarA.TabIndex = 32
        Me.BBuscarA.Text = "Buscar"
        Me.BBuscarA.UseVisualStyleBackColor = True
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.White
        Me.LCorreo.Location = New System.Drawing.Point(451, 57)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(202, 25)
        Me.LCorreo.TabIndex = 31
        Me.LCorreo.Text = "Buscar por Usuario:"
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.BackColor = System.Drawing.Color.Transparent
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.ForeColor = System.Drawing.Color.White
        Me.LCliente.Location = New System.Drawing.Point(-2, 56)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(205, 25)
        Me.LCliente.TabIndex = 30
        Me.LCliente.Text = "Buscar por Apellido:"
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(207, 61)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(169, 20)
        Me.TBApellido.TabIndex = 29
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(645, 62)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(169, 20)
        Me.TBUsuario.TabIndex = 34
        '
        'BBuscarU
        '
        Me.BBuscarU.Location = New System.Drawing.Point(820, 57)
        Me.BBuscarU.Name = "BBuscarU"
        Me.BBuscarU.Size = New System.Drawing.Size(65, 30)
        Me.BBuscarU.TabIndex = 35
        Me.BBuscarU.Text = "Buscar"
        Me.BBuscarU.UseVisualStyleBackColor = True
        '
        'SoloListarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(897, 457)
        Me.Controls.Add(Me.BBuscarU)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.BBuscarA)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.LCliente)
        Me.Controls.Add(Me.TBApellido)
        Me.Name = "SoloListarEmpleados"
        Me.Text = "ListarEmpleados"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents BBuscarA As Button
    Friend WithEvents LCorreo As Label
    Friend WithEvents LCliente As Label
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Perfil As DataGridViewTextBoxColumn
    Friend WithEvents BBuscarU As Button
End Class
