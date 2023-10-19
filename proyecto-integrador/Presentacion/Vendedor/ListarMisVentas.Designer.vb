<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarMisVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LVendeN = New System.Windows.Forms.Label()
        Me.LVendeA = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DVGDetalleFac = New System.Windows.Forms.DataGridView()
        Me.DVentas = New System.Windows.Forms.DataGridView()
        Me.BDetalle = New System.Windows.Forms.Button()
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(510, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIS VENTAS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(798, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Vendedor/a"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.BackColor = System.Drawing.Color.Transparent
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(736, 86)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(81, 20)
        Me.LDni.TabIndex = 92
        Me.LDni.Text = "________"
        '
        'LVendeN
        '
        Me.LVendeN.AutoSize = True
        Me.LVendeN.BackColor = System.Drawing.Color.Transparent
        Me.LVendeN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendeN.ForeColor = System.Drawing.Color.White
        Me.LVendeN.Location = New System.Drawing.Point(871, 58)
        Me.LVendeN.Name = "LVendeN"
        Me.LVendeN.Size = New System.Drawing.Size(81, 20)
        Me.LVendeN.TabIndex = 93
        Me.LVendeN.Text = "________"
        '
        'LVendeA
        '
        Me.LVendeA.AutoSize = True
        Me.LVendeA.BackColor = System.Drawing.Color.Transparent
        Me.LVendeA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendeA.ForeColor = System.Drawing.Color.White
        Me.LVendeA.Location = New System.Drawing.Point(871, 102)
        Me.LVendeA.Name = "LVendeA"
        Me.LVendeA.Size = New System.Drawing.Size(81, 20)
        Me.LVendeA.TabIndex = 91
        Me.LVendeA.Text = "________"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 57)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Buscar Fecha "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.White
        Me.LFechaH.Location = New System.Drawing.Point(41, 212)
        Me.LFechaH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(68, 13)
        Me.LFechaH.TabIndex = 99
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.White
        Me.LFechaD.Location = New System.Drawing.Point(39, 169)
        Me.LFechaD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(71, 13)
        Me.LFechaD.TabIndex = 98
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(127, 206)
        Me.DTPHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(83, 20)
        Me.DTPHasta.TabIndex = 97
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(127, 169)
        Me.DTPDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(83, 20)
        Me.DTPDesde.TabIndex = 96
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(840, 523)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DVGDetalleFac
        '
        Me.DVGDetalleFac.AllowUserToAddRows = False
        Me.DVGDetalleFac.AllowUserToDeleteRows = False
        Me.DVGDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDetalleFac.Location = New System.Drawing.Point(524, 262)
        Me.DVGDetalleFac.Margin = New System.Windows.Forms.Padding(2)
        Me.DVGDetalleFac.Name = "DVGDetalleFac"
        Me.DVGDetalleFac.ReadOnly = True
        Me.DVGDetalleFac.RowHeadersWidth = 51
        Me.DVGDetalleFac.RowTemplate.Height = 24
        Me.DVGDetalleFac.Size = New System.Drawing.Size(529, 249)
        Me.DVGDetalleFac.TabIndex = 102
        '
        'DVentas
        '
        Me.DVentas.AllowUserToOrderColumns = True
        Me.DVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVentas.Location = New System.Drawing.Point(-10, 262)
        Me.DVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.DVentas.Name = "DVentas"
        Me.DVentas.RowHeadersWidth = 51
        Me.DVentas.RowTemplate.Height = 24
        Me.DVentas.Size = New System.Drawing.Size(512, 249)
        Me.DVentas.TabIndex = 100
        '
        'BDetalle
        '
        Me.BDetalle.Location = New System.Drawing.Point(204, 523)
        Me.BDetalle.Name = "BDetalle"
        Me.BDetalle.Size = New System.Drawing.Size(92, 39)
        Me.BDetalle.TabIndex = 105
        Me.BDetalle.Text = "Ver detalle"
        Me.BDetalle.UseVisualStyleBackColor = True
        '
        'ListarMisVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.BDetalle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DVGDetalleFac)
        Me.Controls.Add(Me.DVentas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LVendeN)
        Me.Controls.Add(Me.LVendeA)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarMisVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListarVentas"
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LVendeN As Label
    Friend WithEvents LVendeA As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents DVGDetalleFac As DataGridView
    Friend WithEvents DVentas As DataGridView
    Friend WithEvents BDetalle As Button
End Class
