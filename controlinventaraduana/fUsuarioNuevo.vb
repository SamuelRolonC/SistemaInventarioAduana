Public Class fUsuarioNuevo
    Public Property UsuarioIdLog As String

    Private Sub fNuevoUsuario_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '@note Cargar grupos habilitados al Checked Box List
        For Each item As DataRow In Negocio.cGrupo.CargarGruposHabilitados().Rows
            Me.cblgrupos.Items.Add(item("id"))
        Next

        '@note Restricciones Text Box
        Me.txtMail.MaxLength = 50
        Me.txtID.MaxLength = 20
        Me.txtPass.MaxLength = 20
        Me.txtConfirmarPass.MaxLength = 20
        Me.txtPass.PasswordChar = "*"
        Me.txtConfirmarPass.PasswordChar = "*"
        Me.txtNombre.MaxLength = 45
        Me.txtApellido.MaxLength = 45

        '@note Comprobar permisos del usuario
        Me.btnListaUsuarios.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "lectura")
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        Try
            '@note Guardar registro en usuarios
            Dim xUsuario As New Negocio.cUsuario()
            xUsuario.id = Me.txtID.Text
            xUsuario.nombre = Me.txtNombre.Text
            xUsuario.apellido = Me.txtApellido.Text
            xUsuario.pass = Me.txtPass.Text
            xUsuario.email = Me.txtMail.Text
            xUsuario.habilitado = Me.cbHabilitado.Checked

            xUsuario.ValidarUsuario()
            xUsuario.ValidarPass(Me.txtConfirmarPass.Text)
            If Me.cblgrupos.CheckedItems.Count = 0 Then
                Throw New Exception("Debe asignarle almenos un grupo al usuario")
            End If

            xUsuario.GuardarDatos()

            '@note Guardar registros en us_grupos
            Dim xUsGrupos As New Negocio.cUsGrupos()
            If cblgrupos.CheckedItems.Count <> 0 Then
                Dim xGrupos As New Negocio.cGrupo
                For i = 0 To cblgrupos.Items.Count - 1
                    If cblgrupos.GetItemChecked(i) Then
                        xUsGrupos.grupoId = cblgrupos.Items(i)
                        xUsGrupos.usuarioId = xUsuario.id
                        xUsGrupos.GuardarRegistro(False)
                    End If
                Next
            End If
            MessageBox.Show("Creado exitosamente", "Aviso")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnListaUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaUsuarios.Click
        Dim vListaUsuarios As New fUsuarioLista
        vListaUsuarios.Show()
        Me.Close()
    End Sub
End Class