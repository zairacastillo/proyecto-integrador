Public Class BuscarClientes
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BAtras_Click(sender As Object, e As EventArgs) Handles BAtras.Click
        MDIVendedor.NuevaVenta_Click(sender, e)
    End Sub
End Class