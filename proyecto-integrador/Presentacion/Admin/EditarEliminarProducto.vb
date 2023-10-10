Imports System.Text.RegularExpressions ' Regular Expressions
'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$        validar email
'^[A-Za-z ]+$                            validar alfabetico
'^[0-9 ]+$                               validar numerico

Public Class EditarEliminarProducto
    Dim ObjCategoria As Dcategoria = New Dcategoria

    'subclase que maneja la entidad producto, intermediario entre entity y la tabla
    Dim ObjProducto As Dproducto = New Dproducto

    Dim estado As String = "Activo"
    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TBID.Text = "" Then
            BEditar.Enabled = False
        Else
            BEditar.Enabled = True
        End If

        Dim categorias = ObjCategoria.getAll()
        'se cargan las categorias
        CBCategoria.DataSource = categorias
        CBCategoria.DisplayMember = "descripcion_cat"
        CBCategoria.ValueMember = "Id_categoria"
        'se cargan las categorias
        categorias = ObjCategoria.getAll()
        CBCateg.DataSource = categorias
        CBCateg.DisplayMember = "descripcion_cat"
        CBCateg.ValueMember = "Id_categoria"

        If (DGV1.Columns.Count < 1) Then
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            DGV1.Columns.Add(colBoton)
        End If

        'buscamos clientes y llenamos la tabla
        DGV1.DataSource = ObjProducto.buscarProducto(Integer.Parse(CBCategoria.SelectedValue), TBBuscar.Text.Trim, estado)
        'DGV1.Columns(1).Visible = False
        'DGV1.Columns(10).Visible = False
    End Sub



    Private Sub TBBuscar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos correctamente: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBPrecio, TBStock, TBNombre, TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            Dim ask = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then
                'guardar
                'define entidad cliente
                Dim OProducto As New producto
                'cargamos de datos un registro cliente
                OProducto.Id_producto = Integer.Parse(TBID.Text)
                OProducto.nombre_producto = TBNombre.Text.Trim
                OProducto.estado_producto = CBEstado.Text.Trim
                OProducto.precio = TBPrecio.Text.Trim
                OProducto.stock = TBStock.Text.Trim
                OProducto.Id_categoria = Integer.Parse(CBCateg.SelectedValue)



                If ObjProducto.Modificar(OProducto) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    BCancelar_Click(sender, e)
                    DGV1.DataSource = ObjProducto.getAll()

                Else
                    MsgBox("ERROR: Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If

            End If
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

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        TBID.Clear()
        TBNombre.Clear()
        TBPrecio.Clear()
        CBEstado.Text = ""
        TBStock.Clear()
        TBDescripcion.Clear()
        BEditar.Enabled = False
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

        'variable/objeto seleccionado
        Dim cell As DataGridViewButtonCell = TryCast(DGV1.CurrentCell, DataGridViewButtonCell)

        'si la celda no es vacia
        If cell IsNot Nothing Then

            'Genero una variable que contiene el boton en el datagrid
            Dim bc As DataGridViewButtonColumn = TryCast(DGV1.Columns(e.ColumnIndex), DataGridViewButtonColumn)

            If bc IsNot Nothing Then
                'Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.HeaderText
                    Case "Seleccionar" 'Nombre del boton / celda

                        TBID.Text = DGV1.Rows(cell.RowIndex).Cells(1).Value
                        TBNombre.Text = DGV1.Rows(cell.RowIndex).Cells(2).Value
                        CBEstado.Text = DGV1.Rows(cell.RowIndex).Cells(3).Value
                        TBPrecio.Text = DGV1.Rows(cell.RowIndex).Cells(4).Value
                        TBStock.Text = DGV1.Rows(cell.RowIndex).Cells(5).Value
                        CBCateg.SelectedValue = DGV1.Rows(cell.RowIndex).Cells(6).Value

                        BEditar.Enabled = True

                        Exit Select
                End Select

            End If
        End If

    End Sub

    Private Sub CBEstado_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBEstado.KeyPress
        e.Handled = True
    End Sub
    Private Sub CBCategoria_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub BActivarElim_Click(sender As Object, e As EventArgs) Handles BActivarElim.Click
        'intercambia la variable estado entre activo/inactivo
        If estado = "Activo" Then
            estado = "Inactivo"
        Else
            estado = "Activo"
        End If
        BBuscarCat_Click(sender, e)
    End Sub

    Private Sub BBuscarNombre_Click(sender As Object, e As EventArgs) Handles BBuscarNombre.Click
        DGV1.DataSource = ObjProducto.buscarProducto(-1, TBBuscar.Text.Trim, estado)
    End Sub

    Private Sub BBuscarCat_Click(sender As Object, e As EventArgs) Handles BBuscarCat.Click
        DGV1.DataSource = ObjProducto.buscarProducto(Integer.Parse(CBCategoria.SelectedValue), TBBuscar.Text.Trim, estado)
    End Sub

End Class
