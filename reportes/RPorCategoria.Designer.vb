<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPorCategoria
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
        Me.Chart40 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chart30 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart20 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart10 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Chart40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart40
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart40.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart40.Legends.Add(Legend1)
        Me.Chart40.Location = New System.Drawing.Point(21, 394)
        Me.Chart40.Name = "Chart40"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart40.Series.Add(Series1)
        Me.Chart40.Size = New System.Drawing.Size(300, 257)
        Me.Chart40.TabIndex = 11
        Me.Chart40.Text = "Chart1"
        '
        'chart30
        '
        ChartArea2.Name = "ChartArea1"
        Me.chart30.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chart30.Legends.Add(Legend2)
        Me.chart30.Location = New System.Drawing.Point(380, 394)
        Me.chart30.Name = "chart30"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.YValuesPerPoint = 4
        Me.chart30.Series.Add(Series2)
        Me.chart30.Size = New System.Drawing.Size(300, 257)
        Me.chart30.TabIndex = 10
        Me.chart30.Text = "Chart1"
        '
        'Chart20
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart20.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart20.Legends.Add(Legend3)
        Me.Chart20.Location = New System.Drawing.Point(21, 52)
        Me.Chart20.Name = "Chart20"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart20.Series.Add(Series3)
        Me.Chart20.Size = New System.Drawing.Size(659, 272)
        Me.Chart20.TabIndex = 9
        Me.Chart20.Text = "Chart2"
        '
        'Chart10
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart10.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart10.Legends.Add(Legend4)
        Me.Chart10.Location = New System.Drawing.Point(718, 52)
        Me.Chart10.Name = "Chart10"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Series4.YValuesPerPoint = 2
        Me.Chart10.Series.Add(Series4)
        Me.Chart10.Size = New System.Drawing.Size(300, 272)
        Me.Chart10.TabIndex = 8
        Me.Chart10.Text = "Chart1"
        Me.Chart10.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Categoria Vendida Por Meses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(774, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Categorias Mas Vendidas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Clientes Que Mas Compraron La Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Vendedores Que Mas Vendieron La Categoria"
        '
        'RPorCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 741)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart40)
        Me.Controls.Add(Me.chart30)
        Me.Controls.Add(Me.Chart20)
        Me.Controls.Add(Me.Chart10)
        Me.Name = "RPorCategoria"
        Me.Text = "RPorCategoria"
        CType(Me.Chart40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart40 As DataVisualization.Charting.Chart
    Friend WithEvents chart30 As DataVisualization.Charting.Chart
    Friend WithEvents Chart20 As DataVisualization.Charting.Chart
    Friend WithEvents Chart10 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
