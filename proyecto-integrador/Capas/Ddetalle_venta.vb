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
                         Select id = df.Id_detalle_venta, idPro = df.Id_producto, producto = j.nombre_producto, Cantidad_Comprada = df.cantidad, PrecioUnitario = j.precio, PrecioTotal = f.total).ToList

            grid.DataSource = datos

            'grid.Columns(0).Visible = False
            'grid.Columns(1).Visible = False
            Return True

        Catch ex As Exception
            Return False
            MsgBox("ERROR agregar detalle")

        End Try
    End Function

    '  Function getAll() As List(Of detalle_venta)
    '      Dim lista = (From p In ctx.detalle_venta
    '                   Order By p.Id_detalle_venta
    '                   Select p).ToList
    '
    '      Dim listadetalle_Venta = New List(Of detalle_venta)
    '
    '      For Each valor In lista
    '
    '          Dim item As detalle_venta = New detalle_venta
    '
    '          item.Id_detalle_venta = valor.Id_detalle_venta
    '          item.nombre_detalle_Venta = valor.nombre_detalle_Venta
    '          item.apellido_detalle_Venta = valor.apellido_detalle_Venta
    '          item.dni_detalle_Venta = valor.dni_detalle_Venta
    '          item.direccion_detalle_Venta = valor.direccion_detalle_Venta
    '          item.correo_detalle_Venta = valor.correo_detalle_Venta
    '          item.telefono_detalle_Venta = valor.telefono_detalle_Venta
    '          item.fecha_detalle_Venta = valor.fecha_detalle_Venta
    '          item.estado_detalle_Venta = valor.estado_detalle_Venta
    '
    '          listadetalle_Venta.Add(item)
    '
    '      Next
    '      Return listadetalle_Venta
    '  End Function
    '
    '  Function ExisteMail(ByVal pmail As String, Optional pid As Integer = -1) As Boolean
    '
    '      Dim listaDetalle_Ventas = (From p In ctx.detalle_venta
    '                                 Where p.correo_detalle_Venta = pmail
    '                                 Select p).ToList
    '
    '      If (listaDetalle_Ventas.Count() = 0) Then
    '          Return False 'Correo no existe
    '      Else
    '          If (listaDetalle_Ventas.First.Id_detalle_Venta = pid) Then
    '              Return False 'Correo existe pero es el mismo detalle_Venta
    '          End If
    '
    '          MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
    '          Return True 'Correo ya existe
    '      End If
    '  End Function
    '
    '  Function ExisteDNI(ByVal pdni As String, Optional pid As Integer = -1) As Boolean
    '
    '      Dim listaDetalle_Ventas = (From p In ctx.detalle_venta
    '                                 Where p.dni_detalle_Venta = pdni
    '                                 Select p).ToList
    '
    '      If (listaDetalle_Ventas.Count() = 0) Then
    '          Return False 'dni no existe
    '      Else
    '          If (listaDetalle_Ventas.First.Id_detalle_Venta = pid) Then
    '              Return False 'dni existe pero es el mismo detalle_Venta
    '          End If
    '
    '          MsgBox("ERROR: El Dni ya ha sido registrado", Title:="ERROR")
    '          Return True 'dni ya existe
    '      End If
    '  End Function
    '
    '  'Retorna true si existe Detalle_Venta con el dni recibido como parametro
    '
    '  Function ExisteDetalle_Venta(ByVal pdni As String) As Boolean
    '
    '      Dim buscarClie = (From p In ctx.detalle_venta
    '                        Where p.dni_detalle_Venta = pdni
    '                        Select p).Count
    '      If buscarClie = 0 Then
    '          Return True 'Este detalle_Venta ya existe
    '      Else
    '          Return False 'Este detalle_Venta no existe
    '      End If
    '  End Function
    '
    '  'Devuelve verdadero si existe un teléfono recibido
    '  Function ExisteTelefono(ByVal ptel As String) As Boolean
    '
    '      Dim buscarTel = (From p In ctx.detalle_venta
    '                       Where p.telefono_detalle_Venta = ptel
    '                       Select p).Count
    '      If buscarTel = 0 Then
    '          Return True 'Tel ya existe
    '      Else
    '          Return False 'Tel no existe
    '      End If
    '  End Function
    '
    '
    '  'Devuelve verdadero si existe un correo recibido
    '  Function ExisteMail(ByVal pcorreo As String) As Boolean
    '
    '      Dim buscarCorreo = (From p In ctx.detalle_venta
    '                          Where p.correo_detalle_Venta = pcorreo
    '                          Select p).Count
    '      If buscarCorreo = 0 Then
    '          Return True 'Correo ya existe
    '      Else
    '          Return False 'Correo no existe
    '      End If
    '  End Function
    '
    '  Function buscarDetalle_Venta(ByVal pdni As Integer, ByVal papellido As String, Optional ByVal pestado As String = "Activo") As List(Of detalle_venta)
    '      Dim lista
    '
    '      If (pdni > 0) Then
    '          lista = (From p In ctx.detalle_venta
    '                   Where p.dni_detalle_Venta = pdni And p.estado_detalle_Venta = pestado
    '                   Select p).ToList
    '      Else
    '          lista = (From p In ctx.detalle_venta
    '                   Where p.apellido_detalle_Venta.Contains(papellido) And p.estado_detalle_Venta = pestado
    '                   Select p).ToList
    '      End If
    '
    '      Dim listadetalle_Venta = New List(Of detalle_venta)
    '
    '      For Each valor In lista
    '
    '          Dim item As detalle_venta = New detalle_venta
    '
    '          item.Id_detalle_venta = valor.Id_detalle_Venta
    '          item.nombre_detalle_Venta = valor.nombre_detalle_Venta
    '          item.apellido_detalle_Venta = valor.apellido_detalle_Venta
    '          item.dni_detalle_Venta = valor.dni_detalle_Venta
    '          item.direccion_detalle_Venta = valor.direccion_detalle_Venta
    '          item.correo_detalle_Venta = valor.correo_detalle_Venta
    '          item.fecha_detalle_Venta = valor.fecha_detalle_Venta
    '          item.estado_detalle_Venta = valor.estado_detalle_Venta
    '          item.telefono_detalle_Venta = valor.telefono_detalle_Venta
    '
    '          listadetalle_Venta.Add(item)
    '
    '      Next
    '      Return listadetalle_Venta
    '  End Function
    '
    '  Public Function Modificar(ByVal odetalle_Venta As detalle_venta)
    '
    '      Dim modif = (From q In ctx.detalle_venta Where (q.Id_detalle_venta = odetalle_Venta.Id_detalle_venta) Select q).First
    '
    '
    '      modif.nombre_detalle_Venta = odetalle_Venta.nombre_detalle_Venta
    '      modif.apellido_detalle_Venta = odetalle_Venta.apellido_detalle_Venta
    '      modif.dni_detalle_Venta = odetalle_Venta.dni_detalle_Venta
    '      modif.direccion_detalle_Venta = odetalle_Venta.direccion_detalle_Venta
    '      modif.correo_detalle_Venta = odetalle_Venta.correo_detalle_Venta
    '      modif.fecha_detalle_Venta = odetalle_Venta.fecha_detalle_Venta
    '      modif.estado_detalle_Venta = odetalle_Venta.estado_detalle_Venta
    '      modif.telefono_detalle_Venta = odetalle_Venta.telefono_detalle_Venta
    '
    '
    '
    '      Try
    '          ctx.SaveChanges()
    '          Return True
    '      Catch ex As Exception
    '          Return False
    '      End Try
    '  End Function
    '
    '

End Class
