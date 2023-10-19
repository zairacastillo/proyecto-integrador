<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionCategoria
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
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.LID = New System.Windows.Forms.Label()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.LBuscarCategoria = New System.Windows.Forms.Label()
        Me.TBBuscarDesc = New System.Windows.Forms.TextBox()
        Me.BBuscarDesc = New System.Windows.Forms.Button()
        Me.BNuevaCategoria = New System.Windows.Forms.Button()
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
        Me.DGV1.Location = New System.Drawing.Point(22, 79)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(933, 164)
        Me.DGV1.TabIndex = 5
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPrincipal.Controls.Add(Me.TBID)
        Me.PanelPrincipal.Controls.Add(Me.LID)
        Me.PanelPrincipal.Controls.Add(Me.TBDescripcion)
        Me.PanelPrincipal.Controls.Add(Me.LDescripcion)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(159, 353)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(462, 142)
        Me.PanelPrincipal.TabIndex = 3
        '
        'TBID
        '
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(165, 81)
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
        Me.LID.Location = New System.Drawing.Point(16, 76)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(38, 25)
        Me.LID.TabIndex = 19
        Me.LID.Text = "ID:"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(165, 35)
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(254, 20)
        Me.TBDescripcion.TabIndex = 4
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.ForeColor = System.Drawing.Color.White
        Me.LDescripcion.Location = New System.Drawing.Point(16, 30)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(131, 25)
        Me.LDescripcion.TabIndex = 0
        Me.LDescripcion.Text = "Descripcion:"
        '
        'BEditar
        '
        Me.BEditar.Image = Global.proyecto_integrador.My.Resources.Resources.lapiz
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BEditar.Location = New System.Drawing.Point(732, 301)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(87, 68)
        Me.BEditar.TabIndex = 10
        Me.BEditar.Text = "Guardar Cambios"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cerrar
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.Location = New System.Drawing.Point(732, 517)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(87, 67)
        Me.BCancelar.TabIndex = 11
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'LBuscarCategoria
        '
        Me.LBuscarCategoria.AutoSize = True
        Me.LBuscarCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LBuscarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.LBuscarCategoria.Location = New System.Drawing.Point(197, 28)
        Me.LBuscarCategoria.Name = "LBuscarCategoria"
        Me.LBuscarCategoria.Size = New System.Drawing.Size(252, 20)
        Me.LBuscarCategoria.TabIndex = 14
        Me.LBuscarCategoria.Text = "Buscar Descripcion Categoria:"
        '
        'TBBuscarDesc
        '
        Me.TBBuscarDesc.Location = New System.Drawing.Point(465, 28)
        Me.TBBuscarDesc.Name = "TBBuscarDesc"
        Me.TBBuscarDesc.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscarDesc.TabIndex = 13
        '
        'BBuscarDesc
        '
        Me.BBuscarDesc.Location = New System.Drawing.Point(653, 26)
        Me.BBuscarDesc.Name = "BBuscarDesc"
        Me.BBuscarDesc.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarDesc.TabIndex = 16
        Me.BBuscarDesc.Text = "Buscar"
        Me.BBuscarDesc.UseVisualStyleBackColor = True
        '
        'BNuevaCategoria
        '
        Me.BNuevaCategoria.Location = New System.Drawing.Point(732, 402)
        Me.BNuevaCategoria.Name = "BNuevaCategoria"
        Me.BNuevaCategoria.Size = New System.Drawing.Size(87, 67)
        Me.BNuevaCategoria.TabIndex = 17
        Me.BNuevaCategoria.Text = "Nueva Categoria"
        Me.BNuevaCategoria.UseVisualStyleBackColor = True
        '
        'GestionCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.BNuevaCategoria)
        Me.Controls.Add(Me.BBuscarDesc)
        Me.Controls.Add(Me.LBuscarCategoria)
        Me.Controls.Add(Me.TBBuscarDesc)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionCategoria"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents LDescripcion As Label
    Friend WithEvents BEditar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents LBuscarCategoria As Label
    Friend WithEvents TBBuscarDesc As TextBox
    Friend WithEvents BBuscarDesc As Button
    Friend WithEvents BNuevaCategoria As Button
    Friend WithEvents TBID As TextBox
    Friend WithEvents LID As Label
End Class
