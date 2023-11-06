Imports System.Text.RegularExpressions ' Regular Expressions
'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$        validar email
'^[A-Za-z ]+$                            validar alfabetico
'^[0-9 ]+$                               validar numerico

Public Class ReporteProducto
    Dim ObjCategoria As Dcategoria = New Dcategoria

    'subclase que maneja la entidad producto, intermediario entre entity y la tabla
    Dim ObjProducto As Dproducto = New Dproducto

    Dim estado As String = "Activo"
    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TBID.Text = "" Then
            BReporte.Enabled = False
        Else
            BReporte.Enabled = True
        End If

        Dim categorias = ObjCategoria.getAll()
        'se cargan las categorias
        CBCategoria.DataSource = categorias
        CBCategoria.DisplayMember = "descripcion_cat"
        CBCategoria.ValueMember = "Id_categoria"
        CBCategoria.SelectedValue = 0

        If (DGV1.Columns.Count < 1) Then     ' agrega la columna "seleccionar al inicio
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            colBoton.UseColumnTextForButtonValue = True
            DGV1.Columns.Add(colBoton)
        End If


        'buscamos productos y llenamos la tabla
        ObjProducto.buscarProducto(DGV1, CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)

        ' If Not DGV1.Columns.Contains("Categorias") Then
        '     Dim colCat As New System.Windows.Forms.DataGridViewTextBoxColumn
        '     colCat.HeaderText = "Categorias"
        '     colCat.Name = "Categorias"
        '     DGV1.Columns.Add(colCat)
        ' End If
        '
        '
        ' ObjProducto.llenarCategorias(DGV1)
        'DGV1.Columns(8).Visible = False
        'DGV1.Columns(9).Visible = False
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
        TBEstado.Text = ""
        TBStock.Clear()
        TBDescripcion.Clear()
        TBCategoria.Clear()
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
                        TBEstado.Text = DGV1.Rows(cell.RowIndex).Cells("Estado").Value
                        TBPrecio.Text = Decimal.Parse(DGV1.Rows(cell.RowIndex).Cells("Precio").Value)
                        TBStock.Text = DGV1.Rows(cell.RowIndex).Cells("Stock").Value
                        TBDescripcion.Text = DGV1.Rows(cell.RowIndex).Cells("Descrip").Value
                        TBCategoria.Text = DGV1.Rows(cell.RowIndex).Cells("CodCat").Value
                        BReporte.Enabled = True
                        Exit Select
                End Select

            End If
        End If

    End Sub

    Private Sub CBEstado_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub CBCategoria_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBCategoria.KeyPress
        e.Handled = True
    End Sub
    Private Sub CBCateg_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs)
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

    Private Sub BReporte_Click(sender As Object, e As EventArgs) Handles BReporte.Click
        Dim fechaDesde = DTPDesde.Value
        Dim fechaHasta = DTPHasta.Value
        Dim nombreProducto = TBNombre.Text.Trim
        Dim idProducto = TBID.Text.Trim
        Dim RProd = New RPorProducto(fechaDesde, fechaHasta, idProducto, nombreProducto)
        RProd.Show()
    End Sub
End Class
