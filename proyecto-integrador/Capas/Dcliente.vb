Public Class Dcliente

    Dim ctx As PROYECTO2Entities = New PROYECTO2Entities

    Function getAllCliente(ByVal dg As DataGridView)
        dg.DataSource = Me.getAll()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
    End Function
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
            item.telefono_cliente = valor.telefono_cliente
            item.fecha_cliente = valor.fecha_cliente
            item.estado_cliente = valor.estado_cliente

            listacliente.Add(item)

        Next
        Return listacliente
    End Function


    'Retorna true si existe Cliente con el dni recibido como parametro

    Function ExisteCliente(ByVal pdni As String) As Boolean

        Dim buscarClie = (From p In ctx.cliente
                          Where p.dni_cliente = pdni
                          Select p).Count
        If buscarClie = 0 Then
            Return True 'Este cliente ya existe
        Else
            Return False 'Este cliente no existe
        End If
    End Function

    'Devuelve verdadero si existe un teléfono recibido
    Function ExisteTelefono(ByVal ptel As String) As Boolean

        Dim buscarTel = (From p In ctx.cliente
                         Where p.telefono_cliente = ptel
                         Select p).Count
        If buscarTel = 0 Then
            Return True 'Tel ya existe
        Else
            Return False 'Tel no existe
        End If
    End Function


    'Devuelve verdadero si existe un correo recibido
    Function ExisteMail(ByVal pcorreo As String) As Boolean

        Dim buscarCorreo = (From p In ctx.cliente
                            Where p.correo_cliente = pcorreo
                            Select p).Count
        If buscarCorreo = 0 Then
            Return True 'Correo ya existe
        Else
            Return False 'Correo no existe
        End If
    End Function





End Class
