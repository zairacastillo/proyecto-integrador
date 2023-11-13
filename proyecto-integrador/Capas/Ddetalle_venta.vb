Public Class Ddetalle_Venta


    Dim ctx As CLUBMENEntities = New CLUBMENEntities

    Function getAllDetalle_Venta(ByVal dg As DataGridView) As Boolean
        'dg.DataSource = Me.getAll()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        Return False
    End Function
    Function agregrar_detalle_Venta(ByVal odetalle_Venta As detalle_venta) As Boolean
        Try
            ctx.detalle_venta.Add(odetalle_Venta)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Function mostrarDetalle(ByVal idFac As Integer, ByVal grid As DataGridView)
        Try
            Dim datos = (From df In ctx.detalle_venta
                         Join j In ctx.producto On df.Id_producto Equals j.Id_producto
                         Join cat In ctx.categoria On j.Id_categoria Equals cat.Id_categoria
                         Join f In ctx.venta On f.Id_venta Equals df.Id_venta
                         Where df.Id_venta = idFac
                         Select idVenta = f.Id_venta, id = df.Id_detalle_venta, idPro = df.Id_producto, Producto = j.nombre_producto, Categoria = cat.descripcion_cat, Cantidad_Comprada = df.cantidad, PrecioUnitario = j.precio, SubTotal = (j.precio * df.cantidad)).ToList

            grid.DataSource = datos

            grid.Columns(0).Visible = False
            grid.Columns(1).Visible = False
            grid.Columns(2).Visible = False
            grid.Columns(6).Visible = False
            Return True

        Catch ex As Exception
            Return False
            MsgBox("ERROR agregar detalle")

        End Try
    End Function



End Class
