Public Class SoloListarEmpleados

    Dim ObjPerfil As Dperfil = New Dperfil
    Dim ObjEmpleado As Dempleado = New Dempleado

    Dim estado As String = "Activo"
    Private Sub BBuscarA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TBApellido_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub SoloListarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV1.DataSource = ObjEmpleado.buscarEmpleado(1, TBBuscarApellido.Text.Trim, estado)
        DGV1.Columns(12).Visible = False
        DGV1.Columns(13).Visible = False
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        SoloListarEmpleados_Load(sender, e)
    End Sub
End Class