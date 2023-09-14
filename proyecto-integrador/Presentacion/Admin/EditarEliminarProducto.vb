Imports System.Text.RegularExpressions ' Regular Expressions
'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$        validar email
'^[A-Za-z ]+$                            validar alfabetico
'^[0-9 ]+$                               validar numerico

Public Class EditarEliminarProducto





    'variable global para el archivo destino
    Dim destinationPathFile As String

    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'establecemos altura de las filas
        DGV1.RowTemplate.Height = 50
    End Sub


    'Agregamo Foto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BFoto.Click

        'generamos un opendialog file
        Dim AbrirArchivo As OpenFileDialog = New OpenFileDialog()
        AbrirArchivo.Filter = "JPeg Image|*.jpg|Png Image|*.png"
        AbrirArchivo.Title = "Seleccione imagen"
        'Timestamp Unixstamp
        Dim uTime As Integer
        uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        'si el open dialog da OK procedemos
        If (AbrirArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            'comprobamos existencia de carpeta
            Dim folder As String = My.Computer.FileSystem.CurrentDirectory.ToString() + "\Fotos"

            'establecemos destino del archivo
            destinationPathFile = folder + "\" + uTime.ToString + AbrirArchivo.SafeFileName

            'si el directorio no existe lo creamos
            If (Not System.IO.Directory.Exists(folder)) Then
                System.IO.Directory.CreateDirectory(folder)
            End If

            'copias el archivo a la carpeta generada con sobreescritura
            My.Computer.FileSystem.CopyFile(AbrirArchivo.FileName, destinationPathFile, True)

            'mostrar path original imagen el textbox
            TBFoto.Text = AbrirArchivo.FileName

            'cambiar imagen del PictureBox principal
            PBAvatar.BackgroundImage = Image.FromFile(destinationPathFile)

        End If

    End Sub

    'agregamos cliente
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        'variable de mensaje de error
        Dim msjTxt As String = "Debe Completar todos los campos correctamente: "

        ' lista de TB a verificar si estan vacios
        Dim listaTB = {TBID, TBPrecio, TBEstado, TBStock, TBNombre, TBCategoria, TBDescripcion}

        TBVacios(listaTB) ' devuelve true si algun TB esta vacio

        'si campos estan vacios o empiezan con espacio
        If TBVacios(listaTB) Then
            'Mensaje
            MsgBox(msjTxt, MsgBoxStyle.Critical, Title:="Error")
        Else
            'mensaje y almacenamiento de resultado en variable
            Dim ask As Integer = MsgBox("¿Seguro que desea Guardar el Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

            'si acepta guardamos / mensaje
            If ask = DialogResult.Yes Then
                'cambiamos el tipo de fuente de la columna apellido y nombre
                DGV1.Columns(0).DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
                DGV1.Columns(1).DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)


                ' Dim ejemplo As New System.Windows.Forms.DataGridViewTextBoxColumn  tipo de dato texto
                '  Dim ejemplo As New System.Windows.Forms.DataGridViewButtonCell
                '  ejemplo.Value = "Eliminar"


                'creamos una fila y obtenemos numero de fila
                Dim numRow As Integer = DGV1.Rows.Add()
                'completamos los campos
                DGV1.Rows(numRow).Cells(0).Value = TBID.Text.Trim 'Nombre
                DGV1.Rows(numRow).Cells(1).Value = TBNombre.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(2).Value = TBPrecio.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(3).Value = TBStock.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(4).Value = TBCategoria.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(5).Value = TBDescripcion.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(6).Value = TBFoto.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(7).Value = TBEstado.Text.Trim 'Apellido
                DGV1.Rows(numRow).Cells(8).Value = "Editar" 'Titulo boton Eliminar
                DGV1.Rows(numRow).Cells(9).Value = "Eliminar" 'Titulo boton Eliminar

                'Si existe imagen, cargamos en celda
                If (System.IO.File.Exists(destinationPathFile)) Then
                    DGV1.Rows(numRow).Cells(6).Value = Image.FromFile(destinationPathFile)
                Else
                    'sino, tomamos avatar por defecto
                    DGV1.Rows(numRow).Cells(6).Value = My.Resources.avatar
                End If
                DGV1.Rows(numRow).Cells(7).Value = destinationPathFile 'Ruta del archivo destino


                'Reseteamos Form
                TBNombre.Clear()
                TBID.Clear()
                TBPrecio.Clear()
                TBFoto.Clear()
                PBAvatar.BackgroundImage = My.Resources.avatar
                destinationPathFile = ""


            End If
        End If

    End Sub

    'eliminar fila y archivo asociado
    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

        'variable/objeto seleccionado
        Dim cell As DataGridViewButtonCell = TryCast(DGV1.CurrentCell, DataGridViewButtonCell)

        'si la celda no es vacia
        If cell IsNot Nothing Then

            'Genero una variable que contiene el boton en el datagrid
            Dim bc As DataGridViewButtonColumn = TryCast(DGV1.Columns(e.ColumnIndex), DataGridViewButtonColumn)

            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Eliminar" 'Nombre del boton / celda
                        'mensaje y almacenamiento de resultado en variable
                        Dim ask = MsgBox("¿Seguro que desea Eliminar el Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Title:="Confirmar Inserción")

                        'si acepta guardamos / mensaje
                        If ask = vbYes Then
                            'Quitamos fila        
                            DGV1.Rows.RemoveAt(cell.RowIndex)
                        End If


                        Exit Select
                End Select

            End If
        End If

    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

    End Sub

    Private Sub TBID_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBID.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub TBPrecio_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBEstado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBEstado.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBStock_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBCategoria_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBCategoria.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TBDescripcion_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TBDescripcion.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
