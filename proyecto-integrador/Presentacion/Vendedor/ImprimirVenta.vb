Public Class ImprimirVenta
    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Dim OBJVenta As New Dventa
    Dim OBJDetalleVenta As New Ddetalle_Venta
    Dim idVenta As Integer

    Sub New(p_idVenta As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        idVenta = p_idVenta
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' Define los límites de la página
        Dim anchoPagina = e.MarginBounds.Width
        Dim altoPagina = e.MarginBounds.Height

        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub ImprimirVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cabecera = OBJVenta.GetVentaPorId(idVenta)
        OBJDetalleVenta.mostrarDetalle(idVenta, DVGDetalleFac)

        With cabecera
            LID.Text = .Nro_factura

            LVendedorA.Text = .apellidoVendedor
            LVendedorN.Text = .nombreVendedor

            LDNI.Text = .DniCliente
            LClienteA.Text = .apellidoCliente
            LClienteN.Text = .nombreCliente

            LFecha.Text = .fecha_de_factura.Date
            LTotal.Text = .Total

            LPago.Text = .Pago
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LPago.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Public Sub imprimir()
        ' Dim rectangulo As New Rectangle(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100)
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.WindowState = 2
        PrintPreviewDialog1.ShowDialog()
        Me.Close()
    End Sub

End Class