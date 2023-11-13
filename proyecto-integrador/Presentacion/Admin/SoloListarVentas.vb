Public Class SoloListarVentas
    Dim ObjEmpleados As Dempleado = New Dempleado
    Dim factura As New Dventa
    Dim det As New Ddetalle_Venta
    Private Sub SoloListarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factura.MostrarFactura2(DVentas)

        CBEmpleados.DataSource = ObjEmpleados.getAllNombresEmpleados()
        CBEmpleados.DisplayMember = "ApeNom"
        CBEmpleados.ValueMember = "ID"
        CBEmpleados.SelectedValue = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As Date = System.DateTime.Now
        Dim factura As New Dventa
        If DTPDesde.Value > DTPHasta.Value Or DTPHasta.Value > fecha Or DTPDesde.Value > fecha Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else

            factura.porFecha(DTPDesde.Value.Date, DTPHasta.Value.Date.AddDays(1), DVentas, CBEmpleados.SelectedValue)

        End If
    End Sub

    Private Sub BDetalle_Click(sender As Object, e As EventArgs) Handles BDetalle.Click
        Dim fila As Integer = Me.DVentas.CurrentRow.Index
        Dim id As Integer = Me.DVentas.Rows(fila).Cells("Nro_factura").Value

        det.mostrarDetalle(id, DVGDetalleFac)
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DVGDetalleFac.DataSource = Nothing
        DVGDetalleFac.Rows.Clear()
        factura.MostrarFactura2(DVentas)

        CBEmpleados.DataSource = ObjEmpleados.getAllNombresEmpleados()
        CBEmpleados.DisplayMember = "ApeNom"
        CBEmpleados.ValueMember = "ID"
        CBEmpleados.SelectedValue = 0

    End Sub

    Private Sub DVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVentas.CellContentClick

    End Sub

    Private Sub CBEmpleados_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBEmpleados.KeyPress
        e.Handled = True
    End Sub
End Class