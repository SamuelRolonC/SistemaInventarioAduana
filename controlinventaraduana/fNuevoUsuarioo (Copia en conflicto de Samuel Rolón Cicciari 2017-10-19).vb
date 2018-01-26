Public Class fNuevoUsuarioo
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim vDatosValidos As Boolean = True
        Dim xUsuarios As New AlmacenAduana.Negocio.cUsuario()

        If Me.txtNombre.Text <> "" Then
            xUsuarios.establecerValores("nombre", Me.txtNombre.Text)

        Else
            vDatosValidos = False
        End If

        If Me.txtApellido.Text <> "" Then
            xUsuarios.establecerValores("apellido", Me.txtApellido.Text)
        Else
            vDatosValidos = False
        End If

        If Me.txtDNI.Text <> "" Then
            xUsuarios.establecerValores("dni", Me.txtDNI.Text)

        Else
            vDatosValidos = False
        End If

        If Me.txtID.Text <> "" Then
            xUsuarios.establecerValores("id", Me.txtID.Text)
        Else
            vDatosValidos = False
        End If


        If Me.txtMail.Text <> "" Then
            xUsuarios.establecerValores("mail", Me.txtNombre.Text)

        Else
            vDatosValidos = False
        End If

        If Me.txtContraseña1.Text <> "" And Me.txtContraseña2.Text <> "" Then
            If (Me.txtContraseña1.Text = Me.txtContraseña2.Text) Then

                xUsuarios.establecerValores("pass", Me.txtContraseña1.Text)

            Else
                vDatosValidos = False
                lblPass.Text = "Contraseñas no coinciden"
                lblPass.ForeColor = System.Drawing.Color.Red

            End If
        End If

        xUsuarios.habilitado = True

        If vDatosValidos Then
            xUsuarios.guardarDatos(xUsuarios)

            fLogin.Show()
            Me.Hide()
        Else
            MessageBox.Show("Campos obligatorios vacíos o datos inválidos", "Atención")
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        fLogin.Show()
        Me.Hide()
    End Sub

    Private Sub fNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        txtMail.MaxLength = 30
        txtID.MaxLength = 8
        txtContraseña1.MaxLength = 8
        txtContraseña2.MaxLength = 50
        txtNombre.MaxLength = 10
        txtApellido.MaxLength = 10

    End Sub



    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If Not ((e.KeyValue >= 97 And e.KeyValue < 122) OrElse (e.KeyValue >= 65 And e.KeyValue < 90) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 164 And e.KeyValue = 165) OrElse (e.KeyValue = 14 And e.KeyValue = 15)) Then
            e.Handled = True
            MsgBox("Ingrese caracteres validos ")
            txtNombre.Text = vbNullChar

        End If
    End Sub

    Private Sub txtMail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If Not ((e.KeyValue >= 97 And e.KeyValue < 122) OrElse (e.KeyValue >= 65 And e.KeyValue < 90) OrElse (e.KeyValue >= 97 And e.KeyValue < 122) OrElse (e.KeyValue >= 65 And e.KeyValue < 90) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 164 And e.KeyValue = 165) OrElse (e.KeyValue = 14 And e.KeyValue = 15) OrElse (e.KeyValue = 64)) Then
            e.Handled = True
            MsgBox("Ingrese caracteres validos ")
            txtMail.Text = vbNullChar

        End If
    End Sub

    Private Sub txtApellido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApellido.KeyDown
        If Not ((e.KeyValue >= 97 And e.KeyValue < 122) OrElse (e.KeyValue >= 65 And e.KeyValue < 90) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 164 And e.KeyValue = 165) OrElse (e.KeyValue = 14 And e.KeyValue = 15)) Then
            e.Handled = True
            MsgBox("Ingrese caracteres validos ")
            txtApellido.Text = vbNullChar

        End If
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue >= 97 And e.KeyValue < 122) OrElse (e.KeyValue >= 65 And e.KeyValue < 90) OrElse (e.KeyValue = 14 And e.KeyValue = 15)) Then
            e.Handled = True
            MsgBox("Ingresar caracteres validos ")
            txtID.Text = vbNullChar
        End If
    End Sub

    Private Sub txtDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNI.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            MsgBox("Ingresar caracteres validos ")
            txtDNI.Text = vbNullChar
        End If
    End Sub

    Private Sub txtNombre_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNombre.MouseClick

        txtNombre.Text = vbNullChar
        txtNombre.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub txtApellido_MouseClick(sender As Object, e As MouseEventArgs) Handles txtApellido.MouseClick
        txtApellido.Text = vbNullChar
        txtApellido.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub txtDNI_MouseClick(sender As Object, e As MouseEventArgs) Handles txtDNI.MouseClick
        txtDNI.Text = vbNullChar
        txtDNI.ForeColor = System.Drawing.Color.Black
    End Sub


End Class