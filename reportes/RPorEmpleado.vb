Imports System.Windows.Forms.DataVisualization.Charting
Public Class RPorEmpleado

    Dim fechaDesde
    Dim fechaHasta
    Dim idVendedor
    Dim nombVendedor
    Public Sub New(p_fechaDesde As Date, p_fechaHasta As Date, p_idVendedor As Integer, p_nombVendedor As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        fechaDesde = p_fechaDesde
        fechaHasta = p_fechaHasta
        idVendedor = p_idVendedor
        nombVendedor = p_nombVendedor
    End Sub
    Private Sub RPorEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RP_VendedoresMasVendio(Chart10)
        RP_VendedorPorMes(Chart20)
        RP_ProductoMasVendioEmpleado(chart30)
        RP_ClientesMasVendioEmpleado(Chart40)
    End Sub

    Function RP_VendedoresMasVendio(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Vendedor"

        ' Consulta para obtener la cantidad de Vendedors por categoría
        Dim query = vendedoresMasVendio(fechaDesde, fechaHasta)

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

    Function RP_VendedorPorMes(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Vendedor"

        ' Consulta para obtener la cantidad de Vendedors por categoría
        Dim query = vendedorPorMes(fechaDesde, fechaHasta, idVendedor)

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
        p_chart.Legends(0).Title = "Vendedor" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        p_chart.Series(0).Name = nombVendedor

        Return 0
    End Function

    Function RP_ProductoMasVendioEmpleado(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Vendedor"

        ' Consulta para obtener la cantidad de Vendedors por categoría
        Dim query = productoMasVendioEmpleado(fechaDesde, fechaHasta, idVendedor)

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
        p_chart.ChartAreas(0).AxisY.Title = "Compras"

        ' Mostrar etiquetas en el eje X
        p_chart.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre etiquetas

        ' Establecer el título de la leyenda
        p_chart.Legends(0).Title = "Productos" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        Return 0
    End Function

    Function RP_ClientesMasVendioEmpleado(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Vendedor"

        ' Consulta para obtener la cantidad de Vendedors por categoría
        Dim query = clientesMasVendioEmpleado(fechaDesde, fechaHasta, idVendedor)


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