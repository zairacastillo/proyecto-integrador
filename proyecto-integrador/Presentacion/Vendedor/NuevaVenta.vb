Public Class NuevaVenta


    Private Sub BProducto_Click(sender As Object, e As EventArgs) Handles BProducto.Click
        MDIVendedor.AgregarProductoVenta(sender, e)
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click
        MDIVendedor.AgregarClienteVenta(sender, e)
    End Sub

    Private Sub BCompra_Click(sender As Object, e As EventArgs) Handles BCompra.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBVendedor, TBClienteA, TBClienteN, TBTotal}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            'guardar venta
        End If
    End Sub

    Private Sub TBCantidad_TextChanged(sender As Object, e As EventArgs) Handles TBCantidad.KeyPress

        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BBuscarProd_Click(sender As Object, e As EventArgs) Handles BBuscarProd.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBProducto, TBStock, TBCantidad, TBUnitario}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            'guardar venta
        End If
    End Sub


End Class