Public Class fNuevoIngreso

    Private Sub fNuevoIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Establecer los Combo Box
        mFuncsYProcs.EstablecerCmbTipoMercaderia(cmbTipoMercaderia)
        mFuncsYProcs.EstablecerCmbTipoComercio(cmbTipoComercio)
        mFuncsYProcs.EstablecerCmbCondicion(cmbCondicion)
        mFuncsYProcs.EstablecerCmbGalpon(cmbGalpon)
        mFuncsYProcs.EstablecerCmbCliente(cmbCliente)

        txtConocimiento.MaxLength = 20
        txtConocimientoOrigen.MaxLength = 20
        txtCantBultos.MaxLength = 3
        txtPesoBruto.MaxLength = 6
        txtPesoNeto.MaxLength = 6
        txtTamanoTotal.MaxLength = 15
        txtOrigen.MaxLength = 45
        txtRotulo.MaxLength = 45
        txtFechaIngreso.MaxLength = 10
    End Sub

    Private Sub cmbGalpon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGalpon.SelectedIndexChanged
        If Me.cmbGalpon.SelectedValue <> 1 Then
            mFuncsYProcs.EstablecerCmbPosicion(Me.cmbPosicion, Me.cmbGalpon.Text)
        Else
            Me.cmbPosicion.DataSource = Nothing
            Me.cmbPosicion.DisplayMember = Nothing
            Me.cmbPosicion.ValueMember = Nothing
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarMercaderia.Click
        Dim vDatosValidos As Boolean = True
        Dim xMercaderia As New AlmacenAduana.Negocio.cMercaderia()

        If Me.txtConocimiento.Text <> "" Then
            xMercaderia.establecerValores("conocimiento", Me.txtConocimiento.Text)
        Else
            vDatosValidos = False
        End If

        If (Me.txtCantBultos.Text <> "") And IsNumeric(Me.txtCantBultos.Text) Then
            If Me.txtCantBultos.Text > 0 Then
                xMercaderia.establecerValores("cantidadBultos", Me.txtCantBultos.Text)
            Else
                vDatosValidos = False
            End If
        Else
            vDatosValidos = False
        End If

        If (Me.txtPesoNeto.Text <> "") And IsNumeric(Me.txtPesoNeto.Text) Then
            If Me.txtPesoNeto.Text > 0 Then
                xMercaderia.establecerValores("pesoNeto", Me.txtPesoNeto.Text)
            Else
                vDatosValidos = False
            End If
        Else
            vDatosValidos = False
        End If

        If Me.txtTamanoTotal.Text <> "" Then
            xMercaderia.establecerValores("tamanoTotal", Me.txtTamanoTotal.Text)
        Else
            vDatosValidos = False
        End If

        ' @param If No valida si el campo esta vacio o no, valida los valores si es que el campo no esta vacio. Este campo no es obligatorio
        If Me.txtPesoBruto.Text <> "" Then
            If IsNumeric(Me.txtPesoBruto.Text) Then
                If Me.txtPesoBruto.Text > 0 Then
                    xMercaderia.establecerValores("pesoBruto", Me.txtPesoBruto.Text)
                Else
                    vDatosValidos = False
                End If
            Else
                vDatosValidos = False
            End If
        End If

        If Me.txtFechaIngreso.Text <> "" Then
            '@note La BD permite los sig formatos: 'YYYY-MM-DD' y 'DD-MM-YYYY'
            ' xMercaderia.establecerValores("fechaHoraIngreso", Me.txtFechaIngreso.Text)
            vDatosValidos = False
            MessageBox.Show("Ingreso manual de fecha desactivado. Deje el espacio en blanco", "Atencion")
        End If

        If Me.cmbTipoComercio.SelectedValue <> 1 Then
            xMercaderia.establecerValores("tipoComercio", Me.cmbTipoComercio.Text)
        Else
            vDatosValidos = False
        End If

        If Me.cmbCondicion.SelectedValue <> 1 Then
            xMercaderia.condicion = Me.cmbCondicion.Text
        Else
            vDatosValidos = False
        End If

        If (Me.cmbPosicion.SelectedValue <> 1) And (Me.cmbPosicion.Items.Count > 0) Then
            xMercaderia.posicionId = Me.cmbPosicion.Text
        Else
            vDatosValidos = False
        End If

        If Me.cmbGalpon.SelectedValue <> 1 Then

        Else
            vDatosValidos = False
        End If

        If Me.cmbGalpon.SelectedValue <> 1 Then
            xMercaderia.clienteId = Me.cmbCliente.Text
        Else
            vDatosValidos = False
        End If

        xMercaderia.rotulo = Me.txtRotulo.Text
        xMercaderia.establecerValores("tipoMercaderia", Me.cmbTipoMercaderia.Text)
        xMercaderia.establecerValores("conocimientoOrigen", txtConocimientoOrigen.Text)
        xMercaderia.establecerValores("origen", txtOrigen.Text)
        xMercaderia.establecerValores("comentarios", txtComentarios.Text)

        ' @param If Agrega la mercaderia al almacen y reestablece el formulario
        If vDatosValidos Then
            xMercaderia.guardarDatos(xMercaderia)
            ' @note Limpiar el formulario para proximos ingresos
            mFuncsYProcs.sLimpiarCadaTextBox(Me)
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

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        fMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        fAlmacen.Show()
        Me.Hide()
    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click
        Me.lblHora.Text = String.Format("{0:HH:mm}", DateTime.Now)
    End Sub
End Class