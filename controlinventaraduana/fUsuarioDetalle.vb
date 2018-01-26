Public Class fUsuarioDetalle
    Property usuarioID As String

    Private Sub fUsuarioDetalle_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '@note Deshabilitar edicion de datos
        mFuncsYProcs.HabilitarTByCB(Me, False)
        Me.cbHabilitado.Enabled = False
        Me.cblgrupos.Enabled = False
        Me.btnAplicar.Enabled = False

        '@note Aplicar restricciones de permisos
        Me.btnEditar.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "modificacion")
        Me.btnAplicar.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "modificacion")
        Me.btnBorrar.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "baja")
        Me.btnListaUsuarios.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "lectura")

        '@note Cargar datos del usuario
        Dim xUsuario As New Negocio.cUsuario
        xUsuario.ObtenerUsuario(Me.usuarioID)
        Dim xDes As New Negocio.Cripto3DES

        Me.txtNombre.Text = xUsuario.nombre
        Me.txtApellido.Text = xUsuario.apellido
        Me.txtID.Text = xUsuario.id
        Me.txtEmail.Text = xDes.DesencriptarDato(xUsuario.email)
        Me.cbHabilitado.Checked = xUsuario.habilitado

        '@note Agregar grupos al CheckedBoxList
        Dim xGrupo As New Negocio.cGrupo
        For Each item As DataRow In Negocio.GestorEstandarDatos.CargarTabla("grupos").Rows
            cblgrupos.Items.Add(item("id"))
        Next

        '@note Tildar Check Box
        For Each UsGrupo As DataRow In Negocio.cUsGrupos.CargarTabla(Me.usuarioID).Rows
            xGrupo.ObtenerGrupo(UsGrupo("grupos_id"))
            For i = 0 To (cblgrupos.Items.Count - 1)
                If cblgrupos.Items(i).ToString = xGrupo.id Then
                    cblgrupos.SetItemChecked(i, True)
                End If
            Next
        Next

        '@note Restricciones Text Box
        txtEmail.MaxLength = 50
        txtID.MaxLength = 20
        txtNombre.MaxLength = 45
        txtApellido.MaxLength = 45
    End Sub

    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        mFuncsYProcs.HabilitarTByCB(Me, True)
        Me.txtID.Enabled = False
        Me.btnAplicar.Enabled = True
        Me.cbHabilitado.Enabled = True
        Me.cblgrupos.Enabled = True
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim Result As Integer = MessageBox.Show("¿Está seguro de que quiere modificar este usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Try
                '@note Actualizar registro en usuarios
                Dim xUsuario As New Negocio.cUsuario()
                xUsuario.id = Me.usuarioID
                xUsuario.nombre = Me.txtNombre.Text
                xUsuario.apellido = Me.txtApellido.Text
                xUsuario.email = Me.txtEmail.Text
                xUsuario.habilitado = Me.cbHabilitado.Checked

                xUsuario.ValidarUsuario()

                xUsuario.ModificarRegistro()

                '@note Actualizar registro en grupos
                Dim xUsGrupos As New Negocio.cUsGrupos()
                If cblgrupos.CheckedItems.Count <> 0 Then
                    For i = 0 To cblgrupos.Items.Count - 1
                        If cblgrupos.GetItemChecked(i) Then
                            xUsGrupos.grupoId = cblgrupos.Items(i)
                            xUsGrupos.usuarioId = xUsuario.id
                            xUsGrupos.GuardarRegistro(True)
                        Else
                            Negocio.cUsGrupos.BorrarRegistro(xUsuario.id, cblgrupos.Items(i))
                        End If
                    Next
                Else
                    Throw New Exception("Debe seleccionar almenos un grupo para el usuario")
                End If

                '@IMPORTANT Manejar el caso en que se produzca una interrupcion y reejecucion del try luego de guardados algunos registros a la BD

                MessageBox.Show("Modificado exitosamente", "Aviso")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Result As Integer = MessageBox.Show("¿Está seguro de que quiere borrar este usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Try
                Negocio.cPermGrupos.BorrarRegistro(usuarioID)
                Negocio.cUsGrupos.BorrarRegistrosSegun("Usuario", usuarioID)
                Negocio.GestorEstandarDatos.BorrarRegistro("usuarios", "String", usuarioID)

                MessageBox.Show("Borrado exitosamente", "Aviso")

                Dim vUsuarioLista As New fUsuarioLista
                vUsuarioLista.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnListaUsuarios_Click(sender As Object, e As EventArgs) Handles btnListaUsuarios.Click
        Dim UsuarioLista As New fUsuarioLista
        UsuarioLista.Show()
        Me.Close()
    End Sub
End Class