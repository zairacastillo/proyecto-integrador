
Imports System.Data.SqlClient

Imports System.ComponentModel

Public Class NuevoCliente

    'subclase que maneja la entidad cliente, intermediario entre entity y la tabla
    Dim ObjCliente As Dcliente = New Dcliente

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBNombre, TBApellido, TBDni, TBCorreo, TBTel, TBDirec}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Or Not validar_email(TBCorreo) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")

        ElseIf objCliente.ExisteCliente(TBDni.Text) = False Then
            MessageBox.Show("El dni ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf objCliente.ExisteMail(TBCorreo.Text) = False Then
            MessageBox.Show("El mail ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ObjCliente.ExisteTelefono(TBTel.Text) = False Then
            MessageBox.Show("El Telefono ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Else

            'mensaje y almacenamiento de resultado en variable
            Dim ask = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then

                'define entidad cliente
                Dim OCliente As New cliente

                OCliente.apellido_cliente = TBApellido.Text.Trim
                OCliente.correo_cliente = TBCorreo.Text.Trim
                OCliente.direccion_cliente = TBDirec.Text.Trim
                OCliente.dni_cliente = TBDni.Text.Trim
                OCliente.nombre_cliente = TBNombre.Text.Trim
                OCliente.telefono_cliente = TBTel.Text.Trim
                OCliente.fecha_cliente = System.DateTime.Now

                If ObjCliente.agregrar_cliente(OCliente) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    TBNombre.Clear()
                    TBApellido.Clear()
                    TBDni.Clear()
                    TBCorreo.Clear()
                    TBTel.Clear()
                    TBDirec.Clear()

                Else

                    MsgBox("Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If



            End If
        End If

        ObjCliente.getAllCliente(DGV1)

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

    Private Sub NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ObjCliente.getAllCliente(DGV1)
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub
End Class