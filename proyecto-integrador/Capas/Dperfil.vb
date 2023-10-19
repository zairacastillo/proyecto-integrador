Public Class Dperfil


    Dim ctx As CLUBMENEntities = New CLUBMENEntities


    Function getAll() As List(Of perfil)
        Dim lista = (From p In ctx.perfil
                     Order By p.Id_perfil
                     Select p).ToList

        Dim listaperfil = New List(Of perfil)

        For Each valor In lista

            Dim item As perfil = New perfil

            item.Id_perfil = valor.Id_perfil
            item.descripcion_perfil = valor.descripcion_perfil

            listaperfil.Add(item)

        Next
        Return listaperfil
    End Function

End Class
