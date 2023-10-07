Imports System.Text.RegularExpressions ' Regular Expressions
'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$        validar email
'^[A-Za-z ]+$                            validar alfabetico
'^[0-9 ]+$                               validar numerico

Public Class EditarEliminarProducto


    'variable global para el archivo destino
    Dim destinationPathFile As String

    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'establecemos altura de las filas
        DGV1.RowTemplate.Height = 50
    End Sub



    Private Sub TBBuscar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos correctamente: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBPrecio, TBEstado, TBStock, TBNombre, CBCateg, TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        End If
    End Sub

    Private Sub TBNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub




    Private Sub TBStock_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress

        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBPrecio_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub




End Class
