Imports System.Text.RegularExpressions ' Regular Expressions
Public Class NuevaFactura
    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub



    'agregamos cliente
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "


        'verificamos campo vacio Apellido
        If Regex.IsMatch(TBNombre.Text.Trim, "^\S+$") = False Then
            msjTxt = msjTxt + " Introduzca Nombre. "
            errorCheck = True
        Else
            'solo caracteres alfabéticos
            If Regex.IsMatch(TBNombre.Text.Trim, "^[A-Za-z ]+$") = False Then
                msjTxt = msjTxt + " Introduzca solo caracteres alfabéticos en el campo Apellido. "
                errorCheck = True
            End If
        End If

        'verificamos campo vacio Precio
        If Regex.IsMatch(TBPrecio.Text.Trim, "^\S+$") = False Then
            msjTxt = msjTxt + " Introduzca Precio. "
            errorCheck = True
            'buscar validacion numerica
            'Else
            'solo caracteres alfabéticos
            'If Regex.IsMatch(TBNombre.Text.Trim, "^[A-Za-z ]+$") = False Then
            'msjTxt = msjTxt + " Introduzca solo caracteres alfabéticos en el campo Nombre. "
            'errorCheck = True
            'End If
        End If

        'si campos no validan
        If errorCheck Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            'mensaje y almacenamiento de resultado en variable
            Dim ask As Integer = MsgBox("¿Seguro que desea Agregar Factura?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

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
                DGV1.Rows(numRow).Cells(1).Value = TBNombre.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(2).Value = TBPrecio.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(3).Value = TBCant.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(4).Value = TBTotal.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(3).Value = DTPFecnac.Text.Trim 'Fecha Nacimiento



                'Reseteamos Form
                TBNombre.Clear()
                'TB.Clear()
                DTPFecnac.ResetText()



            End If
        End If

    End Sub

    Private Sub NuevaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class