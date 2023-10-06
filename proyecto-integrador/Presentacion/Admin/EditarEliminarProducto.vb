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




    'agregamos cliente
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) 

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos correctamente: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBID, TBPrecio, TBEstado, TBStock, TBNombre, TBCategoria, TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            'mensaje y almacenamiento de resultado en variable
            Dim ask As Integer = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

            'si acepta guardamos / mensaje
            If ask = DialogResult.Yes Then
                'cambiamos el tipo de fuente de la columna apellido y nombre
                DGV1.Columns(0).DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
                DGV1.Columns(1).DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)


                ' Dim ejemplo As New System.Windows.Forms.DataGridViewTextBoxColumn  tipo de dato texto
                '  Dim ejemplo As New System.Windows.Forms.DataGridViewButtonCell
                '  ejemplo.Value = "Eliminar"


                'creamos una fila y obtenemos numero de fila
                Dim numRow As Integer = DGV1.Rows.Add()
                'completamos los campos
                DGV1.Rows(numRow).Cells(0).Value = TBID.Text.Trim 'ID
                DGV1.Rows(numRow).Cells(1).Value = TBNombre.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(2).Value = TBPrecio.Text.Trim 'Precio
                DGV1.Rows(numRow).Cells(3).Value = TBStock.Text.Trim 'Stock
                DGV1.Rows(numRow).Cells(4).Value = TBCategoria.Text.Trim 'Categoria
                DGV1.Rows(numRow).Cells(5).Value = TBDescripcion.Text.Trim 'Descripcion
                DGV1.Rows(numRow).Cells(6).Value = TBEstado.Text.Trim 'Estado
                DGV1.Rows(numRow).Cells(7).Value = "Seleccionar"

                'falta celda seleccionar


                'Reseteamos Form
                TBNombre.Clear()
                TBID.Clear()
                TBPrecio.Clear()
                TBStock.Clear()
                TBCategoria.Clear()
                TBDescripcion.Clear()
                TBEstado.Clear()

            End If
        End If

    End Sub


    Private Sub TBID_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBID.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub TBPrecio_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBEstado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBEstado.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBStock_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBCategoria_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBCategoria.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBDescripcion_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDescripcion.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

    End Sub
End Class
