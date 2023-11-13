

Public Class GestionCategoria

    'subclase que maneja la entidad categoria, intermediario entre entity y la tabla
    Dim Objcategoria As Dcategoria = New Dcategoria

    Private Sub TBDescripcion_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDescripcion.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")

        ElseIf Objcategoria.Existecategoria(TBDescripcion.Text.Trim) Then
            MessageBox.Show("La categoria ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim ask = MsgBox("¿Seguro que desea actualizar la categoria?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then
                'guardar

                'define entidad categoria
                Dim Ocategoria As New categoria
                'cargamos de datos un registro categoria
                Ocategoria.Id_categoria = Integer.Parse(TBID.Text.Trim)
                Ocategoria.descripcion_cat = TBDescripcion.Text.Trim

                If Not Objcategoria.Existecategoria(Ocategoria.descripcion_cat) AndAlso Objcategoria.Modificar(Ocategoria) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    BCancelar_Click(sender, e)
                    DGV1.DataSource = Objcategoria.getAll()

                Else
                    MsgBox("ERROR: Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If

            End If
        End If
    End Sub


    Private Sub Editarcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TBID.Text = "" Then
            BEditar.Enabled = False
            BNuevaCategoria.Enabled = True
        Else
            BEditar.Enabled = True
            BNuevaCategoria.Enabled = False
        End If

        If (DGV1.Columns.Count < 1) Then
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            colBoton.UseColumnTextForButtonValue = True
            DGV1.Columns.Add(colBoton)
        End If

        'buscamos categorias y llenamos la tabla
        DGV1.DataSource = Objcategoria.buscarCategoria(TBBuscarDesc.Text.Trim)
        'DGV1.Columns(3).Visible = False
        'DGV1.Columns(10).Visible = False
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        TBID.Clear()
        TBDescripcion.Clear()
        BEditar.Enabled = False
        BNuevaCategoria.Enabled = True
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
                        TBDescripcion.Text = DGV1.Rows(cell.RowIndex).Cells(2).Value
                        BEditar.Enabled = True
                        BNuevaCategoria.Enabled = False
                        Exit Select
                End Select

            End If
        End If

    End Sub


    Private Sub BBuscarDesc_Click(sender As Object, e As EventArgs) Handles BBuscarDesc.Click
        Editarcategoria_Load(sender, e)
    End Sub

    Private Sub TBBuscarDesc_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscarDesc.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BNuevaCategoria_Click(sender As Object, e As EventArgs) Handles BNuevaCategoria.Click
        'variable de control
        Dim errorCheck As Boolean = False

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBDescripcion}

        'TBVacios(listaTB)  devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")

        ElseIf TBID.Text IsNot "" Then
            MessageBox.Show("El campo ID debe estar vacio para crear una nueva categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Objcategoria.Existecategoria(TBDescripcion.Text.Trim) Then
            MessageBox.Show("La categoria ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            'mensaje y almacenamiento de resultado en variable
            Dim ask = MsgBox("¿Seguro que desea Guardar el categoria?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then

                'define entidad categoria
                Dim Ocategoria As New categoria
                Ocategoria.descripcion_cat = TBDescripcion.Text.Trim

                If Objcategoria.agregrar_categoria(Ocategoria) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    TBDescripcion.Clear()

                Else

                    MsgBox("Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If



            End If
        End If

        Objcategoria.getAllcategoria(DGV1)
    End Sub
End Class