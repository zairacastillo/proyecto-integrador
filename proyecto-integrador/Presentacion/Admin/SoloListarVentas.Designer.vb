<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoloListarVentas
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DVGDetalleFac = New System.Windows.Forms.DataGridView()
        Me.DVentas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BDetalle = New System.Windows.Forms.Button()
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(778, 598)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 113
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DVGDetalleFac
        '
        Me.DVGDetalleFac.AllowUserToAddRows = False
        Me.DVGDetalleFac.AllowUserToDeleteRows = False
        Me.DVGDetalleFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DVGDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDetalleFac.Location = New System.Drawing.Point(78, 370)
        Me.DVGDetalleFac.Margin = New System.Windows.Forms.Padding(2)
        Me.DVGDetalleFac.Name = "DVGDetalleFac"
        Me.DVGDetalleFac.ReadOnly = True
        Me.DVGDetalleFac.RowHeadersWidth = 51
        Me.DVGDetalleFac.RowTemplate.Height = 24
        Me.DVGDetalleFac.Size = New System.Drawing.Size(796, 209)
        Me.DVGDetalleFac.TabIndex = 112
        '
        'DVentas
        '
        Me.DVentas.AllowUserToAddRows = False
        Me.DVentas.AllowUserToDeleteRows = False
        Me.DVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVentas.Location = New System.Drawing.Point(78, 157)
        Me.DVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.DVentas.Name = "DVentas"
        Me.DVentas.ReadOnly = True
        Me.DVentas.RowHeadersWidth = 51
        Me.DVentas.RowTemplate.Height = 24
        Me.DVentas.Size = New System.Drawing.Size(796, 209)
        Me.DVentas.TabIndex = 111
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 57)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Buscar Fecha "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.White
        Me.LFechaH.Location = New System.Drawing.Point(211, 128)
        Me.LFechaH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(68, 13)
        Me.LFechaH.TabIndex = 110
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.White
        Me.LFechaD.Location = New System.Drawing.Point(209, 85)
        Me.LFechaD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(71, 13)
        Me.LFechaD.TabIndex = 109
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(297, 122)
        Me.DTPHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(83, 20)
        Me.DTPHasta.TabIndex = 108
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(297, 85)
        Me.DTPDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(83, 20)
        Me.DTPDesde.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(402, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = " VENTAS "
        '
        'CBEmpleados
        '
        Me.CBEmpleados.FormattingEnabled = True
        Me.CBEmpleados.Location = New System.Drawing.Point(698, 78)
        Me.CBEmpleados.Name = "CBEmpleados"
        Me.CBEmpleados.Size = New System.Drawing.Size(176, 21)
        Me.CBEmpleados.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(749, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Empleados"
        '
        'BDetalle
        '
        Me.BDetalle.Location = New System.Drawing.Point(628, 591)
        Me.BDetalle.Name = "BDetalle"
        Me.BDetalle.Size = New System.Drawing.Size(92, 39)
        Me.BDetalle.TabIndex = 116
        Me.BDetalle.Text = "Ver detalle"
        Me.BDetalle.UseVisualStyleBackColor = True
        '
        'SoloListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.BDetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBEmpleados)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DVGDetalleFac)
        Me.Controls.Add(Me.DVentas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SoloListarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SoloListarVentas"
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents DVGDetalleFac As DataGridView
    Friend WithEvents DVentas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents CBEmpleados As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BDetalle As Button
End Class
