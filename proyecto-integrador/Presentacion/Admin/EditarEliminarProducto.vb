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
        CBCategoria.SelectedValue = 0

        'se cargan las categorias
        categorias = ObjCategoria.getAll()
        CBCateg.DataSource = categorias
        CBCateg.DisplayMember = "descripcion_cat"
        CBCateg.ValueMember = "Id_categoria"
        CBCateg.SelectedValue = 0

        If (DGV1.Columns.Count < 1) Then     ' agrega la columna "seleccionar al inicio
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            colBoton.UseColumnTextForButtonValue = True
            DGV1.Columns.Add(colBoton)
        End If

        'buscamos productos y llenamos la tabla
        ObjProducto.buscarProducto(DGV1, CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)
    End Sub

    Private Sub DGV1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        If e.RowIndex >= 0 AndAlso DGV1.Rows(e.RowIndex).Cells("Stock").Value IsNot Nothing Then
            Dim stock As Integer = Convert.ToInt32(DGV1.Rows(e.RowIndex).Cells("Stock").Value)
            If stock = 0 Then
                DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red ' Cambia el color de fondo a rojo
            ElseIf stock < 10 Then
                DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow 'cambia a amarillo
            End If

        End If
    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        If Validar_precio(e) Then
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
        EditarProducto_Load(sender, e)
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

                        TBID.Text = DGV1.Rows(cell.RowIndex).Cells("Codigo").Value
                        TBNombre.Text = DGV1.Rows(cell.RowIndex).Cells("Nombre").Value
                        CBEstado.Text = DGV1.Rows(cell.RowIndex).Cells("Estado").Value
                        TBPrecio.Text = Decimal.Parse(DGV1.Rows(cell.RowIndex).Cells("Precio").Value)
                        TBStock.Text = DGV1.Rows(cell.RowIndex).Cells("Stock").Value
                        TBDescripcion.Text = DGV1.Rows(cell.RowIndex).Cells("Descripcion").Value
                        CBCateg.SelectedValue = DGV1.Rows(cell.RowIndex).Cells("IDCAT").Value

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
    Private Sub CBCateg_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBCateg.KeyPress
        e.Handled = True
    End Sub

    Private Sub BActivarElim_Click(sender As Object, e As EventArgs) Handles BAEstado.Click
        'intercambia la variable estado entre activo/inactivo

        If estado = "Activo" Then
            estado = "Inactivo"
            BAEstado.Text = "Mostrar Activos"
        Else
            estado = "Activo"
            BAEstado.Text = "Mostrar Inactivos"
        End If
        BBuscarNombre_Click(sender, e)
    End Sub

    Private Sub BBuscarNombre_Click(sender As Object, e As EventArgs) Handles BBuscarNombre.Click
        ObjProducto.buscarProducto(DGV1, CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)
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
            Dim ask = MsgBox("¿Seguro que desea Guardar el producto?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
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
                OProducto.descripcion_producto = TBDescripcion.Text.Trim


                If ObjProducto.Modificar(OProducto) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    BCancelar_Click(sender, e)
                    ObjProducto.buscarProducto(DGV1, CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)

                Else
                    MsgBox("ERROR: Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TBBuscar.Clear()
        Dim categorias = ObjCategoria.getAll()
        'se cargan las categorias
        CBCategoria.DataSource = categorias
        CBCategoria.DisplayMember = "descripcion_cat"
        CBCategoria.ValueMember = "Id_categoria"
        CBCategoria.SelectedValue = 0
        'buscamos productos y llenamos la tabla
        ObjProducto.buscarProducto(DGV1, CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)
    End Sub
End Class
