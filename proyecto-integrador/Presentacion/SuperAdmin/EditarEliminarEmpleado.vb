Public Class EditarEliminarEmpleado
    Private Sub TBNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBApellido_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBApellido.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBEstado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBPerfil.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBUsuario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBUsuario.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBPerfil_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBPerfil.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBDni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBTel.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If (IsNull_textbox(TBNombre) = True Or IsNull_textbox(TBApellido) = True Or IsNull_textbox(TBDni) = True Or IsNull_textbox(TBCorreo) = True Or IsNull_textbox(TBTel) = True Or IsNull_textbox(TBPerfil) = True Or IsNull_textbox(TBCont) = True Or Not validar_email(TBCorreo)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            Dim ask = MsgBox("¿Seguro que desea Guardar el Empleado?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

            'si acepta guardamos / mensaje
            If ask = vbYes Then

                'creamos una fila y obtenemos numero de fila
                Dim numRow As Integer = DGV1.Rows.Add()
                'completamos los campos
                DGV1.Rows(numRow).Cells(0).Value = TBNombre.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(1).Value = TBApellido.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(2).Value = TBDni.Text.Trim 'DNI
                DGV1.Rows(numRow).Cells(3).Value = TBTel.Text.Trim 'Telefono
                DGV1.Rows(numRow).Cells(4).Value = TBCorreo.Text.Trim 'Correo
                DGV1.Rows(numRow).Cells(5).Value = TBCont.Text.Trim 'Contraseña
                DGV1.Rows(numRow).Cells(6).Value = TBUsuario.Text.Trim 'Usuario
                DGV1.Rows(numRow).Cells(7).Value = TBPerfil.Text.Trim 'Perfil


                'Reseteamos Form
                TBNombre.Clear()
                TBApellido.Clear()
                TBDni.Clear()
                TBCorreo.Clear()
                TBTel.Clear()
                TBCont.Clear()
                TBUsuario.Clear()
                TBPerfil.Clear()

            End If
        End If



    End Sub


End Class