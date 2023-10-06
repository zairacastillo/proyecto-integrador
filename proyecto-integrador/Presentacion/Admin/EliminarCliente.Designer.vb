<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EliminarCliente
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBBuscarAp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.BBuscarD = New System.Windows.Forms.Button()
        Me.BBuscarA = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(466, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Buscar Cliente Apellido"
        '
        'TBBuscarAp
        '
        Me.TBBuscarAp.Location = New System.Drawing.Point(667, 22)
        Me.TBBuscarAp.Name = "TBBuscarAp"
        Me.TBBuscarAp.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscarAp.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar Cliente DNI"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(180, 21)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(182, 20)
        Me.TBBuscar.TabIndex = 17
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(0, 62)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV1.Size = New System.Drawing.Size(971, 230)
        Me.DGV1.TabIndex = 16
        '
        'BBuscarD
        '
        Me.BBuscarD.Location = New System.Drawing.Point(368, 19)
        Me.BBuscarD.Name = "BBuscarD"
        Me.BBuscarD.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarD.TabIndex = 25
        Me.BBuscarD.Text = "Buscar"
        Me.BBuscarD.UseVisualStyleBackColor = True
        '
        'BBuscarA
        '
        Me.BBuscarA.Location = New System.Drawing.Point(855, 21)
        Me.BBuscarA.Name = "BBuscarA"
        Me.BBuscarA.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarA.TabIndex = 26
        Me.BBuscarA.Text = "Buscar"
        Me.BBuscarA.UseVisualStyleBackColor = True
        '
        'EliminarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_integrador.My.Resources.Resources.cuadros_negros_734708
        Me.ClientSize = New System.Drawing.Size(956, 304)
        Me.Controls.Add(Me.BBuscarA)
        Me.Controls.Add(Me.BBuscarD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBBuscarAp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "EliminarCliente"
        Me.Text = "EliminarCliente"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TBBuscarAp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents BBuscarD As Button
    Friend WithEvents BBuscarA As Button
End Class
