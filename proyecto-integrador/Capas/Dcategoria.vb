Public Class Dcategoria


    Dim ctx As CLUBMENEntities = New CLUBMENEntities

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


    Function buscarCategoria(ByVal pdesc As String)
        Dim lista

        lista = (From p In ctx.categoria
                 Where p.descripcion_cat.Contains(pdesc)
                 Select ID = p.Id_categoria, Descripcion = p.descripcion_cat).ToList


        Return lista
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
    Function ObtenerCategorias()

        Dim listacategoria
        Dim todos = New With {Key .Nombre = "Todas Las Categorias", Key .ID = 0}
        listacategoria = (From p In ctx.categoria
                          Order By p.Id_categoria
                          Select Nombre = p.descripcion_cat, ID = p.Id_categoria).ToList

        listacategoria.Insert(0, todos)
        Return listacategoria

    End Function
    '
End Class
