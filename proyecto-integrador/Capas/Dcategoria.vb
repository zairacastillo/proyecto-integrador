Public Class Dcategoria


    Dim ctx As PROYECTO2Entities2 = New PROYECTO2Entities2

    Function getAllcategoria(ByVal dg As DataGridView) As Boolean
        dg.DataSource = Me.getAll()
        'dg.Columns(0).Visible = False
        'dg.Columns(9).Visible = False
        Return False
    End Function
    Function agregrar_categoria(ByVal ocategoria As categoria) As Boolean
        Try
            ctx.categoria.Add(ocategoria)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function getAll() As List(Of categoria)
        Dim lista = (From p In ctx.categoria
                     Order By p.Id_categoria
                     Select p).ToList

        Dim listacategoria = New List(Of categoria)

        For Each valor In lista

            Dim item As categoria = New categoria

            item.Id_categoria = valor.Id_categoria
            item.descripcion_cat = valor.descripcion_cat


            listacategoria.Add(item)

        Next
        Return listacategoria
    End Function

    '    Function ExisteMail(ByVal pmail As String, Optional pid As Integer = -1) As Boolean
    '
    '        Dim listacategorias = (From p In ctx.categoria
    '                               Where p.correo_categoria = pmail
    '                               Select p).ToList
    '
    '        If (listacategorias.Count() = 0) Then
    '            Return False 'Correo no existe
    '        Else
    '            If (listacategorias.First.Id_categoria = pid) Then
    '                Return False 'Correo existe pero es el mismo categoria
    '            End If
    '
    '            MsgBox("ERROR: El Correo ya ha sido registrado", Title:="ERROR")
    '            Return True 'Correo ya existe
    '        End If
    '    End Function
    '
    '    Function ExisteDNI(ByVal pdni As String, Optional pid As Integer = -1) As Boolean
    '
    '        Dim listacategorias = (From p In ctx.categoria
    '                               Where p.dni_categoria = pdni
    '                               Select p).ToList
    '
    '        If (listacategorias.Count() = 0) Then
    '            Return False 'dni no existe
    '        Else
    '            If (listacategorias.First.Id_categoria = pid) Then
    '                Return False 'dni existe pero es el mismo categoria
    '            End If
    '
    '            MsgBox("ERROR: El Dni ya ha sido registrado", Title:="ERROR")
    '            Return True 'dni ya existe
    '        End If
    '    End Function
    '
    'Retorna true si existe categoria con la descripcion recibida como parametro

    Function Existecategoria(ByVal pdesc As String) As Boolean

        Dim buscarCat = (From p In ctx.categoria
                         Where p.descripcion_cat = pdesc
                         Select p).Count
        If buscarCat = 0 Then
            Return False 'Este categoria no existe
        Else
            Return True 'Este categoria ya existe
        End If
    End Function

    '    'Devuelve verdadero si existe un teléfono recibido
    '    Function ExisteTelefono(ByVal ptel As String) As Boolean
    '
    '        Dim buscarTel = (From p In ctx.categoria
    '                         Where p.telefono_categoria = ptel
    '                         Select p).Count
    '        If buscarTel = 0 Then
    '            Return True 'Tel ya existe
    '        Else
    '            Return False 'Tel no existe
    '        End If
    '    End Function
    '
    '
    '    'Devuelve verdadero si existe un correo recibido
    '    Function ExisteMail(ByVal pcorreo As String) As Boolean
    '
    '        Dim buscarCorreo = (From p In ctx.categoria
    '                            Where p.correo_categoria = pcorreo
    '                            Select p).Count
    '        If buscarCorreo = 0 Then
    '            Return True 'Correo ya existe
    '        Else
    '            Return False 'Correo no existe
    '        End If
    '    End Function
    '
    Function buscarCategoria(ByVal pdesc As String) As List(Of categoria)
        Dim lista

        lista = (From p In ctx.categoria
                 Where p.descripcion_cat.Contains(pdesc)
                 Select p).ToList


        Dim listacategoria = New List(Of categoria)

        For Each valor In lista

            Dim item As categoria = New categoria

            item.Id_categoria = valor.Id_categoria
            item.descripcion_cat = valor.descripcion_cat


            listacategoria.Add(item)

        Next
        Return listacategoria
    End Function
    '
    Public Function Modificar(ByVal ocategoria As categoria)

        Dim modif = (From q In ctx.categoria Where (q.Id_categoria = ocategoria.Id_categoria) Select q).First


        modif.descripcion_cat = ocategoria.descripcion_cat



        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '
    '
    '
End Class
