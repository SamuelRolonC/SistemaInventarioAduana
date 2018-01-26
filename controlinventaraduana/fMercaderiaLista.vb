Public Class fMercaderiaLista

    Private Sub fAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Cargar y presentar el datagridview
        Dim xMercaderia As New Negocio.cMercaderia
        dgvAlmacen.DataSource = xMercaderia.CargarTabla()

        Me.dgvAlmacen.Columns("cantidadBultos").Visible = False
        Me.dgvAlmacen.Columns("pesoNeto").Visible = False
        Me.dgvAlmacen.Columns("pesoBruto").Visible = False
        Me.dgvAlmacen.Columns("tamanototal").Visible = False
        Me.dgvAlmacen.Columns("origen").Visible = False
        Me.dgvAlmacen.Columns("fechaIngreso").Visible = False
        Me.dgvAlmacen.Columns("fechaDespacho").Visible = False
        Me.dgvAlmacen.Columns("condicion").Visible = False
        Me.dgvAlmacen.Columns("comentarios").Visible = False

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

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnNuevaMercaderia.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Mercaderias", "alta")

    End Sub

    Private Sub dgvAlmacen_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvAlmacen.CellDoubleClick
        Dim vDetalleMercaderia As New fMercaderiaDetalle
        vDetalleMercaderia.MerConocimiento = Convert.ToString(dgvAlmacen.CurrentRow.Cells(0).Value)
        vDetalleMercaderia.MerConocimientoOrigen = Convert.ToString(dgvAlmacen.CurrentRow.Cells(1).Value)
        vDetalleMercaderia.Show()
        Me.Close()
    End Sub

    Private Sub dgvAlmacen_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvAlmacen.CellClick
        Dim xDT As New DataTable
        Dim xMercaderia As New Negocio.cMercaderia
        xDT = xMercaderia.CargarTabla(Convert.ToString(dgvAlmacen.CurrentRow.Cells(0).Value), Convert.ToString(dgvAlmacen.CurrentRow.Cells(1).Value))
        Dim vMercaderia As DataRow = xDT.Rows(0)

        txtPesoNeto.Text = CStr(vMercaderia("pesoNeto"))
        txtPesoBruto.Text = CStr(vMercaderia("pesoBruto"))
        txtCondicion.Text = CStr(vMercaderia("condicion"))
        txtTamanoTotal.Text = CStr(vMercaderia("tamanoTotal"))
        txtFechaIngreso.Text = CStr(vMercaderia("fechaIngreso"))
        txtFechaDespacho.Text = CStr(vMercaderia("fechaDespacho"))
    End Sub

    Private Sub MarcarDespachoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MarcarDespachoToolStripMenuItem.Click
        'Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia

        'xMercaderia.modificarDatos("fechaDespacho", "getdate()")
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoIngreso_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevaMercaderia.Click
        Dim vMercaderiaNueva As New fMercaderiaNueva
        vMercaderiaNueva.Show()
        Me.Close()
    End Sub

    Private Sub btnListaGrupos_Click(sender As Object, e As EventArgs)
        Dim vGrupoLista As New fGrupoLista
        vGrupoLista.Show()
        Me.Close()
    End Sub
End Class