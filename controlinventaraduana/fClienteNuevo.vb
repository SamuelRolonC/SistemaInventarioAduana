Public Class fClienteNuevo

    Private Sub fClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnListaClientes.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "lectura")

        ' @note Establece la capacidad máxima de cada textbox
        txtID.MaxLength = 11
        txtNombre.MaxLength = 45
        txtTelefono.MaxLength = 20
        txtMail.MaxLength = 45
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim vDatosValidos As Boolean = True
        Dim xClientes As New Negocio.cCliente

        Try
            If Not IsNumeric(Me.txtID.Text) Then
                Throw New Exception("El CUIT/CUIL debe ser numerico")
            End If

            If Me.txtNombre.Text = "" Then
                Throw New Exception("Debe ingresar el nombre del cliente")
            End If

            If Me.txtTelefono.Text = "" Then
                Throw New Exception("Debe ingresar el telefono del cliente")
            End If

            If Me.txtMail.Text = "" Then
                Throw New Exception("Debe ingresar el email del cliente")
            End If

            xClientes.nombre = Me.txtNombre.Text
            xClientes.id = Me.txtID.Text
            xClientes.telefono = Me.txtTelefono.Text
            xClientes.mail = Me.txtMail.Text

            xClientes.guardarDatos()
            MessageBox.Show("Agregado exitosamente", "Aviso")
            mFuncsYProcs.sLimpiarCadaTextBox(Me)
            mFuncsYProcs.ReestablecerCadaLabel(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnListaClientes_Click(sender As Object, e As EventArgs) Handles btnListaClientes.Click
        Dim vListaClientes As New fClienteLista
        vListaClientes.Show()
        Me.Close()
    End Sub
End Class