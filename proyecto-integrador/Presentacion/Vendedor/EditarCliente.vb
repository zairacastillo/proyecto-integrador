

Public Class EditarCliente

    'define entidad cliente
    Dim OCliente As New cliente
    'subclase que maneja la entidad cliente, intermediario entre entity y la tabla
    Dim ObjCliente As Dcliente = New Dcliente
    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

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

    Private Sub TBDni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBTel_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBTel.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBNombre, TBApellido, TBDni, TBCorreo, TBTel, TBDirec}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Or Not validar_email(TBCorreo) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            Dim ask = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then
                'guardar
            End If
        End If
    End Sub


    Private Sub EditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObjCliente.getAllCliente(DGV1)
    End Sub


End Class