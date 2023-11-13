Public Class Dproducto


    Dim ctx As CLUBMENEntities = New CLUBMENEntities


    Function llenarCategorias(ByRef dg As DataGridView) As Boolean

        Dim cat As categoria
        For Each fila In dg.Rows
            cat = fila.Cells("categoria").Value
            fila.Cells("Categorias").Value = cat.descripcion_cat
        Next

        dg.Columns(8).Visible = False
        dg.Columns(9).Visible = False
        Return False
    End Function

    Public Sub GetProductoAll(ByVal grid As DataGridView)

        Dim listaproducto = (From p In ctx.producto
                             Order By p.Id_producto
                             Select Codigo = p.Id_producto, Nombre = p.nombre_producto, CodCat = p.categoria.Id_categoria,
                                    Categoria = p.categoria.descripcion_cat, Descrip = p.descripcion_producto, Precio = p.precio, Stock = p.stock, Estado = p.estado_producto).ToList

        grid.DataSource = listaproducto
        'grid.DataSource = Control_Stock(grid)
        'grid.Columns(7).Visible = False

    End Sub


    Function getAllproducto(ByRef dg As DataGridView) As Boolean

        dg.DataSource = Me.getAll()


        Dim cat As categoria
        For Each fila In dg.Rows
            cat = fila.Cells("categoria").Value
            fila.Cells("Categorias").Value = cat.descripcion_cat
        Next

        dg.Columns(8).Visible = False
        dg.Columns(9).Visible = False
        Return False
    End Function
    Function agregrar_producto(ByVal oproducto As producto) As Boolean
        Try
            ctx.producto.Add(oproducto)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function getAll() As List(Of producto)
        Dim lista = (From p In ctx.producto.Include("categoria")
                     Select p).ToList

        Dim listaproducto = New List(Of producto)

        For Each valor In lista

            Dim item As producto = New producto

            item.Id_producto = valor.Id_producto
            item.nombre_producto = valor.nombre_producto
            item.estado_producto = valor.estado_producto
            item.precio = valor.precio
            item.stock = valor.stock
            item.Id_categoria = valor.Id_categoria
            item.categoria = valor.categoria
            item.descripcion_producto = valor.descripcion_producto

            listaproducto.Add(item)


        Next
        Return listaproducto
    End Function

    Function ExisteProducto(ByVal pnombre As String, Optional ByVal pid As Integer = -1) As Boolean

        Dim buscarProd = (From p In ctx.producto
                          Where p.nombre_producto = pnombre
                          Select p).ToList

        If (buscarProd.Count() = 0) Then
            Return False 'producto no existe
        Else
            If (buscarProd.First.Id_producto = pid) Then
                Return False 'producto existe pero es el mismo cliente
            End If
            MsgBox("ERROR: El producto ya ha sido registrado", Title:="ERROR")
            Return True 'producto ya existe
        End If
    End Function


    Function buscarProducto(grid As DataGridView, Optional ByVal pidCategoria As Integer = 0, Optional ByVal pnombre As String = "", Optional ByVal pestado As String = "Activo")
        Dim lista

        If (pidCategoria > 0) Then
            lista = (From p In ctx.producto
                     Where p.Id_categoria = pidCategoria And p.nombre_producto.Contains(pnombre) And p.estado_producto = pestado
                     Select Codigo = p.Id_producto, Nombre = p.nombre_producto, Categoria = p.categoria.descripcion_cat, Descripcion = p.descripcion_producto, Precio = p.precio, Stock = p.stock, Estado = p.estado_producto, IDCAT = p.categoria.Id_categoria).ToList
        Else
            lista = (From p In ctx.producto
                     Where p.nombre_producto.Contains(pnombre) And p.estado_producto = pestado
                     Select Codigo = p.Id_producto, Nombre = p.nombre_producto, Categoria = p.categoria.descripcion_cat, Descripcion = p.descripcion_producto, Precio = p.precio, Stock = p.stock, Estado = p.estado_producto, IDCAT = p.categoria.Id_categoria).ToList
        End If


        grid.DataSource = lista
        Return False
    End Function
    '
    Public Function Modificar(ByVal oproducto As producto)

        Dim modif = (From q In ctx.producto Where (q.Id_producto = oproducto.Id_producto) Select q).First


        modif.nombre_producto = oproducto.nombre_producto
        modif.estado_producto = oproducto.estado_producto
        modif.precio = oproducto.precio
        modif.stock = oproducto.stock
        modif.Id_categoria = oproducto.Id_categoria
        modif.descripcion_producto = oproducto.descripcion_producto


        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Console.WriteLine("Exception: {0}", ex)
            Return False
        End Try
    End Function

    'Actualiza el stock con la cantidad recibida como parametro
    Public Function ActualizarStock(ByVal id_inst As Integer, ByVal p_cantidad As Integer)
        Try
            Using ctx As New CLUBMENEntities
                Dim producto = (From q In ctx.producto Where q.Id_producto = id_inst Select q).First

                Dim nuevo = producto.stock - p_cantidad
                producto.stock = nuevo
                ctx.SaveChanges()
                Return True
            End Using
        Catch Ex As Exception
            Return False
        End Try
    End Function

    Function Control_Stock(ByVal grid As DataGridView) As DataGridView
        For Each fila As DataGridViewRow In grid.Rows
            If fila.Cells("Stock").Value < 10000000 Then
                fila.Cells(6).Style.BackColor = Color.Red
            ElseIf fila.Cells("Stock").Value < 11 Then
                fila.DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next

        Return grid
    End Function
    '
    Function ObtenerProductos()

        Dim listaproducto
        Dim todos = New With {Key .Nombre = "Todos Los Productos", Key .ID = 0}
        listaproducto = (From p In ctx.producto
                         Order By p.Id_producto
                         Select Nombre = p.categoria.descripcion_cat & " " & p.nombre_producto, ID = p.Id_producto).ToList

        listaproducto.Insert(0, todos)
        Return listaproducto
    End Function
    '
    '
End Class
'