Public Class fMercaderiaNueva

    Private Sub fNuevoIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Establecer los Combo Box
        mFuncsYProcs.EstablecerCmbTipoMercaderia(cmbTipoMercaderia)
        mFuncsYProcs.EstablecerCmbTipoComercio(cmbTipoComercio)
        mFuncsYProcs.EstablecerCmbCondicion(cmbCondicion)
        mFuncsYProcs.EstablecerCmbGalpon(cmbGalpon)
        mFuncsYProcs.EstablecerCmbCliente(cmbCliente)

        '@note Establece la capacidad máxima de cada textbox
        txtConocimiento.MaxLength = 20
        txtConocimientoOrigen.MaxLength = 20
        txtCantBultos.MaxLength = 3
        txtPesoBruto.MaxLength = 6
        txtPesoNeto.MaxLength = 6
        txtTamanoTotal.MaxLength = 15
        txtOrigen.MaxLength = 45
        txtRotulo.MaxLength = 45

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMercaderia.Click
        Dim vDatosValidos As Boolean = True
        Dim xMercaderia As New Negocio.cMercaderia()

        If Me.txtConocimiento.Text <> "" Then
            xMercaderia.conocimiento = Me.txtConocimiento.Text
        Else
            vDatosValidos = False
            Me.lblConocimiento.ForeColor = Color.Red
        End If

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
                Me.lblPesoNeto.ForeColor = Color.Red
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

        If Me.cmbCliente.SelectedValue <> 1 Then
            xMercaderia.clienteId = Me.cmbCliente.Text
        Else
            vDatosValidos = False
            Me.lblCliente.ForeColor = Color.Red
        End If

        xMercaderia.fechaIngreso = Me.dtpFechaIngreso.Value.Date
        xMercaderia.rotulo = Me.txtRotulo.Text
        xMercaderia.tipoMercaderia = Me.cmbTipoMercaderia.Text
        xMercaderia.conocimientoOrigen = Me.txtConocimientoOrigen.Text
        xMercaderia.origen = Me.txtOrigen.Text
        xMercaderia.comentarios = Me.txtComentarios.Text

        ' @param If Agrega la mercaderia al almacen y reestablece el formulario
        If vDatosValidos Then
            xMercaderia.GuardarRegistro()
            MessageBox.Show("Agregado exitosamente", "Aviso")

            ' @note Limpiar el formulario para proximos ingresos
            mFuncsYProcs.sLimpiarCadaTextBox(Me)
            mFuncsYProcs.ReestablecerCadaLabel(Me)
            cmbTipoComercio.SelectedValue = 1
            cmbTipoMercaderia.SelectedValue = 1
            cmbCondicion.SelectedValue = 1
            cmbPosicion.SelectedValue = 1
            cmbGalpon.SelectedValue = 1
            cmbCliente.SelectedValue = 1
        Else
            MessageBox.Show("Campos obligatorios vacíos o datos inválidos", "Atención")
        End If
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim vClientes As New fClienteNuevo
        vClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnListaMercaderias_Click(sender As Object, e As EventArgs) Handles btnListaMercaderias.Click
        Dim vMercaderiaLista As New fMercaderiaLista
        vMercaderiaLista.Show()
        Me.Close()
    End Sub
End Class