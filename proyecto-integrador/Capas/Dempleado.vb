Public Class Dempleado


    Dim ctx As PROYECTO2Entities2 = New PROYECTO2Entities2

    Function getAllEmpleado(ByVal dg As DataGridView) As Boolean
        dg.DataSource = Me.getAll()
        'dg.Columns(0).Visible = False
        'dg.Columns(9).Visible = False
        Return False
    End Function
    Function agregrar_empleado(ByVal oempleado As empleado) As Boolean
        Try
            ctx.empleado.Add(oempleado)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function getAll() As List(Of empleado)
        Dim lista = (From p In ctx.empleado
                     Order By p.Id_empleado
                     Select p).ToList

        Dim listaempleado = New List(Of empleado)

        For Each valor In lista

            Dim item As empleado = New empleado

            item.Id_empleado = valor.Id_empleado
            item.nombre_empleado = valor.nombre_empleado
            item.apellido_empleado = valor.apellido_empleado
            item.dni_empleado = valor.dni_empleado
            item.direccion_empleado = valor.direccion_empleado
            item.correo_empleado = valor.correo_empleado
            item.telefono_empleado = valor.telefono_empleado
            item.direccion_empleado = valor.direccion_empleado
            item.usuario = valor.usuario
            item.contraseña = valor.contraseña
            item.Id_perfil = valor.Id_perfil
            item.fecha_empleado = valor.fecha_empleado
            item.estado_empleado = valor.estado_empleado

            listaempleado.Add(item)

        Next
        Return listaempleado
    End Function

    Function ExisteMail(ByVal pmail As String, Optional pid As Integer = -1) As Boolean

        Dim listaEmpleados = (From p In ctx.empleado
                              Where p.correo_empleado = pmail
                              Select p).ToList

        If (listaEmpleados.Count() = 0) Then
            Return False 'Correo no existe
        Else
            If (listaEmpleados.First.Id_empleado = pid) Then
                Return False 'Correo existe pero es el mismo empleado
            End If

            MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
            Return True 'Correo ya existe
        End If
    End Function

    Function ExisteUser(ByVal pUser As String, Optional pid As Integer = -1) As Boolean

        Dim listaEmpleados = (From p In ctx.empleado
                              Where p.usuario = pUser
                              Select p).ToList

        If (listaEmpleados.Count() = 0) Then
            Return False 'Correo no existe
        Else
            If (listaEmpleados.First.Id_empleado = pid) Then
                Return False 'Correo existe pero es el mismo empleado
            End If

            MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
            Return True 'Correo ya existe
        End If
    End Function

    Function ExisteDNI(ByVal pdni As String, Optional pid As Integer = -1) As Boolean

        Dim listaEmpleados = (From p In ctx.empleado
                              Where p.dni_empleado = pdni
                              Select p).ToList

        If (listaEmpleados.Count() = 0) Then
            Return False 'dni no existe
        Else
            If (listaEmpleados.First.Id_empleado = pid) Then
                Return False 'dni existe pero es el mismo empleado
            End If

            MsgBox("ERROR: El Dni ya ha sido registrado", Title:="ERROR")
            Return True 'dni ya existe
        End If
    End Function

    'Retorna true si existe Empleado con el dni recibido como parametro

    Function ExisteEmpleado(ByVal pdni As String) As Boolean

        Dim buscarClie = (From p In ctx.empleado
                          Where p.dni_empleado = pdni
                          Select p).Count
        If buscarClie = 0 Then
            Return True 'Este empleado ya existe
        Else
            Return False 'Este empleado no existe
        End If
    End Function

    'Devuelve verdadero si existe un teléfono recibido
    Function ExisteTelefono(ByVal ptel As String) As Boolean

        Dim buscarTel = (From p In ctx.empleado
                         Where p.telefono_empleado = ptel
                         Select p).Count
        If buscarTel = 0 Then
            Return True 'Tel ya existe
        Else
            Return False 'Tel no existe
        End If
    End Function
    Function ExisteUsuario(ByVal puser As String) As Boolean

        Dim buscarUser = (From p In ctx.empleado
                          Where p.usuario = puser
                          Select p).Count
        If buscarUser = 0 Then
            Return True 'Tel ya existe
        Else
            Return False 'Tel no existe
        End If
    End Function

    'Devuelve verdadero si existe un correo recibido
    Function ExisteMail(ByVal pcorreo As String) As Boolean

        Dim buscarCorreo = (From p In ctx.empleado
                            Where p.correo_empleado = pcorreo
                            Select p).Count
        If buscarCorreo = 0 Then
            Return True 'Correo ya existe
        Else
            Return False 'Correo no existe
        End If
    End Function

    Function buscarEmpleado(ByVal pIdPerfil As Integer, ByVal pApellido As String, Optional ByVal pestado As String = "Activo") As List(Of empleado)
        Dim lista

        If (pIdPerfil > 0) Then
            lista = (From p In ctx.empleado
                     Where p.Id_perfil = pIdPerfil And p.apellido_empleado.Contains(pApellido) And p.estado_empleado = pestado
                     Select p).ToList
        Else
            lista = (From p In ctx.empleado
                     Where p.apellido_empleado.Contains(pApellido) And p.estado_empleado = pestado
                     Select p).ToList
        End If

        Dim listaempleado = New List(Of empleado)

        For Each valor In lista

            Dim item As empleado = New empleado

            item.Id_empleado = valor.Id_empleado
            item.nombre_empleado = valor.nombre_empleado
            item.apellido_empleado = valor.apellido_empleado
            item.dni_empleado = valor.dni_empleado
            item.direccion_empleado = valor.direccion_empleado
            item.correo_empleado = valor.correo_empleado
            item.telefono_empleado = valor.telefono_empleado
            item.direccion_empleado = valor.direccion_empleado
            item.usuario = valor.usuario
            item.contraseña = valor.contraseña
            item.Id_perfil = valor.Id_perfil
            item.fecha_empleado = valor.fecha_empleado
            item.estado_empleado = valor.estado_empleado


            listaempleado.Add(item)

        Next
        Return listaempleado
    End Function

    Public Function Modificar(ByVal oempleado As empleado)

        Dim modif = (From q In ctx.empleado Where (q.Id_empleado = oempleado.Id_empleado) Select q).First

        modif.Id_empleado = oempleado.Id_empleado
        modif.nombre_empleado = oempleado.nombre_empleado
        modif.apellido_empleado = oempleado.apellido_empleado
        modif.dni_empleado = oempleado.dni_empleado
        modif.direccion_empleado = oempleado.direccion_empleado
        modif.correo_empleado = oempleado.correo_empleado
        modif.telefono_empleado = oempleado.telefono_empleado
        modif.direccion_empleado = oempleado.direccion_empleado
        modif.usuario = oempleado.usuario
        modif.contraseña = oempleado.contraseña
        modif.Id_perfil = oempleado.Id_perfil
        modif.estado_empleado = oempleado.estado_empleado

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



End Class
