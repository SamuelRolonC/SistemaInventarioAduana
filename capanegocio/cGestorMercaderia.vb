Public Class cGestorMercaderia
    Public Property Validada As Boolean

    Public Function ValidarMercaderia(ByVal Mercaderia As AlmacenAduana.Negocio.cMercaderia)
        Dim vDatosValidos As Boolean = True
        Dim Mercaderia As New AlmacenAduana.Negocio.cMercaderia()

        If Me.txtConocimiento.Text <> "" Then
            Mercaderia.conocimiento = Me.txtConocimiento.Text
        Else
            vDatosValidos = False
            Me.lblConocimiento.ForeColor = Color.Red
        End If

        If (Me.txtCantBultos.Text <> "") And IsNumeric(Me.txtCantBultos.Text) Then
            If Me.txtCantBultos.Text > 0 Then
                Mercaderia.cantidadBultos = Me.txtCantBultos.Text
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
                Mercaderia.pesoNeto = Me.txtPesoNeto.Text
            Else
                vDatosValidos = False
                Me.lblPesoNeto.ForeColor = Color.Red
            End If
        Else
            vDatosValidos = False
            Me.lblPesoNeto.ForeColor = Color.Red
        End If

        If Me.txtTamanoTotal.Text <> "" Then
            Mercaderia.tamanoTotal = Me.txtTamanoTotal.Text
        Else
            vDatosValidos = False
            Me.lblTamanoTotal.ForeColor = Color.Red
        End If

        ' @param If No valida si el campo esta vacio o no, valida los valores si es que el campo no esta vacio. Este campo no es obligatorio
        If Me.txtPesoBruto.Text <> "" Then
            If IsNumeric(Me.txtPesoBruto.Text) Then
                If Me.txtPesoBruto.Text > 0 Then
                    Mercaderia.pesoBruto = Me.txtPesoBruto.Text
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
            Mercaderia.tipoComercio = Me.cmbTipoComercio.Text
        Else
            vDatosValidos = False
            Me.lblTipoComercio.ForeColor = Color.Red
        End If

        If Me.cmbCondicion.SelectedValue <> 1 Then
            Mercaderia.condicion = Me.cmbCondicion.Text
        Else
            vDatosValidos = False
            Me.lblCondicion.ForeColor = Color.Red
        End If

        If (Me.cmbPosicion.SelectedValue <> 1) And (Me.cmbPosicion.Items.Count > 0) Then
            Mercaderia.posicionId = Me.cmbPosicion.Text
        Else
            vDatosValidos = False
            Me.lblPosicion.ForeColor = Color.Red
        End If

        If Me.cmbCliente.SelectedValue <> 1 Then
            Mercaderia.clienteId = Me.cmbCliente.Text
        Else
            vDatosValidos = False
            Me.lblCliente.ForeColor = Color.Red
        End If

        Mercaderia.fechaIngreso = Me.dtpFechaIngreso.Value.Date
        Mercaderia.rotulo = Me.txtRotulo.Text
        Mercaderia.tipoMercaderia = Me.cmbTipoMercaderia.Text
        Mercaderia.conocimientoOrigen = Me.txtConocimientoOrigen.Text
        Mercaderia.origen = Me.txtOrigen.Text
        Mercaderia.comentarios = Me.txtComentarios.Text
    End Function
End Class
