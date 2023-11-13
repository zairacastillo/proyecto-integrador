

Public Class ListarClientes


    'subclase que maneja la entidad cliente, intermediario entre entity y la tabla
    Dim ObjCliente As Dcliente = New Dcliente
    'variable global estado de cliente
    Dim estado As String = "Activo"

    Dim NVenta As NuevaVenta

    Dim mostrarBAgregarVenta As Boolean = False


    Public Sub New(ByVal pNVenta As NuevaVenta, Optional ByVal pBAgregarVenta As Boolean = False)
        InitializeComponent()
        mostrarBAgregarVenta = pBAgregarVenta
        NVenta = pNVenta
    End Sub

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



    Private Sub EditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BAgregarVenta.Enabled = False
        BAgregarVenta.Visible = mostrarBAgregarVenta


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
        DGV1.DataSource = ObjCliente.buscarCliente(p_dni, TBBuscarAp.Text.Trim)
        DGV1.Columns(1).Visible = False
        'DGV1.Columns(10).Visible = False
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

                        TBID.Text = DGV1.Rows(cell.RowIndex).Cells("ID").Value
                        TBNombre.Text = DGV1.Rows(cell.RowIndex).Cells("nombre").Value
                        TBApellido.Text = DGV1.Rows(cell.RowIndex).Cells("apellido").Value
                        TBDni.Text = DGV1.Rows(cell.RowIndex).Cells("DNI").Value
                        TBCorreo.Text = DGV1.Rows(cell.RowIndex).Cells("correo").Value
                        TBTel.Text = DGV1.Rows(cell.RowIndex).Cells("telefono").Value
                        TBDirec.Text = DGV1.Rows(cell.RowIndex).Cells("direccion").Value
                        'TBEstado.Text = DGV1.Rows(cell.RowIndex).Cells("estado_cliente").Value

                        BAgregarVenta.Enabled = mostrarBAgregarVenta
                        BAgregarVenta.Visible = mostrarBAgregarVenta

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

    Private Sub BAgregarVenta_Click(sender As Object, e As EventArgs) Handles BAgregarVenta.Click
        Dim msjTxt As String = "Debe Completar todos los campos: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBNombre, TBApellido, TBDni, TBCorreo, TBTel, TBDirec}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Or Not validar_email(TBCorreo) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            Dim ask = MsgBox("¿Seguro que desea Cargar el Cliente?", MsgBoxStyle.YesNo, Title:="Confirmar Inserción")
            If ask = vbYes Then
                'guardar
                'define entidad cliente
                Dim OCliente As New cliente
                'cargamos de datos un registro cliente
                OCliente.Id_cliente = Integer.Parse(TBID.Text)
                OCliente.apellido_cliente = TBApellido.Text.Trim
                OCliente.correo_cliente = TBCorreo.Text.Trim
                OCliente.direccion_cliente = TBDirec.Text.Trim
                OCliente.dni_cliente = Integer.Parse(TBDni.Text.Trim)
                OCliente.nombre_cliente = TBNombre.Text.Trim
                OCliente.telefono_cliente = TBTel.Text.Trim
                'OCliente.estado_cliente = TBEstado.Text.Trim

                NVenta.CargaCliente(OCliente)
                Me.Close()
            End If
        End If
    End Sub

End Class