<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDISuperAdmin
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMenu, Me.EditMenu, Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(126, 431)
        Me.MenuStrip.TabIndex = 12
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Image = Global.proyecto_integrador.My.Resources.Resources.vendedor
        Me.ViewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewMenu.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ViewMenu.Size = New System.Drawing.Size(113, 46)
        Me.ViewMenu.Text = "  &Empleados"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Image = Global.proyecto_integrador.My.Resources.Resources.anadir_amigo1
        Me.NuevoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(196, 38)
        Me.NuevoToolStripMenuItem1.Text = "&Nuevo"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.StatusBarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.ShowShortcutKeys = False
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.StatusBarToolStripMenuItem.Text = "&Editar/Eliminar"
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
        Me.EditMenu.Size = New System.Drawing.Size(113, 46)
        Me.EditMenu.Text = "  &Productos"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Image = Global.proyecto_integrador.My.Resources.Resources.lista_prod1
        Me.ListarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.ListarToolStripMenuItem.Text = "&Listar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Image = Global.proyecto_integrador.My.Resources.Resources.lista_prod1
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 46)
        Me.ToolStripMenuItem1.Text = "  &Ventas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.CheckOnClick = True
        Me.ToolStripMenuItem3.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShowShortcutKeys = False
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(196, 38)
        Me.ToolStripMenuItem3.Text = "&Listar"
        '
        'MDISuperAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "MDISuperAdmin"
        Me.Text = "MDISuperAdmin"
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
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
