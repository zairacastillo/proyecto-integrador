Imports System.Windows.Forms.DataVisualization.Charting
Public Class RPorEmpleado

    Dim OBJEmpleado As New Dempleado
    Dim filtrarFecha = False
    Dim fechaDesde = Date.Now
    Dim fechaHasta = Date.Now

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ComboBox1.DataSource = OBJEmpleado.ObtenerEmpleados()
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"
    End Sub
    Private Sub RPorEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart10.Series(0).Points.Clear()
        Chart20.Series(0).Points.Clear()
        chart30.Series(0).Points.Clear()
        Chart40.Series(0).Points.Clear()
        Chart50.Series(0).Points.Clear()
        RP_VendedoresMasVendio(Chart10)
        RP_VendedorPorMes(Chart20)
        RP_ProductoMasVendioEmpleado(chart30)
        RP_ClientesMasVendioEmpleado(Chart40)
        RP_RecaudadoPorMesEmpleado(Chart50)
        LTotalRecaudado.Text = "$ " & TotalRecaudadoEmpleado(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)
    End Sub

    Function RP_VendedoresMasVendio(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Vendedor"

        ' Consulta para obtener la cantidad de Vendedors por categoría
        Dim query = vendedoresMasVendio(fechaDesde, fechaHasta, filtrarFecha)

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
        Dim query = vendedorPorMes(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)

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

        p_chart.Series(0).Name = ComboBox1.Text

        Return 0
    End Function

    Function RP_ProductoMasVendioEmpleado(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Vendedor"

        ' Consulta para obtener la cantidad de Vendedors por categoría
        Dim query = productoMasVendioEmpleado(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)

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
        Dim query = clientesMasVendioEmpleado(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)


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

    Function RP_RecaudadoPorMesEmpleado(p_chart As Chart)
        ' Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

        ' Consulta para obtener la cantidad de Categorias por categoría
        Dim query = RecaudadoEmpleadoPorFecha(fechaDesde, fechaHasta, filtrarFecha, ComboBox1.SelectedValue)

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
        p_chart.Legends(0).Title = "Productos" ' Título de la leyenda

        ' Mostrar la leyenda
        p_chart.Legends(0).Enabled = True ' Habilitar la visualización de la leyenda

        p_chart.Series(0).Name = ComboBox1.Text
        Return 0
    End Function

    Private Sub BNoFiltrar_Click(sender As Object, e As EventArgs) Handles BNoFiltrar.Click
        filtrarFecha = False
        fechaDesde = DTPDesde.Value.Date
        fechaHasta = DTPHasta.Value.Date.AddDays(1)
        RPorEmpleado_Load(sender, e)
    End Sub

    Private Sub BFiltrar_Click(sender As Object, e As EventArgs) Handles BFiltrar.Click
        Dim fecha As Date = System.DateTime.Now
        If DTPDesde.Value > DTPHasta.Value Or DTPHasta.Value > fecha Or DTPDesde.Value > fecha Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else
            filtrarFecha = True
            fechaDesde = DTPDesde.Value.Date
            fechaHasta = DTPHasta.Value.Date.AddDays(1)
            RPorEmpleado_Load(sender, e)
        End If
    End Sub
End Class