Public Class EditarEliminarEmpleado

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


   Private Sub TBUsuario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBUsuario.KeyPress
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
        CBBuscaPerfil.DataSource = ObjPerfil.getAll()
        CBBuscaPerfil.DisplayMember = "descripcion_perfil"
        CBBuscaPerfil.ValueMember = "Id_perfil"
        CBBuscaPerfil.SelectedValue = 0

        CBPerfil.DataSource = ObjPerfil.getAll()
        CBPerfil.DisplayMember = "descripcion_perfil"
        CBPerfil.ValueMember = "Id_perfil"
        CBPerfil.SelectedValue = 0



        If TBID.Text = "" Then
            BEditar.Enabled = False
        Else
            BEditar.Enabled = True
        End If

        If (DGV1.Columns.Count < 1) Then
            Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
            colBoton.HeaderText = "Seleccionar"
            colBoton.Text = "Seleccionar"
            DGV1.Columns.Add(colBoton)
        End If

        'buscamos empleados y llenamos la tabla
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(CBBuscaPerfil.SelectedValue, TBBuscarApellido.Text.Trim, estado)
        'DGV1.Columns(1).Visible = False
        'DGV1.Columns(10).Visible = False
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
       Dim msjTxt As String = "Debe Completar todos los campos: "

       ' lista de TB a verificar si estan vacios
       Dim listaTB = {TBNombre, TBApellido, TBDni, TBCorreo, TBTel, TBDirec, TBUsuario, TBCont}

       TBVacios(listaTB) ' devuelve true si algun TB esta vacio

       'si campos estan vacios o empiezan con espacio
       If TBVacios(listaTB) Or Not validar_email(TBCorreo) Then
           'Mensaje
           MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
       Else
           Dim ask = MsgBox("¿Seguro que desea Guardar el Empleado?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
           If ask = vbYes Then
               'guardar
               'define entidad empleado
               Dim OEmpleado As New empleado
                'cargamos de datos un registro empleado
                OEmpleado.Id_empleado = TBID.Text.Trim
                OEmpleado.nombre_empleado = TBNombre.Text.Trim
                OEmpleado.apellido_empleado = TBApellido.Text.Trim
                OEmpleado.dni_empleado = TBDni.Text.Trim
                OEmpleado.correo_empleado = TBCorreo.Text.Trim
                OEmpleado.telefono_empleado = TBTel.Text.Trim
                OEmpleado.direccion_empleado = TBDirec.Text.Trim
                OEmpleado.usuario = TBUsuario.Text.Trim
                OEmpleado.contraseña = TBCont.Text.Trim
                OEmpleado.Id_perfil = CBPerfil.SelectedValue
                OEmpleado.estado_empleado = CBEstado.Text

                If Not ObjEmpleado.ExisteDNI(OEmpleado.dni_empleado, OEmpleado.Id_empleado) And Not ObjEmpleado.ExisteMail(OEmpleado.correo_empleado, OEmpleado.Id_empleado) And Not ObjEmpleado.ExisteUser(OEmpleado.usuario, OEmpleado.Id_empleado) AndAlso ObjEmpleado.Modificar(OEmpleado) Then

                    MsgBox("Los datos se guardaron correctamente", Title:="Confirmar Inserción")
                    'Reseteamos Form
                    BCancelar_Click(sender, e)
                    DGV1.DataSource = ObjEmpleado.getAll()

                Else
                    MsgBox("ERROR: Los datos NO se guardaron correctamente", Title:="ERROR Inserción")
                End If

            End If
       End If
   End Sub

   Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
       TBID.Clear()
       TBNombre.Clear()
       TBApellido.Clear()
       TBDni.Clear()
       TBCorreo.Clear()
       TBTel.Clear()
       TBDirec.Clear()
       CBPerfil.SelectedValue = 0
       BEditar.Enabled = False
   End Sub

   Private Sub CBPerfil_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBPerfil.KeyPress
       e.Handled = True
   End Sub

    Private Sub CBEstado_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBEstado.KeyPress
        e.Handled = True
    End Sub
    Private Sub CBBuscaPerfil_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles CBBuscaPerfil.KeyPress
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
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(CBBuscaPerfil.SelectedValue, TBBuscarApellido.Text.Trim, estado)
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
                        TBUsuario.Text = DGV1.Rows(cell.RowIndex).Cells(8).Value
                        TBCont.Text = DGV1.Rows(cell.RowIndex).Cells(9).Value
                        CBPerfil.SelectedValue = DGV1.Rows(cell.RowIndex).Cells(10).Value
                        CBEstado.Text = DGV1.Rows(cell.RowIndex).Cells(12).Value
                        BEditar.Enabled = True
                        Exit Select
                End Select

            End If
        End If

    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(CBBuscaPerfil.SelectedValue, TBBuscarApellido.Text.Trim, estado)
    End Sub


End Class