Public Class fMercaderiaDetalle
    Property MerConocimiento As String
    Property MerConocimientoOrigen As String

    Private Sub fDetalleMercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Cargar datos de la mercaderia
        Dim xMercaderia As New Negocio.cMercaderia
        xMercaderia.ObtenerMercaderia(MerConocimiento, MerConocimientoOrigen)

        ' Deshabilitar edicion de datos
        mFuncsYProcs.HabilitarTByCB(Me, False)
        btnAplicar.Enabled = False
        btnAgregarCliente.Enabled = False
        dtpFechaIngreso.Enabled = False
        dtpFechaDespacho.Enabled = False

        ' Establecer los Combo Box
        mFuncsYProcs.EstablecerCmbTipoMercaderia(cmbTipoMercaderia)
        mFuncsYProcs.EstablecerCmbTipoComercio(cmbTipoComercio)
        mFuncsYProcs.EstablecerCmbCondicion(cmbCondicion)
        mFuncsYProcs.EstablecerCmbCliente(cmbCliente)
        mFuncsYProcs.EstablecerCmbGalpon(cmbGalpon)

        '@note Cargar datos en controles
        Me.txtConocimiento.Text = xMercaderia.conocimiento
        Me.txtConocimientoOrigen.Text = xMercaderia.conocimientoOrigen
        Me.txtRotulo.Text = xMercaderia.rotulo
        Me.cmbTipoComercio.Text = xMercaderia.tipoComercio
        Me.txtCantBultos.Text = xMercaderia.cantidadBultos
        Me.txtPesoNeto.Text = xMercaderia.pesoNeto
        Me.txtPesoBruto.Text = xMercaderia.pesoBruto
        Me.txtTamanoTotal.Text = xMercaderia.tamanoTotal
        Me.cmbTipoMercaderia.Text = xMercaderia.tipoMercaderia
        Me.txtOrigen.Text = xMercaderia.origen
        Me.cmbCondicion.Text = xMercaderia.condicion
        Me.txtComentarios.Text = xMercaderia.comentarios
        Me.cmbCliente.Text = xMercaderia.clienteId
        Me.dtpFechaIngreso.Value = xMercaderia.fechaIngreso
        Me.dtpFechaDespacho.Value = xMercaderia.fechaDespacho
        Me.cmbPosicion.Text = xMercaderia.posicionId
        Me.cmbCliente.Text = xMercaderia.clienteId

        '@note Cargar datos de galpon
        Dim xPosicion As New Negocio.cPosicion
        Dim xDTPosiciones As New DataTable
        xDTPosiciones = xPosicion.cargarDatos(0, xMercaderia.posicionId) ' Busca una posicion especifica, no necesita indicar el galpon
        Dim vPosicion As DataRow = xDTPosiciones.Rows(0)
        Me.cmbGalpon.Text = CStr(vPosicion("galpones_id"))

        mFuncsYProcs.EstablecerCmbPosicion(cmbPosicion, Me.cmbGalpon.Text)

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnEditar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Mercaderias", "modificacion")
        Me.btnAplicar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Mercaderias", "modificacion")
        Me.btnBorrar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Mercaderias", "baja")
        Me.btnListaMercaderias.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Mercaderias", "lectura")
        Me.btnAgregarCliente.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "alta")
    End Sub

    Private Sub cmbGalpon_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGalpon.SelectedIndexChanged
        If Me.cmbGalpon.SelectedValue <> 1 Then
            mFuncsYProcs.EstablecerCmbPosicion(Me.cmbPosicion, Me.cmbGalpon.Text)
        Else
            Me.cmbPosicion.DataSource = Nothing
            Me.cmbPosicion.DisplayMember = Nothing
            Me.cmbPosicion.ValueMember = Nothing
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        mFuncsYProcs.HabilitarTByCB(Me, True)
        txtConocimiento.Enabled = False
        txtConocimientoOrigen.Enabled = False
        btnAplicar.Enabled = True
        btnAgregarCliente.Enabled = True
        dtpFechaIngreso.Enabled = True
        dtpFechaDespacho.Enabled = True
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAplicar.Click
        Dim vDatosValidos As Boolean = True
        Dim xMercaderia As New Negocio.cMercaderia()

        xMercaderia.conocimiento = Me.txtConocimiento.Text
        xMercaderia.conocimientoOrigen = Me.txtConocimientoOrigen.Text

        If (Me.txtCantBultos.Text <> "") And IsNumeric(Me.txtCantBultos.Text) Then
            If Me.txtCantBultos.Text > 0 Then
                xMercaderia.cantidadBultos = Me.txtCantBultos.Text
            Else
                vDatosValidos = False
                Me.lblCantBultos.ForeColor = Color.Red
            End If
        Else
            vDatosValidos = False
            Me.lblCantBultos.ForeColor = Color.Red
        End If

        If (Me.txtPesoNeto.Text <> "") And IsNumeric(Me.txtPesoNeto.Text) Then
            If Me.txtPesoNeto.Text > 0 Then
                xMercaderia.pesoNeto = Me.txtPesoNeto.Text
            Else
                vDatosValidos = False
                Me.lblPesoNeto.ForeColor = Color.Red
            End If
        Else
            vDatosValidos = False
            Me.lblPesoNeto.ForeColor = Color.Red
        End If

        If Me.txtTamanoTotal.Text <> "" Then
            xMercaderia.tamanoTotal = Me.txtTamanoTotal.Text
        Else
            vDatosValidos = False
            Me.lblTamanoTotal.ForeColor = Color.Red
        End If

        ' @param If No valida si el campo esta vacio o no, valida los valores si es que el campo no esta vacio. Este campo no es obligatorio
        If Me.txtPesoBruto.Text <> "" Then
            If IsNumeric(Me.txtPesoBruto.Text) Then
                If Me.txtPesoBruto.Text > 0 Then
                    xMercaderia.pesoBruto = Me.txtPesoBruto.Text
                Else
                    vDatosValidos = False
                    Me.lblPesoBruto.ForeColor = Color.Red
                End If
            Else
                vDatosValidos = False
                Me.lblPesoBruto.ForeColor = Color.Red
            End If
        End If

        If Me.cmbTipoComercio.SelectedValue <> 1 Then
            xMercaderia.tipoComercio = Me.cmbTipoComercio.Text
        Else
            vDatosValidos = False
            Me.lblTipoComercio.ForeColor = Color.Red
        End If

        If Me.cmbCondicion.SelectedValue <> 1 Then
            xMercaderia.condicion = Me.cmbCondicion.Text
        Else
            vDatosValidos = False
            Me.lblCondicion.ForeColor = Color.Red
        End If

        If (Me.cmbPosicion.SelectedValue <> 1) And (Me.cmbPosicion.Items.Count > 0) Then
            xMercaderia.posicionId = Me.cmbPosicion.Text
        Else
            vDatosValidos = False
            Me.lblPosicion.ForeColor = Color.Red
        End If

        If Me.cmbGalpon.SelectedValue <> 1 Then
            xMercaderia.clienteId = Me.cmbCliente.Text
        Else
            vDatosValidos = False
            Me.lblGalpon.ForeColor = Color.Red
        End If

        xMercaderia.fechaIngreso = Me.dtpFechaIngreso.Value.Date
        xMercaderia.fechaDespacho = Me.dtpFechaDespacho.Value.Date
        xMercaderia.rotulo = Me.txtRotulo.Text
        xMercaderia.tipoMercaderia = Me.cmbTipoMercaderia.Text
        xMercaderia.conocimientoOrigen = txtConocimientoOrigen.Text
        xMercaderia.origen = Me.txtOrigen.Text
        xMercaderia.comentarios = Me.txtComentarios.Text

        ' @param If Agrega la mercaderia al almacen y reestablece el formulario
        If vDatosValidos Then
            xMercaderia.ModificarRegistro()
            mFuncsYProcs.ReestablecerCadaLabel(Me)
            MessageBox.Show("Modificado exitosamente", "Aviso")
        Else
            MessageBox.Show("Campos obligatorios vacíos o datos inválidos", "Atención")
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim xMercaderia As New Negocio.cMercaderia

        xMercaderia.BorrarRegistro(MerConocimiento, MerConocimientoOrigen)
        MessageBox.Show("Borrado exitosamente", "Aviso")

        Dim vMercaderiaLista As New fMercaderiaLista
        vMercaderiaLista.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnListaMercaderias_Click(sender As Object, e As EventArgs) Handles btnListaMercaderias.Click
        Dim vMercaderiaLista As New fMercaderiaLista
        vMercaderiaLista.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim vNuevoCliente As New fClienteNuevo
        vNuevoCliente.Show()
        Me.Close()
    End Sub
End Class