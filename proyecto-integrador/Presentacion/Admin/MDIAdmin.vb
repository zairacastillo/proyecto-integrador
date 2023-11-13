Imports System.Windows.Forms

Public Class MDIAdmin


    Dim vendedor As empleado
    Dim OEmpleado As empleado = New empleado

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

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles BListarVentas.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New SoloListarVentas
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me
        'cantidad formularios abiertos 
        m_ChildFormNumber += 1
        ChildForm.Text = "Listar Ventas"

        ChildForm.Show()
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



    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New NuevoProducto
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Nuevo Producto"

        ChildForm.Show()
    End Sub



    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    'Nuevo Producto
    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BNuevoProducto.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New NuevoProducto
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Nuevo Producto"

        ChildForm.Show()
    End Sub

    'Listar Producto
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BListarProducto.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New EditarEliminarProducto()
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Editar/Eliminar Producto"

        ChildForm.Show()
    End Sub

    Private Sub GestionCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionCategoriaToolStripMenuItem.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New GestionCategoria
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Gestion Categoria"

        ChildForm.Show()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea Cerrar Sesion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then
            Close()
            Login.Show()
        End If
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New RPorCategoria
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Categorias"

        ChildForm.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New RPorCliente
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Clientes"

        ChildForm.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New RPorProducto
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Productos"

        ChildForm.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New RPorEmpleado
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Vendedores"

        ChildForm.Show()
    End Sub
End Class
