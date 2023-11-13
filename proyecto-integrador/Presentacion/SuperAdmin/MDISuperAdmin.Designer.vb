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
        Me.BNuevoUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.BEditarEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LEmpleadoN = New System.Windows.Forms.Label()
        Me.LEmpleadoA = New System.Windows.Forms.Label()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMenu, Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(151, 431)
        Me.MenuStrip.TabIndex = 12
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BNuevoUsuario, Me.BEditarEliminar})
        Me.ViewMenu.Image = Global.proyecto_integrador.My.Resources.Resources.vendedor
        Me.ViewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewMenu.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ViewMenu.Size = New System.Drawing.Size(138, 46)
        Me.ViewMenu.Text = "  &Gestion Usuarios"
        '
        'BNuevoUsuario
        '
        Me.BNuevoUsuario.Image = Global.proyecto_integrador.My.Resources.Resources.anadir_amigo1
        Me.BNuevoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BNuevoUsuario.Name = "BNuevoUsuario"
        Me.BNuevoUsuario.Size = New System.Drawing.Size(161, 38)
        Me.BNuevoUsuario.Text = "&Nuevo"
        '
        'BEditarEliminar
        '
        Me.BEditarEliminar.CheckOnClick = True
        Me.BEditarEliminar.Image = Global.proyecto_integrador.My.Resources.Resources.listar
        Me.BEditarEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BEditarEliminar.Name = "BEditarEliminar"
        Me.BEditarEliminar.ShowShortcutKeys = False
        Me.BEditarEliminar.Size = New System.Drawing.Size(161, 38)
        Me.BEditarEliminar.Text = "&Editar/Eliminar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.proyecto_integrador.My.Resources.Resources.copia_de_respaldo
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 46)
        Me.ToolStripMenuItem1.Text = "  &BackUp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bienvenido:"
        '
        'LEmpleadoN
        '
        Me.LEmpleadoN.AutoSize = True
        Me.LEmpleadoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleadoN.Location = New System.Drawing.Point(12, 267)
        Me.LEmpleadoN.Name = "LEmpleadoN"
        Me.LEmpleadoN.Size = New System.Drawing.Size(99, 20)
        Me.LEmpleadoN.TabIndex = 15
        Me.LEmpleadoN.Text = "__________"
        '
        'LEmpleadoA
        '
        Me.LEmpleadoA.AutoSize = True
        Me.LEmpleadoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleadoA.Location = New System.Drawing.Point(12, 313)
        Me.LEmpleadoA.Name = "LEmpleadoA"
        Me.LEmpleadoA.Size = New System.Drawing.Size(99, 20)
        Me.LEmpleadoA.TabIndex = 16
        Me.LEmpleadoA.Text = "__________"
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.logout1
        Me.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCerrarSesion.Location = New System.Drawing.Point(12, 364)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(97, 64)
        Me.BCerrarSesion.TabIndex = 18
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCerrarSesion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 130)
        Me.Label2.MaximumSize = New System.Drawing.Size(130, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(50, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 55)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nota: Para crear un BackUp es necesario que exista la carpeta: C:\Backup"
        '
        'MDISuperAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BCerrarSesion)
        Me.Controls.Add(Me.LEmpleadoA)
        Me.Controls.Add(Me.LEmpleadoN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MDISuperAdmin"
        Me.Text = "MDISuperAdmin"
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
    Friend WithEvents BNuevoUsuario As ToolStripMenuItem
    Friend WithEvents BEditarEliminar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents LEmpleadoN As Label
    Friend WithEvents LEmpleadoA As Label
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents Label2 As Label
End Class
