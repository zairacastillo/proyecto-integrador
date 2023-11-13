<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIVendedor
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LEmpleadoN = New System.Windows.Forms.Label()
        Me.LEmpleadoA = New System.Windows.Forms.Label()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
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
        'MenuStrip
        '
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewMenu, Me.EditMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(117, 431)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.FileMenu.Image = Global.proyecto_integrador.My.Resources.Resources.cliente
        Me.FileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileMenu.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.FileMenu.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.FileMenu.ShowShortcutKeys = False
        Me.FileMenu.Size = New System.Drawing.Size(104, 46)
        Me.FileMenu.Text = "  &Clientes"
        Me.FileMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.proyecto_integrador.My.Resources.Resources.anadir_amigo1
        Me.NuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(125, 38)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.EditarToolStripMenuItem.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.EditarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(125, 38)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Image = Global.proyecto_integrador.My.Resources.Resources.lista_prod1
        Me.ViewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewMenu.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ViewMenu.Size = New System.Drawing.Size(104, 46)
        Me.ViewMenu.Text = "  &Ventas"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Image = Global.proyecto_integrador.My.Resources.Resources.anadir_amigo1
        Me.NuevoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(125, 38)
        Me.NuevoToolStripMenuItem1.Text = "&Nuevo"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.StatusBarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.ShowShortcutKeys = False
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(125, 38)
        Me.StatusBarToolStripMenuItem.Text = "&Listar"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem})
        Me.EditMenu.Image = Global.proyecto_integrador.My.Resources.Resources.productos
        Me.EditMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditMenu.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.EditMenu.Size = New System.Drawing.Size(104, 46)
        Me.EditMenu.Text = "  &Productos"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Image = Global.proyecto_integrador.My.Resources.Resources.lista_prod1
        Me.ListarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(118, 38)
        Me.ListarToolStripMenuItem.Text = "&Listar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Bienvenido:"
        '
        'LEmpleadoN
        '
        Me.LEmpleadoN.AutoSize = True
        Me.LEmpleadoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleadoN.Location = New System.Drawing.Point(12, 276)
        Me.LEmpleadoN.Name = "LEmpleadoN"
        Me.LEmpleadoN.Size = New System.Drawing.Size(81, 20)
        Me.LEmpleadoN.TabIndex = 19
        Me.LEmpleadoN.Text = "________"
        '
        'LEmpleadoA
        '
        Me.LEmpleadoA.AutoSize = True
        Me.LEmpleadoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleadoA.Location = New System.Drawing.Point(12, 320)
        Me.LEmpleadoA.Name = "LEmpleadoA"
        Me.LEmpleadoA.Size = New System.Drawing.Size(81, 20)
        Me.LEmpleadoA.TabIndex = 20
        Me.LEmpleadoA.Text = "________"
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.logout1
        Me.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCerrarSesion.Location = New System.Drawing.Point(12, 343)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(81, 73)
        Me.BCerrarSesion.TabIndex = 22
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCerrarSesion.UseVisualStyleBackColor = True
        '
        'MDIVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.BCerrarSesion)
        Me.Controls.Add(Me.LEmpleadoA)
        Me.Controls.Add(Me.LEmpleadoN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MDIVendedor"
        Me.Text = "MDIVendedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents LEmpleadoN As Label
    Friend WithEvents LEmpleadoA As Label
    Friend WithEvents BCerrarSesion As Button
End Class
