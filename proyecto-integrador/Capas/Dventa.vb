Public Class Dventa


    Dim ctx As CLUBMENEntities = New CLUBMENEntities

    Function getAllVenta(ByVal dg As DataGridView) As Boolean
        ' dg.DataSource = Me.getAll()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        Return False
    End Function

    Function getLastIdVenta() As Integer
        Dim listaVenta = (From p In ctx.venta
                          Order By p.Id_venta
                          Select p).ToList

        Return listaVenta.Last.Id_venta
    End Function

    Function agregrar_venta(ByVal oventa As venta) As Boolean

        'Try
        ctx.venta.Add(oventa)
        ctx.SaveChanges()
        Return True
        ' Catch ex As Exception
        '  MsgBox(ex.Message)
        Return False

        'End Try

    End Function



    Public Function porFecha(ByVal desde As Date, ByVal hasta As Date, ByRef grid As DataGridView, ByVal id_Emp As Integer)
        Try
            Dim objMostrar
            If id_Emp = 0 Then
                objMostrar = (From f In ctx.venta
                              Join c In ctx.cliente On f.Id_cliente Equals c.Id_cliente
                              Join e In ctx.empleado On f.empleado.Id_empleado Equals e.Id_empleado
                              Where hasta >= f.fecha And f.fecha >= desde
                              Select Nro_factura = f.Id_venta, Idemp = f.empleado.Id_empleado, nombreVendedor = e.nombre_empleado, apellidoVendedor = e.apellido_empleado,
                                      IdVend = f.empleado.dni_empleado, idCli = f.Id_cliente, nombreCliente = c.nombre_cliente, Apellido = c.apellido_cliente,
                                      fecha_de_factura = f.fecha, Total = f.total).ToList
            Else

                objMostrar = (From f In ctx.venta
                              Join c In ctx.cliente On f.Id_cliente Equals c.Id_cliente
                              Join e In ctx.empleado On f.empleado.Id_empleado Equals e.Id_empleado
                              Where (e.Id_empleado = id_Emp) And f.fecha >= desde And f.fecha <= hasta
                              Select Nro_factura = f.Id_venta, Idemp = f.empleado.Id_empleado, nombreVendedor = e.nombre_empleado, apellidoVendedor = e.apellido_empleado,
                                  IdVend = f.empleado.dni_empleado, idCli = f.Id_cliente, nombreCliente = c.nombre_cliente, Apellido = c.apellido_cliente,
                                  fecha_de_factura = f.fecha, Total = f.total).ToList

            End If
            If objMostrar.Count <> 0 Then
                grid.DataSource = objMostrar

                'grid.Columns("Idemp").Visible = False
                'grid.Columns("idCli").Visible = False
                'grid.Columns("IdVend").Visible = False
                'grid.Columns(10).Visible = False
            Else
                grid.DataSource = Nothing
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function MostrarFactura2(ByVal grid As DataGridView)
        Try
            Using Mostrar As New CLUBMENEntities
                Dim objMostrar = (From f In Mostrar.venta
                                  Join c In Mostrar.cliente On f.Id_cliente Equals c.Id_cliente
                                  Join e In Mostrar.empleado On f.empleado.Id_empleado Equals e.Id_empleado
                                  Select Nro_factura = f.Id_venta, Idemp = f.empleado.dni_empleado, nombreVendedor = e.nombre_empleado, apellidoVendedor = e.apellido_empleado,
                                      IdVend = f.empleado.Id_empleado, idCli = f.Id_cliente, nombreCliente = c.nombre_cliente, Apellido = c.apellido_cliente,
                                      fecha_de_factura = f.fecha, Total = f.total).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar

                    grid.Columns("Idemp").Visible = False
                    grid.Columns("idCli").Visible = False
                    grid.Columns("IdVend").Visible = False

                    'grid.Columns(1).Visible = False
                    'grid.Columns(4).Visible = False
                    'grid.Columns(5).Visible = False
                    'grid.Columns(10).Visible = False
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarFactura1(ByVal dni As Integer, ByVal grid As DataGridView)
        Try
            Using Mostrar As New CLUBMENEntities
                Dim objMostrar = (From f In Mostrar.venta
                                  Join c In Mostrar.cliente On f.Id_cliente Equals c.Id_cliente
                                  Join e In Mostrar.empleado On f.empleado.Id_empleado Equals e.Id_empleado
                                  Where e.dni_empleado = dni
                                  Select Nro_factura = f.Id_venta, Idemp = f.empleado.dni_empleado, nombreVendedor = e.nombre_empleado, apellidoVendedor = e.apellido_empleado,
                                      IdVend = f.empleado.Id_empleado, idCli = f.Id_cliente, nombreCliente = c.nombre_cliente, Apellido = c.apellido_cliente,
                                      fecha_de_factura = f.fecha, Total = f.total).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar


                    grid.Columns("Idemp").Visible = False
                    grid.Columns("idCli").Visible = False
                    grid.Columns("IdVend").Visible = False
                    '                    grid.Columns(1).Visible = False
                    '                   grid.Columns(4).Visible = False
                    '                  grid.Columns(5).Visible = False
                    '                 grid.Columns(10).Visible = False
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetVentaPorId(ByVal p_id As Integer)
        Try
            Using ctx
                Dim venta = (From f In ctx.venta
                             Join c In ctx.cliente On f.Id_cliente Equals c.Id_cliente
                             Join e In ctx.empleado On f.empleado.Id_empleado Equals e.Id_empleado
                             Where f.Id_venta = p_id
                             Select Nro_factura = f.Id_venta, Idemp = f.empleado.dni_empleado, nombreVendedor = e.nombre_empleado, apellidoVendedor = e.apellido_empleado,
                                      dniCliente = c.dni_cliente, IdVend = f.empleado.Id_empleado, idCli = f.Id_cliente, nombreCliente = c.nombre_cliente, apellidoCliente = c.apellido_cliente,
                                      fecha_de_factura = f.fecha, Total = f.total, Pago = f.pago.descripcion_pago).First
                Return venta
            End Using
        Catch ex As Exception
            Return New Object
        End Try
    End Function


End Class
