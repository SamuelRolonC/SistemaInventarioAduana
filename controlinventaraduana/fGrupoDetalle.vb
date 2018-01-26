Public Class fGrupoDetalle
    Public Property GrupoDetalleId As String ' Id del grupo que detalla en el formulario para ver o modificar

    Private Sub fModificarGrupoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '@note Deshabilitar edicion de datos
        mFuncsYProcs.HabilitarTByCB(Me, False)
        Me.cbHabilitar.Enabled = False
        Me.tvPermisos.Enabled = False
        Me.btnAplicar.Enabled = False

        '@note Aplicar restricciones de permisos
        Me.btnEditar.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "modificacion")
        Me.btnAplicar.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "modificacion")
        Me.btnBorrar.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "baja")
        Me.btnListaGruposUsuarios.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "lectura")

        '@note Cargar datos del grupo
        Dim xGrupo As New Negocio.cGrupo
        xGrupo.ObtenerGrupo(GrupoDetalleId)

        Me.txtNombre.Text = xGrupo.id
        Me.cbHabilitar.Checked = xGrupo.habilitado

        '@note Cargar nodos en TreeView
        Dim vNumFila As Integer
        For Each vFilaPermiso As System.Data.DataRow In Negocio.GestorEstandarDatos.CargarTabla("permisos").Rows
            Me.tvPermisos.Nodes.Add(vFilaPermiso("id"))
            Me.tvPermisos.Nodes(vNumFila).Nodes.Add("Alta")
            Me.tvPermisos.Nodes(vNumFila).Nodes.Add("Baja")
            Me.tvPermisos.Nodes(vNumFila).Nodes.Add("Modificación")
            Me.tvPermisos.Nodes(vNumFila).Nodes.Add("Lectura")
            Me.tvPermisos.Nodes(vNumFila).Expand()

            Me.tvPermisos.CheckBoxes = True

            '@note Tildar nodos
            Dim xPermGrupos As New Negocio.cPermGrupos
            For Each vPermGrupos As System.Data.DataRow In xPermGrupos.CargarTabla(GrupoDetalleId).Rows
                If vFilaPermiso("id") = vPermGrupos("permisos_id") Then
                    Me.tvPermisos.Nodes(vNumFila).Nodes(0).Checked = vPermGrupos("Alta")
                    Me.tvPermisos.Nodes(vNumFila).Nodes(1).Checked = vPermGrupos("Baja")
                    Me.tvPermisos.Nodes(vNumFila).Nodes(2).Checked = vPermGrupos("Modificacion")
                    Me.tvPermisos.Nodes(vNumFila).Nodes(3).Checked = vPermGrupos("Lectura")
                End If
            Next

            vNumFila += 1
        Next
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Result As Integer = MessageBox.Show("¿Está seguro de que quiere borrar este grupo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Try
                Negocio.cPermGrupos.BorrarRegistro(GrupoDetalleId)
                Negocio.cUsGrupos.BorrarRegistrosSegun("Grupo", GrupoDetalleId)
                Negocio.GestorEstandarDatos.BorrarRegistro("grupos", "String", GrupoDetalleId)

                MessageBox.Show("Borrado exitosamente", "Aviso")

                Dim vGruposLista As New fGrupoLista
                vGruposLista.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        mFuncsYProcs.HabilitarTByCB(Me, True)
        Me.txtNombre.Enabled = False
        Me.btnAplicar.Enabled = True
        Me.cbHabilitar.Enabled = True
        Me.tvPermisos.Enabled = True
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim Result As Integer = MessageBox.Show("¿Está seguro de que quiere modificar este grupo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Dim xGrupo As New Negocio.cGrupo
            xGrupo.ObtenerGrupo(GrupoDetalleId)

            Try
                '@note Actualizar registro en grupos
                xGrupo.id = txtNombre.Text
                xGrupo.habilitado = cbHabilitar.Checked

                xGrupo.ValidarGrupo()

                xGrupo.ModificarRegistro()

                Dim xPermGrupos As New Negocio.cPermGrupos
                For Each vNodoPadre As TreeNode In tvPermisos.Nodes
                    xPermGrupos.permisosId = vNodoPadre.Text
                    xPermGrupos.gruposId = GrupoDetalleId

                    ' Inicializa a falso todos los permisos
                    xPermGrupos.alta = False
                    xPermGrupos.baja = False
                    xPermGrupos.modificacion = False
                    xPermGrupos.lectura = False

                    For Each vNodoHijo As TreeNode In vNodoPadre.Nodes
                        If vNodoHijo.Checked Then
                            ' Determina a que permiso esta relacionado el nodo
                            Select Case vNodoHijo.Text
                                Case "Alta"
                                    xPermGrupos.alta = True
                                Case "Baja"
                                    xPermGrupos.baja = True
                                Case "Modificación"
                                    xPermGrupos.modificacion = True
                                Case "Lectura"
                                    xPermGrupos.lectura = True
                            End Select
                        End If
                    Next
                    xPermGrupos.ModificarRegistro()
                Next

                MessageBox.Show("Modificado exitosamente", "Aviso")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
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