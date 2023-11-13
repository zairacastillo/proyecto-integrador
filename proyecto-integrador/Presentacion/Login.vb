Public Class Login

    Dim objEmpleado As Dempleado = New Dempleado
    Dim objRol As Dperfil = New Dperfil
    Public user As String
    Public id As Integer


    Private Sub BTIniciar_Click(sender As Object, e As EventArgs) Handles BTIniciar.Click
        Try
            Dim usuario As New Dempleado

            If TBUsuario.Text = "" Or TBContraseña.Text = "" Then
                MsgBox("Debe completar los campos ", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
                Exit Sub
            End If


            Dim Oempleado As empleado = New empleado
            Oempleado = usuario.verificarUsuario(TBUsuario.Text, TBContraseña.Text)

            If Oempleado.Id_perfil = 3 Then
                Dim mdi As MDISuperAdmin = New MDISuperAdmin(Oempleado)
                mdi.Show()
                TBUsuario.Clear()
                TBContraseña.Clear()

            ElseIf Oempleado.Id_perfil = 2 Then
                Dim mdi As MDIAdmin = New MDIAdmin(Oempleado)
                mdi.Show()
                TBUsuario.Clear()
                TBContraseña.Clear()

            ElseIf Oempleado.Id_perfil = 1 Then
                Dim mdi As MDIVendedor = New MDIVendedor(Oempleado)
                mdi.Show()
                TBUsuario.Clear()
                TBContraseña.Clear()
            Else
                MsgBox("Usuario o Contraseña incorrecto", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
                TBContraseña.Clear()
            End If

        Catch ex As Exception
            MsgBox("Usuario o Contraseña incorrecto", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
            TBContraseña.Clear()
        End Try

    End Sub






    Private Sub BIniciarV_Click(sender As Object, e As EventArgs)
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

    Private Sub BIniciarA_Click(sender As Object, e As EventArgs)
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

    Private Sub BIniciarS_Click(sender As Object, e As EventArgs)
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

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class