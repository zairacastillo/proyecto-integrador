Public Class NuevaVenta
    Dim OBJproducto As Dproducto = New Dproducto
    Dim OBJcliente As Dcliente = New Dcliente
    Dim OBJventa As Dventa = New Dventa
    Dim OBJdetalle_venta As Ddetalle_Venta = New Ddetalle_Venta

    Dim OProducto As producto = New producto
    Dim OCliente As cliente = New cliente
    Dim OEmpleado As empleado = New empleado

    Public Sub New(pempleado As empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        OEmpleado = pempleado

        TBVendedorA.Text = OEmpleado.apellido_empleado
        TBVendedorN.Text = OEmpleado.nombre_empleado
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub BProducto_Click(sender As Object, e As EventArgs) Handles BProducto.Click

        Dim listProductos As New ListarProductos(Me, True)
        listProductos.MdiParent = Me.MdiParent
        listProductos.Show()

    End Sub

    Public Sub CargaProducto(ByVal POProducto As producto)
        OProducto = POProducto

        TBProducto.Text = OProducto.nombre_producto
        TBStock.Text = OProducto.stock
        TBUnitario.Text = OProducto.precio
    End Sub

    Public Sub CargaCliente(ByVal POCliente As cliente)
        OCliente = POCliente

        TBClienteA.Text = OCliente.nombre_cliente
        TBClienteN.Text = OCliente.apellido_cliente
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click

        Dim listClientes As New ListarClientes(Me, True)
        listClientes.MdiParent = Me.MdiParent
        listClientes.Show()

    End Sub

    Private Sub BCompra_Click(sender As Object, e As EventArgs) Handles BCompra.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBVendedorA, TBClienteA, TBClienteN, TBTotal}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            Dim id_ultima_venta = guardarVenta()
            If guardarDetalleVenta(id_ultima_venta, DGV1) Then
                MsgBox("se guardo con exito")
            End If
        End If
    End Sub

    Private Sub TBCantidad_TextChanged(sender As Object, e As EventArgs) Handles TBCantidad.KeyPress

        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BAgregarProd_Click(sender As Object, e As EventArgs) Handles BAgregarProd.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBProducto, TBStock, TBCantidad, TBUnitario}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")

        ElseIf Integer.Parse(TBCantidad.Text) > Integer.Parse(TBStock.Text) Then
            MsgBox("No hay suficiente stock de ese producto", MsgBoxStyle.Critical, Title:="Error")

        Else
            Dim ask As Integer = MsgBox("¿Seguro que desea Guardar la venta?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

            'si acepta guardamos / mensaje
            If ask = DialogResult.Yes Then
                AgregarFilaProd()
                TBTotal.Text = actualizarTotalPrecio()
            End If
        End If
    End Sub

    Private Sub CrearFilaProd()
        Dim btnCancel = New DataGridViewButtonCell
        btnCancel.Value = "Cancelar"

        Dim numRow As Integer = DGV1.Rows.Add()
        DGV1.Rows(numRow).Cells(0).Value = OProducto.Id_producto
        DGV1.Rows(numRow).Cells(1).Value = OProducto.nombre_producto
        DGV1.Rows(numRow).Cells(2).Value = OProducto.precio
        DGV1.Rows(numRow).Cells(3).Value = TBCantidad.Text.Trim
        DGV1.Rows(numRow).Cells(4).Value = Decimal.Parse(OProducto.precio) * Decimal.Parse(TBCantidad.Text.Trim)
        DGV1.Rows(numRow).Cells(5) = btnCancel 'boton cancelar

    End Sub

    Private Sub AgregarFilaProd()

        Dim indexfilaProd = existeProdDataGrid()

        If indexfilaProd > -1 Then ' si devuelve valor valido
            Dim antCant = DGV1.Rows(indexfilaProd).Cells(3).Value
            Dim CantAgregada = Decimal.Parse(TBCantidad.Text.Trim)

            If (antCant + CantAgregada) <= OProducto.stock Then 'si la cantidad en el datagrid + el agregado es menor que el stock

                DGV1.Rows(indexfilaProd).Cells(3).Value = antCant + CantAgregada

                Dim antPrecio = DGV1.Rows(indexfilaProd).Cells(4).Value
                Dim PrecioAgregado = Decimal.Parse(OProducto.precio) * Decimal.Parse(TBCantidad.Text.Trim)

                DGV1.Rows(indexfilaProd).Cells(4).Value = antPrecio + PrecioAgregado 'total precio
            Else

                MsgBox("No hay suficiente stock de ese producto", MsgBoxStyle.Critical, Title:="Error")

            End If


        Else

            CrearFilaProd()

        End If

    End Sub
    Private Sub eliminarFilaProd()

    End Sub

    Private Function existeProdDataGrid() As Integer
        For Each fila In DGV1.Rows
            If fila.Cells(0).Value = OProducto.Id_producto Then 'si existe el producto en el datagrid

                Return fila.Cells(0).RowIndex 'devuelve el indice donde se encuentra

            End If
        Next
        Return -1
    End Function

    Private Function actualizarTotalPrecio() As Decimal
        Dim precio = 0.0
        For Each fila In DGV1.Rows
            precio = precio + fila.Cells(4).Value
        Next
        Return precio
    End Function


    Private Function guardarVenta() As Integer
        Dim Oventa = New venta
        Oventa.Id_empleado = OEmpleado.Id_empleado 'cambiar, hacerlo dinamico
        Oventa.Id_cliente = OCliente.Id_cliente
        Oventa.fecha = System.DateTime.Now
        Oventa.total = Decimal.Parse(TBTotal.Text.Trim)

        If OBJventa.agregrar_venta(Oventa) Then
            Return OBJventa.getLastIdVenta()
        Else
            Return -1
        End If

    End Function

    Private Function guardarDetalleVenta(id_ultima_venta, dg) As Boolean

        For Each fila In dg.rows
            Dim Odetalle_venta = New detalle_venta
            Odetalle_venta.Id_producto = fila.cells("ID").value
            Odetalle_venta.precio_unitario = fila.cells("PrecioUnitario").value
            Odetalle_venta.cantidad = fila.cells("Cantidad").value
            Odetalle_venta.subtotal = fila.cells("Subtotal").value
            Odetalle_venta.Id_venta = id_ultima_venta

            If Not OBJdetalle_venta.agregrar_detalle_Venta(Odetalle_venta) Then
                Return False
            End If
        Next

        Return True

    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DGV1.CurrentCell, DataGridViewButtonCell)

        'si la celda no es vacia
        If cell IsNot Nothing Then

            DGV1.Rows.RemoveAt(cell.RowIndex)
            DGV1.Refresh()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TBProducto.Clear()
        TBStock.Clear()
        TBCantidad.Clear()
        TBUnitario.Clear()
    End Sub
End Class