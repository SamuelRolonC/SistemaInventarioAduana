Public Class fGrupoNuevo

    Private Sub NuevoGrupo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '@note Cargar TreeView de permisos
        Dim vNumFila As Integer = 0
        For Each vFila As System.Data.DataRow In Negocio.GestorEstandarDatos.CargarTabla("permisos").Rows
            tvPermisos.Nodes.Add(vFila("id"))
            tvPermisos.Nodes(vNumFila).Nodes.Add("Alta")
            tvPermisos.Nodes(vNumFila).Nodes.Add("Baja")
            tvPermisos.Nodes(vNumFila).Nodes.Add("Modificacion")
            tvPermisos.Nodes(vNumFila).Nodes.Add("Lectura")
            vNumFila += 1
        Next
        tvPermisos.CheckBoxes = True

        '@note Comprobar permisos del usuario
        Me.btnListaGruposUsuarios.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "lectura")
        Me.btnAgregarGrupo.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "alta")
    End Sub

    Private Sub btnAgregarGrupo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregarGrupo.Click
        Dim xGrupo As New Negocio.cGrupo
        Dim xPermGrupos As New Negocio.cPermGrupos

        Try
            '@note Crear registro en grupos
            xGrupo.id = txtNombre.Text
            xGrupo.habilitado = cbHabilitar.Checked

            xGrupo.ValidarGrupo()

            xGrupo.GuardarRegistro()

            '@note Crear registros en perm_grupos
            For Each vNodoPadre As TreeNode In tvPermisos.Nodes
                xPermGrupos.permisosId = vNodoPadre.Text
                xPermGrupos.gruposId = xGrupo.id

                ' Inicializa a falso todos los permisos
                xPermGrupos.alta = False
                xPermGrupos.baja = False
                xPermGrupos.modificacion = False
                xPermGrupos.lectura = False

                For Each vNodoHijo As TreeNode In vNodoPadre.Nodes
                    If vNodoHijo.Checked Then
                        Select Case vNodoHijo.Text
                            Case "Alta"
                                xPermGrupos.alta = True
                            Case "Baja"
                                xPermGrupos.baja = True
                            Case "Modificacion"
                                xPermGrupos.modificacion = True
                            Case "Lectura"
                                xPermGrupos.lectura = True
                        End Select
                    End If
                Next

                xPermGrupos.GuardarDatos()
            Next

            MessageBox.Show("Agregado exitosamente", "Aviso")

            ' @note Limpiar el formulario
            mFuncsYProcs.sLimpiarCadaTextBox(Me)
            mFuncsYProcs.ReestablecerCadaLabel(Me)
            mFuncsYProcs.LimpiarTreeView(Me.tvPermisos)
            Me.cbHabilitar.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnListaGruposUsuarios_Click(sender As Object, e As EventArgs) Handles btnListaGruposUsuarios.Click
        Dim vGruposLista As New fGrupoLista
        vGruposLista.Show()
        Me.Close()
    End Sub
End Class