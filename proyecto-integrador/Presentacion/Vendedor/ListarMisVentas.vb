Public Class ListarMisVentas

    Dim det As New Ddetalle_Venta
    Dim OEmpleado As New empleado
    Public Sub New(pempleado As empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        OEmpleado = pempleado
        LDni.Text = OEmpleado.dni_empleado
        LVendeA.Text = OEmpleado.apellido_empleado
        LVendeN.Text = OEmpleado.nombre_empleado
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub ListarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim factura As New Dventa
        LDni.Text = OEmpleado.dni_empleado
        factura.MostrarFactura1(LDni.Text, DVentas)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As Date = System.DateTime.Now
        Dim factura As New Dventa
        If DTPDesde.Value > DTPHasta.Value Or DTPHasta.Value > fecha Or DTPDesde.Value > fecha Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else
            factura.porFecha(DTPDesde.Value, DTPHasta.Value.Date.AddDays(1), DVentas, OEmpleado.Id_empleado)

        End If
    End Sub



    Private Sub BDetalle_Click(sender As Object, e As EventArgs) Handles BDetalle.Click
        If DVentas.Rows.Count > 0 Then
            Dim fila As Integer = Me.DVentas.CurrentRow.Index
            Dim id As Integer = Me.DVentas.Rows(fila).Cells(0).Value

            det.mostrarDetalle(id, DVGDetalleFac)
        End If
    End Sub

    Private Sub DVGDetalleFac_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGDetalleFac.CellContentClick

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DVGDetalleFac.Rows.Count > 0 Then
            Dim idVenta = DVGDetalleFac.Rows(0).Cells(0).Value
            Dim impVenta As New ImprimirVenta(idVenta)
            'impVenta.MdiParent = Me.MdiParent
            impVenta.Show()
            wait(1)
            impVenta.imprimir()
        End If
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub BTodos_Click(sender As Object, e As EventArgs) Handles BTodos.Click
        DVGDetalleFac.DataSource = Nothing
        DVGDetalleFac.Rows.Clear()
        Dim factura As New Dventa
        LDni.Text = OEmpleado.dni_empleado
        factura.MostrarFactura1(LDni.Text, DVentas)

    End Sub
End Class

