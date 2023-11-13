<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RPorProducto
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BNoFiltrar = New System.Windows.Forms.Button()
        Me.BFiltrar = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart20 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart10 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LTotalRecaudado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chart50 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart40 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chart30 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Chart20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BNoFiltrar
        '
        Me.BNoFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BNoFiltrar.Location = New System.Drawing.Point(1300, 220)
        Me.BNoFiltrar.Name = "BNoFiltrar"
        Me.BNoFiltrar.Size = New System.Drawing.Size(87, 56)
        Me.BNoFiltrar.TabIndex = 139
        Me.BNoFiltrar.Text = "Historico"
        Me.BNoFiltrar.UseVisualStyleBackColor = True
        '
        'BFiltrar
        '
        Me.BFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BFiltrar.Location = New System.Drawing.Point(1300, 145)
        Me.BFiltrar.Name = "BFiltrar"
        Me.BFiltrar.Size = New System.Drawing.Size(87, 56)
        Me.BFiltrar.TabIndex = 138
        Me.BFiltrar.Text = "Filtrar"
        Me.BFiltrar.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.Black
        Me.LFechaH.Location = New System.Drawing.Point(1297, 56)
        Me.LFechaH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(68, 13)
        Me.LFechaH.TabIndex = 137
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.Black
        Me.LFechaD.Location = New System.Drawing.Point(1129, 56)
        Me.LFechaD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(71, 13)
        Me.LFechaD.TabIndex = 136
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(1300, 81)
        Me.DTPHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(83, 20)
        Me.DTPHasta.TabIndex = 135
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(1132, 81)
        Me.DTPDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(83, 20)
        Me.DTPDesde.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(801, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Productos Mas Vendidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Productos Vendidos Por Meses"
        '
        'Chart20
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart20.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart20.Legends.Add(Legend1)
        Me.Chart20.Location = New System.Drawing.Point(23, 52)
        Me.Chart20.Name = "Chart20"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart20.Series.Add(Series1)
        Me.Chart20.Size = New System.Drawing.Size(681, 291)
        Me.Chart20.TabIndex = 131
        Me.Chart20.Text = "Chart2"
        '
        'Chart10
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart10.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart10.Legends.Add(Legend2)
        Me.Chart10.Location = New System.Drawing.Point(742, 52)
        Me.Chart10.Name = "Chart10"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.YValuesPerPoint = 2
        Me.Chart10.Series.Add(Series2)
        Me.Chart10.Size = New System.Drawing.Size(300, 291)
        Me.Chart10.TabIndex = 130
        Me.Chart10.Text = "Chart1"
        Me.Chart10.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'LTotalRecaudado
        '
        Me.LTotalRecaudado.AutoSize = True
        Me.LTotalRecaudado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalRecaudado.ForeColor = System.Drawing.Color.LimeGreen
        Me.LTotalRecaudado.Location = New System.Drawing.Point(256, 720)
        Me.LTotalRecaudado.MaximumSize = New System.Drawing.Size(0, 20)
        Me.LTotalRecaudado.MinimumSize = New System.Drawing.Size(0, 20)
        Me.LTotalRecaudado.Name = "LTotalRecaudado"
        Me.LTotalRecaudado.Size = New System.Drawing.Size(24, 20)
        Me.LTotalRecaudado.TabIndex = 147
        Me.LTotalRecaudado.Text = "$"
        Me.LTotalRecaudado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 720)
        Me.Label6.MaximumSize = New System.Drawing.Size(0, 20)
        Me.Label6.MinimumSize = New System.Drawing.Size(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 20)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "Total Recaudado: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Recaudado Por Fechas"
        '
        'Chart50
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart50.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart50.Legends.Add(Legend3)
        Me.Chart50.Location = New System.Drawing.Point(23, 413)
        Me.Chart50.Name = "Chart50"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart50.Series.Add(Series3)
        Me.Chart50.Size = New System.Drawing.Size(681, 276)
        Me.Chart50.TabIndex = 144
        Me.Chart50.Text = "Chart2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1108, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 13)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Vendedores Que Mas Vendieron"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(760, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Clientes Que Mas Compraron"
        '
        'Chart40
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart40.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart40.Legends.Add(Legend4)
        Me.Chart40.Location = New System.Drawing.Point(742, 413)
        Me.Chart40.Name = "Chart40"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart40.Series.Add(Series4)
        Me.Chart40.Size = New System.Drawing.Size(300, 276)
        Me.Chart40.TabIndex = 141
        Me.Chart40.Text = "Chart1"
        '
        'chart30
        '
        ChartArea5.Name = "ChartArea1"
        Me.chart30.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chart30.Legends.Add(Legend5)
        Me.chart30.Location = New System.Drawing.Point(1079, 413)
        Me.chart30.Name = "chart30"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Series5.YValuesPerPoint = 4
        Me.chart30.Series.Add(Series5)
        Me.chart30.Size = New System.Drawing.Size(300, 276)
        Me.chart30.TabIndex = 140
        Me.chart30.Text = "Chart1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todos"})
        Me.ComboBox1.Location = New System.Drawing.Point(1132, 145)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox1.TabIndex = 148
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1129, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Elegir Producto"
        '
        'RPorProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 759)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LTotalRecaudado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Chart50)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chart40)
        Me.Controls.Add(Me.chart30)
        Me.Controls.Add(Me.BNoFiltrar)
        Me.Controls.Add(Me.BFiltrar)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart20)
        Me.Controls.Add(Me.Chart10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RPorProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "otroReporte"
        CType(Me.Chart20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BNoFiltrar As Button
    Friend WithEvents BFiltrar As Button
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart20 As DataVisualization.Charting.Chart
    Friend WithEvents Chart10 As DataVisualization.Charting.Chart
    Friend WithEvents LTotalRecaudado As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart50 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart40 As DataVisualization.Charting.Chart
    Friend WithEvents chart30 As DataVisualization.Charting.Chart
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
End Class
