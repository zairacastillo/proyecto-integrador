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
    '
    '    Function ExisteMail(ByVal pmail As String, Optional pid As Integer = -1) As Boolean
    '
    '        Dim listaproductos = (From p In ctx.producto
    '                              Where p.correo_producto = pmail
    '                              Select p).ToList
    '
    '        If (listaproductos.Count() = 0) Then
    '            Return False 'Correo no existe
    '        Else
    '            If (listaproductos.First.Id_producto = pid) Then
    '                Return False 'Correo existe pero es el mismo producto
    '            End If
    '
    '            MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
    '            Return True 'Correo ya existe
    '        End If
    '    End Function
    '
    '    Function ExisteDNI(ByVal pdni As String, Optional pid As Integer = -1) As Boolean
    '
    '        Dim listaproductos = (From p In ctx.producto
    '                              Where p.dni_producto = pdni
    '                              Select p).ToList
    '
    '        If (listaproductos.Count() = 0) Then
    '            Return False 'dni no existe
    '        Else
    '            If (listaproductos.First.Id_producto = pid) Then
    '                Return False 'dni existe pero es el mismo producto
    '            End If
    '
    '            MsgBox("ERROR: El Dni ya ha sido registrado", Title:="ERROR")
    '            Return True 'dni ya existe
    '        End If
    '    End Function
    '
    '    'Retorna true si existe producto con el dni recibido como parametro
    '
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


    Function buscarProducto(Optional ByVal pidCategoria As Integer = 0, Optional ByVal pnombre As String = "", Optional ByVal pestado As String = "Activo") As List(Of producto)
        Dim lista

        If (pidCategoria > 0) Then
            lista = (From p In ctx.producto
                     Where p.Id_categoria = pidCategoria And p.nombre_producto.Contains(pnombre) And p.estado_producto = pestado
                     Select p).ToList
        Else
            lista = (From p In ctx.producto
                     Where p.nombre_producto.Contains(pnombre) And p.estado_producto = pestado
                     Select p).ToList
        End If

        Dim listaproducto = New List(Of producto)

        For Each valor In lista

            Dim item As producto = New producto

            item.Id_producto = valor.Id_producto
            item.nombre_producto = valor.nombre_producto
            item.estado_producto = valor.estado_producto
            item.precio = valor.precio
            item.stock = valor.stock
            item.Id_categoria = valor.Id_categoria
            item.descripcion_producto = valor.descripcion_producto
            item.categoria = valor.categoria
            listaproducto.Add(item)

        Next
        Return listaproducto
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
    '
    '
    '
End Class
'