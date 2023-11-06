

Public Class ReporteCategoria

    'subclase que maneja la entidad categoria, intermediario entre entity y la tabla
    Dim Objcategoria As Dcategoria = New Dcategoria

    Private Sub TBDescripcion_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDescripcion.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub BReporte_Click(sender As Object, e As EventArgs) Handles BReporte.Click
        Dim fechaDesde = DTPDesde.Value
        Dim fechaHasta = DTPHasta.Value
        Dim nombreCategoria = TBDescripcion.Text.Trim
        Dim idCategoria = TBID.Text.Trim
        Dim RCateg = New RPorCategoria(fechaDesde, fechaHasta, idCategoria, nombreCategoria)
        RCateg.Show()
    End Sub


    Private Sub Editarcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TBID.Text = "" Then
            BReporte.Enabled = False
        Else
            BReporte.Enabled = True
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
        DGV1.Columns(3).Visible = False
        'DGV1.Columns(10).Visible = False
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        TBID.Clear()
        TBDescripcion.Clear()
        BReporte.Enabled = False
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
                        BReporte.Enabled = True
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

End Class