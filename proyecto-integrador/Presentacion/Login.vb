Public Class Login
    Private Sub BIniciarV_Click(sender As Object, e As EventArgs) Handles BIniciarV.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBUsuario, TBContraseña}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            MDIVendedor.Show()

        End If
    End Sub

    Private Sub BIniciarA_Click(sender As Object, e As EventArgs) Handles BIniciarA.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBUsuario, TBContraseña}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            MDIAdmin.Show()

        End If
    End Sub

    Private Sub BIniciarS_Click(sender As Object, e As EventArgs) Handles BIniciarS.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBUsuario, TBContraseña}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            MDISuperAdmin.Show()

        End If
    End Sub
End Class