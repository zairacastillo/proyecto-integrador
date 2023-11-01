Public Class SoloListarVentas
    Dim ObjEmpleados As Dempleado = New Dempleado
    Dim factura As New Dventa
    Dim det As New Ddetalle_Venta
    Private Sub SoloListarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factura.MostrarFactura2(DVentas)

        CBEmpleados.DataSource = ObjEmpleados.getAllNombresEmpleados()
        CBEmpleados.DisplayMember = "apellido_empleado"
        CBEmpleados.ValueMember = "Id_empleado"
        CBEmpleados.SelectedValue = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As Date = System.DateTime.Now
        Dim factura As New Dventa
        If DTPDesde.Value > DTPHasta.Value Or DTPHasta.Value > fecha Or DTPDesde.Value > fecha Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else
            factura.porFecha1(DTPDesde.Value, DTPHasta.Value, DVentas, CBEmpleados.SelectedValue)

        End If
    End Sub

    Private Sub BDetalle_Click(sender As Object, e As EventArgs) Handles BDetalle.Click
        Dim fila As Integer = Me.DVentas.CurrentRow.Index
        Dim id As Integer = Me.DVentas.Rows(fila).Cells("Nro_factura").Value

        det.mostrarDetalle(id, DVGDetalleFac)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ImprimirVenta.Show()
    End Sub
End Class