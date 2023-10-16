Public Class ListarMisVentas

    Dim det As New Ddetalle_Venta
    Private Sub ListarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As Date = System.DateTime.Now
        Dim factura As New Dventa
        If DTPDesde.Value > DTPHasta.Value Or DTPHasta.Value > fecha Or DTPDesde.Value > fecha Then
            MsgBox("Fecha incorrecta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else
            factura.porFecha1(DTPDesde.Text, DTPHasta.Text, DVentas, 3) 'cambiar 3

        End If
    End Sub

    Private Sub DVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVentas.CellContentClick

    End Sub

    Private Sub BDetalle_Click(sender As Object, e As EventArgs) Handles BDetalle.Click
        Dim fila As Integer = Me.DVentas.CurrentRow.Index
        Dim id As Integer = Me.DVentas.Rows(fila).Cells(0).Value

        det.mostrarDetalle(id, DVGDetalleFac)
    End Sub
End Class