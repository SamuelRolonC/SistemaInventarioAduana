Public Class fMercaderiaDetalle
    Property MerConocimiento As String
    Property MerConocimientoOrigen As String

    Private Sub fDetalleMercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xDTMercaderias As New DataTable
        Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia
        xDTMercaderias = xMercaderia.CargarTabla(Me.MerConocimiento, Me.MerConocimientoOrigen)
        Dim vMercaderia As DataRow = xDTMercaderias.Rows(0)

        Dim xPosicion As New AlmacenAduana.Negocio.cPosicion
        Dim xDTPosiciones As New DataTable
        xDTPosiciones = xPosicion.cargarDatos(0, CStr(vMercaderia("posiciones_id"))) ' Busca una posicion especifica, no necesita indicar el galpon
        Dim vPosicion As DataRow = xDTPosiciones.Rows(0)

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

        ' Cargar datos en Controles
        Me.txtConocimiento.Text = CStr(vMercaderia("conocimiento"))
        Me.txtConocimientoOrigen.Text = CStr(vMercaderia("conocimientoOrigen"))
        Me.txtRotulo.Text = CStr(vMercaderia("rotulo"))
        Me.cmbTipoComercio.Text = CStr(vMercaderia("tipoComercio"))
        Me.txtCantBultos.Text = CStr(vMercaderia("cantidadBultos"))
        Me.txtPesoNeto.Text = CStr(vMercaderia("pesoNeto"))
        Me.txtPesoBruto.Text = CStr(vMercaderia("pesoBruto"))
        Me.txtTamanoTotal.Text = CStr(vMercaderia("tamanoTotal"))
        Me.cmbTipoMercaderia.Text = CStr(vMercaderia("tipoMercaderia"))
        Me.txtOrigen.Text = CStr(vMercaderia("origen"))
        Me.cmbCondicion.Text = CStr(vMercaderia("condicion"))
        Me.txtComentarios.Text = CStr(vMercaderia("comentarios"))
        Me.cmbCliente.Text = CStr(vMercaderia("clientes_id"))
        Me.cmbGalpon.Text = CStr(vPosicion("galpones_id"))
        Me.dtpFechaIngreso.Value = vMercaderia("fechaIngreso")
        Me.dtpFechaDespacho.Value = vMercaderia("fechaDespacho")

        mFuncsYProcs.EstablecerCmbPosicion(cmbPosicion, Me.cmbGalpon.Text)

        Me.cmbPosicion.Text = CStr(vMercaderia("posiciones_id"))
        Me.cmbCliente.Text = CStr(vMercaderia("clientes_id"))
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

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        fMenuPrincipal.Show()
        ' @Dispose A diferencia de Hide al salir del formulario, y si estaban los controles habilitados
        ' luego de modificar la mercaderia, al volver a entrar, el programa va a pasar por Load volviendo
        ' a deshabiltar los controles, cosa que con el Hide no se podria.
        Me.Dispose()
    End Sub

    Private Sub btnAlmacen_Click(ByVal sender As Object, ByVal e As EventArgs)
        fMercaderiaLista.Show()
        Me.Dispose()
    End Sub

    Private Sub btnNuevoIngreso_Click(ByVal sender As Object, ByVal e As EventArgs)
        fMercaderiaNueva.Show()
        Me.Dispose()
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAplicar.Click
        Dim vDatosValidos As Boolean = True
        Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia()

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
        Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia
        Dim vAlmacen As New fMercaderiaLista

        xMercaderia.BorrarRegistro(MerConocimiento, MerConocimientoOrigen)
        MessageBox.Show("Borrado exitosamente", "Aviso")
        vAlmacen.Show()
        Me.Dispose()
    End Sub

    Private Sub btnListaMercaderias_Click(sender As Object, e As EventArgs) Handles btnListaMercaderias.Click
        Dim vListaMercaderias As New fMercaderiaLista

        vListaMercaderias.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim vNuevoCliente As New fClientes

        vNuevoCliente.Show()
        Me.Close()
    End Sub
End Class