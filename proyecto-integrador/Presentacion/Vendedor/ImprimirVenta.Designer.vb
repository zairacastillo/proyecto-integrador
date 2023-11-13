<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirVenta))
        Me.DVGDetalleFac = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LClienteA = New System.Windows.Forms.Label()
        Me.LClienteN = New System.Windows.Forms.Label()
        Me.LVendedorN = New System.Windows.Forms.Label()
        Me.LVendedorA = New System.Windows.Forms.Label()
        Me.LID = New System.Windows.Forms.Label()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LPago = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DVGDetalleFac
        '
        Me.DVGDetalleFac.AllowUserToAddRows = False
        Me.DVGDetalleFac.AllowUserToDeleteRows = False
        Me.DVGDetalleFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DVGDetalleFac.BackgroundColor = System.Drawing.Color.White
        Me.DVGDetalleFac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DVGDetalleFac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DVGDetalleFac.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DVGDetalleFac.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DVGDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDetalleFac.EnableHeadersVisualStyles = False
        Me.DVGDetalleFac.GridColor = System.Drawing.Color.White
        Me.DVGDetalleFac.Location = New System.Drawing.Point(11, 300)
        Me.DVGDetalleFac.Margin = New System.Windows.Forms.Padding(2)
        Me.DVGDetalleFac.Name = "DVGDetalleFac"
        Me.DVGDetalleFac.ReadOnly = True
        Me.DVGDetalleFac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DVGDetalleFac.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DVGDetalleFac.RowHeadersVisible = False
        Me.DVGDetalleFac.RowHeadersWidth = 51
        Me.DVGDetalleFac.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DVGDetalleFac.RowTemplate.Height = 24
        Me.DVGDetalleFac.Size = New System.Drawing.Size(779, 514)
        Me.DVGDetalleFac.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(630, 848)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Total:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(492, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 15)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "415771"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(434, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 15)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "Telefono:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(434, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 15)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Codigo Postal:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(526, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "3400"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(515, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 15)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Cordoba 1200"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(434, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 15)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Domicilio:"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.PictureBox1.Image = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.PictureBox1.Location = New System.Drawing.Point(127, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 88)
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.UseAntiAlias = True
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Vendedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(283, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nro Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(424, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(623, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Location = New System.Drawing.Point(711, 108)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(64, 16)
        Me.LFecha.TabIndex = 44
        Me.LFecha.Text = "________"
        '
        'LClienteA
        '
        Me.LClienteA.AutoSize = True
        Me.LClienteA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClienteA.ForeColor = System.Drawing.Color.Black
        Me.LClienteA.Location = New System.Drawing.Point(632, 242)
        Me.LClienteA.Name = "LClienteA"
        Me.LClienteA.Size = New System.Drawing.Size(64, 16)
        Me.LClienteA.TabIndex = 45
        Me.LClienteA.Text = "________"
        '
        'LClienteN
        '
        Me.LClienteN.AutoSize = True
        Me.LClienteN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClienteN.ForeColor = System.Drawing.Color.Black
        Me.LClienteN.Location = New System.Drawing.Point(730, 242)
        Me.LClienteN.Name = "LClienteN"
        Me.LClienteN.Size = New System.Drawing.Size(64, 16)
        Me.LClienteN.TabIndex = 46
        Me.LClienteN.Text = "________"
        '
        'LVendedorN
        '
        Me.LVendedorN.AutoSize = True
        Me.LVendedorN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedorN.ForeColor = System.Drawing.Color.Black
        Me.LVendedorN.Location = New System.Drawing.Point(221, 242)
        Me.LVendedorN.Name = "LVendedorN"
        Me.LVendedorN.Size = New System.Drawing.Size(64, 16)
        Me.LVendedorN.TabIndex = 47
        Me.LVendedorN.Text = "________"
        '
        'LVendedorA
        '
        Me.LVendedorA.AutoSize = True
        Me.LVendedorA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedorA.ForeColor = System.Drawing.Color.Black
        Me.LVendedorA.Location = New System.Drawing.Point(145, 242)
        Me.LVendedorA.Name = "LVendedorA"
        Me.LVendedorA.Size = New System.Drawing.Size(64, 16)
        Me.LVendedorA.TabIndex = 48
        Me.LVendedorA.Text = "________"
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LID.ForeColor = System.Drawing.Color.Black
        Me.LID.Location = New System.Drawing.Point(420, 157)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(64, 16)
        Me.LID.TabIndex = 49
        Me.LID.Text = "________"
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.ForeColor = System.Drawing.Color.Black
        Me.LTotal.Location = New System.Drawing.Point(711, 855)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(64, 16)
        Me.LTotal.TabIndex = 115
        Me.LTotal.Text = "________"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.ForeColor = System.Drawing.Color.Black
        Me.LDNI.Location = New System.Drawing.Point(542, 242)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(64, 16)
        Me.LDNI.TabIndex = 116
        Me.LDNI.Text = "________"
        '
        'LPago
        '
        Me.LPago.AutoSize = True
        Me.LPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPago.ForeColor = System.Drawing.Color.Black
        Me.LPago.Location = New System.Drawing.Point(86, 157)
        Me.LPago.Name = "LPago"
        Me.LPago.Size = New System.Drawing.Size(64, 16)
        Me.LPago.TabIndex = 118
        Me.LPago.Text = "________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Pago:"
        '
        'ImprimirVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 900)
        Me.ControlBox = False
        Me.Controls.Add(Me.LPago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LDNI)
        Me.Controls.Add(Me.LTotal)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LVendedorA)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LVendedorN)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LClienteN)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LClienteA)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DVGDetalleFac)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImprimirVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprimirVenta"
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DVGDetalleFac As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LClienteA As Label
    Friend WithEvents LClienteN As Label
    Friend WithEvents LVendedorN As Label
    Friend WithEvents LVendedorA As Label
    Friend WithEvents LID As Label
    Friend WithEvents LTotal As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LPago As Label
    Friend WithEvents Label7 As Label
End Class
