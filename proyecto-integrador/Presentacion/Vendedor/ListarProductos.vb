Imports System.Text.RegularExpressions ' Regular Expressions
'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$        validar email
'^[A-Za-z ]+$                            validar alfabetico
'^[0-9 ]+$                               validar numerico

Public Class ListarProductos
    Dim ObjCategoria As Dcategoria = New Dcategoria

    'subclase que maneja la entidad producto, intermediario entre entity y la tabla
    Dim ObjProducto As Dproducto = New Dproducto

    Dim NVenta As NuevaVenta

    Dim mostrarBAgregarVenta As Boolean = False

    Dim estado As String = "Activo"


    Public Sub New(ByVal pNVenta As NuevaVenta, Optional ByVal pBAgregarVenta As Boolean = False)
        InitializeComponent()
        mostrarBAgregarVenta = pBAgregarVenta
        NVenta = pNVenta
    End Sub


    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BAgregarVenta.Enabled = False
        BAgregarVenta.Visible = mostrarBAgregarVenta

        'Dim categorias = ObjCategoria.getAll()
        'se cargan las categorias
        CBCategoria.DataSource = ObjCategoria.getAll()
        CBCategoria.DisplayMember = "descripcion_cat"
        CBCategoria.ValueMember = "Id_categoria"
        CBCategoria.SelectedValue = 0

        'se cargan las categorias
        'categorias = ObjCategoria.getAll()
        CBCateg.DataSource = ObjCategoria.getAll()
        CBCateg.DisplayMember = "descripcion_cat"
        CBCateg.ValueMember = "Id_categoria"
        CBCateg.SelectedValue = 0

        If (DGV1.Columns.Count < 1) Then
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            DGV1.Columns.Add(colBoton)
        End If

        'buscamos clientes y llenamos la tabla
        DGV1.DataSource = ObjProducto.buscarProducto(CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)
        DGV1.Columns(8).Visible = False
        DGV1.Columns(9).Visible = False
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
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

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
                        TBDescripcion.Text = DGV1.Rows(cell.RowIndex).Cells(6).Value
                        CBCateg.SelectedValue = DGV1.Rows(cell.RowIndex).Cells("Id_categoria").Value

                        BAgregarVenta.Enabled = mostrarBAgregarVenta
                        BAgregarVenta.Visible = mostrarBAgregarVenta

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


    Private Sub BBuscarNombre_Click(sender As Object, e As EventArgs) Handles BBuscarNombre.Click
        DGV1.DataSource = ObjProducto.buscarProducto(CBCategoria.SelectedValue, TBBuscar.Text.Trim, estado)
    End Sub

    Public Sub BAgregarVenta_Click(sender As Object, e As EventArgs) Handles BAgregarVenta.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBID, TBNombre, TBPrecio, TBStock, TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            Dim ask = MsgBox("¿Seguro que desea cargar el producto " + TBNombre.Text.Trim + "?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then
                'guardar

                'define entidad producto
                Dim OProducto As New producto
                'cargamos de datos un registro producto
                OProducto.Id_producto = Integer.Parse(TBID.Text)
                OProducto.estado_producto = CBEstado.SelectedValue
                OProducto.nombre_producto = TBNombre.Text.Trim
                OProducto.precio = TBPrecio.Text.Trim
                OProducto.stock = TBStock.Text.Trim
                OProducto.Id_categoria = CBCateg.SelectedValue
                OProducto.descripcion_producto = TBDescripcion.Text.Trim

                NVenta.CargaProducto(OProducto)
                Me.Close()
            End If
        End If
    End Sub
End Class
