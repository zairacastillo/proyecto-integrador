Imports System.Windows.Forms
Imports System.IO
Imports IWshRuntimeLibrary
Imports System.Data.SqlClient

Public Class MDISuperAdmin

    Dim vendedor As empleado
    Dim OEmpleado As empleado = New empleado

    Dim cn As New CLUBMENEntities
    Dim da As SqlDataAdapter
    Dim dst As DataSet

    Public Sub New(pempleado As empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        OEmpleado = pempleado

        LEmpleadoA.Text = OEmpleado.apellido_empleado
        LEmpleadoN.Text = OEmpleado.nombre_empleado
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BNuevoUsuario.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New NuevoEmpleado
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Nuevo Empleado"

        ChildForm.Show()
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BEditarEliminar.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New EditarEliminarEmpleado
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Editar\Eliminar Usuario"

        ChildForm.Show()
    End Sub




    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.BEditarEliminar.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim nombre As String
            nombre = "CLUBMEN" & Now.Day & "_" & Now.Month & "_" & Now.Year & "_" & Now.Hour & "_" & Now.Minute & ".bak"
            Dim destino_backup As String = "C:\Backup\"

            Using cnx As New SqlConnection("Data Source =.\SQLEXPRESS;Initial Catalog=CLUBMEN;Integrated Security=True")

                cnx.Open()


                Using cmd As New SqlCommand("BACKUP DATABASE [CLUBMEN] TO DISK='" & destino_backup & " " & nombre & "' ", cnx)

                    cmd.ExecuteNonQuery()
                    MsgBox("SE CREO EL BACKUP CORRECTAMENTE ")

                End Using
            End Using
        Catch ex As Exception
            MsgBox("OCURRIO UN ERROR DURANTE LA CREACION DEL BACKUP")
        End Try
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea Cerrar Sesion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then
            Close()
            Login.Show()
        End If
    End Sub

End Class
