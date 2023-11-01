<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImprimirVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirVenta))
        Me.DVGDetalleFac = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.TBVendedorN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBClienteA = New System.Windows.Forms.TextBox()
        Me.TBClienteN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.TBVendedorA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DVGDetalleFac
        '
        Me.DVGDetalleFac.AllowUserToAddRows = False
        Me.DVGDetalleFac.AllowUserToDeleteRows = False
        Me.DVGDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDetalleFac.Location = New System.Drawing.Point(49, 316)
        Me.DVGDetalleFac.Margin = New System.Windows.Forms.Padding(2)
        Me.DVGDetalleFac.Name = "DVGDetalleFac"
        Me.DVGDetalleFac.ReadOnly = True
        Me.DVGDetalleFac.RowHeadersWidth = 51
        Me.DVGDetalleFac.RowTemplate.Height = 24
        Me.DVGDetalleFac.Size = New System.Drawing.Size(948, 249)
        Me.DVGDetalleFac.TabIndex = 103
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LFecha)
        Me.Panel2.Controls.Add(Me.TBVendedorN)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBClienteA)
        Me.Panel2.Controls.Add(Me.TBClienteN)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TBID)
        Me.Panel2.Controls.Add(Me.TBVendedorA)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(49, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(948, 140)
        Me.Panel2.TabIndex = 105
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LFecha.Location = New System.Drawing.Point(139, 97)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(55, 13)
        Me.LFecha.TabIndex = 44
        Me.LFecha.Text = "________"
        '
        'TBVendedorN
        '
        Me.TBVendedorN.Location = New System.Drawing.Point(695, 35)
        Me.TBVendedorN.Name = "TBVendedorN"
        Me.TBVendedorN.ReadOnly = True
        Me.TBVendedorN.Size = New System.Drawing.Size(169, 20)
        Me.TBVendedorN.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha:"
        '
        'TBClienteA
        '
        Me.TBClienteA.Location = New System.Drawing.Point(517, 93)
        Me.TBClienteA.Name = "TBClienteA"
        Me.TBClienteA.ReadOnly = True
        Me.TBClienteA.Size = New System.Drawing.Size(158, 20)
        Me.TBClienteA.TabIndex = 21
        '
        'TBClienteN
        '
        Me.TBClienteN.Location = New System.Drawing.Point(695, 93)
        Me.TBClienteN.Name = "TBClienteN"
        Me.TBClienteN.ReadOnly = True
        Me.TBClienteN.Size = New System.Drawing.Size(169, 20)
        Me.TBClienteN.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(398, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ID Venta:"
        '
        'TBID
        '
        Me.TBID.BackColor = System.Drawing.SystemColors.Control
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(134, 30)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(169, 20)
        Me.TBID.TabIndex = 40
        '
        'TBVendedorA
        '
        Me.TBVendedorA.Location = New System.Drawing.Point(517, 35)
        Me.TBVendedorA.Name = "TBVendedorA"
        Me.TBVendedorA.ReadOnly = True
        Me.TBVendedorA.Size = New System.Drawing.Size(158, 20)
        Me.TBVendedorA.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(398, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Vendedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(749, 577)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Total:"
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(821, 582)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.ReadOnly = True
        Me.TBTotal.Size = New System.Drawing.Size(169, 20)
        Me.TBTotal.TabIndex = 106
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(507, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "415771"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(449, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "Telefono:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(449, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Codigo Postal:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(541, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "3400"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(530, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Cordoba 1200"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(449, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Domicilio:"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.PictureBox1.Image = Global.proyecto_integrador.My.Resources.Resources.logo11
        Me.PictureBox1.Location = New System.Drawing.Point(125, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 88)
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'ImprimirVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DVGDetalleFac)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImprimirVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprimirVenta"
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DVGDetalleFac As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LFecha As Label
    Friend WithEvents TBVendedorN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBClienteA As TextBox
    Friend WithEvents TBClienteN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents TBVendedorA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
