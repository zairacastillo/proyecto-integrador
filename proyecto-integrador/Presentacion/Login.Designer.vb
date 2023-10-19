<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TUsuario = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.BIniciarV = New System.Windows.Forms.Button()
        Me.BIniciarA = New System.Windows.Forms.Button()
        Me.BIniciarS = New System.Windows.Forms.Button()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BTIniciar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TUsuario
        '
        Me.TUsuario.AutoSize = True
        Me.TUsuario.BackColor = System.Drawing.Color.Transparent
        Me.TUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TUsuario.Location = New System.Drawing.Point(83, 57)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(71, 20)
        Me.TUsuario.TabIndex = 0
        Me.TUsuario.Text = "Usuario"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.BackColor = System.Drawing.Color.Transparent
        Me.LContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LContraseña.Location = New System.Drawing.Point(83, 123)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(102, 20)
        Me.LContraseña.TabIndex = 1
        Me.LContraseña.Text = "Contraseña"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(211, 54)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(147, 20)
        Me.TBUsuario.TabIndex = 2
        '
        'BIniciarV
        '
        Me.BIniciarV.Location = New System.Drawing.Point(28, 174)
        Me.BIniciarV.Name = "BIniciarV"
        Me.BIniciarV.Size = New System.Drawing.Size(117, 23)
        Me.BIniciarV.TabIndex = 4
        Me.BIniciarV.Text = "Iniciar Vendedor"
        Me.BIniciarV.UseVisualStyleBackColor = True
        '
        'BIniciarA
        '
        Me.BIniciarA.Location = New System.Drawing.Point(183, 174)
        Me.BIniciarA.Name = "BIniciarA"
        Me.BIniciarA.Size = New System.Drawing.Size(117, 23)
        Me.BIniciarA.TabIndex = 5
        Me.BIniciarA.Text = "Iniciar Admi"
        Me.BIniciarA.UseVisualStyleBackColor = True
        '
        'BIniciarS
        '
        Me.BIniciarS.Location = New System.Drawing.Point(322, 174)
        Me.BIniciarS.Name = "BIniciarS"
        Me.BIniciarS.Size = New System.Drawing.Size(117, 23)
        Me.BIniciarS.TabIndex = 6
        Me.BIniciarS.Text = "Iniciar SuperAdmi"
        Me.BIniciarS.UseVisualStyleBackColor = True
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(206, 123)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(152, 20)
        Me.TBContraseña.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.PictureBox1.Location = New System.Drawing.Point(394, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 99)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(486, 182)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 23
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BTIniciar
        '
        Me.BTIniciar.Location = New System.Drawing.Point(28, 80)
        Me.BTIniciar.Name = "BTIniciar"
        Me.BTIniciar.Size = New System.Drawing.Size(75, 35)
        Me.BTIniciar.TabIndex = 24
        Me.BTIniciar.Text = "Iniciar Sesion"
        Me.BTIniciar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 220)
        Me.Controls.Add(Me.BTIniciar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.BIniciarS)
        Me.Controls.Add(Me.BIniciarA)
        Me.Controls.Add(Me.BIniciarV)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.TUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TUsuario As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents BIniciarV As Button
    Friend WithEvents BIniciarA As Button
    Friend WithEvents BIniciarS As Button
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BTIniciar As Button
End Class
