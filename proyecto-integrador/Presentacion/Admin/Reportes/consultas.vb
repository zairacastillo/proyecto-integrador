Module consultas

    Dim ctx As CLUBMENEntities = New CLUBMENEntities
#Region "Productos"
    Public Function productosMasVendidos(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean)
        Dim query

        If filtrarFecha Then
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                     Group By producto = detalle.producto Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (5)).ToList
        Else
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Group By producto = detalle.producto Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (5)).ToList
        End If


        Return query
    End Function

    Public Function productoPorMes(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idProducto As Integer)
        Dim query

        If idProducto > 0 Then
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_producto = idProducto
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.producto.Id_producto = idProducto
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            End If
        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            End If
        End If



        Return query
    End Function

    Public Function empleadosMasVendioProd(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idProducto As Integer)
        Dim query

        If idProducto > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_producto = idProducto
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where detalle.producto.Id_producto = idProducto
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If

        Else

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If

        End If



        Return query
    End Function

    Public Function clientesMasComproProd(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idProducto As Integer)

        Dim query

        If idProducto > 0 Then
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_producto = idProducto
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where detalle.producto.Id_producto = idProducto
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If

        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        End If



        Return query
    End Function

    Function RecaudadoProductoPorFecha(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idProducto As Integer)
        Dim query
        If idProducto > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_producto = idProducto
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.producto.Id_producto = idProducto
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If

        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If
        End If


        Return query
    End Function

    Function TotalRecaudadoProducto(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idProducto As Integer)
        Dim query
        Try

            If idProducto > 0 Then

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_producto = idProducto
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where detalle.producto.Id_producto = idProducto
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If



            Else

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If

            End If

        Catch ex As Exception
            query = 0

        End Try
        Return query
    End Function

#End Region

#Region "Categorias"
    Public Function categoriasMasVendidas(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean)
        Dim query

        If filtrarFecha Then
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                     Group By categoria = detalle.producto.categoria Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Categoria = categoria.descripcion_cat, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (10)).ToList
        Else
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Group By categoria = detalle.producto.categoria Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Categoria = categoria.descripcion_cat, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (10)).ToList
        End If


        Return query
    End Function

    Public Function categoriaPorMes(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idCategoria As Integer)
        Dim query
        If idCategoria > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_categoria = idCategoria
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.producto.Id_categoria = idCategoria
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad), Anio).ToList
            End If

        Else

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad), Anio).ToList
            End If

        End If



        Return query
    End Function

    Public Function empleadosMasVendioCateg(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idCategoria As Integer)
        Dim query
        If idCategoria > 0 Then
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_categoria = idCategoria
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where detalle.producto.Id_categoria = idCategoria
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Group By empleado = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (empleado.apellido_empleado + ", " + empleado.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        End If

        Return query
    End Function

    Public Function clientesMasComproCateg(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idCategoria As Integer)

        Dim query

        If idCategoria > 0 Then
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_categoria = idCategoria
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where detalle.producto.Id_categoria = idCategoria
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        End If



        Return query
    End Function

    Function RecaudadoCategoriaPorFecha(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idCategoria As Integer)
        Dim query
        If idCategoria > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_categoria = idCategoria
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.producto.Id_categoria = idCategoria
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If

        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If
        End If


        Return query
    End Function

    Function TotalRecaudadoCategoria(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idCategoria As Integer)
        Dim query
        Try

            If idCategoria > 0 Then

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And detalle.producto.Id_categoria = idCategoria
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where detalle.producto.Id_categoria = idCategoria
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If



            Else

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If

            End If

        Catch ex As Exception
            query = 0

        End Try
        Return query
    End Function
#End Region

#Region "Vendedores"
    Public Function vendedoresMasVendio(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean)

        Dim query
        If filtrarFecha Then
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                     Group By vendedor = detalle.venta.empleado Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (10)).ToList
        Else
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Group By vendedor = detalle.venta.empleado Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (10)).ToList
        End If


        Return query
    End Function

    Public Function vendedorPorMes(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idEmpleado As Integer)
        Dim query
        If idEmpleado > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.venta.Id_empleado = idEmpleado AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.venta.Id_empleado = idEmpleado
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            End If
        Else

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            End If
        End If



        Return query
    End Function

    Public Function productoMasVendioEmpleado(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idEmpleado As Integer)
        Dim query
        If idEmpleado > 0 Then
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where detalle.venta.Id_empleado = idEmpleado AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where detalle.venta.Id_empleado = idEmpleado
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        End If


        Return query
    End Function

    Public Function clientesMasVendioEmpleado(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idEmpleado As Integer)

        Dim query
        If idEmpleado > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where detalle.venta.Id_empleado = idEmpleado AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where detalle.venta.Id_empleado = idEmpleado
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        Else

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Group By cliente = venta.cliente Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        End If


        Return query
    End Function

    Function RecaudadoEmpleadoPorFecha(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idEmpleado As Integer)
        Dim query
        If idEmpleado > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And venta.Id_empleado = idEmpleado
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                         Where venta.Id_empleado = idEmpleado
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If

        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If
        End If


        Return query
    End Function

    Function TotalRecaudadoEmpleado(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, idEmpleado As Integer)
        Dim query
        Try

            If idEmpleado > 0 Then

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And venta.Id_empleado = idEmpleado
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                             Where venta.Id_empleado = idEmpleado
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If



            Else

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Join empleado In ctx.empleado On venta.Id_empleado Equals empleado.Id_empleado
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If

            End If

        Catch ex As Exception
            query = 0

        End Try
        Return query
    End Function


