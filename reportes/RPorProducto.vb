Imports System.Windows.Forms.DataVisualization.Charting
Public Class RPorProducto

    Dim fechaDesde
    Dim fechaHasta
    Dim idProducto
    Dim nombProducto
    Public Sub New(p_fechaDesde As Date, p_fechaHasta As Date, p_idProducto As Integer, p_nombProducto As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        fechaDesde = p_fechaDesde
        fechaHasta = p_fechaHasta
        idProducto = p_idProducto
        nombProducto = p_nombProducto
    End Sub


    Private Sub otroReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RP_ProductosMasVendidos(Chart10)
        RP_ProductoPorMes(Chart20)
        RP_EmpleadoMasVendioProd(chart30)
        RP_ClientesMasComproProd(Chart40)
    End Sub


    Function RP_ProductosMasVendidos(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

        ' Consulta para obtener la cantidad de productos por categoría
        Dim query = productosMasVendidos(fechaDesde, fechaHasta)

        Dim index As Integer = 0
        ' Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda

        For Each resultado In query
            p_chart.Series(0).Points.AddXY(resultado.Producto, resultado.Cantidad)
            p_chart.Series(0).Points(p_chart.Series(0).Points.Count - 1).LegendText = resultado.Producto
            'Establecer las etiquetas en el eje X del gráfico
            p_chart.Series(0).Points(index).AxisLabel = resultado.Cantidad
            index = index + 1
        Next

        ' Asignar nombre al eje X
        p_chart.ChartAreas(0).AxisX.Title = "Productos"
        ' Asignar nombre al eje y
        p_chart.ChartAreas(0).AxisY.Title = "Ventas"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Productos" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        Return 0
    End Function

    Function RP_ProductoPorMes(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

        ' Consulta para obtener la cantidad de productos por categoría
        Dim query = productoPorMes(fechaDesde, fechaHasta, idProducto)

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
        p_chart.Legends(0).Title = "Producto" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        p_chart.Series(0).Name = nombProducto

        Return 0
    End Function

    Function RP_EmpleadoMasVendioProd(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

        ' Consulta para obtener la cantidad de productos por categoría
        Dim query = empleadosMasVendioProd(fechaDesde, fechaHasta, idProducto)

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

    Function RP_ClientesMasComproProd(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

        ' Consulta para obtener la cantidad de productos por categoría
        Dim query = clientesMasComproProd(fechaDesde, fechaHasta, idProducto)


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