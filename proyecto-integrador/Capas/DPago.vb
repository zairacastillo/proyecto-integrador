Public Class DPago

    Dim ctx As CLUBMENEntities = New CLUBMENEntities

    Function agregrar_pago(ByVal opago As pago) As Boolean
        Try
            ctx.pago.Add(opago)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function getAll() As List(Of pago)
        Dim lista = (From p In ctx.pago
                     Order By p.Id_pago
                     Select p).ToList

        Dim listapago = New List(Of pago)

        For Each valor In lista

            Dim item As pago = New pago

            item.Id_pago = valor.Id_pago
            item.descripcion_pago = valor.descripcion_pago


            listapago.Add(item)

        Next
        Return listapago
    End Function

End Class
