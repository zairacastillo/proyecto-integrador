

Public Class ReporteCliente


    'subclase que maneja la entidad cliente, intermediario entre entity y la tabla
    Dim ObjCliente As Dcliente = New Dcliente
    'variable global estado de cliente
    Dim estado As String = "Activo"
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

    Private Sub BReporte_Click(sender As Object, e As EventArgs) Handles BReporte.Click
        Dim fechaDesde = DTPDesde.Value
        Dim fechaHasta = DTPHasta.Value
        Dim nombreCliente = TBApellido.Text.Trim + ", " + TBNombre.Text.Trim
        Dim idCliente = TBID.Text.Trim
        Dim RCliente = New RPorCliente(fechaDesde, fechaHasta, idCliente, nombreCliente)
        RCliente.Show()
    End Sub


    Private Sub EditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TBID.Text = "" Then
            BReporte.Enabled = False
        Else
            BReporte.Enabled = True
        End If

        Dim p_dni As Integer = 0
        If Not (TBBuscar.Text.Trim = "") Then
            p_dni = Convert.ToInt32(TBBuscar.Text.Trim)
        End If

        If (DGV1.Columns.Count < 1) Then
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            colBoton.UseColumnTextForButtonValue = True
            DGV1.Columns.Add(colBoton)

        End If

        'buscamos clientes y llenamos la tabla
        DGV1.DataSource = ObjCliente.buscarCliente(p_dni, TBBuscarAp.Text.Trim, estado)
        DGV1.Columns(1).Visible = False
        DGV1.Columns(10).Visible = False
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        TBID.Clear()
        TBNombre.Clear()
        TBApellido.Clear()
        TBDni.Clear()
        TBCorreo.Clear()
        TBTel.Clear()
        TBDirec.Clear()
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
                        TBNombre.Text = DGV1.Rows(cell.RowIndex).Cells(2).Value
                        TBApellido.Text = DGV1.Rows(cell.RowIndex).Cells(3).Value
                        TBDni.Text = DGV1.Rows(cell.RowIndex).Cells(4).Value
                        TBCorreo.Text = DGV1.Rows(cell.RowIndex).Cells(5).Value
                        TBTel.Text = DGV1.Rows(cell.RowIndex).Cells(6).Value
                        TBDirec.Text = DGV1.Rows(cell.RowIndex).Cells(7).Value
                        BReporte.Enabled = True

                        Exit Select
                End Select

            End If
        End If

    End Sub

    Private Sub BBuscarDni_Click(sender As Object, e As EventArgs) Handles BBuscarDni.Click
        EditarCliente_Load(sender, e)
    End Sub

    Private Sub BBuscarAp_Click(sender As Object, e As EventArgs) Handles BBuscarAp.Click
        EditarCliente_Load(sender, e)
    End Sub

    Private Sub BAEstado_Click(sender As Object, e As EventArgs) Handles BAEstado.Click
        'intercambia la variable estado entre activo/inactivo

        If estado = "Activo" Then
            estado = "Inactivo"
            BAEstado.Text = "Mostrar Activos"
        Else
            estado = "Activo"
            BAEstado.Text = "Mostrar Inactivos"
        End If
        EditarCliente_Load(sender, e)
    End Sub

    Private Sub TBBuscarAp_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscarAp.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As KeyPressEventArgs)
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class