Public Class fAlmacen
    Property MerConocimiento As String
    Property MerConocimientoOrigen As String

    Private Sub fAlmacen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia

        dgvAlmacen.DataSource = xMercaderia.cargarDatos()

        Me.dgvAlmacen.Columns("cantidadBultos").Visible = False
        Me.dgvAlmacen.Columns("pesoNeto").Visible = False
        Me.dgvAlmacen.Columns("pesoBruto").Visible = False
        Me.dgvAlmacen.Columns("tamanototal").Visible = False
        Me.dgvAlmacen.Columns("origen").Visible = False
        Me.dgvAlmacen.Columns("fechaIngreso").Visible = False
        Me.dgvAlmacen.Columns("fechaDespacho").Visible = False
        Me.dgvAlmacen.Columns("condicion").Visible = False
        Me.dgvAlmacen.Columns("comentarios").Visible = False

        ' @note las columnas conocimiento y conocimientoOrigen ya tienen el indice 0 y 1 respectivamente, eso no requiere cambios.
        Me.dgvAlmacen.Columns("rotulo").DisplayIndex = 2
        Me.dgvAlmacen.Columns("tipoComercio").DisplayIndex = 3
        Me.dgvAlmacen.Columns("tipoMercaderia").DisplayIndex = 4
        Me.dgvAlmacen.Columns("clientes_id").DisplayIndex = 5
        Me.dgvAlmacen.Columns("posiciones_id").DisplayIndex = 6

        Me.dgvAlmacen.Columns("conocimiento").HeaderText = "Conocimiento"
        Me.dgvAlmacen.Columns("conocimientoOrigen").HeaderText = "Conocimiento Origen"
        Me.dgvAlmacen.Columns("rotulo").HeaderText = "Rótulo"
        Me.dgvAlmacen.Columns("tipoComercio").HeaderText = "Tipo de Comercio"
        Me.dgvAlmacen.Columns("tipoMercaderia").HeaderText = "Tipo de Mercaderia"
        Me.dgvAlmacen.Columns("clientes_id").HeaderText = "Cliente"
        Me.dgvAlmacen.Columns("posiciones_id").HeaderText = "Posicion"

    End Sub

    ' @param dgvAlmacen_MouseUp Controla cuando y donde debe mostrarse el menu contextual del datagrid
    Private Sub dgvAlmacen_MouseUp(ByVal sender As Object, ByVal vClick As System.Windows.Forms.MouseEventArgs) Handles dgvAlmacen.MouseUp
        If vClick.Button = Windows.Forms.MouseButtons.Right Then
            Dim vHitTest As DataGridView.HitTestInfo = sender.HitTest(vClick.X, vClick.Y)

            If (vHitTest.Type = DataGridViewHitTestType.RowHeader) Or (vHitTest.Type = DataGridViewHitTestType.Cell) Then
                cmstripAlmacen.Show(dgvAlmacen.PointToScreen(vClick.Location))
            End If
        End If
    End Sub

    Private Sub dgvAlmacen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlmacen.CellDoubleClick
        Dim vDetalleMercaderia As New fDetalleMercaderia

        Me.MerConocimiento = Convert.ToString(dgvAlmacen.CurrentRow.Cells(0).Value)
        Me.MerConocimientoOrigen = Convert.ToString(dgvAlmacen.CurrentRow.Cells(1).Value)
        vDetalleMercaderia.Show()
        Me.Hide()
    End Sub

    Private Sub dgvAlmacen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlmacen.CellClick
        Dim xDT As New DataTable
        Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia
        xDT = xMercaderia.cargarDatos(Convert.ToString(dgvAlmacen.CurrentRow.Cells(0).Value), Convert.ToString(dgvAlmacen.CurrentRow.Cells(1).Value))
        Dim vMercaderia As DataRow = xDT.Rows(0)

        txtPesoNeto.Text = CStr(vMercaderia("pesoNeto"))
        txtPesoBruto.Text = CStr(vMercaderia("pesoBruto"))
        txtCondicion.Text = CStr(vMercaderia("condicion"))
        txtTamanoTotal.Text = CStr(vMercaderia("tamanoTotal"))
        txtFechaIngreso.Text = CStr(vMercaderia("fechaIngreso"))
        txtFechaDespacho.Text = CStr(vMercaderia("fechaDespacho"))
    End Sub

    Private Sub MarcarDespachoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcarDespachoToolStripMenuItem.Click
        'Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia

        'xMercaderia.modificarDatos("fechaDespacho", "getdate()")
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        fMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoIngreso_Click(sender As Object, e As EventArgs) Handles btnNuevoIngreso.Click
        fNuevoIngreso.Show()
        Me.Hide()
    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click
        Me.lblHora.Text = String.Format("{0:HH:mm}", DateTime.Now)
    End Sub
End Class