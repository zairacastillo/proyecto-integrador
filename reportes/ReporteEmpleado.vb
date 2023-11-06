Public Class ReporteEmpleado

    Dim ObjPerfil As Dperfil = New Dperfil
    Dim ObjEmpleado As Dempleado = New Dempleado

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


    Private Sub TBUsuario_TextChanged(sender As Object, e As KeyPressEventArgs)
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBDni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBTel.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub TBBuscarApellido_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBBuscarApellido.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBBuscarDni_TextChanged(sender As Object, e As KeyPressEventArgs)
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub EditarEliminarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        'buscamos empleados y llenamos la tabla
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(1, TBBuscarApellido.Text.Trim, estado)
        DGV1.Columns(13).Visible = False
        DGV1.Columns(14).Visible = False
    End Sub

    Private Sub BReporte_Click(sender As Object, e As EventArgs) Handles BReporte.Click
        Dim fechaDesde = DTPDesde.Value
        Dim fechaHasta = DTPHasta.Value
        Dim nombreEmpleado = TBApellido.Text.Trim + ", " + TBNombre.Text.Trim
        Dim idEmpleado = TBID.Text.Trim
        Dim REmpleado = New RPorEmpleado(fechaDesde, fechaHasta, idEmpleado, nombreEmpleado)
        REmpleado.Show()
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

    Private Sub CBPerfil_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CBEstado_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub CBBuscaPerfil_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
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
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(1, TBBuscarApellido.Text.Trim, estado)
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

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(1, TBBuscarApellido.Text.Trim, estado)
    End Sub

    Private Sub CBBuscaPerfil_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TBBuscarApellido_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class