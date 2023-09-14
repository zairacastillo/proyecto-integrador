

Public Class EditarEliminarCliente



    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBNombre, TBApellido, TBDni, TBCorreo, TBTel, TBDirec}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else

            'si campos no validan
            If errorCheck Then
                'Mensaje
                MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
            Else
                'mensaje y almacenamiento de resultado en variable
                Dim ask As Integer = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")
                'creamos una fila y obtenemos numero de fila
                Dim numRow As Integer = DGV1.Rows.Add()
                'completamos los campos
                DGV1.Rows(numRow).Cells(0).Value = TBNombre.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(1).Value = TBApellido.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(2).Value = TBDni.Text.Trim 'DNI
                DGV1.Rows(numRow).Cells(3).Value = TBCorreo.Text.Trim 'Correo
                DGV1.Rows(numRow).Cells(4).Value = TBTel.Text.Trim 'Telefono
                DGV1.Rows(numRow).Cells(5).Value = TBDirec.Text.Trim '


                'Reseteamos Form
                TBNombre.Clear()
                TBApellido.Clear()
                TBDni.Clear()
                TBCorreo.Clear()
                TBTel.Clear()
                TBDirec.Clear()

            End If
        End If


    End Sub

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

    Private Sub TBDni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress, TBDni.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBTel_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBTel.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


End Class