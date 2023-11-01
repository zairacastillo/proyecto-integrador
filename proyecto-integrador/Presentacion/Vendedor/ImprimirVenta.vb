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
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub ImprimirVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cabecera = OBJVenta.GetVentaPorId(idVenta)
        OBJDetalleVenta.mostrarDetalle(idVenta, DVGDetalleFac)

        With cabecera
            TBID.Text = .Nro_factura

            TBVendedorA.Text = .apellidoVendedor
            TBVendedorN.Text = .nombreVendedor

            TBClienteA.Text = .apellidoCliente
            TBClienteN.Text = .nombreCliente

            LFecha.Text = .fecha_de_factura.Date
            TBTotal.Text = .Total
        End With
    End Sub

    Public Sub imprimir()

        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()
    End Sub

End Class