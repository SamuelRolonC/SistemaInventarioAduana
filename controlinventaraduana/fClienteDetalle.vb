Public Class fClienteDetalle
    Property ClienteID As String

    Private Sub fConfigCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Cargar datos del cliente
        Dim xCliente As New Negocio.cCliente
        xCliente.ObtenerCliente(ClienteID)

        Me.txtID.Text = xCliente.id
        Me.txtNombre.Text = xCliente.nombre
        Me.txtTelefono.Text = xCliente.telefono
        Me.txtMail.Text = xCliente.mail

        ' Deshabilitar edicion de datos
        mFuncsYProcs.HabilitarTByCB(Me, False)
        btnAplicar.Enabled = False
        Me.txtID.Enabled = False
        Me.txtMail.Enabled = False
        Me.txtNombre.Enabled = False
        Me.txtTelefono.Enabled = False

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnEditar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "modificacion")
        Me.btnAplicar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "modificacion")
        Me.btnBorrar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "baja")
        Me.btnListaClientes.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "lectura")

        '@note Restricciones Text Box
        Me.txtID.MaxLength = 11
        Me.txtNombre.MaxLength = 45
        Me.txtTelefono.MaxLength = 20
        Me.txtMail.MaxLength = 45
    End Sub

    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        mFuncsYProcs.HabilitarTByCB(Me, True)
        txtID.Enabled = False
        btnAplicar.Enabled = True
        txtMail.Enabled = True
        txtNombre.Enabled = True
        txtTelefono.Enabled = True
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim xCliente As New Negocio.cCliente
        Dim Result As Integer = MessageBox.Show("¿Estas seguro que quieres eliminar este cliente?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            If Result = DialogResult.Yes Then
                xCliente.BorrarRegistro(ClienteID)
                MessageBox.Show("Borrado exitosamente", "Aviso")

                Dim vListaCliente As New fClienteLista
                vListaCliente.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Dim vDatosValidos As Boolean = True
        Dim xClientes As New Negocio.cCliente()

        Try
            If Me.txtNombre.Text = "" Then
                Throw New Exception("Debe ingresar el nombre del cliente")
            End If

            If Me.txtTelefono.Text = "" Then
                Throw New Exception("Debe ingresar el telefono del cliente")
            End If

            If Me.txtMail.Text = "" Then
                Throw New Exception("Debe ingresar el email del cliente")
            End If

            xClientes.id = Me.ClienteID
            xClientes.nombre = Me.txtNombre.Text
            xClientes.telefono = Me.txtTelefono.Text
            xClientes.mail = Me.txtMail.Text

            xClientes.ModificarRegistro()
            MessageBox.Show("Modificado exitosamente", "Aviso")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnListaMercaderias_Click(sender As Object, e As EventArgs) Handles btnListaClientes.Click
        Dim vListaClientes As New fClienteLista
        vListaClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click

        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class