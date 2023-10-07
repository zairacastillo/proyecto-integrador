Public Class EliminarCliente
    'define entidad cliente
    Dim OCliente As New cliente
    'subclase que maneja la entidad cliente, intermediario entre entity y la tabla
    Dim ObjCliente As Dcliente = New Dcliente
    Private Sub EliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObjCliente.getAllCliente(DGV1)
    End Sub
End Class