
Imports System.Data.SqlClient

Imports System.ComponentModel

Public Class NuevoCliente

    Dim OCliente As New cliente
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
        Else

            'mensaje y almacenamiento de resultado en variable
            Dim ask = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then

                'cargamos de datos un registro cliente
                OCliente.apellido_cliente = TBApellido.Text.Trim
                OCliente.correo_cliente = TBCorreo.Text.Trim
                OCliente.direccion_cliente = TBDirec.Text.Trim
                OCliente.dni_cliente = TBDni.Text.Trim
                OCliente.nombre_cliente = TBNombre.Text.Trim
                OCliente.telefono_cliente = TBTel.Text.Trim
                OCliente.estado_cliente = "Activo"
                OCliente.fecha_cliente = System.DateTime.Now

                'agregamos cliente a la tabla
                If Not ObjCliente.ExisteDNI(OCliente.dni_cliente) AndAlso Not ObjCliente.ExisteMail(OCliente.correo_cliente) AndAlso ObjCliente.agregrar_cliente(OCliente) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    TBNombre.Clear()
                    TBApellido.Clear()
                    TBDni.Clear()
                    TBCorreo.Clear()
                    TBTel.Clear()
                    TBDirec.Clear()

                Else

                    MsgBox("ERROR: Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If



            End If
        End If

        DGV1.DataSource = ObjCliente.getAll()
        DGV1.Columns(0).Visible = False
        DGV1.Columns(9).Visible = False
        'BRecargar_Click(sender, e)

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

    Private Sub getClienteAll(ByVal grid As DataGridView)
        'DataGrid.DataSource = ObjCliente.getAll()

    End Sub

End Class