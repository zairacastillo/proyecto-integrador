Module consultas

    Dim ctx As CLUBMENEntities = New CLUBMENEntities
#Region "Productos"
    Public Function productosMasVendidos(fechaInicio As Date, fechaFin As Date)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By producto = detalle.producto Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Producto = producto.nombre_producto, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (10)).ToList

        Return query
    End Function

    Public Function productoPorMes(fechaInicio As Date, fechaFin As Date, p_idProducto As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where detalle.Id_producto = p_idProducto AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By Mes = Month(venta.fecha) Into Group
                 Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList

        Return query
    End Function

    Public Function empleadosMasVendioProd(fechaInicio As Date, fechaFin As Date, p_idProducto As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                 Where detalle.Id_producto = p_idProducto AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By empleado = venta.empleado Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

    Public Function clientesMasComproProd(fechaInicio As Date, fechaFin As Date, p_idProducto As Integer)

        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                 Where detalle.Id_producto = p_idProducto AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By cliente = venta.cliente Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function
#End Region

#Region "Categorias"
    Public Function categoriasMasVendidas(fechaInicio As Date, fechaFin As Date)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By categoria = detalle.producto.categoria Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Categoria = categoria.descripcion_cat, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (10)).ToList

        Return query
    End Function

    Public Function categoriaPorMes(fechaInicio As Date, fechaFin As Date, p_idCategoria As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where detalle.producto.Id_categoria = p_idCategoria AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By Mes = Month(venta.fecha) Into Group
                 Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList

        Return query
    End Function

    Public Function empleadosMasVendioCateg(fechaInicio As Date, fechaFin As Date, p_idCategoria As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                 Where detalle.producto.Id_categoria = p_idCategoria AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By empleado = venta.empleado Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

    Public Function clientesMasComproCateg(fechaInicio As Date, fechaFin As Date, p_idCategoria As Integer)

        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                 Where detalle.producto.Id_categoria = p_idCategoria AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By cliente = venta.cliente Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

#End Region

#Region "Vendedores"
    Public Function vendedoresMasVendio(fechaInicio As Date, fechaFin As Date)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By vendedor = detalle.venta.empleado Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (10)).ToList

        Return query
    End Function

    Public Function vendedorPorMes(fechaInicio As Date, fechaFin As Date, p_idEmpleado As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where detalle.venta.Id_empleado = p_idEmpleado AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By Mes = Month(venta.fecha) Into Group
                 Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList

        Return query
    End Function

    Public Function productoMasVendioEmpleado(fechaInicio As Date, fechaFin As Date, p_idEmpleado As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                 Where detalle.venta.Id_empleado = p_idEmpleado AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By producto = detalle.producto Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Producto = producto.nombre_producto, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

    Public Function clientesMasVendioEmpleado(fechaInicio As Date, fechaFin As Date, p_idEmpleado As Integer)

        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                 Where detalle.venta.Id_empleado = p_idEmpleado AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By cliente = venta.cliente Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

#End Region

#Region "Clientes"
    Public Function clientesMasCompraron(fechaInicio As Date, fechaFin As Date)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By cliente = detalle.venta.cliente Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (10)).ToList

        Return query
    End Function

    Public Function clientePorMes(fechaInicio As Date, fechaFin As Date, p_idCliente As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Where detalle.venta.Id_cliente = p_idCliente AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By Mes = Month(venta.fecha) Into Group
                 Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList

        Return query
    End Function

    Public Function clienteMasComproProducto(fechaInicio As Date, fechaFin As Date, p_idCliente As Integer)
        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                 Where detalle.venta.Id_cliente = p_idCliente AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By producto = detalle.producto Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Producto = producto.nombre_producto, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

    Public Function clientesMasComproAEmpleado(fechaInicio As Date, fechaFin As Date, p_idCliente As Integer)

        Dim query

        query = (From detalle In ctx.detalle_venta
                 Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                 Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                 Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                 Where detalle.venta.Id_cliente = p_idCliente AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                 Group By vendedor = venta.empleado Into Group
                 Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                 Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                 Take (5)).ToList

        Return query
    End Function

#End Region
End Module
