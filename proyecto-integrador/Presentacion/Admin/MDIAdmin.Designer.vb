<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BListarVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BNuevoProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.BListarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LEmpleadoN = New System.Windows.Forms.Label()
        Me.LEmpleadoA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem5})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(126, 431)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "________"
        '
        'ToolStripMenuItem1ToolStripMenuItem2
        '
        Me.ToolStripMenuItem1ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BListarVentas})
        Me.ToolStripMenuItem1ToolStripMenuItem2.Image = Global.proyecto_integrador.My.Resources.Resources.portapapeles1
        Me.ToolStripMenuItem1ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1ToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1ToolStripMenuItem2.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem1ToolStripMenuItem2.Name = "ToolStripMenuItem1ToolStripMenuItem2"
        Me.ToolStripMenuItem1ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ToolStripMenuItem1ToolStripMenuItem2.ShowShortcutKeys = False
        Me.ToolStripMenuItem1ToolStripMenuItem2.Size = New System.Drawing.Size(113, 46)
        Me.ToolStripMenuItem1ToolStripMenuItem2.Text = "  &Ventas"
        Me.ToolStripMenuItem1ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BListarVentas
        '
        Me.BListarVentas.Image = Global.proyecto_integrador.My.Resources.Resources.lista_prod
        Me.BListarVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BListarVentas.ImageTransparentColor = System.Drawing.Color.Black
        Me.BListarVentas.Name = "BListarVentas"
        Me.BListarVentas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.BListarVentas.ShowShortcutKeys = False
        Me.BListarVentas.Size = New System.Drawing.Size(111, 38)
        Me.BListarVentas.Text = "&Listar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BNuevoProducto, Me.BListarProducto, Me.GestionCategoriaToolStripMenuItem})
        Me.ToolStripMenuItem3.Image = Global.proyecto_integrador.My.Resources.Resources.productos
        Me.ToolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(113, 46)
        Me.ToolStripMenuItem3.Text = "  &Productos"
        '
        'BNuevoProducto
        '
        Me.BNuevoProducto.Image = Global.proyecto_integrador.My.Resources.Resources.agregar_prod1
        Me.BNuevoProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BNuevoProducto.Name = "BNuevoProducto"
        Me.BNuevoProducto.Size = New System.Drawing.Size(184, 38)
        Me.BNuevoProducto.Text = "&Nuevo"
        '
        'BListarProducto
        '
        Me.BListarProducto.Image = Global.proyecto_integrador.My.Resources.Resources.lapiz
        Me.BListarProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BListarProducto.Name = "BListarProducto"
        Me.BListarProducto.Size = New System.Drawing.Size(184, 38)
        Me.BListarProducto.Text = "&Editar/Baja"
        '
        'GestionCategoriaToolStripMenuItem
        '
        Me.GestionCategoriaToolStripMenuItem.Name = "GestionCategoriaToolStripMenuItem"
        Me.GestionCategoriaToolStripMenuItem.Size = New System.Drawing.Size(184, 38)
        Me.GestionCategoriaToolStripMenuItem.Text = "Gestion Categoria"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VendedoresToolStripMenuItem})
        Me.ToolStripMenuItem5.Image = Global.proyecto_integrador.My.Resources.Resources.estadisticas
        Me.ToolStripMenuItem5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem5.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ToolStripMenuItem5.ShowShortcutKeys = False
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(113, 46)
        Me.ToolStripMenuItem5.Text = "  &Reportes"
        Me.ToolStripMenuItem5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem.Text = "Categorias"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoriasToolStripMenuItem.Text = "Clientes"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Productos"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'LEmpleadoN
        '
        Me.LEmpleadoN.AutoSize = True
        Me.LEmpleadoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleadoN.Location = New System.Drawing.Point(12, 255)
        Me.LEmpleadoN.Name = "LEmpleadoN"
        Me.LEmpleadoN.Size = New System.Drawing.Size(81, 20)
        Me.LEmpleadoN.TabIndex = 11
        Me.LEmpleadoN.Text = "________"
        '
        'LEmpleadoA
        '
        Me.LEmpleadoA.AutoSize = True
        Me.LEmpleadoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleadoA.Location = New System.Drawing.Point(12, 306)
        Me.LEmpleadoA.Name = "LEmpleadoA"
        Me.LEmpleadoA.Size = New System.Drawing.Size(81, 20)
        Me.LEmpleadoA.TabIndex = 12
        Me.LEmpleadoA.Text = "________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bienvenido:"
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.logout1
        Me.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCerrarSesion.Location = New System.Drawing.Point(12, 354)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(88, 63)
        Me.BCerrarSesion.TabIndex = 15
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCerrarSesion.UseVisualStyleBackColor = True
        '
        'MDIAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.BCerrarSesion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LEmpleadoA)
        Me.Controls.Add(Me.LEmpleadoN)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIAdmin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripMenuItem1ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BListarVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BNuevoProducto As ToolStripMenuItem
    Friend WithEvents BListarProducto As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents GestionCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LEmpleadoN As Label
    Friend WithEvents LEmpleadoA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
End Class
