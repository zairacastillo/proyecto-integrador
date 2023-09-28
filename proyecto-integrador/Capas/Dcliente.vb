Public Class Dcliente

    Dim ctx As PROYECTO2Entities = New PROYECTO2Entities

    Function agregrar_cliente(ByVal ocliente As cliente) As Boolean
        Try
            ctx.cliente.Add(ocliente)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function getAll() As List(Of cliente)
        Dim lista = (From p In ctx.cliente
                     Order By p.Id_cliente
                     Select p).ToList

        Dim listacliente = New List(Of cliente)

        For Each valor In lista

            Dim item As cliente = New cliente

            item.Id_cliente = valor.Id_cliente
            item.nombre_cliente = valor.nombre_cliente
            item.apellido_cliente = valor.apellido_cliente
            item.dni_cliente = valor.dni_cliente
            item.direccion_cliente = valor.direccion_cliente
            item.correo_cliente = valor.correo_cliente
            item.fecha_cliente = valor.fecha_cliente
            item.estado_cliente = valor.estado_cliente
            item.telefono_cliente = valor.telefono_cliente

            listacliente.Add(item)

        Next
        Return listacliente
    End Function

    Function ExisteMail(ByVal pmail As String) As Boolean

        Dim buscarCorreo = (From p In ctx.cliente
                            Where p.correo_cliente = pmail
                            Select p).Count
        If buscarCorreo = 0 Then
            Return False 'Correo no existe
        Else
            MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
            Return True 'Correo ya existe
        End If
    End Function

    Function ExisteDNI(ByVal pdni As String) As Boolean

        Dim buscarCorreo = (From p In ctx.cliente
                            Where p.dni_cliente = pdni
                            Select p).Count

        If buscarCorreo = 0 Then
            Return False 'Correo no existe
        Else
            MsgBox("ERROR: El dni ya ha sido registrado", Title:="ERROR")
            Return True 'Correo ya existe
        End If
    End Function

    Function buscarCliente(ByVal pdni As Integer, ByVal papellido As String) As List(Of cliente)
        Dim lista

        If (pdni > 0) Then
            lista = (From p In ctx.cliente
                     Where p.dni_cliente = pdni
                     Select p).ToList
        Else
            lista = (From p In ctx.cliente
                     Where p.apellido_cliente.StartsWith(papellido)
                     Select p).ToList
        End If

        Dim listacliente = New List(Of cliente)

        For Each valor In lista

            Dim item As cliente = New cliente

            item.Id_cliente = valor.Id_cliente
            item.nombre_cliente = valor.nombre_cliente
            item.apellido_cliente = valor.apellido_cliente
            item.dni_cliente = valor.dni_cliente
            item.direccion_cliente = valor.direccion_cliente
            item.correo_cliente = valor.correo_cliente
            item.fecha_cliente = valor.fecha_cliente
            item.estado_cliente = valor.estado_cliente
            item.telefono_cliente = valor.telefono_cliente

            listacliente.Add(item)

        Next
        Return listacliente
    End Function

    Public Function Modificar(ByVal ocliente As cliente)

        Dim modif = (From q In ctx.cliente Where (q.Id_cliente = ocliente.Id_cliente) Select q).First


        modif.nombre_cliente = ocliente.nombre_cliente
        modif.apellido_cliente = ocliente.apellido_cliente
        modif.dni_cliente = ocliente.dni_cliente
        modif.direccion_cliente = ocliente.direccion_cliente
        modif.correo_cliente = ocliente.correo_cliente

        modif.estado_cliente = ocliente.estado_cliente
        modif.telefono_cliente = ocliente.telefono_cliente



        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
