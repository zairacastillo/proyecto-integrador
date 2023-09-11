Public Class NuevaVenta
    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BProducto_Click(sender As Object, e As EventArgs) Handles BProducto.Click
        MDIVendedor.buscarProductos(sender, e)
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click
        MDIVendedor.buscarClientes(sender, e)
    End Sub
End Class