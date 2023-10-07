﻿Imports System.Windows.Forms

Public Class MDIAdmin


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



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BListarVendedores.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New SoloListarEmpleados
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Listar Vendedores"

        ChildForm.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New EliminarCliente
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Listar Cliente"

        ChildForm.Show()
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
        Dim ChildForm As New EditarEliminarProducto
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Editar/Eliminar Producto"

        ChildForm.Show()
    End Sub



    Private Sub BListarClientes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BListarClientes.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New SoloListarClientes
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Listar Clientes"

        ChildForm.Show()
    End Sub

    Private Sub BEliminarClientes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BEliminarClientes.Click
        For Each ChildForma As Form In Me.MdiChildren
            ChildForma.Close()
        Next
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New EliminarCliente
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Eliminar Cliente"

        ChildForm.Show()
    End Sub
End Class
