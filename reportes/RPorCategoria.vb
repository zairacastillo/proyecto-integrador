Imports System.Windows.Forms.DataVisualization.Charting
Public Class RPorCategoria

    Dim fechaDesde
    Dim fechaHasta
    Dim idCategoria
    Dim nombCategoria
    Public Sub New(p_fechaDesde As Date, p_fechaHasta As Date, p_idCategoria As Integer, p_nombCategoria As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        fechaDesde = p_fechaDesde
        fechaHasta = p_fechaHasta
        idCategoria = p_idCategoria
        nombCategoria = p_nombCategoria
    End Sub
    Private Sub RPorCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RP_CategoriasMasVendidos(Chart10)
        RP_CategoriaPorMes(Chart20)
        RP_EmpleadoMasVendioCateg(chart30)
        RP_ClientesMasComproCateg(Chart40)
    End Sub



    Function RP_CategoriasMasVendidos(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = categoriasMasVendidas(fechaDesde, fechaHasta)

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
        Dim query = categoriaPorMes(fechaDesde, fechaHasta, idCategoria)

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

        p_chart.Series(0).Name = nombCategoria

        Return 0
    End Function

    Function RP_EmpleadoMasVendioCateg(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = empleadosMasVendioCateg(fechaDesde, fechaHasta, idCategoria)

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
        Dim query = clientesMasComproCateg(fechaDesde, fechaHasta, idCategoria)


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

End Class