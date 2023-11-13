Imports System.Text.RegularExpressions ' Regular Expressions
'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$        validar email
'^[A-Za-z ]+$                            validar alfabetico
'^[0-9 ]+$                               validar numerico

Public Class NuevoProducto
    Dim ObjCategoria As Dcategoria = New Dcategoria

    'subclase que maneja la entidad producto, intermediario entre entity y la tabla
    Dim ObjProducto As Dproducto = New Dproducto

    Private Sub NuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'se cargan las categorias
        CBCategoria.DataSource = ObjCategoria.getAll()
        CBCategoria.DisplayMember = "descripcion_cat"
        CBCategoria.ValueMember = "Id_categoria"
        CBCategoria.SelectedValue = 0


        ObjProducto.GetProductoAll(DGV1)
        For fila As Integer = 0 To DGV1.Rows.Count - 1
            Dim dvgstock = DGV1.Item(6, fila).Value
            If dvgstock > 1 Then
                DGV1.Rows(fila).DefaultCellStyle.BackColor = Color.Blue

            End If

        Next

    End Sub

    Private Sub DGV1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        If e.RowIndex >= 0 AndAlso DGV1.Rows(e.RowIndex).Cells("Stock").Value IsNot Nothing Then
            Dim stock As Integer = Convert.ToInt32(DGV1.Rows(e.RowIndex).Cells("Stock").Value)
            If stock = 0 Then
                DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red ' Cambia el color de fondo a rojo
            ElseIf stock < 10 Then
                DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            End If

        End If
    End Sub


    'agregamos producto
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBNombre, TBPrecio, TBStock, TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Or CBCategoria.SelectedValue < 1 Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")

        ElseIf ObjProducto.ExisteProducto(TBNombre.Text) Then
            MessageBox.Show("El nombre de producto ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            'mensaje y almacenamiento de resultado en variable
            Dim ask = MsgBox("¿Seguro que desea Guardar el Producto?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then

                'define entidad producto
                Dim OProducto As New producto

                OProducto.nombre_producto = TBNombre.Text.Trim
                OProducto.estado_producto = "Activo"
                OProducto.precio = Decimal.Parse(TBPrecio.Text.Trim)
                OProducto.stock = TBStock.Text.Trim
                OProducto.Id_categoria = Integer.Parse(CBCategoria.SelectedValue)
                OProducto.descripcion_producto = TBDescripcion.Text.Trim

                If ObjProducto.agregrar_producto(OProducto) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    TBNombre.Clear()
                    TBPrecio.Clear()
                    TBStock.Clear()
                    TBDescripcion.Clear()
                Else

                    MsgBox("Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If



            End If
        End If
        ObjProducto.GetProductoAll(DGV1)


    End Sub



    Private Sub TBPrecio_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress
        If Validar_precio(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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


    Private Sub CBCategoria_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub
End Class
