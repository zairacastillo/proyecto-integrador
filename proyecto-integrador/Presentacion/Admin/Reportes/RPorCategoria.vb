Imports System.Windows.Forms.DataVisualization.Charting
Public Class RPorCategoria
    Dim OBJCategorias As New Dcategoria
    Dim filtrarFecha = False
    Dim fechaDesde = Date.Now
    Dim fechaHasta = Date.Now

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ComboBox1.DataSource = OBJCategorias.ObtenerCategorias()
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"
    End Sub

    Private Sub RPorCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart10.Series(0).Points.Clear()
        Chart20.Series(0).Points.Clear()
        chart30.Series(0).Points.Clear()
        Chart40.Series(0).Points.Clear()
        Chart50.Series(0).Points.Clear()
        RP_CategoriasMasVendidos(Chart10)
        RP_CategoriaPorMes(Chart20)
        RP_EmpleadoMasVendioCateg(chart30)
        RP_ClientesMasComproCateg(Chart40)
        RP_RecaudadoPorMes(Chart50)
        LTotalRecaudado.Text = "$ " & TotalRecaudadoCategoria(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)
    End Sub



    Function RP_CategoriasMasVendidos(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = categoriasMasVendidas(fechaDesde, fechaHasta, filtrarFecha)

        Dim index As Integer = 0
        ' Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda

        For Each resultado In query
            p_chart.Series(0).Points.AddXY(resultado.Categoria, resultado.Cantidad)
            p_chart.Series(0).Points(p_chart.Series(0).Points.Count - 1).LegendText = resultado.Categoria
            'Establecer las etiquetas en el eje X del gráfico
            p_chart.Series(0).Points(index).AxisLabel = resultado.Cantidad
            index = index + 1
        Next

        ' Asignar nombre al eje X
        p_chart.ChartAreas(0).AxisX.Title = "Categorias"
        ' Asignar nombre al eje y
        p_chart.ChartAreas(0).AxisY.Title = "Ventas"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Categorias" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        Return 0
    End Function

    Function RP_CategoriaPorMes(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = categoriaPorMes(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)

        Dim index As Integer = 0
        ' Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
        Dim nombresMeses() As String = {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

        For Each resultado In query
            p_chart.Series(0).Points.AddXY(resultado.Mes, resultado.Cantidad)
            p_chart.Series(0).Points(p_chart.Series(0).Points.Count - 1).LegendText = resultado.Mes
            'Establecer las etiquetas en el eje X del gráfico
            p_chart.Series(0).Points(index).AxisLabel = nombresMeses(resultado.Mes)
            index = index + 1
        Next

        ' Asignar nombre al eje X
        p_chart.ChartAreas(0).AxisX.Title = "Meses"
        ' Asignar nombre al eje y
        p_chart.ChartAreas(0).AxisY.Title = "Ventas"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Categoria" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        p_chart.Series(0).Name = ComboBox1.Text
        Return 0
    End Function

    Function RP_EmpleadoMasVendioCateg(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = empleadosMasVendioCateg(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)

        Dim index As Integer = 0
        ' Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda

        For Each resultado In query
            p_chart.Series(0).Points.AddXY(resultado.Vendedor, resultado.Cantidad)
            p_chart.Series(0).Points(p_chart.Series(0).Points.Count - 1).LegendText = resultado.Vendedor
            'Establecer las etiquetas en el eje X del gráfico
            p_chart.Series(0).Points(index).AxisLabel = resultado.Cantidad
            index = index + 1
        Next

        ' Asignar nombre al eje X
        p_chart.ChartAreas(0).AxisX.Title = "Vendedores"
        ' Asignar nombre al eje y
        p_chart.ChartAreas(0).AxisY.Title = "Ventas"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Vendedores" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        Return 0
    End Function

    Function RP_ClientesMasComproCateg(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = clientesMasComproCateg(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)


        Dim index As Integer = 0
        ' Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda

        For Each resultado In query
            p_chart.Series(0).Points.AddXY(resultado.Cliente, resultado.Cantidad)
            p_chart.Series(0).Points(p_chart.Series(0).Points.Count - 1).LegendText = resultado.Cliente
            'Establecer las etiquetas en el eje X del gráfico
            p_chart.Series(0).Points(index).AxisLabel = resultado.Cantidad
            index = index + 1
        Next

        ' Asignar nombre al eje X
        p_chart.ChartAreas(0).AxisX.Title = "Clientes"
        ' Asignar nombre al eje y
        p_chart.ChartAreas(0).AxisY.Title = "Compras"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Clientes" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        p_chart.Series(0).Name = "Clientes"

        Return 0
    End Function


    Function RP_RecaudadoPorMes(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = RecaudadoCategoriaPorFecha(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)

        Dim index As Integer = 0
        ' Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
        Dim nombresMeses() As String = {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

        For Each resultado In query
            p_chart.Series(0).Points.AddXY(resultado.Mes, resultado.Cantidad)
            p_chart.Series(0).Points(p_chart.Series(0).Points.Count - 1).LegendText = resultado.Mes
            'Establecer las etiquetas en el eje X del gráfico
            p_chart.Series(0).Points(index).AxisLabel = nombresMeses(resultado.Mes)
            index = index + 1
        Next

        ' Asignar nombre al eje X
        p_chart.ChartAreas(0).AxisX.Title = "Meses"
        ' Asignar nombre al eje y
        p_chart.ChartAreas(0).AxisY.Title = "Totales"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Categoria" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        p_chart.Series(0).Name = ComboBox1.Text
        Return 0
    End Function

    Private Sub BNoFiltrar_Click(sender As Object, e As EventArgs) Handles BNoFiltrar.Click
        filtrarFecha = False
        fechaDesde = DTPDesde.Value.Date
        fechaHasta = DTPHasta.Value.Date.AddDays(1)
        RPorCategoria_Load(sender, e)
    End Sub

    Private Sub BFiltrar_Click(sender As Object, e As EventArgs) Handles BFiltrar.Click
        Dim fecha As Date = System.DateTime.Now
        If DTPDesde.Value > DTPHasta.Value Or DTPHasta.Value > fecha Or DTPDesde.Value > fecha Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else
            filtrarFecha = True
            fechaDesde = DTPDesde.Value.Date
            fechaHasta = DTPHasta.Value.Date.AddDays(1)
            RPorCategoria_Load(sender, e)
        End If
    End Sub


End Class