#End Region

#Region "Clientes"
    Public Function clientesMasCompraron(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean)
        Dim query
        If filtrarFecha Then
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                     Group By cliente = detalle.venta.cliente Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (5)).ToList
        Else
            query = (From detalle In ctx.detalle_venta
                     Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                     Group By cliente = detalle.venta.cliente Into Group
                     Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                     Select Cliente = (cliente.apellido_cliente + ", " + cliente.nombre_cliente), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                     Take (5)).ToList
        End If


        Return query
    End Function

    Public Function clientePorMes(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, p_idCliente As Integer)
        Dim query
        If p_idCliente > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.venta.Id_cliente = p_idCliente AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where detalle.venta.Id_cliente = p_idCliente
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            End If
        Else

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) d.detalle.cantidad)).ToList
            End If
        End If

        Return query
    End Function

    Public Function clienteMasComproProducto(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, p_idCliente As Integer)
        Dim query
        If p_idCliente > 0 Then
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where detalle.venta.Id_cliente = p_idCliente AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where detalle.venta.Id_cliente = p_idCliente
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Group By producto = detalle.producto Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Producto = (producto.categoria.descripcion_cat + " " + producto.nombre_producto), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList
            End If
        End If


        Return query
    End Function

    Public Function clientesMasComproAEmpleado(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, p_idCliente As Integer)

        Dim query
        If p_idCliente > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where detalle.venta.Id_cliente = p_idCliente AndAlso venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By vendedor = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList

            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where detalle.venta.Id_cliente = p_idCliente
                         Group By vendedor = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList

            End If
        Else

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By vendedor = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList

            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Join cliente In ctx.cliente On venta.Id_cliente Equals cliente.Id_cliente
                         Join vendedor In ctx.empleado On venta.Id_empleado Equals vendedor.Id_empleado
                         Group By vendedor = venta.empleado Into Group
                         Order By Group.Sum(Function(d) d.detalle.cantidad) Descending
                         Select Vendedor = (vendedor.apellido_empleado + ", " + vendedor.nombre_empleado), Cantidad = Group.Sum(Function(d) d.detalle.cantidad)
                         Take (5)).ToList

            End If
        End If

        Return query
    End Function

    Function RecaudadoClientePorFecha(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, p_idCliente As Integer)
        Dim query
        If p_idCliente > 0 Then

            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And venta.Id_cliente = p_idCliente
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.Id_cliente = p_idCliente
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If

        Else
            If filtrarFecha Then
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            Else
                query = (From detalle In ctx.detalle_venta
                         Join venta In ctx.venta On detalle.Id_venta Equals venta.Id_venta
                         Group By Anio = Year(venta.fecha), Mes = Month(venta.fecha) Into Group
                         Select Mes, Cantidad = Group.Sum(Function(d) (d.detalle.precio_unitario * d.detalle.cantidad)), Anio).ToList
            End If
        End If


        Return query
    End Function

    Function TotalRecaudadoCliente(fechaInicio As Date, fechaFin As Date, filtrarFecha As Boolean, p_idCliente As Integer)
        Dim query
        Try

            If p_idCliente > 0 Then

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin And venta.Id_cliente = p_idCliente
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.Id_cliente = p_idCliente
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If



            Else

                If filtrarFecha Then
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Where venta.fecha >= fechaInicio AndAlso venta.fecha <= fechaFin
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                Else
                    query = (From venta In ctx.venta
                             Join detalle In ctx.detalle_venta On detalle.Id_venta Equals venta.Id_venta
                             Select (detalle.precio_unitario * detalle.cantidad)).Sum()
                End If

            End If

        Catch ex As Exception
            query = 0

        End Try
        Return query
    End Function

#End Region

End Module
