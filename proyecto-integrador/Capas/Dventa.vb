Public Class Dventa


    Dim ctx As PROYECTO2Entities2 = New PROYECTO2Entities2

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

        Try
            ctx.venta.Add(oventa)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    '  Function getAll() As List(Of venta)
    '      Dim lista = (From p In ctx.venta
    '                   Order By p.Id_venta
    '                   Select p).ToList
    '
    '      Dim listaventa = New List(Of venta)
    '
    '      For Each valor In lista
    '
    '          Dim item As venta = New venta
    '
    '          item.Id_venta = valor.Id_venta
    '          item.nombre_venta = valor.nombre_venta
    '          item.apellido_venta = valor.apellido_venta
    '          item.dni_venta = valor.dni_venta
    '          item.direccion_venta = valor.direccion_venta
    '          item.correo_venta = valor.correo_venta
    '          item.telefono_venta = valor.telefono_venta
    '          item.fecha_venta = valor.fecha_venta
    '          item.estado_venta = valor.estado_venta
    '
    '          listaventa.Add(item)
    '
    '      Next
    '      Return listaventa
    '  End Function

    ' Function ExisteMail(ByVal pmail As String, Optional pid As Integer = -1) As Boolean
    '
    '     Dim listaVentas = (From p In ctx.venta
    '                        Where p.correo_venta = pmail
    '                        Select p).ToList
    '
    '     If (listaVentas.Count() = 0) Then
    '         Return False 'Correo no existe
    '     Else
    '         If (listaVentas.First.Id_venta = pid) Then
    '             Return False 'Correo existe pero es el mismo venta
    '         End If
    '
    '         MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
    '         Return True 'Correo ya existe
    '     End If
    ' End Function
    '
    ' Function ExisteDNI(ByVal pdni As String, Optional pid As Integer = -1) As Boolean
    '
    '     Dim listaVentas = (From p In ctx.venta
    '                        Where p.dni_venta = pdni
    '                        Select p).ToList
    '
    '     If (listaVentas.Count() = 0) Then
    '         Return False 'dni no existe
    '     Else
    '         If (listaVentas.First.Id_venta = pid) Then
    '             Return False 'dni existe pero es el mismo venta
    '         End If
    '
    '         MsgBox("ERROR: El Dni ya ha sido registrado", Title:="ERROR")
    '         Return True 'dni ya existe
    '     End If
    ' End Function
    '
    ' 'Retorna true si existe Venta con el dni recibido como parametro
    '
    ' Function ExisteVenta(ByVal pdni As String) As Boolean
    '
    '     Dim buscarClie = (From p In ctx.venta
    '                       Where p.dni_venta = pdni
    '                       Select p).Count
    '     If buscarClie = 0 Then
    '         Return True 'Este venta ya existe
    '     Else
    '         Return False 'Este venta no existe
    '     End If
    ' End Function
    '
    ' 'Devuelve verdadero si existe un teléfono recibido
    ' Function ExisteTelefono(ByVal ptel As String) As Boolean
    '
    '     Dim buscarTel = (From p In ctx.venta
    '                      Where p.telefono_venta = ptel
    '                      Select p).Count
    '     If buscarTel = 0 Then
    '         Return True 'Tel ya existe
    '     Else
    '         Return False 'Tel no existe
    '     End If
    ' End Function
    '
    '
    ' 'Devuelve verdadero si existe un correo recibido
    ' Function ExisteMail(ByVal pcorreo As String) As Boolean
    '
    '     Dim buscarCorreo = (From p In ctx.venta
    '                         Where p.correo_venta = pcorreo
    '                         Select p).Count
    '     If buscarCorreo = 0 Then
    '         Return True 'Correo ya existe
    '     Else
    '         Return False 'Correo no existe
    '     End If
    ' End Function
    '
    ' Function buscarVenta(ByVal pdni As Integer, ByVal papellido As String, Optional ByVal pestado As String = "Activo") As List(Of venta)
    '     Dim lista
    '
    '     If (pdni > 0) Then
    '         lista = (From p In ctx.venta
    '                  Where p.dni_venta = pdni And p.estado_venta = pestado
    '                  Select p).ToList
    '     Else
    '         lista = (From p In ctx.venta
    '                  Where p.apellido_venta.Contains(papellido) And p.estado_venta = pestado
    '                  Select p).ToList
    '     End If
    '
    '     Dim listaventa = New List(Of venta)
    '
    '     For Each valor In lista
    '
    '         Dim item As venta = New venta
    '
    '         item.Id_venta = valor.Id_venta
    '         item.nombre_venta = valor.nombre_venta
    '         item.apellido_venta = valor.apellido_venta
    '         item.dni_venta = valor.dni_venta
    '         item.direccion_venta = valor.direccion_venta
    '         item.correo_venta = valor.correo_venta
    '         item.fecha_venta = valor.fecha_venta
    '         item.estado_venta = valor.estado_venta
    '         item.telefono_venta = valor.telefono_venta
    '
    '         listaventa.Add(item)
    '
    '     Next
    '     Return listaventa
    ' End Function
    '
    ' Public Function Modificar(ByVal oventa As venta)
    '
    '     Dim modif = (From q In ctx.venta Where (q.Id_venta = oventa.Id_venta) Select q).First
    '
    '
    '     modif.nombre_venta = oventa.nombre_venta
    '     modif.apellido_venta = oventa.apellido_venta
    '     modif.dni_venta = oventa.dni_venta
    '     modif.direccion_venta = oventa.direccion_venta
    '     modif.correo_venta = oventa.correo_venta
    '     modif.fecha_venta = oventa.fecha_venta
    '     modif.estado_venta = oventa.estado_venta
    '     modif.telefono_venta = oventa.telefono_venta
    '
    '
    '
    '     Try
    '         ctx.SaveChanges()
    '         Return True
    '     Catch ex As Exception
    '         Return False
    '     End Try
    ' End Function



End Class
