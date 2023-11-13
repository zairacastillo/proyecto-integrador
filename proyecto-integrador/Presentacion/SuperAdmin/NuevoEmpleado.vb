Public Class NuevoEmpleado
    Dim ObjPerfil As Dperfil = New Dperfil
    Dim ObjEmpleado As Dempleado = New Dempleado

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

    Private Sub TBEstado_TextChanged(sender As Object, e As KeyPressEventArgs)
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBUsuario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBUsuario.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CBPerfil_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CBPerfil.KeyPress
        e.Handled = True
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
        'define entidad empleado


        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBNombre, TBApellido, TBDni, TBCorreo, TBTel, TBDirec, TBUsuario, TBCont}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Or Not validar_email(TBCorreo) Or TBCont.Text.Length < 8 Then

            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")

        ElseIf ObjEmpleado.ExisteEmpleado(TBDni.Text) = False Then
            MessageBox.Show("El dni ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ObjEmpleado.ExisteMail(TBCorreo.Text) = False Then
            MessageBox.Show("El mail ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ObjEmpleado.ExisteTelefono(TBTel.Text) = False Then
            MessageBox.Show("El Telefono ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ObjEmpleado.ExisteUsuario(TBUsuario.Text) = False Then
            MessageBox.Show("El nombre de usuario ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            'mensaje y almacenamiento de resultado en variable
            Dim ask = MsgBox("¿Seguro que desea Guardar el Empleado?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then

                Dim OEmpleado As New empleado

                OEmpleado.nombre_empleado = TBNombre.Text.Trim
                OEmpleado.apellido_empleado = TBApellido.Text.Trim
                OEmpleado.dni_empleado = TBDni.Text.Trim
                OEmpleado.correo_empleado = TBCorreo.Text.Trim
                OEmpleado.telefono_empleado = TBTel.Text
                OEmpleado.direccion_empleado = TBDirec.Text.Trim
                OEmpleado.usuario = TBUsuario.Text.Trim
                OEmpleado.contraseña = BCrypt.Net.BCrypt.HashPassword(TBCont.Text.Trim)
                OEmpleado.Id_perfil = CBPerfil.SelectedValue
                OEmpleado.fecha_empleado = System.DateTime.Now
                OEmpleado.estado_empleado = "Activo"

                If ObjEmpleado.agregrar_empleado(OEmpleado) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    TBNombre.Clear()
                    TBApellido.Clear()
                    TBDni.Clear()
                    TBCorreo.Clear()
                    TBTel.Clear()
                    TBDirec.Clear()
                    TBUsuario.Clear()
                    TBCont.Clear()
                    CBPerfil.SelectedValue = 0
                Else

                    MsgBox("Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If



            End If
        End If

        ObjEmpleado.getAllEmpleado(DGV1)

    End Sub

    Private Sub NuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CBPerfil.DataSource = ObjPerfil.getAll()
        CBPerfil.DisplayMember = "descripcion_perfil"
        CBPerfil.ValueMember = "Id_perfil"
        CBPerfil.SelectedValue = 0

        ObjEmpleado.getAllEmpleado(DGV1)

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub
End Class